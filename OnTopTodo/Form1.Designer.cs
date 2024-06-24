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
            openTodoDetailBtn = new Button();
            renameTodoBtn = new Button();
            delSelectedTodoBtn = new Button();
            SuspendLayout();
            // 
            // todoDisplayList
            // 
            todoDisplayList.FormattingEnabled = true;
            todoDisplayList.Location = new Point(12, 12);
            todoDisplayList.Name = "todoDisplayList";
            todoDisplayList.Size = new Size(201, 256);
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
            delCheckedTodoBtn.Location = new Point(219, 171);
            delCheckedTodoBtn.Name = "delCheckedTodoBtn";
            delCheckedTodoBtn.Size = new Size(166, 47);
            delCheckedTodoBtn.TabIndex = 2;
            delCheckedTodoBtn.Text = "刪除已完成事項";
            delCheckedTodoBtn.UseVisualStyleBackColor = true;
            delCheckedTodoBtn.Click += delCheckedTodoBtn_Click;
            // 
            // openTodoDetailBtn
            // 
            openTodoDetailBtn.Location = new Point(219, 65);
            openTodoDetailBtn.Name = "openTodoDetailBtn";
            openTodoDetailBtn.Size = new Size(166, 47);
            openTodoDetailBtn.TabIndex = 3;
            openTodoDetailBtn.Text = "開啟事項內容";
            openTodoDetailBtn.UseVisualStyleBackColor = true;
            openTodoDetailBtn.Click += openTodoDetailBtn_Click;
            // 
            // renameTodoBtn
            // 
            renameTodoBtn.Location = new Point(219, 118);
            renameTodoBtn.Name = "renameTodoBtn";
            renameTodoBtn.Size = new Size(166, 47);
            renameTodoBtn.TabIndex = 4;
            renameTodoBtn.Text = "更新事項名稱";
            renameTodoBtn.UseVisualStyleBackColor = true;
            renameTodoBtn.Click += renameTodoBtn_Click;
            // 
            // delSelectedTodoBtn
            // 
            delSelectedTodoBtn.Location = new Point(219, 224);
            delSelectedTodoBtn.Name = "delSelectedTodoBtn";
            delSelectedTodoBtn.Size = new Size(166, 47);
            delSelectedTodoBtn.TabIndex = 5;
            delSelectedTodoBtn.Text = "刪除被選中單筆事項";
            delSelectedTodoBtn.UseVisualStyleBackColor = true;
            delSelectedTodoBtn.Click += delSelectedTodoBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 368);
            Controls.Add(delSelectedTodoBtn);
            Controls.Add(renameTodoBtn);
            Controls.Add(openTodoDetailBtn);
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
        private Button openTodoDetailBtn;
        private Button renameTodoBtn;
        private Button delSelectedTodoBtn;
    }
}
