﻿namespace ProgettoNatale
{
    partial class Azioni_Elfo
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
            this.View_Kids = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.View_Gifts = new System.Windows.Forms.Button();
            this.Impostazioni_Profilo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(109, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(585, 105);
            this.label1.TabIndex = 6;
            this.label1.Text = "Christmas System";
            // 
            // View_Kids
            // 
            this.View_Kids.BackColor = System.Drawing.Color.Chocolate;
            this.View_Kids.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View_Kids.ForeColor = System.Drawing.Color.White;
            this.View_Kids.Location = new System.Drawing.Point(34, 162);
            this.View_Kids.Name = "View_Kids";
            this.View_Kids.Size = new System.Drawing.Size(260, 115);
            this.View_Kids.TabIndex = 5;
            this.View_Kids.Text = "BAMBINI";
            this.View_Kids.UseVisualStyleBackColor = false;
            this.View_Kids.Click += new System.EventHandler(this.View_Kids_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(23, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 58);
            this.label2.TabIndex = 9;
            this.label2.Text = "Menù:";
            // 
            // View_Gifts
            // 
            this.View_Gifts.BackColor = System.Drawing.Color.Chocolate;
            this.View_Gifts.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View_Gifts.ForeColor = System.Drawing.Color.White;
            this.View_Gifts.Location = new System.Drawing.Point(506, 162);
            this.View_Gifts.Name = "View_Gifts";
            this.View_Gifts.Size = new System.Drawing.Size(260, 115);
            this.View_Gifts.TabIndex = 10;
            this.View_Gifts.Text = "REGALI";
            this.View_Gifts.UseVisualStyleBackColor = false;
            this.View_Gifts.Click += new System.EventHandler(this.View_Gifts_Click);
            // 
            // Impostazioni_Profilo
            // 
            this.Impostazioni_Profilo.BackColor = System.Drawing.Color.Chocolate;
            this.Impostazioni_Profilo.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Impostazioni_Profilo.ForeColor = System.Drawing.Color.White;
            this.Impostazioni_Profilo.Location = new System.Drawing.Point(258, 351);
            this.Impostazioni_Profilo.Name = "Impostazioni_Profilo";
            this.Impostazioni_Profilo.Size = new System.Drawing.Size(260, 115);
            this.Impostazioni_Profilo.TabIndex = 11;
            this.Impostazioni_Profilo.Text = "IMPOSTAZIONI PROFILO";
            this.Impostazioni_Profilo.UseVisualStyleBackColor = false;
            this.Impostazioni_Profilo.Click += new System.EventHandler(this.Impostazioni_Profilo_Click);
            // 
            // Azioni_Elfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProgettoNatale.Properties.Resources.WhatsApp_Image_2021_12_29_at_21_48_39__1_;
            this.ClientSize = new System.Drawing.Size(797, 490);
            this.Controls.Add(this.Impostazioni_Profilo);
            this.Controls.Add(this.View_Gifts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.View_Kids);
            this.Name = "Azioni_Elfo";
            this.Text = "Azioni_Elfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button View_Kids;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button View_Gifts;
        private System.Windows.Forms.Button Impostazioni_Profilo;
    }
}