using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSP_v01
{
    public class MathCalc
    {
        /// <summary>
        /// Функция получения степени для вычисления суммы числового ряда
        /// </summary>
        /// <param name="k"></param>
        /// <param name="i"></param>
        /// <param name="base_n"></param>
        /// <param name="n"></param>
        public int GetExtent(int k, int i, int base_n)
        {
            string a_k = "", a_i = "";
            int sum = 0;
                //количество разрядов у обоих чилел должно быть одинаковым
                a_k = Int32ToString(k, base_n);
                a_i = Int32ToString(i, base_n);
                
                while (a_k.Length != a_i.Length)
                {
                    if (a_k.Length < a_i.Length)
                        a_k = "0" + a_k;
                    if(a_k.Length > a_i.Length)
                        a_i = "0" + a_i;
                }
                
                int n = a_k.Length;
                //сравнить с формулой (2.5), что делать с разрядами? 
                for (int lmb = 0; lmb < n; lmb++)
                {       
                    //нужно a_k[n+1-lmb], а пока это Адамар
                    sum = sum + Convert.ToInt32(a_k[lmb]) * Convert.ToInt32(a_i[lmb]);
                }

            return sum;
        }
        
        /// <summary>
        /// Процедура генерации матрицы по значениям размерности n и основания base_n
        /// </summary>
        /// <param name="n"></param>
        /// <param name="base_num"></param>
        public int[,] MatrixGen(int n, int base_num)
        {
            //int base_num = 2; //by default
            //n = 4;
            //base_num = 2;
            int[,] arr = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    //check as fill with 0
                    int Sum = GetExtent(i, j, base_num);
                    // получаем функции Уолша (классические)
                    if (base_num == 2)
                    {
                        arr[i, j] = (int)(Math.Pow((-1), Sum));
                    }
                    // получаем функции Уолша (модифицированные)
                    if (base_num == 4)
                    {
                        arr[i, j] = (int)(Math.Sqrt(2) * Math.Cos((Math.PI) / 2 * Sum - (Math.PI) / 4));
                    }
                }
            }
            return arr;
        }

        public string Int32ToString(int value, int toBase)
        {
            string result = string.Empty;
            do
            {
                result = "0123456789ABCDEF"[value % toBase] + result;
                value /= toBase;
            }
            while (value > 0);

            //result = "0" + result; 

            return result;
        }
        //по формулам (правилу) стр 2.5, 2.6 сформировать матрицу Пэли

        public double[,] CalcCore(int n, int base_num)
        {
            double[,] X = new double[n, n];
            int[,] arr_buf = MatrixGen(n, base_num);
            for (int k = 0; k < n; k++)
            {
                for (int i = 0; i < n; i++)
                {
                    int Sum = GetExtent(k, i, base_num);
                    if (i % 2 == 0)
                        // (i+1) вместо x(i)// вообще заменить
                        X[k, i] = Math.Round((1 / (double)n) * arr_buf[k, i] * Math.Cos((2 * Math.PI / n) * Sum), 2);
                    else
                        X[k, i] = Math.Round((1 / (double)n) * arr_buf[k, i] * Math.Sin((2 * Math.PI / n) * Sum), 2);
                }
            }
            return X;
        }

        public double GetFunction(double i, int n, int base_num)
        {
            double Y = 0, add = 0;
            int Sum = 0;
            for (int k = 0; k < n; k++)
            {
                Sum = GetExtent(k, (int)i, base_num);
            }

            Random r = new Random();
            if (i % 2 == 0)
                // (i+1) вместо x(i)// вообще заменить
                add = Math.Round((2 * r.Next(0, 255) / 255 - 0.5) * Math.Cos((2 * Math.PI / n) * Sum), 2);
            else
                add = Math.Round((2 * r.Next(0, 255) / 255 - 0.5) * Math.Sin((2 * Math.PI / n) * Sum), 2);
            Y = 0 + add;
            return Y;
        }
    }
}
