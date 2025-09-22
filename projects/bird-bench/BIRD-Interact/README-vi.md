
<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=it">Itapano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>

</div>

# BIRD-INTERACT 1.0 <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/hku-logo.jpg" alt="HKU Logo" width="50" style="vertical-align:middle;margin-left:10px;"> <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/google-cloud-logo.png" alt="Google Cloud Logo" width="50" style="vertical-align:middle;margin-left:10px;">

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/bird_interact.png" 
       style="width: 30%; min-width: 100px; display: block; margin: auto; border-radius: 15px !important;">
</p>


<div style="display: flex; justify-content: center; align-items: center; gap: 10px;">
  <a href="https://creativecommons.org/licenses/by-sa/4.0/deed.en">
    <img src="https://img.shields.io/badge/License-CC%20By%20SA%204.0-orange.svg" alt="License">
  </a>
  <a href="https://bird-interact.github.io/">
    <img src="https://img.shields.io/badge/Leaderboard-2025-28a745.svg" alt="Leaderboard">
  </a>
  <a href="https://huggingface.co/datasets/birdsql/bird-interact-lite/tree/main">
    <img src="https://img.shields.io/badge/Dataset-HuggingFace-FFD21E.svg" alt="HuggingFace">
  </a>
  <a href="https://www.python.org/downloads/release/python-310/">
    <img src="https://img.shields.io/badge/Python-3.10+-teal.svg" alt="Python">
  </a>
  <a href="https://pypi.org/project/openai/">
    <img src="https://img.shields.io/badge/OpenAI-1.40+-beige.svg" alt="OpenAI">
  </a>
</div>

## ⚠️ Thông báo  
Xin lưu ý rằng trước khi quá trình đánh giá của bạn bắt đầu, khi Docker tải các cơ sở dữ liệu, đôi khi có thể xảy ra lỗi do sự không nhất quán của môi trường (những lỗi này sẽ không kết thúc quá trình nhưng sẽ xuất hiện trong nhật ký Docker). Do đó, một số cơ sở dữ liệu có thể không được tải đúng cách, dẫn đến các cơ sở dữ liệu rỗng. Điều này sẽ làm cho kết quả đánh giá thấp bất thường.  
👉 Vì vậy, chúng tôi đặc biệt khuyến nghị kiểm tra nhật ký Docker để phát hiện bất kỳ lỗi nào **trước khi chạy đánh giá** và xác minh rằng tất cả cơ sở dữ liệu đã được tải thành công.

## 📰 Tin tức

- [2025-08-26] 🚀 Chúng tôi vui mừng thông báo phát hành bộ **[BIRD-Interact-Full (600)](https://huggingface.co/datasets/birdsql/bird-interact-full)**!  
Đây là một bộ rất khó — các LLM tốt nhất chỉ đạt **16.33%** tỷ lệ thành công, và chỉ **10.0%** trên các phần `c-interact` và `a-interact`.  
👉 Để biết thêm chi tiết, vui lòng truy cập [trang dự án của chúng tôi](https://bird-interact.github.io/).

- [2025-08-26] 📬 Chúng tôi sẽ gửi **Ground Truth & Test cases** đến danh sách email trong tuần này.  
Nếu bạn muốn truy cập sớm, vui lòng gửi email theo hướng dẫn trên trang để nhận **tải xuống tự động**.  

- [2025-08-26] 💾 Ngoài ra, chúng tôi cũng đã phát hành phiên bản SQLite của **[LiveSQLBench-Lite](https://huggingface.co/datasets/birdsql/livesqlbench-base-lite-sqlite)** để thuận tiện cho nghiên cứu cục bộ.  
Các phiên bản đầy đủ của **LiveSQLBench-Base** và **-Large** sẽ ra mắt sớm!

- [2025-08-22] **Sửa lỗi**: Trong mã Bird-Interact-Agent, chúng tôi đã sửa một lỗi khiến khi đánh giá SQL phase-2, câu lệnh SQL phase-1 đã lưu không thể thực thi thành công, dẫn tới tỷ lệ thành công phase-2 thấp hơn. Lỗi này chỉ ảnh hưởng đến những tác vụ mà phase1 sql thực hiện một số thao tác trên cơ sở dữ liệu, ví dụ như CREATE table, v.v.

## 🧸 Tổng quan

BIRD-INTERACT, một bộ chuẩn đánh giá text-to-SQL tương tác, **tái định hình đánh giá Text-to-SQL qua lăng kính của các tương tác động**.
Môi trường kết hợp cơ sở tri thức phân cấp, tài liệu cơ sở dữ liệu và trình mô phỏng người dùng dựa trên chức năng để tái tạo môi trường doanh nghiệp thực tế với đầy đủ các thao tác **CRUD**.
Nó cung cấp hai chế độ kiểm tra nghiêm ngặt: (1) **Tương tác hội thoại** thụ động và (2) **Tương tác chủ động** tác tử, bao gồm 600 tác vụ được chú thích như Business Intelligence (BI), thao tác CRUD, v.v., mỗi tác vụ đều được bảo vệ bằng các trường hợp kiểm thử có thể thực thi.
Các đánh giá điển hình kích hoạt từ 1.968 đến 5.496 lượt tương tác giữa mô hình và trình mô phỏng người dùng, trong khi các mô hình suy luận tiên tiến hiện nay chỉ giải quyết được **≈24%** và **≈18%** số tác vụ, nhấn mạnh thách thức của bộ kiểm chuẩn này.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ Hai chế độ đánh giá

BIRD-INTERACT hỗ trợ hai chế độ đánh giá như đã đề cập ở trên:

   - **c-Interact**: Tương tác hội thoại là chế độ thụ động với quy trình cố định. Mã nguồn và thông tin chi tiết có trong `bird_interact_conv`.
   - **a-Interact**: Tương tác chủ động là chế độ nhập vai, quy trình động và được dẫn dắt bởi mô hình. Mã nguồn và thông tin chi tiết có trong `bird_interact_agent`.


### 🐣 Phiên bản Lite

Chúng tôi phát hành phiên bản nhẹ của BIRD-INTERACT, `bird-interact-lite-exp`, bao gồm 270 tác vụ thực tế chất lượng cao dành riêng cho PostgreSQL. Đây là điểm khởi đầu tốt để thử nghiệm nhanh.

### 🦜 Phiên bản đầy đủ

Phiên bản đầy đủ của BIRD-INTERACT, `bird-interact-full`, là bộ kiểm chuẩn toàn diện bao gồm 600 tác vụ cho PostgreSQL. Nó bao phủ nhiều loại thao tác SQL và truy vấn người dùng. Phiên bản đầy đủ sẽ sớm ra mắt.

### Kết quả hiệu năng mô hình trên BIRD-INTERACT Lite

#### 1. Hiệu năng **c-Interact**
| Thứ hạng | Tên Mô hình      | Điểm thưởng chuẩn hóa | Cấp độ        |
|:------:|--------------------|:-------:|:--------------:|
| 1    | o3-mini            | 33.04 | 🏆 Hội thoại xuất sắc |
| 2    | GPT-4o             | 30.33 | 💎 Hội thoại tốt      |
| 3    | Gemini-2.0-flash   | 27.41 | 💎 Hội thoại tốt      |
| 4    | Claude-3.7-sonnet  | 26.60 | ✨ Tiêu chuẩn        |
| 5    | DeepSeek-R1        | 21.74 | ✨ Tiêu chuẩn        |
| 6    | Qwen3              | 20.33 | ⚪ Cơ bản            |
| 7    | DeepSeek-V3        | 15.85 | ⚪ Cơ bản            |

#### 2. Hiệu năng **a-Interact**
| Thứ hạng | Tên Mô hình      | Tham số ngân sách*     | Trung bình bước/tác vụ | Trung bình chi phí (USD)/tác vụ | Điểm thưởng chuẩn hóa | Cấp độ            |
|:------:|--------------------|:-------------------:|:----------------:|:---------------------:|:-------------------:|:---------------------:|
| 1    | Claude-3.7-sonnet  | 6/6 | 15.4 | $0.6668 | 29.19 | 🏆 Tương tác xuất sắc  |
| 2    | o3-mini            | 6/6 | 7.8 | $0.0754 | 21.07 | 💎 Tương tác tốt        |
| 3    | DeepSeek-V3        | 6/6 | 15.6 | $0.0629 | 19.19 | 💎 Tương tác tốt        |
| 4    | Qwen3              | 6/6 | 12.5 | $0.0278 | 18.74 | ✨ Chuẩn                |
| 5    | GPT-4o             | 6/6 | 15.3 | $0.4594 | 18.37 | ✨ Chuẩn                |
| 6    | Gemini-2.0-flash   | 6/6 | 13.2 | $0.0337 | 17.26 | ⚪ Cơ bản               |
| 7    | DeepSeek-R1        | 6/6 | 12.0 | $0.0931 | 17.07 | ⚪ Cơ bản               |

> \* Tham số ngân sách: Ngân sách khởi tạo/Nhẫn nại người dùng, được đo bằng *bird-coin* tiền ảo của chúng tôi <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;">. Tham khảo [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting) để biết thêm chi tiết.

### Tăng Quy mô Thời gian Tương tác (ITS)

Tăng Quy mô Thời gian Tương tác (ITS) đề cập đến khả năng của mô hình liên tục nâng cao hiệu suất cuối cùng thông qua tương tác nhiều lượt. Khi hiệu suất tương tác này vượt qua hiệu suất lý tưởng của mô hình ở một tác vụ đã được xác định đầy đủ và không mơ hồ trong một lượt, ta nói mô hình đáp ứng **định luật ITS**. Khi sự kiên nhẫn của người dùng tăng lên và số lượt tương tác tích lũy, hiệu suất tiếp tục cải thiện, chứng tỏ mô hình có thể duy trì giao tiếp hiệu quả trong các cuộc hội thoại kéo dài. Hiện tại, chỉ claude-3-7-sonnet đáp ứng định luật ITS.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## 📦 Chi tiết Bộ Dữ liệu

### Mô tả Bộ Dữ liệu

- **Cơ sở dữ liệu:** Toàn bộ cơ sở dữ liệu PostgreSQL có thể được tải về từ [Google Drive](https://drive.google.com/file/d/1KABce6czIqL9kMyIX7i-_A0CIQoDnmyW/view). Xem phần [Quick Eval](#quick-eval) để biết thêm chi tiết.
- **data:** Mỗi thực thể dữ liệu gồm các phần chính sau:
   - `selected_database`: Tên cơ sở dữ liệu.  
   - `query`: Truy vấn người dùng không mơ hồ.  
   - `amb_user_query`: Truy vấn người dùng đã được tiêm mơ hồ.
   - `user_query_ambiguity`: Các điểm mơ hồ được tiêm vào truy vấn người dùng.
   - `non_critical_ambiguity`: Các mơ hồ không quan trọng như thứ tự, giới hạn, v.v.
   - `knowledge_ambiguity`: Các mơ hồ tạo ra do che giấu kiến thức bên ngoài. 
   - `sol_sql`: Giải pháp SQL chuẩn xác.  
   - `preprocess_sql`: Truy vấn SQL thực thi trước khi chạy giải pháp hoặc dự đoán.  
   - `clean_up_sql`: Truy vấn SQL thực thi sau các trường hợp kiểm thử để hoàn tác các thay đổi trên cơ sở dữ liệu.  
   - `test_cases`: Bộ trường hợp kiểm thử để xác thực SQL được dự đoán, đã sửa.
   - `follow_up`: Các câu hỏi tiếp theo đã được gán nhãn.
   - `external_knowledge`: Kiến thức bên ngoài liên quan đến tác vụ cụ thể.

- **evaluation:** Mã đánh giá có sẵn trong thư mục [`./evaluation`](./evaluation).
- **Được biên soạn bởi:** Nhóm BIRD & Google Cloud
- **Giấy phép:** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **Thẻ dữ liệu HuggingFace:** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)

### Sử dụng bộ dữ liệu

Để tránh rò rỉ dữ liệu qua việc tự động thu thập, chúng tôi không bao gồm các giải pháp GT sql và các trường hợp kiểm thử cùng với dữ liệu.
vui lòng gửi email tới [bird.bench25@gmail.com](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/mailto:bird.bench25@gmail.com) với tiêu đề chứa thẻ `[bird-interact-lite GT&Test Cases]` để nhận bộ đầy đủ, sẽ được gửi tự động.


<!-- ### Sử dụng bộ dữ liệu từ HuggingFace

Bạn có thể tải bộ dữ liệu từ HuggingFace bằng lệnh sau:
```bash
from datasets import load_dataset
# Load the flash version of the dataset
dataset = load_dataset("birdsql/bird-interact-lite")
print(dataset["lite"][0])

# Load the full version of the dataset (coming soon)
dataset = load_dataset("birdsql/bird-interact-full")
print(dataset["full"][0])
```

Hoặc bạn có thể sử dụng script được cung cấp để tải xuống phiên bản đầy đủ của bộ dữ liệu và tách nó thành các phương ngữ khác nhau.
```bash
cd baseline/data
python pull_data.py \
  --schema_path path/to/full_schema.jsonl \
  --input_path path/to/input.jsonl \ # Đường dẫn tới tệp JSONL đầu vào (có thể để trống nếu bạn muốn tải bộ dữ liệu từ HuggingFace)
  --output_folder path/to/output_dir # thư mục đầu ra của các tệp đã chia
```

## Cấu trúc Thư mục
```ultree
.
├── LICENSE
├── README.md
├── bird_interact_conv
│   ├── ...
│   └── README.md
├── bird_interact_agent
│   ├── ...
│   └── README.md
├── evaluation
│   ├── docker-compose.yml
│   ├── env
│   ├── postgre_table_dumps
│   ├── run
│   └── src
├── materials
│   ├── ...
└── requirements.txt
```
Chi tiết về cách chạy **a-interact** có thể được tìm thấy tại `./bird_interact_agent/README.md`; và **c-interact** có thể được tìm thấy tại `./bird_interact_conv/README.md`.

## 📋 Danh sách công việc

- [x] Phát hành phiên bản rút gọn, bird-interact-lite (270).
- [x] Phát hành phiên bản hội thoại, bird-interact-conv.
- [x] Phát hành phiên bản agent, bird-interact-agent.
- [x] Phát hành phiên bản đầy đủ bird-interact-full (600).
- [ ] SFT / RL một Bộ mô phỏng Người dùng

## Được tạo bởi:
Nhóm BIRD & Google Cloud







---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-22

---