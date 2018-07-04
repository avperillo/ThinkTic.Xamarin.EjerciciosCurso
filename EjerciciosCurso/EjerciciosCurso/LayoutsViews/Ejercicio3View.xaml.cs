﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EjerciciosCurso.LayoutsViews
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Ejercicio3View : ContentPage
	{
		public Ejercicio3View ()
		{
			InitializeComponent ();
		}

        private void btnColumn_Clicked(object sender, EventArgs e)
        {
            FlexLayout.Direction = FlexDirection.Column;
        }

        private void btnRow_Clicked(object sender, EventArgs e)
        {
            FlexLayout.Direction = FlexDirection.Row;
        }

        private void btnWrap_Clicked(object sender, EventArgs e)
        {
            FlexLayout.Wrap = FlexLayout.Wrap == FlexWrap.Wrap ? FlexWrap.NoWrap : FlexWrap.Wrap;
        }

        private void btnAlignStart_Clicked(object sender, EventArgs e)
        {
            FlexLayout.AlignItems = FlexAlignItems.Start;
        }

        private void btnAlignCenter_Clicked(object sender, EventArgs e)
        {
            FlexLayout.AlignItems = FlexAlignItems.Center;
        }

        private void btnAlignEnd_Clicked(object sender, EventArgs e)
        {
            FlexLayout.AlignItems = FlexAlignItems.End;
        }

        private void btnJustifyCenter_Clicked(object sender, EventArgs e)
        {
            FlexLayout.JustifyContent = FlexJustify.Center;
        }

        private void btnSpaceAround_Clicked(object sender, EventArgs e)
        {
            FlexLayout.JustifyContent = FlexJustify.SpaceAround;
        }

        private void btnSpaceEvently_Clicked(object sender, EventArgs e)
        {
            FlexLayout.JustifyContent = FlexJustify.SpaceEvenly;
        }
    }
}