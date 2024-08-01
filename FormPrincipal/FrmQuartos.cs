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

namespace FormPrincipal
{
    public partial class FrmQuartos : Form
    {
        Thread nt; 
        public FrmQuartos()
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
    }
}
