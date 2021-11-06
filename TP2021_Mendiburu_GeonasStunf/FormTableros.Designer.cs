
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TP2021_Mendiburu_GeonasStunf
{
    public partial class FormTableros 
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        cJuego partida;
        private Panel[,] _chessBoardPanels;
        Panel[,] Fatales;
        const int tileSize = 45;
        const int gridSize = 8;
        Color clr1 = Color.Beige;
        Color clr2 = Color.RosyBrown;
        int tab = 0;
        //private void Form_Load(object sender, EventArgs e)
        //{
        //    const int tileSize = 40;
        //    const int gridSize = 12;
        //    Color clr1 = Color.Black;
        //    Color clr2 = Color.White;
        //    //inicializo taablero
        //    _chessBoardPanels = new Panel[gridSize, gridSize];
        //    for (int i = 0; i < gridSize; i++)
        //    {
        //        for (int j = 0; j < gridSize; j++)
        //        {
        //            Panel newPanel = new Panel
        //            {
        //                Size = new Size(tileSize, tileSize),
        //                Location = new Point((tileSize * i)+5, (tileSize * j)+5)
        //            };
        //            Controls.Add(newPanel);
        //            _chessBoardPanels[i, j] = newPanel;
        //            if (i % 2 == 0)
        //                newPanel.BackColor = j % 2 != 0 ? clr1 : clr2;
        //            else
        //                newPanel.BackColor = j% 2 != 0 ? clr2 : clr1;

        //        }
        //    }
        //}

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /// 

       

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
        public void Tableros()
        {
            _chessBoardPanels = new Panel[gridSize, gridSize];

            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    Panel newPanel = new Panel
                    {
                        Size = new Size(tileSize, tileSize),
                        Location = new Point((tileSize * i) + 42, (tileSize * j) + 69)
                    };
                    Controls.Add(newPanel);
                    _chessBoardPanels[i, j] = newPanel;
                    if (i % 2 == 0)
                        newPanel.BackColor = j % 2 != 0 ? clr1 : clr2;
                    else
                        newPanel.BackColor = j % 2 != 0 ? clr2 : clr1;

                }
            }
        }
   
        private void InitializeComponent()
        {
            this.rdbttnAmenazasfatales = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.BttnSiguiente = new System.Windows.Forms.Button();
            this.bttnFinalizar = new System.Windows.Forms.Button();
            this.TableroNumero = new System.Windows.Forms.TextBox();
            this.TxtNum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rdbttnAmenazasfatales
            // 
            this.rdbttnAmenazasfatales.AllowDrop = true;
            this.rdbttnAmenazasfatales.AutoSize = true;
            this.rdbttnAmenazasfatales.BackColor = System.Drawing.Color.Maroon;
            this.rdbttnAmenazasfatales.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F);
            this.rdbttnAmenazasfatales.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdbttnAmenazasfatales.Location = new System.Drawing.Point(426, 440);
            this.rdbttnAmenazasfatales.Name = "rdbttnAmenazasfatales";
            this.rdbttnAmenazasfatales.Size = new System.Drawing.Size(162, 24);
            this.rdbttnAmenazasfatales.TabIndex = 0;
            this.rdbttnAmenazasfatales.Text = "Amenazas Fatales";
            this.rdbttnAmenazasfatales.UseVisualStyleBackColor = false;
            this.rdbttnAmenazasfatales.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F);
            this.button1.Location = new System.Drawing.Point(50, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Anterior";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BttnSiguiente
            // 
            this.BttnSiguiente.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F);
            this.BttnSiguiente.Location = new System.Drawing.Point(755, 431);
            this.BttnSiguiente.Name = "BttnSiguiente";
            this.BttnSiguiente.Size = new System.Drawing.Size(161, 41);
            this.BttnSiguiente.TabIndex = 2;
            this.BttnSiguiente.Text = "Siguiente";
            this.BttnSiguiente.UseVisualStyleBackColor = true;
            this.BttnSiguiente.Click += new System.EventHandler(this.BttnSiguiente_Click);
            // 
            // bttnFinalizar
            // 
            this.bttnFinalizar.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F);
            this.bttnFinalizar.Location = new System.Drawing.Point(755, 487);
            this.bttnFinalizar.Name = "bttnFinalizar";
            this.bttnFinalizar.Size = new System.Drawing.Size(161, 36);
            this.bttnFinalizar.TabIndex = 3;
            this.bttnFinalizar.Text = "Finalizar";
            this.bttnFinalizar.UseVisualStyleBackColor = true;
            this.bttnFinalizar.Click += new System.EventHandler(this.bttnFinalizar_Click);
            // 
            // TableroNumero
            // 
            this.TableroNumero.BackColor = System.Drawing.Color.Maroon;
            this.TableroNumero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TableroNumero.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F);
            this.TableroNumero.ForeColor = System.Drawing.Color.White;
            this.TableroNumero.Location = new System.Drawing.Point(67, 35);
            this.TableroNumero.Name = "TableroNumero";
            this.TableroNumero.ReadOnly = true;
            this.TableroNumero.Size = new System.Drawing.Size(133, 22);
            this.TableroNumero.TabIndex = 4;
            this.TableroNumero.Text = "Tablero numero:";
            this.TableroNumero.TextChanged += new System.EventHandler(this.TableroNumero_TextChanged);
            // 
            // TxtNum
            // 
            this.TxtNum.BackColor = System.Drawing.Color.Maroon;
            this.TxtNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNum.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F);
            this.TxtNum.ForeColor = System.Drawing.Color.White;
            this.TxtNum.Location = new System.Drawing.Point(200, 35);
            this.TxtNum.Name = "TxtNum";
            this.TxtNum.ReadOnly = true;
            this.TxtNum.Size = new System.Drawing.Size(51, 22);
            this.TxtNum.TabIndex = 5;
            // 
            // FormTableros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(973, 554);
            this.Controls.Add(this.TxtNum);
            this.Controls.Add(this.TableroNumero);
            this.Controls.Add(this.bttnFinalizar);
            this.Controls.Add(this.BttnSiguiente);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rdbttnAmenazasfatales);
            this.Name = "FormTableros";
            this.Text = "FormTableros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button1;
        private Button BttnSiguiente;
        private RadioButton rdbttnAmenazasfatales;
        private Button bttnFinalizar;
        private TextBox TableroNumero;
        private TextBox TxtNum;
    }
}