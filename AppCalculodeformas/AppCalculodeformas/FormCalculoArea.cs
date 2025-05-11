using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCalculodeformas
{
    public partial class FormCalculoArea : Form
    {
        public float A = 0.0f;
        public float B = 0.0f;
        public float C = 0.0f;

        public FormCalculoArea()
        {
            InitializeComponent();
            lbA.Visible = false;
            txtA.Visible = false;
            lbB.Visible = false;
            txtB.Visible = false;
            lbC.Visible = false;
            txtC.Visible = false;
        }


        public void reiniciar()
        {
            lbC.Visible = false;
            txtC.Visible = false;
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            txtarea.Text = "";
            txtperimetro.Text = "";
            cbopcion.TabIndex = 0;
        }
        public void reiniciarcampos()
        {
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            txtarea.Text = "";
            txtperimetro.Text = "";
        }

        public void readdata(TextBox txta, TextBox txtb, TextBox txtc)
        {

            if (!string.IsNullOrWhiteSpace(txta.Text))
            {
                try
                {
                    A = float.Parse(txta.Text);
                }
                catch
                {
                    MessageBox.Show("Ingreso invalido...", "Mensaje de error");
                }
            }
            if (!string.IsNullOrWhiteSpace(txtb.Text))
            {
                try
                {
                    B = float.Parse(txtb.Text);
                }
                catch
                {
                    MessageBox.Show("Ingreso invalido...", "Mensaje de error");
                }
            }
            if (!string.IsNullOrWhiteSpace(txtc.Text))
            {
                try
                {
                    C = float.Parse(txtc.Text);
                }
                catch
                {
                    MessageBox.Show("Ingreso invalido...", "Mensaje de error");
                }
            }

        }
        public class triangulo
        {
            private float a; // base
            private float b; //altura
            private float area;
            private float perimetro;
            public triangulo(float bas, float altura)
            {
                a = bas; b = altura;
            }

            public void CalculoArea()
            {
                area = (a*b)/2;
                perimetro = 3* (float)Math.Sqrt((4* area)/(float)Math.Sqrt(3));
            }

            public float resA()
            {
                return area;
            }
            public float resp()
            {
                return perimetro;
            }
        }


        public class cuadrado
        {
            private float a; //lado
            private float area;
            private float perimetro;
            public cuadrado(float lado)
            {
                a = lado;
            }

            public void CalculoArea()
            {
                area = (a * a);
                perimetro = 4 * a;
            }

            public float resA()
            {
                return area;
            }
            public float resp()
            {
                return perimetro;
            }
        }

        public class circulo
        {
            private float a; //radio
            private float area;
            private float perimetro;
            public circulo(float radio)
            {
                a = radio;
            }

            public void CalculoArea()
            {
                area = ((float)Math.Pow(a,2) * (float)Math.PI );
                perimetro = 2 * (float)Math.PI * (float)Math.Sqrt(area / (float)Math.PI);
            }

            public float resA()
            {
                return area;
            }
            public float resp()
            {
                return perimetro;
            }
        }

        public class rectangulo
        {
            private float a; //base
            private float b; // altura
            private float area;
            private float perimetro;
            public rectangulo(float bas, float alt)
            {
                a = bas; b = alt;
            }

            public void CalculoArea()
            {
                area = a * b;
                perimetro = (2 * a) + (2 * b);
            }

            public float resA()
            {
                return area;
            }
            public float resp()
            {
                return perimetro;
            }
        }

        public class rombo
        {
            private float a; //diagonal mayor
            private float b; //diagonal menor
            private float area;
            private float perimetro;
            public rombo(float diaMy, float diagMn)
            {
                a = diaMy; b = diagMn;
            }

            public void CalculoArea()
            {
                area = (a * b) / 2;
                perimetro = 2 * (float)Math.Sqrt((float)Math.Pow(a, 2)+(float)Math.Pow(b, 2));
            }

            public float resA()
            {
                return area;
            }
            public float resp()
            {
                return perimetro;
            }
        }

        public class trapecio
        {
            private float a; //base menor
            private float b; //base mayor
            private float c; //altura
            private float area;
            private float perimetro;

            public trapecio(float basMn, float basMy, float alt)
            {
                a = basMn; b = basMy;
                c = alt;
            }
            public void CalculoArea()
            {
                area = ((a + b)*c)/ 2;
                perimetro = a + b + c + (float)Math.Sqrt(Math.Pow((a+b),2) + Math.Pow(c,2));
            }

            public float resA()
            {
                return area;
            }
            public float resp()
            {
                return perimetro;
            }
        }

        public class trapezoide
        {
            private float a; //base menor
            private float b; //base mayor
            private float c; //altura
            private float area;
            private float perimetro;
            public trapezoide(float basMn, float basMy, float alt)
            {
                a = basMn; b = basMy;
                c = alt;
            }
            public void CalculoArea()
            {
                area = ((a + b) * c) / 2;
                perimetro = a+b+(2*c);
            }

            public float resA()
            {
                return area;
            }
            public float resp()
            {
                return perimetro;
            }
        }

        public class trapezioIsc
        {
            private float a; //base menor
            private float b; //base mayor
            private float c; //altura
            private float area;
            private float perimetro;

            public trapezioIsc(float basMn, float basMy, float alt)
            {
                a = basMn; b = basMy;
                c = alt;
            }
            public void CalculoArea()
            {
                area = ((a + b) * c) / 2;
                perimetro = a + b + (2 * c);
            }

            public float resA()
            {
                return area;
            }
            public float resp()
            {
                return perimetro;
            }
        }

        public class elipse
        {
            private float a; //Semieje menor
            private float b; //Semieje mayor
            private float area;
            private float perimetro;
            public elipse(float SemMn, float SemMy)
            {
                a = SemMn; b = SemMy;
            }

            public void CalculoArea()
            {
                area = a*b* (float) Math.PI;
                perimetro = (float)Math.PI * (3 * (a * b) - (float)Math.Sqrt((3 * a + b)*(a + 3 * b)));
            }

            public float resA()
            {
                return area;
            }
            public float resp()
            {
                return perimetro;
            }
        }

        public class ovalo
        {
            private float a; //Semieje menor
            private float b; //Semieje mayor
            private float area;
            private float perimetro;

            public ovalo(float SemMn, float SemMy)
            {
                a = SemMn; b = SemMy;
            }

            public void CalculoArea()
            {
                area = a * b * (float)Math.PI;
                perimetro = (float)Math.PI * (3 * (a * b) - (float)Math.Sqrt((3 * a + b) * (a + 3 * b)));
            }

            public float resA()
            {
                return area;
            }
            public float resp()
            {
                return perimetro;
            }
        }

        public class deltoide
        {
            private float a; //diagonal menor
            private float b; //diagonal mayor
            private float area;
            private float perimetro;

            public deltoide(float diaMy, float diagMn)
            {
                a = diaMy; b = diagMn;
            }
            public void CalculoArea()
            {
                area = (a + b) / 2;
                perimetro = 2 * (float)Math.Sqrt((float)Math.Pow(a, 2) + (float)Math.Pow(b, 2));
            }

            public float resA()
            {
                return area;
            }
            public float resp()
            {
                return perimetro;
            }
        }

        public class romboide
        {
            private float a; //base
            private float b; //altura
            private float area;
            private float perimetro;
            public romboide(float bas, float alt)
            {
                a = bas; b = alt;
            }

            public void CalculoArea()
            {
                area = (a + b) / 2;
                perimetro = 2 * (a + b);
            }

            public float resA()
            {
                return area;
            }
            public float resp()
            {
                return perimetro;
            }
        }

        public class poligonoReg
        {
            private float a; //tamaño del lado
            private float b; //numero de lados
            private float area;
            private float perimetro;

            public poligonoReg(float TamL, float numL)
            {
                a= TamL; b= numL;
            }

            public void CalculoArea()
            {
                area = (b * a * a) / (4*(float)Math.Tan(Math.PI/b));
                perimetro = a * b;
            }

            public float resA()
            {
                return area;
            }
            public float resp()
            {
                return perimetro;
            }
        }

        public void cualforma()
        {
            switch (cbopcion.SelectedIndex)
            {
                case 0: //ninguno
                    break;
                case 1: //cuadrado
                    cuadrado square = new cuadrado(A);
                    square.CalculoArea();
                    txtarea.Text = square.resA().ToString();
                    txtperimetro.Text = square.resp().ToString();
                    break;
                case 2: //triangulo
                    triangulo tri = new triangulo(A,B);
                    tri.CalculoArea();
                    txtarea.Text = tri.resA().ToString();
                    txtperimetro.Text = tri.resp().ToString();
                    break;
                case 3: //rectangulo
                    rectangulo rect = new rectangulo(A,B);
                    rect.CalculoArea();
                    txtarea.Text = rect.resA().ToString();
                    txtperimetro.Text = rect.resp().ToString();
                    break;
                case 4: //circulo
                    circulo circ = new circulo(A);
                    circ.CalculoArea();
                    txtarea.Text= circ.resA().ToString();
                    txtperimetro.Text = circ.resp().ToString();
                    break;
                case 5://elipse
                    elipse elips = new elipse(A,B);
                    elips.CalculoArea();
                    txtarea.Text=elips.resA().ToString();
                    txtperimetro.Text = elips.resp().ToString();
                    break;
                case 6://Trapecio
                    trapecio trap = new trapecio(A,B,C);
                    trap.CalculoArea();
                    txtarea.Text=trap.resA().ToString();
                    txtperimetro.Text = trap.resp().ToString();
                    break;
                case 7://Trapezoide
                    trapezoide trapz= new trapezoide(A,B,C);
                    trapz.CalculoArea();
                    txtarea.Text=trapz.resA().ToString();
                    txtperimetro.Text = trapz.resp().ToString();
                    break;
                case 8://Trapecio isoceles
                    trapezioIsc trapIsc = new trapezioIsc(A,B,C);
                    trapIsc.CalculoArea();
                    txtarea.Text=trapIsc.resA().ToString();
                    txtperimetro.Text = trapIsc.resp().ToString();
                    break;
                case 9://ovalo
                    ovalo oval = new ovalo(A, B);
                    oval.CalculoArea();
                    txtarea.Text = oval.resA().ToString();
                    txtperimetro.Text = oval.resp().ToString();
                    break;
                case 10://rombo
                    rombo romb = new rombo(A,B);
                    romb.CalculoArea();
                    txtarea.Text=romb.resA().ToString();
                    txtperimetro.Text = romb.resp().ToString();
                    break;
                case 11: //romboide
                    romboide rombd = new romboide(A,B);
                    rombd.CalculoArea();
                    txtarea.Text=rombd.resA().ToString();
                    txtperimetro.Text = rombd.resp().ToString();
                    break;
                case 12://deltoide
                    deltoide delt = new deltoide(A,B);
                    delt.CalculoArea();
                    txtarea.Text = delt.resA().ToString();
                    txtperimetro.Text = delt.resp().ToString();
                    break;
                case 13://pentagono
                    poligonoReg pent = new poligonoReg(A,5);
                    pent.CalculoArea();
                    txtarea.Text =pent.resA().ToString();
                    txtperimetro.Text = pent.resp().ToString();
                    break;
                case 14://hexagono
                    poligonoReg hex = new poligonoReg(A, 6);
                    hex.CalculoArea();
                    txtarea.Text = hex.resA().ToString();
                    txtperimetro.Text = hex.resp().ToString();
                    break;
                case 15://heptagono
                    poligonoReg hept = new poligonoReg(A, 7);
                    hept.CalculoArea();
                    txtarea.Text = hept.resA().ToString();
                    txtperimetro.Text = hept.resp().ToString();
                    break;
                case 16://octagono
                    poligonoReg oct = new poligonoReg(A, 8);
                    oct.CalculoArea();
                    txtarea.Text = oct.resA().ToString();
                    txtperimetro.Text = oct.resp().ToString();
                    break;
                case 17://eneagono
                    poligonoReg eng = new poligonoReg(A, 9);
                    eng.CalculoArea();
                    txtarea.Text = eng.resA().ToString();
                    txtperimetro.Text = eng.resp().ToString();
                    break;
                case 18://decagono
                    poligonoReg dec = new poligonoReg(A, 10);
                    dec.CalculoArea();
                    txtarea.Text = dec.resA().ToString();
                    txtperimetro.Text = dec.resp().ToString();
                    break;
            }
        }
        private void btncalcular_Click(object sender, EventArgs e)
        {
            readdata(txtA, txtB, txtC);
            cualforma();

        }

        private void cbopcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            reiniciarcampos();
            switch (cbopcion.SelectedIndex)
            {
                case 0: //ninguno
                    lbA.Visible = false;
                    txtA.Visible = false;
                    lbB.Visible = false;
                    txtB.Visible = false;
                    lbC.Visible = false;
                    txtC.Visible = false;
                    picbref.Image = null;
                break;
                case 1: //cuadrado
                    lbA.Visible = true;
                    txtA.Visible = true;
                    lbA.Text = "Lado";
                    lbB.Visible = false;
                    txtB.Visible = false;
                    lbC.Visible = false;
                    txtC.Visible = false;
                    picbref.Image = Image.FromFile("img/cuadrado.jpg");
                    break;
                case 2: //triangulo
                    lbA.Visible = true;
                    txtA.Visible = true;
                    lbA.Text = "Base";
                    lbB.Visible = true;
                    txtB.Visible = true;
                    lbB.Text = "Altura";
                    lbC.Visible = false;
                    txtC.Visible = false;
                    picbref.Image = Image.FromFile("img/triangulo.png");
                    break;
                case 3: //rectangulo
                    lbA.Visible = true;
                    txtA.Visible = true;
                    lbA.Text = "Base";
                    lbB.Visible = true;
                    txtB.Visible = true;
                    lbB.Text = "Altura";
                    lbC.Visible = false;
                    txtC.Visible = false;
                    picbref.Image = Image.FromFile("img/rectangulo.png");
                    break;
                case 4: //circulo
                    lbA.Visible = true;
                    txtA.Visible = true;
                    lbA.Text = "Radio";
                    lbB.Visible = false;
                    txtB.Visible = false;
                    lbC.Visible = false;
                    txtC.Visible = false;
                    picbref.Image = Image.FromFile("img/circulo.jpg");
                    break;
                case 5://elipse
                    lbA.Visible = true;
                    txtA.Visible = true;
                    lbA.Text = "Semieje Mayor";
                    lbB.Visible = true;
                    txtB.Visible = true;
                    lbB.Text = "Semieje Menor";
                    lbC.Visible = false;
                    txtC.Visible = false;
                    picbref.Image = Image.FromFile("img/elipse.png");
                    break;
                case 6://Trapecio
                    lbA.Visible = true;
                    txtA.Visible = true;
                    lbA.Text = "Base Menor";
                    lbB.Visible = true;
                    txtB.Visible = true;
                    lbB.Text = "Base Mayor";
                    lbC.Visible = true;
                    txtC.Visible = true;
                    lbC.Text = "Altura";
                    picbref.Image = Image.FromFile("img/trapecio.png");
                    break;
                case 7://Trapezoide
                    lbA.Visible = true;
                    txtA.Visible = true;
                    lbA.Text = "Base Menor";
                    lbB.Visible = true;
                    txtB.Visible = true;
                    lbB.Text = "Base Mayor";
                    lbC.Visible = true;
                    txtC.Visible = true;
                    lbC.Text = "Altura";
                    picbref.Image = Image.FromFile("img/trapezoide.png");
                    break;
                case 8://Trapecio isoceles
                    lbA.Visible = true;
                    txtA.Visible = true;
                    lbA.Text = "Base Menor";
                    lbB.Visible = true;
                    txtB.Visible = true;
                    lbB.Text = "Base Mayor";
                    lbC.Visible = true;
                    txtC.Visible = true;
                    lbC.Text = "Altura";
                    picbref.Image = Image.FromFile("img/trapecioIsc.png");
                    break;
                case 9://ovalo
                    lbA.Visible = true;
                    txtA.Visible = true;
                    lbA.Text = "Semieje Mayor";
                    lbB.Visible = true;
                    txtB.Visible = true;
                    lbB.Text = "Semieje Menor";
                    lbC.Visible = false;
                    txtC.Visible = false;
                    picbref.Image = Image.FromFile("img/ovalo.jpg");
                    break;
                case 10://rombo
                    lbA.Visible = true;
                    txtA.Visible = true;
                    lbA.Text = "Diagonal Mayor";
                    lbB.Visible = true;
                    txtB.Visible = true;
                    lbB.Text = "Diagonal Menor";
                    lbC.Visible = false;
                    txtC.Visible = false;
                    picbref.Image = Image.FromFile("img/rombo.png");
                    break;
                case 11: //romboide
                    lbA.Visible = true;
                    txtA.Visible = true;
                    lbA.Text = "Base";
                    lbB.Visible = true;
                    txtB.Visible = true;
                    lbB.Text = "Altura";
                    lbC.Visible = false;
                    txtC.Visible = false;
                    picbref.Image = Image.FromFile("img/romboide.jpg");
                    break;
                case 12://deltoide
                    lbA.Visible = true;
                    txtA.Visible = true;
                    lbA.Text = "Diagonal Mayor";
                    lbB.Visible = true;
                    txtB.Visible = true;
                    lbB.Text = "Diagonal Menor";
                    lbC.Visible = false;
                    txtC.Visible = false;
                    picbref.Image = Image.FromFile("img/deltoide.png");
                    break;
                case 13://pentagono
                    lbA.Visible = true;
                    txtA.Visible = true;
                    lbA.Text = "Tamaño del lado";
                    lbB.Visible = false;
                    txtB.Visible = false;
                    lbC.Visible = false;
                    txtC.Visible = false;
                    picbref.Image = Image.FromFile("img/pentagono.png");
                    break;
                case 14://hexagono
                    lbA.Visible = true;
                    txtA.Visible = true;
                    lbA.Text = "Tamaño del lado";
                    lbB.Visible = false;
                    txtB.Visible = false;
                    lbC.Visible = false;
                    txtC.Visible = false;
                    picbref.Image = Image.FromFile("img/hexagono.png");
                    break;
                case 15://heptagono
                    lbA.Visible = true;
                    txtA.Visible = true;
                    lbA.Text = "Tamaño del lado";
                    lbB.Visible = false;
                    txtB.Visible = false;
                    lbC.Visible = false;
                    txtC.Visible = false;
                    picbref.Image = Image.FromFile("img/heptagono.png");
                    break;
                case 16://octagono
                    lbA.Visible = true;
                    txtA.Visible = true;
                    lbA.Text = "Tamaño del lado";
                    lbB.Visible = false;
                    txtB.Visible = false;
                    lbC.Visible = false;
                    txtC.Visible = false;
                    picbref.Image = Image.FromFile("img/octagono.png");
                    break;
                case 17://eneagono
                    lbA.Visible = true;
                    txtA.Visible = true;
                    lbA.Text = "Tamaño del lado";
                    lbB.Visible = false;
                    txtB.Visible = false;
                    lbC.Visible = false;
                    txtC.Visible = false;
                    picbref.Image = Image.FromFile("img/eneagono.jpg");
                    break;
                case 18://decagono
                    lbA.Visible = true;
                    txtA.Visible = true;
                    lbA.Text = "Tamaño del lado";
                    lbB.Visible = false;
                    txtB.Visible = false;
                    lbC.Visible = false;
                    txtC.Visible = false;
                    picbref.Image = Image.FromFile("img/decagono.png");
                    break;
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            reiniciar();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
