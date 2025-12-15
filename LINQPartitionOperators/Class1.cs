using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPartitionOperators
{


    public abstract class  Employee
    {

        public int Empid { get; set; }
        public string Ename { get; set; }
       public abstract string Designation { get; set; }

    }

    public class Fresher:Employee
    {
        public override string Designation { get; set; }

    }

    public class Manager :Employee
    {
        public override string Designation { get; set; }
    }





  public  abstract class Vehicle
    {

        public  string Name { get; set; }
      public  abstract int Mileage { get; set; }
    }

    public class Car : Vehicle
    {
        public override int Mileage { get; set ; }
    }


    public class Auto : Vehicle
    {
        public override int Mileage { get; set; }

    }

    public class Bike : Vehicle
    {
        public override int Mileage { get; set; }
    }
}
