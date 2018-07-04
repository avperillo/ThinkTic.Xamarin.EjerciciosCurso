using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace EjerciciosCurso
{
	public partial class App : Application
	{
		public App ()
		{

            LiveReload.Init();

			InitializeComponent();

            //MainPage = new MainPage();
            //MainPage = new LayoutsViews.Ejercicio1Page();
            //MainPage = new LayoutsViews.Ejercicio2View();
            MainPage = new LayoutsViews.Ejercicio3View();
        }

        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
