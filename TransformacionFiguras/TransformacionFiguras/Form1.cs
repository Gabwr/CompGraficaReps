using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransformacionFiguras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        rectangulo rectangle = new rectangulo();
        class rectangulo
        {
            private float width;
            private float height;
            private Point[] points = new Point[4];
            private Point pointCenter;
            private float perimeter;
            private float area;
            private Graphics graph;
            public float originalsize;
            private int sz=1;
            private SolidBrush pen;
            //Constructor sin parametros
            public rectangulo()
            {
                width = 0.0f; height = 0.0f;
                perimeter = 0.0f; area = 0.0f;
            }
            
            public void setoriginal(float original) 
            {
                originalsize = original;
            }
            public float getoriginal()
            {
                return originalsize;
            }


            public void readdata(TextBox txtwidth, TextBox txtheight, PictureBox piccanvas)
            {
                try
                {
                    width = float.Parse(txtwidth.Text);
                    height = float.Parse(txtheight.Text);
                }
                catch
                {
                    MessageBox.Show("Ingreso invalido...", "Mensaje de error");
                }
                pointCenter = new Point( (piccanvas.Width / 2),  (piccanvas.Height / 2));
                points[0] = new Point(((piccanvas.Width / 2) - (int)width / 2) - sz, ((piccanvas.Height / 2) - (int)height / 2) - sz);
                points[1] = new Point(((piccanvas.Width / 2) + (int)width / 2) + sz, ((piccanvas.Height / 2) - (int)height / 2) - sz);
                points[2] = new Point(sz + ((piccanvas.Width / 2) + (int)width / 2), sz +((piccanvas.Height / 2) + (int)height / 2));
                points[3] = new Point(((piccanvas.Width / 2) - (int)width / 2) - sz, sz + ((piccanvas.Height / 2) + (int)height / 2));
                
            }

            public void setSize(int size)
            {
                sz = size;
            }

            public void calcularPerimetro()
            {
                perimeter = 2 * width + 2 * height;

            }

            public void calcularArea()
            {
                area = width * height;
            }

            public void Printdata(TextBox txtperimeter, TextBox txtarea)
            {
                txtarea.Text = perimeter.ToString();
                txtperimeter.Text = area.ToString();
            }

            public void InitializeData(TextBox txtperimeter, TextBox txtarea, TextBox txtheight, TextBox txtwidht, PictureBox piccanvas)

            {
                width = 0.0f; height = 0.0f;
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
        private void button1_Click(object sender, EventArgs e)
        {
            rectangle.rotar(-5);

            rectangle.PlotShape(picBoxTransformacion);
        }
        
        private void btnDibujar_Click(object sender, EventArgs e)
        {
            rectangle.readdata(txtlado,txtlado,picBoxTransformacion);
            rectangle.calcularArea();
            rectangle.calcularPerimetro();
            rectangle.setoriginal(float.Parse(txtlado.Text));
            rectangle.Printdata(txtperimetro, txtarea);
            rectangle.PlotShape(picBoxTransformacion);
        }

        private void picBoxTransformacion_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                rectangle.movepoints(10, 4);

            }
            else if (e.KeyCode == Keys.Down)
            {
                rectangle.movepoints(10, 3);
            }
            else if (e.KeyCode == Keys.Left)
            {
                rectangle.movepoints(10, 2);
            }
            else if (e.KeyCode == Keys.Right)
            {
                rectangle.movepoints(10, 1);
            }
            rectangle.PlotShape(picBoxTransformacion);
        }

        private void btnplus5_Click(object sender, EventArgs e)
        {
            rectangle.rotar(5);
            
            rectangle.PlotShape(picBoxTransformacion);
            
        }

        private void tBar_Scroll(object sender, EventArgs e)
        {
            rectangle.setSize(tBar.Value);
            float original = rectangle.getoriginal();
            float suma = original+ (float) tBar.Value;
            txtlado.Text = suma.ToString();
            rectangle.readdata(txtlado, txtlado, picBoxTransformacion);
            rectangle.calcularArea();
            rectangle.calcularPerimetro();
            rectangle.Printdata(txtperimetro,txtarea);
            lbmostarTamanio.Text = tBar.Value.ToString();
            
            rectangle.PlotShape(picBoxTransformacion);

        }
    }
}
