warbleR: Biyoakustik Analizi Kolaylaştırın
================

🌐 **Diller:**  
[English](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=en) |
[Español](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=es) |
[Français](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=fr) |
[Deutsch](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=de) |
[Português](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=pt) |
[Italiano](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=it) |
[Русский](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ru) |
[中文 (简体)](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=zh-CN) |
[中文 (繁體)](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=zh-TW) |
[日本語](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ja) |
[한국어](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ko) |
[हिन्दी](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=hi) |
[ไทย](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=th) |
[Nederlands](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=nl) |
[Polski](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=pl) |
[العربية](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ar) |
[فارسی](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=fa) |
[Türkçe](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=tr) |
[Tiếng Việt](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=vi) |
[Bahasa Indonesia](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=id) |
[অসমীয়া](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=as)

<!-- README.md README.Rmd dosyasından üretilmiştir. Lütfen o dosyayı düzenleyin -->
<!-- badges: start -->

[![lifecycle](https://img.shields.io/badge/lifecycle-maturing-brightgreen.svg)](https://lifecycle.r-lib.org/articles/stages.html)
[![status](https://tinyverse.netlify.app/badge/warbleR)](https://CRAN.R-project.org/package=warbleR)
[![Project Status: Active The project has reached a stable, usable state
and is being actively
developed.](https://www.repostatus.org/badges/latest/active.svg)](https://www.repostatus.org/#active)
[![License: GPL
v3](https://img.shields.io/badge/License-GPLv3-blue.svg)](https://www.gnu.org/licenses/gpl-3.0)
[![CRAN_Status_Badge](https://www.r-pkg.org/badges/version/warbleR)](https://cran.r-project.org/package=warbleR)
[![Total
Downloads](https://cranlogs.r-pkg.org/badges/grand-total/warbleR)](https://cranlogs.r-pkg.org/badges/grand-total/warbleR)
[![Codecov test
coverage](https://codecov.io/gh/maRce10/warbleR/branch/master/graph/badge.svg)](https://app.codecov.io/gh/maRce10/warbleR?branch=master)
<!-- badges: end -->

<img src="https://raw.githubusercontent.com/maRce10/warbleR/master/man/figures/warbleR_sticker.png" alt="warbleR logo" align="right" width = "25%" height="25%"/>

[warbleR](https://cran.r-project.org/package=warbleR), R'da hayvan akustik sinyallerinin yapısının analizini kolaylaştırmak için tasarlanmıştır.
Kullanıcılar açık erişimli kuş kaydı toplayabilir ya da kendi verilerini
akustik parametrelerin spektrografik görselleştirilmesi ve ölçülmesini kolaylaştıran bir iş akışına girebilirler.
[warbleR](https://cran.r-project.org/package=warbleR), seewave paketinin temel ses analizi araçlarını kullanır ve akustik yapı analizi için yeni
araçlar sunar. Bu araçlar, akustik sinyallerin toplu analizinde kullanılabilir.

Paketin temel özellikleri şunlardır:

- Akustik yapının ölçümü için çeşitli araçlar
- Bir seçim tablosunda referans verilen akustik sinyaller üzerinden görevleri uygulamak için döngülerin kullanımı
- Kullanıcıların verileri düzenlemesine ve akustik analizleri doğrulamasına olanak tanıyan çalışma dizininde spektrogramlarla görüntü üretimi

Paket şu işlevleri sunar:

- [Xeno‐Canto](https://xeno-canto.org/) kayıtlarını keşfetme ve indirme
- Birden fazla ses dosyasını keşfetme, düzenleme ve işleme
- Sinyalleri otomatik olarak algılama (frekans ve zamanda) (ancak daha kapsamlı ve kullanıcı dostu bir uygulama için [ohun](https://docs.ropensci.org/ohun/) R paketine bakınız)
- Tüm kayıtların ya da bireysel sinyallerin spektrogramlarını oluşturma
- Akustik sinyal yapısının farklı ölçümlerini gerçekleştirme
- Ölçüm yöntemlerinin performansını değerlendirme
- Sinyalleri kataloglama
- Akustik sinyallerde farklı yapısal seviyeleri karakterize etme
- Düet koordinasyonunun istatistiksel analizi
- Veritabanlarını ve açıklama tablolarını birleştirme

Fonksiyonların çoğu, görevlerin paralel olarak yürütülmesine olanak tanır ve bu da görevlerin birden fazla işlemciye dağıtılarak hesaplama









verimlilik. Analizin her adımındaki performansı değerlendirmek için araçlar da mevcuttur.

## Kurulum

Paketi CRAN üzerinden aşağıdaki şekilde kurun/yükleyin:


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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-13

---