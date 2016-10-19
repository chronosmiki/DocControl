using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocControl.Dao;

namespace DocControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ConectaBD conn = new Dao.ConectaBD();
            conn.Conecta();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tsNovoDoc_Click(object sender, EventArgs e)
        {
            pAddDoc.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pAddDoc.Visible = false;
            txtNome.Clear();
            txtEmpresa.Clear();
        }
    }
}
