using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuongTrinhBac2
{
    public class Program
    {
        static double a, b, c, delta, x1, x2;
        static void Main(string[] args)
        {
            NhapABC();
            GiaiPhuongTrinh();
            Console.Write("Nhập enter để kết thúc chương trình:");
            Console.Read();
        }

        // Cần khởi tạo function nhập biến vàoƯ
        static void NhapABC() { 


            String buf;
            Console.WriteLine("Nhap A:");
            buf= Console.ReadLine();
            a = Double.Parse(buf);
            Console.WriteLine("Nhap B:");
            buf = Console.ReadLine();
            b = Double.Parse(buf);
            Console.WriteLine("Nhập C:");
            buf = Console.ReadLine();
            c = Double.Parse(buf);

        }

        // Khởi tạo function giải phương trình

        static void GiaiPhuongTrinh()
        {
            // Tính giá trị cho delta
            delta = b * b - 4 * a * c;
            Console.Write("delta" + delta);
            if (delta > 0)
            {

                x1 = (-b + Math.Sqrt(delta)) / 2 * a;
                x2 = (-b - Math.Sqrt(delta)) / 2 * a;
                Console.Write(" Phương trình có 2 nghiệm phân biệt:");
                Console.WriteLine(" X1" + x1);
                Console.WriteLine(" X2" + x2);

            }
            else if (delta < 0)
            {

                Console.Write("Phương trình vô nghiệm");

            }

            else
            {
                double x;
                x = -b / (2 * a);
                Console.WriteLine(" Nghiệm là:" + x);

            }

        }
    }




}
