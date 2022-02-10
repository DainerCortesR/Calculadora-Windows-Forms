using System;
using System.Linq;
using System.Windows.Forms;
using Calculadora.ClassFolder.Lenght;
using Calculadora.Desing;

namespace Calculadora
{
    public partial class FrmLength : Form
    {
        private string[] Longitudes = { "Nanómetros", "Micrones", "Milímetros", "Centímetros", "Metros", "Kilómetros", "Pulgadas", "Pies", "Yardas", "Millas", "Millas náuticas" };
        private double Valor = 0;
        private double Resultado = 0;

        public FrmLength()
        {
            InitializeComponent();
            LightAndDark.LightDarkActive(this.panel1, this.lblName, this.txtNum1, this.txtNum2,
            this.cmbUno, this.cmbDos, this.btnCalcular);
        }

        private void FrmLength_Load(object sender, EventArgs e)
        {
            try
            {
                LightAndDark.ContinueForm = "FrmLength";
                LightAndDark.OpenChild = false;

                foreach (var item in this.Longitudes)
                {
                    this.cmbUno.Items.Add(item);
                    this.cmbDos.Items.Add(item);
                }

                this.cmbUno.Texts = Longitudes[6];
                this.cmbDos.Texts = Longitudes[3];
            }
            catch (Exception)
            {
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

        private void MostrarResultado()
        {
            ClassLength cll = new ClassLength();
            this.Resultado = cll.Calcular(Convert.ToDouble(txtNum1.Text), this.cmbUno.Texts, this.cmbDos.Texts);
            //Metodos para calcular la conversión
            //Resultado en pantalla
            this.txtNum2.Text = this.Resultado.ToString();
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                this.MostrarResultado();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
    }
}
