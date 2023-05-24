
namespace Laba_Testing
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label = new System.Windows.Forms.Label();
            this.textBoxRadius = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.labelWarningRadius = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelArea = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNumCorners = new System.Windows.Forms.TextBox();
            this.labelWarningCorners = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(450, 17);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox.MinimumSize = new System.Drawing.Size(350, 350);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(350, 350);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.SizeChanged += new System.EventHandler(this.pictureBox_SizeChanged);
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            this.pictureBox.Resize += new System.EventHandler(this.pictureBox_Resize);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(14, 5);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(399, 20);
            this.label.TabIndex = 1;
            this.label.Text = "Введите радиус окружности (в см, но не более 10!):";
            // 
            // textBoxRadius
            // 
            this.textBoxRadius.Location = new System.Drawing.Point(14, 28);
            this.textBoxRadius.Name = "textBoxRadius";
            this.textBoxRadius.Size = new System.Drawing.Size(395, 26);
            this.textBoxRadius.TabIndex = 2;
            this.textBoxRadius.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRadius_KeyPress);
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.button.Location = new System.Drawing.Point(83, 316);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(261, 73);
            this.button.TabIndex = 3;
            this.button.Text = "Построить фигуру";
            this.button.UseVisualStyleBackColor = false;
            this.button.UseWaitCursor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // labelWarningRadius
            // 
            this.labelWarningRadius.AutoSize = true;
            this.labelWarningRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWarningRadius.ForeColor = System.Drawing.Color.DarkRed;
            this.labelWarningRadius.Location = new System.Drawing.Point(60, 57);
            this.labelWarningRadius.MaximumSize = new System.Drawing.Size(400, 0);
            this.labelWarningRadius.Name = "labelWarningRadius";
            this.labelWarningRadius.Size = new System.Drawing.Size(312, 44);
            this.labelWarningRadius.TabIndex = 4;
            this.labelWarningRadius.Text = "Допускается ввод только целых неотрицательных чисел";
            this.labelWarningRadius.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 419);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Площадь заштрихованной фигуры:";
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelArea.Location = new System.Drawing.Point(316, 419);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(39, 20);
            this.labelArea.TabIndex = 6;
            this.labelArea.Text = "???";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(371, 419);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "см2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(387, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Введите количество лучей у звезды ( от 3 до 10):";
            // 
            // textBoxNumCorners
            // 
            this.textBoxNumCorners.Location = new System.Drawing.Point(18, 187);
            this.textBoxNumCorners.Name = "textBoxNumCorners";
            this.textBoxNumCorners.Size = new System.Drawing.Size(395, 26);
            this.textBoxNumCorners.TabIndex = 9;
            this.textBoxNumCorners.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumCorners_KeyPress);
            // 
            // labelWarningCorners
            // 
            this.labelWarningCorners.AutoSize = true;
            this.labelWarningCorners.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWarningCorners.ForeColor = System.Drawing.Color.DarkRed;
            this.labelWarningCorners.Location = new System.Drawing.Point(60, 216);
            this.labelWarningCorners.MaximumSize = new System.Drawing.Size(400, 0);
            this.labelWarningCorners.Name = "labelWarningCorners";
            this.labelWarningCorners.Size = new System.Drawing.Size(312, 44);
            this.labelWarningCorners.TabIndex = 10;
            this.labelWarningCorners.Text = "Допускается ввод только целых неотрицательных чисел";
            this.labelWarningCorners.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxNumCorners);
            this.panel1.Controls.Add(this.labelWarningCorners);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.textBoxRadius);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labelWarningRadius);
            this.panel1.Controls.Add(this.labelArea);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 487);
            this.panel1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 505);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MinimumSize = new System.Drawing.Size(830, 560);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "Лабораторная работа по тестированию";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textBoxRadius;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label labelWarningRadius;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelArea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNumCorners;
        private System.Windows.Forms.Label labelWarningCorners;
        private System.Windows.Forms.Panel panel1;
    }
}

