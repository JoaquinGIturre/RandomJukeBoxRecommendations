﻿namespace Proyecto1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAlbum = new System.Windows.Forms.Button();
            this.btnEncendido = new System.Windows.Forms.Button();
            this.btnGeneros = new System.Windows.Forms.Button();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.lblAlbum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAlbum
            // 
            this.btnAlbum.BackColor = System.Drawing.Color.IndianRed;
            this.btnAlbum.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAlbum.BackgroundImage")));
            this.btnAlbum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAlbum.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlbum.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlbum.ForeColor = System.Drawing.Color.Black;
            this.btnAlbum.Location = new System.Drawing.Point(548, 362);
            this.btnAlbum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAlbum.Name = "btnAlbum";
            this.btnAlbum.Size = new System.Drawing.Size(95, 31);
            this.btnAlbum.TabIndex = 0;
            this.btnAlbum.Text = "Álbum";
            this.btnAlbum.UseVisualStyleBackColor = false;
            this.btnAlbum.Click += new System.EventHandler(this.btnAlbum_Click);
            // 
            // btnEncendido
            // 
            this.btnEncendido.BackColor = System.Drawing.Color.IndianRed;
            this.btnEncendido.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEncendido.BackgroundImage")));
            this.btnEncendido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEncendido.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnEncendido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEncendido.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncendido.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEncendido.Location = new System.Drawing.Point(426, 222);
            this.btnEncendido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEncendido.Name = "btnEncendido";
            this.btnEncendido.Size = new System.Drawing.Size(86, 27);
            this.btnEncendido.TabIndex = 2;
            this.btnEncendido.Text = "ON";
            this.btnEncendido.UseVisualStyleBackColor = false;
            this.btnEncendido.Click += new System.EventHandler(this.btnEncendido_Click);
            // 
            // btnGeneros
            // 
            this.btnGeneros.BackColor = System.Drawing.Color.IndianRed;
            this.btnGeneros.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGeneros.BackgroundImage")));
            this.btnGeneros.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGeneros.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneros.ForeColor = System.Drawing.Color.Black;
            this.btnGeneros.Location = new System.Drawing.Point(296, 362);
            this.btnGeneros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGeneros.Name = "btnGeneros";
            this.btnGeneros.Size = new System.Drawing.Size(93, 31);
            this.btnGeneros.TabIndex = 3;
            this.btnGeneros.Text = "Géneros";
            this.btnGeneros.UseVisualStyleBackColor = false;
            this.btnGeneros.Click += new System.EventHandler(this.btnGeneros_Click);
            // 
            // cmbGenero
            // 
            this.cmbGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(92)))), ((int)(((byte)(185)))));
            this.cmbGenero.Cursor = System.Windows.Forms.Cursors.Cross;
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero.DropDownWidth = 100;
            this.cmbGenero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbGenero.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGenero.ForeColor = System.Drawing.Color.Lavender;
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbGenero.Location = new System.Drawing.Point(408, 409);
            this.cmbGenero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(122, 32);
            this.cmbGenero.TabIndex = 4;
            this.cmbGenero.Visible = false;
            this.cmbGenero.SelectedIndexChanged += new System.EventHandler(this.cmbGenero_SelectedIndexChanged);
            this.cmbGenero.SelectionChangeCommitted += new System.EventHandler(this.cmbGenero_SelectionChangeCommitted);
            // 
            // lblAlbum
            // 
            this.lblAlbum.AutoSize = true;
            this.lblAlbum.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlbum.Location = new System.Drawing.Point(331, 9);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(246, 31);
            this.lblAlbum.TabIndex = 5;
            this.lblAlbum.Text = "Album seleccionado";
            this.lblAlbum.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(938, 744);
            this.Controls.Add(this.lblAlbum);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.btnGeneros);
            this.Controls.Add(this.btnEncendido);
            this.Controls.Add(this.btnAlbum);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(956, 791);
            this.MinimumSize = new System.Drawing.Size(956, 791);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Random Juke Box Recommendations";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlbum;
        private System.Windows.Forms.Button btnEncendido;
        private System.Windows.Forms.Button btnGeneros;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.Label lblAlbum;
    }
}

