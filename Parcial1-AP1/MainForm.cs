using Parcial1_AP1.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1_AP1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void EvaluacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            REvaluacionesForm ev = new REvaluacionesForm();
            ev.MdiParent = this;
            ev.Show();
        }
    }
}
