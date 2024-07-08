##  HOTCAT CAFE Project

###- Code first y�ntemi ile Ntier Katmanl� Mimari kullan�larak yaz�lacak.CodeFirst kullan�lmas�n�n nedeni bu projenin ilk defa olu�turuluyor olmas�ndan kaynakl� olarak elimizde herhangi bir veri taban�n�n bulunmamas�. Bu projeyi DbFirst ile de olu�turulmaya ba�lanams�nda da herhsngi bir sak�nca yoktur. Projeye DbFirst ile ba�lay�p CodeFirst ile devam edilebilirdi. 
- NTier mimarisini kullanma amac�m projenin daha mod�ler, geli�ime a��k olmas�d�r.

- Ba�lan��te 3 katmandan meydana gelecek.Bunlar DAL-BLL-UI katmanlar�d�r. �htiyaca y�nelik ekstra katmanlar dahil edilecektir. MVC,Model vs gibi.

	- Model: Model katman� dal katman�nda varl�klar� temsil eden Entity'leri bar�nd�ran katmand�r.Projemizde olmas�n� istedi�imiz projenin ihtiyac� olan entityler bu katmanda olu�turulur.�htiyaca g�re ilerleyen zamanlarda yeni entityler eklenebilir.
		- Base: Interface'den alm�� oldu�u �zellikleri b�nyesine dahil eder.
			-BaseEntity:Entitylere i�inde bar�nd�rd��� property'leri miras(inheritance) b�rakmas� i�in olu�turulacakt�r.Genel bir tabir ile bizim �nc� entity'miz diyebiliriz.Projenin geli�ime a��k olmas� Yani SOLID prensiperinden ilki olan Single Responsibility Principle'e uygun olmas� ad�na bu �ekilde olu�turulacakt�r.
		- Entities: Veritaban�nda olmas�n� istedi�imiz tablolar� temsil eder.
			- AppUser
			- AppUserRole
			- Category
			- Product
			- Order
			- OrderDetail



		- Enums: Tablolarda kullan�lacak sabitleri temsil eder.
		- Interfaces: B�t�n classlara �nc�l�k edek �zellikleri bar�nd�r�r.

	- DAL (Data Access Layer): Veritaban�na ula��m katman�n� temsil eder. Veritaban� ile ilgili nesnelerimiz, tasar�m desenleri, Entity gibi varl�klar bu katman i�erisinde kullan�lmal�d�r.
		- Context: Veritaban� nesnesini temsil eder.


	- BLL (Business Logic Layer): �� mant��� katman� olarak kullan�lacakt�r. Kullan�c�n talep etti�i i�lemler ilk olarak bu katman taraf�ndan kar��lanacak. Repository ve Service bu katman i�erisinde olu�turulacak.
		--Repositories
			--Abstracts
				--BaseAbstracts
					-IRepository: Bu interface b�t�n i�lemlere �nc�l�k edecek metotlar�n kurallar�n� bar�nd�rmaktad�r. (CRUD) Interface d��ar�dan bir T al�r.
		--Concretes
			--BaseConcrete
				--BaseRepository: IRepository'den miras alara eylemleri (metotlar�) somut hale d�n��t�ren class.. D�a�r�dan bir T al�r

	Yukar�daki tan�mlamalarda bulunan T tipleri Ayr� bir servis olu�turulacak. Bu kurallar� b�nyesine al�r. Bu kurallara g�re spesifik eylemleri ger�ekle�tirir. �rne�in CategoryService'de ger�ekle�tirildi�i gibi. (Bknz. CategoryService)
			

	- UI (User Interface): Sunum katman�n� temsil eder. 
		- MVC projesi bu katman i�erisinde olu�turulacak. 
		- Console App
		- WebApi

    - Common (Ortak Katman): �lerleyen etaplarda projenin daha esnek olabilmesi i�in her bir katmanda ortak olarak kullan�lacak i�lemler/yap�lar bu katmanda yer almaktad�rlar.
		--ImageHelper: �e�risinde bulunan static metot vas�tas�yla d�a�r�dan iletilen dosyan�n bir g�rsel olup olmad���n� kontrol edilmesini ard�ndan bu g�rselin projeye dahil edilmesini ger�ekle�tirir.


#SMTP Ayarlar�
Email: yzl3172@outlook.com
Pass: YzlKadikoy--