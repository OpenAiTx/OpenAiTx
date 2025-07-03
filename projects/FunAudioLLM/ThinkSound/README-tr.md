# 🎶 ThinkSound

<p align="center">
  Eğer bu projeyi faydalı bulduysanız, GitHub'da bir yıldız ⭐ bırakmanız çok memnun edici olurdu!
</p>

<p align="center">
  <a href="https://arxiv.org/pdf/2506.21448">
    <img src="https://img.shields.io/badge/arXiv-2506.21448-b31b1b.svg" alt="arXiv"/>
  </a>
  &nbsp;
  <a href="https://thinksound-project.github.io/">
    <img src="https://img.shields.io/badge/Online%20Demo-🌐-blue" alt="Online Demo"/>
  </a>
  &nbsp;
  <a href="https://huggingface.co/spaces/FunAudioLLM/ThinkSound">
    <img src="https://img.shields.io/badge/HuggingFace-Spaces-orange?logo=huggingface" alt="Hugging Face"/>
  </a>
  &nbsp;
  <a href="https://modelscope.cn/studios/iic/ThinkSound">
    <img src="https://img.shields.io/badge/ModelScope-在线体验-green" alt="ModelScope"/>
  </a>
</p>

---

**ThinkSound**, Zincirleme Düşünce (CoT) akıl yürütme ile yönlendirilen flow-matching tabanlı birleşik bir Any2Audio üretim çerçevesidir.

Görüntü, metin ve ses girdilerinden ses üretimi veya düzenlemesi için PyTorch implementasyonu: Multimodal Büyük Dil Modelleri (MLLM) üzerinden adım adım akıl yürütme ile güçlendirilmiştir.

![Teaser](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 Haberler
- **2025.07** &nbsp; 🔥[Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound) ve [ModelScope](https://modelscope.cn/studios/iic/ThinkSound) üzerinde etkileşimli deneyim için çevrim içi demo yayında!
- **2025.07** &nbsp; 🔥Çıkarım (inference) betikleri ve web arayüzü yayınlandı;
- **2025.06** &nbsp; 🔥[ThinkSound makalesi](https://arxiv.org/pdf/2506.21448) arXiv'de yayınlandı!
- **2025.06** &nbsp; 🔥[Çevrim İçi Demo](http://thinksound-project.github.io/) yayında - hemen deneyin!

---

## 🚀 Özellikler

- **Any2Audio**: Rastgele modlardan — video, metin, ses veya bunların kombinasyonlarından — ses üretimi.
- **Video'dan Sese SOTA**: Birçok V2A (Video to Audio) benchmark'ında en son teknoloji (state-of-the-art) sonuçlar.
- **CoT Tabanlı Akıl Yürütme**: MLLM'ler ile adım adım zincirleme düşünce akıl yürütmesiyle bileşen tabanlı ve kontrol edilebilir ses üretimi.
- **Etkileşimli Nesne Merkezli Düzenleme**: Görsel nesnelere tıklayarak veya metin talimatlarıyla belirli ses olaylarını düzenleyin veya iyileştirin.
- **Birleşik Çerçeve**: Tek bir temel model ile üretim, düzenleme ve etkileşimli iş akışı desteği.

---

## ✨ Yöntem Genel Bakışı

ThinkSound, ses üretimi ve düzenleme işlemini, tamamı MLLM tabanlı Zincirleme Düşünce (CoT) akıl yürütme ile yönlendirilen üç etkileşimli aşamaya ayırır:

1. **Foley Üretimi:** Videodan anlamca ve zamansal olarak hizalı temel ses manzaraları üretir.
2. **Nesne Merkezli İyileştirme:** Kullanıcı tarafından belirtilen nesneler için video üzerinde tıklama veya bölge seçimi ile sesleri iyileştirin veya ekleyin.
3. **Hedefli Ses Düzenleme:** Üretilen sesi yüksek seviyeli doğal dil talimatlarıyla düzenleyin.

![ThinkSound Overview](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- Geniş çaplı CoT ile açıklamalı bir veri kümesi (**AudioCoT**), hem akıl yürütme modülünü hem de birleşik ses temel modelini eğitmek için kullanılır.
![AudioCoT Pipeline](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig2_dataset.png) -->

---

## ⚡ Hızlı Başlangıç

**Ortam Hazırlığı:**
```bash
git clone https://github.com/liuhuadai/ThinkSound.git
cd ThinkSound
pip install -r requirements.txt
conda install -y -c conda-forge 'ffmpeg<7'
# Önceden eğitilmiş ağırlıkları https://huggingface.co/liuhuadai/ThinkSound adresinden ckpts/ dizinine indirin
# Model ağırlıkları ayrıca https://www.modelscope.cn/models/iic/ThinkSound adresinden indirilebilir
git lfs install
git clone https://huggingface.co/liuhuadai/ThinkSound ckpts
```

**Çalıştırılabilir yapın**
```bash
chmod +x scripts/demo.sh
```

**Betik çalıştırma**
```bash
./scripts/demo.sh <video_yolu> <altyazı> <CoT açıklaması>
```


### Web Arayüzü Kullanımı

Etkileşimli bir deneyim için Gradio web arayüzünü başlatın:

```bash
python app.py
```

---
## 📝 YAPILACAKLAR

- ☐ ThinkSound modelleri için eğitim betiklerini yayımla
- ☐ AudioCoT veri setini ve otomatikleştirilmiş hattı açık kaynak yap
- ☐ Ayrıntılı dokümantasyon ve API referansı sağla
- ☐ Ek modallikler ve ardıl görevler için destek ekle

---

## 📄 Lisans

Bu proje [Apache 2.0 Lisansı](LICENSE) altında yayımlanmıştır.

> **Not:**  
> Kod, modeller ve veri seti **yalnızca araştırma ve eğitim amaçlıdır**.  
> **Ticari kullanım İZİN VERİLMEMEKTEDİR.**
>
> Ticari lisanslama için lütfen yazarlarla iletişime geçin.

---

## 📖 Atıf

ThinkSound'u araştırmanızda veya çalışmalarınızda faydalı bulursanız, lütfen makalemizi kaynak gösterin:

```bibtex
@misc{liu2025thinksoundchainofthoughtreasoningmultimodal,
      title={ThinkSound: Chain-of-Thought Reasoning in Multimodal Large Language Models for Audio Generation and Editing}, 
      author={Huadai Liu and Jialei Wang and Kaicheng Luo and Wen Wang and Qian Chen and Zhou Zhao and Wei Xue},
      year={2025},
      eprint={2506.21448},
      archivePrefix={arXiv},
      primaryClass={eess.AS},
      url={https://arxiv.org/abs/2506.21448}, 
}
```

---

## 📬 İletişim

✨ Herhangi bir sorunuz veya öneriniz varsa [bir issue açmaktan](https://github.com/liuhuadai/ThinkSound/issues) veya e-posta yoluyla bizimle iletişime geçmekten ([liuhuadai@zju.edu.cn](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/mailto:liuhuadai@zju.edu.cn)) çekinmeyin!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-03

---