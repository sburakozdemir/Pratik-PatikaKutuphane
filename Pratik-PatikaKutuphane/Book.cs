using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik_PatikaKutuphane
{
    // Class (Sınıf): Book bir sınıftır. Sınıflar, nesnelerin şablonlarıdır ve 
    // nesnelerin özelliklerini ve davranışlarını tanımlar.
    public class Book
    {
        // Property (Özellik): Aşağıdaki özellikler, bir kitabın karakteristiklerini temsil eder.
        // Bu özellikler, sınıfın verileridir.
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public string AuthorSurname { get; set; }
        public int PageCount { get; set; }
        public string Publisher { get; set; }
        public DateTime RegistrationDate { get; private set; }

        // Constructor (Yapıcı): Constructorlar, bir nesne oluşturulduğunda çağrılan özel metotlardır.
        // Default constructor
        public Book()
        {
            Name = string.Empty;
            AuthorName = string.Empty;
            AuthorSurname = string.Empty;
            PageCount = 0;
            Publisher = string.Empty;
            RegistrationDate = DateTime.Now;
        }

        // Parameterized constructor
        public Book(string name, string authorName, string authorSurname, int pageCount, string publisher)
        {
            Name = name;
            AuthorName = authorName;
            AuthorSurname = authorSurname;
            PageCount = pageCount;
            Publisher = publisher;
            RegistrationDate = DateTime.Now;
        }

        // Method to display book information
        public void DisplayBookInfo()
        {
            Console.WriteLine($"{AuthorName} {AuthorSurname}'in {PageCount} sayfalık, {Publisher} yayınevinden çıkan {Name} kitabı {RegistrationDate} tarihinde kaydedildi.");
        }
    }
}