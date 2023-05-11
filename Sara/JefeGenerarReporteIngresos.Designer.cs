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
            this.buttonDia = new System.Windows.Forms.Button();
            this.buttonMes = new System.Windows.Forms.Button();
            this.buttonAnio = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContenedorRepIngre = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.panelContenedorRepIngre.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDia
            // 
            this.buttonDia.Location = new System.Drawing.Point(3, 3);
            this.buttonDia.Name = "buttonDia";
            this.buttonDia.Size = new System.Drawing.Size(75, 23);
            this.buttonDia.TabIndex = 7;
            this.buttonDia.Text = "Por Día";
            this.buttonDia.UseVisualStyleBackColor = true;
            this.buttonDia.Click += new System.EventHandler(this.buttonDia_Click);
            // 
            // buttonMes
            // 
            this.buttonMes.Location = new System.Drawing.Point(286, 3);
            this.buttonMes.Name = "buttonMes";
            this.buttonMes.Size = new System.Drawing.Size(75, 23);
            this.buttonMes.TabIndex = 8;
            this.buttonMes.Text = "Por Mes";
            this.buttonMes.UseVisualStyleBackColor = true;
            this.buttonMes.Click += new System.EventHandler(this.buttonMes_Click);
            // 
            // buttonAnio
            // 
            this.buttonAnio.Location = new System.Drawing.Point(569, 3);
            this.buttonAnio.Name = "buttonAnio";
            this.buttonAnio.Size = new System.Drawing.Size(75, 23);
            this.buttonAnio.TabIndex = 9;
            this.buttonAnio.Text = "Por Año";
            this.buttonAnio.UseVisualStyleBackColor = true;
            this.buttonAnio.Click += new System.EventHandler(this.buttonAnio_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 51);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(245, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 38);
            this.label1.TabIndex = 11;
            this.label1.Text = "Reporte De Ingresos";
            // 
            // panelContenedorRepIngre
            // 
            this.panelContenedorRepIngre.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelContenedorRepIngre.Controls.Add(this.tableLayoutPanel1);
            this.panelContenedorRepIngre.Controls.Add(this.panel1);
            this.panelContenedorRepIngre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedorRepIngre.Location = new System.Drawing.Point(0, 0);
            this.panelContenedorRepIngre.Name = "panelContenedorRepIngre";
            this.panelContenedorRepIngre.Size = new System.Drawing.Size(850, 533);
            this.panelContenedorRepIngre.TabIndex = 0;
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 57);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(852, 100);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // JefeGenerarReporteIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 533);
            this.Controls.Add(this.panelContenedorRepIngre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "JefeGenerarReporteIngresos";
            this.Text = "JefeGenerarReporteIngresos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelContenedorRepIngre.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDia;
        private System.Windows.Forms.Button buttonMes;
        private System.Windows.Forms.Button buttonAnio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelContenedorRepIngre;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}