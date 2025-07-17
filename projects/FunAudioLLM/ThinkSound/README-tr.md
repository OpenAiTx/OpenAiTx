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
  GitHub'da bir yıldız ⭐ bırakmanız çok memnun edici olur!
</p>

---

**ThinkSound** Zincirleme Düşünme (Chain-of-Thought, CoT) çıkarımıyla yönlendirilen akış eşleme (flow matching) ile birleşik bir Any2Audio üretim çerçevesidir.

Multimodal ses üretimi ve düzenlemesi için PyTorch uygulaması: Multimodal Büyük Dil Modelleri'nden (MLLMs) adım adım çıkarım gücüyle video, metin ve sesten ses oluşturun veya düzenleyin.

![Teaser](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 Haberler
- **2025.07.17** &nbsp; 🧠 İnce ayar etkin: Eğitim ve ince ayar kodu artık herkese açık; ThinkSound'u kendi verilerinizle özelleştirmenize ve genişletmenize yardımcı olacak net kullanım talimatlarıyla birlikte.
- **2025.07.15** &nbsp; 📦 Basitleştirilmiş kurulum ve kullanılabilirlik: Kolay çapraz platform kurulum için PyPI'da bağımlılıklar; Windows `.bat` betikleri ortam oluşturmayı ve betik çalıştırmayı otomatikleştirir.
- **2025.07.08** &nbsp;  🔧 Büyük güncelleme: Model hafifletildi ve bellek/GPU kullanımı optimize edildi, artık ölçekli yüksek verimli ses üretimi destekleniyor!
- **2025.07.01** &nbsp; 🔥[Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound) ve [ModelScope](https://modelscope.cn/studios/iic/ThinkSound) üzerinde çevrimiçi demo ile interaktif deneyim!
- **2025.07.01** &nbsp; 🔥Çıkarım betikleri ve web arayüzü yayınlandı;
- **2025.06** &nbsp; 🔥[ThinkSound makalesi](https://arxiv.org/pdf/2506.21448) arXiv'de yayımlandı!
- **2025.06** &nbsp; 🔥[Çevrimiçi Demo](http://thinksound-project.github.io/) aktif - hemen deneyin!

---


## 🚀 Özellikler

- **Any2Audio**: Rastgele modlardan — video, metin, ses veya bunların birleşimlerinden ses üretin.
- **Video'dan Sese SOTA**: Birçok V2A ölçütünde güncel en iyi (state-of-the-art) sonuçlar elde eder.
- **CoT Tabanlı Çıkarım**: MLLM'ler aracılığıyla bileşen tabanlı ve kontrol edilebilir ses üretimi için Zincirleme Düşünme çıkarımı.
- **Etkileşimli Nesne Merkezli Düzenleme**: Görsel nesnelere tıklayarak veya metin talimatlarıyla belirli ses olaylarını iyileştirin veya düzenleyin.
- **Birleşik Çerçeve**: Tek temel model ile üretim, düzenleme ve etkileşimli iş akışı desteği.

---

## ✨ Yöntem Genel Bakış

ThinkSound, ses üretimi ve düzenlemesini, tamamı MLLM tabanlı Zincirleme Düşünme (CoT) ile yönlendirilen üç etkileşimli aşamaya ayırır:

1. **Foley Üretimi:** Videodan anlamlı ve zamansal olarak hizalı temel ses ortamları oluşturun.
2. **Nesne Merkezli İyileştirme:** Videodaki nesnelere tıklayarak veya bölgeleri seçerek kullanıcı tarafından belirlenen nesneler için sesleri iyileştirin veya ekleyin.
3. **Hedefe Yönelik Ses Düzenleme:** Oluşturulan sesi, üst düzey doğal dil talimatlarıyla değiştirin.

![ThinkSound Genel Bakış](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- Büyük ölçekli CoT etiketli veri seti (**AudioCoT**), hem çıkarım modülünü hem de birleşik ses temel modelini eğitmek için kullanılır.
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
## 🏋️ Modeli Eğitin

[`Training.md`](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/docs/Training.md) dosyasına bakın.


---

## 📝 YAPILACAKLAR & Gelecek Planlar
* - [ ] AudioCoT veri seti ve otomatik hattını açık kaynak yapmak (07/23/2025 öncesi bekleniyor)
* - [ ] Çoklu alanları kapsayan, daha güçlü bir temel model yayımlayarak daha ilgi çekici ve etkileyici foley oluşturma sağlamak (Ağustos 2025 sonuna kadar bekleniyor)
* - [ ] Ek modalliklere ve alt görev desteklerine ekleme yapmak (Temmuz 2025 öncesi bekleniyor)
* - [ ] Farklı ölçeklerde modeller yayımlamak (Temmuz 2025 öncesi bekleniyor)
* - [x] ThinkSound modelleri için eğitim betiklerini yayımlama
* - [x] Yeni başlayanlar için Windows hızlı başlangıç README'si
---


## 📄 Lisans

Bu proje Apache 2.0 Lisansı altında yayımlanmıştır.

> **Not:**
> Kod, modeller ve veri seti **sadece araştırma ve eğitim amaçlıdır**.
> **Ticari kullanım İZİN VERİLMEZ.**
> Ticari lisanslama için lütfen yazarlarla iletişime geçin.

**📦 Üçüncü Taraf Bileşenler**

* **Stable Audio Open VAE** (Stability AI tarafından):
  Bu depo, [Stable Audio Open](https://huggingface.co/stabilityai/stable-audio-open-1.0/) üzerinden ince ayar yapılmış bir VAE içerir ve [Stability AI Community License](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/./third_party/LICENSE_StabilityAI.md) kapsamında lisanslanmıştır.
  **Ticari kullanım ve yeniden dağıtım için Stability AI'dan önceden izin alınması gerekir.**

* 📘 **Diğer tüm kod ve modeller** Apache License 2.0 kapsamında yayımlanmıştır.

---

## Teşekkürler

Teşekkürler:

* **stable-audio-tools** (Stability AI tarafından):
Ses üretimi için kullanımı kolay bir çerçeve, ayrıca VAE modülü ve ağırlıkları sağladığınız için.
* **MMAudio**:
  Ses alanında MM-DiT omurgasının uygulanması için.

---

## 📖 Atıf

ThinkSound'un araştırmanızda veya çalışmalarınızda faydalı olduğunu düşünüyorsanız, lütfen makalemizi kaynak gösterin:



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

✨ Herhangi bir sorunuz veya öneriniz varsa, [bir issue açmaktan](https://github.com/liuhuadai/ThinkSound/issues) veya bize e-posta ile ulaşmaktan ([liuhuadai@zju.edu.cn](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/mailto:liuhuadai@zju.edu.cn)) çekinmeyin!


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-17

---