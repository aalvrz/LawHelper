namespace sistemaBufetes
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.ingresarBoton = new System.Windows.Forms.Button();
            this.passText = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.usuarioText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.serverText = new System.Windows.Forms.TextBox();
            this.serverCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ingresarBoton
            // 
            this.ingresarBoton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ingresarBoton.BackgroundImage")));
            this.ingresarBoton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ingresarBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresarBoton.Location = new System.Drawing.Point(190, 70);
            this.ingresarBoton.Name = "ingresarBoton";
            this.ingresarBoton.Size = new System.Drawing.Size(168, 23);
            this.ingresarBoton.TabIndex = 4;
            this.ingresarBoton.Text = "Iniciar Sesión";
            this.ingresarBoton.UseVisualStyleBackColor = true;
            this.ingresarBoton.Click += new System.EventHandler(this.ingresarBoton_Click);
            // 
            // passText
            // 
            this.passText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passText.Location = new System.Drawing.Point(12, 73);
            this.passText.Name = "passText";
            this.passText.PasswordChar = '*';
            this.passText.Size = new System.Drawing.Size(137, 20);
            this.passText.TabIndex = 2;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(12, 57);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(75, 13);
            this.Label2.TabIndex = 7;
            this.Label2.Text = "Contraseña:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(9, 18);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(54, 13);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "Usuario:";
            // 
            // usuarioText
            // 
            this.usuarioText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usuarioText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioText.Location = new System.Drawing.Point(12, 34);
            this.usuarioText.Name = "usuarioText";
            this.usuarioText.Size = new System.Drawing.Size(137, 20);
            this.usuarioText.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(187, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nombre del Equipo Servidor:";
            // 
            // serverText
            // 
            this.serverText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serverText.Enabled = false;
            this.serverText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverText.Location = new System.Drawing.Point(190, 33);
            this.serverText.Name = "serverText";
            this.serverText.Size = new System.Drawing.Size(168, 20);
            this.serverText.TabIndex = 3;
            // 
            // serverCheck
            // 
            this.serverCheck.AutoSize = true;
            this.serverCheck.BackColor = System.Drawing.Color.Transparent;
            this.serverCheck.Location = new System.Drawing.Point(364, 39);
            this.serverCheck.Name = "serverCheck";
            this.serverCheck.Size = new System.Drawing.Size(15, 14);
            this.serverCheck.TabIndex = 5;
            this.serverCheck.UseVisualStyleBackColor = false;
            this.serverCheck.CheckedChanged += new System.EventHandler(this.serverCheck_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(402, 112);
            this.Controls.Add(this.serverCheck);
            this.Controls.Add(this.serverText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ingresarBoton);
            this.Controls.Add(this.passText);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.usuarioText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesión";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button ingresarBoton;
        internal System.Windows.Forms.TextBox passText;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox usuarioText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox serverText;
        private System.Windows.Forms.CheckBox serverCheck;
    }
}