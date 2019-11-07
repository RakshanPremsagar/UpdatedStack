using Rg.Plugins.Popup.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace XamarinClient
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class PopupforWrite : PopupPage
{
        SampleClient opcClient;
    public PopupforWrite()
    {
        InitializeComponent();
    }

        public void WriteButton_Clicked(object sender, EventArgs e)
        {
            var menu = sender as MenuItem;

            var selected = menu.CommandParameter as ListNode;
            int value = Convert.ToInt32(Value.Text);
            opcClient.VariableWrite(selected.id,value);
        }
        
    }
}