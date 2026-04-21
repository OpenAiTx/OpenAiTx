
<div align="right">
  <details>
    <summary >🌐 Dil</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Annotator

<p align="center">
  <a href="https://appcenter.elementary.io/com.github.phase1geo.annotator">
    <img src="https://appcenter.elementary.io/badge.svg" alt="AppCenter'da edinin"/>
  </a>
</p>

![<center><b>Ana Pencere - Açık Tema</b></center>](https://raw.githubusercontent.com/phase1geo/Annotator/master/data/screenshots/screenshot-editor.png "Elementary OS için Görsel Anotasyonu")

## Genel Bakış

Görüntülerinizi anotasyonlayın ve bir resim 1000 kelime söylesin.

- Dosya sisteminden, panodan veya ekran görüntüsü oluşturup anotasyon yapmak için görüntü yükleyin.
- Görüntü detaylarını vurgulamak için şekiller, çıkartmalar, resimler, metin, çizimler ve diğer açıklama öğeleri ekleyin.
- Görüntü detaylarını geliştirmek için büyüteçler ekleyin.
- Verileri gizlemek için görüntünün belirli kısımlarını bulanıklaştırın.
- Kırpma, yeniden boyutlandırma ve görüntü kenarlıkları ekleyin.
- Renkleri, çizgi kalınlığını ve yazı tipi detaylarını kontrol edin.
- Yakınlaştırma desteği.
- Yüklenen bir görüntüde renk seçici desteği.
- Herhangi bir değişikliğin sınırsız geri al/yeniden yap desteği.
- Anotasyonlu görüntünün PNG kopyalarını sürükleyip bırakma.
- JPEG, PNG, TIFF, BMP, PDF, SVG ve WebP görüntü formatlarına dışa aktarma desteği.
- Anotasyonlu görüntüyü panoya kopyalama desteği.
- Yazıcı desteği.

## Kurulum

### Debian (kaynak koddan)

Annotator'ı derlemek için aşağıdaki bağımlılıklara ihtiyacınız olacak:

- meson
- valac
- debhelper
- gobject-2.0
- glib-2.0
- libgee-0.8-dev
- libgranite-7-dev
- libgtk-4-dev
- libxml2-dev
- libarchive-dev
- libwebp-dev

Annotator'ı kaynak koddan kurmak için `./app install` komutunu çalıştırın.

Annotator'ı çalıştırmak için `com.github.phase1geo.annotator` komutunu çalıştırın.

### Ubuntu (PPA)

@PandaJim tarafından bakımı yapılan [PPA](https://launchpad.net/~ubuntuhandbook1/+archive/ubuntu/annotator/) kullanabilirsiniz. PPA, Ubuntu 20.04+ sürümlerini destekler. Aşağıdaki komutları sırayla girin

```
sudo add-apt-repository ppa:ubuntuhandbook1/annotator
sudo apt update
sudo apt install com.github.phase1geo.annotator
```

### Arch Linux

Eğer bir Arch Linux kullanıcısıysanız, bir
[AUR paketi](https://aur.archlinux.org/packages/annotator/)
`annotator` mevcut:

```
% yay -S annotator
```

### Flatpak

Ek olarak, Annotator Flatpak üzerinden kurulabilir ve çalıştırılabilir.

Elementary Flatpak'ı kaynak koddan derlemek için `./app elementary` komutunu çalıştırın.

Flathub Flatpak'ı kaynak koddan derlemek için `./app flathub` komutunu çalıştırın.

Sonrasında, şu şekilde çalıştırabilirsiniz: `./app run-flatpak`.

<p align="center">
  <a href="https://appcenter.elementary.io/com.github.phase1geo.annotator">
    <img src="https://appcenter.elementary.io/badge.svg" alt="AppCenter'da edinin"/>
  </a>
</p>

## Katkı Sağlayanlar

`document-edit-symbolic.svg` ve `image-crop-symbolic.svg` dosyalarını
[elementary/icons](https://github.com/elementary/icons/tree/main/actions/symbolic) adresinden
GPL v3.0 lisansı şartları altında içermektedir.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-21

---