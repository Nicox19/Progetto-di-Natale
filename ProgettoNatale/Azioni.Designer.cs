﻿
namespace ProgettoNatale
{
    partial class Azioni
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
            this.View_Kids = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.View_Gifts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // View_Kids
            // 
            this.View_Kids.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View_Kids.Location = new System.Drawing.Point(25, 128);
            this.View_Kids.Name = "View_Kids";
            this.View_Kids.Size = new System.Drawing.Size(260, 115);
            this.View_Kids.TabIndex = 0;
            this.View_Kids.Text = "VISUALIZZA BAMBINI";
            this.View_Kids.UseVisualStyleBackColor = true;
            this.View_Kids.Click += new System.EventHandler(this.View_Kids_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(770, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUESTE SONO LE TUE AZIONI DISPONIBILI";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(526, 128);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(260, 115);
            this.Search.TabIndex = 2;
            this.Search.Text = "RICERCA";
            this.Search.UseVisualStyleBackColor = true;
            // 
            // View_Gifts
            // 
            this.View_Gifts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View_Gifts.ForeColor = System.Drawing.SystemColors.ControlText;
            this.View_Gifts.Location = new System.Drawing.Point(25, 323);
            this.View_Gifts.Name = "View_Gifts";
            this.View_Gifts.Size = new System.Drawing.Size(260, 115);
            this.View_Gifts.TabIndex = 3;
            this.View_Gifts.Text = "VISUALIZZA REGALI";
            this.View_Gifts.UseVisualStyleBackColor = true;
            // 
            // Azioni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProgettoNatale.Properties.Resources.Sfondo_Azioni;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.View_Gifts);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.View_Kids);
            this.Name = "Azioni";
            this.Text = "Azioni";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button View_Kids;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button View_Gifts;
    }
}