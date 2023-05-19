using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Notes.Views.FlyoutPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NotesFlyoutPageFlyout : ContentPage
    {
        public ListView ListView;

        public NotesFlyoutPageFlyout()
        {
            InitializeComponent();

            BindingContext = new NotesFlyoutPageFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        private class NotesFlyoutPageFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<NotesFlyoutPageFlyoutMenuItem> MenuItems { get; set; }

            public NotesFlyoutPageFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<NotesFlyoutPageFlyoutMenuItem>(new[]
                {
                    new NotesFlyoutPageFlyoutMenuItem { Id = 0, Title = "Notes", IconSource="fahime.png", TargetType=typeof(MainPage) },
                    new NotesFlyoutPageFlyoutMenuItem { Id = 0, Title = "Notes", IconSource="fahime.png", TargetType=typeof(MainPage) }, 
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}