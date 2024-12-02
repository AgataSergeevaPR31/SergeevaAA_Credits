using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SergeevaAA_Credits
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page3 : ContentPage
	{
		public Page3 ()
		{
			InitializeComponent();
		}

        public void RefreshData()
        {
            DateTime currentDate = DateTime.Now;
            CurrentDateLabel.Text = currentDate.ToString("dd MMMM yyyy");
        }
    }
}