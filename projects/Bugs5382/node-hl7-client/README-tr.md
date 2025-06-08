# Node HL7 Client

> Node.js için saf TypeScript HL7 istemcisi, HL7 sunucularıyla sorunsuz iletişim sağlar.

`node-hl7-client`, HL7 broker/sunucularıyla yüksek performanslı iletişim için oluşturulmuş hafif, bağımlılıksız bir kütüphanedir. Doğru biçimlendirilmiş HL7 mesajlarını göndermeyi, yanıtları işlemeyi ve hem tekli hem de toplu HL7 mesaj formatlarıyla (MSH, BHS ve FHS) çalışmayı destekler.

## ✨ Özellikler

* ⚡ **Sıfır Harici Bağımlılık** – Aşırı hızlı performans, gereksiz ek yük olmadan.
* 🔁 **Otomatik Yeniden Bağlanma & Yeniden Deneme** – Bağlantı kesintilerini otomatik olarak yönetir.
* 🧠 **TypeScript + Tip Tanımları** – Modern geliştirme ortamları için tamamen tiplenmiş.
* 🤝 **Eşlik Paketi Mevcut** – Tam bir HL7 çözümü için [`node-hl7-server`](https://www.npmjs.com/package/node-hl7-server) ile birlikte kullanın.
* 💻 **Çapraz Platform Desteği** – Windows, macOS ve Linux'ta çalışır.
* 🧭 **Standartlara Dayalı** – Tipli oluşturucular, MSH, BHS ve FHS segmentlerinin HL7.org spesifikasyonlarına uymasını sağlar.

## 📦 Kurulum

```bash
npm install node-hl7-client
```

## 📚 Neler Dahil?

* **HL7 İstemcisi** – Uzaktaki bir HL7 sunucusuna bağlanır, mesaj gönderir ve yanıtları işler.
* **HL7 Ayrıştırıcı** – Ham HL7 mesaj dizelerini erişilebilir segmentlere ayrıştırır.
* **HL7 Oluşturucu** – Geçerli HL7 mesajları, toplu mesajlar veya eksiksiz HL7 toplu dosyalar oluşturur.

## 🧾 İçindekiler

1. [Anahtar Kelime Tanımları](#keyword-definitions)
2. [Dokümantasyon](#documentation)
3. [Teşekkürler](#acknowledgements)
4. [Lisans](#license)

## Anahtar Kelime Tanımları

Bu NPM paketi, hasta bakımı ve teşhisleri üzerinde potansiyel etkisi olan tıbbi uygulamaları desteklemek için tasarlanmıştır. Bu dokümantasyon ve bununla ilişkili [node-hl7-server](https://www.npmjs.com/package/node-hl7-server) paketi, açıklık ve birlikte çalışabilirlik için aşağıdaki standart tanımları kullanır:

**"MUST"**, **"MUST NOT"**, **"REQUIRED"**, **"SHALL"**, **"SHALL NOT"**, **"SHOULD"**, **"SHOULD NOT"**, **"RECOMMENDED"**, **"MAY"** ve **"OPTIONAL"** gibi anahtar kelimeler dokümantasyon boyunca tutarlı bir şekilde kullanılır. Bu terimler, büyük harfle yazılmadığında da anlamlarını korur.

* **MUST** – Bu kelime veya **"REQUIRED"** ya da **"SHALL"** terimleri, spesifikasyonun mutlak bir gerekliliğini belirtir.
* **MUST NOT** – Bu ifade veya **"SHALL NOT"** ifadesi, spesifikasyonun mutlak olarak yasakladığı bir durumu belirtir.
* **SHOULD** – Bu kelime veya **"RECOMMENDED"** sıfatı, belirli durumlarda bir maddenin göz ardı edilmesi için geçerli nedenler olabileceğini, ancak tam sonuçlarının anlaşılması ve dikkatlice değerlendirilmesi gerektiğini belirtir.
* **SHOULD NOT** – Bu ifade veya **"NOT RECOMMENDED"** ifadesi, belirli durumlarda davranışın kabul edilebilir veya hatta yararlı olabileceği anlamına gelir. Tüm sonuçlar anlaşılmalı ve uygulamadan önce dikkatlice değerlendirilmelidir.
* **MAY** – Bu kelime veya **"OPTIONAL"** sıfatı, öğenin gerçekten isteğe bağlı olduğunu belirtir. Belirli bir seçeneği içermeyen uygulamalar, içerenlerle yine de çalışabilmelidir; fakat işlevsellik azalabilir. Benzer şekilde, bir seçeneği içeren uygulamalar, içermeyenlerle birlikte çalışabilmelidir (elbette, seçeneğin sağladığı özel işlev dışında).

## 📖 Dokümantasyon

Tam API dokümantasyonu, kullanım örnekleri ve gelişmiş yapılandırmalar proje sitesinde mevcuttur:
🔗 [https://bugs5382.github.io/node-hl7-client/](https://bugs5382.github.io/node-hl7-client/)

## 🙏 Teşekkürler

* [`node-rabbitmq-client`](https://github.com/cody-greene/node-rabbitmq-client) – Bağlantı mantığı ilhamı.
* [`artifacthealth/hl7parser`](https://github.com/artifacthealth/hl7parser) – Ayrıştırıcı ve oluşturucu için tasarım referansı.
* Eşime ve küçük kızıma – Sevgi, sabır ve ilhamları için.

## 📄 Lisans

MIT © [LICENSE](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---