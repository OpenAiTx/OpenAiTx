# AgenticSeek: Özel, Yerel Manus Alternatifi.

<p align="center">
<img align="center" src="https://raw.githubusercontent.com/Fosowl/agenticSeek/main/media/agentic_seek_logo.png" width="300" height="300" alt="Agentic Seek Logo">
<p>

  English | [中文](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_CHS.md) | [繁體中文](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_CHT.md) | [Français](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_FR.md) | [日本語](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_JP.md) | [Português (Brasil)](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_PTBR.md) | [Español](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_ES.md)

*%100 yerel Manus AI alternatifidir. Bu sesli AI asistanı, tüm verilerinizi cihazınızda tutarak internette özerk olarak gezinebilir, kod yazabilir ve görevleri planlayabilir. Yerel muhakeme modelleri için özelleştirilmiş olup, tamamen kendi donanımınızda çalışır ve tam gizlilik ile sıfır bulut bağımlılığı sağlar.*

[![AgenticSeek'i Ziyaret Et](https://img.shields.io/static/v1?label=Website&message=AgenticSeek&color=blue&style=flat-square)](https://fosowl.github.io/agenticSeek.html) ![Lisans](https://img.shields.io/badge/license-GPL--3.0-green) [![Discord](https://img.shields.io/badge/Discord-Join%20Us-7289DA?logo=discord&logoColor=white)](https://discord.gg/8hGDaME3TC) [![Twitter](https://img.shields.io/twitter/url/https/twitter.com/fosowl.svg?style=social&label=Update%20%40Fosowl)](https://x.com/Martin993886460) [![GitHub stars](https://img.shields.io/github/stars/Fosowl/agenticSeek?style=social)](https://github.com/Fosowl/agenticSeek/stargazers)

### Neden AgenticSeek?

* 🔒 Tamamen Yerel ve Özel - Her şey kendi bilgisayarınızda çalışır — bulut yok, veri paylaşımı yok. Dosyalarınız, konuşmalarınız ve aramalarınız gizli kalır.

* 🌐 Akıllı Web Tarama - AgenticSeek, internette kendi başına gezinebilir — arama yapar, okur, bilgi çıkarır, web formlarını doldurur — tamamen eller serbest.

* 💻 Özerk Kodlama Asistanı - Kod mu lazım? Python, C, Go, Java ve daha fazlasında program yazabilir, hata ayıklayabilir ve çalıştırabilir — tamamen gözetimsiz.

* 🧠 Akıllı Ajan Seçimi - Siz sorarsınız, o işi için en iyi ajanı otomatik olarak bulur. Uzman bir ekip her an yardıma hazır gibi.

* 📋 Karmaşık Görevleri Planlar ve Uygular - Seyahat planlamadan karmaşık projelere — büyük görevleri adımlara böler ve birden fazla AI ajanı ile işi bitirir.

* 🎙️ Sesli - Temiz, hızlı ve fütüristik sesli yanıt ve konuşmadan metne özelliği ile bir bilim kurgu filmindeki kişisel AI'nızla konuşuyormuş gibi olursunuz. (Geliştiriliyor)

### **Demo**

> *AgenticSeek projesini arayabilir misin, hangi yeteneklerin gerektiğini öğrenip, sonra CV_candidates.zip dosyasını açıp projeye en uygun olanları bana söyleyebilir misin?*

https://github.com/user-attachments/assets/b8ca60e9-7b3b-4533-840e-08f9ac426316

Açıklama: Bu demo ve görünen tüm dosyalar (örn: CV_candidates.zip) tamamen kurgusaldır. Bir şirket değiliz, aday değil açık kaynak katkıcıları arıyoruz.

> 🛠⚠️️ **Aktif Olarak Geliştiriliyor**

> 🙏 Bu proje bir yan proje olarak başladı ve hiçbir yol haritası ya da fonlaması yok. GitHub Trending'de yer alacak kadar büyüdü. Katkılarınız, geri bildiriminiz ve sabrınız için minnettarız.

## Ön Koşullar

Başlamadan önce, aşağıdaki yazılımların kurulu olduğundan emin olun:

*   **Git:** Depoyu klonlamak için. [Git İndir](https://git-scm.com/downloads)
*   **Python 3.10.x:** Python 3.10.x sürümünü kullanmanız şiddetle tavsiye edilir. Diğer sürümlerde bağımlılık hatası yaşanabilir. [Python 3.10 İndir](https://www.python.org/downloads/release/python-3100/) (3.10.x sürümünü seçin).
*   **Docker Engine & Docker Compose:** SearxNG gibi paket hizmetleri çalıştırmak için.
    *   Docker Desktop'u yükleyin (Docker Compose V2 dahildir): [Windows](https://docs.docker.com/desktop/install/windows-install/) | [Mac](https://docs.docker.com/desktop/install/mac-install/) | [Linux](https://docs.docker.com/desktop/install/linux-install/)
    *   Alternatif olarak Linux'ta Docker Engine ve Docker Compose'u ayrı ayrı yükleyin: [Docker Engine](https://docs.docker.com/engine/install/) | [Docker Compose](https://docs.docker.com/compose/install/) (Compose V2 yüklediğinizden emin olun, örn. `sudo apt-get install docker-compose-plugin`).

### 1. **Depoyu klonlayın ve kurulumu başlatın**

```sh
git clone https://github.com/Fosowl/agenticSeek.git
cd agenticSeek
mv .env.example .env
```

### 2. .env dosyasının içeriğini değiştirin

```sh
SEARXNG_BASE_URL="http://127.0.0.1:8080"
REDIS_BASE_URL="redis://redis:6379/0"
WORK_DIR="/Users/mlg/Documents/workspace_for_ai"
OLLAMA_PORT="11434"
LM_STUDIO_PORT="1234"
CUSTOM_ADDITIONAL_LLM_PORT="11435"
OPENAI_API_KEY='opsiyonel'
DEEPSEEK_API_KEY='opsiyonel'
OPENROUTER_API_KEY='opsiyonel'
TOGETHER_API_KEY='opsiyonel'
GOOGLE_API_KEY='opsiyonel'
ANTHROPIC_API_KEY='opsiyonel'
```

Gerekirse `.env` dosyasındaki değerleri kendinize göre güncelleyin:

- **SEARXNG_BASE_URL**: Değiştirmeyin 
- **REDIS_BASE_URL**: Değiştirmeyin 
- **WORK_DIR**: Yerel makinenizdeki çalışma dizininizin yolu. AgenticSeek bu dizindeki dosyaları okuyabilir ve onlarla etkileşime geçebilir.
- **OLLAMA_PORT**: Ollama servisi için port numarası.
- **LM_STUDIO_PORT**: LM Studio servisi için port numarası.
- **CUSTOM_ADDITIONAL_LLM_PORT**: Herhangi bir ek özel LLM servisi için port.

**API Anahtarları, LLM'i yerel olarak çalıştırmayı seçen kullanıcılar için tamamen isteğe bağlıdır. Bu projenin birincil amacı budur. Yeterli donanımınız varsa boş bırakabilirsiniz.**

### 3. **Docker'ı Başlatın**

Sisteminizde Docker'ın kurulu ve çalışır olduğundan emin olun. Aşağıdaki komutlarla Docker'ı başlatabilirsiniz:

- **Linux/macOS'ta:**  
    Bir terminal açın ve şunu çalıştırın:
    ```sh
    sudo systemctl start docker
    ```
    Veya uygulamalar menüsünden Docker Desktop'u başlatın.

- **Windows'ta:**  
    Başlat menüsünden Docker Desktop'u başlatın.

Docker'ın çalıştığını doğrulamak için şunu çalıştırın:
```sh
docker info
```
Docker kurulumu hakkında bilgi görüyorsanız, doğru şekilde çalışıyor demektir.

Aşağıdaki [Yerel Sağlayıcılar Tablosu](#list-of-local-providers)'na göz atın.

Sonraki adım: [AgenticSeek'i Yerel Olarak Çalıştırın](#start-services-and-run)

*Sorun yaşıyorsanız [Sorun Giderme](#troubleshooting) bölümüne bakın.*
*Donanımınız LLM'leri yerel olarak çalıştıramıyorsa, [API ile çalıştırma kurulumu](#setup-to-run-with-an-api) bölümüne bakın.*
*Detaylı `config.ini` açıklamaları için [Yapılandırma Bölümü](#config) bölümüne bakın.*

---

## LLM'i kendi bilgisayarınızda yerel çalıştırma kurulumu

**Donanım Gereksinimleri:**

LLM'leri yerel olarak çalıştırmak için yeterli donanıma ihtiyacınız var. En azından Magistral, Qwen veya Deepseek 14B çalıştırabilen bir GPU gereklidir. Detaylı model/performance önerileri için SSS'ye bakın.

**Yerel sağlayıcınızı başlatın**  

Örneğin ollama ile yerel sağlayıcınızı başlatın:

```sh
ollama serve
```

Aşağıda desteklenen yerel sağlayıcıların listesine bakın.

**config.ini dosyasını güncelleyin**

config.ini dosyasını düzenleyerek provider_name alanını desteklenen bir sağlayıcı ile ve provider_model alanını sağlayıcınızın desteklediği bir LLM ile değiştirin. *Magistral* veya *Deepseek* gibi muhakeme modellerini öneririz.

Gerekli donanım için README'nin sonundaki **SSS**'ye bakın.

```sh
[MAIN]
is_local = True # Yerel mi yoksa uzaktan mı çalıştırıyorsunuz.
provider_name = ollama # veya lm-studio, openai, vb..
provider_model = deepseek-r1:14b # Donanımınıza uygun bir model seçin
provider_server_address = 127.0.0.1:11434
agent_name = Jarvis # AI'nızın adı
recover_last_session = True # Önceki oturumu kurtarıp kurtarmayacağı
save_session = True # Geçerli oturumu hatırlayıp hatırlamayacağı
speak = False # Metinden sese
listen = False # Sesten metne, sadece CLI için, deneysel
jarvis_personality = False # Daha "Jarvis" benzeri bir kişilik kullanılıp kullanılmayacağı (deneysel)
languages = en zh # Diller listesi, Metinden Sese ilk dili varsayılan olarak kullanır
[BROWSER]
headless_browser = True # CLI kullanmıyorsanız değiştirmeyin.
stealth_mode = True # Tespit edilmemiş selenium kullanarak tarayıcı tespitini azaltır
```

**Uyarı**:

- `config.ini` dosya formatı yorum satırlarını desteklemez. 
Örnek yapılandırmayı doğrudan kopyalayıp yapıştırmayın, yorum satırları hata verebilir. Bunun yerine istediğiniz ayarlarla `config.ini` dosyasını elle düzenleyin ve yorum satırı eklemeyin.

- Eğer LLM'leri çalıştırmak için LM-studio kullanıyorsanız provider_name'i `openai` olarak AYARLAMAYIN. `lm-studio` olarak ayarlayın.

- Bazı sağlayıcılar (örn: lm-studio), IP'nin önünde `http://` olmasını ister. Örneğin `http://127.0.0.1:1234`

**Yerel sağlayıcılar listesi**

| Sağlayıcı  | Yerel? | Açıklama                                               |
|-----------|--------|--------------------------------------------------------|
| ollama    | Evet   | Ollama ile kolayca yerel LLM çalıştırın                |
| lm-studio | Evet   | LM studio ile yerel LLM çalıştırın (`provider_name`i `lm-studio` olarak ayarlayın)|
| openai    | Evet   | OpenAI uyumlu API kullanın (örn: llama.cpp server)     |

Sonraki adım: [Servisleri Başlatın ve AgenticSeek'i çalıştırın](#Start-services-and-Run)  

*Sorun yaşıyorsanız [Sorun Giderme](#troubleshooting) bölümüne bakın.*
*Donanımınız LLM'leri yerel olarak çalıştıramıyorsa, [API ile çalıştırma kurulumu](#setup-to-run-with-an-api) bölümüne bakın.*
*Detaylı `config.ini` açıklamaları için [Yapılandırma Bölümü](#config) bölümüne bakın.*

## API ile çalıştırma kurulumu

Bu kurulum, harici, bulut tabanlı LLM sağlayıcılarını kullanır. Seçtiğiniz servisten bir API anahtarı almanız gerekir.

**1. Bir API Sağlayıcı Seçin ve API Anahtarı Alın:**

Aşağıdaki [API Sağlayıcıları Listesi](#list-of-api-providers)'ne bakın. Web sitelerini ziyaret ederek kaydolun ve API anahtarı alın.

**2. API Anahtarınızı Ortam Değişkeni Olarak Ayarlayın:**


*   **Linux/macOS:**
    Terminalinizi açın ve `export` komutunu kullanın. Kalıcılık için bunu kabuk profil dosyanıza (örn: `~/.bashrc`, `~/.zshrc`) eklemeniz en iyisidir.
    ```sh
    export PROVIDER_API_KEY="api_anahtarınız_buraya" 
    # PROVIDER_API_KEY yerine ilgili değişken adını yazın, örn: OPENAI_API_KEY, GOOGLE_API_KEY
    ```
    TogetherAI örneği:
    ```sh
    export TOGETHER_API_KEY="xxxxxxxxxxxxxxxxxxxxxx"
    ```
*   **Windows:**
*   **Komut İstemi (Geçici, mevcut oturum için):**
    ```cmd
    set PROVIDER_API_KEY=api_anahtarınız_buraya
    ```
*   **PowerShell (Geçici, mevcut oturum için):**
    ```powershell
    $env:PROVIDER_API_KEY="api_anahtarınız_buraya"
    ```
*   **Kalıcı Olarak:** Windows arama çubuğunda "environment variables" (çevre değişkenleri) arayın, "Sistem ortam değişkenlerini düzenle" seçeneğine tıklayın, ardından "Ortam Değişkenleri..." butonuna tıklayın. Uygun isimle (örn. `OPENAI_API_KEY`) ve anahtarınız değer olarak yeni bir Kullanıcı değişkeni ekleyin.

*(Daha fazla bilgi için SSS: [API anahtarlarını nasıl ayarlayabilirim?](#how-do-i-set-api-keys) bölümüne bakınız).*

**3. `config.ini` Dosyasını Güncelleyin:**
```ini
[MAIN]
is_local = False
provider_name = openai # Veya google, deepseek, togetherAI, huggingface
provider_model = gpt-3.5-turbo # Veya gemini-1.5-flash, deepseek-chat, mistralai/Mixtral-8x7B-Instruct-v0.1 vb.
provider_server_address = # Genellikle is_local = False olduğunda çoğu API için göz ardı edilir veya boş bırakılabilir
# ... diğer ayarlar ...
```
*Uyarı:* `config.ini` dosyasındaki değerlerin sonunda boşluk bırakmadığınızdan emin olun.

**API Sağlayıcıları Listesi**

| Sağlayıcı     | `provider_name` | Yerel? | Açıklama                                       | API Anahtar Bağlantısı (Örnekler)                     |
|---------------|-----------------|--------|------------------------------------------------|-------------------------------------------------------|
| OpenAI        | `openai`        | Hayır  | OpenAI'nin API'si ile ChatGPT modellerini kullanır. | [platform.openai.com/signup](https://platform.openai.com/signup) |
| Google Gemini | `google`        | Hayır  | Google Gemini modellerini Google AI Studio ile kullanır. | [aistudio.google.com/keys](https://aistudio.google.com/keys) |
| Deepseek      | `deepseek`      | Hayır  | Deepseek modellerini kendi API'leri ile kullanır. | [platform.deepseek.com](https://platform.deepseek.com) |
| Hugging Face  | `huggingface`   | Hayır  | Hugging Face Inference API'den modeller kullanır. | [huggingface.co/settings/tokens](https://huggingface.co/settings/tokens) |
| TogetherAI    | `togetherAI`    | Hayır  | TogetherAI API ile çeşitli açık kaynak modelleri kullanır. | [api.together.ai/settings/api-keys](https://api.together.ai/settings/api-keys) |

*Not:*
*   Karmaşık web arama ve görev planlama için mevcut istem optimizasyonları Deepseek gibi modellere yönelik olduğundan, `gpt-4o` veya diğer OpenAI modellerini kullanmanızı önermiyoruz.
*   Kodlama/bash görevlerinde Gemini ile, Deepseek için optimize edilmiş biçimlendirme istemlerini her zaman kesin olarak takip etmeyebileceği için sorun yaşanabilir.
*   `config.ini` dosyasındaki `provider_server_address` ayarı, `is_local = False` olduğunda genellikle kullanılmaz; çünkü API uç noktası ilgili sağlayıcının kütüphanesinde sabit kodlanmıştır.

Sonraki adım: [Servisleri başlatın ve AgenticSeek'i çalıştırın](#Start-services-and-Run)

*Sorun yaşıyorsanız **Bilinen sorunlar** bölümüne bakınız.*

*Ayrıntılı yapılandırma dosyası açıklaması için **Config** bölümüne bakınız.*

---

## Servisleri Başlatın ve Çalıştırın

Varsayılan olarak AgenticSeek tamamen docker içinde çalışır.

Gerekli servisleri başlatın. Bu, docker-compose.yml dosyasından tüm servisleri başlatır; şunlar dahil:
    - searxng
    - redis (searxng tarafından gereklidir)
    - frontend
    - backend (eğer `full` kullanıyorsanız)

```sh
./start_services.sh full # MacOS
start ./start_services.cmd full # Windows
```

**Uyarı:** Bu adım tüm Docker imajlarını indirecek ve yükleyecektir, bu işlem 30 dakikaya kadar sürebilir. Servisleri başlattıktan sonra, herhangi bir mesaj göndermeden önce lütfen backend servisi tamamen başlatılana kadar bekleyin (günlüklerde **backend: "GET /health HTTP/1.1" 200 OK** mesajını görmelisiniz). Backend servisleri ilk çalıştırmada 5 dakika kadar sürebilir.

`http://localhost:3000/` adresine gidin; web arayüzünü göreceksiniz.

*Servis başlatma sorun giderme:* Eğer bu scriptler başarısız olursa, Docker Engine'in çalıştığından ve Docker Compose'un (V2, `docker compose`) doğru şekilde kurulu olduğundan emin olun. Hata mesajları için terminaldeki çıktıyı kontrol edin. [SSS: AgenticSeek veya scriptleri çalıştırırken hata alıyorum, ne yapmalıyım?](#faq-troubleshooting) bölümüne bakınız.

**Opsiyonel:** Ana makinede çalıştır (CLI modu):

CLI arayüzü ile çalıştırmak için paketi ana makinenize kurmanız gerekir:

```sh
./install.sh
./install.bat # windows
```

Servisleri başlatın:

```sh
./start_services.sh # MacOS
start ./start_services.cmd # Windows
```

CLI kullanın: `python3 cli.py`


---

## Kullanım

Servislerin `./start_services.sh full` ile çalıştığından emin olun ve web arayüzü için `localhost:3000` adresine gidin.

Ayrıca config dosyasında `listen = True` olarak ayarlayarak konuşmadan yazıya (speech to text) özelliğini kullanabilirsiniz. Sadece CLI modu için geçerlidir.

Çıkmak için sadece `goodbye` yazmanız veya söylemeniz yeterlidir.

Bazı örnek kullanım şekilleri:

> *Python'da bir yılan oyunu yap!*

> *Fransa, Rennes'teki en iyi kafeleri web'de ara ve üç tanesinin adresleriyle birlikte rennes_cafes.txt dosyasına kaydet.*

> *Bir sayının faktoriyelini hesaplayan bir Go programı yaz, factorial.go olarak çalışma alanına kaydet*

> *summer_pictures klasörümdeki tüm JPG dosyalarını ara, bugünün tarihiyle yeniden adlandır ve yeniden adlandırılan dosyaların listesini photos_list.txt'ye kaydet*

> *2024'ten popüler bilim kurgu filmlerini çevrimiçi ara, bu gece izlemek için üç tane seç. Listeyi movie_night.txt dosyasına kaydet.*

> *2025'ten en son AI haber makalelerini web'de ara, üç tane seç ve başlıklarını ve özetlerini kazıyacak bir Python scripti yaz. Scripti news_scraper.py olarak, özetleri ise /home/projects klasöründe ai_news.txt olarak kaydet*

> *Cuma günü, web'de ücretsiz bir hisse senedi fiyat API'si ara, supersuper7434567@gmail.com ile kayıt ol ve ardından API'yi kullanarak Tesla'nın günlük fiyatlarını çeken bir Python scripti yaz, sonuçları stock_prices.csv dosyasına kaydet.*

*Form doldurma yeteneklerinin hâlâ deneysel olduğunu ve başarısız olabileceğini unutmayın.*


Sorgunuzu yazdıktan sonra, AgenticSeek göreve en uygun ajanı atayacaktır.

Bu erken prototipte, ajan yönlendirme sistemi sorgunuza göre her zaman doğru ajanı tahsis edemeyebilir.

Bu nedenle, ne istediğinizi ve AI'nın nasıl ilerlemesi gerektiğini çok açık bir şekilde belirtmelisiniz; örneğin bir web araması yapmasını istiyorsanız, şunu demeyin:

`Yalnız seyahat için iyi ülkeleri biliyor musun?`

Bunun yerine şunu sorun:

`Bir web araması yap ve yalnız seyahat için en iyi ülkeleri bul`

---

## **LLM'i kendi sunucunuzda çalıştıracak şekilde kurulum**  

Güçlü bir bilgisayarınız veya kullanabileceğiniz bir sunucunuz varsa, fakat ona dizüstü bilgisayarınızdan erişmek istiyorsanız, özel llm sunucumuzu kullanarak LLM'i uzak bir sunucuda çalıştırabilirsiniz.

AI modelini çalıştıracak olan "sunucunuzda" ip adresini alın

```sh
ip a | grep "inet " | grep -v 127.0.0.1 | awk '{print $2}' | cut -d/ -f1 # yerel ip
curl https://ipinfo.io/ip # genel ip
```

Not: Windows veya macOS için ip adresini bulmak için sırasıyla ipconfig veya ifconfig kullanın.

Depoyu klonlayın ve `server/` klasörüne girin.


```sh
git clone --depth 1 https://github.com/Fosowl/agenticSeek.git
cd agenticSeek/llm_server/
```

Sunucuya özel gereksinimleri kurun:

```sh
pip3 install -r requirements.txt
```

Sunucu scriptini çalıştırın.

```sh
python3 app.py --provider ollama --port 3333
```

`ollama` ve `llamacpp` arasında LLM servisi olarak seçim yapabilirsiniz.


Şimdi kişisel bilgisayarınızda:

`config.ini` dosyasını değiştirerek `provider_name` değerini `server`, `provider_model` değerini ise `deepseek-r1:xxb` olarak ayarlayın.
`provider_server_address` değerini, modeli çalıştıracak makinenin ip adresi olarak ayarlayın.

```sh
[MAIN]
is_local = False
provider_name = server
provider_model = deepseek-r1:70b
provider_server_address = x.x.x.x:3333
```


Sonraki adım: [Servisleri başlatın ve AgenticSeek'i çalıştırın](#Start-services-and-Run)  

---

## Konuşmadan Yazıya (Speech to Text)

Uyarı: konuşmadan yazıya özelliği şu anda sadece CLI modunda çalışır.

Lütfen şu anda konuşmadan yazıya özelliğinin yalnızca İngilizce olarak çalıştığını unutmayın.

Konuşmadan yazıya işlevselliği varsayılan olarak devre dışıdır. Bunu etkinleştirmek için config.ini dosyasında listen seçeneğini True olarak ayarlayın:

```
listen = True
```

Etkinleştirildiğinde, konuşmadan yazıya özelliği girişinizi işlemeye başlamadan önce tetikleyici bir anahtar kelimeyi, yani ajan adını dinler. Ajanın adını, *config.ini* dosyasındaki `agent_name` değerini güncelleyerek özelleştirebilirsiniz:

```
agent_name = Friday
```

En iyi tanıma için, temsilci adı olarak "John" veya "Emma" gibi yaygın bir İngilizce isim kullanılmasını öneriyoruz.

Transkript görünmeye başladığında, temsilcinin adını yüksek sesle söyleyerek onu uyandırın (ör. "Friday").

Sorgunuzu net bir şekilde konuşun.

Talebinizi sistemin devam etmesini işaret eden bir onay ifadesiyle bitirin. Onay ifadelerine örnekler:
```
"do it", "go ahead", "execute", "run", "start", "thanks", "would ya", "please", "okay?", "proceed", "continue", "go on", "do that", "go it", "do you understand?"
```

## Konfig

Örnek konfig:
```
[MAIN]
is_local = True
provider_name = ollama
provider_model = deepseek-r1:32b
provider_server_address = http://127.0.0.1:11434 # Ollama için örnek; LM-Studio için http://127.0.0.1:1234 kullanın
agent_name = Friday
recover_last_session = False
save_session = False
speak = False
listen = False

jarvis_personality = False
languages = en zh # TTS ve potansiyel yönlendirme için diller listesi.
[BROWSER]
headless_browser = False
stealth_mode = False
```

**`config.ini` Ayarlarının Açıklaması**:

*   **`[MAIN]` Bölümü:**
    *   `is_local`: Yerel bir LLM sağlayıcı (Ollama, LM-Studio, yerel OpenAI-uyumlu sunucu) veya kendi barındırdığınız sunucu seçeneği kullanıyorsanız `True`. Bulut tabanlı bir API (OpenAI, Google, vb.) kullanıyorsanız `False`.
    *   `provider_name`: LLM sağlayıcısını belirtir.
        *   Yerel seçenekler: `ollama`, `lm-studio`, `openai` (yerel OpenAI uyumlu sunucular için), `server` (kendi barındırılan sunucu kurulumu için).
        *   API seçenekleri: `openai`, `google`, `deepseek`, `huggingface`, `togetherAI`.
    *   `provider_model`: Seçilen sağlayıcı için belirli model adı veya kimliği (örn. Ollama için `deepseekcoder:6.7b`, OpenAI API için `gpt-3.5-turbo`, TogetherAI için `mistralai/Mixtral-8x7B-Instruct-v0.1`).
    *   `provider_server_address`: LLM sağlayıcınızın adresi.
        *   Yerel sağlayıcılar için: örn. Ollama için `http://127.0.0.1:11434`, LM-Studio için `http://127.0.0.1:1234`.
        *   `server` sağlayıcı tipi için: Kendi barındırdığınız LLM sunucunuzun adresi (örn. `http://your_server_ip:3333`).
        *   Bulut API'leri (`is_local = False`): Genellikle yok sayılır ya da boş bırakılabilir, çünkü API uç noktası genellikle istemci kütüphanesi tarafından yönetilir.
    *   `agent_name`: Yapay zeka asistanının adı (örn. Friday). Konuşmadan yazıya tetikleme kelimesi olarak kullanılır.
    *   `recover_last_session`: Önceki oturumun durumunu geri yüklemeye çalışmak için `True`, yeni başlamak için `False`.
    *   `save_session`: Gelecekte kurtarmak için mevcut oturumun durumunu kaydetmek için `True`, aksi takdirde `False`.
    *   `speak`: Metinden konuşmaya sesli çıktı için `True`, devre dışı bırakmak için `False`.
    *   `listen`: Konuşmadan yazıya sesli giriş (yalnızca CLI modu) için `True`, devre dışı bırakmak için `False`.
    *   `work_dir`: **Kritik:** AgenticSeek'in dosya okuyup/yazacağı dizin. **Bu yolun sisteminizde geçerli ve erişilebilir olduğundan emin olun.**
    *   `jarvis_personality`: Daha "Jarvis-benzeri" bir sistem istemi için `True` (deneysel), standart istem için `False`.
    *   `languages`: Virgülle ayrılmış diller listesi (örn. `en, zh, fr`). TTS ses seçimi için kullanılır (ilki varsayılan olur) ve LLM yönlendiriciye yardımcı olabilir. Yönlendirici verimliliği için çok fazla veya çok benzer dil eklemekten kaçının.
*   **`[BROWSER]` Bölümü:**
    *   `headless_browser`: Otomatikleştirilmiş tarayıcıyı görünür bir pencere olmadan çalıştırmak için `True` (web arayüzü veya etkileşimsiz kullanım için önerilir). Tarayıcı penceresini göstermek için `False` (CLI modu veya hata ayıklama için yararlı).
    *   `stealth_mode`: Tarayıcı otomasyonunun algılanmasını zorlaştıracak önlemleri etkinleştirmek için `True`. Anticaptcha gibi tarayıcı eklentilerinin manuel olarak yüklenmesini gerektirebilir.


Bu bölüm, desteklenen LLM sağlayıcı tiplerini özetler. Bunları `config.ini` dosyasında yapılandırın.

**Yerel Sağlayıcılar (Kendi Donanımınızda Çalıştırılır):**

| `config.ini`de Sağlayıcı Adı | `is_local` | Açıklama                                                                | Kurulum Bölümü                                                        |
|------------------------------|------------|-------------------------------------------------------------------------|-----------------------------------------------------------------------|
| `ollama`                     | `True`     | Yerel LLM'leri sunmak için Ollama'yı kullanır.                          | [Yerel LLM çalıştırma kurulumu](#setup-for-running-llm-locally-on-your-machine) |
| `lm-studio`                  | `True`     | Yerel LLM'leri sunmak için LM-Studio'yu kullanır.                       | [Yerel LLM çalıştırma kurulumu](#setup-for-running-llm-locally-on-your-machine) |
| `openai` (yerel sunucu için) | `True`     | OpenAI uyumlu API sunan yerel bir sunucuya bağlanır (örn. llama.cpp).   | [Yerel LLM çalıştırma kurulumu](#setup-for-running-llm-locally-on-your-machine) |
| `server`                     | `False`    | Başka bir makinede çalışan AgenticSeek kendi barındırılan LLM sunucusuna bağlanır. | [LLM'i kendi sunucunuzda çalıştırma kurulumu](#setup-to-run-the-llm-on-your-own-server) |

**API Sağlayıcılar (Bulut Tabanlı):**

| `config.ini`de Sağlayıcı Adı | `is_local` | Açıklama                                         | Kurulum Bölümü                                     |
|------------------------------|------------|--------------------------------------------------|----------------------------------------------------|
| `openai`                     | `False`    | OpenAI'nin resmi API'sini kullanır (örn. GPT-3.5, GPT-4). | [API ile çalışma kurulumu](#setup-to-run-with-an-api) |
| `google`                     | `False`    | API üzerinden Google'ın Gemini modellerini kullanır. | [API ile çalışma kurulumu](#setup-to-run-with-an-api) |
| `deepseek`                   | `False`    | Deepseek'in resmi API'sini kullanır.             | [API ile çalışma kurulumu](#setup-to-run-with-an-api) |
| `huggingface`                | `False`    | Hugging Face Inference API'sini kullanır.        | [API ile çalışma kurulumu](#setup-to-run-with-an-api) |
| `togetherAI`                 | `False`    | Çeşitli açık modeller için TogetherAI API'sini kullanır. | [API ile çalışma kurulumu](#setup-to-run-with-an-api) |

---
## Sorun Giderme

Herhangi bir sorunla karşılaşırsanız, bu bölüm size rehberlik edecektir.

# Bilinen Sorunlar

## ChromeDriver Sorunları

**Hata Örneği:** `SessionNotCreatedException: Message: session not created: This version of ChromeDriver only supports Chrome version XXX`

*   **Neden:** Yüklü ChromeDriver sürümünüz, Google Chrome tarayıcınızın sürümüyle uyumlu değil.
*   **Çözüm:**
    1.  **Chrome Sürümünü Kontrol Edin:** Google Chrome'u açın, `Ayarlar > Chrome Hakkında` bölümüne gidin ve sürümünüzü bulun (örn. "Sürüm 120.0.6099.110").
    2.  **Eşleşen ChromeDriver'ı İndirin:**
        *   Chrome 115 ve üzeri sürümler için: [Chrome for Testing (CfT) JSON Endpoints](https://googlechromelabs.github.io/chrome-for-testing/) adresine gidin. "Stable" kanalını bulun ve Chrome'unuzun ana sürümüyle eşleşen ChromeDriver'ı işletim sisteminize uygun olarak indirin.
        *   Eski sürümler (daha az yaygın): [ChromeDriver - WebDriver for Chrome](https://chromedriver.chromium.org/downloads) sayfasında bulabilirsiniz.
        *   Aşağıdaki görsel CfT sayfasından bir örneği göstermektedir:
            ![Chrome for Testing sayfasından belirli sürüm Chromedriver indirin](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/media/chromedriver_readme.png)
    3.  **ChromeDriver'ı Kurun:**
        *   İndirilen `chromedriver` dosyasının (Windows'ta `chromedriver.exe`) sisteminizin PATH ortam değişkeninde listelenen bir dizinde (örn. Linux/macOS için `/usr/local/bin` veya Windows'ta PATH'e eklenmiş bir özel komut dosyası klasörü) olduğundan emin olun.
        *   Alternatif olarak, bunu `agenticSeek` projesinin kök dizinine yerleştirin.
        *   Sürücünün çalıştırılabilir olduğundan emin olun (örn. Linux/macOS için `chmod +x chromedriver`).
    4.  Daha fazla ayrıntı için ana Kurulum rehberindeki [ChromeDriver Kurulumu](#chromedriver-installation) bölümüne bakın.

Bu bölüm eksikse veya başka ChromeDriver sorunlarıyla karşılaşırsanız, lütfen mevcut [GitHub Sorunları](https://github.com/Fosowl/agenticSeek/issues) arasında arama yapın veya yeni bir tane açın.

`Exception: Failed to initialize browser: Message: session not created: This version of ChromeDriver only supports Chrome version 113
Current browser version is 134.0.6998.89 with binary path`

Bu, tarayıcınız ile chromedriver sürümünüz arasında bir uyumsuzluk varsa oluşur.

En son sürümü indirmek için şuraya gidin:

https://developer.chrome.com/docs/chromedriver/downloads

Chrome'un 115 veya üzeri bir sürümünü kullanıyorsanız şuraya gidin:

https://googlechromelabs.github.io/chrome-for-testing/

Ve işletim sisteminize uygun chromedriver sürümünü indirin.

![alt text](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/media/chromedriver_readme.png)

Bu bölüm eksikse lütfen bir sorun bildirin.

##  bağlantı adaptörleri Sorunları

```
Exception: Provider lm-studio failed: HTTP request failed: No connection adapters were found for '127.0.0.1:1234/v1/chat/completions'` (Not: port değişebilir)
```

*   **Neden:** `lm-studio` (veya benzer diğer yerel OpenAI uyumlu sunucular) için `config.ini` dosyasındaki `provider_server_address`, `http://` öneki olmadan girilmiş veya yanlış porta yönlendirilmiş.
*   **Çözüm:**
    *   Adresin `http://` içerdiğinden emin olun. LM-Studio genellikle `http://127.0.0.1:1234` ile varsayılan gelir.
    *   Doğru `config.ini`: `provider_server_address = http://127.0.0.1:1234` (veya gerçek LM-Studio sunucu portunuz).

## SearxNG Temel URL Sağlanmadı

```
raise ValueError("SearxNG base URL must be provided either as an argument or via the SEARXNG_BASE_URL environment variable.")
ValueError: SearxNG base URL must be provided either as an argument or via the SEARXNG_BASE_URL environment variable.`
```

## SSS

**S: Hangi donanım gereklidir?**  

| Model Boyutu | GPU  | Yorum                                               |
|--------------|------|-----------------------------------------------------|
| 7B           | 8GB Vram | ⚠️ Tavsiye edilmez. Performansı düşük, sık sık halüsinasyon yapar ve planlayıcı ajanlar muhtemelen başarısız olur. |
| 14B          | 12 GB VRAM (örn. RTX 3060) | ✅ Basit görevler için kullanılabilir. Web tarama ve planlama görevlerinde zorlanabilir. |
| 32B          | 24+ GB VRAM (örn. RTX 4090) | 🚀 Çoğu görevde başarılı, yine de görev planlamada zorlanabilir |
| 70B+         | 48+ GB Vram | 💪 Mükemmel. Gelişmiş kullanım senaryoları için önerilir. |

**S: Hata alıyorum, ne yapmalıyım?**  

Yerel çalışıyor mu kontrol edin (`ollama serve`), `config.ini` dosyanız sağlayıcınızla uyumlu mu ve bağımlılıklar yüklü mü emin olun. Hiçbiri işe yaramazsa bir sorun bildirmekten çekinmeyin.

**S: Gerçekten %100 yerel çalışabilir mi?**  

Evet, Ollama, lm-studio veya server sağlayıcılarla, tüm konuşmadan yazıya, LLM ve metinden konuşmaya modelleri yerel olarak çalışır. Yerel olmayan seçenekler (OpenAI veya diğer API'ler) isteğe bağlıdır.

**S: Zaten Manus varken neden AgenticSeek kullanmalıyım?**

Manus'un aksine AgenticSeek, harici sistemlerden bağımsızlığı ön planda tutar; size daha fazla kontrol, gizlilik ve API maliyetlerinden kaçınma imkanı sunar.

**S: Projenin arkasında kim var?**

Proje tarafımdan başlatıldı, ayrıca iki arkadaşım GitHub'daki açık kaynak topluluğundan katkıcı ve sürdürücü olarak yer alıyor. Sadece tutkulu bir grup bireyiz, bir startup veya herhangi bir kuruluşla ilişkili değiliz.

Kişisel hesabım (https://x.com/Martin993886460) dışındaki herhangi bir AgenticSeek hesabı X üzerinde sahteciliktir.

## Katkıda Bulunun

AgenticSeek'i geliştirmek için geliştiricilere ihtiyacımız var! Açık sorunları veya tartışmaları inceleyin.

[Katkı rehberi](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/docs/CONTRIBUTING.md)

[![Star History Chart](https://api.star-history.com/svg?repos=Fosowl/agenticSeek&type=Date)](https://www.star-history.com/#Fosowl/agenticSeek&Date)

## Sürdürücüler:

 > [Fosowl](https://github.com/Fosowl) | Paris Saati 

 > [antoineVIVIES](https://github.com/antoineVIVIES) | Taipei Saati 

 > [steveh8758](https://github.com/steveh8758) | Taipei Saati 

## Özel Teşekkürler:

 > [tcsenpai](https://github.com/tcsenpai) ve [plitc](https://github.com/plitc) arka uç dockerizasyonuna yardımcı oldukları için

## Sponsorlar:

Aylık 5$ veya daha fazla sponsorlar burada yer alır:
- **tatra-labs**

Sure! Please provide the content of Part 4 of 4 that you would like to have translated.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-16

---