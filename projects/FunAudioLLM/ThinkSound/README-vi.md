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
  Nếu bạn thấy dự án này hữu ích,<br>
  một ngôi sao ⭐ trên GitHub sẽ được rất trân trọng!
</p>

---

**ThinkSound** là một khuôn khổ tạo âm thanh Any2Audio hợp nhất với phương pháp khớp luồng được hướng dẫn bởi suy luận Chuỗi Suy Nghĩ (CoT).

Cài đặt PyTorch cho tạo và chỉnh sửa âm thanh đa phương tiện: tạo hoặc chỉnh sửa âm thanh từ video, văn bản và âm thanh, được thúc đẩy bởi suy luận từng bước từ các Mô hình Ngôn ngữ Lớn Đa phương tiện (MLLMs).

![Teaser](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 Tin tức
- **2025.07.15** &nbsp; 📦 Đơn giản hóa cài đặt và sử dụng: các phụ thuộc trên PyPI giúp thiết lập đa nền tảng dễ dàng; script `.bat` cho Windows tự động tạo môi trường và chạy lệnh.
- **2025.07.08** &nbsp;  🔧 Cập nhật lớn: mô hình nhẹ hơn, tối ưu hóa bộ nhớ và GPU, giờ hỗ trợ tạo âm thanh với thông lượng cao quy mô lớn!
- **2025.07.01** &nbsp; 🔥Trình diễn trực tuyến tại [Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound) và [ModelScope](https://modelscope.cn/studios/iic/ThinkSound) cho trải nghiệm tương tác!
- **2025.07.01** &nbsp; 🔥Phát hành script suy luận và giao diện web;
- **2025.06** &nbsp; 🔥[Bài báo ThinkSound](https://arxiv.org/pdf/2506.21448) đã phát hành trên arXiv!
- **2025.06** &nbsp; 🔥[Demo trực tuyến](http://thinksound-project.github.io/) đã lên sóng - thử ngay!

---


## 🚀 Tính năng

- **Any2Audio**: Tạo âm thanh từ bất kỳ phương thức nào — video, văn bản, âm thanh hoặc kết hợp chúng.
- **Video-to-Audio SOTA**: Đạt kết quả tiên tiến trên nhiều bộ chuẩn V2A.
- **Suy luận CoT-Driven**: Suy luận Chuỗi Suy Nghĩ cho tạo âm thanh có tính thành phần và kiểm soát, thông qua MLLMs.
- **Chỉnh sửa tập trung vào đối tượng có tính tương tác**: Tinh chỉnh hoặc chỉnh sửa sự kiện âm thanh cụ thể bằng cách nhấp vào đối tượng hình ảnh hoặc sử dụng hướng dẫn văn bản.
- **Khuôn khổ hợp nhất**: Một mô hình nền tảng duy nhất hỗ trợ tạo, chỉnh sửa và luồng công việc tương tác.

---

## ✨ Tổng quan phương pháp

ThinkSound phân tách quá trình tạo và chỉnh sửa âm thanh thành ba giai đoạn tương tác, tất cả đều được dẫn dắt bởi suy luận Chuỗi Suy Nghĩ (CoT) dựa trên MLLM:

1. **Tạo Foley:** Tạo cảnh âm thanh nền tảng, căn chỉnh ngữ nghĩa và thời gian từ video.
2. **Tinh chỉnh tập trung vào đối tượng:** Tinh chỉnh hoặc thêm âm thanh cho đối tượng do người dùng chỉ định thông qua nhấp chuột hoặc vùng trên video.
3. **Chỉnh sửa âm thanh mục tiêu:** Sửa đổi âm thanh đã tạo bằng hướng dẫn ngôn ngữ tự nhiên cấp cao.

![ThinkSound Overview](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- Bộ dữ liệu chú thích CoT quy mô lớn (**AudioCoT**) được sử dụng để huấn luyện cả mô-đun suy luận và mô hình nền tảng âm thanh hợp nhất.
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
---

## 📝 VIỆC CẦN LÀM & Kế Hoạch Tương Lai
* - [ ] Phát hành mã huấn luyện cho các mô hình ThinkSound (Dự kiến trước 20/07/2025)
* - [ ] Mã nguồn mở bộ dữ liệu AudioCoT và quy trình tự động (Dự kiến trước 23/07/2025)
* - [ ] Cung cấp hình ảnh môi trường sẵn sàng sử dụng (Dự kiến trước 23/07/2025)
* - [ ] Phát hành mô hình nền tảng mạnh mẽ hơn bao phủ nhiều lĩnh vực để tạo hiệu ứng âm thanh sống động và hấp dẫn hơn (Dự kiến cuối tháng 8 năm 2025)
* - [ ] Thêm hỗ trợ cho nhiều kiểu dữ liệu và tác vụ hạ nguồn hơn (Dự kiến trước cuối tháng 7 năm 2025)
* - [ ] Phát hành các mô hình với nhiều quy mô khác nhau (Dự kiến trước cuối tháng 7 năm 2025)
* - [x] README khởi động nhanh thân thiện với người mới dùng Windows
---


## 📄 Giấy Phép

Dự án này được phát hành theo Giấy phép Apache 2.0.

> **Lưu ý:**
> Mã nguồn, mô hình và bộ dữ liệu chỉ dùng **cho mục đích nghiên cứu và giáo dục**.
> **Không được phép sử dụng cho mục đích thương mại.**
> Để xin giấy phép thương mại, vui lòng liên hệ tác giả.

**📦 Thành Phần Bên Thứ Ba**

* **Stable Audio Open VAE** (bởi Stability AI):
  Kho lưu trữ này bao gồm một VAE được tinh chỉnh từ [Stable Audio Open](https://huggingface.co/stabilityai/stable-audio-open-1.0/), được cấp phép theo [Stability AI Community License](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/./third_party/LICENSE_StabilityAI.md).
  **Việc sử dụng và phân phối thương mại yêu cầu sự cho phép trước từ Stability AI.**

* 📘 **Toàn bộ mã nguồn và mô hình khác** được phát hành theo Giấy phép Apache 2.0.

---

## Lời Cảm Ơn

Xin chân thành cảm ơn:

* **stable-audio-tools** (bởi Stability AI):
Đã cung cấp một framework dễ sử dụng cho việc sinh âm thanh, cũng như module VAE và trọng số.
* **MMAudio**:
  Đã triển khai backbone MM-DiT trong lĩnh vực âm thanh.

---

## 📖 Trích Dẫn

Nếu bạn thấy ThinkSound hữu ích cho nghiên cứu hoặc công việc của mình, vui lòng trích dẫn bài báo của chúng tôi:


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

## 📬 Liên hệ

✨ Vui lòng [mở một issue](https://github.com/liuhuadai/ThinkSound/issues) hoặc liên hệ với chúng tôi qua email ([liuhuadai@zju.edu.cn](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/mailto:liuhuadai@zju.edu.cn)) nếu bạn có bất kỳ câu hỏi hoặc góp ý nào!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-16

---