using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsLabb1
{
    public class Låda : IEquatable<Låda>
    {
        public int höjd { get; set; }
        public int längd { get; set; }
        public int bredd { get; set; }
        public Låda(int h, int l, int b)
        {
            this.höjd = h;
            this.längd = l;
            this.bredd = b;
        }
      

        public bool Equals(Låda other)
        {
            if (new LådaSameDimensions().Equals(this, other)| new LådaSameVol().Equals(this, other))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
     


        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
  
    }
}
