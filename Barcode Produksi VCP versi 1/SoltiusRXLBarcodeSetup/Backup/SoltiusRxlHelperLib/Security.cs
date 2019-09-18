using System;
using System.Diagnostics;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Security;
using System.Security.Cryptography;
using System.Security.Permissions;

namespace Soltius.Security {

    [DebuggerNonUserCode]
    [Serializable]
    public static class StringCrypter {

        [EditorBrowsable(EditorBrowsableState.Never)]
        [PasswordPropertyText]
        public static string Encrypt(string text) {
            if (string.IsNullOrEmpty(text)) {
                return string.Empty;
            }
            string result = string.Empty;
            text = string.Format("567@vcxz_{0}=C#I$Th3L4nG", text);
            byte[] encodedBytes = Encoding.ASCII.GetBytes(text);
            int length = encodedBytes.Length;
            using (RijndaelManaged provider = new RijndaelManaged()) {
                using (RijndaelManagedTransform transform = provider.CreateEncryptor() as RijndaelManagedTransform) {
                    using (MemoryStream memoryStream = new MemoryStream(length)) {
                        using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write)) {
                            cryptoStream.Write(encodedBytes, 0, length);
                            cryptoStream.FlushFinalBlock();
                            List<byte> encryptedBytes = new List<byte>();
                            encryptedBytes.AddRange(memoryStream.ToArray());
                            encryptedBytes.InsertRange(2, (byte[])provider.Key.Clone());
                            encryptedBytes.InsertRange(3, (byte[])provider.IV.Clone());
                            result = Convert.ToBase64String(encryptedBytes.ToArray());
                            encryptedBytes.Clear();
                        };
                    };
                };
            }
            return result;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [PasswordPropertyText]
        public static string Decrypt(string text) {
            if (string.IsNullOrEmpty(text)) {
                return string.Empty;
            }
            string result = string.Empty;
            List<byte> encryptedBytes = new List<byte>(Convert.FromBase64String(text));
            byte[] iv = encryptedBytes.GetRange(3, 16).ToArray();
            encryptedBytes.RemoveRange(3, 16);
            byte[] key = encryptedBytes.GetRange(2, 32).ToArray();
            encryptedBytes.RemoveRange(2, 32);
            int length = encryptedBytes.Count;
            byte[] decryptedBytes = new byte[length];
            using (RijndaelManaged provider = new RijndaelManaged()) {
                using (MemoryStream memoryStream = new MemoryStream(encryptedBytes.ToArray())) {
                    encryptedBytes.Clear();
                    using (RijndaelManagedTransform transform = provider.CreateDecryptor((byte[])key.Clone(), (byte[])iv.Clone()) as RijndaelManagedTransform) {
                        using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read)) {
                            cryptoStream.Read(decryptedBytes, 0, length);
                            result = Encoding.ASCII.GetString(decryptedBytes).Trim(new char[] { '\0' });
                            result = result.Replace("567@vcxz_", string.Empty);
                            result = result.Replace("=C#I$Th3L4nG", string.Empty);
                        }
                    }
                }
            }
            return result;
        }

    }

}