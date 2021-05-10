using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = new List<int> { 5, 7, 1, 3, 9, 10, 4, 2 };
            arr.Sort();

            List<Profile> profiles = new List<Profile>();
            profiles.Add(new Profile() { Name = "정우성",Height = 186});
            profiles.Add(new Profile() { Name = "김태희",Height = 158});
            profiles.Add(new Profile() { Name = "전지현",Height = 171});
            profiles.Add(new Profile() { Name = "고현정",Height = 172});
            profiles.Add(new Profile() { Name = "이문세",Height = 178});
            profiles.Add(new Profile() { Name = "하하",Height = 170});
            profiles.Add(new Profile() { Name = "주지훈",Height = 192});

            var profile1 = from item in profiles
                           orderby item.Height ascending
                           select item;//sort보다 시간 적게 든다.

            var profile2 = from item in profiles
                           orderby item.Height descending
                           select new { Name = item.Name, Inch = item.Height * 0.393 };//Height -> Inch로 name변경됨

            /*var profile2 = profiles.Where(p => p.Height < 172)
                                    .OrderByDescending(p => p.Height)
                                    .Select(item =>
                                    new
                                    {
                                        Name = item.Name,
                                        Inch = item.Height * 0.393
                                    });*/ // 람다방식 적용

            Console.WriteLine("All Profile List");
            foreach (var item in profiles)
            {
                Console.WriteLine($"{item.Name} : {item.Height} cm.");
            }
            Console.WriteLine();

            Console.WriteLine("All Profile1 List(오름차순)");
            foreach (var item in profile1)
            {
                Console.WriteLine($"{item.Name} : {item.Height} cm.");
            }
            Console.WriteLine();

            Console.WriteLine("All Profile2 List(오름차순)");
            foreach (var item in profile2)
            {
                Console.WriteLine($"{item.Name} : {item.Inch} cm.");
            }
            Console.WriteLine();

            /*List<Profile> newProfiles = new List<Profile>(); // var 해도 문제 발생 하지 x
            foreach (var item in profiles)
            {
                if (item.Height < 172)
                {
                    newProfiles.Add(item);
                }
            }*/

            var newProfiles = from item in profiles
                              where item.Height < 172
                              orderby item.Height descending // 내림차순 정렬
                              select item; //Linq 화, Linq = 데이터 질의 in C#
            

            Console.WriteLine("under 172 cm Profile List");
            foreach (var item in newProfiles)
            {
                Console.WriteLine($"{item.Name} : {item.Height} cm.");
            }
            Console.WriteLine();
            //
            int maxSize = 100; //10;
            int[] numbers = new int[maxSize];
            for (int i = 0; i < maxSize; i++)
            {
                numbers[i] = (i + 1);
            }

            for (int i = 0; i < maxSize; i++)
            {
                Console.Write($"{numbers[i]}\t");
            }
            Console.WriteLine();


            var result = from item in numbers
                         where (item % 10 == 3 || item % 10 == 6 || item % 10 == 9 || item / 10 == 3|| item / 10 == 6|| item / 10 == 9)//item % 3 == 0
                         select item;

            foreach (var item in result)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine("\n");


            InstClass[] arrClass = {
                new InstClass() { Name = "연두반", Score = new int[] {90,80,70,24}},
                new InstClass() { Name = "분홍반", Score = new int[] {60,54,87,72}},
                new InstClass() { Name = "파랑반", Score = new int[] {92,30,85,94}},
                new InstClass() { Name = "노랑반", Score = new int[] {90,88,0,17}}
            };

            var rstClasses = from item in arrClass
                             from score in item.Score
                             where score < 60
                             orderby score ascending
                             select new { Name = item.Name, Lowest = score };

            foreach (var item in rstClasses)
            {
                Console.WriteLine($"{item.Name} : {item.Lowest}");
            }
            Console.WriteLine();

            //group by
            var profiles3 = from item in profiles
                              orderby item.Height 
                              group item by item.Height < 172 into g // 내림차순 정렬
                              select  new { GroupKey = g.Key, Profiles = g }; //Linq 화, Linq = 데이터 질의 in C#

            foreach (var item in profiles3)
            {
                Console.WriteLine($"-172cm 미만 : {item.GroupKey}");
                foreach (var sub in item.Profiles)
                {
                    Console.WriteLine($" >>> {sub.Name} : {sub.Height}");
                }
                
            }

            
        }
    }
}
