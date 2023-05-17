using Notes.model;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace Notes.viewModel
{
    public class TodoListViewModel
    {
        public ObservableCollection<TodoItem> TodoItems { get; set; }

        public TodoListViewModel()
        {
            TodoItems = new ObservableCollection<TodoItem>();

        }

        public ICommand AddTodoCommand => new Command(AddTodoItem); 
        public string NewTodoInputValue { get; set; }
        void AddTodoItem()
        {
            TodoItems.Add(new TodoItem(NewTodoInputValue, false));
        }

        public ICommand RemoveTodoCommand => new Command(RemoveTodoItem);
        void RemoveTodoItem(object o)
        {
            TodoItem item = o as TodoItem;    
            TodoItems.Remove(item);
        }

    }
}
