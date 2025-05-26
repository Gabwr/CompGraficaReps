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
    public partial class Formtrapezoide : Form
    {
        public Formtrapezoide()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }


        trapezoide figuratrapezoide = new trapezoide();
        class trapezoide
        {
            private float altura;
            private float tmbasemenor;
            private float tmbasemayor;
            private Point[] points = new Point[4];
            private Point pointCenter;
            private float perimeter;
            private float area;
            private Graphics graph;
            public float originalsizealtura;
            public float originalsizebaseMenor;
            public float originalsizebaseMayor;
            private int sz = 1;
            private SolidBrush pen;
            //Constructor sin parametros
            public trapezoide()
            {
                altura = 0.0f; tmbasemenor = 0.0f;
                perimeter = 0.0f; area = 0.0f;
            }

            public void setoriginal(float originalaltura, float originalbaseMayor, float originalbaseMenor)
            {
                originalsizealtura = originalaltura;
                originalsizebaseMenor = originalbaseMenor;
                originalsizebaseMayor = originalbaseMayor;
            }
            public float getoriginalaltura()
            {
                return originalsizealtura;
            }
            public float getoriginalbaseMenor()
            {
                return originalsizebaseMenor;
            }
            public float getoriginalbaseMayor()
            {
                return originalsizebaseMayor;
            }

            public void readdata(TextBox txtaltura, TextBox txtbasemayor, TextBox txtbasemenor, PictureBox piccanvas)
            {
                try
                {
                    altura = float.Parse(txtaltura.Text);
                    tmbasemayor = float.Parse(txtbasemayor.Text);
                    tmbasemenor = float.Parse(txtbasemenor.Text);
                }
                catch
                {
                    MessageBox.Show("Ingreso invalido...", "Mensaje de error");
                }
                pointCenter = new Point((piccanvas.Width / 2), (piccanvas.Height / 2));
                points[0] = new Point(((piccanvas.Width / 2) - (int)tmbasemenor / 2 + (int)tmbasemenor / 4) - sz, ((piccanvas.Height / 2) - (int)altura / 2) - sz);
                points[1] = new Point(((piccanvas.Width / 2) + ((int)tmbasemenor / 2) - (int)tmbasemenor / 4) + sz, ((piccanvas.Height / 2) - (int)altura / 2) - sz);
                points[2] = new Point(sz + ((piccanvas.Width / 2) + (int)tmbasemayor / 2), sz + ((piccanvas.Height / 2) + (int)altura / 2));
                points[3] = new Point(((piccanvas.Width / 2) - (int)tmbasemayor / 2) - sz, sz + ((piccanvas.Height / 2) + (int)altura / 2));

            }

            public void setSize(int size)
            {
                sz = size;
            }

            public void calcularPerimetro()
            {
                perimeter = 2 * altura + tmbasemayor + tmbasemenor;

            }

            public void calcularArea()
            {
                area = (altura *( tmbasemenor+tmbasemayor))/2;
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
            figuratrapezoide.readdata(txtAltura, txtbaseMayor,txtbaseMenor, picBoxTransformacion);
            figuratrapezoide.setoriginal(float.Parse(txtAltura.Text), float.Parse(txtbaseMayor.Text), float.Parse(txtbaseMenor.Text));
            figuratrapezoide.calcularArea();
            figuratrapezoide.calcularPerimetro();
            figuratrapezoide.Printdata(txtarea, txtperimetro);
            tBar.Value = 1;
            figuratrapezoide.PlotShape(picBoxTransformacion);
        }

        private void tBar_Scroll(object sender, EventArgs e)
        {
            figuratrapezoide.setSize(tBar.Value);
            float originalaltura = figuratrapezoide.getoriginalaltura();
            float originalbasemenor = figuratrapezoide.getoriginalbaseMenor();
            float originalbasemayor = figuratrapezoide.getoriginalbaseMayor();
            float sumaaltura = originalaltura + (float)tBar.Value;
            float sumabasemenor = originalbasemenor + (float)tBar.Value;
            float sumabasemayor = originalbasemayor + (float)tBar.Value;
            txtAltura.Text = sumaaltura.ToString();
            txtbaseMenor.Text = sumabasemenor.ToString();
            txtbaseMayor.Text = sumabasemayor.ToString();
            figuratrapezoide.readdata(txtAltura, txtbaseMayor, txtbaseMenor, picBoxTransformacion);
            figuratrapezoide.calcularArea();
            figuratrapezoide.calcularPerimetro();
            figuratrapezoide.Printdata(txtperimetro, txtarea);
            lbmostarTamanio.Text = tBar.Value.ToString();

            figuratrapezoide.PlotShape(picBoxTransformacion);
        }

        private void Formtrapezoide_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                figuratrapezoide.movepoints(10, 4);

            }
            else if (e.KeyCode == Keys.Down)
            {
                figuratrapezoide.movepoints(10, 3);
            }
            else if (e.KeyCode == Keys.Left)
            {
                figuratrapezoide.movepoints(10, 2);
            }
            else if (e.KeyCode == Keys.Right)
            {
                figuratrapezoide.movepoints(10, 1);
            }
            figuratrapezoide.PlotShape(picBoxTransformacion);
        }

        private void btnminus5_Click(object sender, EventArgs e)
        {
            figuratrapezoide.rotar(-5);

            figuratrapezoide.PlotShape(picBoxTransformacion);
        }

        private void btnplus5_Click(object sender, EventArgs e)
        {
            figuratrapezoide.rotar(5);

            figuratrapezoide.PlotShape(picBoxTransformacion);
        }
    }
}
