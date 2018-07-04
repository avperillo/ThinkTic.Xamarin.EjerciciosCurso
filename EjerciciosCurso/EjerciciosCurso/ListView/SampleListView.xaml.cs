using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EjerciciosCurso.ListView
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SampleListView : ContentPage
	{
		public SampleListView ()
		{
			InitializeComponent ();

            List<string> items = new List<string>();

            for (int i = 0; i < 10; i++)
            {
                items.Add(i.ToString());
            }

            listview.ItemsSource = items;
		}
	}
}