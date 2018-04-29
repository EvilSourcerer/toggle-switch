namespace ToggleSlider
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
            this.toggleSliderComponent1 = new ToggleSlider.ToggleSliderComponent();
            this.SuspendLayout();
            // 
            // toggleSliderComponent1
            // 
            this.toggleSliderComponent1.AutoSize = true;
            this.toggleSliderComponent1.Checked = false;
            this.toggleSliderComponent1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleSliderComponent1.Location = new System.Drawing.Point(211, 92);
            this.toggleSliderComponent1.Name = "toggleSliderComponent1";
            this.toggleSliderComponent1.Size = new System.Drawing.Size(231, 42);
            this.toggleSliderComponent1.TabIndex = 0;
            this.toggleSliderComponent1.ToggleBarText = "test";
            this.toggleSliderComponent1.ToggleCircleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.toggleSliderComponent1.ToggleColorBar = System.Drawing.Color.Gray;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toggleSliderComponent1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToggleSliderComponent toggleSliderComponent1;
    }
}