# Yazılım Geliştirme Proje Analiz Aracı
Bu projenin temel amacı, yazılım projelerinde iş gücü, maliyet ve zaman tahminlerinin daha doğru ve sistematik bir şekilde yapılmasını sağlayan bir araç geliştirmektir. Kullanıcıdan alınan giriş verileri ve teknik değerlendirmelerle birlikte, TKF (Teknik Karmaşıklık Faktörü), AİN (Ayarlanmış İşlev Noktası), İN (İşlev Noktası), satır sayısı, iş gücü, zaman, maliyet çarpanı ve adam-hafta gibi kritik yazılım mühendisliği metrikleri otomatik olarak hesaplanmaktadır. Bu sayede proje planlama sürecinin daha bilimsel, öngörülebilir ve sürdürülebilir hale getirilmesi hedeflenmektedir.

**Programlama Dili:** C# (.NET Framework – Windows Forms) 
**Veritabanı Yönetim Sistemi:** Microsoft SQL Server

**Proje Görselleri**

<img width="554" height="586" alt="image" src="https://github.com/user-attachments/assets/ecd0dbbf-1d10-44ee-b381-53d445ba7b01" />
<img width="1157" height="637" alt="image" src="https://github.com/user-attachments/assets/31a3a1e2-d7b0-4af3-835a-0f1e9a022b5d" />
<img width="1154" height="634" alt="image" src="https://github.com/user-attachments/assets/084854bb-6ff4-4718-97c3-b50d4ff8d8a5" />
<img width="1154" height="625" alt="image" src="https://github.com/user-attachments/assets/6e29848f-9052-45fe-b71a-6884fb27da3c" />
<img width="1146" height="601" alt="image" src="https://github.com/user-attachments/assets/eb685a3f-0553-4373-86ac-5e5fc5a6753f" />
<img width="1088" height="632" alt="image" src="https://github.com/user-attachments/assets/dfbe1acd-fd6b-4dea-aafd-55b66af612fd" />
<img width="1147" height="631" alt="image" src="https://github.com/user-attachments/assets/e8d0ab27-aaa7-482a-8fb3-f4c16e0c1d32" />
<img width="1145" height="640" alt="image" src="https://github.com/user-attachments/assets/0569a9d7-14bc-467d-bb9c-2bbf9fef6637" />


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
