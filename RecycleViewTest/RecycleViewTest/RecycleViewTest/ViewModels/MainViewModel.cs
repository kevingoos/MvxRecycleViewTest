using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using System.Collections.ObjectModel;
using RecycleViewTest.Models;

namespace RecycleViewTest.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        #region Properties

        public ObservableCollection<TestModel> TestItems { get; set; }

        #endregion

        public MainViewModel()
        {
            TestItems = new ObservableCollection<TestModel>
            {
                new TestModel()
                {
                    Name = "Test1"
                },
                new TestModel()
                {
                    Name = "Test2"
                }
            };
        }
        
        public override Task Initialize()
        {
            //TODO: Add starting logic here
		    
            return base.Initialize();
        }
    }
}