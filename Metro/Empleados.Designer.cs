namespace Metro
{
    partial class Empleados
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
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lbJefes = new System.Windows.Forms.ListBox();
            this.lbConductores = new System.Windows.Forms.ListBox();
            this.lbTecnicos = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bNomina = new System.Windows.Forms.Button();
            this.bVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(423, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "EMPLEADOS";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button2.Image = global::Metro.Properties.Resources.logoPequeño21;
            this.button2.Location = new System.Drawing.Point(791, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 56);
            this.button2.TabIndex = 12;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Image = global::Metro.Properties.Resources.logoPequeño21;
            this.button1.Location = new System.Drawing.Point(44, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 56);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(68, 39);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(794, 10);
            this.button3.TabIndex = 13;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // lbJefes
            // 
            this.lbJefes.FormattingEnabled = true;
            this.lbJefes.Location = new System.Drawing.Point(44, 106);
            this.lbJefes.Name = "lbJefes";
            this.lbJefes.Size = new System.Drawing.Size(758, 69);
            this.lbJefes.TabIndex = 15;
            // 
            // lbConductores
            // 
            this.lbConductores.FormattingEnabled = true;
            this.lbConductores.Location = new System.Drawing.Point(44, 205);
            this.lbConductores.Name = "lbConductores";
            this.lbConductores.Size = new System.Drawing.Size(758, 69);
            this.lbConductores.TabIndex = 16;
            // 
            // lbTecnicos
            // 
            this.lbTecnicos.FormattingEnabled = true;
            this.lbTecnicos.Location = new System.Drawing.Point(44, 310);
            this.lbTecnicos.Name = "lbTecnicos";
            this.lbTecnicos.Size = new System.Drawing.Size(758, 69);
            this.lbTecnicos.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "JEFES DE ESTACIONES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "CONDUCTORES";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "TECNICOS";
            // 
            // bNomina
            // 
            this.bNomina.Location = new System.Drawing.Point(834, 212);
            this.bNomina.Name = "bNomina";
            this.bNomina.Size = new System.Drawing.Size(75, 46);
            this.bNomina.TabIndex = 21;
            this.bNomina.Text = "NOMINA";
            this.bNomina.UseVisualStyleBackColor = true;
            // 
            // bVolver
            // 
            this.bVolver.Location = new System.Drawing.Point(834, 333);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(75, 46);
            this.bVolver.TabIndex = 22;
            this.bVolver.Text = "VOLVER AL INICIO";
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(924, 431);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.bNomina);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTecnicos);
            this.Controls.Add(this.lbConductores);
            this.Controls.Add(this.lbJefes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Name = "Empleados";
            this.Text = "Empleados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox lbJefes;
        private System.Windows.Forms.ListBox lbConductores;
        private System.Windows.Forms.ListBox lbTecnicos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bNomina;
        private System.Windows.Forms.Button bVolver;
    }
}