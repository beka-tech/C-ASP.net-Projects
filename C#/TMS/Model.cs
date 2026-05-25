// var enrollment = new EnrollmentRecord("STU-001","CS-401", DateTime.UtcNow);
// Console.WriteLine(enrollment);

// namespace TMS
// {
  
// }
namespace TMS
{
  
}
public class Enrollment
{
  public string StudentId {get; set;} = string.Empty;
  public string CourseCode{get; set;} = string.Empty;
  public DateTime ProcessedAt{get ; set;}
}

public record EnrollmentRecord(string StudentId, string CourseCode, DateTime EnrolledAt);

public class Course
{
  public required String Code{get;init;}

  public required String Title
  {
    get; 
    set=> field =!String.IsNullOrWhiteSpace(value)?value
    :throw new ArgumentException("Title cannot be empty or whitespace.", nameof(value));

  }



public int Capacity
  {
    get;
    set=>field=value>0
    ?value
    :throw new ArgumentOutOfRangeException(nameof(value),"System constrain: Capacity must be greater than zero");

  }
public int EnrolledCount{get;set;}
  }
// var enrollment = new EnrollmentRecord("STU-001","CS-401", DateTime.UtcNow);
// Console.WriteLine(enrollment);


