using Pratik_PatikaKutuphane;

// New: 'new' anahtar kelimesi, bir sınıftan yeni bir nesne oluşturmak için kullanılır.
// Burada Book sınıfından yeni bir nesne oluşturuyoruz.

// Default constructor kullanarak kitap oluşturma
Book book1 = new Book();
book1.Name = "Adı Aylin";
book1.AuthorName = "Ayşe";
book1.AuthorSurname = "Kulin";
book1.PageCount = 398;
book1.Publisher = "Remzi Kitabevi";
book1.DisplayBookInfo();

Console.WriteLine("--------------------");

// Parameterized constructor kullanarak kitap oluşturma
// Bu, nesne oluşturma sırasında özellikleri atamamızı sağlar.
Book book2 = new Book("Başka Bir Kitap", "Orhan", "Pamuk", 350, "İletişim Yayınları");
book2.DisplayBookInfo();