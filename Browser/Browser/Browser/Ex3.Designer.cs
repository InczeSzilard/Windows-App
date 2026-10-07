namespace Browser
{
    partial class Ex3
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
            this.LbText2 = new System.Windows.Forms.Label();
            this.BtnNormal = new System.Windows.Forms.Button();
            this.BtnBold = new System.Windows.Forms.Button();
            this.BtnItalic = new System.Windows.Forms.Button();
            this.BtnColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LbText2
            // 
            this.LbText2.AutoSize = true;
            this.LbText2.Location = new System.Drawing.Point(358, 73);
            this.LbText2.Name = "LbText2";
            this.LbText2.Size = new System.Drawing.Size(197, 16);
            this.LbText2.TabIndex = 0;
            this.LbText2.Text = "Next exercis is good for practice";
            // 
            // BtnNormal
            // 
            this.BtnNormal.Location = new System.Drawing.Point(41, 346);
            this.BtnNormal.Name = "BtnNormal";
            this.BtnNormal.Size = new System.Drawing.Size(130, 49);
            this.BtnNormal.TabIndex = 1;
            this.BtnNormal.Text = "Normal";
            this.BtnNormal.UseVisualStyleBackColor = true;
            // 
            // BtnBold
            // 
            this.BtnBold.Location = new System.Drawing.Point(246, 344);
            this.BtnBold.Name = "BtnBold";
            this.BtnBold.Size = new System.Drawing.Size(144, 50);
            this.BtnBold.TabIndex = 2;
            this.BtnBold.Text = "Bold";
            this.BtnBold.UseVisualStyleBackColor = true;
            // 
            // BtnItalic
            // 
            this.BtnItalic.Location = new System.Drawing.Point(454, 347);
            this.BtnItalic.Name = "BtnItalic";
            this.BtnItalic.Size = new System.Drawing.Size(142, 47);
            this.BtnItalic.TabIndex = 3;
            this.BtnItalic.Text = "Italic";
            this.BtnItalic.UseVisualStyleBackColor = true;
            // 
            // BtnColor
            // 
            this.BtnColor.Location = new System.Drawing.Point(630, 343);
            this.BtnColor.Name = "BtnColor";
            this.BtnColor.Size = new System.Drawing.Size(148, 51);
            this.BtnColor.TabIndex = 4;
            this.BtnColor.Text = "Color";
            this.BtnColor.UseVisualStyleBackColor = true;
            // 
            // Ex3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnColor);
            this.Controls.Add(this.BtnItalic);
            this.Controls.Add(this.BtnBold);
            this.Controls.Add(this.BtnNormal);
            this.Controls.Add(this.LbText2);
            this.Name = "Ex3";
            this.Text = "Ex3";
            this.Load += new System.EventHandler(this.Ex3_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Ex3_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbText2;
        private System.Windows.Forms.Button BtnNormal;
        private System.Windows.Forms.Button BtnBold;
        private System.Windows.Forms.Button BtnItalic;
        private System.Windows.Forms.Button BtnColor;
    }
}