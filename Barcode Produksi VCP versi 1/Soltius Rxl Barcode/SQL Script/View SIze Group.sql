
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ================================================================
-- Author				:	Arfi
-- Creation Date		:	09-June-2008
-- Released Date		:	10 June-2008
-- Description			:	View Size Group
-- Purpose 				:	Intended For Customized Printing Report
--							- Delivery Note
--							- Transfer Out
--							- Transfer In
--							- Purchase Order
-- Script  Version		:	1.0.0
-- RetailExcel Version	:	Ver. 6.0.2.5 Release # P10H1
-- Client				:	PT. MILANO MITRA ABADI
-- Company				:	PT. SOLTIUS INDONESIA
-- Division				:	M.R.O.
-- ================================================================
ALTER	View [dbo].[ViewSizeGroup]		AS
select	TOP 100 PERCENT
		  Division
		, ItemCode						AS VSGItemCode
		, ItemName						AS VSGItemName
		, Gender+' '+Department			AS VSGSizeGroup
		, Brand							AS VSGBrand
		, Style							AS VSGStyle
		, Color							AS VSGColor
		, Size							AS VSGSize
		, SizeCode						AS VSGSizeCode
		, ItemStatus					AS VSGItemStatus
		, GenderStatus					AS VSGGenderStatus
		, DepartmentStatus				AS VSGDepartmentStatus
		, BrandStatus					AS VSGBrandStatus
		, StyleStatus					AS VSGStyleStatus
		, ColorStatus					AS ColorStatus
		, SizeStatus					AS SizeStatus
from	(
		select		ITM.ITM_DIV_CD					DivCode
					,DIV.DIV_DESC					Division
					,ITM.ITM_CD						ItemCode
					,ITM.ITM_NAME					ItemName
					,ITM_STATUS						ItemStatus
					,ANM1.ANM_DESC					Department
					,ANM1.ANM_STATUS				DepartmentStatus
					,ANM2.ANM_DESC					Brand
					,ANM2.ANM_STATUS				BrandStatus
					,ANM4.ANM_DESC					Gender
					,ANM4.ANM_STATUS				GenderStatus
					,AGM.AGM_GROUP_DESC				Style
					,AGM.AGM_STATUS					StyleStatus
					,ANM7.ANM_DESC					Color
					,ANM7.ANM_STATUS				ColorStatus
					,ANM8.ANM_DESC					Size
					,ANM8.ANM_STATUS				SizeStatus
					,ANM8.ANM_ATTR_CD				SizeCode
		from		ITEM_MST						ITM
					, DIVISION_MST					DIV
					, ATTRIBUTE_NESTING_MST			ANM1
					, ATTRIBUTE_NESTING_MST			ANM2
					, ATTRIBUTE_NESTING_MST			ANM4
-- 					, ATTRIBUTE_NESTING_MST			ANM6
					, ATTRIBUTE_GROUP_MST			AGM
					, ATTRIBUTE_NESTING_MST			ANM7
					, ATTRIBUTE_NESTING_MST			ANM8
		where		ITM.ITM_DIV_CD				=	DIV_ID
					and ITM.ITM_DIV_CD			=	ANM1.ANM_DIV_CD
					and ITM.ITM_ATTR01			=	ANM1.ANM_ATTR_CD
					and ANM1.ANM_ATTR			=	'ATTR1'			
					and ITM.ITM_DIV_CD			=	ANM2.ANM_DIV_CD
					and ITM.ITM_ATTR02			=	ANM2.ANM_ATTR_CD
					and ANM2.ANM_ATTR			=	'ATTR2'
					and ITM.ITM_DIV_CD			=	ANM4.ANM_DIV_CD
					and ITM.ITM_ATTR04			=	ANM4.ANM_ATTR_CD
					and ANM4.ANM_ATTR			=	'ATTR4'
--					and ITM.ITM_DIV_CD			=	ANM6.ANM_DIV_CD
--					and ITM.ITM_ATTR06			=	ANM6.ANM_ATTR_CD
--					and ANM6.ANM_ATTR			=	'ATTR6'
					and AGM.AGM_ATTR6			=	ITM.ITM_ATTR06
					and AGM.AGM_DIV_CD			=	ITM.ITM_DIV_CD
					and ITM.ITM_DIV_CD			=	ANM7.ANM_DIV_CD
					and ITM.ITM_ATTR07			=	ANM7.ANM_ATTR_CD
					and ANM7.ANM_ATTR			=	'ATTR7'
					and ITM.ITM_DIV_CD			=	ANM8.ANM_DIV_CD
					and ITM.ITM_ATTR08			=	ANM8.ANM_ATTR_CD
					and ANM8.ANM_ATTR			=	'ATTR8'
			) 
			VSG
order by	VSGSizeGroup
			, VSGColor
			, VSGSizeCode
			, VSGSize
GO

SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO

