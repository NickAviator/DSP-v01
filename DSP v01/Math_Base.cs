using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSP_v01
{
    public class MathCalc_Base
    {
        public double Xf = 1;
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
                if (a_k.Length > a_i.Length)
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
                        arr[i, j] = (int)(Math.Sqrt(2) * Math.Cos((Math.PI) / 2 * Sum) + Math.Sqrt(2) * Math.Sin((Math.PI) / 2 * Sum));
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

        public double[,] CalcCore(int n, int base_num, bool FFT, double T, int type)
        {
            double[,] X = new double[n, n];
            int[,] arr_buf = MatrixGen(n, base_num);
            if (!FFT)
            {
                for (int k = 0; k < n; k++)
                {
                    for (int i = 0; i < n; i++)
                    {
                        //if (i % 2 == 0)
                            // (i+1) вместо x(i)// вообще заменить                      
                            X[k, i] = Math.Round((1 / (double)n) * arr_buf[k, i] * CalcXf(T, n, type, k), 2);
                        //else
                            //X[k, i] = Math.Round((1 / (double)n) * arr_buf[k, i] * CalcXf(T, n, type, k), 2);
                        /*
                        if (i % 2 == 0)
                            // (i+1) вместо x(i)// вообще заменить                      
                            X[k, i] = Math.Round((1 / (double)n) * arr_buf[k, i] * Math.Cos(2 * Math.PI / n * Sum), 2);
                        else
                            X[k, i] = Math.Round((1 / (double)n) * arr_buf[k, i] * Math.Sin(2 * Math.PI / n * Sum), 2);
                            */
                    }
                }
            }
            else
            {
                int i = 0;
                //Разбивать на группы
                //X(0) = x(0) + x(1) ... - x(5) ...
                for (int lmb = 0; lmb < n / base_num - 1; lmb++)
                {
                    for (int k1 = 0; k1 < n / base_num - 1; k1++)
                    {
                        for (int i1 = 0; i1 < n / base_num; i1++)
                        {                             //работает не на всех комбинациях N, p
                             int Sum = GetExtent(i1, lmb, base_num);
                             X[k1 * base_num + lmb, i1 * base_num + lmb] = Math.Round((1 / (double)n) * arr_buf[k1 * base_num + lmb, i1 * base_num + lmb] * Math.Cos(2 * Math.PI / n * Sum), 2);
                             //i = base_num * i1 + lmb;
                        }
                    }
                }
            }
            return X;
        }

        public double GetFunction(double i, int n, int base_num, bool FFT, double T, int type)
        {
            double Y = 0, add = 0;
            double Sum = 0;
            double[,] arr_out_F = CalcCore(n, base_num, FFT, T, type);

            Random r = new Random();

            //using (var sw = new StreamWriter(@"C:\Users\Nikita\Desktop\Log.txt"))

                for (int k = 0; k < n; k++)
                {
                    // X * sigma * x(i)
                    Sum += arr_out_F[k, (int)i] * Math.Pow(-1, r.Next(0, 4));

                    //sw.WriteLine(k.ToString() + ". Sum: " + Sum.ToString() + "X[" + k + "]:" + arr_out_F[k, (int)i].ToString());
                }
            // Строит долго - посмотреть почему.

            // Для БП прореженный порядок следования отчетов сигнала:
            /*
             * x(i) разбивается на N/p выборки с N/p отсчетами
             * 
             * для 16 и 4:
             * x0 = {x(0), x(4), x(8), x(12)}
             * x1 = {x(1), x(5), x(9), x(13)}
             * x2 = {x(2), x(6), x(10), x(14)}
             * x3 = {x(3), x(7), x(11), x(15)}
            */
            if (i % 2 == 0)
                // (i+1) вместо x(i)// вообще заменить
                add = Math.Round(/*.Cos((2 * Math.PI / n) * */(Sum), 2);
            else
                add = Math.Round(/*Math.Sin((2 * Math.PI / n) */ (Sum), 2);
            Y += add;
            return Y;
        }

        public double GetAKF(double i, double T, int type)
        {
            double Y = 0;
            Y = 10 * Math.Sin(i * Math.PI) / (i * Math.PI);
            return Y;
        }

        public double CalcXf(double T, int n, int type, int k)
        {
            double w = 2 * Math.PI / T;
            double N_up = T; //the same as (w * T) / 2 * Math.PI;
            //double Xf = 1;
            if (type == 1)
                Xf = Math.Abs(k / Math.Sqrt(4*N_up));
            if (type == 2)
                Xf = Math.Abs(k / Math.Sqrt(4 * N_up * Math.PI));
            return Xf;
        }
    }
}
