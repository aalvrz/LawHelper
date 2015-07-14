namespace sistemaBufetes.forms
{
    partial class CaseEvidence
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaseEvidence));
            this.evidenciaList = new System.Windows.Forms.ListBox();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.descText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.abrirBoton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // evidenciaList
            // 
            this.evidenciaList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evidenciaList.FormattingEnabled = true;
            this.evidenciaList.Location = new System.Drawing.Point(402, 61);
            this.evidenciaList.Name = "evidenciaList";
            this.evidenciaList.Size = new System.Drawing.Size(120, 108);
            this.evidenciaList.TabIndex = 0;
            this.evidenciaList.SelectedIndexChanged += new System.EventHandler(this.evidenciaList_SelectedIndexChanged);
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.BackColor = System.Drawing.Color.Transparent;
            this.tituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.Location = new System.Drawing.Point(187, 9);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(206, 20);
            this.tituloLabel.TabIndex = 1;
            this.tituloLabel.Text = "Evidencia Caso Acción #";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripción:";
            // 
            // descText
            // 
            this.descText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descText.Enabled = false;
            this.descText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descText.Location = new System.Drawing.Point(15, 61);
            this.descText.Multiline = true;
            this.descText.Name = "descText";
            this.descText.Size = new System.Drawing.Size(334, 108);
            this.descText.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(399, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Evidencias:";
            // 
            // abrirBoton
            // 
            this.abrirBoton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("abrirBoton.BackgroundImage")));
            this.abrirBoton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.abrirBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abrirBoton.Location = new System.Drawing.Point(402, 175);
            this.abrirBoton.Name = "abrirBoton";
            this.abrirBoton.Size = new System.Drawing.Size(120, 23);
            this.abrirBoton.TabIndex = 5;
            this.abrirBoton.Text = "Abrir Archivo";
            this.abrirBoton.UseVisualStyleBackColor = true;
            this.abrirBoton.Click += new System.EventHandler(this.abrirBoton_Click);
            // 
            // CaseEvidence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(581, 226);
            this.Controls.Add(this.abrirBoton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.descText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tituloLabel);
            this.Controls.Add(this.evidenciaList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CaseEvidence";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evidencia del Caso";
            this.Load += new System.EventHandler(this.CaseEvidence_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox evidenciaList;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox descText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button abrirBoton;
    }
}