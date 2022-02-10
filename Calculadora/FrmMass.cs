using System;
using System.Linq;
using System.Windows.Forms;
using Calculadora.Desing;
using Calculadora.ClassFolder.Mass;

namespace Calculadora
{
    public partial class FrmMass : Form
    {
        private string[] Masa = { "Toneladas", "Toneladas largas (Reino Unido)", "Toneladas cortas (EE.UU.)", "Libras", "Onzas", "Kilogramos", "Gramos" };
        private double Resultado;
        
        public FrmMass()
        {
            InitializeComponent();
            LightAndDark.LightDarkActive(this.panel1, this.lblName, this.txtNum1, this.txtNum2,
            this.cmbUno, this.cmbDos, this.btnCalcular);
        }

        private void FrmWeight_Load(object sender, EventArgs e)
        {
            try
            {
                LightAndDark.ContinueForm = "FrmMass";
                LightAndDark.OpenChild = false;

                foreach (var item in this.Masa)
                {
                    this.cmbUno.Items.Add(item);
                    this.cmbDos.Items.Add(item);
                }
                this.cmbUno.Texts = Masa[3];
                this.cmbDos.Texts = Masa[5];
            }
            catch (Exception)
            {
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

        private void MostrarResultado()
        {
            ClassMass clm = new ClassMass();
            //Metodos para calcular la conversión
            this.Resultado = clm.Calcular(Convert.ToDouble(txtNum1.Text), this.cmbUno.Texts, this.cmbDos.Texts);
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
    }
}
