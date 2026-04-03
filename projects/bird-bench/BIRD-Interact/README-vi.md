
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
Xin lưu ý rằng trước khi bạn bắt đầu quá trình đánh giá, khi Docker tải cơ sở dữ liệu, đôi khi có thể phát sinh lỗi do sự không đồng nhất của môi trường (những lỗi này sẽ không làm dừng quá trình mà chỉ xuất hiện trong log của Docker). Kết quả là một số cơ sở dữ liệu có thể không được tải đúng cách, dẫn đến cơ sở dữ liệu rỗng. Điều này sẽ làm cho kết quả đánh giá thấp bất thường.  
👉 Vì vậy, chúng tôi khuyến nghị mạnh mẽ bạn kiểm tra log Docker để phát hiện lỗi **trước khi chạy đánh giá** và xác nhận rằng tất cả cơ sở dữ liệu đã được tải thành công.

👉 Chúng tôi đã cập nhật **Hướng dẫn Nộp Bài**, nơi đã hỗ trợ các scaffold tác nhân tùy chỉnh. Vui lòng xem chi tiết hướng dẫn nộp bài [tại đây](https://docs.google.com/document/d/1F1DSqHDBzGvXFlWU8iCl9otkqxIefgcH/edit?usp=sharing&ouid=108161566779099489782&rtpof=true&sd=true).

## 📰 Tin tức

- [2026-03-29] 🔥🔥🔥 **BIRD-Interact-ADK**: Chúng tôi phát hành **[BIRD-Interact-ADK](./BIRD-Interact-ADK/)**, một triển khai dựa trên Google ADK với kiến trúc module 3-microservices (tác nhân, mô phỏng người dùng và môi trường DB). Dễ dàng thay thế tác nhân, mô phỏng người dùng hoặc môi trường DB của riêng bạn. Hỗ trợ thực thi song song và mọi nhà cung cấp LLM [tương thích LiteLlm](https://docs.litellm.ai/docs/providers). Khuyến nghị sử dụng triển khai này cho nghiên cứu của bạn.

- [2026-02-08] 🔥🔥🔥 Bài báo **[Bird-Interact](https://huggingface.co/papers/2510.05318)** của chúng tôi đã được chấp nhận tại **ICLR 2026 (Oral)**! Hẹn gặp tại Rio 🇧🇷!  

- [2025-11-06] 🐛 **Sửa lỗi** & 🐳 **Cập nhật Docker**: Cập nhật phiên bản sqlglot lên 26.16.4 để sửa lỗi trình phân tích SQL không thể phân tích SQL đúng cho mô phỏng người dùng. Bạn có thể sửa bằng cách cài lại `pip install sqlglot==26.16.4` trong môi trường `bird_interact_eval`. Ảnh `bird_interact_eval` cũng đã được cập nhật, bạn cũng có thể pull về và tạo lại container `bird_interact_eval`.

- [2025-10-21] 🐳 **Cập nhật Docker**: Chúng tôi đã thêm docker cho Full DB Env. Và chúng tôi đã đẩy 3 ảnh docker (Base/Full DB Env và môi trường đánh giá cho cả `a-Interact` và `c-Interact`) lên Docker Hub để đơn giản hóa việc thiết lập môi trường. Không cần tải DB dumps hay build ảnh thủ công!

- [2025-10-08] 📝 Bài báo **[Bird-Interact](https://huggingface.co/papers/2510.05318)** của chúng tôi hiện đã công khai!  
  Bài báo trình bày đầy đủ chi tiết, phương pháp luận và đánh giá về bộ chuẩn tương tác text-to-SQL của chúng tôi.  
  👉 Hãy xem ngay để biết thêm về ý tưởng đằng sau [BIRD-Interact](https://bird-interact.github.io/).

- [2025-08-26] 🚀 Chúng tôi vui mừng thông báo phát hành bộ **[BIRD-Interact-Full (600)](https://huggingface.co/datasets/birdsql/bird-interact-full)**!  
Đây là một bộ rất khó — các LLM tốt nhất chỉ đạt **16.33%** tỷ lệ thành công, với chỉ **10.0%** ở các phần `c-interact` và `a-interact`.  
👉 Để biết thêm chi tiết, vui lòng truy cập [trang web dự án](https://bird-interact.github.io/).

- [2025-08-26] 📬 Chúng tôi sẽ gửi **Ground Truth & Test cases** tới danh sách email của mình trong tuần này.  
Nếu bạn muốn truy cập sớm, vui lòng gửi email theo hướng dẫn trên trang web để **tải về tự động**.  

- [2025-08-26] 💾 Ngoài ra, chúng tôi cũng đã phát hành phiên bản SQLite của **[LiveSQLBench-Lite](https://huggingface.co/datasets/birdsql/livesqlbench-base-lite-sqlite)** để hỗ trợ nghiên cứu cục bộ dễ dàng hơn.  
Các phiên bản đầy đủ **LiveSQLBench-Base** và **-Large** sẽ ra mắt sớm!

- [2025-08-22] **Sửa lỗi**: Trong mã Bird-Interact-Agent, chúng tôi đã sửa một lỗi khiến khi đánh giá SQL phase-2, câu lệnh SQL phase-1 đã lưu không thể thực thi thành công, dẫn đến tỷ lệ thành công của Phase-2 thấp hơn. Lỗi này chỉ ảnh hưởng đến những tác vụ mà SQL phase1 thực hiện các thao tác trên cơ sở dữ liệu, ví dụ như CREATE table, v.v.

## 🧸 Tổng quan

BIRD-INTERACT, một bộ chuẩn đánh giá chuyển đổi văn bản sang SQL tương tác, **tái định hình việc đánh giá Text-to-SQL dưới góc nhìn của các tương tác động**.
Môi trường kết hợp cơ sở tri thức phân cấp, tài liệu cơ sở dữ liệu và trình mô phỏng người dùng theo chức năng để tái tạo bối cảnh doanh nghiệp thực tế trên đầy đủ các thao tác **CRUD**.
Nó cung cấp hai chế độ kiểm thử nghiêm ngặt: (1) **Tương tác hội thoại** thụ động và (2) **Tương tác đại lý** chủ động, bao quát 600 tác vụ được chú thích gồm Business Intelligence (BI), thao tác CRUD, v.v., mỗi tác vụ đều có các trường hợp kiểm thử thực thi được.
Các lần đánh giá điển hình kích hoạt từ 1.968 đến 5.496 lượt tương tác giữa mô hình và trình mô phỏng người dùng, trong khi các mô hình suy luận hiện đại hiện chỉ giải được **≈24%** và **≈18%** tác vụ, cho thấy độ khó của bộ chuẩn này.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ Hai chế độ đánh giá

BIRD-INTERACT hỗ trợ hai chế độ đánh giá như đã đề cập ở trên:

   - **c-Interact**: Tương tác hội thoại là chế độ thụ động với luồng công việc cố định. Mã nguồn và thông tin chi tiết có tại `bird_interact_conv`.
   - **a-Interact**: Tương tác đại lý là chế độ chủ động nhập vai, luồng công việc động và do mô hình dẫn dắt. Mã nguồn và thông tin chi tiết có tại `bird_interact_agent`.


### 🐣 Phiên bản nhẹ

Chúng tôi phát hành phiên bản nhẹ của BIRD-INTERACT, `bird-interact-lite-exp`, bao gồm 270 tác vụ thực tế chất lượng cao dành riêng cho PostgreSQL. Đây là điểm khởi đầu tốt để thử nghiệm nhanh.

### 🦜 Phiên bản đầy đủ

Phiên bản đầy đủ của BIRD-INTERACT, `bird-interact-full`, là bộ chuẩn toàn diện bao gồm 600 tác vụ cho PostgreSQL. Nó bao phủ đa dạng các thao tác SQL và truy vấn người dùng. Phiên bản đầy đủ sẽ ra mắt sớm.

### Kết quả hiệu suất mô hình trên BIRD-INTERACT-FULL

#### 1. **Hiệu suất c-Interact Text-to-SQL**
| Hạng | Tên Mô hình         | Phần thưởng Chuẩn hóa | Chi phí TB (USD)/Nhiệm vụ | Cấp độ               |
|:----:|:--------------------|:---------------------:|:-------------------------:|:--------------------:|
| 1    | Gemini-2.5-Pro      | 20.92                 | $0.04                     | 🏆 Chat Xuất sắc     |
| 2    | O3-Mini             | 20.27                 | $0.07                     | 🏆 Chat Xuất sắc     |
| 3    | Claude-Sonnet-4     | 18.35                 | $0.29                     | 💎 Chat Tốt          |
| 4    | Qwen-3-Coder-480B   | 17.75                 | $0.11                     | 💎 Chat Tốt          |
| 5    | Deepseek-Chat-V3.1  | 15.15                 | $0.12                     | ✨ Tiêu chuẩn         |
| 6    | Claude-Sonnet-3.7   | 13.87                 | $0.29                     | ✨ Tiêu chuẩn         |
| 7    | GPT-5               | 12.58                 | $0.08                     | ⚪ Cơ bản             |

#### 2. **Hiệu suất a-Interact Text-to-SQL**
| Hạng | Tên Mô hình         | Phần thưởng Chuẩn hóa | Chi phí TB (USD)/Nhiệm vụ | Cấp độ                      |
|:----:|:--------------------|:---------------------:|:-------------------------:|:---------------------------:|
| 1    | GPT-5               | 25.52                 | $0.24                     | 🏆 Tương tác Xuất sắc       |
| 2    | Claude-Sonnet-4     | 23.28                 | $0.51                     | 🏆 Tương tác Xuất sắc       |
| 3    | Claude-Sonnet-3.7   | 17.45                 | $0.60                     | 💎 Tương tác Tốt            |
| 4    | Gemini-2.5-Pro      | 17.33                 | $0.22                     | 💎 Tương tác Tốt            |
| 5    | O3-Mini             | 16.43                 | $0.06                     | ✨ Tiêu chuẩn                |
| 6    | Deepseek-Chat-V3.1  | 13.47                 | $0.06                     | ✨ Tiêu chuẩn                |
| 7    | Qwen-3-Coder-480B   | 10.58                 | $0.07                     | ⚪ Cơ bản                    |

> \* Tham số ngân sách: Ngân sách ban đầu/Ngân sách kiên nhẫn người dùng, được đo bằng đơn vị tiền ảo *bird-coin*s <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;">. Xem thêm tại [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting) để biết chi tiết.

### Tăng quy mô Thời gian Tương tác (ITS)

Tăng quy mô Thời gian Tương tác (ITS) là khả năng của mô hình liên tục nâng cao hiệu suất cuối cùng thông qua các lượt tương tác đa vòng. Khi hiệu suất tương tác này vượt qua hiệu suất lý tưởng hóa của mô hình trong một lượt đơn trên tác vụ đầy đủ, rõ ràng, chúng tôi nói rằng nó thỏa mãn **định luật ITS**. Khi sự kiên nhẫn của người dùng tăng và số lượt tương tác tích lũy, hiệu suất tiếp tục được cải thiện, chứng tỏ mô hình có thể duy trì giao tiếp hiệu quả qua đối thoại kéo dài. Hiện tại, chỉ claude-3-7-sonnet thỏa mãn định luật ITS.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## Thiết lập môi trường

1. Khởi chạy các container Docker cho cơ sở dữ liệu bird-interact-lite, cơ sở dữ liệu bird-interact-full và môi trường đánh giá:
  
  > Nếu bạn chỉ muốn đánh giá trên `bird-interact-lite`, bạn có thể comment dịch vụ [`postgresql_full`](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/./env/docker-compose.yml#L21-L31) trong `docker-compose.yml` để tăng tốc thiết lập môi trường.
  
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
     - 📈 Tổng số CSDL: 18
     - 📋 Tổng số Bảng: 175
     - 🔢 Tổng số Cột: 2286
     - 📈 Số dòng trung bình mỗi bảng: 1.038,48
     - 💾 Tổng dung lượng: 207,15 MB (xấp xỉ)
   - **bird-interact-full**: 
     - 📈 Tổng số CSDL: 22
     - 📋 Tổng số Bảng: 244
     - 🔢 Tổng số Cột: 2011
     - 📈 Số dòng trung bình mỗi bảng: 1.121,19
     - 💾 Tổng dung lượng: 272,00 MB (xấp xỉ)


## 📦 Chi tiết Bộ Dữ Liệu

### Mô tả Bộ Dữ Liệu

- **CSDL:** Toàn bộ cơ sở dữ liệu PostgreSQL có thể tải xuống từ [bird-interact-lite](https://drive.google.com/file/d/1QIGQlRKbkqApAOrQXPqFJgUg8rQ7HRRZ/view) và [bird-interact-full](https://drive.google.com/file/d/1V9SFIWebi27JtaDUAScG1xE9ELbYcWLR/view).
- **data:** Mỗi mẫu dữ liệu bao gồm các phần chính sau:
   - `selected_database`: Tên của cơ sở dữ liệu.  
   - `query`: Câu truy vấn người dùng không mơ hồ.  
   - `amb_user_query`: Câu truy vấn người dùng đã được tiêm nhiễu mơ hồ.
   - `user_query_ambiguity`: Các điểm mơ hồ được tiêm vào truy vấn người dùng.
   - `non_critical_ambiguity`: Các mơ hồ không quan trọng như order, limit, v.v.
   - `knowledge_ambiguity`: Các điểm mơ hồ do kiến thức bên ngoài bị che giấu tạo ra. 
   - `sol_sql`: Giải pháp SQL chuẩn xác.  
   - `preprocess_sql`: Các truy vấn SQL cần chạy trước khi thực thi giải pháp hoặc dự đoán.  
   - `clean_up_sql`: Các truy vấn SQL cần chạy sau khi kiểm thử để hoàn nguyên thay đổi trên CSDL.  
   - `test_cases`: Tập hợp các trường hợp kiểm thử để xác thực SQL dự đoán đã sửa.
   - `follow_up`: Các câu hỏi tiếp theo đã được gán nhãn.
   - `external_knowledge`: Kiến thức bên ngoài liên quan đến tác vụ cụ thể.

- **evaluation:** Mã đánh giá có trong thư mục [`./evaluation`](./evaluation).
- **Được biên soạn bởi:** Nhóm BIRD & Google Cloud
- **Giấy phép:** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **Thẻ Bộ Dữ Liệu HuggingFace:** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)
  và [bird-interact-full](https://huggingface.co/datasets/birdsql/bird-interact-full) cho PostgreSQL; và [mini-interact](https://huggingface.co/datasets/birdsql/mini-interact) cho SQLite.
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
├── BIRD-Interact-ADK
│   ├── ...
│   └── README.md
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
Các chi tiết về cách chạy **a-interact** có thể được tìm thấy trong `./bird_interact_agent/README.md`; **c-interact** có thể được tìm thấy trong `./bird_interact_conv/README.md`; và **triển khai dựa trên ADK** có thể được tìm thấy trong `./BIRD-Interact-ADK/README.md`.

## 📋 Danh sách việc cần làm

- [x] Phát hành phiên bản lite, bird-interact-lite (270).
- [x] Phát hành phiên bản hội thoại, bird-interact-conv.
- [x] Phát hành phiên bản agent, bird-interact-agent.
- [x] Phát hành đầy đủ bird-interact-full (600).
- [x] Phát hành triển khai dựa trên ADK, BIRD-Interact-ADK.
- [ ] SFT / RL một User Simulator

## Lời cảm ơn
Chúng tôi xin bày tỏ lòng biết ơn chân thành đến **Irina Saparina**, **Mohammadreza Pourreza**, **Mehdi Bouzouina**, **Hailong Li**, **Jiatong Shi**, và Giáo sư **Shinji Watanabe** vì những cuộc thảo luận hữu ích và những đóng góp quý giá đã giúp cải thiện dự án này.

## Được tạo bởi:
Nhóm BIRD & Google Cloud







## Trích dẫn

```bibtex
@inproceedings{
huo2026birdinteract,
title={{BIRD}-{INTERACT}: Re-imagining Text-to-{SQL} Evaluation via Lens of Dynamic Interactions},
author={Nan Huo and Xiaohan Xu and Jinyang Li and Per Jacobsson and Shipei Lin and Bowen Qin and Binyuan Hui and Xiaolong Li and Ge Qu and Shuzheng Si and Linheng Han and Edward Alexander and Xintong Zhu and Rui Qin and Ruihan Yu and Yiyao Jin and Feige Zhou and Weihao Zhong and Yun Chen and Hongyu Liu and Chenhao Ma and Fatma Ozcan and Yannis Papakonstantinou and Reynold Cheng},
booktitle={The Fourteenth International Conference on Learning Representations},
year={2026},
url={https://openreview.net/forum?id=nHrYBGujps}
}
```

## Nhật ký thay đổi

- [2025-11-06] 🐛 **Sửa lỗi** & 🐳 **Cập nhật Docker**: Cập nhật phiên bản sqlglot lên 26.16.4 để sửa lỗi trình phân tích cú pháp SQL không thể phân tích đúng SQL cho trình giả lập người dùng. Bạn có thể sửa lỗi này bằng cách cài đặt lại bằng `pip install sqlglot==26.16.4` trong môi trường `bird_interact_eval`. Ảnh `bird_interact_eval` cũng đã được cập nhật, vì vậy bạn cũng có thể kéo về và tạo lại container `bird_interact_eval`.
- [2025-10-21] 🐳 **Cập nhật Docker**: Thêm docker cho môi trường Full DB. Và chúng tôi đã đẩy 3 ảnh docker (Base/Full DB Env và môi trường đánh giá cho cả `a-Interact` và `c-Interact`) lên Docker Hub để hỗ trợ việc thiết lập môi trường. Không cần tải DB dumps và tự xây dựng ảnh nữa! Vui lòng kéo về các ảnh mới nhất từ Docker Hub và tạo lại các container, ví dụ sử dụng `docker compose down -v && docker compose pull && docker compose up -d --force-recreate`.
- [2025-08-22]  🐛 **Sửa lỗi**: Sửa lỗi khi đánh giá SQL giai đoạn 2, SQL đã lưu ở giai đoạn 1 không thể thực thi thành công, dẫn đến tỷ lệ thành công thấp ở Giai đoạn 2. Lỗi này chỉ ảnh hưởng đến các tác vụ mà SQL giai đoạn 1 thực hiện một số thao tác trên cơ sở dữ liệu, ví dụ như CREATE table, v.v.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-03

---