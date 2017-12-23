namespace Laba2
{
    partial class Form1
    {
        /// <summary> 
        /// Обязательная переменная конструктора. 
        /// </summary> 
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы. 
        /// </summary> 
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param> 
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows 

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода. 
        /// </summary> 
        private void InitializeComponent()
        {
            this.pictureBoxDraw = new System.Windows.Forms.PictureBox();
            this.buttonSelectColor = new System.Windows.Forms.Button();
            this.buttonSelectDopColor = new System.Windows.Forms.Button();
            this.textBoxMaxSpeed = new System.Windows.Forms.TextBox();
            this.textBoxMaxCountPassenget = new System.Windows.Forms.TextBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.checkBoxFar = new System.Windows.Forms.CheckBox();
            this.checkBoxAntenna = new System.Windows.Forms.CheckBox();
            this.checkBoxHatch = new System.Windows.Forms.CheckBox();
            this.buttonSetAuto = new System.Windows.Forms.Button();
            this.buttonSetBadUFO = new System.Windows.Forms.Button();
            this.buttonSetUFO = new System.Windows.Forms.Button();
            this.buttonMove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDraw)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxDraw
            // 
            this.pictureBoxDraw.InitialImage = null;
            this.pictureBoxDraw.Location = new System.Drawing.Point(0, -1);
            this.pictureBoxDraw.Name = "pictureBoxDraw";
            this.pictureBoxDraw.Size = new System.Drawing.Size(847, 305);
            this.pictureBoxDraw.TabIndex = 0;
            this.pictureBoxDraw.TabStop = false;
            // 
            // buttonSelectColor
            // 
            this.buttonSelectColor.Location = new System.Drawing.Point(267, 394);
            this.buttonSelectColor.Name = "buttonSelectColor";
            this.buttonSelectColor.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectColor.TabIndex = 1;
            this.buttonSelectColor.Text = "Цвет";
            this.buttonSelectColor.UseVisualStyleBackColor = true;
            this.buttonSelectColor.Click += new System.EventHandler(this.buttonSelectColor_Click);
            // 
            // buttonSelectDopColor
            // 
            this.buttonSelectDopColor.Location = new System.Drawing.Point(487, 394);
            this.buttonSelectDopColor.Name = "buttonSelectDopColor";
            this.buttonSelectDopColor.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectDopColor.TabIndex = 2;
            this.buttonSelectDopColor.Text = "Цвет";
            this.buttonSelectDopColor.UseVisualStyleBackColor = true;
            this.buttonSelectDopColor.Click += new System.EventHandler(this.buttonSelectDopColor_Click);
            // 
            // textBoxMaxSpeed
            // 
            this.textBoxMaxSpeed.Location = new System.Drawing.Point(95, 310);
            this.textBoxMaxSpeed.Name = "textBoxMaxSpeed";
            this.textBoxMaxSpeed.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaxSpeed.TabIndex = 3;
            // 
            // textBoxMaxCountPassenget
            // 
            this.textBoxMaxCountPassenget.Location = new System.Drawing.Point(159, 346);
            this.textBoxMaxCountPassenget.Name = "textBoxMaxCountPassenget";
            this.textBoxMaxCountPassenget.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaxCountPassenget.TabIndex = 4;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(45, 369);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(100, 20);
            this.textBoxWeight.TabIndex = 5;
            // 
            // checkBoxFar
            // 
            this.checkBoxFar.AutoSize = true;
            this.checkBoxFar.Location = new System.Drawing.Point(379, 313);
            this.checkBoxFar.Name = "checkBoxFar";
            this.checkBoxFar.Size = new System.Drawing.Size(57, 17);
            this.checkBoxFar.TabIndex = 6;
            this.checkBoxFar.Text = "Фары";
            this.checkBoxFar.UseVisualStyleBackColor = true;
            // 
            // checkBoxAntenna
            // 
            this.checkBoxAntenna.AutoSize = true;
            this.checkBoxAntenna.Location = new System.Drawing.Point(379, 345);
            this.checkBoxAntenna.Name = "checkBoxAntenna";
            this.checkBoxAntenna.Size = new System.Drawing.Size(68, 17);
            this.checkBoxAntenna.TabIndex = 7;
            this.checkBoxAntenna.Text = "Антенна";
            this.checkBoxAntenna.UseVisualStyleBackColor = true;
            // 
            // checkBoxHatch
            // 
            this.checkBoxHatch.AutoSize = true;
            this.checkBoxHatch.Location = new System.Drawing.Point(379, 376);
            this.checkBoxHatch.Name = "checkBoxHatch";
            this.checkBoxHatch.Size = new System.Drawing.Size(48, 17);
            this.checkBoxHatch.TabIndex = 8;
            this.checkBoxHatch.Text = "Люк";
            this.checkBoxHatch.UseVisualStyleBackColor = true;
            // 
            // buttonSetAuto
            // 
            this.buttonSetAuto.Location = new System.Drawing.Point(882, 24);
            this.buttonSetAuto.Name = "buttonSetAuto";
            this.buttonSetAuto.Size = new System.Drawing.Size(127, 41);
            this.buttonSetAuto.TabIndex = 9;
            this.buttonSetAuto.Text = "летательный аппарат";
            this.buttonSetAuto.UseVisualStyleBackColor = true;
            this.buttonSetAuto.Click += new System.EventHandler(this.buttonSetAuto_Click);
            // 
            // buttonSetBadUFO
            // 
            this.buttonSetBadUFO.Location = new System.Drawing.Point(0, 0);
            this.buttonSetBadUFO.Name = "buttonSetBadUFO";
            this.buttonSetBadUFO.Size = new System.Drawing.Size(75, 23);
            this.buttonSetBadUFO.TabIndex = 16;
            // 
            // buttonSetUFO
            // 
            this.buttonSetUFO.Location = new System.Drawing.Point(882, 87);
            this.buttonSetUFO.Name = "buttonSetUFO";
            this.buttonSetUFO.Size = new System.Drawing.Size(127, 38);
            this.buttonSetUFO.TabIndex = 11;
            this.buttonSetUFO.Text = "летающая тарелка";
            this.buttonSetUFO.UseVisualStyleBackColor = true;
            this.buttonSetUFO.Click += new System.EventHandler(this.buttonSetUFO_Click_1);
            // 
            // buttonMove
            // 
            this.buttonMove.Location = new System.Drawing.Point(882, 225);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(127, 43);
            this.buttonMove.TabIndex = 12;
            this.buttonMove.Text = "Движение";
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Max скорость";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Max кол-во пассажиров";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Вес";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 428);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonMove);
            this.Controls.Add(this.buttonSetUFO);
            this.Controls.Add(this.buttonSetBadUFO);
            this.Controls.Add(this.buttonSetAuto);
            this.Controls.Add(this.checkBoxHatch);
            this.Controls.Add(this.checkBoxAntenna);
            this.Controls.Add(this.checkBoxFar);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.textBoxMaxCountPassenget);
            this.Controls.Add(this.textBoxMaxSpeed);
            this.Controls.Add(this.buttonSelectDopColor);
            this.Controls.Add(this.buttonSelectColor);
            this.Controls.Add(this.pictureBoxDraw);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDraw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDraw;
        private System.Windows.Forms.Button buttonSelectColor;
        private System.Windows.Forms.Button buttonSelectDopColor;
        private System.Windows.Forms.TextBox textBoxMaxSpeed;
        private System.Windows.Forms.TextBox textBoxMaxCountPassenget;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.CheckBox checkBoxFar;
        private System.Windows.Forms.CheckBox checkBoxAntenna;
        private System.Windows.Forms.CheckBox checkBoxHatch;
        private System.Windows.Forms.Button buttonSetAuto;
        private System.Windows.Forms.Button buttonSetBadUFO;
        private System.Windows.Forms.Button buttonSetUFO;
        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }

}


