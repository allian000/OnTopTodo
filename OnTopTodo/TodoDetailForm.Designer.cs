namespace OnTopTodo
{
    partial class TodoDetailForm
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
            exitBtn = new Button();
            todoContentBox = new TextBox();
            SuspendLayout();
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(152, 242);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(123, 40);
            exitBtn.TabIndex = 0;
            exitBtn.Text = "存檔離開";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // todoContentBox
            // 
            todoContentBox.Location = new Point(12, 12);
            todoContentBox.Multiline = true;
            todoContentBox.Name = "todoContentBox";
            todoContentBox.Size = new Size(401, 224);
            todoContentBox.TabIndex = 1;
            // 
            // TodoDetailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 287);
            Controls.Add(todoContentBox);
            Controls.Add(exitBtn);
            Name = "TodoDetailForm";
            Text = "TodoDetailForm";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button exitBtn;
        private TextBox todoContentBox;
    }
}