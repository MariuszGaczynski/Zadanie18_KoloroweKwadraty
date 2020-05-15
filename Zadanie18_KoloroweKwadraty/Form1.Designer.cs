namespace Zadanie18_KoloroweKwadraty
{
    partial class MainForm
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
            this.pnl_Square = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pnl_Square
            // 
            this.pnl_Square.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnl_Square.Location = new System.Drawing.Point(10, 10);
            this.pnl_Square.Name = "pnl_Square";
            this.pnl_Square.Size = new System.Drawing.Size(100, 100);
            this.pnl_Square.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(433, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 150;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 482);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnl_Square);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(720, 520);
            this.MinimumSize = new System.Drawing.Size(720, 520);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Bouncing Square";
            this.Load += new System.EventHandler(this.timer1_Tick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Square;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}

