using System;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using Microsoft.CSharp.RuntimeBinder;

class Program
{
    static void Main(string[] args)
    {
        //int y = 22;
 
        ScriptEngine engine = Python.CreateEngine();
        ScriptScope scope = engine.CreateScope();
        engine.ExecuteFile("program.py", scope);

        dynamic getpassdef = scope.GetVariable("getpassdef");
        getpassdef();

        dynamic isvscomparison = scope.GetVariable("isvscomparison");

        int[] first = {1, 2, 3};
        int[] second = {1, 2, 3};
        Console.WriteLine( isvscomparison(first, second) );

        dynamic swapcasedef = scope.GetVariable("swapcasedef");
        Console.WriteLine( swapcasedef("Test") );

        dynamic multiplystr = scope.GetVariable("multiplystr");
        Console.WriteLine( "b" + multiplystr("r", 20));

        /*scope.SetVariable("y", y);
        engine.ExecuteFile("hello2.py", scope);
        dynamic x = scope.GetVariable("x");
        dynamic z = scope.GetVariable("z");
        Console.WriteLine($"{x} + {y} = {z}");*/
    }
}