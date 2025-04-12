namespace Laba3
{
    partial class fMain
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
            this.tbBicyclesInfo = new System.Windows.Forms.TextBox();
            this.btnAddBicycle = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbBicyclesInfo
            // 
            this.tbBicyclesInfo.Location = new System.Drawing.Point(31, 24);
            this.tbBicyclesInfo.Multiline = true;
            this.tbBicyclesInfo.Name = "tbBicyclesInfo";
            this.tbBicyclesInfo.ReadOnly = true;
            this.tbBicyclesInfo.Size = new System.Drawing.Size(545, 375);
            this.tbBicyclesInfo.TabIndex = 0;
            // 
            // btnAddBicycle
            // 
            this.btnAddBicycle.Location = new System.Drawing.Point(621, 24);
            this.btnAddBicycle.Name = "btnAddBicycle";
            this.btnAddBicycle.Size = new System.Drawing.Size(143, 44);
            this.btnAddBicycle.TabIndex = 1;
            this.btnAddBicycle.Text = "Додати велосипед";
            this.btnAddBicycle.UseVisualStyleBackColor = true;
            this.btnAddBicycle.Click += new System.EventHandler(this.btnAddBicycle_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(621, 355);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(143, 44);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Закрити";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddBicycle);
            this.Controls.Add(this.tbBicyclesInfo);
            this.MaximizeBox = false;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторна робота 3";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbBicyclesInfo;
        private System.Windows.Forms.Button btnAddBicycle;
        private System.Windows.Forms.Button btnClose;
    }
}

