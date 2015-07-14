namespace sistemaBufetes.forms
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.sesionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gruposDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mostrarMenuBoton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip.BackgroundImage")));
            this.toolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarMenuBoton,
            this.helpToolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(632, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "Help";
            // 
            // statusStrip
            // 
            this.statusStrip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("statusStrip.BackgroundImage")));
            this.statusStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // statusLabel
            // 
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // sesionMenu
            // 
            this.sesionMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesionToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.sesionMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.sesionMenu.Name = "sesionMenu";
            this.sesionMenu.Size = new System.Drawing.Size(53, 20);
            this.sesionMenu.Text = "&Sesión";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cerrarSesionToolStripMenuItem.BackgroundImage")));
            this.cerrarSesionToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cerrarSesionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cerrarSesionToolStripMenuItem.Image")));
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.BackgroundImage")));
            this.salirToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // gestionMenu
            // 
            this.gestionMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.gruposDeUsuariosToolStripMenuItem});
            this.gestionMenu.Name = "gestionMenu";
            this.gestionMenu.Size = new System.Drawing.Size(59, 20);
            this.gestionMenu.Text = "&Gestión";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("usuariosToolStripMenuItem.BackgroundImage")));
            this.usuariosToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.usuariosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("usuariosToolStripMenuItem.Image")));
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // gruposDeUsuariosToolStripMenuItem
            // 
            this.gruposDeUsuariosToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gruposDeUsuariosToolStripMenuItem.BackgroundImage")));
            this.gruposDeUsuariosToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gruposDeUsuariosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("gruposDeUsuariosToolStripMenuItem.Image")));
            this.gruposDeUsuariosToolStripMenuItem.Name = "gruposDeUsuariosToolStripMenuItem";
            this.gruposDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.gruposDeUsuariosToolStripMenuItem.Text = "Grupos de Usuarios";
            this.gruposDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.gruposDeUsuariosToolStripMenuItem_Click);
            // 
            // opcionesMenu
            // 
            this.opcionesMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuracionToolStripMenuItem});
            this.opcionesMenu.Name = "opcionesMenu";
            this.opcionesMenu.Size = new System.Drawing.Size(69, 20);
            this.opcionesMenu.Text = "&Opciones";
            // 
            // configuracionToolStripMenuItem
            // 
            this.configuracionToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("configuracionToolStripMenuItem.BackgroundImage")));
            this.configuracionToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.configuracionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("configuracionToolStripMenuItem.Image")));
            this.configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            this.configuracionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.configuracionToolStripMenuItem.Text = "Configuracion";
            this.configuracionToolStripMenuItem.Click += new System.EventHandler(this.configuracionToolStripMenuItem_Click);
            // 
            // ayudaMenu
            // 
            this.ayudaMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.ayudaMenu.Name = "ayudaMenu";
            this.ayudaMenu.Size = new System.Drawing.Size(53, 20);
            this.ayudaMenu.Text = "&Ayuda";
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("manualToolStripMenuItem.BackgroundImage")));
            this.manualToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.manualToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("manualToolStripMenuItem.Image")));
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.manualToolStripMenuItem.Text = "Manual";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("acercaDeToolStripMenuItem.BackgroundImage")));
            this.acercaDeToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.acercaDeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("acercaDeToolStripMenuItem.Image")));
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca De SCB";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip.BackgroundImage")));
            this.menuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sesionMenu,
            this.gestionMenu,
            this.opcionesMenu,
            this.ayudaMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // mostrarMenuBoton
            // 
            this.mostrarMenuBoton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mostrarMenuBoton.Image = ((System.Drawing.Image)(resources.GetObject("mostrarMenuBoton.Image")));
            this.mostrarMenuBoton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mostrarMenuBoton.Name = "mostrarMenuBoton";
            this.mostrarMenuBoton.Size = new System.Drawing.Size(23, 22);
            this.mostrarMenuBoton.Text = "Mostrar Menu";
            this.mostrarMenuBoton.Click += new System.EventHandler(this.mostrarMenuBoton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Main";
            this.Text = "SCB - Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem sesionMenu;
        private System.Windows.Forms.ToolStripMenuItem gestionMenu;
        private System.Windows.Forms.ToolStripMenuItem opcionesMenu;
        private System.Windows.Forms.ToolStripMenuItem ayudaMenu;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gruposDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        public System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripButton mostrarMenuBoton;
    }
}



