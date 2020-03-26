using atest.Model;
using System.Collections.Generic;

namespace atest.Facade
{
    public static class AtFacade
    {
        internal static IAtModel GetModel(string strIn)
        {
            return new AtModel(strIn);
        }

        internal static IList<char> RemoveAdjacentDuplicates(IList<StrInChar> inchars)
        {
            IAdjDupRemover rad = new AdjDupRemover();
            return rad.RemoveAdjacentDuplicates(inchars);
        }
    }
}
