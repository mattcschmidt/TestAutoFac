using System.Collections.Generic;
using TestAutoFac_SingleInstance.Data;

namespace TestAutoFac_SingleInstance.Models
{
    public class MyClassList
    {
        public List<MyClass> myClassList { get; set; }
        public MyClassList()
        {
            myClassList = new CollectClassList().GetClassInfo();
        }
    }
}
