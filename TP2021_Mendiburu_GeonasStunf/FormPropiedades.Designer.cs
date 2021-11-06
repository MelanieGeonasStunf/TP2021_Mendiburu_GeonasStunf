
namespace TP2021_Mendiburu_GeonasStunf
{
    partial class FormPropiedadesPoda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPropiedadesPoda));
            this.lblPODA = new System.Windows.Forms.Label();
            this.lblTorres = new System.Windows.Forms.Label();
            this.lblReina = new System.Windows.Forms.Label();
            this.lblPODA3 = new System.Windows.Forms.Label();
            this.lblPODA4 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnComplejidad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPODA
            // 
            this.lblPODA.AutoSize = true;
            this.lblPODA.Font = new System.Drawing.Font("Mongolian Baiti", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPODA.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPODA.Location = new System.Drawing.Point(12, 20);
            this.lblPODA.Name = "lblPODA";
            this.lblPODA.Size = new System.Drawing.Size(67, 21);
            this.lblPODA.TabIndex = 0;
            this.lblPODA.Text = "PODA";
            // 
            // lblTorres
            // 
            this.lblTorres.AutoSize = true;
            this.lblTorres.Font = new System.Drawing.Font("Mongolian Baiti", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTorres.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTorres.Location = new System.Drawing.Point(12, 78);
            this.lblTorres.Name = "lblTorres";
            this.lblTorres.Size = new System.Drawing.Size(458, 18);
            this.lblTorres.TabIndex = 1;
            this.lblTorres.Text = " - Las torres no pueden estar ni en misma fila ni misma columna";
            this.lblTorres.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblReina
            // 
            this.lblReina.AutoSize = true;
            this.lblReina.Font = new System.Drawing.Font("Mongolian Baiti", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReina.ForeColor = System.Drawing.Color.DarkRed;
            this.lblReina.Location = new System.Drawing.Point(13, 140);
            this.lblReina.Name = "lblReina";
            this.lblReina.Size = new System.Drawing.Size(695, 18);
            this.lblReina.TabIndex = 2;
            this.lblReina.Text = "- La reina no puede estar ni misma fila ni columna que las torres ni mismas diago" +
    "nales que alfiles";
            // 
            // lblPODA3
            // 
            this.lblPODA3.AutoSize = true;
            this.lblPODA3.Font = new System.Drawing.Font("Mongolian Baiti", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPODA3.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPODA3.Location = new System.Drawing.Point(12, 199);
            this.lblPODA3.Name = "lblPODA3";
            this.lblPODA3.Size = new System.Drawing.Size(587, 36);
            this.lblPODA3.TabIndex = 3;
            this.lblPODA3.Text = "- Para posicionar las piezas en el tablero inicialmente nos fijamos que la posici" +
    "on \r\naleatoria que nos brinda el random no este amenazada";
            // 
            // lblPODA4
            // 
            this.lblPODA4.AutoSize = true;
            this.lblPODA4.Font = new System.Drawing.Font("Mongolian Baiti", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPODA4.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPODA4.Location = new System.Drawing.Point(12, 275);
            this.lblPODA4.Name = "lblPODA4";
            this.lblPODA4.Size = new System.Drawing.Size(793, 54);
            this.lblPODA4.TabIndex = 4;
            this.lblPODA4.Text = resources.GetString("lblPODA4.Text");
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.IndianRed;
            this.btnVolver.Font = new System.Drawing.Font("Mongolian Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnVolver.Location = new System.Drawing.Point(543, 373);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 44);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnComplejidad
            // 
            this.btnComplejidad.BackColor = System.Drawing.Color.IndianRed;
            this.btnComplejidad.Font = new System.Drawing.Font("Mongolian Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComplejidad.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnComplejidad.Location = new System.Drawing.Point(624, 373);
            this.btnComplejidad.Name = "btnComplejidad";
            this.btnComplejidad.Size = new System.Drawing.Size(128, 44);
            this.btnComplejidad.TabIndex = 6;
            this.btnComplejidad.Text = "Complejidad";
            this.btnComplejidad.UseVisualStyleBackColor = false;
            this.btnComplejidad.Click += new System.EventHandler(this.btnComplejidad_Click);
            // 
            // FormPropiedadesPoda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnComplejidad);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblPODA4);
            this.Controls.Add(this.lblPODA3);
            this.Controls.Add(this.lblReina);
            this.Controls.Add(this.lblTorres);
            this.Controls.Add(this.lblPODA);
            this.Name = "FormPropiedadesPoda";
            this.Text = "FormPropiedades";
            this.Load += new System.EventHandler(this.FormPropiedades_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPODA;
        private System.Windows.Forms.Label lblTorres;
        private System.Windows.Forms.Label lblReina;
        private System.Windows.Forms.Label lblPODA3;
        private System.Windows.Forms.Label lblPODA4;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnComplejidad;
    }
}