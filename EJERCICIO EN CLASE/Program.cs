using System.Linq.Expressions;
int n1, n2;
void saludar()
{
    Console.WriteLine("Buenas");
}
int suma(int n1, int n2)
{
    
    return  n1 + n2;
  

}
int res(int n1, int n2)
{
   
    return  n1 - n2;
    
}
int div(int n1, int n2)
{
   
    return n1/n2;
   
}
int mul(int n1, int n2)
{
    
    return n1 * n2;
    
saludar();
Console.WriteLine("Ingrese el primer numero");
n1 = int.Parse (Console.ReadLine());
Console.WriteLine("Ingrese el primer numero");
n2 = int.Parse(Console.ReadLine());

Console.WriteLine("Que operacion desea realizar: \r\n1 = Suma \r\n2 = Resta \r\n3 = Multiplicacion \r\n4 = Division");
Console.ReadLine();
int no = int.Parse(Console.ReadLine());
switch (no)
{
    case 1:
        Console.WriteLine(suma);
        break;      
    case 2:
        Console.WriteLine(res);
        break;
        case 3:
        Console.WriteLine(mul);
        break;  
        case 4:
        Console.WriteLine(div);
        break;
        default:
        Console.WriteLine("Ingrese una opcion válida");
        break;




    }
