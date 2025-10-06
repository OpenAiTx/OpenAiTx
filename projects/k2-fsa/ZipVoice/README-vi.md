
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

## Chuyển văn bản thành giọng nói nhanh và chất lượng cao với Flow Matching
</div>

## Tổng quan

ZipVoice là một loạt các mô hình TTS zero-shot nhanh và chất lượng cao dựa trên flow matching.

### 1. Đặc điểm chính

- Nhỏ gọn và nhanh: chỉ 123 triệu tham số.

- Nhân bản giọng nói chất lượng cao: hiệu suất hàng đầu về độ tương đồng, độ rõ ràng và tự nhiên của giọng nói.

- Đa ngôn ngữ: hỗ trợ tiếng Trung và tiếng Anh.

- Đa chế độ: hỗ trợ cả tạo giọng nói một người và đối thoại.

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
      <td>Mô hình cơ bản hỗ trợ TTS zero-shot cho cả tiếng Trung và tiếng Anh với giọng nói một người.</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2506.13053"><img src="https://img.shields.io/badge/arXiv-Paper-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice.github.io"><img src="https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Distill</td>
      <td>Phiên bản rút gọn của ZipVoice, tăng tốc độ với suy giảm hiệu năng tối thiểu.</td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog</td>
      <td>Mô hình tạo đối thoại dựa trên ZipVoice, có khả năng tạo hội thoại hai bên trên một kênh âm thanh.</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2507.09318"><img src="https://img.shields.io/badge/arXiv-Paper-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice-dialog.github.io"><img src="https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog-Stereo</td>
      <td>Biến thể stereo của ZipVoice-Dialog, cho phép tạo cuộc hội thoại hai kênh với mỗi người nói được gán vào một kênh riêng biệt.</td>
    </tr>
  </tbody>
</table>

## Tin tức

**2025/07/14**: **ZipVoice-Dialog** và **ZipVoice-Dialog-Stereo**, hai mô hình tạo hội thoại nói, đã được phát hành. [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice-dialog.github.io)

**2025/07/14**: Bộ dữ liệu **OpenDialog**, bộ dữ liệu hội thoại nói với thời lượng 6.8k giờ, đã được phát hành. Tải về tại [![hf](https://img.shields.io/badge/%F0%9F%A4%97%20HuggingFace-Dataset-yellow)](https://huggingface.co/datasets/k2-fsa/OpenDialog), [![ms](https://img.shields.io/badge/ModelScope-Dataset-blue?logo=data)](https://www.modelscope.cn/datasets/k2-fsa/OpenDialog). Xem chi tiết tại [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318).

**2025/06/16**: **ZipVoice** và **ZipVoice-Distill** đã được phát hành. [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2506.13053) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice.github.io)

## Cài đặt

### 1. Nhân bản kho lưu trữ ZipVoice

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


```bash
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
- `--model-name` có thể là `zipvoice` hoặc `zipvoice_distill`, lần lượt là các mô hình trước và sau khi chưng cất.
- Nếu `<>` hoặc `[]` xuất hiện trong văn bản, các chuỗi được bao quanh bởi chúng sẽ được xử lý như các token đặc biệt. `<>` biểu thị cho pinyin tiếng Trung và `[]` biểu thị cho các thẻ đặc biệt khác.

#### 1.2 Suy luận một danh sách các câu

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
- `prompt_transcription` là bản phiên âm của file wav hội thoại gợi ý, ví dụ, "[S1] Xin chào. [S2] Bạn khỏe không?"
- `prompt_wav` là đường dẫn đến file wav gợi ý.
- `text` là văn bản cần tổng hợp, ví dụ: "[S1] Tôi khỏe. [S2] Bạn tên gì? [S1] Tôi là Eric. [S2] Chào Eric."

(2) **Định dạng gợi ý tách riêng** nơi các tệp âm thanh và phiên âm của hai người nói tồn tại ở các tệp riêng biệt:

```
{wav_name}\t{spk1_prompt_transcription}\t{spk2_prompt_transcription}\t{spk1_prompt_wav}\t{spk2_prompt_wav}\t{text}
```
- `wav_name` là tên của file wav đầu ra.
- `spk1_prompt_transcription` là bản ghi âm lời nhắc của người nói thứ nhất, ví dụ: "Hello"
- `spk2_prompt_transcription` là bản ghi âm lời nhắc của người nói thứ hai, ví dụ: "How are you?"
- `spk1_prompt_wav` là đường dẫn tới file wav lời nhắc của người nói thứ nhất.
- `spk2_prompt_wav` là đường dẫn tới file wav lời nhắc của người nói thứ hai.
- `text` là văn bản cần tổng hợp, ví dụ: "[S1] I'm fine. [S2] What's your name? [S1] I'm Eric. [S2] Hi Eric."

### 3 Hướng dẫn sử dụng tốt hơn:

#### 3.1 Độ dài lời nhắc

Chúng tôi khuyến nghị sử dụng file wav lời nhắc ngắn (ví dụ, dưới 3 giây cho tạo tiếng nói một người, dưới 10 giây cho tạo tiếng nói hội thoại) để tăng tốc độ suy luận. Lời nhắc quá dài sẽ làm chậm quá trình suy luận và giảm chất lượng tiếng nói.

#### 3.2 Tối ưu hóa tốc độ

Nếu tốc độ suy luận không đạt yêu cầu, bạn có thể tăng tốc như sau:

- **Mô hình distill và giảm bước**: Đối với mô hình tạo tiếng nói một người, chúng tôi sử dụng mô hình `zipvoice` mặc định để có chất lượng tiếng nói tốt hơn. Nếu ưu tiên tốc độ, bạn có thể chuyển sang `zipvoice_distill` và giảm `--num-steps` xuống thấp nhất là `4` (mặc định là 8).

- **Tăng tốc CPU với đa luồng**: Khi chạy trên CPU, bạn có thể truyền tham số `--num-thread` (ví dụ, `--num-thread 4`) để tăng số lượng luồng nhằm tăng tốc độ. Mặc định là 1 luồng.

- **Tăng tốc CPU với ONNX**: Khi chạy trên CPU, bạn có thể sử dụng mô hình ONNX với `zipvoice.bin.infer_zipvoice_onnx` để tăng tốc (hiện chưa hỗ trợ ONNX cho mô hình tạo hội thoại). Để tăng tốc hơn nữa, bạn có thể đặt `--onnx-int8 True` để sử dụng mô hình ONNX được lượng tử hóa INT8. Lưu ý rằng mô hình lượng tử hóa sẽ làm giảm chất lượng tiếng nói ở một mức độ nhất định. **Không sử dụng ONNX trên GPU**, vì nó chậm hơn PyTorch trên GPU.

#### 3.3 Kiểm soát bộ nhớ

Văn bản đầu vào sẽ được chia thành từng đoạn dựa trên dấu câu (cho tạo tiếng nói một người) hoặc ký hiệu chuyển người nói (cho tạo tiếng nói hội thoại). Sau đó, các đoạn văn bản này sẽ được xử lý theo lô. Do đó, mô hình có thể xử lý văn bản dài tùy ý với mức sử dụng bộ nhớ gần như không đổi. Bạn có thể kiểm soát bộ nhớ bằng cách điều chỉnh tham số `--max-duration`.

#### 3.4 Đánh giá "raw"

Theo mặc định, chúng tôi tiền xử lý các đầu vào (file wav lời nhắc, bản ghi lời nhắc, và văn bản) để tối ưu hóa suy luận và nâng cao hiệu năng. Nếu bạn muốn đánh giá hiệu năng "raw" của mô hình với các đầu vào chính xác được cung cấp (ví dụ, để tái tạo kết quả trong bài báo của chúng tôi), bạn có thể truyền `--raw-evaluation True`.

#### 3.5 Văn bản ngắn

Khi tạo tiếng nói cho các văn bản rất ngắn (ví dụ, một hoặc hai từ), tiếng nói tạo ra đôi khi có thể bỏ sót một số phát âm. Để khắc phục vấn đề này, bạn có thể truyền `--speed 0.3` (trong đó 0.3 là giá trị có thể điều chỉnh) để kéo dài thời lượng tiếng nói tạo ra.

#### 3.6 Sửa lỗi phát âm ký tự đa âm tiếng Trung

Chúng tôi sử dụng [pypinyin](https://github.com/mozillazg/python-pinyin) để chuyển đổi ký tự tiếng Trung sang pinyin. Tuy nhiên, đôi khi nó có thể phát âm sai **ký tự đa âm** (多音字).


Để chỉnh sửa thủ công các lỗi phát âm này, hãy đặt **pinyin đã chỉnh sửa** trong dấu ngoặc nhọn `< >` và bao gồm **dấu thanh**.

**Ví dụ:**

- Văn bản gốc: `这把剑长三十公分`
- Sửa lại pinyin của `长`:  `这把剑<chang2>三十公分`

> **Lưu ý:** Nếu bạn muốn gán nhiều pinyin thủ công, hãy đặt mỗi pinyin trong dấu `<>`, ví dụ: `这把<jian4><chang2><san1>十公分`

#### 3.7 Loại bỏ khoảng lặng dài trong tiếng nói được tạo ra

Mô hình sẽ tự động xác định vị trí và độ dài của khoảng lặng trong tiếng nói được tạo ra. Đôi khi có khoảng lặng dài ở giữa đoạn nói. Nếu bạn không muốn điều này, bạn có thể thêm tùy chọn `--remove-long-sil` để loại bỏ khoảng lặng dài ở giữa đoạn nói (khoảng lặng ở hai đầu sẽ được loại bỏ mặc định).

#### 3.8 Tải mô hình

Nếu bạn gặp khó khăn khi kết nối tới HuggingFace để tải các mô hình đã huấn luyện sẵn, hãy thử chuyển endpoint sang trang mirror: `export HF_ENDPOINT=https://hf-mirror.com`.

## Huấn luyện mô hình của riêng bạn

Xem thư mục [egs](egs) để biết ví dụ về huấn luyện, tinh chỉnh và đánh giá.

## Triển khai bằng C++

Xem [sherpa-onnx](https://github.com/k2-fsa/sherpa-onnx/pull/2487#issuecomment-3227884498) để biết giải pháp triển khai bằng C++ trên CPU.

## Thảo luận & Trao đổi

Bạn có thể thảo luận trực tiếp trên [Github Issues](https://github.com/k2-fsa/ZipVoice/issues).

Bạn cũng có thể quét mã QR để tham gia nhóm wechat hoặc theo dõi tài khoản chính thức của chúng tôi trên wechat.

| Nhóm Wechat | Tài khoản chính thức Wechat |
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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-06

---