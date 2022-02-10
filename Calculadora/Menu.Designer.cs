
namespace Calculadora
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnInformation = new System.Windows.Forms.Button();
            this.btnTemperature = new System.Windows.Forms.Button();
            this.btnMass = new System.Windows.Forms.Button();
            this.btnLength = new System.Windows.Forms.Button();
            this.btnConverter = new System.Windows.Forms.Button();
            this.btnStandard = new System.Windows.Forms.Button();
            this.btnCalculator = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictMinimize = new System.Windows.Forms.PictureBox();
            this.pictExit = new System.Windows.Forms.PictureBox();
            this.panelIcon = new System.Windows.Forms.Panel();
            this.picClaroOscuro = new System.Windows.Forms.PictureBox();
            this.pictMenu = new System.Windows.Forms.PictureBox();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.f4Elipse1 = new Calculadora.Desing.F4Elipse();
            this.panelMenu.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictExit)).BeginInit();
            this.panelIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClaroOscuro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.panelMenu.Controls.Add(this.btnInformation);
            this.panelMenu.Controls.Add(this.btnTemperature);
            this.panelMenu.Controls.Add(this.btnMass);
            this.panelMenu.Controls.Add(this.btnLength);
            this.panelMenu.Controls.Add(this.btnConverter);
            this.panelMenu.Controls.Add(this.btnStandard);
            this.panelMenu.Controls.Add(this.btnCalculator);
            this.panelMenu.Controls.Add(this.btnMenu);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 18);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 535);
            this.panelMenu.TabIndex = 1;
            // 
            // btnInformation
            // 
            this.btnInformation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnInformation.FlatAppearance.BorderSize = 0;
            this.btnInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformation.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformation.ForeColor = System.Drawing.Color.White;
            this.btnInformation.Location = new System.Drawing.Point(0, 489);
            this.btnInformation.Name = "btnInformation";
            this.btnInformation.Size = new System.Drawing.Size(200, 46);
            this.btnInformation.TabIndex = 15;
            this.btnInformation.Text = "Acerca de";
            this.btnInformation.UseVisualStyleBackColor = true;
            this.btnInformation.Click += new System.EventHandler(this.btnInformation_Click);
            // 
            // btnTemperature
            // 
            this.btnTemperature.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTemperature.FlatAppearance.BorderSize = 0;
            this.btnTemperature.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemperature.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemperature.ForeColor = System.Drawing.Color.White;
            this.btnTemperature.Location = new System.Drawing.Point(0, 258);
            this.btnTemperature.Name = "btnTemperature";
            this.btnTemperature.Size = new System.Drawing.Size(200, 46);
            this.btnTemperature.TabIndex = 14;
            this.btnTemperature.Text = "Temperatura";
            this.btnTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTemperature.UseVisualStyleBackColor = true;
            this.btnTemperature.Click += new System.EventHandler(this.btnTemperature_Click);
            // 
            // btnMass
            // 
            this.btnMass.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMass.FlatAppearance.BorderSize = 0;
            this.btnMass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMass.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMass.ForeColor = System.Drawing.Color.White;
            this.btnMass.Location = new System.Drawing.Point(0, 212);
            this.btnMass.Name = "btnMass";
            this.btnMass.Size = new System.Drawing.Size(200, 46);
            this.btnMass.TabIndex = 13;
            this.btnMass.Text = "Masa";
            this.btnMass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMass.UseVisualStyleBackColor = true;
            this.btnMass.Click += new System.EventHandler(this.btnWeight_Click);
            // 
            // btnLength
            // 
            this.btnLength.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLength.FlatAppearance.BorderSize = 0;
            this.btnLength.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLength.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLength.ForeColor = System.Drawing.Color.White;
            this.btnLength.Location = new System.Drawing.Point(0, 166);
            this.btnLength.Name = "btnLength";
            this.btnLength.Size = new System.Drawing.Size(200, 46);
            this.btnLength.TabIndex = 12;
            this.btnLength.Text = "Longitud";
            this.btnLength.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLength.UseVisualStyleBackColor = true;
            this.btnLength.Click += new System.EventHandler(this.btnLength_Click);
            // 
            // btnConverter
            // 
            this.btnConverter.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConverter.FlatAppearance.BorderSize = 0;
            this.btnConverter.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnConverter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnConverter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnConverter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConverter.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConverter.ForeColor = System.Drawing.Color.White;
            this.btnConverter.Location = new System.Drawing.Point(0, 120);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(200, 46);
            this.btnConverter.TabIndex = 11;
            this.btnConverter.Text = "Conversor";
            this.btnConverter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConverter.UseVisualStyleBackColor = true;
            // 
            // btnStandard
            // 
            this.btnStandard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStandard.FlatAppearance.BorderSize = 0;
            this.btnStandard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStandard.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStandard.ForeColor = System.Drawing.Color.White;
            this.btnStandard.Location = new System.Drawing.Point(0, 74);
            this.btnStandard.Name = "btnStandard";
            this.btnStandard.Size = new System.Drawing.Size(200, 46);
            this.btnStandard.TabIndex = 10;
            this.btnStandard.Text = "Estándar";
            this.btnStandard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStandard.UseVisualStyleBackColor = true;
            this.btnStandard.Click += new System.EventHandler(this.btnStandard_Click);
            // 
            // btnCalculator
            // 
            this.btnCalculator.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCalculator.FlatAppearance.BorderSize = 0;
            this.btnCalculator.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnCalculator.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCalculator.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCalculator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculator.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculator.ForeColor = System.Drawing.Color.White;
            this.btnCalculator.Location = new System.Drawing.Point(0, 28);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(200, 46);
            this.btnCalculator.TabIndex = 9;
            this.btnCalculator.Text = "Calculadora";
            this.btnCalculator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalculator.UseVisualStyleBackColor = true;
            // 
            // btnMenu
            // 
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(200, 28);
            this.btnMenu.TabIndex = 8;
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.pictMinimize);
            this.panel3.Controls.Add(this.pictExit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(550, 18);
            this.panel3.TabIndex = 1;
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            // 
            // pictMinimize
            // 
            this.pictMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictMinimize.Image = global::Calculadora.Properties.Resources.GrayMinimizedClic;
            this.pictMinimize.Location = new System.Drawing.Point(474, 0);
            this.pictMinimize.Name = "pictMinimize";
            this.pictMinimize.Size = new System.Drawing.Size(38, 18);
            this.pictMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictMinimize.TabIndex = 1;
            this.pictMinimize.TabStop = false;
            this.pictMinimize.Click += new System.EventHandler(this.pictMinimize_Click);
            this.pictMinimize.MouseEnter += new System.EventHandler(this.pictMinimize_MouseEnter);
            this.pictMinimize.MouseLeave += new System.EventHandler(this.pictMinimize_MouseLeave);
            // 
            // pictExit
            // 
            this.pictExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictExit.Image = global::Calculadora.Properties.Resources.GrayExitsClic;
            this.pictExit.Location = new System.Drawing.Point(512, 0);
            this.pictExit.Name = "pictExit";
            this.pictExit.Size = new System.Drawing.Size(38, 18);
            this.pictExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictExit.TabIndex = 0;
            this.pictExit.TabStop = false;
            this.pictExit.Click += new System.EventHandler(this.pictExit_Click);
            this.pictExit.MouseEnter += new System.EventHandler(this.pictExit_MouseEnter);
            this.pictExit.MouseLeave += new System.EventHandler(this.pictExit_MouseLeave);
            // 
            // panelIcon
            // 
            this.panelIcon.BackColor = System.Drawing.Color.Transparent;
            this.panelIcon.Controls.Add(this.picClaroOscuro);
            this.panelIcon.Controls.Add(this.pictMenu);
            this.panelIcon.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelIcon.Location = new System.Drawing.Point(200, 18);
            this.panelIcon.Name = "panelIcon";
            this.panelIcon.Size = new System.Drawing.Size(350, 28);
            this.panelIcon.TabIndex = 2;
            // 
            // picClaroOscuro
            // 
            this.picClaroOscuro.Dock = System.Windows.Forms.DockStyle.Left;
            this.picClaroOscuro.Image = global::Calculadora.Properties.Resources.Modo_claro;
            this.picClaroOscuro.Location = new System.Drawing.Point(35, 0);
            this.picClaroOscuro.Name = "picClaroOscuro";
            this.picClaroOscuro.Size = new System.Drawing.Size(35, 28);
            this.picClaroOscuro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClaroOscuro.TabIndex = 1;
            this.picClaroOscuro.TabStop = false;
            this.picClaroOscuro.Click += new System.EventHandler(this.btnClaroOscuro_Click);
            // 
            // pictMenu
            // 
            this.pictMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictMenu.Image = global::Calculadora.Properties.Resources.Menu;
            this.pictMenu.Location = new System.Drawing.Point(0, 0);
            this.pictMenu.Name = "pictMenu";
            this.pictMenu.Size = new System.Drawing.Size(35, 28);
            this.pictMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictMenu.TabIndex = 0;
            this.pictMenu.TabStop = false;
            this.pictMenu.Click += new System.EventHandler(this.pictMenu_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.Transparent;
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(200, 46);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(350, 507);
            this.panelContainer.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // f4Elipse1
            // 
            this.f4Elipse1.CornerRadius = 20;
            this.f4Elipse1.TargetControl = this;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(550, 553);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelIcon);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panelMenu.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictExit)).EndInit();
            this.panelIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picClaroOscuro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictMinimize;
        private System.Windows.Forms.PictureBox pictExit;
        private Desing.F4Elipse f4Elipse1;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel panelIcon;
        private System.Windows.Forms.Button btnCalculator;
        private System.Windows.Forms.Button btnTemperature;
        private System.Windows.Forms.Button btnMass;
        private System.Windows.Forms.Button btnLength;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.Button btnStandard;
        private System.Windows.Forms.PictureBox pictMenu;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.PictureBox picClaroOscuro;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnInformation;
    }
}