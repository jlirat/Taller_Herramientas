using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FAXM
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HistoryPage : ContentPage
    {
        public HistoryPage()
        {
            InitializeComponent();
            List<String> listSource = new List<String>();
            listSource.Add("Elemento 1");
            listSource.Add("Elemento 2");
            listSource.Add("Elemento 3");

            list.ItemsSource = listSource;
        }
    }
}