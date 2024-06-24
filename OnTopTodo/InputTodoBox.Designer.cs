namespace OnTopTodo
{
    partial class TodoInput
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
            todoInputBox = new TextBox();
            submitInputBtn = new Button();
            SuspendLayout();
            // 
            // todoInputBox
            // 
            todoInputBox.Location = new Point(12, 12);
            todoInputBox.Name = "todoInputBox";
            todoInputBox.Size = new Size(311, 23);
            todoInputBox.TabIndex = 0;
            // 
            // submitInputBtn
            // 
            submitInputBtn.Location = new Point(114, 57);
            submitInputBtn.Name = "submitInputBtn";
            submitInputBtn.Size = new Size(95, 44);
            submitInputBtn.TabIndex = 1;
            submitInputBtn.Text = "確認";
            submitInputBtn.UseVisualStyleBackColor = true;
            submitInputBtn.Click += submitInputBtn_Click;
            // 
            // TodoInput
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 113);
            Controls.Add(submitInputBtn);
            Controls.Add(todoInputBox);
            Name = "TodoInput";
            Text = "請輸入代辦事項名稱...";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox todoInputBox;
        private Button submitInputBtn;
    }
}