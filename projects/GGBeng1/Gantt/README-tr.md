# Gantt
<div style="text-align: center"><p><a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> </p></div>
## Kurulum

```
yarn install
```

### Çalıştırma

```
yarn run serve
```

### Açıklama

```
Vue tabanlı geliştirilen bir Gantt diyagramı gösterimi, ekip işbirliği, görev bölümlendirme gibi çevik senaryolarda kullanılabilir.

Gruplamayı destekler
Sürükle ve bırak özelliğini destekler
Genişletmeyi destekler
Yüzdeyi destekler
Zaman aralığı desteği: gün, hafta, ay
Şu anda yalnızca birinci seviye gruplama yazıldı, gelecekte ikinci veya çoklu seviye gruplama ihtiyacını önlemek için son gönderimde bazı kodlar yeniden yapılandırıldı, çoklu seviye gruplamayı destekler, ancak mevcut sürümde geliştirilmedi

Avantajları: Sürükle, genişlet, ilerlemeyi düzenleme gibi işlemlerde veriler gerçek zamanlı güncellenmez, işlem sonrası güncellenir, bu da performans kaybını azaltır.
      Düzenleme, silme, ekleme işlemlerinde tüm örnekler üzerinde yinelemeli değişiklik yapılmaz, yalnızca değiştirilen kısımlar eklenir, silinir veya güncellenir.

Yeniden düzenlemeye hazırlanıyor ve bileşenleştirme için hazırlık yapılıyor, şu anda projede kullanmak için sadece bu projedeki `gant.vue` dosyasını dahil etmek yeterlidir.
Toplu veri içe ve dışa aktarma yöntemi hazır, doğrudan kopyalanabilir!~
```

### Güncelleme Notları

- Düzenlemeyi destekler
- Silmeyi destekler
- Dikey kaydırılamama hatası düzeltildi (aynı anda iki yönlü kaydırma eklendi) [#4](https://github.com/GGBeng1/Gantt/issues/4)
- elementUI kaynaklı hata düzeltildi
- Zaman aralığı ile ilgili sorunlar [#5](https://github.com/GGBeng1/Gantt/issues/5)
- Şu anda aralık yapılandırmasını değiştirerek başka aralıklar (ör. saat ekleme gibi) sağlanamaz. Çünkü başlatma sırasında bazı ayarlar sabitlenmiştir, ileride API olarak sunulmak üzere değiştirilecektir.

### Demo Görüntüle

[demo](https://ggbeng1.github.io/Gantt/#/) adresine bakın

### Gösterim Görseli

<img src="https://raw.githubusercontent.com/GGBeng1/Gantt/master/public/demo.png" alt="">

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-01

---