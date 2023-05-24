using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_Testing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DrawStarInCircle(pictureBox, 1*50, 5);
        }

        private void DrawStarInCircle(PictureBox pictureBox, int radius, int numCorners)
        {
            Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);

            pictureBox.Width = radius * 2 + 40;
            pictureBox.Height = pictureBox.Width;

            using (Graphics g = Graphics.FromImage(bmp))
            {
                // Очистить pictureBox
                g.Clear(Color.White);

                // вычисляем координаты центра окружности
                int centerX = pictureBox.Width / 2;
                int centerY = pictureBox.Height / 2;

                // создаем массив точек для построения звезды
                PointF[] starPoints = new PointF[2 * numCorners];
                double angle = 0;
                double rCurr = 0;
                for (int i = 0; i < 2 * numCorners; i++)
                {
                    angle = Math.PI / numCorners * i;
                    rCurr = i % 2 == 0 ? radius : 0.4 * radius;
                    starPoints[i] = new PointF(
                        (float)(centerX + rCurr * Math.Sin(angle)),
                        (float)(centerY - rCurr * Math.Cos(angle)));
                }
                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddPolygon(starPoints);
                    path.AddEllipse(centerX - radius, centerY - radius, 2 * radius, 2 * radius);
                    using (HatchBrush brush = new HatchBrush(HatchStyle.BackwardDiagonal, Color.Red, Color.Transparent))
                    {
                        g.FillPath(brush, path);
                        g.DrawPath(Pens.Black, path);
                    }
                }

                // Нарисовать звезду
                g.DrawPolygon(Pens.Black, starPoints);

                // Нарисовать окружность
                g.DrawEllipse(Pens.Red, centerX - radius, centerY - radius, 2 * radius, 2 * radius);
            }

            pictureBox.Image = bmp;
            // Отобразить изображение в pictureBox

            labelArea.Text = FindAreaFigure(radius, numCorners).ToString();

        }

        private double FindAreaFigure(int radius, int numCorners)
        {
            double starArea = 0;
            double circleArea = 0;
            double angle = 2 * Math.PI / numCorners;
            double radiusStar = radius * 0.4;
            double side = 2 * radius * Math.Sin(angle / 2);
            double p = 3 * side / 2;
            starArea = numCorners * (Math.Sqrt(p * Math.Pow((p - side), 3)) - Math.Pow(side, 2));

            circleArea = Math.PI * Math.Pow(radius, 2);

            double area = Math.Round((circleArea - starArea) / (50*50), 2);

            return area;
        }

        private void button_Click(object sender, EventArgs e)
        {
            List<String> values = GetValues();
            int radius = int.Parse(values[0]) * 50;
            int numCorners = int.Parse(values[1]);
            DrawStarInCircle(pictureBox, radius, numCorners);
        }

        private List<String> GetValues()
        {
            List <String> values = new List<String>(2) { "1", "5" };
            this.textBoxRadius.KeyPress += new KeyPressEventHandler(this.textBoxRadius_KeyPress);
            this.textBoxNumCorners.KeyPress += new KeyPressEventHandler(this.textBoxNumCorners_KeyPress);
            String valueRadius = textBoxRadius.Text;
            String valueNumCorners = textBoxNumCorners.Text;

            if ((valueNumCorners == null || valueNumCorners == "" || valueNumCorners == " " || valueNumCorners == "0") && (valueRadius == null || valueRadius == "" || valueRadius == " " || valueRadius == "0"))
            {
                labelWarningRadius.Text = "Вводимое число не должно быть не больше  10, по умолчанию установлен радиус 1";
                labelWarningRadius.Visible = true;
                labelWarningCorners.Text = "Вводимое число должно быть в диапазоне от 3 до 10, по умолчанию установлено 5";
                labelWarningCorners.Visible = true;
                values.Insert(0, "1");
                values.Insert(1, "5");
            }
            else if (valueRadius == null || valueRadius == "" || valueRadius == " ")
            {
                labelWarningRadius.Text = "Вводимое число не должно быть не больше 10, по умолчанию установлен радиус 1";
                labelWarningRadius.Visible = true;
                if (int.Parse(valueNumCorners) <= 10 && int.Parse(valueNumCorners) >= 3)
                { 
                    values.Insert(0, "1");
                    values.Insert(1, valueNumCorners);
                }
                else  
                {
                    labelWarningCorners.Text = "Вводимое число должно быть в диапазоне от 3 до 10, по умолчанию установлено 5";
                    labelWarningCorners.Visible = true;
                    values.Insert(0, "1");
                    values.Insert(1, "5");
                }
            }
            else if (valueNumCorners == "" || valueNumCorners == null || valueRadius == " ")
            {
                labelWarningCorners.Text = "Вводимое число должно быть в диапазоне от 3 до 10, по умолчанию установлено 5";
                labelWarningCorners.Visible = true;
                if (int.Parse(valueRadius) > 10)
                {
                    labelWarningRadius.Text = "Вводимое число не должно быть не больше  10, по умолчанию установлен радиус 1";
                    labelWarningRadius.Visible = true;
                    values.Insert(0, "1");
                    values.Insert(1, "5");
                }
                else
                {
                    values.Insert(0, valueRadius);
                    values.Insert(1, "5");
                }

            } else if (int.Parse(valueNumCorners) <= 10 && int.Parse(valueNumCorners) >= 3)
            {
                if (int.Parse(valueRadius) <= 10)
                {
                    values.Insert(0, valueRadius);
                    values.Insert(1, valueNumCorners);
                } else
                {
                    labelWarningRadius.Text = "Вводимое число не должно быть не больше 10, по умолчанию установлен радиус 1";
                    labelWarningRadius.Visible = true;
                    values.Insert(0, "1");
                    values.Insert(1, valueNumCorners);
                }
            } else if (int.Parse(valueRadius) <= 10)
            {
                if (int.Parse(valueNumCorners) <= 10 && int.Parse(valueNumCorners) >= 3 && int.Parse(valueRadius) > 10)
                {
                    values.Insert(0, valueRadius);
                    values.Insert(1, valueNumCorners);
                } else
                {
                    labelWarningCorners.Text = "Вводимое число должно быть в диапазоне от 3 до 10, по умолчанию установлено 5";
                    labelWarningCorners.Visible = true;
                    values.Insert(0, valueRadius);
                    values.Insert(1, "5");
                }
            }
            else
            {
                labelWarningRadius.Text = "Вводимое число не должно быть не больше 10, по умолчанию установлен радиус 1";
                labelWarningRadius.Visible = true;
                labelWarningCorners.Text = "Вводимое число должно быть в диапазоне от 3 до 10, по умолчанию установлено 5";
                labelWarningCorners.Visible = true;
                values.Insert(0, "1");
                values.Insert(1, "5");
            }
            return values;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            pictureBox.Width = (int)(this.Width - panel1.Width);
            pictureBox.Height = (int)(this.Width - panel1.Width);
            
            DrawStarInCircle(pictureBox, pictureBox.Width/2-30, int.Parse(GetValues()[1]));
        }
        private void textBoxRadius_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b')  // Разрешаем ввод только цифр и символа "Backspace"
            {
                e.Handled = true; // Отменяем ввод символа
                labelWarningRadius.Text = "Допускается ввод только целых неотрицательных чисел";
                labelWarningRadius.Visible = true;
            }
            else
            {
                labelWarningRadius.Visible = false;
            }
        }

        private void textBoxNumCorners_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b')  // Разрешаем ввод только цифр и символа "Backspace"
            {
                e.Handled = true; // Отменяем ввод символа
                labelWarningCorners.Text = "Допускается ввод только целых неотрицательных чисел";
                labelWarningCorners.Visible = true;
            }
            else
            {
                labelWarningCorners.Visible = false;
            }
        }
        private void pictureBox_Resize(object sender, EventArgs e)
        {

        }

        private void pictureBox_SizeChanged(object sender, EventArgs e)
        {

        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
