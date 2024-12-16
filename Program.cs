namespace VizeHesaplayıcı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Program akışını burada başlat
            ÖğrenciNotHesaplama();
            static void ÖğrenciNotHesaplama()
            {
                // Öğrencinin adı
                Console.Write("Öğrencinin adını girin: ");
                string studentName = Console.ReadLine();

                // Ders notlarını al
                Console.Write("Vize notunu girin (0-100): ");
                double midtermGrade = Convert.ToDouble(Console.ReadLine());

                Console.Write("Final notunu girin (0-100): ");
                double finalGrade = Convert.ToDouble(Console.ReadLine());

                // Ortalama hesapla
                double average = (midtermGrade * 0.4) + (finalGrade * 0.6);

                // Başarı kategorisini belirle
                string gradeCategory = "";

                if (average >= 90)
                {
                    gradeCategory = "A (Mükemmel)";
                }
                else if (average >= 80)
                {
                    gradeCategory = "B (Çok İyi)";
                }
                else if (average >= 70)
                {
                    gradeCategory = "C (İyi)";
                }
                else if (average >= 60)
                {
                    gradeCategory = "D (Geçer)";
                }
                else
                {
                    gradeCategory = "F (Kaldı)";
                }

                // Sonuçları göster
                Console.WriteLine("\n--- Öğrenci Notları ---");
                Console.WriteLine($"Öğrenci Adı: {studentName}");
                Console.WriteLine($"Vize Notu: {midtermGrade}");
                Console.WriteLine($"Final Notu: {finalGrade}");
                Console.WriteLine($"Ortalama: {average}");
                Console.WriteLine($"Başarı Kategorisi: {gradeCategory}");

                // Programı bitir
                Console.WriteLine("\nBaşka bir öğrenci kaydetmek ister misiniz? (Evet/Hayır)");
                string choice = Console.ReadLine().ToLower();

                if (choice == "evet")
                {
                    ÖğrenciNotHesaplama(); // Yeniden başlat, parametresiz çağrı
                }
                else
                {
                    Console.WriteLine("Program sonlanıyor...");
                }
            }
        }
    }
}
