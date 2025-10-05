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
  Nếu bạn thấy dự án này hữu ích,<br>
  hãy tặng một sao ⭐ trên GitHub để ủng hộ!
</p>

---

**ThinkSound** là một khung tạo Any2Audio thống nhất với phương pháp ghép luồng được hướng dẫn bởi lý luận Chuỗi-Suy-Nghĩ (CoT).

Triển khai PyTorch cho tạo và chỉnh sửa âm thanh đa phương thức: tạo hoặc chỉnh sửa âm thanh từ video, văn bản và âm thanh, được hỗ trợ bởi suy luận từng bước từ các Mô hình Ngôn ngữ Lớn Đa phương thức (MLLMs).

![Teaser](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 Tin tức
- **2025.09.19** &nbsp; 🎉 ThinkSound đã được chấp nhận tại **Hội nghị chính NeurIPS 2025**!
- **2025.09.01** &nbsp; 🔥 Bộ dữ liệu AudioCoT của chúng tôi hiện đã mã nguồn mở và có sẵn trên [Hugging Face](https://huggingface.co/datasets/liuhuadai/AudioCoT)!
- **2025.07.17** &nbsp; 🧠 Đã kích hoạt finetuning: mã huấn luyện và tinh chỉnh hiện đã công khai, kèm hướng dẫn sử dụng rõ ràng để bạn tùy chỉnh và mở rộng ThinkSound với dữ liệu của riêng mình.
- **2025.07.15** &nbsp; 📦 Cài đặt và sử dụng đơn giản: phụ thuộc đã có trên PyPI để thiết lập đa nền tảng dễ dàng; script Windows `.bat` tự động tạo môi trường và chạy script.
- **2025.07.08** &nbsp;  🔧 Cập nhật lớn: mô hình nhẹ hơn và tối ưu hóa bộ nhớ cùng GPU, hiện hỗ trợ tạo âm thanh hiệu suất cao với quy mô lớn!
- **2025.07.01** &nbsp; 🔥Demo trực tuyến trên [Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound) và [ModelScope](https://modelscope.cn/studios/iic/ThinkSound) cho trải nghiệm tương tác!
- **2025.07.01** &nbsp; 🔥Đã phát hành script suy luận và giao diện web;
- **2025.06** &nbsp; 🔥[Bài báo ThinkSound](https://arxiv.org/pdf/2506.21448) đã phát hành trên arXiv!
- **2025.06** &nbsp; 🔥[Demo trực tuyến](http://thinksound-project.github.io/) đã hoạt động - hãy thử ngay!

---


## 🚀 Tính năng

- **Any2Audio**: Tạo âm thanh từ bất kỳ phương thức nào — video, văn bản, âm thanh hoặc kết hợp của chúng.
- **Video-to-Audio SOTA**: Đạt kết quả hàng đầu trên nhiều bộ đánh giá V2A.
- **Suy luận dựa trên CoT**: Suy luận chuỗi tư duy cho tạo âm thanh có tính thành phần và kiểm soát qua MLLMs.
- **Chỉnh sửa tập trung vào đối tượng tương tác**: Tinh chỉnh hoặc chỉnh sửa sự kiện âm thanh cụ thể bằng cách nhấp vào đối tượng hình ảnh hoặc sử dụng hướng dẫn văn bản.
- **Khung hợp nhất**: Một mô hình nền tảng duy nhất hỗ trợ tạo, chỉnh sửa và quy trình tương tác.

---

## ✨ Tổng quan phương pháp

ThinkSound phân tách quá trình tạo và chỉnh sửa âm thanh thành ba giai đoạn tương tác, tất cả đều được hướng dẫn bởi suy luận Chuỗi Tư Duy (CoT) dựa trên MLLM:

1. **Tạo Foley:** Tạo nền âm thanh cơ bản, phù hợp ngữ nghĩa và thời gian từ video.
2. **Tinh chỉnh tập trung vào đối tượng:** Tinh chỉnh hoặc thêm âm thanh cho đối tượng do người dùng chỉ định thông qua nhấp chuột hoặc vùng trên video.
3. **Chỉnh sửa âm thanh mục tiêu:** Chỉnh sửa âm thanh đã tạo bằng hướng dẫn ngôn ngữ tự nhiên cấp cao.

![ThinkSound Overview](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- Một bộ dữ liệu chú thích CoT quy mô lớn (**AudioCoT**) được sử dụng để huấn luyện cả module suy luận và mô hình âm thanh nền tảng hợp nhất.
![AudioCoT Pipeline](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig2_dataset.png) -->

---

## ⚡ Bắt đầu nhanh

**Chuẩn bị môi trường:**
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
> ✅ **Mẹo cho Windows:**  
> Người dùng Windows chỉ cần chạy `setup_windows.bat` (hoặc nhấp đúp vào nó) để tự động tạo môi trường conda, cài đặt tất cả các phụ thuộc (bao gồm cả FFmpeg), và tải về mô hình đã huấn luyện — không cần thiết lập thủ công.  
> Hãy đảm bảo rằng `conda` và `git` đã được cài đặt và có trong PATH hệ thống của bạn trước khi chạy script.


### ▶️ Chạy Demo

#### **Linux/macOS**


```bash
chmod +x scripts/demo.sh
./scripts/demo.sh <path-to-your-demo-video> <title> <CoT description> [use-half]
```
#### **Windows**

Bạn có thể sử dụng tập lệnh `.bat` được cung cấp thay thế:


```bash
.\scripts\demo.bat <path-to-your-demo-video> <title> <CoT description> [use-half]
```
**Lưu ý:**

* `<path-to-your-demo-video>`: Đường dẫn đến một video duy nhất
* `[use-half]` (tùy chọn): Thêm use-half vào cuối để bật chức năng trích xuất đặc tả với độ chính xác nửa.

---

### 📦 Suy luận theo lô

#### **Linux/macOS**


```bash
chmod +x scripts/eval_batch.sh
./scripts/eval_batch.sh <video_path> <csv_path> <save_path (optional)> [use-half]
```
#### **Windows**

Sử dụng script `.bat` tương đương:


```bash
.\scripts\eval_batch.bat <video_path> <csv_path> <save_path (optional)> [use-half]
```
**Lưu ý:**

* `<video_path>`: Đường dẫn đến thư mục gốc chứa tất cả các video .mp4 cần xử lý (tất cả video phải có cùng độ dài).
* `<csv_path>`: Một tệp CSV chứa các lệnh văn bản cho mỗi video (xem `demo_test.csv` để biết định dạng).
* `<save_path>` (tùy chọn): Nơi lưu trữ tệp âm thanh được tạo ra. Mặc định là `results/features`.
* `[use-half]` (tùy chọn): Thêm use-half ở cuối để bật tính năng trích xuất đặc trưng với độ chính xác nửa.

---


### Sử Dụng Giao Diện Web

Để trải nghiệm tương tác, hãy khởi chạy giao diện web Gradio:


```bash
python app.py
```


## 🏋️ Huấn Luyện Mô Hình

Xem [`Training.md`](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/docs/Training.md)


---

## 📝 VIỆC CẦN LÀM & Kế Hoạch Tương Lai
* - [ ] Phát hành mô hình nền tảng mạnh mẽ hơn, bao phủ nhiều lĩnh vực để cung cấp trải nghiệm tạo foley hấp dẫn và sống động hơn
* - [ ] Thêm hỗ trợ cho các dạng dữ liệu và tác vụ hạ nguồn bổ sung
* - [ ] Phát hành các mô hình ở các quy mô khác nhau
* - [x] Mã nguồn mở bộ dữ liệu AudioCoT và quy trình tự động
* - [x] Phát hành các script huấn luyện cho các mô hình ThinkSound
* - [x] README hướng dẫn nhanh cho người mới dùng Windows
---


## 📄 Giấy Phép

Dự án này được phát hành theo Giấy phép Apache 2.0.

> **Lưu ý:**
> Mã nguồn, mô hình và bộ dữ liệu **chỉ dành cho mục đích nghiên cứu và giáo dục**.
> **Không được phép sử dụng cho mục đích thương mại.**
> Để xin giấy phép thương mại, vui lòng liên hệ tác giả.

**📦 Thành Phần Bên Thứ Ba**

* **Stable Audio Open VAE** (bởi Stability AI):
  Kho lưu trữ này bao gồm một VAE đã tinh chỉnh từ [Stable Audio Open](https://huggingface.co/stabilityai/stable-audio-open-1.0/), được cấp phép theo [Stability AI Community License](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/./third_party/LICENSE_StabilityAI.md).
  **Việc sử dụng thương mại và phân phối lại cần có sự cho phép trước của Stability AI.**

* 📘 **Tất cả mã nguồn và mô hình còn lại** được phát hành theo Giấy phép Apache 2.0.

---

## Lời cảm ơn

Xin cảm ơn đến:

* **stable-audio-tools** (bởi Stability AI):
Đã cung cấp một khung dễ sử dụng cho việc sinh âm thanh, cũng như module VAE và trọng số.
* **MMAudio**:
  Đã triển khai backbone MM-DiT trong lĩnh vực âm thanh.

---

## 📖 Trích dẫn

Nếu bạn thấy ThinkSound hữu ích trong nghiên cứu hoặc công việc của mình, vui lòng trích dẫn bài báo của chúng tôi:

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