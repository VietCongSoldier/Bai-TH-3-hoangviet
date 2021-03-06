﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Bai1_BaiTH3 // bài 1-BTH3
{
    class phanso
    {
        private int ts, ms;
        public phanso()
        {
            ts = 0; ms = 1;
        }
        public phanso(int ts, int ms)
        {
            this.ts = ts;
            this.ms = ms;
        }

        public void Nhap()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("xin mời nhập tử số: ");
            ts = int.Parse(Console.ReadLine());
            Console.Write("xin mời nhập mẫu số: ");
            ms = int.Parse(Console.ReadLine());
        }
        public void Hien()
        {
            if (ms == 1)
                Console.WriteLine(ts);
            else
                Console.WriteLine("{0}/{1}", ts, ms);
        }
        public int Ucln(int x, int y)
        {
            x = Math.Abs(x); y = Math.Abs(y);
            while (x != y)
            {
                if (x > y) x = x - y;
                if (y > x) y = y - x;
            }
            return x;
        }
        public phanso ToiGian()
        {
            int uc = Ucln(this.ts, this.ms);
            this.ts = this.ts / uc;
            this.ms = this.ms / uc;
            return this;
        }
        public static phanso operator +(phanso t1, phanso t2)
        {
            phanso Tong = new phanso();
            Tong.ts = t1.ts * t2.ms + t2.ts * t1.ms;
            Tong.ms = t2.ms * t1.ms;
            Tong.ToiGian();
            return Tong;
        }
        public phanso Cong(phanso b)
        {
            phanso Tong = new phanso();
            Tong.ts = this.ts * b.ms + b.ts * this.ms;
            Tong.ms = this.ms + b.ms;
            Tong.ToiGian();
            return Tong;
        }
        public static phanso operator -(phanso t1, phanso t2)
        {
            phanso hieu = new phanso();
            hieu.ts = t1.ts * t2.ms - t2.ts * t1.ms;
            hieu.ms = t2.ms * t1.ms;
            hieu.ToiGian();
            return hieu;
        }
        public phanso Hieu(phanso b)
        {
            phanso hieu = new phanso();
            hieu.ts = this.ts * b.ms - b.ts * this.ms;
            hieu.ms = this.ms + b.ms;
            hieu.ToiGian();
            return hieu;
        }
    }
    class test
    {
        static void Main1()
        {
            Console.OutputEncoding = Encoding.UTF8;
            phanso t1 = new phanso();
            phanso t2 = new phanso();
            Console.WriteLine("kết quả tính của hai phân số vừa nhập :");
            Console.WriteLine();
            Console.WriteLine("Tổng hai phân số");
            phanso T = t1.Cong(t2);
            T.Hien();
            Console.WriteLine("Hiệu hai phân số:");
            phanso TH = t1.Hieu(t2);
            TH.Hien();
            Console.ReadKey();
        }
    }
}
