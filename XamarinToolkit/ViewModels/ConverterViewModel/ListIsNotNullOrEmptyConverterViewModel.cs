using System;
namespace XamarinToolkit.ViewModels.ConverterViewModel
{
    public class ListIsNotNullOrEmptyConverterViewModel : BaseViewModel
    {
        public ListIsNotNullOrEmptyConverterViewModel()
        {
            Title = "List Is Not Null Or Empty Converter";
            MyListValue = "WASIM";
            //MyListValue = null;
        }

        private string _MyListValue;
        public string MyListValue
        {
            get => _MyListValue;
            set => SetProperty(ref _MyListValue, value);
        }
    }
}
