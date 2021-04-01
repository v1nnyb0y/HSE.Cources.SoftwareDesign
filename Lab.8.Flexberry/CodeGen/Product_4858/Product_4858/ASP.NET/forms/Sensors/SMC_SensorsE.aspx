﻿<%--flexberryautogenerated="true"--%>
<%@ Page Language="C#" MasterPageFile="~/Site1.Master"  AutoEventWireup="true" CodeBehind="SMC_SensorsE.aspx.cs" Inherits="IIS.Product_4858.SMC_SensorsE" %>
<%@ Import namespace="NewPlatform.Flexberry.Web.Page" %>
<%-- Autogenerated section start [Register] --%>
<%-- Autogenerated section end [Register] --%>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="<%= Constants.FormCssClass + " " +  Constants.EditFormCssClass %>">
        <h2 class="<%= Constants.FormHeaderCssClass + " " + Constants.EditFormHeaderCssClass %>">Датчик</h2>
        <div class="<%= Constants.FormToolbarCssClass  + " " +  Constants.EditFormToolbarCssClass + " " + Constants.StickyCssClass %>">
            <asp:ImageButton ID="SaveBtn" runat="server" SkinID="SaveBtn" OnClick="SaveBtn_Click" AlternateText="<%$ Resources: Resource, Save %>" ValidationGroup="savedoc" />
            <asp:ImageButton ID="SaveAndCloseBtn" runat="server" SkinID="SaveAndCloseBtn" OnClick="SaveAndCloseBtn_Click" AlternateText="<%$ Resources: Resource, Save_Close %>" ValidationGroup="savedoc" />
            <asp:ImageButton ID="CancelBtn" runat="server" SkinID="CancelBtn" OnClick="CancelBtn_Click" AlternateText="<%$ Resources: Resource, Cancel %>" />
        </div>
        <div class="<%= Constants.FormControlsCssClass + " " + Constants.EditFormControlsCssClass %>">
            <%-- Autogenerated section start [Controls] --%>
<!-- autogenerated start -->
<div>
	<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlNameLabel" runat="server" Text="Наименование" EnableViewState="False">
</asp:Label>
<asp:TextBox CssClass="descTxt" ID="ctrlName" runat="server">
</asp:TextBox>


</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlTypeLabel" runat="server" Text="Тип" EnableViewState="False">
</asp:Label>
<asp:DropDownList ID="ctrlType" CssClass="descTxt" runat="server">
	<asp:ListItem>Temperature</asp:ListItem>
<asp:ListItem>Pressure</asp:ListItem>
<asp:ListItem>Gas</asp:ListItem>
<asp:ListItem>Camera</asp:ListItem>
<asp:ListItem>Manipulation</asp:ListItem>

</asp:DropDownList>

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlOutputDataLabel" runat="server" Text="Выходной параметр" EnableViewState="False">
</asp:Label>
<asp:TextBox CssClass="descTxt" ID="ctrlOutputData" runat="server">
</asp:TextBox>


</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlRoomLabel" runat="server" Text="Помещение" EnableViewState="False">
</asp:Label>
<ac:MasterEditorAjaxLookUp ID="ctrlRoom" CssClass="descTxt" runat="server" ShowInThickBox="True" Autocomplete="true" />

<asp:RequiredFieldValidator ID="ctrlRoomRequiredFieldValidator" runat="server" ControlToValidate="ctrlRoom"
                            ErrorMessage="Не указано: Помещение" Text="*" 
                            EnableClientScript="true" ValidationGroup="savedoc" />

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlRoom_NameLabel" runat="server" Text="Наименование" EnableViewState="False">
</asp:Label>
<asp:TextBox CssClass="descTxt" ID="ctrlRoom_Name" runat="server" ReadOnly="true">
</asp:TextBox>


</div>

</div>
<!-- autogenerated end -->
            <%-- Autogenerated section end [Controls] --%>
        </div>
    </div>
</asp:Content>