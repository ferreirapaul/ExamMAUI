using IUP_BMI_Calculator.Repository;
using IUP_BMI_Calculator.ViewModel;

namespace IUP_BMI_Calculator;

public partial class App : Application
{
    public static BMIResultRepository Repo { get; private set; }
    public App(BMIResultRepository repo)
	{
		InitializeComponent();

		MainPage = new AppShell();
		Repo = repo;
	}
}
