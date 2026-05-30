// namespace TMS
// {
//   public class Student
//   {
//     public string Id {get; set;} = string.Empty;
//     public string Name {get; set;} = string.Empty;
//     public int Age {get; set;} = int.MinValue;
//     public decimal GPA {get; set;} = decimal.Zero;
//   }
// }

namespace TMS
{
  
public class Student
{
  public required string Id {get;init;}

  public required string Name
  {
    get;
    set =>field = !string.IsNullOrWhiteSpace(value)?value:throw new ArgumentOutOfRangeException(nameof(value));
  }

  public required int Age
  {
    get;
    set =>field = value is >=16 and <=100 ? value : throw new ArgumentOutOfRangeException(nameof(value), "Age Must be between 16 and 100");
  }

  public required decimal GPA
  {
    get;
    set=>field = value is >=0m and <=4m ? value : throw new ArgumentOutOfRangeException(nameof(value), "GPA Must be between 0 and 4 ");
  }
}
}