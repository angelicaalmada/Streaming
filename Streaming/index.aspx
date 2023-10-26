<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Streaming.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cargar Videos</title>

    <h1 style="font-family:Arial; text-align:center">Cargar Videos</h1>
    <style>
        iframe {
            height: 400px;
        }
     </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

           <label>Nombre del video</label> <asp:TextBox ID="txtNombre"  runat="server"></asp:TextBox><br>
           <label>Descripcion</label> <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox><br>
            <asp:FileUpload ID="fuVideo" runat="server" /><br>
            <asp:Button ID="btnCargar" runat="server" Text="cargar" OnClick="btnCargar_Click" />
            <br>
            <label>URL</label><asp:TextBox ID="txtURL" runat="server"></asp:TextBox>
            <asp:Literal ID="lit" runat="server"></asp:Literal>
        </div>
    </form>
</body>
</html>
