
<div align="center"><p><a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=hi"><img src="https://img.shields.io/badge/हिन्दी-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=fa"><img src="https://img.shields.io/badge/فارسی-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=id"><img src="https://img.shields.io/badge/Bahasa Indonesia-white" alt="version"></a> </p></div>

# Máy chủ PubChem MCP nâng cao dành cho trợ lý AI

🧪 Một máy chủ MCP tiên tiến, mạnh mẽ và chú trọng quyền riêng tư, cho phép các trợ lý AI tìm kiếm và truy cập thông tin hợp chất hóa học từ PubChem một cách thông minh.

Máy chủ PubChem MCP này hoạt động như một cầu nối mạnh mẽ giữa các trợ lý AI (như trong AnythingLLM) và cơ sở dữ liệu hóa học khổng lồ của PubChem. Nó tận dụng Model Context Protocol (MCP) để cho phép các mô hình AI thực hiện các tìm kiếm thông minh, kiên cố về hợp chất hóa học và lấy thông tin chi tiết về các thuộc tính một cách lập trình.

---

## ✨ Tính năng cốt lõi

Đây không chỉ là một trình bao bọc PubChem thông thường. Máy chủ này đã được xây dựng lại hoàn toàn để cực kỳ mạnh mẽ và thông minh:

-   **🧠 Tìm kiếm dự phòng thông minh**: Nếu tìm kiếm bằng tên phổ biến (như "Vitamin D") thất bại, máy chủ sẽ tự động thực hiện tìm kiếm sâu hơn trong cơ sở dữ liệu PubChem Substance để tìm hợp chất đúng. Điều này cải thiện đáng kể tỷ lệ thành công cho các truy vấn không rõ ràng.
-   **🛡️ Xử lý lỗi kiên cố & thử lại**: Máy chủ được thiết kế để xử lý lỗi API một cách linh hoạt. Nếu gặp lỗi "Server Busy" từ PubChem, nó sẽ tự động chờ và thử lại yêu cầu, đảm bảo truy vấn của bạn thành công ngay cả khi tải nặng.
-   **🔒 Hỗ trợ proxy Tor tùy chọn**: Bạn hoàn toàn kiểm soát quyền riêng tư của mình. Một file `config.ini` đơn giản cho phép bạn chuyển tất cả yêu cầu qua mạng Tor (qua SOCKS5 hoặc proxy HTTP), ngăn địa chỉ IP của bạn bị lộ. Máy chủ mặc định an toàn và sẽ **không bao giờ** rò rỉ IP của bạn nếu kết nối proxy thất bại.
-   **🔎 Tìm kiếm hợp chất đơn & đa**: Xử lý linh hoạt yêu cầu cho một hoặc nhiều hợp chất trong một lần nhập.
-   **🧪 Truy xuất thuộc tính chi tiết**: Truy cập các thuộc tính hóa học quan trọng như Tên IUPAC, Công thức phân tử, Khối lượng phân tử và đặc biệt là **Khối lượng đơn đồng vị (Monoisotopic Mass)**.

---

---

### 🚀 Không cần cài đặt: Dùng thử trực tiếp trên Smithery.ai

Dành cho những ai mới với máy chủ MCP hoặc chỉ muốn kiểm tra khả năng của công cụ mà không cần thiết lập cục bộ, phiên bản trực tuyến đã được triển khai trên Smithery.ai. Bạn có thể trò chuyện với agent trực tiếp trên trình duyệt của mình.

[**<-- Khám phá PubChem Agent trực tiếp trên Smithery.ai -->**](https://smithery.ai/server/@Milor123/smithery-pubchem-deploy)

**Cách bắt đầu:**

1.  Nhấn vào liên kết trên để vào trang máy chủ.
2.  Đăng nhập bằng tài khoản **GitHub** hoặc **Google**.
3.  Nhấn nút **"Explore capabilities"** để mở giao diện chat và bắt đầu thử nghiệm!

> **✅ Mô hình khuyến nghị để đạt kết quả tốt nhất**
>
> Để đạt độ chính xác tối đa, đặc biệt với các số thập phân dài, chúng tôi khuyến nghị sử dụng các mô hình mạnh. Các mô hình dưới đây đã được kiểm tra và hoạt động xuất sắc với công cụ này:
>
> *   **Claude 3 Sonnet của Anthropic**
> *   **GPT-4 Turbo của OpenAI** (hoặc các phiên bản mới hơn như GPT-4o)
>
> Chúng tôi đã xác nhận rằng cả hai mô hình đều xử lý chính xác độ chính xác đầy đủ của các số thập phân được trả về bởi công cụ mà không có bất kỳ làm tròn nào.

---

## 🚀 Khởi động nhanh & Cài đặt

Máy chủ này được thiết kế để chạy tại chỗ, trên máy tính để bàn của bạn hoặc trong môi trường Docker của AnythingLLM.

### 1. Các phụ thuộc

Dự án này dựa vào một số thư viện Python. Hãy đảm bảo rằng chúng đã được cài đặt trong môi trường của bạn.

Tạo một tệp `requirements.txt` với nội dung sau:
```txt
requests
bs4 
mcp 
pubchempy
pandas
PySocks
```

Cài đặt chúng bằng cách sử dụng `uv` hoặc `pip`:
```bash
uv venv
.venv\Scripts\activate
uv pip install -r requirements.txt
```
*(Lưu ý: Chỉ cần cài đặt `PySocks` nếu bạn dự định sử dụng tính năng proxy Tor SOCKS5.)*

### 2. Cấu hình

Máy chủ được cấu hình thông qua file `config.ini` và file này sẽ được **tạo tự động** khi bạn chạy lần đầu tiên. File này sẽ xuất hiện cùng thư mục với script `pubchem_server.py`.

**`config.ini` mặc định:**
```ini
[proxy]
# Change 'use_proxy' to 'true' to route all requests through a proxy.
# Essential for protecting your privacy if you use Tor.
use_proxy = false

# Defines the proxy type. Options:
#   socks5h  -> (Recommended for Tor) The native SOCKS proxy for Tor. More secure.
#   http     -> An HTTP proxy. If using Tor, requires additional configuration.
proxy_type = socks5h

# The proxy address. THIS IS A CRITICAL SETTING!
#   - If you run this script on your DESKTOP, use: 127.0.0.1
#   - If you run this script inside DOCKER, use: host.docker.internal
host = 127.0.0.1

# The proxy port.
#   9050 -> Default port for Tor's SOCKS proxy.
#   8118 -> Default port for Tor's HTTP proxy (if enabled).
port = 9050
```

### 3. Tích hợp với AnythingLLM

Làm theo tài liệu chính thức để thêm cái này như một máy chủ MCP tùy chỉnh. Điểm mấu chốt là chỉ định `command` tới file thực thi Python của bạn và script `pubchem_server.py`.

**Ví dụ cho AnythingLLM Desktop (`plugins/anythingllm_mcp_servers.json`):**
```json
{
  "mcpServers": {
    "pubchem": {
      "name": "PubChem Server (Enhanced)",
      "transport": "stdio",
      "command": "\"C:\\path\\to\\your\\.venv\\Scripts\\python.exe\" \"C:\\path\\to\\your\\project\\pubchem_server.py\"",
      "cwd": "C:\\path\\to\\your\\project"
    }
  }
}
```


### 3.1 Ví dụ Triển khai với AnythingLLM

Dưới đây là một số ví dụ về cách tương tác với agent. Các bài kiểm tra này được thực hiện bằng AnythingLLM Desktop, kết nối với nhiều Mô hình Ngôn ngữ Lớn thông qua OpenRouter.

Một phát hiện quan trọng từ quá trình thử nghiệm là việc lựa chọn mô hình. Chúng tôi **rất khuyến nghị không sử dụng các mô hình nhỏ hoặc mô hình cục bộ** cho nhiệm vụ này. Các mô hình nhỏ thường gặp khó khăn trong việc phân tích chính xác dữ liệu trả về từ công cụ, dẫn đến các lỗi như giá trị bị tưởng tượng, định dạng sai, hoặc nghiêm trọng nhất là **làm tròn số thập phân**, điều này làm mất đi ý nghĩa của công cụ độ chính xác cao này.

Để đảm bảo tính toàn vẹn của kết quả, bạn nên kiểm tra dữ liệu thô trả về bởi MCP. Bạn có thể học cách thực hiện việc này ở phần tiếp theo: [3.2 Cách xác minh đầu ra MCP trong nhật ký](#32-cach-xac-minh-dau-ra-mcp-trong-nhat-ky).

<img width="837" height="1060" alt="imagen" src="https://github.com/user-attachments/assets/5a16c7a2-d65d-4d64-98dd-f3cb4cae9b22" />

Ngược lại, một số mô hình đã cho thấy hiệu suất xuất sắc. Chúng tôi đạt được kết quả nổi bật với **Google `Gemini 2.5 Flash lite`**. Mô hình này thể hiện độ chính xác tuyệt vời trong việc xử lý các số thập phân dài và định dạng bảng Markdown cuối cùng một cách chuẩn xác.

Google gemini 2.5 flash lite không có prompt và có prompt đều giữ hoàn hảo số thập phân (trong ví dụ sử dụng nhiệt độ 0.6)

<img width="1089" height="1061" alt="imagen" src="https://github.com/user-attachments/assets/4574efa5-d6d9-49e3-a665-a39a427f09a1" />

Đối với nhiệm vụ cụ thể này, cá nhân tôi yêu thích **`Gemini 2.5 Flash lite`** bởi độ chính xác và độ tin cậy ổn định.

### 3.2 Cách xác minh đầu ra MCP trong nhật ký

Cách tốt nhất để xác nhận agent nhận đúng dữ liệu và LLM không mắc lỗi là kiểm tra tệp nhật ký debug được tạo bởi máy chủ MCP.

Máy chủ này được cấu hình để tự động tạo một tệp nhật ký trong một thư mục con bên trong thư mục dự án của bạn. Vị trí sẽ là:

```
your-project-folder/
└── logs_mcp/
    └── mcp_debug.log
```

Bên trong `mcp_debug.log`, bạn sẽ tìm thấy dữ liệu JSON chính xác mà công cụ gửi về cho LLM *trước khi* mô hình xử lý nó. Bạn có thể kiểm tra thủ công JSON này để xác minh bất kỳ giá trị nào, đặc biệt là các số thập phân dài từ các thuộc tính như `monoisotopic_mass`, đảm bảo rằng LLM không gây ra lỗi làm tròn hoặc ảo giác trong câu trả lời cuối cùng.

---

## 📊 Sử dụng

Khi đã tích hợp, trợ lý AI của bạn sẽ tự động sử dụng công cụ này khi được hỏi về thông tin hóa học. Công cụ chính được cung cấp là `search_compounds_by_name`.

### Ví dụ về Prompt

Prompt này minh họa khả năng của công cụ xử lý danh sách các hợp chất với các loại tên khác nhau và truy xuất nhiều thuộc tính.

```
@agent
Please use your PubChem tool to find information on the following compounds:

- Thiamine (Vitamin B1)
- Riboflavin (Vitamin B2)
- Folic Acid
- Hydroxocobalamin

For each compound found, please retrieve the IUPAC Name, Molecular Formula, and Monoisotopic Mass.

Present all the results in a single Markdown table.
```

Tác nhân sẽ gọi công cụ `search_compounds_by_name`, công cụ này sẽ tìm kiếm thông minh từng hợp chất, truy xuất dữ liệu của chúng và trả về cho LLM để định dạng.

---

## 🛠 Công Cụ MCP Được Công Khai

### `search_compounds_by_name`

Tìm kiếm nhiều hợp chất theo tên, từng cái một, sử dụng chiến lược dự phòng thông minh với tạm dừng và thử lại để đảm bảo độ tin cậy tối đa.

**Tham số:**
-   `names` (List[str]): Một danh sách tên hợp chất. Ví dụ: `["Aspirin", "Ibuprofen"]`

**Trả về:** Một danh sách các từ điển, mỗi từ điển chứa thông tin hợp chất tìm được hoặc thông báo lỗi giải thích lý do tại sao việc tìm kiếm thất bại đối với hợp chất đó.

---

## 🙏 Lời Cảm Ơn

Dự án này được truyền cảm hứng mạnh mẽ và xây dựng dựa trên nền tảng của [PubChem-MCP-Server](https://github.com/JackKuo666/PubChem-MCP-Server) gốc do **JackKuo666** tạo ra.

Dù kho lưu trữ này không phải là một nhánh trực tiếp, dự án gốc là điểm khởi đầu quan trọng. Phiên bản này nâng cấp ý tưởng ban đầu với trọng tâm vào độ ổn định cực cao, chiến lược tìm kiếm thông minh và bảo mật người dùng thông qua tích hợp Tor tùy chọn 🧅.

Xin chân thành cảm ơn tác giả gốc vì công việc tuyệt vời và đã chia sẻ với cộng đồng.

---

## ⚠️ Miễn Trừ Trách Nhiệm

Công cụ này chỉ dành cho mục đích nghiên cứu và giáo dục. Vui lòng tuân thủ điều khoản dịch vụ của PubChem và sử dụng công cụ này một cách có trách nhiệm.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-27

---