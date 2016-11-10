<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="RegistroVentas.aspx.cs" Inherits="Jeff_Aplicada2_P2.RegistroVentas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 130px;
        }
        .auto-style3 {
            text-align: center;
        }
        .auto-style4 {
            text-align: right;
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
            width: 268px;
            text-align: right;
        }
        .auto-style9 {
            width: 449px;
        }
        .auto-style10 {
            width: 217px;
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
        .auto-style13 {
            font-weight: bold;
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
            <td class="auto-style11"><strong>Factura de Ventas</strong></td>
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
            <td class="auto-style8"><strong>VentaId:</strong></td>
            <td class="auto-style7">
                <asp:TextBox ID="VentaIdTextBox" runat="server" Width="260px"></asp:TextBox>
            </td>
            <td>
                <strong>
                <asp:Button ID="BuscarButton" runat="server" Text="Buscar" Width="80px" CssClass="auto-style13" OnClick="BuscarButton_Click" />
                </strong>
            </td>
        </tr>
        <tr>
            <td class="auto-style8"><strong>Fecha:</strong></td>
            <td class="auto-style7">
                <asp:TextBox ID="FechaTextBox" runat="server" Width="260px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8"><strong>Monto:</strong></td>
            <td class="auto-style7">
                <asp:TextBox ID="MontoTextBox" runat="server" Width="260px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <table class="auto-style1">
        <tr>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style9"><strong>Articulo: </strong>
                <asp:DropDownList ID="DropDownList" runat="server" Height="20px" Width="145px">
                </asp:DropDownList>
                <strong>&nbsp;Cantidad: </strong>
                <asp:TextBox ID="CantidadTextBox" runat="server" Text="1" Width="25px"></asp:TextBox>
                <strong>&nbsp;Precio: </strong>
                <asp:TextBox ID="PrecioTextBox" runat="server" Width="55px"></asp:TextBox>
            </td>
            <td>
                <strong>
                <asp:Button ID="AgregarButton" runat="server" Text="Agregar" CssClass="auto-style13" OnClick="AgregarButton_Click" />
                </strong>
            </td>
        </tr>
        <tr>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style9">
                <asp:GridView ID="GridView" runat="server" AutoGenerateColumns="False" Width="384px" Height="106px">
                    <Columns>
                        <asp:BoundField HeaderText="Descripcion" />
                        <asp:BoundField HeaderText="Cantidad" />
                        <asp:BoundField HeaderText="Precio" />
                    </Columns>
                </asp:GridView>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <table class="auto-style1">
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">
                <strong>
                <asp:Button ID="NuevoButton" runat="server" Text="Nuevo" Width="80px" CssClass="auto-style13" OnClick="NuevoButton_Click" />
                </strong>
            </td>
            <td class="auto-style3">
                <strong>
                <asp:Button ID="GuardarButton" runat="server" Text="Guardar" Width="80px" CssClass="auto-style13" OnClick="GuardarButton_Click" />
                </strong>
            </td>
            <td>
                <strong><em>
                <asp:Button ID="EliminarButton" runat="server" Text="Eliminar" Width="80px" CssClass="auto-style13" OnClick="EliminarButton_Click" />
                </em></strong>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
