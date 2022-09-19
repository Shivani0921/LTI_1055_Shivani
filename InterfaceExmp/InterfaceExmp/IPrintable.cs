using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExmp
{
    internal interface IPrintable
    {
        //only abstract methods and properties are here
        //oppsite to asbtract class no fields are here

        //no public word required for method access modifier
        //why? cos it itself publically available by default
        void Print();
        void ShowDate();

    }
}
