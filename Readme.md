<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128543374/15.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1315)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* **[Default.aspx](./CS/CustomLocalizer/Default.aspx) (VB: [Default.aspx](./VB/CustomLocalizer/Default.aspx))**
* [Default.aspx.cs](./CS/CustomLocalizer/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/CustomLocalizer/Default.aspx.vb))
* [MyEditorsLocalizer.cs](./CS/CustomLocalizer/MyEditorsLocalizer.cs) (VB: [MyEditorsLocalizer.vb](./VB/CustomLocalizer/MyEditorsLocalizer.vb))
* [MyGridLocalizer.cs](./CS/CustomLocalizer/MyGridLocalizer.cs) (VB: [MyGridLocalizer.vb](./VB/CustomLocalizer/MyGridLocalizer.vb))
* [MyWebLocalizer.cs](./CS/CustomLocalizer/MyWebLocalizer.cs) (VB: [MyWebLocalizer.vb](./VB/CustomLocalizer/MyWebLocalizer.vb))
<!-- default file list end -->
# How to use a custom ASPxGridView localizer
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e1315/)**
<!-- run online end -->


<p>The ASPxGridView can be localized via satellite resource assemblies. This is the recommended approach to localization and it's described in the <a href="https://docs.devexpress.com/AspNet/12050/localization/localizing-aspnet-controls-via-satellite-resource-assemblies">Localizing ASP.NET Controls via Satellite Resource Assemblies</a> help topic.</p><p>However, if you prefer to supply translations programmatically, you can define a custom Localizer class by inheriting it from ASPxGridViewLocalizer. This example demonstrates this approach in action.</p>

