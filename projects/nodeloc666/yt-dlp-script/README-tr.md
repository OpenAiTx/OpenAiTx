
<div align="right">
  <details>
    <summary >🌐 Dil</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>


# 🎬 yt-dlp Video Toplu İndirme Aracı (Windows / Linux Destekli)

> [yt-dlp](https://github.com/yt-dlp/yt-dlp) tabanlı tek tıklamayla video indirme betiği, ilham kaynağı [NodeSeek üstadının paylaşımı](https://www.nodeseek.com/post-334093-2#15).
> Tekli video ve toplu indirme destekler, Windows ve yaygın Linux dağıtımlarıyla (Debian / Ubuntu / Alpine / CentOS) uyumludur.

---

## ✨ Özellikler

* 📥 **Tek Tıkla Çalıştırma**: Manuel yapılandırmaya gerek yok, talimatlara göre girin ve indirmeye başlayın
* 🍪 **Özel Çerez Desteği**: Giriş yapılması gereken videolar için uygundur (⚠️ Bu özellik henüz doğrulanmadı, hata olabilir)
* 📂 **Özel Çıkış Dizini Desteği**: Kolayca belirlediğiniz klasöre kaydedin
* 📃 **Toplu İndirme Desteği**: `urls.txt` dosyasındaki bağlantıları otomatik olarak okur ve indirir
* ⚙️ **Otomatik Bağımlılık Kurulumu**: Linux ortamında `yt-dlp` ve `ffmpeg` otomatik kurulur

---

## 🖼️ Ekran Görüntüsü Önizlemesi

| Örnek 1                                                                   | Örnek 2                                                                   |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| ![Örnek 1](https://img.uutv.dpdns.org/file/1746720584399_1000193433.jpg) | ![Örnek 2](https://img.uutv.dpdns.org/file/1746720581006_1000193434.jpg) |
| ![Örnek 3](https://img.uutv.dpdns.org/file/1746720588978_1000193428.jpg) | ![Örnek 4](https://img.uutv.dpdns.org/file/1746720587272_1000193427.jpg) |

---

## 🪟 Windows Kullanım Talimatları

1. Aşağıdaki dosyaları indirin:

   * [`yt-dlp.exe`](https://github.com/yt-dlp/yt-dlp)
   * [`ffmpeg` Windows sürümü](https://www.gyan.dev/ffmpeg/builds/ffmpeg-git-full.7z)

2. Çıkardıktan sonra, aşağıdaki dosyaları aynı klasöre koyun (ör. `yt-dlp` klasörü):

   * `yt-dlp.exe`
   * `ffmpeg.exe`
   * `ffprobe.exe`
   * `yt-dlp.bat` (betik dosyası)

3. `yt-dlp.bat` dosyasına çift tıklayın, talimatlara göre video indirin.
4. Varsayılan ayarları değiştirmek için config/config.ini dosyasını düzenleyin

---

## 🐧 Linux Kullanım Talimatları (TeknolojiLion tarafından hazırlanan en yeni betikte aynı işlevsellik de entegre edilmiştir)

**Desteklenen Sistemler**: Debian / Ubuntu / Alpine / CentOS

Tek tıkla kurulum veya güncelleme ve çalıştırma:

```bash
bash -c "$(curl -fsSL https://raw.githubusercontent.com/nodeloc666/yt-dlp-script/main/install.sh)"
```

Kaldırmak için:

```bash
bash -c "$(curl -fsSL https://raw.githubusercontent.com/nodeloc666/yt-dlp-script/main/uninstall.sh)"
```

---

## 📱 Android Kullanım Tavsiyeleri

1. [Seal](https://github.com/JunkFood02/Seal) uygulamasını kullanarak Android'de `yt-dlp` özelliklerini deneyimleyebilirsiniz.
2. Termux ile Debian kurup da indirebilirsiniz, ama buna gerek yok, Seal oldukça kullanışlı

---

## ⚠️ Dikkat Edilmesi Gerekenler

1. **Toplu İndirme Modu**: Script otomatik olarak mevcut dizindeki `config\urls.txt` dosyasını okur, her satırda bir video bağlantısı olmalıdır. Dosya yoksa otomatik olarak oluşturulur.
2. **Kaynak Kullanımı Uyarısı**: Belleği az olan cihazlarda aynı anda birden fazla büyük video indirmekten veya çok yüksek eşzamanlı iş parçacığı ayarlamaktan kaçının.
3. **CentOS Özel Notu**: Ortam oldukça farklı olduğundan, kapsamlı test yapılmadı; üretim dışı ortamlarda kullanılmasını öneririz. Diğer ana sistemlerde sorunsuz çalışmaktadır.
4. Linux sürümünde küçük hata: Script ana sayfaya geldiğinde bir kez bağımlılıkları kontrol eder; kod çalışıyor diye değiştirmedim, üşendim
5. Windows sürümünde küçük hata: Diğer sayfalardan ana sayfaya dönüp tekrar seçim yapınca, varsayılan seçenek çalışmayabilir ve döngüde takılır; imkanım yetmedi, tam düzeltemedim
İki çözüm yolu:
    1. Çıkıp tekrar çalıştırmak
    2. Varsayılanı kullanmamak, rakam girerek seçim yapmak

---

## 📄 Lisans

Bu proje [MIT Lisansı](https://opensource.org/licenses/MIT) ile lisanslanmıştır.

---


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-08

---