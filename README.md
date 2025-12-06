# Yazılım Geliştirme Proje Analiz Aracı
Bu projenin temel amacı, yazılım projelerinde iş gücü, maliyet ve zaman tahminlerinin daha doğru ve sistematik bir şekilde yapılmasını sağlayan bir araç geliştirmektir. Kullanıcıdan alınan giriş verileri ve teknik değerlendirmelerle birlikte, TKF (Teknik Karmaşıklık Faktörü), AİN (Ayarlanmış İşlev Noktası), İN (İşlev Noktası), satır sayısı, iş gücü, zaman, maliyet çarpanı ve adam-hafta gibi kritik yazılım mühendisliği metrikleri otomatik olarak hesaplanmaktadır. Bu sayede proje planlama sürecinin daha bilimsel, öngörülebilir ve sürdürülebilir hale getirilmesi hedeflenmektedir.

**Programlama Dili:** C# (.NET Framework – Windows Forms) 
**Veritabanı Yönetim Sistemi:** Microsoft SQL Server

**Proje Görselleri**
<img width="138" height="151" alt="image" src="https://github.com/user-attachments/assets/b9bf52c3-8524-4e67-bea1-5b5ae88aabce" />

# Gerekli SQL kodları

create database ypgProjesi
use ypgProjesi

CREATE TABLE Kullanici (
    Adi NVARCHAR(100),
	Soyadi NVARCHAR(100),
    TKF_Degeri INT,
    AIN_Degeri FLOAT,
    IN_Degeri FLOAT,
	Satir_sayisi float,
	Is_gucu float,
	Zaman float,
	Maliyet_Carpani float,
	Duzeltilmis_is_gucu float,
	Ortalama_personel float,
	Adam_hafta float
);


CREATE TABLE ProgramlamaPlatformu (
    PlatformAdi NVARCHAR(50),
    OrtalamaSatirSayisi INT
);

INSERT INTO ProgramlamaPlatformu (PlatformAdi, OrtalamaSatirSayisi) VALUES 
('Assembly', 300),
('COBOL', 100),
('Fortran', 100),
('Pascal', 90),
('C', 90),
('Ada', 70),
('Nesne Kökenli Diller', 30),
('4. Kuşak Diller', 20),
('Kod Üreticiler', 15);
