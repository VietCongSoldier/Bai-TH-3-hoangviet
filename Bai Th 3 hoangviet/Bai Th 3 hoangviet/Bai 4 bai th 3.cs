using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_Th_3_hoangviet
{
    class Bai_4_bai_th_3
    {
    }
    class HocSinh
    {
        private string hoten;
        private double diemtoan;
        private double diemli;
        private double diemhoa;
        public HocSinh()
        {
            hoten = " ";
            diemtoan = diemli = diemhoa = 0;
        }
        public HocSinh(string hoten, double diemtoan, double diemli, double diemhoa)
        {
            this.hoten = hoten;
            this.diemtoan = diemtoan;
            this.diemli = diemli;
            this.diemhoa = diemhoa;
        }

        public void Nhap()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Họ tên học sinh : ");
            hoten = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Điểm toán= ");
            diemtoan = double.Parse(Console.ReadLine());
            Console.Write("Điểm lí=");
            diemli = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Điểm hóa= ");
            diemhoa = double.Parse(Console.ReadLine());
        }
        public void Hien()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("HỌ TÊN HỌC SINH{0}", hoten);
            Console.WriteLine("ĐIỂM TOÁN{0} ", diemtoan);
            Console.WriteLine("ĐIỂM LÍ{0} ", diemli);
            Console.WriteLine("ĐIỂM HÓA", diemhoa);
        }
        public double TB()
        {
            double tb = 0;
            tb = (diemtoan + diemli + diemhoa) / 3;

            return tb;

        }
        public void kt()
        {
            if (TB() <= 5)
                Console.WriteLine("thi lại!!");
            else
            {
                Console.WriteLine("không phải thi lại!");
            }

        }

    }
    class QLHS
    {
        private HocSinh[] ds;
        private int sLhs;
        public void Nhap()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write(" SỐ LƯỢNG HỌC SINH: ");
            sLhs = int.Parse(Console.ReadLine());
            Console.WriteLine();
            ds = new HocSinh[sLhs];
            for (int i = 0; i < sLhs; ++i)
            {
                ds[i] = new HocSinh();
                ds[i].Nhap();
            }
        }
        public void Hien()
        {
            if (ds == null)
                Console.WriteLine("CHUA NHAP HOC SINH NAO VAO DANH DACH");
            else
            {
                Console.WriteLine("DANH SACH CAC HOC SINH!");
                for (int i = 0; i < sLhs; ++i)
                    ds[i].Hien();
            }

        }
        public void KiemTraHS()
        {
            if (ds == null)
                Console.WriteLine("CHUA NHAP HOC SINH NAO DANH SACH");
            else
            {
                Console.WriteLine("DANH SACH HOC SINH PHAI THI LAI");
                for (int i = 0; i < sLhs; ++i)
                    ds[i].kt();    
            }

        }

    }

    class programt
    {
        static void Main4(string[] args)
        {
            QLHS hs = new QLHS();
            Console.WriteLine(" thông tin cần thiết của học sinh!");
            hs.Nhap();
            hs.Hien();
            Console.ReadKey();
        }
    }
}
