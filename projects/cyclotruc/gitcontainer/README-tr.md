![Gitcontainer](https://raw.githubusercontent.com/cyclotruc/gitcontainer/main/docs/image.png)

# Gitcontainer 🐳

**Herhangi bir GitHub deposunu, yapay zeka destekli Dockerfile oluşturma ile üretime hazır bir Docker konteynerine dönüştürün.**

[![MIT Lisansı](https://img.shields.io/badge/License-MIT-green.svg)](https://choosealicense.com/licenses/mit/)
[![Python 3.9+](https://img.shields.io/badge/python-3.9+-blue.svg)](https://www.python.org/downloads/)
[![FastAPI](https://img.shields.io/badge/FastAPI-0.68+-00a393.svg)](https://fastapi.tiangolo.com/)

Gitcontainer, GitHub depolarını analiz ederek otomatik olarak üretime hazır Dockerfile’lar oluşturan yapay zeka destekli bir web uygulamasıdır. Sadece bir GitHub URL’si yapıştırın ve akıllı taban imaj seçimi, bağımlılık yönetimi ve Docker en iyi uygulamalarıyla özelleştirilmiş bir Dockerfile elde edin.

## 🌟 Hızlı Erişim

Herhangi bir GitHub deposu URL’sinde `github.com` kısmını `gitcontainer.com` ile değiştirerek o depoya ait Dockerfile oluşturma sayfasına anında erişebilirsiniz.

Örneğin:
```
https://github.com/kullanici/depoadi  →  https://gitcontainer.com/kullanici/depoadi
```

## ✨ Özellikler

- **🔄 Anında URL Erişimi**: Herhangi bir GitHub URL’sinde 'github.com' kısmını 'gitcontainer.com' ile değiştirmeniz yeterli
- **🤖 Yapay Zeka Destekli Analiz**: Depo yapısını analiz etmek ve akıllı Dockerfile’lar oluşturmak için OpenAI GPT-4 kullanır
- **⚡ Gerçek Zamanlı Akış**: AI’ın Dockerfile’ınızı WebSocket ile gerçek zamanlı olarak oluşturmasını izleyin
- **🎯 Akıllı Algılama**: Teknoloji yığınlarını otomatik olarak algılar (Python, Node.js, Java, Go, vb.)
- **🔧 Üretime Hazır**: Doğru güvenlik, çok aşamalı yapı ve optimizasyon ile en iyi uygulamalara uygun Dockerfile’lar oluşturur
- **📋 Ek Talimatlar**: Özelleşmiş ortamlar için özel gereksinimler ekleyin
- **📄 Docker Compose**: Karmaşık uygulamalar için otomatik olarak docker-compose.yml önerir
- **🎨 Modern Arayüz**: Söz dizimi vurgulama için Monaco editörüyle temiz ve duyarlı arayüz
- **📱 Mobil Uyumluluk**: Masaüstü ve mobil cihazlarda sorunsuz çalışır

## 🚀 Hızlı Başlangıç

### Ön Koşullar

- Python 3.9 veya üzeri
- Git
- OpenAI API anahtarı

### Kurulum

1. **Depoyu klonlayın:**
   ```bash
   git clone https://github.com/cyclotruc/gitcontainer.git
   cd gitcontainer
   ```

2. **Bağımlılıkları yükleyin:**
   ```bash
   pip install -r requirements.txt
   ```

3. **Ortam değişkenlerini ayarlayın:**
   ```bash
   # .env dosyası oluşturun
   echo "OPENAI_API_KEY=your_openai_api_key_here" > .env
   ```

4. **Uygulamayı başlatın:**
   ```bash
   python app.py
   ```

5. **Tarayıcınızı açın:**
   `http://localhost:8000` adresine gidin

## 🛠️ Nasıl Çalışır?

1. **URL İşleme**: Herhangi bir depoya erişmek için URL’de 'github.com' kısmını 'gitcontainer.com' ile değiştirin
2. **Depo Klonlama**: Gitcontainer, Git ile GitHub deposunu yerel olarak klonlar
3. **Kod Analizi**: [gitingest](https://github.com/cyclotruc/gitingest) kullanılarak depo yapısı analiz edilir ve ilgili bilgiler çıkarılır
4. **AI Oluşturma**: Analiz, Dockerfile oluşturmak için özel istemlerle OpenAI GPT-4’e gönderilir
5. **Akıllı Optimizasyon**: AI aşağıdakileri dikkate alır:
   - Teknoloji yığını algılama
   - Bağımlılık yönetimi
   - Güvenlik en iyi uygulamaları
   - Faydalı olduğunda çok aşamalı yapılar
   - Port yapılandırması
   - Ortam değişkenleri
   - Sağlık kontrolleri

## 📁 Proje Yapısı

```
cyclotruc-gitcontainer/
├── app.py                 # Ana FastAPI uygulaması
├── requirements.txt       # Python bağımlılıkları
├── .env                  # Ortam değişkenleri (bunu oluşturun)
├── static/               # Statik dosyalar (ikonlar, CSS)
├── templates/
│   └── index.jinja       # Ana HTML şablonu
└── tools/                # Temel işlevsellik modülleri
    ├── __init__.py
    ├── create_container.py  # AI Dockerfile oluşturma
    ├── git_operations.py    # GitHub deposu klonlama
    └── gitingest.py        # Depo analizi
```
## 🔧 Konfigürasyon

### Ortam Değişkenleri

| Değişken | Açıklama | Gerekli |
|----------|----------|---------|
| `OPENAI_API_KEY` | OpenAI API anahtarınız | Evet |
| `PORT` | Sunucu portu (varsayılan: 8000) | Hayır |
| `HOST` | Sunucu adresi (varsayılan: 0.0.0.0) | Hayır |

### Gelişmiş Kullanım

Araçları programatik olarak kullanabilirsiniz:

```python
from tools import clone_repo_tool, gitingest_tool, create_container_tool
import asyncio

async def generate_dockerfile(github_url):
    # Depoyu klonla
    clone_result = await clone_repo_tool(github_url)
    
    # gitingest ile analiz et
    analysis = await gitingest_tool(clone_result['local_path'])
    
    # Dockerfile oluştur
    dockerfile = await create_container_tool(
        gitingest_summary=analysis['summary'],
        gitingest_tree=analysis['tree'],
        gitingest_content=analysis['content']
    )
    
    return dockerfile

# Kullanım
result = asyncio.run(generate_dockerfile("https://github.com/user/repo"))
print(result['dockerfile'])
```

## 🎨 Özelleştirme

### Özel Talimatlar Ekleme

Oluşturmayı özelleştirmek için "Ek talimatlar" özelliğini kullanın:

- `"Daha küçük imaj boyutu için Alpine Linux kullan"`
- `"Redis ve PostgreSQL dahil et"`
- `"Prodüksiyon dağıtımı için optimize et"`
- `"Hata ayıklama için geliştirme araçları ekle"`

## 📝 Lisans

Bu proje MIT Lisansı ile lisanslanmıştır - detaylar için [LICENSE](LICENSE) dosyasına bakınız.

## 🙏 Teşekkürler

- **[OpenAI](https://openai.com/)** GPT-4 API sağladığı için
- **[gitingest](https://github.com/cyclotruc/gitingest)** depo analiz yetenekleri için
- **[FastAPI](https://fastapi.tiangolo.com/)** mükemmel web çatısı için
- **[Monaco Editor](https://microsoft.github.io/monaco-editor/)** kod sözdizimi vurgulama için

## 🔗 Bağlantılar

- **GitHub Deposu**: [https://github.com/cyclotruc/gitcontainer](https://github.com/cyclotruc/gitcontainer)
- **Demo**: Örnek depolarla canlı deneyin
- **Sorunlar**: [Hata bildir veya özellik iste](https://github.com/cyclotruc/gitcontainer/issues)

---

**[Romain Courtois](https://github.com/cyclotruc) tarafından ❤️ ile yapılmıştır**

*Herhangi bir depoyu saniyeler içinde bir container’a dönüştürün!*

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---