// Problem 1.   Declare Variables
//
// Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, 
// ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
// Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.   
// Submit the source code of your Visual Studio project as part of your homework submssion.

using System;

class DeclareVariables
{
    static void Main()
    {
        Console.Title = "01. Declare Variables";
        Console.WriteLine("minimum byte value: {0}, maximum byte value: {1}", byte.MinValue, byte.MaxValue);
        Console.WriteLine("minimum sbyte value: {0}, maximum sbyte value: {1}", sbyte.MinValue, sbyte.MaxValue);
        Console.WriteLine("minimum short value: {0}, maximum short value: {1}", short.MinValue, short.MaxValue);
        Console.WriteLine("minimum ushort value: {0}, maximum ushort value: {1}", ushort.MinValue, ushort.MaxValue);
        Console.WriteLine("minimum int value: {0}, maximum int value: {1}", int.MinValue, int.MaxValue);
        Console.WriteLine("minimum uint value: {0}, maximum uint: {1}", uint.MinValue, uint.MaxValue);
        Console.WriteLine("minimum long value: {0}, maxumum long value: {1}", long.MinValue, long.MaxValue);
        Console.WriteLine("minimum ulong value: {0}, maximum ulong value: {1}\n", ulong.MinValue, ulong.MaxValue);
        ushort ushortVar = 52130;
        sbyte sbyteVar = -115;
        int intVar = 4825932;
        byte byteVar = 97;
        short shortVar = -10000;
        Console.WriteLine("ushortVar = {0}\nsbyteVar = {1}\nintVar = {2}\nbyteVar = {3}\nshortVar = {4}", ushortVar, sbyteVar, intVar, byteVar, shortVar);
    }
}
