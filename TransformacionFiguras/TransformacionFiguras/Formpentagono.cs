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
    public partial class Formpentagono : Form
    {
        public Formpentagono()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        pentagono figurapentagono = new pentagono();
        class pentagono
        {
            private float lado;
            private Point[] points = new Point[5];
            private Point pointCenter;
            private float perimeter;
            private float area;
            private Graphics graph;
            public float originalsizelado;
            private int sz = 1;
            private SolidBrush pen;
            //Constructor sin parametros
            public pentagono()
            {
                lado = 0.0f;
                perimeter = 0.0f; area = 0.0f;
            }

            public void setoriginal(float originallado)
            {
                originalsizelado = originallado;
            }
            public float getoriginallado()
            {
                return originalsizelado;
            }

            public void readdata(TextBox txtdlado, PictureBox piccanvas)
            {
                try
                {
                    lado = float.Parse(txtdlado.Text);
                }
                catch
                {
                    MessageBox.Show("Ingreso invalido...", "Mensaje de error");
                }

                pointCenter = new Point((piccanvas.Width / 2), (piccanvas.Height / 2));
                for (int i = 0; i < points.Length; i++)
                {
                    int x = pointCenter.X + Convert.ToInt32(Math.Round(lado * Math.Cos((2 * Math.PI * i) / 5- Math.PI/2)));
                    int y = pointCenter.Y + Convert.ToInt32(Math.Round(lado * Math.Sin((2 * Math.PI * i) / 5- Math.PI/2)));
                    Point mpoint = new Point(x, y);
                    points[i] = mpoint;

                }
                
            }

            public void setSize(int size)
            {
                sz = size;
            }

            public void calcularPerimetro()
            {
                perimeter = 5 * lado;

            }

            public void calcularArea()
            {
                area = (5 * lado * lado) / (4 * (float)Math.Tan(Math.PI / 5));
                
            }

            public void Printdata(TextBox txtperimeter, TextBox txtarea)
            {
                txtarea.Text = perimeter.ToString();
                txtperimeter.Text = area.ToString();
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
           figurapentagono.readdata(txtlado, picBoxTransformacion);
            figurapentagono.calcularArea();
            figurapentagono.calcularPerimetro();
            figurapentagono.setoriginal(float.Parse(txtlado.Text));
            figurapentagono.Printdata(txtperimetro, txtarea);
            figurapentagono.PlotShape(picBoxTransformacion);
        }

        private void tBar_Scroll(object sender, EventArgs e)
        {
            figurapentagono.setSize(tBar.Value);
            float original = figurapentagono.getoriginallado();
            float suma = original + (float)tBar.Value;
            txtlado.Text = suma.ToString();
            figurapentagono.readdata(txtlado, picBoxTransformacion);
            figurapentagono.calcularArea();
            figurapentagono.calcularPerimetro();
            figurapentagono.Printdata(txtperimetro, txtarea);
            lbmostarTamanio.Text = tBar.Value.ToString();

            figurapentagono.PlotShape(picBoxTransformacion);
        }

        private void btnminus5_Click(object sender, EventArgs e)
        {
            figurapentagono.rotar(-5);

            figurapentagono.PlotShape(picBoxTransformacion);
        }

        private void btnplus5_Click(object sender, EventArgs e)
        {
            figurapentagono.rotar(5);

            figurapentagono.PlotShape(picBoxTransformacion);
        }

        private void Formpentagono_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                figurapentagono.movepoints(10, 4);

            }
            else if (e.KeyCode == Keys.Down)
            {
                figurapentagono.movepoints(10, 3);
            }
            else if (e.KeyCode == Keys.Left)
            {
                figurapentagono.movepoints(10, 2);
            }
            else if (e.KeyCode == Keys.Right)
            {
                figurapentagono.movepoints(10, 1);
            }
            figurapentagono.PlotShape(picBoxTransformacion);
        }
    }
}
