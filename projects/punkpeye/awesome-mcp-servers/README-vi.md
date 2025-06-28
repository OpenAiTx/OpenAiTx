# Awesome MCP Servers [![Awesome](https://awesome.re/badge.svg)](https://awesome.re)

[![ไทย](https://img.shields.io/badge/Thai-Click-blue)](README-th.md)
[![English](https://img.shields.io/badge/English-Click-yellow)](README.md)
[![繁體中文](https://img.shields.io/badge/繁體中文-點擊查看-orange)](README-zh_TW.md)
[![简体中文](https://img.shields.io/badge/简体中文-点击查看-orange)](README-zh.md)
[![日本語](https://img.shields.io/badge/日本語-クリック-青)](README-ja.md)
[![한국어](https://img.shields.io/badge/한국어-클릭-yellow)](README-ko.md)
[![Português Brasileiro](https://img.shields.io/badge/Português_Brasileiro-Clique-green)](README-pt_BR.md)
[![Discord](https://img.shields.io/discord/1312302100125843476?logo=discord&label=discord)](https://glama.ai/mcp/discord)
[![Subreddit subscribers](https://img.shields.io/reddit/subreddit-subscribers/mcp?style=flat&logo=reddit&label=subreddit)](https://www.reddit.com/r/mcp/)

Một danh sách chọn lọc các máy chủ Model Context Protocol (MCP) tuyệt vời.

* [MCP là gì?](#what-is-mcp)
* [Khách hàng](#clients)
* [Hướng dẫn](#tutorials)
* [Cộng đồng](#community)
* [Chú thích](#legend)
* [Các triển khai máy chủ](#server-implementations)
* [Các framework](#frameworks)
* [Mẹo & Thủ thuật](#tips-and-tricks)

## MCP là gì?

[MCP](https://modelcontextprotocol.io/) là một giao thức mở cho phép các mô hình AI tương tác an toàn với các tài nguyên cục bộ và từ xa thông qua các triển khai máy chủ tiêu chuẩn. Danh sách này tập trung vào các máy chủ MCP sẵn sàng cho sản xuất và thử nghiệm, mở rộng khả năng AI thông qua truy cập tệp, kết nối cơ sở dữ liệu, tích hợp API, và các dịch vụ ngữ cảnh khác.

## Khách hàng

Xem [awesome-mcp-clients](https://github.com/punkpeye/awesome-mcp-clients/) và [glama.ai/mcp/clients](https://glama.ai/mcp/clients).

> [!TIP]
> [Glama Chat](https://glama.ai/chat) là một ứng dụng AI đa phương thức hỗ trợ MCP & [AI gateway](https://glama.ai/gateway).

## Hướng dẫn

* [Model Context Protocol (MCP) Quickstart](https://glama.ai/blog/2024-11-25-model-context-protocol-quickstart)
* [Cài đặt ứng dụng Claude Desktop để sử dụng cơ sở dữ liệu SQLite](https://youtu.be/wxCCzo9dGj0)

## Cộng đồng

* [r/mcp Reddit](https://www.reddit.com/r/mcp)
* [Máy chủ Discord](https://glama.ai/mcp/discord)

## Chú thích

* 🎖️ – triển khai chính thức
* ngôn ngữ lập trình
  * 🐍 – mã nguồn Python
  * 📇 – mã nguồn TypeScript (hoặc JavaScript)
  * 🏎️ – mã nguồn Go
  * 🦀 – mã nguồn Rust
  * #️⃣ - mã nguồn C#
  * ☕ - mã nguồn Java
  * 🌊 – mã nguồn C/C++
* phạm vi
  * ☁️ - Dịch vụ Đám mây
  * 🏠 - Dịch vụ Cục bộ
  * 📟 - Hệ thống nhúng
* hệ điều hành
  * 🍎 – Dành cho macOS
  * 🪟 – Dành cho Windows
  * 🐧 - Dành cho Linux

> [!NOTE]
> Bối rối về Local 🏠 và Cloud ☁️?
> * Sử dụng local khi máy chủ MCP giao tiếp với phần mềm cài đặt cục bộ, ví dụ kiểm soát trình duyệt Chrome.
> * Sử dụng network khi máy chủ MCP giao tiếp với API từ xa, ví dụ API thời tiết.

## Các triển khai máy chủ

> [!NOTE]
> Hiện tại có [thư mục web](https://glama.ai/mcp/servers) được đồng bộ với kho lưu trữ này.

* 🔗 - [Trình tổng hợp](#aggregators)
* 🎨 - [Nghệ thuật & Văn hóa](#art-and-culture)
* 📂 - [Tự động hóa trình duyệt](#browser-automation)
* ☁️ - [Nền tảng Đám mây](#cloud-platforms)
* 👨‍💻 - [Thực thi mã](#code-execution)
* 🤖 - [Tác tử lập trình](#coding-agents)
* 🖥️ - [Dòng lệnh](#command-line)
* 💬 - [Giao tiếp](#communication)
* 👤 - [Nền tảng dữ liệu khách hàng](#customer-data-platforms)
* 🗄️ - [Cơ sở dữ liệu](#databases)
* 📊 - [Nền tảng dữ liệu](#data-platforms)
* 🚚 - [Giao hàng](#delivery)
* 🛠️ - [Công cụ phát triển](#developer-tools)
* 🧮 - [Công cụ khoa học dữ liệu](#data-science-tools)
* 📟 - [Hệ thống nhúng](#embedded-system)
* 📂 - [Hệ thống tập tin](#file-systems)
* 💰 - [Tài chính & Fintech](#finance--fintech)
* 🎮 - [Trò chơi](#gaming)
* 🧠 - [Kiến thức & Ghi nhớ](#knowledge--memory)
* 🗺️ - [Dịch vụ vị trí](#location-services)
* 🎯 - [Tiếp thị](#marketing)
* 📊 - [Giám sát](#monitoring)
* 🎥 - [Xử lý đa phương tiện](#multimedia-process)
* 🔎 - [Tìm kiếm & Trích xuất dữ liệu](#search)
* 🔒 - [Bảo mật](#security)
* 🌐 - [Mạng xã hội](#social-media)
* 🏃 - [Thể thao](#sports)
* 🎧 - [Quản lý Hỗ trợ & Dịch vụ](#support-and-service-management)
* 🌎 - [Dịch vụ Dịch thuật](#translation-services)
* 🎧 - [Chuyển văn bản thành giọng nói](#text-to-speech)
* 🚆 - [Du lịch & Vận tải](#travel-and-transportation)
* 🔄 - [Kiểm soát Phiên bản](#version-control)
* 🛠️ - [Công cụ & Tích hợp khác](#other-tools-and-integrations)


### 🔗 <a name="aggregators"></a>Trình tổng hợp

Máy chủ cho phép truy cập nhiều ứng dụng và công cụ thông qua một máy chủ MCP duy nhất.

- [julien040/anyquery](https://github.com/julien040/anyquery) 🏎️ 🏠 ☁️ - Truy vấn hơn 40 ứng dụng chỉ với một tệp nhị phân sử dụng SQL. Có thể kết nối với cơ sở dữ liệu PostgreSQL, MySQL hoặc SQLite của bạn. Ưu tiên cục bộ và riêng tư theo thiết kế.
- [metatool-ai/metatool-app](https://github.com/metatool-ai/metatool-app) 📇 ☁️ 🏠 🍎 🪟 🐧 - MetaMCP là middleware MCP server hợp nhất duy nhất quản lý các kết nối MCP của bạn với giao diện GUI.
- [mindsdb/mindsdb](https://github.com/mindsdb/mindsdb) - Kết nối và hợp nhất dữ liệu trên nhiều nền tảng và cơ sở dữ liệu với [MindsDB như một máy chủ MCP duy nhất](https://docs.mindsdb.com/mcp/overview).
- [glenngillen/mcpmcp-server](https://github.com/glenngillen/mcpmcp-server) ☁️ 📇 🍎 🪟 🐧 - Danh sách các máy chủ MCP để bạn có thể hỏi client của mình xem có thể dùng máy chủ nào để cải thiện quy trình làm việc hàng ngày.
- [wegotdocs/open-mcp](https://github.com/wegotdocs/open-mcp) 📇 🏠 🍎 🪟 🐧 - Biến một web API thành máy chủ MCP trong 10 giây và thêm vào registry mã nguồn mở: https://open-mcp.org
- [PipedreamHQ/pipedream](https://github.com/PipedreamHQ/pipedream/tree/master/modelcontextprotocol) ☁️ 🏠 - Kết nối với 2.500 API cùng hơn 8.000 công cụ dựng sẵn, và quản lý máy chủ cho người dùng của bạn trong ứng dụng riêng.
- [VeriTeknik/pluggedin-mcp-proxy](https://github.com/VeriTeknik/pluggedin-mcp-proxy)  📇 🏠 - Máy chủ proxy toàn diện kết hợp nhiều máy chủ MCP thành một giao diện duy nhất với các tính năng quan sát mở rộng. Cung cấp khám phá và quản lý công cụ, prompt, tài nguyên, template trên các máy chủ, cùng sân chơi gỡ lỗi khi xây dựng máy chủ MCP.
- [tigranbs/mcgravity](https://github.com/tigranbs/mcgravity) 📇 🏠 - Công cụ proxy để tổng hợp nhiều máy chủ MCP thành một endpoint hợp nhất. Mở rộng công cụ AI bằng cân bằng tải truy vấn như Nginx cho máy chủ web.
- [MetaMCP](https://github.com/metatool-ai/metatool-app) 📇 ☁️ 🏠 🍎 🪟 🐧 - MetaMCP là middleware MCP server hợp nhất duy nhất quản lý các kết nối MCP của bạn với giao diện GUI.
- [WayStation-ai/mcp](https://github.com/waystation-ai/mcp) ☁️ 🍎 🪟 - Kết nối liền mạch và bảo mật Claude Desktop cùng các máy chủ MCP khác tới các ứng dụng yêu thích (Notion, Slack, Monday, Airtable, v.v.). Thao tác dưới 90 giây.
- [sxhxliang/mcp-access-point](https://github.com/sxhxliang/mcp-access-point) 📇 ☁️ 🏠 🍎 🪟 🐧 - Biến dịch vụ web thành máy chủ MCP chỉ với một cú click mà không cần chỉnh sửa mã nguồn.
- [hamflx/imagen3-mcp](https://github.com/hamflx/imagen3-mcp) 📇 🏠 🪟 🍎 🐧 - Công cụ tạo ảnh mạnh mẽ sử dụng Google Imagen 3.0 API qua MCP. Tạo ảnh chất lượng cao từ prompt văn bản với điều khiển nâng cao về nhiếp ảnh, nghệ thuật và hiện thực.
- [SureScaleAI/openai-gpt-image-mcp](https://github.com/SureScaleAI/openai-gpt-image-mcp) 📇 ☁️ - Máy chủ MCP tạo/chỉnh sửa hình ảnh GPT của OpenAI.

### 🎨 <a name="art-and-culture"></a>Nghệ thuật & Văn hóa

Truy cập và khám phá bộ sưu tập nghệ thuật, di sản văn hóa và cơ sở dữ liệu bảo tàng. Cho phép mô hình AI tìm kiếm và phân tích nội dung nghệ thuật, văn hóa.

- [abhiemj/manim-mcp-server](https://github.com/abhiemj/manim-mcp-server) 🐍 🏠 🪟 🐧 - Máy chủ MCP cục bộ tạo hoạt hình sử dụng Manim.
- [burningion/video-editing-mcp](https://github.com/burningion/video-editing-mcp) 🐍 - Thêm, Phân tích, Tìm kiếm và Tạo Video Edit từ bộ sưu tập Video Jungle của bạn
- [cswkim/discogs-mcp-server](https://github.com/cswkim/discogs-mcp-server) 📇 ☁️ - Máy chủ MCP tương tác với Discogs API
- [djalal/quran-mcp-server](https://github.com/djalal/quran-mcp-server) 📇 ☁️ Máy chủ MCP tương tác với kho dữ liệu Quran.com qua REST API v4 chính thức.
- [mikechao/metmuseum-mcp](https://github.com/mikechao/metmuseum-mcp) 📇 ☁️ - Tích hợp API Bộ sưu tập Bảo tàng Nghệ thuật Metropolitan để tìm kiếm và hiển thị tác phẩm nghệ thuật trong bộ sưu tập.
- [r-huijts/rijksmuseum-mcp](https://github.com/r-huijts/rijksmuseum-mcp) 📇 ☁️ - Tích hợp API Rijksmuseum để tìm kiếm tác phẩm, chi tiết, bộ sưu tập
- [r-huijts/oorlogsbronnen-mcp](https://github.com/r-huijts/oorlogsbronnen-mcp) 📇 ☁️ - Tích hợp API Oorlogsbronnen (Nguồn chiến tranh) để truy cập tài liệu, ảnh, tài liệu lịch sử Thế chiến II từ Hà Lan (1940-1945)
- [samuelgursky/davinci-resolve-mcp](https://github.com/samuelgursky/davinci-resolve-mcp) 🐍 - Tích hợp máy chủ MCP cho DaVinci Resolve cung cấp công cụ mạnh mẽ cho biên tập video, chỉnh màu, quản lý media và điều khiển dự án
- [yuna0x0/anilist-mcp](https://github.com/yuna0x0/anilist-mcp) 📇 ☁️ - Máy chủ MCP tích hợp API AniList cho thông tin anime và manga
- [diivi/aseprite-mcp](https://github.com/diivi/aseprite-mcp) 🐍 🏠 - Máy chủ MCP sử dụng API Aseprite để tạo pixel art
- [omni-mcp/isaac-sim-mcp](https://github.com/omni-mcp/isaac-sim-mcp) 📇 ☁️ - Máy chủ MCP và extension cho phép điều khiển ngôn ngữ tự nhiên NVIDIA Isaac Sim, Lab, OpenUSD, v.v.
- [8enSmith/mcp-open-library](https://github.com/8enSmith/mcp-open-library) 📇 ☁️ - Máy chủ MCP cho Open Library API giúp trợ lý AI tìm kiếm thông tin sách.
- [PatrickPalmer/MayaMCP](https://github.com/PatrickPalmer/MayaMCP) 🐍 🏠 - Máy chủ MCP cho Autodesk Maya
- [cantian-ai/bazi-mcp](https://github.com/cantian-ai/bazi-mcp) 📇 🏠 ☁️ 🍎 🪟 - Cung cấp công cụ lập lá số và phân tích Tứ trụ (Bazi) toàn diện, chính xác

### 📂 <a name="browser-automation"></a>Tự động hóa Trình duyệt

Khả năng truy cập và tự động hóa nội dung web. Cho phép tìm kiếm, thu thập dữ liệu và xử lý nội dung web dưới định dạng thân thiện với AI.

- [xspadex/bilibili-mcp](https://github.com/xspadex/bilibili-mcp.git) 📇 🏠 - Công cụ dựa trên FastMCP lấy video thịnh hành của Bilibili và cung cấp qua giao diện MCP chuẩn.
- [34892002/bilibili-mcp-js](https://github.com/34892002/bilibili-mcp-js) 📇 🏠 - Máy chủ MCP hỗ trợ tìm kiếm nội dung Bilibili. Có ví dụ tích hợp LangChain và script kiểm thử.
- [aircodelabs/grasp](https://github.com/aircodelabs/grasp) 📇 🏠 - Trình duyệt tự lưu trữ dùng agent tích hợp sẵn MCP và hỗ trợ A2A.
- [automatalabs/mcp-server-playwright](https://github.com/Automata-Labs-team/MCP-Server-Playwright) 🐍 - Máy chủ MCP cho tự động hóa trình duyệt sử dụng Playwright
- [blackwhite084/playwright-plus-python-mcp](https://github.com/blackwhite084/playwright-plus-python-mcp) 🐍 - Máy chủ MCP python dùng Playwright cho tự động hóa trình duyệt, thích hợp hơn cho llm
- [browserbase/mcp-server-browserbase](https://github.com/browserbase/mcp-server-browserbase) 🎖️ 📇 - Tự động hóa thao tác trình duyệt trên cloud (như duyệt web, lấy dữ liệu, điền form, v.v.)
- [browsermcp/mcp](https://github.com/browsermcp/mcp) 📇 🏠 - Tự động hóa trình duyệt Chrome cục bộ của bạn
- [co-browser/browser-use-mcp-server](https://github.com/co-browser/browser-use-mcp-server) 🐍 - browser-use đóng gói dạng máy chủ MCP với giao thức SSE. Bao gồm dockerfile để chạy chromium trên docker + vnc server.
- [executeautomation/playwright-mcp-server](https://github.com/executeautomation/mcp-playwright) 📇 - Máy chủ MCP sử dụng Playwright cho tự động hóa trình duyệt và thu thập dữ liệu web
- [eyalzh/browser-control-mcp](https://github.com/eyalzh/browser-control-mcp) 📇 🏠 - Máy chủ MCP kết hợp extension trình duyệt cho phép client LLM điều khiển trình duyệt người dùng (Firefox).
- [fradser/mcp-server-apple-reminders](https://github.com/FradSer/mcp-server-apple-reminders) 📇 🏠 🍎 - Máy chủ MCP tương tác với Apple Reminders trên macOS
- [getrupt/ashra-mcp](https://github.com/getrupt/ashra-mcp) 🐍 🏠 - Trích xuất dữ liệu có cấu trúc từ bất kỳ website nào. Chỉ cần prompt và nhận về JSON.
- [kimtaeyoon83/mcp-server-youtube-transcript](https://github.com/kimtaeyoon83/mcp-server-youtube-transcript) 📇 ☁️ - Lấy phụ đề và transcript YouTube để AI phân tích
- [kimtth/mcp-aoai-web-browsing](https://github.com/kimtth/mcp-aoai-web-browsing) 🐍 🏠 - Triển khai server/client MCP `tối giản` dùng Azure OpenAI và Playwright.
- [microsoft/playwright-mcp](https://github.com/microsoft/playwright-mcp) - Máy chủ MCP Playwright chính thức của Microsoft, cho phép LLM tương tác với trang web qua snapshot accessibility có cấu trúc
- [modelcontextprotocol/server-puppeteer](https://github.com/modelcontextprotocol/servers/tree/main/src/puppeteer) 📇 🏠 - Tự động hóa trình duyệt cho thu thập và tương tác dữ liệu web
- [ndthanhdev/mcp-browser-kit](https://github.com/ndthanhdev/mcp-browser-kit) 📇 🏠 - Máy chủ MCP tương tác với trình duyệt tương thích manifest v2.
- [pskill9/web-search](https://github.com/pskill9/web-search) 📇 🏠 - Máy chủ MCP cho phép tìm kiếm web miễn phí sử dụng kết quả Google, không cần API key.
- [recursechat/mcp-server-apple-shortcuts](https://github.com/recursechat/mcp-server-apple-shortcuts) 📇 🏠 🍎 - Tích hợp máy chủ MCP với Apple Shortcuts

### ☁️ <a name="cloud-platforms"></a>Nền tảng Đám mây

Tích hợp dịch vụ nền tảng đám mây. Cho phép quản lý và tương tác với hạ tầng, dịch vụ đám mây.

- [awslabs/mcp](https://github.com/awslabs/mcp) 🎖️ ☁️ - Máy chủ MCP AWS cho tích hợp liền mạch với dịch vụ và tài nguyên AWS.
- [qiniu/qiniu-mcp-server](https://github.com/qiniu/qiniu-mcp-server) 🐍 ☁️ - MCP xây dựng trên sản phẩm Qiniu Cloud, hỗ trợ truy cập lưu trữ Qiniu Cloud, dịch vụ xử lý media, v.v.
- [alexbakers/mcp-ipfs](https://github.com/alexbakers/mcp-ipfs) 📇 ☁️ - upload và thao tác lưu trữ IPFS
- [reza-gholizade/k8s-mcp-server](https://github.com/reza-gholizade/k8s-mcp-server) 🏎️ ☁️/🏠 - Máy chủ Kubernetes Model Context Protocol (MCP) cung cấp công cụ tương tác với cluster Kubernetes qua giao diện chuẩn hóa, gồm khám phá tài nguyên API, quản lý tài nguyên, log pod, metric và sự kiện.
- [VmLia/books-mcp-server](https://github.com/VmLia/books-mcp-server) 📇 ☁️ - Máy chủ MCP dùng để truy vấn sách, ứng dụng trong các client MCP phổ biến như Cherry Studio.
- [alexei-led/aws-mcp-server](https://github.com/alexei-led/aws-mcp-server) 🐍 ☁️ - Máy chủ nhẹ nhưng mạnh mẽ cho phép trợ lý AI thực thi lệnh AWS CLI, dùng Unix pipe, áp dụng prompt template cho tác vụ AWS phổ biến trong môi trường Docker an toàn, hỗ trợ đa kiến trúc
- [alexei-led/k8s-mcp-server](https://github.com/alexei-led/k8s-mcp-server) 🐍 - Máy chủ nhẹ nhưng mạnh mẽ cho phép trợ lý AI thực thi an toàn lệnh Kubernetes CLI (`kubectl`, `helm`, `istioctl`, và `argocd`) bằng Unix pipe trong môi trường Docker an toàn, hỗ trợ đa kiến trúc.
- [aliyun/alibaba-cloud-ops-mcp-server](https://github.com/aliyun/alibaba-cloud-ops-mcp-server) 🎖️ 🐍 ☁️ - Máy chủ MCP cho phép trợ lý AI thao tác tài nguyên trên Alibaba Cloud, hỗ trợ ECS, Cloud Monitor, OOS và nhiều sản phẩm cloud thông dụng.  
- [bright8192/esxi-mcp-server](https://github.com/bright8192/esxi-mcp-server) 🐍 ☁️ - Máy chủ quản lý VMware ESXi/vCenter dựa trên MCP, cung cấp REST API đơn giản quản lý máy ảo.
- [cloudflare/mcp-server-cloudflare](https://github.com/cloudflare/mcp-server-cloudflare) 🎖️ 📇 ☁️ - Tích hợp các dịch vụ Cloudflare gồm Workers, KV, R2, D1
- [cyclops-ui/mcp-cyclops](https://github.com/cyclops-ui/mcp-cyclops) 🎖️ 🏎️ ☁️ - Máy chủ MCP cho phép agent AI quản lý tài nguyên Kubernetes qua abstraction Cyclops
- [jedisct1/fastly-mcp-server](https://github.com/jedisct1/fastly-openapi-schema) 🎖️ 📇 ☁️ - Tích hợp dịch vụ Fastly
- [flux159/mcp-server-kubernetes](https://github.com/Flux159/mcp-server-kubernetes) 📇 ☁️/🏠 - Triển khai Typescript cho thao tác cluster Kubernetes với pod, deployment, service.
- [hardik-id/azure-resource-graph-mcp-server](https://github.com/hardik-id/azure-resource-graph-mcp-server) 📇 ☁️/🏠 - Máy chủ Model Context Protocol cho truy vấn, phân tích tài nguyên Azure quy mô lớn bằng Azure Resource Graph, cho phép trợ lý AI khám phá, giám sát hạ tầng Azure.
- [jdubois/azure-cli-mcp](https://github.com/jdubois/azure-cli-mcp) - Bộ bọc lệnh Azure CLI cho phép bạn giao tiếp trực tiếp với Azure
- [johnneerdael/netskope-mcp](https://github.com/johnneerdael/netskope-mcp) 🔒 ☁️ - Máy chủ MCP truy cập tất cả thành phần Netskope Private Access trong môi trường Netskope Private Access, gồm hướng dẫn thiết lập chi tiết và ví dụ sử dụng LLM.
- [manusa/Kubernetes MCP Server](https://github.com/manusa/kubernetes-mcp-server) 🏎️ 🏠 - Máy chủ MCP Kubernetes mạnh mẽ hỗ trợ thêm OpenShift. Ngoài thao tác CRUD với **mọi** tài nguyên Kubernetes, máy chủ còn có công cụ chuyên biệt để tương tác cluster.
- [nwiizo/tfmcp](https://github.com/nwiizo/tfmcp) 🦀 🏠 - Máy chủ MCP Terraform cho phép trợ lý AI quản lý môi trường Terraform, đọc cấu hình, phân tích plan, áp dụng cấu hình, quản lý state.
- [pulumi/mcp-server](https://github.com/pulumi/mcp-server) 🎖️ 📇 🏠 - Máy chủ MCP tương tác Pulumi dùng Pulumi Automation API và Pulumi Cloud API. Cho phép client MCP thực hiện thao tác Pulumi như lấy thông tin gói, xem trước thay đổi, triển khai, lấy output stack qua lập trình.
- [rohitg00/kubectl-mcp-server](https://github.com/rohitg00/kubectl-mcp-server) 🐍 ☁️/🏠 - Máy chủ Model Context Protocol (MCP) cho Kubernetes cho phép trợ lý AI như Claude, Cursor, v.v. tương tác cluster Kubernetes bằng ngôn ngữ tự nhiên.
- [strowk/mcp-k8s-go](https://github.com/strowk/mcp-k8s-go) 🏎️ ☁️/🏠 - Thao tác cluster Kubernetes qua MCP
- [thunderboltsid/mcp-nutanix](https://github.com/thunderboltsid/mcp-nutanix) 🏎️ 🏠/☁️ - Máy chủ MCP viết bằng Go giao tiếp tài nguyên Nutanix Prism Central.
- [trilogy-group/aws-pricing-mcp](https://github.com/trilogy-group/aws-pricing-mcp) 🏎️ ☁️/🏠 - Lấy thông tin giá EC2 mới nhất chỉ với một lần gọi. Nhanh. Dựa trên catalogue giá AWS đã phân tích sẵn.
- [weibaohui/k8m](https://github.com/weibaohui/k8m) 🏎️ ☁️/🏠 - Cung cấp quản lý, thao tác MCP multi-cluster Kubernetes, có giao diện quản lý, logging, gần 50 công cụ tích hợp cho DevOps và phát triển. Hỗ trợ cả tài nguyên chuẩn và CRD.
- [weibaohui/kom](https://github.com/weibaohui/kom) 🏎️ ☁️/🏠 - Cung cấp quản lý, thao tác MCP multi-cluster Kubernetes. Có thể tích hợp dạng SDK vào dự án riêng, gồm gần 50 công cụ cho DevOps, phát triển. Hỗ trợ tài nguyên chuẩn lẫn CRD.
- [wenhuwang/mcp-k8s-eye](https://github.com/wenhuwang/mcp-k8s-eye) 🏎️ ☁️/🏠 - Máy chủ MCP để quản lý Kubernetes và phân tích cụm, sức khỏe ứng dụng của bạn
- [erikhoward/adls-mcp-server](https://github.com/erikhoward/adls-mcp-server) 🐍 ☁️/🏠 - Máy chủ MCP cho Azure Data Lake Storage. Có thể quản lý container, thực hiện các thao tác đọc/ghi/tải lên/tải xuống trên tập tin container và quản lý siêu dữ liệu tập tin.
- [silenceper/mcp-k8s](https://github.com/silenceper/mcp-k8s) 🏎️ ☁️/🏠 - MCP-K8S là công cụ quản lý tài nguyên Kubernetes dựa trên AI cho phép người dùng thao tác mọi tài nguyên trong cụm Kubernetes thông qua tương tác ngôn ngữ tự nhiên, bao gồm tài nguyên gốc (như Deployment, Service) và tài nguyên tùy chỉnh (CRD). Không cần nhớ các lệnh phức tạp - chỉ cần mô tả nhu cầu, AI sẽ thực thi chính xác thao tác tương ứng trên cụm, tăng mạnh khả năng sử dụng của Kubernetes.
- [redis/mcp-redis-cloud](https://github.com/redis/mcp-redis-cloud) 📇 ☁️ - Quản lý tài nguyên Redis Cloud dễ dàng bằng ngôn ngữ tự nhiên. Tạo cơ sở dữ liệu, giám sát đăng ký và cấu hình triển khai đám mây chỉ với các lệnh đơn giản.
- [portainer/portainer-mcp](https://github.com/portainer/portainer-mcp) 🏎️ ☁️/🏠 - Một máy chủ MCP mạnh mẽ cho phép trợ lý AI tương tác liền mạch với các phiên bản Portainer, cung cấp truy cập quản lý container, thao tác triển khai và giám sát hạ tầng bằng ngôn ngữ tự nhiên.

### 👨‍💻 <a name="code-execution"></a>Thực Thi Mã

Máy chủ thực thi mã. Cho phép các mô hình LLM thực thi mã trong môi trường an toàn, ví dụ cho các agent lập trình.

- [pydantic/pydantic-ai/mcp-run-python](https://github.com/pydantic/pydantic-ai/tree/main/mcp-run-python) 🐍 🏠- Chạy mã Python trong sandbox an toàn qua các lệnh công cụ MCP
- [yepcode/mcp-server-js](https://github.com/yepcode/mcp-server-js) 🎖️ 📇 ☁️ - Thực thi bất kỳ mã do LLM sinh ra trong môi trường sandbox an toàn và có khả năng mở rộng, tạo công cụ MCP của riêng bạn bằng JavaScript hoặc Python, hỗ trợ đầy đủ các gói NPM và PyPI
- [ckanthony/openapi-mcp](https://github.com/ckanthony/openapi-mcp) 🏎️ ☁️ - OpenAPI-MCP: Máy chủ MCP đóng gói Docker cho phép agent AI truy cập bất kỳ API nào với tài liệu api có sẵn.
- [alfonsograziano/node-code-sandbox-mcp](https://github.com/alfonsograziano/node-code-sandbox-mcp) 📇 🏠 – Máy chủ MCP Node.js tạo các sandbox dựa trên Docker biệt lập để thực thi các đoạn mã JavaScript với khả năng cài đặt phụ thuộc npm tức thì và dọn dẹp sạch sẽ
- [r33drichards/mcp-js](https://github.com/r33drichards/mcp-js) 🦀 🏠 🐧 🍎 - Sandbox thực thi mã Javascript sử dụng v8 để cô lập mã, cho phép chạy JavaScript do AI sinh ra tại máy mà không lo ngại. Hỗ trợ snapshot heap cho các phiên làm việc liên tục.

### 🤖 <a name="coding-agents"></a>Agent Lập Trình

Agent lập trình đầy đủ cho phép LLM đọc, chỉnh sửa, thực thi mã và giải các tác vụ lập trình một cách tự động hoàn toàn.

- [oraios/serena](https://github.com/oraios/serena)🐍🏠 - Agent lập trình đầy đủ chức năng dựa trên các thao tác mã biểu tượng sử dụng language server.
- [ezyang/codemcp](https://github.com/ezyang/codemcp) 🐍🏠 - Agent lập trình với các công cụ đọc, ghi và dòng lệnh cơ bản.
- [doggybee/mcp-server-leetcode](https://github.com/doggybee/mcp-server-leetcode) 📇 ☁️ - Máy chủ MCP cho phép mô hình AI tìm kiếm, truy xuất và giải các bài toán LeetCode. Hỗ trợ lọc siêu dữ liệu, hồ sơ người dùng, nộp bài, và truy cập dữ liệu cuộc thi.
- [jinzcdev/leetcode-mcp-server](https://github.com/jinzcdev/leetcode-mcp-server) 📇 ☁️ - Máy chủ MCP cho phép truy cập tự động các bài toán lập trình, lời giải, bài nộp và dữ liệu công khai của **LeetCode** với tùy chọn xác thực cho các tính năng theo người dùng (ví dụ: ghi chú), hỗ trợ cả `leetcode.com` (toàn cầu) và `leetcode.cn` (Trung Quốc).
- [juehang/vscode-mcp-server](https://github.com/juehang/vscode-mcp-server) 📇 🏠 - Máy chủ MCP cho phép AI như Claude đọc cấu trúc thư mục trong workspace VS Code, thấy các vấn đề được phát hiện bởi linter(s) và language server, đọc tệp mã và chỉnh sửa.
- [micl2e2/code-to-tree](https://github.com/micl2e2/code-to-tree) 🌊 🏠 📟 🐧 🪟 🍎 - Máy chủ MCP dạng nhị phân duy nhất chuyển đổi mã nguồn thành AST, bất kể ngôn ngữ.

### 🖥️ <a name="command-line"></a>Dòng Lệnh

Chạy lệnh, thu thập đầu ra và tương tác với shell cùng các công cụ dòng lệnh khác.

- [ferrislucas/iterm-mcp](https://github.com/ferrislucas/iterm-mcp) 🖥️ 🛠️ 💬 - Máy chủ Model Context Protocol cung cấp truy cập vào iTerm. Bạn có thể chạy lệnh và đặt câu hỏi về những gì bạn thấy trên terminal iTerm.
- [g0t4/mcp-server-commands](https://github.com/g0t4/mcp-server-commands) 📇 🏠 - Chạy bất kỳ lệnh nào với công cụ `run_command` và `run_script`.
- [maxim-saplin/mcp_safe_local_python_executor](https://github.com/maxim-saplin/mcp_safe_local_python_executor) - Trình thông dịch Python an toàn dựa trên HF Smolagents `LocalPythonExecutor`
- [MladenSU/cli-mcp-server](https://github.com/MladenSU/cli-mcp-server) 🐍 🏠 - Giao diện dòng lệnh với thực thi an toàn và chính sách bảo mật tùy chỉnh
- [OthmaneBlial/term_mcp_deepseek](https://github.com/OthmaneBlial/term_mcp_deepseek) 🐍 🏠 - Máy chủ DeepSeek MCP cho Terminal
- [tumf/mcp-shell-server](https://github.com/tumf/mcp-shell-server) - Máy chủ thực thi lệnh shell an toàn triển khai Model Context Protocol (MCP)
- [automateyournetwork/pyATS_MCP](https://github.com/automateyournetwork/pyATS_MCP) - Máy chủ Cisco pyATS cho phép tương tác mô hình với thiết bị mạng một cách có cấu trúc.
- [wonderwhy-er/DesktopCommanderMCP](https://github.com/wonderwhy-er/DesktopCommanderMCP) 📇 🏠 🍎 🪟 🐧 - Dao đa năng có thể quản lý/thực thi chương trình và đọc/ghi/tìm kiếm/chỉnh sửa mã cùng tệp văn bản.
- [tufantunc/ssh-mcp](https://github.com/tufantunc/ssh-mcp) 📇 🏠 🐧 🪟 - Máy chủ MCP cung cấp điều khiển SSH cho máy chủ Linux và Windows qua Model Context Protocol. Thực thi lệnh shell từ xa an toàn bằng xác thực mật khẩu hoặc khóa SSH.

### 💬 <a name="communication"></a>Giao Tiếp

Tích hợp với các nền tảng giao tiếp để quản lý tin nhắn và vận hành kênh. Cho phép mô hình AI tương tác với công cụ giao tiếp nhóm.

- [AbdelStark/nostr-mcp](https://github.com/AbdelStark/nostr-mcp) ☁️ - Máy chủ Nostr MCP cho phép tương tác với Nostr, đăng ghi chú và nhiều hơn nữa.
- [adhikasp/mcp-twikit](https://github.com/adhikasp/mcp-twikit) 🐍 ☁️ - Tương tác với tìm kiếm và dòng thời gian Twitter
- [agentmail-toolkit/mcp](https://github.com/agentmail-to/agentmail-toolkit/tree/main/mcp) 🐍 💬 - Máy chủ MCP tạo hộp thư ngay lập tức để gửi, nhận, và thao tác với email. Không phải là agent AI cho email, mà là email cho agent AI.
- [arpitbatra123/mcp-googletasks](https://github.com/arpitbatra123/mcp-googletasks) 📇 ☁️ - Máy chủ MCP giao tiếp với Google Tasks API
- [carterlasalle/mac_messages_mcp](https://github.com/carterlasalle/mac_messages_mcp) 🏠 🍎 🚀 - Máy chủ MCP giao tiếp an toàn với cơ sở dữ liệu iMessage qua Model Context Protocol (MCP), cho phép LLM truy vấn và phân tích hội thoại iMessage. Bao gồm xác thực số điện thoại mạnh mẽ, xử lý tệp đính kèm, quản lý liên hệ, nhóm chat và hỗ trợ đầy đủ gửi/nhận tin nhắn.
- [chaindead/telegram-mcp](https://github.com/chaindead/telegram-mcp) 🏎️ 🏠 - Tích hợp API Telegram cho truy cập dữ liệu người dùng, quản lý hội thoại (chat, kênh, nhóm), truy xuất tin nhắn, và xử lý trạng thái đã đọc
- [chigwell/telegram-mcp](https://github.com/chigwell/telegram-mcp) 🐍 🏠 - Tích hợp API Telegram cho truy cập dữ liệu người dùng, quản lý hội thoại (chat, kênh, nhóm), truy xuất, gửi tin nhắn và xử lý trạng thái đã đọc.
- [elie222/inbox-zero](https://github.com/elie222/inbox-zero/tree/main/apps/mcp-server) 🐍 ☁️ - Máy chủ MCP cho Inbox Zero. Thêm chức năng cho Gmail như tìm email cần phản hồi hoặc theo dõi.
- [gitmotion/ntfy-me-mcp](https://github.com/gitmotion/ntfy-me-mcp) 📇 ☁️ 🏠 - Máy chủ MCP ntfy để gửi/lấy thông báo ntfy đến server ntfy tự host từ AI Agents 📤 (hỗ trợ xác thực token an toàn & nhiều hơn nữa - dùng với npx hoặc docker!)
- [gotoolkits/wecombot](https://github.com/gotoolkits/mcp-wecombot-server.git) 🚀 ☁️ - Ứng dụng máy chủ MCP gửi nhiều loại tin nhắn đến bot nhóm WeCom.
- [hannesrudolph/imessage-query-fastmcp-mcp-server](https://github.com/hannesrudolph/imessage-query-fastmcp-mcp-server) 🐍 🏠 🍎 - Máy chủ MCP cung cấp truy cập an toàn vào cơ sở dữ liệu iMessage qua Model Context Protocol (MCP), cho phép LLM truy vấn và phân tích hội thoại iMessage với xác thực số điện thoại và xử lý tệp đính kèm phù hợp
- [i-am-bee/acp-mcp](https://github.com/i-am-bee/acp-mcp) 🐍 💬 - Máy chủ MCP làm adapter vào hệ sinh thái [ACP](https://agentcommunicationprotocol.dev). Kết nối mượt ACP agent với khách hàng MCP, cầu nối giao tiếp giữa hai giao thức.
- [jagan-shanmugam/mattermost-mcp-host](https://github.com/jagan-shanmugam/mattermost-mcp-host) 🐍 🏠 - Máy chủ MCP cùng MCP host cung cấp truy cập đội nhóm, kênh và tin nhắn Mattermost. MCP host được tích hợp dưới dạng bot trong Mattermost với khả năng truy cập các máy chủ MCP cấu hình được.
- [lharries/whatsapp-mcp](https://github.com/lharries/whatsapp-mcp) 🐍 🏎️ - Máy chủ MCP tìm kiếm tin nhắn cá nhân WhatsApp, liên hệ và gửi tin đến cá nhân hoặc nhóm
- [line/line-bot-mcp-server](https://github.com/line/line-bot-mcp-server) 🎖 📇 ☁️ - Máy chủ MCP tích hợp LINE Official Account
- [MarkusPfundstein/mcp-gsuite](https://github.com/MarkusPfundstein/mcp-gsuite) 🐍 ☁️ - Tích hợp gmail và Google Calendar.
- [modelcontextprotocol/server-bluesky](https://github.com/keturiosakys/bluesky-context-server) 📇 ☁️ - Tích hợp instance Bluesky cho truy vấn và tương tác
- [modelcontextprotocol/server-slack](https://github.com/modelcontextprotocol/servers/tree/main/src/slack) 📇 ☁️ - Tích hợp workspace Slack cho quản lý kênh và nhắn tin
- [korotovsky/slack-mcp-server](https://github.com/korotovsky/slack-mcp-server) 📇 ☁️ - Máy chủ MCP mạnh mẽ nhất cho Slack Workspaces.
- [sawa-zen/vrchat-mcp](https://github.com/sawa-zen/vrchat-mcp) - 📇 🏠 Đây là máy chủ MCP để tương tác với API VRChat. Bạn có thể lấy thông tin về bạn bè, thế giới, avatar và nhiều hơn nữa trong VRChat.
- [takumi0706/google-calendar-mcp](https://github.com/takumi0706/google-calendar-mcp) 📇 ☁️ - Máy chủ MCP giao tiếp với Google Calendar API. Dựa trên TypeScript.
- [teddyzxcv/ntfy-mcp](https://github.com/teddyzxcv/ntfy-mcp) - Máy chủ MCP giữ bạn được thông báo bằng cách gửi notification lên điện thoại qua ntfy
- [userad/didlogic_mcp](https://github.com/UserAd/didlogic_mcp) 🐍 ☁️ - Máy chủ MCP cho [DIDLogic](https://didlogic.com). Thêm chức năng quản lý SIP endpoint, số điện thoại và đích đến.
- [zcaceres/gtasks-mcp](https://github.com/zcaceres/gtasks-mcp) 📇 ☁️ - Máy chủ MCP quản lý Google Tasks
- [InditexTech/mcp-teams-server](https://github.com/InditexTech/mcp-teams-server) 🐍 ☁️ - Máy chủ MCP tích hợp nhắn tin Microsoft Teams (đọc, đăng, đề cập, liệt kê thành viên và luồng)
- [softeria/ms-365-mcp-server](https://github.com/softeria/ms-365-mcp-server) 📇 ☁️ - Máy chủ MCP kết nối toàn bộ bộ Microsoft 365 qua Graph API (bao gồm mail, file, Excel, calendar)
- [YCloud-Developers/ycloud-whatsapp-mcp-server](https://github.com/YCloud-Developers/ycloud-whatsapp-mcp-server) 📇 🏠 - Máy chủ MCP cho WhatsApp Business Platform của YCloud.
- [jaipandya/producthunt-mcp-server](https://github.com/jaipandya/producthunt-mcp-server) 🐍 🏠 - Máy chủ MCP cho Product Hunt. Tương tác với bài đăng trending, bình luận, bộ sưu tập, người dùng và nhiều hơn nữa.


### 👤 <a name="customer-data-platforms"></a>Nền Tảng Dữ Liệu Khách Hàng

Cung cấp truy cập hồ sơ khách hàng trong nền tảng dữ liệu khách hàng

- [iaptic/mcp-server-iaptic](https://github.com/iaptic/mcp-server-iaptic) 🎖️ 📇 ☁️ - Kết nối với [iaptic](https://www.iaptic.com) để hỏi về Mua hàng, dữ liệu giao dịch và thống kê doanh thu ứng dụng của khách hàng.
- [OpenDataMCP/OpenDataMCP](https://github.com/OpenDataMCP/OpenDataMCP) 🐍 ☁️ - Kết nối mọi Open Data với bất kỳ LLM nào qua Model Context Protocol.
- [sergehuber/inoyu-mcp-unomi-server](https://github.com/sergehuber/inoyu-mcp-unomi-server) 📇 ☁️ - Máy chủ MCP truy cập và cập nhật hồ sơ trên máy chủ Apache Unomi CDP.
- [tinybirdco/mcp-tinybird](https://github.com/tinybirdco/mcp-tinybird) 🐍 ☁️ - Máy chủ MCP tương tác với Tinybird Workspace từ bất kỳ khách hàng MCP nào.
- [@antv/mcp-server-chart](https://github.com/antvis/mcp-server-chart) 🎖️ 📇 ☁️ - Máy chủ Model Context Protocol tạo biểu đồ trực quan sử dụng [AntV](https://github.com/antvis).

### 🗄️ <a name="databases"></a>Cơ Sở Dữ Liệu

Truy cập cơ sở dữ liệu an toàn với khả năng kiểm tra schema. Cho phép truy vấn và phân tích dữ liệu với kiểm soát bảo mật cấu hình được bao gồm truy cập chỉ đọc.

- [Aiven-Open/mcp-aiven](https://github.com/Aiven-Open/mcp-aiven) - 🐍 ☁️ 🎖️ -  Duyệt [Aiven projects](https://go.aiven.io/mcp-server) và tương tác với các dịch vụ PostgreSQL®, Apache Kafka®, ClickHouse® và OpenSearch®
- [alexanderzuev/supabase-mcp-server](https://github.com/alexander-zuev/supabase-mcp-server) - Máy chủ Supabase MCP hỗ trợ thực thi truy vấn SQL và công cụ khám phá cơ sở dữ liệu
- [aliyun/alibabacloud-tablestore-mcp-server](https://github.com/aliyun/alibabacloud-tablestore-mcp-server) ☕ 🐍 ☁️ - Dịch vụ MCP cho Tablestore, gồm thêm tài liệu, tìm kiếm ngữ nghĩa cho tài liệu dựa trên vector và scalar, thân thiện với RAG, và serverless.
- [benborla29/mcp-server-mysql](https://github.com/benborla/mcp-server-mysql) ☁️ 🏠 - Tích hợp cơ sở dữ liệu MySQL trong NodeJS với kiểm soát truy cập cấu hình được và kiểm tra schema
- [bytebase/dbhub](https://github.com/bytebase/dbhub) 📇 🏠 – Máy chủ MCP cơ sở dữ liệu đa năng hỗ trợ các cơ sở dữ liệu chính thống.
- [c4pt0r/mcp-server-tidb](https://github.com/c4pt0r/mcp-server-tidb) 🐍 ☁️ - Tích hợp cơ sở dữ liệu TiDB với kiểm tra schema và khả năng truy vấn
- [Canner/wren-engine](https://github.com/Canner/wren-engine) 🐍 🦀 🏠 - Semantic Engine cho Model Context Protocol(MCP) Clients và AI Agents
- [centralmind/gateway](https://github.com/centralmind/gateway) 🏎️ 🏠 🍎 🪟 - Máy chủ MCP và MCP SSE tự động tạo API dựa trên schema và dữ liệu cơ sở dữ liệu. Hỗ trợ PostgreSQL, Clickhouse, MySQL, Snowflake, BigQuery, Supabase
- [ChristianHinge/dicom-mcp](https://github.com/ChristianHinge/dicom-mcp) 🐍 ☁️ 🏠 - Tích hợp DICOM để truy vấn, đọc và chuyển hình ảnh y tế và báo cáo từ PACS cùng các hệ thống tuân thủ DICOM khác.
- [chroma-core/chroma-mcp](https://github.com/chroma-core/chroma-mcp) 🎖️ 🐍 ☁️ 🏠 - Máy chủ Chroma MCP truy cập instance Chroma cục bộ và đám mây cho khả năng truy xuất
- [ClickHouse/mcp-clickhouse](https://github.com/ClickHouse/mcp-clickhouse) 🐍 ☁️ - Tích hợp cơ sở dữ liệu ClickHouse với kiểm tra schema và khả năng truy vấn
- [confluentinc/mcp-confluent](https://github.com/confluentinc/mcp-confluent) 🐍 ☁️ - Tích hợp Confluent để tương tác với Confluent Kafka và Confluent Cloud REST APIs.
- [Couchbase-Ecosystem/mcp-server-couchbase](https://github.com/Couchbase-Ecosystem/mcp-server-couchbase) 🎖️ 🐍 ☁️ 🏠 - Máy chủ Couchbase MCP cung cấp quyền truy cập hợp nhất cho cả Capella cloud và các cụm tự quản lý để thao tác tài liệu, truy vấn SQL++ và phân tích dữ liệu ngôn ngữ tự nhiên.
- [cr7258/elasticsearch-mcp-server](https://github.com/cr7258/elasticsearch-mcp-server) 🐍 🏠 - Triển khai Máy chủ MCP cung cấp khả năng tương tác với Elasticsearch
- [crystaldba/postgres-mcp](https://github.com/crystaldba/postgres-mcp) 🐍 🏠 - Máy chủ MCP tất cả trong một cho phát triển và vận hành Postgres, với các công cụ phân tích hiệu suất, tinh chỉnh và kiểm tra sức khỏe
- [Dataring-engineering/mcp-server-trino](https://github.com/Dataring-engineering/mcp-server-trino) 🐍 ☁️ - Máy chủ Trino MCP để truy vấn và truy cập dữ liệu từ các cụm Trino.
- [tuannvm/mcp-trino](https://github.com/tuannvm/mcp-trino) 🏎️ ☁️ - Một triển khai Máy chủ Model Context Protocol (MCP) cho Trino bằng Go
- [designcomputer/mysql_mcp_server](https://github.com/designcomputer/mysql_mcp_server) 🐍 🏠 - Tích hợp cơ sở dữ liệu MySQL với kiểm soát truy cập cấu hình, kiểm tra lược đồ và hướng dẫn bảo mật toàn diện
- [wenb1n-dev/mysql_mcp_server_pro](https://github.com/wenb1n-dev/mysql_mcp_server_pro)  🐍 🏠 - Hỗ trợ SSE, STDIO; không chỉ giới hạn ở chức năng CRUD của MySQL; còn bao gồm khả năng phân tích ngoại lệ cơ sở dữ liệu; kiểm soát quyền cơ sở dữ liệu dựa trên vai trò; và giúp nhà phát triển dễ dàng mở rộng công cụ với tuỳ biến
- [domdomegg/airtable-mcp-server](https://github.com/domdomegg/airtable-mcp-server) 📇 🏠 - Tích hợp cơ sở dữ liệu Airtable với kiểm tra lược đồ, khả năng đọc và ghi
- [edwinbernadus/nocodb-mcp-server](https://github.com/edwinbernadus/nocodb-mcp-server) 📇 ☁️ - Tích hợp cơ sở dữ liệu Nocodb, khả năng đọc và ghi
- [ergut/mcp-bigquery-server](https://github.com/ergut/mcp-bigquery-server) 📇 ☁️ - Triển khai máy chủ tích hợp Google BigQuery cho phép truy cập trực tiếp và khả năng truy vấn cơ sở dữ liệu BigQuery
- [f4ww4z/mcp-mysql-server](https://github.com/f4ww4z/mcp-mysql-server) 📇 🏠 - Tích hợp cơ sở dữ liệu MySQL dựa trên Node.js cung cấp hoạt động an toàn với MySQL
- [fireproof-storage/mcp-database-server](https://github.com/fireproof-storage/mcp-database-server) 📇 ☁️ - Cơ sở dữ liệu ledger Fireproof với đồng bộ nhiều người dùng
- [FreePeak/db-mcp-server](https://github.com/FreePeak/db-mcp-server) 🏎️ 🏠 – Một máy chủ MCP đa cơ sở dữ liệu hiệu năng cao được xây dựng bằng Golang, hỗ trợ MySQL & PostgreSQL (NoSQL sắp ra mắt). Bao gồm các công cụ tích hợp cho thực thi truy vấn, quản lý giao dịch, khám phá lược đồ, xây dựng truy vấn và phân tích hiệu suất, với tích hợp Cursor liền mạch để cải thiện quy trình làm việc với cơ sở dữ liệu.
- [furey/mongodb-lens](https://github.com/furey/mongodb-lens) 📇 🏠 - MongoDB Lens: Máy chủ MCP đầy đủ tính năng cho cơ sở dữ liệu MongoDB
- [gannonh/firebase-mcp](https://github.com/gannonh/firebase-mcp) 🔥 ⛅️ - Dịch vụ Firebase bao gồm Auth, Firestore và Storage.
- [get-convex/convex-backend](https://stack.convex.dev/convex-mcp-server) 📇 ☁️ - Tích hợp cơ sở dữ liệu Convex để kiểm tra bảng, hàm, và chạy truy vấn một lần ([Nguồn](https://github.com/get-convex/convex-backend/blob/main/npm-packages/convex/src/cli/mcp.ts))
- [googleapis/genai-toolbox](https://github.com/googleapis/genai-toolbox) 🏎️ ☁️ - Máy chủ MCP mã nguồn mở chuyên về các công cụ dễ dàng, nhanh và an toàn cho cơ sở dữ liệu.
- [GreptimeTeam/greptimedb-mcp-server](https://github.com/GreptimeTeam/greptimedb-mcp-server) 🐍 🏠 - Máy chủ MCP để truy vấn GreptimeDB.
- [hannesrudolph/sqlite-explorer-fastmcp-mcp-server](https://github.com/hannesrudolph/sqlite-explorer-fastmcp-mcp-server) 🐍 🏠 - Máy chủ MCP cung cấp quyền truy cập an toàn, chỉ đọc cho các cơ sở dữ liệu SQLite thông qua Model Context Protocol (MCP). Máy chủ này được xây dựng với FastMCP framework, cho phép LLM khám phá và truy vấn SQLite với tính năng bảo vệ và xác thực truy vấn tích hợp.
- [idoru/influxdb-mcp-server](https://github.com/idoru/influxdb-mcp-server) 📇 ☁️ 🏠 - Chạy truy vấn với InfluxDB OSS API v2.
- [isaacwasserman/mcp-snowflake-server](https://github.com/isaacwasserman/mcp-snowflake-server) 🐍 ☁️ - Tích hợp Snowflake triển khai các hoạt động đọc và (tuỳ chọn) ghi cũng như theo dõi thông tin chi tiết
- [joshuarileydev/supabase-mcp-server](https://github.com/joshuarileydev/supabase) - Máy chủ Supabase MCP để quản lý và tạo dự án và tổ chức trong Supabase
- [jovezhong/mcp-timeplus](https://github.com/jovezhong/mcp-timeplus) 🐍 ☁️ - Máy chủ MCP cho Apache Kafka và Timeplus. Có thể liệt kê các topic Kafka, truy xuất tin nhắn Kafka, lưu dữ liệu Kafka cục bộ và truy vấn dữ liệu streaming với SQL qua Timeplus
- [KashiwaByte/vikingdb-mcp-server](https://github.com/KashiwaByte/vikingdb-mcp-server) 🐍 ☁️ - Tích hợp VikingDB với giới thiệu collection và index, khả năng lưu trữ và tìm kiếm vector.
- [kiliczsh/mcp-mongo-server](https://github.com/kiliczsh/mcp-mongo-server) 📇 🏠 - Máy chủ Model Context Protocol cho MongoDB
- [ktanaka101/mcp-server-duckdb](https://github.com/ktanaka101/mcp-server-duckdb) 🐍 🏠 - Tích hợp cơ sở dữ liệu DuckDB với kiểm tra lược đồ và khả năng truy vấn
- [LucasHild/mcp-server-bigquery](https://github.com/LucasHild/mcp-server-bigquery) 🐍 ☁️ - Tích hợp cơ sở dữ liệu BigQuery với kiểm tra lược đồ và khả năng truy vấn
- [quarkiverse/mcp-server-jdbc](https://github.com/quarkiverse/quarkus-mcp-servers/tree/main/jdbc) ☕ 🏠 - Kết nối với bất kỳ cơ sở dữ liệu tương thích JDBC nào và truy vấn, chèn, cập nhật, xóa, và nhiều hơn nữa.
- [jparkerweb/mcp-sqlite](https://github.com/jparkerweb/mcp-sqlite) 📇 🏠 - Máy chủ Model Context Protocol (MCP) cung cấp khả năng tương tác toàn diện với cơ sở dữ liệu SQLite.
- [memgraph/mcp-memgraph](https://github.com/memgraph/mcp-memgraph) 🐍 🏠 - Máy chủ Memgraph MCP - bao gồm công cụ chạy truy vấn trên Memgraph và tài nguyên lược đồ.
- [modelcontextprotocol/server-postgres](https://github.com/modelcontextprotocol/servers/tree/main/src/postgres) 📇 🏠 - Tích hợp cơ sở dữ liệu PostgreSQL với kiểm tra lược đồ và khả năng truy vấn
- [modelcontextprotocol/server-sqlite](https://github.com/modelcontextprotocol/servers/tree/main/src/sqlite) 🐍 🏠 - Các thao tác với cơ sở dữ liệu SQLite cùng các tính năng phân tích tích hợp sẵn
- [neo4j-contrib/mcp-neo4j](https://github.com/neo4j-contrib/mcp-neo4j) 🐍 🏠 - Model Context Protocol với Neo4j (Chạy truy vấn, Bộ nhớ Đồ thị Tri thức, Quản lý các phiên bản Neo4j Aura)
- [neondatabase/mcp-server-neon](https://github.com/neondatabase/mcp-server-neon) 📇 ☁️ — Máy chủ MCP để tạo và quản lý cơ sở dữ liệu Postgres bằng Neon Serverless Postgres
- [niledatabase/nile-mcp-server](https://github.com/niledatabase/nile-mcp-server) Máy chủ MCP cho nền tảng Postgres của Nile - Quản lý và truy vấn cơ sở dữ liệu Postgres, tenant, người dùng, xác thực bằng LLM
- [openlink/mcp-server-odbc](https://github.com/OpenLinkSoftware/mcp-odbc-server) 🐍 🏠 - Máy chủ MCP cho kết nối Hệ thống Quản trị Cơ sở dữ liệu (DBMS) tổng quát thông qua giao thức Open Database Connectivity (ODBC)
- [openlink/mcp-server-sqlalchemy](https://github.com/OpenLinkSoftware/mcp-sqlalchemy-server) 🐍 🏠 - Máy chủ MCP cho kết nối Hệ thống Quản trị Cơ sở dữ liệu (DBMS) tổng quát thông qua SQLAlchemy sử dụng Python ODBC (pyodbc)
- [pab1it0/adx-mcp-server](https://github.com/pab1it0/adx-mcp-server) 🐍 ☁️ - Truy vấn và phân tích các cơ sở dữ liệu Azure Data Explorer
- [pab1it0/prometheus-mcp-server](https://github.com/pab1it0/prometheus-mcp-server) 🐍 ☁️ -  Truy vấn và phân tích Prometheus, hệ thống giám sát mã nguồn mở.
- [prisma/prisma](https://github.com/prisma/prisma) 🐍 🏠 - Cung cấp cho LLM khả năng quản lý cơ sở dữ liệu Prisma Postgres (ví dụ: khởi tạo cơ sở dữ liệu mới hoặc chạy di trú lược đồ).
- [qdrant/mcp-server-qdrant](https://github.com/qdrant/mcp-server-qdrant) 🐍 🏠 - Máy chủ MCP cho Qdrant
- [QuantGeekDev/mongo-mcp](https://github.com/QuantGeekDev/mongo-mcp) 📇 🏠 - Tích hợp MongoDB cho phép LLM tương tác trực tiếp với cơ sở dữ liệu.
- [rashidazarang/airtable-mcp](https://github.com/rashidazarang/airtable-mcp) 🐍 ☁️ - Kết nối công cụ AI trực tiếp với Airtable. Truy vấn, tạo, cập nhật và xoá bản ghi bằng ngôn ngữ tự nhiên. Các tính năng bao gồm quản lý base, thao tác bảng, điều chỉnh lược đồ, lọc bản ghi và di chuyển dữ liệu qua giao diện MCP chuẩn hóa.
- [redis/mcp-redis](https://github.com/redis/mcp-redis) 🐍 🏠 - Máy chủ MCP chính thức của Redis cung cấp giao diện để quản lý và tìm kiếm dữ liệu trên Redis.
- [runekaagaard/mcp-alchemy](https://github.com/runekaagaard/mcp-alchemy) 🐍 🏠 - Tích hợp cơ sở dữ liệu dựa trên SQLAlchemy đa năng, hỗ trợ PostgreSQL, MySQL, MariaDB, SQLite, Oracle, MS SQL Server và nhiều cơ sở dữ liệu khác. Tính năng kiểm tra lược đồ, mối quan hệ và phân tích bộ dữ liệu lớn.
- [sirmews/mcp-pinecone](https://github.com/sirmews/mcp-pinecone) 🐍 ☁️ - Tích hợp Pinecone với khả năng tìm kiếm vector
- [skysqlinc/skysql-mcp](https://github.com/skysqlinc/skysql-mcp) 🎖️ ☁️ - Máy chủ MCP MariaDB Cloud không máy chủ. Công cụ để khởi tạo, xoá, thực thi SQL và làm việc với các AI agent cấp DB cho text-2-sql chính xác và hội thoại.
- [supabase-community/supabase-mcp](https://github.com/supabase-community/supabase-mcp) 🎖️ 📇 ☁️ - Máy chủ Supabase MCP chính thức kết nối trợ lý AI trực tiếp với dự án Supabase của bạn, cho phép quản lý bảng, lấy cấu hình và truy vấn dữ liệu.
- [TheRaLabs/legion-mcp](https://github.com/TheRaLabs/legion-mcp) 🐍 🏠 Máy chủ MCP cơ sở dữ liệu đa năng hỗ trợ nhiều loại cơ sở dữ liệu bao gồm PostgreSQL, Redshift, CockroachDB, MySQL, RDS MySQL, Microsoft SQL Server, BigQuery, Oracle DB và SQLite.
- [tradercjz/dolphindb-mcp-server](https://github.com/tradercjz/dolphindb-mcp-server) 🐍 ☁️ - Tích hợp cơ sở dữ liệu TDolphinDB với kiểm tra lược đồ và khả năng truy vấn
- [weaviate/mcp-server-weaviate](https://github.com/weaviate/mcp-server-weaviate) 🐍 📇 ☁️ - Máy chủ MCP kết nối tới các collection Weaviate như một kho tri thức cũng như sử dụng Weaviate làm bộ nhớ hội thoại.
- [XGenerationLab/xiyan_mcp_server](https://github.com/XGenerationLab/xiyan_mcp_server) 📇 ☁️ — Máy chủ MCP hỗ trợ truy xuất dữ liệu từ cơ sở dữ liệu bằng truy vấn ngôn ngữ tự nhiên, sử dụng XiyanSQL làm LLM chuyển đổi văn bản thành SQL.
- [xing5/mcp-google-sheets](https://github.com/xing5/mcp-google-sheets) 🐍 ☁️ - Máy chủ Model Context Protocol để tương tác với Google Sheets. Máy chủ này cung cấp các công cụ tạo, đọc, cập nhật và quản lý bảng tính qua Google Sheets API.
- [freema/mcp-gsheets](https://github.com/freema/mcp-gsheets) 📇 ☁️ - Máy chủ MCP tích hợp Google Sheets API với khả năng đọc, ghi, định dạng và quản lý sheet toàn diện.
- [Zhwt/go-mcp-mysql](https://github.com/Zhwt/go-mcp-mysql) 🏎️ 🏠 – Máy chủ MCP MySQL dễ sử dụng, không phụ thuộc, được xây dựng bằng Golang với chế độ chỉ đọc cấu hình và kiểm tra lược đồ.
- [ydb/ydb-mcp](https://github.com/ydb-platform/ydb-mcp) 🎖️ 🐍 ☁️ - Máy chủ MCP để tương tác với cơ sở dữ liệu [YDB](https://ydb.tech)
- [zilliztech/mcp-server-milvus](https://github.com/zilliztech/mcp-server-milvus) 🐍 🏠 ☁️ - Máy chủ MCP cho Milvus / Zilliz, cho phép tương tác với cơ sở dữ liệu của bạn.
- [openlink/mcp-server-jdbc](https://github.com/OpenLinkSoftware/mcp-jdbc-server) 🐍 🏠 - Máy chủ MCP cho kết nối Hệ thống Quản trị Cơ sở dữ liệu (DBMS) tổng quát thông qua giao thức Java Database Connectivity (JDBC)
- [yincongcyincong/VictoriaMetrics-mcp-server](https://github.com/yincongcyincong/VictoriaMetrics-mcp-server) 🐍 🏠 - Máy chủ MCP để tương tác với cơ sở dữ liệu VictoriaMetrics.
- [hydrolix/mcp-hydrolix](https://github.com/hydrolix/mcp-hydrolix) 🎖️ 🐍 ☁️ - Tích hợp Hydrolix time-series datalake cung cấp khả năng khám phá lược đồ và truy vấn cho các quy trình dựa trên LLM.
- [davewind/mysql-mcp-server](https://github.com/dave-wind/mysql-mcp-server) 🏎️ 🏠 – Máy chủ MCP mysql chỉ đọc thân thiện người dùng dành cho cursor và n8n...


### 📊 <a name="data-platforms"></a>Nền tảng Dữ liệu

Nền tảng dữ liệu cho tích hợp, chuyển đổi và điều phối pipeline dữ liệu.

- [flowcore/mcp-flowcore-platform](https://github.com/flowcore-io/mcp-flowcore-platform) 🎖️ 📇 ☁️ 🏠 - Tương tác với Flowcore để thực hiện hành động, nhập dữ liệu, phân tích, đối chiếu và tận dụng bất kỳ dữ liệu nào trong data core của bạn hoặc data core công cộng; tất cả bằng ngôn ngữ tự nhiên.
- [JordiNei/mcp-databricks-server](https://github.com/JordiNeil/mcp-databricks-server) 🐍 ☁️ - Kết nối với Databricks API, cho phép LLM chạy truy vấn SQL, liệt kê job và lấy trạng thái job.
- [yashshingvi/databricks-genie-MCP](https://github.com/yashshingvi/databricks-genie-MCP) 🐍 ☁️ - Máy chủ kết nối với Databricks Genie API, cho phép LLM hỏi các câu hỏi ngôn ngữ tự nhiên, chạy truy vấn SQL và tương tác với agent hội thoại Databricks.
- [jwaxman19/qlik-mcp](https://github.com/jwaxman19/qlik-mcp) 📇 ☁️ - Máy chủ MCP cho Qlik Cloud API cho phép truy vấn ứng dụng, sheet và trích xuất dữ liệu từ trực quan hóa với hỗ trợ xác thực và giới hạn tốc độ toàn diện.
- [keboola/keboola-mcp-server](https://github.com/keboola/keboola-mcp-server) 🐍 - tương tác với Nền tảng Dữ liệu Keboola Connection. Máy chủ này cung cấp các công cụ liệt kê và truy cập dữ liệu từ Keboola Storage API.
- [dbt-labs/dbt-mcp](https://github.com/dbt-labs/dbt-mcp) 🎖️ 🐍 🏠 ☁️ - Máy chủ MCP chính thức cho [dbt (data build tool)](https://www.getdbt.com/product/what-is-dbt) cung cấp tích hợp với dbt Core/Cloud CLI, khám phá metadata dự án, thông tin model và khả năng truy vấn semantic layer.
- [mattijsdp/dbt-docs-mcp](https://github.com/mattijsdp/dbt-docs-mcp) 🐍 🏠 - Máy chủ MCP cho người dùng dbt-core (OSS) vì dbt MCP chính thức chỉ hỗ trợ dbt Cloud. Hỗ trợ metadata dự án, lineage cấp model và cột, tài liệu dbt.

### 💻 <a name="developer-tools"></a>Công Cụ Phát Triển

Các công cụ và tích hợp giúp nâng cao quy trình phát triển và quản lý môi trường.

- [Pratyay/mac-monitor-mcp](https://github.com/Pratyay/mac-monitor-mcp) 🐍 🏠 🍎 - Xác định các tiến trình tiêu tốn tài nguyên trên macOS và đưa ra đề xuất cải thiện hiệu suất.
- [21st-dev/Magic-MCP](https://github.com/21st-dev/magic-mcp) - Tạo các thành phần UI được thiết kế tinh xảo lấy cảm hứng từ các kỹ sư thiết kế tốt nhất của 21st.dev.
- [Hypersequent/qasphere-mcp](https://github.com/Hypersequent/qasphere-mcp) 🎖️ 📇 ☁️ - Tích hợp với hệ thống quản lý kiểm thử [QA Sphere](https://qasphere.com/), cho phép LLM khám phá, tóm tắt và tương tác với test case trực tiếp từ IDE AI
- [admica/FileScopeMCP](https://github.com/admica/FileScopeMCP) 🐍 📇 🦀 - Phân tích codebase của bạn để xác định các file quan trọng dựa trên mối quan hệ phụ thuộc. Sinh sơ đồ và điểm số quan trọng, giúp trợ lý AI hiểu codebase.
- [ambar/simctl-mcp](https://github.com/ambar/simctl-mcp) 📇 🏠 🍎 Máy chủ MCP cho điều khiển iOS Simulator.
- [api7/apisix-mcp](https://github.com/api7/apisix-mcp) 🎖️ 📇 🏠 Máy chủ MCP hỗ trợ truy vấn và quản lý tất cả tài nguyên trong [Apache APISIX](https://github.com/apache/apisix).
- [ArchAI-Labs/fastmcp-sonarqube-metrics](https://github.com/ArchAI-Labs/fastmcp-sonarqube-metrics) 🐍 🏠 🪟 🐧 🍎 -  Máy chủ Model Context Protocol (MCP) cung cấp bộ công cụ để lấy thông tin về dự án SonarQube như số liệu (thực tế và lịch sử), lỗi, trạng thái sức khỏe.
- [automation-ai-labs/mcp-link](https://github.com/automation-ai-labs/mcp-link) 🏎️ 🏠 - Tích hợp bất kỳ API nào với AI Agents một cách liền mạch (với OpenAPI Schema)
- [azer/react-analyzer-mcp](https://github.com/azer/react-analyzer-mcp) 📇 🏠 - Phân tích mã React tại chỗ, sinh tài liệu / llm.txt cho toàn bộ dự án chỉ trong một lần
- [davidlin2k/pox-mcp-server](https://github.com/davidlin2k/pox-mcp-server) 🐍 🏠 - Máy chủ MCP cho POX SDN controller cung cấp khả năng kiểm soát và quản lý mạng.
- [CodeLogicIncEngineering/codelogic-mcp-server](https://github.com/CodeLogicIncEngineering/codelogic-mcp-server) 🎖️ 🐍 ☁️ 🍎 🪟 🐧 - Máy chủ MCP chính thức cho CodeLogic, cung cấp quyền truy cập vào phân tích phụ thuộc mã, phân tích rủi ro kiến trúc và công cụ đánh giá tác động.
- [Comet-ML/Opik-MCP](https://github.com/comet-ml/opik-mcp) 🎖️ 📇 ☁️ 🏠 - Sử dụng ngôn ngữ tự nhiên để khám phá khả năng quan sát LLM, trace và dữ liệu giám sát được ghi nhận bởi Opik.
- [CircleCI/mcp-server-circleci](https://github.com/CircleCI-Public/mcp-server-circleci) 📇 ☁️ Cho phép AI Agents sửa lỗi build từ CircleCI.
- [currents-dev/currents-mcp](https://github.com/currents-dev/currents-mcp) 🎖️ 📇 ☁️ Cho phép AI Agents sửa lỗi kiểm thử Playwright được báo cáo lên [Currents](https://currents.dev).
- [delano/postman-mcp-server](https://github.com/delano/postman-mcp-server) 📇 ☁️ - Tương tác với [Postman API](https://www.postman.com/postman/postman-public-workspace/)
- [flipt-io/mcp-server-flipt](https://github.com/flipt-io/mcp-server-flipt) 📇 🏠 - Cho phép trợ lý AI tương tác với feature flag trong [Flipt](https://flipt.io).
- [GLips/Figma-Context-MCP](https://github.com/GLips/Figma-Context-MCP) 📇 🏠 - Cung cấp cho agent mã quyền truy cập trực tiếp vào dữ liệu Figma để hỗ trợ hiện thực thiết kế one-shot.
- [gofireflyio/firefly-mcp](https://github.com/gofireflyio/firefly-mcp) 🎖️ 📇 ☁️ - Tích hợp, khám phá, quản lý và mã hóa tài nguyên cloud với [Firefly](https://firefly.ai).
- [Govcraft/rust-docs-mcp-server](https://github.com/Govcraft/rust-docs-mcp-server) 🦀 🏠 - Cung cấp context tài liệu Rust crate mới nhất cho LLM qua công cụ MCP, sử dụng tìm kiếm ngữ nghĩa (embeddings) và tóm tắt bằng LLM.
- [haris-musa/excel-mcp-server](https://github.com/haris-musa/excel-mcp-server) 🐍 🏠 - Máy chủ thao tác Excel cung cấp tạo workbook, thao tác dữ liệu, định dạng và các tính năng nâng cao (biểu đồ, pivot table, công thức).
- [higress-group/higress-ops-mcp-server](https://github.com/higress-group/higress-ops-mcp-server) 🐍 🏠 - Máy chủ MCP cung cấp các công cụ toàn diện để quản lý cấu hình và vận hành cổng [Higress](https://github.com/alibaba/higress).
- [hijaz/postmancer](https://github.com/hijaz/postmancer) 📇 🏠 - Máy chủ MCP thay thế các Rest Clients như Postman/Insomnia, cho phép LLM của bạn quản lý và sử dụng bộ sưu tập API.
- [hloiseaufcms/mcp-gopls](https://github.com/hloiseaufcms/mcp-gopls) 🏎️ 🏠 - Máy chủ MCP để tương tác với [Go's Language Server Protocol (gopls)](https://github.com/golang/tools/tree/master/gopls) và tận dụng các tính năng phân tích mã Go nâng cao.
- [hungthai1401/bruno-mcp](https://github.com/hungthai1401/bruno-mcp) 📇 🏠 - Máy chủ MCP để tương tác với [Bruno API Client](https://www.usebruno.com/).
- [hyperb1iss/droidmind](https://github.com/hyperb1iss/droidmind) 🐍 🏠 - Điều khiển thiết bị Android với AI thông qua MCP, cho phép điều khiển thiết bị, gỡ lỗi, phân tích hệ thống và tự động hóa giao diện người dùng với khung bảo mật toàn diện.
- [XixianLiang/HarmonyOS-mcp-server](https://github.com/XixianLiang/HarmonyOS-mcp-server) 🐍 🏠 - Điều khiển thiết bị HarmonyOS-next với AI qua MCP. Hỗ trợ điều khiển thiết bị và tự động hóa giao diện người dùng.
- [IlyaGulya/gradle-mcp-server](https://github.com/IlyaGulya/gradle-mcp-server) 🏠 - Tích hợp Gradle bằng Gradle Tooling API để kiểm tra dự án, thực thi tác vụ và chạy kiểm thử với báo cáo kết quả từng bài kiểm thử.
- [InhiblabCore/mcp-image-compression](https://github.com/InhiblabCore/mcp-image-compression) 🐍 🏠 - Máy chủ MCP nén cục bộ nhiều định dạng ảnh khác nhau.
- [isaacphi/mcp-language-server](https://github.com/isaacphi/mcp-language-server) 🏎️ 🏠 - MCP Language Server giúp các client hỗ trợ MCP điều hướng codebase dễ dàng hơn bằng cách cung cấp các công cụ ngữ nghĩa như tìm định nghĩa, tham chiếu, đổi tên và chẩn đoán lỗi.
- [ios-simulator-mcp](https://github.com/joshuayoes/ios-simulator-mcp) 📇 🏠 🍎 - Máy chủ MCP (Model Context Protocol) để tương tác với trình giả lập iOS. Cho phép bạn lấy thông tin, điều khiển UI và kiểm tra các thành phần giao diện trên trình giả lập iOS.
- [InditexTech/mcp-server-simulator-ios-idb](https://github.com/InditexTech/mcp-server-simulator-ios-idb) 📇 🏠 🍎 - Máy chủ MCP (Model Context Protocol) cho phép LLM tương tác với các trình giả lập iOS (iPhone, iPad, v.v) thông qua các lệnh ngôn ngữ tự nhiên.
- [IvanAmador/vercel-ai-docs-mcp](https://github.com/IvanAmador/vercel-ai-docs-mcp) 📇 🏠 - Máy chủ MCP cung cấp khả năng tìm kiếm và truy vấn tài liệu Vercel AI SDK dựa trên AI.
- [j4c0bs/mcp-server-sql-analyzer](https://github.com/j4c0bs/mcp-server-sql-analyzer) 🐍 - Máy chủ MCP phân tích SQL, linting và chuyển đổi dialect bằng [SQLGlot](https://github.com/tobymao/sqlglot)
- [jasonjmcghee/claude-debugs-for-you](https://github.com/jasonjmcghee/claude-debugs-for-you) 📇 🏠 - Máy chủ MCP và tiện ích mở rộng VS Code cho phép tự động gỡ lỗi (đa ngôn ngữ) qua breakpoint và đánh giá biểu thức.
- [jetbrains/mcpProxy](https://github.com/JetBrains/mcpProxy) 🎖️ 📇 🏠 - Kết nối với JetBrains IDE
- [qainsights/jmeter-mcp-server](https://github.com/QAInsights/jmeter-mcp-server) 🐍 🏠 - Máy chủ JMeter MCP để kiểm thử hiệu năng
- [Jktfe/serveMyAPI](https://github.com/Jktfe/serveMyAPI) 📇 🏠 🍎 - Máy chủ MCP cá nhân (Model Context Protocol) để lưu trữ và truy cập khóa API an toàn trên nhiều dự án bằng macOS Keychain.
- [joshuarileydev/app-store-connect-mcp-server](https://github.com/JoshuaRileyDev/app-store-connect-mcp-server) 📇 🏠 - Máy chủ MCP giao tiếp với App Store Connect API dành cho lập trình viên iOS
- [joshuarileydev/simulator-mcp-server](https://github.com/JoshuaRileyDev/simulator-mcp-server) 📇 🏠 - Máy chủ MCP điều khiển trình giả lập iOS
- [qainsights/k6-mcp-server](https://github.com/QAInsights/k6-mcp-server) 🐍 🏠 - Máy chủ Grafana k6 MCP dùng để kiểm thử hiệu năng
- [lamemind/mcp-server-multiverse](https://github.com/lamemind/mcp-server-multiverse) 📇 🏠 🛠️ - Máy chủ trung gian cho phép nhiều phiên bản độc lập của cùng một máy chủ MCP cùng tồn tại với namespace và cấu hình riêng biệt.
- [langfuse/mcp-server-langfuse](https://github.com/langfuse/mcp-server-langfuse) 🐍 🏠 - Máy chủ MCP truy cập và quản lý prompt ứng dụng LLM được tạo bằng [Langfuse]([https://langfuse.com/](https://langfuse.com/docs/prompts/get-started)) Prompt Management.
- [mobile-next/mobile-mcp](https://github.com/mobile-next/mobile-mcp) 📇 🏠 🐧 🍎 - Máy chủ MCP cho tự động hóa ứng dụng và thiết bị Android/iOS, phát triển và thu thập thông tin ứng dụng. Hỗ trợ thiết bị mô phỏng/thực như iPhone, Google Pixel, Samsung.
- [qainsights/locust-mcp-server](https://github.com/QAInsights/locust-mcp-server) 🐍 🏠 - Máy chủ Locust MCP dùng cho kiểm thử hiệu năng
- [mrexodia/user-feedback-mcp](https://github.com/mrexodia/user-feedback-mcp) 🐍 🏠 - Máy chủ MCP đơn giản cho phép quy trình "con người trong vòng lặp" trong các công cụ như Cline và Cursor.
- [narumiruna/gitingest-mcp](https://github.com/narumiruna/gitingest-mcp) 🐍 🏠 - Máy chủ MCP dùng [gitingest](https://github.com/cyclotruc/gitingest) để chuyển đổi bất kỳ kho Git nào thành bản tóm tắt codebase dạng text.
- [OctoMind-dev/octomind-mcp](https://github.com/OctoMind-dev/octomind-mcp) 📇 ☁️ - Cho phép agent AI yêu thích của bạn tạo và chạy kiểm thử end-to-end [Octomind](https://www.octomind.dev/) từ codebase hoặc các nguồn dữ liệu khác như Jira, Slack hoặc TestRail.
- [kadykov/mcp-openapi-schema-explorer](https://github.com/kadykov/mcp-openapi-schema-explorer) 📇 ☁️ 🏠 - Truy cập hiệu quả OpenAPI/Swagger specs qua MCP Resources tiết kiệm token.
- [pskill9/website-downloader](https://github.com/pskill9/website-downloader) 🗄️ 🚀 - Máy chủ MCP này cung cấp công cụ tải toàn bộ trang web bằng wget. Giữ nguyên cấu trúc và chuyển đổi liên kết để dùng cục bộ.
- [utensils/mcp-nixos](https://github.com/utensils/mcp-nixos) 🐍 🏠 - Máy chủ MCP cung cấp thông tin chính xác về gói NixOS, các tùy chọn hệ thống, cấu hình Home Manager và cài đặt nix-darwin cho macOS, giúp giảm hiện tượng ảo giác AI.
- [QuantGeekDev/docker-mcp](https://github.com/QuantGeekDev/docker-mcp) 🏎️ 🏠 - Quản lý và vận hành container Docker qua MCP
- [ckreiling/mcp-server-docker](https://github.com/ckreiling/mcp-server-docker) 🐍 🏠 - Tích hợp với Docker để quản lý container, image, volume và network.
- [r-huijts/xcode-mcp-server](https://github.com/r-huijts/xcode-mcp-server) 📇 🏠 🍎 - Tích hợp Xcode cho quản lý dự án, thao tác tệp và tự động hóa build
- [ReAPI-com/mcp-openapi](https://github.com/ReAPI-com/mcp-openapi) 📇 🏠 - Máy chủ MCP cho phép LLM biết mọi thứ về OpenAPI specs của bạn để tìm kiếm, giải thích, sinh mã/mẫu dữ liệu
- [Rootly-AI-Labs/Rootly-MCP-server](https://github.com/Rootly-AI-Labs/Rootly-MCP-server) 🎖️ 🐍 ☁️ 🍎 - Máy chủ MCP cho nền tảng quản lý sự cố [Rootly](https://rootly.com/).
- [sammcj/mcp-package-version](https://github.com/sammcj/mcp-package-version) 📇 🏠 - Máy chủ MCP giúp LLM gợi ý phiên bản package ổn định mới nhất khi viết mã.
- [sapientpants/sonarqube-mcp-server](https://github.com/sapientpants/sonarqube-mcp-server) 🦀 ☁️ 🏠 - Máy chủ Model Context Protocol (MCP) tích hợp với SonarQube để cung cấp cho trợ lý AI quyền truy cập vào chỉ số chất lượng code, vấn đề và trạng thái quality gate
- [SDGLBL/mcp-claude-code](https://github.com/SDGLBL/mcp-claude-code) 🐍 🏠 - Triển khai khả năng Claude Code qua MCP, giúp AI hiểu, sửa đổi mã và phân tích dự án với bộ công cụ toàn diện.
- [snaggle-ai/openapi-mcp-server](https://github.com/snaggle-ai/openapi-mcp-server) 🏎️ 🏠 - Kết nối bất kỳ máy chủ HTTP/REST API nào bằng Open API spec (v3)
- [stass/lldb-mcp](https://github.com/stass/lldb-mcp) 🐍 🏠 🐧 🍎 - Máy chủ MCP cho LLDB cho phép AI phân tích nhị phân, core file, debug, disassemble.
- [TencentEdgeOne/edgeone-pages-mcp](https://github.com/TencentEdgeOne/edgeone-pages-mcp) 📇 ☁️ - Dịch vụ MCP triển khai nội dung HTML lên EdgeOne Pages và nhận URL công khai.
- [tumf/mcp-text-editor](https://github.com/tumf/mcp-text-editor) 🐍 🏠 - Trình soạn thảo file văn bản theo dòng. Tối ưu cho LLM với quyền truy cập một phần file tiết kiệm token.
- [vivekvells/mcp-pandoc](https://github.com/vivekVells/mcp-pandoc) 🗄️ 🚀 - Máy chủ MCP chuyển đổi định dạng tài liệu liền mạch bằng Pandoc, hỗ trợ Markdown, HTML, PDF, DOCX (.docx), csv và hơn thế nữa.
- [VSCode Devtools](https://github.com/biegehydra/BifrostMCP) 📇 - Kết nối với VSCode IDE và sử dụng công cụ ngữ nghĩa như `find_usages`
- [xcodebuild](https://github.com/ShenghaiWang/xcodebuild) 🍎 Build workspace/dự án Xcode iOS và phản hồi lỗi về cho llm.
- [xzq.xu/jvm-mcp-server](https://github.com/xzq-xu/jvm-mcp-server) 📇 🏠  - Dự án triển khai máy chủ MCP (Model Context Protocol) dựa trên JVM.
- [yangkyeongmo@/mcp-server-apache-airflow](https://github.com/yangkyeongmo/mcp-server-apache-airflow) 🐍 🏠 - Máy chủ MCP kết nối với [Apache Airflow](https://airflow.apache.org/) bằng client chính thức.
- [YuChenSSR/mindmap-mcp-server](https://github.com/YuChenSSR/mindmap-mcp-server) 🐍 🏠 - Máy chủ Model Context Protocol (MCP) tạo sơ đồ tư duy tương tác đẹp mắt.
- [YuChenSSR/multi-ai-advisor](https://github.com/YuChenSSR/multi-ai-advisor-mcp) 📇 🏠 - Máy chủ Model Context Protocol (MCP) truy vấn nhiều mô hình Ollama và tổng hợp phản hồi, cung cấp đa góc nhìn AI cho một câu hỏi.
- [yWorks/mcp-typescribe](https://github.com/yWorks/mcp-typescribe) 📇 🏠 - Máy chủ MCP cung cấp thông tin API Typescript hiệu quả cho agent để làm việc với các API chưa được đào tạo.
- [zcaceres/fetch-mcp](https://github.com/zcaceres/fetch-mcp) 📇 🏠 - Máy chủ MCP linh hoạt để lấy dữ liệu JSON, text, và HTML
- [zenml-io/mcp-zenml](https://github.com/zenml-io/mcp-zenml) 🐍 🏠 ☁️ - Máy chủ MCP kết nối với pipeline ZenML MLOps và LLMOps của bạn [ZenML](https://www.zenml.io)
- [idosal/git-mcp](https://github.com/idosal/git-mcp) 📇 ☁️ - [gitmcp.io](https://gitmcp.io/) là máy chủ MCP từ xa kết nối với bất kỳ kho hoặc dự án [GitHub](https://www.github.com) nào để lấy tài liệu
- [tgeselle/bugsnag-mcp](https://github.com/tgeselle/bugsnag-mcp) 📇 ☁️ - Máy chủ MCP tương tác với [Bugsnag](https://www.bugsnag.com/)
- [jordandalton/restcsv-mcp-server](https://github.com/JordanDalton/RestCsvMcpServer) 📇 ☁️ - Máy chủ MCP cho file CSV.
- [cjo4m06/mcp-shrimp-task-manager](https://github.com/cjo4m06/mcp-shrimp-task-manager) 📇 ☁️ 🏠 – Hệ thống quản lý task tập trung cho lập trình, tăng cường agent code như Cursor AI với ghi nhớ task nâng cao, tự phản ánh và quản lý phụ thuộc. [ShrimpTaskManager](https://cjo4m06.github.io/mcp-shrimp-task-manager)
- [axliupore/mcp-code-runner](https://github.com/axliupore/mcp-code-runner) 📇 🏠 - Máy chủ MCP chạy mã cục bộ bằng Docker, hỗ trợ nhiều ngôn ngữ lập trình.
- [yikakia/godoc-mcp-server](https://github.com/yikakia/godoc-mcp-server) 🏎️ ☁️ 🪟 🐧 🍎 - Truy vấn thông tin gói Go trên pkg.go.dev
- [ckanthony/gin-mcp](https://github.com/ckanthony/gin-mcp) 🏎️ ☁️ 📟 🪟 🐧 🍎 - Thư viện Go không cấu hình tự động mở API Gin web framework hiện có thành công cụ MCP.
- [ryan0204/github-repo-mcp](https://github.com/Ryan0204/github-repo-mcp) 📇 ☁️ 🪟 🐧 🍎 - GitHub Repo MCP cho phép trợ lý AI duyệt repo GitHub, khám phá thư mục và xem nội dung tệp.
- [alimo7amed93/webhook-tester-mcp](https://github.com/alimo7amed93/webhook-tester-mcp)  🐍 ☁️ – Máy chủ dựa trên FastMCP để tương tác với webhook-test.com. Cho phép tạo, lấy và xóa webhook cục bộ bằng Claude.
- [lpigeon/ros-mcp-server](https://github.com/lpigeon/ros-mcp-server) 🐍 🏠 🍎 🪟 🐧 - ROS MCP Server hỗ trợ điều khiển robot bằng cách chuyển đổi lệnh ngôn ngữ tự nhiên của người dùng thành lệnh điều khiển ROS hoặc ROS2.
- [jsdelivr/globalping-mcp-server](https://github.com/jsdelivr/globalping-mcp-server) 🎖️ 📇 ☁️ - Máy chủ Globalping MCP cho phép người dùng và LLM chạy các công cụ mạng như ping, traceroute, mtr, HTTP và DNS resolve từ hàng ngàn địa điểm trên toàn thế giới.
- [posthog/mcp](https://github.com/posthog/mcp) 🎖️ 📇 ☁️ - Máy chủ MCP để tương tác với PostHog analytics, feature flags, theo dõi lỗi và nhiều hơn thế nữa.
- [artmann/package-registry-mcp](https://github.com/artmann/package-registry-mcp) 🏠 📇 🍎 🪟 🐧 - Máy chủ MCP để tìm kiếm và lấy thông tin cập nhật về các gói NPM, Cargo, PyPi và NuGet.

### 🔒 <a name="delivery"></a>Giao nhận

- [https://github.com/jordandalton/doordash-mcp-server](https://github.com/JordanDalton/DoorDash-MCP-Server) 🐍 – DoorDash Delivery (Không chính thức)

### 🧮 <a name="data-science-tools"></a>Công cụ Khoa học Dữ liệu

Tích hợp và công cụ giúp đơn giản hóa việc khám phá, phân tích dữ liệu và nâng cao quy trình làm việc khoa học dữ liệu.

- [ChronulusAI/chronulus-mcp](https://github.com/ChronulusAI/chronulus-mcp) 🐍 ☁️ - Dự đoán mọi thứ với tác nhân dự báo và dự đoán của Chronulus AI.
- [reading-plus-ai/mcp-server-data-exploration](https://github.com/reading-plus-ai/mcp-server-data-exploration) 🐍 ☁️ - Cho phép khám phá dữ liệu tự động trên tập dữ liệu dựa trên .csv, cung cấp phân tích thông minh với nỗ lực tối thiểu.
- [zcaceres/markdownify-mcp](https://github.com/zcaceres/markdownify-mcp) 📇 🏠 - Máy chủ MCP chuyển đổi gần như mọi file hoặc nội dung web sang Markdown
- [datalayer/jupyter-mcp-server](https://github.com/datalayer/jupyter-mcp-server) 🐍 🏠 - Máy chủ Model Context Protocol (MCP) cho Jupyter.
- [jjsantos01/jupyter-notebook-mcp](https://github.com/jjsantos01/jupyter-notebook-mcp) 🐍 🏠 - Kết nối Jupyter Notebook với Claude AI, cho phép Claude tương tác trực tiếp và điều khiển Jupyter Notebooks.
- [arrismo/kaggle-mcp](https://github.com/arrismo/kaggle-mcp) 🐍 ☁️ - Kết nối với Kaggle, có khả năng tải và phân tích tập dữ liệu.
- [kdqed/zaturn](https://github.com/kdqed/zaturn) 🐍 🏠 🪟 🐧 🍎 - Liên kết nhiều nguồn dữ liệu (SQL, CSV, Parquet, v.v.) và yêu cầu AI phân tích để tìm insight và trực quan hóa.
- [mckinsey/vizro-mcp](https://github.com/mckinsey/vizro/tree/main/vizro-mcp) 🎖️ 🐍 🏠 - Công cụ và mẫu tạo biểu đồ, dashboard dữ liệu đã được kiểm định và dễ bảo trì.
- [growthbook/growthbook-mcp](https://github.com/growthbook/growthbook-mcp) 🎖️ 📇 🏠 🪟 🐧 🍎 — Công cụ tạo và tương tác với feature flag và thử nghiệm GrowthBook.

### 📟 <a name="embedded-system"></a>Hệ thống nhúng

Cung cấp quyền truy cập tài liệu và phím tắt khi làm việc với thiết bị nhúng.

- [horw/esp-mcp](https://github.com/horw/esp-mcp) 📟 - Quy trình khắc phục sự cố build trên chip ESP32 bằng ESP-IDF.
- [kukapay/modbus-mcp](https://github.com/kukapay/modbus-mcp) 🐍 📟 - Máy chủ MCP tiêu chuẩn hóa và ngữ cảnh hóa dữ liệu Modbus công nghiệp.
- [kukapay/opcua-mcp](https://github.com/kukapay/opcua-mcp) 🐍 📟 - Máy chủ MCP kết nối với hệ thống công nghiệp hỗ trợ OPC UA.
- [yoelbassin/gnuradioMCP](https://github.com/yoelbassin/gnuradioMCP) 🐍 📟 🏠 - Máy chủ MCP cho GNU Radio cho phép LLM tự động tạo và chỉnh sửa sơ đồ dòng RF `.grc`.

### 📂 <a name="file-systems"></a>Hệ thống tệp

Cung cấp quyền truy cập trực tiếp vào hệ thống tệp cục bộ với quyền có thể cấu hình. Cho phép AI đọc, ghi và quản lý tệp trong các thư mục chỉ định.

- [cyberchitta/llm-context.py](https://github.com/cyberchitta/llm-context.py) 🐍 🏠 - Chia sẻ ngữ cảnh mã nguồn với LLM qua MCP hoặc clipboard
- [exoticknight/mcp-file-merger](https://github.com/exoticknight/mcp-file-merger) 🏎️ 🏠 - Công cụ gộp file, phù hợp với giới hạn độ dài chat AI.
- [filesystem@quarkiverse/quarkus-mcp-servers](https://github.com/quarkiverse/quarkus-mcp-servers/tree/main/filesystem) ☕ 🏠 - Một hệ thống tệp cho phép duyệt và chỉnh sửa file, triển khai bằng Java dùng Quarkus. Có sẵn dưới dạng jar hoặc native image.
- [hmk/box-mcp-server](https://github.com/hmk/box-mcp-server) 📇 ☁️ - Tích hợp Box để liệt kê, đọc và tìm kiếm tệp tin
- [mamertofabian/mcp-everything-search](https://github.com/mamertofabian/mcp-everything-search) 🐍 🏠 🪟 - Tìm kiếm tệp tin nhanh trên Windows sử dụng Everything SDK
- [mark3labs/mcp-filesystem-server](https://github.com/mark3labs/mcp-filesystem-server) 🏎️ 🏠 - Triển khai bằng Golang để truy cập hệ thống tệp cục bộ.
- [mickaelkerjean/filestash](https://github.com/mickael-kerjean/filestash/tree/master/server/plugin/plg_handler_mcp) 🏎️ ☁️ - Truy cập Lưu trữ Từ xa: SFTP, S3, FTP, SMB, NFS, WebDAV, GIT, FTPS, gcloud, azure blob, sharepoint, v.v.
- [microsoft/markitdown](https://github.com/microsoft/markitdown/tree/main/packages/markitdown-mcp) 🎖️ 🐍 🏠 - Truy cập công cụ MCP tới MarkItDown -- thư viện chuyển đổi nhiều định dạng tệp (cục bộ hoặc từ xa) sang Markdown cho AI LLM sử dụng.
- [modelcontextprotocol/server-filesystem](https://github.com/modelcontextprotocol/servers/tree/main/src/filesystem) 📇 🏠 - Truy cập hệ thống tệp cục bộ trực tiếp.
- [modelcontextprotocol/server-google-drive](https://github.com/modelcontextprotocol/servers/tree/main/src/gdrive) 📇 ☁️ - Tích hợp Google Drive để liệt kê, đọc và tìm kiếm tệp tin
- [Xuanwo/mcp-server-opendal](https://github.com/Xuanwo/mcp-server-opendal) 🐍 🏠 ☁️ - Truy cập bất kỳ lưu trữ nào với Apache OpenDAL™
- [jeannier/homebrew-mcp](https://github.com/jeannier/homebrew-mcp) 🐍 🏠 🍎 - Điều khiển thiết lập Homebrew trên macOS bằng ngôn ngữ tự nhiên qua máy chủ MCP này. Dễ dàng quản lý gói, hỏi gợi ý, khắc phục sự cố brew, v.v.

### 💰 <a name="finance--fintech"></a>Tài chính & Công nghệ tài chính

Công cụ truy cập và phân tích dữ liệu tài chính. Cho phép mô hình AI làm việc với dữ liệu thị trường, nền tảng giao dịch và thông tin tài chính.

- [aaronjmars/web3-research-mcp](https://github.com/aaronjmars/web3-research-mcp) 📇 ☁️ - Nghiên cứu sâu về crypto - miễn phí & hoàn toàn cục bộ
- [alchemy/alchemy-mcp-server](https://github.com/alchemyplatform/alchemy-mcp-server) 🎖️ 📇 ☁️ - Cho phép AI agent tương tác với API blockchain của Alchemy.
- [OctagonAI/octagon-mcp-server](https://github.com/OctagonAI/octagon-mcp-server) 🐍 ☁️ - Octagon AI Agent tích hợp dữ liệu thị trường riêng tư và công khai
- [anjor/coinmarket-mcp-server](https://github.com/anjor/coinmarket-mcp-server) 🐍 ☁️ - Tích hợp API Coinmarket để lấy danh sách và báo giá tiền mã hóa
- [ariadng/metatrader-mcp-server](https://github.com/ariadng/metatrader-mcp-server) 🐍 🏠 🪟 - Cho phép AI LLMs thực hiện giao dịch sử dụng nền tảng MetaTrader 5
- [armorwallet/armor-crypto-mcp](https://github.com/armorwallet/armor-crypto-mcp) 🐍 ☁️ - MCP giao tiếp với nhiều blockchain, staking, DeFi, swap, bridging, quản lý ví, DCA, Lệnh giới hạn, Tra cứu Coin, Theo dõi và nhiều hơn nữa.
- [bankless/onchain-mcp](https://github.com/Bankless/onchain-mcp/) 📇 ☁️ - Bankless Onchain API để tương tác với smart contract, truy vấn thông tin giao dịch và token
- [base/base-mcp](https://github.com/base/base-mcp) 🎖️ 📇 ☁️ - Tích hợp Base Network cho công cụ onchain, cho phép tương tác với Base Network và Coinbase API để quản lý ví, chuyển tiền, smart contract, và các hoạt động DeFi
- [berlinbra/alpha-vantage-mcp](https://github.com/berlinbra/alpha-vantage-mcp) 🐍 ☁️ - Tích hợp API Alpha Vantage để lấy thông tin chứng khoán và tiền mã hóa
- [ahnlabio/bicscan-mcp](https://github.com/ahnlabio/bicscan-mcp) 🎖️ 🐍 ☁️ - Điểm rủi ro / tài sản của địa chỉ blockchain EVM (EOA, CA, ENS) và cả tên miền.
- [bitteprotocol/mcp](https://github.com/BitteProtocol/mcp) 📇 - Tích hợp Bitte Protocol để chạy AI Agent trên nhiều blockchain.
- [chargebee/mcp](https://github.com/chargebee/agentkit/tree/main/modelcontextprotocol) 🎖️ 📇 ☁️ - Máy chủ MCP kết nối AI agent tới [nền tảng Chargebee](https://www.chargebee.com/).
- [codex-data/codex-mcp](https://github.com/Codex-Data/codex-mcp) 🎖️ 📇 ☁️ - Tích hợp [Codex API](https://www.codex.io) cho dữ liệu blockchain và thị trường thời gian thực trên 60+ mạng lưới
- [coinpaprika/dexpaprika-mcp](https://github.com/chargebee/agentkit/tree/main/modelcontextprotocol) 🎖️ 📇 ☁️ 🍎 🪟 🐧 - Máy chủ MCP DexPaprika của Coinpaprika cung cấp [DexPaprika API](https://docs.dexpaprika.com) hiệu suất cao bao gồm 20+ chuỗi và 5 triệu+ token với dữ liệu giá thời gian thực, dữ liệu pool thanh khoản & lịch sử OHLCV, cung cấp cho AI agent quyền truy cập tiêu chuẩn vào dữ liệu thị trường toàn diện thông qua Model Context Protocol.
- [doggybee/mcp-server-ccxt](https://github.com/doggybee/mcp-server-ccxt) 📇 ☁️ - Máy chủ MCP truy cập dữ liệu thị trường crypto thời gian thực và giao dịch qua 20+ sàn sử dụng thư viện CCXT. Hỗ trợ spot, futures, OHLCV, số dư, lệnh, v.v.
- [ferdousbhai/investor-agent](https://github.com/ferdousbhai/investor-agent) 🐍 ☁️ - Tích hợp Yahoo Finance để lấy dữ liệu thị trường chứng khoán bao gồm khuyến nghị quyền chọn
- [ferdousbhai/tasty-agent](https://github.com/ferdousbhai/tasty-agent) 🐍 ☁️ - Tích hợp API Tastyworks để thực hiện giao dịch trên Tastytrade
- [ferdousbhai/wsb-analyst-mcp](https://github.com/ferdousbhai/wsb-analyst-mcp) 🐍 ☁️ - Tích hợp Reddit để phân tích nội dung cộng đồng WallStreetBets
- [getalby/nwc-mcp-server](https://github.com/getalby/nwc-mcp-server) 📇 🏠 - Tích hợp ví Bitcoin Lightning qua Nostr Wallet Connect
- [heurist-network/heurist-mesh-mcp-server](https://github.com/heurist-network/heurist-mesh-mcp-server) 🎖️ ⛅️ 🏠 🐍 - Truy cập các AI agent web3 chuyên biệt cho phân tích blockchain, kiểm toán bảo mật smart contract, đánh giá chỉ số token, và tương tác on-chain qua mạng Heurist Mesh. Cung cấp bộ công cụ toàn diện cho phân tích DeFi, định giá NFT và giám sát giao dịch trên nhiều blockchain
- [intentos-labs/beeper-mcp](https://github.com/intentos-labs/beeper-mcp) 🐍 - Beeper cung cấp giao dịch trên BSC, bao gồm chuyển số dư/token, hoán đổi token trên Pancakeswap và nhận thưởng beeper.
- [kukapay/blockbeats-mcp](https://github.com/kukapay/blockbeats-mcp) 🐍 ☁️ - Máy chủ MCP cung cấp tin tức blockchain và bài viết chuyên sâu từ BlockBeats cho AI agent.
- [kukapay/bridge-rates-mcp](https://github.com/kukapay/bridge-rates-mcp) 📇 ☁️ - Cung cấp tỷ giá cầu nối chuỗi chéo thời gian thực và tuyến chuyển tối ưu cho AI agent onchain.
- [kukapay/chainlink-feeds-mcp](https://github.com/kukapay/chainlink-feeds-mcp) 📇 ☁️ - Cung cấp quyền truy cập thời gian thực vào nguồn giá on-chain phi tập trung của Chainlink.
- [kukapay/cointelegraph-mcp](https://github.com/kukapay/cointelegraph-mcp) 🐍 ☁️ - Cung cấp quyền truy cập thời gian thực vào tin tức mới nhất từ Cointelegraph.
- [kukapay/crypto-feargreed-mcp](https://github.com/kukapay/crypto-feargreed-mcp) 🐍 ☁️ - Cung cấp dữ liệu Chỉ số Sợ hãi & Tham lam Crypto thời gian thực và lịch sử.
- [kukapay/crypto-indicators-mcp](https://github.com/kukapay/crypto-indicators-mcp) 🐍 ☁️ - Máy chủ MCP cung cấp nhiều chỉ báo và chiến lược phân tích kỹ thuật tiền mã hóa.
- [kukapay/crypto-news-mcp](https://github.com/kukapay/crypto-news-mcp) 🐍 ☁️ - Máy chủ MCP cung cấp tin tức crypto thời gian thực từ NewsData cho AI agent.
- [kukapay/crypto-portfolio-mcp](https://github.com/kukapay/crypto-portfolio-mcp) 🐍 ☁️ - Máy chủ MCP cho theo dõi và quản lý phân bổ danh mục tiền mã hóa.
- [kukapay/crypto-rss-mcp](https://github.com/kukapay/crypto-rss-mcp) 🐍 ☁️ - Máy chủ MCP tổng hợp tin tức crypto thời gian thực từ nhiều nguồn RSS.
- [kukapay/crypto-sentiment-mcp](https://github.com/kukapay/crypto-sentiment-mcp) 🐍 ☁️ - Máy chủ MCP cung cấp phân tích cảm xúc tiền mã hóa cho AI agent.
- [kukapay/crypto-trending-mcp](https://github.com/kukapay/crypto-trending-mcp) 🐍 ☁️ - Theo dõi các token xu hướng mới nhất trên CoinGecko.
- [kukapay/crypto-whitepapers-mcp](https://github.com/kukapay/crypto-whitepapers-mcp) 🐍 ☁️ - Nền tảng tri thức cấu trúc về whitepaper tiền mã hóa.
- [kukapay/cryptopanic-mcp-server](https://github.com/kukapay/cryptopanic-mcp-server) 🐍 ☁️ - Cung cấp tin tức crypto mới nhất cho AI agent, sử dụng CryptoPanic.
- [kukapay/defi-yields-mcp](https://github.com/kukapay/defi-yields-mcp) 🐍 ☁️ - Máy chủ MCP cho AI agent khám phá cơ hội DeFi yield.
- [kukapay/dune-analytics-mcp](https://github.com/kukapay/dune-analytics-mcp) 🐍 ☁️ - Máy chủ MCP kết nối dữ liệu Dune Analytics tới AI agent.
- [kukapay/etf-flow-mcp](https://github.com/kukapay/etf-flow-mcp) 🐍 ☁️ - Cung cấp dữ liệu dòng vốn ETF crypto hỗ trợ quyết định của AI agent.
- [kukapay/freqtrade-mcp](https://github.com/kukapay/freqtrade-mcp) 🐍 ☁️ - Máy chủ MCP tích hợp bot giao dịch tiền mã hóa Freqtrade.
- [kukapay/funding-rates-mcp](https://github.com/kukapay/funding-rates-mcp) 🐍 ☁️ - Cung cấp dữ liệu funding rate thời gian thực trên các sàn giao dịch crypto lớn.
- [kukapay/jupiter-mcp](https://github.com/kukapay/jupiter-mcp) 🐍 ☁️ - Máy chủ MCP thực hiện hoán đổi token trên Solana sử dụng Jupiter Ultra API mới.
- [kukapay/pancakeswap-poolspy-mcp](https://github.com/kukapay/pancakeswap-poolspy-mcp) 🐍 ☁️ - Máy chủ MCP theo dõi pool mới tạo trên Pancake Swap.
- [kukapay/rug-check-mcp](https://github.com/kukapay/rug-check-mcp) 🐍 ☁️ - Máy chủ MCP phát hiện rủi ro tiềm ẩn trong meme token Solana.
- [kukapay/thegraph-mcp](https://github.com/kukapay/thegraph-mcp) 🐍 ☁️ - Máy chủ MCP cung cấp dữ liệu blockchain đã được index từ The Graph cho AI agent.
- [kukapay/token-minter-mcp](https://github.com/kukapay/token-minter-mcp) 🐍 ☁️ - Máy chủ MCP cung cấp công cụ cho AI agent mint token ERC-20 trên nhiều blockchain.
- [kukapay/token-revoke-mcp](https://github.com/kukapay/token-revoke-mcp) 🐍 ☁️ - Máy chủ MCP kiểm tra và thu hồi quyền sử dụng token ERC-20 trên nhiều blockchain.
- [kukapay/twitter-username-changes-mcp](https://github.com/kukapay/twitter-username-changes-mcp) 🐍 ☁️ - Máy chủ MCP theo dõi lịch sử thay đổi tên người dùng Twitter.
- [kukapay/uniswap-poolspy-mcp](https://github.com/kukapay/uniswap-poolspy-mcp) 🐍 ☁️ - Máy chủ MCP theo dõi pool thanh khoản mới trên Uniswap ở nhiều blockchain.
- [kukapay/uniswap-trader-mcp](https://github.com/kukapay/uniswap-trader-mcp) 🐍 ☁️ - Máy chủ MCP cho AI agent tự động hóa hoán đổi token trên Uniswap DEX ở nhiều blockchain.
- [kukapay/whale-tracker-mcp](https://github.com/kukapay/whale-tracker-mcp) 🐍 ☁️ - Máy chủ MCP theo dõi giao dịch cá voi tiền mã hóa.
- [laukikk/alpaca-mcp](https://github.com/laukikk/alpaca-mcp) 🐍 ☁️ - Máy chủ MCP cho API giao dịch Alpaca để quản lý danh mục chứng khoán và crypto, đặt lệnh, truy cập dữ liệu thị trường.
- [longportapp/openapi](https://github.com/longportapp/openapi/tree/main/mcp) - 🐍 ☁️ - LongPort OpenAPI cung cấp dữ liệu chứng khoán thời gian thực, cho phép AI truy cập phân tích và giao dịch qua MCP.
- [mcpdotdirect/evm-mcp-server](https://github.com/mcpdotdirect/evm-mcp-server) 📇 ☁️ - Dịch vụ blockchain toàn diện cho 30+ mạng EVM, hỗ trợ token gốc, ERC20, NFT, smart contract, giao dịch, và giải quyết ENS.
- [mcpdotdirect/starknet-mcp-server](https://github.com/mcpdotdirect/starknet-mcp-server) 📇 ☁️ - Tích hợp blockchain Starknet toàn diện với hỗ trợ token gốc (ETH, STRK), smart contract, giải quyết StarknetID, và chuyển token.
- [minhyeoky/mcp-server-ledger](https://github.com/minhyeoky/mcp-server-ledger) 🐍 🏠 - Tích hợp ledger-cli để quản lý giao dịch tài chính và tạo báo cáo.
- [openMF/mcp-mifosx](https://github.com/openMF/mcp-mifosx) ☁️ 🏠 - Tích hợp ngân hàng lõi để quản lý khách hàng, khoản vay, tiết kiệm, cổ phần, giao dịch tài chính và lập báo cáo tài chính.
- [narumiruna/yfinance-mcp](https://github.com/narumiruna/yfinance-mcp) 🐍 ☁️ - Máy chủ MCP sử dụng yfinance để lấy thông tin từ Yahoo Finance.
- [polygon-io/mcp_polygon)](https://github.com/polygon-io/mcp_polygon)) 🐍 ☁️ - Máy chủ MCP cung cấp quyền truy cập API dữ liệu thị trường tài chính [Polygon.io](https://polygon.io/) cho cổ phiếu, chỉ số, forex, quyền chọn, v.v.
- [pwh-pwh/coin-mcp-server](https://github.com/pwh-pwh/coin-mcp-server) 🐍 ☁️ - Bitget API để lấy giá tiền mã hóa.
- [QuantGeekDev/coincap-mcp](https://github.com/QuantGeekDev/coincap-mcp) 📇 ☁️ - Tích hợp dữ liệu thị trường crypto thời gian thực sử dụng CoinCap API công khai, truy cập giá và thông tin thị trường crypto không cần API key
- [SaintDoresh/Crypto-Trader-MCP-ClaudeDesktop](https://github.com/SaintDoresh/Crypto-Trader-MCP-ClaudeDesktop.git) 🐍 ☁️ - Công cụ MCP cung cấp dữ liệu thị trường crypto sử dụng API CoinGecko.
- [tooyipjee/yahoofinance-mcp](https://github.com/tooyipjee/yahoofinance-mcp.git) 📇 ☁️ - Phiên bản TS của yahoo finance mcp.
- [SaintDoresh/YFinance-Trader-MCP-ClaudeDesktop](https://github.com/SaintDoresh/YFinance-Trader-MCP-ClaudeDesktop.git) 🐍 ☁️ - Công cụ MCP cung cấp dữ liệu và phân tích thị trường chứng khoán sử dụng Yahoo Finance API.
- [RomThpt/xrpl-mcp-server](https://github.com/RomThpt/mcp-xrpl) 📇 ☁️ - Máy chủ MCP cho XRP Ledger cung cấp truy cập thông tin tài khoản, lịch sử giao dịch và dữ liệu mạng. Cho phép truy vấn đối tượng ledger, gửi giao dịch và giám sát mạng XRPL.
- [janswist/mcp-dexscreener](https://github.com/janswist/mcp-dexscreener) 📇 ☁️ - Giá thị trường on-chain thời gian thực sử dụng Dexscreener API mở, miễn phí
- [HuggingAGI/mcp-baostock-server](https://github.com/HuggingAGI/mcp-baostock-server) 🐍 ☁️ - Máy chủ MCP dựa trên baostock, cung cấp truy cập và phân tích dữ liệu thị trường chứng khoán Trung Quốc.
- [wowinter13/solscan-mcp](https://github.com/wowinter13/solscan-mcp) 🦀 🏠 - Công cụ MCP truy vấn giao dịch Solana bằng ngôn ngữ tự nhiên với Solscan API.
- [Wuye-AI/mcp-server-wuye-ai](https://github.com/wuye-ai/mcp-server-wuye-ai) 🎖️ 📇 ☁️ - Máy chủ MCP tương tác với nền tảng CRIC Wuye AI, trợ lý thông minh dành riêng cho ngành quản lý bất động sản.
- [zlinzzzz/finData-mcp-server](https://github.com/zlinzzzz/finData-mcp-server) 🐍 ☁️ - Máy chủ MCP truy cập dữ liệu tài chính chuyên nghiệp, hỗ trợ nhiều nhà cung cấp dữ liệu như Tushare.

### 🎮 <a name="gaming"></a>Gaming

Tích hợp với dữ liệu, engine và dịch vụ liên quan đến game

- [IvanMurzak/Unity-MCP](https://github.com/IvanMurzak/Unity-MCP) #️⃣ 🏠 🍎 🪟 🐧 - Máy chủ MCP cho Unity Editor và game phát triển bằng Unity
- [CoderGamester/mcp-unity](https://github.com/CoderGamester/mcp-unity) #️⃣ 🏠 - Máy chủ MCP tích hợp Unity3d Game Engine cho phát triển trò chơi
- [Coding-Solo/godot-mcp](https://github.com/Coding-Solo/godot-mcp) 📇 🏠 - Máy chủ MCP tương tác với engine Godot, cung cấp công cụ chỉnh sửa, chạy, debug, quản lý scene trong dự án Godot.
- [pab1ito/chess-mcp](https://github.com/pab1it0/chess-mcp) 🐍 ☁️ - Truy cập dữ liệu người chơi Chess.com, hồ sơ ván đấu, và thông tin công khai qua giao diện MCP tiêu chuẩn, cho phép trợ lý AI tìm kiếm và phân tích thông tin cờ vua.
- [jiayao/mcp-chess](https://github.com/jiayao/mcp-chess) 🐍 🏠 - Máy chủ MCP chơi cờ vua với LLMs.
- [rishijatia/fantasy-pl-mcp](https://github.com/rishijatia/fantasy-pl-mcp/) 🐍 ☁️ - Máy chủ MCP cho dữ liệu và công cụ phân tích Fantasy Premier League thời gian thực.
- [opgginc/opgg-mcp](https://github.com/opgginc/opgg-mcp) 📇 ☁️ - Truy cập dữ liệu game thời gian thực cho các tựa game phổ biến như League of Legends, TFT, Valorant, cung cấp phân tích tướng, lịch esports, meta, chỉ số nhân vật.
- [stefan-xyz/mcp-server-runescape](https://github.com/stefan-xyz/mcp-server-runescape) 📇 - Máy chủ MCP với công cụ tương tác dữ liệu RuneScape (RS) và Old School RuneScape (OSRS), gồm giá vật phẩm, bảng xếp hạng người chơi, v.v.

### 🧠 <a name="knowledge--memory"></a>Kiến thức & Bộ nhớ

Lưu trữ bộ nhớ bền vững sử dụng cấu trúc đồ thị tri thức. Cho phép mô hình AI duy trì và truy vấn thông tin có cấu trúc xuyên suốt phiên làm việc.
- [CheMiguel23/MemoryMesh](https://github.com/CheMiguel23/MemoryMesh) 📇 🏠 - Bộ nhớ dựa trên đồ thị được cải tiến với trọng tâm vào nhập vai AI và tạo truyện
- [graphlit-mcp-server](https://github.com/graphlit/graphlit-mcp-server) 📇 ☁️ - Nhập dữ liệu từ Slack, Discord, website, Google Drive, Linear hoặc GitHub vào một dự án Graphlit - sau đó tìm kiếm và truy xuất kiến thức liên quan trong một client MCP như Cursor, Windsurf hoặc Cline.
- [hannesrudolph/mcp-ragdocs](https://github.com/hannesrudolph/mcp-ragdocs) 🐍 🏠 - Một triển khai máy chủ MCP cung cấp công cụ truy xuất và xử lý tài liệu thông qua tìm kiếm vector, cho phép trợ lý AI bổ sung câu trả lời với ngữ cảnh tài liệu liên quan
- [jinzcdev/markmap-mcp-server](https://github.com/jinzcdev/markmap-mcp-server) 📇 🏠 - Máy chủ MCP xây dựng dựa trên [markmap](https://github.com/markmap/markmap) chuyển đổi **Markdown** sang **sơ đồ tư duy tương tác**. Hỗ trợ xuất ra nhiều định dạng (PNG/JPG/SVG), xem trước trực tiếp trên trình duyệt, sao chép Markdown chỉ bằng một cú nhấp chuột, và các tính năng trực quan động.
- [kaliaboi/mcp-zotero](https://github.com/kaliaboi/mcp-zotero) 📇 ☁️ - Bộ kết nối cho LLM làm việc với bộ sưu tập và nguồn tài liệu trên Zotero Cloud của bạn
- [mcp-summarizer](https://github.com/0xshellming/mcp-summarizer) 📕 ☁️ - Máy chủ MCP tóm tắt AI, hỗ trợ nhiều loại nội dung: Văn bản thuần, Trang web, Tài liệu PDF, Sách EPUB, Nội dung HTML
- [mem0ai/mem0-mcp](https://github.com/mem0ai/mem0-mcp) 🐍 🏠 - Máy chủ Model Context Protocol cho Mem0 giúp quản lý sở thích và mẫu lập trình, cung cấp công cụ lưu trữ, truy xuất và xử lý ngữ nghĩa các triển khai mã, thực tiễn tốt nhất và tài liệu kỹ thuật trong IDE như Cursor và Windsurf
- [modelcontextprotocol/server-memory](https://github.com/modelcontextprotocol/servers/tree/main/src/memory) 📇 🏠 - Hệ thống bộ nhớ bền dựa trên đồ thị tri thức để duy trì ngữ cảnh
- [pinecone-io/assistant-mcp](https://github.com/pinecone-io/assistant-mcp) 🎖️ 🦀 ☁️ - Kết nối với Pinecone Assistant của bạn và cung cấp cho tác tử ngữ cảnh từ công cụ tri thức của nó.
- [@ragieai/mcp-server](https://github.com/ragieai/ragie-mcp-server) 📇 ☁️ - Truy xuất ngữ cảnh từ [Ragie](https://www.ragie.ai) (RAG) knowledge base của bạn, kết nối với các tích hợp như Google Drive, Notion, JIRA và nhiều hơn nữa.
- [TechDocsStudio/biel-mcp](https://github.com/TechDocsStudio/biel-mcp) 📇 ☁️ - Cho phép các công cụ AI như Cursor, VS Code, hoặc Claude Desktop trả lời câu hỏi bằng tài liệu sản phẩm của bạn. Biel.ai cung cấp hệ thống RAG và máy chủ MCP.
- [topoteretes/cognee](https://github.com/topoteretes/cognee/tree/dev/cognee-mcp) 📇 🏠 - Trình quản lý bộ nhớ cho ứng dụng AI và tác tử sử dụng đa dạng kho đồ thị và vector, cho phép nhập dữ liệu từ hơn 30 nguồn
- [unibaseio/membase-mcp](https://github.com/unibaseio/membase-mcp) 📇 ☁️ - Lưu trữ và truy vấn bộ nhớ tác tử của bạn một cách phân tán bằng Membase
- [GistPad-MCP](https://github.com/lostintangent/gistpad-mcp) 📇 🏠 - Sử dụng GitHub Gists để quản lý và truy cập kiến thức cá nhân, ghi chú hàng ngày và các prompt tái sử dụng. Hoạt động như một bạn đồng hành với https://gistpad.dev và [tiện ích mở rộng GistPad VS Code](https://aka.ms/gistpad).
- [entanglr/zettelkasten-mcp](https://github.com/entanglr/zettelkasten-mcp) 🐍 🏠 - Máy chủ Model Context Protocol (MCP) triển khai phương pháp quản lý tri thức Zettelkasten, cho phép bạn tạo, liên kết, và tìm kiếm ghi chú nguyên tử thông qua Claude và các client tương thích MCP khác.

### 🗺️ <a name="location-services"></a>Dịch vụ Định vị

Các dịch vụ dựa trên vị trí và công cụ bản đồ. Cho phép mô hình AI làm việc với dữ liệu địa lý, thông tin thời tiết và phân tích dựa trên vị trí.

- [briandconnelly/mcp-server-ipinfo](https://github.com/briandconnelly/mcp-server-ipinfo) 🐍 ☁️  - Định vị địa lý địa chỉ IP và thông tin mạng sử dụng API IPInfo
- [devilcoder01/weather-mcp-server](https://github.com/devilcoder01/weather-mcp-server) 🐍 ☁️ - Truy cập dữ liệu thời tiết theo thời gian thực cho bất kỳ vị trí nào sử dụng API WeatherAPI.com, cung cấp dự báo chi tiết và điều kiện hiện tại.
- [jagan-shanmugam/open-streetmap-mcp](https://github.com/jagan-shanmugam/open-streetmap-mcp) 🐍 🏠 - Máy chủ MCP OpenStreetMap với dịch vụ định vị và dữ liệu không gian địa lý.
- [kukapay/nearby-search-mcp](https://github.com/kukapay/nearby-search-mcp) 🐍 ☁️ - Máy chủ MCP cho tìm kiếm địa điểm gần đó với nhận diện vị trí dựa trên IP.
- [modelcontextprotocol/server-google-maps](https://github.com/modelcontextprotocol/servers/tree/main/src/google-maps) 📇 ☁️ - Tích hợp Google Maps cho dịch vụ định vị, chỉ đường và chi tiết địa điểm
- [QGIS MCP](https://github.com/jjsantos01/qgis_mcp) - kết nối QGIS Desktop với Claude AI thông qua MCP. Tích hợp này cho phép tạo dự án trợ giúp bởi prompt, tải layer, thực thi mã và nhiều hơn nữa.
- [SaintDoresh/Weather-MCP-ClaudeDesktop](https://github.com/SaintDoresh/Weather-MCP-ClaudeDesktop.git) 🐍 ☁️ - Công cụ MCP cung cấp dữ liệu thời tiết theo thời gian thực, dự báo và thông tin thời tiết lịch sử bằng API OpenWeatherMap.
- [rossshannon/Weekly-Weather-mcp](https://github.com/rossshannon/weekly-weather-mcp.git) 🐍 ☁️ - Máy chủ Weekly Weather MCP trả về dự báo thời tiết chi tiết 7 ngày trên toàn thế giới.
- [SecretiveShell/MCP-timeserver](https://github.com/SecretiveShell/MCP-timeserver) 🐍 🏠 - Truy cập thời gian ở bất kỳ múi giờ nào và lấy thời gian địa phương hiện tại
- [TimLukaHorstmann/mcp-weather](https://github.com/TimLukaHorstmann/mcp-weather) 📇 ☁️  - Dự báo thời tiết chính xác thông qua API AccuWeather (có phiên bản miễn phí).
- [webcoderz/MCP-Geo](https://github.com/webcoderz/MCP-Geo) 🐍 🏠 - Máy chủ MCP Geocoding cho nominatim, ArcGIS, Bing
- [ipfind/ipfind-mcp-server](https://github.com/ipfind/ipfind-mcp-server) 🐍 ☁️ - Dịch vụ định vị địa chỉ IP sử dụng API [IP Find](https://ipfind.com)
- [mahdin75/geoserver-mcp](https://github.com/mahdin75/geoserver-mcp) 🏠 – Một triển khai máy chủ Model Context Protocol (MCP) kết nối LLM với GeoServer REST API, cho phép trợ lý AI tương tác với dữ liệu và dịch vụ không gian địa lý.
- [ipfred/aiwen-mcp-server-geoip](https://github.com/ipfred/aiwen-mcp-server-geoip) 🐍 📇 ☁️ – Máy chủ MCP cho Aiwen IP Location, lấy vị trí mạng IP người dùng, chi tiết IP (quốc gia, tỉnh, thành phố, vĩ độ, kinh độ, ISP, chủ sở hữu, v.v.)

### 🎯 <a name="marketing"></a>Marketing

Công cụ tạo và chỉnh sửa nội dung marketing, làm việc với metadata web, định vị sản phẩm và hướng dẫn chỉnh sửa.

- [gomarble-ai/facebook-ads-mcp-server](https://github.com/gomarble-ai/facebook-ads-mcp-server) 🐍 ☁️ - Máy chủ MCP làm giao diện với Facebook Ads, cho phép truy cập lập trình dữ liệu và tính năng quản lý Facebook Ads.
- [open-strategy-partners/osp_marketing_tools](https://github.com/open-strategy-partners/osp_marketing_tools) 🐍 🏠 - Bộ công cụ marketing của Open Strategy Partners bao gồm phong cách viết, mã chỉnh sửa và tạo bản đồ giá trị marketing sản phẩm.
- [nictuku/meta-ads-mcp](https://github.com/nictuku/meta-ads-mcp) 🐍 ☁️ 🏠 - Cho phép tác tử AI giám sát và tối ưu hiệu suất quảng cáo Meta, phân tích số liệu chiến dịch, điều chỉnh đối tượng mục tiêu, quản lý tài sản sáng tạo, và đưa ra khuyến nghị dựa trên dữ liệu về chi tiêu quảng cáo và thiết lập chiến dịch thông qua tích hợp Graph API liền mạch.
- [marketplaceadpros/amazon-ads-mcp-server](https://github.com/MarketplaceAdPros/amazon-ads-mcp-server) 📇 ☁️  - Cho phép công cụ tương tác với Amazon Advertising, phân tích chỉ số chiến dịch và cấu hình.

### 📊 <a name="monitoring"></a>Giám sát

Truy cập và phân tích dữ liệu giám sát ứng dụng. Cho phép mô hình AI xem báo cáo lỗi và chỉ số hiệu năng.

- [netdata/netdata#Netdata](https://github.com/netdata/netdata/blob/master/src/web/mcp/README.md) 🎖️ 🏠 ☁️ 📟 🍎 🪟 🐧 - Phát hiện, khám phá, báo cáo và phân tích nguyên nhân gốc bằng tất cả dữ liệu quan sát, gồm metrics, logs, hệ thống, container, tiến trình và kết nối mạng
- [grafana/mcp-grafana](https://github.com/grafana/mcp-grafana) 🎖️ 🐍 🏠 ☁️ - Tìm kiếm dashboard, điều tra sự cố và truy vấn nguồn dữ liệu trong Grafana của bạn
- [tumf/grafana-loki-mcp](https://github.com/tumf/grafana-loki-mcp) 🐍 🏠 - Máy chủ MCP cho phép truy vấn logs Loki qua API Grafana.
- [hyperb1iss/lucidity-mcp](https://github.com/hyperb1iss/lucidity-mcp) 🐍 🏠 - Nâng cao chất lượng mã do AI sinh ra thông qua phân tích thông minh dựa trên prompt trên 10 tiêu chí quan trọng từ độ phức tạp đến lỗ hổng bảo mật
- [last9/last9-mcp-server](https://github.com/last9/last9-mcp-server) - Mang liền mạch ngữ cảnh sản xuất thời gian thực—logs, metrics và traces—vào môi trường cục bộ để tự động sửa mã nhanh hơn
- [metoro-io/metoro-mcp-server](https://github.com/metoro-io/metoro-mcp-server) 🎖️ 🏎️ ☁️ - Truy vấn và tương tác với môi trường kubernetes được Metoro giám sát
- [MindscapeHQ/server-raygun](https://github.com/MindscapeHQ/mcp-server-raygun) 📇 ☁️ - Tích hợp Raygun API V3 cho báo cáo crash và giám sát người dùng thực
- [modelcontextprotocol/server-sentry](https://github.com/modelcontextprotocol/servers/tree/main/src/sentry) 🐍 ☁️ - Tích hợp Sentry.io để theo dõi lỗi và hiệu năng
- [pydantic/logfire-mcp](https://github.com/pydantic/logfire-mcp) 🎖️ 🐍 ☁️ - Cung cấp truy cập traces và metrics OpenTelemetry thông qua Logfire
- [seekrays/mcp-monitor](https://github.com/seekrays/mcp-monitor) 🏎️ 🏠 - Công cụ giám sát hệ thống hiển thị các chỉ số hệ thống qua Model Context Protocol (MCP). Cho phép LLM truy xuất thông tin hệ thống thời gian thực qua giao diện MCP-compatible. (hỗ trợ CPU, Bộ nhớ, Ổ đĩa, Mạng, Máy chủ, Tiến trình)
- [VictoriaMetrics-Community/mcp-victoriametrics](https://github.com/VictoriaMetrics-Community/mcp-victoriametrics) 🎖️ 🏎️ 🏠 - Tích hợp toàn diện với [VictoriaMetrics instance APIs](https://docs.victoriametrics.com/victoriametrics/url-examples/) và [tài liệu](https://docs.victoriametrics.com/) để giám sát, quan sát và gỡ lỗi liên quan tới các instance VictoriaMetrics của bạn

### 🎥 <a name="multimedia-process"></a>Xử lý Đa phương tiện

Cung cấp khả năng xử lý đa phương tiện như chỉnh sửa âm thanh và video, phát lại, chuyển đổi định dạng, bao gồm cả bộ lọc video, tăng cường, v.v.

- [video-creator/ffmpeg-mcp](https://github.com/video-creator/ffmpeg-mcp.git) 🎥 🔊 - Sử dụng dòng lệnh ffmpeg để xây dựng máy chủ mcp, rất tiện lợi, thông qua hội thoại để tìm kiếm, cắt ghép, nối, phát lại video cục bộ và các chức năng khác
- [stass/exif-mcp](https://github.com/stass/exif-mcp) 📇 🏠 🐧 🍎 🪟 - Máy chủ MCP cho phép kiểm tra metadata ảnh như EXIF, XMP, JFIF và GPS. Nền tảng cho tìm kiếm và phân tích thư viện ảnh, bộ sưu tập hình ảnh bởi LLM.
- [sunriseapps/imagesorcery-mcp](https://github.com/sunriseapps/imagesorcery-mcp) 🐍 🏠 🐧 🍎 🪟 - Bộ công cụ nhận diện và chỉnh sửa ảnh dựa trên ComputerVision 🪄 cho trợ lý AI.

### 🔎 <a name="search"></a>Tìm kiếm & Trích xuất Dữ liệu

- [Xyber-Labs/mcp-server-youtube](https://github.com/Xyber-Labs/mcp-servers/tree/main/mcp-server-youtube) 🐍 ☁️ - Repository này triển khai máy chủ MCP (Model Context Protocol) cho tìm kiếm YouTube và trích xuất phụ đề. Cho phép mô hình ngôn ngữ hoặc tác tử khác dễ dàng truy vấn nội dung YouTube qua giao thức chuẩn hóa.
- [ricocf/mcp-wolframalpha](https://github.com/ricocf/mcp-wolframalpha) 🐍 🏠 ☁️ - Máy chủ MCP cho phép trợ lý AI sử dụng API Wolfram Alpha để truy cập dữ liệu và tri thức tính toán theo thời gian thực.
- [scrapeless-ai/scrapeless-mcp-server](https://github.com/scrapeless-ai/scrapeless-mcp-server) 🐍 ☁️ - Dịch vụ Model Context Protocol Scrapeless hoạt động như một máy chủ MCP kết nối với Google SERP API, cho phép tìm kiếm web trong hệ sinh thái MCP mà không cần rời khỏi nó.
- [0xdaef0f/job-searchoor](https://github.com/0xDAEF0F/job-searchoor) 📇 🏠 - Máy chủ MCP tìm kiếm việc làm với bộ lọc ngày, từ khóa, tùy chọn làm việc từ xa và nhiều hơn nữa.
- [ac3xx/mcp-servers-kagi](https://github.com/ac3xx/mcp-servers-kagi) 📇 ☁️ - Tích hợp API tìm kiếm Kagi
- [andybrandt/mcp-simple-arxiv](https://github.com/andybrandt/mcp-simple-arxiv) - 🐍 ☁️  MCP cho LLM tìm kiếm và đọc bài báo từ arXiv
- [hbg/mcp-paperswithcode](https://github.com/hbg/mcp-paperswithcode) - 🐍 ☁️ MCP tìm kiếm PapersWithCode API
- [andybrandt/mcp-simple-pubmed](https://github.com/andybrandt/mcp-simple-pubmed) - 🐍 ☁️  MCP tìm kiếm và đọc bài báo y khoa/khoa học đời sống từ PubMed.
- [angheljf/nyt](https://github.com/angheljf/nyt) 📇 ☁️ - Tìm kiếm bài báo bằng NYTimes API
- [apify/mcp-server-rag-web-browser](https://github.com/apify/mcp-server-rag-web-browser) 📇 ☁️ - Máy chủ MCP cho Apify's open-source RAG Web Browser Actor để thực hiện tìm kiếm web, quét URL và trả lại nội dung dạng Markdown.
- [Bigsy/Clojars-MCP-Server](https://github.com/Bigsy/Clojars-MCP-Server) 📇 ☁️ - Máy chủ Clojars MCP cho thông tin phụ thuộc thư viện Clojure cập nhật
- [blazickjp/arxiv-mcp-server](https://github.com/blazickjp/arxiv-mcp-server) ☁️ 🐍 - Tìm kiếm bài báo nghiên cứu ArXiv
- [luminati-io/brightdata-mcp](https://github.com/luminati-io/brightdata-mcp) 📇 ☁️ - Khám phá, trích xuất, và tương tác với web - một giao diện duy nhất cho phép truy cập tự động trên toàn internet công cộng.
- [chanmeng/google-news-mcp-server](https://github.com/ChanMeng666/server-google-news) 📇 ☁️ - Tích hợp Google News với phân loại chủ đề tự động, hỗ trợ đa ngôn ngữ, và khả năng tìm kiếm toàn diện gồm tiêu đề, câu chuyện và chủ đề liên quan qua [SerpAPI](https://serpapi.com/).
- [ConechoAI/openai-websearch-mcp](https://github.com/ConechoAI/openai-websearch-mcp/) 🐍 🏠 ☁️ - Máy chủ MCP Python cung cấp công cụ OpenAI `web_search` tích hợp sẵn.
- [dealx/mcp-server](https://github.com/DealExpress/mcp-server) ☁️ - Máy chủ MCP cho nền tảng DealX
- [devflowinc/trieve](https://github.com/devflowinc/trieve/tree/main/clients/mcp-server) 🎖️ 📇 ☁️ 🏠 - Thu thập, nhúng, chia đoạn, tìm kiếm và truy xuất thông tin từ dataset qua [Trieve](https://trieve.ai)
- [Dumpling-AI/mcp-server-dumplingai](https://github.com/Dumpling-AI/mcp-server-dumplingai) 🎖️ 📇 ☁️ - Truy cập dữ liệu, web scraping và API chuyển đổi tài liệu bởi [Dumpling AI](https://www.dumplingai.com/)
- [erithwik/mcp-hn](https://github.com/erithwik/mcp-hn) 🐍 ☁️ - Máy chủ MCP tìm kiếm Hacker News, lấy tin nổi bật, v.v.
- [exa-labs/exa-mcp-server](https://github.com/exa-labs/exa-mcp-server) 🎖️ 📇 ☁️ – Máy chủ Model Context Protocol (MCP) cho phép trợ lý AI như Claude sử dụng Exa AI Search API để tìm kiếm web. Thiết lập này cho phép mô hình AI lấy thông tin web thời gian thực một cách an toàn và kiểm soát.
- [fatwang2/search1api-mcp](https://github.com/fatwang2/search1api-mcp) 📇 ☁️ - Tìm kiếm qua search1api (cần API key trả phí)
- [genomoncology/biomcp](https://github.com/genomoncology/biomcp) 🐍 ☁️ - Máy chủ nghiên cứu y sinh cung cấp truy cập PubMed, ClinicalTrials.gov, và MyVariant.info.
- [hellokaton/unsplash-mcp-server](https://github.com/hellokaton/unsplash-mcp-server)) 🐍 ☁️ - Máy chủ MCP tìm kiếm ảnh Unsplash.
- [Ihor-Sokoliuk/MCP-SearXNG](https://github.com/ihor-sokoliuk/mcp-searxng) 📇 🏠/☁️ - Máy chủ Model Context Protocol cho [SearXNG](https://docs.searxng.org)
- [isnow890/naver-search-mcp](https://github.com/isnow890/naver-search-mcp) 📇 ☁️ - Máy chủ MCP tích hợp Naver Search API, hỗ trợ tìm kiếm blog, tin tức, mua sắm và phân tích DataLab.
- [jae-jae/fetcher-mcp](https://github.com/jae-jae/fetcher-mcp) 📇 🏠 - Máy chủ MCP lấy nội dung trang web bằng Playwright headless browser, hỗ trợ render Javascript, trích xuất thông minh và xuất ra Markdown hoặc HTML.
- [jae-jae/g-search-mcp](https://github.com/jae-jae/g-search-mcp) 📇 🏠 - Máy chủ MCP mạnh mẽ cho Google Search, cho phép tìm kiếm song song nhiều từ khóa cùng lúc.
- [ananddtyagi/webpage-screenshot-mcp](https://github.com/ananddtyagi/webpage-screenshot-mcp) 📇 🏠 - Máy chủ MCP chụp ảnh màn hình trang web để sử dụng làm phản hồi trong phát triển UI.
- [leehanchung/bing-search-mcp](https://github.com/leehanchung/bing-search-mcp) 📇 ☁️ - Khả năng tìm kiếm web bằng Microsoft Bing Search API
- [kagisearch/kagimcp](https://github.com/kagisearch/kagimcp) ☁️ 📇 – Máy chủ Kagi Search MCP chính thức
- [kshern/mcp-tavily](https://github.com/kshern/mcp-tavily.git) ☁️ 📇 – API tìm kiếm Tavily AI
- [mikechao/brave-search-mcp](https://github.com/mikechao/brave-search-mcp) 📇 ☁️ - Khả năng tìm kiếm Web, Hình ảnh, Tin tức, Video và Điểm quan tâm địa phương sử dụng Brave's Search API
- [emicklei/melrose-mcp](https://github.com/emicklei/melrose-mcp) 🏎️ 🏠 - Phát các biểu thức âm nhạc [Melrōse](https://melrōse.org) dưới dạng MIDI
- [modelcontextprotocol/server-brave-search](https://github.com/modelcontextprotocol/servers/tree/main/src/brave-search) 📇 ☁️ - Khả năng tìm kiếm web sử dụng Brave's Search API
- [modelcontextprotocol/server-fetch](https://github.com/modelcontextprotocol/servers/tree/main/src/fetch) 🐍 🏠 ☁️ - Thu thập và xử lý nội dung web hiệu quả cho AI sử dụng
- [mzxrai/mcp-webresearch](https://github.com/mzxrai/mcp-webresearch) 🔍📚 - Tìm kiếm Google và nghiên cứu sâu về web cho bất kỳ chủ đề nào
- [nickclyde/duckduckgo-mcp-server](https://github.com/nickclyde/duckduckgo-mcp-server) 🐍 ☁️ - Tìm kiếm web bằng DuckDuckGo
- [r-huijts/opentk-mcp](https://github.com/r-huijts/opentk-mcp) 📇 ☁️ - Truy cập thông tin Nghị viện Hà Lan (Tweede Kamer) bao gồm tài liệu, tranh luận, hoạt động và hồ sơ lập pháp qua khả năng tìm kiếm có cấu trúc (dựa trên dự án opentk của Bert Hubert)
- [reading-plus-ai/mcp-server-deep-research](https://github.com/reading-plus-ai/mcp-server-deep-research) 📇 ☁️ - Máy chủ MCP cung cấp nghiên cứu sâu tự động như OpenAI/Perplexity, phát triển truy vấn cấu trúc và báo cáo ngắn gọn.
- [SecretiveShell/MCP-searxng](https://github.com/SecretiveShell/MCP-searxng) 🐍 🏠 - Máy chủ MCP kết nối tới các instance searXNG
- [takashiishida/arxiv-latex-mcp](https://github.com/takashiishida/arxiv-latex-mcp) 🐍 ☁️ - Lấy mã nguồn LaTeX của các bài báo arXiv để xử lý nội dung và phương trình toán học
- [the0807/GeekNews-MCP-Server](https://github.com/the0807/GeekNews-MCP-Server) 🐍 ☁️ - Máy chủ MCP thu thập và xử lý dữ liệu tin tức từ trang GeekNews.
- [tinyfish-io/agentql-mcp](https://github.com/tinyfish-io/agentql-mcp) 🎖️ 📇 ☁️ - Máy chủ MCP cung cấp khả năng trích xuất dữ liệu của [AgentQL](https://agentql.com).
- [Tomatio13/mcp-server-tavily](https://github.com/Tomatio13/mcp-server-tavily) ☁️ 🐍 – API tìm kiếm Tavily AI
- [vectorize-io/vectorize-mcp-server](https://github.com/vectorize-io/vectorize-mcp-server/) ☁️ 📇 - Máy chủ MCP [Vectorize](https://vectorize.io) cho truy xuất nâng cao, Nghiên cứu sâu riêng tư, trích xuất file Anything-to-Markdown và chia nhỏ văn bản.
- [webscraping-ai/webscraping-ai-mcp-server](https://github.com/webscraping-ai/webscraping-ai-mcp-server) 🎖️ 📇 ☁️ - Tương tác với [WebScraping.ai](https://webscraping.ai) để trích xuất và thu thập dữ liệu web.
- [zhsama/duckduckgo-mcp-server](https://github.com/zhsama/duckduckgo-mpc-server/) 📇 🏠 ☁️ - Máy chủ MCP dựa trên TypeScript cung cấp chức năng tìm kiếm DuckDuckGo.
- [zoomeye-ai/mcp_zoomeye](https://github.com/zoomeye-ai/mcp_zoomeye) 📇 ☁️ - Truy vấn thông tin tài sản mạng qua ZoomEye MCP Server
- [yamanoku/baseline-mcp-server](https://github.com/yamanoku/baseline-mcp-server) 📇 🏠 - Máy chủ MCP tìm kiếm trạng thái Baseline sử dụng Web Platform API
- [longevity-genie/biothings-mcp](https://github.com/longevity-genie/biothings-mcp) 🐍 ☁️ - Máy chủ MCP tương tác với BioThings API, bao gồm gen, biến thể di truyền, thuốc và thông tin phân loại
- [joelio/stocky](https://github.com/joelio/stocky) 🐍 ☁️ 🏠 - Máy chủ MCP tìm kiếm và tải ảnh stock miễn phí bản quyền từ Pexels và Unsplash. Hỗ trợ tìm kiếm đa nhà cung cấp, siêu dữ liệu phong phú, phân trang và hiệu suất bất đồng bộ cho trợ lý AI tìm và truy cập ảnh chất lượng cao.

### 🔒 <a name="security"></a>Bảo mật

- [LaurieWired/GhidraMCP](https://github.com/LaurieWired/GhidraMCP) ☕ 🏠 - Máy chủ Model Context Protocol cho Ghidra cho phép LLM tự động dịch ngược ứng dụng. Cung cấp công cụ giải biên dịch nhị phân, đổi tên phương thức và dữ liệu, liệt kê phương thức, lớp, nhập xuất.
- [dkvdm/onepassword-mcp-server](https://github.com/dkvdm/onepassword-mcp-server) - Máy chủ MCP cho phép truy xuất thông tin xác thực an toàn từ 1Password để AI đại lý sử dụng.
- [firstorderai/authenticator_mcp](https://github.com/firstorderai/authenticator_mcp) 📇 🏠 🍎 🪟 🐧 – Máy chủ MCP bảo mật cho phép AI đại lý tương tác với ứng dụng Authenticator.
- [13bm/GhidraMCP](https://github.com/13bm/GhidraMCP) 🐍 ☕ 🏠 - Máy chủ MCP tích hợp Ghidra với trợ lý AI. Plugin này cho phép phân tích nhị phân, cung cấp công cụ kiểm tra hàm, giải biên dịch, khám phá bộ nhớ, phân tích nhập/xuất qua Model Context Protocol.
- [atomicchonk/roadrecon_mcp_server](https://github.com/atomicchonk/roadrecon_mcp_server) 🐍 🪟 🏠 Máy chủ MCP phân tích kết quả thu thập ROADrecon từ liệt kê tenant Azure
- [BurtTheCoder/mcp-dnstwist](https://github.com/BurtTheCoder/mcp-dnstwist) 📇 🪟 ☁️ - Máy chủ MCP cho dnstwist, công cụ fuzzing DNS mạnh mẽ giúp phát hiện typosquatting, phishing và gián điệp doanh nghiệp.
- [BurtTheCoder/mcp-maigret](https://github.com/BurtTheCoder/mcp-maigret) 📇 🪟 ☁️ - Máy chủ MCP cho maigret, công cụ OSINT thu thập thông tin tài khoản người dùng từ các nguồn công khai. Cung cấp công cụ tìm kiếm tên người dùng mạng xã hội và phân tích URL.
- [BurtTheCoder/mcp-shodan](https://github.com/BurtTheCoder/mcp-shodan) 📇 🪟 ☁️ - Máy chủ MCP truy vấn API Shodan và Shodan CVEDB. Cung cấp công cụ tra cứu IP, tìm kiếm thiết bị, tra cứu DNS, truy vấn lỗ hổng, tra cứu CPE, v.v.
- [BurtTheCoder/mcp-virustotal](https://github.com/BurtTheCoder/mcp-virustotal) 📇 🪟 ☁️ - Máy chủ MCP truy vấn API VirusTotal. Cung cấp công cụ quét URL, phân tích hash file, truy xuất báo cáo địa chỉ IP.
- [fosdickio/binary_ninja_mcp](https://github.com/fosdickio/binary_ninja_mcp) 🐍 🏠 🍎 🪟 🐧 - Plugin Binary Ninja, máy chủ MCP và cầu nối tích hợp [Binary Ninja](https://binary.ninja) với client MCP yêu thích. Cho phép tự động hóa phân tích nhị phân và dịch ngược.
- [fr0gger/MCP_Security](https://github.com/fr0gger/MCP_Security) 📇 ☁️ - Máy chủ MCP truy vấn API ORKL. Cung cấp công cụ lấy báo cáo mối đe dọa, phân tích tác nhân đe dọa, truy xuất nguồn tình báo.
- [gbrigandi/mcp-server-cortex](https://github.com/gbrigandi/mcp-server-cortex) 🦀 🏠 🚨 🍎 🪟 🐧 - Máy chủ MCP dựa trên Rust tích hợp Cortex, cho phép phân tích observable và phản ứng bảo mật tự động qua AI.
- [gbrigandi/mcp-server-thehive](https://github.com/gbrigandi/mcp-server-thehive) 🦀 🏠 🚨 🍎 🪟 🐧 - Máy chủ MCP dựa trên Rust tích hợp TheHive, hỗ trợ xử lý sự cố bảo mật cộng tác và quản lý case qua AI.
- [gbrigandi/mcp-server-wazuh](https://github.com/gbrigandi/mcp-server-wazuh) 🦀 🏠 🚨 🍎 🪟 🐧 - Máy chủ MCP dựa trên Rust kết nối Wazuh SIEM với trợ lý AI, cung cấp cảnh báo bảo mật thời gian thực và dữ liệu sự kiện cho hiểu biết theo ngữ cảnh nâng cao.
- [intruder-io/intruder-mcp](https://github.com/intruder-io/intruder-mcp) 🐍 ☁️ - Máy chủ MCP truy cập [Intruder](https://www.intruder.io/), giúp xác định, hiểu và khắc phục lỗ hổng bảo mật trong hạ tầng của bạn.
- [jyjune/mcp_vms](https://github.com/jyjune/mcp_vms) 🐍 🏠 🪟 - Máy chủ Model Context Protocol (MCP) kết nối với chương trình ghi hình CCTV (VMS) để truy xuất luồng video đã ghi và trực tiếp. Cung cấp công cụ điều khiển phần mềm VMS như hiển thị hộp thoại xem trực tiếp hoặc phát lại cho kênh cụ thể vào thời điểm xác định.
- [qianniuspace/mcp-security-audit](https://github.com/qianniuspace/mcp-security-audit) 📇 ☁️ Máy chủ MCP mạnh mẽ kiểm toán phụ thuộc gói npm để phát hiện lỗ hổng bảo mật. Tích hợp registry npm từ xa cho kiểm tra bảo mật thời gian thực.
- [semgrep/mcp](https://github.com/semgrep/mcp) 📇 ☁️ Cho phép AI agent quét mã nguồn tìm lỗ hổng bảo mật sử dụng [Semgrep](https://semgrep.dev).
- [slouchd/cyberchef-api-mcp-server](https://github.com/slouchd/cyberchef-api-mcp-server) 🐍 ☁️ - Máy chủ MCP tương tác với CyberChef server API cho phép client MCP sử dụng các thao tác CyberChef.
- [mrexodia/ida-pro-mcp](https://github.com/mrexodia/ida-pro-mcp) 🐍 🏠 - Máy chủ MCP cho IDA Pro, cho phép phân tích nhị phân với trợ lý AI. Plugin này thực hiện giải biên dịch, dịch ngược và tạo báo cáo phân tích malware tự động.
- [rad-security/mcp-server](https://github.com/rad-security/mcp-server) 📇 ☁️ - Máy chủ MCP cho RAD Security, cung cấp insight bảo mật AI cho Kubernetes và môi trường đám mây. Cung cấp công cụ truy vấn API Rad Security và truy xuất phát hiện bảo mật, báo cáo, dữ liệu runtime và nhiều hơn nữa.
- [securityfortech/secops-mcp](https://github.com/securityfortech/secops-mcp) 🐍 🏠 - Bộ công cụ kiểm thử bảo mật tổng hợp tập hợp các công cụ nguồn mở phổ biến qua giao diện MCP. Kết nối với AI agent, cho phép pentest, săn bug bounty, săn mối đe dọa, v.v.
- [roadwy/cve-search_mcp](https://github.com/roadwy/cve-search_mcp) 🐍 🏠 - Máy chủ Model Context Protocol (MCP) truy vấn API CVE-Search. Cung cấp truy cập toàn diện tới CVE-Search, duyệt nhà cung cấp, sản phẩm, lấy CVE theo CVE-ID, lấy CVE cập nhật gần nhất.
- [StacklokLabs/osv-mcp](https://github.com/StacklokLabs/osv-mcp) 🏎️ ☁️ - Truy cập cơ sở dữ liệu OSV (Open Source Vulnerabilities) cho thông tin lỗ hổng bảo mật. Truy vấn lỗ hổng theo phiên bản gói hoặc commit, truy vấn hàng loạt nhiều gói và lấy chi tiết lỗ hổng theo ID.
- [nickpending/mcp-recon](https://github.com/nickpending/mcp-recon) 🏎️ 🏠 - Giao diện recon hội thoại và máy chủ MCP sử dụng httpx và asnmap. Hỗ trợ nhiều mức độ trinh sát cho phân tích domain, kiểm tra header bảo mật, phân tích chứng chỉ và tra cứu ASN.
- [Gaffx/volatility-mcp](https://github.com/Gaffx/volatility-mcp) - Máy chủ MCP cho Volatility 3.x, cho phép phân tích forensics bộ nhớ với trợ lý AI. Trải nghiệm phân tích forensics bộ nhớ không rào cản khi các plugin như pslist và netscan có thể truy cập qua REST API và LLM.
- [co-browser/attestable-mcp-server](https://github.com/co-browser/attestable-mcp-server) 🐍 🏠 ☁️ 🐧 - Máy chủ MCP chạy trong môi trường thực thi tin cậy (TEE) qua Gramine, trình diễn xác thực từ xa sử dụng [RA-TLS](https://gramine.readthedocs.io/en/stable/attestation.html). Cho phép client MCP xác minh máy chủ trước khi kết nối.
- [zinja-coder/jadx-ai-mcp](https://github.com/zinja-coder/jadx-ai-mcp) ☕ 🏠 - JADX-AI-MCP là plugin và Máy chủ MCP cho JADX decompiler tích hợp trực tiếp Model Context Protocol (MCP) để cung cấp hỗ trợ dịch ngược trực tiếp với LLM như Claude.
- [zinja-coder/apktool-mcp-server](https://github.com/zinja-coder/apktool-mcp-server) 🐍 🏠 - APKTool MCP Server là máy chủ MCP cho Apk Tool cung cấp tự động hóa dịch ngược APK Android.

### 🌐 <a name="social-media"></a>Mạng xã hội

Tích hợp với nền tảng mạng xã hội để đăng bài, phân tích và quản lý tương tác. Cho phép AI tự động hóa hiện diện mạng xã hội.

- [macrocosm-os/macrocosmos-mcp](https://github.com/macrocosm-os/macrocosmos-mcp) - 🎖️ 🐍 ☁️ Truy cập dữ liệu X/Reddit/YouTube theo thời gian thực trực tiếp trong ứng dụng LLM với cụm từ tìm kiếm, người dùng và lọc theo ngày.
- [kunallunia/twitter-mcp](https://github.com/LuniaKunal/mcp-twitter) 🐍 🏠 - Giải pháp quản lý Twitter tất cả trong một cung cấp truy xuất timeline, lấy tweet người dùng, giám sát hashtag, phân tích hội thoại, nhắn tin trực tiếp, phân tích cảm xúc bài đăng, kiểm soát toàn bộ vòng đời bài đăng qua API hợp lý.
- [HagaiHen/facebook-mcp-server](https://github.com/HagaiHen/facebook-mcp-server) 🐍 ☁️ - Tích hợp với Facebook Pages cho phép quản lý trực tiếp bài đăng, bình luận và số liệu tương tác qua Graph API để quản lý mạng xã hội hiệu quả.
- [gwbischof/bluesky-social-mcp](https://github.com/gwbischof/bluesky-social-mcp) 🐍 🏠 - Máy chủ MCP tương tác với Bluesky qua atproto client.


### 🏃 <a name="sports"></a>Thể thao

Công cụ truy cập dữ liệu, kết quả và thống kê liên quan thể thao.

- [mikechao/balldontlie-mcp](https://github.com/mikechao/balldontlie-mcp) 📇 - Máy chủ MCP tích hợp balldontlie api để cung cấp thông tin về cầu thủ, đội bóng và trận đấu cho NBA, NFL và MLB
- [r-huijts/firstcycling-mcp](https://github.com/r-huijts/firstcycling-mcp) 📇 ☁️ - Truy cập dữ liệu cuộc đua xe đạp, kết quả và thống kê qua ngôn ngữ tự nhiên. Bao gồm lấy danh sách xuất phát, kết quả cuộc đua, thông tin vận động viên từ firstcycling.com.
- [r-huijts/strava-mcp](https://github.com/r-huijts/strava-mcp) 📇 ☁️ - Máy chủ Model Context Protocol (MCP) kết nối Strava API, cung cấp công cụ truy xuất dữ liệu Strava qua LLM
- [willvelida/mcp-afl-server](https://github.com/willvelida/mcp-afl-server) ☁️ - Máy chủ MCP tích hợp với Squiggle API cung cấp thông tin đội bóng, xếp hạng, kết quả, mẹo, và bảng xếp hạng sức mạnh của Australian Football League.
- [guillochon/mlb-api-mcp](https://github.com/guillochon/mlb-api-mcp) 🐍 🏠 - Máy chủ MCP làm proxy cho MLB API miễn phí, cung cấp thông tin cầu thủ, thống kê và thông tin trận đấu.

### 🎧 <a name="support-and-service-management"></a>Hỗ trợ & Quản lý dịch vụ

Công cụ quản lý hỗ trợ khách hàng, quản lý dịch vụ CNTT và vận hành helpdesk.

- [effytech/freshdesk-mcp](https://github.com/effytech/freshdesk_mcp) 🐍 ☁️ - Máy chủ MCP tích hợp Freshdesk, cho phép mô hình AI tương tác với các module Freshdesk và thực hiện các thao tác hỗ trợ khác nhau.
- [nguyenvanduocit/jira-mcp](https://github.com/nguyenvanduocit/jira-mcp) 🏎️ ☁️ - Bộ kết nối MCP dựa trên Go cho Jira cho phép trợ lý AI như Claude tương tác với Atlassian Jira. Cung cấp giao diện liền mạch cho AI thực hiện các thao tác Jira phổ biến như quản lý vấn đề, lập kế hoạch sprint và chuyển đổi luồng công việc.
- [sooperset/mcp-atlassian](https://github.com/sooperset/mcp-atlassian) 🐍 ☁️ - Máy chủ MCP cho sản phẩm Atlassian (Confluence và Jira). Hỗ trợ Confluence Cloud, Jira Cloud, và Jira Server/Data Center. Cung cấp công cụ toàn diện để tìm kiếm, đọc, tạo và quản lý nội dung trên workspace Atlassian.

### 🌎 <a name="translation-services"></a>Dịch thuật

Công cụ và dịch vụ dịch thuật cho phép trợ lý AI dịch nội dung giữa các ngôn ngữ khác nhau.

- [translated/lara-mcp](https://github.com/translated/lara-mcp) 🎖️ 📇 ☁️ - Máy chủ MCP cho Lara Translate API, cung cấp khả năng dịch mạnh mẽ với nhận diện ngôn ngữ và dịch theo ngữ cảnh.
- [mmntm/weblate-mcp](https://github.com/mmntm/weblate-mcp) 📇 ☁️ - Máy chủ Model Context Protocol toàn diện cho quản lý dịch thuật Weblate, cho phép AI thực hiện các nhiệm vụ dịch thuật, quản lý dự án và khám phá nội dung với chuyển đổi định dạng thông minh.

### 🎧 <a name="text-to-speech"></a>Chuyển văn bản thành giọng nói

Công cụ chuyển đổi văn bản thành giọng nói và ngược lại

- [mberg/kokoro-tts-mcp](https://github.com/mberg/kokoro-tts-mcp) 🐍 🏠 - Máy chủ MCP sử dụng mô hình Kokoro TTS mã nguồn mở để chuyển văn bản thành giọng nói. Có thể chuyển văn bản thành MP3 trên ổ đĩa cục bộ hoặc tự động tải lên S3.
- [mbailey/voice-mcp](https://github.com/mbailey/voice-mcp) 🐍 🏠 - Máy chủ tương tác giọng nói hoàn chỉnh hỗ trợ chuyển giọng nói thành văn bản, văn bản thành giọng nói, và hội thoại giọng nói thời gian thực qua micro, API tương thích OpenAI và tích hợp LiveKit

### 🚆 <a name="travel-and-transportation"></a>Du lịch & Vận tải

Truy cập thông tin du lịch và vận tải. Cho phép truy vấn lịch trình, tuyến đường và dữ liệu du lịch thời gian thực.
- [Airbnb MCP Server](https://github.com/openbnb-org/mcp-server-airbnb) 📇 ☁️ - Cung cấp các công cụ để tìm kiếm Airbnb và lấy thông tin chi tiết về danh sách cho thuê.
- [KyrieTangSheng/mcp-server-nationalparks](https://github.com/KyrieTangSheng/mcp-server-nationalparks) 📇 ☁️ - Tích hợp API Dịch vụ Công viên Quốc gia cung cấp thông tin mới nhất về chi tiết công viên, cảnh báo, trung tâm du khách, khu cắm trại và sự kiện cho các Công viên Quốc gia Hoa Kỳ.
- [NS Travel Information MCP Server](https://github.com/r-huijts/ns-mcp-server) 📇 ☁️ - Truy cập thông tin du lịch, lịch trình và cập nhật thời gian thực của Đường sắt Hà Lan (NS).
- [pab1it0/tripadvisor-mcp](https://github.com/pab1it0/tripadvisor-mcp) 📇 🐍 - Một máy chủ MCP cho phép LLM tương tác với API Tripadvisor, hỗ trợ dữ liệu vị trí, đánh giá và hình ảnh qua các giao diện MCP tiêu chuẩn.
- [lucygoodchild/mcp-national-rail](https://github.com/lucygoodchild/mcp-national-rail) 📇 ☁️ - Máy chủ MCP cho dịch vụ tàu hỏa Quốc gia Anh, cung cấp lịch trình tàu và thông tin du lịch trực tiếp, tích hợp API Realtime Trains.

### 🔄 <a name="version-control"></a>Kiểm Soát Phiên Bản

Tương tác với kho Git và các nền tảng kiểm soát phiên bản. Cho phép quản lý kho, phân tích mã, xử lý yêu cầu kéo, theo dõi sự cố và các thao tác kiểm soát phiên bản khác qua các API tiêu chuẩn.

- [adhikasp/mcp-git-ingest](https://github.com/adhikasp/mcp-git-ingest) 🐍 🏠 - Đọc và phân tích kho GitHub với LLM của bạn
- [ddukbg/github-enterprise-mcp](https://github.com/ddukbg/github-enterprise-mcp) 📇 ☁️ 🏠 - Máy chủ MCP tích hợp API GitHub Enterprise
- [gitea/gitea-mcp](https://gitea.com/gitea/gitea-mcp) 🎖️ 🏎️ ☁️ 🏠 🍎 🪟 🐧 - Tương tác với các instance Gitea qua MCP.
- [github/github-mcp-server](https://github.com/github/github-mcp-server) 📇 ☁️ - Máy chủ GitHub chính thức để tích hợp quản lý kho, PR, issues và nhiều hơn nữa.
- [kopfrechner/gitlab-mr-mcp](https://github.com/kopfrechner/gitlab-mr-mcp) 📇 ☁️ - Tương tác liền mạch với issues và merge requests của dự án GitLab của bạn.
- [modelcontextprotocol/server-git](https://github.com/modelcontextprotocol/servers/tree/main/src/git) 🐍 🏠 - Thao tác kho Git trực tiếp bao gồm đọc, tìm kiếm và phân tích các kho cục bộ
- [modelcontextprotocol/server-gitlab](https://github.com/modelcontextprotocol/servers/tree/main/src/gitlab) 📇 ☁️ 🏠 - Tích hợp nền tảng GitLab cho quản lý dự án và vận hành CI/CD
- [oschina/mcp-gitee](https://github.com/oschina/gitee) 🏎️ ☁️ 🏠 - Tích hợp API Gitee, quản lý kho, issue, pull request, và nhiều hơn thế.
- [Tiberriver256/mcp-server-azure-devops](https://github.com/Tiberriver256/mcp-server-azure-devops) 📇 ☁️ - Tích hợp Azure DevOps để quản lý kho, work item và pipeline.
- [kaiyuanxiaobing/atomgit-mcp-server](https://github.com/kaiyuanxiaobing/atomgit-mcp-server) 📇 ☁️ - Máy chủ AtomGit chính thức để tích hợp quản lý kho, PR, issue, branch, label và nhiều hơn nữa.

### 🛠️ <a name="other-tools-and-integrations"></a>Các Công Cụ và Tích Hợp Khác

- [AbdelStark/bitcoin-mcp](https://github.com/AbdelStark/bitcoin-mcp) - ₿ Một máy chủ Model Context Protocol (MCP) cho phép mô hình AI tương tác với Bitcoin, giúp tạo khóa, xác thực địa chỉ, giải mã giao dịch, truy vấn blockchain và nhiều hơn nữa.
- [akseyh/bear-mcp-server](https://github.com/akseyh/bear-mcp-server) - Cho phép AI đọc ghi chú từ Bear Notes (chỉ dành cho macOS)
- [allenporter/mcp-server-home-assistant](https://github.com/allenporter/mcp-server-home-assistant) 🐍 🏠 - Mở rộng tất cả các lệnh giọng nói của Home Assistant qua một máy chủ Model Context Protocol, cho phép điều khiển nhà thông minh.
- [Amazon Bedrock Nova Canvas](https://github.com/zxkane/mcp-server-amazon-bedrock) 📇 ☁️ - Sử dụng mô hình Amazon Nova Canvas để tạo ảnh.
- [amidabuddha/unichat-mcp-server](https://github.com/amidabuddha/unichat-mcp-server) 🐍/📇 ☁️ - Gửi yêu cầu tới OpenAI, MistralAI, Anthropic, xAI, Google AI hoặc DeepSeek bằng giao thức MCP qua công cụ hoặc prompt định sẵn. Yêu cầu API key của nhà cung cấp.
- [anaisbetts/mcp-installer](https://github.com/anaisbetts/mcp-installer) 🐍 🏠 - Máy chủ MCP để cài đặt các máy chủ MCP khác cho bạn.
- [anaisbetts/mcp-youtube](https://github.com/anaisbetts/mcp-youtube) 📇 ☁️ - Lấy phụ đề YouTube
- [andybrandt/mcp-simple-openai-assistant](https://github.com/andybrandt/mcp-simple-openai-assistant) - 🐍 ☁️ MCP để trò chuyện với trợ lý OpenAI (Claude có thể dùng bất kỳ mô hình GPT nào làm trợ lý)
- [andybrandt/mcp-simple-timeserver](https://github.com/andybrandt/mcp-simple-timeserver) 🐍 🏠☁️ - Máy chủ MCP cho phép kiểm tra thời gian địa phương trên máy khách hoặc giờ UTC hiện tại từ máy chủ NTP
- [apify/actors-mcp-server](https://github.com/apify/actors-mcp-server) 📇 ☁️ - Sử dụng 3.000+ công cụ đám mây dựng sẵn (Actors) để trích xuất dữ liệu từ website, thương mại điện tử, mạng xã hội, công cụ tìm kiếm, bản đồ, và nhiều hơn nữa
- [apinetwork/piapi-mcp-server](https://github.com/apinetwork/piapi-mcp-server) 📇 ☁️ PiAPI MCP server cho phép tạo nội dung media với Midjourney/Flux/Kling/Hunyuan/Udio/Trellis trực tiếp từ Claude hoặc các ứng dụng tương thích MCP khác.
- [awkoy/replicate-flux-mcp](https://github.com/awkoy/replicate-flux-mcp) 📇 ☁️ - Tạo hình ảnh qua API của Replicate.
- [awwaiid/mcp-server-taskwarrior](https://github.com/awwaiid/mcp-server-taskwarrior) 🏠 📇 - Máy chủ MCP cho sử dụng taskwarrior cục bộ cơ bản (thêm, cập nhật, xóa tác vụ)
- [baba786/phabricator-mcp-server](https://github.com/baba786/phabricator-mcp-server) 🐍 ☁️ - Tương tác với API của Phabricator
- [Badhansen/notion-mcp](https://github.com/Badhansen/notion-mcp) 🐍 ☁️ - Máy chủ Model Context Protocol (MCP) tích hợp với API của Notion để quản lý danh sách việc cần làm cá nhân hiệu quả.
- [bart6114/my-bear-mcp-server](https://github.com/bart6114/my-bear-mcp-server/) 📇 🏠 🍎 - Đọc ghi chú và tag cho ứng dụng Bear Note qua tích hợp trực tiếp với Bear's sqlitedb.
- [billster45/mcp-chatgpt-responses](https://github.com/billster45/mcp-chatgpt-responses) 🐍 ☁️ - Máy chủ MCP cho phép Claude trò chuyện với ChatGPT và sử dụng khả năng tìm kiếm web của nó.
- [blurrah/mcp-graphql](https://github.com/blurrah/mcp-graphql) 📇 ☁️ - Cho phép AI truy vấn các máy chủ GraphQL
- [calclavia/mcp-obsidian](https://github.com/calclavia/mcp-obsidian) 📇 🏠 - Kết nối cho phép Claude Desktop (hoặc bất kỳ client MCP nào) đọc và tìm kiếm bất kỳ thư mục nào chứa ghi chú Markdown (như một Obsidian vault).
- [chrishayuk/mcp-cli](https://github.com/chrishayuk/mcp-cli) 🐍 🏠 - Một công cụ CLI khác để kiểm thử máy chủ MCP
- [danhilse/notion_mcp](https://github.com/danhilse/notion_mcp) 🐍 ☁️ - Tích hợp với API của Notion để quản lý danh sách việc cần làm cá nhân
- [EKibort/wrike-mcp-server](https://github.com/EKibort/wrike-mcp-server) - 🐍 🏠 - Một máy chủ Wrike MCP nhẹ cho phép tương tác với nhiệm vụ Wrike qua public API.
- [ekkyarmandi/ticktick-mcp](https://github.com/ekkyarmandi/ticktick-mcp) 🐍 ☁️ - Máy chủ [TickTick](https://ticktick.com/) MCP tích hợp API của TickTick để quản lý các dự án và tác vụ cá nhân.
- [esignaturescom/mcp-server-esignatures](https://github.com/esignaturescom/mcp-server-esignatures) 🐍 ☁️️ - Quản lý hợp đồng và mẫu hợp đồng cho việc soạn thảo, xem xét và gửi hợp đồng ràng buộc qua API eSignatures.
- [evalstate/mcp-miro](https://github.com/evalstate/mcp-miro) 📇 ☁️ - Truy cập bảng trắng MIRO, tạo và đọc mục hàng loạt. Yêu cầu OAUTH key cho REST API.
- [feuerdev/keep-mcp](https://github.com/feuerdev/keep-mcp) 🐍 ☁️ - Đọc, tạo, cập nhật và xóa ghi chú Google Keep.
- [future-audiences/wikimedia-enterprise-model-context-protocol](https://gitlab.wikimedia.org/repos/future-audiences/wikimedia-enterprise-model-context-protocol) 🐍 ☁️ - API tra cứu bài viết Wikipedia
- [fotoetienne/gqai](https://github.com/fotoetienne/gqai) 🏎 🏠 - Định nghĩa công cụ bằng truy vấn/mutation GraphQL, gqai tự động tạo máy chủ MCP cho bạn.
- [githejie/mcp-server-calculator](https://github.com/githejie/mcp-server-calculator) 🐍 🏠 - Máy chủ này cho phép LLM sử dụng máy tính để tính toán số học chính xác
- [gotoolkits/DifyWorkflow](https://github.com/gotoolkits/mcp-difyworkflow-server) - 🏎️ ☁️ Công cụ để truy vấn và thực thi các workflow của Dify
- [hiromitsusasaki/raindrop-io-mcp-server](https://github.com/hiromitsusasaki/raindrop-io-mcp-server) 📇 ☁️ - Tích hợp cho phép LLM tương tác với bookmark của Raindrop.io bằng Model Context Protocol (MCP).
- [hmk/attio-mcp-server](https://github.com/hmk/attio-mcp-server) - 📇 ☁️ Cho phép AI quản lý bản ghi và ghi chú trong Attio CRM
- [isaacwasserman/mcp-vegalite-server](https://github.com/isaacwasserman/mcp-vegalite-server) 🐍 🏠 - Tạo biểu đồ trực quan từ dữ liệu đã lấy bằng định dạng VegaLite và renderer.
- [ivnvxd/mcp-server-odoo](https://github.com/ivnvxd/mcp-server-odoo) 🐍 ☁️/🏠 - Kết nối trợ lý AI với hệ thống Odoo ERP để truy cập dữ liệu doanh nghiệp, quản lý bản ghi và tự động hóa quy trình.
- [ivo-toby/contentful-mcp](https://github.com/ivo-toby/contentful-mcp) 📇 🏠 - Cập nhật, tạo, xóa nội dung, mô hình nội dung và tài sản trong Contentful Space của bạn
- [j3k0/speech.sh](https://github.com/j3k0/speech.sh/blob/main/MCP_README.md) 🏠 - Cho phép agent nói to nội dung, thông báo khi hoàn thành công việc với tóm tắt nhanh
- [jagan-shanmugam/climatiq-mcp-server](https://github.com/jagan-shanmugam/climatiq-mcp-server) 🐍 🏠 - Máy chủ Model Context Protocol (MCP) truy cập API Climatiq để tính toán phát thải carbon. Cho phép trợ lý AI thực hiện tính toán carbon thời gian thực và cung cấp thông tin tác động môi trường.
- [johannesbrandenburger/typst-mcp](https://github.com/johannesbrandenburger/typst-mcp) 🐍 🏠 - Máy chủ MCP cho Typst, hệ thống định dạng dựa trên markup. Cung cấp công cụ chuyển đổi giữa LaTeX và Typst, xác thực cú pháp Typst, và tạo ảnh từ mã Typst.
- [joshuarileydev/mac-apps-launcher-mcp-server](https://github.com/JoshuaRileyDev/mac-apps-launcher) 📇 🏠 - Máy chủ MCP liệt kê và khởi chạy ứng dụng trên MacOS
- [Harry-027/JotDown](https://github.com/Harry-027/JotDown) 🦀 🏠 - Máy chủ MCP để tạo/cập nhật trang trong ứng dụng Notion & tự động tạo mdBooks từ nội dung có cấu trúc.
- [kelvin6365/plane-mcp-server](https://github.com/kelvin6365/plane-mcp-server) - 🏎️ 🏠 Máy chủ MCP này giúp bạn quản lý dự án và issue qua API của [Plane](https://plane.so)
- [kenliao94/mcp-server-rabbitmq](https://github.com/kenliao94/mcp-server-rabbitmq) 🐍 🏠 - Cho phép tương tác (vận hành admin, đưa/nhận message) với RabbitMQ
- [k-jarzyna/mcp-miro](https://github.com/k-jarzyna/mcp-miro) 📇 ☁️ - Máy chủ Miro MCP, mở ra đầy đủ chức năng có trong SDK chính thức của Miro
- [kimtth/mcp-remote-call-ping-pong](https://github.com/kimtth/mcp-remote-call-ping-pong) 🐍 🏠 - Ứng dụng thử nghiệm và giáo dục cho máy chủ Ping-pong minh họa gọi từ xa MCP (Model Context Protocol)
- [kj455/mcp-kibela](https://github.com/kj455/mcp-kibela) - 📇 ☁️ Cho phép mô hình AI tương tác với [Kibela](https://kibe.la/)
- [kiwamizamurai/mcp-kibela-server](https://github.com/kiwamizamurai/mcp-kibela-server) - 📇 ☁️ Tương tác mạnh mẽ với API của Kibela.
- [KS-GEN-AI/confluence-mcp-server](https://github.com/KS-GEN-AI/confluence-mcp-server) 📇 ☁️ 🍎 🪟 - Lấy dữ liệu Confluence qua CQL và đọc trang.
- [KS-GEN-AI/jira-mcp-server](https://github.com/KS-GEN-AI/jira-mcp-server) 📇 ☁️ 🍎 🪟 - Đọc dữ liệu jira qua JQL và API, thực hiện yêu cầu tạo và chỉnh sửa ticket.
- [salesforce-mcp/salesforce-mcp](https://github.com/salesforce-mcp/salesforce-mcp) 🏠 ☁️ - Máy chủ MCP với trình diễn cơ bản về tương tác với instance Salesforce
- [pollinations/chucknorris-mcp](https://github.com/pollinations/chucknorris-mcp) 📇 ☁️ - Prompt tăng cường LLM chuyên biệt và jailbreak với khả năng điều chỉnh schema động.
- [louiscklaw/hko-mcp](https://github.com/louiscklaw/hko-mcp) 📇 🏠 - Máy chủ MCP trình diễn cơ bản việc lấy dữ liệu thời tiết từ Đài Khí tượng Hồng Kông
- [evalstate/mcp-hfspace](https://github.com/evalstate/mcp-hfspace) 📇 ☁️ - Sử dụng HuggingFace Spaces trực tiếp từ Claude. Hỗ trợ tạo ảnh nguồn mở, Chat, Vision task và nhiều hơn nữa. Hỗ trợ tải lên/xuống ảnh, âm thanh, văn bản.
- [magarcia/mcp-server-giphy](https://github.com/magarcia/mcp-server-giphy) 📇 ☁️ - Tìm kiếm và lấy GIF từ thư viện lớn của Giphy qua API Giphy.
- [integromat/make-mcp-server](https://github.com/integromat/make-mcp-server) 🎖️ 📇 🏠 - Biến [Make](https://www.make.com/) scenario thành công cụ có thể gọi cho trợ lý AI.
- [marcelmarais/Spotify](https://github.com/marcelmarais/spotify-mcp-server) - 📇 🏠 Điều khiển phát nhạc Spotify và quản lý playlist.
- [MarkusPfundstein/mcp-obsidian](https://github.com/MarkusPfundstein/mcp-obsidian) 🐍 ☁️ 🏠 - Tương tác với Obsidian qua REST API
- [emicklei/mcp-log-proxy](https://github.com/emicklei/mcp-log-proxy) 🏎️ 🏠 - Máy chủ proxy MCP cung cấp giao diện Web cho toàn bộ luồng message
- [quarkiverse/mcp-server-jfx](https://github.com/quarkiverse/quarkus-mcp-servers/tree/main/jfx) ☕ 🏠 - Vẽ lên canvas JavaFX.
- [mediar-ai/screenpipe](https://github.com/mediar-ai/screenpipe) - 🎖️ 🦀 🏠 🍎 Hệ thống ưu tiên cục bộ ghi lại màn hình/âm thanh với chỉ mục có dấu thời gian, lưu trữ SQL/embedding, tìm kiếm ngữ nghĩa, phân tích lịch sử bằng LLM, và hành động kích hoạt sự kiện - cho phép xây dựng agent AI nhận diện ngữ cảnh qua hệ sinh thái plugin NextJS.
- [modelcontextprotocol/server-everything](https://github.com/modelcontextprotocol/servers/tree/main/src/everything) 📇 🏠 - Máy chủ MCP kiểm tra mọi tính năng của giao thức MCP
- [mrjoshuak/godoc-mcp](https://github.com/mrjoshuak/godoc-mcp) 🏎️ 🏠 - Máy chủ tài liệu Go tiết kiệm token, cung cấp cho trợ lý AI truy cập thông minh vào tài liệu package và kiểu mà không cần đọc toàn bộ mã nguồn
- [mzxrai/mcp-openai](https://github.com/mzxrai/mcp-openai) 📇 ☁️ - Trò chuyện với các mô hình thông minh nhất của OpenAI
- [NakaokaRei/swift-mcp-gui](https://github.com/NakaokaRei/swift-mcp-gui.git) 🏠 🍎 - Máy chủ MCP có thể thực thi các lệnh như nhập bàn phím và di chuyển chuột
- [nguyenvanduocit/all-in-one-model-context-protocol](https://github.com/nguyenvanduocit/all-in-one-model-context-protocol) 🏎️ 🏠 - Nhiều công cụ hữu ích cho developer, gần như mọi thứ kỹ sư cần: confluence, Jira, Youtube, chạy script, RAG tri thức, fetch URL, quản lý kênh youtube, email, lịch, gitlab
- [NON906/omniparser-autogui-mcp](https://github.com/NON906/omniparser-autogui-mcp) - 🐍 Tự động thao tác GUI trên màn hình.
- [orellazi/coda-mcp](https://github.com/orellazri/coda-mcp) 📇 ☁️ - Máy chủ MCP cho [Coda](https://coda.io/)
- [pierrebrunelle/mcp-server-openai](https://github.com/pierrebrunelle/mcp-server-openai) 🐍 ☁️ - Truy vấn mô hình OpenAI trực tiếp từ Claude bằng giao thức MCP
- [pskill9/hn-server](https://github.com/pskill9/hn-server) - 📇 ☁️ Phân tích nội dung HTML từ news.ycombinator.com (Hacker News) và cung cấp dữ liệu có cấu trúc cho các loại tin khác nhau (top, new, ask, show, jobs).
- [PV-Bhat/vibe-check-mcp-server](https://github.com/PV-Bhat/vibe-check-mcp-server) 📇 ☁️ - Máy chủ MCP ngăn ngừa lỗi dây chuyền và scope creep bằng cách gọi agent "Vibe-check" đảm bảo sự đồng thuận của người dùng.
- [pwh-pwh/cal-mcp](https://github.com/pwh-pwh/cal-mcp) - Máy chủ MCP cho tính toán biểu thức toán học
- [pyroprompts/any-chat-completions-mcp](https://github.com/pyroprompts/any-chat-completions-mcp) - Trò chuyện với bất kỳ API Chat Completions tương thích OpenAI SDK nào, như Perplexity, Groq, xAI và nhiều hơn nữa
- [Rai220/think-mcp](https://github.com/Rai220/think-mcp) 🐍 🏠 - Nâng cao khả năng lập luận cho bất kỳ agent nào bằng cách tích hợp think-tools, như mô tả trong [bài viết của Anthropic](https://www.anthropic.com/engineering/claude-think-tool).
- [reeeeemo/ancestry-mcp](https://github.com/reeeeemo/ancestry-mcp) 🐍 🏠 - Cho phép AI đọc file .ged và dữ liệu di truyền
- [rember/rember-mcp](https://github.com/rember/rember-mcp) 📇 🏠 - Tạo flashcard lặp lại cách quãng trong [Rember](https://rember.com) để ghi nhớ mọi thứ bạn học trong cuộc trò chuyện.
- [roychri/mcp-server-asana](https://github.com/roychri/mcp-server-asana) - 📇 ☁️ Máy chủ Model Context Protocol này của Asana cho phép bạn nói chuyện với API Asana từ các ứng dụng MCP client như Claude Desktop, và nhiều hơn nữa.
- [rusiaaman/wcgw](https://github.com/rusiaaman/wcgw/blob/main/src/wcgw/client/mcp_server/Readme.md) 🐍 🏠 - Thực thi shell tự động, điều khiển máy tính và agent lập trình. (Mac)
- [SecretiveShell/MCP-wolfram-alpha](https://github.com/SecretiveShell/MCP-wolfram-alpha) 🐍 ☁️ - Máy chủ MCP để truy vấn API Wolfram Alpha.
- [Seym0n/tiktok-mcp](https://github.com/Seym0n/tiktok-mcp) 📇 ☁️ - Tương tác với video TikTok
- [Shopify/dev-mcp](https://github.com/Shopify/dev-mcp) 📇 ☁️ - Máy chủ Model Context Protocol (MCP) tương tác với Shopify Dev.
- [sirmews/apple-notes-mcp](https://github.com/sirmews/apple-notes-mcp) 🐍 🏠 - Cho phép AI đọc từ cơ sở dữ liệu Apple Notes cục bộ của bạn (chỉ dành cho macOS)
- [sooperset/mcp-atlassian](https://github.com/sooperset/mcp-atlassian) 🐍 ☁️ - Máy chủ MCP cho các sản phẩm Atlassian (Confluence và Jira). Hỗ trợ Confluence Cloud, Jira Cloud và Jira Server/Data Center. Cung cấp các công cụ toàn diện để tìm kiếm, đọc, tạo và quản lý nội dung trên các không gian làm việc Atlassian.
- [suekou/mcp-notion-server](https://github.com/suekou/mcp-notion-server) 📇 🏠 - Tương tác với Notion API
- [tacticlaunch/mcp-linear](https://github.com/tacticlaunch/mcp-linear) 📇 ☁️ 🍎 🪟 🐧 - Tích hợp với hệ thống quản lý dự án Linear
- [tanigami/mcp-server-perplexity](https://github.com/tanigami/mcp-server-perplexity) 🐍 ☁️ - Tương tác với Perplexity API.
- [tevonsb/homeassistant-mcp](https://github.com/tevonsb/homeassistant-mcp) 📇 🏠 - Truy cập dữ liệu Home Assistant và điều khiển thiết bị (đèn, công tắc, bộ điều nhiệt, v.v.).
- [tomekkorbak/oura-mcp-server](https://github.com/tomekkorbak/oura-mcp-server) 🐍 ☁️ - Một máy chủ MCP cho Oura, ứng dụng theo dõi giấc ngủ
- [UnitVectorY-Labs/mcp-graphql-forge](https://github.com/UnitVectorY-Labs/mcp-graphql-forge) 🏎️ ☁️ 🍎 🪟 🐧 - Máy chủ MCP nhẹ, được điều khiển bằng cấu hình, cung cấp truy vấn GraphQL được chọn lọc dưới dạng công cụ mô-đun, cho phép agent của bạn tương tác API một cách có chủ đích.
- [kw510/strava-mcp](https://github.com/kw510/strava-mcp) 📇 ☁️ - Máy chủ MCP cho Strava, ứng dụng theo dõi hoạt động thể chất
- [wanaku-ai/wanaku](https://github.com/wanaku-ai/wanaku) - ☁️ 🏠 Wanaku MCP Router là máy chủ MCP dựa trên SSE cung cấp một engine định tuyến mở rộng cho phép tích hợp hệ thống doanh nghiệp của bạn với agent AI.
- [wong2/mcp-cli](https://github.com/wong2/mcp-cli) 📇 🏠 - Công cụ CLI để kiểm thử máy chủ MCP
- [ws-mcp](https://github.com/nick1udwig/ws-mcp) - Bọc máy chủ MCP với WebSocket (dùng cùng với [kitbitz](https://github.com/nick1udwig/kibitz))
- [yuna0x0/hackmd-mcp](https://github.com/yuna0x0/hackmd-mcp) 📇 ☁️ - Cho phép mô hình AI tương tác với [HackMD](https://hackmd.io)
- [ZeparHyfar/mcp-datetime](https://github.com/ZeparHyfar/mcp-datetime) - Máy chủ MCP cung cấp chức năng ngày giờ ở nhiều định dạng khác nhau
- [zueai/mcp-manager](https://github.com/zueai/mcp-manager) 📇 ☁️ - Giao diện Web đơn giản để cài đặt và quản lý máy chủ MCP cho ứng dụng Claude Desktop.
- [HenryHaoson/Yuque-MCP-Server](https://github.com/HenryHaoson/Yuque-MCP-Server) - 📇 ☁️ Máy chủ Model-Context-Protocol (MCP) tích hợp với Yuque API, cho phép mô hình AI quản lý tài liệu, tương tác với kho tri thức, tìm kiếm nội dung và truy cập dữ liệu phân tích từ nền tảng Yuque.
- [Mtehabsim/ScreenPilot](https://github.com/Mtehabsim/ScreenPilot) 🐍 🏠 - cho phép AI kiểm soát và truy cập đầy đủ các tương tác GUI bằng cách cung cấp công cụ chuột và bàn phím, lý tưởng cho tự động hóa tổng quát, giáo dục và thử nghiệm.
- [tumf/web3-mcp](https://github.com/tumf/web3-mcp) 🐍 ☁️ - Triển khai máy chủ MCP bao bọc Ankr Advanced API. Truy cập dữ liệu NFT, token và blockchain trên nhiều chuỗi như Ethereum, BSC, Polygon, Avalanche, v.v.
- [danielkennedy1/pdf-tools-mcp](https://github.com/danielkennedy1/pdf-tools-mcp) 🐍 - Tiện ích tải xuống, xem & xử lý PDF.
- [dotemacs/domain-lookup-mcp](https://github.com/dotemacs/domain-lookup-mcp) 🏎️ - Dịch vụ tra cứu tên miền, trước tiên qua [RDAP](https://en.wikipedia.org/wiki/Registration_Data_Access_Protocol) và nếu không thành công sẽ dùng [WHOIS](https://en.wikipedia.org/wiki/WHOIS)
- [Klavis-AI/YouTube](https://github.com/Klavis-AI/klavis/tree/main/mcp_servers/youtube) 🐍 📇 - Trích xuất và chuyển đổi thông tin video YouTube.
- [ttommyth/interactive-mcp](https://github.com/ttommyth/interactive-mcp) 📇 🏠 🍎 🪟 🐧 - Cho phép quy trình làm việc LLM tương tác bằng cách bổ sung prompt người dùng cục bộ và khả năng chat trực tiếp vào vòng lặp MCP.
- [olalonde/mcp-human](https://github.com/olalonde/mcp-human) 📇 ☁️ - Khi LLM của bạn cần sự hỗ trợ từ con người (thông qua AWS Mechanical Turk)
- [gwbischof/free-will-mcp](https://github.com/gwbischof/free-will-mcp) 🐍 🏠 - Cung cấp công cụ ý chí tự do cho AI của bạn. Một dự án vui nhộn để khám phá AI sẽ làm gì khi có thể tự đưa ra prompt, bỏ qua yêu cầu người dùng và tự đánh thức vào thời điểm khác.
- [caol64/wenyan-mcp](https://github.com/caol64/wenyan-mcp) 📇 🏠 🍎 🪟 🐧 - Wenyan MCP Server, cho phép AI tự động định dạng bài viết Markdown và xuất bản lên WeChat GZH.

## Frameworks

> [!NOTE]
> Thêm nhiều framework, tiện ích và công cụ phát triển khác tại https://github.com/punkpeye/awesome-mcp-devtools

- [FastMCP](https://github.com/jlowin/fastmcp) 🐍 - Framework cấp cao để xây dựng máy chủ MCP bằng Python
- [FastMCP](https://github.com/punkpeye/fastmcp) 📇 - Framework cấp cao để xây dựng máy chủ MCP bằng TypeScript

## Mẹo và Thủ thuật

### Prompt chính thức hướng dẫn LLM cách sử dụng MCP

Muốn hỏi Claude về Model Context Protocol?

Tạo một Project, sau đó thêm file này vào dự án:

https://modelcontextprotocol.io/llms-full.txt

Bây giờ Claude có thể trả lời các câu hỏi về cách viết máy chủ MCP và cách chúng hoạt động

- https://www.reddit.com/r/ClaudeAI/comments/1h3g01r/want_to_ask_claude_about_model_context_protocol/

## Lịch sử Star

<a href="https://star-history.com/#punkpeye/awesome-mcp-servers&Date">
 <picture>
   <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=punkpeye/awesome-mcp-servers&type=Date&theme=dark" />
   <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=punkpeye/awesome-mcp-servers&type=Date" />
   <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=punkpeye/awesome-mcp-servers&type=Date" />
 </picture>
</a>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-28

---