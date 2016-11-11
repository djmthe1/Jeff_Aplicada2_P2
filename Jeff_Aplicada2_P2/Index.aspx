<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Jeff_Aplicada2_P2.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 282px;
        }
        .auto-style2 {
            width: 279px;
        }
        .auto-style3 {
            width: 279px;
            text-align: center;
        }
        .auto-style4 {
            width: 282px;
            text-align: center;
        }
        .auto-style7 {
            width: 280px;
            text-align: center;
        }
        .auto-style8 {
            width: 281px;
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4"><strong></strong></td>
            <td class="auto-style3"><strong>Segundo Parcial</strong></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4"><strong></strong></td>
            <td class="auto-style3"><strong>Programacion Aplicada II</strong></td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <table style="width:100%;">
        <tr>
            <td class="auto-style8"><strong>Registros</strong></td>
            <td class="auto-style7"><strong></strong></td>
            <td class="text-center"><strong>Consultas</strong></td>
        </tr>
        <tr>
            <td class="auto-style8">
                <asp:Button ID="RegistroVentasButton" runat="server" Class="btn-primary" Text="Ventas" Width="103px" OnClick="RegistroVentasButton_Click" />
            </td>
            <td class="auto-style7">&nbsp;</td>
            <td class="text-center">
                <asp:Button ID="ConsultaVentasButton" runat="server" Class="btn-primary" Text="Ventas" Width="102px" OnClick="ConsultaVentasButton_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style8">
                <asp:Button ID="RegistroArticulosButton" runat="server" Class="btn-primary" Text="Articulos" Width="102px" OnClick="RegistroArticulosButton_Click" />
            </td>
            <td class="auto-style7">&nbsp;</td>
            <td class="text-center">
                <asp:Button ID="ConsultaArticulosButton" runat="server" Class="btn-primary" Text="Articulos" Width="102px" OnClick="ConsultaArticulosButton_Click" />
            </td>
        </tr>
    </table>
    <table style="width:100%;">
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
