using System;
using System.Collections.Generic;
using System.Text;

namespace AplikasiConsoleOop
{
    class PemilikHewan : Hewan
    {
       // public string idPemilikHewan { get; set; }
//public string namaPemilik { get; set; }
        public string noHp { get; set; }
        public string alamat { get;  set; }

        public void KepemilikanHewan()
        {
            Console.WriteLine("===== Data Pemilik Hewan =====");
        }
       // public void Id()
       // {
       //     Console.WriteLine($"ID Pemilik Hewan : {this.idPemilikHewan}");
      //  }
      //  public void NamaPemilik()
      //  {
        //    Console.WriteLine($"Nama Pemilik Hewan : {this.namaPemilik}");
      //  }
        public void NoHP()
        {
            Console.WriteLine($"No Hanphone Pemilik Hewan: {this.noHp}");
        }
        public void Alamat()
        { 
            Console.WriteLine(  $"Alamat Pemilik Hewan : {this.alamat}");
        }

        public void DataPemilik( )
        {
            Console.WriteLine("===== DATA PEMILIK HEWAN =====");
            Console.WriteLine($"ID Pemilik Hewan: {id}");
            Console.WriteLine($"Nama Pemilik Hewan : {nama}");
                Console.WriteLine(  $"Tinggi Pemilik :{tinggi}");
            Console.WriteLine($"No Hanphone Pemilik Hewan: {noHp}");
            Console.WriteLine($"Alamat Pemilik Hewan : {alamat}");
            Console.WriteLine($"Jumlah Kaki : {jumlahKaki}");
            Console.WriteLine($"Jumlah Pasang Kaki :{BerapaJumlahPasangKaki()}");
            Console.WriteLine($"ID Hewan : {id}");
            Console.WriteLine($"Riwayat Penyakit Peliharaan :  {riwayatPenyakit}");
        }

    }
   
}
