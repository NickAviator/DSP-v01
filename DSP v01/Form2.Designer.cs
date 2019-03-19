namespace DSP_v01
{
    partial class Form2
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
            this.Form2Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Form2Close
            // 
            this.Form2Close.Location = new System.Drawing.Point(511, 330);
            this.Form2Close.Name = "Form2Close";
            this.Form2Close.Size = new System.Drawing.Size(96, 23);
            this.Form2Close.TabIndex = 0;
            this.Form2Close.Text = "Закрыть";
            this.Form2Close.UseVisualStyleBackColor = true;
            this.Form2Close.Click += new System.EventHandler(this.Form2Close_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 377);
            this.Controls.Add(this.Form2Close);
            this.Name = "Form2";
            this.Text = "Настройка программы";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Form2Close;
    }
}