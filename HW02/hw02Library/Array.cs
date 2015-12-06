using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw02Library
{
    public class Array
    {
        public double[] values;

        //Constructor 建構式:沒有任何回傳型別
        public Array(int length)
        {
            values = new double[length];
            for (int index = 0; index < length; index++)
            {
                values[index] = 0;
            }
        }

        // == Functions writen for homework ==
        public double Sum()
        {
            double sum = 0;
            for (int i = 0; i < values.Length; i++)
            {
                sum += values[i];
            }
            return sum;
        }

        public Array Cusum()
        {
            double[] table = new double[this.values.Length];
            double sum = 0;
            for (int i = 0; i < values.Length; i++)
            {
                sum += values[i];
                table[i] = sum;
            }
            this.values = table;
            return this;
        }

        public Array Add(double value)
        {
            double[] table = new double[this.values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                table[i] = values[i] + value;
            }
            this.values = table;
            return this;
        }

        public Array Sub(double value)
        {
            double[] table = new double[this.values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                table[i] = values[i] - value;
            }
            this.values = table;
            return this;
        }

        public Array Multiply(double value)
        {
            double[] table = new double[this.values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                table[i] = values[i] * value;
            }
            this.values = table;
            return this;
        }

        public Array Div(double value)
        {
            double[] table = new double[this.values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                table[i] = values[i] / value;
            }
            this.values = table;
            return this;
        }

        // == Functions given by instructor ==
        public Array Remove(int index)
        {
            double[] table = new double[this.values.Length - 1];
            int count = 0;
            for (int Index = 0; Index < values.Length; Index++)
            {
                if (Index == index)
                {
                    continue;
                }
                table[count] = values[Index];
                count++;
            }
            this.values = table;

            return this;
        }

        public void Print()
        {
            for (int index = 0; index < this.values.Length; index++)
            {
                Console.WriteLine("Array[{0}]={1}", index, values[index]);
            }
        }

        public Array GenerateRamdomValues()
        {
            Random random = new Random();
            for (int index = 0; index < this.values.Length; index++)
            {
                this.values[index] = random.Next(0, this.values.Length);
            }
            return this;
        }

        public Array GenerateSequence()
        {
            for (int index = 0; index < this.values.Length; index++)
            {
                this.values[index] = index;
            }
            return this;
        }
    }
}