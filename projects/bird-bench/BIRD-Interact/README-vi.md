
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

## Tin tức
- [2025-08-22] **Sửa lỗi**: Trong mã Bird-Interact-Agent, chúng tôi đã sửa một lỗi khi đánh giá SQL giai đoạn 2, SQL giai đoạn 1 được lưu trữ không thể thực thi thành công, dẫn đến tỷ lệ thành công của Giai đoạn 2 thấp hơn. Lỗi này chỉ ảnh hưởng đến các tác vụ mà sql giai đoạn 1 thực hiện một số thao tác trên cơ sở dữ liệu, ví dụ: CREATE table, v.v.

## 🧸 Tổng quan

BIRD-INTERACT là một bộ đánh giá text-to-SQL tương tác, **tái hiện việc đánh giá Text-to-SQL thông qua góc nhìn của các tương tác động**.
Môi trường kết hợp một cơ sở tri thức phân cấp, tài liệu cơ sở dữ liệu và mô phỏng người dùng dựa trên chức năng để tái tạo môi trường doanh nghiệp thực tế với đầy đủ thao tác **CRUD**.
Nó cung cấp hai chế độ kiểm tra nghiêm ngặt: (1) **Tương tác hội thoại** thụ động và (2) **Tương tác đại lý** chủ động, bao gồm 600 tác vụ được chú thích như Phân tích kinh doanh (BI), thao tác CRUD, v.v., mỗi tác vụ đều có các trường hợp kiểm thử thực thi được bảo vệ.
Đánh giá thông thường kích hoạt 1.968-5.496 lượt tương tác giữa mô hình và mô phỏng người dùng, trong khi các mô hình lý luận tiên tiến hiện nay chỉ giải được **≈24%** và **≈18%** tác vụ, cho thấy thử thách của bộ đánh giá này.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ Hai chế độ đánh giá

BIRD-INTERACT hỗ trợ hai chế độ đánh giá như đã đề cập ở trên:

   - **c-Interact**: Tương tác hội thoại là chế độ thụ động và quy trình làm việc cố định. Mã nguồn và thông tin chi tiết có thể tìm thấy trong `bird_interact_conv`.
   - **a-Interact**: Tương tác đại lý là chế độ chủ động nhập vai, quy trình làm việc động và do mô hình dẫn dắt. Mã nguồn và thông tin chi tiết có thể tìm thấy trong `bird_interact_agent`.


### 🐣 Phiên bản Lite

Chúng tôi phát hành phiên bản nhẹ của BIRD-INTERACT, `bird-interact-lite-exp`, bao gồm 270 tác vụ thực tế chất lượng cao dành riêng cho PostgreSQL. Đây là điểm khởi đầu tốt để thử nghiệm nhanh.

### 🦜 Phiên bản Đầy Đủ

Phiên bản đầy đủ của BIRD-INTERACT, `bird-interact-full`, là bộ kiểm thử toàn diện gồm 600 tác vụ cho PostgreSQL. Nó bao phủ nhiều loại thao tác SQL và truy vấn người dùng. Phiên bản đầy đủ sẽ sớm ra mắt.

### Kết quả Hiệu năng Mô hình trên BIRD-INTERACT Lite

#### 1. Hiệu năng **c-Interact**
| Xếp hạng | Tên Mô hình       | Điểm Thưởng Chuẩn hóa | Cấp độ          |
|:------:|--------------------|:-------:|:--------------:|
| 1    | o3-mini            | 33.04 | 🏆 Chat Xuất sắc |
| 2    | GPT-4o             | 30.33 | 💎 Chat Tốt      |
| 3    | Gemini-2.0-flash   | 27.41 | 💎 Chat Tốt      |
| 4    | Claude-3.7-sonnet  | 26.60 | ✨ Chuẩn         |
| 5    | DeepSeek-R1        | 21.74 | ✨ Chuẩn         |
| 6    | Qwen3              | 20.33 | ⚪ Cơ bản         |
| 7    | DeepSeek-V3        | 15.85 | ⚪ Cơ bản         |

#### 2. Hiệu năng **a-Interact**
| Xếp hạng | Tên Mô hình        | Thông số Ngân sách* | Bước TB/tác vụ | Chi phí TB (USD)/tác vụ | Điểm Thưởng Chuẩn hóa | Cấp độ                 |
|:------:|--------------------|:-------------------:|:----------------:|:---------------------:|:-------------------:|:---------------------:|
| 1    | Claude-3.7-sonnet  | 6/6 | 15.4 | $0.6668 | 29.19 | 🏆 Tương tác Xuất sắc     |
| 2    | o3-mini            | 6/6 | 7.8  | $0.0754 | 21.07 | 💎 Tương tác Tốt          |
| 3    | DeepSeek-V3        | 6/6 | 15.6 | $0.0629 | 19.19 | 💎 Tương tác Tốt          |
| 4    | Qwen3              | 6/6 | 12.5 | $0.0278 | 18.74 | ✨ Chuẩn                  |
| 5    | GPT-4o             | 6/6 | 15.3 | $0.4594 | 18.37 | ✨ Chuẩn                  |
| 6    | Gemini-2.0-flash   | 6/6 | 13.2 | $0.0337 | 17.26 | ⚪ Cơ bản                 |
| 7    | DeepSeek-R1        | 6/6 | 12.0 | $0.0931 | 17.07 | ⚪ Cơ bản                 |

> * Thông số Ngân sách: Ngân sách Khởi động/Ngân sách Kiên nhẫn Người dùng, được đo bằng tiền ảo *bird-coin*s <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;">. Xem [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting) để biết thêm chi tiết.

### Tăng tỷ lệ Thời gian Tương tác (ITS)

Tăng tỷ lệ Thời gian Tương tác (ITS) là khả năng của mô hình liên tục tăng hiệu suất cuối cùng thông qua các lượt tương tác nhiều vòng. Khi hiệu năng tương tác này vượt qua hiệu năng lý tưởng hóa của mô hình trên một tác vụ được chỉ định đầy đủ, rõ ràng, ta nói mô hình thỏa mãn **luật ITS**. Khi sự kiên nhẫn của người dùng tăng và số lượt tương tác tích lũy, hiệu năng tiếp tục cải thiện, cho thấy mô hình có thể duy trì giao tiếp hiệu quả qua đối thoại kéo dài. Hiện tại, chúng tôi chỉ thấy claude-3-7-sonnet đáp ứng luật ITS.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## 📦 Chi tiết Bộ Dữ Liệu

### Mô tả Bộ Dữ Liệu

- **Cơ sở dữ liệu:** Toàn bộ cơ sở dữ liệu PostgreSQL có thể tải về từ [Google Drive](https://drive.google.com/file/d/1KABce6czIqL9kMyIX7i-_A0CIQoDnmyW/view). Xem phần [Quick Eval](#quick-eval) để biết thêm chi tiết.
- **data:** Mỗi trường dữ liệu bao gồm các phần chính sau:
   - `selected_database`: Tên của cơ sở dữ liệu.  
   - `query`: Truy vấn người dùng không mơ hồ.  
   - `amb_user_query`: Truy vấn người dùng có chèn các điểm mơ hồ.
   - `user_query_ambiguity`: Các điểm mơ hồ được chèn vào truy vấn người dùng.
   - `non_critical_ambiguity`: Các điểm mơ hồ không quan trọng như thứ tự, giới hạn, v.v.
   - `knowledge_ambiguity`: Các điểm mơ hồ tạo ra do che giấu kiến thức bên ngoài. 
   - `sol_sql`: Câu lệnh SQL đáp án đúng.  
   - `preprocess_sql`: Các truy vấn SQL cần chạy trước khi thực thi đáp án hoặc dự đoán.  
   - `clean_up_sql`: Các truy vấn SQL cần chạy sau khi kiểm thử để hoàn nguyên các thay đổi với cơ sở dữ liệu.  
   - `test_cases`: Bộ kiểm thử để xác thực câu SQL đã được sửa dự đoán.
   - `follow_up`: Các câu hỏi tiếp theo đã được gán nhãn.
   - `external_knowledge`: Kiến thức bên ngoài liên quan đến tác vụ cụ thể.

- **evaluation:** Mã đánh giá có sẵn tại thư mục [`./evaluation`](./evaluation).
- **Tổ chức bởi:** Nhóm BIRD & Google Cloud
- **Giấy phép:** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **Thẻ Dataset trên HuggingFace:** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)

### Ứng dụng Bộ Dữ Liệu

Để tránh rò rỉ dữ liệu do tự động thu thập, chúng tôi không bao gồm các đáp án GT sql và bộ kiểm thử cùng với dữ liệu.
vui lòng gửi email đến [bird.bench25@gmail.com](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/mailto:bird.bench25@gmail.com) với tiêu đề `[bird-interact-lite GT&Test Cases]` để nhận bộ đầy đủ, sẽ được gửi tự động.


<!-- ### Sử dụng Bộ Dữ Liệu từ HuggingFace

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
Chi tiết về cách chạy **a-interact** có thể được tìm thấy trong `./bird_interact_agent/README.md`; và **c-interact** có thể được tìm thấy trong `./bird_interact_conv/README.md`.


## 📋 Danh Sách Việc Cần Làm

- [x] Phát hành phiên bản rút gọn, bird-interact-lite (270).
- [x] Phát hành phiên bản hội thoại, bird-interact-conv.
- [x] Phát hành phiên bản agent, bird-interact-agent.
- [x] Phát hành phiên bản đầy đủ bird-interact-full (600).
- [ ] SFT / RL một Bộ Giả Lập Người Dùng

## Được Tạo Bởi:
Nhóm BIRD & Google Cloud


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-26

---