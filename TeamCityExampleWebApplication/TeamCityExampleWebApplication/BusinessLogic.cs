using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamCityExampleWebApplication
{
    public class BusinessLogic : IBusinessLogic
    {
        public string GetName()
        {
            return "Bob";
        }
    }
}
