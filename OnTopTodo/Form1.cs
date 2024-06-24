using System.Windows.Forms;

namespace OnTopTodo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addTodoBtn_Click(object sender, EventArgs e)
        {
            TodoInput inputDialog = new TodoInput();
            inputDialog.ShowDialog();
            String todoName = inputDialog.TodoInputText;
            todoDisplayList.Items.Add(todoName);
        }

        private void delCheckedTodoBtn_Click(object sender, EventArgs e)
        {
            var itemsToRemove = new List<int>();
            for (int i = todoDisplayList.CheckedIndices.Count - 1; i >= 0; i--)
            {
                int index = todoDisplayList.CheckedIndices[i];
                itemsToRemove.Add(index);
            }
            foreach (int index in itemsToRemove)
            {
                todoDisplayList.Items.RemoveAt(index);
            }
        }
    }
}
