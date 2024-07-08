##  HOTCAT CAFE Project

###- Code first yöntemi ile Ntier Katmanlý Mimari kullanýlarak yazýlacak.CodeFirst kullanýlmasýnýn nedeni bu projenin ilk defa oluþturuluyor olmasýndan kaynaklý olarak elimizde herhangi bir veri tabanýnýn bulunmamasý. Bu projeyi DbFirst ile de oluþturulmaya baþlanamsýnda da herhsngi bir sakýnca yoktur. Projeye DbFirst ile baþlayýp CodeFirst ile devam edilebilirdi. 
- NTier mimarisini kullanma amacým projenin daha modüler, geliþime açýk olmasýdýr.

- Baþlanýçte 3 katmandan meydana gelecek.Bunlar DAL-BLL-UI katmanlarýdýr. Ýhtiyaca yönelik ekstra katmanlar dahil edilecektir. MVC,Model vs gibi.

	- Model: Model katmaný dal katmanýnda varlýklarý temsil eden Entity'leri barýndýran katmandýr.Projemizde olmasýný istediðimiz projenin ihtiyacý olan entityler bu katmanda oluþturulur.Ýhtiyaca göre ilerleyen zamanlarda yeni entityler eklenebilir.
		- Base: Interface'den almýþ olduðu özellikleri bünyesine dahil eder.
			-BaseEntity:Entitylere içinde barýndýrdýðý property'leri miras(inheritance) býrakmasý için oluþturulacaktýr.Genel bir tabir ile bizim öncü entity'miz diyebiliriz.Projenin geliþime açýk olmasý Yani SOLID prensiperinden ilki olan Single Responsibility Principle'e uygun olmasý adýna bu þekilde oluþturulacaktýr.
		- Entities: Veritabanýnda olmasýný istediðimiz tablolarý temsil eder.
			- AppUser
			- AppUserRole
			- Category
			- Product
			- Order
			- OrderDetail



		- Enums: Tablolarda kullanýlacak sabitleri temsil eder.
		- Interfaces: Bütün classlara öncülük edek özellikleri barýndýrýr.

	- DAL (Data Access Layer): Veritabanýna ulaþým katmanýný temsil eder. Veritabaný ile ilgili nesnelerimiz, tasarým desenleri, Entity gibi varlýklar bu katman içerisinde kullanýlmalýdýr.
		- Context: Veritabaný nesnesini temsil eder.


	- BLL (Business Logic Layer): Ýþ mantýðý katmaný olarak kullanýlacaktýr. Kullanýcýn talep ettiði iþlemler ilk olarak bu katman tarafýndan karþýlanacak. Repository ve Service bu katman içerisinde oluþturulacak.
		--Repositories
			--Abstracts
				--BaseAbstracts
					-IRepository: Bu interface bütün iþlemlere öncülük edecek metotlarýn kurallarýný barýndýrmaktadýr. (CRUD) Interface dýþarýdan bir T alýr.
		--Concretes
			--BaseConcrete
				--BaseRepository: IRepository'den miras alara eylemleri (metotlarý) somut hale dönüþtüren class.. Dýaþrýdan bir T alýr

	Yukarýdaki tanýmlamalarda bulunan T tipleri Ayrý bir servis oluþturulacak. Bu kurallarý bünyesine alýr. Bu kurallara göre spesifik eylemleri gerçekleþtirir. Örneðin CategoryService'de gerçekleþtirildiði gibi. (Bknz. CategoryService)
			

	- UI (User Interface): Sunum katmanýný temsil eder. 
		- MVC projesi bu katman içerisinde oluþturulacak. 
		- Console App
		- WebApi

    - Common (Ortak Katman): Ýlerleyen etaplarda projenin daha esnek olabilmesi için her bir katmanda ortak olarak kullanýlacak iþlemler/yapýlar bu katmanda yer almaktadýrlar.
		--ImageHelper: Ýeçrisinde bulunan static metot vasýtasýyla dýaþrýdan iletilen dosyanýn bir görsel olup olmadýðýný kontrol edilmesini ardýndan bu görselin projeye dahil edilmesini gerçekleþtirir.


#SMTP Ayarlarý
Email: yzl3172@outlook.com
Pass: YzlKadikoy--