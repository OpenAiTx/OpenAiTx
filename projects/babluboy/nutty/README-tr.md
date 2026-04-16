
<div align="right">
  <details>
    <summary >🌐 Dil</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Nutty [![Çeviri durumu](https://hosted.weblate.org/widgets/nutty/-/svg-badge.svg)](https://hosted.weblate.org/engage/nutty/?utm_source=widget) [![Derleme Durumu](https://travis-ci.org/babluboy/nutty.svg?branch=master)](https://travis-ci.org/babluboy/nutty) [![Snap Durumu](https://build.snapcraft.io/badge/babluboy/nutty.svg)](https://build.snapcraft.io/user/babluboy/nutty) [![Bağış Yap](https://img.shields.io/badge/Donate-PayPal-green.svg)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=FZP8GK839VGQC)
Bir Ağ Aracı

Yazar: Siddhartha Das

elementary OS için ağ ile ilgili temel bilgileri sağlamak amacıyla yapılmış basit bir uygulama. Sunulan bilgiler aşağıdaki sekmelerde yer almaktadır.<br>
1. Bilgilerim: Cihazın ağ kartı hakkında temel ve ayrıntılı bilgiler sağlar<br>
2. Kullanım: Ağ veri kullanımını iki görünümde sunar - geçmiş kullanım ve mevcut kullanım<br>
3. Hız: Yükleme ve indirme hızlarını kontrol edin ve bir hosta olan rota sürelerini alın<br>
4. Portlar: Yerel cihazda aktif portlar ve bunları kullanan uygulamalar hakkında bilgi sağlar<br>
5. Cihazlar: Ağda bağlı diğer cihazları izler, uyarır ve bilgi sağlar<br>

Nutty web sitesinde özellikler, kısayollar, Ubuntu ve desteklenen diğer dağıtımlar için kurulum rehberleri vb. detaylara bakabilirsiniz : <br>
https://babluboy.github.io/nutty/

## Kaynaktan Derleme, Test Etme ve Kurulum

Derleme için aşağıdaki bağımlılıklara ihtiyacınız olacak:
* libgranite-dev
* libnotify-dev
* libxml2-dev
* libxml2-utils
* libgee-0.8-dev
* libgtk-3-dev
* libsqlite3-dev
* meson
* valac

Çalıştırmak için bu bağımlılıklara ihtiyacınız olacak:
* net-tools
* nethogs
* nmap
* traceroute
* vnstat
* curl
* wireless-tools
* iproute2
* pciutils

Bazen vnstat yüklemeden sonra başlatılmaz, vnstat daemon'unu başlatmak için uygun init sistem komutunu kullanın, örn. `sudo systemctl enable vnstat`

Yapı ortamını yapılandırmak için `meson build` komutunu ve derlemek için `ninja test` komutunu çalıştırın

```
git clone https://github.com/babluboy/nutty.git
cd nutty
meson build --prefix=/usr
cd build
ninja
```
Kurulum için `sudo ninja install` komutunu kullanın, ardından `com.github.babluboy.nutty` komutuyla çalıştırın.


```
sudo ninja install
com.github.babluboy.nutty
```

Kaldırmak için, derleme dizinine gidin ve çalıştırın
```
sudo ninja uninstall
```

### Deb paketinden Kurulum

Nutty'yi `.deb` paketinden kurmak için, yukarıda belirtilen tüm Nutty çalışma bağımlılıklarının yüklü olduğundan emin olun (yapı bağımlılıklarına gerek yoktur). Ardından aşağıdaki komutu çalıştırın
```bash
sudo dpkg -i <deb-package-name>.deb
```

Ve `.deb` paketi ile yüklenmiş Nutty'i kaldırmak için şunu çalıştırın
```bash
sudo apt autoremove com.github.babluboy.nutty
```
Eğer Nutty'nin `.deb` paketini doğrudan kendiniz derlemek istiyorsanız, yukarıdaki derleme bağımlılıklarını yükleyin ve ardından çalıştırın

```bash
git clone https://github.com/babluboy/nutty.git
cd nutty
dpkg-buildpackage -us -uc
cd ..
```


## Screenshot

![screenshot](https://raw.githubusercontent.com/babluboy/nutty/gh-pages/images/Nutty_Device_Alert.png)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-16

---