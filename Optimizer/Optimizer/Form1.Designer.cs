
namespace Optimizer
{
    partial class Form1
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblStat = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnB1 = new System.Windows.Forms.Button();
            this.btnB2 = new System.Windows.Forms.Button();
            this.btnB3 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panel2.Controls.Add(this.btnB3);
            this.panel2.Controls.Add(this.lblStat);
            this.panel2.Controls.Add(this.btnB2);
            this.panel2.Controls.Add(this.btnB1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.btn1);
            this.panel2.Controls.Add(this.btn3);
            this.panel2.Controls.Add(this.btn2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(732, 346);
            this.panel2.TabIndex = 2;
            // 
            // lblStat
            // 
            this.lblStat.AutoSize = true;
            this.lblStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStat.ForeColor = System.Drawing.Color.LightGray;
            this.lblStat.Location = new System.Drawing.Point(315, 272);
            this.lblStat.Name = "lblStat";
            this.lblStat.Size = new System.Drawing.Size(0, 39);
            this.lblStat.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 100);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(291, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Optimize";
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(310, 155);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(117, 48);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "OptimizeSystem";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(549, 155);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(117, 48);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "OptimizeFullscreen";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(61, 155);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(117, 48);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "OptimizeGames";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnB1
            // 
            this.btnB1.Location = new System.Drawing.Point(82, 202);
            this.btnB1.Name = "btnB1";
            this.btnB1.Size = new System.Drawing.Size(75, 23);
            this.btnB1.TabIndex = 3;
            this.btnB1.Text = "Backup";
            this.btnB1.UseVisualStyleBackColor = true;
            this.btnB1.Click += new System.EventHandler(this.btnB1_Click);
            // 
            // btnB2
            // 
            this.btnB2.Location = new System.Drawing.Point(331, 202);
            this.btnB2.Name = "btnB2";
            this.btnB2.Size = new System.Drawing.Size(75, 23);
            this.btnB2.TabIndex = 4;
            this.btnB2.Text = "Backup";
            this.btnB2.UseVisualStyleBackColor = true;
            this.btnB2.Click += new System.EventHandler(this.btnB2_Click);
            // 
            // btnB3
            // 
            this.btnB3.Location = new System.Drawing.Point(569, 202);
            this.btnB3.Name = "btnB3";
            this.btnB3.Size = new System.Drawing.Size(75, 23);
            this.btnB3.TabIndex = 5;
            this.btnB3.Text = "Backup";
            this.btnB3.UseVisualStyleBackColor = true;
            this.btnB3.Click += new System.EventHandler(this.btnB3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 346);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Optimizer";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStat;
        private System.Windows.Forms.Button btnB3;
        private System.Windows.Forms.Button btnB2;
        private System.Windows.Forms.Button btnB1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
    }
}

