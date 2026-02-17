
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
Xin lưu ý rằng trước quá trình đánh giá, khi Docker tải các cơ sở dữ liệu, đôi khi có thể xảy ra lỗi do môi trường không đồng nhất (những lỗi này sẽ không làm dừng quá trình nhưng sẽ xuất hiện trong nhật ký Docker). Kết quả là một số cơ sở dữ liệu có thể không tải đúng, dẫn đến cơ sở dữ liệu trống. Điều này sẽ khiến kết quả đánh giá thấp bất thường.  
👉 Do đó, chúng tôi khuyến nghị mạnh mẽ kiểm tra nhật ký Docker để phát hiện lỗi **trước khi chạy đánh giá** và xác minh rằng tất cả các cơ sở dữ liệu đã được tải thành công.

👉 Chúng tôi đã cập nhật **Hướng dẫn Nộp bài**, trong đó hỗ trợ khung đại lý tùy chỉnh. Vui lòng xem hướng dẫn nộp bài chi tiết của chúng tôi [ở đây](https://docs.google.com/document/d/1F1DSqHDBzGvXFlWU8iCl9otkqxIefgcH/edit?usp=sharing&ouid=108161566779099489782&rtpof=true&sd=true).

## 📰 Tin tức

- [2026-02-08] 🔥🔥🔥 **[Bài báo Bird-Interact](https://huggingface.co/papers/2510.05318)** của chúng tôi đã được chấp nhận tại **ICLR 2026 (Oral)**! Hẹn gặp ở Rio 🇧🇷!  

- [2025-11-06] 🐛 **Sửa lỗi** & 🐳 **Cập nhật Docker**: Cập nhật phiên bản sqlglot lên 26.16.4 để sửa lỗi trình phân tích cú pháp SQL không phân tích đúng SQL cho trình mô phỏng người dùng. Bạn có thể sửa bằng cách cài đặt lại `pip install sqlglot==26.16.4` trong môi trường `bird_interact_eval`. Hình ảnh `bird_interact_eval` cũng đã được cập nhật, bạn cũng có thể kéo về và tạo lại container `bird_interact_eval`.

- [2025-10-21] 🐳 **Cập nhật Docker**: Chúng tôi đã thêm docker cho Full DB Env. Và đã đẩy 3 hình ảnh docker (Base/Full DB Env và môi trường đánh giá cho cả `a-Interact` và `c-Interact`) lên Docker Hub để thuận tiện cho việc thiết lập môi trường. Không cần tải DB dumps và xây dựng hình ảnh thủ công nữa!

- [2025-10-08] 📝 **[Bài báo Bird-Interact](https://huggingface.co/papers/2510.05318)** của chúng tôi hiện đã công khai!  
  Bài báo trình bày đầy đủ chi tiết, phương pháp và đánh giá về benchmark text-to-SQL tương tác.  
  👉 Xem ngay và tìm hiểu thêm về ý tưởng đằng sau [BIRD-Interact](https://bird-interact.github.io/).

- [2025-08-26] 🚀 Chúng tôi vui mừng thông báo phát hành bộ **[BIRD-Interact-Full (600)](https://huggingface.co/datasets/birdsql/bird-interact-full)**!  
Đây là bộ khó — các LLM tốt nhất chỉ đạt tỷ lệ thành công **16.33%**, với chỉ **10.0%** ở phần `c-interact` và `a-interact`.  
👉 Để biết thêm chi tiết, vui lòng truy cập [website dự án](https://bird-interact.github.io/).

- [2025-08-26] 📬 Chúng tôi sẽ gửi **Ground Truth & Test cases** tới danh sách gửi thư của mình trong tuần này.  
Nếu bạn muốn truy cập sớm, vui lòng gửi email theo hướng dẫn trên trang để được **tải về tự động**.  

- [2025-08-26] 💾 Ngoài ra, chúng tôi cũng đã phát hành phiên bản SQLite của **[LiveSQLBench-Lite](https://huggingface.co/datasets/birdsql/livesqlbench-base-lite-sqlite)** để thuận tiện cho nghiên cứu cục bộ.  
Phiên bản đầy đủ **LiveSQLBench-Base** và **-Large** sẽ ra mắt sớm!

- [2025-08-22] **Sửa lỗi**: Trong mã Bird-Interact-Agent, chúng tôi đã sửa một lỗi khiến khi đánh giá phase-2 SQL, câu lệnh phase-1 SQL lưu trữ không thực thi được thành công, dẫn đến tỷ lệ thành công phase-2 thấp hơn. Lỗi này chỉ ảnh hưởng đến các tác vụ mà phase1 sql thực hiện một số thao tác trên cơ sở dữ liệu, ví dụ như CREATE table, v.v.

## 🧸 Tổng quan

BIRD-INTERACT, một bộ đánh giá text-to-SQL tương tác, **định nghĩa lại việc đánh giá Text-to-SQL qua lăng kính tương tác động**.
Môi trường kết hợp cơ sở tri thức phân cấp, tài liệu cơ sở dữ liệu và trình mô phỏng người dùng dựa trên chức năng để tái tạo môi trường doanh nghiệp thực với đầy đủ các thao tác **CRUD**.
Nó cung cấp hai chế độ kiểm thử nghiêm ngặt: (1) **Tương tác hội thoại** bị động và (2) **Tương tác chủ động** dạng agent, bao quát 600 tác vụ đã được gán nhãn bao gồm Business Intelligence (BI), thao tác CRUD và nhiều hơn nữa, mỗi tác vụ đều có test case thực thi được.
Các đánh giá điển hình kích hoạt 1.968-5.496 lượt tương tác giữa mô hình và trình mô phỏng người dùng, trong khi các mô hình suy luận hiện đại chỉ giải quyết được **≈24%** và **≈18%** tác vụ, nhấn mạnh độ khó của bộ đánh giá này.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ Hai chế độ đánh giá

BIRD-INTERACT hỗ trợ hai chế độ đánh giá như đã đề cập ở trên:

   - **c-Interact**: Tương tác hội thoại, đây là chế độ bị động với quy trình cố định. Mã nguồn và thông tin chi tiết có thể tìm thấy tại `bird_interact_conv`.
   - **a-Interact**: Tương tác chủ động dạng agent, là chế độ chủ động với quy trình động và được dẫn dắt bởi các mô hình. Mã nguồn và thông tin chi tiết có thể tìm thấy tại `bird_interact_agent`.


### 🐣 Phiên bản rút gọn

Chúng tôi phát hành bản rút gọn của BIRD-INTERACT, `bird-interact-lite-exp`, bao gồm 270 tác vụ thực tế chất lượng cao dành riêng cho PostgreSQL. Đây là điểm khởi đầu tốt để thử nghiệm nhanh.

### 🦜 Phiên bản đầy đủ

Phiên bản đầy đủ của BIRD-INTERACT, `bird-interact-full`, là bộ đánh giá toàn diện bao gồm 600 tác vụ cho PostgreSQL. Nó bao phủ nhiều thao tác SQL và truy vấn người dùng. Phiên bản đầy đủ sẽ ra mắt sớm.

### Kết quả hiệu năng mô hình trên BIRD-INTERACT-FULL

#### 1. **Hiệu năng c-Interact Text-to-SQL**
| Hạng | Tên mô hình        | Normalized Reward | Chi phí TB (USD)/Tác vụ | Cấp độ              |
|:----:|:-------------------|:-----------------:|:-------------------:|:------------------:|
| 1    | Gemini-2.5-Pro     | 20.92             | $0.04               | 🏆 Trò chuyện xuất sắc  |
| 2    | O3-Mini            | 20.27             | $0.07               | 🏆 Trò chuyện xuất sắc  |
| 3    | Claude-Sonnet-4    | 18.35             | $0.29               | 💎 Trò chuyện tốt       |
| 4    | Qwen-3-Coder-480B  | 17.75             | $0.11               | 💎 Trò chuyện tốt       |
| 5    | Deepseek-Chat-V3.1 | 15.15             | $0.12               | ✨ Tiêu chuẩn           |
| 6    | Claude-Sonnet-3.7  | 13.87             | $0.29               | ✨ Tiêu chuẩn           |
| 7    | GPT-5              | 12.58             | $0.08               | ⚪ Cơ bản               |

#### 2. **Hiệu suất a-Interact Text-to-SQL**
| Xếp hạng | Tên mô hình         | Phần thưởng Chuẩn hóa | Chi phí TB (USD)/Tác vụ | Cấp độ                      |
|:----:|:-------------------|:-----------------:|:-------------------:|:------------------------:|
| 1    | GPT-5              | 25.52             | $0.24               | 🏆 Tương tác xuất sắc     |
| 2    | Claude-Sonnet-4    | 23.28             | $0.51               | 🏆 Tương tác xuất sắc     |
| 3    | Claude-Sonnet-3.7  | 17.45             | $0.60               | 💎 Tương tác tốt          |
| 4    | Gemini-2.5-Pro     | 17.33             | $0.22               | 💎 Tương tác tốt          |
| 5    | O3-Mini            | 16.43             | $0.06               | ✨ Tiêu chuẩn              |
| 6    | Deepseek-Chat-V3.1 | 13.47             | $0.06               | ✨ Tiêu chuẩn              |
| 7    | Qwen-3-Coder-480B  | 10.58             | $0.07               | ⚪ Cơ bản                  |

> \* Thông số ngân sách: Ngân sách khởi đầu/Ngân sách kiên nhẫn người dùng, được đo bằng đơn vị tiền ảo *bird-coin* <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;">. Xem chi tiết tại [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting).

### Quy mô Thời gian Tương tác (ITS)

Quy mô Thời gian Tương tác (ITS) đề cập đến khả năng của mô hình trong việc liên tục nâng cao hiệu suất cuối cùng thông qua các vòng tương tác đa lượt. Khi hiệu suất tương tác này vượt qua hiệu suất lý tưởng của mô hình trong một tác vụ đơn lẻ, rõ ràng, không mơ hồ, chúng tôi cho rằng mô hình đáp ứng **định luật ITS**. Khi sự kiên nhẫn của người dùng tăng và số lượt tương tác tích lũy, hiệu suất tiếp tục được cải thiện, chứng tỏ mô hình có thể duy trì giao tiếp hiệu quả trong đối thoại kéo dài. Hiện tại, chúng tôi chỉ phát hiện claude-3-7-sonnet đáp ứng định luật ITS.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## Cài đặt môi trường

1. Chạy các container Docker cho cơ sở dữ liệu bird-interact-lite, cơ sở dữ liệu bird-interact-full, và môi trường đánh giá:
  
  > Nếu bạn chỉ muốn đánh giá trên `bird-interact-lite`, bạn có thể comment dịch vụ [`postgresql_full`](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/./env/docker-compose.yml#L21-L31) trong `docker-compose.yml` để tăng tốc quá trình cài đặt môi trường.
  
  Khởi động môi trường bằng lệnh:
   ```bash
   cd env
   docker compose pull 
   docker compose up -d
   ```
   Chờ vài phút để khởi tạo cơ sở dữ liệu.

  Bạn có thể theo dõi tiến trình xây dựng bằng cách:
  ```bash
  docker compose logs -f --tail=100 bird_interact_postgresql_full # or bird_interact_postgresql for bird-interact-lite
  ```
  Nếu hoàn thành, bạn sẽ thấy các bản ghi mà không có lỗi như sau:

  ```bash
  bird_interact_postgresql_full  | 2025-10-28 17:58:30.413 HKT [1] LOG:  database system is ready to accept connection
  ```
  
  Nếu bạn đã tạo các container trước đó và muốn tạo lại chúng, bạn có thể chạy lệnh sau:
  ```bash
  docker compose down -v # this cmd removes the containers and the volumes
  docker compose pull   # pull the latest images from Docker Hub
  docker compose up -d --force-recreate # build and start the containers again. --force-recreate means force the recreation of the containers. 
  # Or `docker compose up -d --force-recreate bird_interact_eval` to only recreate the bird_interact_eval container about evalution code environment.
  ```
   
   Điều này chạy 3 container sử dụng các ảnh dựng sẵn từ Docker Hub:
   - `bird_interact_postgresql`: Cơ sở dữ liệu PostgreSQL cho bird-interact-lite
   - `bird_interact_postgresql_full`: Cơ sở dữ liệu PostgreSQL cho bird-interact-full
   - `bird_interact_eval`: Môi trường đánh giá cho cả `a-Interact` và `c-Interact`.

   Bây giờ, bạn có thể khởi động môi trường đánh giá bằng cách thực hiện lệnh sau:
   ```bash
   docker compose exec bird_interact_eval bash
   ```
2. (Tùy chọn) Tự xây dựng môi trường (nếu bạn muốn xây dựng các image từ đầu):
   - Tải về các file dump của cơ sở dữ liệu
      - [bird-interact-lite](https://drive.google.com/file/d/1QIGQlRKbkqApAOrQXPqFJgUg8rQ7HRRZ/view). Giải nén và đổi tên thành `env/postgre_table_dumps`.
      - [bird-interact-full](https://drive.google.com/file/d/1V9SFIWebi27JtaDUAScG1xE9ELbYcWLR/view). Giải nén và đổi tên thành `env/postgre_table_dumps_full`.
   - Tự xây dựng môi trường bằng cách chạy `docker-compose.build.yml`.

      ```bash
      cd env/
      docker compose -f docker-compose.build.yml build
      docker compose -f docker-compose.build.yml up -d
      ```

3. (Khuyến nghị) Kiểm tra các container cơ sở dữ liệu đã được xây dựng và chạy thành công.

- In nhật ký xây dựng container để đảm bảo rằng các cơ sở dữ liệu đã được xây dựng thành công mà không có lỗi:
   ```bash 
   docker logs bird_interact_postgresql > build_bird_interact_postgresql.log 2>&1
   docker logs bird_interact_postgresql_full > build_bird_interact_postgresql_full.log 2>&1
   ```
   Nếu xảy ra lỗi, `"Đã xảy ra lỗi trong quá trình nhập:"` sẽ được in ra trong các tập tin nhật ký.


-  Kiểm tra xem các container cơ sở dữ liệu có đang hoạt động tốt không.
   
   Sử dụng script Python do chúng tôi cung cấp để xác minh siêu dữ liệu cơ sở dữ liệu:
   ```bash
   docker compose exec bird_interact_eval bash
   cd /app/env
   python check_db_metadata.py --host bird_interact_postgresql
   python check_db_metadata.py --host bird_interact_postgresql_full
   ```
   
   Kết quả mong đợi:
   - **bird-interact-lite**: 
     - 📈 Tổng số Cơ sở dữ liệu: 18
     - 📋 Tổng số Bảng: 175
     - 🔢 Tổng số Cột: 2286
     - 📈 Số hàng trung bình mỗi bảng: 1.038,48
     - 💾 Tổng dung lượng: 207,15 MB (ước lượng)
   - **bird-interact-full**: 
     - 📈 Tổng số Cơ sở dữ liệu: 22
     - 📋 Tổng số Bảng: 244
     - 🔢 Tổng số Cột: 2011
     - 📈 Số hàng trung bình mỗi bảng: 1.121,19
     - 💾 Tổng dung lượng: 272,00 MB (ước lượng)


## 📦 Chi tiết Bộ dữ liệu

### Mô tả Bộ dữ liệu

- **Cơ sở dữ liệu:** Toàn bộ cơ sở dữ liệu PostgreSQL có thể tải về từ [bird-interact-lite](https://drive.google.com/file/d/1QIGQlRKbkqApAOrQXPqFJgUg8rQ7HRRZ/view) và [bird-interact-full](https://drive.google.com/file/d/1V9SFIWebi27JtaDUAScG1xE9ELbYcWLR/view).
- **data:** Mỗi trường hợp dữ liệu chứa các phần chính sau:
   - `selected_database`: Tên cơ sở dữ liệu.  
   - `query`: Truy vấn người dùng rõ ràng.  
   - `amb_user_query`: Truy vấn người dùng đã được chèn sự mơ hồ.
   - `user_query_ambiguity`: Những điểm mơ hồ được thêm vào truy vấn người dùng.
   - `non_critical_ambiguity`: Sự mơ hồ không quan trọng như thứ tự, giới hạn, v.v.
   - `knowledge_ambiguity`: Sự mơ hồ do giấu kiến thức bên ngoài. 
   - `sol_sql`: Giải pháp SQL chuẩn xác.  
   - `preprocess_sql`: Các truy vấn SQL chạy trước khi thực hiện giải pháp hoặc dự đoán.  
   - `clean_up_sql`: Các truy vấn SQL chạy sau các trường hợp kiểm thử để hoàn tác các thay đổi đã thực hiện trên cơ sở dữ liệu.  
   - `test_cases`: Tập hợp các trường hợp kiểm thử để xác thực SQL dự đoán đã được chỉnh sửa.
   - `follow_up`: Các câu hỏi tiếp theo đã được gán nhãn.
   - `external_knowledge`: Kiến thức bên ngoài liên quan đến nhiệm vụ cụ thể.

- **evaluation:** Mã đánh giá có sẵn tại thư mục [`./evaluation`](./evaluation).
- **Được tuyển chọn bởi:** Đội BIRD & Google Cloud
- **Giấy phép:** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **HuggingFace Dataset Card:** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)
  và [bird-interact-full](https://huggingface.co/datasets/birdsql/bird-interact-full)
### Sử dụng Bộ Dữ Liệu

Để tránh rò rỉ dữ liệu do tự động thu thập, chúng tôi không bao gồm các sql giải pháp GT và các trường hợp kiểm thử cùng với dữ liệu.
vui lòng gửi email tới [bird.bench25@gmail.com](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/mailto:bird.bench25@gmail.com) với tiêu đề chứa thẻ `[bird-interact-lite GT&Test Cases]` hoặc `[bird-interact-full GT&Test Cases]` để nhận bộ dữ liệu ground truth và các trường hợp kiểm thử cho bộ dữ liệu bird-interact-lite hoặc bird-interact-full, sẽ được gửi tự động.


### Kết hợp dữ liệu công khai với ground truth và các trường hợp kiểm thử

Sau đó sử dụng đoạn script sau để kết hợp dữ liệu công khai với ground truth và các trường hợp kiểm thử:

Lấy phiên bản đầy đủ làm ví dụ:
(1) Chạy:
```bash
python combine_public_with_gt.py /path/to/bird-interact-full/bird_interact_data.jsonl /path/to/bird_interact_full_gt_kg_testcases_08022.jsonl /path/to/bird_interact_data.jsonl  # bird_interact_full_gt_kg_testcases_08022.jsonl is the data of ground-truth fields, which is obtained by emailing us.
```
Điều này sẽ tạo một tệp mới tại `/path/to/bird_interact_data.jsonl` với dữ liệu đã được kết hợp.

(2) Sau đó thay thế dữ liệu công khai gốc bằng dữ liệu đã kết hợp:

```bash
cp /path/to/bird_interact_data.jsonl /path/to/bird-interact-full/bird_interact_data.jsonl
```

Tương tự cho các phiên bản khác: bird-interact-lite, phiên bản mini, v.v. Chỉ cần đặt đúng đường dẫn cho dữ liệu công khai, dữ liệu thực tế và các trường hợp kiểm thử, sau đó thay thế dữ liệu công khai bằng dữ liệu đã kết hợp.




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
Chi tiết về cách chạy **a-interact** có thể được tìm thấy ở `./bird_interact_agent/README.md`; và **c-interact** có thể được tìm thấy ở `./bird_interact_conv/README.md`.

## 📋 Danh sách việc cần làm

- [x] Phát hành phiên bản nhẹ, bird-interact-lite (270).
- [x] Phát hành phiên bản hội thoại, bird-interact-conv.
- [x] Phát hành phiên bản agent, bird-interact-agent.
- [x] Phát hành đầy đủ bird-interact-full (600).
- [ ] SFT / RL một Trình mô phỏng Người dùng

## Ghi nhận
Chúng tôi xin bày tỏ lòng biết ơn chân thành tới **Irina Saparina**, **Mohammadreza Pourreza**, **Mehdi Bouzouina**, **Hailong Li**, **Jiatong Shi**, và Giáo sư **Shinji Watanabe** vì những cuộc thảo luận hiệu quả và những ý kiến quý giá đã giúp cải thiện dự án này.

## Được tạo bởi:
Nhóm BIRD & Google Cloud








## Nhật ký thay đổi

- [2025-11-06] 🐛 **Sửa lỗi** & 🐳 **Cập nhật Docker**: Cập nhật phiên bản sqlglot lên 26.16.4 để sửa lỗi trình phân tích cú pháp SQL không thể phân tích đúng SQL cho trình mô phỏng người dùng. Bạn có thể sửa lỗi này bằng cách cài đặt lại bằng `pip install sqlglot==26.16.4` trong môi trường `bird_interact_eval`. Hình ảnh `bird_interact_eval` cũng đã được cập nhật, bạn cũng có thể pull về và tạo lại container `bird_interact_eval`.
- [2025-10-21] 🐳 **Cập nhật Docker**: Thêm docker cho môi trường Full DB. Và chúng tôi đã đẩy 3 hình ảnh docker (Base/Full DB Env và môi trường đánh giá cho cả `a-Interact` và `c-Interact`) lên Docker Hub để thuận tiện cho việc thiết lập môi trường. Không cần tải DB dumps hoặc tự build hình ảnh! Hãy pull các hình ảnh mới nhất từ Docker Hub và tạo lại các container, ví dụ sử dụng `docker compose down -v && docker compose pull && docker compose up -d --force-recreate`.
- [2025-08-22]  🐛 **Sửa lỗi**: Sửa lỗi khi đánh giá phase-2 SQL, phase-1 SQL lưu trữ không thể thực thi thành công, dẫn đến tỷ lệ thành công của Phase-2 thấp hơn. Lỗi này chỉ ảnh hưởng tới những tác vụ mà phase1 sql thực hiện một số thao tác trên cơ sở dữ liệu, ví dụ CREATE table, v.v.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-17

---