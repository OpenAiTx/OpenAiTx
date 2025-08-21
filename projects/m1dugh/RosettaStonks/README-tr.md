
<div align="right">
  <details>
    <summary >🌐 Dil</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Rosetta Stonks

- [Giriş](#introduction)
- [Kurulum](#install)
  - [Chrome](#chrome-tabanlı-tarayıcılar)
    - [Görsel Rehber](#chrome-tabanlı-tarayıcılar)
  - [Firefox](#firefox-tabanlı-tarayıcılar)
- [Nasıl kullanılır](#how-to-use)
  - [Zaman ekleme](#adding-time)
    - [Temeller](#adding-time-in-foundations)
    - [Akıcılık geliştirici](#adding-time-in-fluency-builder)
  - [Dersi doğrulama](#validating-lesson)
    - [Temeller](#validating-lesson-in-foundations)
    - [Akıcılık geliştirici](#validating-lesson-in-fluency-builder)

## Giriş

RosettaStonks, rosetta stone dil öğrenme platformunda zaman eklemenizi ve dersleri
doğrulamanızı sağlayan bir tarayıcı uzantısıdır.

> RosettaStonks, ve rosetta stone'unuz stonks olur.

## Kurulum

### Chrome tabanlı tarayıcılar

➡️ **Chrome uzantılarını manuel yüklemede yeni misiniz?** [Adım Adım Görsel Kılavuz](https://raw.githubusercontent.com/m1dugh/RosettaStonks/master/INSTALL_GUI.md) adresine göz atın — faydalı ekran görüntüleri içerir! 🖼️

#### 1. GitHub Sürümü ile Kullanma

Uzantıyı chrome tabanlı bir tarayıcıda kullanmak için şunları yapmanız gerekir:

- son sürümden `rosettastonks-chrome.tar.gz` dosyasını
  bilgisayarınıza indirin.
- uzantıyı saklamak için bilgisayarınızda `rosettastonks` adında bir klasör oluşturun
- `rosettastonks` klasöründe aşağıdaki komutu çalıştırın.


```bash
$ tar xvzf /path/to/rosettastonks-chrome.tar.gz
```

2. nix paket yöneticisini kullanma

Önceki komutlar yerine, eğer **flakes** destekleyen bir nix sistemindeyseniz,
aşağıdaki komutları çalıştırabilirsiniz. Bu komutlar, tüm dosyaların bulunduğu
`/tmp/rosettastonks` yolu altında bir klasör kuracaktır.

```bash
$ nix build --out-link "/tmp/rosettastonks" github:m1dugh/RosettaStonks#chrome
```

Klasör artık `/tmp/rosettastonks/` altında kurulu.

**Bu bölüm, github yöntemi veya nix yöntemi kullanıyor olmanızdan bağımsız olarak tüm kullanıcılar içindir.**

Tarayıcınızda:

- `chrome://extensions` adresine gidin
- `Geliştirici modu` seçeneğini işaretleyin
- `Paketlenmemişi yükle`ye tıklayın
- `rosettastonks` klasörünüzü seçin

### Firefox tabanlı tarayıcılar

- En son sürümden `rosettastonks.xpi` dosyasını indirin.
- Alternatif olarak, flake desteği ile nix paket yöneticisi kullanıyorsanız, aşağıdaki komutu çalıştırabilirsiniz.



```bash
$ nix build --out-link "/tmp/rosettatonks.xpi" github:m1dugh/RosettaStonks#mozilla
```

- Tarayıcınızda `about:addons` sayfasına gidin
- Ayarlar düğmesine tıklayın ve `Eklentileri Hata Ayıkla` seçeneğine gidin.
- `Geçici Eklenti Yükle` seçeneğine tıklayın
- Dosya seçicide `/tmp/rosettastonks.xpi` dosyasını seçin.

_Uyarı: Bu yöntem eklentiyi yalnızca geçici olarak yükler, yani tarayıcınızı kapatırsanız
eklenti kaldırılır. Bunun nedeni, firefox politikalarının doğrulanmamış eklentilerin kullanılmasına izin vermemesidir._

## Nasıl Kullanılır

### Zaman Ekleme

#### Foundations'da Zaman Ekleme

`foundations` ürününde zaman eklemek için egzersizlerinize gitmeniz ve
en az bir soruyu yok saymanız veya çözmeniz gerekir. Bunu yaptıktan sonra,
eklenti sayfasında zaman ekleyebileceğiniz bir alan görünmelidir.

#### Fluency builder'da Zaman Ekleme

`fluency builder` ürününde zaman eklemek için egzersizlerinize gitmeniz ve
en az bir egzersizi yanıtlamanız gerekir. Zaman ekleme alanı görünmüyorsa,
herhangi bir zaman isteği yakalanmamış demektir; soruyu yenileyip tekrar
yanıtlamanız gerekir. Zamanın eklenmesi için, zaman eklediğiniz dersi
tamamlamanız gerekir.

_Not: Zaman ekleme alanını görmüyorsanız, Rosetta Stone sitesinde yaptığınız
eylemler geçerli zaman eklenmesini sağlamamıştır; bu nedenle, başka soruları
yanıtlamanız gerekir._

### Dersi Doğrulama

#### Foundations'da Dersi Doğrulama

Bir dersi doğrulamak için, bir ders başlatılır ve tüm sorular
sağ alttaki `yok say` butonuyla geçilir. Tüm sorular görüldükten sonra,
`dersi doğrula` butonuna tıklamak dersi doğrulamalıdır. Eğer olmuyorsa, ana sayfanıza dönün, aynı derse tıklayın, bu


size sormalı `Devam etmek mi yoksa sıfırlamak mı istiyorsunuz?`, her ikisini de seçebilirsiniz ve
dersi tekrar doğrulayabilirsiniz, çalışana kadar. Maksimum 3/4 kez sonra çalışmalıdır.

#### Fluency builder'da dersi doğrulama

Şu anda, rosetta stonks üzerinde ders doğrulama özelliği mevcut değil.

## Uygulamayı oluşturma

### Worker'ı oluşturma

Worker aşağıdaki komut kullanılarak paketlenebilir

```
$ deno task build:worker
```

Bu, `/dist/worker.esm.js` paketlenmiş dosyasını oluşturur ki bu, worker için paketlenmiş dosyadır.

### Ön yüzün derlenmesi

Worker, aşağıdaki komut kullanılarak paketlenebilir


```
$ deno task build:frontend
```

Bu işlem, frontend için paketlenmiş dosya olan `/dist/frontend.esm.js` dosyasını oluşturur.

## Uzantının Paketlenmesi

### Chrome

Chrome için uzantıyı paketlemek üzere aşağıdaki komut çalıştırılabilir:


```
$ make chrome
```

### Firefox

Firefox için uzantıyı paketlemek üzere aşağıdaki komut çalıştırılabilir:

```
$ make firefox
```

Bu işlem, firefox'ta yüklenebilen uzantı dosyası olan `rosettastonks.xpi` dosyasını oluşturacaktır.

📸 Görselleri mi tercih ediyorsunuz? [Görsellerle Chrome Kurulum Rehberi](https://raw.githubusercontent.com/m1dugh/RosettaStonks/master/INSTALL_GUI.md) bağlantısına göz atabilirsiniz.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-21

---