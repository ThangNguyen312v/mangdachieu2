using System;
namespace tinhtong2{
    class program{
        static void Main(string[] Args){
            int[,] nums;
            Console.WriteLine("nhap size: ");
            int size = Int32.Parse(Console.ReadLine());

            nums = new int[size,size];
             for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("Nhap gia tri cho phan tu: ");
                    nums[i, j] = Int32.Parse(Console.ReadLine());
                }

        }
        int tong = 0;
         for (int i = 0; i < size; i++)
            {
                tong += nums[i, i];
            }
            Console.WriteLine("tong cua duong cheo la: " + tong);
    }
    }
}
    

    
