
<div align="right">
  <details>
    <summary >🌐 Dil</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# WineZGUI

#### Zenity kullanan Wine GUI - Oyna ve Paylaş!

![](https://raw.githubusercontent.com/fastrizwaan/WineZGUI/main/assets/winezgui.svg) <a href="https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI"><img width='240' alt='Flathub'dan İndir' src='https://dl.flathub.org/assets/badges/flathub-badge-en.png'/></a>

![](https://github.com/fastrizwaan/WineZGUI/releases/download/0.97.12/winezgui-0.97.14.png)

## WineZGUI Nedir

WineZGUI (Wine-Zee-Goo-Eee olarak telaffuz edilir) wine ile Windows oyunlarını kolayca oynamak için bir wine arayüzüdür. Zenity kullanarak daha kolay bir wine oyun deneyimi için Wine Prefix Yönetimi ve Linux Masaüstü Entegrasyonu sağlayan Bash betikleri koleksiyonudur. Dosya Yöneticisi (Nautilus gibi) üzerinden Direct play (kurulmamış) EXE uygulaması veya oyunu hızlı başlatmaya ve her Windows EXE dosyası için ayrı bir wine prefix oluşturmaya olanak tanır.

## Neden WineZGUI?

1. Dosya yöneticisinden Windows oyunları veya exe dosyalarını çalıştırır.
2. Kolay erişim için uygulama kısayolu oluşturur.
3. Prefix ayarlamaya değil oyun oynamaya odaklanır.
4. Prefixleri yedekler ve daha sonra geri yükler.
5. Paylaşmak için Oyun Paketleri oluşturur (prefix+oyun)

## Nasıl çalışır

1. Bir Windows binary veya exe WineZGUI ile açıldığında, 
2. Yeni bir prefix oluşturur (şablonu kopyalar) ve EXE dosya adıyla masaüstü kısayolu oluşturur.
3. Kullanıcı betiği başlattığında, exe başlatılır.
4. Eğer bir kurulum ise, yüklenen exe'yi algılar ve Oyunlar menüsü kategorisinde kısayollar oluşturur.

## Bir Oyun veya Programı başka bir sürücü veya dizinde nasıl çalıştırılır

Terminalinizi açın ve şunu yazın:

`flatpak override --user --filesystem=/path/to/your/drive io.github.fastrizwaan.WineZGUI`

### WineZGUI'nin Kurulumu

WineZGUI, Flathub'da Flatpak olarak mevcuttur:

<a href="https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI"><img width='240' alt='Flathub'dan İndir' src='https://dl.flathub.org/assets/badges/flathub-badge-en.png'/></a>


Flathub WineZGUI yalnızca Masaüstü, Belgeler, İndirilenler, Müzik, Resimler, Videolar dizinlerine erişebilir. Diğer konumlardan veya başka bağlı bölümlerden/sürücülerden dosyalara erişmek için, ya dosyaları bahsedilen dizinlere (İndirilenler vb.) kopyalamanız gerekir ya da okuma izni verilmelidir; bu izin Flatseal uygulaması veya komut satırı ile `flatpak --user override --filesystem=host:ro io.github.fastrizwaan.WineZGUI` komutuyla verilebilir.

Flatpak sürümünü kullanmanızı şiddetle tavsiye ederim, çünkü dağıtım tabanlı wine (wine-staging) sürekli güncellenir ve oyunlar birkaç günde bir bozulabilir. Flathub'dan wine stable kullanmak daha iyidir veya dağıtım paketlerinden wine stable 5.0 veya 7.0 kullanabilirsiniz.

#### [Desteklenen Linux dağıtımlarında](https://flatpak.org/setup/) WineZGUI flatpak kurulumu

WineZGUI tarafımdan flatpak-wine paketinde paketlenmiştir. [WineZGUI Flathub](https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI) diğer flatpakım şimdi kullanımdan kaldırıldı [flatpak-wine](https://github.com/fastrizwaan/flatpak-wine) 

### Bir Linux sisteminde KURULUM için, bkz. [Gereksinimler](https://github.com/fastrizwaan/WineZGUI#requirements)

Kurulum anlıktır, çünkü birkaç dosyayı belirli dizinlere kopyalar.

##### Sürüm 0.99.13

Kaynağı indirin [WineZGUI-0.99.13.tar.gz](https://github.com/fastrizwaan/WineZGUI/archive/refs/tags/0.99.13.tar.gz) veya `git tag 0.99.13` kullanın

##### tar.gz kullanarak

```
wget https://github.com/fastrizwaan/WineZGUI/archive/refs/tags/0.99.13.tar.gz
tar -zxvf 0.99.13.tar.gz
cd WineZGUI-0.99.13
sudo ./setup --install ; #systemwide
```

##### git etiket 0.99.13

```
git clone --depth 1 --branch 0.99.13 https://github.com/fastrizwaan/WineZGUI.git
cd WineZGUI
sudo ./setup --install ; #systemwide
```

##### Geliştirme sürümü

```
git clone https://github.com/fastrizwaan/WineZGUI.git
cd WineZGUI
sudo ./setup --install ; #systemwide
```

### WineZGUI'nin Kaldırılması

##### Flatpak ile kaldırma

```
flatpak remove io.github.fastrizwaan.WineZGUI
```

##### Sistem kaldırma

Aynı kurulum kaynak dizininden `uninstall` komutunu çalıştırın

```
sudo ./setup --uninstall
```

## Gereksinimler

`wine` - ana program

`winetricks` - wine eklenti betiği olmalı

`perl‑image‑exiftool` - uygulama/oyun adını çıkarmak için

`icoutils` - exe dosyasından simge çıkarmak için

`gnome-terminal` - (isteğe bağlı) prefix dizinine kabukta erişmek için

## Linux İşletim Sistemi için Gereksinimleri Yükleyin

### Flatpak Destekli Dağıtımlar

Tüm bağımlılıkları içeren [flatpak-wine](https://github.com/fastrizwaan/flatpak-wine/releases) paketini edinin. Wine paketlemeyen dağıtımlar için faydalıdır.

```
flatpak --user remote-add --if-not-exists flathub https://flathub.org/repo/flathub.flatpakrepo
flatpak --user -y install flathub org.winehq.Wine/x86_64/stable-24.08
```

## Çalışma Zamanı Bağımlılıkları:

### Fedora 36

`sudo dnf install zenity wine winetricks perl-Image-ExifTool icoutils gnome-terminal wget zstd samba-winbind-clients.x86_64 samba-winbind-clients.i686`

### Debian / Ubuntu / Linux Mint

```
sudo dpkg --add-architecture i386 && sudo apt update
sudo apt install zenity wine wine32 wine64 winetricks libimage-exiftool-perl icoutils gnome-terminal wget zstd winbind
```

### Solus

```
sudo eopkg it zenity wine wine-32bit winetricks perl-image-exiftool icoutils gnome-terminal wget zstd diffutils samba-devel
```

### Arch Linux / EndeavourOS

```
sudo pacman -Sy zenity wine winetricks perl-image-exiftool icoutils gnome-terminal wget \
                lib32-alsa-plugins lib32-libpulse lib32-openal zstd samba
```

#### XBOX uyumlu denetleyiciler

xbox 360 uyumlu denetleyiciler için çekirdek sürücülerini https://github.com/paroj/xpad adresinden derleyin ve kurun


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-28

---