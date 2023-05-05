using System;
using System.Web.UI;

namespace CadastraAluno
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            new Aluno()
            {
                Nome = txtNome.Text,
                Ra = txtNotas.Text,
                Notas = txtNotas.Text
            }.Salvar();


            //Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "sucesso", "<script>alert('O cliente foi cadastrado com sucesso !!!')</script>");

            //gridClientes.DataSource = Aluno.Todos();
            //gridClientes.DataBind();

            //foreach (var c in Cliente.Todos())
            //{
            //    bodyTable.InnerHtml += "<tr>";
            //    bodyTable.InnerHtml += $"<td>{c.Nome}</td>";
            //    bodyTable.InnerHtml += $"<td>{c.Telefone}</td>";
            //    bodyTable.InnerHtml += "</tr>";
            //}
        }
    }
}