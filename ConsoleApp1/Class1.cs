namespace ConsoleApp1;
/// <summary>
/// 声明学生类
/// </summary>
public class Student
{
    public string Id;
    public int Age;
    public string Hobby;
/// <summary>
/// 创建构造函数  
/// </summary>
/// <param 名称="id"></param>
/// <param 年龄="age"></param>
/// <param 爱好="hobby"></param>
    public Student(string id, int age, string hobby)
    {
        Id = id;
        Age = age;
        Hobby = hobby; 
    }
    
    
}