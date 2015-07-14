namespace sistemaBufetes.forms
{
    partial class Inventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.codigoText = new System.Windows.Forms.TextBox();
            this.nombreText = new System.Windows.Forms.TextBox();
            this.costoText = new System.Windows.Forms.TextBox();
            this.ubicacionText = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.mainButton = new System.Windows.Forms.Button();
            this.findButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.validador = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.validador)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 47);
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
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Costo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ubicación:";
            // 
            // codigoText
            // 
            this.codigoText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.codigoText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codigoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoText.Location = new System.Drawing.Point(86, 17);
            this.codigoText.Name = "codigoText";
            this.codigoText.Size = new System.Drawing.Size(119, 20);
            this.codigoText.TabIndex = 4;
            // 
            // nombreText
            // 
            this.nombreText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nombreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreText.Location = new System.Drawing.Point(86, 40);
            this.nombreText.Name = "nombreText";
            this.nombreText.Size = new System.Drawing.Size(119, 20);
            this.nombreText.TabIndex = 5;
            // 
            // costoText
            // 
            this.costoText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.costoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costoText.Location = new System.Drawing.Point(86, 64);
            this.costoText.Name = "costoText";
            this.costoText.Size = new System.Drawing.Size(119, 20);
            this.costoText.TabIndex = 6;
            // 
            // ubicacionText
            // 
            this.ubicacionText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ubicacionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ubicacionText.Location = new System.Drawing.Point(86, 88);
            this.ubicacionText.Name = "ubicacionText";
            this.ubicacionText.Size = new System.Drawing.Size(119, 20);
            this.ubicacionText.TabIndex = 7;
            // 
            // cancelButton
            // 
            this.cancelButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelButton.BackgroundImage")));
            this.cancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(116, 136);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(95, 25);
            this.cancelButton.TabIndex = 25;
            this.cancelButton.Text = "Cancelar";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // mainButton
            // 
            this.mainButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainButton.BackgroundImage")));
            this.mainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainButton.Location = new System.Drawing.Point(15, 136);
            this.mainButton.Name = "mainButton";
            this.mainButton.Size = new System.Drawing.Size(95, 25);
            this.mainButton.TabIndex = 24;
            this.mainButton.Text = "Agregar";
            this.mainButton.UseVisualStyleBackColor = true;
            this.mainButton.Click += new System.EventHandler(this.mainButton_Click);
            // 
            // findButton
            // 
            this.findButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("findButton.BackgroundImage")));
            this.findButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.findButton.Image = ((System.Drawing.Image)(resources.GetObject("findButton.Image")));
            this.findButton.Location = new System.Drawing.Point(431, 17);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(40, 25);
            this.findButton.TabIndex = 27;
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addButton.BackgroundImage")));
            this.addButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addButton.Enabled = false;
            this.addButton.Image = ((System.Drawing.Image)(resources.GetObject("addButton.Image")));
            this.addButton.Location = new System.Drawing.Point(383, 17);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(40, 25);
            this.addButton.TabIndex = 26;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // validador
            // 
            this.validador.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.validador.ContainerControl = this;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(483, 171);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.mainButton);
            this.Controls.Add(this.ubicacionText);
            this.Controls.Add(this.costoText);
            this.Controls.Add(this.nombreText);
            this.Controls.Add(this.codigoText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Inventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.validador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox codigoText;
        private System.Windows.Forms.TextBox nombreText;
        private System.Windows.Forms.TextBox costoText;
        private System.Windows.Forms.TextBox ubicacionText;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button mainButton;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ErrorProvider validador;
    }
}