using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerTestApp
{
    class MyList : IEnumerable, IEnumerator
    {
        private int[] array;

        public int this[int index]//== MyList[i] == array[i]
        {
            get { return array[index]; } 
            set 
            {
                if (index >= array.Length)//main에서 요구하는 길이 받아줌
                {
                    System.Array.Resize(ref array, index+1);
                    Console.WriteLine($"Array resized : {array.Length}");
                }
                array[index] = value;
            }
        }//property와 비슷

        public int Length
        {
            get
            {
                return array.Length;//3
            }
        }//length property생성 이유 : array가 private여서 main에서 접근 불가하므로

        public object Current => throw new NotImplementedException();

        public MyList()
        {
            array = new int[3];
        }


        public void Reset()
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }
    }
}
