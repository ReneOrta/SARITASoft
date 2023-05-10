
namespace Sara
{
    partial class Pedido
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.mod_button = new System.Windows.Forms.RadioButton();
            this.ad_button = new System.Windows.Forms.RadioButton();
            this.panel_vista = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel_vista, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.05464F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.94537F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1574, 791);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.89541F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.10459F));
            this.tableLayoutPanel2.Controls.Add(this.mod_button, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.ad_button, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1568, 81);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // mod_button
            // 
            this.mod_button.Appearance = System.Windows.Forms.Appearance.Button;
            this.mod_button.AutoSize = true;
            this.mod_button.BackColor = System.Drawing.Color.Brown;
            this.mod_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mod_button.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mod_button.ForeColor = System.Drawing.Color.Khaki;
            this.mod_button.Location = new System.Drawing.Point(754, 3);
            this.mod_button.Name = "mod_button";
            this.mod_button.Size = new System.Drawing.Size(811, 75);
            this.mod_button.TabIndex = 1;
            this.mod_button.TabStop = true;
            this.mod_button.Text = "Cancelar";
            this.mod_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mod_button.UseVisualStyleBackColor = false;
            this.mod_button.CheckedChanged += new System.EventHandler(this.mod_button_CheckedChanged);
            // 
            // ad_button
            // 
            this.ad_button.Appearance = System.Windows.Forms.Appearance.Button;
            this.ad_button.AutoSize = true;
            this.ad_button.BackColor = System.Drawing.Color.Brown;
            this.ad_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ad_button.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ad_button.ForeColor = System.Drawing.Color.Khaki;
            this.ad_button.Location = new System.Drawing.Point(3, 3);
            this.ad_button.Name = "ad_button";
            this.ad_button.Size = new System.Drawing.Size(745, 75);
            this.ad_button.TabIndex = 0;
            this.ad_button.TabStop = true;
            this.ad_button.Text = "Agregar";
            this.ad_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ad_button.UseVisualStyleBackColor = false;
            this.ad_button.CheckedChanged += new System.EventHandler(this.ad_button_CheckedChanged);
            // 
            // panel_vista
            // 
            this.panel_vista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_vista.Location = new System.Drawing.Point(3, 90);
            this.panel_vista.Name = "panel_vista";
            this.panel_vista.Size = new System.Drawing.Size(1568, 698);
            this.panel_vista.TabIndex = 1;
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1574, 791);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pedido";
            this.Text = "Pedido";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel_vista;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton mod_button;
        private System.Windows.Forms.RadioButton ad_button;
    }
}