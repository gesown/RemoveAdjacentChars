using System;
using System.Collections.Generic;
namespace atest.Model
{
    internal interface IAtModel
    {
        string InputString { get; set; }
        IList<StrInChar> InputChars { get; set; }
    }
}