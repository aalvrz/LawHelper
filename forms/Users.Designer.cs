namespace sistemaBufetes.forms
{
    partial class Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.superCheck = new System.Windows.Forms.CheckBox();
            this.userText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.lnameText = new System.Windows.Forms.TextBox();
            this.mobileText = new System.Windows.Forms.TextBox();
            this.mailText = new System.Windows.Forms.TextBox();
            this.mainButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.passText = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.findButton = new System.Windows.Forms.Button();
            this.gruposCombo = new System.Windows.Forms.ComboBox();
            this.validador = new System.Windows.Forms.ErrorProvider(this.components);
            this.encIcon = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.validador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.encIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Celular:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Grupo:";
            // 
            // superCheck
            // 
            this.superCheck.AutoSize = true;
            this.superCheck.BackColor = System.Drawing.Color.Transparent;
            this.superCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superCheck.Location = new System.Drawing.Point(15, 189);
            this.superCheck.Name = "superCheck";
            this.superCheck.Size = new System.Drawing.Size(104, 17);
            this.superCheck.TabIndex = 7;
            this.superCheck.Text = "Super usuario";
            this.superCheck.UseVisualStyleBackColor = false;
            // 
            // userText
            // 
            this.userText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.userText.BackColor = System.Drawing.Color.White;
            this.userText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userText.Location = new System.Drawing.Point(72, 14);
            this.userText.Name = "userText";
            this.userText.Size = new System.Drawing.Size(136, 20);
            this.userText.TabIndex = 0;
            // 
            // nameText
            // 
            this.nameText.BackColor = System.Drawing.Color.White;
            this.nameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameText.Location = new System.Drawing.Point(72, 38);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(136, 20);
            this.nameText.TabIndex = 1;
            // 
            // lnameText
            // 
            this.lnameText.BackColor = System.Drawing.Color.White;
            this.lnameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lnameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnameText.Location = new System.Drawing.Point(72, 61);
            this.lnameText.Name = "lnameText";
            this.lnameText.Size = new System.Drawing.Size(136, 20);
            this.lnameText.TabIndex = 2;
            // 
            // mobileText
            // 
            this.mobileText.BackColor = System.Drawing.Color.White;
            this.mobileText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mobileText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileText.Location = new System.Drawing.Point(72, 84);
            this.mobileText.Name = "mobileText";
            this.mobileText.Size = new System.Drawing.Size(136, 20);
            this.mobileText.TabIndex = 3;
            // 
            // mailText
            // 
            this.mailText.BackColor = System.Drawing.Color.White;
            this.mailText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mailText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailText.Location = new System.Drawing.Point(72, 107);
            this.mailText.Name = "mailText";
            this.mailText.Size = new System.Drawing.Size(136, 20);
            this.mailText.TabIndex = 4;
            // 
            // mainButton
            // 
            this.mainButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainButton.BackgroundImage")));
            this.mainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainButton.Location = new System.Drawing.Point(12, 221);
            this.mainButton.Name = "mainButton";
            this.mainButton.Size = new System.Drawing.Size(95, 25);
            this.mainButton.TabIndex = 8;
            this.mainButton.Text = "Agregar";
            this.mainButton.UseVisualStyleBackColor = true;
            this.mainButton.Click += new System.EventHandler(this.mainButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Contraseña:";
            // 
            // passText
            // 
            this.passText.BackColor = System.Drawing.Color.White;
            this.passText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passText.Location = new System.Drawing.Point(93, 155);
            this.passText.Name = "passText";
            this.passText.PasswordChar = '*';
            this.passText.Size = new System.Drawing.Size(115, 20);
            this.passText.TabIndex = 6;
            // 
            // cancelButton
            // 
            this.cancelButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelButton.BackgroundImage")));
            this.cancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(113, 221);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(95, 25);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancelar";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addButton.BackgroundImage")));
            this.addButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addButton.Enabled = false;
            this.addButton.Image = ((System.Drawing.Image)(resources.GetObject("addButton.Image")));
            this.addButton.Location = new System.Drawing.Point(302, 9);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(40, 25);
            this.addButton.TabIndex = 10;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // findButton
            // 
            this.findButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("findButton.BackgroundImage")));
            this.findButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.findButton.Image = ((System.Drawing.Image)(resources.GetObject("findButton.Image")));
            this.findButton.Location = new System.Drawing.Point(352, 9);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(40, 25);
            this.findButton.TabIndex = 11;
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // gruposCombo
            // 
            this.gruposCombo.BackColor = System.Drawing.Color.White;
            this.gruposCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gruposCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gruposCombo.FormattingEnabled = true;
            this.gruposCombo.Location = new System.Drawing.Point(72, 129);
            this.gruposCombo.Name = "gruposCombo";
            this.gruposCombo.Size = new System.Drawing.Size(136, 21);
            this.gruposCombo.TabIndex = 5;
            // 
            // validador
            // 
            this.validador.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.validador.ContainerControl = this;
            // 
            // encIcon
            // 
            this.encIcon.BackColor = System.Drawing.Color.Transparent;
            this.encIcon.Image = ((System.Drawing.Image)(resources.GetObject("encIcon.Image")));
            this.encIcon.Location = new System.Drawing.Point(235, 155);
            this.encIcon.Name = "encIcon";
            this.encIcon.Size = new System.Drawing.Size(24, 24);
            this.encIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.encIcon.TabIndex = 15;
            this.encIcon.TabStop = false;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(404, 258);
            this.Controls.Add(this.encIcon);
            this.Controls.Add(this.gruposCombo);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.passText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mainButton);
            this.Controls.Add(this.mailText);
            this.Controls.Add(this.mobileText);
            this.Controls.Add(this.lnameText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.userText);
            this.Controls.Add(this.superCheck);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión: Usuarios";
            this.Load += new System.EventHandler(this.Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.validador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.encIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox superCheck;
        private System.Windows.Forms.TextBox userText;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox lnameText;
        private System.Windows.Forms.TextBox mobileText;
        private System.Windows.Forms.TextBox mailText;
        private System.Windows.Forms.Button mainButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox passText;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.ComboBox gruposCombo;
        private System.Windows.Forms.ErrorProvider validador;
        private System.Windows.Forms.PictureBox encIcon;
        private System.Windows.Forms.ToolTip toolTip;
    }
}