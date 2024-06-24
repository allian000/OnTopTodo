using System.Windows.Forms;

namespace OnTopTodo
{
    public partial class Form1 : Form
    {
        private List<TodoItem> todoItems;
        public Form1()
        {
            InitializeComponent();
            InitializeTodoItems();
            //todoDisplayList.
        }

        // 初始化代辦事項列表
        private void InitializeTodoItems()
        {
            todoItems = [];
        }

        private void InitializeTodoDisplayList()
        {
            todoDisplayList.Items.Clear();
            foreach (var item in todoItems)
            {
                if (item.getName() != "" || item.getName() != null)
                {
                    todoDisplayList.Items.Add(item.getName());
                }
            }
        }

        private void addTodoBtn_Click(object sender, EventArgs e)
        {
            TodoInput inputDialog = new TodoInput();
            inputDialog.ShowDialog();
            String todoName = inputDialog.TodoInputText;
            TodoItem todoItem = new TodoItem(todoName, "");
            todoItems.Add(todoItem);
            // 重新渲染列表
            InitializeTodoDisplayList();
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
                todoItems.RemoveAt(index);
            }
        }


        private void openTodoDetailBtn_Click(object sender, EventArgs e)
        {
            String selectedName = todoDisplayList.SelectedItem as String;

            if (selectedName != null)
            {
                TodoItem selectedTodoItem = todoItems.Find(item => item.getName() == selectedName);

                if (selectedTodoItem != null)
                {
                    TodoDetailForm todoDetailForm = new TodoDetailForm(selectedTodoItem);
                    todoDetailForm.Show();
                }
            }
        }

        private void renameTodoBtn_Click(object sender, EventArgs e)
        {
            String selectedTodoItemName = todoDisplayList.SelectedItem as String;

            if (selectedTodoItemName != null)
            {
                TodoItem selectedTodoItem = todoItems.Find(item => item.getName() == selectedTodoItemName);
                if (selectedTodoItem != null)
                {
                    RenameTodoForm renameTodo = new RenameTodoForm(selectedTodoItemName);
                    renameTodo.ShowDialog();
                    String todoName = renameTodo.TodoInputText;
                    if (todoName == null || todoName.Length == 0)
                    {
                        todoName = selectedTodoItemName;
                    }
                    selectedTodoItem.setName(todoName);
                    InitializeTodoDisplayList();
                }
            }
        }

        private void delSelectedTodoBtn_Click(object sender, EventArgs e)
        {
            String selectedTodoItemName = todoDisplayList.SelectedItem as String;
            if (selectedTodoItemName != null)
            {
                TodoItem selectedTodoItem = todoItems.Find(item => item.getName() == selectedTodoItemName);
                if (selectedTodoItem != null)
                {
                    todoItems.Remove(selectedTodoItem);
                    InitializeTodoDisplayList();
                }
            }
        }
    }
}
