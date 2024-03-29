
/****** Object:  View [dbo].[ViewBarcode]    Script Date: 12/30/2008 15:23:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ================================================================
-- Author				:	Teofilus Sunarsa
-- Creation Date		:	23-Dec-2008
-- Released Date		:	23-Dec-2008
-- Description			:	View Barcode
-- Purpose 				:	Intended For Customized Printing Barcode by :
--							- Purchase Order
--							- Goods Receipt Note
--							- Item Master
-- Script  Version		:	1.0.0
-- RetailExcel Version	:	Ver. 6.0.2.5 Release # P10H1
-- Client				:	PT. MILANO MITRA ABADI
-- ================================================================
-- ================================================================
-- Update By			:	Bagus Pramana
-- Creation Date		:	30-Dec-2008
-- Released Date		:	30-Dec-2008
-- Description			:	View Barcode
-- Purpose 				:	Intended For Customized Printing Barcode by :
--							- Purchase Order
--							- Goods Receipt Note
--							- Item 
--							- Initial Stock
-- Script  Version		:	1.0.0
-- RetailExcel Version	:	Ver. 6.0.2.5 Release # P10H1
-- Client				:	PT. MILANO MITRA ABADI
-- ================================================================
CREATE	View [dbo].[ViewBarcode]		AS
select	A.Division as Division,
		A.Organization as Organization, 
		A.ItemCode as ItemCode, 
		A.ItemName as ItemName,
		A.Brand as Brand,
		A.Style as Style,
		A.Color as Color,
		A.Size as Size,
		A.SizeRange as SizeRange,
		A.DocumentNo as DocumentNo,
		A.YY+A.Comb+A.MM as ProdCode,
		'PO' as StatusDoc,
		A.ItemStatus as ItemStatus,
		A.Quantity as Quantity,
		A.SizeGroup as SizeGroup
from ( 
select	    VSR.*,POD_QTY as Quantity,POD_PO_NO as DocumentNo,POD_ORG_CD as Organization,right(datepart(YY,POD_PO_DT),2) as YY,
			right ((datepart(YY,POD_PO_DT) + datepart(MM,POD_PO_DT) + datepart(DD,POD_PO_DT)),2) as Comb,
			case when  datepart(MM,POD_PO_DT) < 10 
			then '0' + cast(datepart(MM,POD_PO_DT) as varchar(2)) 
			else cast (datepart(MM,POD_PO_DT) as varchar(2)) end as MM
from		viewsizerange  VSR
inner join	purchase_order_dtl POD on pod_itm_cd = itemcode
) as A
union all
select	A.Division as Division, 
		A.Organization as Organization,
		A.ItemCode as ItemCode, 
		A.ItemName as ItemName,
		A.Brand as Brand,
		A.Style as Style,
		A.Color as Color,
		A.Size as Size,
		A.SizeRange as SizeRange,
		A.DocumentNo as DocumentNo,
		A.YY+A.Comb+A.MM as ProdCode,		
		'GRN' as StatusDoc,
		A.ItemStatus as ItemStatus,
		A.Quantity as Quantity,
		A.SizeGroup as SizeGroup
from(
select	    VSR.*,gid_po_qty as Quantity,gid_doc_no as DocumentNo,gid_org_cd as organization,right(datepart(YY,gid_psh_dt),2) as YY,
			right ((datepart(YY,gid_psh_dt) + datepart(MM,gid_psh_dt) + datepart(DD,gid_psh_dt)),2) as Comb,
			case when  datepart(MM,gid_psh_dt) < 10 
			then '0' + cast(datepart(MM,gid_psh_dt) as varchar(2)) 
			else cast (datepart(MM,gid_psh_dt) as varchar(2)) end as MM
from		viewsizerange  VSR
inner join	goods_receipt_dtl GID on gid_itm_cd = itemcode
) as A
union all
select	A.Division as Division,
		'001' as Organization, 
		A.ItemCode as ItemCode, 
		A.ItemName as ItemName,
		A.Brand as Brand,
		A.Style as Style,
		A.Color as Color,
		A.Size as Size,
		A.SizeRange as SizeRange,
		A.DocumentNo as DocumentNo,
		A.YY+A.Comb+A.MM as ProdCode,	
		'ITM' as StatusDoc,
		ItemStatus,
		'1' as Quantity,
		A.SizeGroup as SizeGroup
from(
select	    VSR.*,'NULL' as DocumentNo,right(datepart(YY,getdate()),2) as YY,
			right ((datepart(YY,getdate()) + datepart(MM,getdate()) + datepart(DD,getdate())),2) as Comb,
			case when  datepart(MM,getdate()) < 10 
			then '0' + cast(datepart(MM,getdate()) as varchar(2)) 
			else cast (datepart(MM,getdate()) as varchar(2)) end as MM
from		viewsizerange  VSR
) as A
union all
select	A.Division as Division,
		A.Organization as Organization, 
		A.ItemCode as ItemCode, 
		A.ItemName as ItemName,
		A.Brand as Brand,
		A.Style as Style,
		A.Color as Color,
		A.Size as Size,
		A.SizeRange as SizeRange,
		A.DocumentNo as DocumentNo,
		A.YY+A.Comb+A.MM as ProdCode,		
		'ISD' as StatusDoc,
		A.ItemStatus as ItemStatus,
		A.Quantity as Quantity,
		A.SizeGroup as SizeGroup
from(
select	    VSR.*,isd_qty as Quantity,isd_doc_no as DocumentNo,isd_org_cd as organization,right(datepart(YY,getdate()),2) as YY,
			right ((datepart(YY,getdate()) + datepart(MM,getdate()) + datepart(DD,getdate())),2) as Comb,
			case when  datepart(MM,getdate()) < 10 
			then '0' + cast(datepart(MM,getdate()) as varchar(2)) 
			else cast (datepart(MM,getdate()) as varchar(2)) end as MM
from		viewsizerange  VSR
inner join	init_stock_dtl isd on isd_itm_cd = itemcode
) as A