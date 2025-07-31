
# 💊📅 İlaç ve Randevu Otomasyonu

## 📘 Proje Hakkında

**İlaç ve Randevu Otomasyonu**, kullanıcıların kendi sağlık takibini yapabilmesini sağlayan kapsamlı bir masaüstü uygulamasıdır. Kullanıcılar sisteme giriş yaptıktan sonra:

- Aldıkları ilaçları tarih, fiyat, etki ve yan etki bilgileriyle birlikte kaydedebilir,
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

| Teknoloji            | Açıklama                                     |
|----------------------|----------------------------------------------|
| C# (.NET Framework)  | Masaüstü uygulama geliştirildi               |
| Windows Forms        | Kullanıcı arayüzü                            |
| SQL Server           | Veritabanı yönetimi                          |
| Entity Framework     | ORM yapısı                                   |
| DevExpress           | Gelişmiş ve modern arayüz bileşenleri        |
| LINQ                 | Veri sorgulama işlemleri                     |

---

## 🧭 Proje Kapsamı

### Kullanıcılar:
- Sisteme kayıt olabilir veya giriş yapabilir.
- Kendi profilleri altında birden fazla ilaç ekleyebilirler.
- Ekledikleri ilaçların detaylarını görüntüleyebilirler (fiyat, tarih, etkiler).
- İlaçları güncelleyebilir veya silebilirler.

### Randevu Sistemi:
- Kullanıcılar sistemden randevu alabilir.
- Randevuların tarih ve saat bilgilerini görebilir.
- Randevularını iptal edebilirler.

---

## 🔌 Veritabanı Tabloları

| Tablo Adı   | Açıklama                                          |
|-------------|---------------------------------------------------|
| `Kullanici` | Kullanıcı bilgilerini içerir (Ad, Email, Şifre vs.) |
| `Ilac`      | Kullanıcıya ait ilaçların bilgilerini tutar         |
| `Randevu`   | Kullanıcının oluşturduğu randevuları içerir         |

### Tablolar Arası İlişkiler

- Bir **Kullanıcı**, birden fazla **İlaç** ekleyebilir (1-N).
- Bir **Kullanıcı**, birden fazla **Randevu** oluşturabilir (1-N).

---
## 🖼️ Uygulama Görselleri

### 🔐 Giriş Ekranı
![Giriş Ekranı](./images/giris-formu.png)

### 📝 Kayıt Ekranı
![Kayıt Ekranı](./images/kayit-formu.png)

### 💊 İlaç Ekleme
![İlaç Ekleme](./images/ilac-ekle.png)

### 📄 İlaç Detayları
![İlaç Detayları](./images/ilac-detay.png)

### 📅 Randevu Paneli
![Randevu Paneli](./images/randevu-formu.png)
****
## 💾 Kurulum ve Çalıştırma

### 📌 Gereksinimler

- Visual Studio 2017 veya üzeri
- .NET Framework 4.6.1 veya üzeri
- Microsoft SQL Server
- SQL Server Management Studio (SSMS)

---

### 🚀 Adım Adım Kurulum

#### 1. Projeyi Klonlayın

```bash
git clone https://github.com/KULLANICIADIN/ilac-randevu-otomasyonu.git
