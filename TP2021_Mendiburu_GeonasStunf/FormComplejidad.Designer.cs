
namespace TP2021_Mendiburu_GeonasStunf
{
    partial class FormComplejidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormComplejidad));
            this.lblComplex = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCotainferior = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblComplex
            // 
            this.lblComplex.AutoSize = true;
            this.lblComplex.Font = new System.Drawing.Font("Mongolian Baiti", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplex.ForeColor = System.Drawing.Color.DarkRed;
            this.lblComplex.Location = new System.Drawing.Point(12, 9);
            this.lblComplex.Name = "lblComplex";
            this.lblComplex.Size = new System.Drawing.Size(158, 21);
            this.lblComplex.TabIndex = 0;
            this.lblComplex.Text = "COMPLEJIDAD";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.IndianRed;
            this.btnVolver.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnVolver.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnVolver.Location = new System.Drawing.Point(603, 349);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(135, 73);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver a Inicio";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(52, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(686, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // lblCotainferior
            // 
            this.lblCotainferior.AutoSize = true;
            this.lblCotainferior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCotainferior.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCotainferior.ForeColor = System.Drawing.Color.DarkRed;
            this.lblCotainferior.Location = new System.Drawing.Point(261, 141);
            this.lblCotainferior.Name = "lblCotainferior";
            this.lblCotainferior.Size = new System.Drawing.Size(275, 20);
            this.lblCotainferior.TabIndex = 3;
            this.lblCotainferior.Text = "Ω(C)=n, n cantidad de entradas";
            // 
            // FormComplejidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCotainferior);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblComplex);
            this.Name = "FormComplejidad";
            this.Text = "FormComplejidad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblComplex;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCotainferior;
    }
}