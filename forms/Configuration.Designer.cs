namespace sistemaBufetes.forms
{
    partial class Configuration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configuration));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bufeteText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.idiomaCombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.temaCombo = new System.Windows.Forms.ComboBox();
            this.aceptarBoton = new System.Windows.Forms.Button();
            this.cancelarBoton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.examinarBoton = new System.Windows.Forms.Button();
            this.fileBrowser = new System.Windows.Forms.OpenFileDialog();
            this.validador = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validador)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Configuración del Sistema";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del Bufete:";
            // 
            // bufeteText
            // 
            this.bufeteText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bufeteText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bufeteText.Location = new System.Drawing.Point(134, 45);
            this.bufeteText.Name = "bufeteText";
            this.bufeteText.Size = new System.Drawing.Size(139, 20);
            this.bufeteText.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Idioma:";
            // 
            // idiomaCombo
            // 
            this.idiomaCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idiomaCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idiomaCombo.FormattingEnabled = true;
            this.idiomaCombo.Items.AddRange(new object[] {
            "Español"});
            this.idiomaCombo.Location = new System.Drawing.Point(134, 74);
            this.idiomaCombo.Name = "idiomaCombo";
            this.idiomaCombo.Size = new System.Drawing.Size(139, 21);
            this.idiomaCombo.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tema:";
            // 
            // temaCombo
            // 
            this.temaCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.temaCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temaCombo.FormattingEnabled = true;
            this.temaCombo.Items.AddRange(new object[] {
            "Papiro"});
            this.temaCombo.Location = new System.Drawing.Point(134, 101);
            this.temaCombo.Name = "temaCombo";
            this.temaCombo.Size = new System.Drawing.Size(139, 21);
            this.temaCombo.TabIndex = 8;
            // 
            // aceptarBoton
            // 
            this.aceptarBoton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("aceptarBoton.BackgroundImage")));
            this.aceptarBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aceptarBoton.Location = new System.Drawing.Point(15, 198);
            this.aceptarBoton.Name = "aceptarBoton";
            this.aceptarBoton.Size = new System.Drawing.Size(113, 23);
            this.aceptarBoton.TabIndex = 9;
            this.aceptarBoton.Text = "Aceptar";
            this.aceptarBoton.UseVisualStyleBackColor = true;
            this.aceptarBoton.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancelarBoton
            // 
            this.cancelarBoton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelarBoton.BackgroundImage")));
            this.cancelarBoton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelarBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarBoton.Location = new System.Drawing.Point(134, 198);
            this.cancelarBoton.Name = "cancelarBoton";
            this.cancelarBoton.Size = new System.Drawing.Size(113, 23);
            this.cancelarBoton.TabIndex = 10;
            this.cancelarBoton.Text = "Cancelar";
            this.cancelarBoton.UseVisualStyleBackColor = true;
            this.cancelarBoton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(299, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Logo:";
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logo.Location = new System.Drawing.Point(302, 61);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(175, 114);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 12;
            this.logo.TabStop = false;
            // 
            // examinarBoton
            // 
            this.examinarBoton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("examinarBoton.BackgroundImage")));
            this.examinarBoton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.examinarBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examinarBoton.Location = new System.Drawing.Point(333, 181);
            this.examinarBoton.Name = "examinarBoton";
            this.examinarBoton.Size = new System.Drawing.Size(110, 23);
            this.examinarBoton.TabIndex = 13;
            this.examinarBoton.Text = "Examinar...";
            this.examinarBoton.UseVisualStyleBackColor = true;
            this.examinarBoton.Click += new System.EventHandler(this.examinarBoton_Click);
            // 
            // fileBrowser
            // 
            this.fileBrowser.Title = "Seleccionar Logo";
            // 
            // validador
            // 
            this.validador.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.validador.ContainerControl = this;
            // 
            // Configuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(501, 233);
            this.Controls.Add(this.examinarBoton);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cancelarBoton);
            this.Controls.Add(this.aceptarBoton);
            this.Controls.Add(this.temaCombo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.idiomaCombo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bufeteText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Configuration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración";
            this.Load += new System.EventHandler(this.Configuration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bufeteText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox idiomaCombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox temaCombo;
        private System.Windows.Forms.Button aceptarBoton;
        private System.Windows.Forms.Button cancelarBoton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button examinarBoton;
        private System.Windows.Forms.OpenFileDialog fileBrowser;
        private System.Windows.Forms.ErrorProvider validador;
    }
}