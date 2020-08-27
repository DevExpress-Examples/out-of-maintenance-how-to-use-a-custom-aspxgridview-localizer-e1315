<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CustomLocalizer._Default" %>

<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dxe" %>

<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dxwgv" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>How to use a custom ASPxGridView localizer</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <dxwgv:ASPxGridView ID="ASPxGridView1" runat="server" AutoGenerateColumns="False" KeyFieldName="ID" OnRowDeleting="ASPxGridView1_RowDeleting" OnRowInserting="ASPxGridView1_RowInserting" OnRowUpdating="ASPxGridView1_RowUpdating" Width="420px">
            <Columns>
                <dxwgv:GridViewCommandColumn ShowEditButton="true" ShowClearFilterButton="true" ShowNewButtonInHeader="true" ShowDeleteButton="true" VisibleIndex="0">
                   
                </dxwgv:GridViewCommandColumn>
                <dxwgv:GridViewDataTextColumn FieldName="ID" VisibleIndex="1" Width="150px">
                </dxwgv:GridViewDataTextColumn>
            </Columns>
            <Settings ShowFilterBar="Visible" ShowFilterRow="True" ShowGroupPanel="True" />
        </dxwgv:ASPxGridView>
    </div>
    </form>
</body>
</html>
