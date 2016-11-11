<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="RegistroArticulos.aspx.cs" Inherits="Jeff_Aplicada2_P2.RegistroArticulos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 130px;
        }
        .auto-style3 {
            text-align: center;
            width: 265px;
        }
        .auto-style4 {
            text-align: right;
            width: 444px;
        }
        .auto-style5 {
            width: 268px;
        }
        .auto-style6 {
            width: 270px;
        }
        .auto-style7 {
            width: 269px;
        }
        .auto-style8 {
            width: 443px;
            text-align: right;
        }
        .auto-style11 {
            width: 270px;
            text-align: center;
            font-size: large;
            text-decoration: underline;
            color: #333300;
        }
        .auto-style12 {
            width: 268px;
            text-align: center;
            font-size: large;
            text-decoration: underline;
            color: #333300;
        }
        .auto-style14 {
            width: 265px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style11"><strong>Registro de Articulos</strong></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    <table class="auto-style1">
        <tr>
            <td class="auto-style8"><strong>ArticuloId:</strong></td>
            <td class="auto-style7">
                <asp:TextBox ID="ArticuloIdTextBox" runat="server" Width="260px"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="BuscarButton" runat="server" Class="btn-primary" Text="Buscar" Width="80px" OnClick="BuscarButton_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style8"><strong>Descripcion:</strong></td>
            <td class="auto-style7">
                <asp:TextBox ID="DescripcionTextBox" runat="server" Width="260px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8"><strong>Existencia:</strong></td>
            <td class="auto-style7">
                <asp:TextBox ID="ExistenciaTextBox" runat="server" Width="260px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <table class="auto-style1">
        <tr>
            <td class="auto-style4"><strong>Precio:</strong></td>
            <td class="auto-style14">
                <asp:TextBox ID="PrecioTextBox" runat="server" Width="260px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">
                &nbsp;</td>
            <td class="auto-style3">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Button ID="NuevoButton" runat="server" Class="btn-primary" Text="Nuevo" Width="80px" OnClick="NuevoButton_Click" />
            </td>
            <td class="auto-style3">
                <asp:Button ID="GuardarButton" runat="server" Class="btn-primary" Text="Guardar" Width="80px" OnClick="GuardarButton_Click" />
            </td>
            <td>
                <em>
                <asp:Button ID="EliminarButton" runat="server" Class="btn-primary" Text="Eliminar" Width="80px" OnClick="EliminarButton_Click" />
                </em>
            </td>
        </tr>
    </table>
</asp:Content>
