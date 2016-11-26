namespace AuthProject
{
    partial class DeleteForm
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
            this.user_ListBox = new System.Windows.Forms.ListBox();
            this.cancel_Button = new System.Windows.Forms.Button();
            this.delete_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // user_ListBox
            // 
            this.user_ListBox.FormattingEnabled = true;
            this.user_ListBox.Location = new System.Drawing.Point(12, 12);
            this.user_ListBox.Name = "user_ListBox";
            this.user_ListBox.Size = new System.Drawing.Size(177, 121);
            this.user_ListBox.TabIndex = 0;
            // 
            // cancel_Button
            // 
            this.cancel_Button.Location = new System.Drawing.Point(99, 139);
            this.cancel_Button.Name = "cancel_Button";
            this.cancel_Button.Size = new System.Drawing.Size(90, 23);
            this.cancel_Button.TabIndex = 9;
            this.cancel_Button.Text = "Cancel";
            this.cancel_Button.UseVisualStyleBackColor = true;
            this.cancel_Button.Click += new System.EventHandler(this.cancel_Button_Click);
            // 
            // delete_Button
            // 
            this.delete_Button.Location = new System.Drawing.Point(10, 139);
            this.delete_Button.Name = "delete_Button";
            this.delete_Button.Size = new System.Drawing.Size(83, 23);
            this.delete_Button.TabIndex = 8;
            this.delete_Button.Text = "Delete";
            this.delete_Button.UseVisualStyleBackColor = true;
            this.delete_Button.Click += new System.EventHandler(this.delete_Button_Click);
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 169);
            this.Controls.Add(this.cancel_Button);
            this.Controls.Add(this.delete_Button);
            this.Controls.Add(this.user_ListBox);
            this.Name = "DeleteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteForm";
            this.Load += new System.EventHandler(this.DeleteForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox user_ListBox;
        private System.Windows.Forms.Button cancel_Button;
        private System.Windows.Forms.Button delete_Button;
    }
}