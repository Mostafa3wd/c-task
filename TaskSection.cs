using System;
namespace Task_Section{
    //task 1
    public class Student{
    
    private String Name ;
    public String _Name{
        set{Name=value;
        if(value == null || value == "" || value.Length >=32)
                {
                    throw new Exception("Invalid Name");
                }
        }
        get{ return Name;}
    }
    private int Age;
    public int _Age{
        set{Age =value;
        if(value <= 0 || value > 128)
                {
                    throw new Exception("Invalid Age");
                }
        }
        get{return Age;}
    }
        public Student(String name ,int age){
            _Name=name;
            _Age=age;
        }
        public virtual void print(){
            
            Console.WriteLine("My name is "+ _Name+ ",My age is "+_Age);

        }
    }
    public class Student : Student{
        private int Year;
        public int _Year{
            set{Year=value;
            if(value < 1 || value > 5)
                {
                throw new Exception("Invalid Year");
                }
            }
            get{return Year;}
        }
        private float Gpa;
        public float _Gpa{
            set{Gpa=value;
            if(value < 0 || value > 4)
                {
                throw new Exception("Invalid Gpa");
                }
            }
            get{return Gpa;}
        }
        public Student(String name,int age , int year, float gpa) : base(name,age){
            _Year= year;
            _Gpa=gpa;
        }

        public override void print()
        {
            Console.WriteLine("My name is "+ _Name  + ",My age is "+_Age+",My gpa is "+_Gpa);
        }
    }
    // task 2
    public class Staff : Student{
        private double Salary ;
        public double _Salary{
            set{Salary=value;
            if(value < 0 || value > 120000)
                {
                    throw new Exception("Invalid Salary");
                }
            }
            get{return Salary;}
        }
        private int JoinYear;
        public int _JoinYear{
            set{value = (2022-(2022-_Age));
            JoinYear=value;
            if(value<21)
                {
                    throw new Exception("Invalid JoinYear ");
                }
            }
            get{return JoinYear;}

        }
        public Staff(String name , int age ,double salary,int joinyear): base (name , age){
            _Salary=salary;
            _JoinYear=joinyear;

        }
        public override void print()
        {
        Console.WriteLine("My name is "+ _Name + ",My age is "+_Age+", and my salary is "+_Salary );
        }
    }
        public class Database {
        private  int CountIndex = 0;
        public int Size;
        
        public Student[] People ;
        public Database(int size){
            Size=size;
        People =new Student[size];

        }
        public void AddStudent(Student student){

            People[CountIndex++]= student; //first element in array  will take value from object student 

        }
        public void AddStaff(Staff staff){

            People[CountIndex++]= staff; //first element in array  will take value from object staff

        }
        public void AddPerson(Student person){

            People[CountIndex++]= person;

        }
        public void print_everthing(){
            for (int i=0;i< CountIndex ;i++){
                People[i].print();
            }

        }
    }
	class task{
	public static void Main(String []arge){
        Console.WriteLine("Enter the number of People :  ");
        int size = int.Parse(Console.ReadLine());
        var data_b= new Database(size);
        while(true){
            int option = int.Parse(Console.ReadLine());
            switch(option) {
                case 1: 
                Console.WriteLine("Enter the Name :  ");
                String N1 = Console.ReadLine();
                Console.WriteLine("Enter the Age :  ");
                int A1 = int.Parse( Console.ReadLine());
                Console.WriteLine("Enter the Year :  ");
                int Y1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Gpa :  ");
                float G1 = float.Parse(Console.ReadLine());
                try{
                    var student = new Student(N1,A1,Y1,G1);
                data_b.AddStudent(student);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                
                //student.print();
                break;
                case 2: 
                Console.WriteLine("Enter the Name :  ");
                String name1 = Console.ReadLine();
                Console.WriteLine("Enter the Age :  ");
                int age2 = int.Parse( Console.ReadLine());
                Console.WriteLine("Enter the Salary :  ");
                double salary2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the JoinYear :  ");
                int joinyear2 = int.Parse(Console.ReadLine());
                try{
                    var staff = new Staff(name1,age2,salary2,joinyear2);
                data_b.AddStaff(staff);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                
                //staff.print();
                break;
                case 3:
                Console.WriteLine("Enter the Name :  ");
                String N3 = Console.ReadLine();
                Console.WriteLine("Enter the Age :  ");
                int A3 = int.Parse( Console.ReadLine());
                try{
                var person =new Student(N3,A3);
                data_b.AddPerson(person);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                break;
                case 4:
                data_b.print_everthing();
                break;
                default:
                Console.WriteLine("Error");
                break;

            }
        }

	}
	}
}