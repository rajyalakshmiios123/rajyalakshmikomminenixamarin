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
    public class BlogViewModel : ViewModelBase
    {
        public string WebSource { get; set; }
        public ICommand GobackCommand { get; set; }
        public BlogViewModel()
        {
            WebSource = "http://rajyalakshmikommineni.blogspot.com/";
        }
    }
}