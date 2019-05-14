using System.Collections.Generic;
using TestAutoFac_SingleInstance.Models;

namespace TestAutoFac_SingleInstance.Data
{
    public class CollectClassList
    {
        public List<MyClass> GetClassInfo()
        {
            return new List<MyClass>() {
                new MyClass{ PropertyA = "A1", PropertyB = "B1" } ,
            new MyClass{PropertyA = "A2", PropertyB = "B2"} ,
            new MyClass{PropertyA = "A3", PropertyB = "B3" },
            };
        }
    }
}
