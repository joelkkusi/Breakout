namespace Breakout
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.paddle = new System.Windows.Forms.Label();
            this.ball = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // paddle
            // 
            this.paddle.BackColor = System.Drawing.SystemColors.Control;
            this.paddle.Location = new System.Drawing.Point(200, 550);
            this.paddle.Name = "paddle";
            this.paddle.Size = new System.Drawing.Size(125, 25);
            this.paddle.TabIndex = 0;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.LightCoral;
            this.ball.Location = new System.Drawing.Point(250, 500);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(20, 20);
            this.ball.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(532, 653);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.paddle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label paddle;
        private Label ball;
    }
}