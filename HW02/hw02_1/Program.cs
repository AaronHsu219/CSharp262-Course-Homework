using hw02Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw02_1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // == Generate 0 array
            hw02Library.Array numbers2 = new hw02Library.Array(10);

            // == TEST Array.GenerateSequence()
            Console.WriteLine(" <== GenerateSequence() ==>");
            numbers2.GenerateSequence();
            numbers2.Print();

            // == TEST Sum()
            Console.WriteLine("\n <== Test Sum() ==>");
            Console.WriteLine(numbers2.Sum());

            // == TEST Cusum()
            Console.WriteLine("\n <== Test Cusum() ==>");
            numbers2.Cusum().Print();

            // == TEST Add();
            Console.WriteLine("\n <== Test Add() ==>");
            numbers2.Add(3).Print();

            // == TEST Sub();
            Console.WriteLine("\n <== Test Sub() ==>");
            numbers2.Sub(3).Print();

            // == TEST Multiply();
            Console.WriteLine("\n <== Test Multify() ==>");
            numbers2.Multiply(3).Print();

            // == TEST Div();
            Console.WriteLine("\n <== Test Div() ==>");
            numbers2.Div(3).Print();
        }
    }
}