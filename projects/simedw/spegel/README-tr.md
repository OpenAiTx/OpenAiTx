# Spegel – Web’i Yapay Zeka ile Yansıtın

Web sitelerini otomatik olarak terminalde görüntülemeye optimize edilmiş markdown formatına çevirir.
Tanıtım blog yazısını [buradan](https://simedw.com/2025/06/23/introducing-spegel/) okuyabilirsiniz.

Bu bir ön gösterimdir, hatalar olabilir fakat sorun veya pull request oluşturmakta özgürsünüz.

##  Ekran Görüntüsü
Bazen bir tarif bulmak için birinin hayat hikayesini okumak istemezsiniz
![Tarif Örneği](https://simedw.com/2025/06/23/introducing-spegel/images/recipe_example.png)


## Kurulum

Python 3.11+ gerektirir

```
pip install spegel
```
veya depoyu klonlayıp düzenlenebilir modda kurabilirsiniz

```bash
# Depoyu klonla ve dizine gir
$ git clone <repo-url>
$ cd spegel

# Bağımlılıkları ve CLI'ı kur
$ pip install -e .
```

## API Anahtarları
Spegel şu anda yalnızca Gemini 2.5 Flash’ı desteklemektedir. Kullanmak için API anahtarınızı ortam değişkeni olarak vermelisiniz

```
GEMINI_API_KEY=...
```


## Kullanım

### Tarayıcıyı başlat

```bash
spegel                # Karşılama ekranı ile başlat
spegel bbc.com        # Bir URL ile hemen aç
```

Veya eşdeğer olarak:

```bash
python -m spegel      # Karşılama ekranı ile başlat
python -m spegel bbc.com
```

### Temel kontroller
- `/`         – URL girişi aç
- `Tab`/`Shift+Tab` – Bağlantılar arasında dolaş
- `Enter`     – Seçili bağlantıyı aç
- `e`         – Mevcut görünüm için LLM komutunu düzenle
- `b`         – Geri git
- `q`         – Çık

## Ayarları düzenleme

Spegel ayarları bir TOML yapılandırma dosyasından yükler. Görünümleri, komutları ve arayüz seçeneklerini özelleştirebilirsiniz.

**Yapılandırma dosyası arama sırası:**
1. `./.spegel.toml` (geçerli dizin)
2. `~/.spegel.toml`
3. `~/.config/spegel/config.toml`

Ayarları düzenlemek için:
1. Örnek yapılandırmayı kopyalayın:
   ```bash
   cp example_config.toml .spegel.toml
   # veya ~/.spegel.toml oluşturun
   ```
2. Sevdiğiniz editör ile `.spegel.toml` dosyasını düzenleyin.

Örnek parça:
```toml
[settings]
default_view = "terminal"
app_title = "Spegel"

[[views]]
id = "raw"
name = "Ham Görünüm"
prompt = ""

[[views]]
id = "terminal"
name = "Terminal"
prompt = "Bu web sayfasını mükemmel bir terminal tarama deneyimine dönüştür! ..."
```

---

Daha fazla bilgi için kodu inceleyin veya bir sorun açın!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---