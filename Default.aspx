<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CadastraAluno._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">Cadastrar aluno</h1>
        </section>

        <div class="row">
            <section class="col-md-8" aria-labelledby="nome">
                <asp:Label ID="lblNome" runat="server" Text="Nome"></asp:Label>
                <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
                <br>
                <br />
                <asp:Label ID="Label1" runat="server" Text="RA"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </section>
            <br />
            <section class="col-md-2" aria-labelledby="notas">
                <asp:Label ID="lblNotas" runat="server" Text="Notas"></asp:Label>
                <asp:TextBox ID="txtNotas" runat="server"></asp:TextBox>
            </section>
            <div class="col-md-2">
                <asp:Button ID="btnCadastrar" runat="server" OnClick="btnCadastrar_Click" Text="Cadastrar" />

            </div>
        </div>
    </main>

</asp:Content>
