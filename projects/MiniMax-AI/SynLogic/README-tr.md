<div align="center">
  <picture>
    <source srcset="assets/minimax-logo.png" media="(prefers-color-scheme: dark)">
      <img src="https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/assets/minimax-logo.png" width="60%" alt="MiniMax">
    </source>
  </picture>
</div>
<hr>

<div align="center" style="line-height: 1;">
<a href="https://arxiv.org/abs/2505.19641" target="_blank" style="margin: 2px;">
  <img alt="Paper" src="https://img.shields.io/badge/📖_Paper-Arxiv-327DE6?style=flat-square&labelColor=2C3E50" style="display: inline-block; vertical-align: middle;"/>
</a>
<a href="https://huggingface.co/datasets/MiniMaxAI/SynLogic" target="_blank" style="margin: 2px;">
  <img alt="Hugging Face" src="https://img.shields.io/badge/🤗_HF-Data-327DE6?style=flat-square&labelColor=2C3E50" style="display: inline-block; vertical-align: middle;"/>
</a>
<a href="https://huggingface.co/collections/MiniMaxAI/synlogic-6836c3246fca0277657ff032" target="_blank" style="margin: 2px;">
  <img alt="Hugging Face" src="https://img.shields.io/badge/🤗_HF-Model-327DE6?style=flat-square&labelColor=2C3E50" style="display: inline-block; vertical-align: middle;"/>
</a>
</div>

<hr>

# SynLogic

Bu depo, çeşitli, doğrulanabilir çıkarım verilerini ölçeklenebilir şekilde üreten kapsamlı bir mantıksal çıkarım veri sentezi çerçevesi olan SynLogic için kod ve verileri içermektedir. Çalışmamız, Büyük Dil Modellerinin (LLM'ler) genel çıkarım yeteneklerinin geliştirilmesi için yüksek kaliteli mantıksal çıkarım eğitim verileri konusundaki kritik boşluğu ele almaktadır.

<p align="center">
  <img src="https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/assets/main.jpg" alt="Laser main figure">
</p> 

## Haberler
- **[2025/07/07]** :fire: SynLogic verilerini Verl çerçevesi ile RL eğitimi yapmak için rehberlik sağlıyoruz. Ayrıntılar için [docs/training_guidance.md](https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/docs/training_guidance.md) dosyasına bakınız. 

- **[2025/06/03]** :fire: Eğitilmiş Modeller Hugging Face'te Yayınlandı:  
→ [MiniMaxAI/SynLogic Koleksiyonu](https://huggingface.co/collections/MiniMaxAI/synlogic-6836c3246fca0277657ff032)  

- **[2025/05]** :fire: "SynLogic: Mantıksal Çıkarım ve Ötesi için Ölçekli Olarak Doğrulanabilir Çıkarım Verisi Sentezi" başlıklı makaleye ait kaynakları yayınlamaktan heyecan duyuyoruz.

## 📋 Genel Bakış

**SynLogic**, aşağıdakileri sağlayan bir veri sentezi çerçevesi ve kapsamlı bir veri kümesidir:
- 📊 **Sudoku, 24 Oyunu, Şifre, Ok Labirenti ve daha fazlası dahil olmak üzere 35 farklı mantıksal çıkarım görevini kapsar**
- 🎯 **Her görev için ayarlanabilir parametrelerle kontrol edilebilir zorlukta sentez imkanı sunar**
- ✅ **RL eğitimi için kural tabanlı doğrulama ile doğrulanabilir ödüller sağlar**
- 🚀 **Açık kaynak veri kümeleri arasında SOTA performansına ulaşır, DeepSeek-R1-Distill-Qwen-32B'yi BBEH'de 6 puanla geçer**

### Temel Özellikler
- **Ölçeklenebilir Veri Üretimi**: Kontrol edilebilir zorluk seviyeleriyle sınırsız sentez
- **Kapsamlı Görev Yelpazesi**: 35 farklı mantıksal çıkarım görevi, özelleştirilmiş üreticiler ve doğrulayıcılarla
- **RL'ye Hazır**: Tüm örnekler basit kurallarla doğrulanabilir, pekiştirmeli öğrenme için idealdir
- **Alanlar Arası Transfer**: Matematiksel ve kodlama alanlarında güçlü genelleme

## 🚀 Hızlı Başlangıç

### Kurulum
```bash
git clone https://github.com/MiniMax-AI/SynLogic.git
cd SynLogic
pip install -r requirements.txt
```

### Örnek Veri Üretimi (Ok Labirenti Örneği)
```bash
# Ok Labirenti ile hızlı örnek
bash games/tasks/arrow_maze/run.sh

# Veya özel parametrelerle
python scripts/arrow_maze.py \
  --num_of_data 1000 \
  --width 5 \
  --height 5 \
  --arrow_fill_rate_min 0.3 \
  --arrow_fill_rate_max 0.9
```

### RL Eğitimi için

SynLogic verilerinin pekiştirmeli öğrenme eğitiminde kullanılmasına yönelik kapsamlı bir rehber sunuyoruz. SynLogic'in Verl çerçevesi ile entegrasyonu için ayrıntılı talimatlar için [docs/training_guidance.md](https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/docs/training_guidance.md) dosyasına bakınız.

## :rocket: Kaynaklar

### Veri Kümeleri
| Veri Kümesi Adı | Açıklama | Bağlantı |
|:---------------:|:--------:|:--------:|
| **SynLogic** | Veri Kümesi | [🤗 HuggingFace](https://huggingface.co/datasets/MiniMaxAI/SynLogic) |



### Modeller


| Model Adı | Açıklama | Bağlantı |
|:----------|:--------|:--------:|
| **SynLogic-7B** | SynLogic ile eğitilmiş 7B model | [🤗 HuggingFace](https://huggingface.co/MiniMaxAI/SynLogic-7B) |
| **SynLogic-32B** | SynLogic ile eğitilmiş 32B model | [🤗 HuggingFace](https://huggingface.co/MiniMaxAI/SynLogic-32B) |
| **SynLogic-Mix-3-32B** | SynLogic, Matematik ve Kodlama verileriyle eğitilmiş 32B model | [🤗 HuggingFace](https://huggingface.co/MiniMaxAI/SynLogic-Mix-3-32B) |

## 🔄 Gelecek Güncellemeler

SynLogic'i daha fazla mantıksal akıl yürütme göreviyle genişletmek için aktif olarak çalışıyoruz.

En son güncellemeler ve sürümler için depomuzu takip edin!

## Atıf
Çalışmamızın faydalı olduğunu düşünüyorsanız lütfen makalemizi atıf olarak gösterin:

```bibtex
@misc{liu2025synlogic,
      title={SynLogic: Synthesizing Verifiable Reasoning Data at Scale for Learning Logical Reasoning and Beyond}, 
      author={Junteng Liu and Yuanxiang Fan and Zhuo Jiang and Han Ding and Yongyi Hu and Chi Zhang and Yiqi Shi and Shitong Weng and Aili Chen and Shiqi Chen and Yunan Huang and Mozhi Zhang and Pengyu Zhao and Junjie Yan and Junxian He},
      year={2025},
      eprint={2505.19641},
      archivePrefix={arXiv},
      primaryClass={cs.AI},
      url={https://arxiv.org/abs/2505.19641}, 
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---