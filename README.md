# CodeFirstDatabaseCreation
### CodeFirstDatabaseCreation with EntityFramework

- ORM klasörü altında Context ve Entity klasörleri oluşturulur

- Entity altında baseclass ve diğer classları tanımlanır

- EntityFramework yüklemek için;
	* Nuget Packet Manager açılır
	* Browse tıklanır
	* EntityFramework seçilir 
	* Install 
	* Ok
	* I Accept
	* Reference kısmına gelen entityframework kontrol edilir
	
- Context altına AppDBContext classı oluşturulur

- Classa "using System.Data.Entity;" kütüphanesini eklenir

- DBContext classını miras olarak verilir

- Constructor açılır

- Database propertysi kullanılarak connection string yazılır;

	* Database ismini kendimiz veriyoruz.
	
	* string içerisinde Çift \\ kullanılır
Örnek;	
` Database.Connection.ConnectionString = "Server=ExampleServerName;Database=CodeFirstDb;Trusted_Connection=True;";`

- Tabloya dahil edilmek istenen classlar için dbset<> tipinde propertyler oluşturulur.

```
	public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
```

- Tools> Nuget Packet Manager> Console açılır.

- Migration işlemini aktif hale getirmek için; 

	* enable-migrations komutu yazıp entera basılır
	
	* Migrations klasörü ve Configiration classı otomatik oluşur.
	
	* Configuration classı constructorunda `AutomaticMigrationsEnabled = true;` yapılır.
	
	* Console'da update-database komutu yazılır entera basılır.

### Veritabanı oluşmuş olur
