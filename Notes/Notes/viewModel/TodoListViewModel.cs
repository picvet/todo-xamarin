using Notes.model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace Notes.viewModel
{
    public class TodoListViewModel : INotifyPropertyChanged
    {
        // Collection containing our todo list for the person
        public ObservableCollection<TodoItem> TodoItems { get; set; }

        public TodoListViewModel()
        {
            TodoItems = new ObservableCollection<TodoItem>();
            
        }

        public ICommand AddTodoCommand => new Command(AddTodoItem); 

        public string _newTodoInputValue;
        public string NewTodoInputValue { 
            get { return _newTodoInputValue; }
            set {
                _newTodoInputValue = value;
                OnPropertyChanged(nameof(NewTodoInputValue));
            }
        }        

        void AddTodoItem()
        {
            TodoItems.Add(new TodoItem(NewTodoInputValue, false));
            NewTodoInputValue = "";
        }

        public ICommand RemoveTodoCommand => new Command(RemoveTodoItem);
        void RemoveTodoItem(object o)
        {
            TodoItem item = o as TodoItem;    
            TodoItems.Remove(item);
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;

    }
}
