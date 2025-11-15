<div align="right">
  <details>
    <summary >🌐 Dil</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>


warbleR: Biyoakustik Analizi Kolaylaştırın
================

<!-- README.md dosyası README.Rmd'den üretilmiştir. Lütfen o dosyayı düzenleyin -->
<!-- rozetler: başlangıç -->

[![lifecycle](https://img.shields.io/badge/lifecycle-maturing-brightgreen.svg)](https://lifecycle.r-lib.org/articles/stages.html)
[![status](https://tinyverse.netlify.app/badge/warbleR)](https://CRAN.R-project.org/package=warbleR)
[![Proje Durumu: Aktif Proje kararlı, kullanılabilir bir duruma ulaşmıştır
ve aktif olarak
geliştirilmektedir.](https://www.repostatus.org/badges/latest/active.svg)](https://www.repostatus.org/#active)
[![Lisans: GPL
v3](https://img.shields.io/badge/License-GPLv3-blue.svg)](https://www.gnu.org/licenses/gpl-3.0)
[![CRAN_Durum_Rozeti](https://www.r-pkg.org/badges/version/warbleR)](https://cran.r-project.org/package=warbleR)
[![Toplam
İndirme](https://cranlogs.r-pkg.org/badges/grand-total/warbleR)](https://cranlogs.r-pkg.org/badges/grand-total/warbleR)
[![Codecov test
kapsamı](https://codecov.io/gh/maRce10/warbleR/branch/master/graph/badge.svg)](https://app.codecov.io/gh/maRce10/warbleR?branch=master)
<!-- badges: end -->

<img src="https://raw.githubusercontent.com/maRce10/warbleR/master/man/figures/warbleR_sticker.png" alt="warbleR logo" align="right" width = "25%" height="25%"/>

[warbleR](https://cran.r-project.org/package=warbleR), R'da hayvan akustik sinyallerinin yapısının analizini
kolaylaştırmak amacıyla geliştirilmiştir. Kullanıcılar açık erişimli kuş kayıtlarını toplayabilir veya kendi
verilerini bir iş akışına ekleyerek spektrografik görselleştirme ve
akustik parametrelerin ölçümünü kolaylaştırabilirler.
[warbleR](https://cran.r-project.org/package=warbleR), seewave paketinin
temel ses analiz araçlarını kullanır ve akustik yapı analizi için yeni
araçlar sunar. Bu araçlar akustik sinyallerin toplu analizinde
kullanılabilir.

Paketin temel özellikleri şunlardır:

- Akustik yapı ölçümü için çeşitli araçlar
- Akustik sinyallere seçim tablosunda referans verilerek döngülerle görevlerin uygulanması
- Spektrogramlarla çalışma dizininde görseller oluşturulması, böylece
  kullanıcıların verilerini organize etmesi ve akustik analizleri doğrulaması sağlanır

Paket aşağıdaki işlevleri sunar:

- [Xeno‐Canto](https://xeno-canto.org/) kayıtlarını keşfetmek ve indirmek
- Birden çok ses dosyasını keşfetmek, düzenlemek ve manipüle etmek
- Sinyalleri otomatik olarak tespit etmek (frekans ve zamanda) (daha kapsamlı
  ve kullanışlı bir uygulama için R paketi [ohun](https://docs.ropensci.org/ohun/) incelenebilir)
- Tam kayıtların veya bireysel sinyallerin spektrogramlarını oluşturmak



- Akustik sinyal yapısının farklı ölçülerini çalıştırın
- Ölçüm yöntemlerinin performansını değerlendirin
- Sinyalleri kataloglayın
- Akustik sinyallerdeki farklı yapısal seviyeleri karakterize edin
- Düet koordinasyonunun istatistiksel analizi
- Veritabanlarını ve açıklama tablolarını birleştirin

Fonksiyonların çoğu görevlerin paralelleştirilmesine izin verir,
bu da görevleri birden fazla işlemciye dağıtarak hesaplama
verimliliğini artırır. Analizin her aşamasında performansı değerlendirmek için araçlar da mevcuttur.

## Kurulum

Paketi CRAN'dan aşağıdaki şekilde yükleyin/başlatın:


``` r
install.packages("warbleR")

# load package
library(warbleR)
```

En son geliştirme sürümünü
[github](https://github.com/) üzerinden yüklemek için
R paketine ihtiyacınız olacak
[remotes](https://cran.r-project.org/package=remotes):
``` r
remotes::install_github("maRce10/warbleR")

# load package
library(warbleR)
```

## Kullanım

Paket, ana özelliklerini açıklayan birkaç açıklamalı belge içerir.
[warbleR’ye
Giriş](https://marce10.github.io/warbleR/articles/warbleR.html)
paketin işlevselliklerine genel bir bakış sunar. [Açıklama veri
formatı](https://marce10.github.io/warbleR/articles/annotation_data_format.html)
gerekli giriş açıklamaları için formatın ayrıntılı bir tanımını verir.
Ayrıca, fonksiyonların akustik analiz iş akışında nasıl düzenleneceğine dair örnekler içeren üç ek [paket
açıklama belgesi](https://marce10.github.io/warbleR/articles/) bulunmaktadır.

Paketin tam açıklaması (biraz eski olsa da) şu [dergi
makalesinde](https://besjournals.onlinelibrary.wiley.com/doi/10.1111/2041-210X.12624) bulunabilir.

## Diğer paketler

[seewave](https://cran.r-project.org/package=seewave) ve
[tuneR](https://cran.r-project.org/package=seewave) paketleri, akustik analiz ve manipülasyon için çok çeşitli fonksiyonlar sunar. Genellikle,
halihazırda R ortamına aktarılmış dalga nesneleri üzerinde çalışırlar.
[baRulho](https://cran.r-project.org/package=baRulho) paketi, akustik sinyallerde habitat kaynaklı bozulmayı niceliksel olarak ölçmeye odaklanır ve veri girişi ile çıkışı
[warbleR](https://cran.r-project.org/package=warbleR) ile benzerdir. [Rraven](https://cran.r-project.org/package=Rraven) paketi, R ile [Raven ses analiz
yazılımı](https://www.ravensoundsoftware.com/) ([Cornell Kuşbilim
Laboratuvarı](https://www.birds.cornell.edu/home)) arasında veri alışverişini kolaylaştırır ve Raven’ın R’deki akustik analiz iş akışına açıklama aracı olarak dahil edilmesi için oldukça
faydalı olabilir. [ohun](https://docs.ropensci.org/ohun/) paketi,
ses olaylarının otomatik olarak tespitinde çalışır, tespit rutinlerini teşhis ve optimize etmek için fonksiyonlar sağlar. [dynaSpec](https://cran.r-project.org/package=seewave) ise
dinamik spektrogramlar (yani spektrogram videoları) oluşturmayı sağlar.

## Atıf












Lütfen [warbleR](https://cran.r-project.org/package=warbleR) paketini aşağıdaki şekilde kaynak gösteriniz:

Araya-Salas, M. ve Smith-Vidaurre, G. (2017), *warbleR: hayvan akustik sinyallerinin analizini kolaylaştıran bir r paketi*. Methods Ecol Evol. 8, 184-191.

NOT: Herhangi bir spektrogram oluşturma veya akustik ölçüm fonksiyonu kullanıyorsanız lütfen
[tuneR](https://cran.r-project.org/package=tuneR) ve
[seewave](https://cran.r-project.org/package=seewave) paketlerini de kaynak gösteriniz






---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-15

---