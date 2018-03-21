namespace GroupingRadioButtons
{
    partial class frmRadiogrp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRadiogrp));
            this.GrbWeather = new System.Windows.Forms.GroupBox();
            this.RdoSnow = new System.Windows.Forms.RadioButton();
            this.RdoSun = new System.Windows.Forms.RadioButton();
            this.RdoRain = new System.Windows.Forms.RadioButton();
            this.GrbCountry = new System.Windows.Forms.GroupBox();
            this.RdoUk = new System.Windows.Forms.RadioButton();
            this.RdoItaly = new System.Windows.Forms.RadioButton();
            this.RdoCanada = new System.Windows.Forms.RadioButton();
            this.LblTitle = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Button();
            this.PicRain = new System.Windows.Forms.PictureBox();
            this.PicSun = new System.Windows.Forms.PictureBox();
            this.PicSnow = new System.Windows.Forms.PictureBox();
            this.PicCanada = new System.Windows.Forms.PictureBox();
            this.PicItaly = new System.Windows.Forms.PictureBox();
            this.PicUk = new System.Windows.Forms.PictureBox();
            this.GrbWeather.SuspendLayout();
            this.GrbCountry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicRain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSnow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCanada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicItaly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicUk)).BeginInit();
            this.SuspendLayout();
            // 
            // GrbWeather
            // 
            this.GrbWeather.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GrbWeather.Controls.Add(this.RdoSnow);
            this.GrbWeather.Controls.Add(this.RdoSun);
            this.GrbWeather.Controls.Add(this.RdoRain);
            this.GrbWeather.Location = new System.Drawing.Point(56, 47);
            this.GrbWeather.Name = "GrbWeather";
            this.GrbWeather.Size = new System.Drawing.Size(148, 172);
            this.GrbWeather.TabIndex = 0;
            this.GrbWeather.TabStop = false;
            this.GrbWeather.Text = "Weather";
            // 
            // RdoSnow
            // 
            this.RdoSnow.AutoSize = true;
            this.RdoSnow.Location = new System.Drawing.Point(21, 137);
            this.RdoSnow.Name = "RdoSnow";
            this.RdoSnow.Size = new System.Drawing.Size(52, 17);
            this.RdoSnow.TabIndex = 2;
            this.RdoSnow.TabStop = true;
            this.RdoSnow.Text = "Snow";
            this.RdoSnow.UseVisualStyleBackColor = true;
            this.RdoSnow.CheckedChanged += new System.EventHandler(this.RdoSnow_CheckedChanged);
            // 
            // RdoSun
            // 
            this.RdoSun.AutoSize = true;
            this.RdoSun.Location = new System.Drawing.Point(21, 82);
            this.RdoSun.Name = "RdoSun";
            this.RdoSun.Size = new System.Drawing.Size(44, 17);
            this.RdoSun.TabIndex = 1;
            this.RdoSun.TabStop = true;
            this.RdoSun.Text = "Sun";
            this.RdoSun.UseVisualStyleBackColor = true;
            this.RdoSun.CheckedChanged += new System.EventHandler(this.RdoSun_CheckedChanged);
            // 
            // RdoRain
            // 
            this.RdoRain.AutoSize = true;
            this.RdoRain.Location = new System.Drawing.Point(21, 40);
            this.RdoRain.Name = "RdoRain";
            this.RdoRain.Size = new System.Drawing.Size(47, 17);
            this.RdoRain.TabIndex = 0;
            this.RdoRain.TabStop = true;
            this.RdoRain.Text = "Rain";
            this.RdoRain.UseVisualStyleBackColor = true;
            this.RdoRain.CheckedChanged += new System.EventHandler(this.RdoRain_CheckedChanged);
            // 
            // GrbCountry
            // 
            this.GrbCountry.Controls.Add(this.RdoUk);
            this.GrbCountry.Controls.Add(this.RdoItaly);
            this.GrbCountry.Controls.Add(this.RdoCanada);
            this.GrbCountry.Location = new System.Drawing.Point(328, 47);
            this.GrbCountry.Name = "GrbCountry";
            this.GrbCountry.Size = new System.Drawing.Size(139, 172);
            this.GrbCountry.TabIndex = 1;
            this.GrbCountry.TabStop = false;
            this.GrbCountry.Text = "Country";
            // 
            // RdoUk
            // 
            this.RdoUk.AutoSize = true;
            this.RdoUk.Location = new System.Drawing.Point(22, 137);
            this.RdoUk.Name = "RdoUk";
            this.RdoUk.Size = new System.Drawing.Size(40, 17);
            this.RdoUk.TabIndex = 2;
            this.RdoUk.TabStop = true;
            this.RdoUk.Text = "UK";
            this.RdoUk.UseVisualStyleBackColor = true;
            this.RdoUk.CheckedChanged += new System.EventHandler(this.RdoUk_CheckedChanged);
            // 
            // RdoItaly
            // 
            this.RdoItaly.AutoSize = true;
            this.RdoItaly.Location = new System.Drawing.Point(22, 82);
            this.RdoItaly.Name = "RdoItaly";
            this.RdoItaly.Size = new System.Drawing.Size(44, 17);
            this.RdoItaly.TabIndex = 1;
            this.RdoItaly.TabStop = true;
            this.RdoItaly.Text = "Italy";
            this.RdoItaly.UseVisualStyleBackColor = true;
            this.RdoItaly.CheckedChanged += new System.EventHandler(this.RdoItaly_CheckedChanged);
            // 
            // RdoCanada
            // 
            this.RdoCanada.AutoSize = true;
            this.RdoCanada.Location = new System.Drawing.Point(22, 40);
            this.RdoCanada.Name = "RdoCanada";
            this.RdoCanada.Size = new System.Drawing.Size(62, 17);
            this.RdoCanada.TabIndex = 0;
            this.RdoCanada.TabStop = true;
            this.RdoCanada.Text = "Canada";
            this.RdoCanada.UseVisualStyleBackColor = true;
            this.RdoCanada.CheckedChanged += new System.EventHandler(this.RdoCanada_CheckedChanged);
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(1, 9);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(552, 16);
            this.LblTitle.TabIndex = 2;
            this.LblTitle.Text = "Chose one button from the weather group and one button from the country group";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BtnExit
            // 
            this.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnExit.Location = new System.Drawing.Point(204, 248);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(124, 37);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // PicRain
            // 
            this.PicRain.Image = ((System.Drawing.Image)(resources.GetObject("PicRain.Image")));
            this.PicRain.Location = new System.Drawing.Point(236, 56);
            this.PicRain.Name = "PicRain";
            this.PicRain.Size = new System.Drawing.Size(60, 38);
            this.PicRain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicRain.TabIndex = 4;
            this.PicRain.TabStop = false;
            this.PicRain.Visible = false;
            // 
            // PicSun
            // 
            this.PicSun.Image = ((System.Drawing.Image)(resources.GetObject("PicSun.Image")));
            this.PicSun.Location = new System.Drawing.Point(237, 120);
            this.PicSun.Name = "PicSun";
            this.PicSun.Size = new System.Drawing.Size(59, 38);
            this.PicSun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicSun.TabIndex = 5;
            this.PicSun.TabStop = false;
            this.PicSun.Visible = false;
            // 
            // PicSnow
            // 
            this.PicSnow.Image = ((System.Drawing.Image)(resources.GetObject("PicSnow.Image")));
            this.PicSnow.Location = new System.Drawing.Point(236, 182);
            this.PicSnow.Name = "PicSnow";
            this.PicSnow.Size = new System.Drawing.Size(59, 37);
            this.PicSnow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicSnow.TabIndex = 6;
            this.PicSnow.TabStop = false;
            this.PicSnow.Visible = false;
            // 
            // PicCanada
            // 
            this.PicCanada.Image = ((System.Drawing.Image)(resources.GetObject("PicCanada.Image")));
            this.PicCanada.Location = new System.Drawing.Point(480, 56);
            this.PicCanada.Name = "PicCanada";
            this.PicCanada.Size = new System.Drawing.Size(66, 37);
            this.PicCanada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicCanada.TabIndex = 7;
            this.PicCanada.TabStop = false;
            this.PicCanada.Visible = false;
            // 
            // PicItaly
            // 
            this.PicItaly.Image = ((System.Drawing.Image)(resources.GetObject("PicItaly.Image")));
            this.PicItaly.Location = new System.Drawing.Point(480, 117);
            this.PicItaly.Name = "PicItaly";
            this.PicItaly.Size = new System.Drawing.Size(65, 40);
            this.PicItaly.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicItaly.TabIndex = 8;
            this.PicItaly.TabStop = false;
            this.PicItaly.Visible = false;
            // 
            // PicUk
            // 
            this.PicUk.Image = ((System.Drawing.Image)(resources.GetObject("PicUk.Image")));
            this.PicUk.Location = new System.Drawing.Point(480, 184);
            this.PicUk.Name = "PicUk";
            this.PicUk.Size = new System.Drawing.Size(65, 34);
            this.PicUk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicUk.TabIndex = 9;
            this.PicUk.TabStop = false;
            this.PicUk.Visible = false;
            // 
            // frmRadiogrp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 298);
            this.Controls.Add(this.PicUk);
            this.Controls.Add(this.PicItaly);
            this.Controls.Add(this.PicCanada);
            this.Controls.Add(this.PicSnow);
            this.Controls.Add(this.PicSun);
            this.Controls.Add(this.PicRain);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.GrbCountry);
            this.Controls.Add(this.GrbWeather);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmRadiogrp";
            this.Text = "Grouping Radio Buttons";
            this.GrbWeather.ResumeLayout(false);
            this.GrbWeather.PerformLayout();
            this.GrbCountry.ResumeLayout(false);
            this.GrbCountry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicRain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSnow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCanada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicItaly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicUk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GrbWeather;
        private System.Windows.Forms.RadioButton RdoSnow;
        private System.Windows.Forms.RadioButton RdoSun;
        private System.Windows.Forms.RadioButton RdoRain;
        private System.Windows.Forms.GroupBox GrbCountry;
        private System.Windows.Forms.RadioButton RdoUk;
        private System.Windows.Forms.RadioButton RdoItaly;
        private System.Windows.Forms.RadioButton RdoCanada;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.PictureBox PicRain;
        private System.Windows.Forms.PictureBox PicSun;
        private System.Windows.Forms.PictureBox PicSnow;
        private System.Windows.Forms.PictureBox PicCanada;
        private System.Windows.Forms.PictureBox PicItaly;
        private System.Windows.Forms.PictureBox PicUk;
    }
}

