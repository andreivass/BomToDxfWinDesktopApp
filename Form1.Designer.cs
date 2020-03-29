namespace DxfBom1
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
            this.lblBrowseDxf = new System.Windows.Forms.Label();
            this.lblBrowseTxt = new System.Windows.Forms.Label();
            this.btnBrowseDxf = new System.Windows.Forms.Button();
            this.btnBrowseTxt = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblSelectedDfx = new System.Windows.Forms.Label();
            this.lblTxtSelected = new System.Windows.Forms.Label();
            this.lblRun = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBrowseDxf
            // 
            this.lblBrowseDxf.AutoSize = true;
            this.lblBrowseDxf.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrowseDxf.Location = new System.Drawing.Point(12, 29);
            this.lblBrowseDxf.Name = "lblBrowseDxf";
            this.lblBrowseDxf.Size = new System.Drawing.Size(260, 42);
            this.lblBrowseDxf.TabIndex = 0;
            this.lblBrowseDxf.Text = "Browse dxf file";
            this.lblBrowseDxf.Click += new System.EventHandler(this.lblBrowseDxf_Click);
            // 
            // lblBrowseTxt
            // 
            this.lblBrowseTxt.AutoSize = true;
            this.lblBrowseTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrowseTxt.Location = new System.Drawing.Point(12, 191);
            this.lblBrowseTxt.Name = "lblBrowseTxt";
            this.lblBrowseTxt.Size = new System.Drawing.Size(354, 42);
            this.lblBrowseTxt.TabIndex = 1;
            this.lblBrowseTxt.Text = "Browse BOM .txt file";
            // 
            // btnBrowseDxf
            // 
            this.btnBrowseDxf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseDxf.Location = new System.Drawing.Point(19, 90);
            this.btnBrowseDxf.Name = "btnBrowseDxf";
            this.btnBrowseDxf.Size = new System.Drawing.Size(171, 51);
            this.btnBrowseDxf.TabIndex = 2;
            this.btnBrowseDxf.Text = "Browse dxf";
            this.btnBrowseDxf.UseVisualStyleBackColor = true;
            this.btnBrowseDxf.Click += new System.EventHandler(this.btnBrowseDxf_Click);
            // 
            // btnBrowseTxt
            // 
            this.btnBrowseTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseTxt.Location = new System.Drawing.Point(19, 255);
            this.btnBrowseTxt.Name = "btnBrowseTxt";
            this.btnBrowseTxt.Size = new System.Drawing.Size(171, 51);
            this.btnBrowseTxt.TabIndex = 3;
            this.btnBrowseTxt.Text = "Browse txt";
            this.btnBrowseTxt.UseVisualStyleBackColor = true;
            this.btnBrowseTxt.Click += new System.EventHandler(this.btnBrowseTxt_Click);
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.Location = new System.Drawing.Point(19, 379);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(171, 51);
            this.btnRun.TabIndex = 4;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblSelectedDfx
            // 
            this.lblSelectedDfx.AutoSize = true;
            this.lblSelectedDfx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedDfx.Location = new System.Drawing.Point(12, 149);
            this.lblSelectedDfx.Name = "lblSelectedDfx";
            this.lblSelectedDfx.Size = new System.Drawing.Size(170, 25);
            this.lblSelectedDfx.TabIndex = 5;
            this.lblSelectedDfx.Text = "File not selected";
            // 
            // lblTxtSelected
            // 
            this.lblTxtSelected.AutoSize = true;
            this.lblTxtSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxtSelected.Location = new System.Drawing.Point(14, 329);
            this.lblTxtSelected.Name = "lblTxtSelected";
            this.lblTxtSelected.Size = new System.Drawing.Size(170, 25);
            this.lblTxtSelected.TabIndex = 6;
            this.lblTxtSelected.Text = "File not selected";
            // 
            // lblRun
            // 
            this.lblRun.AutoSize = true;
            this.lblRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRun.Location = new System.Drawing.Point(269, 392);
            this.lblRun.Name = "lblRun";
            this.lblRun.Size = new System.Drawing.Size(104, 25);
            this.lblRun.TabIndex = 7;
            this.lblRun.Text = "Click Run";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Created by Andrei Vassiljev for Usesoft AS 2020";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRun);
            this.Controls.Add(this.lblTxtSelected);
            this.Controls.Add(this.lblSelectedDfx);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnBrowseTxt);
            this.Controls.Add(this.btnBrowseDxf);
            this.Controls.Add(this.lblBrowseTxt);
            this.Controls.Add(this.lblBrowseDxf);
            this.Name = "Form1";
            this.Text = "Add BOM to dxf";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBrowseDxf;
        private System.Windows.Forms.Label lblBrowseTxt;
        private System.Windows.Forms.Button btnBrowseDxf;
        private System.Windows.Forms.Button btnBrowseTxt;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblSelectedDfx;
        private System.Windows.Forms.Label lblTxtSelected;
        private System.Windows.Forms.Label lblRun;
        private System.Windows.Forms.Label label1;
    }
}

