![cover-v5-optimized](./images/GitHub_README_if.png)

<p align="center">
  📌 <a href="https://dify.ai/blog/introducing-dify-workflow-file-upload-a-demo-on-ai-podcast">Giới thiệu Dify Workflow File Upload: Tái tạo Google NotebookLM Podcast</a>
</p>

<p align="center">
  <a href="https://cloud.dify.ai">Dify Cloud</a> ·
  <a href="https://docs.dify.ai/getting-started/install-self-hosted">Tự triển khai</a> ·
  <a href="https://docs.dify.ai">Tài liệu</a> ·
  <a href="https://dify.ai/pricing">Tổng quan các phiên bản Dify</a>
</p>

<p align="center">
    <a href="https://dify.ai" target="_blank">
        <img alt="Static Badge" src="https://img.shields.io/badge/Product-F04438"></a>
    <a href="https://dify.ai/pricing" target="_blank">
        <img alt="Static Badge" src="https://img.shields.io/badge/free-pricing?logo=free&color=%20%23155EEF&label=pricing&labelColor=%20%23528bff"></a>
    <a href="https://discord.gg/FngNHpbcY7" target="_blank">
        <img src="https://img.shields.io/discord/1082486657678311454?logo=discord&labelColor=%20%235462eb&logoColor=%20%23f5f5f5&color=%20%235462eb"
            alt="chat on Discord"></a>
    <a href="https://reddit.com/r/difyai" target="_blank">  
        <img src="https://img.shields.io/reddit/subreddit-subscribers/difyai?style=plastic&logo=reddit&label=r%2Fdifyai&labelColor=white"
            alt="join Reddit"></a>
    <a href="https://twitter.com/intent/follow?screen_name=dify_ai" target="_blank">
        <img src="https://img.shields.io/twitter/follow/dify_ai?logo=X&color=%20%23f5f5f5"
            alt="follow on X(Twitter)"></a>
    <a href="https://www.linkedin.com/company/langgenius/" target="_blank">
        <img src="https://custom-icon-badges.demolab.com/badge/LinkedIn-0A66C2?logo=linkedin-white&logoColor=fff"
            alt="follow on LinkedIn"></a>
    <a href="https://hub.docker.com/u/langgenius" target="_blank">
        <img alt="Docker Pulls" src="https://img.shields.io/docker/pulls/langgenius/dify-web?labelColor=%20%23FDB062&color=%20%23f79009"></a>
    <a href="https://github.com/langgenius/dify/graphs/commit-activity" target="_blank">
        <img alt="Commits last month" src="https://img.shields.io/github/commit-activity/m/langgenius/dify?labelColor=%20%2332b583&color=%20%2312b76a"></a>
    <a href="https://github.com/langgenius/dify/" target="_blank">
        <img alt="Issues closed" src="https://img.shields.io/github/issues-search?query=repo%3Alanggenius%2Fdify%20is%3Aclosed&label=issues%20closed&labelColor=%20%237d89b0&color=%20%235d6b98"></a>
    <a href="https://github.com/langgenius/dify/discussions/" target="_blank">
        <img alt="Discussion posts" src="https://img.shields.io/github/discussions/langgenius/dify?labelColor=%20%239b8afb&color=%20%237a5af8"></a>
</p>

<p align="center">
  <a href="./README.md"><img alt="README in English" src="https://img.shields.io/badge/English-d9d9d9"></a>
  <a href="./README_TW.md"><img alt="繁體中文文件" src="https://img.shields.io/badge/繁體中文-d9d9d9"></a>
  <a href="./README_CN.md"><img alt="简体中文版自述文件" src="https://img.shields.io/badge/简体中文-d9d9d9"></a>
  <a href="./README_JA.md"><img alt="日本語のREADME" src="https://img.shields.io/badge/日本語-d9d9d9"></a>
  <a href="./README_ES.md"><img alt="README en Español" src="https://img.shields.io/badge/Español-d9d9d9"></a>
  <a href="./README_FR.md"><img alt="README en Français" src="https://img.shields.io/badge/Français-d9d9d9"></a>
  <a href="./README_KL.md"><img alt="README tlhIngan Hol" src="https://img.shields.io/badge/Klingon-d9d9d9"></a>
  <a href="./README_KR.md"><img alt="README in Korean" src="https://img.shields.io/badge/한국어-d9d9d9"></a>
  <a href="./README_AR.md"><img alt="README بالعربية" src="https://img.shields.io/badge/العربية-d9d9d9"></a>
  <a href="./README_TR.md"><img alt="Türkçe README" src="https://img.shields.io/badge/Türkçe-d9d9d9"></a>
  <a href="./README_VI.md"><img alt="README Tiếng Việt" src="https://img.shields.io/badge/Ti%E1%BA%BFng%20Vi%E1%BB%87t-d9d9d9"></a>
  <a href="./README_DE.md"><img alt="README in Deutsch" src="https://img.shields.io/badge/German-d9d9d9"></a>
  <a href="./README_BN.md"><img alt="README in বাংলা" src="https://img.shields.io/badge/বাংলা-d9d9d9"></a>
</p>

Dify là nền tảng phát triển ứng dụng LLM mã nguồn mở. Giao diện trực quan kết hợp quy trình làm việc AI kiểu agentic, pipeline RAG, khả năng agent, quản lý mô hình, tính năng quan sát và nhiều hơn nữa, cho phép bạn nhanh chóng chuyển từ nguyên mẫu sang sản xuất.

## Bắt đầu nhanh

> Trước khi cài đặt Dify, hãy đảm bảo máy của bạn đáp ứng các yêu cầu hệ thống tối thiểu sau:
>
> - CPU >= 2 nhân
> - RAM >= 4 GiB

</br>

Cách dễ nhất để khởi động máy chủ Dify là thông qua [docker compose](docker/docker-compose.yaml). Trước khi chạy Dify bằng các lệnh sau, hãy chắc chắn rằng [Docker](https://docs.docker.com/get-docker/) và [Docker Compose](https://docs.docker.com/compose/install/) đã được cài đặt trên máy của bạn:

```bash
cd dify
cd docker
cp .env.example .env
docker compose up -d
```

Sau khi chạy, bạn có thể truy cập bảng điều khiển Dify trên trình duyệt tại [http://localhost/install](http://localhost/install) và bắt đầu quá trình khởi tạo.

#### Tìm kiếm sự trợ giúp

Vui lòng tham khảo [Câu hỏi thường gặp](https://docs.dify.ai/getting-started/install-self-hosted/faqs) nếu bạn gặp sự cố khi thiết lập Dify. Liên hệ với [cộng đồng và chúng tôi](#community--contact) nếu bạn vẫn gặp vấn đề.

> Nếu bạn muốn đóng góp cho Dify hoặc phát triển thêm, hãy tham khảo [hướng dẫn triển khai từ mã nguồn](https://docs.dify.ai/getting-started/install-self-hosted/local-source-code) của chúng tôi.

## Tính năng nổi bật

**1. Workflow (Quy trình làm việc)**:
Xây dựng và kiểm thử các workflow AI mạnh mẽ trên giao diện canvas trực quan, tận dụng tất cả tính năng bên dưới và nhiều hơn nữa.

**2. Hỗ trợ mô hình toàn diện**:
Tích hợp liền mạch với hàng trăm LLM độc quyền/mã nguồn mở từ nhiều nhà cung cấp inference và giải pháp tự triển khai, bao gồm GPT, Mistral, Llama3 và bất kỳ mô hình tương thích API OpenAI nào. Danh sách đầy đủ các nhà cung cấp mô hình được hỗ trợ có tại [đây](https://docs.dify.ai/getting-started/readme/model-providers).

![providers-v5](https://github.com/langgenius/dify/assets/13230914/5a17bdbe-097a-4100-8363-40255b70f6e3)

**3. Prompt IDE**:
Giao diện trực quan để thiết kế prompt, so sánh hiệu năng mô hình, và bổ sung các tính năng như chuyển văn bản thành giọng nói cho ứng dụng dạng trò chuyện.

**4. RAG Pipeline**:
Khả năng RAG toàn diện, bao gồm mọi thứ từ nạp tài liệu đến truy xuất, hỗ trợ sẵn sàng cho việc trích xuất văn bản từ PDF, PPT và các định dạng tài liệu phổ biến khác.

**5. Khả năng Agent**:
Bạn có thể định nghĩa agent dựa trên LLM Function Calling hoặc ReAct, và thêm các công cụ dựng sẵn hoặc tuỳ chỉnh cho agent. Dify cung cấp hơn 50 công cụ tích hợp sẵn cho AI agent, như Google Search, DALL·E, Stable Diffusion và WolframAlpha.

**6. LLMOps**:
Giám sát và phân tích log ứng dụng và hiệu suất theo thời gian. Bạn có thể liên tục cải thiện prompt, tập dữ liệu và mô hình dựa trên dữ liệu sản xuất và chú thích.

**7. Backend-as-a-Service**:
Tất cả các dịch vụ của Dify đều có API tương ứng, giúp bạn dễ dàng tích hợp Dify vào logic kinh doanh của mình.

## So sánh tính năng

<table style="width: 100%;">
  <tr>
    <th align="center">Tính năng</th>
    <th align="center">Dify.AI</th>
    <th align="center">LangChain</th>
    <th align="center">Flowise</th>
    <th align="center">OpenAI Assistants API</th>
  </tr>
  <tr>
    <td align="center">Cách tiếp cận lập trình</td>
    <td align="center">API + Hướng ứng dụng</td>
    <td align="center">Python Code</td>
    <td align="center">Hướng ứng dụng</td>
    <td align="center">Hướng API</td>
  </tr>
  <tr>
    <td align="center">LLM được hỗ trợ</td>
    <td align="center">Đa dạng phong phú</td>
    <td align="center">Đa dạng phong phú</td>
    <td align="center">Đa dạng phong phú</td>
    <td align="center">Chỉ OpenAI</td>
  </tr>
  <tr>
    <td align="center">RAG Engine</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
  </tr>
  <tr>
    <td align="center">Agent</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
    <td align="center">✅</td>
  </tr>
  <tr>
    <td align="center">Workflow</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
  </tr>
  <tr>
    <td align="center">Quan sát (Observability)</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
    <td align="center">❌</td>
  </tr>
  <tr>
    <td align="center">Tính năng doanh nghiệp (SSO/Quản lý truy cập)</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
    <td align="center">❌</td>
    <td align="center">❌</td>
  </tr>
  <tr>
    <td align="center">Triển khai cục bộ</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
  </tr>
</table>

## Sử dụng Dify

- **Cloud </br>**
  Chúng tôi cung cấp dịch vụ [Dify Cloud](https://dify.ai) cho bất kỳ ai muốn thử nghiệm mà không cần cài đặt. Nó cung cấp đầy đủ tính năng như bản tự triển khai và bao gồm 200 lượt gọi GPT-4 miễn phí trong gói sandbox.

- **Tự triển khai Dify Community Edition</br>**
  Nhanh chóng cài đặt Dify trong môi trường của bạn với [hướng dẫn khởi động nhanh](#quick-start).
  Sử dụng [tài liệu](https://docs.dify.ai) của chúng tôi để tham khảo thêm và hướng dẫn chi tiết hơn.

- **Dify cho doanh nghiệp/tổ chức</br>**
  Chúng tôi cung cấp các tính năng bổ sung dành cho doanh nghiệp. [Đặt câu hỏi qua chatbot này](https://udify.app/chat/22L1zSxg6yW1cWQg) hoặc [gửi email cho chúng tôi](mailto:business@dify.ai?subject=[GitHub]Business%20License%20Inquiry) để thảo luận về nhu cầu doanh nghiệp. </br>
  > Với các startup và doanh nghiệp nhỏ sử dụng AWS, hãy tham khảo [Dify Premium trên AWS Marketplace](https://aws.amazon.com/marketplace/pp/prodview-t22mebxzwjhu6) và triển khai vào AWS VPC của bạn chỉ với một cú nhấp chuột. Đây là gói AMI giá hợp lý, cho phép bạn tạo ứng dụng với logo và thương hiệu tùy chỉnh.

## Luôn dẫn đầu

Gắn sao cho Dify trên GitHub để nhận thông báo ngay khi có bản phát hành mới.

![star-us](https://github.com/langgenius/dify/assets/13230914/b823edc1-6388-4e25-ad45-2f6b187adbb4)

## Cài đặt nâng cao

Nếu bạn cần tuỳ chỉnh cấu hình, vui lòng tham khảo các chú thích trong file [.env.example](docker/.env.example) và cập nhật giá trị tương ứng trong file `.env` của bạn. Ngoài ra, bạn có thể cần chỉnh sửa file `docker-compose.yaml`, như thay đổi phiên bản image, ánh xạ cổng hoặc gắn volume, tuỳ vào môi trường triển khai và nhu cầu của bạn. Sau khi thay đổi, hãy chạy lại `docker-compose up -d`. Danh sách đầy đủ các biến môi trường có tại [đây](https://docs.dify.ai/getting-started/install-self-hosted/environments).

Nếu bạn muốn cấu hình một hệ thống có tính sẵn sàng cao, đã có các [Helm Charts](https://helm.sh/) và file YAML do cộng đồng đóng góp, cho phép triển khai Dify trên Kubernetes.

- [Helm Chart bởi @LeoQuote](https://github.com/douban/charts/tree/master/charts/dify)
- [Helm Chart bởi @BorisPolonsky](https://github.com/BorisPolonsky/dify-helm)
- [Helm Chart bởi @magicsong](https://github.com/magicsong/ai-charts)
- [File YAML bởi @Winson-030](https://github.com/Winson-030/dify-kubernetes)
- [File YAML bởi @wyy-holding](https://github.com/wyy-holding/dify-k8s)

#### Sử dụng Terraform để triển khai

Triển khai Dify lên Cloud Platform chỉ với một cú nhấp chuột bằng [terraform](https://www.terraform.io/)

##### Azure Global

- [Azure Terraform bởi @nikawang](https://github.com/nikawang/dify-azure-terraform)

##### Google Cloud

- [Google Cloud Terraform bởi @sotazum](https://github.com/DeNA/dify-google-cloud-terraform)

#### Sử dụng AWS CDK để triển khai

Triển khai Dify lên AWS với [CDK](https://aws.amazon.com/cdk/)

##### AWS

- [AWS CDK bởi @KevinZhao](https://github.com/aws-samples/solution-for-deploying-dify-on-aws)

## Đóng góp

Nếu bạn muốn đóng góp mã nguồn, hãy xem [Hướng dẫn đóng góp](https://github.com/langgenius/dify/blob/main/CONTRIBUTING.md).
Đồng thời, hãy ủng hộ Dify bằng cách chia sẻ nó trên mạng xã hội, sự kiện, hội nghị.

> Chúng tôi đang tìm kiếm cộng tác viên hỗ trợ dịch Dify sang các ngôn ngữ khác ngoài tiếng Trung hoặc tiếng Anh. Nếu bạn quan tâm, vui lòng xem [README i18n](https://github.com/langgenius/dify/blob/main/web/i18n/README.md) để biết thêm thông tin và để lại bình luận ở kênh `global-users` trên [Discord Community Server](https://discord.gg/8Tpq4AcN9c) của chúng tôi.

## Cộng đồng & liên hệ

- [Thảo luận trên GitHub](https://github.com/langgenius/dify/discussions). Thích hợp cho: chia sẻ phản hồi và đặt câu hỏi.
- [Vấn đề trên GitHub](https://github.com/langgenius/dify/issues). Thích hợp cho: báo lỗi khi sử dụng Dify.AI và đề xuất tính năng. Xem [Hướng dẫn đóng góp](https://github.com/langgenius/dify/blob/main/CONTRIBUTING.md).
- [Discord](https://discord.gg/FngNHpbcY7). Thích hợp cho: chia sẻ ứng dụng của bạn và giao lưu với cộng đồng.
- [X(Twitter)](https://twitter.com/dify_ai). Thích hợp cho: chia sẻ ứng dụng và giao lưu với cộng đồng.

**Cộng tác viên**

<a href="https://github.com/langgenius/dify/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=langgenius/dify" />
</a>

## Lịch sử Star

[![Star History Chart](https://api.star-history.com/svg?repos=langgenius/dify&type=Date)](https://star-history.com/#langgenius/dify&Date)

## Công bố bảo mật

Để bảo vệ quyền riêng tư của bạn, vui lòng không đăng các vấn đề bảo mật lên GitHub. Thay vào đó, hãy gửi câu hỏi của bạn tới security@dify.ai và chúng tôi sẽ cung cấp câu trả lời chi tiết hơn.

## Giấy phép

Kho lưu trữ này được phát hành theo [Giấy phép Mã nguồn mở Dify](LICENSE), về cơ bản là Apache 2.0 với một số hạn chế bổ sung.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---