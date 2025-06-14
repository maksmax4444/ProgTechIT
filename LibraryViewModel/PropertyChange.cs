﻿using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace LibraryViewModel
{
    public class PropertyChange : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = "")
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        private string name;
        public string Name
        {
            get
            { 
                return name; 
            }
            set => SetProperty(ref name, value);
        }
    }
}