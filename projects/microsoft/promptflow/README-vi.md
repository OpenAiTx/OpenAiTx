# Prompt flow

[![Python package](https://img.shields.io/pypi/v/promptflow)](https://pypi.org/project/promptflow/)
[![Python](https://img.shields.io/pypi/pyversions/promptflow.svg?maxAge=2592000)](https://pypi.python.org/pypi/promptflow/)
[![PyPI - Downloads](https://img.shields.io/pypi/dm/promptflow)](https://pypi.org/project/promptflow/)
[![CLI](https://img.shields.io/badge/CLI-reference-blue)](https://microsoft.github.io/promptflow/reference/pf-command-reference.html)
[![vsc extension](https://img.shields.io/visual-studio-marketplace/i/prompt-flow.prompt-flow?logo=Visual%20Studio&label=Extension%20)](https://marketplace.visualstudio.com/items?itemName=prompt-flow.prompt-flow)

[![Doc](https://img.shields.io/badge/Doc-online-green)](https://microsoft.github.io/promptflow/index.html)
[![Issue](https://img.shields.io/github/issues/microsoft/promptflow)](https://github.com/microsoft/promptflow/issues/new/choose)
[![Discussions](https://img.shields.io/github/discussions/microsoft/promptflow)](https://github.com/microsoft/promptflow/issues/new/choose)
[![CONTRIBUTING](https://img.shields.io/badge/Contributing-8A2BE2)](https://github.com/microsoft/promptflow/blob/main/CONTRIBUTING.md)
[![License: MIT](https://img.shields.io/github/license/microsoft/promptflow)](https://github.com/microsoft/promptflow/blob/main/LICENSE)

> Chào mừng bạn tham gia cùng chúng tôi để cải thiện prompt flow bằng cách
> tham gia [thảo luận](https://github.com/microsoft/promptflow/discussions),
> mở [vấn đề mới](https://github.com/microsoft/promptflow/issues/new/choose),
> gửi [PR](https://github.com/microsoft/promptflow/pulls).

**Prompt flow** là bộ công cụ phát triển được thiết kế để đơn giản hóa chu trình phát triển ứng dụng AI dựa trên LLM, từ ý tưởng, tạo mẫu, kiểm thử, đánh giá cho đến triển khai sản xuất và giám sát. Nó giúp việc thiết kế prompt trở nên dễ dàng hơn rất nhiều và cho phép bạn xây dựng ứng dụng LLM với chất lượng sản xuất.

Với prompt flow, bạn có thể:

- **Tạo và phát triển flow một cách lặp lại**
    - Tạo [flow](https://microsoft.github.io/promptflow/concepts/concept-flows.html) có thể thực thi, liên kết các LLM, prompt, mã Python và các [công cụ](https://microsoft.github.io/promptflow/concepts/concept-tools.html) khác lại với nhau.
    - Gỡ lỗi và lặp lại flow của bạn, đặc biệt là [theo dõi tương tác với LLM](https://microsoft.github.io/promptflow/how-to-guides/tracing/index.html) một cách dễ dàng.
- **Đánh giá chất lượng và hiệu năng flow**
    - Đánh giá chất lượng và hiệu suất của flow với bộ dữ liệu lớn hơn.
    - Tích hợp kiểm thử và đánh giá vào hệ thống CI/CD để đảm bảo chất lượng của flow.
- **Chu trình phát triển tối ưu cho sản xuất**
    - Triển khai flow lên nền tảng phục vụ mà bạn lựa chọn hoặc tích hợp vào mã nguồn ứng dụng một cách dễ dàng.
    - (Tùy chọn nhưng rất khuyến nghị) Hợp tác cùng nhóm của bạn bằng cách sử dụng phiên bản cloud của [Prompt flow trên Azure AI](https://learn.microsoft.com/en-us/azure/machine-learning/prompt-flow/overview-what-is-prompt-flow?view=azureml-api-2).

------

## Cài đặt

Để bắt đầu nhanh chóng, bạn có thể sử dụng môi trường phát triển dựng sẵn. **Nhấn vào nút dưới đây** để mở repo trong GitHub Codespaces, sau đó tiếp tục đọc file readme!

[![Open in GitHub Codespaces](https://github.com/codespaces/badge.svg)](https://codespaces.new/microsoft/promptflow?quickstart=1)

Nếu bạn muốn bắt đầu trên môi trường cục bộ, đầu tiên hãy cài đặt các gói:

Đảm bảo bạn có môi trường python, khuyến nghị sử dụng `python>=3.9, <=3.11`.

```sh
pip install promptflow promptflow-tools
```

## Bắt đầu nhanh ⚡

**Tạo chatbot với prompt flow**

Chạy lệnh sau để khởi tạo một prompt flow từ mẫu chat, nó sẽ tạo thư mục tên `my_chatbot` và sinh ra các file cần thiết bên trong:

```sh
pf flow init --flow ./my_chatbot --type chat
```

**Thiết lập kết nối cho API key của bạn**

Đối với OpenAI key, thiết lập kết nối bằng cách chạy lệnh sau, sử dụng file `openai.yaml` trong thư mục `my_chatbot`, file này lưu trữ OpenAI key của bạn (ghi đè key và tên bằng --set để tránh thay đổi file yaml):

```sh
pf connection create --file ./my_chatbot/openai.yaml --set api_key=<your_api_key> --name open_ai_connection
```

Đối với Azure OpenAI key, thiết lập kết nối bằng cách chạy lệnh sau, sử dụng file `azure_openai.yaml`:

```sh
pf connection create --file ./my_chatbot/azure_openai.yaml --set api_key=<your_api_key> api_base=<your_api_base> --name open_ai_connection
```

**Trò chuyện với flow của bạn**

Trong thư mục `my_chatbot`, có file `flow.dag.yaml` mô tả flow, bao gồm input/output, các node, kết nối và model LLM, v.v.

> Lưu ý rằng ở node `chat`, chúng ta sử dụng kết nối tên `open_ai_connection` (chỉ định trong trường `connection`) và model `gpt-35-turbo` (chỉ định trong trường `deployment_name`). Trường deployment_name dùng để chỉ định model OpenAI hoặc resource deployment Azure OpenAI.

Tương tác với chatbot của bạn bằng cách chạy: (nhấn `Ctrl + C` để kết thúc phiên)

```sh
pf flow test --flow ./my_chatbot --interactive
```

**Giá trị cốt lõi: đảm bảo "Chất lượng Cao" từ mẫu thử đến sản xuất**

Khám phá [**hướng dẫn 15 phút**](https://raw.githubusercontent.com/microsoft/promptflow/main/examples/tutorials/flow-fine-tuning-evaluation/promptflow-quality-improvement.md) hướng dẫn bạn qua các bước tinh chỉnh prompt ➡ kiểm thử hàng loạt ➡ đánh giá, tất cả đều nhằm đảm bảo chất lượng cao sẵn sàng cho sản xuất.

Bước tiếp theo! Tiếp tục với phần **Hướng dẫn** 👇 để tìm hiểu sâu hơn về prompt flow.

## Hướng dẫn 🏃‍♂️

Prompt flow là công cụ được thiết kế để **xây dựng ứng dụng LLM chất lượng cao**, quy trình phát triển trong prompt flow gồm các bước: phát triển flow, nâng cao chất lượng flow, triển khai flow vào sản xuất.

### Phát triển ứng dụng LLM của riêng bạn

#### Tiện ích mở rộng VS Code

Chúng tôi cũng cung cấp tiện ích mở rộng VS Code (trình thiết kế flow) cho trải nghiệm phát triển flow tương tác với giao diện UI.

<img src="https://raw.githubusercontent.com/microsoft/promptflow/main/docs/media/readme/vsc.png" alt="vsc" width="1000"/>

Bạn có thể cài đặt từ <a href="https://marketplace.visualstudio.com/items?itemName=prompt-flow.prompt-flow">visualstudio marketplace</a>.

#### Tìm hiểu sâu về phát triển flow

[Bắt đầu với prompt flow](https://raw.githubusercontent.com/microsoft/promptflow/main/docs/how-to-guides/quick-start.md): Hướng dẫn từng bước để chạy flow đầu tiên của bạn.

### Học từ các trường hợp sử dụng

[Hướng dẫn: Chat với PDF](https://github.com/microsoft/promptflow/blob/main/examples/tutorials/e2e-development/chat-with-pdf.md): Hướng dẫn toàn diện cách xây dựng ứng dụng chat chất lượng cao với prompt flow, bao gồm phát triển flow và đánh giá với các chỉ số.
> Nhiều ví dụ khác có thể được tìm thấy [tại đây](https://microsoft.github.io/promptflow/tutorials/index.html#samples). Chúng tôi hoan nghênh đóng góp các trường hợp sử dụng mới!

### Thiết lập cho cộng tác viên

Nếu bạn quan tâm đóng góp, vui lòng bắt đầu với hướng dẫn thiết lập dev của chúng tôi: [dev_setup.md](https://raw.githubusercontent.com/microsoft/promptflow/main/docs/dev/dev_setup.md).

Bước tiếp theo! Tiếp tục với phần **Đóng góp** 👇 để đóng góp cho prompt flow.

## Đóng góp

Dự án này hoan nghênh các đóng góp và đề xuất. Hầu hết các đóng góp yêu cầu bạn đồng ý với
Thỏa thuận Cấp phép Cộng tác viên (CLA) xác nhận rằng bạn có quyền và thực sự cấp cho chúng tôi
quyền sử dụng đóng góp của bạn. Để biết chi tiết, truy cập https://cla.opensource.microsoft.com.

Khi bạn gửi pull request, bot CLA sẽ tự động xác định xem bạn có cần cung cấp
CLA hay không và đánh dấu PR phù hợp (ví dụ: trạng thái kiểm tra, bình luận). Chỉ cần làm theo hướng dẫn
do bot cung cấp. Bạn chỉ cần làm điều này một lần cho tất cả các repo sử dụng CLA của chúng tôi.

Dự án này đã áp dụng [Quy tắc ứng xử Mã nguồn Mở Microsoft](https://opensource.microsoft.com/codeofconduct/).
Để biết thêm thông tin hãy xem [FAQ Quy tắc ứng xử](https://opensource.microsoft.com/codeofconduct/faq/) hoặc
liên hệ [opencode@microsoft.com](mailto:opencode@microsoft.com) với bất kỳ câu hỏi hay góp ý nào thêm.

## Thương hiệu

Dự án này có thể chứa các thương hiệu hoặc logo cho dự án, sản phẩm hoặc dịch vụ. Việc sử dụng hợp pháp thương hiệu hoặc logo của Microsoft phải tuân thủ và theo
[Hướng dẫn Thương hiệu & Nhãn hiệu của Microsoft](https://www.microsoft.com/en-us/legal/intellectualproperty/trademarks/usage/general).
Việc sử dụng thương hiệu hoặc logo Microsoft trong các phiên bản sửa đổi của dự án này không được gây nhầm lẫn hoặc ngụ ý rằng được Microsoft tài trợ.
Mọi việc sử dụng thương hiệu hoặc logo bên thứ ba phải tuân thủ chính sách của bên thứ ba đó.

## Quy tắc ứng xử

Dự án này đã áp dụng
[Quy tắc ứng xử Mã nguồn Mở Microsoft](https://opensource.microsoft.com/codeofconduct/).
Để biết thêm thông tin vui lòng xem
[FAQ Quy tắc ứng xử](https://opensource.microsoft.com/codeofconduct/faq/)
hoặc liên hệ [opencode@microsoft.com](mailto:opencode@microsoft.com)
nếu có thắc mắc hoặc góp ý thêm.

## Thu thập dữ liệu

Phần mềm này có thể thu thập thông tin về bạn và cách bạn sử dụng phần mềm, đồng thời
gửi về Microsoft nếu cấu hình bật telemetry.
Microsoft có thể sử dụng thông tin này để cung cấp dịch vụ và cải thiện sản phẩm, dịch vụ của chúng tôi.
Bạn có thể bật telemetry như mô tả trong repo.
Ngoài ra còn có một số tính năng trong phần mềm cho phép bạn và Microsoft
thu thập dữ liệu từ người dùng ứng dụng của bạn. Nếu bạn sử dụng các tính năng này, bạn
phải tuân thủ pháp luật hiện hành, bao gồm cung cấp thông báo phù hợp cho
người dùng ứng dụng của bạn cùng với bản sao tuyên bố về quyền riêng tư của Microsoft.
Tuyên bố quyền riêng tư của chúng tôi nằm tại
https://go.microsoft.com/fwlink/?LinkID=824704. Bạn có thể tìm hiểu thêm về việc thu thập
và sử dụng dữ liệu trong tài liệu trợ giúp và tuyên bố quyền riêng tư của chúng tôi. Việc
sử dụng phần mềm này đồng nghĩa với việc bạn đồng ý với các thực tiễn này.

### Cấu hình Telemetry

Thu thập telemetry được bật theo mặc định.

Để tắt, vui lòng chạy `pf config set telemetry.enabled=false` để tắt nó.

## Giấy phép

Bản quyền (c) Microsoft Corporation. Bảo lưu mọi quyền.

Được cấp phép theo giấy phép [MIT](LICENSE).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---