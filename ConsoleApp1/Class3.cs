namespace ConsoleApp1;

public class Class3
{
   //字段
   private int age;
   //完整属性写法
   public int Age
   {
      get { return age;}
      set
      {
         if (value>=0 && value<=100)
         {
            age = value;
         }
         else
         {
            Console.WriteLine("输入的年龄有误！");
         }
      }
   }
   //简写属性
   public int Id { get; private set; }

   
    
}