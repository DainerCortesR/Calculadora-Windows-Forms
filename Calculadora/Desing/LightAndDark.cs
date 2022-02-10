using System.Windows.Forms;
using System.Drawing;

namespace Calculadora.Desing
{
    class LightAndDark
    {
        public static bool ActiveLightDark = true;
        public static bool OpenChild = false;
        public static string ContinueForm = "";

        public static void LightDarkActive(Panel panel, Label lbl, TextBox txt1, TextBox txt2,
            F4ComboBox cmb1, F4ComboBox cmb2, F4Button btn1)
        {
            if (ActiveLightDark == false)
            {
                //Panel
                panel.BackColor = Color.FromArgb(231, 231, 231);
                //Texto
                lbl.ForeColor = Color.Black;
                //TextBox
                txt1.BackColor = Color.FromArgb(231, 231, 231);
                txt1.ForeColor = Color.Black;
                //
                txt2.BackColor = Color.FromArgb(231, 231, 231);
                txt2.ForeColor = Color.Black;
                //ComboBox
                cmb1.BackColor = Color.FromArgb(231, 231, 231);
                cmb1.IconColor = Color.Black;
                cmb1.ForeColor = Color.Black;
                //
                cmb2.BackColor = Color.FromArgb(231, 231, 231);
                cmb2.IconColor = Color.Black;
                cmb2.ForeColor = Color.Black;
                //Buton
                btn1.BackColor = Color.White;
                btn1.ForeColor = Color.Black;             
            }
            else
            {
                //Panel
                panel.BackColor = Color.FromArgb(42, 42, 42);
                //Texto
                lbl.ForeColor = Color.White;
                //TextBox
                txt1.BackColor = Color.FromArgb(42, 42, 42);
                txt1.ForeColor = Color.White;
                //
                txt2.BackColor = Color.FromArgb(42, 42, 42);
                txt2.ForeColor = Color.White;
                //ComboBox
                cmb1.BackColor = Color.FromArgb(42, 42, 42);
                cmb1.IconColor = Color.White;
                cmb1.ForeColor = Color.White;
                //
                cmb2.BackColor = Color.FromArgb(42, 42, 42);
                cmb2.IconColor = Color.White;
                cmb2.ForeColor = Color.White;
                //Buton
                btn1.BackColor = Color.FromArgb(64, 64, 64);
                btn1.ForeColor = Color.White;
            }
        }
    }
}
