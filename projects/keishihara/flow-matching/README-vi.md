
<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Flow Matching trong PyTorch

Kho lưu trữ này chứa một hiện thực đơn giản bằng PyTorch của bài báo [Flow Matching for Generative Modeling](https://arxiv.org/abs/2210.02747).

## Ví dụ Flow Matching 2D

Ảnh động bên dưới minh họa việc ánh xạ một phân phối Gaussian đơn đến phân phối dạng bàn cờ, với trường véc-tơ được trực quan hóa.

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/checkerboard/vector_field_and_samples_checkerboard.gif" height="400" />
</p>

Và đây là một ví dụ khác với tập dữ liệu moons.

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/moons/vector_field_and_samples_moons.gif" height="400" />
</p>

## Bắt đầu

Sao chép kho lưu trữ và thiết lập môi trường python.

```bash
git clone https://github.com/keishihara/flow-matching.git
cd flow-matching
```

Đảm bảo bạn đã cài đặt Python 3.12+.
Cài đặt `uv`:

```bash
curl -LsSf https://astral.sh/uv/install.sh | sh
```
Sau đó, thiết lập môi trường:


```bash
uv sync
```

## Conditional Flow Matching [Lipman+ 2023]

Đây là bản triển khai gốc của bài báo CFM [1]. Một số thành phần của mã nguồn được điều chỉnh từ [2] và [3].

### Bộ dữ liệu 2D Toy

Bạn có thể huấn luyện các mô hình CFM trên các bộ dữ liệu tổng hợp 2D như `checkerboard` và `moons`. Chỉ định tên bộ dữ liệu bằng tùy chọn `--dataset`. Tham số huấn luyện đã được định nghĩa sẵn trong script, và hình ảnh minh họa kết quả huấn luyện sẽ được lưu trong thư mục `outputs/`. Các checkpoint của mô hình không được đính kèm vì có thể dễ dàng tái tạo với các thiết lập mặc định.

```bash
uv run scripts/train_flow_matching_2d.py --dataset checkerboard
```

Các trường vectơ và các mẫu được tạo ra, giống như những mẫu được hiển thị dưới dạng GIF ở đầu README này, hiện có thể được tìm thấy trong thư mục `outputs/cfm/`.

### Bộ dữ liệu hình ảnh

Bạn cũng có thể huấn luyện các mô hình CFM theo điều kiện lớp trên các bộ dữ liệu phân loại hình ảnh phổ biến. Cả các mẫu đã tạo và các checkpoint của mô hình đều sẽ được lưu trữ trong thư mục `outputs/cfm`. Để xem danh sách chi tiết các tham số huấn luyện, hãy chạy `uv run scripts/train_flow_matching_on_image.py --help`.

Để huấn luyện CFM theo điều kiện lớp trên bộ dữ liệu MNIST, hãy chạy:

```bash
uv run scripts/train_flow_matching_on_image.py --do_train --dataset mnist
```

Sau khi huấn luyện, bạn có thể tạo các mẫu với:

```bash
uv run scripts/train_flow_matching_on_image.py --do_sample --dataset mnist
```

Bây giờ, bạn sẽ có thể nhìn thấy các mẫu đã được tạo ra trong thư mục `outputs/cfm/mnist/`.

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/mnist/trajectory.gif" height="400" />
</p>

## Rectified Flow [Liu+ 2023]

Đây là một bản triển khai của mô hình Reflow (cụ thể là 2-Rectified Flow) từ bài báo Rectified Flow [2].

### Dữ liệu tổng hợp 2D

Chúng tôi đã triển khai Reflow trên các bộ dữ liệu tổng hợp 2D, giống như CFM. Để huấn luyện reflow, bạn cần chỉ định checkpoint CFM đã được huấn luyện trước vì reflow là một mô hình chưng cất.

Ví dụ, để huấn luyện trên bộ dữ liệu `checkerboard` với checkpoint CFM đã được huấn luyện trước:

```bash
uv run scripts/train_reflow_2d.py --dataset checkerboard
```

Kết quả huấn luyện, bao gồm các hình ảnh trực quan hóa trường vector và các mẫu được tạo ra, được lưu trong thư mục `outputs/reflow/`.

### So sánh quá trình lấy mẫu giữa CFM và Reflow

Để so sánh CFM và Reflow trên các bộ dữ liệu 2d, hãy chạy:

```bash
uv run scripts/plot_comparison_2d.py --dataset checkerboard
```

Các ảnh GIF kết quả có thể được tìm thấy trong thư mục `outputs/comparisons/`. Dưới đây là ví dụ so sánh hai phương pháp trong tập dữ liệu `checkerboard`:

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/comparisons/cfm_reflow_checkerboard.gif" height="400" />
</p>

## Tài liệu tham khảo

- [1] Lipman, Yaron, et al. "Flow Matching for Generative Modeling." [arXiv:2210.02747](https://arxiv.org/abs/2210.02747)
- [2] Liu, Xingchao, et al. "Flow Straight and Fast: Learning to Generate and Transfer Data with Rectified Flow." [arXiv:2209.03003](https://arxiv.org/abs/2209.03003)
- [3] [facebookresearch/flow_matching](https://github.com/facebookresearch/flow_matching)
- [4] [atong01/conditional-flow-matching](https://github.com/atong01/conditional-flow-matching)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-19

---