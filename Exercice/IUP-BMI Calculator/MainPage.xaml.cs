using IUP_BMI_Calculator.ViewModel;

namespace IUP_BMI_Calculator;

public partial class MainPage : ContentPage
{
	public MainPage(BMICalculatorViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}

}

