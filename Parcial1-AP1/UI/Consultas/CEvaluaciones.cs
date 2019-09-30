using Parcial1_AP1.BLL;
using Parcial1_AP1.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1_AP1.UI.Consultas
{
    public partial class CEvaluaciones : Form
    {
        public CEvaluaciones()
        {
            InitializeComponent();
        }

        private void Consultarbutton_Click(object sender, EventArgs e)
        {
            var listado = new List<Evaluaciones>();
            if (CriteriotextBox.Text.Trim().Length > 0)
            {
                switch (FiltrocomboBox.SelectedIndex)
                {
                    case 0://Todo
                        listado = EvaluacionesBLL.GetList(p => true);
                        break;
                    case 1://ID
                        int id = Convert.ToInt32(CriteriotextBox.Text);
                        listado = EvaluacionesBLL.GetList(p => p.EvaluacionID == id);
                        break;
                    case 2://Nombre
                        listado = EvaluacionesBLL.GetList(p => p.Nombre.Contains(CriteriotextBox.Text));
                        break;
                    case 3://Perdido
                        decimal perdido = Convert.ToDecimal(CriteriotextBox.Text);
                        listado = EvaluacionesBLL.GetList(p => p.Perdido == perdido);
                        break;
                    case 4://Pronostico
                        int pronostico = Convert.ToInt32(CriteriotextBox.Text);
                        listado = EvaluacionesBLL.GetList(p => p.Pronostico == pronostico);
                        break;
                }
                listado = listado.Where(x => x.Fecha.Date >= DesdedateTimePicker.Value.Date && x.Fecha.Date <= HastadateTimePicker.Value.Date).ToList();
            }
            else
            {
                listado = EvaluacionesBLL.GetList(p => true);
            }
            ConsultardataGridView.DataSource = null;
            ConsultardataGridView.DataSource = listado;
        }
    }
}
