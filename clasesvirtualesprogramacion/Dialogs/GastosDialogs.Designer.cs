namespace clasesvirtualesprogramacion.Dialogs
{
    partial class GastosDialogs
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
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label categoriaLabel;
            System.Windows.Forms.Label subcategoriaLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label formapagoLabel;
            System.Windows.Forms.Label valorLabel;
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.categoriaComboBox = new System.Windows.Forms.ComboBox();
            this.subcategoriaComboBox = new System.Windows.Forms.ComboBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.formapagoComboBox = new System.Windows.Forms.ComboBox();
            this.valorNumericUpDown = new System.Windows.Forms.NumericUpDown();
            fechaLabel = new System.Windows.Forms.Label();
            categoriaLabel = new System.Windows.Forms.Label();
            subcategoriaLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            formapagoLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valorNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(338, 218);
            this.btnguardar.Size = new System.Drawing.Size(89, 34);
            this.btnguardar.TabIndex = 6;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(444, 218);
            this.btncancelar.Size = new System.Drawing.Size(87, 34);
            this.btncancelar.TabIndex = 7;
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(12, 9);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(40, 13);
            fechaLabel.TabIndex = 3;
            fechaLabel.Text = "Fecha:";
            // 
            // categoriaLabel
            // 
            categoriaLabel.AutoSize = true;
            categoriaLabel.Location = new System.Drawing.Point(12, 65);
            categoriaLabel.Name = "categoriaLabel";
            categoriaLabel.Size = new System.Drawing.Size(55, 13);
            categoriaLabel.TabIndex = 5;
            categoriaLabel.Text = "Categoria:";
            // 
            // subcategoriaLabel
            // 
            subcategoriaLabel.AutoSize = true;
            subcategoriaLabel.Location = new System.Drawing.Point(12, 122);
            subcategoriaLabel.Name = "subcategoriaLabel";
            subcategoriaLabel.Size = new System.Drawing.Size(74, 13);
            subcategoriaLabel.TabIndex = 7;
            subcategoriaLabel.Text = "SubCategoria:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(12, 186);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 9;
            descripcionLabel.Text = "Descripcion:";
            // 
            // formapagoLabel
            // 
            formapagoLabel.AutoSize = true;
            formapagoLabel.Location = new System.Drawing.Point(291, 7);
            formapagoLabel.Name = "formapagoLabel";
            formapagoLabel.Size = new System.Drawing.Size(82, 13);
            formapagoLabel.TabIndex = 13;
            formapagoLabel.Text = "Forma de Pago:";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new System.Drawing.Point(174, 7);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(34, 13);
            valorLabel.TabIndex = 15;
            valorLabel.Text = "Valor:";
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaDateTimePicker.Location = new System.Drawing.Point(67, 9);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(91, 20);
            this.fechaDateTimePicker.TabIndex = 0;
            this.fechaDateTimePicker.Value = new System.DateTime(2020, 10, 29, 0, 0, 0, 0);
            // 
            // categoriaComboBox
            // 
            this.categoriaComboBox.FormattingEnabled = true;
            this.categoriaComboBox.Items.AddRange(new object[] {
            "ALIMENTOS",
            "TRANSPORTE",
            "HOGAR",
            "LAVANDERÍA",
            "DIVERSIÓN",
            "PERSONAL"});
            this.categoriaComboBox.Location = new System.Drawing.Point(140, 65);
            this.categoriaComboBox.Name = "categoriaComboBox";
            this.categoriaComboBox.Size = new System.Drawing.Size(391, 21);
            this.categoriaComboBox.TabIndex = 3;
            // 
            // subcategoriaComboBox
            // 
            this.subcategoriaComboBox.FormattingEnabled = true;
            this.subcategoriaComboBox.Items.AddRange(new object[] {
            "SUPERMERCADO",
            "KIOSKO",
            "RESTAURANTE",
            "TAXI",
            "BUS",
            "MOTOTAXI",
            "ELECTRICIDAD",
            "AGUA",
            "TELÉFONO",
            "JABÓN",
            "DETERGENTE",
            "SUAVIZANTE",
            "AZISTIN",
            "CINE ",
            "VIAJE",
            "OTROS"});
            this.subcategoriaComboBox.Location = new System.Drawing.Point(140, 122);
            this.subcategoriaComboBox.Name = "subcategoriaComboBox";
            this.subcategoriaComboBox.Size = new System.Drawing.Size(391, 21);
            this.subcategoriaComboBox.TabIndex = 4;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.descripcionTextBox.Location = new System.Drawing.Point(140, 183);
            this.descripcionTextBox.Multiline = true;
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(391, 20);
            this.descripcionTextBox.TabIndex = 5;
            // 
            // formapagoComboBox
            // 
            this.formapagoComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.formapagoComboBox.FormattingEnabled = true;
            this.formapagoComboBox.Items.AddRange(new object[] {
            "EFECTIVO",
            "CRÉDITO",
            "TARJETA DE CRÉDITO"});
            this.formapagoComboBox.Location = new System.Drawing.Point(379, 6);
            this.formapagoComboBox.Name = "formapagoComboBox";
            this.formapagoComboBox.Size = new System.Drawing.Size(152, 21);
            this.formapagoComboBox.TabIndex = 2;
            this.formapagoComboBox.SelectedIndexChanged += new System.EventHandler(this.formapagoComboBox_SelectedIndexChanged);
            // 
            // valorNumericUpDown
            // 
            this.valorNumericUpDown.Location = new System.Drawing.Point(214, 7);
            this.valorNumericUpDown.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.valorNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.valorNumericUpDown.Name = "valorNumericUpDown";
            this.valorNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.valorNumericUpDown.TabIndex = 1;
            this.valorNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // GastosDialogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 273);
            this.Controls.Add(valorLabel);
            this.Controls.Add(this.valorNumericUpDown);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(categoriaLabel);
            this.Controls.Add(this.categoriaComboBox);
            this.Controls.Add(subcategoriaLabel);
            this.Controls.Add(this.subcategoriaComboBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(formapagoLabel);
            this.Controls.Add(this.formapagoComboBox);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "GastosDialogs";
            this.Text = "Informacón de Gastos";
            this.Controls.SetChildIndex(this.btnguardar, 0);
            this.Controls.SetChildIndex(this.btncancelar, 0);
            this.Controls.SetChildIndex(this.formapagoComboBox, 0);
            this.Controls.SetChildIndex(formapagoLabel, 0);
            this.Controls.SetChildIndex(this.descripcionTextBox, 0);
            this.Controls.SetChildIndex(descripcionLabel, 0);
            this.Controls.SetChildIndex(this.subcategoriaComboBox, 0);
            this.Controls.SetChildIndex(subcategoriaLabel, 0);
            this.Controls.SetChildIndex(this.categoriaComboBox, 0);
            this.Controls.SetChildIndex(categoriaLabel, 0);
            this.Controls.SetChildIndex(this.fechaDateTimePicker, 0);
            this.Controls.SetChildIndex(fechaLabel, 0);
            this.Controls.SetChildIndex(this.valorNumericUpDown, 0);
            this.Controls.SetChildIndex(valorLabel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.erp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valorNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        public System.Windows.Forms.ComboBox categoriaComboBox;
        public System.Windows.Forms.ComboBox subcategoriaComboBox;
        public System.Windows.Forms.TextBox descripcionTextBox;
        public System.Windows.Forms.ComboBox formapagoComboBox;
        public System.Windows.Forms.NumericUpDown valorNumericUpDown;
    }
}