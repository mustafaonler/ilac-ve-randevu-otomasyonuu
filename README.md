
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

### 📷 Görsel 1
![Görsel 1](./images/Ekran%20görüntüsü%202025-04-25%20145426.png)


### 📷 Görsel 2
![Görsel 2](./images/ekran-goruntusu-2025-04-25-145500.png)

### 📷 Görsel 3
![Görsel 3](./images/ekran-goruntusu-2025-04-25-150023.png)

### 📷 Görsel 4
![Görsel 4](./images/ekran-goruntusu-2025-04-25-150231.png)

### 📷 Görsel 5
![Görsel 5](./images/ekran-goruntusu-2025-04-25-150458.png)

### 📷 Görsel 6
![Görsel 6](./images/ekran-goruntusu-2025-04-25-150522.png)

### 📷 Görsel 7
![Görsel 7](./images/ekran-goruntusu-2025-04-25-150805.png)



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
