# AutoGPT: Yapay Zeka Ajanları Oluşturun, Dağıtın ve Çalıştırın

[![Discord Takip](https://dcbadge.vercel.app/api/server/autogpt?style=flat)](https://discord.gg/autogpt) &ensp;
[![Twitter Takip](https://img.shields.io/twitter/follow/Auto_GPT?style=social)](https://twitter.com/Auto_GPT) &ensp;
[![Lisans: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

**AutoGPT**, karmaşık iş akışlarını otomatikleştiren sürekli çalışan yapay zeka ajanları oluşturmanızı, dağıtmanızı ve yönetmenizi sağlayan güçlü bir platformdur.

## Barındırma Seçenekleri
   - İndirip kendi sunucunuzda barındırın
   - Bulut tabanlı beta için [Bekleme Listesine Katılın](https://bit.ly/3ZDijAI)

## Kendi Sunucunuzda Kurulum Nasıl Yapılır
> [!NOT]
> AutoGPT Platformunu kendiniz kurmak ve barındırmak teknik bir süreçtir.
> Eğer çalışır bir çözüm arıyorsanız, bulut tabanlı beta için [bekleme listesine katılmanızı](https://bit.ly/3ZDijAI) öneririz.

### Sistem Gereksinimleri

Kuruluma başlamadan önce sisteminizin aşağıdaki gereksinimleri karşıladığından emin olun:

#### Donanım Gereksinimleri
- CPU: 4+ çekirdek önerilir
- RAM: Minimum 8GB, 16GB önerilir
- Depolama: En az 10GB boş alan

#### Yazılım Gereksinimleri
- İşletim Sistemleri:
  - Linux (Ubuntu 20.04 veya daha yenisi önerilir)
  - macOS (10.15 veya daha yenisi)
  - Windows 10/11, WSL2 ile
- Gerekli Yazılımlar (minimum sürümler ile):
  - Docker Engine (20.10.0 veya daha yeni)
  - Docker Compose (2.0.0 veya daha yeni)
  - Git (2.30 veya daha yeni)
  - Node.js (16.x veya daha yeni)
  - npm (8.x veya daha yeni)
  - VSCode (1.60 veya daha yeni) veya herhangi bir modern kod editörü

#### Ağ Gereksinimleri
- Kararlı bir internet bağlantısı
- Gerekli portlara erişim (Docker'da yapılandırılacaktır)
- Dışa giden HTTPS bağlantıları yapabilme

### Güncellenmiş Kurulum Talimatları:
Tamamen bakımı yapılan ve düzenli olarak güncellenen bir dökümantasyon sitesine geçtik.

👉 [Resmi kendi sunucunuzda barındırma rehberini buradan takip edin](https://docs.agpt.co/platform/getting-started/)

Bu eğitimde Docker, VSCode, git ve npm'in kurulu olduğu varsayılmaktadır.

### 🧱 AutoGPT Arayüzü (Frontend)

AutoGPT arayüzü, kullanıcıların güçlü yapay zeka otomasyon platformumuzla etkileşime geçtiği yerdir. Yapay zeka ajanlarımızdan yararlanmak ve onlarla çeşitli şekillerde etkileşim kurmak için birden fazla yol sunar. Bu arayüz, yapay zeka otomasyon fikirlerinizi hayata geçireceğiniz noktadır:

   **Ajan Oluşturucu:** Özelleştirmek isteyenler için, sezgisel ve düşük kodlu arayüzümüz kendi yapay zeka ajanlarınızı tasarlamanıza ve yapılandırmanıza olanak tanır.
   
   **İş Akışı Yönetimi:** Otomasyon iş akışlarınızı kolayca oluşturun, değiştirin ve optimize edin. Ajanınızı, her bloğun tek bir işlem yaptığı blokları birbirine bağlayarak oluşturursunuz.
   
   **Dağıtım Kontrolleri:** Ajanlarınızın yaşam döngüsünü, testten üretime kadar yönetin.
   
   **Kullanıma Hazır Ajanlar:** Oluşturmak istemiyor musunuz? Önceden yapılandırılmış ajan kütüphanemizden seçim yapın ve hemen çalıştırın.
   
   **Ajan Etkileşimi:** Kendi oluşturduğunuz veya hazır ajanları kolayca çalıştırabilir ve kullanıcı dostu arayüzümüz aracılığıyla onlarla etkileşime geçebilirsiniz.

   **İzleme ve Analitik:** Ajanlarınızın performansını takip edin ve otomasyon süreçlerinizi sürekli geliştirmek için içgörüler elde edin.

[Kendi özel bloklarınızı nasıl oluşturacağınızı öğrenmek için bu rehberi okuyun](https://docs.agpt.co/platform/new_blocks/).

### 💽 AutoGPT Sunucusu (Server)

AutoGPT Sunucusu, platformumuzun güç merkezidir. Ajanlarınız burada çalışır. Dağıtıldıktan sonra, ajanlar harici kaynaklar tarafından tetiklenebilir ve sürekli olarak çalışabilir. AutoGPT'nin sorunsuz çalışmasını sağlayan tüm temel bileşenleri içerir.

   **Kaynak Kod:** Ajanlarımızı ve otomasyon süreçlerini yönlendiren temel mantık.
   
   **Altyapı:** Güvenilir ve ölçeklenebilir performansı sağlayan sağlam sistemler.
   
   **Pazar Yeri:** Geniş bir önceden oluşturulmuş ajan yelpazesi bulabileceğiniz ve dağıtabileceğiniz kapsamlı bir pazar yeri.

### 🐙 Örnek Ajanlar

AutoGPT ile neler yapabileceğinize dair iki örnek:

1. **Trend Konulardan Viral Videolar Üretin**
   - Bu ajan Reddit'teki konuları okur.
   - Trend olan başlıkları tespit eder.
   - İçeriğe dayalı olarak otomatik olarak kısa video oluşturur.

2. **Sosyal Medya için Videolardan En İyi Alıntıları Tespit Edin**
   - Bu ajan YouTube kanalınıza abone olur.
   - Yeni bir video yüklediğinizde, videoyu metne dönüştürür.
   - Özet oluşturmak için en etkili alıntıları tespit etmek amacıyla yapay zekayı kullanır.
   - Ardından, otomatik olarak sosyal medyada yayınlamak için bir gönderi yazar.

Bu örnekler, AutoGPT ile neler başarabileceğinizin sadece bir kısmını göstermektedir! Her kullanım senaryosu için özelleştirilmiş iş akışlarıyla ajanlar oluşturabilirsiniz.

---
### Misyon ve Lisanslama
Misyonumuz, sizin önemli olan şeylere odaklanabilmeniz için araçlar sunmaktır:

- 🏗️ **Oluşturmak** - Harika bir şeyin temelini atın.
- 🧪 **Test Etmek** - Ajanınızı mükemmelleştirin.
- 🤝 **Delege Etmek** - Yapay zekanın sizin için çalışmasına izin verin ve fikirlerinizin hayat bulmasını sağlayın.

Devrimin bir parçası olun! **AutoGPT** burada kalıcı ve yapay zekâ inovasyonunun ön saflarında.

**📖 [Dokümantasyon](https://docs.agpt.co)**
&ensp;|&ensp;
**🚀 [Katkıda Bulunun](CONTRIBUTING.md)**

**Lisanslama:**

MIT Lisansı: AutoGPT deposunun büyük bölümü MIT Lisansı altındadır.

Polyform Shield Lisansı: Bu lisans, autogpt_platform klasörü için geçerlidir.

Daha fazla bilgi için: https://agpt.co/blog/introducing-the-autogpt-platform

---
## 🤖 AutoGPT Klasik
> Aşağıda AutoGPT'nin klasik sürümüyle ilgili bilgiler yer almaktadır.

**🛠️ [Kendi Ajanınızı Oluşturun - Hızlı Başlangıç](classic/FORGE-QUICKSTART.md)**

### 🏗️ Forge

**Kendi ajanınızı oluşturun!** &ndash; Forge, kendi ajan uygulamanızı oluşturmak için kullanıma hazır bir araç setidir. Çoğu temel kodu sizin için halleder, böylece tüm yaratıcılığınızı *sizin* ajanınızı öne çıkaran şeylere yönlendirebilirsiniz. Tüm eğitimler [burada](https://medium.com/@aiedge/autogpt-forge-e3de53cc58ec) mevcuttur. [`forge`](/classic/forge/) bileşenleri geliştirmeyi hızlandırmak ve ajan projenizdeki temel kodu azaltmak için ayrı ayrı da kullanılabilir.

🚀 [**Forge ile Başlarken**](https://github.com/Significant-Gravitas/AutoGPT/blob/master/classic/forge/tutorials/001_getting_started.md) &ndash;
Bu rehber, kendi ajanınızı oluşturma sürecinde ve kıyaslama ile kullanıcı arayüzünü kullanmada size yol gösterecektir.

📘 [Forge hakkında daha fazla bilgi edinin](https://github.com/Significant-Gravitas/AutoGPT/tree/master/classic/forge)

### 🎯 Kıyaslama (Benchmark)

**Ajanınızın performansını ölçün!** `agbenchmark`, ajan protokolünü destekleyen herhangi bir ajanla kullanılabilir ve projenin [CLI] ile entegrasyonu, AutoGPT ve forge tabanlı ajanlarla kullanılmasını daha da kolaylaştırır. Kıyaslama, zorlu bir test ortamı sunar. Çerçevemiz, özerk ve nesnel performans değerlendirmelerine olanak tanır ve ajanlarınızın gerçek dünya için hazır olmasını sağlar.

<!-- TODO: Kıyaslamayı gösteren görsel eklenecek -->

📦 [`agbenchmark`](https://pypi.org/project/agbenchmark/) Pypi'de
&ensp;|&ensp;
📘 [Kıyaslama hakkında daha fazla bilgi edinin](https://github.com/Significant-Gravitas/AutoGPT/tree/master/classic/benchmark)

### 💻 Arayüz (UI)

**Ajanları kullanımı kolaylaştırır!** `frontend`, ajanlarınızı kontrol etmek ve izlemek için kullanıcı dostu bir arayüz sunar. [Ajan protokolü](#-agent-protocol) üzerinden ajanlara bağlanır ve hem kendi ekosistemimizdeki hem de dışındaki birçok ajanla uyumluluğu garanti eder.

<!-- TODO: Ön yüz ekran görüntüsü eklenecek -->

Arayüz, repodaki tüm ajanlarla kutudan çıktığı gibi çalışır. Sadece [CLI] ile istediğiniz ajanı başlatın!

📘 [Arayüz hakkında daha fazla bilgi edinin](https://github.com/Significant-Gravitas/AutoGPT/tree/master/classic/frontend)

### ⌨️ CLI

[CLI]: #-cli

Depoda sunulan tüm araçların kullanılmasını mümkün olduğunca kolaylaştırmak için, repoda kök dizinde bir CLI bulunur:

```shell
$ ./run
Usage: cli.py [OPTIONS] COMMAND [ARGS]...

Options:
  --help  Show this message and exit.

Commands:
  agent      Commands to create, start and stop agents
  benchmark  Commands to start the benchmark and list tests and categories
  setup      Installs dependencies needed for your system.
```

Sadece repoyu klonlayın, `./run setup` ile bağımlılıkları kurun ve kullanmaya başlayabilirsiniz!

## 🤔 Sorularınız mı var? Sorunlar? Öneriler?

### Yardım Alın - [Discord 💬](https://discord.gg/autogpt)

[![Discord'da Bize Katılın](https://invidget.switchblade.xyz/autogpt)](https://discord.gg/autogpt)

Bir hata bildirmek veya özellik talep etmek için bir [GitHub Issue](https://github.com/Significant-Gravitas/AutoGPT/issues/new/choose) oluşturun. Lütfen aynı konuda başkasının bir issue açmadığından emin olun.

## 🤝 Kardeş Projeler

### 🔄 Ajan Protokolü

Tekdüze bir standart sürdürmek ve mevcut ve gelecekteki birçok uygulama ile sorunsuz uyumluluk sağlamak için, AutoGPT AI Engineer Foundation tarafından geliştirilen [agent protocol](https://agentprotocol.ai/) standardını kullanır. Bu, ajanınızın arayüz ve kıyaslama ile olan iletişim yollarını standardize eder.

---

## Yıldız İstatistikleri

<p align="center">
<a href="https://star-history.com/#Significant-Gravitas/AutoGPT">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=Significant-Gravitas/AutoGPT&type=Date&theme=dark" />
    <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=Significant-Gravitas/AutoGPT&type=Date" />
    <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=Significant-Gravitas/AutoGPT&type=Date" />
  </picture>
</a>
</p>

## ⚡ Katkıda Bulunanlar

<a href="https://github.com/Significant-Gravitas/AutoGPT/graphs/contributors" alt="Katkıda Bulunanları Görüntüle">
  <img src="https://contrib.rocks/image?repo=Significant-Gravitas/AutoGPT&max=1000&columns=10" alt="Katkıda Bulunanlar" />
</a>

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---