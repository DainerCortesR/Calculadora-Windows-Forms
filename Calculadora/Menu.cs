using System;
using System.Drawing;
using System.Windows.Forms;
using Calculadora.Desing;
using System.Diagnostics;

namespace Calculadora
{
    public partial class Menu : Form
    {
        private bool Activate = true;
        private int poX = 0;
        private int poY = 0;

        public Menu()
        {
            InitializeComponent();
        }

        //Boton cerrar programa
        private void pictExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void pictExit_MouseEnter(object sender, EventArgs e)
        {
            pictExit.Image = Properties.Resources.GrayExitsHover;
        }
        private void pictExit_MouseLeave(object sender, EventArgs e)
        {
            if (LightAndDark.ActiveLightDark == false)
            {
                this.pictExit.Image = Properties.Resources.ImgExits;
            }
            else
            {
                this.pictExit.Image = Properties.Resources.GrayExitsClic;
            }
        }
     
        //Boton minimizar programa
        private void pictMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictMinimize_MouseEnter(object sender, EventArgs e)
        {
            pictMinimize.Image = Properties.Resources.GrayMinimizedHover;
        }

        private void pictMinimize_MouseLeave(object sender, EventArgs e)
        {
            if (LightAndDark.ActiveLightDark == false)
            {
                this.pictMinimize.Image = Properties.Resources.ImgMinimize;
            }
            else
            {
                this.pictMinimize.Image = Properties.Resources.GrayMinimizedClic;
            }
        }

        //Ejecutar al iniciar el programa
        private void Menu_Load(object sender, EventArgs e)
        {
            this.MenuMO();
            this.OpenChild(new FrmCalculator());
            this.FormularioActivo();
        }

        //Metodo para mover el formulario
        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                this.poX = e.X;
                this.poY = e.Y;
            }
            else
            {
                Left = Left + (e.X - this.poX);
                Top = Top + (e.Y - this.poY);
            }
        }

        //Motodo para abrir el formulario hijo
        private void OpenChild(object Frm)
        {
            if (this.panelContainer.Controls.Count > 0)
            {
                panelContainer.Controls.RemoveAt(0);
            }

            Form f = Frm as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(f);
            panelContainer.Tag = f;
            f.Show();
        }

        //Metodo para ocultar el menu
        private void MenuMO()
        {

            if (this.Activate == true)
            {
                this.Width = 350;
                this.Height = 553;
                this.pictMenu.Visible = true;
                this.panelMenu.Visible = false;
                this.btnCalculator.Visible = false;
                this.btnStandard.Visible = false;
                this.btnConverter.Visible = false;
                this.btnLength.Visible = false;
                this.btnMass.Visible = false;
                this.btnTemperature.Visible = false;
                this.Activate = false;
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.MenuMO();
        }

        //Metodo para mostrar el menu
        private void pictMenu_Click(object sender, EventArgs e)
        {
            if (Activate == false)
            {
                this.Width = 550;
                this.Height = 553;
                this.pictMenu.Visible = false;
                this.panelMenu.Visible = true;
                this.btnCalculator.Visible = true;
                this.btnStandard.Visible = true;
                this.btnConverter.Visible = true;
                this.btnLength.Visible = true;
                this.btnMass.Visible = true;
                this.btnTemperature.Visible = true;
                this.Activate = true;
            }
        }

        private void btnStandard_Click(object sender, EventArgs e)
        {
            this.OpenChild(new FrmCalculator());
            this.MenuMO();
            this.FormularioActivo();
        }

        private void btnLength_Click(object sender, EventArgs e)
        {
            this.OpenChild(new FrmLength());
            this.MenuMO();
            this.FormularioActivo();
        }

        private void btnWeight_Click(object sender, EventArgs e)
        {
            this.OpenChild(new FrmMass());
            this.MenuMO();
            this.FormularioActivo();
        }

        private void btnTemperature_Click(object sender, EventArgs e)
        {
            this.OpenChild(new FrmTemperature());
            this.MenuMO();
            this.FormularioActivo();
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {        
            Process.Start("https://github.com/DainerCortesR");
            this.MenuMO();
        }

        private void btnClaroOscuro_Click(object sender, EventArgs e)
        {       
            OpenChild(new Activar());
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Interval == 100)
            {
                this.CambiarColor();
                if (LightAndDark.ActiveLightDark == false)
                {

                    picClaroOscuro.Image = Properties.Resources.Modo_oscuro;
                }
                else
                {
                    picClaroOscuro.Image = Properties.Resources.Modo_claro;
                }
            }
            if (LightAndDark.OpenChild == true)
            {
                switch (LightAndDark.ContinueForm)
                {
                    case "FrmCalculator":
                        this.OpenChild(new FrmCalculator());
                        break;
                    case "FrmLength":
                        this.OpenChild(new FrmLength());
                        break;
                    case "FrmTemperature":
                        this.OpenChild(new FrmTemperature());
                        break;
                    case "FrmMass":
                        this.OpenChild(new FrmMass());
                        break;
                    default:
                        break;
                }
                this.FormularioActivo();
                this.timer1.Stop();
            }
        }

        private void BotonesOscuros()
        {
            //Botones
            this.btnStandard.BackColor = Color.FromArgb(72, 72, 72);
            this.btnLength.BackColor = Color.FromArgb(72, 72, 72);
            this.btnMass.BackColor = Color.FromArgb(72, 72, 72);
            this.btnTemperature.BackColor = Color.FromArgb(72, 72, 72);
            this.btnInformation.BackColor = Color.FromArgb(72, 72, 72);
        }

        private void BotonesClaros()
        {
            //Botones
            this.btnStandard.BackColor = Color.FromArgb(243, 243, 243);
            this.btnLength.BackColor = Color.FromArgb(243, 243, 243);
            this.btnMass.BackColor = Color.FromArgb(243, 243, 243);
            this.btnTemperature.BackColor = Color.FromArgb(243, 243, 243);
            this.btnInformation.BackColor = Color.FromArgb(243, 243, 243);
        }

        private void CambiarColor()
        {
            if (LightAndDark.ActiveLightDark == false)
            {
                //Formulario
                this.BackColor = Color.FromArgb(231, 231, 231);
                //Paneles
                this.panelMenu.BackColor = Color.FromArgb(243, 243, 243);
                //Botones
                this.btnCalculator.ForeColor = Color.Black;
                this.btnStandard.ForeColor = Color.Black;
                this.btnConverter.ForeColor = Color.Black;
                this.btnLength.ForeColor = Color.Black;
                this.btnMass.ForeColor = Color.Black;
                this.btnTemperature.ForeColor = Color.Black;
                this.btnInformation.ForeColor = Color.Black;
                //
                this.btnMenu.Image = Properties.Resources.MenuBlack;
                this.pictMenu.Image = Properties.Resources.MenuBlack;
                //
                this.pictExit.Image = Properties.Resources.ImgExits;
                this.pictMinimize.Image = Properties.Resources.ImgMinimize;
              
            }
            else
            {
                //Formulario
                this.BackColor = Color.FromArgb(42, 42, 42);
                //Paneles
                this.panelMenu.BackColor = Color.FromArgb(72, 72, 72);
                //Botones
                this.btnCalculator.ForeColor = Color.White;
                this.btnStandard.ForeColor = Color.White;
                this.btnConverter.ForeColor = Color.White;
                this.btnLength.ForeColor = Color.White;
                this.btnMass.ForeColor = Color.White;
                this.btnTemperature.ForeColor = Color.White;
                this.btnInformation.ForeColor = Color.White;
                //
                this.btnMenu.Image = Properties.Resources.Menu;
                this.pictMenu.Image = Properties.Resources.Menu;
                //
                this.pictExit.Image = Properties.Resources.GrayExitsClic;
                this.pictMinimize.Image = Properties.Resources.GrayMinimizedClic;
            }
        }

        private void FormularioActivo()
        {
            if (LightAndDark.ActiveLightDark == false)
            {       
                if (LightAndDark.ContinueForm == "FrmCalculator")
                {
                    this.BotonesClaros();
                    this.btnStandard.BackColor = Color.FromArgb(218, 218, 218);
                }
                else if (LightAndDark.ContinueForm == "FrmLength")
                {
                    this.BotonesClaros();
                    this.btnLength.BackColor = Color.FromArgb(218, 218, 218);
                }
                else if (LightAndDark.ContinueForm == "FrmTemperature")
                {
                    this.BotonesClaros();
                    this.btnTemperature.BackColor = Color.FromArgb(218, 218, 218);
                }
                else if (LightAndDark.ContinueForm == "FrmMass")
                {
                    this.BotonesClaros();
                    this.btnMass.BackColor = Color.FromArgb(218, 218, 218);
                }
            }
            else
            {
                if (LightAndDark.ContinueForm == "FrmCalculator")
                {
                    this.BotonesOscuros();
                    this.btnStandard.BackColor = Color.FromArgb(86, 86, 86);
                }
                else if (LightAndDark.ContinueForm == "FrmLength")
                {
                    this.BotonesOscuros();
                    this.btnLength.BackColor = Color.FromArgb(86, 86, 86);
                }
                else if (LightAndDark.ContinueForm == "FrmTemperature")
                {
                    this.BotonesOscuros();
                    this.btnTemperature.BackColor = Color.FromArgb(86, 86, 86);
                }
                else if (LightAndDark.ContinueForm == "FrmMass")
                {
                    this.BotonesOscuros();
                    this.btnMass.BackColor = Color.FromArgb(86, 86, 86);
                }
            }      
        }
    }
}
