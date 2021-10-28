using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class SistemaDataContextFactory
    {
        private static SistemaDataContext dataContext;
        SistemaDataContext DataContext{
            get{
                if(dataContext == null);
                dataContext = new SistemaDataContext();
                return dataContext; 
            }
        }
    }
}
