using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace GenericsLabb1
{
    class LådaSameValues : EqualityComparer<Låda>
    {
        public override bool Equals(Låda x, Låda y)
        {
            if ((x.bredd, x.höjd, x.längd) == (y.bredd, y.höjd, y.längd))
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
            int hCode = låd.höjd ^ låd.längd ^låd.bredd;
            Console.WriteLine("HashCode: {0}", hCode.GetHashCode());
            return hCode.GetHashCode();
        }
    }
}
