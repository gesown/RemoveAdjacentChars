using atest.Model;
using System.Collections.Generic;

namespace atest.Facade
{
    internal interface IAdjDupRemover
    {
        IList<char> RemoveAdjacentDuplicates(IList<StrInChar> inchars);
    }
}