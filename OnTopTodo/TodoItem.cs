using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTopTodo
{
    public class TodoItem
    {
        private string Name { get; set; }
        private string Content { get; set; }
        public TodoItem(string name, string content)
        {
            this.Name = name;
            this.Content = content;
        }

        public String getName() { return this.Name; }
        public void setName(String name) { this.Name = name;}

        public String getContent() { return this.Content; }
        public void setContent(string content)
        {
            this.Content = content;
            OnContentChanged();
        }
        public event EventHandler ContentChanged;
        protected virtual void OnContentChanged()
        {
            ContentChanged?.Invoke(this, EventArgs.Empty);
        }

    }
}
