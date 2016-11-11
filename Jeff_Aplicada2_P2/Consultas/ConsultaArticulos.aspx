<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="ConsultaArticulos.aspx.cs" Inherits="Jeff_Aplicada2_P2.Consultas.ConsultaArticulos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 135px;
        }
        .auto-style3 {
            width: 269px;
        }
        .auto-style4 {
            width: 436px;
        }
        .auto-style5 {
            width: 269px;
            text-align: center;
        }
        .auto-style6 {
            width: 352px;
            text-align: center;
        }
        .auto-style7 {
            width: 352px;
        }
        .auto-style8 {
            width: 352px;
            text-align: right;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style5"><strong>Consulta Articulos</strong></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8">Buscar Por:<asp:DropDownList ID="BuscarPorDropDownList" runat="server" Class="form-control input-sm" CssClass="col-xs-offset-0" Height="35px" style="margin-left: 0px" Width="189px">
                <asp:ListItem>ArticuloId</asp:ListItem>
                <asp:ListItem>Descripcion</asp:ListItem>
                <asp:ListItem>Existencia</asp:ListItem>
                <asp:ListItem>Precio</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="FiltroTextBox" runat="server" CssClass="form-control" placeholder="Filtro" Width="262px"></asp:TextBox>
            </td>
            <td><strong>
                <asp:Button ID="BuscarButton" runat="server" Class="btn-primary" OnClick="BuscarButton_Click" Text="Buscar" Width="100px" />
                </strong></td>
        </tr>
    </table>
    <table class="auto-style1">
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style4">
                <asp:GridView ID="ConsultaGridView" runat="server" Width="438px">
                </asp:GridView>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
