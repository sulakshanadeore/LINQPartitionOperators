using LINQPartitionOperators;
using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");

        //int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

        //var take3 = numbers.Take(3);
        //foreach (var item in take3)
        //{
        //    Console.WriteLine(item);
        //}
        //Console.WriteLine("--------");
        //var result = numbers.TakeLast(3);
        //foreach (var item in result)
        //{
        //    Console.WriteLine(item);
        //}
        //Console.WriteLine("--------");
        //result = numbers.TakeWhile(n => n < 10);
        //foreach (var item in result)
        //{
        //    Console.WriteLine(item);
        //}
        //Console.WriteLine("--------");
        //result = numbers.Skip(3);
        //foreach (var item in result)
        //{
        //    Console.WriteLine(item);
        //}
        //Console.WriteLine("---------");
        //result = numbers.SkipWhile(n => n < 10);
        //foreach (var item in result)
        //{
        //    Console.WriteLine(item);
        //}
        //Console.WriteLine("---------");
        //result = numbers.SkipLast(10);
        //foreach (var item in result)
        //{
        //    Console.WriteLine(item);
        //}
        //Console.WriteLine("----------------------");
        //var chunkresult = numbers.Chunk(3);

        //foreach (var item in chunkresult)
        //{
        //    Console.WriteLine(string.Join(",",item));

        //}


        //var students = new List<Student> 
        //{
        //    new Student {Name="Jack" ,Marks=76} ,
        //    new Student { Name="Mike" ,Marks=97} ,
        //    new Student { Name="Jim" ,Marks=55} ,
        //    new Student {Name="Sam" ,Marks=69 } ,
        //    new Student {Name="Raj" ,Marks=45 } ,
        //};

        //var result = students.Take(3);

        //foreach (var item in result)
        //{
        //    Console.WriteLine(item.Name + "  " + item.Marks);
        //}


        //var students = new List<Student>
        //{
        //    new Student {Name="Jack" ,Marks=76,City="Pune"} ,
        //    new Student { Name="Mike" ,Marks=97,City= "Pune"} ,
        //    new Student { Name="Jim" ,Marks=55, City = "Mumbai"} ,
        //    new Student {Name="Sam" ,Marks=69,City="Kochi" } ,
        //    new Student {Name="Raj" ,Marks=45,City="Kochi" } ,
        //};

        ////Find the students who have marks between 45 6o 70, and city=Kochi

        //   var result=from s in students
        //              where (s.Marks>=45 && s.Marks<=70) && s.City=="Kochi"
        //                select s;

        ////Find the students who have marks between 45 6o 70, or city=Kochi
        //result = from s in students
        //             where (s.Marks >= 45 && s.Marks <= 70) || s.City == "Kochi"
        //             select s;

        //foreach (var item in result)
        //{
        //    Console.WriteLine(item.Name + "|" +   item.City + "|" + item.Marks  ) ;    
        //}




        Student[] students = new Student[]
        {
            new Student {Name="Jack" ,Marks=76,City="Pune"} ,
            new Student { Name="Mike" ,Marks=97,City= "Pune"} ,
            new Student { Name="Jim" ,Marks=55, City = "Mumbai"} ,
            new Student {Name="Sam" ,Marks=69,City="Kochi" } ,
            new Student {Name="Raj" ,Marks=45,City="Kochi" } ,
        };

        var list=students.Where(s=>s.City=="Kochi").ToList();

       List<Student> studentList = new List<Student>
        {
            new Student {Name="Jack" ,Marks=76,City="Pune"} ,
            new Student { Name="Mike" ,Marks=97,City= "Pune"} ,
            new Student { Name="Jim" ,Marks=55, City = "Mumbai"} ,
            new Student {Name="Sam" ,Marks=69,City="Kochi" } ,
            new Student {Name="Raj" ,Marks=45,City="Kochi" } ,
        };

        var arr = students.Select(e => e.Name).ToArray();
       
        studentList = new List<Student>
        {
            new Student {RollNo=1,Name="Jack" ,Marks=76,City="Pune"} ,
            new Student {RollNo=2, Name="Mike" ,Marks=97,City= "Pune"} ,
            new Student { RollNo=3,Name="Jim" ,Marks=55, City = "Mumbai"} ,
            new Student {RollNo=4,Name="Sam" ,Marks=69,City="Kochi" } ,
             new Student {RollNo=5,Name="Raj" ,Marks=45,City="Kochi" } ,
        };

        var dict = studentList.ToDictionary(s=>s.RollNo,s=>s.Name);
        Console.WriteLine("Dictionary print");
        foreach (var s in dict)
        {
            Console.WriteLine(s.Key);
            Console.WriteLine(s.Value);
        }

        Console.WriteLine("Print only Kochi students");

        var lookup = studentList.ToLookup(s => s.City);
        foreach (var item in lookup["Kochi"])
        {
            Console.WriteLine(item.Name);
        }

        //studentsArray is a array--Student[]
        Student[] studentsArray = new Student[]
        {
            new Student {Name="Jack" ,Marks=76,City="Pune"} ,
            new Student { Name="Mike" ,Marks=97,City= "Pune"} ,
            new Student { Name="Jim" ,Marks=55, City = "Mumbai"} ,
            new Student {Name="Sam" ,Marks=69,City="Kochi" } ,
            new Student {Name="Raj" ,Marks=45,City="Kochi" } ,
        };
        ArrayList studData = new ArrayList();
        studData=(ArrayList)studentsArray.Cast<Student>();
        studData.Add(1);//It can takes incompatible types
                        //Not safe, so use OfType

        var studs=studData.OfType<Student>(); 

        List<Student> studentsData=studs.ToList();
        studentsData.Add(new Student { RollNo = 7, Name = "ABC" });
        //Safer than Cast, Skips the Incompatible types

        //Here we don't have datbase data so using studentlist, otherwise
        //it will db.studentList.AsEnumerable().Where(e => e.RollNo == 1);

        var resultdata = studentList.AsEnumerable().Where(e => e.RollNo == 1);



        var resultdata2 = resultdata.AsQueryable();





    }
}