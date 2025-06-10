<div align="center">
<h1>Fish Speech</h1>

**İngilizce** | [简体中文](docs/README.zh.md) | [Portekizce](docs/README.pt-BR.md) | [Japonca](docs/README.ja.md) | [Korece](docs/README.ko.md) <br>

<a href="https://www.producthunt.com/posts/fish-speech-1-4?embed=true&utm_source=badge-featured&utm_medium=badge&utm_souce=badge-fish&#0045;speech&#0045;1&#0045;4" target="_blank">
    <img src="https://api.producthunt.com/widgets/embed-image/v1/featured.svg?post_id=488440&theme=light" alt="Fish&#0032;Speech&#0032;1&#0046;4 - Open&#0045;Source&#0032;Multilingual&#0032;Text&#0045;to&#0045;Speech&#0032;with&#0032;Voice&#0032;Cloning | Product Hunt" style="width: 250px; height: 54px;" width="250" height="54" />
</a>
<a href="https://trendshift.io/repositories/7014" target="_blank">
    <img src="https://trendshift.io/api/badge/repositories/7014" alt="fishaudio%2Ffish-speech | Trendshift" style="width: 250px; height: 55px;" width="250" height="55"/>
</a>
<br>
</div>
<br>

<div align="center">
    <img src="https://count.getloli.com/get/@fish-speech?theme=asoul" /><br>
</div>

<br>

<div align="center">
    <a target="_blank" href="https://discord.gg/Es5qTB9BcN">
        <img alt="Discord" src="https://img.shields.io/discord/1214047546020728892?color=%23738ADB&label=Discord&logo=discord&logoColor=white&style=flat-square"/>
    </a>
    <a target="_blank" href="https://hub.docker.com/r/fishaudio/fish-speech">
        <img alt="Docker" src="https://img.shields.io/docker/pulls/fishaudio/fish-speech?style=flat-square&logo=docker"/>
    </a>
    <a target="_blank" href="https://pd.qq.com/s/bwxia254o">
      <img alt="QQ Channel" src="https://img.shields.io/badge/QQ-blue?logo=tencentqq">
    </a>
</div>

<div align="center">
    <a target="_blank" href="https://huggingface.co/spaces/TTS-AGI/TTS-Arena-V2">
      <img alt="TTS-Arena2 Score" src="https://img.shields.io/badge/TTS_Arena2-Rank_%231-gold?style=flat-square&logo=trophy&logoColor=white">
    </a>
    <a target="_blank" href="https://huggingface.co/spaces/fishaudio/fish-speech-1">
        <img alt="Huggingface" src="https://img.shields.io/badge/🤗%20-space%20demo-yellow"/>
    </a>
    <a target="_blank" href="https://huggingface.co/fishaudio/openaudio-s1-mini">
        <img alt="HuggingFace Model" src="https://img.shields.io/badge/🤗%20-models-orange"/>
    </a>
</div>

> [!IMPORTANT]
> **Lisans Bildirimi**  
> Bu kod deposu **Apache Lisansı** altında, tüm model ağırlıkları ise **CC-BY-NC-SA-4.0 Lisansı** altında yayımlanmıştır. Daha fazla ayrıntı için lütfen [LICENSE](LICENSE) dosyasına bakınız.

> [!WARNING]
> **Yasal Uyarı**  
> Kod tabanının herhangi bir yasa dışı kullanımından sorumlu değiliz. Lütfen DMCA ve diğer ilgili yasalar konusunda yerel yasalara başvurunuz.

---

## 🎉 Duyuru

Büyük bir heyecanla, Fish-Speech’in temelleri üzerine inşa edilen devrim niteliğindeki yeni gelişmiş Metinden Konuşmaya (TTS) modeller serisini tanıtarak **OpenAudio** markasına geçtiğimizi duyuruyoruz.

Bu serinin ilk modeli olarak **OpenAudio-S1**’i sunmaktan gurur duyuyoruz; kalite, performans ve yeteneklerde önemli iyileştirmeler getiriyor.

OpenAudio-S1 iki versiyon olarak sunulmaktadır: **OpenAudio-S1** ve **OpenAudio-S1-mini**. Her iki model de şu anda [Fish Audio Playground](https://fish.audio) (OpenAudio-S1 için) ve [Hugging Face](https://huggingface.co/fishaudio/openaudio-s1-mini) (OpenAudio-S1-mini için) üzerinden erişilebilmektedir.

Blog ve teknik rapor için [OpenAudio web sitesini](https://openaudio.com/blogs/s1) ziyaret edin.

## Öne Çıkanlar ✨

### **Mükemmel TTS kalitesi**

Model performansını değerlendirmek için Seed TTS Değerlendirme Metrikleri kullanıyoruz ve sonuçlar OpenAudio S1’in İngilizce metinde **0.008 WER** ve **0.004 CER** değerlerine ulaştığını gösteriyor; bu önceki modellere göre belirgin şekilde daha iyidir. (İngilizce, otomatik değerlendirme, OpenAI gpt-4o-transcribe tabanlı, konuşmacı mesafesi Revai/pyannote-wespeaker-voxceleb-resnet34-LM ile)

| Model | Kelime Hata Oranı (WER) | Karakter Hata Oranı (CER) | Konuşmacı Mesafesi |
|-------|------------------------|--------------------------|--------------------|
| **S1** | **0.008**  | **0.004**  | **0.332** |
| **S1-mini** | **0.011** | **0.005** | **0.380** |

### **TTS-Arena2’de En İyi Model** 🏆

OpenAudio S1, metinden konuşmaya değerlendirme için ölçüt olan [TTS-Arena2](https://arena.speechcolab.org/)'de **#1 sıralamasını** elde etti:

<div align="center">
    <img src="https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/assets/Elo.jpg" alt="TTS-Arena2 Sıralaması" style="width: 75%;" />
</div>

### **Konuşma Kontrolü**

OpenAudio S1, konuşma sentezini geliştirmek için **çeşitli duygusal, ton ve özel işaretleyicileri** destekler:

- **Temel duygular**:
```
(angry) (sad) (excited) (surprised) (satisfied) (delighted) 
(scared) (worried) (upset) (nervous) (frustrated) (depressed)
(empathetic) (embarrassed) (disgusted) (moved) (proud) (relaxed)
(grateful) (confident) (interested) (curious) (confused) (joyful)
```

- **Gelişmiş duygular**:
```
(disdainful) (unhappy) (anxious) (hysterical) (indifferent) 
(impatient) (guilty) (scornful) (panicked) (furious) (reluctant)
(keen) (disapproving) (negative) (denying) (astonished) (serious)
(sarcastic) (conciliative) (comforting) (sincere) (sneering)
(hesitating) (yielding) (painful) (awkward) (amused)
```

- **Ton işaretleyicileri**:
```
(in a hurry tone) (shouting) (screaming) (whispering) (soft tone)
```

- **Özel ses efektleri**:
```
(laughing) (chuckling) (sobbing) (crying loudly) (sighing) (panting)
(groaning) (crowd laughing) (background laughter) (audience laughing)
```

Ayrıca, Ha,ha,ha kullanarak kontrol edebilirsiniz; keşfedilecek birçok başka örnek de mevcuttur.

(Şu anda İngilizce, Çince ve Japonca desteklenmektedir, yakında daha fazla dil eklenecek!)

### **İki Model Türü**

| Model | Boyut | Erişilebilirlik | Özellikler |
|-------|-------|-----------------|------------|
| **S1** | 4B parametre | [fish.audio](fish.audio) üzerinden erişilebilir | Tam özellikli amiral gemisi modeli |
| **S1-mini** | 0.5B parametre | huggingface [hf space](https://huggingface.co/spaces/fishaudio/openaudio-s1-mini) üzerinden erişilebilir | Temel yeteneklere sahip damıtılmış sürüm |

Hem S1 hem de S1-mini çevrimiçi İnsan Geri Bildirimli Pekiştirmeli Öğrenme (RLHF) içermektedir.

## **Özellikler**

1. **Sıfır-örnek & Az-örnek TTS:** 10 ila 30 saniyelik bir ses örneği girerek yüksek kaliteli TTS çıktısı oluşturun. **Ayrıntılı rehberlik için bkz. [Ses Klonlama En İyi Uygulamaları](https://docs.fish.audio/text-to-speech/voice-clone-best-practices).**

2. **Çok dilli & Çapraz dilli Destek:** Çok dilli metni giriş kutusuna kopyalayıp yapıştırmanız yeterli—dil hakkında endişelenmenize gerek yok. Şu anda İngilizce, Japonca, Korece, Çince, Fransızca, Almanca, Arapça ve İspanyolca desteklenmektedir.

3. **Fonem Bağımsızlığı Yok:** Model güçlü genelleme yeteneğine sahiptir ve TTS için fonemlere ihtiyaç duymaz. Her dildeki metinleri işleyebilir.

4. **Yüksek Doğruluk:** Seed-TTS Eval için yaklaşık %0.4 CER (Karakter Hata Oranı) ve %0.8 WER (Kelime Hata Oranı) elde eder.

5. **Hızlı:** Fish-tech hızlandırma ile gerçek zaman faktörü Nvidia RTX 4060 dizüstü bilgisayarda yaklaşık 1:5 ve Nvidia RTX 4090’da 1:15’tir.

6. **WebUI Çıkarım:** Chrome, Firefox, Edge ve diğer tarayıcılarla uyumlu, kullanımı kolay Gradio tabanlı web arayüzü.

7. **GUI Çıkarım:** API sunucusuyla sorunsuz çalışan bir PyQt6 grafik arayüzü sunar. Linux, Windows ve macOS’u destekler. [GUI’ye bakın](https://github.com/AnyaCoder/fish-speech-gui).

8. **Dağıtıma Uygun:** Yerel olarak Linux ve Windows’u (MacOS yakında) destekleyen çıkarım sunucusunu kolayca kurun, hız kaybı minimumdur.

## **Medya & Demolar**

<div align="center">

### **Sosyal Medya**
<a href="https://x.com/FishAudio/status/1929915992299450398" target="_blank">
    <img src="https://img.shields.io/badge/𝕏-Latest_Demo-black?style=for-the-badge&logo=x&logoColor=white" alt="X'te Son Demo" />
</a>

### **Etkileşimli Demolar**
<a href="https://fish.audio" target="_blank">
    <img src="https://img.shields.io/badge/Fish_Audio-Try_OpenAudio_S1-blue?style=for-the-badge" alt="OpenAudio S1'i Dene" />
</a>
<a href="https://huggingface.co/spaces/fishaudio/openaudio-s1-mini" target="_blank">
    <img src="https://img.shields.io/badge/Hugging_Face-Try_S1_Mini-yellow?style=for-the-badge" alt="S1 Mini'yi Dene" />
</a>

### **Video Gösterimleri**

<a href="https://www.youtube.com/watch?v=SYuPvd7m06A" target="_blank">
    <img src="https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/assets/Thumbnail.jpg" alt="OpenAudio S1 Video" style="width: 50%;" />
</a>

### **Ses Örnekleri**
<div style="margin: 20px 0;">
    <em> Yüksek kaliteli ses örnekleri yakında mevcut olacak; farklı diller ve duygularda çok dilli TTS yeteneklerimizi gösterecek.</em>
</div>

</div>

---

## Dokümanlar

- [Kurulum Ortamı](https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/en/install.md)
- [Çıkarım](https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/en/inference.md)

## Katkı Sağlayanlar

- [VITS2 (daniilrobnikov)](https://github.com/daniilrobnikov/vits2)
- [Bert-VITS2](https://github.com/fishaudio/Bert-VITS2)
- [GPT VITS](https://github.com/innnky/gpt-vits)
- [MQTTS](https://github.com/b04901014/MQTTS)
- [GPT Fast](https://github.com/pytorch-labs/gpt-fast)
- [GPT-SoVITS](https://github.com/RVC-Boss/GPT-SoVITS)
- [Qwen3](https://github.com/QwenLM/Qwen3)

## Teknik Rapor (V1.4)
```bibtex
@misc{fish-speech-v1.4,
      title={Fish-Speech: Leveraging Large Language Models for Advanced Multilingual Text-to-Speech Synthesis},
      author={Shijia Liao and Yuxuan Wang and Tianyu Li and Yifan Cheng and Ruoyi Zhang and Rongzhi Zhou and Yijin Xing},
      year={2024},
```
      eprint={2411.01156},
      archivePrefix={arXiv},
      primaryClass={cs.SD},
      url={https://arxiv.org/abs/2411.01156},
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---