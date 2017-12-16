using RajyalakshmiKommineni.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RajyalakshmiKommineni.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        public ICommand GmailClickCommand { get; set; }
        public ICommand FbClickedCommand { get; set; }
        public ICommand GotoBlogCommand { get; set; }
        public string ProfileName { get; set; }
        public string Designation { get; set; }
        public HomeViewModel()
        {
            ProfileName = "Rajyalakshmi Kommineni";
            Designation = "Xamarin Developer at Microsoft";
            GmailClickCommand = new Command(async () => await OpenGmail());
            FbClickedCommand = new Command(async () => await OpenFacebook());
            GotoBlogCommand = new Command(GotoBlog);
        }
        async Task OpenGmail()
        {
            Device.OpenUri(new Uri("mailto:rajiios123@gmail.com"));
        }
        async Task OpenFacebook()
        {
            Device.OpenUri(new Uri("https://www.linkedin.com/in/rajyalakshmi-kommineni-037b70127/"));
        }
        void GotoBlog()
        {
            NavigationService.NavigateToAsync<BlogViewModel>();
        }
    }
}
