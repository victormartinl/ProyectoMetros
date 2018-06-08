namespace Metro
{
    partial class Trenes
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
            this.lbTrenes = new System.Windows.Forms.ListBox();
            this.lbHangar = new System.Windows.Forms.ListBox();
            this.lbCuidados = new System.Windows.Forms.ListBox();
            this.bVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(411, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "TRENES";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button2.Image = global::Metro.Properties.Resources.logoPequeño21;
            this.button2.Location = new System.Drawing.Point(791, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 56);
            this.button2.TabIndex = 16;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Image = global::Metro.Properties.Resources.logoPequeño21;
            this.button1.Location = new System.Drawing.Point(44, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 56);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(68, 38);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(794, 10);
            this.button3.TabIndex = 17;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // lbTrenes
            // 
            this.lbTrenes.FormattingEnabled = true;
            this.lbTrenes.Location = new System.Drawing.Point(44, 106);
            this.lbTrenes.Name = "lbTrenes";
            this.lbTrenes.Size = new System.Drawing.Size(373, 264);
            this.lbTrenes.TabIndex = 19;
            // 
            // lbHangar
            // 
            this.lbHangar.FormattingEnabled = true;
            this.lbHangar.Location = new System.Drawing.Point(500, 106);
            this.lbHangar.Name = "lbHangar";
            this.lbHangar.Size = new System.Drawing.Size(381, 121);
            this.lbHangar.TabIndex = 20;
            // 
            // lbCuidados
            // 
            this.lbCuidados.FormattingEnabled = true;
            this.lbCuidados.Location = new System.Drawing.Point(500, 249);
            this.lbCuidados.Name = "lbCuidados";
            this.lbCuidados.Size = new System.Drawing.Size(381, 121);
            this.lbCuidados.TabIndex = 21;
            // 
            // bVolver
            // 
            this.bVolver.Location = new System.Drawing.Point(425, 390);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(75, 23);
            this.bVolver.TabIndex = 22;
            this.bVolver.Text = "Volver";
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // Trenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(924, 431);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.lbCuidados);
            this.Controls.Add(this.lbHangar);
            this.Controls.Add(this.lbTrenes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Name = "Trenes";
            this.Text = "Trenes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox lbTrenes;
        private System.Windows.Forms.ListBox lbHangar;
        private System.Windows.Forms.ListBox lbCuidados;
        private System.Windows.Forms.Button bVolver;
    }
}