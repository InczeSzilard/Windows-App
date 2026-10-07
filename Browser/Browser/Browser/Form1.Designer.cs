namespace Browser
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
            this.components = new System.ComponentModel.Container();
            this.UP = new System.Windows.Forms.Button();
            this.Down = new System.Windows.Forms.Button();
            this.right = new System.Windows.Forms.Button();
            this.left = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.textPeriod = new System.Windows.Forms.TextBox();
            this.Ex2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UP
            // 
            this.UP.Location = new System.Drawing.Point(41, 391);
            this.UP.Name = "UP";
            this.UP.Size = new System.Drawing.Size(103, 31);
            this.UP.TabIndex = 0;
            this.UP.Text = "UP";
            this.UP.UseVisualStyleBackColor = true;
            // 
            // Down
            // 
            this.Down.Location = new System.Drawing.Point(162, 391);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(83, 31);
            this.Down.TabIndex = 1;
            this.Down.Text = "DOWN";
            this.Down.UseVisualStyleBackColor = true;
            // 
            // right
            // 
            this.right.Location = new System.Drawing.Point(280, 391);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(72, 31);
            this.right.TabIndex = 2;
            this.right.Text = "RIGHT";
            this.right.UseVisualStyleBackColor = true;
            // 
            // left
            // 
            this.left.Location = new System.Drawing.Point(375, 391);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(76, 29);
            this.left.TabIndex = 3;
            this.left.Text = "LEFT";
            this.left.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Button direction";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 252);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(444, 22);
            this.textBox1.TabIndex = 5;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(615, 388);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(144, 55);
            this.Start.TabIndex = 6;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(790, 388);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(137, 55);
            this.Stop.TabIndex = 7;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Changing period";
            // 
            // textPeriod
            // 
            this.textPeriod.Location = new System.Drawing.Point(12, 111);
            this.textPeriod.Name = "textPeriod";
            this.textPeriod.Size = new System.Drawing.Size(434, 22);
            this.textPeriod.TabIndex = 9;
            // 
            // Ex2
            // 
            this.Ex2.Location = new System.Drawing.Point(680, 124);
            this.Ex2.Name = "Ex2";
            this.Ex2.Size = new System.Drawing.Size(157, 43);
            this.Ex2.TabIndex = 10;
            this.Ex2.Text = " Continue";
            this.Ex2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 488);
            this.Controls.Add(this.Ex2);
            this.Controls.Add(this.textPeriod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.left);
            this.Controls.Add(this.right);
            this.Controls.Add(this.Down);
            this.Controls.Add(this.UP);
            this.Name = "Form1";
            this.Text = "SzilardBrowser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UP;
        private System.Windows.Forms.Button Down;
        private System.Windows.Forms.Button right;
        private System.Windows.Forms.Button left;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textPeriod;
        private System.Windows.Forms.Button Ex2;
    }
}

