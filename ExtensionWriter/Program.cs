using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Emit;

namespace ExtensionWriter
{
    public class Methods
    {
        //public int Subscribe(int a, int b)
        //{
        //    Console.WriteLine(a - b);
        //    return a - b;
        //}
        //public int Sum(int a, int b)
        //{
        //    Console.WriteLine(a - b);
        //    return a - b;
        //}
    }
    class Program
    {
        static void Main()
        {
            //Methods methods = new Methods();
            //Action<int, int> action;
            //int z = 1;
            //if(z==1)
            //    action = delegate(int a, int b) { methods.Subscribe(a, b); };
            //else
            //    action = delegate (int a, int b) 
            //    {
            //        //methods.GGG(a, b);

            //    };



            //= new Action(methods.Subscribe);
            //Delegate del = methods.Subscribe;
            //MethodInfo mi = typeof(Methods).GetMethod("Subscribe");

            //Type[] inputTypes = { typeof(int), typeof(int) };


            //Delegate myDel = mi.CreateDelegate(Expression.GetDelegateType(
            //    (from parameter in mi.GetParameters() select parameter.ParameterType)
            //    .Concat(new[] { mi.ReturnType })
            //    .ToArray()));

            //myDel.DynamicInvoke(10, 1);
        }
    }
}
