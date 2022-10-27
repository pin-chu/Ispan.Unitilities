namespace WindowsFormsApp2
{
    partial class LoginForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ClacButton = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ClacButton
            // 
            this.ClacButton.Location = new System.Drawing.Point(118, 164);
            this.ClacButton.Name = "ClacButton";
            this.ClacButton.Size = new System.Drawing.Size(75, 23);
            this.ClacButton.TabIndex = 0;
            this.ClacButton.Text = "Go";
            this.ClacButton.UseVisualStyleBackColor = true;
            this.ClacButton.Click += new System.EventHandler(this.ClacButton_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(41, 59);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(152, 22);
            this.NameTextBox.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(41, 105);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(152, 22);
            this.textBox2.TabIndex = 2;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 233);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.ClacButton);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClacButton;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox textBox2;
    }
}

