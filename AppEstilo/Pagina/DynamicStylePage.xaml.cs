using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AppEstilo.Pagina
{
    public partial class DynamicStylePage : ContentPage
    {
        public DynamicStylePage()
        {
            InitializeComponent();
        }

        private void MudarCor(Object sender, EventArgs args)
        {
            this.Resources["LblColor"] = Color.Orchid;
            this.Resources["Lbl"] = this.Resources["NewLBL"];
        }
    }
}
