<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="Parcial_N2.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Registro.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="formContainer">

    E-mail:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox1" Display="None" ErrorMessage="Ingrese un Email Válido." ValidationExpression="^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"></asp:RegularExpressionValidator>
<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" Display="None" ErrorMessage="Ingrese su Email."></asp:RequiredFieldValidator>
<br /><br />
    Username:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox2" Display="None" ErrorMessage="Ingrese un Usuario."></asp:RequiredFieldValidator>
<br /><br />
    Edad:<asp:TextBox ID="TextBox3" runat="server" EnableTheming="False"></asp:TextBox>
<asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox3" Display="None" ErrorMessage="Debe ser mayor a 15 años." MaximumValue="99" MinimumValue="15"></asp:RangeValidator>
<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox3" Display="None" ErrorMessage="Ingrese su edad."></asp:RequiredFieldValidator>
<br /><br />
    Password:<asp:TextBox ID="TextBox4" runat="server" TextMode="Password"></asp:TextBox>
<asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox5" ControlToValidate="TextBox4" ErrorMessage="Los password no coinciden." Display="None"></asp:CompareValidator>
<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Ingrese una contraseña." ControlToValidate="TextBox5" Display="None"></asp:RequiredFieldValidator>
<br /><br />
    Confirmar Password:<asp:TextBox ID="TextBox5" runat="server" TextMode="Password"></asp:TextBox>
<br /><br />
<asp:ValidationSummary ID="ValidationSummary1" runat="server" />
<br /><br />

   <asp:Button ID="Button1" runat="server" Text="Registrar" OnClick="Button1_Click" BackColor="Black" BorderColor="#66CCFF"  Font-Names="Berlin Sans FB" Font-Size="Large" Font-Strikeout="False" ForeColor="White" />
   


    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Volver" CausesValidation="false" BackColor="Black" BorderColor="#CCFFFF"  Font-Bold="False" Font-Names="Berlin Sans FB" Font-Size="Large" Font-Strikeout="False" ForeColor="White" />
   
        </div>

</asp:Content>
