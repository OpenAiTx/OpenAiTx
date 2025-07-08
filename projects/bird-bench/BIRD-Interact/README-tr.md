# BIRD-INTERACT 1.0 <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/hku-logo.jpg" alt="HKU Logo" width="50" style="vertical-align:middle;margin-left:10px;"> <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/google-cloud-logo.png" alt="Google Cloud Logo" width="50" style="vertical-align:middle;margin-left:10px;">

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/bird_interact.png" 
       style="width: 30%; min-width: 100px; display: block; margin: auto; border-radius: 15px !important;">
</p>


<div style="display: flex; justify-content: center; align-items: center; gap: 10px;">
  <a href="https://creativecommons.org/licenses/by-sa/4.0/deed.en">
    <img src="https://img.shields.io/badge/License-CC%20By%20SA%204.0-orange.svg" alt="License">
  </a>
  <a href="https://bird-interact.github.io/">
    <img src="https://img.shields.io/badge/Leaderboard-2025-28a745.svg" alt="Leaderboard">
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

## 🧸 Genel Bakış

BIRD-INTERACT, etkileşimli bir metinden-SQL'e kıyaslama seti olarak, **Metinden-SQL'e değerlendirmesini dinamik etkileşimler merceğinden yeniden tasarlar**.
Ortam, hiyerarşik bir bilgi tabanını, veritabanı dokümantasyonunu ve işlev odaklı bir kullanıcı simülatörünü birleştirerek, tam **CRUD** işlemlerinde gerçekçi kurumsal ortamları yeniden yaratır.
İki sıkı test modu sunar: (1) pasif **Sohbet Etkileşimi** ve (2) aktif **Ajans Etkileşimi**; bu modlar, her biri çalıştırılabilir test vakaları ile korunan, İş Zekâsı (BI), CRUD işlemleri ve benzeri dahil olmak üzere 600 anotasyonlu görevi kapsar.
Tipik değerlendirmeler, model ile kullanıcı simülatörü arasında 1.968-5.496 etkileşim turunu tetikler; güncel en gelişmiş akıl yürütme modelleri ise şu anda yalnızca görevlerin **≈%24**’ünü ve **≈%18**’ini çözebilmektedir; bu da kıyaslama setinin zorluğunu ortaya koymaktadır.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ İki Değerlendirme Modu

BIRD-INTERACT yukarıda bahsedilen iki değerlendirme modunu destekler:

   - **c-Interact**: Sohbet Etkileşimi, pasif bir moddur ve iş akışı sabittir. Kod ve detaylı bilgilere `bird_interact_conv` dizininden ulaşılabilir.
   - **a-Interact**: Ajans Etkileşimi, iş akışının dinamik olduğu ve modeller tarafından yönlendirildiği gömülü aktif bir moddur. Kod ve detaylı bilgilere `bird_interact_agent` dizininden ulaşılabilir.


### 🐣 Hafif Sürüm

BIRD-INTERACT’in hafif bir sürümü olan `bird-interact-lite-exp` yayınlanmıştır ve özellikle PostgreSQL için 270 yüksek kaliteli gerçek dünya görevi içerir. Hızlı denemeler için iyi bir başlangıç noktasıdır.

### 🦜 Tam Sürüm

BIRD-INTERACT’in tam sürümü olan `bird-interact-full`, PostgreSQL için 600 görevi içeren kapsamlı bir kıyaslama setidir. Geniş bir SQL işlemleri ve kullanıcı sorguları yelpazesini kapsar. Tam sürüm yakında yayınlanacaktır.

### BIRD-INTERACT Lite Üzerindeki Model Performans Sonuçları

#### 1. **c-Interact** Performansı
| Sıra | Model Adı          | Normalize Ödül | Seviye             |
|:------:|--------------------|:-------:|:--------------:|
| 1    | o3-mini            | 33.04 | 🏆 Mükemmel Sohbet |
| 2    | GPT-4o             | 30.33 | 💎 İyi Sohbet       |
| 3    | Gemini-2.0-flash   | 27.41 | 💎 İyi Sohbet       |
| 4    | Claude-3.7-sonnet  | 26.60 | ✨ Standart         |
| 5    | DeepSeek-R1        | 21.74 | ✨ Standart         |
| 6    | Qwen3              | 20.33 | ⚪ Temel            |
| 7    | DeepSeek-V3        | 15.85 | ⚪ Temel            |

#### 2. **a-Interact** Performansı
| Sıra | Model Adı          | Bütçe Parametreleri* | Ort. Tur/Görev | Ort. Maliyet (USD)/Görev | Normalize Ödül | Seviye                 |
|:------:|--------------------|:-------------------:|:----------------:|:---------------------:|:-------------------:|:---------------------:|
| 1    | Claude-3.7-sonnet  | 6/6 | 15.4 | $0.6668 | 29.19 | 🏆 Mükemmel Etkileşim     |
| 2    | o3-mini            | 6/6 | 7.8  | $0.0754 | 21.07 | 💎 İyi Etkileşim          |
| 3    | DeepSeek-V3        | 6/6 | 15.6 | $0.0629 | 19.19 | 💎 İyi Etkileşim          |
| 4    | Qwen3              | 6/6 | 12.5 | $0.0278 | 18.74 | ✨ Standart               |
| 5    | GPT-4o             | 6/6 | 15.3 | $0.4594 | 18.37 | ✨ Standart               |
| 6    | Gemini-2.0-flash   | 6/6 | 13.2 | $0.0337 | 17.26 | ⚪ Temel                  |
| 7    | DeepSeek-R1        | 6/6 | 12.0 | $0.0931 | 17.07 | ⚪ Temel                  |

> \* Bütçe Parametreleri: Başlangıç Bütçesi/Kullanıcı Sabır Bütçesi, sanal para birimimiz *bird-coin* <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;"> ile ölçülür. Daha fazla bilgi için [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting) dosyasına bakınız.

### Etkileşim-Zaman Ölçeklendirmesi (ITS)

Etkileşim-Zaman Ölçeklendirmesi (ITS), bir modelin çoklu tur etkileşimler aracılığıyla nihai performansını sürekli olarak artırabilme yeteneğini ifade eder. Bu etkileşimli performans, modelin tamamen belirtilmiş, belirsizliği olmayan bir görevdeki idealize edilmiş tek tur performansını aştığında, modelin **ITS yasasını** sağladığını söyleriz. Kullanıcı sabrı arttıkça ve etkileşim turları biriktikçe, performans gelişmeye devam eder; bu da modelin uzun diyaloglarda etkili iletişimi sürdürebildiğini gösterir. Şu anda yalnızca claude-3-7-sonnet modelinin ITS yasasını sağladığını bulduk.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## 📦 Veri Kümesi Detayları

### Veri Kümesi Açıklaması

- **Veritabanı:** Tam PostgreSQL veritabanını [Google Drive](https://drive.google.com/file/d/1KABce6czIqL9kMyIX7i-_A0CIQoDnmyW/view) üzerinden indirebilirsiniz. Daha fazla ayrıntı için [Hızlı Değerlendirme](#quick-eval) bölümüne bakınız.
- **data:** Her veri örneği aşağıdaki ana bölümleri içerir:
   - `selected_database`: Veritabanının adı.  
   - `query`: Belirsizliği olmayan kullanıcı sorgusu.  
   - `amb_user_query`: Belirsizlikler eklenmiş kullanıcı sorgusu.
   - `user_query_ambiguity`: Kullanıcı sorgusuna eklenen belirsizlikler.
   - `non_critical_ambiguity`: Sıra, limit vb. kritik olmayan belirsizlikler.
   - `knowledge_ambiguity`: Maskelenmiş harici bilgiler tarafından oluşturulan belirsizlikler.
   - `sol_sql`: Gerçek (ground truth) SQL çözümü.
   - `preprocess_sql`: Çözüm veya tahmin çalıştırılmadan önce çalıştırılacak SQL sorguları.
   - `clean_up_sql`: Test vakalarından sonra veritabanında yapılan değişiklikleri geri almak için çalıştırılacak SQL sorguları.
   - `test_cases`: Tahmin edilen düzeltilmiş SQL’i doğrulamak için bir dizi test vakası.
   - `follow_up`: Etiketlenmiş takip soruları.
   - `external_knowledge`: Belirli görevle ilgili harici bilgi.

- **değerlendirme:** Değerlendirme kodu [`./evaluation`](./evaluation) dizininde mevcuttur.
- **Hazırlayan:** BIRD Takımı & Google Cloud
- **Lisans:** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **HuggingFace Dataset Kartı:** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)

### Veri Kümesi Kullanımları

Otomatik taramayla veri sızıntısını önlemek için, GT çözüm SQL'leri ve test vakaları verilerle birlikte dahil edilmemiştir.
Tam set için başlıkta `[bird-interact-lite GT&Test Cases]` etiketiyle [bird.bench25@gmail.com](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/mailto:bird.bench25@gmail.com) adresine e-posta gönderebilirsiniz; set otomatik olarak gönderilecektir.


<!-- ### HuggingFace'ten Veri Kümesini Kullanma

Veri kümesini HuggingFace üzerinden aşağıdaki komutla indirebilirsiniz:
```bash
from datasets import load_dataset
# Veri kümesinin flash versiyonunu yükleyin
dataset = load_dataset("birdsql/bird-interact-lite")
print(dataset["lite"][0])

# Veri kümesinin tam versiyonunu yükleyin (yakında)
dataset = load_dataset("birdsql/bird-interact-full")
print(dataset["full"][0])
```

Ya da sağlanan script ile veri kümesinin tam versiyonunu indirip farklı diyalektlere bölebilirsiniz.
```bash
cd baseline/data
python pull_data.py \
  --schema_path path/to/full_schema.jsonl \
  --input_path path/to/input.jsonl \ # Girdi JSONL dosyasının yolu (veri kümesini HuggingFace’ten indirmek istiyorsanız boş olabilir)
  --output_folder path/to/output_dir # bölen dosyaların çıktısının alınacağı klasör
``` -->

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
**a-interact** çalıştırma detaylarını `./bird_interact_agent/README.md` dosyasında; **c-interact** ile ilgili detayları ise `./bird_interact_conv/README.md` dosyasında bulabilirsiniz.


## 📋 Yapılacaklar Listesi

- [x] Lite sürüm yayınlandı, bird-interact-lite (270).
- [x] Diyalog versiyonu yayınlandı, bird-interact-conv.
- [x] Agent versiyonu yayınlandı, bird-interact-agent.
- [ ] Tam sürüm yayınlanacak, bird-interact-full (600).
- [ ] SFT / RL ve Kullanıcı Simülatörü

## Oluşturanlar:
BIRD Takımı & Google Cloud

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---