using System;
namespace XamarinToolkit.ViewModels.ConverterViewModel
{
    public class ListToStringConverterViewModel : BaseViewModel
    {
        public ListToStringConverterViewModel()
        {
            Title = "List To String Converter";
            MyListValue = "Wasim Alam";
        }

        private string _MyListValue;
        public string MyListValue
        {
            get => _MyListValue;
            set => SetProperty(ref _MyListValue, value);
        }
    }
}
