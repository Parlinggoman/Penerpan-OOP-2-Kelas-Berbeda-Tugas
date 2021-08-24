using System;

namespace AplikasiConsoleOop
{
    class Program
    {
        static void Main(string[] args)
        {
           
           
            
            Hewan e1 = new Hewan();
            e1.id = "H001";
            e1.jenisHewan = "Mamalia";
            e1.nama = "Sapi";
            e1.tinggi = "200 CM" ;
            e1.jumlahKaki = 4;
            e1.warnaBulu = "Campuran Hitam dan Putih";
            // e1.riwayatPenyakit = "Nafsu Makan Berkurang dan Muntah-Muntah";
            e1.BerapaJumlahPasangKaki();
            //char[] characters = e1.nama.ToCharArray();



            PemilikHewan p1 = new PemilikHewan();
            p1.id = "P002";
            p1.nama = "Karrie";
            p1.tinggi = "172 CM" ;
            p1.noHp = "081533184602";
            p1.alamat = "Jl.DuriKosambi";
            p1.jumlahKaki= 2;
            p1.BerapaJumlahPasangKaki();
            p1.id = e1.id;
            //p1.riwayatPenyakit = "Sehat";


          //Console.WriteLine($"Data Hewan dengan ID :{e1.id} Nama Hewan: {e1.nama}" +
            //    $" Jenis Hewan : {e1.jenisHewan}" +
             //   $" Warna Bulu Sapi : {e1.warnaBulu} Penyakit Hewan : {e1.riwayatPenyakit} " +
              //  $"Jumlah Pasang Kaki: {e1.BerapaJumlahPasangKaki()}");
           
           e1.ShowData();
           p1.DataPemilik();
           
        }
        
    }
}
