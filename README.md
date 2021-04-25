# ReCapProject

- ÖDEV 1 - 

Kampımızla beraber paralelde geliştireceğimiz bir projemiz daha olacak. Araba kiralama sistemi yazıyoruz.

Yepyeni bir proje oluşturunuz. Adı ReCapProject olacak. (Tekrar ve geliştirme projesi)

Entities, DataAccess, Business ve Console katmanlarını oluşturunuz.

Bir araba nesnesi oluşturunuz. "Car"

Özellik olarak : Id, BrandId, ColorId, ModelYear, DailyPrice, Description alanlarını ekleyiniz. (Brand = Marka)

InMemory formatta GetById, GetAll, Add, Update, Delete oprasyonlarını yazınız.

Consolda test ediniz.

Önemli: Copy-Paste yasak fakat kamp projesinden destek almak serbest.

----------

- ÖDEV 2 - 

Araba Kiralama projemiz üzerinde çalışmaya devam edeceğiz.

Car nesnesine ek olarak;

1) Brand ve Color nesneleri ekleyiniz(Entity)

Brand-->Id,Name

Color-->Id,Name

2) Sql Server tarafında yeni bir veritabanı kurunuz. Cars,Brands,Colors tablolarını oluşturunuz. (Araştırma)

3) Sisteme Generic IEntityRepository altyapısı yazınız.

4) Car, Brand ve Color nesneleri için Entity Framework altyapısını yazınız.

5) GetCarsByBrandId , GetCarsByColorId servislerini yazınız.

6) Sisteme yeni araba eklendiğinde aşağıdaki kuralları çalıştırınız.

Araba ismi minimum 2 karakter olmalıdır

Araba günlük fiyatı 0'dan büyük olmalıdır.

-----------
- ÖDEV 3 -

Önerim aşağıdaki gibi yeniden yapmanızdır.

CarRental Projenizde Core katmanı oluşturunuz.
IEntity, IDto, IEntityRepository, EfEntityRepositoryBase dosyalarınızı 9. gün dersindeki gibi oluşturup ekleyiniz.
Car, Brand, Color sınıflarınız için tüm CRUD operasyonlarını hazır hale getiriniz.
Console'da Tüm CRUD operasyonlarınızı Car, Brand, Model nesneleriniz için test ediniz. GetAll, GetById, Insert, Update, Delete.
Arabaları şu bilgiler olacak şekilde listeleyiniz. CarName, BrandName, ColorName, DailyPrice. (İpucu : IDto oluşturup 3 tabloya join yazınız)

------------
- ÖDEV 4 - 

Car Rental Projenizde;

Core katmanında Results yapılandırması yapınız.
Daha önce geliştirdiğiniz tüm Business sınıflarını bu yapıya göre refactor (kodu iyileştirme) ediniz.

------------

- ÖDEV 5 - 

CarRental projenizde;

1- Kullanıcılar tablosu oluşturunuz. Users-->Id,FirstName,LastName,Email,Password

2- Müşteriler tablosu oluşturunuz. Customers-->UserId,CompanyName

*****Kullanıcılar ve müşteriler ilişkilidir.

3- Arabanın kiralanma bilgisini tutan tablo oluşturunuz. Rentals-->Id, CarId, CustomerId, RentDate(Kiralama Tarihi), ReturnDate(Teslim Tarihi). Araba teslim edilmemişse ReturnDate null'dır.
4- Projenizde bu entity'leri oluşturunuz.

5- CRUD operasyonlarını yazınız.

6- Yeni müşteriler ekleyiniz.

7- Arabayı kiralama imkanını kodlayınız. Rental-->Add

Arabanın kiralanabilmesi için arabanın teslim edilmesi gerekmektedir.

------------

- ÖDEV 6 - 

CarRental projenizde;

WebAPI katmanını kurunuz.
Business katmanındaki tüm servislerin Api karşılığını yazınız.
Postman'de test ediniz.
Kodlarınızı paylaşınız.

------------

- ÖDEV 7 - 

1- Car Rental Projenize Autofac desteği ekleyiniz. 

2- Car Rental Projenize FluentValidation desteği ekleyiniz.

3- Car Rental Projenize AOP desteği ekleyiniz. ValidationAspect ekleyiniz.

-----------

- ÖDEV 8 - 

RentACar projenizde;

CarImages (Araba Resimleri) tablosu oluşturunuz. (Id,CarId,ImagePath,Date) Bir arabanın birden fazla resmi olabilir.
Api üzerinden arabaya resim ekleyecek sistemi yazınız.
Resimler projeniz içerisinde bir klasörde tutulacaktır. Resimler yüklendiği isimle değil, kendi vereceğiniz GUID ile dosyalanacaktır.
Resim silme, güncelleme yetenekleri ekleyiniz.
Bir arabanın en fazla 5 resmi olabilir.
Resmin eklendiği tarih sistem tarafından atanacaktır.
Bir arabaya ait resimleri listeleme imkanı oluşturunuz. (Liste)
Eğer bir arabaya ait resim yoksa, default bir resim gösteriniz. Bu resim şirket logonuz olabilir. (Tek elemanlı liste)

-----------

-ÖDEV 9 - 

RentACar projenize JWT entegrasyonu yapınız.






