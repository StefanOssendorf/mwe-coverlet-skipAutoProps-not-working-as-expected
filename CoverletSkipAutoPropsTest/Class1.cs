using System;

namespace CoverletSkipAutoPropsTest
{
    public class Class1
    {
        public String Name { get; set; }

        public Int32 Age { get; set; }


        public Boolean DoFunnyThings()
        {
            Name = "Dummy";
            Age = 1337;

            return true;
        }
    }
}
