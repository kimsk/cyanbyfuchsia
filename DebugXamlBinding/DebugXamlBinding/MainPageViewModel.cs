using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugXamlBinding
{
    public class MainPageViewModel
    {
        public MainPageViewModel()
        {
            Title = "Hello Runtime!";            
        }
        public string Title { get; set; }
    }
}
