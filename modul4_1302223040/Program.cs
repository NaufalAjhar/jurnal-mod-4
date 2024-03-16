public class KodeBuah
{
    public enum NamaBuah
    {
        Apel, Aprikot, Alpukat, Pisang, Paprika, Blackberry, Ceri, Kelapa, Jagung    
    }

    public static String getKodebuah(NamaBuah namaBuah)
    {
        String[] KodeBuah =
        {
            "A00", "B00", "C00", "D00", "E00", "F00", "H00", "I00", "J00"
        };

        return KodeBuah[(int)namaBuah];
    }
}

internal class Progam
{
    static void Main(String[] args)
    {
        Console.WriteLine("Kode buah: " + KodeBuah.getKodebuah(KodeBuah.NamaBuah.Paprika));

    }

}
