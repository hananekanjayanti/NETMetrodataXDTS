using System;

namespace MetrodataxDTS
{
    internal class Program
    {
        static int gajibersih(int tunjangannikah, int gaji, int tunjanganmasa)
        {
            int jumlah = gaji + tunjanganmasa + tunjangannikah;
            return jumlah;
        }

        public static void Main(string[] args)
        {
            string nama, nip, status, gol;
            int masa, tunjangannikah = 0, gaji, tunjanganmasa = 0;

            Console.WriteLine("Selamat datang di layanan hitung gaji PT.BUMI AIRLANGGA!");
            Console.WriteLine("\t\t\t______________________\t\t\t");
            Console.WriteLine("Masukan Nama : ");
            nama = Console.ReadLine();
            Console.WriteLine("Masukan NIP : ");
            nip = Console.ReadLine();
            Console.WriteLine("Tuliskan nominal gaji pokok (dalam Rupiah) :  ");
            gaji = int.Parse(Console.ReadLine());
            Console.WriteLine("Masukan Lama masa kerja (dalam tahun) : ");
            masa = int.Parse(Console.ReadLine());

            if(masa >= 5)
            {
                tunjanganmasa = 20 * gaji / 100;
            }

            Console.WriteLine("Pilih golongan pangkat anda sekarang: (1= Juru, 2= Pengatur, 3 = Penata, 4 = pembina) ");
            gol = Console.ReadLine();

            switch (gol)
            {
                case "1":
                case "Juru":
                    break;
                case "2":
                case "Pengatur":
                    break;
                case "3":
                case "Penata":
                    break;
                case "4":
                case "Pembina":
                    break;
                default:
                    Console.WriteLine("pilihan tidak valid ");
                    break;
            }

            Console.WriteLine("Apakah anda sudah menikah (y/n) : ");
            status = Console.ReadLine();
            status.ToLower();
            
            if(status == "y" || status == "ya" || status == " yes")
            {
                tunjangannikah = 10 * gaji / 100;
            }
            //gajitotalbersih = gaji + tunjanganmasa + tunjangannikah;

            int hasil = gajibersih(30000000, 500000, 2000000);

            Console.WriteLine("=================================== ");
            Console.WriteLine("Nama :  "+nama);
            Console.WriteLine("Gaji Pokok:  "+gaji);
            Console.WriteLine("Golongan : " + gol);
            Console.WriteLine("Tunjangan Nikah:  "+tunjangannikah);
            Console.WriteLine("Total Gaji Bersih:  "+hasil);
            Console.WriteLine("Terimakasih telah menggunakan layanan hitung gaji PT.BUMI AIRLANGGA!");

        }

    }
}
