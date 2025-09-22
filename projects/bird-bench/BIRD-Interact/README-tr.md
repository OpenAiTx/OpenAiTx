
<div align="right">
  <details>
    <summary >🌐 Dil</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=it">İtalyanca</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>

</div>

# BIRD-INTERACT 1.0 <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/hku-logo.jpg" alt="HKU Logo" width="50" style="vertical-align:middle;margin-left:10px;"> <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/google-cloud-logo.png" alt="Google Cloud Logo" width="50" style="vertical-align:middle;margin-left:10px;">

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/bird_interact.png" 
       style="width: 30%; min-width: 100px; display: block; margin: auto; border-radius: 15px !important;">
</p>


<div style="display: flex; justify-content: center; align-items: center; gap: 10px;">
  <a href="https://creativecommons.org/licenses/by-sa/4.0/deed.en">
    <img src="https://img.shields.io/badge/License-CC%20By%20SA%204.0-orange.svg" alt="Lisans">
  </a>
  <a href="https://bird-interact.github.io/">
    <img src="https://img.shields.io/badge/Leaderboard-2025-28a745.svg" alt="Lider Tablosu">
  </a>
  <a href="https://huggingface.co/datasets/birdsql/bird-interact-lite/tree/main">
    <img src="https://img.shields.io/badge/Dataset-HuggingFace-FFD21E.svg" alt="HuggingFace">
  </a>
  <a href="https://www.python.org/downloads/release/python-310/">
    <img src="https://img.shields.io/badge/Python-3.10+-teal.svg" alt="Python">
  </a>
  <a href="https://pypi.org/project/openai/">
    <img src="https://img.shields.io/badge/OpenAI-1.40+-beige.svg" alt="OpenAI">
  </a>
</div>

## ⚠️ Duyuru  
Lütfen değerlendirme sürecinizden önce, Docker veritabanlarını yüklerken ortam tutarsızlığı nedeniyle bazen hatalar oluşabileceğini unutmayın (bu hatalar süreci sonlandırmaz ancak Docker günlüklerinde görünebilir). Sonuç olarak bazı veritabanları düzgün yüklenemeyebilir ve boş veritabanları oluşabilir. Bu, değerlendirme sonuçlarının anormal derecede düşük olmasına neden olur.  
👉 Bu nedenle, **değerlendirmeyi çalıştırmadan önce** Docker günlüklerinde herhangi bir hata olup olmadığını kontrol etmenizi ve tüm veritabanlarının başarıyla yüklendiğini doğrulamanızı önemle tavsiye ederiz.

## 📰 Haberler

- [2025-08-26] 🚀 **[BIRD-Interact-Full (600)](https://huggingface.co/datasets/birdsql/bird-interact-full)** setinin yayınlandığını duyurmaktan heyecan duyuyoruz!  
Zor bir set — en iyi LLM'ler yalnızca **%16,33** başarı oranına ulaşabiliyor, `c-interact` ve `a-interact` bölümlerinde ise sadece **%10,0**.  
👉 Daha fazla bilgi için [proje web sitemizi](https://bird-interact.github.io/) ziyaret edebilirsiniz.

- [2025-08-26] 📬 Bu hafta **Gerçek Sonuçlar & Test vakalarını** e-posta listemize göndereceğiz.  
Erken erişim isterseniz, sitedeki talimatlara göre e-posta göndererek **otomatik indirme** talebinde bulunun.  

- [2025-08-26] 💾 Ayrıca, yerel araştırmalarda kolaylık sağlamak için **[LiveSQLBench-Lite](https://huggingface.co/datasets/birdsql/livesqlbench-base-lite-sqlite)** SQLite versiyonunu da yayınladık.  
Tam **LiveSQLBench-Base** ve **-Large** sürümleri yakında geliyor!

- [2025-08-22] **Hata Düzeltme**: Bird-Interact-Agent kodunda, faz-2 SQL değerlendirilirken, saklanan faz-1 SQL’in başarıyla çalıştırılamamasına ve Faz-2’nin başarı oranının düşmesine sebep olan bir hata düzeltildi. Bu hata sadece faz1 sql’in veritabanında CREATE table gibi işlemler yaptığı görevleri etkiler.

## 🧸 Genel Bakış

BIRD-INTERACT, etkileşimli bir text-to-SQL kıyaslama seti olarak, **Text-to-SQL değerlendirmesini dinamik etkileşimler perspektifinden yeniden tasarlar**.
Ortam; hiyerarşik bir bilgi tabanı, veritabanı belgeleri ve işlev odaklı bir kullanıcı simülatörü ile gerçekçi kurumsal ortamları tam **CRUD** işlemleriyle yeniden yaratır.
İki titiz test modu sunar: (1) pasif **Sohbet Etkileşimi** ve (2) aktif **Ajanssal Etkileşim**, her biri çalıştırılabilir test vakaları ile korunan, İş Zekası (BI), CRUD işlemleri ve benzeri dahil olmak üzere 600 açıklamalı görevi kapsar.
Tipik değerlendirmeler, model ve kullanıcı simülatörü arasında 1.968-5.496 etkileşim turunu tetiklerken, en gelişmiş akıl yürütme modelleri şu anda yalnızca görevlerin **≈%24** ve **≈%18**'ini çözebilmekte, bu da kıyaslamanın zorluğunu ortaya koymaktadır.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ İki Değerlendirme Modu

BIRD-INTERACT yukarıda belirtildiği gibi iki değerlendirme modunu destekler:

   - **c-Interact**: Sohbet Etkileşimi; pasif bir mod olup iş akışı sabittir. Kod ve detaylı bilgiye `bird_interact_conv` üzerinden ulaşılabilir.
   - **a-Interact**: Ajanssal Etkileşim; iş akışının dinamik olduğu ve modeller tarafından yönlendirildiği aktif, bedenlenmiş bir moddur. Kod ve detaylı bilgiye `bird_interact_agent` üzerinden ulaşılabilir.


### 🐣 Hafif Sürüm

BIRD-INTERACT'ın hafif bir sürümünü, `bird-interact-lite-exp` olarak yayımlıyoruz; özellikle PostgreSQL için 270 yüksek kaliteli gerçek dünya görevi içerir. Hızlı denemeler için iyi bir başlangıç noktasıdır.

### 🦜 Tam Sürüm

BIRD-INTERACT'ın tam sürümü, `bird-interact-full`, PostgreSQL için 600 görevi kapsayan kapsamlı bir kıyaslama setidir. Geniş bir SQL işlemi ve kullanıcı sorgusu yelpazesini kapsar. Tam sürüm yakında geliyor.

### BIRD-INTERACT Lite Üzerindeki Model Performans Sonuçları

#### 1. **c-Interact** Performansı
| Sıra | Model Adı           | Normalize Ödül | Seviye              |
|:------:|--------------------|:-------:|:--------------:|
| 1    | o3-mini            | 33.04 | 🏆 Mükemmel Sohbet |
| 2    | GPT-4o             | 30.33 | 💎 İyi Sohbet       |
| 3    | Gemini-2.0-flash   | 27.41 | 💎 İyi Sohbet       |
| 4    | Claude-3.7-sonnet  | 26.60 | ✨ Standart         |
| 5    | DeepSeek-R1        | 21.74 | ✨ Standart         |
| 6    | Qwen3              | 20.33 | ⚪ Temel            |
| 7    | DeepSeek-V3        | 15.85 | ⚪ Temel            |

#### 2. **a-Interact** Performansı
| Sıra | Model Adı           | Bütçe Parametreleri* | Ortalama Adım/Görev | Ortalama Maliyet (USD)/Görev | Normalize Ödül | Seviye                |
|:------:|--------------------|:-------------------:|:----------------:|:---------------------:|:-------------------:|:---------------------:|
| 1    | Claude-3.7-sonnet  | 6/6 | 15.4 | $0.6668 | 29.19 | 🏆 Mükemmel Etkileşim   |
| 2    | o3-mini            | 6/6 | 7.8 | $0.0754 | 21.07 | 💎 İyi Etkileşim        |
| 3    | DeepSeek-V3        | 6/6 | 15.6 | $0.0629 | 19.19 | 💎 İyi Etkileşim        |
| 4    | Qwen3              | 6/6 | 12.5 | $0.0278 | 18.74 | ✨ Standart             |
| 5    | GPT-4o             | 6/6 | 15.3 | $0.4594 | 18.37 | ✨ Standart             |
| 6    | Gemini-2.0-flash   | 6/6 | 13.2 | $0.0337 | 17.26 | ⚪ Temel                |
| 7    | DeepSeek-R1        | 6/6 | 12.0 | $0.0931 | 17.07 | ⚪ Temel                |

> \* Bütçe Parametreleri: Başlangıç Bütçesi/Kullanıcı Sabır Bütçesi, sanal para birimimiz *bird-coin* cinsinden ölçülür <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;">. Daha fazla detay için [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting) adresine bakınız.

### Etkileşim-Zamanı Ölçekleme (ITS)

Etkileşim-Zamanı Ölçekleme (ITS), bir modelin çoklu dönüşlü etkileşimler yoluyla nihai performansını sürekli olarak artırabilme yeteneğini ifade eder. Bu etkileşimli performans, modelin tam olarak belirlenmiş, belirsizliği olmayan bir görevdeki ideal tek dönüş performansını aştığında, modelin **ITS yasasını** sağladığı söylenir. Kullanıcı sabrı arttıkça ve etkileşim dönüşleri biriktikçe, performans gelişmeye devam eder; bu da modelin uzun diyaloglarda etkili iletişimi sürdürebildiğini gösterir. Şu anda sadece claude-3-7-sonnet'ın ITS yasasını sağladığını tespit ettik.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## 📦 Veri Kümesi Detayları

### Veri Kümesi Açıklaması

- **Veritabanı:** Tam PostgreSQL veritabanı [Google Drive'dan](https://drive.google.com/file/d/1KABce6czIqL9kMyIX7i-_A0CIQoDnmyW/view) indirilebilir. Daha fazla bilgi için [Hızlı Değerlendirme](#quick-eval) bölümüne bakınız.
- **data:** Her veri örneği aşağıdaki ana bölümleri içerir:
   - `selected_database`: Veritabanının adı.  
   - `query`: Belirsizliği olmayan kullanıcı sorgusu.  
   - `amb_user_query`: Enjekte edilmiş belirsizliklere sahip kullanıcı sorgusu.
   - `user_query_ambiguity`: Kullanıcı sorgusuna enjekte edilen belirsizlikler.
   - `non_critical_ambiguity`: Sıralama, limit gibi kritik olmayan belirsizlikler.
   - `knowledge_ambiguity`: Maskelenmiş harici bilgilerle oluşturulan belirsizlikler.
   - `sol_sql`: Doğru SQL çözümü.  
   - `preprocess_sql`: Çözüm ya da tahmin çalıştırılmadan önce çalıştırılacak SQL sorguları.  
   - `clean_up_sql`: Testlerden sonra veritabanındaki değişiklikleri geri almak için çalıştırılacak SQL sorguları.  
   - `test_cases`: Tahmin edilen düzeltilmiş SQL'i doğrulamak için bir dizi test durumu.
   - `follow_up`: Etiketli takip soruları.
   - `external_knowledge`: Belirli görevle ilgili harici bilgi.

- **evaluation:** Değerlendirme kodu [`./evaluation`](./evaluation) dizininde mevcuttur.
- **Düzenleyen:** BIRD Ekibi & Google Cloud
- **Lisans:** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **HuggingFace Veri Kümesi Kartı:** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)

### Veri Kümesi Kullanımları

Otomatik tarama ile veri sızıntısını önlemek için, GT çözüm sql'leri ve test vakaları verilerle birlikte dahil edilmemiştir.
tam set için başlıkta `[bird-interact-lite GT&Test Cases]` etiketi ile [bird.bench25@gmail.com](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/mailto:bird.bench25@gmail.com) adresine e-posta gönderebilirsiniz; set otomatik olarak gönderilecektir.


<!-- ### HuggingFace üzerinden Veri Kümesini Kullanma

Veri kümesini aşağıdaki komut ile HuggingFace'den indirebilirsiniz:
```bash
from datasets import load_dataset
# Load the flash version of the dataset
dataset = load_dataset("birdsql/bird-interact-lite")
print(dataset["lite"][0])

# Load the full version of the dataset (coming soon)
dataset = load_dataset("birdsql/bird-interact-full")
print(dataset["full"][0])
```

Ya da sağlanan betiği kullanarak veri setinin tam sürümünü indirebilir ve farklı ağızlara bölebilirsiniz.
```bash
cd baseline/data
python pull_data.py \
  --schema_path path/to/full_schema.jsonl \
  --input_path path/to/input.jsonl \ # Girdi JSONL dosyasının yolu (eğer veri setini HuggingFace'den indirmek istiyorsanız boş olabilir)
  --output_folder path/to/output_dir # bölünmüş dosyaların çıktı klasörü
```

## Klasör Yapısı
```ultree
.
├── LICENSE
├── README.md
├── bird_interact_conv
│   ├── ...
│   └── README.md
├── bird_interact_agent
│   ├── ...
│   └── README.md
├── evaluation
│   ├── docker-compose.yml
│   ├── env
│   ├── postgre_table_dumps
│   ├── run
│   └── src
├── materials
│   ├── ...
└── requirements.txt
```
**a-interact**'ın çalıştırılmasıyla ilgili detaylar `./bird_interact_agent/README.md` dosyasında bulunabilir; **c-interact** ile ilgili detaylar ise `./bird_interact_conv/README.md` dosyasında mevcuttur.

## 📋 Yapılacaklar Listesi

- [x] Lite sürümünü yayınla, bird-interact-lite (270).
- [x] Konuşmalı sürümü yayınla, bird-interact-conv.
- [x] Agent sürümünü yayınla, bird-interact-agent.
- [x] Tam sürümünü yayınla, bird-interact-full (600).
- [ ] SFT / RL ve Kullanıcı Simülatörü

## Oluşturanlar:
BIRD Takımı & Google Cloud







---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-22

---