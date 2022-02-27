using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GenericsLabb1 
{
    public class LådaCollection : ICollection<Låda>
    {
        
        private List<Låda> innerCol;
        public LådaCollection()
        {
            innerCol = new List<Låda>();
        }
        public Låda this[int index]
            {
            get { return innerCol[index]; }
            set { innerCol[index] = value; }
        }


        public int Count
        {
            get
            {
                return innerCol.Count;
            }
        }

        public bool IsReadOnly { get; }

        public void Add(Låda nyLåda)
        {
            if (!Contains(nyLåda))
            {
                innerCol.Add(nyLåda);
            }
            else
            {
                Console.WriteLine("Låda {0}x{1}x{2} finns redan i samlingen",
                   nyLåda.höjd.ToString(), nyLåda.längd.ToString(), nyLåda.bredd.ToString());
            }
        }

        public void Clear()
        {
            innerCol.Clear();
        }

        public bool Contains(Låda item)
        {
            bool hitta = false;
            foreach (Låda L in innerCol)
            {


                if (L.Equals(item))
                {
                    return true;
                }
            }
            return hitta;
        }
        public bool Contains(Låda item, IEqualityComparer<Låda> comparer)
        {
            bool hitta = false;
            foreach (Låda L in innerCol)
            {


                if (comparer.Equals(L, item))
                {
                    return true;
                }
            }

            return hitta;

        }

        public void CopyTo(Låda[] array, int arrayIndex)
        {
            if (array == null)
                throw new ArgumentException("Array kan inte vara tom.");
            if (arrayIndex < 0)
                throw new ArgumentOutOfRangeException("Array index kan inte vara negativ.");
            if (Count > array.Length - arrayIndex + 1)
                throw new ArgumentException("Arrays har mindre värden än collection");
            for (int i = 0; i < innerCol.Count; i++)
            {
                array[i + arrayIndex] = innerCol[i];
            }
        }

        public IEnumerator<Låda> GetEnumerator()
        {

            return new LådaEnumerator(this);
        }

        public bool Remove(Låda item)
        {
            bool result = false;
            // Iteratererar inner collection för att hitta vilken låda som ska bort.
            for (int i = 0; i < innerCol.Count; i++)
            {
                Låda curLåda = innerCol[i];

                if(new LådaSameDimensions().Equals(curLåda, item))
                {
                    innerCol.RemoveAt(i);
                    result = true;
                    break;
                }
                if(new LådaSameVol().Equals(curLåda, item))
                {
                    innerCol.RemoveAt(i);
                    result = true;
                    break;
                }
            }
            return result;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new LådaEnumerator(this);
        }
    }
}
