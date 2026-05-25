using System.Runtime.InteropServices.Marshalling;
using System.Text;
// using DataType;
// int ? age = 90;
// if(age.HasValue)
// {
//     Console.WriteLine($"Age is {age.Value}");
// }
// else
// {
//     Console.WriteLine("Age is not provided.");
// } 

// String ? name = "beka";

// Console.WriteLine(name ?? "unknown");

// int age = 90;

// String can = age >= 18 ? "yes" : "no";

// Console.WriteLine($"Is allowed to drive: {can}");

// int[] num1 = {9};
// int[] num2 = num1;

// num2[0] = 10;

// Console.WriteLine(num1[0]);

// double number = 100.4656;
// int newNumber = (int)number; // Implicit conversion from int to double  
// Console.WriteLine(newNumber); // Output: 100

// double n1 =0.1;
// double n2 = 0.2;
// double sum = n1 + n2;
// Console.WriteLine(sum); // Output: 0.30000000000000004

// String text = "string built in methods ";
// Console.WriteLine(text.Replace("built","Build "));

// using System.Reflection.Metadata;

// String sentence = " Hello World K";


// bool hasE = sentence.Contains("e");
// bool startsWithH = sentence.StartsWith("H");
// // Console.WriteLine($"Does the sentence start with 'H'? {startsWithH}");

// Console.WriteLine($"Does the sentence contain 'e'? {hasE}");
// String trimmedSentence = sentence.Trim().Replace(" ","");
// Console.WriteLine(trimmedSentence);
// String[] newWords = sentence.Trim().Split(" ");
// Console.WriteLine(newWords[2]);


// StringBuilder result = new StringBuilder();

// // String result = "";
// for (int i = 0; i < 100; i++)
// {
//     result.Append(i.ToString() + " ") ;
// }
// Console.WriteLine(result);

// String line ="Hello World K";
// String[]  parts  = line.Split(" ");

// foreach (var part in parts)
// {
//     Console.WriteLine(part);
// }

//try




// String day = "Mondaym";

// switch (day)
// {
//   case  "Monday":
//   Console.WriteLine(1);
//   break;

//   default:
//   Console.WriteLine("O");
//   break;
// }

//  int c = 24;

// Console.WriteLine(c++); 

// String? region = "Addis";

// Console.WriteLine(region??"unassigned ");

// String? region = null;

// Console.WriteLine(region??"Region unassigned");

// var a = new Rectangle(2,3);
// //  a.Width = 2;
// //  a.Height = 2;
// Console.WriteLine(a.Area);
// Console.WriteLine(a.Perimeter);

// void  Increment(int value)
// {
//   value++;
// }
// int val =10;
//  Increment(ref val);
// Console.WriteLine(val);


// void GetNameAndAge(out string name, out int age)
// {
//     name = "Usman";
//     age = 21;
// }

// GetNameAndAge(out string userName, out int userAge);

// Console.WriteLine(userName);
// Console.WriteLine(userAge);

// Dictionary<String, int > Students = new Dictionary<string, int>();

// Students.Add("beka",23);
// Students.Add("abe",23);

// Console.WriteLine(Students["beka"]);





// Student s1 = new Student("Beka", 29);
// // s1.school = "Unity";
// // s1.Talk();

// var a = s1.age;

// Console.WriteLine(a);




// Student mystudent = new Student();

// mystudent.Name ="beka";
// mystudent.Age = -1;

// mystudent.talk();

// BankAccount myacct = new BankAccount();
// myacct.Deposit(30);
// Console.WriteLine(myacct.Balance);

