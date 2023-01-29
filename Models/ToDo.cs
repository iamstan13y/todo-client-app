using System.ComponentModel;

namespace Todo.Client.Models
{
    public class ToDo : INotifyPropertyChanged
    {
        int _id;
        string _name;
        public event PropertyChangedEventHandler PropertyChanged;
    }
}