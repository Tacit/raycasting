namespace raytracing
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
            this.pan2d = new System.Windows.Forms.Panel();
            this.pb2d = new System.Windows.Forms.PictureBox();
            this.pan3d = new System.Windows.Forms.Panel();
            this.pb3d = new System.Windows.Forms.PictureBox();
            this.btnLoadMap = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pan2d.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb2d)).BeginInit();
            this.pan3d.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb3d)).BeginInit();
            this.SuspendLayout();
            // 
            // pan2d
            // 
            this.pan2d.BackColor = System.Drawing.Color.Black;
            this.pan2d.Controls.Add(this.pb2d);
            this.pan2d.Location = new System.Drawing.Point(12, 12);
            this.pan2d.Name = "pan2d";
            this.pan2d.Size = new System.Drawing.Size(320, 240);
            this.pan2d.TabIndex = 0;
            // 
            // pb2d
            // 
            this.pb2d.BackColor = System.Drawing.Color.White;
            this.pb2d.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb2d.Location = new System.Drawing.Point(0, 0);
            this.pb2d.Name = "pb2d";
            this.pb2d.Size = new System.Drawing.Size(320, 240);
            this.pb2d.TabIndex = 0;
            this.pb2d.TabStop = false;
            // 
            // pan3d
            // 
            this.pan3d.BackColor = System.Drawing.Color.Black;
            this.pan3d.Controls.Add(this.pb3d);
            this.pan3d.Location = new System.Drawing.Point(362, 12);
            this.pan3d.Name = "pan3d";
            this.pan3d.Size = new System.Drawing.Size(320, 240);
            this.pan3d.TabIndex = 1;
            // 
            // pb3d
            // 
            this.pb3d.BackColor = System.Drawing.Color.White;
            this.pb3d.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb3d.Location = new System.Drawing.Point(0, 0);
            this.pb3d.Name = "pb3d";
            this.pb3d.Size = new System.Drawing.Size(320, 240);
            this.pb3d.TabIndex = 1;
            this.pb3d.TabStop = false;
            // 
            // btnLoadMap
            // 
            this.btnLoadMap.Location = new System.Drawing.Point(777, 12);
            this.btnLoadMap.Name = "btnLoadMap";
            this.btnLoadMap.Size = new System.Drawing.Size(75, 23);
            this.btnLoadMap.TabIndex = 2;
            this.btnLoadMap.Text = "Load Map";
            this.btnLoadMap.UseVisualStyleBackColor = true;
            this.btnLoadMap.Click += new System.EventHandler(this.btnLoadMap_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(696, 52);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Rotate Left";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(777, 52);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "Rotate Right";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(862, 278);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnLoadMap);
            this.Controls.Add(this.pan3d);
            this.Controls.Add(this.pan2d);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pan2d.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb2d)).EndInit();
            this.pan3d.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb3d)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan2d;
        private System.Windows.Forms.Panel pan3d;
        private System.Windows.Forms.Button btnLoadMap;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pb2d;
        private System.Windows.Forms.PictureBox pb3d;
    }
}

