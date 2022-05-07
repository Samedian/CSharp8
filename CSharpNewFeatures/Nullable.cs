using System;

namespace CSharpNewFeatures
{
    class Nullable
    {
        static void Main(string[] args)
        {
            #nullable enable 
            string? name = null;
            var myName = name!.ToString();//! null forgiving operator
            #nullable restore
        }
    }
}
