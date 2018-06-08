namespace Metro
{
    partial class Lineas
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
            this.bTornos = new System.Windows.Forms.Button();
            this.bTrenes = new System.Windows.Forms.Button();
            this.bJefeEstacion = new System.Windows.Forms.Button();
            this.bSeleccionar = new System.Windows.Forms.Button();
            this.lbNombre = new System.Windows.Forms.ListBox();
            this.lbNumero = new System.Windows.Forms.ListBox();
            this.lbEstaciones = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bInicio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bTornos
            // 
            this.bTornos.Location = new System.Drawing.Point(780, 210);
            this.bTornos.Name = "bTornos";
            this.bTornos.Size = new System.Drawing.Size(75, 36);
            this.bTornos.TabIndex = 0;
            this.bTornos.Text = "Sistema de tornos";
            this.bTornos.UseVisualStyleBackColor = true;
            // 
            // bTrenes
            // 
            this.bTrenes.Location = new System.Drawing.Point(780, 276);
            this.bTrenes.Name = "bTrenes";
            this.bTrenes.Size = new System.Drawing.Size(75, 36);
            this.bTrenes.TabIndex = 1;
            this.bTrenes.Text = "Trenes";
            this.bTrenes.UseVisualStyleBackColor = true;
            this.bTrenes.Click += new System.EventHandler(this.bTrenes_Click);
            // 
            // bJefeEstacion
            // 
            this.bJefeEstacion.Location = new System.Drawing.Point(780, 338);
            this.bJefeEstacion.Name = "bJefeEstacion";
            this.bJefeEstacion.Size = new System.Drawing.Size(75, 36);
            this.bJefeEstacion.TabIndex = 2;
            this.bJefeEstacion.Text = "Jefe de estacion";
            this.bJefeEstacion.UseVisualStyleBackColor = true;
            this.bJefeEstacion.Click += new System.EventHandler(this.bJefeEstacion_Click);
            // 
            // bSeleccionar
            // 
            this.bSeleccionar.Location = new System.Drawing.Point(780, 111);
            this.bSeleccionar.Name = "bSeleccionar";
            this.bSeleccionar.Size = new System.Drawing.Size(75, 36);
            this.bSeleccionar.TabIndex = 3;
            this.bSeleccionar.Text = "Seleccionar";
            this.bSeleccionar.UseVisualStyleBackColor = true;
            // 
            // lbNombre
            // 
            this.lbNombre.FormattingEnabled = true;
            this.lbNombre.Location = new System.Drawing.Point(37, 110);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(127, 277);
            this.lbNombre.TabIndex = 4;
            // 
            // lbNumero
            // 
            this.lbNumero.FormattingEnabled = true;
            this.lbNumero.Location = new System.Drawing.Point(178, 110);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(127, 277);
            this.lbNumero.TabIndex = 5;
            // 
            // lbEstaciones
            // 
            this.lbEstaciones.FormattingEnabled = true;
            this.lbEstaciones.Location = new System.Drawing.Point(423, 110);
            this.lbEstaciones.Name = "lbEstaciones";
            this.lbEstaciones.Size = new System.Drawing.Size(281, 277);
            this.lbEstaciones.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(68, 44);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(794, 10);
            this.button3.TabIndex = 9;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(416, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "LINEAS";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button2.Image = global::Metro.Properties.Resources.logoPequeño21;
            this.button2.Location = new System.Drawing.Point(791, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 56);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Image = global::Metro.Properties.Resources.logoPequeño21;
            this.button1.Location = new System.Drawing.Point(44, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 56);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(144, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "LINEAS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(515, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "ESTACIONES";
            // 
            // bInicio
            // 
            this.bInicio.Location = new System.Drawing.Point(333, 389);
            this.bInicio.Name = "bInicio";
            this.bInicio.Size = new System.Drawing.Size(75, 35);
            this.bInicio.TabIndex = 13;
            this.bInicio.Text = "Volver al inicio";
            this.bInicio.UseVisualStyleBackColor = true;
            this.bInicio.Click += new System.EventHandler(this.bInicio_Click);
            // 
            // Lineas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(924, 431);
            this.Controls.Add(this.bInicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lbEstaciones);
            this.Controls.Add(this.lbNumero);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.bSeleccionar);
            this.Controls.Add(this.bJefeEstacion);
            this.Controls.Add(this.bTrenes);
            this.Controls.Add(this.bTornos);
            this.Name = "Lineas";
            this.Text = "Lineas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bTornos;
        private System.Windows.Forms.Button bTrenes;
        private System.Windows.Forms.Button bJefeEstacion;
        private System.Windows.Forms.Button bSeleccionar;
        private System.Windows.Forms.ListBox lbNombre;
        private System.Windows.Forms.ListBox lbNumero;
        private System.Windows.Forms.ListBox lbEstaciones;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bInicio;
    }
}