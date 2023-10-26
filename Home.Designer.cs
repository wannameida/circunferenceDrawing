namespace circunferenceDraw
{
    partial class Home
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnConPo = new System.Windows.Forms.Button();
            this.grpPoint = new System.Windows.Forms.GroupBox();
            this.nudXPo = new System.Windows.Forms.NumericUpDown();
            this.nudYPo = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.grpCentro = new System.Windows.Forms.GroupBox();
            this.nudXCen = new System.Windows.Forms.NumericUpDown();
            this.nudYCen = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConCen = new System.Windows.Forms.Button();
            this.btnDesenhar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grpPoint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudXPo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYPo)).BeginInit();
            this.grpCentro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudXCen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYCen)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1188, 715);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.webBrowser1);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1180, 681);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sobre";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(8, 6);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1166, 669);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnDesenhar);
            this.tabPage2.Controls.Add(this.btnConPo);
            this.tabPage2.Controls.Add(this.grpPoint);
            this.tabPage2.Controls.Add(this.btnEditar);
            this.tabPage2.Controls.Add(this.grpCentro);
            this.tabPage2.Controls.Add(this.btnConCen);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1180, 681);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dados";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnConPo
            // 
            this.btnConPo.Location = new System.Drawing.Point(500, 356);
            this.btnConPo.Name = "btnConPo";
            this.btnConPo.Size = new System.Drawing.Size(156, 39);
            this.btnConPo.TabIndex = 7;
            this.btnConPo.Text = "Concluído";
            this.btnConPo.UseVisualStyleBackColor = true;
            this.btnConPo.Click += new System.EventHandler(this.btnConPo_Click);
            // 
            // grpPoint
            // 
            this.grpPoint.BackColor = System.Drawing.Color.Transparent;
            this.grpPoint.Controls.Add(this.nudXPo);
            this.grpPoint.Controls.Add(this.nudYPo);
            this.grpPoint.Controls.Add(this.label3);
            this.grpPoint.Controls.Add(this.label4);
            this.grpPoint.Location = new System.Drawing.Point(8, 210);
            this.grpPoint.Name = "grpPoint";
            this.grpPoint.Size = new System.Drawing.Size(1166, 140);
            this.grpPoint.TabIndex = 5;
            this.grpPoint.TabStop = false;
            this.grpPoint.Text = "Ponto";
            // 
            // nudXPo
            // 
            this.nudXPo.Location = new System.Drawing.Point(157, 23);
            this.nudXPo.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudXPo.Name = "nudXPo";
            this.nudXPo.Size = new System.Drawing.Size(120, 29);
            this.nudXPo.TabIndex = 4;
            this.nudXPo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudYPo
            // 
            this.nudYPo.Location = new System.Drawing.Point(889, 23);
            this.nudYPo.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudYPo.Name = "nudYPo";
            this.nudYPo.Size = new System.Drawing.Size(120, 29);
            this.nudYPo.TabIndex = 3;
            this.nudYPo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1015, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Insira o y do ponto.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Insira o x do ponto.";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(500, 636);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(156, 39);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // grpCentro
            // 
            this.grpCentro.Controls.Add(this.nudXCen);
            this.grpCentro.Controls.Add(this.nudYCen);
            this.grpCentro.Controls.Add(this.label2);
            this.grpCentro.Controls.Add(this.label1);
            this.grpCentro.Location = new System.Drawing.Point(8, 6);
            this.grpCentro.Name = "grpCentro";
            this.grpCentro.Size = new System.Drawing.Size(1166, 140);
            this.grpCentro.TabIndex = 2;
            this.grpCentro.TabStop = false;
            this.grpCentro.Text = "Centro";
            // 
            // nudXCen
            // 
            this.nudXCen.Location = new System.Drawing.Point(157, 23);
            this.nudXCen.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudXCen.Name = "nudXCen";
            this.nudXCen.Size = new System.Drawing.Size(120, 29);
            this.nudXCen.TabIndex = 4;
            this.nudXCen.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudYCen
            // 
            this.nudYCen.Location = new System.Drawing.Point(889, 23);
            this.nudYCen.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudYCen.Name = "nudYCen";
            this.nudYCen.Size = new System.Drawing.Size(120, 29);
            this.nudYCen.TabIndex = 3;
            this.nudYCen.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1015, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Insira o y do centro.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Insira o x do centro.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnConCen
            // 
            this.btnConCen.Location = new System.Drawing.Point(500, 152);
            this.btnConCen.Name = "btnConCen";
            this.btnConCen.Size = new System.Drawing.Size(156, 39);
            this.btnConCen.TabIndex = 5;
            this.btnConCen.Text = "Concluído";
            this.btnConCen.UseVisualStyleBackColor = true;
            this.btnConCen.Click += new System.EventHandler(this.btnConcluido_Click);
            // 
            // btnDesenhar
            // 
            this.btnDesenhar.Location = new System.Drawing.Point(500, 501);
            this.btnDesenhar.Name = "btnDesenhar";
            this.btnDesenhar.Size = new System.Drawing.Size(156, 39);
            this.btnDesenhar.TabIndex = 8;
            this.btnDesenhar.Text = "Desenhar";
            this.btnDesenhar.UseVisualStyleBackColor = true;
            this.btnDesenhar.Click += new System.EventHandler(this.btnDesenhar_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 727);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Home";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.grpPoint.ResumeLayout(false);
            this.grpPoint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudXPo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYPo)).EndInit();
            this.grpCentro.ResumeLayout(false);
            this.grpCentro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudXCen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYCen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpCentro;
        private System.Windows.Forms.NumericUpDown nudYCen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudXCen;
        private System.Windows.Forms.Button btnConCen;
        private System.Windows.Forms.GroupBox grpPoint;
        private System.Windows.Forms.NumericUpDown nudXPo;
        private System.Windows.Forms.NumericUpDown nudYPo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnConPo;
        private System.Windows.Forms.Button btnDesenhar;
    }
}

