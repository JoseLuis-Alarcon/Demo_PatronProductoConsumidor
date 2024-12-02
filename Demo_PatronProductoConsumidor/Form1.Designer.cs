namespace Demo_PatronProductoConsumidor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            BtnRegistrar = new Button();
            TxtProducto = new TextBox();
            TxtNombreCliente = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            DgvPedidos = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            BtnProcesar = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvPedidos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnRegistrar);
            panel1.Controls.Add(TxtProducto);
            panel1.Controls.Add(TxtNombreCliente);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(9, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(358, 200);
            panel1.TabIndex = 0;
            // 
            // BtnRegistrar
            // 
            BtnRegistrar.Location = new Point(238, 151);
            BtnRegistrar.Name = "BtnRegistrar";
            BtnRegistrar.Size = new Size(107, 34);
            BtnRegistrar.TabIndex = 4;
            BtnRegistrar.Text = "Registrar";
            BtnRegistrar.UseVisualStyleBackColor = true;
            BtnRegistrar.Click += BtnRegistrar_Click;
            // 
            // TxtProducto
            // 
            TxtProducto.Location = new Point(13, 109);
            TxtProducto.Name = "TxtProducto";
            TxtProducto.Size = new Size(327, 23);
            TxtProducto.TabIndex = 3;
            // 
            // TxtNombreCliente
            // 
            TxtNombreCliente.Location = new Point(13, 37);
            TxtNombreCliente.Name = "TxtNombreCliente";
            TxtNombreCliente.Size = new Size(327, 23);
            TxtNombreCliente.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 81);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 1;
            label2.Text = "Producto a pedir : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 10);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre del cliente :";
            // 
            // panel2
            // 
            panel2.Controls.Add(DgvPedidos);
            panel2.Controls.Add(BtnProcesar);
            panel2.Location = new Point(9, 229);
            panel2.Name = "panel2";
            panel2.Size = new Size(445, 200);
            panel2.TabIndex = 1;
            // 
            // DgvPedidos
            // 
            DgvPedidos.BackgroundColor = Color.FromArgb(224, 224, 224);
            DgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvPedidos.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            DgvPedidos.Location = new Point(3, 6);
            DgvPedidos.Name = "DgvPedidos";
            DgvPedidos.Size = new Size(316, 186);
            DgvPedidos.TabIndex = 6;
            // 
            // Column1
            // 
            Column1.HeaderText = "Id";
            Column1.Name = "Column1";
            Column1.Width = 50;
            // 
            // Column2
            // 
            Column2.HeaderText = "Nombre";
            Column2.Name = "Column2";
            Column2.Width = 70;
            // 
            // Column3
            // 
            Column3.HeaderText = "Producto";
            Column3.Name = "Column3";
            Column3.Width = 70;
            // 
            // Column4
            // 
            Column4.HeaderText = "Fecha";
            Column4.Name = "Column4";
            Column4.Width = 70;
            // 
            // BtnProcesar
            // 
            BtnProcesar.Location = new Point(336, 6);
            BtnProcesar.Name = "BtnProcesar";
            BtnProcesar.Size = new Size(95, 34);
            BtnProcesar.TabIndex = 5;
            BtnProcesar.Text = "Procesar";
            BtnProcesar.UseVisualStyleBackColor = true;
            BtnProcesar.Click += BtnProcesar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(472, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvPedidos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox TxtProducto;
        private TextBox TxtNombreCliente;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Button BtnRegistrar;
        private DataGridView DgvPedidos;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Button BtnProcesar;
    }
}
