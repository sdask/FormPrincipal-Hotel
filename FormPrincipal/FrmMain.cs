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
using System.Xml.Linq;

namespace FormPrincipal
{
    public partial class FrmPrincipal : Form
    {
        Thread nt;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnAlmoxerifado_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(novoFrmAlmoxerifado);
            nt.SetApartmentState(ApartmentState.STA); 
            nt.Start();
        }

        private void novoFrmAlmoxerifado()
        {
            Application.Run(new FrmAlmoxerifado());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(novoFrmCadastro);
            nt.SetApartmentState (ApartmentState.STA);
            nt.Start();
        }

        private void novoFrmCadastro()
        {
           Application.Run(new FrmCadastro());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(novoFrmFinanceiro);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void novoFrmFinanceiro()
        {
            Application.Run(new FrmFinanceiro());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(novoFrmRestaurante);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void novoFrmRestaurante()
        {
          Application.Run(new FrmRestaurante());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(novoFrmFuncionario);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void novoFrmFuncionario()
        {
            Application.Run(new FrmFuncionario());
        }

        private void btnQuartos_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(novoFrmQuartos);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void novoFrmQuartos()
        {
            Application.Run(new Frm());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(novoFrmlogin);
            nt.SetApartmentState(ApartmentState.STA) ;
            nt.Start();
        }

        private void novoFrmlogin()
        {
            Application.Run(new FrmLogin());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this .Close();
            nt = new Thread(novoFrmReserv);
            nt.SetApartmentState (ApartmentState.STA) ;
            nt.Start();
        }

        private void novoFrmReserv()
        {
            Application.Run (new FrmReserv());
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
