namespace Metro
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.bLineas = new System.Windows.Forms.Button();
            this.bEmpleados = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bLineas
            // 
            this.bLineas.ForeColor = System.Drawing.Color.Black;
            this.bLineas.Location = new System.Drawing.Point(196, 237);
            this.bLineas.Name = "bLineas";
            this.bLineas.Size = new System.Drawing.Size(85, 23);
            this.bLineas.TabIndex = 0;
            this.bLineas.Text = "LINEAS";
            this.bLineas.UseVisualStyleBackColor = true;
            this.bLineas.Click += new System.EventHandler(this.bLineas_Click);
            // 
            // bEmpleados
            // 
            this.bEmpleados.ForeColor = System.Drawing.Color.Black;
            this.bEmpleados.Location = new System.Drawing.Point(374, 237);
            this.bEmpleados.Name = "bEmpleados";
            this.bEmpleados.Size = new System.Drawing.Size(85, 23);
            this.bEmpleados.TabIndex = 1;
            this.bEmpleados.Text = "EMPLEADOS";
            this.bEmpleados.UseVisualStyleBackColor = true;
            this.bEmpleados.Click += new System.EventHandler(this.bEmpleados_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Metro.Properties.Resources.logoMedio;
            this.button1.Location = new System.Drawing.Point(218, -5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 142);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(13, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(629, 10);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(654, 341);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bEmpleados);
            this.Controls.Add(this.bLineas);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bLineas;
        private System.Windows.Forms.Button bEmpleados;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}