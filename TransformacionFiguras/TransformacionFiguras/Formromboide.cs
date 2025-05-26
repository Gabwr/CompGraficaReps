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
    public partial class Formromboide : Form
    {
        public Formromboide()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        
        romboide figuraromboide = new romboide();
        class romboide
        {
            private float altura;
            private float tmbase;
            private Point[] points = new Point[4];
            private Point pointCenter;
            private float perimeter;
            private float area;
            private Graphics graph;
            public float originalsizealtura;
            public float originalsizebase;
            private int sz = 1;
            private SolidBrush pen;
            //Constructor sin parametros
            public romboide()
            {
                altura = 0.0f; tmbase = 0.0f;
                perimeter = 0.0f; area = 0.0f;
            }

            public void setoriginal(float originalaltura, float originalbase)
            {
                originalsizealtura = originalaltura;
                originalsizebase = originalbase;
            }
            public float getoriginalaltura()
            {
                return originalsizealtura;
            }
            public float getoriginalbase()
            {
                return originalsizebase;
            }

            public void readdata(TextBox txtaltura, TextBox txtbase, PictureBox piccanvas)
            {
                try
                {
                    altura = float.Parse(txtaltura.Text);
                    tmbase = float.Parse(txtbase.Text);
                }
                catch
                {
                    MessageBox.Show("Ingreso invalido...", "Mensaje de error");
                }
                pointCenter = new Point((piccanvas.Width / 2), (piccanvas.Height / 2));
                points[0] = new Point(((piccanvas.Width / 2) - (int)tmbase / 2+ (int) tmbase/4) - sz, ((piccanvas.Height / 2) - (int)altura / 2) - sz);
                points[1] = new Point(((piccanvas.Width / 2) + ((int)tmbase / 2)+(int) tmbase / 4 )+ sz, ((piccanvas.Height / 2) - (int)altura / 2) - sz);
                points[2] = new Point(sz + ((piccanvas.Width / 2) + (int)tmbase / 2), sz + ((piccanvas.Height / 2) + (int)altura / 2));
                points[3] = new Point(((piccanvas.Width / 2) - (int)tmbase / 2) - sz, sz + ((piccanvas.Height / 2) + (int)altura / 2));

            }

            public void setSize(int size)
            {
                sz = size;
            }

            public void calcularPerimetro()
            {
                perimeter = 2 * tmbase +2 * altura;

            }

            public void calcularArea()
            {
                area = altura* tmbase;
            }

            public void Printdata(TextBox txtperimeter, TextBox txtarea)
            {
                txtarea.Text = perimeter.ToString();
                txtperimeter.Text = area.ToString();
            }

            public void InitializeData(TextBox txtperimeter, TextBox txtarea, TextBox txtheight, TextBox txtwidht, PictureBox piccanvas)

            {
                altura = 0.0f; tmbase = 0.0f;
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
            figuraromboide.readdata(txtaltura, txtbase, picBoxTransformacion);
            figuraromboide.setoriginal(float.Parse(txtaltura.Text), float.Parse(txtbase.Text));
            figuraromboide.calcularArea();
            figuraromboide.calcularPerimetro();
            figuraromboide.Printdata(txtarea, txtperimetro);
            tBar.Value = 1;
            figuraromboide.PlotShape(picBoxTransformacion);
        }

        private void tBar_Scroll(object sender, EventArgs e)
        {
            figuraromboide.setSize(tBar.Value);
            float originalaltura = figuraromboide.getoriginalaltura();
            float originalbase = figuraromboide.getoriginalbase();
            float sumaaltura = originalaltura + (float)tBar.Value;
            float sumabase = originalbase + (float)tBar.Value;
            txtaltura.Text = sumaaltura.ToString();
            txtbase.Text = sumabase.ToString();
            figuraromboide.readdata(txtaltura, txtbase, picBoxTransformacion);
            figuraromboide.calcularArea();
            figuraromboide.calcularPerimetro();
            figuraromboide.Printdata(txtperimetro, txtarea);
            lbmostarTamanio.Text = tBar.Value.ToString();

            figuraromboide.PlotShape(picBoxTransformacion);
        }

        private void btnminus5_Click(object sender, EventArgs e)
        {
            figuraromboide.rotar(-5);

            figuraromboide.PlotShape(picBoxTransformacion);
        }

        private void btnplus5_Click(object sender, EventArgs e)
        {
            figuraromboide.rotar(5);

            figuraromboide.PlotShape(picBoxTransformacion);
        }

        private void Formromboide_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                figuraromboide.movepoints(10, 4);

            }
            else if (e.KeyCode == Keys.Down)
            {
                figuraromboide.movepoints(10, 3);
            }
            else if (e.KeyCode == Keys.Left)
            {
                figuraromboide.movepoints(10, 2);
            }
            else if (e.KeyCode == Keys.Right)
            {
                figuraromboide.movepoints(10, 1);
            }
            figuraromboide.PlotShape(picBoxTransformacion);
        }
    }
}
