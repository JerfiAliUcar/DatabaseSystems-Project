Sitenin Amacı:
Apple markası için alternatif bir web sitesi. Kullanıcıların iPhone modellerini tanıyıp özelliklerini inceleyebileceği, kendilerine uygun buldukları yetkili satıcılar hakkında bilgi alabileceği, fiyatları öğrenebileceği ve yorum bırakabileceği bir web sitesi. Tüm gerekli verileri SQL Server veri tabanı kullanarak saklıyoruz.
Varlık-İlişki Şeması
1. User:
   - Gereksinim: Kullanıcı bilgilerini tutar.
   - Özellikler: UserID, ad, soyad, e-posta adresi ve telefon numarası gibi bilgileri içermelidir.
2. iPhone:
   - Gereksinim: Kullanıcıların iPhone modellerini inceleyebilmesi için her modelin özelliklerini tutar.
   - Özellikler: iPhoneID, Model adı, çıkış yılı, ekran boyutu, CPU, RAM, pil, fiyat ve modelin resminin adresi gibi bilgileri içermelidir.
3. Comment:
   - Gereksinim: Kullanıcıların yaptığı yorumları tutar.
   - Özellikler: CommentID, yorumu yapan kullanıcının UserID değeri ve comment gibi detaylar tabloda bulunmalıdır.
4. Dealer:
   - Gereksinim: iPhone’ları satan satıcıları tutar.
   - Özellikler: DealerID, DealerName, DealerAddress ve Description gibi detaylar tabloda bulunmalıdır.
4. DealerIphones:
   - Gereksinim: iPhone’ların her bir dealer’daki fiyatlarını tutar.
   - Özellikler: DealerID, IphoneID, Price gibi detaylar tabloda bulunmalıdır.

 


![image](https://github.com/JerfiAliUcar/DatabaseSystems-Project/assets/103874096/de32fa08-fc7b-46ff-a27f-7ac8d2ddae15)





  İlişkiler ve İlişkisel Veri Modeli

İlişkiler:
 	User ve Comment arasında bire-çok (1-N) ilişki
 	Comment ve iPhone arasında çoktan-bire (N-1) ilişki
 	Dealer ve DealerIphone arasında çoktan çoğa (N-N)
 	Iphone ile DealerIphone arasında çoktan çoğa (N-N)


İlişkisel Veri Modeli:
Varlık-ilişki şeması ilişkisel veri modeline dönüştürülmüştür:
-	User(UserID,Name,Surname,Email,Phone)
-	Comment(CommentID,UserID,iPhoneID,Comment)
-	Dealer(DealerID,DealerName,DealerAddress,Description)
-	iPhone(iPhoneID,DealerID,ModelName,RelaseDate,ScreenSize,CPU,RAM,Battery,Price,ImageUrl)
-	DealerIphones(DealerID,IphoneID,Price)
                                             
İşlevsel Bağımlılıklar ve Normalizasyon
  

İşlevsel bağımlılıklar:
Her varlık için geçerli işlevsel bağımlılıklar belirtilmiştir:
-	User: UserID → Name, Surname, Email, Phone
-	Comment: CommentID → UserID, iPhoneID, Comment
-	Dealer: DealerID → DealerName, DealerAddress, Description
-	iPhone: iPhoneID → DealerID, ModelName, RelaseDate, ScreenSize, CPU, RAM, Battery, ImageUrl 
-	DealerIphones: DealerID,IphoneID → Price
 Normalizasyon:
İlişkiler, 3NF (Üçüncü Normal Form) olarak tasarlanmıştır. Tüm varlıklar 3NF’tedir.
  
Uygulama Mimarisi

Web uygulamamda Asp .Net Core MVC yapısını kullandım. Frontend kısmını HTML, CSS ve Bootstrap ile Backend kısmını ise C# ile yazdım. Mimari olarak ise servislerin yer aldığı business, veritabanının bağlandığı data ve projenin web tarafı olan web.mvc katmanları ile basit bir 3 layer architecture kullanıldı. Veritabanı yönetim sistemi olarak ise SQL Server kullanıldı.


