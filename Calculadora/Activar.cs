using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculadora.Desing;

namespace Calculadora
{
    public partial class Activar : Form
    {
        public Activar()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            LightAndDark.OpenChild = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (LightAndDark.ActiveLightDark == false)
            {

                LightAndDark.ActiveLightDark = true;
            }
            else
            {
                LightAndDark.ActiveLightDark = false;
            }
            this.Close();
            LightAndDark.OpenChild = true;
        }

        private void Activar_Load(object sender, EventArgs e)
        {
            LightAndDark.OpenChild = false;
            if (LightAndDark.ActiveLightDark == false)
            {
                //Formulario
                this.BackColor = Color.FromArgb(231, 231, 231);
                //Texto
                this.label1.ForeColor = Color.Black;
                this.label1.Text = "¿Desea activar el modo oscuro?";
                //Botones
                this.btnAceptar.BackColor = Color.White;
                this.btnAceptar.ForeColor = Color.Black;
                this.btnCancelar.BackColor = Color.White;
                this.btnCancelar.ForeColor = Color.Black;
            }
            else
            {
                //formulario
                this.BackColor = Color.FromArgb(42, 42, 42);
                //Texto
                this.label1.ForeColor = Color.White;
                this.label1.Text = "¿Desea activar el modo claro?";
                //Botones
                this.btnAceptar.BackColor = Color.FromArgb(64, 64, 64);
                this.btnAceptar.ForeColor = Color.White;
                this.btnCancelar.BackColor = Color.FromArgb(64, 64, 64);
                this.btnCancelar.ForeColor = Color.White;
            }
        }
    }
}
