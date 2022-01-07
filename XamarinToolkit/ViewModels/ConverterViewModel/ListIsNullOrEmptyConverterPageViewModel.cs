using System;
namespace XamarinToolkit.ViewModels.ConverterViewModel
{
    public class ListIsNullOrEmptyConverterPageViewModel : BaseViewModel
    {
        public ListIsNullOrEmptyConverterPageViewModel()
        {
            Title = "List Is Null Or Empty Converter";
            MyListValue = null;
            MyListValue = "null";
        }

        private string _MyListValue;
        public string MyListValue
        {
            get => _MyListValue;
            set => SetProperty(ref _MyListValue, value);
        }
    }
}
