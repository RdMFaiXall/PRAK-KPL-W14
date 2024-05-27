// See https://aka.ms/new-console-template for more information

namespace MODUL05_1302220093.ProgramMain
{
    // Class dengan generic
    public class SimpleDataBase<T>
    {
        List<T> storedData;
        List<DateTime> inputDates;

        // Constructor untuk SimpleDataBase agar list storedData dan list inputDates kosong
        public SimpleDataBase()
        {
            this.storedData = new List<T>();
            this.inputDates = new List<DateTime>();
        }

        // Method untuk menerima dan memasukkan data ke list
        public void AddNewData(T iniData)
        {
            this.storedData.Add(iniData);
            this.inputDates.Add(DateTime.Now);
        }

        // Method untuk menampilkan 3 data 2 digit nim pada console sebanyak yang terdapat pada list
        public void PrintAllData()
        {
            for (int i = 0; i < storedData.Count; i++)
            {
                Console.WriteLine("Data " + (i + 1) + " berisi : " + storedData[i] + ", yang disimpan pada waktu UTC: " + inputDates[i]);
            }
        }
    }

    public class Penjumlahan
    {
        // Method dengan Generic parameter T
        public void JumlahTigaAngka<T>(T inputA, T inputB, T inputC)
        {
            // 3 variabel tipe data dynamic untuk menampung inputan 
            dynamic nilaiSatu = inputA;
            dynamic nilaiDua = inputB;
            dynamic nilaiTiga = inputC;

            // Konversi menjadi tipe data double
            double hasilPenjumlahan = nilaiSatu + nilaiDua + nilaiTiga;
            Console.WriteLine("Hasil : " + hasilPenjumlahan);
        }

        public static void Main(string[] args)
        {
            // Object untuk run class Penjumlahan
            Penjumlahan penjumlahan = new Penjumlahan();
            Console.WriteLine("Masukkan 3 Angka : ");
            double firstNum = float.Parse(Console.ReadLine());
            double secondNum = float.Parse(Console.ReadLine());
            double thirdNum = float.Parse(Console.ReadLine());
            penjumlahan.JumlahTigaAngka(firstNum, secondNum, thirdNum);
            Console.WriteLine(" ");

            // Object untuk eksekusi Class SimpleDataBase
            SimpleDataBase<double> dataBase = new SimpleDataBase<double>();
            dataBase.AddNewData(firstNum);
            dataBase.AddNewData(secondNum);
            dataBase.AddNewData(thirdNum);
            dataBase.PrintAllData();
        }
    }
}