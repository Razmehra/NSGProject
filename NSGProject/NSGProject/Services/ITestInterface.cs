using NSGProject.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;


[assembly: Dependency(typeof(ITestInterface))]
namespace NSGProject.Services
{
    public interface ITestInterface
    {
        void InvokeService();
    }
}
