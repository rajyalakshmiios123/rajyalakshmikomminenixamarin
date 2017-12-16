using RajyalakshmiKommineni.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RajyalakshmiKommineni.ViewModels.Base
{
    public class ViewModelBase : ExtendedBindableObject
    {
        // protected readonly IDialogService DialogService;
        protected readonly INavigationService NavigationService;

        private bool _isBusy;
        private string _title;

        public bool IsBusy
        {
            get
            {
                return _isBusy;
            }

            set
            {
                _isBusy = value;
                RaisePropertyChanged(() => IsBusy);
            }
        }
        public string Title
        {
            get
            {
                return _title;
            }

            set
            {
                _title = value;
                RaisePropertyChanged(() => Title);
            }
        }

        public ViewModelBase()
        {
            // DialogService = ViewModelLocator.Instance.Resolve<IDialogService>();
            NavigationService = ViewModelLocator.Instance.Resolve<INavigationService>();
        }

        public virtual Task InitializeAsync(object navigationData)
        {
            return Task.FromResult(false);
        }
    }
}


