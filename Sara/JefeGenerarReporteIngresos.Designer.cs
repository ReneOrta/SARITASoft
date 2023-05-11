namespace Sara
{
    partial class JefeGenerarReporteIngresos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonDia = new System.Windows.Forms.Button();
            this.buttonMes = new System.Windows.Forms.Button();
            this.buttonAnio = new System.Windows.Forms.Button();
            this.panelContenedorRepIngre = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.Khaki;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 92);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Khaki;
            this.label1.Location = new System.Drawing.Point(309, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(713, 77);
            this.label1.TabIndex = 11;
            this.label1.Text = "REPORTE DE INGRESOS";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.buttonDia, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonMes, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonAnio, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 103);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1150, 94);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // buttonDia
            // 
            this.buttonDia.BackColor = System.Drawing.Color.Brown;
            this.buttonDia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDia.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDia.ForeColor = System.Drawing.Color.Khaki;
            this.buttonDia.Location = new System.Drawing.Point(3, 3);
            this.buttonDia.Name = "buttonDia";
            this.buttonDia.Size = new System.Drawing.Size(377, 88);
            this.buttonDia.TabIndex = 7;
            this.buttonDia.Text = "POR DÍA";
            this.buttonDia.UseVisualStyleBackColor = false;
            this.buttonDia.Click += new System.EventHandler(this.buttonDia_Click);
            // 
            // buttonMes
            // 
            this.buttonMes.BackColor = System.Drawing.Color.Brown;
            this.buttonMes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMes.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMes.ForeColor = System.Drawing.Color.Khaki;
            this.buttonMes.Location = new System.Drawing.Point(386, 3);
            this.buttonMes.Name = "buttonMes";
            this.buttonMes.Size = new System.Drawing.Size(377, 88);
            this.buttonMes.TabIndex = 8;
            this.buttonMes.Text = "POR MES";
            this.buttonMes.UseVisualStyleBackColor = false;
            this.buttonMes.Click += new System.EventHandler(this.buttonMes_Click);
            // 
            // buttonAnio
            // 
            this.buttonAnio.BackColor = System.Drawing.Color.Brown;
            this.buttonAnio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAnio.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnio.ForeColor = System.Drawing.Color.Khaki;
            this.buttonAnio.Location = new System.Drawing.Point(769, 3);
            this.buttonAnio.Name = "buttonAnio";
            this.buttonAnio.Size = new System.Drawing.Size(378, 88);
            this.buttonAnio.TabIndex = 9;
            this.buttonAnio.Text = "POR AÑO";
            this.buttonAnio.UseVisualStyleBackColor = false;
            this.buttonAnio.Click += new System.EventHandler(this.buttonAnio_Click);
            // 
            // panelContenedorRepIngre
            // 
            this.panelContenedorRepIngre.BackColor = System.Drawing.Color.Peru;
            this.panelContenedorRepIngre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedorRepIngre.Location = new System.Drawing.Point(3, 203);
            this.panelContenedorRepIngre.Name = "panelContenedorRepIngre";
            this.panelContenedorRepIngre.Size = new System.Drawing.Size(1150, 459);
            this.panelContenedorRepIngre.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Peru;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panelContenedorRepIngre, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 435F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1156, 665);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // JefeGenerarReporteIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 665);
            this.Controls.Add(this.tableLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "JefeGenerarReporteIngresos";
            this.Text = "JefeGenerarReporteIngresos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonDia;
        private System.Windows.Forms.Button buttonMes;
        private System.Windows.Forms.Button buttonAnio;
        private System.Windows.Forms.Panel panelContenedorRepIngre;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}