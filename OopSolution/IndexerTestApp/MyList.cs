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
        //IEnumerable,IEnumerator 상속 == for each 사용 가능하게 해줌

        private int[] array;
        private int position = -1; //배열의 현재 위치값  why -1? 배열이 비었음을 표시

        //배열화 <배열이 아닌 MyList를 배열처럼 만들어주는 property>
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

        public MyList()
        {
            array = new int[3];
        }


        public void Reset()// 컬렉션의 첫 번째 요소 앞의 초기 위치에 열거자를 설정합니다.
        {
            position = -1;//초기화
            //throw new NotImplementedException();
        }

        //foreach를 위한 작업

        //IEnumerator method
        //public object Current => throw new NotImplementedException();//컬렉션에서 열거자의 현재 위치에 있는 요소를 가져옵니다.
        public object Current => array[position];//변형

        /*public object Current // == public object Current => array[position];
        {
            get { return array[position]; } // 현재값 나타냄 , foreach에만 필요!
        }*/


        //IEnumerable method!
        public IEnumerator GetEnumerator()//컬렉션을 반복하는 열거자를 반환 
        {
            return this;
            //throw new NotImplementedException();
        }

        public bool MoveNext()//열거자를 컬렉션의 다음 요소로 이동합니다.
        {
            position ++;
            return (position < array.Length);
            //throw new NotImplementedException();
        }
    }
}
