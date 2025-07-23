<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<div align="center">

# ZipVoice⚡

## Chuyển văn bản thành giọng nói Zero-Shot nhanh và chất lượng cao với Flow Matching
</div>

## Tổng quan

ZipVoice là một loạt các mô hình TTS zero-shot nhanh và chất lượng cao dựa trên flow matching.

### 1. Đặc điểm nổi bật

- Nhỏ gọn và nhanh: chỉ 123 triệu tham số.

- Nhái giọng chất lượng cao: hiệu suất hàng đầu về độ tương đồng với người nói, độ rõ ràng và tự nhiên.

- Đa ngôn ngữ: hỗ trợ tiếng Trung và tiếng Anh.

- Đa chế độ: hỗ trợ cả tạo giọng nói đơn và hội thoại.

### 2. Các biến thể mô hình

<table>
  <thead>
    <tr>
      <th>Tên mô hình</th>
      <th>Mô tả</th>
      <th>Bài báo</th>
      <th>Demo</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>ZipVoice</td>
      <td>Mô hình cơ bản hỗ trợ TTS zero-shot cho một người nói bằng cả tiếng Trung và tiếng Anh.</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2506.13053"><img src="https://img.shields.io/badge/arXiv-Paper-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice.github.io"><img src="https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Distill</td>
      <td>Phiên bản rút gọn của ZipVoice, tăng tốc độ mà chỉ giảm hiệu suất tối thiểu.</td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog</td>
      <td>Mô hình tạo hội thoại dựa trên ZipVoice, có khả năng tạo hội thoại hai bên trên một kênh đơn.</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2507.09318"><img src="https://img.shields.io/badge/arXiv-Paper-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice-dialog.github.io"><img src="https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog-Stereo</td>
      <td>Biến thể stereo của ZipVoice-Dialog, cho phép tạo hội thoại hai kênh với mỗi người nói trên một kênh riêng biệt.</td>
    </tr>
  </tbody>
</table>

## Tin tức

**2025/07/14**: **ZipVoice-Dialog** và **ZipVoice-Dialog-Stereo**, hai mô hình tạo hội thoại bằng giọng nói, đã được phát hành. [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice-dialog.github.io)

**2025/07/14**: Bộ dữ liệu **OpenDialog**, một bộ dữ liệu hội thoại nói dài 6.8k giờ, đã được phát hành. Tải tại [![hf](https://img.shields.io/badge/%F0%9F%A4%97%20HuggingFace-Dataset-yellow)](https://huggingface.co/datasets/k2-fsa/OpenDialog), [![ms](https://img.shields.io/badge/ModelScope-Dataset-blue?logo=data)](https://www.modelscope.cn/datasets/k2-fsa/OpenDialog). Xem chi tiết tại [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318).

**2025/06/16**: **ZipVoice** và **ZipVoice-Distill** đã được phát hành. [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2506.13053) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice.github.io)

## Cài đặt

### 1. Sao chép kho lưu trữ ZipVoice


```bash
git clone https://github.com/k2-fsa/ZipVoice.git
```
### 2. (Tùy chọn) Tạo một môi trường ảo Python


```bash
python3 -m venv zipvoice
source zipvoice/bin/activate
```
### 3. Cài đặt các gói cần thiết


```bash
pip install -r requirements.txt
```
### 4. Cài đặt k2 để huấn luyện hoặc suy luận hiệu quả

**k2 là cần thiết cho việc huấn luyện** và có thể tăng tốc quá trình suy luận. Tuy nhiên, bạn vẫn có thể sử dụng chế độ suy luận của ZipVoice mà không cần cài đặt k2.

> **Lưu ý:** Đảm bảo cài đặt phiên bản k2 phù hợp với phiên bản PyTorch và CUDA của bạn. Ví dụ, nếu bạn đang sử dụng pytorch 2.5.1 và CUDA 12.1, bạn có thể cài đặt k2 như sau:


```bash
pip install k2==1.24.4.dev20250208+cuda12.1.torch2.5.1 -f https://k2-fsa.github.io/k2/cuda.html
```
Vui lòng tham khảo https://k2-fsa.org/get-started/k2/ để biết chi tiết.
Người dùng tại Trung Quốc đại lục có thể tham khảo https://k2-fsa.org/zh-CN/get-started/k2/.

- Để kiểm tra cài đặt k2:


```
python3 -c "import k2; print(k2.__file__)"
```
## Sử dụng

### 1. Tạo giọng nói một người nói

Để tạo giọng nói một người nói với các mô hình ZipVoice hoặc ZipVoice-Distill đã được huấn luyện trước của chúng tôi, hãy sử dụng các lệnh sau (Các mô hình cần thiết sẽ được tải xuống từ HuggingFace):

#### 1.1 Suy luận một câu đơn lẻ


```bash
python3 -m zipvoice.bin.infer_zipvoice \
    --model-name zipvoice \
    --prompt-wav prompt.wav \
    --prompt-text "I am the transcription of the prompt wav." \
    --text "I am the text to be synthesized." \
    --res-wav-path result.wav
```
- `--model-name` có thể là `zipvoice` hoặc `zipvoice_distill`, lần lượt là các mô hình trước và sau khi distillation.
- Nếu xuất hiện `<>` hoặc `[]` trong văn bản, các chuỗi được bao quanh bởi chúng sẽ được xử lý như các token đặc biệt. `<>` biểu thị pinyin tiếng Trung và `[]` biểu thị các thẻ đặc biệt khác.
- Có thể chạy các mô hình ONNX trên CPU nhanh hơn với `zipvoice.bin.infer_zipvoice_onnx`.

> **Lưu ý:** Nếu bạn gặp khó khăn khi kết nối với HuggingFace, hãy thử:
> ```bash
> export HF_ENDPOINT=https://hf-mirror.com
> ```

#### 1.2 Suy luận cho danh sách các câu


```bash
python3 -m zipvoice.bin.infer_zipvoice \
    --model-name zipvoice \
    --test-list test.tsv \
    --res-dir results
```
- Mỗi dòng của `test.tsv` có định dạng `{wav_name}\t{prompt_transcription}\t{prompt_wav}\t{text}`.

### 2. Tạo sinh lời thoại

#### 2.1 Lệnh suy luận

Để tạo sinh các cuộc hội thoại hai người nói với các mô hình ZipVoice-Dialogue hoặc ZipVoice-Dialogue-Stereo đã được huấn luyện trước của chúng tôi, hãy sử dụng các lệnh sau (Các mô hình cần thiết sẽ được tải xuống từ HuggingFace):


```bash
python3 -m zipvoice.bin.infer_zipvoice_dialog \
    --model-name "zipvoice_dialog" \
    --test-list test.tsv \
    --res-dir results
```
- `--model-name` có thể là `zipvoice_dialog` hoặc `zipvoice_dialog_stereo`,
    lần lượt tạo ra các đoạn hội thoại mono và stereo.

#### 2.2 Định dạng đầu vào

Mỗi dòng của `test.tsv` sẽ thuộc một trong các định dạng sau:

(1) **Định dạng prompt gộp** trong đó âm thanh và bản ghi lời thoại của hai người nói được gộp vào một tệp wav prompt:

```
{wav_name}\t{prompt_transcription}\t{prompt_wav}\t{text}
```
- `wav_name` là tên của file wav đầu ra.
- `prompt_transcription` là bản phiên âm của file wav lời thoại gợi ý, ví dụ, "[S1] Xin chào. [S2] Bạn khỏe không?"
- `prompt_wav` là đường dẫn tới file wav gợi ý.
- `text` là văn bản cần tổng hợp, ví dụ, "[S1] Tôi khỏe. [S2] Tên bạn là gì?"

(2) **Định dạng gợi ý tách riêng** nơi các tệp âm thanh và phiên âm của hai người nói tồn tại ở các tệp riêng biệt:


```
{wav_name}\t{spk1_prompt_transcription}\t{spk2_prompt_transcription}\t{spk1_prompt_wav}\t{spk2_prompt_wav}\t{text}'
```
- `wav_name` là tên của tệp wav đầu ra.
- `spk1_prompt_transcription` là bản phiên âm của tệp wav nhắc của người nói thứ nhất, ví dụ, "Hello"
- `spk2_prompt_transcription` là bản phiên âm của tệp wav nhắc của người nói thứ hai, ví dụ, "How are you?"
- `spk1_prompt_wav` là đường dẫn tới tệp wav nhắc của người nói thứ nhất.
- `spk2_prompt_wav` là đường dẫn tới tệp wav nhắc của người nói thứ hai.
- `text` là văn bản cần tổng hợp, ví dụ: "[S1] I'm fine. [S2] What's your name?"

### 3. Các tính năng khác

#### 3.1 Sửa lỗi phát âm sai các ký tự đa âm trong tiếng Trung

Chúng tôi sử dụng [pypinyin](https://github.com/mozillazg/python-pinyin) để chuyển đổi ký tự tiếng Trung sang pinyin. Tuy nhiên, đôi khi nó có thể phát âm sai các **ký tự đa âm** (多音字).

Để sửa thủ công các lỗi phát âm này, hãy đặt **pinyin đã chỉnh sửa** trong dấu ngoặc nhọn `< >` và bao gồm cả **dấu thanh**.

**Ví dụ:**

- Văn bản gốc: `这把剑长三十公分`
- Sửa pinyin của `长`:  `这把剑<chang2>三十公分`

> **Lưu ý:** Nếu bạn muốn gán nhiều pinyin thủ công, hãy đặt mỗi pinyin trong `<>`, ví dụ: `这把<jian4><chang2><san1>十公分`

## Huấn luyện mô hình của riêng bạn

Xem thư mục [egs](egs) để biết các ví dụ về huấn luyện, tinh chỉnh và đánh giá.

## Thảo luận & Giao tiếp

Bạn có thể thảo luận trực tiếp trên [Github Issues](https://github.com/k2-fsa/ZipVoice/issues).

Bạn cũng có thể quét mã QR để tham gia nhóm wechat của chúng tôi hoặc theo dõi tài khoản wechat chính thức.

| Nhóm Wechat | Tài khoản Wechat chính thức |
| ------------ | -------------------------- |
|![wechat](https://k2-fsa.org/zh-CN/assets/pic/wechat_group.jpg) |![wechat](https://k2-fsa.org/zh-CN/assets/pic/wechat_account.jpg) |

## Trích dẫn


```bibtex
@article{zhu2025zipvoice,
      title={ZipVoice: Fast and High-Quality Zero-Shot Text-to-Speech with Flow Matching},
      author={Zhu, Han and Kang, Wei and Yao, Zengwei and Guo, Liyong and Kuang, Fangjun and Li, Zhaoqing and Zhuang, Weiji and Lin, Long and Povey, Daniel},
      journal={arXiv preprint arXiv:2506.13053},
      year={2025}
}

@article{zhu2025zipvoicedialog,
      title={ZipVoice-Dialog: Non-Autoregressive Spoken Dialogue Generation with Flow Matching},
      author={Zhu, Han and Kang, Wei and Guo, Liyong and Yao, Zengwei and Kuang, Fangjun and Zhuang, Weiji and Li, Zhaoqing and Han, Zhifeng and Zhang, Dong and Zhang, Xin and Song, Xingchen and Lin, Long and Povey, Daniel},
      journal={arXiv preprint arXiv:2507.09318},
      year={2025}
}
```




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-22

---