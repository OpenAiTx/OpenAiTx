
<div align="right">
  <details>
    <summary >🌐 Dil</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

<br/>
<p align="center"><img width="500" height="auto" alt="codriver_banner" src="https://github.com/user-attachments/assets/1957b950-db16-4ebd-b514-4f9b4f4abfd9" /></p>

<br/>

<a href="https://github.com/RickyDane/CoDriver/actions/workflows/main.yml"><p align="center"><img src="https://github.com/RickyDane/CoDriver/actions/workflows/main.yml/badge.svg?branch=master"></p></a>

<p align="center">
  <img src="https://img.shields.io/badge/Windows-blue" />
  <img src="https://img.shields.io/badge/ macOS-white" />
  <img src="https://img.shields.io/badge/Linux-red" />
</p>

<p align="center">
  <a href="https://discord.gg/zSE27rjdzp">
      <img src="https://dcbadge.limes.pink/api/server/https://discord.gg/zSE27rjdzp" />
  </a>
</p>

<p align="center">
  <a href='https://ko-fi.com/rickydane'>
      <img height='36px' style='border: 0px; height: 36px;' src='https://storage.ko-fi.com/cdn/kofi2.png?v=3' border='0' alt='ko-fi.com'da bana bir kahve ısmarla' />
  </a>
</p>

<br/>

<p align="center">
  Rust dilini öğrenmek istediğim için ortaya çıkan basit bir dosya gezgini.
  <br>
  İşletim sistemi bağımsızdır ve optimizasyon için sadeleştirilmiştir.
</p>

<br/><br/>

Performans, ["jwalk"](https://crates.io/crates/jwalk/versions) ve ["Tauri"](https://tauri.app/) tarafından sağlanmaktadır.
<br/><br/>
CoDriver, dosya ve klasörlere erişmek için yol önbelleklemesi kullanmaz; bu nedenle performans Rust, disk hızı ve cpu gücünden sağlanmaktadır.

⁉️ Unutmayın ki bu yazılım hâlâ geliştirme aşamasındadır ve hatalar içerebilir!
<br/><br/>

# Bağlantılar
- <a href="#basic-features">Temel özellikler</a>
- <a href="#advanced-features">Gelişmiş özellikler</a>
- <a href="#dependencies-if-not-working-instantly">Bağımlılıklar</a>
- <a href="#%EF%B8%8F-ftp-integration-sshfs">FTP uygulaması (SSHFS)</a>
- <a href="#%EF%B8%8F-known-issues">Bilinen sorunlar</a>
- <a href="#-todos">Yapılacaklar</a>
- <a href="#user-interface">Kullanıcı arayüzü</a>

## Temel özellikler
- Klasörler arasında alışık olduğunuz şekilde gezinin
- Dosya ve klasörleri kopyala & yapıştır, sil, oluştur ve yeniden adlandır
- Izgara, liste ve miller-sütunları modları arasında geçiş yapın
- Açılır pencereleri esc ile kapatın
- Bir yolu girerek Ctrl / Cmd + G ile doğrudan bir dizine atlayın
- Liste modunda öğeleri boyut, ad veya son değişiklik zamanına göre sıralayın

## Gelişmiş özellikler
- Dosya ve klasörleri sıkıştırın
  - zip
  - zstd
  - brotli
  - density (https://github.com/g1mv/density)
- Arşivleri çıkarın
  - rar
  - zip
  - 7zip
  - tar (.gz, .bz2)
  - density
- LAlt + 1 / 2 / 3 | (macOS option + 1 / 2 / 3) kısayolu ile bir dizine gidin
  - Yolları ayarlardan kendiniz yapılandırın
- F6 ile dosya oluşturun
- F7 ile klasör oluşturun
- Çift Panel görünümü
  - F8 ile dosya arayın
  - Seçili öğeyi diğer panele F5 ile kopyalayın
  - Seçili öğeyi diğer panele LShift + F5 ile taşıyın
- Dosyaları gezgine sürükleyip bırakarak geçerli dizine kopyalayın
- Ctrl / Cmd + LShift + M ile seçiminizi çoklu yeniden adlandırın
  - Çoklu yeniden adlandırmayı Ctrl / Cmd + Return ile çalıştırın
- Dosya hızlı önizlemesi -> Dizin girdisini seçin ve boşluk çubuğuna dokunun.
  - Desteklenen dosyalar: tüm resim dosyaları (.jpg, .png, ...), .pdf, .mp4, .json, .txt, .html
  - Diğer tüm öğeler hakkında bazı bilgiler (yol, boyut, son değişiklik) içeren küçük bir döşeme gösterir.
- Anında gezinme -> Yazmaya başlayın ve dizin girdilerini otomatik olarak filtreleyerek istenen konuma <br/>
  ulaşmayı çok daha hızlı hale getirin

## Bağımlılıklar (Anında çalışmıyorsa)

<details>
<summary>Genişletmek için tıklayın</summary>

### Linux

- openssl1.1

#### Debian / Ubuntu
```
sudo apt update
sudo apt install libwebkit2gtk-4.0-dev \
    build-essential \
    curl \
    wget \
    file \
    libssl-dev \
    libgtk-3-dev \
    libayatana-appindicator3-dev \
    librsvg2-dev
```

#### Kemer
```
sudo apt update
sudo apt install libwebkit2gtk-4.0-dev \
    build-essential \
    curl \
    wget \
    file \
    libssl-dev \
    libgtk-3-dev \
    libayatana-appindicator3-dev \
    librsvg2-dev
```

#### Fedora
```
sudo dnf check-update
sudo dnf install openssl1.1 \
    webkit2gtk4.0-devel \
    openssl-devel \
    curl \
    wget \
    file \
    libappindicator-gtk3-devel \
    librsvg2-devel
sudo dnf group install "C Development Tools and Libraries"
```
</details>

## 🖥️ FTP entegrasyonu (sshfs)
<details>
  <summary>Göstermek için genişlet</summary>
  <br/>
  Bağımlılıklar (Ayrıca yüklenmesi gerekir):
  <br/>

  | macOS | Linux | Windows |
  | ----- | ----- | ------- |
  | fuse-t <br/> fuse-t-sshfs | libfuse | Henüz desteklenmiyor **_henüz_** |

  ### Kurulum:
  #### macOS
  ```
  brew tap macos-fuse-t/homebrew-cask
  brew install fuse-t
  brew install fuse-t-sshfs
  ```
  #### Linux
  ```
  sudo apt-get install sshfs
  ```

## 🏴‍☠️ Dil Desteği
- İngilizce
  - Yakında diller arasında seçim yapma seçeneği eklenecek ...
</details>

## ⚠️ Bilinen sorunlar:
- Linux'ta pencere dışına sürükleyip bırakma şu anda her zaman çalışmıyor
- Windows'ta [Microsoft Visual C++ Redistributable](https://learn.microsoft.com/en-us/cpp/windows/latest-supported-vc-redist?view=msvc-170) yüklemeniz gerekebilir
- ms-windows üzerinde izinler biraz garip
  - Eğer elemanları kopyalama veya benzeri bir sorun yaşarsanız programı yönetici olarak çalıştırmanız gerekebilir
- Program başlamazsa linux sistemlerde openssl1.1 yüklemeniz gerekebilir

## 📝 Yapılacaklar:
- Çoklu dil desteği
- Favoriler
- Çevrimiçi depolama servislerine erişim (Google Drive, vb.)

## Kullanıcı arayüzü
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 19 16" src="https://github.com/user-attachments/assets/fc408504-3000-4325-bc2a-638cdd01ea0a" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 19 40" src="https://github.com/user-attachments/assets/5f772d02-6bc2-470c-b999-6982043496c1" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 20 02" src="https://github.com/user-attachments/assets/7f2ec5ea-a669-4630-a1f8-413c7ced3f3b" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 20 07" src="https://github.com/user-attachments/assets/4ac9930d-7b50-4910-afb3-d47c562c3b44" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 20 28" src="https://github.com/user-attachments/assets/7dcfb0fa-c106-401a-b917-06e766021368" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 23 18" src="https://github.com/user-attachments/assets/4bac06d1-22df-47d4-95c9-1ccb50083506" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 23 39" src="https://github.com/user-attachments/assets/fdca23b0-9ed5-495b-9fec-18ecbfd4d5f2" />



## Katkıda bulunmak için
Makinenizi tauri v1 uygulamaları geliştirmek için hazırlayın: [Tauri önkoşulları](https://tauri.app/v1/guides/getting-started/prerequisites)
</br></br>
Bunu yaptıktan sonra makinenizde bir konumda ```git clone https://github.com/RickyDane/CoDriver``` veya ```gh repo clone RickyDane/CoDriver``` komutunu çalıştırın.
</br></br>
Bu projenin kök dizininde ```cargo tauri dev``` komutunu çalıştırarak CoDriver'ı derleyip çalıştırmaya başlamalısınız.
</br>
tauri-cli'nin kurulu olduğundan emin olun: ```cargo install tauri-cli```
</br>

## Sürüm imzalama

macOS sürüm çıktıları, Gatekeeper'ın yüklenen uygulamanın hasarlı olduğunu bildirmesini önlemek için imzalanmalı ve noter tasdikli olmalıdır. Gerekli GitHub Actions gizli anahtarları ve doğrulama komutları için [macOS imzalama ve noter tasdik işlemleri](https://raw.githubusercontent.com/RickyDane/CoDriver/master/docs/macos-signing-notarization.md) bölümüne bakınız.

## Yıldız Geçmişi

<a href="https://star-history.com/#rickydane/CoDriver&Date">
 <picture>
   <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date&theme=dark" />
   <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date" />
   <img alt="Yıldız Geçmişi Grafiği" src="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date" />
 </picture>
</a>

#### Diğer üçüncü parti yazılımlar
- DragSelect (https://github.com/ThibaultJanBeyer/DragSelect)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-25

---