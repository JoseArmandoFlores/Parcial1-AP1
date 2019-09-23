namespace Parcial1_AP1.UI.Registros
{
    partial class REvaluacionesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Idlabel = new System.Windows.Forms.Label();
            this.Fechalabel = new System.Windows.Forms.Label();
            this.Nombrelabel = new System.Windows.Forms.Label();
            this.Valorlabel = new System.Windows.Forms.Label();
            this.CalificacionesgroupBox = new System.Windows.Forms.GroupBox();
            this.Logradolabel = new System.Windows.Forms.Label();
            this.Perdidolabel = new System.Windows.Forms.Label();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.IDnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ValortextBox = new System.Windows.Forms.TextBox();
            this.LogradotextBox = new System.Windows.Forms.TextBox();
            this.PerdidotextBox = new System.Windows.Forms.TextBox();
            this.Decisionlabel = new System.Windows.Forms.Label();
            this.Pronosticolabel = new System.Windows.Forms.Label();
            this.PronosticocomboBox = new System.Windows.Forms.ComboBox();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.MyerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.CalificacionesgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Idlabel
            // 
            this.Idlabel.AutoSize = true;
            this.Idlabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Idlabel.Location = new System.Drawing.Point(12, 21);
            this.Idlabel.Name = "Idlabel";
            this.Idlabel.Size = new System.Drawing.Size(30, 22);
            this.Idlabel.TabIndex = 0;
            this.Idlabel.Text = "ID";
            // 
            // Fechalabel
            // 
            this.Fechalabel.AutoSize = true;
            this.Fechalabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fechalabel.Location = new System.Drawing.Point(330, 21);
            this.Fechalabel.Name = "Fechalabel";
            this.Fechalabel.Size = new System.Drawing.Size(57, 22);
            this.Fechalabel.TabIndex = 1;
            this.Fechalabel.Text = "Fecha";
            // 
            // Nombrelabel
            // 
            this.Nombrelabel.AutoSize = true;
            this.Nombrelabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombrelabel.Location = new System.Drawing.Point(12, 49);
            this.Nombrelabel.Name = "Nombrelabel";
            this.Nombrelabel.Size = new System.Drawing.Size(92, 22);
            this.Nombrelabel.TabIndex = 2;
            this.Nombrelabel.Text = "Estudiante";
            // 
            // Valorlabel
            // 
            this.Valorlabel.AutoSize = true;
            this.Valorlabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valorlabel.Location = new System.Drawing.Point(39, 34);
            this.Valorlabel.Name = "Valorlabel";
            this.Valorlabel.Size = new System.Drawing.Size(53, 22);
            this.Valorlabel.TabIndex = 3;
            this.Valorlabel.Text = "Valor";
            // 
            // CalificacionesgroupBox
            // 
            this.CalificacionesgroupBox.Controls.Add(this.PerdidotextBox);
            this.CalificacionesgroupBox.Controls.Add(this.LogradotextBox);
            this.CalificacionesgroupBox.Controls.Add(this.ValortextBox);
            this.CalificacionesgroupBox.Controls.Add(this.Perdidolabel);
            this.CalificacionesgroupBox.Controls.Add(this.Logradolabel);
            this.CalificacionesgroupBox.Controls.Add(this.Valorlabel);
            this.CalificacionesgroupBox.Location = new System.Drawing.Point(12, 78);
            this.CalificacionesgroupBox.Name = "CalificacionesgroupBox";
            this.CalificacionesgroupBox.Size = new System.Drawing.Size(506, 118);
            this.CalificacionesgroupBox.TabIndex = 4;
            this.CalificacionesgroupBox.TabStop = false;
            this.CalificacionesgroupBox.Text = "Calificaciones tareas y parcial";
            // 
            // Logradolabel
            // 
            this.Logradolabel.AutoSize = true;
            this.Logradolabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logradolabel.Location = new System.Drawing.Point(208, 34);
            this.Logradolabel.Name = "Logradolabel";
            this.Logradolabel.Size = new System.Drawing.Size(76, 22);
            this.Logradolabel.TabIndex = 4;
            this.Logradolabel.Text = "Logrado";
            // 
            // Perdidolabel
            // 
            this.Perdidolabel.AutoSize = true;
            this.Perdidolabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Perdidolabel.Location = new System.Drawing.Point(389, 34);
            this.Perdidolabel.Name = "Perdidolabel";
            this.Perdidolabel.Size = new System.Drawing.Size(73, 22);
            this.Perdidolabel.TabIndex = 5;
            this.Perdidolabel.Text = "Perdido";
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechadateTimePicker.Location = new System.Drawing.Point(393, 23);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(125, 22);
            this.FechadateTimePicker.TabIndex = 5;
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(126, 50);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(392, 22);
            this.NombretextBox.TabIndex = 7;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Location = new System.Drawing.Point(249, 22);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 24);
            this.Buscarbutton.TabIndex = 8;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // IDnumericUpDown
            // 
            this.IDnumericUpDown.Location = new System.Drawing.Point(126, 23);
            this.IDnumericUpDown.Name = "IDnumericUpDown";
            this.IDnumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.IDnumericUpDown.TabIndex = 9;
            // 
            // ValortextBox
            // 
            this.ValortextBox.Location = new System.Drawing.Point(24, 59);
            this.ValortextBox.Name = "ValortextBox";
            this.ValortextBox.Size = new System.Drawing.Size(92, 22);
            this.ValortextBox.TabIndex = 10;
            // 
            // LogradotextBox
            // 
            this.LogradotextBox.Location = new System.Drawing.Point(203, 59);
            this.LogradotextBox.Name = "LogradotextBox";
            this.LogradotextBox.Size = new System.Drawing.Size(92, 22);
            this.LogradotextBox.TabIndex = 11;
            // 
            // PerdidotextBox
            // 
            this.PerdidotextBox.Location = new System.Drawing.Point(381, 59);
            this.PerdidotextBox.Name = "PerdidotextBox";
            this.PerdidotextBox.ReadOnly = true;
            this.PerdidotextBox.Size = new System.Drawing.Size(92, 22);
            this.PerdidotextBox.TabIndex = 12;
            // 
            // Decisionlabel
            // 
            this.Decisionlabel.AutoSize = true;
            this.Decisionlabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decisionlabel.Location = new System.Drawing.Point(12, 209);
            this.Decisionlabel.Name = "Decisionlabel";
            this.Decisionlabel.Size = new System.Drawing.Size(202, 22);
            this.Decisionlabel.TabIndex = 10;
            this.Decisionlabel.Text = "Por como vas deberias: ";
            // 
            // Pronosticolabel
            // 
            this.Pronosticolabel.AutoSize = true;
            this.Pronosticolabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pronosticolabel.Location = new System.Drawing.Point(12, 250);
            this.Pronosticolabel.Name = "Pronosticolabel";
            this.Pronosticolabel.Size = new System.Drawing.Size(95, 22);
            this.Pronosticolabel.TabIndex = 11;
            this.Pronosticolabel.Text = "Pronostico";
            // 
            // PronosticocomboBox
            // 
            this.PronosticocomboBox.FormattingEnabled = true;
            this.PronosticocomboBox.Items.AddRange(new object[] {
            "Continuar",
            "Suspenso",
            "Retirar"});
            this.PronosticocomboBox.Location = new System.Drawing.Point(113, 248);
            this.PronosticocomboBox.Name = "PronosticocomboBox";
            this.PronosticocomboBox.Size = new System.Drawing.Size(405, 24);
            this.PronosticocomboBox.TabIndex = 12;
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Location = new System.Drawing.Point(36, 309);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 40);
            this.Nuevobutton.TabIndex = 13;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(232, 309);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 40);
            this.Guardarbutton.TabIndex = 14;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Location = new System.Drawing.Point(432, 309);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 40);
            this.Eliminarbutton.TabIndex = 15;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // MyerrorProvider
            // 
            this.MyerrorProvider.ContainerControl = this;
            // 
            // REvaluacionesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 377);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.PronosticocomboBox);
            this.Controls.Add(this.Pronosticolabel);
            this.Controls.Add(this.Decisionlabel);
            this.Controls.Add(this.IDnumericUpDown);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.CalificacionesgroupBox);
            this.Controls.Add(this.Nombrelabel);
            this.Controls.Add(this.Fechalabel);
            this.Controls.Add(this.Idlabel);
            this.Name = "REvaluacionesForm";
            this.Text = "REvaluacionesForm";
            this.Load += new System.EventHandler(this.REvaluacionesForm_Load);
            this.CalificacionesgroupBox.ResumeLayout(false);
            this.CalificacionesgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Idlabel;
        private System.Windows.Forms.Label Fechalabel;
        private System.Windows.Forms.Label Nombrelabel;
        private System.Windows.Forms.Label Valorlabel;
        private System.Windows.Forms.GroupBox CalificacionesgroupBox;
        private System.Windows.Forms.Label Perdidolabel;
        private System.Windows.Forms.Label Logradolabel;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.TextBox PerdidotextBox;
        private System.Windows.Forms.TextBox LogradotextBox;
        private System.Windows.Forms.TextBox ValortextBox;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.NumericUpDown IDnumericUpDown;
        private System.Windows.Forms.Label Decisionlabel;
        private System.Windows.Forms.Label Pronosticolabel;
        private System.Windows.Forms.ComboBox PronosticocomboBox;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.ErrorProvider MyerrorProvider;
    }
}