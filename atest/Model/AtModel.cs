using System.Collections.Generic;
using System.Linq;

namespace atest.Model
{
    class AtModel : IAtModel
    {
        public AtModel(string inputString)
        {
            InputChars = new List<StrInChar>();
            this.InputString = inputString;
            var inChars = InputString.ToCharArray().ToList();
            foreach (var item in inChars)
            {
                var newSIC = new StrInChar();
                newSIC.AdjFlag = false;
                newSIC.InChar = item;
                InputChars.Add(newSIC);
            }
        }
        public string InputString {get;set;}
        public IList<StrInChar> InputChars {get;set;}
    }
}
