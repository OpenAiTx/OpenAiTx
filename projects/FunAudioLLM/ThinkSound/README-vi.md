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
  Nếu bạn thấy dự án này hữu ích,<br>
  hãy cho một sao ⭐ trên GitHub để động viên chúng tôi!
</p>

---

## Sơ đồ thư mục của kho lưu trữ

Kho lưu trữ GitHub **ThinkSound** này chứa hai dự án liên quan trên các nhánh riêng biệt:

| Nhánh | Dự án | Tài liệu |
|-------|-------|----------|
| **`master`** | **ThinkSound** (NeurIPS 2025) — mô hình Any2Audio hợp nhất với flow matching được dẫn dắt bởi Chain-of-Thought (CoT) | File này: **`README.md`** |
| **`prismaudio`** | **PrismAudio** — công trình tiếp theo (ICLR 2026) về chuyển đổi video thành âm thanh với CoT-RL đa chiều | **`README.md`** trên nhánh [`prismaudio`](https://github.com/liuhuadai/ThinkSound/tree/prismaudio) |

Đối với **ThinkSound**, hãy sử dụng nhánh **`master`** (README này). Đối với **PrismAudio**, hãy chuyển sang nhánh **`prismaudio`** và làm theo **`README.md`** tại đó.

---

**ThinkSound** là khung hợp nhất Any2Audio với flow matching được dẫn dắt bởi Chain-of-Thought (CoT) reasoning.

Triển khai PyTorch cho tạo và chỉnh sửa âm thanh đa phương thức: tạo hoặc chỉnh sửa âm thanh từ video, văn bản và âm thanh, được hỗ trợ bởi suy luận từng bước từ MLLMs (Multimodal Large Language Models).

![Teaser](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 Tin tức
- **2026.03.24** &nbsp; 🔥 **PrismAudio** đã được phát hành trong cùng repo trên nhánh [`prismaudio`](https://github.com/liuhuadai/ThinkSound/tree/prismaudio) — xem **`README.md`** tại đó để thiết lập và tải mô hình.
- **2026.01.26** &nbsp; 🎉 PrismAudio đã được nhận vào **ICLR 2026 Main Conference** (code/tài liệu trên `prismaudio`).
- **2025.11.25** &nbsp; 🔥 [Demo PrismAudio trực tuyến](http://prismaudio-project.github.io/) đã hoạt động.
- **2025.11.25** &nbsp; 🔥 [Bài báo PrismAudio](https://arxiv.org/pdf/2511.18833) trên arXiv — CoT-RL đa chiều cho chuyển đổi video thành âm thanh.
- **2025.09.19** &nbsp; 🎉 **ThinkSound** đã được nhận vào **NeurIPS 2025 Main Conference**!
- **2025.09.01** &nbsp; Dataset AudioCoT của chúng tôi đã được mở nguồn và có trên [Hugging Face](https://huggingface.co/datasets/liuhuadai/AudioCoT)!
- **2025.07.17** &nbsp; 🧠 Đã bật finetuning: code huấn luyện và finetuning công khai, kèm hướng dẫn rõ ràng để bạn tùy chỉnh và mở rộng ThinkSound với dữ liệu riêng.
- **2025.07.15** &nbsp; 📦 Cài đặt và sử dụng đơn giản: các dependency trên PyPI giúp thiết lập đa nền tảng dễ dàng; script `.bat` cho Windows tự động tạo môi trường và chạy script.
- **2025.07.08** &nbsp;  🔧 Cập nhật lớn: mô hình nhẹ hơn, tối ưu hóa bộ nhớ và GPU, hỗ trợ tạo âm thanh tốc độ cao quy mô lớn!
- **2025.07.01** &nbsp; Demo trực tuyến trên [Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound) và [ModelScope](https://modelscope.cn/studios/iic/ThinkSound) cho trải nghiệm tương tác!
- **2025.07.01** &nbsp; Phát hành script suy luận và giao diện web; 
- **2025.06** &nbsp; [Bài báo ThinkSound](https://arxiv.org/pdf/2506.21448) đã lên arXiv!
- **2025.06** &nbsp; [Demo trực tuyến](http://thinksound-project.github.io/) đã hoạt động - hãy thử ngay!

---


<div align="center">

### Công trình tiếp theo: PrismAudio (cùng repo, nhánh `prismaudio`)
**PrismAudio** là phiên bản kế thừa của ThinkSound (ICLR 2026), được phát triển dưới tên mới nhưng vẫn được giữ trong kho lưu trữ này trên nhánh **`prismaudio`**. Hướng dẫn cài đặt, checkpoint, và trích dẫn có trong **[`README.md` trên nhánh đó](https://github.com/liuhuadai/ThinkSound/blob/prismaudio/README.md)**.

👉 [`git checkout prismaudio`](https://github.com/liuhuadai/ThinkSound/tree/prismaudio) hoặc mở nhánh đó trên GitHub.

</div>

---


## 🚀 Tính năng

- **Any2Audio**: Tạo âm thanh từ bất kỳ phương thức nào — video, văn bản, âm thanh, hoặc kết hợp chúng.
- **Video-to-Audio SOTA**: Đạt kết quả tiên tiến nhất trên nhiều bộ đánh giá V2A.
- **Lập luận dựa trên CoT**: Lập luận Chuỗi Suy Nghĩ cho tạo âm thanh có tính thành phần và kiểm soát thông qua MLLM.
- **Chỉnh sửa tập trung vào đối tượng tương tác**: Tinh chỉnh hoặc chỉnh sửa các sự kiện âm thanh cụ thể bằng cách nhấp vào đối tượng hình ảnh hoặc sử dụng hướng dẫn văn bản.
- **Khung hợp nhất**: Một mô hình nền tảng hỗ trợ tạo, chỉnh sửa và quy trình tương tác.

---

## ✨ Tổng quan phương pháp

ThinkSound phân tách quá trình tạo và chỉnh sửa âm thanh thành ba giai đoạn tương tác, tất cả đều được hướng dẫn bởi lập luận Chuỗi Suy Nghĩ dựa trên MLLM (CoT):

1. **Tạo Foley:** Sinh ra không gian âm thanh nền tảng, căn chỉnh ngữ nghĩa và thời gian từ video.
2. **Tinh chỉnh tập trung đối tượng:** Tinh chỉnh hoặc thêm âm thanh cho các đối tượng do người dùng chỉ định thông qua nhấp chuột hoặc vùng trong video.
3. **Chỉnh sửa âm thanh có mục tiêu:** Chỉnh sửa âm thanh được tạo bằng hướng dẫn ngôn ngữ tự nhiên cấp cao.

![Tổng quan ThinkSound](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- Một bộ dữ liệu chú thích CoT quy mô lớn (**AudioCoT**) được sử dụng để huấn luyện cả mô-đun lập luận và mô hình nền tảng âm thanh hợp nhất.
![Quy trình AudioCoT](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig2_dataset.png) -->

---

## ⚡ Bắt đầu nhanh

**Chuẩn bị môi trường:**

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


## 📄 Giấy phép

Dự án này được phát hành dưới Giấy phép Apache 2.0.

> **Lưu ý:**
> Mã nguồn, mô hình và tập dữ liệu chỉ **dành cho mục đích nghiên cứu và giáo dục**.
> **Không được phép sử dụng cho mục đích thương mại.**
> Để được cấp phép thương mại, vui lòng liên hệ với tác giả.

**📦 Thành phần bên thứ ba**

* **Stable Audio Open VAE** (bởi Stability AI):
  Kho lưu trữ này bao gồm một VAE được tinh chỉnh từ [Stable Audio Open](https://huggingface.co/stabilityai/stable-audio-open-1.0/), được cấp phép theo [Stability AI Community License](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/./third_party/LICENSE_StabilityAI.md).
  **Việc sử dụng thương mại và phân phối lại yêu cầu sự cho phép trước từ Stability AI.**

* 📘 **Tất cả mã nguồn và mô hình còn lại** được phát hành theo Giấy phép Apache 2.0.

---

## Lời cảm ơn

Xin chân thành cảm ơn:

* **stable-audio-tools** (bởi Stability AI):
Cảm ơn đã cung cấp một framework dễ sử dụng cho việc tạo âm thanh, cũng như module và trọng số VAE.
* **MMAudio**:
  Cho việc triển khai backbone MM-DiT trong lĩnh vực âm thanh.

---



## 📖 Trích dẫn

Nếu bạn thấy dự án của chúng tôi hữu ích cho nghiên cứu hoặc công việc của mình, vui lòng trích dẫn bài báo của chúng tôi:

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