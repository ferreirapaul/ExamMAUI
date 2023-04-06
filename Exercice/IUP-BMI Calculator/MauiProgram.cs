using Microsoft.Extensions.Logging;
using IUP_BMI_Calculator.Repository;
using IUP_BMI_Calculator.ViewModel;

namespace IUP_BMI_Calculator;


public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		
		string dbPath = FileAccessHelper.GetLocalFilePath("BMIResult_5999222006_PaulFerreira.db3");
        builder.Services.AddSingleton<BMIResultRepository>(s => ActivatorUtilities.CreateInstance<BMIResultRepository>(s, dbPath));
		builder.Services.AddSingleton<BMICalculatorViewModel>();
        builder.Services.AddSingleton<MainPage>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
