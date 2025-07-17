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
  một ngôi sao ⭐ trên GitHub sẽ được đánh giá rất cao!
</p>

---

**ThinkSound** là một khung tạo Any2Audio hợp nhất với phương pháp flow matching được hướng dẫn bởi lý luận Chuỗi Tư Duy (Chain-of-Thought - CoT).

Cài đặt PyTorch cho tạo và chỉnh sửa âm thanh đa phương thức: tạo hoặc chỉnh sửa âm thanh từ video, văn bản và âm thanh, được hỗ trợ bởi suy luận từng bước từ các Mô hình Ngôn ngữ Lớn Đa phương thức (MLLMs).

![Teaser](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 Tin tức
- **2025.07.17** &nbsp; 🧠 Đã bật finetuning: mã huấn luyện và tinh chỉnh hiện đã được công khai, kèm hướng dẫn sử dụng rõ ràng giúp bạn tùy chỉnh và mở rộng ThinkSound với dữ liệu của riêng bạn.
- **2025.07.15** &nbsp; 📦 Đơn giản hóa cài đặt và sử dụng: các phụ thuộc đã có trên PyPI cho việc thiết lập đa nền tảng dễ dàng; script Windows `.bat` tự động tạo môi trường và chạy mã.
- **2025.07.08** &nbsp;  🔧 Cập nhật lớn: nhẹ hóa mô hình và tối ưu hóa sử dụng bộ nhớ, GPU, hiện hỗ trợ tạo âm thanh tốc độ cao trên quy mô lớn!
- **2025.07.01** &nbsp; 🔥Demo trực tuyến tại [Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound) và [ModelScope](https://modelscope.cn/studios/iic/ThinkSound) cho trải nghiệm tương tác!
- **2025.07.01** &nbsp; 🔥Phát hành script suy luận và giao diện web; 
- **2025.06** &nbsp; 🔥[Bài báo ThinkSound](https://arxiv.org/pdf/2506.21448) đã phát hành trên arXiv!
- **2025.06** &nbsp; 🔥[Demo trực tuyến](http://thinksound-project.github.io/) đã hoạt động - thử ngay!

---


## 🚀 Tính năng

- **Any2Audio**: Tạo âm thanh từ bất kỳ phương thức nào — video, văn bản, âm thanh, hoặc kết hợp chúng.
- **Video-to-Audio SOTA**: Đạt kết quả tối tân trên nhiều bộ kiểm thử V2A.
- **Suy luận CoT**: Chuỗi Tư Duy cho tạo âm thanh có tính cấu thành và kiểm soát nhờ MLLMs.
- **Chỉnh sửa tập trung đối tượng tương tác**: Tinh chỉnh hoặc chỉnh sửa các sự kiện âm thanh cụ thể bằng cách nhấp vào đối tượng trong hình ảnh hoặc sử dụng hướng dẫn văn bản.
- **Khung hợp nhất**: Một mô hình nền tảng duy nhất hỗ trợ tạo, chỉnh sửa và quy trình làm việc tương tác.

---

## ✨ Tổng quan phương pháp

ThinkSound phân rã quá trình tạo và chỉnh sửa âm thanh thành ba giai đoạn tương tác, tất cả đều được dẫn dắt bởi lý luận Chuỗi Tư Duy (CoT) dựa trên MLLM:

1. **Tạo Foley:** Tạo nền âm thanh cơ bản, phù hợp về ngữ nghĩa và thời gian từ video.
2. **Tinh chỉnh tập trung đối tượng:** Tinh chỉnh hoặc thêm âm thanh cho các đối tượng do người dùng chỉ định thông qua nhấp chuột hoặc vùng chọn trên video.
3. **Chỉnh sửa âm thanh mục tiêu:** Chỉnh sửa âm thanh đã tạo bằng hướng dẫn ngôn ngữ tự nhiên cấp cao.

![ThinkSound Overview](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- Một bộ dữ liệu chú thích CoT quy mô lớn (**AudioCoT**) được sử dụng để huấn luyện cả module suy luận và mô hình nền tảng âm thanh hợp nhất.
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
## 🏋️ Huấn luyện Mô hình

Xem [`Training.md`](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/docs/Training.md)


---

## 📝 KẾ HOẠCH & Dự định Tương lai
* - [ ] Mã nguồn mở bộ dữ liệu AudioCoT và quy trình tự động hóa (Dự kiến trước 23/07/2025)
* - [ ] Phát hành một mô hình nền tảng mạnh mẽ hơn bao phủ nhiều lĩnh vực để mang lại trải nghiệm sáng tạo foley hấp dẫn và sống động hơn (Dự kiến trước cuối tháng 8/2025)
* - [ ] Bổ sung hỗ trợ cho các dạng dữ liệu và nhiệm vụ đầu ra khác (Dự kiến trước cuối tháng 7/2025)
* - [ ] Phát hành mô hình ở nhiều quy mô khác nhau (Dự kiến trước cuối tháng 7/2025)
* - [x] Phát hành mã huấn luyện cho các mô hình ThinkSound
* - [x] README hướng dẫn nhanh cho người mới bắt đầu trên Windows
---


## 📄 Giấy phép

Dự án này được phát hành theo Giấy phép Apache 2.0.

> **Lưu ý:**
> Mã nguồn, mô hình và bộ dữ liệu **chỉ dành cho mục đích nghiên cứu và giáo dục**.
> **KHÔNG được phép sử dụng cho mục đích thương mại.**
> Để cấp phép thương mại, vui lòng liên hệ tác giả.

**📦 Thành phần bên thứ ba**

* **Stable Audio Open VAE** (bởi Stability AI):
  Kho lưu trữ này bao gồm một mô hình VAE được tinh chỉnh từ [Stable Audio Open](https://huggingface.co/stabilityai/stable-audio-open-1.0/), được cấp phép theo [Stability AI Community License](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/./third_party/LICENSE_StabilityAI.md).
  **Việc sử dụng cho mục đích thương mại và phân phối lại yêu cầu sự cho phép trước của Stability AI.**

* 📘 **Tất cả các mã nguồn và mô hình khác** được phát hành theo Giấy phép Apache 2.0.

---

## Lời cảm ơn

Xin cảm ơn:

* **stable-audio-tools** (bởi Stability AI):
Đã cung cấp một framework dễ sử dụng cho việc tạo sinh âm thanh, cũng như mô-đun VAE và trọng số.
* **MMAudio**:
  Đã triển khai backbone MM-DiT trong lĩnh vực âm thanh.

---

## 📖 Trích dẫn

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

✨ Hãy thoải mái [mở một issue](https://github.com/liuhuadai/ThinkSound/issues) hoặc liên hệ với chúng tôi qua email ([liuhuadai@zju.edu.cn](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/mailto:liuhuadai@zju.edu.cn)) nếu bạn có bất kỳ câu hỏi hoặc đề xuất nào!


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-17

---