using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using MySql.Data.MySqlClient;


namespace FormPrincipal
{
    public partial class FrmCadastro : Form
    {
        Thread nt;
        public FrmCadastro()
        {

            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(novoFrmPrincipal);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void novoFrmPrincipal()
        {
            Application.Run(new FrmPrincipal());
        }

        private void FrmCadastro_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                var strConexao = "server=localhost;uid=root;database=BancoHotelaria1";
                var conexao = new MySqlConnection(strConexao);



                // Executar Comando Insert

                String sql = "INSERT INTO cliente (Nome_cliente,Primeiro_Telefone,Segundo_Telefone,CPF,CEP,Email,Bairro,Cidade,UF,Complemento,Numero) VALUES (' " + Nome.Text + "',' " + Telefone.Text + "',' " + Telefone2.Text +"',' " + CPF.Text + "',' " + CEP.Text + "',' " + Email.Text + "',' " + Bairro.Text +"',' " + Cidade.Text +"',' " + UF.Text +"',' " + Complemento.Text +"',' " + Numero.Text + "');";
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                conexao.Open();

                comando.ExecuteReader();

                MessageBox.Show("Deu tudo certo,Inserido");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

    
        


       
        
