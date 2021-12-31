using System;
namespace XamarinToolkit.ViewModels.ConverterViewModel
{
    public class BoolToObjectConverterViewModel : BaseViewModel
    {
        public BoolToObjectConverterViewModel()
        {
            Title = "Bool To Object Converter";
            MyBoolean = true;
        }

        private bool _MyBoolean;
        public bool MyBoolean
        {
            get { return _MyBoolean; }
            set { SetProperty(ref _MyBoolean, value); }
        }
    }
}
