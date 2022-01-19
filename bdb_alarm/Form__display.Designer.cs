namespace bdb_alarm
{
    partial class Form__display
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
            this.label__display_note = new System.Windows.Forms.Label();
            this.label__display_time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label__display_note
            // 
            this.label__display_note.AutoSize = true;
            this.label__display_note.Font = new System.Drawing.Font("굴림", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label__display_note.Location = new System.Drawing.Point(12, 140);
            this.label__display_note.Name = "label__display_note";
            this.label__display_note.Size = new System.Drawing.Size(921, 96);
            this.label__display_note.TabIndex = 1;
            this.label__display_note.Text = "label__display_note";
            // 
            // label__display_time
            // 
            this.label__display_time.AutoSize = true;
            this.label__display_time.Font = new System.Drawing.Font("굴림", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label__display_time.Location = new System.Drawing.Point(12, 9);
            this.label__display_time.Name = "label__display_time";
            this.label__display_time.Size = new System.Drawing.Size(913, 96);
            this.label__display_time.TabIndex = 0;
            this.label__display_time.Text = "label__display_time";
            // 
            // Form__display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label__display_note);
            this.Controls.Add(this.label__display_time);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form__display";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form__display";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label label__display_note;
        public System.Windows.Forms.Label label__display_time;
    }
}