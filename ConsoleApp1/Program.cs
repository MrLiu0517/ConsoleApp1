// See https://aka.ms/new-console-template for more information

//整数类型
int a = 20;
//长整形
long b = 2L;
//浮点型
float c = 30;
double d = 30.0;
//字符类型
char e = 'a';
//字符串类型
string f = "nihao";
//自动推导数据类型变量数据
var r = "nihao";

//创建类的实例
Calcu add = new Calcu();
//调用方法
int q = add.Add(445, 32);
//输出结果
Console.WriteLine(q);//477

//方法和类
class Calcu
{
    public int Add(int a, int b)
    {
        return a + b;
    }
}