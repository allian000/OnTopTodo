namespace OnTopTodo
{
    partial class RenameTodoForm
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
            renameTodoBox = new TextBox();
            submitInputBtn = new Button();
            SuspendLayout();
            // 
            // renameTodoBox
            // 
            renameTodoBox.Location = new Point(12, 12);
            renameTodoBox.Name = "renameTodoBox";
            renameTodoBox.Size = new Size(311, 23);
            renameTodoBox.TabIndex = 0;
            // 
            // submitInputBtn
            // 
            submitInputBtn.Location = new Point(112, 55);
            submitInputBtn.Name = "submitInputBtn";
            submitInputBtn.Size = new Size(95, 32);
            submitInputBtn.TabIndex = 1;
            submitInputBtn.Text = "確認";
            submitInputBtn.UseVisualStyleBackColor = true;
            submitInputBtn.Click += submitInputBtn_Click;
            // 
            // RenameTodoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 99);
            Controls.Add(submitInputBtn);
            Controls.Add(renameTodoBox);
            Name = "RenameTodoForm";
            Text = "重新命名代辦事項...";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox renameTodoBox;
        private Button submitInputBtn;
    }
}