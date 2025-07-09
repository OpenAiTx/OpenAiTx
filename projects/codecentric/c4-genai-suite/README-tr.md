# c4 GenAI Suite

Model Context Provider (MCP) entegrasyonuna sahip, Langchain ile güçlendirilmiş ve tüm büyük Büyük Dil Modelleri (LLM'ler) ve Gömme Modelleri ile uyumlu bir yapay zeka sohbet botu uygulaması.

Yöneticiler, RAG (Retrieval-Augmented Generation) servisleri veya MCP sunucuları gibi uzantılar ekleyerek farklı yeteneklere sahip asistanlar oluşturabilirler. Uygulama, modern bir teknoloji yığını kullanılarak geliştirilmiştir; bunlar arasında React, NestJS ve REI-S servisi için Python FastAPI bulunmaktadır.

Kullanıcılar, kullanıcı dostu bir arayüz üzerinden asistanlarla etkileşime girebilirler. Asistanın yapılandırmasına bağlı olarak, kullanıcılar soru sorabilir, kendi dosyalarını yükleyebilir veya diğer özellikleri kullanabilirler. Asistanlar, yanıtlarını yapılandırılmış uzantılara göre çeşitli LLM sağlayıcılarıyla etkileşime girerek sunar. Yapılandırılmış uzantılar tarafından sağlanan bağlamsal bilgiler, asistanların alanına özgü soruları yanıtlamasına ve ilgili bilgileri sunmasına olanak tanır.

Uygulama, modüler ve genişletilebilir olacak şekilde tasarlanmıştır; böylece kullanıcılar, uzantılar ekleyerek farklı yeteneklere sahip asistanlar oluşturabilirler.

![kısa temel kullanım demosu videosu](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/demo/preview.webp)

## Özellikler

### Büyük Dil Modelleri (LLM) ve Çok Modlu Modeller

c4 GenAI Suite zaten birçok modeli doğrudan desteklemektedir. Eğer tercih ettiğiniz model henüz desteklenmiyorsa, onu destekleyecek bir uzantı yazmak kolay olmalıdır.

* OpenAI uyumlu modeller
* Azure OpenAI modelleri
* Bedrock modelleri
* Google GenAI modelleri
* Ollama uyumlu modeller
### Retrieval Augmented Generation (RAG)

c4 GenAI Suite, LLM tarafından kullanılmak üzere dosyaları hazırlayan bir sunucu olan REI-S'i içerir.

* REI-S, özel entegre edilmiş bir RAG sunucusu
  * Vektör depoları
    * pgvector
    * Azure AI Search
  * Gömme modelleri
    * OpenAI uyumlu gömmeler
    * Azure OpenAI gömmeleri
    * Ollama uyumlu gömmeler
  * Dosya formatları:
    * pdf, docx, pptx, xlsx, ...
    * ses dosyası sesli transkripsiyon (Whisper aracılığıyla)

### Uzantılar

c4 GenAI Suite, genişletilebilirlik için tasarlanmıştır. Uzantı yazmak ve mevcut bir MCP sunucusunu kullanmak kolaydır.

* Model Context Protocol (MCP) sunucuları
* Özel systemprompt
* Bing Arama
* Hesap makinesi
## Başlarken

### Docker-Compose Kullanımı

- Proje kök dizininde `docker compose up` komutunu çalıştırın.
- Bir tarayıcıda [uygulamayı](http://localhost:3333) açın. Varsayılan giriş bilgileri kullanıcı `admin@example.com` ve şifre `secret` şeklindedir.

![asistan yapılandırmasını gösteren video](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/demo/assistants.webp)

### Helm & Kubernetes Kullanımı

Kubernetes ortamlarında dağıtım için lütfen [Helm Chart'ımızın README dosyasına](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/./helm-chart/README.md) bakın.

### Asistanlar ve Uzantıların Kurulumu

c4 GenAI Suite, *asistanlar* etrafında döner.
Her asistan, LLM modelini ve hangi araçları kullanabileceğini belirleyen bir dizi uzantıdan oluşur.

- Yönetici alanında (sol altta kullanıcı adına tıklayın), [asistanlar bölümüne](http://localhost:3333/admin/assistants) gidin.
- Bölüm başlığının yanındaki yeşil `+` düğmesiyle bir asistan ekleyin. Bir isim ve açıklama seçin.
- Oluşturulan asistanı seçin ve yeşil `+ Uzantı Ekle`ye tıklayın.
- Modeli seçin ve kimlik bilgilerini doldurun.
- Çalıştığını kontrol etmek için `Test` düğmesini kullanın ve ardından `kaydedin`.

Artık [sohbet sayfasına](http://localhost:3333/chat) (sol üstteki `c4 GenAI Suite`e tıklayın) dönebilir ve yeni asistanınızla yeni bir konuşma başlatabilirsiniz.

> [!IPUCU]
> `docker-compose` dosyamız, CPU üzerinde çalışan yerel bir Ollama içerir. Bunu hızlı testler için kullanabilirsiniz. Ancak yavaş olacaktır ve muhtemelen başka bir model kullanmak istersiniz. Bunu kullanmak isterseniz, Asistanınızda aşağıdaki model uzantısını oluşturmanız yeterlidir.
> * Uzantı: `Dev: Ollama`
> * Uç Nokta: `http://ollama:11434`
> * Model: `llama3.2`
### Model Context Protocol (MCP) [isteğe bağlı]

`MCP Tools` Eklentisi ile `sse` arayüzü sunan herhangi bir MCP sunucusunu kullanın (veya bir `stdio` MCP sunucusunun önünde vekil olarak bizim `mcp-tool-as-server` uygulamamızı kullanın).
Her MCP sunucusu, bir eklenti olarak ayrıntılı şekilde yapılandırılabilir.

### Retrieval Augmented Generation (RAG) / Dosya Arama [isteğe bağlı]

Kullanıcı tarafından sağlanan dosyaları aramak için RAG sunucumuz `REI-S`'i kullanın. Asistan için sadece bir `Dosyaları Ara` eklentisi yapılandırın.
Bu süreç [services/reis alt dizininde](services/reis/#example-configuration-in-c4) ayrıntılı olarak açıklanmıştır.

## Katkı & Geliştirme

* Katkıda bulunma yönergeleri için [CONTRIBUTING.md](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/CONTRIBUTING.md) dosyasına bakın.
* Geliştirici olarak başlamak için [DEVELOPERS.md](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/DEVELOPERS.md) dosyasını kontrol edin.

## Ana Bileşenler

Uygulama bir **Ön Yüz** , bir **Arka Uç**  ve bir **REI-S**  hizmetinden oluşmaktadır.

```
┌──────────┐
│   Kullanıcı │
└─────┬────┘
      │ erişim
      ▼
┌──────────┐
│ Arayüz   │
└─────┬────┘
      │ erişim
      ▼
┌──────────┐     ┌─────────────────┐
│ Arka Uç  │────►│      LLM        │
└─────┬────┘     └─────────────────┘
      │ erişim
      ▼
┌──────────┐     ┌─────────────────┐
│  REI-S   │────►│ Gömme Modeli    │
│          │     └─────────────────┘
│          │
│          │     ┌─────────────────┐
│          │────►│  Vektör Deposu  │
└──────────┘     └─────────────────┘
```
### Frontend

Frontend, kullanıcıların backend ve REI-S servisi ile etkileşime geçmesini sağlayan kullanıcı dostu bir arayüz sunmak için React ve TypeScript ile geliştirilmiştir. Asistanları, uzantıları ve sohbet işlevlerini yönetmek için özellikler içerir.

> Kaynaklar: `/frontend`

### Backend

Backend, uygulamanın ana API katmanı olarak hizmet veren NestJS ve TypeScript kullanılarak geliştirilmiştir. Frontend'den gelen istekleri işler ve sohbet işlevlerini kolaylaştırmak için llm sağlayıcıları ile etkileşime geçer. Backend ayrıca asistanları ve bunların uzantılarını yönetir, kullanıcıların sohbetlerinde çeşitli AI modellerini yapılandırmasına ve kullanmasına olanak tanır.

Ek olarak, backend kullanıcı kimlik doğrulamasını yönetir ve dosya indeksleme ve geri alma işlemleri için REI-S servisi ile iletişim kurar.

Veri kalıcılığı için backend, **PostgreSQL** veritabanı kullanır.

> Kaynaklar: `/backend`

### REI-S

REI-S (**R**etrieval **E**xtraction **I**ngestion **S**erver), temel RAG (Retrieval-Augmented Generation) yetenekleri sunan Python tabanlı bir sunucudur. Dosya içeriği çıkarma, indeksleme ve sorgulama işlemlerine olanak tanır, böylece uygulamanın büyük veri setlerini verimli bir şekilde işlemesini sağlar. REI-S servisi, backend ile sorunsuz çalışacak şekilde tasarlanmıştır ve sohbet işlevleri ile dosya aramaları için gerekli verileri sağlar.

REI-S, vektör depolama için Azure AI Search ve pgvector'u destekler, böylece esnek ve ölçeklenebilir veri erişim seçenekleri sunar. Servis, vektör depolama tipi ve bağlantı detaylarını belirtmek için ortam değişkenleri ile yapılandırılabilir.

> Kaynaklar: `/services/reis`


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---