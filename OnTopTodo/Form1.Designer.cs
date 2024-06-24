namespace OnTopTodo
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            todoDisplayList = new CheckedListBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            addTodoBtn = new Button();
            delCheckedTodoBtn = new Button();
            SuspendLayout();
            // 
            // todoDisplayList
            // 
            todoDisplayList.FormattingEnabled = true;
            todoDisplayList.Location = new Point(12, 12);
            todoDisplayList.Name = "todoDisplayList";
            todoDisplayList.Size = new Size(201, 346);
            todoDisplayList.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // addTodoBtn
            // 
            addTodoBtn.Location = new Point(219, 12);
            addTodoBtn.Name = "addTodoBtn";
            addTodoBtn.Size = new Size(166, 47);
            addTodoBtn.TabIndex = 1;
            addTodoBtn.Text = "新增事項";
            addTodoBtn.UseVisualStyleBackColor = true;
            addTodoBtn.Click += addTodoBtn_Click;
            // 
            // delCheckedTodoBtn
            // 
            delCheckedTodoBtn.Location = new Point(219, 65);
            delCheckedTodoBtn.Name = "delCheckedTodoBtn";
            delCheckedTodoBtn.Size = new Size(166, 47);
            delCheckedTodoBtn.TabIndex = 2;
            delCheckedTodoBtn.Text = "刪除已完成事項";
            delCheckedTodoBtn.UseVisualStyleBackColor = true;
            delCheckedTodoBtn.Click += delCheckedTodoBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 450);
            Controls.Add(delCheckedTodoBtn);
            Controls.Add(addTodoBtn);
            Controls.Add(todoDisplayList);
            Name = "Form1";
            Text = "On Top Todo";
            TopMost = true;
            ResumeLayout(false);
        }

        #endregion

        private CheckedListBox todoDisplayList;
        private ContextMenuStrip contextMenuStrip1;
        private Button addTodoBtn;
        private Button delCheckedTodoBtn;
    }
}
