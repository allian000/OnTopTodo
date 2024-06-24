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
    public partial class TodoInput : Form
    {
        public string TodoInputText { get; private set; }
        public TodoInput()
        {
            InitializeComponent();
        }

        private void submitInputBtn_Click(object sender, EventArgs e)
        {
            TodoInputText = todoInputBox.Text;
            this.Close();
        }
    }
}
