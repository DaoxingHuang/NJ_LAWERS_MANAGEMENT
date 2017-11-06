using GalaSoft.MvvmLight;
using NJ.Lawers.Mangement.Model;

namespace NJ.Lawers.Mangement.ViewModel
{
    /// <summary>    /// 
    /// <c>This class contains properties that the main View can data bind to.    
    /// </c>
    /// <see cref="MyViewModelBase"/>  
    /// </summary>
    public class MainViewModel : MyViewModelBase
    {
        private readonly IDataService dataService;

        /// <summary>
        /// The <see cref="Title" /> property's name.
        /// </summary>
        public const string TitlePropertyName = "Title";

        private string title = string.Empty;

        /// <summary>
        /// Gets the WelcomeTitle property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                Set(ref title, value);
            }
        }

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel(IDataService dataService)
        {
            this.dataService = dataService;
            this.dataService.GetData(
                (item, error) =>
                {
                    if (error != null)
                    {                       
                        return;
                    }

                    Title = item.Title;
                });
        }

        public override void Cleanup()
        {
            base.Cleanup();
        }
    }
}