//delegate, Lambda, LinQ

#region
//================================================
//using LinQLambda;

//MyDele myDele = new MyDele(M1);
//myDele += M1;
//myDele += (new Student()).SayHello;
//myDele();
//static void M1(){
//    Console.WriteLine("M1 is called");
//}

//IntDele intDele = new IntDele(Add);
//intDele += Sub;
//var sum =intDele(4,3);
//static int Add(int x, int y)
//{
//    return x + y;
//}

//static int Sub(int x, int y)
//{
//    return x - y;
//}
#endregion
//================================================
#region
//using LinQLambda;

//MyDeleWithP<int> myDele = new MyDeleWithP<int>(Add);
//MyDeleWithP<double> myDeleD = new MyDeleWithP<double>(Mul);
//myDele(1, 2);
//Console.WriteLine(myDele(3, 4));

//Console.WriteLine(myDeleD(2,2));
//MyDele<int> myDele1 = new MyDele<int>(Sub);
//Console.WriteLine(myDele1());
//static int Sub()
// {
//    return 9;
//}
//static int Add(int x, int y)
//{
//    return x + y;
//}

//static double Mul(double x, double y)
//{
//    return x * y;
//}

#endregion
//================================================
#region
//Action action = new Action(SayHi);
//action();
//Action<string, int> action1 = new Action<string, int>(Greeting);
//action1("I am good", 3);

////the last parameter is out;
//Func<int, int, int> func = new Func<int, int, int>(Add);
//Func<double, double, double> func1 = new Func<double, double, double>(Mul);
//func1(3, 4);
//func(3, 4);
//Console.WriteLine($"{func1(3, 4)}, {func(3, 4)}");

//static void Greeting(string str, int round)
//{
//    for(int i = 0; i < round; i++)
//    {
//        Console.WriteLine($"{str} for {i+1} times.");
//    }
//}
//static void SayHi()
//{
//    Console.WriteLine("Hello");
//}

//static int Add(int i, int j)
//{
//    return i + j;
//}

//static double Mul(double i, double j)
//{
//    return i * j;
//}

#endregion
//================================================
#region
//Caculatior<int>((int a, int b) => { return a * b; }, 10, 20);
//Caculatior((int a, int b) => a * b, 11, 12);
//Caculatior(((a, b) => a * b),11,11) ;

//static void Caculatior<T>( Func<T,T,T>func, T x, T y)
//{
//    var result=func(x, y);
//    Console.WriteLine($"{result}");
//}


#endregion
//================================================


using TCPData;
using TCPExtensions;

List<Employee> employees = Data.GetEmployees();

var filteredEm = employees.Filter(em => em.IsManager == true);
//foreach(var em in filteredEm)
//{
//    Console.WriteLine(em.FirstName);
//}

var filteredEm1 = employees.Filter(em => em.AnnualSalary >60000);
foreach (var em in filteredEm1)
{
    Console.WriteLine(em.FirstName);
}
