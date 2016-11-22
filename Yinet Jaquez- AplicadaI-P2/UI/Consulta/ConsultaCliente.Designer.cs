namespace Yinet_Jaquez__AplicadaI_P2.UI
{
    partial class ConsultaCliente
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
            this.CampoTextBox = new System.Windows.Forms.TextBox();
            this.ConsultarBoton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ConsultaDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CampoTextBox
            // 
            this.CampoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CampoTextBox.ForeColor = System.Drawing.Color.Navy;
            this.CampoTextBox.Location = new System.Drawing.Point(188, 40);
            this.CampoTextBox.Name = "CampoTextBox";
            this.CampoTextBox.Size = new System.Drawing.Size(279, 24);
            this.CampoTextBox.TabIndex = 0;
            // 
            // ConsultarBoton
            // 
            this.ConsultarBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsultarBoton.Location = new System.Drawing.Point(491, 31);
            this.ConsultarBoton.Name = "ConsultarBoton";
            this.ConsultarBoton.Size = new System.Drawing.Size(147, 44);
            this.ConsultarBoton.TabIndex = 1;
            this.ConsultarBoton.Text = "Consultar";
            this.ConsultarBoton.UseVisualStyleBackColor = true;
            this.ConsultarBoton.Click += new System.EventHandler(this.ConsultarBoton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre o ID";
            // 
            // ConsultaDataGridView
            // 
            this.ConsultaDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ConsultaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultaDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.ConsultaDataGridView.Location = new System.Drawing.Point(52, 118);
            this.ConsultaDataGridView.Name = "ConsultaDataGridView";
            this.ConsultaDataGridView.Size = new System.Drawing.Size(620, 207);
            this.ConsultaDataGridView.TabIndex = 3;
            // 
            // ConsultaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 380);
            this.Controls.Add(this.ConsultaDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConsultarBoton);
            this.Controls.Add(this.CampoTextBox);
            this.Name = "ConsultaCliente";
            this.Text = "Consulta Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CampoTextBox;
        private System.Windows.Forms.Button ConsultarBoton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ConsultaDataGridView;
    }
}