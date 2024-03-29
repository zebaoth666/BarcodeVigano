
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO

ALTER	View [dbo].[ViewSizeRange]		AS
select	TOP 100 PERCENT
		VSG.Division			as	Division
		, VSG.VSGItemCode		as	ItemCode
		, VSG.VSGItemName		as	ItemName
		, VSG.VSGBrand			as	Brand
		, Range.Style			as	Style
		, VSG.VSGColor			as	Color
		, VSG.VSGSize			as	Size
		, VSG.VSGItemStatus     as	ItemStatus
		, VSG.VSGSizeGroup		as	SizeGroup
 		, Range.SizeRange		as	SizeRange
FROM	(
		select	  A.Style					Style
				, min(A.Size)+'-'+
				  max(A.Size)				SizeRange
		from	(
				select	 AGM.AGM_GROUP_DESC				Style
						,ANM.ANM_DESC					Size
				from	ITEM_MST						ITM
						, DIVISION_MST					DIV
						, ATTRIBUTE_GROUP_MST			AGM
						, ATTRIBUTE_NESTING_MST			ANM
				where	ITM.ITM_DIV_CD				=	DIV_ID
						and AGM.AGM_ATTR6			=	ITM.ITM_ATTR06
						and AGM.AGM_DIV_CD			=	ITM.ITM_DIV_CD
						and ITM.ITM_DIV_CD			=	ANM.ANM_DIV_CD
						and ITM.ITM_ATTR08			=	ANM.ANM_ATTR_CD
						and ANM.ANM_ATTR			=	'ATTR8'
				) A
		group by	A.Style
		) Range
		, ViewSizeGroup			VSG
WHERE	Range.Style		=	VSG.VSGStyle
ORDER BY Division
		 , Brand
		 , Style
		 , Color
		 , ItemCode
		 , Size
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

