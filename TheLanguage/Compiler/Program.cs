using System;
using System.Reflection.Emit;

namespace Compiler
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicMethod method = new DynamicMethod("Test", typeof(int), null);
            var ilGenerator = method.GetILGenerator();

            // return 1+4; ->
            ilGenerator.Emit(OpCodes.Ldc_I4, 1); //1 wird auf Stack gelegt
            ilGenerator.Emit(OpCodes.Ldc_I4, 4); //4 wird auf Stack gelegt
            ilGenerator.Emit(OpCodes.Add); //Werte auf dem Stack (1 und 4) werden addiert
            ilGenerator.Emit(OpCodes.Ret); //Returned den letzten Wert auf dem Stack

            var func = (Func<int>)method.CreateDelegate(typeof(Func<int>));

            Console.WriteLine(func());
            Console.ReadLine();
        }
    }
}
