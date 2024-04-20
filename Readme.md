# Sinema Bileti Rezervasyon Uygulaması
* Bu proje, sinema bileti rezervasyon bilgilerini SQLite veritabanı dosyasına kaydetme projesidir.
* Visual Studio 2022 (.Net SDK 8) ile yapılmıştır.
* Microsoft.EntityFrameworkCore.Sqlite (8.0.4) NuGet paketi yüklenmiştir.

# Proje Varlıkları
* DB => DB.db veritabanını içeren klasördür.
* Models => Film.cs, Salon.cs ve Seans.cs adlı dosyaları içeren klasördür.
* DB.db => Movie, MovieTheater, Session ve Customer tablolarını içeren veritabanıdır.
* Movie.cs => Movie veritabanı modeli için oluşturulan sınıftır.
* MovieTheater.cs => MovieTheater veritabanı modeli için oluşturulan sınıftır.
* Session.cs => Session veritabanı modeli için oluşturulan sınıftır.
* Customer.cs => Customer veritabanı modeli için oluşturulan sınıftır.
* DBContext.cs => DbContext sınıfını miras alan bir sınıftır. DbSet ve modelBuilder nesneleri için oluşturulan sınıftır.

* Not => DB.db veritabanı'nın DDL komutları DB\DB.sql dosyasına kayıt edilmiştir.

## Movie.cs
```
public int id { get; set; }
public string? movieName { get; set; }
public TimeSpan timeOne { get; set; }
public TimeSpan timeTwo { get; set; }
public TimeSpan timeThree { get; set; }
public TimeSpan timeFour { get; set; }
```
* public static bool control() => Boş alan kontrolü yapan ve girilen verilerin uygun olup olmadığını kontrol eden metotdur.
* public static void clear() => Form elemanlarının değerlerini başlangıç değerlerine döndüren metotdur.
* public static void saveDatas(Movie) => İlgili verileri veritabanına kayıt eden metotdur.
* public static void listDatas() => İlgili tablodan verileri çeken ve DataGridView nesnesinde listeleyen metotdur.

## MovieTheater.cs
```
public int id { get; set; }
public string? movieTheaterName { get; set; }
public int movieTheaterCapacity { get; set; }
```
* public static bool control() => Boş alan kontrolü yapan ve girilen verilerin uygun olup olmadığını kontrol eden metotdur.
* public static void clear() => Form elemanlarının değerlerini başlangıç değerlerine döndüren metotdur.
* public static void saveDatas(MovieTheater) => İlgili verileri veritabanına kayıt eden metotdur.
* public static void listDatas() => İlgili tablodan verileri çeken ve DataGridView nesnesinde listeleyen metotdur.

## Session.cs
```
public int id { get; set; }
public string? movieName { get; set; }
public string? movieTheaterName { get; set; }
public DateTime movieDate {  get; set; }
public TimeSpan movieTime { get; set; }
```
* public static bool control() => Boş alan kontrolü yapan ve girilen verilerin uygun olup olmadığını kontrol eden metotdur.
* public static void clear() => Form elemanlarının değerlerini başlangıç değerlerine döndüren metotdur.
* public static void saveDatas(Session) => İlgili verileri veritabanına kayıt eden metotdur.
* public static void listDatas() => İlgili tablodan verileri çeken ve DataGridView nesnesinde listeleyen metotdur.
* public static void fillMovie() => Film adlarını ComboBox nesnesinde listeleyen metotdur.
* public static void fillMovieTheaters() => Salon adlarını ComboBox nesnesinde listeleyen metotdur.
* public static void fillMovieTimes() => Film ismine göre film saatlerini ComboBox nesnesinde listeleyen metotdur.
* public static void fillSMovieDateDt() => Form başlatıldığında sMovieDateDt adlı DateTimePicker nesnesi'nin değerine mevcut günün tarih değerini aktaran metotdur.

## Customer.cs
```
public int id { get; set; }
public int sessionID { get; set; }
public string? customerName { get; set; }
public string? customerSurname { get; set; }
public string? customerIDNumber { get; set; }
public string? cardNumber { get; set; }
public int validityMonth { get; set; }
public int validityYear { get; set; }
public int securityCode { get; set; }
```
* public static bool control() => Boş alan kontrolü yapan ve girilen verilerin uygun olup olmadığını kontrol eden metotdur.
* public static void clear() => Form elemanlarının değerlerini başlangıç değerlerine döndüren metotdur.
* public static void saveDatas(Customer) => İlgili verileri veritabanına kayıt eden metotdur.
* public static void listDatas() => İlgili tablodan verileri çeken ve DataGridView nesnesinde listeleyen metotdur.
* public static void fillValidityMonthCombo() => validityMonthCombo adlı ComboBox nesnesine öğe (1'den 12'ye kadar olan sayılar) ekleyen metotdur.
* public static void fillValidityYearCombo() => validityYearCombo adlı ComboBox nesnesine öğe (geçerli günün yılı ve bu yıldan sonraki 4 yılı) ekleyen metotdur.

## DBContext.cs
```
public virtual DbSet<Movie> Movies { get; set; }
public virtual DbSet<MovieTheater> MovieTheaters { get; set; }
public virtual DbSet<Session> Sessions { get; set; }
public virtual DbSet<Customer> Customers { get; set; }
```
* protected override void OnConfiguring(DbContextOptionsBuilder) => Veritabanı bağlantı ayarlarını yapılandırmak için kullanılan metotdur.
* protected override void OnModelCreating(ModelBuilder) => Veritabanı modelini oluşturmak için kullanılan metotdur.

## Modeller

Projede 4 tane model oluşturulmuştur.

1. Movie
```
modelBuilder.Entity<Movie>(entity =>
{
    entity.ToTable("Movie");
    entity.HasKey(e => e.id);
    entity.Property(e => e.movieName).HasColumnType("TEXT");
    entity.Property(e => e.timeOne).HasColumnType("TIMESPAN");
    entity.Property(e => e.timeTwo).HasColumnType("TIMESPAN");
    entity.Property(e => e.timeThree).HasColumnType("TIMESPAN");
    entity.Property(e => e.timeFour).HasColumnType("TIMESPAN");
});
```

2. MovieTheater
```
modelBuilder.Entity<MovieTheater>(entity =>
{
    entity.ToTable("MovieTheater");
    entity.HasKey(e => e.id);
    entity.Property(e => e.movieTheaterName).HasColumnType("TEXT");
    entity.Property(e => e.movieTheaterCapacity).HasColumnType("INTEGER");
});
```

3. Session
```
modelBuilder.Entity<Session>(entity =>
{
    entity.ToTable("Session");
    entity.HasKey(e => e.id);
    entity.Property(e => e.movieName).HasColumnType("TEXT");
    entity.Property(e => e.movieTheaterName).HasColumnType("TEXT");
    entity.Property(e => e.movieDate).HasColumnType("DATETIME");
    entity.Property(e => e.movieTime).HasColumnType("TIMESPAN");
});
```

4. Customer
```
modelBuilder.Entity<Customer>(entity =>
{
    entity.ToTable("Customer");
    entity.HasKey(e => e.id);
    entity.Property(e => e.sessionID).HasColumnType("INTEGER");
    entity.Property(e => e.customerName).HasColumnType("TEXT");
    entity.Property(e => e.customerSurname).HasColumnType("TEXT");
    entity.Property(e => e.customerIDNumber).HasColumnType("TEXT");
    entity.Property(e => e.cardNumber).HasColumnType("TEXT");
    entity.Property(e => e.validityMonth).HasColumnType("INTEGER");
    entity.Property(e => e.validityYear).HasColumnType("INTEGER");
    entity.Property(e => e.securityCode).HasColumnType("INTEGER");
});
```

## Program.cs
```
public static HomePage homePage = new HomePage();
public const string pathDB = @"DB\DB.db";
```
* public static void Main() => Ana metotdur.
* public static bool existsDB() => Veritabanı dosyası'nın var olup olmadığını kontrol eden metotdur.
* Not => Form nesnelerine diğer sınıflardan erişebilmek için homePage nesnesi 'public static' tanımı ile oluşturulmuştur. Bu durum güvenlik açıklarına yol açabilir.

## HomePage
* Bir tane TabControl nesnesi kullanılmıştır.
* Dört tane TabPage (Movie Record Page, Movie Theater Record Page, Session Record Page, Customer Record Page) nesnesi kullanılmıştır.

## HomePage.cs
* private void saveMovieBtn_Click(object, EventArgs) => Boş alan kontrolü yapılır ve girilen verilerin uygun olup olmadığı kontrol edilir. Boş alan yok ise Movie sınıfından bir nesne oluşturulur ve girilen veriler nesnede bulunan ilgili alanlara aktarılır. Daha sonra veriler Movie tablosuna kayıt edilir ve ilgili DataGridView nesnesinde listelenir. Session sayfasında bulunan, film adlarını listeleyen ComboBox nesnesinin öğreleri güncellenir. Boş alan var ise MessageBox nesnesi oluşturulur ve kullanıcıya hata mesajı görüntülenir.

* private void saveMovieTheaterBtn_Click(object, EventArgs) => Boş alan kontrolü yapılır ve girilen verilerin uygun olup olmadığı kontrol edilir. Boş alan yok ise MovieTheater sınıfından bir nesne oluşturulur ve girilen veriler nesnede bulunan ilgili alanlara aktarılır. Daha sonra veriler MovieTheater tablosuna kayıt edilir ve ilgili DataGridView nesnesinde listelenir. Session sayfasında bulunan, sinema salonu adlarını listeleyen ComboBox nesnesinin öğreleri güncellenir. Boş alan var ise MessageBox nesnesi oluşturulur ve kullanıcıya hata mesajı görüntülenir.

* private void saveSessionBtn_Click(object, EventArgs) => Boş alan kontrolü yapılır ve girilen verilerin uygun olup olmadığı kontrol edilir. Boş alan yok ise Session sınıfından bir nesne oluşturulur ve girilen veriler nesnede bulunan ilgili alanlara aktarılır. Daha sonra veriler Session tablosuna kayıt edilir ve ilgili DataGridView nesnesinde listelenir. Boş alan var ise MessageBox nesnesi oluşturulur ve kullanıcıya hata mesajı görüntülenir.

* private void saveCustomerBtn_Click(object, EventArgs) => Boş alan kontrolü yapılır ve girilen verilerin uygun olup olmadığı kontrol edilir. Boş alan yok ise Customer sınıfından bir nesne oluşturulur ve girilen veriler nesnede bulunan ilgili alanlara aktarılır. Daha sonra veriler Customer tablosuna kayıt edilir ve ilgili DataGridView nesnesinde listelenir. Boş alan var ise MessageBox nesnesi oluşturulur ve kullanıcıya hata mesajı görüntülenir.

* private void HomePage_Load(object, EventArgs) => homePage nesnesi başlatıldığında çalışır. Session sayfasında bulunan film adlarını ve salon adlarını listeleyen ComboBox nesnesine ilgili öğeleri ekler. Session sayfasında bulunan DateTimePicker nesnesi'nin değerine mevcut günün tarih değerini aktarır. Customer sayfasında bulunan, ay ve yıl için oluşturulan ComboBox nesnesine ilgili öğeleri ekler. Movie, MovieTheater, Session ve Custoemr sayfalarında bulunan DataGridView nesnelerine ilgili verileri ekler. Aşağıdaki metotları çalıştırır:
```
Session.fillMovie();
Session.fillMovieTheaters();
Session.fillSMovieDateDt();

Customer.fillValidityMonthCombo();
Customer.fillValidityYearCombo();

Movie.listDatas();
MovieTheater.listDatas();
Session.listDatas();
Customer.listDatas();
```

* private void HomePage_KeyDown(object, KeyEventArgs) => HomePage sayfasında herhangi bir tuşa basıldığında (tuşa basma süreci bittiğinde) tetiklenen metotdur. 'Escape' tuşuna basıldığında mevcut uygulamayı sonlandırır. Aşağıdaki kodu çalıştırır:
```
switch (e.KeyCode)
{
    case Keys.Escape:
        Application.Exit();
        break;
}
```

* private void datasMovie_DataBindingComplete(object, DataGridViewBindingCompleteEventArgs) => DB.db veritabanı dosyası'nın var olup olmadığını kontrol eder. Veritabanı dosyası var ise ilgili DataGridView nesnesinin sütun başlık isimlerini ayarlar. DataGridView nesnesi'nin ilk sütununu (id sütununu) gizler.

* private void datasMovieTheater_DataBindingComplete(object, DataGridViewBindingCompleteEventArgs) => DB.db veritabanı dosyası'nın var olup olmadığını kontrol eder. Veritabanı dosyası var ise ilgili DataGridView nesnesinin sütun başlık isimlerini ayarlar. DataGridView nesnesi'nin ilk sütununu (id sütununu) gizler.

* private void datasSession_DataBindingComplete(object, DataGridViewBindingCompleteEventArgs) => DB.db veritabanı dosyası'nın var olup olmadığını kontrol eder. Veritabanı dosyası var ise ilgili DataGridView nesnesinin sütun başlık isimlerini ayarlar. DataGridView nesnesi'nin ilk sütununu (id sütununu) gizler.

* private void datasSessions_DataBindingComplete(object, DataGridViewBindingCompleteEventArgs) => DB.db veritabanı dosyası'nın var olup olmadığını kontrol eder. Veritabanı dosyası var ise ilgili DataGridView nesnesinin sütun başlık isimlerini ayarlar. DataGridView nesnesi'nin ilk sütununu (id sütununu) gizler.

* private void sMovieNameCombo_SelectedIndexChanged(object, EventArgs) => Session sınıfında bulunan 'fillMovieTimes' adlı metodu çalıştırır.

# Nasıl Çalışır
1. Uygulama çalıştırıldığında Movie Record Page bölümü gelmektedir. Film adı ve film saat bilgisi (4 adet saat bilgisi) girilir. Save kısmına basılır. Veriler kayıt edilir ve listelenir.

2. Movie Theater Record Page bölümüne basılır. Salon adı ve salon kapasite bilgisi girilir. Save kısmına basılır. Veriler kayıt edilir ve listelenir.

3. Session Record Page bölümüne basılır. Film adı, salon adı, film tarihi ve film saat bilgisi seçilir. Save kısmına basılır. Veriler kayıt edilir ve listelenir.

4. Customer Record Page bölümüne basılır. İlgili DataGridView nesnesinden seans bilgisi seçilir. Müşteri adı, müşteri soyadı, müşteri kimlik numarası, kart numarası, kart'ın son kullanım tarihi ve kart güvenlik numarası bilgisi girilir. Save kısmına basılır. Veriler kayıt edilir.

# Önemli Notlar
* Not: Uygulamanın çalıştırıldığı dizinde 'DB\DB.db' veritabanı dosyasının, HomePage ve Microsoft.EntityFrameworkCore.Sqlite NuGet paketinin dll dosyalarının olması gerekmektedir.
* Not: Verilerin kayıt edilme veya listelenme aşamasında bir sorun ile karşılaşılır ise Try Catch bloğunun yakaladığı hata veya hatalar MessageBox nesnesi kullanılarak mesaj olarak kullanıcıya iletilecektir.
* Not: Session Record Page bölümünde film tarih bilgisi seçilirken; mevcut tarihinten önceki bir tarih seçilememektedir.
* Not: Customer Record Page bölümünde kart'ın son kullanım tarihi seçilirken; mevcut tarihin ay bilgisinden önceki aylar seçilememektedir.
* Not: Customer Record Page bölümünde kart'ın son kullanım tarihi seçilirken; mevcut tarihin yıl bilgisinden itibaren sonraki 4 yıl bilgisi listelenmektedir. Daha ileri bir tarih listelenmediğinden seçilememektedir.

# Kayıt Edilen Veriler
Movie tablosuna 5, MovieTheater tablosuna 5, Session tablosuna 5, Customer tablosuna 2 adet veri girişi yapılmıştır.
* Not => Seans oluştururken salon kapasiteleri 1 değer azaltılmıştır. 2 adet müşteri verisi eklendiği için 2 adet seans bilgisi DataGridView nesnelerinde listelenmemektedir.