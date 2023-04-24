namespace CapaPresentacion
{
    partial class Inicio
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.MenuUsuario = new FontAwesome.Sharp.IconMenuItem();
            this.MenuConfiguracion = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuTipoPrenda = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuColorPrenda = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuTallaPrenda = new FontAwesome.Sharp.IconMenuItem();
            this.MenuVentas = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuRegistrarVenta = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuVerDetalleVenta = new FontAwesome.Sharp.IconMenuItem();
            this.MenuCompras = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuRegistrarCompra = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuVerDetalleCompra = new FontAwesome.Sharp.IconMenuItem();
            this.MenuClientes = new FontAwesome.Sharp.IconMenuItem();
            this.MenuReportes = new FontAwesome.Sharp.IconMenuItem();
            this.MenuAcercade = new FontAwesome.Sharp.IconMenuItem();
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.White;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuUsuario,
            this.MenuConfiguracion,
            this.MenuVentas,
            this.MenuCompras,
            this.MenuClientes,
            this.MenuReportes,
            this.MenuAcercade});
            this.menu.Location = new System.Drawing.Point(0, 48);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(996, 73);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // MenuUsuario
            // 
            this.MenuUsuario.AutoSize = false;
            this.MenuUsuario.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            this.MenuUsuario.IconColor = System.Drawing.Color.Black;
            this.MenuUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuUsuario.IconSize = 50;
            this.MenuUsuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuUsuario.Name = "MenuUsuario";
            this.MenuUsuario.Size = new System.Drawing.Size(80, 69);
            this.MenuUsuario.Text = "Usuarios";
            this.MenuUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuUsuario.Click += new System.EventHandler(this.MenuUsuario_Click);
            // 
            // MenuConfiguracion
            // 
            this.MenuConfiguracion.AutoSize = false;
            this.MenuConfiguracion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuTipoPrenda,
            this.SubMenuColorPrenda,
            this.SubMenuTallaPrenda});
            this.MenuConfiguracion.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.MenuConfiguracion.IconColor = System.Drawing.Color.Black;
            this.MenuConfiguracion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuConfiguracion.IconSize = 50;
            this.MenuConfiguracion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuConfiguracion.Name = "MenuConfiguracion";
            this.MenuConfiguracion.Size = new System.Drawing.Size(80, 69);
            this.MenuConfiguracion.Text = "Configuración";
            this.MenuConfiguracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // SubMenuTipoPrenda
            // 
            this.SubMenuTipoPrenda.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuTipoPrenda.IconColor = System.Drawing.Color.Black;
            this.SubMenuTipoPrenda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuTipoPrenda.Name = "SubMenuTipoPrenda";
            this.SubMenuTipoPrenda.Size = new System.Drawing.Size(153, 22);
            this.SubMenuTipoPrenda.Text = "Tipo de Prenda";
            this.SubMenuTipoPrenda.Click += new System.EventHandler(this.SubMenuTipoPrenda_Click);
            // 
            // SubMenuColorPrenda
            // 
            this.SubMenuColorPrenda.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuColorPrenda.IconColor = System.Drawing.Color.Black;
            this.SubMenuColorPrenda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuColorPrenda.Name = "SubMenuColorPrenda";
            this.SubMenuColorPrenda.Size = new System.Drawing.Size(153, 22);
            this.SubMenuColorPrenda.Text = "Color";
            this.SubMenuColorPrenda.Click += new System.EventHandler(this.SubMenuColorPrenda_Click);
            // 
            // SubMenuTallaPrenda
            // 
            this.SubMenuTallaPrenda.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuTallaPrenda.IconColor = System.Drawing.Color.Black;
            this.SubMenuTallaPrenda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuTallaPrenda.Name = "SubMenuTallaPrenda";
            this.SubMenuTallaPrenda.Size = new System.Drawing.Size(153, 22);
            this.SubMenuTallaPrenda.Text = "Tallas";
            this.SubMenuTallaPrenda.Click += new System.EventHandler(this.SubMenuTallaPrenda_Click);
            // 
            // MenuVentas
            // 
            this.MenuVentas.AutoSize = false;
            this.MenuVentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuRegistrarVenta,
            this.SubMenuVerDetalleVenta});
            this.MenuVentas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.MenuVentas.IconColor = System.Drawing.Color.Black;
            this.MenuVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuVentas.IconSize = 50;
            this.MenuVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuVentas.Name = "MenuVentas";
            this.MenuVentas.Size = new System.Drawing.Size(80, 69);
            this.MenuVentas.Text = "Ventas";
            this.MenuVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // SubMenuRegistrarVenta
            // 
            this.SubMenuRegistrarVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuRegistrarVenta.IconColor = System.Drawing.Color.Black;
            this.SubMenuRegistrarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuRegistrarVenta.Name = "SubMenuRegistrarVenta";
            this.SubMenuRegistrarVenta.Size = new System.Drawing.Size(129, 22);
            this.SubMenuRegistrarVenta.Text = "Registrar";
            this.SubMenuRegistrarVenta.Click += new System.EventHandler(this.SubMenuRegistrarVenta_Click);
            // 
            // SubMenuVerDetalleVenta
            // 
            this.SubMenuVerDetalleVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuVerDetalleVenta.IconColor = System.Drawing.Color.Black;
            this.SubMenuVerDetalleVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuVerDetalleVenta.Name = "SubMenuVerDetalleVenta";
            this.SubMenuVerDetalleVenta.Size = new System.Drawing.Size(129, 22);
            this.SubMenuVerDetalleVenta.Text = "Ver Detalle";
            this.SubMenuVerDetalleVenta.Click += new System.EventHandler(this.SubMenuVerDetalleVenta_Click);
            // 
            // MenuCompras
            // 
            this.MenuCompras.AutoSize = false;
            this.MenuCompras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuRegistrarCompra,
            this.SubMenuVerDetalleCompra});
            this.MenuCompras.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            this.MenuCompras.IconColor = System.Drawing.Color.Black;
            this.MenuCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuCompras.IconSize = 50;
            this.MenuCompras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuCompras.Name = "MenuCompras";
            this.MenuCompras.Size = new System.Drawing.Size(80, 69);
            this.MenuCompras.Text = "Compras";
            this.MenuCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // SubMenuRegistrarCompra
            // 
            this.SubMenuRegistrarCompra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuRegistrarCompra.IconColor = System.Drawing.Color.Black;
            this.SubMenuRegistrarCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuRegistrarCompra.Name = "SubMenuRegistrarCompra";
            this.SubMenuRegistrarCompra.Size = new System.Drawing.Size(129, 22);
            this.SubMenuRegistrarCompra.Text = " Registrar";
            this.SubMenuRegistrarCompra.Click += new System.EventHandler(this.SubMenuRegistrarCompra_Click);
            // 
            // SubMenuVerDetalleCompra
            // 
            this.SubMenuVerDetalleCompra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuVerDetalleCompra.IconColor = System.Drawing.Color.Black;
            this.SubMenuVerDetalleCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuVerDetalleCompra.Name = "SubMenuVerDetalleCompra";
            this.SubMenuVerDetalleCompra.Size = new System.Drawing.Size(129, 22);
            this.SubMenuVerDetalleCompra.Text = "Ver Detalle";
            this.SubMenuVerDetalleCompra.Click += new System.EventHandler(this.SubMenuVerDetalleCompra_Click);
            // 
            // MenuClientes
            // 
            this.MenuClientes.AutoSize = false;
            this.MenuClientes.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.MenuClientes.IconColor = System.Drawing.Color.Black;
            this.MenuClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuClientes.IconSize = 50;
            this.MenuClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuClientes.Name = "MenuClientes";
            this.MenuClientes.Size = new System.Drawing.Size(80, 69);
            this.MenuClientes.Text = "Clientes";
            this.MenuClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuClientes.Click += new System.EventHandler(this.MenuClientes_Click);
            // 
            // MenuReportes
            // 
            this.MenuReportes.AutoSize = false;
            this.MenuReportes.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            this.MenuReportes.IconColor = System.Drawing.Color.Black;
            this.MenuReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuReportes.IconSize = 50;
            this.MenuReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuReportes.Name = "MenuReportes";
            this.MenuReportes.Size = new System.Drawing.Size(80, 69);
            this.MenuReportes.Text = "Reportes";
            this.MenuReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuReportes.Click += new System.EventHandler(this.MenuReportes_Click);
            // 
            // MenuAcercade
            // 
            this.MenuAcercade.AutoSize = false;
            this.MenuAcercade.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.MenuAcercade.IconColor = System.Drawing.Color.Black;
            this.MenuAcercade.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuAcercade.IconSize = 50;
            this.MenuAcercade.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuAcercade.Name = "MenuAcercade";
            this.MenuAcercade.Size = new System.Drawing.Size(80, 69);
            this.MenuAcercade.Text = "Acerca de";
            this.MenuAcercade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.menuTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTitulo.Size = new System.Drawing.Size(996, 48);
            this.menuTitulo.TabIndex = 1;
            this.menuTitulo.Text = "menuStrip2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "EddieShirt - ERP";
            // 
            // contenedor
            // 
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 121);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(996, 503);
            this.contenedor.TabIndex = 3;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 624);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menuTitulo);
            this.MainMenuStrip = this.menu;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.MenuStrip menuTitulo;
        private FontAwesome.Sharp.IconMenuItem MenuUsuario;
        private FontAwesome.Sharp.IconMenuItem MenuConfiguracion;
        private FontAwesome.Sharp.IconMenuItem MenuVentas;
        private FontAwesome.Sharp.IconMenuItem MenuCompras;
        private FontAwesome.Sharp.IconMenuItem MenuClientes;
        private FontAwesome.Sharp.IconMenuItem MenuReportes;
        private FontAwesome.Sharp.IconMenuItem MenuAcercade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel contenedor;
        private FontAwesome.Sharp.IconMenuItem SubMenuTipoPrenda;
        private FontAwesome.Sharp.IconMenuItem SubMenuColorPrenda;
        private FontAwesome.Sharp.IconMenuItem SubMenuTallaPrenda;
        private FontAwesome.Sharp.IconMenuItem SubMenuRegistrarVenta;
        private FontAwesome.Sharp.IconMenuItem SubMenuVerDetalleVenta;
        private FontAwesome.Sharp.IconMenuItem SubMenuRegistrarCompra;
        private FontAwesome.Sharp.IconMenuItem SubMenuVerDetalleCompra;
    }
}

