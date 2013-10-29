using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugXamlBinding
{
    public class MainPageViewModelSample
    {
        public MainPageViewModelSample()
        {
            Title = "Hello Design Time!";    
        }
        public string Title { get; set; }
    }
}
