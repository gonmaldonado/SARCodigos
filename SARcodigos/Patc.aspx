<%@ Page Title="Patc" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Patc.aspx.cs" Inherits="SARcodigos.Patc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <br />
    <link href="CSS/Estilo.css" rel="stylesheet" />
    <form action="" >
    <div class="row">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
      <ContentTemplate>
       <h1><span class="label label-default">Patc</span></h1> 
      <div class="col-md-6">
          <asp:DropDownList ID="ddlColumna" runat="server" Height="26px" Width="186px">
              <asp:ListItem>CODIGO</asp:ListItem>
              <asp:ListItem>MATERIAL</asp:ListItem>
              <asp:ListItem>DESCRIPCION</asp:ListItem>
          </asp:DropDownList>
          <asp:TextBox ID="txtFiltro" runat="server" Height="26px" Width="186px"></asp:TextBox>
          <asp:Button ID="btnBuscar" runat="server" Text="Buscar" class="btn btn-default btn-sm" OnClick="btnBuscar_Click"   />
          <asp:Button ID="btnBorrar2" runat="server" Text="Borrar" class="btn btn-default btn-sm" OnClick="btnBorrar2_Click" />
      </div>
    <div class="col-md-5">
    </div>
    </ContentTemplate>
 </asp:UpdatePanel> 
     <div class="col-md-1">
        <asp:Button ID="btnExcel" class="btn btn-success btn-sm" runat="server" Text="Excel" OnClick="btnExcel_Click"   />
    </div>
    </div>
    <div class="row">
    <asp:UpdatePanel ID="UpdatePanel3" runat="server">
      <ContentTemplate>
      <div class="col-md-12" style="left: 0px; top: 0px; height: 449px">
         <div class="scrolling-table-container" style="height: 458px">
             <asp:GridView ID="gvSeat" runat="server" EmptyDataText="Sin datos para mostrar" CssClass="table table-striped table-hover table-condensed small-top-margin"></asp:GridView>
          </div>
        </div>
        </ContentTemplate>
     </asp:UpdatePanel> 
    </div>
    <hr />  
</form>
</asp:Content>
