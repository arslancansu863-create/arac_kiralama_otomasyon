<div align="center">

<img src="https://readme-typing-svg.demolab.com?font=Fira+Code&size=32&duration=3000&pause=1000&color=0078D4&center=true&vCenter=true&width=600&lines=🚗+Araç+Kiralama+Otomasyonu;C%23+%7C+WinForms+%7C+SQL+Server" alt="Typing SVG" />

<br/>

![C#](https://img.shields.io/badge/C%23-%23239120.svg?style=for-the-badge&logo=csharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![SQL Server](https://img.shields.io/badge/SQL%20Server-CC2927?style=for-the-badge&logo=microsoftsqlserver&logoColor=white)
![Windows Forms](https://img.shields.io/badge/WinForms-0078D4?style=for-the-badge&logo=windows&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91?style=for-the-badge&logo=visualstudio&logoColor=white)

<br/>

> **Araç kiralama süreçlerini uçtan uca yöneten, C# ve SQL Server tabanlı masaüstü otomasyon uygulaması.**

<br/>

[![GitHub repo](https://img.shields.io/badge/GitHub-arslancansu863--create-181717?style=flat-square&logo=github)](https://github.com/arslancansu863-create/arac_kiralama_otomasyon)
![Platform](https://img.shields.io/badge/Platform-Windows-blue?style=flat-square&logo=windows)
![Status](https://img.shields.io/badge/Status-Active-brightgreen?style=flat-square)

</div>

---

## 📋 İçindekiler

- [🎯 Proje Hakkında](#-proje-hakkında)
- [✨ Özellikler](#-özellikler)
- [🏗️ Sistem Mimarisi](#️-sistem-mimarisi)
- [🗄️ Veritabanı Yapısı](#️-veritabanı-yapısı)
- [🚀 Kurulum](#-kurulum)
- [💻 Kullanım](#-kullanım)
- [🛠️ Teknolojiler](#️-teknolojiler)
- [📁 Proje Yapısı](#-proje-yapısı)
- [🤝 Katkıda Bulunma](#-katkıda-bulunma)

---

## 🎯 Proje Hakkında

**Araç Kiralama Otomasyonu**, araç kiralama işletmelerinin günlük operasyonlarını kolaylaştırmak için geliştirilmiş kapsamlı bir masaüstü yönetim sistemidir. Araç envanteri takibinden kiralama işlemlerine, fatura oluşturmaktan müşteri yönetimine kadar tüm süreçler tek çatı altında toplanmıştır.

```
🏢 İşletme Yöneticisi  ──►  Araç Kiralama Otomasyonu  ──►  SQL Server Veritabanı
        │                           │
        │                    ┌──────┴──────┐
        │                    │   WinForms  │
        └───────────────────►│    Arayüz   │
                             └─────────────┘
```

---

## ✨ Özellikler

### 🚘 Araç Yönetimi
| Özellik | Açıklama |
|--------|----------|
| ➕ Araç Ekleme | Marka, model, yıl, plaka ve fiyat bilgisiyle yeni araç kaydı |
| 📋 Araç Listeleme | Tüm araçları filtreli ve sıralı görüntüleme |
| ✏️ Araç Güncelleme | Araç bilgilerini anlık güncelleme |
| 🗑️ Araç Silme | Sistemden araç kaydı kaldırma |
| 🔍 Müsaitlik Kontrolü | Araçların kiralanabilir / kirada durumu takibi |

### 📅 Kiralama İşlemleri
| Özellik | Açıklama |
|--------|----------|
| 📝 Yeni Kiralama | Tarih aralığı ve araç seçimiyle kiralama başlatma |
| 🔄 Kiralama Güncelleme | Aktif kiralamayı düzenleme |
| ✅ Teslim Alma | Aracı teslim alarak kiralamanın kapatılması |
| 📊 Kiralama Geçmişi | Tüm geçmiş ve aktif kiralamalar |

### 🧾 Fatura / Ödeme
| Özellik | Açıklama |
|--------|----------|
| 💰 Otomatik Hesaplama | Gün x günlük ücret formülüyle fatura oluşturma |
| 🖨️ Fatura Görüntüleme | Kiralama sonrası detaylı fatura ekranı |
| 📈 Gelir Takibi | İşletme bazlı gelir özeti |

---

## 🏗️ Sistem Mimarisi

```
┌─────────────────────────────────────────────────┐
│                  SUNUM KATMANI                  │
│         Windows Forms (WinForms) Arayüzü        │
│   [Araç Formu] [Kiralama Formu] [Fatura Formu]  │
└────────────────────┬────────────────────────────┘
                     │
┌────────────────────▼────────────────────────────┐
│                 İŞ MANTIĞI KATMANI               │
│        C# Sınıfları & Servis Metodları           │
│   [AracService] [KiralamaService] [FaturaService]│
└────────────────────┬────────────────────────────┘
                     │
┌────────────────────▼────────────────────────────┐
│              VERİTABANI KATMANI                  │
│         SQL Server & ADO.NET / ORM               │
│     [Arac] [Kiralama] [Fatura] Tabloları         │
└─────────────────────────────────────────────────┘
```

---

## 🗄️ Veritabanı Yapısı

```sql
-- Araç Tablosu
Arac (
  AracID        INT PRIMARY KEY IDENTITY,
  Marka         NVARCHAR(50),
  Model         NVARCHAR(50),
  Yil           INT,
  Plaka         NVARCHAR(20) UNIQUE,
  GunlukUcret   DECIMAL(10,2),
  Durum         BIT  -- 1: Müsait, 0: Kirada
)

-- Kiralama Tablosu
Kiralama (
  KiralamaID    INT PRIMARY KEY IDENTITY,
  AracID        INT FOREIGN KEY → Arac,
  BaslangicTarih DATE,
  BitisTarih     DATE,
  ToplamUcret   DECIMAL(10,2)
)

-- Fatura Tablosu
Fatura (
  FaturaID      INT PRIMARY KEY IDENTITY,
  KiralamaID    INT FOREIGN KEY → Kiralama,
  FaturaTarihi  DATETIME,
  Tutar         DECIMAL(10,2),
  OdemeDurumu   NVARCHAR(20)
)
```

---

## 🚀 Kurulum

### Gereksinimler

- ![Windows](https://img.shields.io/badge/Windows-10%2F11-blue?logo=windows&style=flat-square)
- ![.NET](https://img.shields.io/badge/.NET_Framework-4.7%2B-512BD4?logo=dotnet&style=flat-square)
- ![SQL Server](https://img.shields.io/badge/SQL_Server-2017%2B-CC2927?logo=microsoftsqlserver&style=flat-square)
- ![Visual Studio](https://img.shields.io/badge/Visual_Studio-2019%2B-5C2D91?logo=visualstudio&style=flat-square)

### Adım Adım Kurulum

**1️⃣ Repoyu klonla**
```bash
git clone https://github.com/arslancansu863-create/arac_kiralama_otomasyon.git
cd arac_kiralama_otomasyon
```

**2️⃣ Veritabanını oluştur**
```sql
-- SQL Server Management Studio'da çalıştır
CREATE DATABASE AracKiralamaDB;
USE AracKiralamaDB;
-- Ardından proje içindeki database.sql dosyasını çalıştır
```

**3️⃣ Bağlantı dizisini ayarla**

`App.config` veya `appsettings` dosyasında aşağıdaki satırı düzenle:
```xml
<connectionStrings>
  <add name="AracDB"
       connectionString="Server=YOUR_SERVER;Database=AracKiralamaDB;Integrated Security=True;" />
</connectionStrings>
```

**4️⃣ Projeyi derle ve çalıştır**
```
Visual Studio → Build → Start (F5)
```

---

## 💻 Kullanım

```
Uygulama Açılır
      │
      ├── 🚘 Araç Yönetimi
      │       ├── Yeni Araç Ekle
      │       ├── Araçları Listele
      │       └── Araç Sil / Güncelle
      │
      ├── 📅 Kiralama
      │       ├── Müsait Araçları Gör
      │       ├── Kiralama Başlat (tarih seç)
      │       └── Aracı Teslim Al
      │
      └── 🧾 Fatura
              ├── Fatura Oluştur
              └── Fatura Görüntüle / Yazdır
```

---

## 🛠️ Teknolojiler

<div align="center">

| Teknoloji | Kullanım Amacı | Versiyon |
|-----------|----------------|----------|
| ![C#](https://img.shields.io/badge/C%23-239120?logo=csharp&logoColor=white&style=flat-square) **C#** | Ana programlama dili | .NET Framework |
| ![WinForms](https://img.shields.io/badge/WinForms-0078D4?logo=windows&logoColor=white&style=flat-square) **Windows Forms** | Masaüstü GUI arayüzü | .NET Framework |
| ![SQL Server](https://img.shields.io/badge/SQL%20Server-CC2927?logo=microsoftsqlserver&logoColor=white&style=flat-square) **SQL Server** | İlişkisel veritabanı | 2017+ |
| ![ADO.NET](https://img.shields.io/badge/ADO.NET-512BD4?logo=dotnet&logoColor=white&style=flat-square) **ADO.NET** | Veritabanı bağlantısı | — |
| ![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91?logo=visualstudio&logoColor=white&style=flat-square) **Visual Studio** | Geliştirme ortamı | 2019+ |

</div>

---

## 📁 Proje Yapısı

```
arac_kiralama_otomasyon/
│
├── 📂 Forms/
│   ├── MainForm.cs          # Ana menü formu
│   ├── AracForm.cs          # Araç yönetimi formu
│   ├── KiralamaForm.cs      # Kiralama işlemleri formu
│   └── FaturaForm.cs        # Fatura görüntüleme formu
│
├── 📂 Models/
│   ├── Arac.cs              # Araç veri modeli
│   ├── Kiralama.cs          # Kiralama veri modeli
│   └── Fatura.cs            # Fatura veri modeli
│
├── 📂 Database/
│   ├── DbConnection.cs      # SQL Server bağlantı sınıfı
│   └── database.sql         # Veritabanı oluşturma scripti
│
├── App.config               # Uygulama ayarları
└── README.md                # Bu dosya 📄
```

---

## 🤝 Katkıda Bulunma

1. 🍴 Bu repoyu **fork** edin
2. 🌿 Yeni bir branch oluşturun: `git checkout -b feature/yeni-ozellik`
3. 💾 Değişikliklerinizi commit edin: `git commit -m 'Yeni özellik eklendi'`
4. 📤 Branch'i push edin: `git push origin feature/yeni-ozellik`
5. 📬 **Pull Request** açın

---

<div align="center">

**⭐ Bu projeyi beğendiyseniz star vermeyi unutmayın!**

Made with ❤️ by [arslancansu863-create](https://github.com/arslancansu863-create)

</div>
