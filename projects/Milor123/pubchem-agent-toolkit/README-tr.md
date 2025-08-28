
<div align="center"><p><a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=hi"><img src="https://img.shields.io/badge/हिन्दी-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=fa"><img src="https://img.shields.io/badge/فارسی-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=id"><img src="https://img.shields.io/badge/Bahasa Indonesia-white" alt="version"></a> </p></div>

# AI Asistanları için Gelişmiş PubChem MCP Sunucusu

🧪 PubChem’den kimyasal bileşik bilgilerini akıllıca arayabilen, gelişmiş, sağlam ve gizlilik odaklı bir MCP sunucusu.

Bu PubChem MCP Sunucusu, AI asistanları (AnythingLLM gibi) ile PubChem’in geniş kimyasal veritabanı arasında güçlü bir köprü görevi görür. Model Context Protocol (MCP) kullanarak, AI modellerinin kimyasal bileşikler için akıllı ve dayanıklı aramalar yapmasını ve ayrıntılı özellikleri programatik olarak almasını sağlar.

---

## ✨ Temel Özellikler

Bu, sıradan bir PubChem sarmalayıcısı değildir. Sunucu, baştan sona son derece dayanıklı ve akıllı olacak şekilde yeniden inşa edilmiştir:

-   **🧠 Akıllı Yedekli Arama**: Yaygın bir isimle (ör. "Vitamin D") yapılan arama başarısız olursa, sunucu otomatik olarak PubChem Substance veritabanında daha derin bir arama gerçekleştirir ve doğru bileşiği bulur. Bu, belirsiz sorguların başarı oranını büyük ölçüde artırır.
-   **🛡️ Sağlam Hata Yönetimi ve Yeniden Deneme**: Sunucu, API hatalarını zarifçe yönetmek üzere tasarlanmıştır. PubChem’den "Sunucu Meşgul" hatası alırsa, otomatik olarak bekler ve isteği yeniden dener, böylece yoğun yük altında bile sorgularınızın başarıyla yanıtlanmasını sağlar.
-   **🔒 Opsiyonel Tor Proxy Desteği**: Gizliliğiniz tamamen sizin kontrolünüzde. Basit bir `config.ini` dosyası ile tüm istekleri Tor ağı üzerinden (SOCKS5 veya HTTP proxy) yönlendirebilirsiniz, böylece IP adresinizin açığa çıkmasını önlersiniz. Sunucu varsayılan olarak güvenlidir ve proxy bağlantısı başarısız olsa bile IP’nizi **asla** sızdırmaz.
-   **🔎 Tekli & Çoklu Bileşik Arama**: Tek veya birden fazla bileşiği tek bir istemde sorunsuz şekilde arayabilir.
-   **🧪 Ayrıntılı Özellik Alma**: IUPAC Adı, Moleküler Formül, Moleküler Ağırlık ve özellikle **Monoisotopik Kütle** gibi önemli kimyasal özelliklere erişim sağlar.

---

---

### 🚀 Kurulum Gerektirmez: Smithery.ai’da Canlı Deneyin

MCP sunucularına yeni olanlar veya yerel kurulum olmadan bu aracın yeteneklerini test etmek isteyenler için, Smithery.ai üzerinde canlı ve barındırılan bir sürümü mevcuttur. Böylece tarayıcınızda doğrudan ajan ile sohbet edebilirsiniz.

[**<-- Smithery.ai’da Canlı PubChem Agent’ı Keşfedin -->**](https://smithery.ai/server/@Milor123/smithery-pubchem-deploy)

**Başlamak için:**

1.  Yukarıdaki bağlantıya tıklayarak sunucu sayfasına gidin.
2.  **GitHub** veya **Google** hesabınızla giriş yapın.
3.  Sohbet arayüzünü açmak ve test etmeye başlamak için **"Explore capabilities"** düğmesine tıklayın!

> **✅ En İyi Sonuçlar İçin Önerilen Modeller**
>
> Özellikle uzun ondalık sayılarla en yüksek doğruluğu almak için güçlü modellerin kullanılması şiddetle tavsiye edilir. Aşağıdaki modeller bu araçla test edilmiştir ve mükemmel çalışmaktadır:
>
> *   **Anthropic Claude 3 Sonnet**
> *   **OpenAI'nin GPT-4 Turbo'su** (veya GPT-4o gibi daha yeni sürümler)
>
> Her iki modelin de aracın döndürdüğü ondalık sayıların tam hassasiyetini herhangi bir yuvarlama olmadan doğru şekilde işlediğini doğruladık.

---

## 🚀 Hızlı Başlangıç & Kurulum

Bu sunucu, yerel olarak çalıştırılmak üzere tasarlanmıştır; masaüstünüzde veya AnythingLLM Docker ortamında çalıştırabilirsiniz.

### 1. Bağımlılıklar

Bu proje birkaç Python kütüphanesine bağlıdır. Ortamınızda kurulu olduklarından emin olun.

Aşağıdaki içerikle bir `requirements.txt` dosyası oluşturun:
```txt
requests
bs4 
mcp 
pubchempy
pandas
PySocks
```

Bunları `uv` veya `pip` kullanarak yükleyin:
```bash
uv venv
.venv\Scripts\activate
uv pip install -r requirements.txt
```
*(Not: `PySocks` yalnızca Tor SOCKS5 proxy özelliğini kullanmayı planlıyorsanız gereklidir.)*

### 2. Yapılandırma

Sunucu, **ilk kez çalıştırıldığında otomatik olarak oluşturulan** bir `config.ini` dosyası ile yapılandırılır. Bu dosya, `pubchem_server.py` betiği ile aynı dizinde görünecektir.

**Varsayılan `config.ini`:**
```ini
[proxy]
# Change 'use_proxy' to 'true' to route all requests through a proxy.
# Essential for protecting your privacy if you use Tor.
use_proxy = false

# Defines the proxy type. Options:
#   socks5h  -> (Recommended for Tor) The native SOCKS proxy for Tor. More secure.
#   http     -> An HTTP proxy. If using Tor, requires additional configuration.
proxy_type = socks5h

# The proxy address. THIS IS A CRITICAL SETTING!
#   - If you run this script on your DESKTOP, use: 127.0.0.1
#   - If you run this script inside DOCKER, use: host.docker.internal
host = 127.0.0.1

# The proxy port.
#   9050 -> Default port for Tor's SOCKS proxy.
#   8118 -> Default port for Tor's HTTP proxy (if enabled).
port = 9050
```

### 3. AnythingLLM ile Entegrasyon

Resmi dokümantasyonu takip ederek bunu özel bir MCP sunucusu olarak ekleyin. Buradaki anahtar nokta, `command`'ı Python çalıştırıcınıza ve `pubchem_server.py` betiğine yönlendirmektir.

**AnythingLLM Masaüstü için örnek (`plugins/anythingllm_mcp_servers.json`):**
```json
{
  "mcpServers": {
    "pubchem": {
      "name": "PubChem Server (Enhanced)",
      "transport": "stdio",
      "command": "\"C:\\path\\to\\your\\.venv\\Scripts\\python.exe\" \"C:\\path\\to\\your\\project\\pubchem_server.py\"",
      "cwd": "C:\\path\\to\\your\\project"
    }
  }
}
```


### 3.1 AnythingLLM ile Uygulama Örnekleri

Ajan ile nasıl etkileşim kurulacağına dair bazı örnekler burada verilmiştir. Bu testler AnythingLLM Desktop kullanılarak, çeşitli Büyük Dil Modellerine OpenRouter üzerinden bağlanarak gerçekleştirilmiştir.

Testlerimizde elde ettiğimiz kritik bir bulgu, seçtiğiniz modelin önemi olmuştur. Bu görev için **küçük veya yerel modellerin kullanılmasını kesinlikle önermiyoruz**. Küçük modeller, aracın döndürdüğü verileri doğru şekilde ayrıştırmakta genellikle zorlanır ve hayal ürünü değerler, yanlış formatlama veya en kritiği olan **ondalık sayıların yuvarlanması** gibi hatalara yol açabilir; bu da yüksek hassasiyetli bu aracın amacını boşa çıkarır.

Sonuçlarınızın bütünlüğünü sağlamak için MCP'nin döndürdüğü ham verileri daima doğrulamak iyi bir uygulamadır. Bunu nasıl yapacağınızı bir sonraki bölümde öğrenebilirsiniz: [3.2 MCP çıktıları günlüklerde nasıl doğrulanır](#32-how-to-verify-mcp-outputs-in-the-logs).

<img width="837" height="1060" alt="imagen" src="https://github.com/user-attachments/assets/5a16c7a2-d65d-4d64-98dd-f3cb4cae9b22" />

Diğer yandan, birkaç model mükemmel performans sergilemiştir. **Google'ın `Gemini 2.5 Flash lite`** ile olağanüstü sonuçlar elde ettik. Uzun ondalık sayıları işleme ve nihai Markdown tablosunu doğru biçimlendirme konusunda dikkate değer bir hassasiyet gösterdi.

Google gemini 2.5 flash lite, istemli ve istemsiz örneklerde (örnekte 0.6 sıcaklık kullanılmıştır) kusursuz ondalık hassasiyeti korur.

<img width="1089" height="1061" alt="imagen" src="https://github.com/user-attachments/assets/4574efa5-d6d9-49e3-a665-a39a427f09a1" />

Bu özel görev için kişisel favorim, tutarlı doğruluk ve güvenilirliği nedeniyle **`Gemini 2.5 Flash lite`** modelidir.

### 3.2 MCP Çıktıları Günlüklerde Nasıl Doğrulanır

Ajanın doğru verileri aldığını ve LLM'nin hata yapmadığını doğrulamanın en iyi yolu, MCP sunucusu tarafından oluşturulan hata ayıklama günlük dosyasını kontrol etmektir.

Bu sunucu, proje dizininizin alt klasöründe otomatik olarak bir günlük dosyası oluşturacak şekilde yapılandırılmıştır. Konumu şu şekilde olacaktır:

```
your-project-folder/
└── logs_mcp/
    └── mcp_debug.log
```

`mcp_debug.log` içinde, aracın LLM'ye göndermeden *önce* geri gönderdiği tam JSON verisini bulacaksınız. Bu JSON'u manuel olarak inceleyerek, özellikle `monoisotopic_mass` gibi özelliklerden gelen uzun ondalık sayıları doğrulayabilir, LLM'nin nihai cevabında herhangi bir yuvarlama hatası veya hayal ürünü veri eklemediğinden emin olabilirsiniz.

---

## 📊 Kullanım

Entegre edildikten sonra, AI asistanınız kimyasal bilgilerle ilgili bir soru sorulduğunda otomatik olarak bu aracı kullanacaktır. Sunulan ana araç `search_compounds_by_name`'dır.

### Örnek İstem

Bu istem, aracın farklı ad türlerine sahip bir bileşik listesini işleyip birden fazla özelliği alabilme yeteneğini göstermektedir.

```
@agent
Please use your PubChem tool to find information on the following compounds:

- Thiamine (Vitamin B1)
- Riboflavin (Vitamin B2)
- Folic Acid
- Hydroxocobalamin

For each compound found, please retrieve the IUPAC Name, Molecular Formula, and Monoisotopic Mass.

Present all the results in a single Markdown table.
```

Agent, her bileşiği akıllıca bulacak, verilerini alacak ve biçimlendirme için LLM'ye döndürecek olan `search_compounds_by_name` aracını çağıracaktır.

---

## 🛠 MCP Aracının Açıklandığı Bölüm

### `search_compounds_by_name`

Birden fazla bileşiği isimlerine göre, birer birer, maksimum güvenilirlik için beklemeler ve yeniden denemelerle akıllı bir yedekleme stratejisi kullanarak arar.

**Parametreler:**
-   `names` (List[str]): Bileşik isimlerinden oluşan bir liste. Örnek: `["Aspirin", "Ibuprofen"]`

**Döndürür:** Her bir sözlükte ya bulunan bileşiğin bilgileri ya da o bileşiğin aramasının neden başarısız olduğuna dair hata mesajı içeren sözlüklerden oluşan bir liste.

---

## 🙏 Teşekkürler

Bu proje, **JackKuo666** tarafından oluşturulan orijinal [PubChem-MCP-Server](https://github.com/JackKuo666/PubChem-MCP-Server) temel alınarak büyük ölçüde ilham alınmış ve onun üzerine inşa edilmiştir.

Bu depo doğrudan bir çatal olmasa da, orijinal proje kritik bir başlangıç noktasıydı. Bu sürüm, orijinal konsepti aşırı dayanıklılık, akıllı arama stratejileri ve isteğe bağlı Tor entegrasyonu 🧅 ile kullanıcı gizliliği odağıyla geliştirmiştir.

Orijinal yazara, harika çalışması ve toplulukla paylaşımı için çok teşekkürler.

---

## ⚠️ Uyarı

Bu araç araştırma ve eğitim amaçlı tasarlanmıştır. Lütfen PubChem'in hizmet koşullarına saygı gösterin ve bu aracı sorumlu bir şekilde kullanın.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-27

---