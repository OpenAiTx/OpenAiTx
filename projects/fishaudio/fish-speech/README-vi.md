<div align="center">
<h1>Fish Speech</h1>

**Tiếng Anh** | [简体中文](docs/README.zh.md) | [Tiếng Bồ Đào Nha](docs/README.pt-BR.md) | [Tiếng Nhật](docs/README.ja.md) | [Tiếng Hàn](docs/README.ko.md) <br>

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
> **Thông Báo Về Giấy Phép**  
> Bộ mã nguồn này được phát hành dưới **Giấy phép Apache** và tất cả trọng số mô hình được phát hành theo **Giấy phép CC-BY-NC-SA-4.0**. Vui lòng xem chi tiết tại [LICENSE](LICENSE).

> [!WARNING]
> **Tuyên Bố Pháp Lý**  
> Chúng tôi không chịu bất kỳ trách nhiệm nào đối với việc sử dụng mã nguồn này cho các mục đích phi pháp. Vui lòng tuân thủ pháp luật địa phương về DMCA và các quy định liên quan khác.

---

## 🎉 Thông Báo

Chúng tôi rất vui mừng thông báo rằng chúng tôi đã đổi thương hiệu thành **OpenAudio** — giới thiệu một dòng mô hình Text-to-Speech tiên tiến, mang tính cách mạng, được xây dựng dựa trên nền tảng của Fish-Speech.

Chúng tôi tự hào ra mắt **OpenAudio-S1** là mô hình đầu tiên trong dòng sản phẩm này, mang lại những cải tiến đáng kể về chất lượng, hiệu năng và khả năng.

OpenAudio-S1 có hai phiên bản: **OpenAudio-S1** và **OpenAudio-S1-mini**. Cả hai mô hình hiện đã có trên [Fish Audio Playground](https://fish.audio) (cho **OpenAudio-S1**) và [Hugging Face](https://huggingface.co/fishaudio/openaudio-s1-mini) (cho **OpenAudio-S1-mini**).

Truy cập [trang web OpenAudio](https://openaudio.com/blogs/s1) để đọc blog & báo cáo kỹ thuật.

## Điểm Nổi Bật ✨

### **Chất lượng TTS xuất sắc**

Chúng tôi sử dụng các chỉ số đánh giá Seed TTS Eval Metrics để đánh giá hiệu năng mô hình, và kết quả cho thấy OpenAudio S1 đạt **0.008 WER** và **0.004 CER** trên văn bản tiếng Anh, tốt hơn đáng kể so với các mô hình trước đó. (Tiếng Anh, đánh giá tự động, dựa trên OpenAI gpt-4o-transcribe, khoảng cách người nói sử dụng Revai/pyannote-wespeaker-voxceleb-resnet34-LM)

| Mô hình | Tỷ lệ lỗi từ (WER) | Tỷ lệ lỗi ký tự (CER) | Khoảng cách người nói |
|-------|----------------------|---------------------------|------------------|
| **S1** | **0.008**  | **0.004**  | **0.332** |
| **S1-mini** | **0.011** | **0.005** | **0.380** |

### **Mô hình tốt nhất tại TTS-Arena2** 🏆

OpenAudio S1 đã đạt **xếp hạng #1** trên [TTS-Arena2](https://arena.speechcolab.org/), chuẩn mực đánh giá cho text-to-speech:

<div align="center">
    <img src="https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/assets/Elo.jpg" alt="TTS-Arena2 Ranking" style="width: 75%;" />
</div>

### **Điều khiển giọng nói**

OpenAudio S1 **hỗ trợ đa dạng cảm xúc, ngữ điệu và các ký hiệu đặc biệt** để tăng cường khả năng tổng hợp giọng nói:

- **Cảm xúc cơ bản**:
```
(angry) (sad) (excited) (surprised) (satisfied) (delighted) 
(scared) (worried) (upset) (nervous) (frustrated) (depressed)
(empathetic) (embarrassed) (disgusted) (moved) (proud) (relaxed)
(grateful) (confident) (interested) (curious) (confused) (joyful)
```

- **Cảm xúc nâng cao**:
```
(disdainful) (unhappy) (anxious) (hysterical) (indifferent) 
(impatient) (guilty) (scornful) (panicked) (furious) (reluctant)
(keen) (disapproving) (negative) (denying) (astonished) (serious)
(sarcastic) (conciliative) (comforting) (sincere) (sneering)
(hesitating) (yielding) (painful) (awkward) (amused)
```

- **Ký hiệu ngữ điệu**:
```
(in a hurry tone) (shouting) (screaming) (whispering) (soft tone)
```

- **Hiệu ứng âm thanh đặc biệt**:
```
(laughing) (chuckling) (sobbing) (crying loudly) (sighing) (panting)
(groaning) (crowd laughing) (background laughter) (audience laughing)
```

Bạn cũng có thể sử dụng Ha,ha,ha để điều khiển, còn rất nhiều trường hợp khác chờ bạn khám phá.

(Hỗ trợ tiếng Anh, tiếng Trung và tiếng Nhật hiện tại, nhiều ngôn ngữ khác sẽ sớm ra mắt!)

### **Hai Loại Mô Hình**

| Mô hình | Kích thước | Khả dụng | Tính năng |
|-------|------|--------------|----------|
| **S1** | 4B tham số | Có trên [fish.audio](fish.audio) | Mô hình đầy đủ tính năng |
| **S1-mini** | 0.5B tham số | Có trên huggingface [hf space](https://huggingface.co/spaces/fishaudio/openaudio-s1-mini) | Phiên bản rút gọn với các khả năng cốt lõi |

Cả S1 và S1-mini đều tích hợp học tăng cường trực tuyến từ phản hồi của con người (RLHF).

## **Tính năng**

1. **Zero-shot & Few-shot TTS:** Nhập mẫu giọng nói từ 10 đến 30 giây để tạo ra đầu ra TTS chất lượng cao. **Xem hướng dẫn chi tiết tại [Thực hành tốt nhất cho nhân bản giọng nói](https://docs.fish.audio/text-to-speech/voice-clone-best-practices).**

2. **Hỗ trợ đa ngôn ngữ & xuyên ngôn ngữ:** Chỉ cần sao chép và dán văn bản đa ngôn ngữ vào hộp nhập liệu—không cần lo ngại về ngôn ngữ. Hiện hỗ trợ tiếng Anh, Nhật, Hàn, Trung, Pháp, Đức, Ả Rập và Tây Ban Nha.

3. **Không phụ thuộc vào âm vị:** Mô hình có khả năng tổng quát hóa mạnh mẽ và không phụ thuộc vào âm vị để tổng hợp tiếng nói. Có thể xử lý văn bản ở bất kỳ hệ chữ nào.

4. **Chính xác cao:** Đạt tỷ lệ lỗi ký tự (CER) thấp khoảng 0.4% và tỷ lệ lỗi từ (WER) khoảng 0.8% cho đánh giá Seed-TTS.

5. **Nhanh:** Với công nghệ fish-tech, hệ số thời gian thực khoảng 1:5 trên laptop Nvidia RTX 4060 và 1:15 trên Nvidia RTX 4090.

6. **WebUI Inference:** Giao diện web thân thiện dựa trên Gradio, tương thích Chrome, Firefox, Edge và các trình duyệt khác.

7. **Giao diện GUI:** Có giao diện đồ họa PyQt6 hoạt động liền mạch với máy chủ API. Hỗ trợ Linux, Windows và macOS. [Xem GUI](https://github.com/AnyaCoder/fish-speech-gui).

8. **Dễ triển khai:** Thiết lập máy chủ suy luận dễ dàng với hỗ trợ gốc cho Linux, Windows (MacOS sắp có), giảm thiểu hao hụt tốc độ.

## **Truyền thông & Demo**

<div align="center">

### **Mạng xã hội**
<a href="https://x.com/FishAudio/status/1929915992299450398" target="_blank">
    <img src="https://img.shields.io/badge/𝕏-Latest_Demo-black?style=for-the-badge&logo=x&logoColor=white" alt="Latest Demo on X" />
</a>

### **Demo Tương tác**
<a href="https://fish.audio" target="_blank">
    <img src="https://img.shields.io/badge/Fish_Audio-Try_OpenAudio_S1-blue?style=for-the-badge" alt="Try OpenAudio S1" />
</a>
<a href="https://huggingface.co/spaces/fishaudio/openaudio-s1-mini" target="_blank">
    <img src="https://img.shields.io/badge/Hugging_Face-Try_S1_Mini-yellow?style=for-the-badge" alt="Try S1 Mini" />
</a>

### **Video trình diễn**

<a href="https://www.youtube.com/watch?v=SYuPvd7m06A" target="_blank">
    <img src="https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/assets/Thumbnail.jpg" alt="OpenAudio S1 Video" style="width: 50%;" />
</a>

### **Mẫu âm thanh**
<div style="margin: 20px 0;">
    <em> Các mẫu âm thanh chất lượng cao sẽ sớm được cập nhật, trình diễn khả năng TTS đa ngôn ngữ với nhiều trạng thái cảm xúc khác nhau.</em>
</div>

</div>

---

## Tài liệu

- [Xây dựng môi trường](https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/en/install.md)
- [Suy luận](https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/en/inference.md)

## Ghi nhận

- [VITS2 (daniilrobnikov)](https://github.com/daniilrobnikov/vits2)
- [Bert-VITS2](https://github.com/fishaudio/Bert-VITS2)
- [GPT VITS](https://github.com/innnky/gpt-vits)
- [MQTTS](https://github.com/b04901014/MQTTS)
- [GPT Fast](https://github.com/pytorch-labs/gpt-fast)
- [GPT-SoVITS](https://github.com/RVC-Boss/GPT-SoVITS)
- [Qwen3](https://github.com/QwenLM/Qwen3)

## Báo cáo kỹ thuật (V1.4)
```bibtex
@misc{fish-speech-v1.4,
      title={Fish-Speech: Leveraging Large Language Models for Advanced Multilingual Text-to-Speech Synthesis},
      author={Shijia Liao and Yuxuan Wang and Tianyu Li and Yifan Cheng and Ruoyi Zhang and Rongzhi Zhou and Yijin Xing},
      year={2024},
```bibtex
      eprint={2411.01156},
      archivePrefix={arXiv},
      primaryClass={cs.SD},
      url={https://arxiv.org/abs/2411.01156},
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---