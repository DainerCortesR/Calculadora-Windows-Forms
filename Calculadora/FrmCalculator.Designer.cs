
namespace Calculadora
{
    partial class FrmCalculator
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalculator));
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lblAcumulador = new System.Windows.Forms.Label();
            this.btnClear = new Calculadora.Desing.F4Button();
            this.btnDivision = new Calculadora.Desing.F4Button();
            this.btnResta = new Calculadora.Desing.F4Button();
            this.btnMultiplicacion = new Calculadora.Desing.F4Button();
            this.btnDelete = new Calculadora.Desing.F4Button();
            this.btnPunto = new Calculadora.Desing.F4Button();
            this.btnResultado = new Calculadora.Desing.F4Button();
            this.btnCero = new Calculadora.Desing.F4Button();
            this.btnMasMenos = new Calculadora.Desing.F4Button();
            this.btnTres = new Calculadora.Desing.F4Button();
            this.btnSuma = new Calculadora.Desing.F4Button();
            this.btnDos = new Calculadora.Desing.F4Button();
            this.btnUno = new Calculadora.Desing.F4Button();
            this.btnSeis = new Calculadora.Desing.F4Button();
            this.btnCinco = new Calculadora.Desing.F4Button();
            this.btnCuatro = new Calculadora.Desing.F4Button();
            this.btnNueve = new Calculadora.Desing.F4Button();
            this.btnOcho = new Calculadora.Desing.F4Button();
            this.btnSiete = new Calculadora.Desing.F4Button();
            this.btnPorcentaje = new Calculadora.Desing.F4Button();
            this.btnElevado = new Calculadora.Desing.F4Button();
            this.SuspendLayout();
            // 
            // txtNum
            // 
            this.txtNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.txtNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNum.Font = new System.Drawing.Font("Verdana", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum.ForeColor = System.Drawing.Color.White;
            this.txtNum.Location = new System.Drawing.Point(25, 5);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(298, 49);
            this.txtNum.TabIndex = 5;
            this.txtNum.Text = "0";
            this.txtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNum.Enter += new System.EventHandler(this.txtNum_Enter);
            this.txtNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNum_KeyDown);
            this.txtNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum_KeyPress);
            // 
            // lblAcumulador
            // 
            this.lblAcumulador.AutoSize = true;
            this.lblAcumulador.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcumulador.ForeColor = System.Drawing.Color.Gray;
            this.lblAcumulador.Location = new System.Drawing.Point(33, 60);
            this.lblAcumulador.MaximumSize = new System.Drawing.Size(228, 18);
            this.lblAcumulador.Name = "lblAcumulador";
            this.lblAcumulador.Size = new System.Drawing.Size(0, 18);
            this.lblAcumulador.TabIndex = 29;
            this.lblAcumulador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClear.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClear.BorderRadius = 70;
            this.btnClear.BorderSize = 0;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.btnClear.Location = new System.Drawing.Point(25, 113);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(70, 70);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "C";
            this.btnClear.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDivision.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDivision.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDivision.BorderRadius = 70;
            this.btnDivision.BorderSize = 0;
            this.btnDivision.FlatAppearance.BorderSize = 0;
            this.btnDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivision.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivision.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(179)))), ((int)(((byte)(212)))));
            this.btnDivision.Location = new System.Drawing.Point(253, 116);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(70, 70);
            this.btnDivision.TabIndex = 27;
            this.btnDivision.Text = " /";
            this.btnDivision.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDivision.UseVisualStyleBackColor = false;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnResta
            // 
            this.btnResta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnResta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnResta.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnResta.BorderRadius = 70;
            this.btnResta.BorderSize = 0;
            this.btnResta.FlatAppearance.BorderSize = 0;
            this.btnResta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResta.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(179)))), ((int)(((byte)(212)))));
            this.btnResta.Location = new System.Drawing.Point(253, 268);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(70, 70);
            this.btnResta.TabIndex = 26;
            this.btnResta.Text = "  -";
            this.btnResta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResta.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnResta.UseVisualStyleBackColor = false;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btnMultiplicacion
            // 
            this.btnMultiplicacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMultiplicacion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMultiplicacion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMultiplicacion.BorderRadius = 70;
            this.btnMultiplicacion.BorderSize = 0;
            this.btnMultiplicacion.FlatAppearance.BorderSize = 0;
            this.btnMultiplicacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiplicacion.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(179)))), ((int)(((byte)(212)))));
            this.btnMultiplicacion.Location = new System.Drawing.Point(253, 192);
            this.btnMultiplicacion.Name = "btnMultiplicacion";
            this.btnMultiplicacion.Size = new System.Drawing.Size(70, 70);
            this.btnMultiplicacion.TabIndex = 25;
            this.btnMultiplicacion.Text = "× ";
            this.btnMultiplicacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMultiplicacion.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMultiplicacion.UseVisualStyleBackColor = false;
            this.btnMultiplicacion.Click += new System.EventHandler(this.btnMultiplicacion_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnDelete.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnDelete.BorderRadius = 50;
            this.btnDelete.BorderSize = 0;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(266, 60);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(50, 50);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPunto
            // 
            this.btnPunto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPunto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPunto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPunto.BorderRadius = 70;
            this.btnPunto.BorderSize = 0;
            this.btnPunto.FlatAppearance.BorderSize = 0;
            this.btnPunto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPunto.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPunto.ForeColor = System.Drawing.Color.White;
            this.btnPunto.Location = new System.Drawing.Point(177, 418);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(70, 70);
            this.btnPunto.TabIndex = 21;
            this.btnPunto.Text = ".";
            this.btnPunto.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPunto.UseVisualStyleBackColor = false;
            this.btnPunto.Click += new System.EventHandler(this.btnPunto_Click);
            // 
            // btnResultado
            // 
            this.btnResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(179)))), ((int)(((byte)(212)))));
            this.btnResultado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(179)))), ((int)(((byte)(212)))));
            this.btnResultado.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(179)))), ((int)(((byte)(212)))));
            this.btnResultado.BorderRadius = 70;
            this.btnResultado.BorderSize = 0;
            this.btnResultado.FlatAppearance.BorderSize = 0;
            this.btnResultado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResultado.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultado.ForeColor = System.Drawing.Color.White;
            this.btnResultado.Location = new System.Drawing.Point(253, 418);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(70, 70);
            this.btnResultado.TabIndex = 2;
            this.btnResultado.Text = "= ";
            this.btnResultado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResultado.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(179)))), ((int)(((byte)(212)))));
            this.btnResultado.UseVisualStyleBackColor = false;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // btnCero
            // 
            this.btnCero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCero.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCero.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCero.BorderRadius = 70;
            this.btnCero.BorderSize = 0;
            this.btnCero.FlatAppearance.BorderSize = 0;
            this.btnCero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCero.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCero.ForeColor = System.Drawing.Color.White;
            this.btnCero.Location = new System.Drawing.Point(101, 417);
            this.btnCero.Name = "btnCero";
            this.btnCero.Size = new System.Drawing.Size(70, 70);
            this.btnCero.TabIndex = 19;
            this.btnCero.Text = "0";
            this.btnCero.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCero.UseVisualStyleBackColor = false;
            this.btnCero.Click += new System.EventHandler(this.btnCero_Click);
            // 
            // btnMasMenos
            // 
            this.btnMasMenos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMasMenos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMasMenos.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMasMenos.BorderRadius = 70;
            this.btnMasMenos.BorderSize = 0;
            this.btnMasMenos.FlatAppearance.BorderSize = 0;
            this.btnMasMenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasMenos.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMasMenos.ForeColor = System.Drawing.Color.White;
            this.btnMasMenos.Location = new System.Drawing.Point(25, 417);
            this.btnMasMenos.Name = "btnMasMenos";
            this.btnMasMenos.Size = new System.Drawing.Size(70, 70);
            this.btnMasMenos.TabIndex = 18;
            this.btnMasMenos.Text = "+/-";
            this.btnMasMenos.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMasMenos.UseVisualStyleBackColor = false;
            this.btnMasMenos.Click += new System.EventHandler(this.btnMasMenos_Click);
            // 
            // btnTres
            // 
            this.btnTres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTres.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTres.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTres.BorderRadius = 70;
            this.btnTres.BorderSize = 0;
            this.btnTres.FlatAppearance.BorderSize = 0;
            this.btnTres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTres.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTres.ForeColor = System.Drawing.Color.White;
            this.btnTres.Location = new System.Drawing.Point(177, 342);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(70, 70);
            this.btnTres.TabIndex = 17;
            this.btnTres.Text = "3";
            this.btnTres.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTres.UseVisualStyleBackColor = false;
            this.btnTres.Click += new System.EventHandler(this.btnTres_Click);
            // 
            // btnSuma
            // 
            this.btnSuma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSuma.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSuma.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSuma.BorderRadius = 70;
            this.btnSuma.BorderSize = 0;
            this.btnSuma.FlatAppearance.BorderSize = 0;
            this.btnSuma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuma.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(179)))), ((int)(((byte)(212)))));
            this.btnSuma.Location = new System.Drawing.Point(253, 342);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(70, 70);
            this.btnSuma.TabIndex = 16;
            this.btnSuma.Text = "+ ";
            this.btnSuma.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuma.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSuma.UseVisualStyleBackColor = false;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnDos
            // 
            this.btnDos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDos.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDos.BorderRadius = 70;
            this.btnDos.BorderSize = 0;
            this.btnDos.FlatAppearance.BorderSize = 0;
            this.btnDos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDos.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDos.ForeColor = System.Drawing.Color.White;
            this.btnDos.Location = new System.Drawing.Point(101, 341);
            this.btnDos.Name = "btnDos";
            this.btnDos.Size = new System.Drawing.Size(70, 70);
            this.btnDos.TabIndex = 15;
            this.btnDos.Text = "2";
            this.btnDos.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDos.UseVisualStyleBackColor = false;
            this.btnDos.Click += new System.EventHandler(this.btnDos_Click);
            // 
            // btnUno
            // 
            this.btnUno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUno.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUno.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUno.BorderRadius = 70;
            this.btnUno.BorderSize = 0;
            this.btnUno.FlatAppearance.BorderSize = 0;
            this.btnUno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUno.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUno.ForeColor = System.Drawing.Color.White;
            this.btnUno.Location = new System.Drawing.Point(25, 341);
            this.btnUno.Name = "btnUno";
            this.btnUno.Size = new System.Drawing.Size(70, 70);
            this.btnUno.TabIndex = 14;
            this.btnUno.Text = "1";
            this.btnUno.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUno.UseVisualStyleBackColor = false;
            this.btnUno.Click += new System.EventHandler(this.btnUno_Click);
            // 
            // btnSeis
            // 
            this.btnSeis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSeis.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSeis.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSeis.BorderRadius = 70;
            this.btnSeis.BorderSize = 0;
            this.btnSeis.FlatAppearance.BorderSize = 0;
            this.btnSeis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeis.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeis.ForeColor = System.Drawing.Color.White;
            this.btnSeis.Location = new System.Drawing.Point(177, 266);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(70, 70);
            this.btnSeis.TabIndex = 13;
            this.btnSeis.Text = "6";
            this.btnSeis.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSeis.UseVisualStyleBackColor = false;
            this.btnSeis.Click += new System.EventHandler(this.btnSeis_Click);
            // 
            // btnCinco
            // 
            this.btnCinco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCinco.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCinco.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCinco.BorderRadius = 70;
            this.btnCinco.BorderSize = 0;
            this.btnCinco.FlatAppearance.BorderSize = 0;
            this.btnCinco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCinco.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCinco.ForeColor = System.Drawing.Color.White;
            this.btnCinco.Location = new System.Drawing.Point(101, 265);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(70, 70);
            this.btnCinco.TabIndex = 11;
            this.btnCinco.Text = "5";
            this.btnCinco.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCinco.UseVisualStyleBackColor = false;
            this.btnCinco.Click += new System.EventHandler(this.btnCinco_Click);
            // 
            // btnCuatro
            // 
            this.btnCuatro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCuatro.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCuatro.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCuatro.BorderRadius = 70;
            this.btnCuatro.BorderSize = 0;
            this.btnCuatro.FlatAppearance.BorderSize = 0;
            this.btnCuatro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuatro.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuatro.ForeColor = System.Drawing.Color.White;
            this.btnCuatro.Location = new System.Drawing.Point(25, 265);
            this.btnCuatro.Name = "btnCuatro";
            this.btnCuatro.Size = new System.Drawing.Size(70, 70);
            this.btnCuatro.TabIndex = 10;
            this.btnCuatro.Text = "4";
            this.btnCuatro.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCuatro.UseVisualStyleBackColor = false;
            this.btnCuatro.Click += new System.EventHandler(this.btnCuatro_Click);
            // 
            // btnNueve
            // 
            this.btnNueve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNueve.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNueve.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNueve.BorderRadius = 70;
            this.btnNueve.BorderSize = 0;
            this.btnNueve.FlatAppearance.BorderSize = 0;
            this.btnNueve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNueve.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNueve.ForeColor = System.Drawing.Color.White;
            this.btnNueve.Location = new System.Drawing.Point(177, 189);
            this.btnNueve.Name = "btnNueve";
            this.btnNueve.Size = new System.Drawing.Size(70, 70);
            this.btnNueve.TabIndex = 9;
            this.btnNueve.Text = "9";
            this.btnNueve.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNueve.UseVisualStyleBackColor = false;
            this.btnNueve.Click += new System.EventHandler(this.btnNueve_Click);
            // 
            // btnOcho
            // 
            this.btnOcho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOcho.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOcho.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOcho.BorderRadius = 70;
            this.btnOcho.BorderSize = 0;
            this.btnOcho.FlatAppearance.BorderSize = 0;
            this.btnOcho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOcho.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOcho.ForeColor = System.Drawing.Color.White;
            this.btnOcho.Location = new System.Drawing.Point(101, 189);
            this.btnOcho.Name = "btnOcho";
            this.btnOcho.Size = new System.Drawing.Size(70, 70);
            this.btnOcho.TabIndex = 7;
            this.btnOcho.Text = "8";
            this.btnOcho.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOcho.UseVisualStyleBackColor = false;
            this.btnOcho.Click += new System.EventHandler(this.btnOcho_Click);
            // 
            // btnSiete
            // 
            this.btnSiete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSiete.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSiete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSiete.BorderRadius = 70;
            this.btnSiete.BorderSize = 0;
            this.btnSiete.FlatAppearance.BorderSize = 0;
            this.btnSiete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiete.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiete.ForeColor = System.Drawing.Color.White;
            this.btnSiete.Location = new System.Drawing.Point(25, 189);
            this.btnSiete.Name = "btnSiete";
            this.btnSiete.Size = new System.Drawing.Size(70, 70);
            this.btnSiete.TabIndex = 6;
            this.btnSiete.Text = "7";
            this.btnSiete.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSiete.UseVisualStyleBackColor = false;
            this.btnSiete.Click += new System.EventHandler(this.btnSiete_Click);
            // 
            // btnPorcentaje
            // 
            this.btnPorcentaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPorcentaje.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPorcentaje.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPorcentaje.BorderRadius = 70;
            this.btnPorcentaje.BorderSize = 0;
            this.btnPorcentaje.FlatAppearance.BorderSize = 0;
            this.btnPorcentaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPorcentaje.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPorcentaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(179)))), ((int)(((byte)(212)))));
            this.btnPorcentaje.Location = new System.Drawing.Point(177, 113);
            this.btnPorcentaje.Name = "btnPorcentaje";
            this.btnPorcentaje.Size = new System.Drawing.Size(70, 70);
            this.btnPorcentaje.TabIndex = 4;
            this.btnPorcentaje.Text = " %";
            this.btnPorcentaje.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPorcentaje.UseVisualStyleBackColor = false;
            this.btnPorcentaje.Click += new System.EventHandler(this.btnPorcentaje_Click);
            // 
            // btnElevado
            // 
            this.btnElevado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnElevado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnElevado.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnElevado.BorderRadius = 70;
            this.btnElevado.BorderSize = 0;
            this.btnElevado.FlatAppearance.BorderSize = 0;
            this.btnElevado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElevado.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElevado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(179)))), ((int)(((byte)(212)))));
            this.btnElevado.Location = new System.Drawing.Point(101, 113);
            this.btnElevado.Name = "btnElevado";
            this.btnElevado.Size = new System.Drawing.Size(70, 70);
            this.btnElevado.TabIndex = 25;
            this.btnElevado.Text = "^2";
            this.btnElevado.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnElevado.UseVisualStyleBackColor = false;
            this.btnElevado.Click += new System.EventHandler(this.btnElevado_Click);
            // 
            // FrmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(350, 507);
            this.Controls.Add(this.lblAcumulador);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnMultiplicacion);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnPunto);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.btnCero);
            this.Controls.Add(this.btnMasMenos);
            this.Controls.Add(this.btnTres);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.btnDos);
            this.Controls.Add(this.btnUno);
            this.Controls.Add(this.btnSeis);
            this.Controls.Add(this.btnCinco);
            this.Controls.Add(this.btnCuatro);
            this.Controls.Add(this.btnNueve);
            this.Controls.Add(this.btnOcho);
            this.Controls.Add(this.btnSiete);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.btnPorcentaje);
            this.Controls.Add(this.btnElevado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmCalculator_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Desing.F4Button btnElevado;
        private Desing.F4Button btnPorcentaje;
        private System.Windows.Forms.TextBox txtNum;
        private Desing.F4Button btnNueve;
        private Desing.F4Button btnOcho;
        private Desing.F4Button btnSiete;
        private Desing.F4Button btnSeis;
        private Desing.F4Button btnCinco;
        private Desing.F4Button btnCuatro;
        private Desing.F4Button btnTres;
        private Desing.F4Button btnSuma;
        private Desing.F4Button btnDos;
        private Desing.F4Button btnUno;
        private Desing.F4Button btnPunto;
        private Desing.F4Button btnResultado;
        private Desing.F4Button btnCero;
        private Desing.F4Button btnMasMenos;
        private Desing.F4Button btnDelete;
        private Desing.F4Button btnMultiplicacion;
        private Desing.F4Button btnResta;
        private Desing.F4Button btnDivision;
        private Desing.F4Button btnClear;
        private System.Windows.Forms.Label lblAcumulador;
    }
}

