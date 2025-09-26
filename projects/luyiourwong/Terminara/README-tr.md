
<div align="right">
  <details>
    <summary >🌐 Dil</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=as">অসমীয়া</
      </div>
    </div>
  </details>

</div>

# Terminara

[![DeepWiki'ye Sor](https://deepwiki.com/badge.svg)](https://deepwiki.com/luyiourwong/Terminara)
![Python desteği](https://img.shields.io/badge/Python-3.10%20%7C%203.11%20%7C%203.12%20%7C%203.13-blue)

Terminal tabanlı bir yapay zeka simülasyon oyunu.

## Nasıl kullanılır

Yürütülebilir uygulamayı [son sürüm](https://github.com/luyiourwong/Terminara/releases/latest) üzerinden indirebilirsiniz.

Tam sıkıştırılmış dosya, yürütülebilir dosya ve varsayılan dünya ayarları dosyasını içerir. Oyunu en son sürüme güncelliyorsanız yalnızca yürütülebilir dosyayı indirebilirsiniz.

| İşletim Sistemi | Sürüm                                            |
|-----------------|--------------------------------------------------|
| Windows         | Windows 10, Windows 11                           |
| Linux           | (GLIBC 2.35+) Ubuntu 22.04 LTS, Ubuntu 24.04 LTS |
| MacOS           | macOS 13, macOS 14, macOS 15, macOS 26           |

<details>
<summary><strong>Manuel çalıştırma</strong></summary>

### Kurulum

1.  **Depoyu klonlayın:**
    ```bash
    git clone https://github.com/luyiourwong/Terminara
    cd Terminara
    ```

2.  **Sanal bir ortam oluşturun:**
    ```bash
    python -m venv .venv
    source .venv/bin/activate
    ```
    Windows'da `.venv\Scripts\activate` komutunu kullanın.

3.  **Bağımlılıkları yükleyin:**
    ```bash
    pip install -e .
    ```

### Yöntem 1'i Başlat: Kurulu komutu kullanarak (Önerilir)
Kurulumdan sonra, oyunu şu şekilde çalıştırın:
```bash
terminara
```

### Başlatma Yöntemi 2: Doğrudan çalıştırma
Çapraz platform yöntemi
```bash
python -m terminara.main
```
or
```bash
python terminara/main.py
```
Windows'ta, `terminara\main.py` dosyasını kullanın

daha fazla bilgi için, [Katkı & Geliştirme Rehberi](https://raw.githubusercontent.com/luyiourwong/Terminara/main/CONTRIBUTING.md) adresine bakın.
</details>

## AI Kurulumu

Uygulamayı başlattıktan sonra, ana menüden AI ayarlarını yapılandırmanız gerekir.

![AI Ayarları](https://raw.githubusercontent.com/luyiourwong/Terminara/main/docs/assets/ai_settings.png)

Aşağıdaki alanları doldurmanız gerekiyor: (OpenAI uyumlu API)
- **Host**: API uç noktası. Varsayılan OpenAI uç noktasını kullanmak için boş bırakın.
- **API Key**: AI servisi için API anahtarınız.
- **Model**: Kullanmak istediğiniz model.

Ayarları kaydetmek için "Uygula"ya tıklayın.

### Örnekler

#### 1. [OpenAI](https://platform.openai.com/) (Varsayılan)
- **Host**: (boş bırakın)
- **API Key**: `YOUR_OPENAI_API_KEY`
- **Model**: `gpt-4o-mini-2024-07-18`

#### 2. [Google AI Studio](http://aistudio.google.com/)
- **Host**: `https://generativelanguage.googleapis.com/v1beta/openai/`
- **API Key**: `YOUR_GEMINI_API_KEY`
- **Model**: `gemini-2.0-flash`

## Dünya Kurulumu

### Yapılandırma Depolama
Dünya ayarları `terminara/data/worlds` dizininde saklanır. (tam sürümde)
```
.
|-- terminara/
|   `-- data/
|       |-- schema/           # Json schema files for world settings
|       `-- worlds/           # Directory for world setting files
`-- terminara_platform_version        # Executable file
```

### Yeni bir dünya oluşturma
Bir örnek dünya [aethelgard.json](https://raw.githubusercontent.com/luyiourwong/Terminara/main/terminara/data/worlds/aethelgard.json) dosyasında bulunmaktadır. Yeni bir dünya oluşturmak için [şemayı](https://raw.githubusercontent.com/luyiourwong/Terminara/main/terminara/data/schema/world_schema.json) takip edebilirsiniz.

## Bağlantılar

- [GitHub Pages](https://luyiourwong.github.io/Terminara)
- [GitHub Deposu](https://github.com/luyiourwong/Terminara)
- [Katkıda Bulun & Geliştirme Rehberi](https://raw.githubusercontent.com/luyiourwong/Terminara/main/CONTRIBUTING.md)

## Lisans

Bu proje [MIT Lisansı](LICENSE) altında lisanslanmıştır.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-26

---