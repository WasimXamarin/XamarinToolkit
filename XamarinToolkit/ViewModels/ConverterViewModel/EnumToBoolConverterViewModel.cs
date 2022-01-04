using System;
namespace XamarinToolkit.ViewModels.ConverterViewModel
{
    public class EnumToBoolConverterViewModel : BaseViewModel
    {
       // public string[] AllStates { get; } = Enum.GetNames(typeof(IssueState));
        public EnumToBoolConverterViewModel()
        {
            Title = "Enum To Bool Converter";
        }

        //IssueState selectedState = IssueState.None;
        //public IssueState SelectedState
        //{
        //    get => selectedState;
        //    set => SetProperty(ref selectedState, value);
        //}
    }
}
