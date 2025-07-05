<h1 align="center">Kullanıma Hoş Geldiniz&nbsp;&nbsp;Cursor Auto Helper 👋</h1>
<p>
  <img alt="Version" src="https://img.shields.io/badge/version-2.3.0-blue.svg?cacheSeconds=2592000" />
  <img alt="License: MIT" src="https://img.shields.io/badge/License-MIT-yellow.svg" />
  <img alt="Cursor Version" src="https://img.shields.io/badge/Cursor-0.48.x%20%E8%87%B3%201.0.0-blue.svg" />
</p>

> Cursor otomatik devam aracı, Cursor otomatik yeniden deneme, Cursor otomatik onay, Cursor kullanım istatistikleri, Cursor geliştirme aracı, Cursor yardımcı aracı, Cursor otomasyon aracı, Cursor tema ayarları, Cursor Otomatik Devam Aracı, Cursor Otomatik Yeniden Deneme Aracı, Cursor Otomatik Onay Aracı, Cursor Kullanım İstatistikleri Aracı, Cursor Verimlilik Aracı, Cursor Otomasyon Aracı, Cursor Tema Ayarları, 25 araç çağrısından sonra Cursor, Cursor Araç Çağrı Limiti🔧🤖🚀
> 

## 🏠 [Anasayfa](https://github.com/pen9un/cursor-auto-helper)

Cursor Auto Helper, Cursor IDE için özel olarak geliştirilmiş bir otomasyon ve geliştirme aracıdır. Gerçek zamanlı kullanım göstergesi, 25 konuşma sınırının otomatik yönetimi, ağ bağlantı hatası, onay bildirimleri gibi durumları otomatik olarak ele alır ve geliştirme deneyiminizi daha akıcı hale getirir.

**Video Tanıtımı:** [Cursor Auto Helper Tanıtım Videosu](https://www.bilibili.com/video/BV1cajKzCEzv/)

Yüksek kaliteli promptlar ve iyi planlanmış proje gereksinimleriyle, bu program Cursor'un herhangi bir insan müdahalesine gerek kalmadan bir projeyi otomatik olarak tamamlamasını sağlar.

> 🔒 **Sürüm Uyumluluğu**: Şu anda Cursor 0.49.6 ve Cursor 1.0.0 sürümlerinde geliştirme ve testler tamamlanmıştır, teorik olarak Cursor 0.48.x - 1.0.0 sürümleriyle uyumludur.

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/cursor-auto-helper.png" alt="cursor-auto-helper" />

## 📖Güncelleme Günlüğü

- 2025-06-01 v2.3 sürümü yayınlandı, Cursor tema ayarları eklendi, kod enjeksiyon kararlılığı iyileştirildi, kullanım göstergesi resmi format ile uyumlu hale getirildi
- 2025-05-21 v2.1 sürümü yayınlandı, mimari yeniden tasarlandı, çoklu platform desteği eklendi, gerçek zamanlı kullanım göstergesi gibi özellikler eklendi
- 2025-04-25 v1.0 sürümü tamamlandı, 25 konuşma sınırı, ağ bağlantı hatası, onay bildirimleri gibi durumları otomatik olarak ele alma özellikleri eklendi
- 2025-04-20 Proje başlatıldı

## 🌟 Cursor Auto Helper En İyi Pratikler

Not: Aşağıdaki dokümantasyon Cursor gibi AI araçlarıyla yardımcı olarak oluşturulabilir, manuel doğrulama ve düzenleme gereklidir.

**ADIM 1:** Ayrıntılı proje sistem gereksinimleri tasarımı (gereksinimler ne kadar net olursa, proje kalitesi o kadar yüksek olur), yüksek kaliteli proje geliştirme promptları yazın **SYSTEM.md**

**ADIM 2:** **SYSTEM.md**'ye göre yüksek kaliteli sistem geliştirme tasarım dokümanı oluşturun **DESIGN.md**

**ADIM 3:** **SYSTEM.md** ve **DESIGN.md**'ye göre yüksek kaliteli geliştirme planı dokümanı oluşturun **TODOLIST.md**

**ADIM 4:** **Cursor Auto Helper** kullanarak, **SYSTEM.md**, **DESIGN.md**, **TODOLIST.md** dosyalarını belirtin ve otomatik devam geri bildirim promptlarını kullanarak Cursor'un geliştirme planına uygun şekilde projeyi tamamen otomatik olarak tamamlamasını sağlayın

**Cursor Auto Helper Otomatik Devam Geri Bildirim Promptu:**

```
@SYSTEM.md @DESIGN.md @TODOLIST.md Lütfen sonraki fonksiyon geliştirmelerinde TODOLIST geliştirme planına kesinlikle uyunuz ve TODOLIST geliştirme planını gerçek zamanlı olarak güncelleyiniz, her iş tamamlandığında bana "devam edilsin mi" diye sormanız gerekiyor, proje tamamlandığında "proje geliştirme tamamlandı" şeklinde dönüş yapınız
```

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/guide.png" alt="guide" />

## 🚀 Kullanım Talimatları

Star ile destek vermekten memnuniyet duyarız, herhangi bir sorun için lütfen [Issues](https://github.com/pen9un/cursor-auto-helper/issues) bölümüne yazın.

### 📝 Konfigürasyon Dosyası Açıklaması

Konfigürasyon dosyası `config.ini` **otomasyon davranışlarını özelleştirmek için kullanılır** (ihtiyaca göre ayarlayıp test edebilirsiniz), aşağıdaki konfigürasyon seçeneklerini destekler:

#### Temel Ayarlar
```ini
[common]
log_enable = true     # Log kaydı etkin mi, log kaydı istemiyorsanız false yapabilirsiniz

[cursor]
path = C:\Path\To\Cursor.exe  # Cursor IDE'nin kurulu olduğu yol, program Cursor yolunu otomatik bulur, bulamazsa uyarı verir, burayı düzenleyebilirsiniz
```

#### Otomatik Aksiyon Ayarları
Her otomatik aksiyon, `actionadı.` öneki ile başlar, aşağıdaki alanlar desteklenir:

- `type`: Aksiyon tipi
  - `click`: Butona tıkla
  - `input_and_submit`: Girdi ve gönder

- `text` / `text_list`: Eşleşen metin içeriği
  - `text`: Tek bir dize
  - `text_list`: | ile ayrılmış birden fazla dize, sayfa içeriği bunlardan herhangi birini içeriyorsa tetiklenir

- `button_selector`: Tıklanacak butonun CSS seçicisi (sadece `click` tipinde gerekli)
- `button_text`: Butonun metin içeriği (isteğe bağlı, butonu daha ayrıntılı belirlemek için)
- `input_box_selector`: Girdi kutusunun CSS seçicisi (`input_and_submit` tipinde gerekli)
- `input_content`: Otomatik olarak girilecek içerik
- `submit_btn_selector`: Gönderme butonunun CSS seçicisi
- `delay`: Aksiyon gerçekleşmeden önceki gecikme süresi (milisaniye), sayfa renderını beklemek için kullanılabilir

##### Konfigürasyon Örneği
```ini
[auto_actions]
# Bağlantı hatası durumunda otomatik yeniden deneme
action_retry.type = "click"
action_retry.text = "Connection failed. If the problem persists, please check your internet connection or VPN"
action_retry.button_selector = "div.anysphere-secondary-button"
action_retry.button_text = "Try again"
action_retry.delay = 3000

# 25 araç çağrısından sonra
action_continue.type = "input_and_submit"
action_continue.text_list = "agent after 25 tool calls"
action_continue.input_box_selector = ".full-input-box.undefined"
action_continue.input_content = "请继续"
action_continue.submit_btn_selector = ".codicon-arrow-up-two"
```
action_continue.delay = 1000

# Otomatik Onayla ve Devam Et
action_need_continue.type = "input_and_submit"
action_need_continue.text_list = "是否需要|是否继续|需要我|请告诉我"
action_need_continue.input_box_selector = ".full-input-box.undefined"
action_need_continue.input_content = "请继续后续开发，并实时记录更新开发进度"
action_need_continue.submit_btn_selector = ".codicon-arrow-up-two"
action_need_continue.delay = 1000
```

> **Not:**
> 1. Her action'ın adı (örn. `action_retry`, `action_continue`) özelleştirilebilir, ancak aynı action'a ait tüm alanların öneki tutarlı olmalıdır.
> 2. CSS seçicilerin doğru olduğundan emin olmak için tarayıcı geliştirici araçlarını kullanmanız önerilir.
> 3. Yapılandırma dosyası değiştirildikten sonra programı yeniden başlatmak gerekir.

## 🎯 Uygulama Senaryoları

### 💼 Uzun Diyalog Geliştirme
- 25 konuşma sınırını otomatik olarak işler, kesintisiz uzun diyalog geliştirmeyi destekler, diyalog akışını otomatik devam ettirir, geliştirme verimliliğini artırır.

### 👥 Düzensiz Ağ Koşulları
- Ağ hatalarını otomatik olarak algılar, bağlantıyı akıllıca yeniden dener, diyalogu otomatik olarak geri yükler, geliştirme sürecinin kesintisiz olmasını sağlar.

### 🏢 Onay Gerektiren Senaryolar
- Onay bildirimlerini akıllıca algılar, otomatik işler, manuel müdahaleyi azaltır.

### 📚 Kullanım İzleme
- Diyalog sayısını gerçek zamanlı olarak izler, Cursor kullanımını takip eder, kullanım verilerini kaydeder, verimliliği optimize eder.

Terminal kullanım ekranı:

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/cursor-auto-helper-1.png" alt="cursor-auto-helper-1" />

Cursor IDE kullanım ekranı:

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/cursor-auto-helper-logs.png" alt="cursor-auto-helper-logs" />

## 🌟 Özellik Açıklamaları

### 🤖 Otomatik Uzun Diyalog Devamı
- Cursor'ın 25 konuşma sınırını otomatik olarak işler, çoklu tur kesintisiz diyaloglara destek verir.

### 🎨 Otomatik Bağlantı Yeniden Deneme
- Ağ bağlantı hatalarını otomatik olarak algılar, akıllıca yeniden dener, bağlantı durumunu gerçek zamanlı izler.

### 📱 Otomatik Onay Bildirimi
- Birden fazla onay bildirim senaryosunu akıllıca tanır, onay pencerelerini otomatik olarak işler.
- Özelleştirilebilir onay içeriği ve yanıt desteği ile manuel müdahaleyi azaltır.
- Esnek kural yapılandırması ile çeşitli geliştirme süreçlerine uyum sağlar.

### 🛍️ Kullanım İstatistikleri
- Diyalog sayısı ve kullanım miktarını gerçek zamanlı olarak kaydeder.
- Kullanım verilerinin görsel gösterimi ile analiz ve optimizasyonu kolaylaştırır.
- Terminalde renkli günlükler, IDE kullanım paneli desteğiyle kullanılabilirliği artırır.

### 💡 Günlük Sistemi
- Çok seviyeli günlükler (DEBUG/INFO/SUCCESS/WARNING/ERROR/CRITICAL), terminalde renkli çıktı sağlar.
- Günlük dosyaları tarihe göre otomatik oluşturulur, dosya kaydı ve sürükle-bırak panel desteği mevcuttur.
- Gerçek zamanlı panel, geliştiricilerin izlemesi ve geriye dönük incelemesi için kolaylık sunar.

### 🔒 Sürüm Uyumluluğu ve Performans Optimizasyonu
- Cursor 0.49.6 tabanlı geliştirilmiştir, çekirdek işlevler tam test edilmiştir.
- Belirli sürümler için optimize edilmiştir, Cursor sürüm güncellemeleri sürekli takip edilir.
- Yüksek kararlılık, iyi uyumluluk; üretim ortamlarında kullanıma uygundur.

## 🔮 Sonuç Gösterimi

### 🤖 Otomatik Diyalog Devamı

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/auto-continue.png" alt="auto-continue" />

### 🚀 Cursor Otomatik Tamamlama Programı Gösterimi

Proje gereksiniminden tam uygulamaya, tamamen otomatik süreç:

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/auto-complete.png" alt="auto-complete" />

## 🤝 Yazar

👤 **pen9un**

* Web Sitesi: https://github.com/pen9un/
* Github: [@pen9un](https://github.com/pen9un)

## ❤️ Destek

Eğer bu projeyi faydalı bulduysanız, ücretsiz bir ⭐️⭐️ bırakın

## ✨Star Geçmişi

[![Star History Chart](https://api.star-history.com/svg?repos=pen9un/cursor-auto-helper&type=Date)](https://star-history.com/#pen9un/cursor-auto-helper&Date)

## 💹 Ziyaretçi İstatistikleri

![Visitor Count](https://profile-counter.glitch.me/pen9un/count.svg) 


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---