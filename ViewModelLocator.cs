using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamlPlayground
{
    public class ViewModelLocator
    {
        public Foo Foo => new Foo();
    }

    public class Foo
    {
        public MainWindowViewModel MainWindowViewModel => new MainWindowViewModel();
        
    }
}
