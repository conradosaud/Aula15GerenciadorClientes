namespace Aula15GerenciadorUsuarios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            for (int i = 0; i < Program.clientes.Count; i++)
            {
                if ( 
                    Program.clientes[i].usuario.usuario == usuario 
                    &&
                    Program.clientes[i].usuario.senha == senha
                )
                {
                    Form2 form2 = new Form2();
                    form2.Show();
                }
                else
                {
                    MessageBox.Show("Usu�rio ou senha incorretos");
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario("admin", "admin");
            Cliente cliente = new Cliente("Admin", 0, usuario);
            Program.clientes.Add(cliente);
        }

    }
}