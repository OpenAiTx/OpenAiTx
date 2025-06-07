# OCI AI Blueprints

**Triển khai, mở rộng và giám sát các khối lượng công việc AI với nền tảng OCI AI Blueprints, rút ngắn thời gian triển khai GPU từ hàng tuần xuống còn vài phút.**

OCI AI Blueprints là một giải pháp không cần mã hóa, đơn giản hóa việc triển khai và quản lý các khối lượng công việc AI tạo sinh trên Kubernetes Engine (OKE). Bằng cách cung cấp các khuyến nghị phần cứng đã được kiểm định, các bộ phần mềm đóng gói sẵn và công cụ quan sát hoạt động ngay khi cài đặt, OCI AI Blueprints giúp bạn vận hành các ứng dụng AI một cách nhanh chóng và hiệu quả—mà không cần phải vật lộn với sự phức tạp của các quyết định hạ tầng, khả năng tương thích phần mềm và các thực tiễn tốt nhất của MLOps.

[![Cài đặt OCI AI Blueprints](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/refs/heads/main/docs/images/install.svg)](./GETTING_STARTED_README.md)

## Mục Lục

**Bắt Đầu**

- [Cài đặt AI Blueprints](./GETTING_STARTED_README.md)
- [Truy cập Cổng thông tin và API AI Blueprints](docs/usage_guide.md)

**Về OCI AI Blueprints**

- [OCI AI Blueprints là gì?](docs/about.md)
- [Tại sao sử dụng OCI AI Blueprints?](docs/about.md)
- [Tính năng](docs/about.md)
- [Danh sách Blueprint](#blueprints)
- [Câu hỏi thường gặp](docs/about.md)
- [Hỗ trợ & Liên hệ](https://github.com/oracle-quickstart/oci-ai-blueprints/blob/vkammari/doc_improvements/docs/about/README.md#frequently-asked-questions-faq)

**Tham Khảo API**

- [Tài liệu Tham khảo API](docs/api_documentation.md)

**Tài Nguyên Bổ Sung**

- [Xuất bản Blueprint tùy chỉnh](./docs/custom_blueprints)
- [Cài đặt cập nhật](docs/installing_new_updates.md)
- [Chính sách IAM](docs/iam_policies.md)
- [Nội dung kho lưu trữ](docs/about.md)
- [Các vấn đề đã biết](docs/known_issues.md)

## Bắt Đầu

Cài đặt OCI AI Blueprints bằng cách nhấn nút dưới đây:

[![Cài đặt OCI AI Blueprints](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/refs/heads/main/docs/images/install.svg)](./GETTING_STARTED_README.md)

## Blueprint

Blueprint vượt xa các mẫu Terraform cơ bản. Mỗi blueprint:

- Cung cấp các gợi ý phần cứng đã được kiểm chứng (ví dụ: kiểu máy tối ưu, cấu hình CPU/GPU),
- Bao gồm các bộ ứng dụng đầu-cuối được tùy chỉnh cho từng trường hợp sử dụng GenAI khác nhau, và
- Tích hợp sẵn giám sát, ghi log, và tự động mở rộng quy mô ngay từ đầu.

Sau khi bạn cài đặt OCI AI Blueprints lên cụm OKE trong tenancy của mình, bạn có thể triển khai các blueprint dựng sẵn sau:

| Blueprint                                                                                     | Mô tả                                                                                                                                      |
| --------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------- |
| [**LLM & VLM Inference với vLLM**](docs/sample_blueprints/llm_inference_with_vllm/README.md)  | Triển khai các mô hình Llama 2/3/3.1 7B/8B sử dụng GPU NVIDIA và engine vLLM với tính năng tự động mở rộng.                              |
| [**Benchmarking Fine-Tuning**](./docs/sample_blueprints/lora-benchmarking)                    | Chạy kiểm thử hiệu suất LoRA finetuning Llama-2 70B đã lượng tử hóa của MLCommons trên A100.                                              |
| [**LoRA Fine-Tuning**](./docs/sample_blueprints/lora-fine-tuning)                             | Tinh chỉnh LoRA cho các mô hình tùy chỉnh hoặc HuggingFace với bất kỳ tập dữ liệu nào. Bao gồm tùy chỉnh siêu tham số linh hoạt.          |
| [**Health Check**](./docs/sample_blueprints/gpu-health-check)                                 | Đánh giá toàn diện hiệu suất GPU để đảm bảo sẵn sàng phần cứng tối ưu trước khi bắt đầu các khối lượng tính toán nặng.                   |
| [**CPU Inference**](./docs/sample_blueprints/cpu-inference)                                   | Sử dụng Ollama để thử nghiệm suy luận trên CPU với các mô hình như Mistral, Gemma và nhiều mô hình khác.                                 |
| [**Multi-node Inference với RDMA và vLLM**](./docs/sample_blueprints/multi-node-inference/)   | Triển khai các LLM kích thước Llama-405B trên nhiều node với RDMA sử dụng node H100, vLLM và LeaderWorkerSet.                            |
| [**Autoscaling Inference với vLLM**](./docs/sample_blueprints/auto_scaling/)                  | Phục vụ LLM với tính năng tự động mở rộng sử dụng KEDA, mở rộng tới nhiều GPU và node dựa trên các chỉ số ứng dụng như độ trễ suy luận.  |
| [**LLM Inference với MIG**](./docs/sample_blueprints/mig_multi_instance_gpu/)                 | Triển khai LLM trên một phần GPU với Multi-Instance GPU của Nvidia và phục vụ bằng vLLM.                                                  |
| [**Job Queuing**](./docs/sample_blueprints/teams)                                             | Tận dụng hệ thống xếp hàng công việc và thực thi hạn ngạch tài nguyên, chia sẻ công bằng giữa các nhóm.                                  |

## Hỗ Trợ & Liên Hệ

Nếu bạn có bất kỳ câu hỏi, vấn đề hoặc phản hồi nào, vui lòng liên hệ [vishnu.kammari@oracle.com](mailto:vishnu.kammari@oracle.com) hoặc [grant.neuman@oracle.com](mailto:grant.neuman@oracle.com).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---