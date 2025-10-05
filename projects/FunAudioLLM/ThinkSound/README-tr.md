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
  <img src="https://img.shields.io/badge/NeurIPS 2025-Main Conference-blue.svg" alt="NeurIPS 2025"/>
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

<p align="center">
  Eğer bu projeyi faydalı bulduysanız,<br>
  GitHub'da bir yıldız ⭐ bırakmanız çok memnuniyet verici olur!
</p>

---

**ThinkSound**, Zincirleme-Düşünce (CoT) çıkarımıyla yönlendirilen akış eşleştirmesine sahip, birleşik bir Any2Audio üretim çerçevesidir.

Multimodal ses üretimi ve düzenlemesi için PyTorch uygulaması: video, metin ve sesten ses üretin veya düzenleyin, Çok Modlu Büyük Dil Modellerinin (MLLM) adım adım akıl yürütmesiyle desteklenir.

![Teaser](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 Haberler
- **2025.09.19** &nbsp; 🎉 ThinkSound, **NeurIPS 2025 Ana Konferansı**'na kabul edildi!
- **2025.09.01** &nbsp; 🔥 AudioCoT veri setimiz artık açık kaynak ve [Hugging Face](https://huggingface.co/datasets/liuhuadai/AudioCoT)'de mevcut!
- **2025.07.17** &nbsp; 🧠 İnce ayar etkin: eğitim ve ince ayar kodu artık herkese açık, ThinkSound'u kendi verilerinizle özelleştirip genişletmeniz için açık kullanım talimatları ile birlikte.
- **2025.07.15** &nbsp; 📦 Basitleştirilmiş kurulum ve kullanılabilirlik: kolay platformlar arası kurulum için PyPI bağımlılıkları; Windows `.bat` betikleri ortam oluşturma ve betik çalıştırmayı otomatikleştirir.
- **2025.07.08** &nbsp;  🔧 Büyük güncelleme: model hafifletildi ve bellek/GPU kullanımı optimize edildi, artık ölçekli yüksek verimli ses üretimini destekliyor!
- **2025.07.01** &nbsp; 🔥[Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound) ve [ModelScope](https://modelscope.cn/studios/iic/ThinkSound)'da çevrimiçi demo ile etkileşimli deneyim!
- **2025.07.01** &nbsp; 🔥Çıkarım betikleri ve web arayüzü yayınlandı;
- **2025.06** &nbsp; 🔥[ThinkSound makalesi](https://arxiv.org/pdf/2506.21448) arXiv'de yayınlandı!
- **2025.06** &nbsp; 🔥[Çevrimiçi Demo](http://thinksound-project.github.io/) yayında - hemen deneyin!

---


## 🚀 Özellikler

- **Any2Audio**: Ses üretimi için herhangi bir modallite — video, metin, ses veya bunların kombinasyonları.
- **Video'dan Sese SOTA**: Birçok V2A benchmark'ında alanında en iyi sonuçlar elde edilmiştir.
- **CoT Tabanlı Akıl Yürütme**: MLLM'ler aracılığıyla kompozisyonel ve kontrol edilebilir ses üretimi için Chain-of-Thought akıl yürütme.
- **Etkileşimli Nesne Merkezli Düzenleme**: Görsel nesneler üzerine tıklayarak veya metin talimatları kullanarak belirli ses olaylarını iyileştirin veya düzenleyin.
- **Birleşik Çerçeve**: Tek temel model üretim, düzenleme ve etkileşimli iş akışını destekler.

---

## ✨ Yöntem Genel Bakışı

ThinkSound, ses üretimi ve düzenlemesini, tümü MLLM tabanlı Chain-of-Thought (CoT) akıl yürütmesiyle yönlendirilen üç etkileşimli aşamaya ayırır:

1. **Foley Üretimi:** Videodan temel, anlamsal ve zamansal olarak hizalı ses manzaraları üretin.
2. **Nesne Merkezli İyileştirme:** Videodaki tıklamalar veya bölgeler aracılığıyla, kullanıcı tarafından belirtilen nesneler için sesleri iyileştirin veya ekleyin.
3. **Hedefli Ses Düzenleme:** Üretilen sesi üst düzey doğal dil talimatlarıyla değiştirin.

![ThinkSound Overview](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- Akıl yürütme modülü ve birleşik ses temel modelini eğitmek için büyük ölçekli CoT etiketli veri seti (**AudioCoT**) kullanılır.
![AudioCoT Pipeline](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig2_dataset.png) -->

---

## ⚡ Hızlı Başlangıç

**Ortam Hazırlığı:**
```bash
git clone https://github.com/liuhuadai/ThinkSound.git
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


## 🏋️ Modeli Eğitme

Bakınız [`Training.md`](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/docs/Training.md)


---

## 📝 TODO & Gelecek Planları
* - [ ] Daha güçlü, çoklu alanları kapsayan bir temel model yayınlanarak daha ilgi çekici ve sürükleyici foley üretimi sağlanacak
* - [ ] Ek modlar ve aşağı akış görevleri için destek eklenecek
* - [ ] Farklı ölçeklerde modeller yayınlanacak
* - [x] AudioCoT veri seti ve otomatikleştirilmiş boru hattı açık kaynak yapılacak
* - [x] ThinkSound modelleri için eğitim betikleri yayınlanacak
* - [x] Yeni başlayanlar için Windows hızlı başlangıç README'si hazırlanacak
---

## 📄 Lisans

Bu proje Apache 2.0 Lisansı altında yayınlanmıştır.

> **Not:**
> Kod, modeller ve veri seti **sadece araştırma ve eğitim amaçlıdır**.
> **Ticari kullanımına İZİN VERİLMEMEKTEDİR.**
> Ticari lisanslama için lütfen yazarlarla iletişime geçiniz.

**📦 Üçüncü Taraf Bileşenler**

* **Stable Audio Open VAE** (Stability AI tarafından):
  Bu depo, [Stable Audio Open](https://huggingface.co/stabilityai/stable-audio-open-1.0/) adresinden ince ayarlanmış bir VAE içerir ve [Stability AI Topluluk Lisansı](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/./third_party/LICENSE_StabilityAI.md) ile lisanslanmıştır.
  **Ticari kullanım ve yeniden dağıtım için Stability AI'den önceden izin alınması gerekmektedir.**

* 📘 **Diğer tüm kod ve modeller** Apache License 2.0 kapsamında yayınlanmıştır.

---

## Teşekkürler


Çok teşekkürler:

* **stable-audio-tools** (Stability AI tarafından):
Ses üretimi için kolay kullanılabilir bir çerçeve sağladığı, ayrıca VAE modülünü ve ağırlıklarını sunduğu için.
* **MMAudio**:
  Ses alanında MM-DiT omurgasının uygulanması için.

---

## 📖 Atıf

ThinkSound'u araştırmanızda veya çalışmalarınızda faydalı bulursanız, lütfen makalemize atıfta bulunun:

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

## 📬 Contact


✨ Feel free to [open an issue](https://github.com/liuhuadai/ThinkSound/issues) or contact us via email ([liuhuadai@zju.edu.cn](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/mailto:liuhuadai@zju.edu.cn)) if you have any questions or suggestions!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-04

---