using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnTopTodo
{
    public partial class TodoDetailForm : Form
    {
        private TodoItem _todoItem;
        public TodoDetailForm(TodoItem todoItem)
        {
            InitializeComponent();
            _todoItem = todoItem;
            this.Text = _todoItem.getName();
            this.todoContentBox.Text = _todoItem.getContent();

            // 訂閱內容改變的事件
            _todoItem.ContentChanged += Item_ContentChanged;
        }

        private void Item_ContentChanged(object sender, EventArgs e)
        {
            // 在這處裡內容改變事件
            todoContentBox.Text = _todoItem.getContent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            // 寫回更新的資料
            _todoItem.setContent(todoContentBox.Text);
            MessageBox.Show("保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
