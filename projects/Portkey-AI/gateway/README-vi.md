<p align="right">
   <strong>Tiếng Anh</strong> | <a href="./.github/README.cn.md">中文</a> | <a href="./.github/README.jp.md">日本語</a>
</p>

<div align="center">

<a href="https://portkey.sh/report-github"><img src="https://raw.githubusercontent.com/siddharthsambharia-portkey/Portkey-Product-Images/refs/heads/main/LLM%20Report%20Campaign%20Frame.png"></img></a>
<br>

# Cổng AI Gateway
#### Kết nối tới hơn 250+ LLM chỉ với 1 API nhanh & thân thiện

<img src="https://cfassets.portkey.ai/sdk.gif" width="550px" alt="Portkey AI Gateway Demo showing LLM routing capabilities" style="margin-left:-35px">

[Docs](https://portkey.wiki/gh-1) | [Enterprise](https://portkey.wiki/gh-2) | [Hosted Gateway](https://portkey.wiki/gh-3) | [Changelog](https://portkey.wiki/gh-4) | [API Reference](https://portkey.wiki/gh-5)


[![License](https://img.shields.io/github/license/Ileriayo/markdown-badges)](./LICENSE)
[![Discord](https://img.shields.io/discord/1143393887742861333)](https://portkey.wiki/gh-6)
[![Twitter](https://img.shields.io/twitter/url/https/twitter/follow/portkeyai?style=social&label=Follow%20%40PortkeyAI)](https://portkey.wiki/gh-7)
[![npm version](https://badge.fury.io/js/%40portkey-ai%2Fgateway.svg)](https://portkey.wiki/gh-8)
[![Better Stack Badge](https://uptime.betterstack.com/status-badges/v1/monitor/q94g.svg)](https://portkey.wiki/gh-9)

<a href="https://us-east-1.console.aws.amazon.com/cloudformation/home?region=us-east-1#/stacks/quickcreate?stackName=portkey-gateway&templateURL=https://portkey-gateway-ec2-quicklaunch.s3.us-east-1.amazonaws.com/portkey-gateway-ec2-quicklaunch.template.yaml"><img src="https://img.shields.io/badge/Deploy_to_EC2-232F3E?style=for-the-badge&logo=amazonwebservices&logoColor=white" alt="Triển khai lên AWS EC2" width="105"/></a> [![Ask DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/Portkey-AI/gateway)
</div>

<br/>

[Cổng AI Gateway](https://portkey.wiki/gh-10) được thiết kế cho việc định tuyến nhanh, đáng tin cậy & an toàn tới hơn 1600+ mô hình ngôn ngữ, hình ảnh, âm thanh và ảnh. Đây là một giải pháp mã nguồn mở, nhẹ và sẵn sàng cho doanh nghiệp, cho phép bạn tích hợp với bất kỳ mô hình ngôn ngữ nào chỉ trong dưới 2 phút.

- [x] **Cực nhanh** (độ trễ <1ms) với dung lượng cực nhỏ (122kb)
- [x] **Đã được kiểm thử thực tế**, với hơn 10 tỷ tokens xử lý mỗi ngày
- [x] **Sẵn sàng cho doanh nghiệp** với bảo mật nâng cao, khả năng mở rộng và triển khai tùy chỉnh

<br>

#### Bạn có thể làm gì với AI Gateway?
- Tích hợp với bất kỳ LLM nào chỉ dưới 2 phút - [Khởi động nhanh](#quickstart-2-mins)
- Ngăn ngừa downtime với **[tự động thử lại](https://portkey.wiki/gh-11)** và **[fallbacks](https://portkey.wiki/gh-12)**
- Mở rộng ứng dụng AI với **[cân bằng tải](https://portkey.wiki/gh-13)** và **[định tuyến điều kiện](https://portkey.wiki/gh-14)**
- Bảo vệ triển khai AI của bạn với **[guardrails](https://portkey.wiki/gh-15)**
- Không chỉ văn bản mà còn hỗ trợ **[đa phương thức](https://portkey.wiki/gh-16)**
- Khám phá tích hợp **[agentic workflow](https://portkey.wiki/gh-17)**

<br><br>

> [!TIP]
> Gắn sao cho repo này sẽ giúp nhiều lập trình viên biết đến AI Gateway hơn 🙏🏻
>
> ![star-2](https://github.com/user-attachments/assets/53597dce-6333-4ecc-a154-eb05532954e4)
> 
<br>


<br>

## Khởi động nhanh (2 phút)

### 1. Thiết lập AI Gateway của bạn

```bash
# Chạy gateway trên máy (yêu cầu Node.js và npm)
npx @portkey-ai/gateway
```
> Gateway chạy tại `http://localhost:8787/v1`
> 
> Gateway Console chạy tại `http://localhost:8787/public/`

<sup>
Hướng dẫn triển khai:
&nbsp; <a href="https://portkey.wiki/gh-18"><img height="12" width="12" src="https://cfassets.portkey.ai/logo/dew-color.svg" /> Portkey Cloud (Khuyến nghị)</a>
&nbsp; <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/docs/installation-deployments.md#docker"><img height="12" width="12" src="https://cdn.simpleicons.org/docker/3776AB" /> Docker</a>
&nbsp; <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/docs/installation-deployments.md#nodejs-server"><img height="12" width="12" src="https://cdn.simpleicons.org/node.js/3776AB" /> Node.js</a>
&nbsp; <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/docs/installation-deployments.md#cloudflare-workers"><img height="12" width="12" src="https://cdn.simpleicons.org/cloudflare/3776AB" /> Cloudflare</a>
&nbsp; <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/docs/installation-deployments.md#replit"><img height="12" width="12" src="https://cdn.simpleicons.org/replit/3776AB" /> Replit</a>
&nbsp; <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/docs/installation-deployments.md"> Khác...</a>

</sup>

### 2. Gửi yêu cầu đầu tiên của bạn

<!-- <details open>
<summary>Python Example</summary> -->
```python
# pip install -qU portkey-ai

from portkey_ai import Portkey

# Client tương thích OpenAI
client = Portkey(
    provider="openai", # hoặc 'anthropic', 'bedrock', 'groq', v.v.
    Authorization="sk-***" # API key của nhà cung cấp
)

# Gửi yêu cầu qua AI Gateway của bạn
client.chat.completions.create(
    messages=[{"role": "user", "content": "Thời tiết hôm nay thế nào?"}],
    model="gpt-4o-mini"
)
```



<sup>Thư viện hỗ trợ:
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/javascript/3776AB" /> JS](https://portkey.wiki/gh-19)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/python/3776AB" /> Python](https://portkey.wiki/gh-20)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/gnubash/3776AB" /> REST](https://portkey.sh/gh-84)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/openai/3776AB" /> OpenAI SDKs](https://portkey.wiki/gh-21)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/langchain/3776AB" /> Langchain](https://portkey.wiki/gh-22)
&nbsp; [LlamaIndex](https://portkey.wiki/gh-23)
&nbsp; [Autogen](https://portkey.wiki/gh-24)
&nbsp; [CrewAI](https://portkey.wiki/gh-25)
&nbsp; [Thêm..](https://portkey.wiki/gh-26)
</sup>

Trên Gateway Console (`http://localhost:8787/public/`) bạn có thể xem tất cả log local ở một nơi.

<img src="https://github.com/user-attachments/assets/362bc916-0fc9-43f1-a39e-4bd71aac4a3a" width="400" />


### 3. Routing & Guardrails
`Configs` trong gateway LLM cho phép bạn tạo quy tắc định tuyến, bổ sung độ tin cậy và thiết lập guardrails.
```python
config = {
  "retry": {"attempts": 5},

  "output_guardrails": [{
    "default.contains": {"operator": "none", "words": ["Apple"]},
    "deny": True
  }]
}

# Gắn config vào client
client = client.with_options(config=config)

client.chat.completions.create(
    model="gpt-4o-mini",
    messages=[{"role": "user", "content": "Trả lời ngẫu nhiên với Apple hoặc Bat"}]
)

# Lệnh này sẽ luôn trả lời với "Bat" vì guardrail từ chối mọi phản hồi chứa "Apple". Cấu hình retry sẽ thử lại 5 lần trước khi dừng.
```
<div align="center">
<img src="https://portkey.ai/blog/content/images/size/w1600/2024/11/image-15.png" width=600 title="Luồng request qua AI gateway của Portkey với retries và guardrails" alt="Luồng request qua AI gateway của Portkey với retries và guardrails"/>
</div>

Bạn có thể làm nhiều hơn nữa với configs trên AI gateway của mình. [Xem thêm ví dụ  →](https://portkey.wiki/gh-27)

<br/>

### Phiên bản doanh nghiệp (Triển khai riêng tư)

<sup>

[<img height="12" width="12" src="https://cfassets.portkey.ai/amazon-logo.svg" /> AWS](https://portkey.wiki/gh-28)
&nbsp; [<img height="12" width="12" src="https://cfassets.portkey.ai/azure-logo.svg" /> Azure](https://portkey.wiki/gh-29)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/googlecloud/3776AB" /> GCP](https://portkey.wiki/gh-30)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/redhatopenshift/3776AB" /> OpenShift](https://portkey.wiki/gh-31)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/kubernetes/3776AB" /> Kubernetes](https://portkey.wiki/gh-85)

</sup>

[Phiên bản doanh nghiệp](https://portkey.wiki/gh-86) của LLM Gateway cung cấp các tính năng nâng cao cho **quản lý tổ chức**, **quản trị**, **bảo mật** và [nhiều hơn nữa](https://portkey.wiki/gh-87) sẵn sàng sử dụng. [Xem so sánh tính năng →](https://portkey.wiki/gh-32)

Kiến trúc triển khai doanh nghiệp cho các nền tảng hỗ trợ có tại đây - [**Enterprise Private Cloud Deployments**](https://portkey.wiki/gh-33)

<a href="https://portkey.sh/demo-13"><img src="https://portkey.ai/blog/content/images/2024/08/Get-API-Key--5-.png" height=50 alt="Đặt lịch demo AI gateway doanh nghiệp" /></a><br/>


<br>

<hr>

### AI Engineering Hours

Tham gia cuộc gọi cộng đồng hàng tuần vào thứ Sáu (8 AM PT) để bắt đầu triển khai AI Gateway! [Diễn ra mỗi thứ Sáu](https://portkey.wiki/gh-35)

<a href="https://portkey.wiki/gh-35"><img width="500" src="https://github.com/user-attachments/assets/c2885699-f197-4289-b819-21eb839fbae1" /></a>

Biên bản cuộc họp [được đăng tại đây](https://portkey.wiki/gh-36).


<hr>

### LLMs in Prod'25

Những góc nhìn từ việc phân tích hơn 2 nghìn tỷ tokens, trên 90+ khu vực và 650+ nhóm trong môi trường sản xuất. Bạn sẽ nhận được gì từ báo cáo này:
- Xu hướng định hình việc ứng dụng AI và sự phát triển của các nhà cung cấp LLM.
- Chuẩn hiệu năng để tối ưu tốc độ, chi phí và độ tin cậy.
- Chiến lược để mở rộng hệ thống AI ở quy mô sản xuất.

<a href="https://portkey.sh/report-github"><img width="500" src="https://raw.githubusercontent.com/siddharthsambharia-portkey/Portkey-Product-Images/refs/heads/main/LLM%20Report%20Campaign%20Image.png" /></a>

<a href="https://portkey.sh/report-github">**Nhận báo cáo**</a>
<hr>


## Tính năng cốt lõi
### Định tuyến đáng tin cậy
- <a href="https://portkey.wiki/gh-37">**Phương án dự phòng (Fallbacks)**</a>: Tự động chuyển sang nhà cung cấp hoặc mô hình khác khi yêu cầu bị lỗi thông qua LLM gateway. Bạn có thể chỉ định các lỗi sẽ kích hoạt phương án dự phòng. Nâng cao độ tin cậy cho ứng dụng của bạn.
- <a href="https://portkey.wiki/gh-38">**Tự động thử lại (Automatic Retries)**</a>: Tự động thử lại các yêu cầu bị lỗi lên tới 5 lần. Chiến lược exponential backoff giúp giãn cách các lần thử lại để tránh quá tải mạng.
- <a href="https://portkey.wiki/gh-39">**Cân bằng tải (Load Balancing)**</a>: Phân phối các yêu cầu LLM qua nhiều khóa API hoặc nhà cung cấp AI với trọng số để đảm bảo tính sẵn sàng cao và hiệu suất tối ưu.
- <a href="https://portkey.wiki/gh-40">**Giới hạn thời gian yêu cầu (Request Timeouts)**</a>: Quản lý LLM & độ trễ bằng cách thiết lập giới hạn thời gian cụ thể cho từng yêu cầu, cho phép tự động dừng các yêu cầu vượt quá khoảng thời gian quy định.
- <a href="https://portkey.wiki/gh-41">**Cổng LLM đa phương tiện (Multi-modal LLM Gateway)**</a>: Gọi các mô hình thị giác, âm thanh (chuyển văn bản thành giọng nói & ngược lại), và tạo ảnh từ nhiều nhà cung cấp — tất cả đều sử dụng chữ ký OpenAI quen thuộc.
- <a href="https://portkey.wiki/gh-42">**Realtime APIs**</a>: Gọi các API realtime do OpenAI phát hành thông qua server websocket tích hợp.

### Bảo mật & Độ chính xác
- <a href="https://portkey.wiki/gh-88">**Guardrails**</a>: Xác minh đầu vào và đầu ra của LLM để tuân thủ các kiểm tra bạn đã chỉ định. Chọn từ hơn 40 guardrail dựng sẵn để đảm bảo tuân thủ các tiêu chuẩn bảo mật và chính xác. Bạn có thể <a href="https://portkey.wiki/gh-43">tự mang guardrail</a> hoặc chọn từ <a href="https://portkey.wiki/gh-44">nhiều đối tác của chúng tôi</a>.
- [**Quản lý khóa an toàn**](https://portkey.wiki/gh-45): Dùng khóa của bạn hoặc tạo khóa ảo tức thời.
- [**Kiểm soát truy cập dựa trên vai trò**](https://portkey.wiki/gh-46): Kiểm soát truy cập chi tiết cho người dùng, workspace và khóa API.
- <a href="https://portkey.wiki/gh-47">**Tuân thủ & Bảo mật dữ liệu**</a>: AI gateway tuân thủ SOC2, HIPAA, GDPR và CCPA.

### Quản lý chi phí
- [**Bộ nhớ đệm thông minh (Smart caching)**](https://portkey.wiki/gh-48): Lưu đệm phản hồi từ LLM để giảm chi phí và cải thiện độ trễ. Hỗ trợ cache đơn giản và semantic*.
- [**Phân tích sử dụng (Usage analytics)**](https://portkey.wiki/gh-49): Giám sát và phân tích việc sử dụng AI và LLM, bao gồm số lượng yêu cầu, độ trễ, chi phí và tỷ lệ lỗi.
- [**Tối ưu hóa nhà cung cấp***](https://portkey.wiki/gh-89): Tự động chuyển sang nhà cung cấp tiết kiệm nhất dựa trên mô hình sử dụng và giá cả.

### Hợp tác & Quy trình làm việc
- <a href="https://portkey.ai/docs/integrations/agents">**Hỗ trợ Agents**</a>: Tích hợp liền mạch với các framework agent phổ biến để xây dựng ứng dụng AI phức tạp. Gateway tích hợp dễ dàng với [Autogen](https://portkey.wiki/gh-50), [CrewAI](https://portkey.wiki/gh-51), [LangChain](https://portkey.wiki/gh-52), [LlamaIndex](https://portkey.wiki/gh-53), [Phidata](https://portkey.wiki/gh-54), [Control Flow](https://portkey.wiki/gh-55), và cả [Custom Agents](https://portkey.wiki/gh-56).
- [**Quản lý mẫu Prompt***](https://portkey.wiki/gh-57): Tạo, quản lý và phiên bản hóa các mẫu prompt một cách cộng tác thông qua playground prompt chung.
<br/><br/>

<sup>
*&nbsp;Có sẵn trên phiên bản hosted và enterprise
</sup>

<br>

## Sổ tay hướng dẫn (Cookbooks)

### ☄️ Xu hướng
- Sử dụng các mô hình từ [Nvidia NIM](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/providers/nvidia.ipynb) với AI Gateway
- Giám sát [CrewAI Agents](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/monitoring-agents/CrewAI_with_Telemetry.ipynb) bằng Portkey!
- So sánh [Top 10 Mô hình LMSYS](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/use-cases/LMSYS%20Series/comparing-top10-LMSYS-models-with-Portkey.ipynb) với AI Gateway.

### 🚨 Mới nhất
* [Tạo tập dữ liệu tổng hợp bằng Nemotron](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/use-cases/Nemotron_GPT_Finetuning_Portkey.ipynb)
* [Sử dụng LLM Gateway với Vercel's AI SDK](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/integrations/vercel-ai.md)
* [Giám sát Llama Agents với LLM Gateway của Portkey](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/monitoring-agents/Llama_Agents_with_Telemetry.ipynb)

[Xem tất cả sổ tay hướng dẫn →](https://portkey.wiki/gh-58)
<br/><br/>

## Các nhà cung cấp được hỗ trợ

Khám phá các tích hợp Gateway với [45+ nhà cung cấp](https://portkey.wiki/gh-59) và [8+ framework agent](https://portkey.wiki/gh-90).

|                                                                                                                            | Nhà cung cấp                                                                                      | Hỗ trợ | Luồng |
| -------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | ------- | ------ |
| <img src="docs/images/openai.png" width=35 />                                                                              | [OpenAI](https://portkey.wiki/gh-60)                           | ✅       | ✅      |
| <img src="docs/images/azure.png" width=35>                                                                                 | [Azure OpenAI](https://portkey.wiki/gh-61)               | ✅       | ✅      |
| <img src="docs/images/anyscale.png" width=35>                                                                              | [Anyscale](https://portkey.wiki/gh-62) | ✅       | ✅      |
| <img src="https://upload.wikimedia.org/wikipedia/commons/2/2d/Google-favicon-2015.png" width=35>                           | [Google Gemini](https://portkey.wiki/gh-63)             | ✅       | ✅      |
| <img src="docs/images/anthropic.png" width=35>                                                                             | [Anthropic](https://portkey.wiki/gh-64)                     | ✅       | ✅      |
| <img src="docs/images/cohere.png" width=35>                                                                                | [Cohere](https://portkey.wiki/gh-65)                           | ✅       | ✅      |
| <img src="https://assets-global.website-files.com/64f6f2c0e3f4c5a91c1e823a/654693d569494912cfc0c0d4_favicon.svg" width=35> | [Together AI](https://portkey.wiki/gh-66)                 | ✅       | ✅      |
| <img src="https://www.perplexity.ai/favicon.svg" width=35>                                                                 | [Perplexity](https://portkey.wiki/gh-67)                | ✅       | ✅      |
| <img src="https://docs.mistral.ai/img/favicon.ico" width=35>                                                               | [Mistral](https://portkey.wiki/gh-68)                      | ✅       | ✅      |
| <img src="https://docs.nomic.ai/img/nomic-logo.png" width=35>                                                              | [Nomic](https://portkey.wiki/gh-69)                             | ✅       | ✅      |
| <img src="https://files.readme.io/d38a23e-small-studio-favicon.png" width=35>                                              | [AI21](https://portkey.wiki/gh-91)                                    | ✅       | ✅      |
| <img src="https://platform.stability.ai/small-logo-purple.svg" width=35>                                                   | [Stability AI](https://portkey.wiki/gh-71)               | ✅       | ✅      |
| <img src="https://deepinfra.com/_next/static/media/logo.4a03fd3d.svg" width=35>                                            | [DeepInfra](https://portkey.sh/gh-92)                               | ✅       | ✅      |
| <img src="https://ollama.com/public/ollama.png" width=35>                                                                  | [Ollama](https://portkey.wiki/gh-72)                           | ✅       | ✅      |
| <img src="https://novita.ai/favicon.ico" width=35>                                                                         | [Novita AI](https://portkey.wiki/gh-73)                              | ✅       | ✅      | `/chat/completions`, `/completions` |


> [Xem danh sách đầy đủ hơn 200 mô hình được hỗ trợ tại đây](https://portkey.wiki/gh-74)
<br>

<br>

## Agents
Gateway tích hợp liền mạch với các framework agent phổ biến. [Đọc tài liệu tại đây](https://portkey.wiki/gh-75).


| Framework | Gọi 200+ LLM | Định tuyến nâng cao | Caching | Logging & Tracing* | Quan sát* | Quản lý Prompt* |
|------------------------------|--------|-------------|---------|------|---------------|-------------------|
| [Autogen](https://portkey.wiki/gh-93)    | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [CrewAI](https://portkey.wiki/gh-94)             | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [LangChain](https://portkey.wiki/gh-95)             | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [Phidata](https://portkey.wiki/gh-96)             | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [Llama Index](https://portkey.wiki/gh-97)             | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [Control Flow](https://portkey.wiki/gh-98) | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [Tự xây dựng Agents](https://portkey.wiki/gh-99) | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |

<br>

*Có trên [ứng dụng hosted](https://portkey.wiki/gh-76). Đọc tài liệu chi tiết [tại đây](https://portkey.wiki/gh-100).


## Phiên bản Gateway Enterprise
Giúp ứng dụng AI của bạn <ins>ổn định hơn</ins> và <ins>tương thích tương lai</ins>, đồng thời đảm bảo <ins>bảo mật dữ liệu</ins> và <ins>riêng tư</ins> hoàn toàn.

✅&nbsp; Quản lý khóa an toàn - cho kiểm soát truy cập theo vai trò và theo dõi <br>
✅&nbsp; Bộ nhớ đệm đơn giản & semantic - phục vụ truy vấn lặp lại nhanh hơn & tiết kiệm chi phí <br>
✅&nbsp; Kiểm soát truy cập & Quy tắc inbound - kiểm soát IP và vùng địa lý có thể truy cập triển khai của bạn <br>
✅&nbsp; Ẩn thông tin cá nhân (PII Redaction) - tự động loại bỏ dữ liệu nhạy cảm khỏi yêu cầu để tránh lộ thông tin <br>
✅&nbsp; Tuân thủ SOC2, ISO, HIPAA, GDPR - đảm bảo thực hành bảo mật tốt nhất <br>
✅&nbsp; Hỗ trợ chuyên nghiệp - cùng ưu tiên phát triển tính năng <br>

[Đặt lịch gọi để thảo luận triển khai doanh nghiệp](https://portkey.sh/demo-13)

<br>


## Đóng góp

Cách dễ nhất để đóng góp là chọn một issue có gắn thẻ `good first issue` 💪. Đọc hướng dẫn đóng góp [tại đây](https://raw.githubusercontent.com/Portkey-AI/gateway/main/.github/CONTRIBUTING.md).

Báo lỗi? [Gửi tại đây](https://portkey.wiki/gh-78) | Yêu cầu tính năng? [Gửi tại đây](https://portkey.wiki/gh-78)


### Bắt đầu cùng cộng đồng
Tham gia AI Engineering Hours hàng tuần vào thứ Sáu (8 AM PT) để:
- Gặp gỡ các thành viên và cộng tác viên khác
- Học các tính năng nâng cao và mẫu triển khai Gateway
- Chia sẻ trải nghiệm và nhận hỗ trợ
- Cập nhật các ưu tiên phát triển mới nhất

[Tham gia buổi tiếp theo →](https://portkey.wiki/gh-101) | [Ghi chú cuộc họp](https://portkey.wiki/gh-102)

<br>

## Cộng đồng

Tham gia cộng đồng đang phát triển của chúng tôi trên toàn thế giới, để nhận trợ giúp, ý tưởng và thảo luận về AI.

- Xem [Blog chính thức](https://portkey.wiki/gh-78)
- Trò chuyện cùng chúng tôi trên [Discord](https://portkey.wiki/community)
- Theo dõi chúng tôi trên [Twitter](https://portkey.wiki/gh-79)
- Kết nối trên [LinkedIn](https://portkey.wiki/gh-80)
- Đọc tài liệu bằng [tiếng Nhật](https://raw.githubusercontent.com/Portkey-AI/gateway/main/.github/README.jp.md)
- Truy cập [YouTube](https://portkey.wiki/gh-103)
- Tham gia [Cộng đồng Dev](https://portkey.wiki/gh-82)
<!-- - Các câu hỏi gắn thẻ #portkey trên [Stack Overflow](https://stackoverflow.com/questions/tagged/portkey) -->

![Rubeus Social Share (4)](https://github.com/Portkey-AI/gateway/assets/971978/89d6f0af-a95d-4402-b451-14764c40d03f)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---