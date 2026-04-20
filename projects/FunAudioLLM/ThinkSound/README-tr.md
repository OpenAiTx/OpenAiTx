<h1 align="center">ThinkSound</h1>

<p align="center">
  🌐
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=en">English</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=zh-CN">简体中文</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=zh-TW">繁體中文</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=es">Español</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=fr">Français</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=ja">日本語</a>
  
</p>
<p align="center">
  <img src="https://img.shields.io/badge/NeurIPS%202025-Main%20Conference-blue.svg" alt="NeurIPS 2025"/>
  &nbsp;
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

<p align="center">
  Eğer bu projeyi faydalı bulduysanız,<br>
  GitHub'da bir yıldız ⭐ bırakırsanız çok memnun oluruz!
</p>

---

## Depo düzeni
Bu **ThinkSound** GitHub deposu, iki ilgili projeyi ayrı dallarda barındırmaktadır:

| Dal | Proje | Dokümantasyon |
|-----|-------|----------------|
| **`master`** | **ThinkSound** (NeurIPS 2025) — CoT rehberli akış eşleştirme ile birleşik Any2Audio üretimi | Bu dosya: **`README.md`** |
| **`prismaudio`** | **PrismAudio** — video'dan ses'e çok boyutlu CoT-RL ile devam eden çalışma (ICLR 2026) | [`prismaudio`](https://github.com/liuhuadai/ThinkSound/tree/prismaudio) dalında **`README.md`** |

**ThinkSound** için **`master`** dalını (bu README) kullanın. **PrismAudio** için ise **`prismaudio`** dalına geçip oradaki **`README.md`** dosyasını takip edin.

---

**ThinkSound**, Zincirleme Düşünce (CoT) akıl yürütme ile yönlendirilen akış eşleştirmeye sahip birleşik bir Any2Audio üretim çerçevesidir.

Multimodal ses üretimi ve düzenlemesi için PyTorch uygulaması: video, metin ve sesten ses üretin veya düzenleyin; Multimodal Büyük Dil Modellerinin (MLLM) adım adım akıl yürütme yeteneğiyle desteklenir.

![Teaser](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 Haberler
- **2026.03.24** &nbsp; 🔥 **PrismAudio** aynı repoda [`prismaudio`](https://github.com/liuhuadai/ThinkSound/tree/prismaudio) dalında yayınlandı — kurulum ve modeller için oradaki **`README.md`** dosyasına bakın.
- **2026.01.26** &nbsp; 🎉 PrismAudio, **ICLR 2026 Ana Konferansı**'na kabul edildi (kod/dökümanlar `prismaudio` dalında).
- **2025.11.25** &nbsp; 🔥 [Çevrimiçi PrismAudio Demo](http://prismaudio-project.github.io/) yayında.
- **2025.11.25** &nbsp; 🔥 [PrismAudio makalesi](https://arxiv.org/pdf/2511.18833) arXiv'de — video'dan ses'e çok boyutlu CoT-RL.
- **2025.09.19** &nbsp; 🎉 **ThinkSound**, **NeurIPS 2025 Ana Konferansı**'na kabul edildi!
- **2025.09.01** &nbsp; AudioCoT veri setimiz artık açık kaynaklı ve [Hugging Face](https://huggingface.co/datasets/liuhuadai/AudioCoT) üzerinde erişilebilir!
- **2025.07.17** &nbsp; 🧠 İnce ayar etkin: eğitim ve ince ayar kodu artık herkese açık, ThinkSound'u kendi verinizle özelleştirmeniz ve geliştirmeniz için net kullanım yönergeleriyle birlikte.
- **2025.07.15** &nbsp; 📦 Kolay kurulum ve kullanım: PyPI bağımlılıkları ile kolay çapraz platform kurulum; Windows `.bat` betikleri ortam oluşturmayı ve betik çalıştırmayı otomatikleştirir.
- **2025.07.08** &nbsp;  🔧 Büyük güncelleme: model hafifletildi ve bellek/GPU kullanımı optimize edildi, artık yüksek verimli ses üretimini destekliyor!
- **2025.07.01** &nbsp; [Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound) ve [ModelScope](https://modelscope.cn/studios/iic/ThinkSound) üzerinde çevrimiçi demo ile interaktif deneyim!
- **2025.07.01** &nbsp; Çıkarım betikleri ve web arayüzü yayınlandı; 
- **2025.06** &nbsp; [ThinkSound makalesi](https://arxiv.org/pdf/2506.21448) arXiv'de yayınlandı!
- **2025.06** &nbsp; [Çevrimiçi Demo](http://thinksound-project.github.io/) yayında - hemen deneyin!

---


<div align="center">

### Devam Çalışması: PrismAudio (aynı repo, `prismaudio` dalı)


**PrismAudio** ThinkSound'un (ICLR 2026) halefidir, yeni bir ad altında geliştirilmiş ancak bu depoda **`prismaudio`** dalında tutulmaktadır. Kurulum, kontrol noktaları ve atıf bilgileri için **[o dalın `README.md` dosyasına bakınız](https://github.com/liuhuadai/ThinkSound/blob/prismaudio/README.md)**.

👉 [`git checkout prismaudio`](https://github.com/liuhuadai/ThinkSound/tree/prismaudio) veya dalı GitHub'da açın.

</div>

---


## 🚀 Özellikler

- **Any2Audio**: İstenilen herhangi bir modaliteden — video, metin, ses veya bunların kombinasyonlarından — ses üretimi.
- **Video'dan Sese SOTA**: Birden fazla V2A benchmark'ında son teknoloji (state-of-the-art) sonuçlara ulaşır.
- **CoT-Tabanlı Akıl Yürütme**: MLLM'ler aracılığıyla birleşik ve kontrol edilebilir ses üretimi için Chain-of-Thought akıl yürütme.
- **Etkileşimli Nesne Merkezli Düzenleme**: Görsel nesnelere tıklayarak veya metin talimatlarıyla belirli ses olaylarını iyileştirin veya düzenleyin.
- **Birleşik Çerçeve**: Tek bir temel model; üretim, düzenleme ve etkileşimli iş akışını destekler.

---

## ✨ Yöntem Genel Bakış

ThinkSound, ses üretimi ve düzenlemesini, tümü MLLM tabanlı Chain-of-Thought (CoT) akıl yürütmesi ile yönlendirilen üç etkileşimli aşamaya ayırır:

1. **Foley Üretimi:** Videodan, anlamca ve zamanca uyumlu temel ses manzaraları üretir.
2. **Nesne Merkezli İyileştirme:** Videodaki belirli nesneler için tıklama veya bölge seçimiyle sesleri iyileştirin veya ekleyin.
3. **Hedefli Ses Düzenleme:** Üretilen sesi, üst düzey doğal dil talimatlarıyla değiştirin.

![ThinkSound Overview](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- Geniş ölçekli CoT-etiketli bir veri seti (**AudioCoT**), hem akıl yürütme modülünü hem de birleşik ses temel modelini eğitmek için kullanılır.
![AudioCoT Pipeline](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig2_dataset.png) -->

---

## ⚡ Hızlı Başlangıç

**Ortam Hazırlığı:**
```bash
# ThinkSound code: branch master. PrismAudio: clone with -b prismaudio (see README.md on that branch).
git clone -b master https://github.com/liuhuadai/ThinkSound.git
cd ThinkSound
conda create -n thinksound python=3.10
conda activate thinksound
pip install thinksound
conda install -y -c conda-forge 'ffmpeg<7'
# Download pretrained weights https://huggingface.co/liuhuadai/ThinkSound to Directory ckpts/
# model weights can be also downloaded from https://www.modelscope.cn/models/iic/ThinkSound
git lfs install
git clone https://huggingface.co/liuhuadai/ThinkSound ckpts
# To improve inference and training speed, you may optionally install a FlashAttention backend compatible with your system and PyTorch version.
```
> ✅ **Windows İpucu:**  
> Windows kullanıcıları, `setup_windows.bat` dosyasını çalıştırarak (veya çift tıklayarak) conda ortamını otomatik olarak oluşturabilir, tüm bağımlılıkları (FFmpeg dahil) yükleyebilir ve önceden eğitilmiş modeli indirebilir — elle kurulum gerekmez.  
> Scripti çalıştırmadan önce, `conda` ve `git`'in sistem PATH'inizde kurulu ve erişilebilir olduğundan emin olun.


### ▶️ Demoyu Çalıştırın

#### **Linux/macOS**


```bash
chmod +x scripts/demo.sh
./scripts/demo.sh <path-to-your-demo-video> <title> <CoT description> [use-half]
```
#### **Windows**

Bunun yerine sağlanan `.bat` betiğini kullanabilirsiniz:


```bash
.\scripts\demo.bat <path-to-your-demo-video> <title> <CoT description> [use-half]
```
**Not:**

* `<path-to-your-demo-video>`: Tek bir videonun yolu
* `[use-half]` (isteğe bağlı): Yarı hassasiyetli özellik çıkarımını etkinleştirmek için sona use-half ekleyin.

---

### 📦 Toplu Çıkarım

#### **Linux/macOS**


```bash
chmod +x scripts/eval_batch.sh
./scripts/eval_batch.sh <video_path> <csv_path> <save_path (optional)> [use-half]
```
#### **Windows**

Eşdeğer `.bat` betiğini kullanın:


```bash
.\scripts\eval_batch.bat <video_path> <csv_path> <save_path (optional)> [use-half]
```
**Not:**

* `<video_path>`: İşlenecek tüm .mp4 videoların bulunduğu kök dizinin yolu (tüm videolar aynı sürede olmalıdır).
* `<csv_path>`: Her video için metin istemleri içeren bir CSV dosyası (`demo_test.csv` formatına bakınız).
* `<save_path>` (isteğe bağlı): Oluşturulan sesin kaydedileceği yer. Varsayılan olarak `results/features`.
* `[use-half]` (isteğe bağlı): Yarı hassasiyetli özellik çıkarımını etkinleştirmek için en sona use-half ekleyin.

---


### Web Arayüzü Kullanımı

Etkileşimli bir deneyim için Gradio web arayüzünü başlatın:


```bash
python app.py
```
## 🏋️ Modeli Eğit

[`Training.md`](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/docs/Training.md) dosyasına bakın


---


## 📄 Lisans

Bu proje Apache 2.0 Lisansı altında yayımlanmıştır.

> **Not:**
> Kod, modeller ve veri seti **yalnızca araştırma ve eğitim amaçlıdır**.
> **Ticari kullanım İZİN VERİLMEZ.**
> Ticari lisanslama için lütfen yazarlarla iletişime geçin.

**📦 Üçüncü Taraf Bileşenler**

* **Stable Audio Open VAE** (Stability AI tarafından):
  Bu depo, [Stable Audio Open](https://huggingface.co/stabilityai/stable-audio-open-1.0/) adresinden alınan ve [Stability AI Community License](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/./third_party/LICENSE_StabilityAI.md) ile lisanslanan ince ayarlı bir VAE içermektedir.
  **Ticari kullanım ve yeniden dağıtım için Stability AI’dan önceden izin alınması gerekmektedir.**

* 📘 **Tüm diğer kod ve modeller** Apache Lisansı 2.0 altında yayımlanmıştır.

---

## Teşekkürler

Çok teşekkürler:

* **stable-audio-tools** (Stability AI tarafından):
Ses üretimi için kolay kullanılabilen bir çerçeve sağladıkları ve VAE modülü ile ağırlıklarını sundukları için.
* **MMAudio**:
  Ses alanında MM-DiT omurgasının uygulanması için.

---



## 📖 Atıf

Eğer projemizi araştırmanızda veya çalışmalarınızda faydalı bulduysanız, lütfen makalemize atıfta bulunun:

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
@misc{liu2025prismaudiodecomposedchainofthoughtsmultidimensional,
          title={PrismAudio: Decomposed Chain-of-Thoughts and Multi-dimensional Rewards for Video-to-Audio Generation}, 
          author={Huadai Liu and Kaicheng Luo and Wen Wang and Qian Chen and Peiwen Sun and Rongjie Huang and Xiangang Li and Jieping Ye and Wei Xue},
          year={2025},
          eprint={2511.18833},
          archivePrefix={arXiv},
          primaryClass={cs.SD},
          url={https://arxiv.org/abs/2511.18833}, 
    }
```

---

## 📬 Contact


✨ Feel free to [open an issue](https://github.com/liuhuadai/ThinkSound/issues) or contact us via email ([liuhuadai@zju.edu.cn](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/mailto:liuhuadai@zju.edu.cn)) if you have any questions or suggestions!





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-20

---