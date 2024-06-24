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

        private void InitializeTodoDisplayList(String searchText)
        {
            todoDisplayList.Items.Clear();
            var sortedTodoItems = todoItems
            .Select(item => new { Item = item, Score = CalculateMatchScore(item.getName(), searchText) })
            .OrderByDescending(x => x.Score)
            .ToList();

            foreach (var entry in sortedTodoItems)
            {
                if (!string.IsNullOrEmpty(entry.Item.getName()))
                {
                    todoDisplayList.Items.Add(entry.Item.getName());
                }
            }
        }

        private int CalculateMatchScore(string todoName, string searchText)
        {
            if (string.IsNullOrEmpty(todoName) || string.IsNullOrEmpty(searchText))
                return 0;

            int maxScore = 0;
            int currentScore = 0;

            for (int i = 0; i < todoName.Length; i++)
            {
                if (i + searchText.Length <= todoName.Length &&
                    todoName.Substring(i, searchText.Length).Equals(searchText, StringComparison.OrdinalIgnoreCase))
                {
                    currentScore = searchText.Length;
                    maxScore = Math.Max(maxScore, currentScore);
                }
                else
                {
                    currentScore = 0;
                }
            }

            return maxScore;
        }

        private void addTodoBtn_Click(object sender, EventArgs e)
        {
            TodoInput inputDialog = new TodoInput();
            inputDialog.ShowDialog();
            String todoName = inputDialog.TodoInputText;
            TodoItem todoItem = new TodoItem(todoName, "");
            todoItems.Add(todoItem);
            // 重新渲染列表
            InitializeTodoDisplayList("");
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
                    InitializeTodoDisplayList("");
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
                    InitializeTodoDisplayList("");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void searchTodoBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchTodoBox.Text;
            InitializeTodoDisplayList(searchText);
        }
    }
}
