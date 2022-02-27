using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace GenericsLabb1
{
    public class LådaSameDimensions : EqualityComparer<Låda>
    {
        public override bool Equals(Låda x, Låda y)
        {
            if (x.bredd == y.bredd && x.höjd == y.höjd && x.längd == y.längd)
            { 
              
                return true;
               
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode([DisallowNull] Låda låd)
        {
            var hCode =  låd.höjd ^ låd.längd ^ låd.bredd;
            return hCode.GetHashCode();
        }
    }
}
