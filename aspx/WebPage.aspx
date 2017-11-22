<%@ Page Language="C#" masterpagefile="~masterurl/default.master" title="Untitled 1" inherits="Microsoft.SharePoint.WebPartPages.WebPartPage, Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" meta:progid="SharePoint.WebPartPage.Document" %>
<%@ Register tagprefix="WebPartPages" namespace="Microsoft.SharePoint.WebPartPages" assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register tagprefix="SharePoint" namespace="Microsoft.SharePoint.WebControls" assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<asp:Content id="Content1" runat="Server" contentplaceholderid="PlaceHolderMain">
<asp:ScriptManagerProxy runat="server" id="ScriptManagerProxy">	</asp:ScriptManagerProxy>

<link rel="stylesheet" href="https://xyz.sharepoint.com/sites/modules/SitePages/admin/JSCode.css" />
<link rel="stylesheet" href="https://xyz.sharepoint.com/sites/modules/SitePages/admin/CSSCode.css" />
<head>
<meta name="WebPartPageExpansion" content="full" />
</head>

<div id="ReportTable">
</div>

<style>
table, th, td {
    border: 1px solid black;
    border-collapse: collapse;
}
</style>


<script type="text/javascript" src="/sites/modules/SitePages/admin/JSCode.js"></script>
<script type="text/javascript" src="/sites/modules/SitePages/admin/SPORestLayer.js"></script>
</asp:Content>
