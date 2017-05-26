using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace CustomControl
{
    public class AutoSuggestInputViewModel : NotifiedBase
    {
        private string _text;
        private List<SimpleListItem> _inputList;

        public AutoSuggestInputViewModel()
        {
            _inputList = new List<SimpleListItem>
            {
                new SimpleListItem
                {
                    Text = "Xamarin",
                    Detail = "Mobile"
                },
                new SimpleListItem
                {
                    Text = "Microsoft",
                    Detail = "Tech giant"
                },
                new SimpleListItem
                {
                    Text = "Google",
                    Detail = "Search Engine"
                },
                new SimpleListItem
                {
                    Text = "Visual Studio",
                    Detail = "IDE"
                },
                new SimpleListItem
                {
                    Text = "C#",
                    Detail = "Programming Language"
                },new SimpleListItem
                {
                    Text = "Rohit",
                    Detail = "Speaker"
                },
                new SimpleListItem
                {
                    Text = "Macbook",
                    Detail = "Laptop"
                },
                new SimpleListItem
                {
                    Text = "Nexus",
                    Detail = "Android Phone"
                }
            };
        }

        public string Text
        {
            get { return _text ?? string.Empty; }
            set
            {
                _text = value;
                OnPropertyChanged();

                ResetSuggestion(_text);
            }
        }

        private void ResetSuggestion(string text)
        {
            Items.Clear();

            if (string.IsNullOrWhiteSpace(text))
            {
                return;
            }

            foreach (var item in _inputList.Where(x => x.Text.IndexOf(text, StringComparison.OrdinalIgnoreCase) >= 0).Take(3))
            {
                Items.Add(item);
            }
        }

        public ObservableCollection<SimpleListItem> Items { get; } = new ObservableCollection<SimpleListItem>();
    }
}
