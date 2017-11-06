using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using NJ.Lawers.Mangement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Author:Daoxing,Huang
/// <c>Inherit this ,it could automatically registered in IOC
/// and if create temp model,dont try to use this as parent.
/// Will make it easier to use in the future ,and in first verion will
/// use it temp.
/// </c>
/// <example>YourModel:MyViewModelBase</example>  
/// </summary>
namespace NJ.Lawers.Mangement.ViewModel
{
    public class MyViewModelBase : ViewModelBase
    {
        static MyViewModelBase()
        {
            if (ViewModelBase.IsInDesignModeStatic)
            {
                RegisterIsDesignMode();
            }
            else
            {
                RegisterModel();
            }
            SimpleIoc.Default.Register<MyViewModelBase>();
        }

        private static void RegisterIsDesignMode()
        {
            SimpleIoc.Default.Register<IDataService, Design.DesignDataService>();
        }

        private static void RegisterModel()
        {
            SimpleIoc.Default.Register<IDataService, DataService>();
        }
    }

  
}


