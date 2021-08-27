<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E533)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MyGridView.cs](./CS/Q131966/MyGridView.cs) (VB: [MyGridView.vb](./VB/Q131966/MyGridView.vb))
<!-- default file list end -->
# How to change the name of columns generated by GridView in your GridView descendant


<p>All that you need to accomplish this task is to override the ColumnView's GenerateColumnName method. Please note that when you override this method, all columns generated in the form should have unique names.</p>

<br/>


