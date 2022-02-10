using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculadora.ClassFolder.Calculator;
using Calculadora.Desing;

namespace Calculadora
{
    public partial class FrmCalculator : Form
    {
        private double Valor1 = 0;
        private double Valor2 = 0;
        private char Signo;
        private double Resultado = 0;
        private bool NuevaOp = false;
        private int Continuar = 0;
        public FrmCalculator()
        {
            InitializeComponent();
            this.CambiarColorFrmCalculator();
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))                 
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }
                this.Press(sender, e);
            }
            catch (Exception)
            {
            }
        }

        private void Press(object sender, KeyPressEventArgs e)
        {
            if ("1".Contains(e.KeyChar))
            {
                btnUno_Click(sender, e);
            }
        }

        private void QuitarCero()
        {
            if (this.txtNum.Text == "0")
            {
                this.txtNum.Text = "";
            }
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            try
            {
                this.QuitarCero();
                this.NuevaOperacion();
                this.txtNum.Text += "1";
            }
            catch (Exception)
            {
            }
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            try
            {
                this.QuitarCero();
                this.NuevaOperacion();
                this.txtNum.Text += "2";
            }
            catch (Exception)
            {
            }
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            try
            {
                this.QuitarCero();
                this.NuevaOperacion();
                this.txtNum.Text += "3";
            }
            catch (Exception)
            {
            }
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            try
            {
                this.QuitarCero();
                this.NuevaOperacion();
                this.txtNum.Text += "4";
            }
            catch (Exception)
            {
            }
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            try
            {
                this.QuitarCero();
                this.NuevaOperacion();
                this.txtNum.Text += "5";
            }
            catch (Exception)
            {
            }
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            try
            {
                this.QuitarCero();
                this.NuevaOperacion();
                this.txtNum.Text += "6";
            }
            catch (Exception)
            {
            }
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            try
            {
                this.QuitarCero();
                this.NuevaOperacion();
                this.txtNum.Text += "7";
            }
            catch (Exception)
            {
            }
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            try
            {
                this.QuitarCero();
                this.NuevaOperacion();
                this.txtNum.Text += "8";
            }
            catch (Exception)
            {
            }
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            try
            {
                this.QuitarCero();
                this.NuevaOperacion();
                this.txtNum.Text += "9";
            }
            catch (Exception)
            {
            }
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            try
            {
                this.QuitarCero();
                this.NuevaOperacion();
                this.txtNum.Text += "0";
            }
            catch (Exception)
            {
            }
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.txtNum.Text.Contains("."))
                {
                    this.txtNum.Text += ".";
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            try
            {
                this.SignoOperacion(this.Signo = '+');
            }
            catch (Exception)
            {
            }
        }
        private void btnResta_Click(object sender, EventArgs e)
        {
            try
            {
                this.SignoOperacion(this.Signo = '-');
            }
            catch (Exception)
            {
            }
        }
        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            try
            {
                this.SignoOperacion(this.Signo = 'x');
            }
            catch (Exception)
            {
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            try
            {
                this.SignoOperacion(this.Signo = '/');
            }
            catch (Exception)
            {
            }
        }

        private void btnElevado_Click(object sender, EventArgs e)
        {
            try
            {
                double acumulador = 0;

                acumulador = Math.Pow(Convert.ToDouble(this.txtNum.Text), 2);
                this.txtNum.Text = acumulador.ToString();
                this.lblAcumulador.Text += acumulador.ToString();
            }
            catch (Exception)
            {
            }

        }

        private void btnPorcentaje_Click(object sender, EventArgs e)
        {
            try
            {
                int index = 0;
                if (this.lblAcumulador.Text.Contains(this.Signo))
                {
                    index += 1;
                }
                if (index >= 1)
                {
                    this.txtNum.Text = (Convert.ToDouble(this.txtNum.Text) / 100).ToString();
                    lblAcumulador.Text = this.Valor1.ToString() + this.Signo;
                }
                else
                {
                    this.txtNum.Text = (Convert.ToDouble(this.txtNum.Text) / 100).ToString();
                }
            }
            catch (Exception)
            {
            }
        }

        private string RemoveNegative(string text, int num)
        {
            return text.Remove(num, 1);
        }

        private void btnMasMenos_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtNum.Text.Contains("-"))
                {
                    this.txtNum.Text = this.RemoveNegative(this.txtNum.Text, 0);
                }
                else
                {
                    this.txtNum.Text = '-' + this.txtNum.Text;
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            try
            {
                this.MostrarResultado();
            }
            catch (Exception)
            {
            }
        }

        private void txtNum_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    this.MostrarResultado();
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtNum.Text = "0";
            this.lblAcumulador.Text = "";
            Valor1 = 0;
            Valor2 = 0;
            Resultado = 0;
            this.NuevaOp = false;
        }

        //Metodo para almacenar el signo y los numeros
        private void SignoOperacion(char signo)
        {
            int index = 0;
            if (this.lblAcumulador.Text.Contains(signo))
            {
                index += 1;
            }
            if (index >= 1)
            {
                this.Valor2 = Convert.ToDouble(this.txtNum.Text);
                this.ResultadoF();
                this.Valor1 = Convert.ToDouble(this.Resultado);
                signo = '[';
                lblAcumulador.Text = this.Valor1.ToString() + this.Signo;
            }
            else
            {
                this.Valor1 = Convert.ToDouble(this.txtNum.Text);
                signo = '[';
                txtNum.Clear();
                lblAcumulador.Text = this.Valor1.ToString() + this.Signo;
            }
            this.Continuar = 1;
        }

        private void MostrarOperacion()
        {
            lblAcumulador.Text = this.Valor1.ToString() + this.Signo + this.Valor2 + '=';
            this.txtNum.Text = this.Resultado.ToString();
            this.NuevaOp = true;
        }

        private void NuevaOperacion()
        {
            if (this.NuevaOp == true)
            {
                this.txtNum.Clear();
                this.lblAcumulador.Text = this.Resultado.ToString() + this.Signo;
                this.NuevaOp = false;
                this.Continuar = 1;
            }
        }

        private void ResultadoF()
        {
            switch (this.Signo)
            {
                case '+':
                    this.Resultado = Suma.SumaNum(this.Valor1, this.Valor2);
                    this.MostrarOperacion();
                    break;
                case '-':
                    this.Resultado = Resta.RestaNum(this.Valor1, this.Valor2);
                    this.MostrarOperacion();
                    break;
                case 'x':
                    this.Resultado = Multiplicacion.MultipNum(this.Valor1, this.Valor2);
                    this.MostrarOperacion();
                    break;
                case '/':
                    this.Resultado = Division.DivNum(this.Valor1, this.Valor2);
                    this.MostrarOperacion();
                    break;
                default:
                    break;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtNum.Text.Length > 1)
                {
                    this.txtNum.Text = this.txtNum.Text.Substring(0, this.txtNum.Text.Length - 1);
                }
                else
                {
                    this.txtNum.Text = "";
                }
            }
            catch (Exception)
            {
            }
        }    

        private void FrmCalculator_Load_1(object sender, EventArgs e)
        {
            //this.CambiarColorFrmCalculator();
            LightAndDark.ContinueForm = "FrmCalculator";
            LightAndDark.OpenChild = false;
        }

        private void txtNum_Enter(object sender, EventArgs e)
        {
            this.QuitarCero();
        }

        public void CambiarColorFrmCalculator()
        {
            if (LightAndDark.ActiveLightDark == false)
            {
                //Formulario
                this.BackColor = Color.FromArgb(231, 231, 231);
                //CajaTexto
                this.txtNum.BackColor = Color.FromArgb(231, 231, 231);
                this.txtNum.ForeColor = Color.Black;
                //Botones
                //
                this.btnMasMenos.BackColor = Color.White;
                this.btnMasMenos.ForeColor = Color.Black;
                //
                this.btnCero.BackColor = Color.White;
                this.btnCero.ForeColor = Color.Black;
                //
                this.btnPunto.BackColor = Color.White;
                this.btnPunto.ForeColor = Color.Black;
                //
                this.btnUno.BackColor = Color.White;
                this.btnUno.ForeColor = Color.Black;
                //
                this.btnDos.BackColor = Color.White;
                this.btnDos.ForeColor = Color.Black;
                //
                this.btnTres.BackColor = Color.White;
                this.btnTres.ForeColor = Color.Black;
                //
                this.btnCuatro.BackColor = Color.White;
                this.btnCuatro.ForeColor = Color.Black;
                //
                this.btnCinco.BackColor = Color.White;
                this.btnCinco.ForeColor = Color.Black;
                //
                this.btnCinco.BackColor = Color.White;
                this.btnCinco.ForeColor = Color.Black;
                //
                this.btnSeis.BackColor = Color.White;
                this.btnSeis.ForeColor = Color.Black;
                //
                this.btnSiete.BackColor = Color.White;
                this.btnSiete.ForeColor = Color.Black;
                //
                this.btnOcho.BackColor = Color.White;
                this.btnOcho.ForeColor = Color.Black;
                //
                this.btnNueve.BackColor = Color.White;
                this.btnNueve.ForeColor = Color.Black;
                //
                this.btnSuma.BackColor = Color.White;
                //
                this.btnResta.BackColor = Color.White;
                //
                this.btnMultiplicacion.BackColor = Color.White;
                //
                this.btnDivision.BackColor = Color.White;
                //
                this.btnPorcentaje.BackColor = Color.White;
                //
                this.btnElevado.BackColor = Color.White;
                //
                this.btnClear.BackColor = Color.White;
                //
                this.btnDelete.BackColor = Color.FromArgb(231, 231, 231);
                //
                this.btnResultado.BackColor = Color.FromArgb(78, 179, 212);
                this.btnResultado.ForeColor = Color.Black;
            }
            else
            {
                //Formulario
                this.BackColor = Color.FromArgb(42, 42, 42);
                //CajaTexto
                this.txtNum.BackColor = Color.FromArgb(42, 42, 42);
                this.txtNum.ForeColor = Color.White;
                //Botones
                //
                this.btnMasMenos.BackColor = Color.FromArgb(64, 64, 64);
                this.btnMasMenos.ForeColor = Color.White;
                //
                this.btnCero.BackColor = Color.FromArgb(64, 64, 64);
                this.btnCero.ForeColor = Color.White;
                //
                this.btnPunto.BackColor = Color.FromArgb(64, 64, 64);
                this.btnPunto.ForeColor = Color.White;
                //
                this.btnUno.BackColor = Color.FromArgb(64, 64, 64);
                this.btnUno.ForeColor = Color.White;
                //
                this.btnDos.BackColor = Color.FromArgb(64, 64, 64);
                this.btnDos.ForeColor = Color.White;
                //
                this.btnTres.BackColor = Color.FromArgb(64, 64, 64);
                this.btnTres.ForeColor = Color.White;
                //
                this.btnCuatro.BackColor = Color.FromArgb(64, 64, 64);
                this.btnCuatro.ForeColor = Color.White;
                //
                this.btnCinco.BackColor = Color.FromArgb(64, 64, 64);
                this.btnCinco.ForeColor = Color.White;
                //
                this.btnCinco.BackColor = Color.FromArgb(64, 64, 64);
                this.btnCinco.ForeColor = Color.White;
                //
                this.btnSeis.BackColor = Color.FromArgb(64, 64, 64);
                this.btnSeis.ForeColor = Color.White;
                //
                this.btnSiete.BackColor = Color.FromArgb(64, 64, 64);
                this.btnSiete.ForeColor = Color.White;
                //
                this.btnOcho.BackColor = Color.FromArgb(64, 64, 64);
                this.btnOcho.ForeColor = Color.White;
                //
                this.btnNueve.BackColor = Color.FromArgb(64, 64, 64);
                this.btnNueve.ForeColor = Color.White;
                //
                this.btnSuma.BackColor = Color.FromArgb(64, 64, 64);
                //
                this.btnResta.BackColor = Color.FromArgb(64, 64, 64);
                //
                this.btnMultiplicacion.BackColor = Color.FromArgb(64, 64, 64);
                //
                this.btnDivision.BackColor = Color.FromArgb(64, 64, 64);
                //
                this.btnPorcentaje.BackColor = Color.FromArgb(64, 64, 64);
                //
                this.btnElevado.BackColor = Color.FromArgb(64, 64, 64);
                //
                this.btnClear.BackColor = Color.FromArgb(64, 64, 64);
                //
                this.btnDelete.BackColor = Color.FromArgb(42, 42, 42);
                //
                this.btnResultado.BackColor = Color.FromArgb(78, 179, 212);
                this.btnResultado.ForeColor = Color.White;
            }
        }

        private void MostrarResultado()
        {
            if (this.Continuar == 1)
            {
                this.Valor2 = Convert.ToDouble(this.txtNum.Text);
                this.ResultadoF();
                this.Continuar = 0;
            }
        }
    }
}
