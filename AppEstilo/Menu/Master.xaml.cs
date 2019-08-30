using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppEstilo.Menu
{
    public partial class Master : MasterDetailPage
    {
        public Master()
        {
            InitializeComponent();
        }

        private void GoPagina1(Object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Pagina.ImpliciteStylePage());
            IsPresented = false;
        }

        private void GoPagina2(Object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Pagina.ExplicitStylePage());
            IsPresented = false;
        }

        private void GoPagina3(Object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Pagina.GlobalStylePage());
            IsPresented = false;
        }

        private void GoPagina4(Object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Pagina.InheritStyle());
            IsPresented = false;
        }

        private void GoPagina5(Object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Pagina.DynamicStylePage());
            IsPresented = false;
        }
    }
}
