
<div align="right">
  <details>
    <summary >🌐 Dil</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# DIY Akıllı Ev Aile Takvimi (Skylight Klonu)

![Sklylight calendar](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/assets/main_view.jpeg)
![DIY Skylight](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/assets/sky2.png)

## 📖 Giriş

Eşim son zamanlarda sosyal medyada akıllı ev takvimleri (Skylight, Cozyla, Hearth) ile ilgili reklam bombardımanına tutuldu ve birine 300 doların üzerinde harcamaya hazırdı. Ona izin vermeden önce, bu ürünleri araştırmam için bana bir şans vermesini istedim.
Çoğu cihazın benzer işlevsellik sunduğunu, ancak fiyatlarının önemli ölçüde farklılık gösterdiğini fark ettim. En önemlisi, **Home Assistant** ile uygulayamayacağım olağanüstü bir özellik de görmedim.

**Hedef:** WAF onaylı (Eş Kabul Faktörü), tezgah üstü dostu, dokunmatik ekranlı bir takvim; ev otomasyonumuza derinlemesine entegre olacak ve aylık ücret gerektirmeyecek.

## 💡 Neden Kendi Çözümümü Yapıyorum?

Home Assistant ile DIY (Kendin Yap) yolunu seçmek, Skylight/Hearth ekranı satın almaya göre çeşitli avantajlar sundu:

* **Aylık Ücret Yok:** "Premium" özellikler için abonelikten kaçınılır.
* **Sorunsuz Entegrasyon:** Işıklarımız, görevlerimiz (Grocy) ve varlık sensörlerimizle iletişim kurar.
* **Eski Donanım:** Bir Mini PC ve standart bir monitör yeniden kullanıldı.
* **Gizlilik:** Satıcıya bağlı kalma veya şirketin kapanma riski yok.

## 🛠 Donanım Seçimi

Şu anda bu sistem, herhangi bir HD (1920x1080) ekranda gösterilecek şekilde tasarlanmıştır.

Benim durumumda, gereksinim "skylight gibi görünmesi", dokunmatik olması, tezgah üstü kullanıma uygun olması ve farklı yerlere taşınabilmesi idi. Bu nedenle aşağıda anlattığım donanımı tercih ettim.
Yine de sizin kullanım durumunuz farklı olabilir ve örneğin bir tablette veya başka bir cihazda göstermek isterseniz ihtiyaca göre uyarlamanız gerekecektir.

Başlangıçta kullandığım donanımı yukarıda belirttiğim nedenlerle seçtim ve ayrıca kamera, hoparlör ve mikrofonla işlevselliği genişletme umudum vardı. Şu anda, bu ek donanım fikirleriyle ilgilenecek zamanım olmadığı için, muhtemelen şimdi farklı inşa ederdim.

* **Monitör:** [HP Engage 15 inç Dokunmatik Ekran](https://computers.woot.com/offers/hp-engage-16t-fhd-monitor). Genel taşınabilir monitörler yerine bunu seçmemin nedeni, dahili **Hoparlör, Kamera ve Mikrofon** içermesi ve gelecekte sesli kontrol veya görüntülü arama imkanı sunmasıydı.
* **Bilgisayar:** Windows/Linux Kiosk modunda çalışan eski bir Mini PC (NUC/Tiny PC) veya bir Raspberry Pi 4.~~

## ✨ Özellikler

* **Aile Genelinde & Bireysel Görünümler:** Belirli aile üyelerinin takvimlerini açıp kapatabilme.
* **Çift Yönlü Senkronizasyon:** Etkinlikleri ekranda veya telefonlarımızda (Google Takvim) düzenleme.
* **"Etkinlik Ekle" Pop-up'ı:** Doğrudan ekrandan belirli takvimlere etkinlik eklemek için özel bir arayüz.
* **Hava Durumu & Tarih:** Güzel ve hızlıca bakılabilen başlık alanı.
* **Duyarlı:** Ekran genişliğine göre gün sayısını otomatik olarak ayarlar (Mobil ve Masaüstü için).

---

## ⚙️ Kurulum Rehberi

*Not: Bu kurulum, gerekli tüm yardımcıları, betikleri ve değişkenleri sizin için otomatik olarak oluşturacak bir **YAML Paketi** kullanır. Bunları elle oluşturmanıza gerek yoktur.*



### 1. Ön Koşullar (HACS)

[HACS](https://hacs.xyz/) yüklü olmalıdır. Lütfen aşağıdaki **Ön Yüz** entegrasyonlarını yükleyin:

* `week-planner-card`
* `bubble-card`
* `config-template-card`
* `card-mod`
* `better-moment-card`
* `weather-card`
* `browser_mod` (Açılır pencerelerin çalışması için gereklidir)
* `layout-card` (Bölümler görünümü için gereklidir)
* `button-card` (Etkinlik eklemek için açılır pencere gereklidir)

*Not: Ayarlar → Cihazlar & Hizmetler bölümünde Browser Mod'un bir Entegrasyon (karo) olarak göründüğünden emin olun, sadece HACS altında değil. 
Eğer görünmüyorsa, Entegrasyon Ekle → Browser Mod'a tıklayın ve işlemi tamamlayın, ardından HA'yı yeniden başlatın.
HACS üzerinden yüklemek sadece dosyaları indirir; entegrasyonu eklemelisiniz ki HA eylemleri/varlıkları kaydetsin.

### 2. Arka Uç (Beyinler)

1. Home Assistant'ta `configuration.yaml` dosyanızı açın.
2. Paketleri etkinleştirmek için `homeassistant:` altında bu satırın ekli olduğundan emin olun:

   ```yaml
   homeassistant:
     packages: !include_dir_named packages
   ```
3. HA yapılandırma dizininizde `packages` adlı bir klasör oluşturun (eğer yoksa).
4. Bu depodan [packages/family_calendar.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/packages/family_calendar.yaml) dosyasını indirin.
5. [ #<--- UPDATE THIS ENTITY] ifadesini arayın ve takvim varlık kimliğini kendi ortamınıza uygun olacak şekilde güncelleyin. Daha fazla ayrıntı için bölüm 3'e bakın.
6. Dosyayı `packages/` klasörünüzün içine yerleştirin.
7. **Home Assistant'ı yeniden başlatın**.

### 3. Takvimler

**Google Takvimleri** veya **Yerel Takvimleri** kullanabilirsiniz.

#### Seçenek A: Takvim İsimlerini Yeniden Kullanma (En Kolayı)


1. **Ayarlar > Cihazlar & Servisler** bölümüne gidin.
2. **Yerel Takvim** entegrasyonunu ekleyin.
3. Takvimleri şu isimlerle oluşturun: `calendar1`, `calendar2`, `calendar3`, `calendar4`, `Family`.
    * *Bu isimleri kullanırsanız, kod kutudan çıktığı gibi çalışır!*

#### Seçenek B: Özel Takvim

1. **Ayarlar > Cihazlar & Servisler** bölümüne gidin.
2. **Yerel Takvim** veya **Google Takvim** entegrasyonunu ekleyin.
3. **Yapılandırma > Entegrasyonlar > Yerel Takvim** veya **Google Takvim** bölümüne gidin ve "Girdi Ekle"yi seçin
4. Oluşturulan her giriş için, dashboard.yaml dosyasını güncellemek üzere varlık kimliğini alın.
5. `dashboard.yaml` dosyasını açın.
6. `# <--- UPDATE THIS ENTITY` ifadesini arayın.
7. Ortamınıza uygun varlık kimliğini güncelleyin


#### Tatilleri Ayarlama

Home Assistant güncellemeleriyle birlikte, tatiller artık arayüz üzerinden eklenmektedir:

1. **Ayarlar > Cihazlar & Servisler > Entegrasyon Ekle > Tatil** bölümüne gidin.
2. Ülkenizi seçin.
3. Varlık kimliğini kontrol edin (ör. `calendar.holidays`). Varsayılandan farklıysa, dashboard YAML'de bunu güncelleyin.

### 4. Gösterge Paneli (Görünüm)


1. **Ayarlar > Gösterge Paneli** bölümüne gidin
2. **Gösterge Paneli Ekle**'ye tıklayın (Seçenek olarak "Sıfırdan Yeni Gösterge Paneli"ni seçin, "Yan menüye ekle" seçeneğini işaretleyin).
3. Sol menüden yeni oluşturulan gösterge panelini seçin ve düzenlemek için kalem simgesine tıklayın.
5. 3 nokta simgesini seçin ve "Ham yapılandırıcı düzenleyici"yi seçin.
6. [dashboard.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/dashboard.yaml) dosyasındaki kodu kopyalayıp yapıştırın.

### Adım 5: Tema (Opsiyonel)

Belirli bir yazı tipi görünümü elde etmek için (Ovo):

1. `configuration.yaml` dosyanızda `frontend:` altında bu satırın olduğundan emin olun:

   ```yaml
   frontend:
     themes: !include_dir_merge_named themes
   ```
2. Yapılandırma dizininizde `themes` adında bir klasör oluşturun.
3. [themes/skylight.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/themes/skylight.yaml) dosyasını indirip bu klasöre yerleştirin.
4. Dosya Düzenleyicisi'ni kullanarak calbackgrd.png dosyasını /www/ klasörüne yükleyin, bu gösterge panelinde dahili olarak /local olarak çevrilir.
5. Home Assistant'ı yeniden başlatın.
6. Profilinize gidin (Sol altta Kullanıcı Simgesi) ve **Tema**'yı `Skylight` olarak değiştirin.
NOT: Tema kapsamlı değildir, bunu aklınızda bulundurun

---

## 📐 Nasıl Çalışır (Teknik Detaylar)

### Filtre Mantığı

`week-planner-card` kartı, belirli takvimleri anlık olarak gizlemeyi doğal olarak desteklemez. Bunu çözmek için **Girdi Metinleri**ni Regex filtresi olarak kullandım.

* Bir kişiye ait butona tıkladığınızda, filtresi `.*` (Her şeyi göster) ile `^$` (Hiçbir şey gösterme) arasında geçiş yapar.
* `config-template-card`, bu değişkenleri takvim kartına dinamik olarak enjekte eder.

### Etkinlik Oluşturma Betiği

"Etkinlik Ekle" açılır penceresi, birden fazla kişi ve etkinlik türü (Tüm Gün vs Saatli) için mantığı yöneten tek bir betik kullanır.


```yaml
# Simplified Logic Example
target_calendar: "{{ calendar_map.get(states('input_select.calendar_select')) }}"

choose:
  - conditions: "All Day Event is ON"
    action: calendar.create_event (start_date, end_date)
  - conditions: "All Day Event is OFF"
    action: calendar.create_event (start_date_time, end_date_time)
```

## NOTLAR

Orijinal gönderim, bunu nasıl yapacağınız hakkında üst düzey bir genel bakış sağlamak ve insanların kodu kendi özel senaryolarına uyarlayabilmesine olanak tanımak içindi.

Bunu özellikle yaptım çünkü her ekran ve ihtiyaç farklıdır. Tüm potansiyel ekran boyutları, panolar vb. için geliştirme yapamam. Bu yüzden bahsettiğim ekranda veya herhangi birinde (1920x1080) çalışacak şekilde inşa edildi ancak başkaları için düzenlenebilir olmalı.

Ekran hakkında konuşursak, başta bunu önermemin nedeni, Woot'ta indirimde olması ve o dönemde dokunmatik ekranlı bir ekran edinmenin ekonomik bir yoluydu. Şu anda durum böyle olmayabilir, bu yüzden size uygun olan herhangi bir ekranı kullanın. Tablet, dokunmatik ekran, telefon, fark etmez. Düzenlemeniz gereken asıl şey pano olacak.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-08

---