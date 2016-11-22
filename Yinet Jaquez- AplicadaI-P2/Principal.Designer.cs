namespace Yinet_Jaquez__AplicadaI_P2
{
    partial class Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.BuscarBoton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Telefono = new System.Windows.Forms.GroupBox();
            this.ClienteTextBox = new System.Windows.Forms.TextBox();
            this.ClientesComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AgregarBoton = new System.Windows.Forms.Button();
            this.ListaDataGridView = new System.Windows.Forms.DataGridView();
            this.InsertarBoton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.Telefono.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Tan;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem,
            this.consultarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(646, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem});
            this.registrarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(73, 21);
            this.registrarToolStripMenuItem.Text = "Registrar";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaToolStripMenuItem});
            this.consultarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(76, 21);
            this.consultarToolStripMenuItem.Text = "Consultas";
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.consultaToolStripMenuItem.Text = "Consultar";
            this.consultaToolStripMenuItem.Click += new System.EventHandler(this.consultaToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdTextBox.ForeColor = System.Drawing.Color.Red;
            this.IdTextBox.Location = new System.Drawing.Point(105, 26);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(144, 29);
            this.IdTextBox.TabIndex = 2;
            // 
            // BuscarBoton
            // 
            this.BuscarBoton.BackColor = System.Drawing.Color.Transparent;
            this.BuscarBoton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuscarBoton.Image = global::Yinet_Jaquez__AplicadaI_P2.Properties.Resources._40px_Icono_buscar;
            this.BuscarBoton.Location = new System.Drawing.Point(274, 15);
            this.BuscarBoton.Name = "BuscarBoton";
            this.BuscarBoton.Size = new System.Drawing.Size(66, 43);
            this.BuscarBoton.TabIndex = 3;
            this.BuscarBoton.UseVisualStyleBackColor = false;
            this.BuscarBoton.Click += new System.EventHandler(this.BuscarBoton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cliente";
            // 
            // Telefono
            // 
            this.Telefono.Controls.Add(this.BuscarBoton);
            this.Telefono.Controls.Add(this.ClienteTextBox);
            this.Telefono.Controls.Add(this.label2);
            this.Telefono.Controls.Add(this.label1);
            this.Telefono.Controls.Add(this.IdTextBox);
            this.Telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefono.Location = new System.Drawing.Point(24, 56);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(382, 130);
            this.Telefono.TabIndex = 5;
            this.Telefono.TabStop = false;
            this.Telefono.Text = "Cliente";
            // 
            // ClienteTextBox
            // 
            this.ClienteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClienteTextBox.ForeColor = System.Drawing.Color.Red;
            this.ClienteTextBox.Location = new System.Drawing.Point(105, 75);
            this.ClienteTextBox.Name = "ClienteTextBox";
            this.ClienteTextBox.Size = new System.Drawing.Size(255, 24);
            this.ClienteTextBox.TabIndex = 5;
            // 
            // ClientesComboBox
            // 
            this.ClientesComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientesComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientesComboBox.FormattingEnabled = true;
            this.ClientesComboBox.Location = new System.Drawing.Point(89, 215);
            this.ClientesComboBox.Name = "ClientesComboBox";
            this.ClientesComboBox.Size = new System.Drawing.Size(255, 28);
            this.ClientesComboBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefono";
            // 
            // AgregarBoton
            // 
            this.AgregarBoton.BackColor = System.Drawing.Color.SeaShell;
            this.AgregarBoton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgregarBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarBoton.Image = global::Yinet_Jaquez__AplicadaI_P2.Properties.Resources.anadir_mas_icono_6734_48;
            this.AgregarBoton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AgregarBoton.Location = new System.Drawing.Point(496, 195);
            this.AgregarBoton.Name = "AgregarBoton";
            this.AgregarBoton.Size = new System.Drawing.Size(117, 50);
            this.AgregarBoton.TabIndex = 6;
            this.AgregarBoton.Text = "Agregar";
            this.AgregarBoton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AgregarBoton.UseVisualStyleBackColor = false;
            this.AgregarBoton.Click += new System.EventHandler(this.AgregarBoton_Click);
            // 
            // ListaDataGridView
            // 
            this.ListaDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ListaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaDataGridView.GridColor = System.Drawing.Color.OrangeRed;
            this.ListaDataGridView.Location = new System.Drawing.Point(58, 260);
            this.ListaDataGridView.Name = "ListaDataGridView";
            this.ListaDataGridView.Size = new System.Drawing.Size(523, 129);
            this.ListaDataGridView.TabIndex = 7;
            // 
            // InsertarBoton
            // 
            this.InsertarBoton.BackColor = System.Drawing.Color.SeaShell;
            this.InsertarBoton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertarBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertarBoton.Image = global::Yinet_Jaquez__AplicadaI_P2.Properties.Resources.anadir_mas_icono_6734_48;
            this.InsertarBoton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InsertarBoton.Location = new System.Drawing.Point(362, 195);
            this.InsertarBoton.Name = "InsertarBoton";
            this.InsertarBoton.Size = new System.Drawing.Size(118, 50);
            this.InsertarBoton.TabIndex = 8;
            this.InsertarBoton.Text = "Insertar";
            this.InsertarBoton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.InsertarBoton.UseVisualStyleBackColor = false;
            this.InsertarBoton.Click += new System.EventHandler(this.InsertarBoton_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(646, 446);
            this.Controls.Add(this.InsertarBoton);
            this.Controls.Add(this.ListaDataGridView);
            this.Controls.Add(this.AgregarBoton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ClientesComboBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Telefono);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Telefono.ResumeLayout(false);
            this.Telefono.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Button BuscarBoton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox Telefono;
        private System.Windows.Forms.TextBox ClienteTextBox;
        private System.Windows.Forms.ComboBox ClientesComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AgregarBoton;
        private System.Windows.Forms.DataGridView ListaDataGridView;
        private System.Windows.Forms.Button InsertarBoton;
    }
}

