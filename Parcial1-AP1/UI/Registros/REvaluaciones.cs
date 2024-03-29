﻿using Parcial1_AP1.BLL;
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

namespace Parcial1_AP1.UI.Registros
{
    public partial class REvaluaciones : Form
    {
        public REvaluaciones()
        {
            InitializeComponent();
        }

        private void REvaluacionesForm_Load(object sender, EventArgs e)
        {
         
        }
        
        private void Limpiar()
        {
            MyerrorProvider.Clear();
            IDnumericUpDown.Value = 0;
            FechadateTimePicker.Value = DateTime.Now;
            NombretextBox.Text = string.Empty;
            ValortextBox.Text = string.Empty;
            LogradotextBox.Text = string.Empty;
            PerdidotextBox.Text = string.Empty;
            PronosticocomboBox.Text = string.Empty;
        }

        private Evaluaciones LlenaClase()
        {
            Evaluaciones evaluacion = new Evaluaciones();
            evaluacion.EvaluacionID = Convert.ToInt32(IDnumericUpDown.Value);
            evaluacion.Fecha = FechadateTimePicker.Value;
            evaluacion.Nombre = NombretextBox.Text;
            evaluacion.Valor = Convert.ToDecimal(ValortextBox.Text);
            evaluacion.Logrado = Convert.ToDecimal(LogradotextBox.Text);
            evaluacion.Perdido = Convert.ToDecimal(ValortextBox.Text) - Convert.ToDecimal(LogradotextBox.Text);

            EvaluacionesBLL.Pronosticar(evaluacion);
            
            return evaluacion;
        }

        private void LlenaCampo(Evaluaciones evaluacion)
        {
            IDnumericUpDown.Value = evaluacion.EvaluacionID;
            FechadateTimePicker.Value = evaluacion.Fecha;
            NombretextBox.Text = evaluacion.Nombre;
            ValortextBox.Text = Convert.ToString(evaluacion.Valor);
            LogradotextBox.Text = Convert.ToString(evaluacion.Logrado);
            PerdidotextBox.Text = Convert.ToString(evaluacion.Perdido);
            PronosticocomboBox.SelectedIndex = evaluacion.Pronostico;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Evaluaciones evaluacion = EvaluacionesBLL.Buscar((int)IDnumericUpDown.Value);
            return (evaluacion != null);
        }
        
        private bool Validar()
        {
            bool paso = true;
            if(Convert.ToDecimal(ValortextBox.Text) < Convert.ToDecimal(LogradotextBox.Text))
            {
                MyerrorProvider.SetError(LogradotextBox, "El campo Logrado no puede ser mayor que el valor");
                LogradotextBox.Focus();
                paso = false;
            }

            if (Convert.ToDecimal(LogradotextBox.Text) < 0 )
            {
                MyerrorProvider.SetError(LogradotextBox, "Cantidad invalida");
                LogradotextBox.Focus();
                paso = false;
            }

            if (Convert.ToDecimal(ValortextBox.Text) < 0)
            {
                MyerrorProvider.SetError(ValortextBox, "Cantidad invalida");
                ValortextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(NombretextBox.Text))
            {
                MyerrorProvider.SetError(NombretextBox, "El campo Nombre no puede estar vacio");
                NombretextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(ValortextBox.Text))
            {
                MyerrorProvider.SetError(ValortextBox, "El campo Valor no puede estar vacio");
                ValortextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(LogradotextBox.Text))
            {
                MyerrorProvider.SetError(LogradotextBox, "El campo Logrado no puede estar vacio");
                LogradotextBox.Focus();
                paso = false;
            }
            return paso;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            Evaluaciones evaluacion;

            if (!Validar())
                return;
            evaluacion = LlenaClase();

            if (IDnumericUpDown.Value == 0)
                paso = EvaluacionesBLL.Guardar(evaluacion);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar una evaluacion que no existe","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                paso = EvaluacionesBLL.Modificar(evaluacion);
            }

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
                MessageBox.Show("No se pudo guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(IDnumericUpDown.Text, out id);

            Limpiar();
            if(EvaluacionesBLL.Buscar(id) != null)
            {
                if (EvaluacionesBLL.Eliminar(id))
                {
                    MessageBox.Show("Eliminado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            else
            {
                MessageBox.Show("No se puede eliminar una evaluacion que no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Evaluaciones evaluacion = new Evaluaciones();
            int id;
            int.TryParse(IDnumericUpDown.Text, out id);

            Limpiar();

            evaluacion = EvaluacionesBLL.Buscar(id);
            if (evaluacion != null)
            {
                LlenaCampo(evaluacion);
            }
            else
            {
                MessageBox.Show("Evaluacion no encontrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ValortextBox_TextChanged(object sender, EventArgs e)
        {
            decimal valor = 1;
            decimal logrado = 1;

            if (!string.IsNullOrWhiteSpace(ValortextBox.Text))
            {
                valor = Convert.ToDecimal(ValortextBox.Text);
            }
            if (!string.IsNullOrWhiteSpace(LogradotextBox.Text))
            {
                logrado = Convert.ToDecimal(LogradotextBox.Text);
            }

            decimal perdido = valor - logrado;

            PerdidotextBox.Text = Convert.ToString(perdido);

            decimal op = ((logrado / valor) * 100);
            decimal porciento = 100 - op;
            if (porciento < 25)
            {
                PronosticocomboBox.SelectedIndex = 0;
            }
            else if (porciento >= 25 && porciento <= 30)
            {
                PronosticocomboBox.SelectedIndex = 1;
            }
            else if (porciento > 25)
            {
                PronosticocomboBox.SelectedIndex = 2;
            }
        }

        private void LogradotextBox_TextChanged(object sender, EventArgs e)
        {
            decimal valor = 1;
            decimal logrado = 1;

            if (!string.IsNullOrWhiteSpace(ValortextBox.Text))
            {
                valor = Convert.ToDecimal(ValortextBox.Text);
            }
            if (!string.IsNullOrWhiteSpace(LogradotextBox.Text))
            {
                logrado = Convert.ToDecimal(LogradotextBox.Text);
            }

            decimal perdido = valor - logrado;

            PerdidotextBox.Text = Convert.ToString(perdido);

            decimal op = ((logrado / valor) * 100);
            decimal porciento = 100 - op;
            if (porciento < 25)
            {
                PronosticocomboBox.SelectedIndex = 0;
            }
            else if (porciento >= 25 && porciento <= 30)
            {
                PronosticocomboBox.SelectedIndex = 1;
            }
            else if (porciento > 25)
            {
                PronosticocomboBox.SelectedIndex = 2;
            }
        }
    }
}
