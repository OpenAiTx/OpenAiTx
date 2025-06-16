# AgenticSeek: Giải pháp thay thế Manus riêng tư, cục bộ.

<p align="center">
<img align="center" src="https://raw.githubusercontent.com/Fosowl/agenticSeek/main/media/agentic_seek_logo.png" width="300" height="300" alt="Agentic Seek Logo">
<p>

  English | [中文](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_CHS.md) | [繁體中文](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_CHT.md) | [Français](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_FR.md) | [日本語](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_JP.md) | [Português (Brasil)](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_PTBR.md) | [Español](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_ES.md)

*Một **giải pháp thay thế Manus AI 100% cục bộ**, trợ lý AI kích hoạt giọng nói này tự động duyệt web, viết mã, và lập kế hoạch công việc, đồng thời giữ tất cả dữ liệu trên thiết bị của bạn. Tối ưu cho các mô hình suy luận cục bộ, chương trình chạy hoàn toàn trên phần cứng của bạn, đảm bảo quyền riêng tư tuyệt đối và không phụ thuộc vào đám mây.*

[![Truy cập AgenticSeek](https://img.shields.io/static/v1?label=Website&message=AgenticSeek&color=blue&style=flat-square)](https://fosowl.github.io/agenticSeek.html) ![License](https://img.shields.io/badge/license-GPL--3.0-green) [![Discord](https://img.shields.io/badge/Discord-Join%20Us-7289DA?logo=discord&logoColor=white)](https://discord.gg/8hGDaME3TC) [![Twitter](https://img.shields.io/twitter/url/https/twitter.com/fosowl.svg?style=social&label=Update%20%40Fosowl)](https://x.com/Martin993886460) [![GitHub stars](https://img.shields.io/github/stars/Fosowl/agenticSeek?style=social)](https://github.com/Fosowl/agenticSeek/stargazers)

### Vì sao chọn AgenticSeek?

* 🔒 Hoàn toàn cục bộ & riêng tư - Mọi thứ đều chạy trên máy của bạn — không đám mây, không chia sẻ dữ liệu. Tệp tin, cuộc trò chuyện, và tìm kiếm của bạn luôn được bảo mật.

* 🌐 Duyệt web thông minh - AgenticSeek có thể tự động duyệt web — tìm kiếm, đọc, trích xuất thông tin, điền biểu mẫu — hoàn toàn rảnh tay.

* 💻 Trợ lý lập trình tự động - Cần mã nguồn? Nó có thể viết, gỡ lỗi, và chạy chương trình Python, C, Go, Java và nhiều hơn nữa — hoàn toàn tự động.

* 🧠 Chọn tác vụ thông minh - Bạn hỏi, nó tự động chọn tác nhân phù hợp nhất. Như có một đội ngũ chuyên gia luôn sẵn sàng hỗ trợ.

* 📋 Lập kế hoạch & thực thi tác vụ phức tạp - Từ lên kế hoạch du lịch đến dự án lớn — nó có thể chia nhỏ công việc và hoàn thành bằng nhiều tác nhân AI.

* 🎙️ Kích hoạt bằng giọng nói - Giọng nói sạch, nhanh, hiện đại và chuyển đổi giọng nói thành văn bản, cho phép bạn trò chuyện với nó như AI cá nhân trong phim khoa học viễn tưởng. (Đang phát triển)

### **Demo**

> *Bạn có thể tìm kiếm dự án agenticSeek, tìm hiểu các kỹ năng cần thiết, sau đó mở CV_candidates.zip và cho tôi biết ai phù hợp nhất với dự án không?*

https://github.com/user-attachments/assets/b8ca60e9-7b3b-4533-840e-08f9ac426316

Lưu ý: Demo này, bao gồm mọi tệp xuất hiện (vd: CV_candidates.zip), đều là hư cấu. Chúng tôi không phải công ty, chúng tôi tìm kiếm cộng tác viên mã nguồn mở chứ không phải ứng viên.

> 🛠⚠️️ **Đang phát triển tích cực**

> 🙏 Dự án này bắt đầu như một dự án phụ, không có lộ trình và không có tài trợ. Nó phát triển ngoài mong đợi khi xuất hiện trên GitHub Trending. Rất cảm ơn sự đóng góp, phản hồi và kiên nhẫn của bạn.

## Yêu cầu trước khi cài đặt

Trước khi bắt đầu, hãy đảm bảo bạn đã cài đặt các phần mềm sau:

*   **Git:** Để nhân bản kho mã. [Tải Git](https://git-scm.com/downloads)
*   **Python 3.10.x:** Chúng tôi khuyến nghị sử dụng Python phiên bản 3.10.x. Sử dụng phiên bản khác có thể gây lỗi phụ thuộc. [Tải Python 3.10](https://www.python.org/downloads/release/python-3100/) (chọn phiên bản 3.10.x).
*   **Docker Engine & Docker Compose:** Để chạy các dịch vụ đi kèm như SearxNG.
    *   Cài đặt Docker Desktop (bao gồm Docker Compose V2): [Windows](https://docs.docker.com/desktop/install/windows-install/) | [Mac](https://docs.docker.com/desktop/install/mac-install/) | [Linux](https://docs.docker.com/desktop/install/linux-install/)
    *   Hoặc, cài đặt Docker Engine và Docker Compose riêng trên Linux: [Docker Engine](https://docs.docker.com/engine/install/) | [Docker Compose](https://docs.docker.com/compose/install/) (đảm bảo cài đặt Compose V2, ví dụ: `sudo apt-get install docker-compose-plugin`).

### 1. **Nhân bản kho mã và thiết lập**

```sh
git clone https://github.com/Fosowl/agenticSeek.git
cd agenticSeek
mv .env.example .env
```

### 2. Thay đổi nội dung tệp .env

```sh
SEARXNG_BASE_URL="http://127.0.0.1:8080"
REDIS_BASE_URL="redis://redis:6379/0"
WORK_DIR="/Users/mlg/Documents/workspace_for_ai"
OLLAMA_PORT="11434"
LM_STUDIO_PORT="1234"
CUSTOM_ADDITIONAL_LLM_PORT="11435"
OPENAI_API_KEY='optional'
DEEPSEEK_API_KEY='optional'
OPENROUTER_API_KEY='optional'
TOGETHER_API_KEY='optional'
GOOGLE_API_KEY='optional'
ANTHROPIC_API_KEY='optional'
```

Cập nhật tệp `.env` với giá trị của bạn nếu cần:

- **SEARXNG_BASE_URL**: Giữ nguyên 
- **REDIS_BASE_URL**: Giữ nguyên 
- **WORK_DIR**: Đường dẫn tới thư mục làm việc trên máy của bạn. AgenticSeek sẽ có thể đọc và tương tác với các tệp này.
- **OLLAMA_PORT**: Số cổng cho dịch vụ Ollama.
- **LM_STUDIO_PORT**: Số cổng cho dịch vụ LM Studio.
- **CUSTOM_ADDITIONAL_LLM_PORT**: Cổng cho dịch vụ LLM tùy chỉnh bổ sung.

**API Key hoàn toàn tùy chọn cho người dùng chọn chạy LLM cục bộ. Đây là mục đích chính của dự án này. Để trống nếu phần cứng của bạn đủ mạnh**

### 3. **Khởi động Docker**

Đảm bảo Docker đã được cài đặt và chạy trên hệ thống. Bạn có thể khởi động Docker bằng các lệnh sau:

- **Trên Linux/macOS:**  
    Mở terminal và chạy:
    ```sh
    sudo systemctl start docker
    ```
    Hoặc khởi động Docker Desktop từ menu ứng dụng nếu đã cài đặt.

- **Trên Windows:**  
    Mở Docker Desktop từ menu Start.

Bạn có thể kiểm tra Docker đang chạy bằng cách thực hiện:
```sh
docker info
```
Nếu bạn thấy thông tin về cài đặt Docker, Docker đã chạy đúng.

Xem bảng [Các nhà cung cấp cục bộ](#list-of-local-providers) bên dưới để tóm tắt.

Bước tiếp theo: [Chạy AgenticSeek cục bộ](#start-services-and-run)

*Xem mục [Khắc phục sự cố](#troubleshooting) nếu bạn gặp vấn đề.*
*Nếu phần cứng của bạn không thể chạy LLM cục bộ, xem [Thiết lập chạy bằng API](#setup-to-run-with-an-api).*
*Để giải thích chi tiết `config.ini`, xem [Phần Cấu hình](#config).*

---

## Thiết lập để chạy LLM cục bộ trên máy của bạn

**Yêu cầu phần cứng:**

Để chạy LLM cục bộ, bạn cần phần cứng đủ mạnh. Tối thiểu, cần GPU đủ để chạy Magistral, Qwen hoặc Deepseek 14B. Xem FAQ để biết khuyến nghị về mô hình/hiệu suất chi tiết.

**Thiết lập nhà cung cấp cục bộ của bạn**  

Khởi động nhà cung cấp cục bộ, ví dụ với ollama:

```sh
ollama serve
```

Xem bên dưới danh sách các nhà cung cấp cục bộ được hỗ trợ.

**Cập nhật config.ini**

Thay đổi tệp config.ini để thiết lập provider_name thành nhà cung cấp hỗ trợ và provider_model thành LLM được nhà cung cấp hỗ trợ. Chúng tôi khuyến nghị các mô hình suy luận như *Magistral* hoặc *Deepseek*.

Xem **FAQ** cuối README để biết phần cứng cần thiết.

```sh
[MAIN]
is_local = True # Khi bạn chạy cục bộ hoặc bằng nhà cung cấp từ xa.
provider_name = ollama # hoặc lm-studio, openai, v.v..
provider_model = deepseek-r1:14b # chọn mô hình phù hợp phần cứng của bạn
provider_server_address = 127.0.0.1:11434
agent_name = Jarvis # tên AI của bạn
recover_last_session = True # có khôi phục phiên trước không
save_session = True # có lưu phiên hiện tại không
speak = False # chuyển văn bản thành giọng nói
listen = False # chuyển giọng nói thành văn bản, chỉ cho CLI, thử nghiệm
jarvis_personality = False # Có dùng tính cách "Jarvis" hơn không (thử nghiệm)
languages = en zh # Danh sách ngôn ngữ, chuyển văn bản thành giọng nói mặc định lấy ngôn ngữ đầu tiên
[BROWSER]
headless_browser = True # giữ nguyên nếu dùng CLI trên host.
stealth_mode = True # Dùng selenium không bị phát hiện để giảm nhận diện trình duyệt
```

**Cảnh báo**:

- Định dạng tệp `config.ini` không hỗ trợ chú thích. 
Không sao chép và dán cấu hình mẫu trực tiếp, vì chú thích sẽ gây lỗi. Hãy chỉnh sửa thủ công tệp `config.ini` với thiết lập mong muốn, không bao gồm chú thích.

- *KHÔNG* đặt provider_name thành `openai` nếu dùng LM-studio để chạy LLM. Hãy đặt thành `lm-studio`.

- Một số nhà cung cấp (vd: lm-studio) yêu cầu bạn phải có `http://` trước địa chỉ IP. Ví dụ: `http://127.0.0.1:1234`

**Danh sách các nhà cung cấp cục bộ**

| Nhà cung cấp | Cục bộ? | Mô tả                                                         |
|--------------|--------|----------------------------------------------------------------|
| ollama       | Có     | Chạy LLM cục bộ dễ dàng bằng ollama làm nhà cung cấp LLM       |
| lm-studio    | Có     | Chạy LLM cục bộ bằng LM studio (đặt `provider_name` là `lm-studio`)|
| openai       | Có     | Dùng API tương thích openai (vd: llama.cpp server)             |

Bước tiếp theo: [Khởi động dịch vụ và chạy AgenticSeek](#Start-services-and-Run)  

*Xem mục [Khắc phục sự cố](#troubleshooting) nếu bạn gặp vấn đề.*
*Nếu phần cứng của bạn không thể chạy LLM cục bộ, xem [Thiết lập chạy bằng API](#setup-to-run-with-an-api).*
*Để giải thích chi tiết `config.ini`, xem [Phần Cấu hình](#config).*

## Thiết lập chạy bằng API

Cách này dùng các nhà cung cấp LLM bên ngoài, dựa trên đám mây. Bạn cần API key từ dịch vụ bạn chọn.

**1. Chọn nhà cung cấp API và lấy API Key:**

Tham khảo [Danh sách nhà cung cấp API](#list-of-api-providers) bên dưới. Truy cập trang web của họ để đăng ký và nhận API key.

**2. Thiết lập API Key dưới dạng biến môi trường:**


*   **Linux/macOS:**
    Mở terminal và dùng lệnh `export`. Nên thêm vào tệp cấu hình shell của bạn (vd: `~/.bashrc`, `~/.zshrc`) để duy trì lâu dài.
    ```sh
    export PROVIDER_API_KEY="your_api_key_here" 
    # Thay PROVIDER_API_KEY bằng tên biến cụ thể, vd: OPENAI_API_KEY, GOOGLE_API_KEY
    ```
    Ví dụ cho TogetherAI:
    ```sh
    export TOGETHER_API_KEY="xxxxxxxxxxxxxxxxxxxxxx"
    ```
*   **Windows:**
*   **Command Prompt (Tạm thời cho phiên làm việc hiện tại):**
    ```cmd
    set PROVIDER_API_KEY=your_api_key_here
    ```
*   **PowerShell (Tạm thời cho phiên làm việc hiện tại):**
    ```powershell
    $env:PROVIDER_API_KEY="your_api_key_here"
    ```
*   **Thiết lập vĩnh viễn:** Tìm kiếm "environment variables" trên thanh tìm kiếm của Windows, nhấn "Edit the system environment variables," sau đó nhấn nút "Environment Variables...". Thêm một biến người dùng mới với tên phù hợp (ví dụ: `OPENAI_API_KEY`) và giá trị là khóa API của bạn.

*(Xem mục FAQ: [Làm thế nào để thiết lập API keys?](#how-do-i-set-api-keys) để biết thêm chi tiết).*

**3. Cập nhật `config.ini`:**
```ini
[MAIN]
is_local = False
provider_name = openai # Hoặc google, deepseek, togetherAI, huggingface
provider_model = gpt-3.5-turbo # Hoặc gemini-1.5-flash, deepseek-chat, mistralai/Mixtral-8x7B-Instruct-v0.1 v.v.
provider_server_address = # Thường bị bỏ qua hoặc để trống khi is_local = False đối với hầu hết API
# ... các thiết lập khác ...
```
*Cảnh báo:* Đảm bảo không có dấu cách thừa ở cuối các giá trị trong `config.ini`.

**Danh sách các nhà cung cấp API**

| Nhà cung cấp  | `provider_name` | Local? | Mô tả                                               | Liên kết lấy API Key (Ví dụ)                |
|---------------|-----------------|--------|-----------------------------------------------------|---------------------------------------------|
| OpenAI        | `openai`        | Không  | Sử dụng mô hình ChatGPT qua API của OpenAI.         | [platform.openai.com/signup](https://platform.openai.com/signup) |
| Google Gemini | `google`        | Không  | Sử dụng mô hình Google Gemini qua Google AI Studio. | [aistudio.google.com/keys](https://aistudio.google.com/keys) |
| Deepseek      | `deepseek`      | Không  | Sử dụng mô hình Deepseek qua API của họ.            | [platform.deepseek.com](https://platform.deepseek.com) |
| Hugging Face  | `huggingface`   | Không  | Sử dụng mô hình từ Hugging Face Inference API.      | [huggingface.co/settings/tokens](https://huggingface.co/settings/tokens) |
| TogetherAI    | `togetherAI`    | Không  | Sử dụng nhiều mô hình mã nguồn mở qua TogetherAI API.| [api.together.ai/settings/api-keys](https://api.together.ai/settings/api-keys) |

*Lưu ý:*
*   Chúng tôi khuyến cáo không nên sử dụng `gpt-4o` hoặc các mô hình OpenAI khác cho các tác vụ duyệt web phức tạp và lập kế hoạch nhiệm vụ vì tối ưu prompt hiện tại phù hợp hơn với các mô hình như Deepseek.
*   Các tác vụ coding/bash có thể gặp vấn đề với Gemini, do nó có thể không tuân thủ chặt chẽ định dạng prompt đã tối ưu cho Deepseek.
*   Trường `provider_server_address` trong `config.ini` thường không được sử dụng khi `is_local = False` vì endpoint API thường đã được cố định trong thư viện của từng nhà cung cấp.

Bước tiếp theo: [Khởi động dịch vụ và chạy AgenticSeek](#Start-services-and-Run)

*Xem mục **Vấn đề đã biết** nếu bạn gặp vấn đề*

*Xem mục **Config** để giải thích chi tiết về file cấu hình.*

---

## Khởi động dịch vụ và chạy

Theo mặc định, AgenticSeek được chạy hoàn toàn trong docker.

Khởi động các dịch vụ cần thiết. Lệnh này sẽ khởi động tất cả dịch vụ từ docker-compose.yml, bao gồm:
    - searxng
    - redis (bắt buộc bởi searxng)
    - frontend
    - backend (nếu dùng `full`)

```sh
./start_services.sh full # MacOS
start ./start_services.cmd full # Window
```

**Cảnh báo:** Bước này sẽ tải về và load tất cả Docker image, có thể mất tới 30 phút. Sau khi khởi động các dịch vụ, vui lòng chờ cho đến khi dịch vụ backend chạy hoàn toàn (bạn sẽ thấy **backend: "GET /health HTTP/1.1" 200 OK** trong log) trước khi gửi bất kỳ tin nhắn nào. Dịch vụ backend có thể mất 5 phút để khởi động lần đầu.

Truy cập `http://localhost:3000/` và bạn sẽ thấy giao diện web.

*Khắc phục sự cố khi khởi động dịch vụ:* Nếu các script này bị lỗi, hãy đảm bảo Docker Engine đang chạy và Docker Compose (V2, `docker compose`) đã được cài đặt đúng. Kiểm tra thông báo lỗi trên terminal. Xem [FAQ: Help! Tôi gặp lỗi khi chạy AgenticSeek hoặc các script của nó.](#faq-troubleshooting)

**Tùy chọn:** Chạy trên máy chủ (chế độ CLI):

Để chạy với giao diện CLI, bạn cần cài đặt package trên máy chủ:

```sh
./install.sh
./install.bat # windows
```

Khởi động dịch vụ:

```sh
./start_services.sh # MacOS
start ./start_services.cmd # Window
```

Sử dụng CLI: `python3 cli.py`


---

## Sử dụng

Đảm bảo các dịch vụ đã được khởi động với `./start_services.sh full` và truy cập `localhost:3000` cho giao diện web.

Bạn cũng có thể sử dụng chức năng chuyển giọng nói thành văn bản bằng cách đặt `listen = True` trong file config. Chức năng này chỉ hỗ trợ ở chế độ CLI.

Để thoát, chỉ cần nói/gõ `goodbye`.

Dưới đây là một số ví dụ sử dụng:

> *Hãy tạo một trò chơi rắn săn mồi bằng python!*

> *Tìm kiếm trên web các quán cà phê hàng đầu ở Rennes, Pháp, và lưu danh sách ba quán cùng địa chỉ vào rennes_cafes.txt.*

> *Viết một chương trình Go để tính giai thừa của một số, lưu lại với tên factorial.go trong thư mục làm việc của bạn*

> *Tìm kiếm trong thư mục summer_pictures của tôi tất cả các file JPG, đổi tên chúng với ngày hôm nay, và lưu danh sách các file đã đổi tên vào photos_list.txt*

> *Tìm kiếm trực tuyến các phim khoa học viễn tưởng nổi tiếng năm 2024 và chọn ba phim để xem tối nay. Lưu danh sách vào movie_night.txt.*

> *Tìm kiếm trên web các bài báo AI mới nhất năm 2025, chọn ba bài, và viết một script Python để lấy tiêu đề và tóm tắt của chúng. Lưu script thành news_scraper.py và các bản tóm tắt vào ai_news.txt trong /home/projects*

> *Thứ Sáu, tìm kiếm trên web một API giá cổ phiếu miễn phí, đăng ký với supersuper7434567@gmail.com rồi viết một script Python để lấy giá Tesla hàng ngày bằng API này và lưu kết quả vào stock_prices.csv*

*Lưu ý rằng khả năng điền form vẫn đang thử nghiệm và có thể bị lỗi.*

Sau khi bạn nhập truy vấn, AgenticSeek sẽ phân bổ agent phù hợp nhất cho tác vụ.

Vì đây là bản prototype sớm, hệ thống định tuyến agent có thể không luôn phân bổ đúng agent dựa trên truy vấn của bạn.

Do đó, bạn nên diễn đạt thật rõ ràng điều bạn muốn và AI nên thực hiện như thế nào. Ví dụ, nếu bạn muốn nó tìm kiếm web, đừng nói:

`Bạn có biết những quốc gia nào tốt cho du lịch một mình không?`

Thay vào đó, hãy hỏi:

`Tìm kiếm trên web và cho biết quốc gia nào tốt nhất cho du lịch một mình`

---

## **Thiết lập để chạy LLM trên máy chủ riêng của bạn**  

Nếu bạn có một máy tính mạnh hoặc một máy chủ có thể sử dụng, nhưng muốn dùng nó từ laptop, bạn có thể chạy LLM trên máy chủ từ xa thông qua llm server tùy chỉnh của chúng tôi.

Trên "máy chủ" sẽ chạy mô hình AI, lấy địa chỉ ip:

```sh
ip a | grep "inet " | grep -v 127.0.0.1 | awk '{print $2}' | cut -d/ -f1 # ip cục bộ
curl https://ipinfo.io/ip # ip công cộng
```

Lưu ý: Với Windows hoặc macOS, dùng ipconfig hoặc ifconfig tương ứng để tìm địa chỉ IP.

Clone repository và vào thư mục `server/`.

```sh
git clone --depth 1 https://github.com/Fosowl/agenticSeek.git
cd agenticSeek/llm_server/
```

Cài đặt các yêu cầu riêng cho server:

```sh
pip3 install -r requirements.txt
```

Chạy script server.

```sh
python3 app.py --provider ollama --port 3333
```

Bạn có thể lựa chọn giữa việc sử dụng `ollama` và `llamacpp` làm dịch vụ LLM.


Bây giờ trên máy cá nhân của bạn:

Thay đổi file `config.ini` để đặt `provider_name` thành `server` và `provider_model` thành `deepseek-r1:xxb`.
Đặt `provider_server_address` là địa chỉ ip của máy sẽ chạy mô hình.

```sh
[MAIN]
is_local = False
provider_name = server
provider_model = deepseek-r1:70b
provider_server_address = x.x.x.x:3333
```

Bước tiếp theo: [Khởi động dịch vụ và chạy AgenticSeek](#Start-services-and-Run)  

---

## Chuyển giọng nói thành văn bản

Cảnh báo: chức năng chuyển giọng nói thành văn bản chỉ hoạt động ở chế độ CLI hiện tại.

Lưu ý rằng hiện tại chức năng này chỉ hỗ trợ tiếng Anh.

Chức năng chuyển giọng nói thành văn bản bị tắt theo mặc định. Để bật, hãy đặt tùy chọn listen thành True trong file config.ini:

```
listen = True
```

Khi được bật, chức năng này sẽ lắng nghe từ khóa kích hoạt, chính là tên agent, trước khi bắt đầu xử lý đầu vào của bạn. Bạn có thể tùy chỉnh tên agent bằng cách cập nhật giá trị `agent_name` trong file *config.ini*:

```
agent_name = Friday
```

Để nhận diện tốt nhất, chúng tôi khuyến nghị sử dụng tên tiếng Anh phổ biến như "John" hoặc "Emma" làm tên agent

Khi bạn thấy bản ghi bắt đầu xuất hiện, hãy nói to tên agent để đánh thức nó (ví dụ: "Friday").

Phát biểu truy vấn của bạn một cách rõ ràng.

Kết thúc yêu cầu của bạn bằng một cụm xác nhận để báo hiệu hệ thống tiến hành. Ví dụ về cụm xác nhận bao gồm:
```
"do it", "go ahead", "execute", "run", "start", "thanks", "would ya", "please", "okay?", "proceed", "continue", "go on", "do that", "go it", "do you understand?"
```

## Config

Ví dụ cấu hình:
```
[MAIN]
is_local = True
provider_name = ollama
provider_model = deepseek-r1:32b
provider_server_address = http://127.0.0.1:11434 # Ví dụ cho Ollama; dùng http://127.0.0.1:1234 cho LM-Studio
agent_name = Friday
recover_last_session = False
save_session = False
speak = False
listen = False

jarvis_personality = False
languages = en zh # Danh sách ngôn ngữ cho TTS và có thể dùng cho định tuyến.
[BROWSER]
headless_browser = False
stealth_mode = False
```

**Giải thích các thiết lập trong `config.ini`**:

*   **Phần `[MAIN]`:**
    *   `is_local`: `True` nếu sử dụng nhà cung cấp LLM nội bộ (Ollama, LM-Studio, máy chủ tương thích OpenAI cục bộ) hoặc tùy chọn máy chủ tự host. `False` nếu sử dụng API đám mây (OpenAI, Google, v.v.).
    *   `provider_name`: Chỉ định nhà cung cấp LLM.
        *   Tùy chọn nội bộ: `ollama`, `lm-studio`, `openai` (cho máy chủ tương thích OpenAI cục bộ), `server` (cho thiết lập máy chủ tự host).
        *   Tùy chọn API: `openai`, `google`, `deepseek`, `huggingface`, `togetherAI`.
    *   `provider_model`: Tên hoặc ID model cụ thể cho nhà cung cấp đã chọn (vd: `deepseekcoder:6.7b` cho Ollama, `gpt-3.5-turbo` cho OpenAI API, `mistralai/Mixtral-8x7B-Instruct-v0.1` cho TogetherAI).
    *   `provider_server_address`: Địa chỉ của nhà cung cấp LLM.
        *   Với nhà cung cấp nội bộ: vd `http://127.0.0.1:11434` cho Ollama, `http://127.0.0.1:1234` cho LM-Studio.
        *   Với loại `server`: Địa chỉ máy chủ LLM tự host (vd: `http://your_server_ip:3333`).
        *   Với API đám mây (`is_local = False`): Thường bị bỏ qua hoặc để trống, vì endpoint API thường được thư viện client xử lý.
    *   `agent_name`: Tên trợ lý AI (vd: Friday). Dùng như từ kích hoạt cho chuyển giọng nói thành văn bản nếu bật.
    *   `recover_last_session`: `True` để thử khôi phục trạng thái phiên trước, `False` để bắt đầu mới.
    *   `save_session`: `True` để lưu trạng thái phiên hiện tại cho khả năng khôi phục sau này, `False` nếu không.
    *   `speak`: `True` để bật đầu ra giọng nói chuyển văn bản thành giọng nói, `False` để tắt.
    *   `listen`: `True` để bật đầu vào giọng nói chuyển giọng nói thành văn bản (chỉ chế độ CLI), `False` để tắt.
    *   `work_dir`: **Quan trọng:** Thư mục nơi AgenticSeek sẽ đọc/ghi file. **Đảm bảo đường dẫn này hợp lệ và có thể truy cập trên hệ thống của bạn.**
    *   `jarvis_personality`: `True` để sử dụng prompt hệ thống giống "Jarvis" hơn (thử nghiệm), `False` cho prompt chuẩn.
    *   `languages`: Danh sách các ngôn ngữ cách nhau bởi dấu phẩy (vd: `en, zh, fr`). Dùng để chọn giọng TTS (mặc định là ngôn ngữ đầu tiên) và có thể hỗ trợ router LLM. Tránh quá nhiều hoặc các ngôn ngữ quá giống nhau để router hiệu quả hơn.
*   **Phần `[BROWSER]`:**
    *   `headless_browser`: `True` để chạy trình duyệt tự động mà không hiện cửa sổ (khuyến nghị cho giao diện web hoặc sử dụng không tương tác). `False` để hiển thị cửa sổ trình duyệt (hữu ích cho chế độ CLI hoặc debug).
    *   `stealth_mode`: `True` để bật các biện pháp giúp trình duyệt tự động khó bị phát hiện hơn. Có thể yêu cầu cài đặt thủ công extension trình duyệt như anticaptcha.


Phần này tóm tắt các loại nhà cung cấp LLM được hỗ trợ. Hãy cấu hình trong `config.ini`.

**Nhà cung cấp nội bộ (chạy trên phần cứng của bạn):**

| Tên nhà cung cấp trong `config.ini` | `is_local` | Mô tả                                                                  | Phần hướng dẫn cài đặt                                              |
|-------------------------------------|------------|------------------------------------------------------------------------|---------------------------------------------------------------------|
| `ollama`                            | `True`     | Dùng Ollama để phục vụ LLM cục bộ.                                     | [Hướng dẫn chạy LLM nội bộ](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/#setup-for-running-llm-locally-on-your-machine) |
| `lm-studio`                         | `True`     | Dùng LM-Studio để phục vụ LLM cục bộ.                                  | [Hướng dẫn chạy LLM nội bộ](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/#setup-for-running-llm-locally-on-your-machine) |
| `openai` (cho máy chủ nội bộ)       | `True`     | Kết nối đến máy chủ cục bộ cung cấp API tương thích OpenAI (vd: llama.cpp). | [Hướng dẫn chạy LLM nội bộ](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/#setup-for-running-llm-locally-on-your-machine) |
| `server`                            | `False`    | Kết nối đến máy chủ LLM tự host AgenticSeek chạy trên máy khác.        | [Hướng dẫn chạy LLM trên máy chủ riêng](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/#setup-to-run-the-llm-on-your-own-server) |

**Nhà cung cấp API (dựa trên đám mây):**

| Tên nhà cung cấp trong `config.ini` | `is_local` | Mô tả                                       | Phần hướng dẫn cài đặt                                            |
|-------------------------------------|------------|----------------------------------------------|-------------------------------------------------------------------|
| `openai`                            | `False`    | Dùng API chính thức của OpenAI (vd: GPT-3.5, GPT-4). | [Hướng dẫn chạy với API](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/#setup-to-run-with-an-api) |
| `google`                            | `False`    | Dùng mô hình Gemini của Google qua API.      | [Hướng dẫn chạy với API](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/#setup-to-run-with-an-api) |
| `deepseek`                          | `False`    | Dùng API chính thức của Deepseek.            | [Hướng dẫn chạy với API](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/#setup-to-run-with-an-api) |
| `huggingface`                       | `False`    | Dùng Hugging Face Inference API.             | [Hướng dẫn chạy với API](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/#setup-to-run-with-an-api) |
| `togetherAI`                        | `False`    | Dùng TogetherAI API cho nhiều mô hình open.  | [Hướng dẫn chạy với API](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/#setup-to-run-with-an-api) |

---
## Xử lý sự cố

Nếu bạn gặp sự cố, phần này cung cấp hướng dẫn.

# Lỗi đã biết

## Lỗi ChromeDriver

**Ví dụ lỗi:** `SessionNotCreatedException: Message: session not created: This version of ChromeDriver only supports Chrome version XXX`

*   **Nguyên nhân:** Phiên bản ChromeDriver bạn cài đặt không tương thích với phiên bản trình duyệt Google Chrome.
*   **Cách khắc phục:**
    1.  **Kiểm tra phiên bản Chrome:** Mở Google Chrome, vào `Cài đặt > Giới thiệu về Chrome` để xem phiên bản (vd: "Phiên bản 120.0.6099.110").
    2.  **Tải ChromeDriver phù hợp:**
        *   Với Chrome phiên bản 115 trở lên: Truy cập [Chrome for Testing (CfT) JSON Endpoints](https://googlechromelabs.github.io/chrome-for-testing/). Tìm kênh "stable" và tải ChromeDriver cho hệ điều hành của bạn phù hợp với major version của Chrome.
        *   Với các phiên bản cũ hơn (ít gặp): Có thể tìm tại [ChromeDriver - WebDriver for Chrome](https://chromedriver.chromium.org/downloads).
        *   Hình ảnh dưới đây là ví dụ từ trang CfT:
            ![Tải đúng phiên bản Chromedriver từ trang Chrome for Testing](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/media/chromedriver_readme.png)
    3.  **Cài đặt ChromeDriver:**
        *   Đảm bảo file `chromedriver` (hoặc `chromedriver.exe` trên Windows) được đặt vào thư mục nằm trong biến môi trường PATH của hệ thống (vd: `/usr/local/bin` trên Linux/macOS, hoặc thư mục scripts tùy chỉnh đã thêm vào PATH trên Windows).
        *   Hoặc đặt nó vào thư mục gốc của dự án `agenticSeek`.
        *   Đảm bảo driver có quyền thực thi (vd: `chmod +x chromedriver` trên Linux/macOS).
    4.  Tham khảo phần [Cài đặt ChromeDriver](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/#chromedriver-installation) trong hướng dẫn cài đặt chính để biết thêm chi tiết.

Nếu phần này chưa đầy đủ hoặc bạn gặp các vấn đề khác liên quan đến ChromeDriver, vui lòng tìm kiếm các [Issue trên GitHub](https://github.com/Fosowl/agenticSeek/issues) hoặc tạo issue mới.

`Exception: Failed to initialize browser: Message: session not created: This version of ChromeDriver only supports Chrome version 113
Current browser version is 134.0.6998.89 with binary path`

Điều này xảy ra khi phiên bản trình duyệt và chromedriver không khớp nhau.

Bạn cần truy cập để tải phiên bản mới nhất:

https://developer.chrome.com/docs/chromedriver/downloads

Nếu bạn dùng Chrome phiên bản 115 trở lên hãy truy cập:

https://googlechromelabs.github.io/chrome-for-testing/

Và tải chromedriver phiên bản phù hợp với hệ điều hành của bạn.

![alt text](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/media/chromedriver_readme.png)

Nếu phần này chưa đầy đủ vui lòng tạo issue mới.

##  Lỗi connection adapters

```
Exception: Provider lm-studio failed: HTTP request failed: No connection adapters were found for '127.0.0.1:1234/v1/chat/completions'` (Lưu ý: port có thể khác)
```

*   **Nguyên nhân:** Trường `provider_server_address` trong `config.ini` cho `lm-studio` (hoặc các server OpenAI-compatible cục bộ khác) thiếu tiền tố `http://` hoặc trỏ sai cổng.
*   **Cách khắc phục:**
    *   Đảm bảo địa chỉ có tiền tố `http://`. LM-Studio mặc định là `http://127.0.0.1:1234`.
    *   Sửa trong `config.ini`: `provider_server_address = http://127.0.0.1:1234` (hoặc đúng port server của bạn).

## Không cung cấp SearxNG Base URL

```
raise ValueError("SearxNG base URL must be provided either as an argument or via the SEARXNG_BASE_URL environment variable.")
ValueError: SearxNG base URL must be provided either as an argument or via the SEARXNG_BASE_URL environment variable.`
```

## Câu hỏi thường gặp (FAQ)

**Hỏi: Tôi cần phần cứng gì?**  

| Kích cỡ Model | GPU         | Ghi chú                                                                                   |
|---------------|-------------|------------------------------------------------------------------------------------------|
| 7B            | 8GB Vram    | ⚠️ Không khuyến nghị. Hiệu năng yếu, dễ sinh ảo giác, agent lập kế hoạch có thể thất bại. |
| 14B           | 12GB Vram (vd RTX 3060) | ✅ Dùng cho tác vụ đơn giản. Có thể gặp khó với duyệt web và lập kế hoạch.           |
| 32B           | 24+GB Vram (vd RTX 4090) | 🚀 Thành công với hầu hết tác vụ, vẫn có thể khó với lập kế hoạch phức tạp.         |
| 70B+          | 48+GB Vram  | 💪 Xuất sắc. Khuyến nghị cho các trường hợp nâng cao.                                     |

**Hỏi: Tôi bị lỗi thì làm gì?**  

Đảm bảo dịch vụ cục bộ đang chạy (`ollama serve`), `config.ini` trùng khớp với nhà cung cấp, và đã cài đủ phụ thuộc. Nếu vẫn không được hãy tạo issue mới.

**Hỏi: Có thực sự chạy 100% cục bộ được không?**  

Có, với Ollama, lm-studio hoặc server, toàn bộ chuyển giọng nói thành văn bản, LLM và chuyển văn bản thành giọng nói đều chạy cục bộ. Các tùy chọn không cục bộ (OpenAI hay API khác) chỉ là tùy chọn.

**Hỏi: Tại sao nên dùng AgenticSeek khi tôi đã có Manus?**

Khác với Manus, AgenticSeek ưu tiên sự độc lập khỏi hệ thống bên ngoài, cho bạn nhiều quyền kiểm soát, bảo mật và tránh phí API.

**Hỏi: Ai đứng sau dự án này?**

Dự án được tạo bởi tôi cùng hai người bạn là các maintainer và contributor đến từ cộng đồng mã nguồn mở trên GitHub. Chúng tôi chỉ là nhóm cá nhân đam mê, không phải startup hay liên kết tổ chức nào.

Bất kỳ tài khoản AgenticSeek nào trên X ngoài tài khoản cá nhân của tôi (https://x.com/Martin993886460) đều là mạo danh.

## Đóng góp

Chúng tôi luôn tìm kiếm developer giúp cải thiện AgenticSeek! Hãy xem các issue hoặc thảo luận đang mở.

[Hướng dẫn đóng góp](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/docs/CONTRIBUTING.md)

[![Star History Chart](https://api.star-history.com/svg?repos=Fosowl/agenticSeek&type=Date)](https://www.star-history.com/#Fosowl/agenticSeek&Date)

## Maintainers:

 > [Fosowl](https://github.com/Fosowl) | Múi giờ Paris 

 > [antoineVIVIES](https://github.com/antoineVIVIES) | Múi giờ Taipei 

 > [steveh8758](https://github.com/steveh8758) | Múi giờ Taipei 

## Đặc biệt cảm ơn:

 > [tcsenpai](https://github.com/tcsenpai) và [plitc](https://github.com/plitc) Đã hỗ trợ docker hóa backend

## Nhà tài trợ:

Nhà tài trợ hàng tháng từ 5$ trở lên sẽ xuất hiện tại đây:
- **tatra-labs**
Certainly! Please provide the content for Part 4 of 4 that you would like to have translated.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-16

---