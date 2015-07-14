namespace sistemaBufetes.forms
{
    partial class ByH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ByH));
            this.bitacoraGrid = new System.Windows.Forms.DataGridView();
            this.accionLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.bitTab = new System.Windows.Forms.TabPage();
            this.updateBit = new System.Windows.Forms.Button();
            this.honTab = new System.Windows.Forms.TabPage();
            this.updateHon = new System.Windows.Forms.Button();
            this.honorariosGrid = new System.Windows.Forms.DataGridView();
            this.bitBindSource = new System.Windows.Forms.BindingSource(this.components);
            this.honBindSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.bitacoraGrid)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.bitTab.SuspendLayout();
            this.honTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.honorariosGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitBindSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.honBindSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bitacoraGrid
            // 
            this.bitacoraGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bitacoraGrid.Location = new System.Drawing.Point(6, 31);
            this.bitacoraGrid.Name = "bitacoraGrid";
            this.bitacoraGrid.Size = new System.Drawing.Size(1024, 136);
            this.bitacoraGrid.TabIndex = 1;
            this.bitacoraGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bitacoraGrid_CellClick);
            this.bitacoraGrid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.bitacoraGrid_DataError);
            this.bitacoraGrid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.bitacoraGrid_RowEnter);
            // 
            // accionLabel
            // 
            this.accionLabel.AutoSize = true;
            this.accionLabel.BackColor = System.Drawing.Color.Transparent;
            this.accionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accionLabel.Location = new System.Drawing.Point(472, 9);
            this.accionLabel.Name = "accionLabel";
            this.accionLabel.Size = new System.Drawing.Size(129, 20);
            this.accionLabel.TabIndex = 2;
            this.accionLabel.Text = "Caso Acción # ";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.bitTab);
            this.tabControl1.Controls.Add(this.honTab);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(16, 32);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1044, 220);
            this.tabControl1.TabIndex = 3;
            // 
            // bitTab
            // 
            this.bitTab.Controls.Add(this.datePicker);
            this.bitTab.Controls.Add(this.updateBit);
            this.bitTab.Controls.Add(this.bitacoraGrid);
            this.bitTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bitTab.Location = new System.Drawing.Point(4, 22);
            this.bitTab.Name = "bitTab";
            this.bitTab.Padding = new System.Windows.Forms.Padding(3);
            this.bitTab.Size = new System.Drawing.Size(1036, 194);
            this.bitTab.TabIndex = 0;
            this.bitTab.Text = "Bitácora";
            this.bitTab.UseVisualStyleBackColor = true;
            // 
            // updateBit
            // 
            this.updateBit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updateBit.BackgroundImage")));
            this.updateBit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updateBit.Image = ((System.Drawing.Image)(resources.GetObject("updateBit.Image")));
            this.updateBit.Location = new System.Drawing.Point(6, 6);
            this.updateBit.Name = "updateBit";
            this.updateBit.Size = new System.Drawing.Size(29, 23);
            this.updateBit.TabIndex = 2;
            this.updateBit.UseVisualStyleBackColor = true;
            this.updateBit.Click += new System.EventHandler(this.addReg_Click);
            // 
            // honTab
            // 
            this.honTab.Controls.Add(this.updateHon);
            this.honTab.Controls.Add(this.honorariosGrid);
            this.honTab.Location = new System.Drawing.Point(4, 22);
            this.honTab.Name = "honTab";
            this.honTab.Padding = new System.Windows.Forms.Padding(3);
            this.honTab.Size = new System.Drawing.Size(1036, 194);
            this.honTab.TabIndex = 1;
            this.honTab.Text = "Honorarios";
            this.honTab.UseVisualStyleBackColor = true;
            // 
            // updateHon
            // 
            this.updateHon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updateHon.BackgroundImage")));
            this.updateHon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updateHon.Image = ((System.Drawing.Image)(resources.GetObject("updateHon.Image")));
            this.updateHon.Location = new System.Drawing.Point(6, 6);
            this.updateHon.Name = "updateHon";
            this.updateHon.Size = new System.Drawing.Size(29, 23);
            this.updateHon.TabIndex = 3;
            this.updateHon.UseVisualStyleBackColor = true;
            this.updateHon.Click += new System.EventHandler(this.updateHon_Click);
            // 
            // honorariosGrid
            // 
            this.honorariosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.honorariosGrid.Location = new System.Drawing.Point(6, 31);
            this.honorariosGrid.Name = "honorariosGrid";
            this.honorariosGrid.Size = new System.Drawing.Size(1024, 136);
            this.honorariosGrid.TabIndex = 2;
            this.honorariosGrid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.honorariosGrid_RowEnter);
            // 
            // toolTip
            // 
            this.toolTip.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip_Popup);
            // 
            // datePicker
            // 
            this.datePicker.Enabled = false;
            this.datePicker.Location = new System.Drawing.Point(41, 9);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 20);
            this.datePicker.TabIndex = 3;
            this.toolTip.SetToolTip(this.datePicker, "Seleccionar Fecha");
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // ByH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1072, 264);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.accionLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ByH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bitácora y Honorarios";
            this.Load += new System.EventHandler(this.ByH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bitacoraGrid)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.bitTab.ResumeLayout(false);
            this.honTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.honorariosGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitBindSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.honBindSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView bitacoraGrid;
        private System.Windows.Forms.Label accionLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage bitTab;
        private System.Windows.Forms.TabPage honTab;
        private System.Windows.Forms.DataGridView honorariosGrid;
        private System.Windows.Forms.Button updateBit;
        private System.Windows.Forms.Button updateHon;
        private System.Windows.Forms.BindingSource bitBindSource;
        private System.Windows.Forms.BindingSource honBindSource;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.DateTimePicker datePicker;
    }
}