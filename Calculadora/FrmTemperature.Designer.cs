
namespace Calculadora
{
    partial class FrmTemperature
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.btnCalcular = new Calculadora.Desing.F4Button();
            this.cmbDos = new Calculadora.Desing.F4ComboBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.cmbUno = new Calculadora.Desing.F4ComboBox();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.btnMasMenos = new Calculadora.Desing.F4Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMasMenos);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.btnCalcular);
            this.panel1.Controls.Add(this.cmbDos);
            this.panel1.Controls.Add(this.txtNum2);
            this.panel1.Controls.Add(this.cmbUno);
            this.panel1.Controls.Add(this.txtNum1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 507);
            this.panel1.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(186, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(152, 29);
            this.lblName.TabIndex = 27;
            this.lblName.Text = "Temperatura";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCalcular.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCalcular.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCalcular.BorderRadius = 50;
            this.btnCalcular.BorderSize = 0;
            this.btnCalcular.FlatAppearance.BorderSize = 0;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(102, 407);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(150, 50);
            this.btnCalcular.TabIndex = 26;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // cmbDos
            // 
            this.cmbDos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.cmbDos.BorderColor = System.Drawing.Color.White;
            this.cmbDos.BorderSize = 0;
            this.cmbDos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbDos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDos.ForeColor = System.Drawing.Color.White;
            this.cmbDos.IconColor = System.Drawing.Color.White;
            this.cmbDos.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbDos.ListTextColor = System.Drawing.Color.White;
            this.cmbDos.Location = new System.Drawing.Point(28, 289);
            this.cmbDos.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbDos.Name = "cmbDos";
            this.cmbDos.Size = new System.Drawing.Size(296, 30);
            this.cmbDos.TabIndex = 25;
            this.cmbDos.Texts = "";
            // 
            // txtNum2
            // 
            this.txtNum2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.txtNum2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNum2.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum2.ForeColor = System.Drawing.Color.White;
            this.txtNum2.Location = new System.Drawing.Point(26, 238);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(298, 33);
            this.txtNum2.TabIndex = 24;
            this.txtNum2.Text = "0";
            this.txtNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNum2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum2_KeyPress);
            // 
            // cmbUno
            // 
            this.cmbUno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.cmbUno.BorderColor = System.Drawing.Color.White;
            this.cmbUno.BorderSize = 0;
            this.cmbUno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbUno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUno.ForeColor = System.Drawing.Color.White;
            this.cmbUno.IconColor = System.Drawing.Color.White;
            this.cmbUno.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbUno.ListTextColor = System.Drawing.Color.White;
            this.cmbUno.Location = new System.Drawing.Point(26, 135);
            this.cmbUno.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbUno.Name = "cmbUno";
            this.cmbUno.Size = new System.Drawing.Size(296, 30);
            this.cmbUno.TabIndex = 23;
            this.cmbUno.Texts = "";
            // 
            // txtNum1
            // 
            this.txtNum1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.txtNum1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNum1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum1.ForeColor = System.Drawing.Color.White;
            this.txtNum1.Location = new System.Drawing.Point(24, 85);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(298, 33);
            this.txtNum1.TabIndex = 22;
            this.txtNum1.Text = "0";
            this.txtNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNum1.Enter += new System.EventHandler(this.txtNum1_Enter);
            this.txtNum1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNum1_KeyDown);
            this.txtNum1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum1_KeyPress);
            // 
            // btnMasMenos
            // 
            this.btnMasMenos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMasMenos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMasMenos.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMasMenos.BorderRadius = 35;
            this.btnMasMenos.BorderSize = 0;
            this.btnMasMenos.FlatAppearance.BorderSize = 0;
            this.btnMasMenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasMenos.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMasMenos.ForeColor = System.Drawing.Color.White;
            this.btnMasMenos.Location = new System.Drawing.Point(28, 44);
            this.btnMasMenos.Name = "btnMasMenos";
            this.btnMasMenos.Size = new System.Drawing.Size(35, 35);
            this.btnMasMenos.TabIndex = 28;
            this.btnMasMenos.Text = "+/-";
            this.btnMasMenos.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMasMenos.UseVisualStyleBackColor = false;
            this.btnMasMenos.Click += new System.EventHandler(this.btnMasMenos_Click);
            // 
            // FrmTemperature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(350, 507);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTemperature";
            this.Text = "FrmTemperature";
            this.Load += new System.EventHandler(this.FrmTemperature_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblName;
        private Desing.F4Button btnCalcular;
        private Desing.F4ComboBox cmbDos;
        private System.Windows.Forms.TextBox txtNum2;
        private Desing.F4ComboBox cmbUno;
        private System.Windows.Forms.TextBox txtNum1;
        private Desing.F4Button btnMasMenos;
    }
}