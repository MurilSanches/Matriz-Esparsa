
partial class frmMatriz
{
    /// <summary>
    /// Variável de designer necessária.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpar os recursos que estão sendo usados.
    /// </summary>
    /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Código gerado pelo Windows Form Designer

    /// <summary>
    /// Método necessário para suporte ao Designer - não modifique 
    /// o conteúdo deste método com o editor de código.
    /// </summary>
    private void InitializeComponent()
    {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.gbMatriz1 = new System.Windows.Forms.GroupBox();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.btnLerMatriz1 = new System.Windows.Forms.Button();
            this.btnSomarValor1 = new System.Windows.Forms.Button();
            this.btnZerar1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.qtdLi1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.qtdCol1 = new System.Windows.Forms.NumericUpDown();
            this.btnExcluir1 = new System.Windows.Forms.Button();
            this.btnIncluir1 = new System.Windows.Forms.Button();
            this.dgvMatriz1 = new System.Windows.Forms.DataGridView();
            this.gbMatriz2 = new System.Windows.Forms.GroupBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.btnLerMatriz2 = new System.Windows.Forms.Button();
            this.btnSomarValor2 = new System.Windows.Forms.Button();
            this.btnZerar2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.qtdLi2 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.qtdCol2 = new System.Windows.Forms.NumericUpDown();
            this.btnExcluir2 = new System.Windows.Forms.Button();
            this.btnIncluir2 = new System.Windows.Forms.Button();
            this.dgvMatriz2 = new System.Windows.Forms.DataGridView();
            this.gbResultado = new System.Windows.Forms.GroupBox();
            this.btnSomarMatrizes = new System.Windows.Forms.Button();
            this.btnMultiplicarMatrizes = new System.Windows.Forms.Button();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.dlgArquivo = new System.Windows.Forms.OpenFileDialog();
            this.btnProcurar1 = new System.Windows.Forms.Button();
            this.btnProcurar2 = new System.Windows.Forms.Button();
            this.gbMatriz1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qtdLi1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtdCol1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz1)).BeginInit();
            this.gbMatriz2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qtdLi2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtdCol2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz2)).BeginInit();
            this.gbResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(593, 9);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(257, 39);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Matriz Esparsa";
            // 
            // gbMatriz1
            // 
            this.gbMatriz1.BackColor = System.Drawing.Color.IndianRed;
            this.gbMatriz1.Controls.Add(this.btnProcurar1);
            this.gbMatriz1.Controls.Add(this.txtValor1);
            this.gbMatriz1.Controls.Add(this.btnLerMatriz1);
            this.gbMatriz1.Controls.Add(this.btnSomarValor1);
            this.gbMatriz1.Controls.Add(this.btnZerar1);
            this.gbMatriz1.Controls.Add(this.label2);
            this.gbMatriz1.Controls.Add(this.label3);
            this.gbMatriz1.Controls.Add(this.qtdLi1);
            this.gbMatriz1.Controls.Add(this.label1);
            this.gbMatriz1.Controls.Add(this.qtdCol1);
            this.gbMatriz1.Controls.Add(this.btnExcluir1);
            this.gbMatriz1.Controls.Add(this.btnIncluir1);
            this.gbMatriz1.Controls.Add(this.dgvMatriz1);
            this.gbMatriz1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbMatriz1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMatriz1.Location = new System.Drawing.Point(12, 64);
            this.gbMatriz1.Name = "gbMatriz1";
            this.gbMatriz1.Size = new System.Drawing.Size(451, 619);
            this.gbMatriz1.TabIndex = 2;
            this.gbMatriz1.TabStop = false;
            this.gbMatriz1.Text = " Matriz 1 ";
            // 
            // txtValor1
            // 
            this.txtValor1.Enabled = false;
            this.txtValor1.Location = new System.Drawing.Point(100, 361);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtValor1.Size = new System.Drawing.Size(314, 26);
            this.txtValor1.TabIndex = 23;
            // 
            // btnLerMatriz1
            // 
            this.btnLerMatriz1.BackColor = System.Drawing.Color.LightCoral;
            this.btnLerMatriz1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLerMatriz1.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.btnLerMatriz1.FlatAppearance.BorderSize = 4;
            this.btnLerMatriz1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLerMatriz1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLerMatriz1.Location = new System.Drawing.Point(29, 545);
            this.btnLerMatriz1.Name = "btnLerMatriz1";
            this.btnLerMatriz1.Size = new System.Drawing.Size(385, 43);
            this.btnLerMatriz1.TabIndex = 22;
            this.btnLerMatriz1.Text = "Ler Matriz 1";
            this.btnLerMatriz1.UseVisualStyleBackColor = false;
            this.btnLerMatriz1.Click += new System.EventHandler(this.btnLerMatriz1_Click);
            // 
            // btnSomarValor1
            // 
            this.btnSomarValor1.BackColor = System.Drawing.Color.LightCoral;
            this.btnSomarValor1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSomarValor1.Enabled = false;
            this.btnSomarValor1.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.btnSomarValor1.FlatAppearance.BorderSize = 4;
            this.btnSomarValor1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSomarValor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSomarValor1.Location = new System.Drawing.Point(29, 475);
            this.btnSomarValor1.Name = "btnSomarValor1";
            this.btnSomarValor1.Size = new System.Drawing.Size(385, 43);
            this.btnSomarValor1.TabIndex = 21;
            this.btnSomarValor1.Text = "Somar Valor na Coluna ";
            this.btnSomarValor1.UseVisualStyleBackColor = false;
            this.btnSomarValor1.Click += new System.EventHandler(this.btnSomarValor1_Click);
            // 
            // btnZerar1
            // 
            this.btnZerar1.BackColor = System.Drawing.Color.LightCoral;
            this.btnZerar1.Enabled = false;
            this.btnZerar1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnZerar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZerar1.Location = new System.Drawing.Point(295, 411);
            this.btnZerar1.Name = "btnZerar1";
            this.btnZerar1.Size = new System.Drawing.Size(119, 43);
            this.btnZerar1.TabIndex = 20;
            this.btnZerar1.Text = "Zerar Matriz";
            this.btnZerar1.UseVisualStyleBackColor = false;
            this.btnZerar1.Click += new System.EventHandler(this.btnZerar1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Linha: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(220, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Coluna: ";
            // 
            // qtdLi1
            // 
            this.qtdLi1.Enabled = false;
            this.qtdLi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtdLi1.Location = new System.Drawing.Point(102, 316);
            this.qtdLi1.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.qtdLi1.Name = "qtdLi1";
            this.qtdLi1.Size = new System.Drawing.Size(98, 26);
            this.qtdLi1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Valor: ";
            // 
            // qtdCol1
            // 
            this.qtdCol1.Enabled = false;
            this.qtdCol1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtdCol1.Location = new System.Drawing.Point(316, 316);
            this.qtdCol1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.qtdCol1.Name = "qtdCol1";
            this.qtdCol1.Size = new System.Drawing.Size(98, 26);
            this.qtdCol1.TabIndex = 19;
            // 
            // btnExcluir1
            // 
            this.btnExcluir1.BackColor = System.Drawing.Color.LightCoral;
            this.btnExcluir1.Enabled = false;
            this.btnExcluir1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluir1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir1.Location = new System.Drawing.Point(114, 411);
            this.btnExcluir1.Name = "btnExcluir1";
            this.btnExcluir1.Size = new System.Drawing.Size(86, 43);
            this.btnExcluir1.TabIndex = 16;
            this.btnExcluir1.Text = "Excluir";
            this.btnExcluir1.UseVisualStyleBackColor = false;
            this.btnExcluir1.Click += new System.EventHandler(this.btnExcluir1_Click);
            // 
            // btnIncluir1
            // 
            this.btnIncluir1.BackColor = System.Drawing.Color.LightCoral;
            this.btnIncluir1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnIncluir1.Enabled = false;
            this.btnIncluir1.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.btnIncluir1.FlatAppearance.BorderSize = 4;
            this.btnIncluir1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIncluir1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluir1.Location = new System.Drawing.Point(29, 411);
            this.btnIncluir1.Name = "btnIncluir1";
            this.btnIncluir1.Size = new System.Drawing.Size(79, 43);
            this.btnIncluir1.TabIndex = 15;
            this.btnIncluir1.Text = "Incluir";
            this.btnIncluir1.UseVisualStyleBackColor = false;
            this.btnIncluir1.Click += new System.EventHandler(this.btnIncluir1_Click);
            // 
            // dgvMatriz1
            // 
            this.dgvMatriz1.AllowUserToAddRows = false;
            this.dgvMatriz1.AllowUserToDeleteRows = false;
            this.dgvMatriz1.AllowUserToOrderColumns = true;
            this.dgvMatriz1.AllowUserToResizeColumns = false;
            this.dgvMatriz1.AllowUserToResizeRows = false;
            this.dgvMatriz1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvMatriz1.BackgroundColor = System.Drawing.Color.White;
            this.dgvMatriz1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatriz1.ColumnHeadersVisible = false;
            this.dgvMatriz1.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMatriz1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvMatriz1.Location = new System.Drawing.Point(29, 43);
            this.dgvMatriz1.Margin = new System.Windows.Forms.Padding(5);
            this.dgvMatriz1.Name = "dgvMatriz1";
            this.dgvMatriz1.ReadOnly = true;
            this.dgvMatriz1.RowHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvMatriz1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvMatriz1.Size = new System.Drawing.Size(394, 242);
            this.dgvMatriz1.TabIndex = 3;
            // 
            // gbMatriz2
            // 
            this.gbMatriz2.BackColor = System.Drawing.Color.IndianRed;
            this.gbMatriz2.Controls.Add(this.btnProcurar2);
            this.gbMatriz2.Controls.Add(this.txtValor2);
            this.gbMatriz2.Controls.Add(this.btnLerMatriz2);
            this.gbMatriz2.Controls.Add(this.btnSomarValor2);
            this.gbMatriz2.Controls.Add(this.btnZerar2);
            this.gbMatriz2.Controls.Add(this.label4);
            this.gbMatriz2.Controls.Add(this.label5);
            this.gbMatriz2.Controls.Add(this.qtdLi2);
            this.gbMatriz2.Controls.Add(this.label6);
            this.gbMatriz2.Controls.Add(this.qtdCol2);
            this.gbMatriz2.Controls.Add(this.btnExcluir2);
            this.gbMatriz2.Controls.Add(this.btnIncluir2);
            this.gbMatriz2.Controls.Add(this.dgvMatriz2);
            this.gbMatriz2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbMatriz2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMatriz2.Location = new System.Drawing.Point(484, 64);
            this.gbMatriz2.Name = "gbMatriz2";
            this.gbMatriz2.Size = new System.Drawing.Size(445, 619);
            this.gbMatriz2.TabIndex = 22;
            this.gbMatriz2.TabStop = false;
            this.gbMatriz2.Text = " Matriz 2 ";
            // 
            // txtValor2
            // 
            this.txtValor2.Enabled = false;
            this.txtValor2.Location = new System.Drawing.Point(96, 368);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtValor2.Size = new System.Drawing.Size(314, 26);
            this.txtValor2.TabIndex = 24;
            // 
            // btnLerMatriz2
            // 
            this.btnLerMatriz2.BackColor = System.Drawing.Color.LightCoral;
            this.btnLerMatriz2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLerMatriz2.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.btnLerMatriz2.FlatAppearance.BorderSize = 4;
            this.btnLerMatriz2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLerMatriz2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLerMatriz2.Location = new System.Drawing.Point(25, 545);
            this.btnLerMatriz2.Name = "btnLerMatriz2";
            this.btnLerMatriz2.Size = new System.Drawing.Size(385, 43);
            this.btnLerMatriz2.TabIndex = 23;
            this.btnLerMatriz2.Text = "Ler Matriz 2";
            this.btnLerMatriz2.UseVisualStyleBackColor = false;
            this.btnLerMatriz2.Click += new System.EventHandler(this.btnLerMatriz2_Click);
            // 
            // btnSomarValor2
            // 
            this.btnSomarValor2.BackColor = System.Drawing.Color.LightCoral;
            this.btnSomarValor2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSomarValor2.Enabled = false;
            this.btnSomarValor2.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.btnSomarValor2.FlatAppearance.BorderSize = 4;
            this.btnSomarValor2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSomarValor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSomarValor2.Location = new System.Drawing.Point(25, 475);
            this.btnSomarValor2.Name = "btnSomarValor2";
            this.btnSomarValor2.Size = new System.Drawing.Size(385, 43);
            this.btnSomarValor2.TabIndex = 21;
            this.btnSomarValor2.Text = "Somar Valor na Coluna ";
            this.btnSomarValor2.UseVisualStyleBackColor = false;
            this.btnSomarValor2.Click += new System.EventHandler(this.btnSomarValor2_Click);
            // 
            // btnZerar2
            // 
            this.btnZerar2.BackColor = System.Drawing.Color.LightCoral;
            this.btnZerar2.Enabled = false;
            this.btnZerar2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnZerar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZerar2.Location = new System.Drawing.Point(293, 411);
            this.btnZerar2.Name = "btnZerar2";
            this.btnZerar2.Size = new System.Drawing.Size(117, 43);
            this.btnZerar2.TabIndex = 20;
            this.btnZerar2.Text = "Zerar Matriz";
            this.btnZerar2.UseVisualStyleBackColor = false;
            this.btnZerar2.Click += new System.EventHandler(this.btnZerar2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Linha: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(216, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Coluna: ";
            // 
            // qtdLi2
            // 
            this.qtdLi2.Enabled = false;
            this.qtdLi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtdLi2.Location = new System.Drawing.Point(98, 324);
            this.qtdLi2.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.qtdLi2.Name = "qtdLi2";
            this.qtdLi2.Size = new System.Drawing.Size(98, 26);
            this.qtdLi2.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Valor: ";
            // 
            // qtdCol2
            // 
            this.qtdCol2.Enabled = false;
            this.qtdCol2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtdCol2.Location = new System.Drawing.Point(312, 324);
            this.qtdCol2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.qtdCol2.Name = "qtdCol2";
            this.qtdCol2.Size = new System.Drawing.Size(98, 26);
            this.qtdCol2.TabIndex = 19;
            // 
            // btnExcluir2
            // 
            this.btnExcluir2.BackColor = System.Drawing.Color.LightCoral;
            this.btnExcluir2.Enabled = false;
            this.btnExcluir2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluir2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir2.Location = new System.Drawing.Point(116, 411);
            this.btnExcluir2.Name = "btnExcluir2";
            this.btnExcluir2.Size = new System.Drawing.Size(80, 43);
            this.btnExcluir2.TabIndex = 16;
            this.btnExcluir2.Text = "Excluir";
            this.btnExcluir2.UseVisualStyleBackColor = false;
            this.btnExcluir2.Click += new System.EventHandler(this.btnExcluir2_Click);
            // 
            // btnIncluir2
            // 
            this.btnIncluir2.BackColor = System.Drawing.Color.LightCoral;
            this.btnIncluir2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnIncluir2.Enabled = false;
            this.btnIncluir2.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.btnIncluir2.FlatAppearance.BorderSize = 4;
            this.btnIncluir2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIncluir2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluir2.Location = new System.Drawing.Point(25, 411);
            this.btnIncluir2.Name = "btnIncluir2";
            this.btnIncluir2.Size = new System.Drawing.Size(84, 43);
            this.btnIncluir2.TabIndex = 15;
            this.btnIncluir2.Text = "Incluir";
            this.btnIncluir2.UseVisualStyleBackColor = false;
            this.btnIncluir2.Click += new System.EventHandler(this.btnIncluir2_Click);
            // 
            // dgvMatriz2
            // 
            this.dgvMatriz2.AllowUserToAddRows = false;
            this.dgvMatriz2.AllowUserToDeleteRows = false;
            this.dgvMatriz2.AllowUserToOrderColumns = true;
            this.dgvMatriz2.AllowUserToResizeColumns = false;
            this.dgvMatriz2.AllowUserToResizeRows = false;
            this.dgvMatriz2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvMatriz2.BackgroundColor = System.Drawing.Color.White;
            this.dgvMatriz2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatriz2.ColumnHeadersVisible = false;
            this.dgvMatriz2.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMatriz2.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvMatriz2.Location = new System.Drawing.Point(25, 43);
            this.dgvMatriz2.Margin = new System.Windows.Forms.Padding(5);
            this.dgvMatriz2.Name = "dgvMatriz2";
            this.dgvMatriz2.ReadOnly = true;
            this.dgvMatriz2.RowHeadersVisible = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvMatriz2.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvMatriz2.Size = new System.Drawing.Size(394, 242);
            this.dgvMatriz2.TabIndex = 3;
            // 
            // gbResultado
            // 
            this.gbResultado.BackColor = System.Drawing.Color.IndianRed;
            this.gbResultado.Controls.Add(this.btnSomarMatrizes);
            this.gbResultado.Controls.Add(this.btnMultiplicarMatrizes);
            this.gbResultado.Controls.Add(this.dgvResultado);
            this.gbResultado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResultado.Location = new System.Drawing.Point(946, 64);
            this.gbResultado.Name = "gbResultado";
            this.gbResultado.Size = new System.Drawing.Size(529, 619);
            this.gbResultado.TabIndex = 24;
            this.gbResultado.TabStop = false;
            this.gbResultado.Text = " Resultado ";
            // 
            // btnSomarMatrizes
            // 
            this.btnSomarMatrizes.BackColor = System.Drawing.Color.LightCoral;
            this.btnSomarMatrizes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSomarMatrizes.Enabled = false;
            this.btnSomarMatrizes.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.btnSomarMatrizes.FlatAppearance.BorderSize = 4;
            this.btnSomarMatrizes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSomarMatrizes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSomarMatrizes.Location = new System.Drawing.Point(25, 545);
            this.btnSomarMatrizes.Name = "btnSomarMatrizes";
            this.btnSomarMatrizes.Size = new System.Drawing.Size(479, 43);
            this.btnSomarMatrizes.TabIndex = 23;
            this.btnSomarMatrizes.Text = "Somar Matrizes";
            this.btnSomarMatrizes.UseVisualStyleBackColor = false;
            this.btnSomarMatrizes.Click += new System.EventHandler(this.btnSomarMatrizes_Click);
            // 
            // btnMultiplicarMatrizes
            // 
            this.btnMultiplicarMatrizes.BackColor = System.Drawing.Color.LightCoral;
            this.btnMultiplicarMatrizes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMultiplicarMatrizes.Enabled = false;
            this.btnMultiplicarMatrizes.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.btnMultiplicarMatrizes.FlatAppearance.BorderSize = 4;
            this.btnMultiplicarMatrizes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMultiplicarMatrizes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicarMatrizes.Location = new System.Drawing.Point(25, 475);
            this.btnMultiplicarMatrizes.Name = "btnMultiplicarMatrizes";
            this.btnMultiplicarMatrizes.Size = new System.Drawing.Size(479, 43);
            this.btnMultiplicarMatrizes.TabIndex = 21;
            this.btnMultiplicarMatrizes.Text = "Multiplicar Matrizes";
            this.btnMultiplicarMatrizes.UseVisualStyleBackColor = false;
            this.btnMultiplicarMatrizes.Click += new System.EventHandler(this.btnMultiplicarMatrizes_Click);
            // 
            // dgvResultado
            // 
            this.dgvResultado.AllowUserToAddRows = false;
            this.dgvResultado.AllowUserToDeleteRows = false;
            this.dgvResultado.AllowUserToOrderColumns = true;
            this.dgvResultado.AllowUserToResizeColumns = false;
            this.dgvResultado.AllowUserToResizeRows = false;
            this.dgvResultado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvResultado.BackgroundColor = System.Drawing.Color.White;
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.ColumnHeadersVisible = false;
            this.dgvResultado.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResultado.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvResultado.Location = new System.Drawing.Point(25, 43);
            this.dgvResultado.Margin = new System.Windows.Forms.Padding(5);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.ReadOnly = true;
            this.dgvResultado.RowHeadersVisible = false;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvResultado.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvResultado.Size = new System.Drawing.Size(479, 411);
            this.dgvResultado.TabIndex = 3;
            // 
            // dlgArquivo
            // 
            this.dlgArquivo.FileName = "openFileDialog1";
            // 
            // btnProcurar1
            // 
            this.btnProcurar1.BackColor = System.Drawing.Color.LightCoral;
            this.btnProcurar1.Enabled = false;
            this.btnProcurar1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProcurar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcurar1.Location = new System.Drawing.Point(206, 411);
            this.btnProcurar1.Name = "btnProcurar1";
            this.btnProcurar1.Size = new System.Drawing.Size(83, 43);
            this.btnProcurar1.TabIndex = 24;
            this.btnProcurar1.Text = "Procurar";
            this.btnProcurar1.UseVisualStyleBackColor = false;
            this.btnProcurar1.Click += new System.EventHandler(this.btnProcurar1_Click);
            // 
            // btnProcurar2
            // 
            this.btnProcurar2.BackColor = System.Drawing.Color.LightCoral;
            this.btnProcurar2.Enabled = false;
            this.btnProcurar2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProcurar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcurar2.Location = new System.Drawing.Point(202, 411);
            this.btnProcurar2.Name = "btnProcurar2";
            this.btnProcurar2.Size = new System.Drawing.Size(83, 43);
            this.btnProcurar2.TabIndex = 25;
            this.btnProcurar2.Text = "Procurar";
            this.btnProcurar2.UseVisualStyleBackColor = false;
            this.btnProcurar2.Click += new System.EventHandler(this.btnProcurar2_Click);
            // 
            // frmMatriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(1487, 694);
            this.Controls.Add(this.gbResultado);
            this.Controls.Add(this.gbMatriz2);
            this.Controls.Add(this.gbMatriz1);
            this.Controls.Add(this.lbTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmMatriz";
            this.ShowIcon = false;
            this.Text = "Matriz Esparsa";
            this.gbMatriz1.ResumeLayout(false);
            this.gbMatriz1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qtdLi1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtdCol1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz1)).EndInit();
            this.gbMatriz2.ResumeLayout(false);
            this.gbMatriz2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qtdLi2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtdCol2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz2)).EndInit();
            this.gbResultado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lbTitulo;
    private System.Windows.Forms.GroupBox gbMatriz1;
    private System.Windows.Forms.DataGridView dgvMatriz1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.NumericUpDown qtdLi1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.NumericUpDown qtdCol1;
    private System.Windows.Forms.Button btnExcluir1;
    private System.Windows.Forms.Button btnIncluir1;
    private System.Windows.Forms.Button btnZerar1;
    private System.Windows.Forms.Button btnSomarValor1;
    private System.Windows.Forms.GroupBox gbMatriz2;
    private System.Windows.Forms.Button btnSomarValor2;
    private System.Windows.Forms.Button btnZerar2;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.NumericUpDown qtdLi2;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.NumericUpDown qtdCol2;
    private System.Windows.Forms.Button btnExcluir2;
    private System.Windows.Forms.Button btnIncluir2;
    private System.Windows.Forms.Button btnLerMatriz1;
    private System.Windows.Forms.Button btnLerMatriz2;
    private System.Windows.Forms.GroupBox gbResultado;
    private System.Windows.Forms.Button btnSomarMatrizes;
    private System.Windows.Forms.Button btnMultiplicarMatrizes;
    private System.Windows.Forms.DataGridView dgvResultado;
    private System.Windows.Forms.OpenFileDialog dlgArquivo;
    private System.Windows.Forms.TextBox txtValor1;
    private System.Windows.Forms.TextBox txtValor2;
    protected System.Windows.Forms.DataGridView dgvMatriz2;
    private System.Windows.Forms.Button btnProcurar1;
    private System.Windows.Forms.Button btnProcurar2;
}


