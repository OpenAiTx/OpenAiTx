# Gantt

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
Vue tabanlı geliştirilen bir Gantt diyagramı gösterimi, takım çalışması, görev bölümlendirme gibi çevik senaryolarda kullanılabilir.

Gruplamayı destekler
Sürükle ve bırak destekler
Genişletme destekler
Yüzde destekler
Zaman aralığı desteği: gün, hafta, ay
Şu anda yalnızca birinci seviye gruplama yazılmıştır, gelecekteki ikinci veya çoklu seviye gruplama ihtiyacını önlemek için önceki bir gönderide bazı kodlar yeniden yapılandırıldı, çoklu seviye gruplamayı destekler, ancak mevcut sürümde geliştirilmemiştir.

Avantajlar: Sürükle-bırak, genişletme ve ilerleme değişikliklerinde veriler anlık olarak güncellenmez, işlemden sonra güncellenir, bu da performans kaybını azaltır.
           Düzenleme, silme, ekleme işlemlerinde ise tüm instancelar topluca yeniden düzenlenmez, sadece değişen kısımlar eklenir, silinir veya güncellenir.

Yeniden organizasyon hazırlığı yapılmakta, bileşenleştirme için hazırlık yapılıyor, şu an projede kullanmak için yalnızca bu projedeki `gant.vue` dosyasını dahil etmeniz yeterli.
Toplu veri içe/dışa aktarma yöntemleri yazılmıştır, doğrudan kopyalayabilirsiniz!~
```

### Güncelleme Açıklamaları

- Düzenleme desteği eklendi
- Silme desteği eklendi
- Dikey kaydırma yapılamama hatası düzeltildi (çift yönlü kaydırma eklendi) [#4](https://github.com/GGBeng1/Gantt/issues/4)
- elementUI kaynaklı hata düzeltildi
- Zaman aralığı ile ilgili sorunlar [#5](https://github.com/GGBeng1/Gantt/issues/5)
- Şu anda aralık yapılandırmasını değiştirerek başka aralıklar (örneğin saat eklemek gibi) sağlanamıyor. Çünkü başlatma sırasında bazı ayarlar sabitleniyor, gelecekte API olarak açılacak şekilde değiştirilecek.

### Örnekleri Görüntüle

[demo](https://ggbeng1.github.io/Gantt/#/) adresine bakın.

### Gösterim

<img src="https://raw.githubusercontent.com/GGBeng1/Gantt/master/public/demo.png" alt="">

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---