# CodeFirstDatabaseCreation
### CodeFirstDatabaseCreation with EntityFramework

- ORM klasörü altında Context ve Entity klasörleri oluştur

- Entity altında baseclass ve diğer classları tanımla

- EntityFramework yükle
	* Nuget Packet Manager aç
	* Browse tıkla
	* EntityFramework seç 
	* Install
	* Ok
	* I Accept
	* Reference kısmına gelen entityframework kontrol et
- Context altına AppDBContext classı oluştur

- Classa "using System.Data.Entity;" kütüphanesini ekle

- DBContext classını miras olarak ver

- Constructor açılır

- Database propertysi kullanılarak connection string yazılır;

	* Database ismini kendimiz veriyoruz.
	
	* string içerisinde Çift \\ kullanılır
	
` Database.Connection.ConnectionString = "Server=ExampleServerName;Database=CodeFirstDb;Trusted_Connection=True;";`

- Tabloya dahil edilmek istenen classlar için dbset<> tipinde propertyler oluşturulur.

```
	public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
```

- Tools> Nuget Packet MAnager> Console açılır.

- Migration işlemini aktif hale getirmek için; 

	* enable-migrations komutu yazıp entera basılır
	
	* Migrations klasörü ve Configiration classı otomatik oluşur.
	
	* Configuration classı constructorunda `AutomaticMigrationsEnabled = true;` yapılır.
	
	* Console'da update-database komutu yazılır entera basılır.
