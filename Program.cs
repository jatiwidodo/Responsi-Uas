using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCustomer
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek customer
        static List<Customer> daftarCustomer = new List<Customer>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahCustomer();
                        break;

                    case 2:
                        HapusCustomer();
                        break;

                    case 3:
                        TampilCustomer();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            Console.WriteLine("Pilih Menu Aplikasi\n\n1. Tambah Customer\n2. Hapus Costumer\n3. Tampilkan Customer\n4. Keluar");
        }

        static void TambahCustomer()
        {
            Console.Clear();

            Console.WriteLine("Tambah Data Customer\n\n");
            Customer newCustomer = new Customer();
            Console.Write("Kode Customer: ");
            newCustomer.KodeCust = Console.ReadLine();
            Console.Write("Nama Customer: ");
            newCustomer.NamaCust = Console.ReadLine();
            Console.Write("Total Piutang: ");
            newCustomer.TotalPiutang = Convert.ToInt32(Console.ReadLine());

            daftarCustomer.Add(newCustomer);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusCustomer()
        {
            Console.Clear();

            Console.Write("Masukkan kode customer: ");
            string inputKode = Console.ReadLine();

            List<int> totalFound = new List<int>();
            int index = 0;
            foreach (Customer findCust in daftarCustomer)
            {
                if (findCust.KodeCust == inputKode)
                {
                    totalFound.Add(index);
                }
                index++;
            }
            if (totalFound.Count == 0)
            {
                Console.WriteLine("\nKode Customer tidak ditemukan");
            }
            else
            {
                for (int i = totalFound.Count; i > 0; i--)
                {
                    daftarCustomer.RemoveAt(totalFound[i - 1]);
                }

                Console.WriteLine("\nData Customer berhasil dihapus");
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilCustomer()
        {
            Console.Clear();

            Console.WriteLine("Data Customer\n\n");
            int index = 0;
            foreach (Customer printCust in daftarCustomer)
            {
                Console.WriteLine("{0}. {1}, {2}, {3}", index + 1, printCust.KodeCust, printCust.NamaCust, printCust.TotalPiutang);
                index++;
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}