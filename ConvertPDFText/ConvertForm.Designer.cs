namespace ConvertPDFText
{
    partial class ConvertForm
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
            this.convertButton = new System.Windows.Forms.Button();
            this.reformatDeitiesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(12, 12);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(215, 103);
            this.convertButton.TabIndex = 0;
            this.convertButton.Text = "Convert Clipboard";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // reformatDeitiesButton
            // 
            this.reformatDeitiesButton.Location = new System.Drawing.Point(12, 121);
            this.reformatDeitiesButton.Name = "reformatDeitiesButton";
            this.reformatDeitiesButton.Size = new System.Drawing.Size(215, 103);
            this.reformatDeitiesButton.TabIndex = 1;
            this.reformatDeitiesButton.Text = "Reformat Deities";
            this.reformatDeitiesButton.UseVisualStyleBackColor = true;
            this.reformatDeitiesButton.Click += new System.EventHandler(this.reformatDeitiesButton_Click);
            // 
            // ConvertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 254);
            this.Controls.Add(this.reformatDeitiesButton);
            this.Controls.Add(this.convertButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConvertForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Convert PDF Text";
            this.ResumeLayout(false);

        }

        #endregion

        private Button convertButton;
        private Button reformatDeitiesButton;
    }
}