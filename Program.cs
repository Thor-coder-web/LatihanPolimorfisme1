ImageProcessor imageProcessor = new ImageProcessor();

imageProcessor.Resize(-5);
imageProcessor.Resize(80);
imageProcessor.Resize(100);
imageProcessor.Resize(200);
imageProcessor.Resize(400, 600);
imageProcessor.Resize("A4");



class ImageProcessor
{
    public void Resize(int persen)
    {
        if (persen <= 0 )
        {
            Console.WriteLine("Eoror! Persentase tidak boleh nol atau negatif");
        }
        else if (persen < 100)
        {
            Console.WriteLine($"Menagecilkan gambar sebesar {persen}% ");
        }
        else if (persen > 100)
        {
            Console.WriteLine($"Memperbesar gambar sebesar {persen}% ");
        }
        else
        {
            Console.WriteLine("Ukuran tetap (100%) tidak ada perubahan");
        }

    }

    public void Resize (int panjang, int lebar)
    {
        Console.WriteLine($"Mengubah ukuran gambar menjadi {panjang}px X {lebar}px ");
    }

    public void Resize (string ukuranKertas)
    {
        Console.WriteLine($"Menyesuaikan ke format kertas {ukuranKertas}");
    }
}