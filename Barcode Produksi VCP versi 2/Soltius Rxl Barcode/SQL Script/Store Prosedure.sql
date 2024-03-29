

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ================================================================
-- Author				:	Bagus
-- Creation Date		:	23-Dec-2008
-- Released Date		:	23 Dec-2008
-- Description			:	Store Procedure
-- Purpose 				:	For Barcode Printing;
-- Script  Version		:	1.0.0
-- RetailExcel Version	:	Ver. 6.0.2.5 Release # P10H1
-- Client				:	PT. MILANO MITRA ABADI
-- Company				:	PT. SOLTIUS INDONESIA
-- Division				:	M.R.O.
--=================================================================

CREATE PROCEDURE [dbo].[SOL_SHOES_BARCODE_PRINTING]
@DIVISION VARCHAR(500), 
@DOC_NO VARCHAR(500),
@TABLE varchar(500)
AS 
BEGIN

if @DIVISION = 'O'
begin
SELECT *,itemcode as Barcode,
case when sizeGroup like '%SHOES' then '1' else '0' end as ItemType 
FROM [ViewBarcode] 
WHERE StatusDoc = @TABLE
and DocumentNo = @DOC_NO
and ItemStatus = 'O'
end

else
begin
SELECT *,itemcode as Barcode,
case when sizeGroup like '%SHOES' then '1' else '0' end as ItemType 
FROM [ViewBarcode] 
WHERE StatusDoc = @TABLE
and division = @DIVISION 
and ItemStatus = 'O'
end


END




SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ================================================================
-- Author				:	Bagus
-- Creation Date		:	30-Dec-2008
-- Released Date		:	30 Dec-2008
-- Description			:	Store Procedure
-- Purpose 				:	For Barcode Printing;
-- Script  Version		:	1.0.0
-- RetailExcel Version	:	Ver. 6.0.2.5 Release # P10H1
-- Client				:	PT. MILANO MITRA ABADI
-- Company				:	PT. SOLTIUS INDONESIA
-- Division				:	M.R.O.
--=================================================================

CREATE PROCEDURE [dbo].[SOL_SHOES_BARCODE_DOCUMENT_KEY]
@COLUMN VARCHAR(500), 
@STATUS VARCHAR(500),
@ORG varchar(500)
AS 
BEGIN
if @COLUMN = 'DOCUMENTNO'
BEGIN
SELECT DISTINCT DOCUMENTNO as DocumentKey FROM VIEWBARCODE 
WHERE STATUSDOC = @STATUS ANd ORGANIZATION = @ORG
ORDER BY DOCUMENTNO ASC
END
ELSE
BEGIN
SELECT DISTINCT DIVISION as DocumentKey FROM VIEWBARCODE 
WHERE STATUSDOC = @STATUS
ORDER BY DIVISION ASC
END

END
