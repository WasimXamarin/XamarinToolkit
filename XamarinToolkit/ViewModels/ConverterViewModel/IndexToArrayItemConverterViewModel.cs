using System;
namespace XamarinToolkit.ViewModels.ConverterViewModel
{
    public class IndexToArrayItemConverterViewModel : BaseViewModel
    {
        public IndexToArrayItemConverterViewModel()
        {
            Title = "Index To Array Item Converter";
            MyIntegerValue = 10;
        }

        private int _MyIntegerValue;
        public int MyIntegerValue
        {
            get => _MyIntegerValue;
            set => SetProperty(ref _MyIntegerValue, value);
        }
    }
}
