namespace TibiaXBot
{
    partial class Mapviewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mapviewer));
            this.button1 = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.mapViewer1 = new Tibia.Util.MapViewer();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.Floor = new System.Windows.Forms.Label();
            this.timerFloor = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlText;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(274, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // plus
            // 
            this.plus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plus.FlatAppearance.BorderSize = 0;
            this.plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.plus.Location = new System.Drawing.Point(239, 12);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(42, 38);
            this.plus.TabIndex = 5;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // minus
            // 
            this.minus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minus.FlatAppearance.BorderSize = 0;
            this.minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.minus.Location = new System.Drawing.Point(239, 45);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(42, 38);
            this.minus.TabIndex = 6;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // mapViewer1
            // 
            this.mapViewer1.Directory = "";
            this.mapViewer1.DrawCoors = true;
            this.mapViewer1.DrawCrosshair = true;
            this.mapViewer1.Location = new System.Drawing.Point(0, 1);
            this.mapViewer1.Name = "mapViewer1";
            this.mapViewer1.OpenTibiaMaps = false;
            this.mapViewer1.Size = new System.Drawing.Size(233, 210);
            this.mapViewer1.TabIndex = 8;
            this.mapViewer1.Paint += new System.Windows.Forms.PaintEventHandler(this.mapViewer1_Paint);
            // 
            // buttonUp
            // 
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonUp.FlatAppearance.BorderSize = 0;
            this.buttonUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonUp.Location = new System.Drawing.Point(239, 89);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(42, 24);
            this.buttonUp.TabIndex = 9;
            this.buttonUp.Text = "^";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDown.FlatAppearance.BorderSize = 0;
            this.buttonDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDown.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDown.Location = new System.Drawing.Point(239, 119);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(42, 38);
            this.buttonDown.TabIndex = 10;
            this.buttonDown.Text = "v";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // Floor
            // 
            this.Floor.AutoSize = true;
            this.Floor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Floor.Location = new System.Drawing.Point(257, 188);
            this.Floor.Name = "Floor";
            this.Floor.Size = new System.Drawing.Size(11, 13);
            this.Floor.TabIndex = 11;
            this.Floor.Text = "*";
            // 
            // timerFloor
            // 
            this.timerFloor.Enabled = true;
            this.timerFloor.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(236, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Z:";
            // 
            // Mapviewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(293, 210);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Floor);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.mapViewer1);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mapviewer";
            this.Text = "Mapviewer";
            this.Load += new System.EventHandler(this.Mapviewer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private Tibia.Util.MapViewer mapViewer1;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Label Floor;
        private System.Windows.Forms.Timer timerFloor;
        private System.Windows.Forms.Label label1;
    }
}