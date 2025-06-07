# Open WebUI 👋

![GitHub stars](https://img.shields.io/github/stars/open-webui/open-webui?style=social)
![GitHub forks](https://img.shields.io/github/forks/open-webui/open-webui?style=social)
![GitHub watchers](https://img.shields.io/github/watchers/open-webui/open-webui?style=social)
![GitHub repo size](https://img.shields.io/github/repo-size/open-webui/open-webui)
![GitHub language count](https://img.shields.io/github/languages/count/open-webui/open-webui)
![GitHub top language](https://img.shields.io/github/languages/top/open-webui/open-webui)
![GitHub last commit](https://img.shields.io/github/last-commit/open-webui/open-webui?color=red)
[![Discord](https://img.shields.io/badge/Discord-Open_WebUI-blue?logo=discord&logoColor=white)](https://discord.gg/5rJgQTnV4s)
[![](https://img.shields.io/static/v1?label=Sponsor&message=%E2%9D%A4&logo=GitHub&color=%23fe8e86)](https://github.com/sponsors/tjbck)

**Open WebUI, tamamen çevrimdışı çalışacak şekilde tasarlanmış, [genişletilebilir](https://docs.openwebui.com/features/plugin/), zengin özellikli ve kullanıcı dostu kendi kendine barındırılan bir yapay zeka platformudur.** **Ollama** ve **OpenAI uyumlu API'ler** gibi çeşitli LLM çalıştırıcılarını destekler, **RAG için yerleşik çıkarım motoru** ile birlikte gelir ve bu sayede **güçlü bir yapay zeka dağıtım çözümü** sunar.

![Open WebUI Demo](./demo.gif)

> [!TIP]  
> **Bir [Kurumsal Plan](https://docs.openwebui.com/enterprise) mı arıyorsunuz?** – **[Satış Ekibimizle Hemen İletişime Geçin!](mailto:sales@openwebui.com)**
>
> **Özel tema ve markalama**, **Hizmet Seviyesi Anlaşması (SLA) desteği**, **Uzun Süreli Destek (LTS) sürümleri** ve **daha fazlası** gibi **gelişmiş yetenekler** edinin!

Daha fazla bilgi için [Open WebUI Dokümantasyonu](https://docs.openwebui.com/) sayfamıza göz atmayı unutmayın.

## Open WebUI'nin Temel Özellikleri ⭐

- 🚀 **Kolay Kurulum**: Docker veya Kubernetes (kubectl, kustomize veya helm) kullanarak zahmetsiz bir deneyim için sorunsuzca kurun. Hem `:ollama` hem de `:cuda` etiketli imajlar için destek sunar.

- 🤝 **Ollama/OpenAI API Entegrasyonu**: Ollama modelleriyle birlikte çok yönlü sohbetler için OpenAI uyumlu API’leri kolayca entegre edin. OpenAI API URL’sini özelleştirerek **LMStudio, GroqCloud, Mistral, OpenRouter ve daha fazlası** ile bağlantı kurabilirsiniz.

- 🛡️ **Ayrıntılı Yetkilendirme ve Kullanıcı Grupları**: Yöneticilerin ayrıntılı kullanıcı rolleri ve izinleri oluşturmasına olanak tanıyarak güvenli bir kullanıcı ortamı sağlıyoruz. Bu ayrıntılı yapı yalnızca güvenliği artırmakla kalmaz, aynı zamanda kullanıcı deneyimini kişiselleştirerek sahiplenme ve sorumluluk duygusu kazandırır.

- 📱 **Duyarlı Tasarım**: Masaüstü PC, Dizüstü Bilgisayar ve Mobil cihazlarda sorunsuz bir deneyim yaşayın.

- 📱 **Mobil için İleri Düzey Web Uygulaması (PWA)**: PWA’mız ile mobil cihazınızda yerel uygulama benzeri bir deneyimin keyfini çıkarın, localhost’ta çevrimdışı erişim ve sorunsuz bir kullanıcı arayüzü elde edin.

- ✒️🔢 **Tam Markdown ve LaTeX Desteği**: Zenginleştirilmiş etkileşim için kapsamlı Markdown ve LaTeX yetenekleriyle LLM deneyiminizi geliştirin.

- 🎤📹 **Eller Serbest Sesli/Görüntülü Görüşme**: Ellerinizi kullanmadan sesli ve görüntülü arama özellikleriyle dinamik ve etkileşimli bir sohbet ortamı yaşayın.

- 🛠️ **Model Oluşturucu**: Web UI üzerinden kolayca Ollama modelleri oluşturun. Özel karakterler/ajanlar ekleyin, sohbet öğelerini özelleştirin ve [Open WebUI Topluluğu](https://openwebui.com/) entegrasyonu ile modelleri zahmetsizce içe aktarın.

- 🐍 **Yerleşik Python Fonksiyon Çağırma Aracı**: Araçlar çalışma alanında yerleşik kod düzenleyici desteğiyle LLM’lerinizi geliştirin. Kendi Fonksiyonunuzu Getirin (BYOF) ile saf Python fonksiyonlarınızı kolayca ekleyin ve LLM’lerle sorunsuz entegrasyon sağlayın.

- 📚 **Yerel RAG Entegrasyonu**: Yenilikçi Geri Alım Artırılmış Üretim (RAG) desteğiyle sohbet etkileşimlerinin geleceğine dalın. Bu özellik, belge etkileşimlerini sohbet deneyiminize sorunsuzca entegre eder. Belgeleri doğrudan sohbete yükleyebilir veya dosya kitaplığınıza ekleyerek `#` komutuyla sorgudan önce kolayca erişebilirsiniz.

- 🔍 **RAG için Web Arama**: `SearXNG`, `Google PSE`, `Brave Search`, `serpstack`, `serper`, `Serply`, `DuckDuckGo`, `TavilySearch`, `SearchApi` ve `Bing` gibi sağlayıcılarla web aramaları yapın ve sonuçları doğrudan sohbetinize aktarın.

- 🌐 **Web Taraması Yeteneği**: Sohbet deneyiminize `#` komutundan sonra bir URL ekleyerek web sitelerini entegre edin. Bu özellik, web içeriğini doğrudan sohbetlerinize dahil etmenize olanak tanır ve etkileşimlerinizi daha zengin ve derin hale getirir.

- 🎨 **Görüntü Üretimi Entegrasyonu**: AUTOMATIC1111 API veya ComfyUI (yerel) ve OpenAI’nin DALL-E’si (harici) gibi seçeneklerle görüntü üretimi yeteneklerini sorunsuzca entegre edin ve sohbetinizi dinamik görsel içeriklerle zenginleştirin.

- ⚙️ **Çoklu Model Sohbetleri**: Farklı modellerle aynı anda kolayca etkileşime geçin, her birinin benzersiz avantajlarından yararlanın. Çeşitli modelleri paralel olarak kullanarak deneyiminizi geliştirin.

- 🔐 **Rol Tabanlı Erişim Kontrolü (RBAC)**: Kısıtlı izinlerle güvenli erişim sağlayın; yalnızca yetkili kişiler Ollama’nıza erişebilir ve özel model oluşturma/çekme hakları yalnızca yöneticilere aittir.

- 🌐🌍 **Çok Dilli Destek**: Uluslararasılaştırma (i18n) desteğimizle Open WebUI’yi tercih ettiğiniz dilde deneyimleyin. Desteklenen dilleri artırmak için bize katılın! Aktif olarak katkıda bulunanlar arıyoruz!

- 🧩 **Boru Hatları, Open WebUI Eklenti Desteği**: [Pipelines Plugin Framework](https://github.com/open-webui/pipelines) ile özel mantık ve Python kütüphanelerini Open WebUI’ye sorunsuzca entegre edin. Pipelines örneğinizi başlatın, OpenAI URL’sini Pipelines URL’sine ayarlayın ve sonsuz olasılıkları keşfedin. [Örnekler](https://github.com/open-webui/pipelines/tree/main/examples) arasında **Fonksiyon Çağırma**, kullanıcı **Hız Sınırlandırma**, **Kullanım İzleme** (Langfuse gibi araçlarla), çok dilli destek için **LibreTranslate ile Canlı Çeviri**, **Zararlı Mesaj Filtreleme** ve çok daha fazlası bulunur.

- 🌟 **Sürekli Güncellemeler**: Open WebUI’yi düzenli güncellemeler, düzeltmeler ve yeni özelliklerle geliştirmeye kararlıyız.

Open WebUI’nin özellikleri hakkında daha fazla bilgi edinmek ister misiniz? Kapsamlı bir genel bakış için [Open WebUI dokümantasyonuna](https://docs.openwebui.com/features) göz atın!

## Sponsorlar 🙌

#### Zümrüt

<table>
  <tr>
    <td>
      <a href="https://n8n.io/" target="_blank">
        <img src="https://docs.openwebui.com/sponsors/logos/n8n.png" alt="n8n" style="width: 8rem; height: 8rem; border-radius: .75rem;" />
      </a>
    </td>
    <td>
      N8N • Arayüzünüzün henüz bir arka ucu var mı?<br><a href="https://n8n.io/">n8n</a>'i deneyin
    </td>
  </tr>
  <tr>
    <td>
      <a href="https://warp.dev/open-webui" target="_blank">
        <img src="https://docs.openwebui.com/sponsors/logos/warp.png" alt="n8n" style="width: 8rem; height: 8rem; border-radius: .75rem;" />
      </a>
    </td>
    <td>
      <a href="https://warp.dev/open-webui">Warp</a> • Geliştiriciler için akıllı terminal
    </td>
  </tr>
</table>

---

Sponsorlarımızın cömert desteği için son derece minnettarız. Katkıları, projemizi sürdürmemize ve geliştirmemize yardımcı oluyor, topluluğumuza kaliteli işler sunmaya devam etmemizi sağlıyor. Teşekkürler!

## Nasıl Kurulur 🚀

### Python pip ile Kurulum 🐍

Open WebUI, Python paket yöneticisi pip kullanılarak kurulabilir. Devam etmeden önce, **Python 3.11** kullandığınızdan emin olun, aksi takdirde uyumluluk sorunları yaşayabilirsiniz.

1. **Open WebUI’yi Kurun**:
   Terminalinizi açın ve aşağıdaki komutu çalıştırarak Open WebUI’yi kurun:

   ```bash
   pip install open-webui
   ```

2. **Open WebUI’yi Başlatma**:
   Kurulumdan sonra, aşağıdaki komutla Open WebUI’yi başlatabilirsiniz:

   ```bash
   open-webui serve
   ```

Bu işlem Open WebUI sunucusunu başlatacak ve [http://localhost:8080](http://localhost:8080) adresinden erişebilirsiniz.

### Docker ile Hızlı Başlangıç 🐳

> [!NOTE]  
> Bazı Docker ortamlarında ek yapılandırmalar gerekebilir. Herhangi bir bağlantı sorunu yaşarsanız, [Open WebUI Dokümantasyonu](https://docs.openwebui.com/)’ndaki ayrıntılı rehberimiz size yardımcı olacaktır.

> [!WARNING]
> Open WebUI’yi Docker ile kurarken, Docker komutunuza `-v open-webui:/app/backend/data` eklediğinizden emin olun. Bu adım, veritabanınızın düzgün şekilde bağlanmasını sağlar ve veri kaybını önler.

> [!TIP]  
> Open WebUI’yi Ollama dahil veya CUDA hızlandırmalı kullanmak istiyorsanız, `:cuda` veya `:ollama` etiketli resmi imajlarımızı kullanmanızı öneririz. CUDA’yı etkinleştirmek için Linux/WSL sisteminizde [Nvidia CUDA container toolkit](https://docs.nvidia.com/dgx/nvidia-container-runtime-upgrade/) kurulu olmalıdır.

### Varsayılan Yapılandırma ile Kurulum

- **Ollama bilgisayarınızda ise** bu komutu kullanın:

  ```bash
  docker run -d -p 3000:8080 --add-host=host.docker.internal:host-gateway -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:main
  ```

- **Ollama Farklı Bir Sunucudaysa** bu komutu kullanın:

  Ollama’ya başka bir sunucudan bağlanmak için `OLLAMA_BASE_URL` değerini sunucu URL’si ile değiştirin:

  ```bash
  docker run -d -p 3000:8080 -e OLLAMA_BASE_URL=https://example.com -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:main
  ```

- **Open WebUI’yi Nvidia GPU desteğiyle çalıştırmak için** bu komutu kullanın:

  ```bash
  docker run -d -p 3000:8080 --gpus all --add-host=host.docker.internal:host-gateway -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:cuda
  ```

### Yalnızca OpenAI API Kullanımı için Kurulum

- **Yalnızca OpenAI API kullanacaksanız** bu komutu kullanın:

  ```bash
  docker run -d -p 3000:8080 -e OPENAI_API_KEY=your_secret_key -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:main
  ```

### Open WebUI’yi Ollama Desteğiyle Birlikte Kurma

Bu kurulum yöntemi, Open WebUI ile Ollama’yı tek bir kapsayıcı imajında birleştirir ve tek bir komutla hızlı bir kurulum sağlar. Donanımınıza uygun komutu seçin:

- **GPU Desteğiyle**:
  GPU kaynaklarını kullanmak için aşağıdaki komutu çalıştırın:

  ```bash
  docker run -d -p 3000:8080 --gpus=all -v ollama:/root/.ollama -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:ollama
  ```

- **Yalnızca CPU için**:
  GPU kullanmıyorsanız, bunun yerine bu komutu kullanın:

  ```bash
  docker run -d -p 3000:8080 -v ollama:/root/.ollama -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:ollama
  ```

Her iki komut da Open WebUI ve Ollama’nın yerleşik, zahmetsiz kurulumunu sağlar ve her şeyi hızla çalıştırmanıza olanak tanır.

Kurulumdan sonra Open WebUI’ye [http://localhost:3000](http://localhost:3000) adresinden erişebilirsiniz. Keyfini çıkarın! 😄

### Diğer Kurulum Yöntemleri

Docker dışı yerel kurulum yöntemleri, Docker Compose, Kustomize ve Helm dahil olmak üzere çeşitli kurulum alternatifleri sunuyoruz. Kapsamlı rehber için [Open WebUI Dokümantasyonu](https://docs.openwebui.com/getting-started/) sayfamızı ziyaret edin veya [Discord topluluğumuza](https://discord.gg/5rJgQTnV4s) katılın.

### Sorun Giderme

Bağlantı sorunları mı yaşıyorsunuz? [Open WebUI Dokümantasyonu](https://docs.openwebui.com/troubleshooting/) size yardımcı olacaktır. Daha fazla destek ve topluluğumuza katılmak için [Open WebUI Discord](https://discord.gg/5rJgQTnV4s) adresini ziyaret edin.

#### Open WebUI: Sunucu Bağlantı Hatası

Bağlantı sorunu yaşıyorsanız, genellikle WebUI docker kapsayıcısının kapsayıcı içindeki 127.0.0.1:11434 (host.docker.internal:11434) adresindeki Ollama sunucusuna ulaşamamasından kaynaklanır. Bunu çözmek için docker komutunda `--network=host` bayrağını kullanın. Unutmayın, bu durumda port 3000’den 8080’e değişir ve bağlantı şu olur: `http://localhost:8080`.

**Örnek Docker Komutu**:

```bash
docker run -d --network=host -v open-webui:/app/backend/data -e OLLAMA_BASE_URL=http://127.0.0.1:11434 --name open-webui --restart always ghcr.io/open-webui/open-webui:main
```

### Docker Kurulumunuzu Güncel Tutmak

Yerel Docker kurulumunuzu en son sürüme güncellemek isterseniz, bunu [Watchtower](https://containrrr.dev/watchtower/) ile yapabilirsiniz:

```bash
docker run --rm --volume /var/run/docker.sock:/var/run/docker.sock containrrr/watchtower --run-once open-webui
```

Komutun sonundaki `open-webui` ifadesini kapsayıcı adınız farklıysa değiştirin.

Güncelleme rehberimiz için [Open WebUI Dokümantasyonu](https://docs.openwebui.com/getting-started/updating) sayfamıza göz atın.

### Geliştirici Dalını Kullanmak 🌙

> [!WARNING]
> `:dev` dalı en son kararsız özellikleri ve değişiklikleri içerir. Kendi riskinizde kullanın; hatalar veya tamamlanmamış özellikler olabilir.

En yeni, en güncel özellikleri denemek istiyorsanız ve ara sıra kararsızlığa razıysanız, `:dev` etiketini şu şekilde kullanabilirsiniz:

```bash
docker run -d -p 3000:8080 -v open-webui:/app/backend/data --name open-webui --add-host=host.docker.internal:host-gateway --restart always ghcr.io/open-webui/open-webui:dev
```

### Çevrimdışı Mod

Open WebUI’yi çevrimdışı bir ortamda çalıştırıyorsanız, internetten model indirme girişimlerini engellemek için `HF_HUB_OFFLINE` ortam değişkenini `1` olarak ayarlayabilirsiniz.

```bash
export HF_HUB_OFFLINE=1
```

## Sırada Ne Var? 🌟

Yol haritamızdaki gelecek özellikleri [Open WebUI Dokümantasyonu](https://docs.openwebui.com/roadmap/) üzerinden keşfedin.

## Lisans 📜

Bu proje, gözden geçirilmiş BSD-3-Clause lisansı olan [Open WebUI Lisansı](LICENSE) ile lisanslanmıştır. Klasik BSD-3 lisansındaki tüm haklara sahipsiniz: yazılımı kullanabilir, değiştirebilir ve dağıtabilirsiniz; ticari ve özel ürünlerde dahil, minimum kısıtlamalarla. Tek ek gereklilik, LICENSE dosyasında detaylandırıldığı şekilde "Open WebUI" markasını korumaktır. Tüm şartlar için [LICENSE](LICENSE) belgesine bakınız. 📄

## Destek 💬

Herhangi bir sorunuz, öneriniz veya desteğe ihtiyacınız varsa, lütfen bir issue açın veya bizimle iletişime geçmek için
[Open WebUI Discord topluluğumuza](https://discord.gg/5rJgQTnV4s) katılın! 🤝

## Yıldız Geçmişi

<a href="https://star-history.com/#open-webui/open-webui&Date">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=open-webui/open-webui&type=Date&theme=dark" />
    <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=open-webui/open-webui&type=Date" />
    <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=open-webui/open-webui&type=Date" />
  </picture>
</a>

---

[Timothy Jaeryang Baek](https://github.com/tjbck) tarafından oluşturulmuştur – Open WebUI’yi birlikte daha harika hale getirelim! 💪

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---