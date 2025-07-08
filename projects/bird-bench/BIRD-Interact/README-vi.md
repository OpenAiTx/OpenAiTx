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

## 🧸 Tổng Quan

BIRD-INTERACT, một bộ chuẩn đánh giá chuyển đổi văn bản sang SQL mang tính tương tác, **tái định hình việc đánh giá Text-to-SQL qua lăng kính của các tương tác động**.
Môi trường này kết hợp một cơ sở tri thức phân cấp, tài liệu cơ sở dữ liệu và một trình mô phỏng người dùng dựa trên chức năng để tái tạo môi trường doanh nghiệp thực tế trên toàn bộ các thao tác **CRUD**.
Nó cung cấp hai chế độ kiểm thử nghiêm ngặt: (1) **Tương tác Hội thoại** (thụ động) và (2) **Tương tác Đại lý** (chủ động), bao gồm 600 tác vụ được chú thích như Trí tuệ Doanh nghiệp (BI), thao tác CRUD, v.v., mỗi tác vụ đều có các ca kiểm thử thực thi được.
Các lần đánh giá điển hình kích hoạt từ 1.968-5.496 lượt tương tác giữa mô hình và trình mô phỏng người dùng, trong khi các mô hình lý luận tiên tiến hiện chỉ giải quyết được **≈24%** và **≈18%** số tác vụ, nhấn mạnh mức độ thử thách của bộ chuẩn này.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ Hai Chế Độ Đánh Giá

BIRD-INTERACT hỗ trợ hai chế độ đánh giá như đã đề cập ở trên:

   - **c-Interact**: Tương tác hội thoại, là chế độ thụ động với luồng công việc cố định. Mã nguồn và thông tin chi tiết có thể được tìm thấy trong `bird_interact_conv`.
   - **a-Interact**: Tương tác đại lý, là chế độ chủ động nhập vai trong đó luồng công việc mang tính động và được dẫn dắt bởi các mô hình. Mã nguồn và thông tin chi tiết có thể được tìm thấy trong `bird_interact_agent`.


### 🐣 Phiên Bản Nhẹ

Chúng tôi phát hành phiên bản nhẹ của BIRD-INTERACT, `bird-interact-lite-exp`, bao gồm 270 tác vụ thực tế chất lượng cao dành riêng cho PostgreSQL. Đây là điểm khởi đầu tốt cho các thử nghiệm nhanh.

### 🦜 Phiên Bản Đầy Đủ

Phiên bản đầy đủ của BIRD-INTERACT, `bird-interact-full`, là bộ chuẩn toàn diện bao gồm 600 tác vụ dành cho PostgreSQL. Nó bao phủ nhiều thao tác SQL và truy vấn người dùng khác nhau. Phiên bản đầy đủ sẽ sớm ra mắt.

### Kết Quả Hiệu Năng Mô Hình trên BIRD-INTERACT Lite

#### 1. Hiệu Năng **c-Interact**
| Hạng | Tên Mô Hình        | Điểm Thưởng Chuẩn Hóa | Cấp Độ             |
|:------:|--------------------|:-------:|:--------------:|
| 1    | o3-mini            | 33.04 | 🏆 Chat Xuất Sắc |
| 2    | GPT-4o             | 30.33 | 💎 Chat Tốt      |
| 3    | Gemini-2.0-flash   | 27.41 | 💎 Chat Tốt      |
| 4    | Claude-3.7-sonnet  | 26.60 | ✨ Tiêu Chuẩn     |
| 5    | DeepSeek-R1        | 21.74 | ✨ Tiêu Chuẩn     |
| 6    | Qwen3              | 20.33 | ⚪ Cơ Bản         |
| 7    | DeepSeek-V3        | 15.85 | ⚪ Cơ Bản         |

#### 2. Hiệu Năng **a-Interact**
| Hạng | Tên Mô Hình        | Tham Số Ngân Sách* | Số Lượt/ Tác Vụ | Chi Phí TB (USD)/Tác Vụ | Điểm Thưởng Chuẩn Hóa | Cấp Độ                |
|:------:|--------------------|:-------------------:|:----------------:|:---------------------:|:-------------------:|:---------------------:|
| 1    | Claude-3.7-sonnet  | 6/6 | 15.4 | $0.6668 | 29.19 | 🏆 Tương Tác Xuất Sắc     |
| 2    | o3-mini            | 6/6 | 7.8  | $0.0754 | 21.07 | 💎 Tương Tác Tốt          |
| 3    | DeepSeek-V3        | 6/6 | 15.6 | $0.0629 | 19.19 | 💎 Tương Tác Tốt          |
| 4    | Qwen3              | 6/6 | 12.5 | $0.0278 | 18.74 | ✨ Tiêu Chuẩn             |
| 5    | GPT-4o             | 6/6 | 15.3 | $0.4594 | 18.37 | ✨ Tiêu Chuẩn             |
| 6    | Gemini-2.0-flash   | 6/6 | 13.2 | $0.0337 | 17.26 | ⚪ Cơ Bản                 |
| 7    | DeepSeek-R1        | 6/6 | 12.0 | $0.0931 | 17.07 | ⚪ Cơ Bản                 |

> \* Tham Số Ngân Sách: Ngân sách khởi đầu/Ngân sách kiên nhẫn của người dùng, được đo bằng tiền ảo *bird-coin*s <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;">. Tham khảo [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting) để biết thêm chi tiết.

### Tăng Quy Mô Theo Thời Gian Tương Tác (ITS)

Tăng Quy Mô Theo Thời Gian Tương Tác (ITS) đề cập đến khả năng của một mô hình liên tục nâng cao hiệu quả cuối cùng thông qua các lượt tương tác đa chiều. Khi hiệu suất tương tác này vượt qua hiệu suất lý tưởng một lượt của mô hình trên tác vụ đã được chỉ định đầy đủ, không mơ hồ, ta nói rằng mô hình đáp ứng **định luật ITS**. Khi sự kiên nhẫn của người dùng tăng lên và số lượt tương tác tích lũy lại, hiệu suất tiếp tục được cải thiện, cho thấy mô hình có thể duy trì giao tiếp hiệu quả qua các cuộc hội thoại kéo dài. Hiện tại, chỉ có claude-3-7-sonnet đáp ứng định luật ITS.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## 📦 Chi Tiết Bộ Dữ Liệu

### Mô Tả Bộ Dữ Liệu

- **Cơ sở dữ liệu:** Toàn bộ cơ sở dữ liệu PostgreSQL có thể được tải xuống từ [Google Drive](https://drive.google.com/file/d/1KABce6czIqL9kMyIX7i-_A0CIQoDnmyW/view). Xem thêm phần [Đánh Giá Nhanh](#quick-eval) để biết chi tiết.
- **data:** Mỗi mẫu dữ liệu bao gồm các phần chính sau:
   - `selected_database`: Tên của cơ sở dữ liệu.  
   - `query`: Truy vấn người dùng không mơ hồ.  
   - `amb_user_query`: Truy vấn người dùng đã được thêm yếu tố mơ hồ.
   - `user_query_ambiguity`: Các yếu tố mơ hồ được thêm vào truy vấn người dùng.
   - `non_critical_ambiguity`: Các yếu tố mơ hồ không quan trọng như thứ tự, giới hạn, v.v.
   - `knowledge_ambiguity`: Các điểm mơ hồ được tạo ra bởi các kiến thức bên ngoài bị che giấu. 
   - `sol_sql`: Giải pháp SQL chuẩn.  
   - `preprocess_sql`: Các truy vấn SQL cần chạy trước khi thực thi giải pháp hoặc dự đoán.  
   - `clean_up_sql`: Các truy vấn SQL cần chạy sau các trường hợp kiểm thử để hoàn tác mọi thay đổi đã thực hiện trên cơ sở dữ liệu.  
   - `test_cases`: Một tập hợp các trường hợp kiểm thử để xác thực truy vấn SQL đã được sửa dự đoán.
   - `follow_up`: Các câu hỏi tiếp theo đã được gắn nhãn.
   - `external_knowledge`: Kiến thức bên ngoài liên quan đến tác vụ cụ thể.

- **evaluation:** Mã đánh giá có sẵn trong thư mục [`./evaluation`](./evaluation).
- **Curated by:** Đội ngũ BIRD & Google Cloud
- **License:** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **HuggingFace Dataset Card:** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)

### Ứng dụng của Bộ Dữ Liệu

Để tránh rò rỉ dữ liệu do quét tự động, chúng tôi không bao gồm các truy vấn SQL giải pháp GT và các trường hợp kiểm thử cùng với dữ liệu.
Vui lòng gửi email đến [bird.bench25@gmail.com](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/mailto:bird.bench25@gmail.com) với thẻ `[bird-interact-lite GT&Test Cases]` trong tiêu đề để nhận bộ đầy đủ, sẽ được gửi tự động.


<!-- ### Sử dụng Bộ Dữ Liệu từ HuggingFace

Bạn có thể tải bộ dữ liệu từ HuggingFace bằng lệnh sau:
```bash
from datasets import load_dataset
# Tải phiên bản flash của bộ dữ liệu
dataset = load_dataset("birdsql/bird-interact-lite")
print(dataset["lite"][0])

# Tải phiên bản đầy đủ của bộ dữ liệu (sắp ra mắt)
dataset = load_dataset("birdsql/bird-interact-full")
print(dataset["full"][0])
```

Hoặc bạn có thể sử dụng script được cung cấp để tải phiên bản đầy đủ của bộ dữ liệu và tách nó thành các phương ngữ khác nhau.
```bash
cd baseline/data
python pull_data.py \
  --schema_path path/to/full_schema.jsonl \
  --input_path path/to/input.jsonl \ # Đường dẫn tới file JSONL đầu vào (có thể để trống nếu bạn muốn tải dữ liệu từ HuggingFace)
  --output_folder path/to/output_dir # thư mục đầu ra chứa các file đã tách
``` -->

## Cấu Trúc Thư Mục
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
Chi tiết về cách chạy **a-interact** có thể được tìm thấy tại `./bird_interact_agent/README.md`; và **c-interact** tại `./bird_interact_conv/README.md`.


## 📋 Danh Sách Công Việc

- [x] Phát hành phiên bản lite, bird-interact-lite (270).
- [x] Phát hành phiên bản hội thoại, bird-interact-conv.
- [x] Phát hành phiên bản agent, bird-interact-agent.
- [ ] Phát hành đầy đủ bird-interact-full (600).
- [ ] SFT / RL một Bộ Mô Phỏng Người Dùng

## Được tạo bởi:
Đội ngũ BIRD & Google Cloud

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---