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
    public partial class RenameTodoForm : Form
    {
        public string TodoInputText { get; private set; }
        public RenameTodoForm(String currentName)
        {
            InitializeComponent();
            renameTodoBox.Text = currentName;
        }

        private void submitInputBtn_Click(object sender, EventArgs e)
        {
            this.TodoInputText = renameTodoBox.Text;
            this.Close();
        }
    }
}
