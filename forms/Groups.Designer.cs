namespace sistemaBufetes.forms
{
    partial class Groups
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Groups));
            this.findButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.nameText = new System.Windows.Forms.TextBox();
            this.codigoText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.mainButton = new System.Windows.Forms.Button();
            this.validador = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.gestionCheck = new System.Windows.Forms.CheckBox();
            this.casosCheck = new System.Windows.Forms.CheckBox();
            this.clientesCheck = new System.Windows.Forms.CheckBox();
            this.testigosCheck = new System.Windows.Forms.CheckBox();
            this.inventarioCheck = new System.Windows.Forms.CheckBox();
            this.evidenciaCheck = new System.Windows.Forms.CheckBox();
            this.reportesCheck = new System.Windows.Forms.CheckBox();
            this.configCheck = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.validador)).BeginInit();
            this.SuspendLayout();
            // 
            // findButton
            // 
            this.findButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("findButton.BackgroundImage")));
            this.findButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.findButton.Image = ((System.Drawing.Image)(resources.GetObject("findButton.Image")));
            this.findButton.Location = new System.Drawing.Point(352, 9);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(40, 25);
            this.findButton.TabIndex = 17;
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
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
            this.addButton.TabIndex = 16;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // nameText
            // 
            this.nameText.BackColor = System.Drawing.Color.White;
            this.nameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameText.Location = new System.Drawing.Point(72, 38);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(136, 20);
            this.nameText.TabIndex = 2;
            // 
            // codigoText
            // 
            this.codigoText.BackColor = System.Drawing.Color.White;
            this.codigoText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codigoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoText.Location = new System.Drawing.Point(72, 14);
            this.codigoText.Name = "codigoText";
            this.codigoText.Size = new System.Drawing.Size(136, 20);
            this.codigoText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Código:";
            // 
            // cancelButton
            // 
            this.cancelButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelButton.BackgroundImage")));
            this.cancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(116, 179);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(95, 25);
            this.cancelButton.TabIndex = 19;
            this.cancelButton.Text = "Cancelar";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // mainButton
            // 
            this.mainButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainButton.BackgroundImage")));
            this.mainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainButton.Location = new System.Drawing.Point(15, 179);
            this.mainButton.Name = "mainButton";
            this.mainButton.Size = new System.Drawing.Size(95, 25);
            this.mainButton.TabIndex = 18;
            this.mainButton.Text = "Agregar";
            this.mainButton.UseVisualStyleBackColor = true;
            this.mainButton.Click += new System.EventHandler(this.mainButton_Click);
            // 
            // validador
            // 
            this.validador.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.validador.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Permisos:";
            // 
            // gestionCheck
            // 
            this.gestionCheck.AutoSize = true;
            this.gestionCheck.BackColor = System.Drawing.Color.Transparent;
            this.gestionCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionCheck.Location = new System.Drawing.Point(79, 76);
            this.gestionCheck.Name = "gestionCheck";
            this.gestionCheck.Size = new System.Drawing.Size(69, 17);
            this.gestionCheck.TabIndex = 21;
            this.gestionCheck.Text = "Gestión";
            this.gestionCheck.UseVisualStyleBackColor = false;
            // 
            // casosCheck
            // 
            this.casosCheck.AutoSize = true;
            this.casosCheck.BackColor = System.Drawing.Color.Transparent;
            this.casosCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.casosCheck.Location = new System.Drawing.Point(79, 99);
            this.casosCheck.Name = "casosCheck";
            this.casosCheck.Size = new System.Drawing.Size(60, 17);
            this.casosCheck.TabIndex = 22;
            this.casosCheck.Text = "Casos";
            this.casosCheck.UseVisualStyleBackColor = false;
            // 
            // clientesCheck
            // 
            this.clientesCheck.AutoSize = true;
            this.clientesCheck.BackColor = System.Drawing.Color.Transparent;
            this.clientesCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientesCheck.Location = new System.Drawing.Point(79, 122);
            this.clientesCheck.Name = "clientesCheck";
            this.clientesCheck.Size = new System.Drawing.Size(71, 17);
            this.clientesCheck.TabIndex = 23;
            this.clientesCheck.Text = "Clientes";
            this.clientesCheck.UseVisualStyleBackColor = false;
            // 
            // testigosCheck
            // 
            this.testigosCheck.AutoSize = true;
            this.testigosCheck.BackColor = System.Drawing.Color.Transparent;
            this.testigosCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testigosCheck.Location = new System.Drawing.Point(79, 145);
            this.testigosCheck.Name = "testigosCheck";
            this.testigosCheck.Size = new System.Drawing.Size(74, 17);
            this.testigosCheck.TabIndex = 24;
            this.testigosCheck.Text = "Testigos";
            this.testigosCheck.UseVisualStyleBackColor = false;
            // 
            // inventarioCheck
            // 
            this.inventarioCheck.AutoSize = true;
            this.inventarioCheck.BackColor = System.Drawing.Color.Transparent;
            this.inventarioCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventarioCheck.Location = new System.Drawing.Point(192, 76);
            this.inventarioCheck.Name = "inventarioCheck";
            this.inventarioCheck.Size = new System.Drawing.Size(83, 17);
            this.inventarioCheck.TabIndex = 25;
            this.inventarioCheck.Text = "Inventario";
            this.inventarioCheck.UseVisualStyleBackColor = false;
            // 
            // evidenciaCheck
            // 
            this.evidenciaCheck.AutoSize = true;
            this.evidenciaCheck.BackColor = System.Drawing.Color.Transparent;
            this.evidenciaCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evidenciaCheck.Location = new System.Drawing.Point(192, 99);
            this.evidenciaCheck.Name = "evidenciaCheck";
            this.evidenciaCheck.Size = new System.Drawing.Size(82, 17);
            this.evidenciaCheck.TabIndex = 26;
            this.evidenciaCheck.Text = "Evidencia";
            this.evidenciaCheck.UseVisualStyleBackColor = false;
            // 
            // reportesCheck
            // 
            this.reportesCheck.AutoSize = true;
            this.reportesCheck.BackColor = System.Drawing.Color.Transparent;
            this.reportesCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportesCheck.Location = new System.Drawing.Point(192, 122);
            this.reportesCheck.Name = "reportesCheck";
            this.reportesCheck.Size = new System.Drawing.Size(77, 17);
            this.reportesCheck.TabIndex = 27;
            this.reportesCheck.Text = "Reportes";
            this.reportesCheck.UseVisualStyleBackColor = false;
            // 
            // configCheck
            // 
            this.configCheck.AutoSize = true;
            this.configCheck.BackColor = System.Drawing.Color.Transparent;
            this.configCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configCheck.Location = new System.Drawing.Point(192, 145);
            this.configCheck.Name = "configCheck";
            this.configCheck.Size = new System.Drawing.Size(104, 17);
            this.configCheck.TabIndex = 28;
            this.configCheck.Text = "Configuración";
            this.configCheck.UseVisualStyleBackColor = false;
            // 
            // Groups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(404, 221);
            this.Controls.Add(this.configCheck);
            this.Controls.Add(this.reportesCheck);
            this.Controls.Add(this.evidenciaCheck);
            this.Controls.Add(this.inventarioCheck);
            this.Controls.Add(this.testigosCheck);
            this.Controls.Add(this.clientesCheck);
            this.Controls.Add(this.casosCheck);
            this.Controls.Add(this.gestionCheck);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.mainButton);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.codigoText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Groups";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión: Grupos de Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.validador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox codigoText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button mainButton;
        private System.Windows.Forms.ErrorProvider validador;
        private System.Windows.Forms.CheckBox evidenciaCheck;
        private System.Windows.Forms.CheckBox inventarioCheck;
        private System.Windows.Forms.CheckBox testigosCheck;
        private System.Windows.Forms.CheckBox clientesCheck;
        private System.Windows.Forms.CheckBox casosCheck;
        private System.Windows.Forms.CheckBox gestionCheck;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox reportesCheck;
        private System.Windows.Forms.CheckBox configCheck;
    }
}