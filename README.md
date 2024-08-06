# Patika Kütüphane Projesi

Bu proje, Patika Kütüphanesi için basit bir kitap kayıt uygulaması oluşturmayı amaçlamaktadır. Uygulama, kitap nesneleri oluşturarak temel kitap bilgilerini kaydeder ve görüntüler.

## Özellikler

- Kitap bilgilerini (Ad, Yazar Adı, Yazar Soyadı, Sayfa Sayısı, Yayınevi) saklama
- Otomatik kayıt tarihi ataması
- İki farklı constructor ile nesne oluşturma imkanı
- Kitap bilgilerini görüntüleme

## Kullanım

Proje iki ana dosyadan oluşur:

1. `Book.cs`: Kitap sınıfının tanımlandığı dosya
2. `Program.cs`: Ana programın ve örnek kullanımın bulunduğu dosya

### Kitap Oluşturma

İki farklı yöntemle kitap oluşturabilirsiniz:

1. Default constructor kullanarak:

```csharp
Book book1 = new Book();
book1.Name = "Adı Aylin";
book1.AuthorName = "Ayşe";
book1.AuthorSurname = "Kulin";
book1.PageCount = 398;
book1.Publisher = "Remzi Kitabevi";
```

2. Parametreli constructor kullanarak:

```csharp
Book book2 = new Book("Başka Bir Kitap", "Orhan", "Pamuk", 350, "İletişim Yayınları");
```

### Kitap Bilgilerini Görüntüleme

Kitap bilgilerini görüntülemek için `DisplayBookInfo()` metodunu kullanabilirsiniz:

```csharp
book1.DisplayBookInfo();
```

## Önemli Kavramlar

Bu proje, nesne yönelimli programlamanın temel kavramlarını örneklemektedir:

- **Class (Sınıf)**: `Book` bir sınıftır. Sınıflar, nesnelerin şablonlarıdır.
- **Property (Özellik)**: `Name`, `AuthorName` gibi özellikler, bir kitabın karakteristiklerini temsil eder.
- **Constructor (Yapıcı)**: Nesnelerin nasıl oluşturulacağını belirleyen özel metotlardır.
- **New**: Yeni bir nesne oluşturmak için kullanılan anahtar kelimedir.
