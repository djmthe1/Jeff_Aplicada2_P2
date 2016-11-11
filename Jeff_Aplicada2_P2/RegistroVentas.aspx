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
        width: 342px;
        text-align: right;
    }
        .auto-style9 {
        width: 466px;
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
        width: 278px;
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
                <asp:Button ID="BuscarButton" runat="server" Class="btn-primary" Text="Buscar" Width="80px" OnClick="BuscarButton_Click" />
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
            <td class="auto-style13">&nbsp;</td>
            <td class="auto-style9"><strong>Articulo: </strong>
                <asp:DropDownList ID="DropDownList" runat="server" Height="20px" Width="145px">
                </asp:DropDownList>
                <strong>&nbsp;Cantidad: </strong>
                <asp:TextBox ID="CantidadTextBox" runat="server" Text="1" Width="25px"></asp:TextBox>
                <strong>&nbsp;Precio: </strong>
                <asp:TextBox ID="PrecioTextBox" runat="server" Width="55px"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="AgregarButton" runat="server" Class="btn-primary" Text="Agregar" OnClick="AgregarButton_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style13">&nbsp;</td>
            <td class="auto-style9">
                <asp:GridView ID="GridView" runat="server" AutoGenerateColumns="False" Width="384px" Height="106px">
                    <Columns>
                            <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" />
                            <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" />
                            <asp:BoundField DataField="Precio" HeaderText="Precio" />
                    </Columns>
                </asp:GridView>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style13">&nbsp;</td>
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
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
