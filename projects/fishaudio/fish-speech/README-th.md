<div align="center">
<h1>Fish Speech</h1>

**English** | [简体中文](docs/README.zh.md) | [Portuguese](docs/README.pt-BR.md) | [日本語](docs/README.ja.md) | [한국어](docs/README.ko.md) <br>

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
> **ประกาศเกี่ยวกับลิขสิทธิ์**  
> โค้ดนี้เผยแพร่ภายใต้ **Apache License** และน้ำหนักโมเดลทั้งหมดเผยแพร่ภายใต้ **CC-BY-NC-SA-4.0 License** กรุณาอ่านรายละเอียดที่ [LICENSE](LICENSE)

> [!WARNING]
> **ข้อจำกัดความรับผิดชอบทางกฎหมาย**  
> เราไม่รับผิดชอบต่อการใช้งานโค้ดนี้ในทางที่ผิดกฎหมาย กรุณาศึกษากฎหมาย DMCA และกฎหมายที่เกี่ยวข้องในพื้นที่ของคุณ

---

## 🎉 ประกาศ

เรารู้สึกตื่นเต้นที่จะประกาศว่าเราได้รีแบรนด์เป็น **OpenAudio** — เปิดตัวชุดโมเดล Text-to-Speech ขั้นสูงชุดใหม่ที่สร้างต่อยอดจาก Fish-Speech

เราภูมิใจนำเสนอ **OpenAudio-S1** ซึ่งเป็นโมเดลแรกในซีรีส์นี้ โดยมีการพัฒนาอย่างมีนัยสำคัญทั้งในด้านคุณภาพ ประสิทธิภาพ และความสามารถ

OpenAudio-S1 มีให้เลือก 2 เวอร์ชัน: **OpenAudio-S1** และ **OpenAudio-S1-mini** ทั้งสองรุ่นพร้อมใช้งานแล้วที่ [Fish Audio Playground](https://fish.audio) (สำหรับ **OpenAudio-S1**) และ [Hugging Face](https://huggingface.co/fishaudio/openaudio-s1-mini) (สำหรับ **OpenAudio-S1-mini**)

เยี่ยมชม [เว็บไซต์ OpenAudio](https://openaudio.com/blogs/s1) สำหรับบล็อกและรายงานเทคนิค

## จุดเด่น ✨

### **คุณภาพ TTS ยอดเยี่ยม**

เราใช้ Seed TTS Eval Metrics ในการประเมินประสิทธิภาพของโมเดล ผลลัพธ์แสดงว่า OpenAudio S1 ทำได้ **0.008 WER** และ **0.004 CER** กับข้อความภาษาอังกฤษ ซึ่งดีกว่าโมเดลก่อนหน้าอย่างเห็นได้ชัด (ภาษาอังกฤษ, ประเมินอัตโนมัติ, อิงตาม OpenAI gpt-4o-transcribe, speaker distance ใช้ Revai/pyannote-wespeaker-voxceleb-resnet34-LM)

| โมเดล | Word Error Rate (WER) | Character Error Rate (CER) | Speaker Distance |
|-------|----------------------|---------------------------|------------------|
| **S1** | **0.008**  | **0.004**  | **0.332** |
| **S1-mini** | **0.011** | **0.005** | **0.380** |

### **โมเดลที่ดีที่สุดใน TTS-Arena2** 🏆

OpenAudio S1 ได้รับ **อันดับ 1** บน [TTS-Arena2](https://arena.speechcolab.org/) ซึ่งเป็นมาตรฐานในการประเมิน Text-to-Speech

<div align="center">
    <img src="https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/assets/Elo.jpg" alt="TTS-Arena2 Ranking" style="width: 75%;" />
</div>

### **ควบคุมการพูดได้**

OpenAudio S1 **รองรับอารมณ์ น้ำเสียง และมาร์กเกอร์พิเศษหลากหลายแบบ** เพื่อเสริมการสังเคราะห์เสียงพูด

- **อารมณ์พื้นฐาน**:
```
(angry) (sad) (excited) (surprised) (satisfied) (delighted) 
(scared) (worried) (upset) (nervous) (frustrated) (depressed)
(empathetic) (embarrassed) (disgusted) (moved) (proud) (relaxed)
(grateful) (confident) (interested) (curious) (confused) (joyful)
```

- **อารมณ์ขั้นสูง**:
```
(disdainful) (unhappy) (anxious) (hysterical) (indifferent) 
(impatient) (guilty) (scornful) (panicked) (furious) (reluctant)
(keen) (disapproving) (negative) (denying) (astonished) (serious)
(sarcastic) (conciliative) (comforting) (sincere) (sneering)
(hesitating) (yielding) (painful) (awkward) (amused)
```

- **มาร์กเกอร์น้ำเสียง**:
```
(in a hurry tone) (shouting) (screaming) (whispering) (soft tone)
```

- **เอฟเฟกต์เสียงพิเศษ**:
```
(laughing) (chuckling) (sobbing) (crying loudly) (sighing) (panting)
(groaning) (crowd laughing) (background laughter) (audience laughing)
```

คุณยังสามารถใช้ Ha,ha,ha เพื่อควบคุมเสียงพูด และยังมีอีกหลายกรณีให้คุณทดลองด้วยตัวเอง

(ขณะนี้รองรับภาษาอังกฤษ จีน และญี่ปุ่น และจะมีภาษาอื่น ๆ เพิ่มเร็วๆ นี้!)

### **สองประเภทของโมเดล**

| โมเดล | ขนาด | ความพร้อมใช้งาน | คุณสมบัติ |
|-------|------|--------------|----------|
| **S1** | 4B พารามิเตอร์ | ใช้งานได้ที่ [fish.audio](fish.audio) | โมเดลเรือธงฟีเจอร์ครบถ้วน |
| **S1-mini** | 0.5B พารามิเตอร์ | ใช้งานได้ที่ huggingface [hf space](https://huggingface.co/spaces/fishaudio/openaudio-s1-mini) | เวอร์ชันกลั่นที่มีความสามารถหลัก |

ทั้ง S1 และ S1-mini รวมการเรียนรู้แบบเสริมกำลังออนไลน์จาก Human Feedback (RLHF)

## **ฟีเจอร์**

1. **Zero-shot & Few-shot TTS:** ป้อนตัวอย่างเสียงพูดยาว 10-30 วินาทีเพื่อสร้างผลลัพธ์ TTS คุณภาพสูง **ดูแนวทางโดยละเอียดที่ [Voice Cloning Best Practices](https://docs.fish.audio/text-to-speech/voice-clone-best-practices)**

2. **รองรับหลายภาษา & ข้ามภาษา:** เพียงแค่คัดลอกและวางข้อความหลายภาษาลงในกล่องอินพุต—ไม่ต้องกังวลเรื่องภาษา ขณะนี้รองรับภาษาอังกฤษ ญี่ปุ่น เกาหลี จีน ฝรั่งเศส เยอรมัน อาหรับ และสเปน

3. **ไม่ต้องพึ่งพาโฟนีม:** โมเดลมีความสามารถในการประยุกต์ใช้สูง และไม่ต้องพึ่งพาโฟนีมสำหรับ TTS สามารถจัดการข้อความในสคริปต์ภาษาใดก็ได้

4. **แม่นยำสูง:** มี CER (Character Error Rate) ต่ำเพียงประมาณ 0.4% และ WER (Word Error Rate) ประมาณ 0.8% สำหรับ Seed-TTS Eval

5. **รวดเร็ว:** ด้วย fish-tech acceleration real-time factor ประมาณ 1:5 บน Nvidia RTX 4060 laptop และ 1:15 บน Nvidia RTX 4090

6. **WebUI Inference:** มีเว็บ UI ที่ใช้งานง่ายบน Gradio รองรับ Chrome, Firefox, Edge และเบราว์เซอร์อื่น ๆ

7. **GUI Inference:** มีอินเทอร์เฟซแบบกราฟิก PyQt6 ทำงานร่วมกับ API server ได้อย่างราบรื่น รองรับ Linux, Windows, และ macOS [ดู GUI](https://github.com/AnyaCoder/fish-speech-gui)

8. **เหมาะกับการนำไปใช้งาน:** ตั้งค่า inference server ได้ง่าย รองรับ Linux, Windows (MacOS เร็วๆ นี้) ลดการสูญเสียความเร็วให้น้อยที่สุด

## **มีเดีย & เดโม**

<div align="center">

### **โซเชียลมีเดีย**
<a href="https://x.com/FishAudio/status/1929915992299450398" target="_blank">
    <img src="https://img.shields.io/badge/𝕏-Latest_Demo-black?style=for-the-badge&logo=x&logoColor=white" alt="Latest Demo on X" />
</a>

### **เดโมแบบอินเทอร์แอคทีฟ**
<a href="https://fish.audio" target="_blank">
    <img src="https://img.shields.io/badge/Fish_Audio-Try_OpenAudio_S1-blue?style=for-the-badge" alt="Try OpenAudio S1" />
</a>
<a href="https://huggingface.co/spaces/fishaudio/openaudio-s1-mini" target="_blank">
    <img src="https://img.shields.io/badge/Hugging_Face-Try_S1_Mini-yellow?style=for-the-badge" alt="Try S1 Mini" />
</a>

### **วิดีโอตัวอย่าง**

<a href="https://www.youtube.com/watch?v=SYuPvd7m06A" target="_blank">
    <img src="https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/assets/Thumbnail.jpg" alt="OpenAudio S1 Video" style="width: 50%;" />
</a>

### **ตัวอย่างเสียง**
<div style="margin: 20px 0;">
    <em> ตัวอย่างเสียงคุณภาพสูงจะพร้อมให้ฟังเร็ว ๆ นี้ สาธิตความสามารถ TTS หลายภาษาและอารมณ์ที่หลากหลายของเรา</em>
</div>

</div>

---

## เอกสาร

- [Build Envrionment](https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/en/install.md)
- [Inference](https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/en/inference.md)

## เครดิต

- [VITS2 (daniilrobnikov)](https://github.com/daniilrobnikov/vits2)
- [Bert-VITS2](https://github.com/fishaudio/Bert-VITS2)
- [GPT VITS](https://github.com/innnky/gpt-vits)
- [MQTTS](https://github.com/b04901014/MQTTS)
- [GPT Fast](https://github.com/pytorch-labs/gpt-fast)
- [GPT-SoVITS](https://github.com/RVC-Boss/GPT-SoVITS)
- [Qwen3](https://github.com/QwenLM/Qwen3)

## รายงานเทคนิค (V1.4)
```bibtex
@misc{fish-speech-v1.4,
      title={Fish-Speech: Leveraging Large Language Models for Advanced Multilingual Text-to-Speech Synthesis},
      author={Shijia Liao and Yuxuan Wang and Tianyu Li and Yifan Cheng and Ruoyi Zhang and Rongzhi Zhou and Yijin Xing},
      year={2024},
      eprint={2411.01156},
      archivePrefix={arXiv},
      primaryClass={cs.SD},
      url={https://arxiv.org/abs/2411.01156},
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---