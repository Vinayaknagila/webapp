namespace Home_workout_application
{
    partial class Homepage
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.simpleBodyWeightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workoutWithDumbellsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resistanceBandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cardioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.simpleBodyWeightToolStripMenuItem,
            this.workoutWithDumbellsToolStripMenuItem,
            this.resistanceBandToolStripMenuItem,
            this.cardioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 58);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(27, 54);
            this.toolStripMenuItem1.Text = "<";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // simpleBodyWeightToolStripMenuItem
            // 
            this.simpleBodyWeightToolStripMenuItem.Image = global::Home_workout_application.Properties.Resources.icons8_pullups_50;
            this.simpleBodyWeightToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.simpleBodyWeightToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.simpleBodyWeightToolStripMenuItem.Name = "simpleBodyWeightToolStripMenuItem";
            this.simpleBodyWeightToolStripMenuItem.Size = new System.Drawing.Size(173, 54);
            this.simpleBodyWeightToolStripMenuItem.Text = "simple body weight";
            this.simpleBodyWeightToolStripMenuItem.Click += new System.EventHandler(this.simpleBodyWeightToolStripMenuItem_Click);
            // 
            // workoutWithDumbellsToolStripMenuItem
            // 
            this.workoutWithDumbellsToolStripMenuItem.Image = global::Home_workout_application.Properties.Resources.icons8_weightlifting_50;
            this.workoutWithDumbellsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.workoutWithDumbellsToolStripMenuItem.Name = "workoutWithDumbellsToolStripMenuItem";
            this.workoutWithDumbellsToolStripMenuItem.Size = new System.Drawing.Size(191, 54);
            this.workoutWithDumbellsToolStripMenuItem.Text = "workout with dumbells";
            this.workoutWithDumbellsToolStripMenuItem.Click += new System.EventHandler(this.workoutWithDumbellsToolStripMenuItem_Click);
            // 
            // resistanceBandToolStripMenuItem
            // 
            this.resistanceBandToolStripMenuItem.Image = global::Home_workout_application.Properties.Resources.icons8_skipping_rope_50__1_;
            this.resistanceBandToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.resistanceBandToolStripMenuItem.Name = "resistanceBandToolStripMenuItem";
            this.resistanceBandToolStripMenuItem.Size = new System.Drawing.Size(151, 54);
            this.resistanceBandToolStripMenuItem.Text = "resistance band";
            this.resistanceBandToolStripMenuItem.Click += new System.EventHandler(this.resistanceBandToolStripMenuItem_Click);
            // 
            // cardioToolStripMenuItem
            // 
            this.cardioToolStripMenuItem.Image = global::Home_workout_application.Properties.Resources.icons8_spinning_50;
            this.cardioToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cardioToolStripMenuItem.Name = "cardioToolStripMenuItem";
            this.cardioToolStripMenuItem.Size = new System.Drawing.Size(105, 54);
            this.cardioToolStripMenuItem.Text = "cardio ";
            this.cardioToolStripMenuItem.Click += new System.EventHandler(this.cardioToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Home_workout_application.Properties.Resources.Article_Banner_1_34_1;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem simpleBodyWeightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workoutWithDumbellsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resistanceBandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cardioToolStripMenuItem;
    }
}