using System;
using System.Windows.Forms;
using Calculadora.Desing;
using Calculadora.ClassFolder.Temperature;
using System.Linq;
using System.Drawing;

namespace Calculadora
{
    public partial class FrmTemperature : Form
    {
        private string[] TemperatureName = { "Celsius", "Fahrenheit", "Kelvin" };
        private double Resultado;

        public FrmTemperature()
        {
            InitializeComponent();
            LightAndDark.LightDarkActive(this.panel1, this.lblName, this.txtNum1, this.txtNum2,
            this.cmbUno, this.cmbDos, this.btnCalcular);
        }

        private void FrmTemperature_Load(object sender, EventArgs e)
        {
            try
            {
                LightAndDark.ContinueForm = "FrmTemperature";
                LightAndDark.OpenChild = false;

                if (LightAndDark.ActiveLightDark == false)
                {
                    btnMasMenos.BackColor = Color.White;
                    btnMasMenos.ForeColor = Color.Black;
                }
                else
                {
                    btnMasMenos.BackColor = Color.FromArgb(64, 64, 64);
                    btnMasMenos.ForeColor = Color.White;
                }
                foreach (var item in this.TemperatureName)
                {
                    this.cmbUno.Items.Add(item);
                    this.cmbDos.Items.Add(item);
                }

                this.cmbUno.Texts = this.TemperatureName[0];
                this.cmbDos.Texts = this.TemperatureName[2];
            }
            catch (Exception)
            {
            }
        }

        private void ContarPuntos(KeyPressEventArgs e)
        {
            int index = 0;

            if (this.txtNum1.Text.Contains("."))
            {
                index += 1;
            }

            if (index >= 1)
            {
                if (".".Contains(e.KeyChar))
                {
                    e.Handled = true;
                }
                index = 0;
            }
        }

        private void txtNum1_Enter(object sender, EventArgs e)
        {
            if (this.txtNum1.Text == "0")
            {
                this.txtNum1.Text = "";
            }
        }

        private void txtNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !".".Contains(e.KeyChar))
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;

                    if (txtNum1.Text.Count() > 15)
                    {
                        e.Handled = true;

                        if (!char.IsControl(e.KeyChar))
                        {
                            e.Handled = true;
                        }
                        else
                        {
                            e.Handled = false;
                        }
                    }
                }
                this.ContarPuntos(e);
            }
            catch (Exception)
            {
            }
        }

        private void txtNum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void MostrarResultado()
        {
            ClassTemperature ctm = new ClassTemperature();
            //Metodos para calcular la conversión
            this.Resultado = ctm.Calcular(Convert.ToDouble(txtNum1.Text), this.cmbUno.Texts, this.cmbDos.Texts);
            //Resultado en pantalla
            this.txtNum2.Text = this.Resultado.ToString();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                this.MostrarResultado();
            }
            catch (Exception)
            {
            }
        }

        private void txtNum1_KeyDown(object sender, KeyEventArgs e)
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

        private string RemoveNegative(string text, int num)
        {
            return text.Remove(num, 1);
        }

        private void btnMasMenos_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtNum1.Text.Count() > 0 && this.txtNum1.Text != "0")
                {
                    if (this.txtNum1.Text.Contains("-"))
                    {
                        this.txtNum1.Text = this.RemoveNegative(this.txtNum1.Text, 0);
                    }
                    else
                    {
                        this.txtNum1.Text = '-' + this.txtNum1.Text;
                    }
                }               
            }
            catch (Exception)
            {
            }
        }
    }
}
