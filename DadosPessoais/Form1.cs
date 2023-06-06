namespace DadosPessoais
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdcadastrar_Click(object sender, EventArgs e)
        {
            string nome, endereco, telefone;
            nome = txtnome.Text;
            endereco = txtendereco.Text;
            telefone = txttelefone.Text;    

            txtcadastradas.Text = ("NOME:" + nome + "ENDEREÇO:" + endereco+ "TELEFONE:" + telefone);
        }
    }
}