![ChartGalaxy Logosu](https://raw.githubusercontent.com/ChartGalaxy/ChartGalaxy/main/title.png)

## Veri Kümesi
> 📦 **[👉 ChartGalaxy veri kümesinin tamamına Hugging Face üzerinden erişin! 👈](https://huggingface.co/datasets/ChartGalaxy/ChartGalaxy)**

Depolama sınırlamaları nedeniyle yalnızca temsilci örneklerden oluşan bir koleksiyon ekledik. 
Bu depo, "ChartGalaxy: A Dataset for Infographic Chart Understanding and Generation" başlıklı makaleye ait kodları içermektedir.

## 🔥 Haberler
**2025.5**:  🎉🎉 Veri kümesinin ilk sürümünü yayınladık. Bu sürümde 1.151.087 sentetik ve 104.519 gerçek infografik grafik yer almakta olup, 75 grafik tipi ve 330 varyasyon bulunmaktadır.

-------------------

<img src="https://raw.githubusercontent.com/ChartGalaxy/ChartGalaxy/main/teaser.png" style="border:none;box-shadow:none;">

![Örnekler görseli](https://raw.githubusercontent.com/ChartGalaxy/ChartGalaxy/main/examples.png)

<!-- ## 🔔 Haberler -->

## Giriş

### Hakkında

ChartGalaxy, veri tabloları ile birlikte sunulan, sentetik ve gerçek infografik grafiklerden oluşan milyon ölçekli bir veri kümesidir. Veri kümesi; infografik grafik anlama, kod üretimi ve grafik üretimi gibi uygulamaları destekler. Mevcut veri kümelerinin çoğunlukla sade grafiklerle sınırlı olması nedeniyle, infografik grafiklerin temel özelliklerinden olan tasarım stillerinin ve yerleşim çeşitliliğinin yakalanamaması sorununu ele almaktadır.

### İstatistikler

- **Boyut**: 1.255.606 infografik grafik (1.151.087 sentetik + 104.519 gerçek)
- **İçerik**: Her infografik grafik, onu oluşturmak için kullanılan tablo verileriyle eşleştirilmiştir
- **Grafik Tipleri**: 75 grafik tipi, 330 grafik varyasyonu
- **Yerleşim Şablonları**: 68 yerleşim şablonu

### Veri Toplama ve Oluşturma

ChartGalaxy şu adımlarla oluşturulmuştur:

1. **Gerçek İnfografik Grafik Toplama**: Pinterest, Visual Capitalist, Statista ve Information is Beautiful gibi 19 güvenilir, grafik açısından zengin web sitesinden grafikler toplanmıştır.

2. **Sentetik İnfografik Grafik Oluşturma**: Aşağıdaki gibi tümevarımsal bir yapılandırma süreci izlenmiştir:
   - 75 grafik tipi (ör. çubuk grafikler) ve farklı görsel öğe stillerini yansıtan 330 grafik varyasyonu tanımlanır
   - Öğeler arasındaki mekânsal ilişkileri belirleyen 68 yerleşim şablonu çıkartılır
   - Bu kalıplara dayalı olarak programatik şekilde sentetik grafikler üretilir

## 🎯 Uygulamalar

ChartGalaxy'nin kullanışlılığı üç temsilci uygulama ile gösterilmektedir:

### 1. 🧠 İnfografik Grafik Anlama

ChartGalaxy üzerinde ince ayar yapmak, temel modellerin infografik grafik anlama performansını artırır.

### 2. 💻 İnfografik Grafik Kod Üretimi

LVLM'lerin infografik grafikler için kod üretimini değerlendiren bir kıyaslama seti. Kıyaslama, üretilen D3.js kodu ile oluşturulan grafiklerle gerçek grafiklerin benzerliğini iki düzeyde değerlendirir: üst düzey (genel görsel benzerlik) ve alt düzey (ince ayrıntılı SVG öğeleri arasında ortalama benzerlik).

#### Genel Bakış

Kıyaslama seti, grafik kodu üretimini iki düzeyde değerlendirir:
- **Alt düzey**: Üretilen ve referans SVG'ler arasında öğe bazında benzerlik
- **Üst düzey**: Genel görsel sadakat ve işlevsellik değerlendirmesi

#### Kurulum

```bash
git clone https://github.com/ChartGalaxy/ChartGalaxy.git
cd ChartGalaxy/code_generation_benchmark
```

#### Kullanım

1. `code_generation_benchmark/configs/default_config.yaml` dosyasında ayarları yapılandırın:
   ```yaml
   prompts:
     high_level_eval_prompt_file: eval_high_level.txt
     chat_prompt_file: chat_direct_prompt.txt

   VLM:
     max_tokens: null
     thinking_budget: 1024
     temperature: 0.0
     top_p: 1.0

   models:
     # Değerlendirmek istediğiniz modellerin yorumunu kaldırın
     # - gpt-4o-2024-11-20
     # - claude-3-7-sonnet-20250219
     # - gemini-2.5-pro-preview-05-06
     # - Qwen/Qwen2.5-VL-72B-Instruct

   dirs:
     output_dir: ./output
     log_dir: ./logs
     data_root_dir: ./data
     clip_cache_dir: ./model-ckpts

   eval_model: gpt-4o-2024-11-20
   n_workers: 10
   ```

2. Kıyaslamayı çalıştırın:
   ```bash
   python main.py
   ```

#### Veri Yapısı

`data_root_dir` içindeki her grafik klasörü şunları içermelidir:
- `chart.svg`: Orijinal grafik (SVG formatında)

Sistem tarafından üretilecekler:
- `convert_chart.html`: Referans grafiğin HTML gösterimi
- `convert_chart.png`: Referans grafiğin PNG ekran görüntüsü
- `convert_chart.json`: Referans grafiğin öğe yapısı
- Modeller için özel çıktılar alt klasörlerde

#### Sonuçlar

Sonuçlar, model bazında alt klasörlerde saklanır ve şunları içerir:
- Üretilen HTML/PNG gösterimleri
- JSON formatında değerlendirme ölçütleri
- `log_dir` içinde ayrıntılı günlükler
  

### 3. 🖼️ Örneğe Dayalı İnfografik Grafik Üretimi

Kullanıcı tarafından sağlanan tablo verilerini, verilen bir örnek grafiğin yerleşimi ve görsel stiliyle uyumlu şekilde infografik grafiğe dönüştüren örneğe dayalı bir yöntemdir. Kullanıcı çalışmaları, bu yöntemin sadakat, estetik ve yaratıcılık açısından GPT-Image-1'den daha iyi performans gösterdiğini ortaya koymaktadır.


## İletişim
- chartgalaxy@163.com

## Makale Bağlantıları

### 📌 Ana Makale (Bu Depo)

- **[ChartGalaxy: A Dataset for Infographic Chart Understanding and Generation](https://arxiv.org/abs/2505.18668)**  
  _Zhen Li, Duan Li, Yukai Guo, Xinyuan Guo, Bowen Li, Lanxi Xiao, Shenyu Qiao, Jiashu Chen, Zijian Wu, Hui Zhang, Xinhuan Shu, Shixia Liu_  

### İlgili Makaleler

- **[OrionBench: A Benchmark for Chart and Human-Recognizable Object Detection in Infographics](https://arxiv.org/abs/2505.17473)**  
  _Jiangning Zhu, Yuxing Zhou, Zheng Wang, Juntao Yao, Yima Gu, Yuhui Yuan, Shixia Liu_  

- **[InfoChartQA: A Benchmark for Multimodal Question Answering on Infographic Charts](https://arxiv.org/abs/2505.19028)**  
  _Minzhi Lin, Tianchi Xie, Mengchen Liu, Yilin Ye, Changjian Chen, Shixia Liu_  

## 📚 Atıf
ChartGalaxy'ı araştırmanızda kullanırsanız lütfen aşağıdaki şekilde atıf yapınız:
```
@misc{li2025chartgalaxydatasetinfographicchart,
      title={ChartGalaxy: A Dataset for Infographic Chart Understanding and Generation}, 
      author={Zhen Li and Yukai Guo and Duan Li and Xinyuan Guo and Bowen Li and Lanxi Xiao and Shenyu Qiao and Jiashu Chen and Zijian Wu and Hui Zhang and Xinhuan Shu and Shixia Liu},
      year={2025},
      eprint={2505.18668},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2505.18668}, 
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---