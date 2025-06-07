# wechat2tg-mac

Wechat Mac protokolüne dayalı olarak Telegram üzerinden WeChat mesajlarını alıp gönderme, wx2tg-server sunucu tarafı güvenlik nedeniyle açık kaynak değildir.

## TG Grubu: [@Wx2TgUserGroup](https://t.me/+AD02MEZa-og3ZGY1)

## Ana Özellikler

1. WeChat bireysel sohbet, WeChat grup mesajları, resmi hesap mesajları ve WeChat Work mesajlarının alınması
2. Telegram'dan belirli WeChat kullanıcılarına, WeChat gruplarına ve resmi hesaplara mesaj gönderme
3. Belirli gruplardan gelen mesajları engelleme

## Desteklenen Mesaj Türleri

### WeChat Mesaj Türleri Destek Listesi

+ [x] Metin mesajı
+ [x] WeChat Work mesajı
+ [x] WeChat çıkartma paketi
+ [x] Resim mesajı
+ [x] Video mesajı
+ [x] Sesli/görüntülü arama (sadece bildirim)
+ [x] Dosya mesajı
+ [x] Bağlantı mesajı
+ [x] Grup sohbet mesajı
+ [x] Grup sohbet @ mesajı (@herkes ve @sen Telegram'da @sen'e dönüştürülür)
+ [x] Resmi hesap mesajı
+ [x] emoji
+ [x] Konum mesajı
+ [x] Mesaj geri çekme
+ [x] Sesli mesaj
+ [ ] Kırmızı paket mesajı (bildirim, içerik alınamaz)
+ [ ] Mini program mesajı

### Telegram Mesaj Türleri Destek Listesi

+ [x] Metin mesajı
+ [x] Çıkartma ifadesi
+ [x] Resim mesajı
+ [x] Video mesajı
+ [x] Dosya mesajı
+ [x] Sesli mesaj

## Dikkat Edilmesi Gerekenler

1. Bu proje yalnızca teknik araştırma ve öğrenme amacıyla kullanılmalıdır, yasa dışı amaçlar için kullanılamaz
2. Herhangi bir sorunla karşılaşırsanız issue açmaktan çekinmeyin

## Kurulum ve Dağıtım

Öncelikle `.env.example` dosyasını `.env` olarak kopyalayın, ardından `.env` dosyasındaki ortam değişkenlerini yapılandırın.

Projede bulunan `app.conf.example` dosyasını `app.conf` olarak `conf` dizinine kopyalayın, Redis adresini kendi Redis sunucunuzun adresine ayarlayın.

### docker-compose

`docker-compose.yml` dosyasını oluşturun:

```yaml
version: '3'

services:
  wx2tg-mac:
    image: finalpi/wechat2tg-mac:latest
    container_name: wx2tg-mac
    volumes:
      - ./config:/app/storage
      - ./save-files:/app/save-files # Klasör bağlandıktan sonra çıkartma dosyalarının yeniden dönüştürülmesine gerek yoktur
    env_file: ".env"
    restart: unless-stopped

  wx2tg-server:
    image: finalpi/wx2tg-server:latest # Görüntü çek
    container_name: wx2tg-server
    ports:
      - "8058:8058"
    volumes:
      - ./conf:/usr/wic-go/conf
    restart: unless-stopped

  wx2tg-redis:
    image: redis:7.2
    container_name: wx2tg-redis
    ports:
      - "16379:6379"
    volumes:
      - ./redis-data:/data
    command: ["redis-server", "--appendonly", "yes"]
    restart: unless-stopped
```

#### Çalıştırma

```shell
docker-compose up -d
```

#### Bot Gizlilik Modunu Kapatma

Botun gizlilik modunu kapatın, BotFather’ı açın, `/mybots` yazın, botunuzu seçin. `Bot Settings` - `Group Privacy` - `Turn off` tıklayın,
`Privacy mode is disabled for xxx` mesajı çıkarsa başarıyla kapatılmıştır.

## Kullanım Kılavuzu

### BOT Komutları

- `/login`: Giriş QR kodunu alır; ilk kez başlatıldığında ilk gönderen kişi `BOT` sahibi olur

- `/flogin`: Dosya aktarım asistanı giriş QR kodunu alır, video ve dosya alımını destekler

- `/update`: Grup avatarı ve takma ad bilgisini günceller

- `/message`: Grup mesajı alımını açıp kapatır

- `/forward`: Gruptaki diğer kişilerin veya botun mesajlarının iletimini açıp kapatır

- `/user`: WeChat kullanıcı listesini alır; butona tıklayarak yeni grup oluşturabilir veya kullanıcı bağlayabilirsiniz (isim veya not ile arama yapılabilir, örn: `/user 张` ile "张" içeren WeChat kullanıcılarını bulur)

- `/room`: WeChat grup listesi alır; butona tıklayarak yeni grup oluşturabilir veya WeChat grubu bağlayabilirsiniz (isim veya not ile arama yapılabilir, örn: `/room 外卖` ile "外卖" içeren WeChat gruplarını bulur)

- `/settings`: Program ayarları

- `/unbind`: WeChat grubu veya WeChat kullanıcısını bağlantıdan çıkarır (sadece gruplarda desteklenir)

### Ortam Değişkenleri Açıklaması

|Adı| Zorunlu | Açıklama                                                                |
|--|------|--------------------------------------------------------------------|
|`BOT_TOKEN`| Evet    | Telegram Bot token’ı, [BotFather](https://t.me/BotFather) üzerinden alınır      |
|`API_ID`| Evet    | Telegram API için API ID                                         |
|`API_HASH`| Evet    | Telegram API için API HASH                                       |
|`BASE_API`| Evet    | wx2tg-server konteynerinin API istek adresi, tam yol girilmelidir                | |
|`PROXY_PROTOCOL`| Hayır   | Proxy tipi seçenekleri (socks5,http,https)                                    |
|`PROXY_HOST`| Hayır   | Proxy URL’si                                                     |
|`PROXY_PORT`| Hayır   | Proxy port numarası                                              |
|`PROXY_USERNAME`| Hayır   | Proxy kullanıcı adı                                              |
|`PROXY_PASSWORD`| Hayır   | Proxy şifresi                                                  |
|`ROOM_MESSAGE`| Hayır   | BOT’ta WeChat grup mesajlarının görüntü formatı                            |
|`OFFICIAL_MESSAGE`| Hayır   | BOT’ta resmi hesap mesajlarının görüntü formatı                            |
|`CONTACT_MESSAGE`| Hayır   | BOT’ta WeChat kullanıcı mesajlarının görüntü formatı                        |
|`ROOM_MESSAGE_GROUP`| Hayır   | Grupta WeChat grup mesajlarının görüntü formatı                             |
|`CONTACT_MESSAGE_GROUP`| Hayır   | Grupta WeChat kullanıcı mesajlarının görüntü formatı                        |
|`OFFICIAL_MESSAGE_GROUP`| Hayır   | Grupta resmi hesap mesajlarının görüntü formatı                             |
|`CREATE_ROOM_NAME`| Hayır   | WeChat grubu için otomatik grup oluşturulurken grup adı formatı                 |
|`CREATE_CONTACT_NAME`| Hayır   | WeChat kişi için otomatik grup oluşturulurken grup adı formatı                 |
|`MESSAGE_DISPLAY`| Hayır   | Metin mesajı görüntü formatı                                              |

 ---

### `/settings` Komutu Açıklaması

1. WeChat emoji’lerinin resim bağlantısı olarak gösterilmesi: Açık olduğunda arkadaşlardan gelen sarı surat ifadeleri resim bağlantısı olarak gösterilir

2. Başlangıçta grup bilgilerini senkronize et: Açık olduğunda program başlatıldığında tüm kişilerin bilgileri senkronize edilir, grup avatarı ve ismi güncellenir

---

### Sesli Mesajı Yazıya Çevirme

1. `TENCENT_SECRET_ID` ve `TENCENT_SECRET_KEY` yapılandırın, Tencent [Ses Tanıma Konsolu](https://console.cloud.tencent.com/asr) üzerinden açılabilir. Ücretsiz kullanım kotası mevcuttur.
2. `/settings` menüsünden otomatik sesli mesajı yazıya çevirme fonksiyonunu etkinleştirin

---

### `API_ID` ve `API_HASH` Nasıl Alınır

1. [telegram account](https://my.telegram.org/) adresine giriş yapın

2. "API development tools" tıklayın ve uygulama detaylarını doldurun (sadece uygulama adı ve kısa adı yeterlidir)

3. Son olarak "Create application" tıklayın

---

### Özelleştirilmiş Mesaj Şablonu

Eğer mesaj gönderenin formatını değiştirmek istiyorsanız, docker ortam değişkenini veya `.env` dosyasını düzenleyebilirsiniz

Özelleştirilebilir mesaj şablonu değişkenleri:

`#[alias]`: Kişi notu

`#[name]`: Kişi takma adı

`#[topic]`: Grup sohbet takma adı

`#[alias_first]`: Not öncelikli, yoksa kişinin takma adını gösterir

`#[identity]`: Kimlik bilgisi metni

`#[body]`: Mesaj gövdesi metni

`#[br]`: Yeni satır

### @herkesi Nasıl Etiketlerim

`@all` ile başlayan mesaj gönderirseniz, herkesi etiketlersiniz, sadece metin mesajlarında desteklenir

---

## Sık Sorulan Sorular


## Geliştirmeye Katkı

1. Projeyi fork’layın, `wx2tg-mac-dev` dalına geçin veya yeni bir dal oluşturun. Lütfen doğrudan ana dala kod göndermeyin
2. Pull Request’i `wx2tg-mac-dev` dalına gönderin


## Lisans

[MIT](LICENSE)


## Teşekkürler

Jetbrains’e bu projeye verdiği destek için teşekkürler

[<img src="https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png" width="200">](https://www.jetbrains.com)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---