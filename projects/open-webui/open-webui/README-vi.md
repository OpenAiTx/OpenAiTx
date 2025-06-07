# Open WebUI 👋

![GitHub stars](https://img.shields.io/github/stars/open-webui/open-webui?style=social)
![GitHub forks](https://img.shields.io/github/forks/open-webui/open-webui?style=social)
![GitHub watchers](https://img.shields.io/github/watchers/open-webui/open-webui?style=social)
![GitHub repo size](https://img.shields.io/github/repo-size/open-webui/open-webui)
![GitHub language count](https://img.shields.io/github/languages/count/open-webui/open-webui)
![GitHub top language](https://img.shields.io/github/languages/top/open-webui/open-webui)
![GitHub last commit](https://img.shields.io/github/last-commit/open-webui/open-webui?color=red)
[![Discord](https://img.shields.io/badge/Discord-Open_WebUI-blue?logo=discord&logoColor=white)](https://discord.gg/5rJgQTnV4s)
[![](https://img.shields.io/static/v1?label=Sponsor&message=%E2%9D%A4&logo=GitHub&color=%23fe8e86)](https://github.com/sponsors/tjbck)

**Open WebUI là một nền tảng AI tự lưu trữ [có thể mở rộng](https://docs.openwebui.com/features/plugin/), giàu tính năng và thân thiện với người dùng, được thiết kế để hoạt động hoàn toàn ngoại tuyến.** Nền tảng này hỗ trợ nhiều trình chạy LLM như **Ollama** và **API tương thích OpenAI**, với **công cụ suy luận tích hợp sẵn** cho RAG, biến nó thành một **giải pháp triển khai AI mạnh mẽ**.

![Open WebUI Demo](./demo.gif)

> [!TIP]  
> **Bạn đang tìm kiếm một [Gói Doanh Nghiệp](https://docs.openwebui.com/enterprise)?** – **[Liên hệ với đội ngũ kinh doanh của chúng tôi ngay hôm nay!](mailto:sales@openwebui.com)**
>
> Nhận các **khả năng nâng cao**, bao gồm **tuỳ biến giao diện và thương hiệu**, **hỗ trợ Thoả Thuận Cấp Dịch vụ (SLA)**, **các phiên bản Hỗ trợ Dài hạn (LTS)**, và nhiều hơn nữa!

Để biết thêm thông tin, hãy xem [Tài liệu Open WebUI](https://docs.openwebui.com/).

## Các Tính Năng Chính của Open WebUI ⭐

- 🚀 **Cài Đặt Dễ Dàng**: Cài đặt liền mạch bằng Docker hoặc Kubernetes (kubectl, kustomize hoặc helm) cho trải nghiệm không rắc rối với hỗ trợ cả hình ảnh được gắn thẻ `:ollama` và `:cuda`.

- 🤝 **Tích Hợp API Ollama/OpenAI**: Tích hợp dễ dàng các API tương thích với OpenAI để trò chuyện đa dạng cùng các mô hình Ollama. Tuỳ chỉnh URL API OpenAI để liên kết với **LMStudio, GroqCloud, Mistral, OpenRouter, và nhiều hơn nữa**.

- 🛡️ **Phân Quyền Chi Tiết và Nhóm Người Dùng**: Cho phép quản trị viên tạo các vai trò và quyền người dùng chi tiết, đảm bảo môi trường người dùng an toàn. Mức độ chi tiết này không chỉ tăng cường bảo mật mà còn cho phép trải nghiệm người dùng tuỳ chỉnh, thúc đẩy ý thức sở hữu và trách nhiệm giữa các người dùng.

- 📱 **Thiết Kế Đáp Ứng**: Trải nghiệm liền mạch trên PC để bàn, Laptop và Thiết bị di động.

- 📱 **Ứng Dụng Web Tiến Tiến (PWA) cho Di Động**: Trải nghiệm như ứng dụng gốc trên thiết bị di động với PWA, cung cấp khả năng truy cập ngoại tuyến trên localhost và giao diện người dùng mượt mà.

- ✒️🔢 **Hỗ Trợ Đầy Đủ Markdown và LaTeX**: Nâng cao trải nghiệm LLM với khả năng Markdown và LaTeX toàn diện cho tương tác phong phú.

- 🎤📹 **Gọi Thoại/Video Rảnh Tay**: Trải nghiệm giao tiếp liền mạch với tính năng gọi thoại và video rảnh tay tích hợp, cho phép môi trường trò chuyện năng động và tương tác hơn.

- 🛠️ **Trình Xây Dựng Mô Hình**: Dễ dàng tạo các mô hình Ollama qua giao diện Web UI. Tạo và thêm nhân vật/agent tuỳ chỉnh, tuỳ biến các thành phần trò chuyện, và nhập mô hình dễ dàng thông qua tích hợp [Cộng đồng Open WebUI](https://openwebui.com/).

- 🐍 **Công Cụ Gọi Hàm Python Gốc**: Nâng cao LLM của bạn với trình soạn thảo mã tích hợp trong không gian làm việc công cụ. Mang Hàm Của Bạn (BYOF) chỉ cần thêm các hàm Python thuần tuý, cho phép tích hợp liền mạch với LLM.

- 📚 **Tích Hợp RAG Cục Bộ**: Khám phá tương lai của trò chuyện với hỗ trợ Retrieval Augmented Generation (RAG) đột phá. Tính năng này tích hợp liền mạch tương tác tài liệu vào trải nghiệm trò chuyện của bạn. Bạn có thể tải tài liệu trực tiếp vào trò chuyện hoặc thêm tập tin vào thư viện tài liệu, truy cập dễ dàng bằng lệnh `#` trước câu truy vấn.

- 🔍 **Tìm Kiếm Web cho RAG**: Thực hiện tìm kiếm web với các nhà cung cấp như `SearXNG`, `Google PSE`, `Brave Search`, `serpstack`, `serper`, `Serply`, `DuckDuckGo`, `TavilySearch`, `SearchApi` và `Bing` và chèn kết quả trực tiếp vào trải nghiệm trò chuyện của bạn.

- 🌐 **Khả Năng Duyệt Web**: Tích hợp liền mạch các trang web vào trò chuyện bằng lệnh `#` theo sau là một URL. Tính năng này cho phép bạn đưa nội dung web trực tiếp vào cuộc trò chuyện, nâng cao độ sâu và phong phú cho tương tác của bạn.

- 🎨 **Tích Hợp Sinh Ảnh**: Tích hợp khả năng sinh ảnh liền mạch bằng các tuỳ chọn như API AUTOMATIC1111 hoặc ComfyUI (cục bộ), và DALL-E của OpenAI (bên ngoài), làm giàu trải nghiệm trò chuyện với nội dung hình ảnh động.

- ⚙️ **Trò Chuyện Nhiều Mô Hình**: Dễ dàng tương tác với nhiều mô hình đồng thời, tận dụng các điểm mạnh riêng biệt để có phản hồi tối ưu. Nâng cao trải nghiệm bằng cách sử dụng đa dạng các mô hình song song.

- 🔐 **Kiểm Soát Truy Cập Dựa Trên Vai Trò (RBAC)**: Đảm bảo truy cập an toàn với các quyền hạn chế; chỉ những cá nhân được uỷ quyền mới có thể truy cập Ollama của bạn, và quyền tạo/tải mô hình chỉ dành riêng cho quản trị viên.

- 🌐🌍 **Hỗ Trợ Đa Ngôn Ngữ**: Trải nghiệm Open WebUI bằng ngôn ngữ ưa thích với hỗ trợ quốc tế hoá (i18n). Hãy cùng chúng tôi mở rộng các ngôn ngữ được hỗ trợ! Chúng tôi luôn tìm kiếm cộng tác viên!

- 🧩 **Pipelines, Hỗ Trợ Plugin Open WebUI**: Tích hợp liền mạch logic tuỳ chỉnh và thư viện Python vào Open WebUI bằng [Khung Plugin Pipelines](https://github.com/open-webui/pipelines). Khởi chạy phiên bản Pipelines của bạn, đặt URL OpenAI thành URL Pipelines, và khám phá vô vàn khả năng. [Ví dụ](https://github.com/open-webui/pipelines/tree/main/examples) gồm **Function Calling**, **Giới hạn tốc độ người dùng** để kiểm soát truy cập, **Giám sát sử dụng** với công cụ như Langfuse, **Dịch trực tiếp với LibreTranslate** cho hỗ trợ đa ngôn ngữ, **Lọc tin nhắn độc hại** và nhiều hơn nữa.

- 🌟 **Cập Nhật Liên Tục**: Chúng tôi cam kết cải tiến Open WebUI với các bản cập nhật, sửa lỗi và tính năng mới thường xuyên.

Muốn tìm hiểu thêm về các tính năng của Open WebUI? Xem [tài liệu Open WebUI](https://docs.openwebui.com/features) để có cái nhìn tổng quan đầy đủ!

## Nhà Tài Trợ 🙌

#### Emerald

<table>
  <tr>
    <td>
      <a href="https://n8n.io/" target="_blank">
        <img src="https://docs.openwebui.com/sponsors/logos/n8n.png" alt="n8n" style="width: 8rem; height: 8rem; border-radius: .75rem;" />
      </a>
    </td>
    <td>
      N8N • Giao diện của bạn đã có backend chưa?<br>Hãy thử <a href="https://n8n.io/">n8n</a>
    </td>
  </tr>
  <tr>
    <td>
      <a href="https://warp.dev/open-webui" target="_blank">
        <img src="https://docs.openwebui.com/sponsors/logos/warp.png" alt="n8n" style="width: 8rem; height: 8rem; border-radius: .75rem;" />
      </a>
    </td>
    <td>
      <a href="https://warp.dev/open-webui">Warp</a> • Terminal thông minh cho lập trình viên
    </td>
  </tr>
</table>

---

Chúng tôi vô cùng biết ơn sự hỗ trợ hào phóng của các nhà tài trợ. Đóng góp của họ giúp chúng tôi duy trì và cải thiện dự án, đảm bảo tiếp tục cung cấp sản phẩm chất lượng cho cộng đồng. Xin cảm ơn!

## Hướng Dẫn Cài Đặt 🚀

### Cài đặt qua Python pip 🐍

Open WebUI có thể được cài đặt bằng pip, trình quản lý gói Python. Trước khi tiến hành, hãy đảm bảo bạn đang sử dụng **Python 3.11** để tránh các vấn đề tương thích.

1. **Cài đặt Open WebUI**:
   Mở terminal và chạy lệnh sau để cài đặt Open WebUI:

   ```bash
   pip install open-webui
   ```

2. **Chạy Open WebUI**:
   Sau khi cài đặt, bạn có thể khởi động Open WebUI bằng cách thực thi:

   ```bash
   open-webui serve
   ```

Lệnh này sẽ khởi động máy chủ Open WebUI, bạn có thể truy cập tại [http://localhost:8080](http://localhost:8080)

### Khởi động nhanh với Docker 🐳

> [!NOTE]  
> Lưu ý rằng đối với một số môi trường Docker, có thể cần cấu hình bổ sung. Nếu bạn gặp bất kỳ vấn đề kết nối nào, hướng dẫn chi tiết của chúng tôi trên [Tài liệu Open WebUI](https://docs.openwebui.com/) sẵn sàng hỗ trợ bạn.

> [!WARNING]
> Khi sử dụng Docker để cài đặt Open WebUI, hãy đảm bảo bao gồm `-v open-webui:/app/backend/data` trong lệnh Docker của bạn. Bước này rất quan trọng để đảm bảo cơ sở dữ liệu của bạn được gắn đúng cách và tránh mất dữ liệu.

> [!TIP]  
> Nếu bạn muốn sử dụng Open WebUI với Ollama hoặc tăng tốc CUDA, hãy sử dụng hình ảnh chính thức được gắn thẻ `:cuda` hoặc `:ollama`. Để bật CUDA, bạn phải cài đặt [Nvidia CUDA container toolkit](https://docs.nvidia.com/dgx/nvidia-container-runtime-upgrade/) trên hệ thống Linux/WSL của mình.

### Cài Đặt Với Cấu Hình Mặc Định

- **Nếu Ollama trên máy tính của bạn**, dùng lệnh sau:

  ```bash
  docker run -d -p 3000:8080 --add-host=host.docker.internal:host-gateway -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:main
  ```

- **Nếu Ollama trên máy chủ khác**, dùng lệnh sau:

  Để kết nối với Ollama trên máy chủ khác, thay đổi `OLLAMA_BASE_URL` thành URL của máy chủ:

  ```bash
  docker run -d -p 3000:8080 -e OLLAMA_BASE_URL=https://example.com -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:main
  ```

- **Để chạy Open WebUI với hỗ trợ Nvidia GPU**, dùng lệnh sau:

  ```bash
  docker run -d -p 3000:8080 --gpus all --add-host=host.docker.internal:host-gateway -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:cuda
  ```

### Cài Đặt Chỉ Dùng API OpenAI

- **Nếu bạn chỉ sử dụng API OpenAI**, dùng lệnh sau:

  ```bash
  docker run -d -p 3000:8080 -e OPENAI_API_KEY=your_secret_key -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:main
  ```

### Cài Đặt Open WebUI Với Ollama Được Đóng Gói

Phương pháp cài đặt này sử dụng một hình ảnh container duy nhất đóng gói Open WebUI cùng Ollama, cho phép thiết lập nhanh chóng chỉ với một lệnh. Chọn lệnh phù hợp với phần cứng của bạn:

- **Hỗ trợ GPU**:
  Sử dụng tài nguyên GPU bằng lệnh sau:

  ```bash
  docker run -d -p 3000:8080 --gpus=all -v ollama:/root/.ollama -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:ollama
  ```

- **Chỉ dùng CPU**:
  Nếu bạn không sử dụng GPU, dùng lệnh sau:

  ```bash
  docker run -d -p 3000:8080 -v ollama:/root/.ollama -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:ollama
  ```

Cả hai lệnh đều giúp cài đặt tích hợp, không rắc rối cả Open WebUI và Ollama, đảm bảo bạn có thể khởi động mọi thứ nhanh chóng.

Sau khi cài đặt, bạn có thể truy cập Open WebUI tại [http://localhost:3000](http://localhost:3000). Chúc bạn vui vẻ! 😄

### Các Phương Pháp Cài Đặt Khác

Chúng tôi cung cấp nhiều lựa chọn cài đặt khác nhau, bao gồm các phương pháp cài đặt native không dùng Docker, Docker Compose, Kustomize, và Helm. Truy cập [Tài liệu Open WebUI](https://docs.openwebui.com/getting-started/) hoặc tham gia [cộng đồng Discord](https://discord.gg/5rJgQTnV4s) để được hướng dẫn đầy đủ.

### Xử Lý Sự Cố

Gặp vấn đề về kết nối? [Tài liệu Open WebUI](https://docs.openwebui.com/troubleshooting/) sẽ giúp bạn. Để được hỗ trợ thêm và tham gia cộng đồng năng động, hãy truy cập [Open WebUI Discord](https://discord.gg/5rJgQTnV4s).

#### Open WebUI: Lỗi Kết Nối Máy Chủ

Nếu bạn gặp sự cố kết nối, thường là do container docker WebUI không thể kết nối với máy chủ Ollama tại 127.0.0.1:11434 (host.docker.internal:11434) bên trong container. Sử dụng cờ `--network=host` trong lệnh docker để khắc phục. Lưu ý rằng cổng thay đổi từ 3000 sang 8080, dẫn đến liên kết: `http://localhost:8080`.

**Ví dụ lệnh Docker**:

```bash
docker run -d --network=host -v open-webui:/app/backend/data -e OLLAMA_BASE_URL=http://127.0.0.1:11434 --name open-webui --restart always ghcr.io/open-webui/open-webui:main
```

### Cập Nhật Docker Của Bạn

Nếu bạn muốn cập nhật bản cài đặt Docker cục bộ lên phiên bản mới nhất, có thể sử dụng [Watchtower](https://containrrr.dev/watchtower/):

```bash
docker run --rm --volume /var/run/docker.sock:/var/run/docker.sock containrrr/watchtower --run-once open-webui
```

Ở cuối lệnh, thay `open-webui` bằng tên container của bạn nếu khác.

Xem Hướng dẫn cập nhật trong [Tài liệu Open WebUI](https://docs.openwebui.com/getting-started/updating).

### Sử Dụng Nhánh Dev 🌙

> [!WARNING]
> Nhánh `:dev` chứa các tính năng mới chưa ổn định và thay đổi liên tục. Sử dụng với rủi ro của riêng bạn vì có thể có lỗi hoặc tính năng chưa hoàn chỉnh.

Nếu bạn muốn thử các tính năng mới nhất và chấp nhận sự không ổn định, hãy sử dụng thẻ `:dev` như sau:

```bash
docker run -d -p 3000:8080 -v open-webui:/app/backend/data --name open-webui --add-host=host.docker.internal:host-gateway --restart always ghcr.io/open-webui/open-webui:dev
```

### Chế Độ Ngoại Tuyến

Nếu bạn chạy Open WebUI trong môi trường ngoại tuyến, bạn có thể đặt biến môi trường `HF_HUB_OFFLINE` thành `1` để ngăn chặn việc tải mô hình từ internet.

```bash
export HF_HUB_OFFLINE=1
```

## Tiếp Theo Là Gì? 🌟

Khám phá các tính năng sắp ra mắt trên lộ trình phát triển tại [Tài liệu Open WebUI](https://docs.openwebui.com/roadmap/).

## Giấy Phép 📜

Dự án này được cấp phép theo [Giấy phép Open WebUI](LICENSE), phiên bản sửa đổi của giấy phép BSD-3-Clause. Bạn nhận được đầy đủ các quyền như BSD-3 truyền thống: có thể sử dụng, chỉnh sửa, phân phối phần mềm, bao gồm cả trong sản phẩm sở hữu độc quyền và thương mại, với rất ít hạn chế. Yêu cầu bổ sung duy nhất là giữ nguyên thương hiệu "Open WebUI", như quy định trong tệp LICENSE. Để biết đầy đủ điều khoản, xem [LICENSE](LICENSE). 📄

## Hỗ Trợ 💬

Nếu bạn có câu hỏi, đề xuất hoặc cần hỗ trợ, hãy tạo issue hoặc tham gia
[cộng đồng Discord Open WebUI](https://discord.gg/5rJgQTnV4s) để kết nối với chúng tôi! 🤝

## Lịch Sử Sao

<a href="https://star-history.com/#open-webui/open-webui&Date">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=open-webui/open-webui&type=Date&theme=dark" />
    <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=open-webui/open-webui&type=Date" />
    <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=open-webui/open-webui&type=Date" />
  </picture>
</a>

---

Được tạo bởi [Timothy Jaeryang Baek](https://github.com/tjbck) - Hãy cùng nhau làm cho Open WebUI tuyệt vời hơn nữa! 💪

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---