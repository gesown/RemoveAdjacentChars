using atest.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace atest.Facade
{
    internal class AdjDupRemover : IAdjDupRemover
    {
        public IList<char> RemoveAdjacentDuplicates(IList<StrInChar> inchars)
        {
            var iCCountIn = 0;
            while (true)
            {
                iCCountIn = inchars.Count;
                inchars = InternalRemoveAdjacentDuplicates(inchars);
                if (inchars.Count == iCCountIn) break;
            }
            return inchars.Select(s => s.InChar).ToList(); 
        }

        private IList<StrInChar> InternalRemoveAdjacentDuplicates(IList<StrInChar> inchars)
        {
            for (int item = 0; item < inchars.Count - 1; item++)
            {
                if (inchars[item].InChar == inchars[item + 1].InChar)
                {
                    inchars[item].AdjFlag = true;
                    inchars[item + 1].AdjFlag = true;
                }
            }
            inchars = inchars.Where(s => s.AdjFlag == false).ToList();
            return inchars;
        }
    }
}