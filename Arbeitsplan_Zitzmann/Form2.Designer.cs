﻿namespace Arbeitsplan_Zitzmann
{
    partial class Arbeitsplan_Tabelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Arbeitsplan_Tabelle));
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.save_button = new System.Windows.Forms.Button();
            this.calc_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1062, 731);
            this.dataGridView1.TabIndex = 1;
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(1080, 12);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(153, 51);
            this.save_button.TabIndex = 2;
            this.save_button.Text = "Speichern";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // calc_button
            // 
            this.calc_button.Location = new System.Drawing.Point(1080, 79);
            this.calc_button.Name = "calc_button";
            this.calc_button.Size = new System.Drawing.Size(153, 51);
            this.calc_button.TabIndex = 3;
            this.calc_button.Text = "Tabelle auswerten";
            this.calc_button.UseVisualStyleBackColor = true;
            this.calc_button.Click += new System.EventHandler(this.calc_button_Click);
            // 
            // Arbeitsplan_Tabelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 802);
            this.Controls.Add(this.calc_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Arbeitsplan_Tabelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arbeitsplan von X";
            this.Load += new System.EventHandler(this.Arbeitsplan_Tabelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button calc_button;
    }
}