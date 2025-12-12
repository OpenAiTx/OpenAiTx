
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
Lütfen değerlendirme sürecinizden önce, Docker veritabanlarını yüklerken ortam tutarsızlığı nedeniyle zaman zaman hatalar oluşabileceğini unutmayın (bu hatalar işlemi durdurmaz, ancak Docker günlüklerinde görünecektir). Sonuç olarak, bazı veritabanları düzgün yüklenemeyebilir ve boş veritabanları oluşabilir. Bu da değerlendirme sonuçlarının anormal derecede düşük olmasına sebep olur.  
👉 Bu nedenle, **değerlendirme çalıştırılmadan önce** Docker günlüklerinde herhangi bir hata olup olmadığını kontrol etmenizi ve tüm veritabanlarının başarıyla yüklendiğini doğrulamanızı şiddetle tavsiye ederiz.

👉 Özelleştirilmiş ajan iskeletlerinin desteklendiği **Başvuru Yönergeleri** güncellendi. Detaylı başvuru yönergelerimize [buradan](https://docs.google.com/document/d/1F1DSqHDBzGvXFlWU8iCl9otkqxIefgcH/edit?usp=sharing&ouid=108161566779099489782&rtpof=true&sd=true) göz atabilirsiniz.

## 📰 Haberler

- [2025-11-06] 🐛 **Hata Düzeltmesi** & 🐳 **Docker güncellemesi**: Kullanıcı simülatörü için SQL ayrıştırıcısının SQL'i doğru ayrıştıramaması hatasını düzeltmek için sqlglot sürümü 26.16.4'e yükseltildi. Bunu `bird_interact_eval` ortamında `pip install sqlglot==26.16.4` komutunu çalıştırarak düzeltebilirsiniz. `bird_interact_eval` imajı da güncellendi, bu yüzden çekip ilgili konteyneri yeniden oluşturabilirsiniz.

- [2025-10-21] 🐳 **Docker güncellemesi**: Tam Veritabanı Ortamı için Docker ekledik. Ayrıca, ortam kurulumunu kolaylaştırmak için 3 docker imajı (Temel/Tam Veritabanı Ortamı ve hem `a-Interact` hem de `c-Interact` için değerlendirme ortamı) Docker Hub'a aktarıldı. Artık DB dökümlerini indirip imajları manuel olarak oluşturmanıza gerek yok!

- [2025-10-08] 📝 **[Bird-Interact makalemiz](https://huggingface.co/papers/2510.05318)** artık herkese açık!  
  Etkileşimli metinden-SQL'e kıyaslama çalışmamızın tüm detaylarını, metodolojisini ve değerlendirmesini sunuyor.  
  👉 [BIRD-Interact](https://bird-interact.github.io/) fikrinin arkasındaki detayları öğrenmek için inceleyebilirsiniz.

- [2025-08-26] 🚀 **[BIRD-Interact-Full (600)](https://huggingface.co/datasets/birdsql/bird-interact-full)** setini yayınladığımızı duyurmaktan heyecan duyuyoruz!  
Bu zorlu bir set — en iyi LLM'ler yalnızca **%16,33** başarı oranına ulaşabiliyor; `c-interact` ve `a-interact` bölümlerinde ise sadece **%10,0**.  
👉 Daha fazla bilgi için [proje web sitemizi](https://bird-interact.github.io/) ziyaret edebilirsiniz.

- [2025-08-26] 📬 **Gerçek Sonuçlar & Test vakaları** bu hafta e-posta listemize gönderilecek.  
Erken erişim isterseniz, sitede belirtilen şekilde e-posta göndererek **otomatik indirme** talep edebilirsiniz.  

- [2025-08-26] 💾 Ayrıca, daha kolay yerel araştırma için **[LiveSQLBench-Lite](https://huggingface.co/datasets/birdsql/livesqlbench-base-lite-sqlite)**'ın bir SQLite sürümünü de yayınladık.  
Tam **LiveSQLBench-Base** ve **-Large** sürümleri yakında geliyor!

- [2025-08-22] **Hata Düzeltmesi**: Bird-Interact-Agent kodunda, faz-2 SQL değerlendirilirken depolanan faz-1 SQL'in başarıyla çalıştırılamamasına ve bu nedenle Faz-2'nin başarı oranının düşmesine neden olan bir hata düzeltildi. Bu hata yalnızca faz1 sql’in veritabanında bazı işlemler yaptığı görevleri etkiler, örn. CREATE table, vb.

## 🧸 Genel Bakış

BIRD-INTERACT, etkileşimli bir text-to-SQL benchmark’ı olarak, **Text-to-SQL değerlendirmesini dinamik etkileşimler bakış açısıyla yeniden kurgular**.
Ortam, hiyerarşik bilgi tabanı, veritabanı dokümantasyonu ve fonksiyon odaklı kullanıcı simülatörünü harmanlayarak, tam **CRUD** işlemlerini kapsayan gerçekçi kurumsal ortamlar sunar.
İki zorlu test modu sunar: (1) pasif **Konuşma Etkileşimi** ve (2) aktif **Ajanik Etkileşim**, her biri çalıştırılabilir test vakaları ile korunan, İş Zekası (BI), CRUD işlemleri ve benzeri 600 açıklamalı görevi kapsar.
Tipik değerlendirmeler, model ile kullanıcı simülatörü arasında 1.968-5.496 etkileşim turu tetiklerken, son teknoloji akıl yürütme modelleri şu anda yalnızca **≈%24** ve **≈%18** oranında görev çözebiliyor; bu da benchmark’ın zorluğunu gösteriyor.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ İki Değerlendirme Modu

BIRD-INTERACT, yukarıda belirtilen iki değerlendirme modunu destekler:

   - **c-Interact**: Konuşma Etkileşimi; pasif bir moddur ve iş akışı sabittir. Kod ve ayrıntılı bilgi `bird_interact_conv` içinde bulunabilir.
   - **a-Interact**: Ajanik Etkileşim; iş akışının dinamik olduğu ve model tarafından yönlendirilen aktif bir moddur. Kod ve ayrıntılı bilgi `bird_interact_agent` içinde bulunabilir.


### 🐣 Lite Sürüm

BIRD-INTERACT'ın lite sürümü olan `bird-interact-lite-exp`i yayımlıyoruz; bu sürüm özellikle PostgreSQL için 270 yüksek kaliteli gerçek dünya görevi içerir. Hızlı denemeler için iyi bir başlangıç noktasıdır.

### 🦜 Tam Sürüm

BIRD-INTERACT'ın tam sürümü olan `bird-interact-full`, PostgreSQL için 600 görevi içeren kapsamlı bir benchmarktır. Geniş bir SQL işlemleri ve kullanıcı sorguları yelpazesini kapsar. Tam sürüm yakında çıkacak.

### BIRD-INTERACT-FULL Üzerinde Model Performans Sonuçları

#### 1. **c-Interact Text-to-SQL** Performansı
| Sıra | Model Adı          | Normalize Ödül     | Ort. Maliyet (USD)/Görev | Seviye              |
|:----:|:-------------------|:------------------:|:------------------------:|:-------------------:|
| 1    | Gemini-2.5-Pro     | 20.92              | $0.04                    | 🏆 Mükemmel Sohbet  |
| 2    | O3-Mini            | 20.27             | $0.07               | 🏆 Mükemmel Sohbet  |
| 3    | Claude-Sonnet-4    | 18.35             | $0.29               | 💎 İyi Sohbet       |
| 4    | Qwen-3-Coder-480B  | 17.75             | $0.11               | 💎 İyi Sohbet       |
| 5    | Deepseek-Chat-V3.1 | 15.15             | $0.12               | ✨ Standart         |
| 6    | Claude-Sonnet-3.7  | 13.87             | $0.29               | ✨ Standart         |
| 7    | GPT-5              | 12.58             | $0.08               | ⚪ Temel            |

#### 2. **a-Interact Metinden-SQL'e** Performansı
| Sıra | Model Adı           | Normalize Ödül    | Ort. Maliyet (USD)/Görev | Seviye                  |
|:----:|:-------------------:|:-----------------:|:-----------------------:|:-----------------------:|
| 1    | GPT-5               | 25.52             | $0.24                   | 🏆 Mükemmel Etkileşim   |
| 2    | Claude-Sonnet-4     | 23.28             | $0.51                   | 🏆 Mükemmel Etkileşim   |
| 3    | Claude-Sonnet-3.7   | 17.45             | $0.60                   | 💎 İyi Etkileşim        |
| 4    | Gemini-2.5-Pro      | 17.33             | $0.22                   | 💎 İyi Etkileşim        |
| 5    | O3-Mini             | 16.43             | $0.06                   | ✨ Standart             |
| 6    | Deepseek-Chat-V3.1  | 13.47             | $0.06                   | ✨ Standart             |
| 7    | Qwen-3-Coder-480B   | 10.58             | $0.07                   | ⚪ Temel                |

> \* Bütçe Parametreleri: Başlangıç Bütçesi/Kullanıcı Sabır Bütçesi, sanal para birimimiz *bird-coin* ile ölçülmüştür <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;">. Daha fazla bilgi için [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting) dosyasına bakabilirsiniz.

### Etkileşim-Zamanı Ölçeklendirme (ITS)

Etkileşim-Zamanı Ölçeklendirme (ITS), bir modelin çoklu dönüşlü etkileşimlerle nihai performansını sürekli olarak artırma yeteneğini ifade eder. Bu etkileşimli performans, modelin tam olarak belirtilmiş, belirsizliği olmayan tek dönüşlü ideal performansını aştığında, modelin **ITS yasasını** sağladığını söyleriz. Kullanıcı sabrı arttıkça ve etkileşim sayısı biriktikçe, performans sürekli iyileşir ve modelin uzun diyaloglarda etkili iletişimi sürdürebildiğini gösterir. Şu anda sadece claude-3-7-sonnet ITS yasasını sağlamaktadır.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## Ortam Kurulumu

1. bird-interact-lite veritabanı, bird-interact-full veritabanı ve değerlendirme ortamı için Docker konteynerlarını çalıştırın:
  
  > Sadece `bird-interact-lite` üzerinde değerlendirme yapmak istiyorsanız, ortam kurulumunu hızlandırmak için [`postgresql_full` servisini](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/./env/docker-compose.yml#L21-L31) `docker-compose.yml` dosyasında yorum satırı yapabilirsiniz.
  
  Ortamı başlatmak için şunu çalıştırın:
   ```bash
   cd env
   docker compose pull 
   docker compose up -d
   ```
   Veritabanı başlatılması için birkaç dakika bekleyin.
   
  Oluşturma ilerlemesini aşağıdaki şekilde takip edebilirsiniz:
  ```bash
  docker compose logs -f --tail=100 bird_interact_postgresql_full # or bird_interact_postgresql for bird-interact-lite
  ```
  Eğer tamamlandıysa, hatasız olarak günlükleri görmelisiniz:

  ```bash
  bird_interact_postgresql_full  | 2025-10-28 17:58:30.413 HKT [1] LOG:  database system is ready to accept connection
  ```

  Eğer daha önce konteynerler oluşturduysanız ve yeniden oluşturmak istiyorsanız, aşağıdaki komutu çalıştırabilirsiniz:
  ```bash
  docker compose down -v # this cmd removes the containers and the volumes
  docker compose pull   # pull the latest images from Docker Hub
  docker compose up -d --force-recreate # build and start the containers again. --force-recreate means force the recreation of the containers. 
  # Or `docker compose up -d --force-recreate bird_interact_eval` to only recreate the bird_interact_eval container about evalution code environment.
  ```
   
   Bu, Docker Hub'dan önceden oluşturulmuş imajları kullanarak 3 konteyner çalıştırır:
   - `bird_interact_postgresql`: bird-interact-lite için PostgreSQL veritabanı
   - `bird_interact_postgresql_full`: bird-interact-full için PostgreSQL veritabanı
   - `bird_interact_eval`: Hem `a-Interact` hem de `c-Interact` için değerlendirme ortamı.

   Şimdi, değerlendirme ortamını aşağıdaki komutu çalıştırarak başlatabilirsiniz:
   ```bash
   docker compose exec bird_interact_eval bash
   ```

2. (İsteğe bağlı) Ortamı manuel olarak oluşturun (görüntüleri sıfırdan oluşturmak isterseniz): 
   - Veritabanı dökümlerini indirin 
      - [bird-interact-lite](https://drive.google.com/file/d/1QIGQlRKbkqApAOrQXPqFJgUg8rQ7HRRZ/view). Sıkıştırmayı açın ve `env/postgre_table_dumps` olarak yeniden adlandırın.
      - [bird-interact-full](https://drive.google.com/file/d/1V9SFIWebi27JtaDUAScG1xE9ELbYcWLR/view). Sıkıştırmayı açın ve `env/postgre_table_dumps_full` olarak yeniden adlandırın.
   - `docker-compose.build.yml` dosyasını çalıştırarak ortamı manuel olarak oluşturun.
      ```bash
      cd env/
      docker compose -f docker-compose.build.yml build
      docker compose -f docker-compose.build.yml up -d
      ```

3. (Önerilen) Veritabanı konteynerlerinin başarılı bir şekilde oluşturulup çalıştığını kontrol edin.

-  Veritabanlarının hatasız bir şekilde başarıyla oluşturulduğundan emin olmak için konteyner oluşturma günlüklerini yazdırın:
   ```bash 
   docker logs bird_interact_postgresql > build_bird_interact_postgresql.log 2>&1
   docker logs bird_interact_postgresql_full > build_bird_interact_postgresql_full.log 2>&1
   ```
   Hatalar oluşursa, `"İçe aktarma sırasında hatalar oluştu:"` günlük dosyalarında yazdırılacaktır.


-  Veritabanı konteynerlerinin düzgün durumda olup olmadığını kontrol edin.
   
   Veritabanı metadatasını doğrulamak için sağladığımız Python betiğini kullanın:
   ```bash
   docker compose exec bird_interact_eval bash
   cd /app/env
   python check_db_metadata.py --host bird_interact_postgresql
   python check_db_metadata.py --host bird_interact_postgresql_full
   ```
   
   Beklenen sonuçlar:
   - **bird-interact-lite**: 
     - 📈 Toplam Veritabanı: 18
     - 📋 Toplam Tablo: 175
     - 🔢 Toplam Sütun: 2286
     - 📈 Tablo Başına Ortalama Satır: 1.038,48
     - 💾 Toplam Boyut: 207,15 MB (yaklaşık)
   - **bird-interact-full**: 
     - 📈 Toplam Veritabanı: 22
     - 📋 Toplam Tablo: 244
     - 🔢 Toplam Sütun: 2011
     - 📈 Tablo Başına Ortalama Satır: 1.121,19
     - 💾 Toplam Boyut: 272,00 MB (yaklaşık)


## 📦 Veri Kümesi Detayları

### Veri Kümesi Açıklaması

- **Veritabanı:** Tam PostgreSQL veritabanı [bird-interact-lite](https://drive.google.com/file/d/1QIGQlRKbkqApAOrQXPqFJgUg8rQ7HRRZ/view) ve [bird-interact-full](https://drive.google.com/file/d/1V9SFIWebi27JtaDUAScG1xE9ELbYcWLR/view) adreslerinden indirilebilir.
- **data:** Her veri örneği aşağıdaki ana bölümleri içerir:
   - `selected_database`: Veritabanının adı.  
   - `query`: Açık ve kesin kullanıcı sorgusu.  
   - `amb_user_query`: Belirsizlikler eklenmiş kullanıcı sorgusu.
   - `user_query_ambiguity`: Kullanıcı sorgusuna enjekte edilen belirsizlikler.
   - `non_critical_ambiguity`: Sıralama, limit vb. kritik olmayan belirsizlikler.
   - `knowledge_ambiguity`: Maskelenmiş dış bilgilerle oluşturulan belirsizlikler. 
   - `sol_sql`: Gerçek SQL çözümü.  
   - `preprocess_sql`: Çözüm veya tahmin çalıştırılmadan önce çalıştırılacak SQL sorguları.  
   - `clean_up_sql`: Test vakalarından sonra veritabanında yapılan değişiklikleri geri almak için çalıştırılacak SQL sorguları.  
   - `test_cases`: Tahmin edilen düzeltilmiş SQL'i doğrulamak için bir test vakası seti.
   - `follow_up`: Etiketlenmiş takip soruları.
   - `external_knowledge`: Belirli görevle ilgili dış bilgi.

- **evaluation:** Değerlendirme kodu [`./evaluation`](./evaluation) dizininde mevcuttur.
- **Hazırlayan:** BIRD Ekibi & Google Cloud
- **Lisans:** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **HuggingFace Veri Kümesi Kartı:** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)
  ve [bird-interact-full](https://huggingface.co/datasets/birdsql/bird-interact-full)
### Veri Kümesi Kullanımları

Otomatik taramayla veri sızıntısını önlemek için GT çözüm sql'leri ve test vakalarını veriyle birlikte dahil etmiyoruz.
Lütfen bird-interact-lite veya bird-interact-full veri kümesi için gerçek veri ve test vakalarını almak üzere başlıkta `[bird-interact-lite GT&Test Cases]` veya `[bird-interact-full GT&Test Cases]` etiketiyle [bird.bench25@gmail.com](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/mailto:bird.bench25@gmail.com) adresine e-posta gönderin, bilgiler otomatik olarak iletilecektir.


### Genel verileri gerçek veri ve test vakaları ile birleştirme

Ardından genel verileri gerçek veri ve test vakaları ile birleştirmek için aşağıdaki betiği kullanın:

Tam sürümü örnek olarak alırsak:
(1) Çalıştırın:
```bash
python combine_public_with_gt.py /path/to/bird-interact-full/bird_interact_data.jsonl /path/to/bird_interact_full_gt_kg_testcases_08022.jsonl /path/to/bird_interact_data.jsonl  # bird_interact_full_gt_kg_testcases_08022.jsonl is the data of ground-truth fields, which is obtained by emailing us.
```
Bu, birleşik veriyle birlikte `/path/to/bird_interact_data.jsonl` konumunda yeni bir dosya oluşturacaktır.

(2) Ardından, orijinal halka açık veriyi birleşik veriyle değiştirin:

```bash
cp /path/to/bird_interact_data.jsonl /path/to/bird-interact-full/bird_interact_data.jsonl
```

Diğer sürümler için de aynı: bird-interact-lite, mini versiyonu, vb. Sadece ortak veri, gerçek veri ve test vakaları için doğru yolları ayarlayın ve ardından ortak veriyi birleştirilmiş veri ile değiştirin.




<!-- ### HuggingFace'den Veri Setini Kullanma

Veri setini aşağıdaki komutla HuggingFace'den indirebilirsiniz:
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
**a-interact**'ı çalıştırma ile ilgili detaylar `./bird_interact_agent/README.md` dosyasında; **c-interact** ile ilgili detaylar ise `./bird_interact_conv/README.md` dosyasında bulunabilir.

## 📋 Yapılacaklar Listesi

- [x] Lite sürümü yayınla, bird-interact-lite (270).
- [x] Konuşma tabanlı sürümü yayınla, bird-interact-conv.
- [x] Aracı sürümünü yayınla, bird-interact-agent.
- [x] Tam sürüm bird-interact-full (600) yayınla.
- [ ] SFT / RL ve Kullanıcı Simülatörü

## Teşekkür
Bu projeyi geliştirmemize yardımcı olan verimli tartışmaları ve değerli katkıları için **Irina Saparina**, **Mohammadreza Pourreza**, **Mehdi Bouzouina**, **Hailong Li**, **Jiatong Shi** ve Profesör **Shinji Watanabe**'ye içten teşekkürlerimizi sunarız.

## Oluşturan:
BIRD Ekibi & Google Cloud








## Değişiklik Günlüğü

- [2025-11-06] 🐛 **Hata Düzeltmesi** & 🐳 **Docker güncellemesi**: sqlglot sürümü 26.16.4'e güncellendi, böylece kullanıcı simülatörü için SQL ayrıştırıcısının SQL'i doğru şekilde ayrıştıramama hatası giderildi. Bunu, `bird_interact_eval` ortamında `pip install sqlglot==26.16.4` komutuyla yeniden kurarak düzeltebilirsiniz. Ayrıca `bird_interact_eval` imajı da güncellendi, bu yüzden bunu da çekip `bird_interact_eval` konteynerini yeniden oluşturabilirsiniz.
- [2025-10-21] 🐳 **Docker güncellemesi**: Full DB Env için docker eklendi. Ayrıca ortam kurulumunu kolaylaştırmak için Docker Hub'a 3 docker imajı (Base/Full DB Env ve hem `a-Interact` hem de `c-Interact` için değerlendirme ortamı) yüklendi. Veritabanı dökümlerini indirip imajları manuel olarak oluşturmanıza gerek yok! Lütfen Docker Hub'dan en son imajları çekin ve konteynerleri tekrar oluşturun, örn. `docker compose down -v && docker compose pull && docker compose up -d --force-recreate` komutunu kullanarak.
- [2025-08-22]  🐛 **Hata Düzeltmesi**: Phase-2 SQL değerlendirilirken, kayıtlı phase-1 SQL'in başarıyla yürütülememesi ve bu nedenle Phase-2'nin başarı oranının düşmesi hatası giderildi. Bu hata yalnızca phase1 sql'in veritabanı üzerinde bazı işlemler yaptığı görevleri etkiliyordu, örn. CREATE table, vb.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-12

---