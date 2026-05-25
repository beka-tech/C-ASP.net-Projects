
public class Rectangle
{
public Rectangle (double width,double height)
  {
    Width = width;
    Height = height;
  }
  public double Width {get;set;}
  public double Height {get;set;}

  public double Area => Width * Height;
  public double Perimeter {
    get => 2 * (Width + Height);
  }
}


// public class Student 
// {
//     public string name = "";
//     public string? school;
//     public int age;

//     public Student(string studentName,  int studentAge)
//     {
//         name = studentName;
//       //  school = studentSchool;
//         age = studentAge;
//     }

//     public void Talk()
//     {
//         Console.WriteLine($"My name is {name} and I am {age} years old. School: {school ?? "unknown"}");
//     }
// }


class Student
{
  private string name;
  private int age;

  public string Name
  {
    get{return name;}
    set
    {
      if (string.IsNullOrWhiteSpace(value))
      {
        Console.WriteLine("Name cannot be empty. ");
      }
      else
      {
        name = value;
      }
    }
  }

  public int Age
  {
    get{return age;}
    set
    {
      if (int.IsNegative(value))
      {
        Console.WriteLine("age can be zero and negative");
      }
      else
      {
        age = value;
      }
    }
  }

  public void talk()
  {
    Console.WriteLine($"{name}and{age}");
  }

}

public class BankAccount
{
  public string Owner{get; set;}
  public decimal Balance{get;private set;}
  public void Deposit(decimal amount)
  {
    if(amount > 0)
    {
      Balance += amount;
    }
  }
}