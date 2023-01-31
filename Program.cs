/*double a;
double b;
double c;
char oper;
double result ;

Console.WriteLine("Input first value ");
 a = double.Parse(Console.ReadLine());

Console.WriteLine("Input Operator ");
 oper = char.Parse(Console.ReadLine());

Console.WriteLine("Input second Value ");
 b = double.Parse(Console.ReadLine());

Console.WriteLine("Input Operator ");
oper = char.Parse(Console.ReadLine());

Console.WriteLine("Input third Value ");
c = double.Parse(Console.ReadLine());

if (oper == '+')
{
    result = a + b + c;
    Console.WriteLine("Summ of count  " + a + " And " + b + " And " + c +  " Equals " + result);
}

else if(oper == '-')
{
    result = a - b;
    Console.WriteLine("Summ of count  " + a + " And " + b + " And " + c + " Equals " + result);
}


else if(oper == '*')
{
    result = a * b;
    Console.WriteLine("Summ of count  " + a + " And " + b + " And " + c + " Equals " + result);
}

else if(oper == '/')
{
    result = a / b;
    Console.WriteLine("Summ of count  " + a + " And " + b + " And " + c + " Equals " + result);
} 
*/

/*double firstValue, secondValue;
char oper;
double result;

Console.WriteLine("Input Virst Value ");
firstValue = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input Operator ");
oper = char.Parse(Console.ReadLine());

Console.WriteLine("Input Virst Value ");
secondValue = Convert.ToDouble(Console.ReadLine());

if(oper == '+')
{
    result = firstValue + secondValue;
    Console.WriteLine("PLUS of values " + firstValue + " And " + secondValue +  " Equals " + result);
}
if (oper == '-')
{
    result = firstValue - secondValue;
    Console.WriteLine("Dividing of values " + firstValue + " And " + secondValue + " Equals " + result);
}

if(oper == '/')
{
    result = firstValue / secondValue;
    Console.WriteLine("Dividing of values " + firstValue + " And " + secondValue + " Equals " + result);
}
if(oper == '*')
{
    result = firstValue * secondValue;
    Console.WriteLine("SUMM of values " + firstValue + " And " + secondValue + " Equals " + result);
}*/



/*int a, b;
bool varieble;

Console.WriteLine("Input True value ");
a = Convert.ToInt32(Console.ReadLine());


if (true)
{
    varieble = a < 100;
    Console.WriteLine(varieble);
}
Console.WriteLine("Input False value ");
b = Convert.ToInt32(Console.ReadLine());

if (true)
{
    varieble = a > 100;
    Console.WriteLine(varieble);
}*/


int a, b;
double result;

Console.WriteLine("Input Value number one: ");
a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input Value number Two: ");
b = Convert.ToInt32(Console.ReadLine());
result = a + b;



Console.WriteLine("Sum of number will be: " + result);