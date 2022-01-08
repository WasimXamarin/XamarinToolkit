using System;
namespace XamarinToolkit.ViewModels.ConverterViewModel
{
    public class TextCaseConverterViewModel : BaseViewModel
    {
        public TextCaseConverterViewModel()
        {
            Title = "Text Case Converter";
            MyString = "Xamarin forma";
        }

        private string _EntryValue;
        public string EntryValue
        {
            get => _EntryValue;
            set => SetProperty(ref _EntryValue, value);
        }

        private string _MyString;
        public string MyString
        {
            get => _MyString;
            set => SetProperty(ref _MyString, value);
        }
    }
}
