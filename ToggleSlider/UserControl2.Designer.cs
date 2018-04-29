namespace ToggleSlider
{
    partial class UserControl2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toggleSlider1 = new ModernToggleSlider.ToggleSlider();
            this.SuspendLayout();
            // 
            // toggleSlider1
            // 
            this.toggleSlider1.AutoSize = true;
            this.toggleSlider1.Checked = false;
            this.toggleSlider1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleSlider1.Location = new System.Drawing.Point(434, 156);
            this.toggleSlider1.Name = "toggleSlider1";
            this.toggleSlider1.Size = new System.Drawing.Size(233, 40);
            this.toggleSlider1.TabIndex = 0;
            this.toggleSlider1.ToggleCircleColor = System.Drawing.Color.Green;
            this.toggleSlider1.ToggleColorBar = System.Drawing.Color.Gray;
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toggleSlider1);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(1119, 378);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ModernToggleSlider.ToggleSlider toggleSlider1;
    }
}
