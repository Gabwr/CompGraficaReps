using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransformacionFiguras
{
    public partial class Formrombo : Form
    {
        public Formrombo()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        rombo figurarombo = new rombo();
        class rombo
        {
            private float diagonalMayor;
            private float diagonalMenor;
            private Point[] points = new Point[4];
            private Point pointCenter;
            private float perimeter;
            private float area;
            private Graphics graph;
            public float originalsizeMayor;
            public float originalsizeMenor;
            private int sz = 1;
            private SolidBrush pen;
            //Constructor sin parametros
            public rombo()
            {
                diagonalMayor = 0.0f; diagonalMenor = 0.0f;
                perimeter = 0.0f; area = 0.0f;
            }

            public void setoriginal(float originalMayor, float originalMenor)
            {
                originalsizeMayor = originalMayor;
                originalsizeMenor = originalMenor;
            }
            public float getoriginalMayor()
            {
                return originalsizeMayor;
            }
            public float getoriginalMenor()
            {
                return originalsizeMenor;
            }

            public void readdata(TextBox txtdmayor, TextBox txtdmenor, PictureBox piccanvas)
            {
                try
                {
                    diagonalMayor = float.Parse(txtdmayor.Text);
                    diagonalMenor = float.Parse(txtdmenor.Text);
                }
                catch
                {
                    MessageBox.Show("Ingreso invalido...", "Mensaje de error");
                }
                pointCenter = new Point((piccanvas.Width / 2), (piccanvas.Height / 2));
                points[0] = new Point(((piccanvas.Width / 2) - (int)diagonalMayor / 2), (piccanvas.Height / 2));
                points[1] = new Point((piccanvas.Width / 2), ((piccanvas.Height / 2) - (int)diagonalMenor / 2));
                points[2] = new Point((piccanvas.Width / 2) + (int)diagonalMayor / 2,  (piccanvas.Height / 2));
                points[3] = new Point((piccanvas.Width / 2) ,  ((piccanvas.Height / 2) + (int)diagonalMenor / 2));

            }

            public void setSize(int size)
            {
                sz = size;
            }

            public void calcularPerimetro()
            {
                perimeter = 2 * (float)Math.Sqrt((float)Math.Pow(diagonalMenor, 2) + (float)Math.Pow(diagonalMayor, 2));

            }

            public void calcularArea()
            {
                area = ( diagonalMayor* diagonalMenor) / 2;
            }

            public void Printdata(TextBox txtperimeter, TextBox txtarea)
            {
                txtarea.Text = perimeter.ToString();
                txtperimeter.Text = area.ToString();
            }

            public void InitializeData(TextBox txtperimeter, TextBox txtarea, TextBox txtheight, TextBox txtwidht, PictureBox piccanvas)

            {
                diagonalMayor = 0.0f; diagonalMenor = 0.0f;
                perimeter = 0.0f; area = 0.0f;

                txtheight.Text = ""; txtarea.Text = "";
                txtperimeter.Text = ""; txtwidht.Text = "";

                txtwidht.Focus();
                piccanvas.Refresh();
            }

            public void PlotShape(PictureBox piccanvas)
            {
                piccanvas.Refresh();
                graph = piccanvas.CreateGraphics();
                pen = new SolidBrush(Color.Green);
                give_size();
                graph.FillPolygon(pen, points);
            }

            public void Close(Form Objform)
            {
                Object obj = Objform;
            }

            public void give_size()
            {
                for (int i = 0; i < points.Length; i++)
                {
                    points[i].X = points[i].X;
                    points[i].Y = points[i].Y;
                }
            }

            public void movepoints(int movement, int opcion)
            {
                switch (opcion)
                {
                    case 1://derecha
                        pointCenter.X = pointCenter.X + movement;
                        for (int i = 0; i < points.Length; i++)
                        {
                            points[i].X = points[i].X + movement;

                        }
                        break;
                    case 2://izquierda
                        pointCenter.X = pointCenter.X - movement;
                        for (int i = 0; i < points.Length; i++)
                        {
                            points[i].X = points[i].X - movement;

                        }
                        break;
                    case 3: //abajo
                        pointCenter.Y = pointCenter.Y + movement;
                        for (int i = 0; i < points.Length; i++)
                        {
                            points[i].Y = points[i].Y + movement;

                        }
                        break;
                    case 4: //arriba
                        pointCenter.Y = pointCenter.Y - movement;
                        for (int i = 0; i < points.Length; i++)
                        {
                            points[i].Y = points[i].Y - movement;

                        }
                        break;
                }

            }

            public void rotar(double anglepl)
            {
                double anglerad = (Math.PI * anglepl) / 180.0;

                for (int i = 0; i < points.Length; i++)
                {
                    int x = points[i].X - pointCenter.X;
                    int y = points[i].Y - pointCenter.Y;

                    double rotatedX = x * Math.Cos(anglerad) - y * Math.Sin(anglerad);
                    double rotatedY = x * Math.Sin(anglerad) + y * Math.Cos(anglerad);

                    points[i].X = (int)Math.Round(rotatedX + pointCenter.X);
                    points[i].Y = (int)Math.Round(rotatedY + pointCenter.Y);
                }
            }

        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            figurarombo.readdata(txtdiagonalmayor, txtdiagonalmenor,picBoxTransformacion);
            figurarombo.setoriginal(float.Parse(txtdiagonalmayor.Text), float.Parse(txtdiagonalmenor.Text));
            figurarombo.calcularArea();
            figurarombo.calcularPerimetro();
            figurarombo.Printdata(txtarea, txtperimetro);
            tBar.Value = 1;
            figurarombo.PlotShape(picBoxTransformacion);
        }

        private void tBar_Scroll(object sender, EventArgs e)
        {
            figurarombo.setSize(tBar.Value);
            float originalMayor = figurarombo.getoriginalMayor();
            float originalMenor = figurarombo.getoriginalMenor();
            float sumaMayor = originalMayor + (float)tBar.Value;
            float sumaMenor = originalMenor + (float)tBar.Value;
            txtdiagonalmayor.Text = sumaMayor.ToString();
            txtdiagonalmenor.Text = sumaMenor.ToString();
            figurarombo.readdata(txtdiagonalmayor, txtdiagonalmenor, picBoxTransformacion);
            figurarombo.calcularArea();
            figurarombo.calcularPerimetro();
            figurarombo.Printdata(txtperimetro, txtarea);
            lbmostarTamanio.Text = tBar.Value.ToString();

            figurarombo.PlotShape(picBoxTransformacion);
        }

        private void btnminus5_Click(object sender, EventArgs e)
        {
            figurarombo.rotar(-5);

            figurarombo.PlotShape(picBoxTransformacion);
        }

        private void btnplus5_Click(object sender, EventArgs e)
        {
            figurarombo.rotar(+5);

            figurarombo.PlotShape(picBoxTransformacion);
        }

        private void Formrombo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                figurarombo.movepoints(10, 4);

            }
            else if (e.KeyCode == Keys.Down)
            {
                figurarombo.movepoints(10, 3);
            }
            else if (e.KeyCode == Keys.Left)
            {
                figurarombo.movepoints(10, 2);
            }
            else if (e.KeyCode == Keys.Right)
            {
                figurarombo.movepoints(10, 1);
            }
            figurarombo.PlotShape(picBoxTransformacion);
        }
    }
}
