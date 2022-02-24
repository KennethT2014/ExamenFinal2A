
namespace ExamenFinal2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.ApellidoP = new System.Windows.Forms.TextBox();
            this.ApellidoM = new System.Windows.Forms.TextBox();
            this.MascBut = new System.Windows.Forms.RadioButton();
            this.FemBut = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.Nacionalidad = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.MostrarDatosPerfil = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Universidad = new System.Windows.Forms.ComboBox();
            this.Carrera = new System.Windows.Forms.ComboBox();
            this.AñoCurso = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 425);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(767, 396);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos Generales";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.AñoCurso);
            this.tabPage2.Controls.Add(this.Carrera);
            this.tabPage2.Controls.Add(this.Universidad);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(767, 396);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Datos Opcionales";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Nacionalidad);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.FemBut);
            this.groupBox1.Controls.Add(this.MascBut);
            this.groupBox1.Controls.Add(this.ApellidoM);
            this.groupBox1.Controls.Add(this.ApellidoP);
            this.groupBox1.Controls.Add(this.Nombre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(19, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 354);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido P:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido M:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sexo:";
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(172, 60);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(153, 22);
            this.Nombre.TabIndex = 4;
            // 
            // ApellidoP
            // 
            this.ApellidoP.Location = new System.Drawing.Point(172, 105);
            this.ApellidoP.Name = "ApellidoP";
            this.ApellidoP.Size = new System.Drawing.Size(153, 22);
            this.ApellidoP.TabIndex = 5;
            // 
            // ApellidoM
            // 
            this.ApellidoM.Location = new System.Drawing.Point(172, 149);
            this.ApellidoM.Name = "ApellidoM";
            this.ApellidoM.Size = new System.Drawing.Size(153, 22);
            this.ApellidoM.TabIndex = 6;
            // 
            // MascBut
            // 
            this.MascBut.AutoSize = true;
            this.MascBut.Location = new System.Drawing.Point(172, 192);
            this.MascBut.Name = "MascBut";
            this.MascBut.Size = new System.Drawing.Size(92, 21);
            this.MascBut.TabIndex = 7;
            this.MascBut.TabStop = true;
            this.MascBut.Text = "Masculino";
            this.MascBut.UseVisualStyleBackColor = true;
            this.MascBut.CheckedChanged += new System.EventHandler(this.MascBut_CheckedChanged);
            // 
            // FemBut
            // 
            this.FemBut.AutoSize = true;
            this.FemBut.Location = new System.Drawing.Point(172, 220);
            this.FemBut.Name = "FemBut";
            this.FemBut.Size = new System.Drawing.Size(91, 21);
            this.FemBut.TabIndex = 8;
            this.FemBut.TabStop = true;
            this.FemBut.Text = "Femenino";
            this.FemBut.UseVisualStyleBackColor = true;
            this.FemBut.CheckedChanged += new System.EventHandler(this.FemBut_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nacionalidad:";
            // 
            // Nacionalidad
            // 
            this.Nacionalidad.FormattingEnabled = true;
            this.Nacionalidad.Location = new System.Drawing.Point(179, 276);
            this.Nacionalidad.Name = "Nacionalidad";
            this.Nacionalidad.Size = new System.Drawing.Size(146, 24);
            this.Nacionalidad.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MostrarDatosPerfil);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(462, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 354);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Perfil";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Fecha de Nacimiento";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(17, 220);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(247, 22);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // MostrarDatosPerfil
            // 
            this.MostrarDatosPerfil.AutoSize = true;
            this.MostrarDatosPerfil.Location = new System.Drawing.Point(26, 276);
            this.MostrarDatosPerfil.Name = "MostrarDatosPerfil";
            this.MostrarDatosPerfil.Size = new System.Drawing.Size(202, 21);
            this.MostrarDatosPerfil.TabIndex = 3;
            this.MostrarDatosPerfil.Text = "Desea Mostrar estos Datos";
            this.MostrarDatosPerfil.UseVisualStyleBackColor = true;
            this.MostrarDatosPerfil.CheckedChanged += new System.EventHandler(this.MostrarDatosPerfil_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 17);
            this.label8.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Universidad:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 17);
            this.label10.TabIndex = 3;
            this.label10.Text = "Carrera:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 17);
            this.label11.TabIndex = 4;
            this.label11.Text = "Año en curso:";
            // 
            // Universidad
            // 
            this.Universidad.FormattingEnabled = true;
            this.Universidad.Location = new System.Drawing.Point(169, 40);
            this.Universidad.Name = "Universidad";
            this.Universidad.Size = new System.Drawing.Size(161, 24);
            this.Universidad.TabIndex = 5;
            this.Universidad.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Carrera
            // 
            this.Carrera.FormattingEnabled = true;
            this.Carrera.Location = new System.Drawing.Point(169, 87);
            this.Carrera.Name = "Carrera";
            this.Carrera.Size = new System.Drawing.Size(161, 24);
            this.Carrera.TabIndex = 6;
            // 
            // AñoCurso
            // 
            this.AñoCurso.FormattingEnabled = true;
            this.AñoCurso.Location = new System.Drawing.Point(169, 130);
            this.AñoCurso.Name = "AñoCurso";
            this.AñoCurso.Size = new System.Drawing.Size(161, 24);
            this.AñoCurso.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 492);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox Nacionalidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton FemBut;
        private System.Windows.Forms.RadioButton MascBut;
        private System.Windows.Forms.TextBox ApellidoM;
        private System.Windows.Forms.TextBox ApellidoP;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox MostrarDatosPerfil;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox AñoCurso;
        private System.Windows.Forms.ComboBox Carrera;
        private System.Windows.Forms.ComboBox Universidad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}

