<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="ConsultaVentas.aspx.cs" Inherits="Jeff_Aplicada2_P2.Consultas.ConsultaVentas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 135px;
        }
        .auto-style2 {
            width: 354px;
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
            width: 354px;
            text-align: center;
        }
        .auto-style7 {
            width: 354px;
            text-align: right;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style6"><strong></strong></td>
            <td class="auto-style5"><strong>Consulta Ventas</strong></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">Buscar Por:<asp:DropDownList ID="BuscarPorDropDownList" runat="server" Class="form-control input-sm" CssClass="col-xs-offset-0" Height="35px" style="margin-left: 0px" Width="189px">
                <asp:ListItem>VentaId</asp:ListItem>
                <asp:ListItem>Fecha</asp:ListItem>
                <asp:ListItem>Monto</asp:ListItem>
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
