using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace GDI_LocalTransformation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Paint += Form1_Paint;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            using (Graphics graphics = e.Graphics)
            {
                //Создадим путь
                GraphicsPath path = new GraphicsPath();
                path.AddLine(20, 20, 200, 50);
                path.AddArc(50, 50, 100, 50, 10, -200);
                Matrix matrix = new Matrix();
                //Применяем вращение
                matrix.Rotate(40);
                //применяем преобразование
                path.Transform(matrix);
                //Визуализируем путь
                graphics.DrawPath(new Pen(Color.Green, 6), path);
                //Освобождение ресурса
            }
        }
    }
}