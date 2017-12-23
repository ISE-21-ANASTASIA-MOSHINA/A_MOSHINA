namespace Laba2
{
    partial class Form2
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
            this.labelAirvehical = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelColor = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panelColor = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelGray = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelGold = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelUFO = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAirvehical
            // 
            this.labelAirvehical.AutoSize = true;
            this.labelAirvehical.Location = new System.Drawing.Point(523, 158);
            this.labelAirvehical.Name = "labelAirvehical";
            this.labelAirvehical.Size = new System.Drawing.Size(59, 13);
            this.labelAirvehical.TabIndex = 2;
            this.labelAirvehical.Text = "AIRvehicle";
            this.labelAirvehical.Click += new System.EventHandler(this.labelAirvehical_Click);
            this.labelAirvehical.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelAirVeh_DragDrop);
            this.labelAirvehical.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelAirVeh_DragEnter);
            this.labelAirvehical.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelAirveh_MouseDown);
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(10, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 406);
            this.panel1.TabIndex = 3;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelAirvehicle_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelAirvehicle_DragEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(458, 380);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelColor
            // 
            this.labelColor.AllowDrop = true;
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(523, 32);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(83, 13);
            this.labelColor.TabIndex = 4;
            this.labelColor.Text = "Основной цвет";
            this.labelColor.Click += new System.EventHandler(this.Airvehicle_Click);
            this.labelColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelColor_DragDrop);
            this.labelColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelColor_DragEnter);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(705, 150);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(115, 41);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // panelColor
            // 
            this.panelColor.Controls.Add(this.panelGreen);
            this.panelColor.Controls.Add(this.panelGray);
            this.panelColor.Controls.Add(this.panelRed);
            this.panelColor.Controls.Add(this.panelWhite);
            this.panelColor.Controls.Add(this.panelYellow);
            this.panelColor.Controls.Add(this.panelBlue);
            this.panelColor.Controls.Add(this.panelGold);
            this.panelColor.Controls.Add(this.panelBlack);
            this.panelColor.Location = new System.Drawing.Point(644, 22);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(207, 108);
            this.panelColor.TabIndex = 6;
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Green;
            this.panelGreen.Location = new System.Drawing.Point(155, 65);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(32, 28);
            this.panelGreen.TabIndex = 7;
            // 
            // panelGray
            // 
            this.panelGray.BackColor = System.Drawing.Color.Gray;
            this.panelGray.Location = new System.Drawing.Point(106, 64);
            this.panelGray.Name = "panelGray";
            this.panelGray.Size = new System.Drawing.Size(34, 30);
            this.panelGray.TabIndex = 6;
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(61, 64);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(28, 30);
            this.panelRed.TabIndex = 5;
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.Location = new System.Drawing.Point(16, 64);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(31, 30);
            this.panelWhite.TabIndex = 4;
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.Location = new System.Drawing.Point(151, 21);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(37, 27);
            this.panelYellow.TabIndex = 3;
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.Location = new System.Drawing.Point(106, 21);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(34, 27);
            this.panelBlue.TabIndex = 2;
            // 
            // panelGold
            // 
            this.panelGold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelGold.Location = new System.Drawing.Point(61, 21);
            this.panelGold.Name = "panelGold";
            this.panelGold.Size = new System.Drawing.Size(28, 27);
            this.panelGold.TabIndex = 1;
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.Location = new System.Drawing.Point(16, 21);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(31, 28);
            this.panelBlack.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(706, 203);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(113, 42);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelUFO
            // 
            this.labelUFO.AutoSize = true;
            this.labelUFO.Location = new System.Drawing.Point(523, 178);
            this.labelUFO.Name = "labelUFO";
            this.labelUFO.Size = new System.Drawing.Size(29, 13);
            this.labelUFO.TabIndex = 8;
            this.labelUFO.Text = "UFO";
            this.labelUFO.Click += new System.EventHandler(this.labelUFO_Click);
            this.labelUFO.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelUFO_MouseDown);
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(517, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Дополнительный цвет";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            this.label1.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.label1.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragEnter);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 418);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelUFO);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.panelColor);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelAirvehical);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelColor.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelAirvehical;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.Panel panelGold;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelGray;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelUFO;
        private System.Windows.Forms.Label label1;
    }
}