using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GenericsLabb1
{
    public class LådaEnumerator : IEnumerator<Låda>
    {
        private LådaCollection _Lådor;
        private int curIndex;
        private Låda curLåda;

        public LådaEnumerator(LådaCollection låda)
        {
            this._Lådor = låda;
            curIndex = -1;
            curLåda = default(Låda);
        }

        public Låda Current
        {
            get { return curLåda; }
        }
        object IEnumerator.Current
        {
            get { return Current; }
        }
        public int Count
        {
            get
            {
                return _Lådor.Count;
            }
        }
        public bool MoveNext()
        {
            if(++curIndex >= _Lådor.Count)
            {
                return false;
            }
            else
            {
                curLåda = _Lådor[curIndex];
            }
            return true;
        }
        void IEnumerator.Reset()
        {
            curIndex = -1;
        }
        public void Dispose()
        {

        }
    }
}
