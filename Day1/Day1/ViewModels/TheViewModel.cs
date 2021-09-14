using Day1.Models;
using Day1.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;

namespace Day1.ViewModels
{
    public class TheViewModel : ObservableObject
    {
        private readonly Calculator _theModel = new Calculator(n => n * 2);

        // The current input value
        private string _text;

        // A collection of previous results
        // It is an ObservableCollection so that it can be bound
        private readonly ObservableCollection<string> _history = new ObservableCollection<string>();

        // The property that the view binds to
        public String Value
        {
            get { return _text; }
            set
            {
                _text = value;
                RaisePropertyChangedEvent("Value");
            }
        }

        // The single command object
        public ICommand ConvertCommand
        {
            get { return new ICommandImpl(ConvertValue);  }
        }

        private void ConvertValue()
        {
            AddToHistory(_theModel.GetResult(
                Convert.ToInt32(Value)).ToString());
            Value = String.Empty;
        }

        private void AddToHistory(string item)
        {
            if (!_history.Contains(item))
                _history.Add(item);
        }

        public IEnumerable<string> History
        {
            get { return _history; }
        }
    }
}
