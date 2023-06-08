<%@ Page Title="Door Trim" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Doortrim.aspx.cs" Inherits="SARcodigos.Doortrim" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <link href="CSS/Estilo.css" rel="stylesheet" />
    <form action="" >
    <div class="row">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
      <ContentTemplate>
       <h1><span class="label label-default">Door Trim</span></h1> 
      <div class="col-md-6">
          <asp:DropDownList ID="ddlColumna" runat="server" Height="26px" Width="186px">
              <asp:ListItem>CODIGO</asp:ListItem>
              <asp:ListItem>MODELO</asp:ListItem>
              <asp:ListItem>DESCRIPCION</asp:ListItem>
          </asp:DropDownList>
          <asp:TextBox ID="txtFiltro" runat="server" Height="26px" Width="186px"></asp:TextBox>
          <asp:Button ID="btnBuscar" runat="server" Text="Buscar" class="btn btn-default btn-sm" OnClick="btnBuscar_Click"  />
          <asp:Button ID="btnBorrar2" runat="server" Text="Borrar" class="btn btn-default btn-sm" OnClick="btnBorrar2_Click" />
      </div>
    <div class="col-md-5">
    </div>
  </ContentTemplate>
</asp:UpdatePanel> 
     <div class="col-md-1">
          <asp:Button ID="btnExcel" class="btn btn-success btn-sm" runat="server" Text="Excel" OnClick="btnExcel_Click" />
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
    </div>
  </ContentTemplate>
</asp:UpdatePanel> 
    <hr />  
  <asp:UpdatePanel ID="UpdatePanel2" runat="server">
   <ContentTemplate>
     <div class="row">
     <h3><span class="label label-default">Filtrar</span></h3> 
        <div class="col-md-7">
            <table >
                <tr>
                    <td>
            <asp:Label ID="Label4" runat="server" Text="Tipo:"></asp:Label>
            <div style="width: 100px; height: 165px">
                <asp:CheckBoxList ID="cbTipo" runat="server"></asp:CheckBoxList>
            </div>
                    </td>
                    <td>&nbsp;&nbsp;&nbsp;</td>
                    <td>
            <asp:Label ID="Label2" runat="server" Text="Fila:"></asp:Label>
            <div style="width: 100px; height: 165px">
                <asp:CheckBoxList ID="cbFila" runat="server"></asp:CheckBoxList>
            </div>
                    </td>
                    <td>
            <asp:Label ID="Label5" runat="server" Text="Modelo:"></asp:Label>
            <div class="scrolling-table-container" style="width: 120px; height: 165px">
                <asp:CheckBoxList ID="cbModelo" runat="server"></asp:CheckBoxList>
            </div>
                    </td>
                    <td>&nbsp;&nbsp;&nbsp;</td>
                    <td>
            <asp:Label ID="Label6" runat="server" Text="Codigo:"></asp:Label>
            <div class="scrolling-table-container" style="width: 160px; height: 165px">
                <asp:CheckBoxList ID="cbCodigo" runat="server"></asp:CheckBoxList>
            </div>
                    </td>
                    <td>&nbsp;&nbsp;&nbsp;</td>
                    <td>
            <asp:Label ID="Label7" runat="server" Text="Descripcion:"></asp:Label>
            <div style="width: 170px; height: 165px">
                <asp:CheckBoxList ID="cbDescripcion" runat="server"></asp:CheckBoxList>
            </div>
                    </td>
            </table>
         </div>
        <div class="col-md-4">
            <table>

                    <td>
            <asp:Label ID="Label8" runat="server" Text="Lado:"></asp:Label>
            <div style="width: 100px; height: 165px">
                <asp:CheckBoxList ID="cbLado" runat="server"></asp:CheckBoxList>
              </div>
           </td>
            <td>
            <asp:Label ID="Label9" runat="server" Text="Material:"></asp:Label>
            <div style="width: 100px; height: 165px">
                <asp:CheckBoxList ID="cbMaterial" runat="server"></asp:CheckBoxList>
            </div>
            </td>
            <td>
            <asp:Label ID="Label10" runat="server" Text="Color:"></asp:Label>
            <div style="width: 100px; height: 165px">
                <asp:CheckBoxList ID="cbColor" runat="server"></asp:CheckBoxList>
            </div>
            </td>
          </tr>
       </table>
     </div>
 </div>
    <div class="row">
         <div class="col-md-10">
         </div>
        <div class="col-md-2">
             <asp:Button ID="Button2" runat="server" Text="Borrar" class="btn btn-default" OnClick="Button2_Click" />
             <asp:Button ID="Button1" runat="server" Text="Filtrar" class="btn btn-default" OnClick="Button1_Click"/>
     </div>
 </div>
    </ContentTemplate>
 </asp:UpdatePanel> 
</form>
</asp:Content>
