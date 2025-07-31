# 💊📅 İlaç ve Randevu Otomasyonu

## 📘 Proje Hakkında

**İlaç ve Randevu Otomasyonu**, kullanıcıların kendi sağlık takibini yapabilmesini sağlayan kapsamlı bir masaüstü uygulamasıdır. Kullanıcılar sisteme giriş yaptıktan sonra:

- Aldıkları ilaçları tarih, fiyat, kullanım amacı ve yan etkileriyle birlikte kaydedebilir,
- Önceden eklenmiş ilaçları listeleyebilir ve detaylarını inceleyebilir,
- Yeni randevular oluşturabilir, geçmiş ve güncel randevularını görebilir.

Bu otomasyon, bireysel kullanıcıların sağlık bilgilerini dijital olarak yönetmelerine olanak tanıyan kullanışlı bir platform sunar.

---

## 🎯 Proje Özellikleri

- 🔐 Kullanıcı kayıt ve giriş sistemi  
- 💊 İlaç ekleme, listeleme, silme ve güncelleme  
- 📄 Her ilaç için tarih, fiyat, kullanım amacı ve yan etkiler bilgisi  
- 📅 Randevu oluşturma, görüntüleme ve iptal etme  
- 🧠 SQL Server ile veri yönetimi  
- 🖼️ DevExpress arayüz bileşenleriyle modern tasarım  

---

## 🛠️ Kullanılan Teknolojiler

| Teknoloji           | Açıklama                                  |
|---------------------|-------------------------------------------|
| C# (.NET Framework)  | Masaüstü uygulama geliştirme              |
| Windows Forms       | Kullanıcı arayüzü                         |
| SQL Server          | Veritabanı yönetimi                       |
| Entity Framework    | ORM yapısı                               |
| DevExpress          | Modern ve gelişmiş arayüz bileşenleri    |
| LINQ                | Veri sorgulama işlemleri                  |

---

## 🧭 Proje Kapsamı

### Kullanıcılar:
- Sisteme kayıt olabilir veya giriş yapabilir.  
- Kendi profilleri altında birden fazla ilaç ekleyebilir.  
- Ekledikleri ilaçların detaylarını görüntüleyebilir (fiyat, tarih, etkiler).  
- İlaçları güncelleyebilir veya silebilirler.  

### Randevu Sistemi:
- Kullanıcılar sistemden randevu alabilir.  
- Randevuların tarih ve saat bilgilerini görebilir.  
- Randevularını iptal edebilirler.

---

## 🔌 Veritabanı Tabloları

| Tablo Adı    | Açıklama                                          |
|--------------|---------------------------------------------------|
| `Kullanici`  | Kullanıcı bilgilerini içerir (Ad, Email, Şifre vb.) |
| `Ilac`       | Kullanıcıya ait ilaçların bilgilerini tutar         |
| `Randevu`    | Kullanıcının oluşturduğu randevuları içerir          |

### Tablolar Arası İlişkiler

- Bir **Kullanıcı**, birden fazla **İlaç** ekleyebilir (1-N).  
- Bir **Kullanıcı**, birden fazla **Randevu** oluşturabilir (1-N).  

---

## 🖼️ Uygulama Görselleri

###  📷 ANA SAYFA
![ANA SAYFA](./images/Ekran%20görüntüsü%202025-04-25%20145426.png)  
**Ana ekran görünümü:** Kullanıcı giriş yaptıktan sonra karşılaştığı ana panel.

### 📷 KULLANICI GÜNCELEME 
![KULLANICI GÜNCELEME](./images/Ekran%20görüntüsü%202025-04-25%20145500.png)  
**Kullanıcı bilgileri güncelleme ekranı:** Kullanıcı profil bilgilerini değiştirebilir.

### 📷 İLAÇ EKLEME  
![İLAÇ EKLEME](./images/Ekran%20görüntüsü%202025-04-25%20150023.png)  
**İlaç ekleme formu:** Kullanıcı yeni ilaç bilgilerini tarih, fiyat, kullanım amacı ve yan etkileri ile kaydedebilir.

### 📷 ARAYÜZ  
![ARAYÜZ](./images/Ekran%20görüntüsü%202025-04-25%20150231.png)  
**İlaç listesi ve detay görüntüleme:** Kullanıcının eklediği ilaçların listesi ve detayları burada gösterilir.

### 📷 GİRİŞ EKRANI 
![GİRİŞ EKRANI](./images/Ekran%20görüntüsü%202025-04-25%20150458.png)  
**Giriş ekranı:** Sisteme kullanıcı girişi için kullanılan form.

### 📷 KAYIT EKRANI  
![KAYIT EKRANI](./images/Ekran%20görüntüsü%202025-04-25%20150522.png)  
**Kayıt olma ekranı:** Yeni kullanıcıların sisteme kayıt olduğu form.

### 📷 RANDEVU EKRANI 
![GİRİŞ EKRANI](./images/Ekran%20görüntüsü%202025-04-25%20150805.png)  
**Randevu yönetim ekranı:** Kullanıcıların randevu oluşturup, görüntüleyip iptal edebildikleri bölüm.

---

### 📌 Gereksinimler

- Visual Studio 2017 veya üzeri  
- .NET Framework 4.6.1 veya üzeri  
- Microsoft SQL Server  
- SQL Server Management Studio (SSMS)  

---

### 🛠️ Kurulum Talimatları

1. **Projeyi İndirin**  
```bash
git clone https://github.com/KULLANICI_ADINIZ/ILAC-RANDEVU-OTOMASYONU.git
