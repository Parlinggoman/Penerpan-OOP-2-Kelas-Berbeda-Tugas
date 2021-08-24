using System;
using System.Collections.Generic;
using System.Text;

namespace AplikasiConsoleOop
{
    class Hewan
    {
        public string id { get; set; }
        public string jenisHewan { get; set; }
        public string nama { get; set; }
        public string tinggi { get; set; }
        public int jumlahKaki { get;  set; }
        public string warnaBulu { get; set; }
        public string riwayatPenyakit { get; private  set; }
      //  public int jumlahPasangKaki { get; set; }

       

        public void DataHewan()
        {
            Console.WriteLine("Data Hewan Berhasil Dibuat");
        }
        public void IdHewan()
        {
            Console.WriteLine($"ID Hewan :{this.id}");
        }

        public void TampilkanJenisHewan()
        {
            Console.WriteLine($"Jenis Hewan : {this.jenisHewan}");
        }
        public void NamaHewanPeliharaan()
        {
            Console.WriteLine($"Nama Hewan :{this.nama}");
        }
        public  void TinggiHewanPeliharaan()
        {
            Console.WriteLine($"Tinggi Hewan : {this.tinggi}");
        }
        public int BerapaJumlahPasangKaki()
        {
            int jumlahPasangKaki = this.jumlahKaki / 2;
            return jumlahPasangKaki;
        }
        public void WarnaBuluHewanPeliharaan()
        {
            Console.WriteLine($"Warna Hewan : {this.warnaBulu}");
        }
        public void RiwayatPenyakitHewan( )
        {
            Console.WriteLine($"Riwayat Penyakit Hewan: {this.riwayatPenyakit}");
        }
       
       // public Hewan()
        //{
          //  Console.WriteLine("Object Berhasil Dibuat");
            //Id = id;
            //JenisHewan = jenisHewan;
            //NamaHewan = namaHewan;
            //TinggiHewan = tinggiHewan;
            //JumlahKaki = jumlahKaki;
            //WarnaBulu = jenisHewan;
            //RiwayatPenyakit = riwayatPenyakit;
            //JumlahPasangKaki = jumlahPasangKaki;
                                              
        //}
        //public Hewan(string id)
        //{
         //   Id = id;
        //}
        public void ShowData()
        {
           Console.WriteLine("===== Data Hewan Berhasil di Buat =====");
           Console.WriteLine($"ID : {id}");
           Console.WriteLine($"Nama Hewan : {nama}");
           Console.WriteLine($"Jenis Hewan : {jenisHewan}");
           Console.WriteLine($"Tinggi Hewan : {tinggi}");
           Console.WriteLine($"Warna Hewan : {warnaBulu}");
           Console.WriteLine($"Jumlah Pasang Kaki : {jumlahKaki/2}");
           Console.WriteLine($"Penyakit : {riwayatPenyakit}");

        }
       
    }
}
