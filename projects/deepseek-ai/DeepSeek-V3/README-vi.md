<!-- markdownlint-disable first-line-h1 -->
<!-- markdownlint-disable html -->
<!-- markdownlint-disable no-duplicate-header -->

<div align="center">
  <img src="https://github.com/deepseek-ai/DeepSeek-V2/blob/main/figures/logo.svg?raw=true" width="60%" alt="DeepSeek-V3" />
</div>
<hr>
<div align="center" style="line-height: 1;">
  <a href="https://www.deepseek.com/"><img alt="Homepage"
    src="https://github.com/deepseek-ai/DeepSeek-V2/blob/main/figures/badge.svg?raw=true"/></a>
  <a href="https://chat.deepseek.com/"><img alt="Chat"
    src="https://img.shields.io/badge/🤖%20Chat-DeepSeek%20V3-536af5?color=536af5&logoColor=white"/></a>
  <a href="https://huggingface.co/deepseek-ai"><img alt="Hugging Face"
    src="https://img.shields.io/badge/%F0%9F%A4%97%20Hugging%20Face-DeepSeek%20AI-ffc107?color=ffc107&logoColor=white"/></a>
  <br>
  <a href="https://discord.gg/Tc7c45Zzu5"><img alt="Discord"
    src="https://img.shields.io/badge/Discord-DeepSeek%20AI-7289da?logo=discord&logoColor=white&color=7289da"/></a>
  <a href="https://github.com/deepseek-ai/DeepSeek-V2/blob/main/figures/qr.jpeg?raw=true"><img alt="Wechat"
    src="https://img.shields.io/badge/WeChat-DeepSeek%20AI-brightgreen?logo=wechat&logoColor=white"/></a>
  <a href="https://twitter.com/deepseek_ai"><img alt="Twitter Follow"
    src="https://img.shields.io/badge/Twitter-deepseek_ai-white?logo=x&logoColor=white"/></a>
  <br>
  <a href="https://github.com/deepseek-ai/DeepSeek-V3/blob/main/LICENSE-CODE"><img alt="Code License"
    src="https://img.shields.io/badge/Code_License-MIT-f5de53?&color=f5de53"/></a>
  <a href="https://github.com/deepseek-ai/DeepSeek-V3/blob/main/LICENSE-MODEL"><img alt="Model License"
    src="https://img.shields.io/badge/Model_License-Model_Agreement-f5de53?&color=f5de53"/></a>
  <br>
  <a href="https://arxiv.org/pdf/2412.19437"><b>Paper Link</b>👁️</a>
</div>

## Mục lục

1. [Giới thiệu](#1-giới-thiệu)
2. [Tóm tắt mô hình](#2-tóm-tắt-mô-hình)
3. [Tải xuống mô hình](#3-tải-xuống-mô-hình)
4. [Kết quả đánh giá](#4-kết-quả-đánh-giá)
5. [Trang web Chat & Nền tảng API](#5-trang-web-chat--nền-tảng-api)
6. [Chạy cục bộ](#6-chạy-cục-bộ)
7. [Giấy phép](#7-giấy-phép)
8. [Trích dẫn](#8-trích-dẫn)
9. [Liên hệ](#9-liên-hệ)


## 1. Giới thiệu

Chúng tôi giới thiệu DeepSeek-V3, một mô hình ngôn ngữ Mixture-of-Experts (MoE) mạnh mẽ với tổng số 671 tỷ tham số, trong đó 37 tỷ tham số được kích hoạt cho mỗi token.  
Để đạt được suy luận hiệu quả và huấn luyện tiết kiệm chi phí, DeepSeek-V3 áp dụng kiến trúc Multi-head Latent Attention (MLA) và DeepSeekMoE, đã được xác thực kỹ lưỡng trong DeepSeek-V2.  
Hơn nữa, DeepSeek-V3 tiên phong với chiến lược cân bằng tải không cần auxiliary-loss và đặt mục tiêu huấn luyện dự đoán đa token (multi-token prediction) nhằm nâng cao hiệu suất.  
Chúng tôi huấn luyện sơ bộ DeepSeek-V3 trên 14,8 nghìn tỷ token đa dạng và chất lượng cao, sau đó tiến hành các giai đoạn Fine-Tuning Giám sát và Học tăng cường để khai thác tối đa khả năng của mô hình.  
Các đánh giá toàn diện cho thấy DeepSeek-V3 vượt trội hơn các mô hình mã nguồn mở khác và đạt hiệu năng tương đương với các mô hình mã nguồn đóng hàng đầu.  
Mặc dù đạt hiệu suất xuất sắc, DeepSeek-V3 chỉ cần 2,788 triệu giờ GPU H800 cho toàn bộ quá trình huấn luyện.  
Ngoài ra, quá trình huấn luyện của mô hình này rất ổn định.  
Trong suốt quá trình huấn luyện, chúng tôi không gặp phải bất kỳ sự cố mất mát không thể phục hồi nào hoặc phải rollback.  
<p align="center">
  <img width="80%" src="figures/benchmark.png">
</p>

## 2. Tóm tắt mô hình

---

**Kiến trúc: Chiến lược cân bằng tải và mục tiêu huấn luyện đột phá**

- Dựa trên kiến trúc hiệu quả của DeepSeek-V2, chúng tôi tiên phong với chiến lược cân bằng tải không cần auxiliary-loss, giúp giảm thiểu suy giảm hiệu suất phát sinh từ việc cân bằng tải.
- Chúng tôi nghiên cứu mục tiêu Dự đoán Đa Token (Multi-Token Prediction - MTP) và chứng minh lợi ích của nó đối với hiệu suất mô hình.  
    Nó cũng có thể được sử dụng cho quá trình suy luận gia tốc (speculative decoding).

---

**Huấn luyện sơ bộ: Hướng tới hiệu quả tối ưu**

- Chúng tôi thiết kế khung huấn luyện hỗn hợp chính xác FP8 và lần đầu tiên xác thực tính khả thi cũng như hiệu quả của huấn luyện FP8 trên mô hình siêu lớn.  
- Thông qua đồng thiết kế thuật toán, framework và phần cứng, chúng tôi vượt qua nút thắt cổ chai truyền thông trong huấn luyện MoE đa node, gần như đạt được sự chồng lấp hoàn toàn giữa tính toán và truyền thông.  
  Điều này nâng cao hiệu quả huấn luyện và giảm chi phí, cho phép mở rộng quy mô mô hình mà không tăng thêm chi phí.  
- Với chi phí chỉ 2,664 triệu giờ GPU H800, chúng tôi hoàn tất huấn luyện sơ bộ DeepSeek-V3 trên 14,8T token, tạo ra mô hình nền tảng mã nguồn mở mạnh nhất hiện nay. Các giai đoạn huấn luyện tiếp theo chỉ cần thêm 0,1 triệu giờ GPU.

---

**Sau huấn luyện: Chưng cất tri thức từ DeepSeek-R1**

- Chúng tôi giới thiệu phương pháp sáng tạo để chưng cất khả năng suy luận từ mô hình Chain-of-Thought (CoT) chuỗi dài, cụ thể từ một trong các mô hình dòng DeepSeek R1, vào các LLM chuẩn, đặc biệt là DeepSeek-V3. Quy trình của chúng tôi tích hợp khéo léo các mẫu xác minh và phản chiếu của R1 vào DeepSeek-V3, cải thiện đáng kể hiệu suất suy luận. Đồng thời, chúng tôi cũng kiểm soát được phong cách và độ dài đầu ra của DeepSeek-V3.

---

## 3. Tải xuống mô hình

<div align="center">

| **Mô hình** | **#Tổng tham số** | **#Tham số kích hoạt** | **Chiều dài ngữ cảnh** | **Tải xuống** |
| :------------: | :------------: | :------------: | :------------: | :------------: |
| DeepSeek-V3-Base | 671B | 37B | 128K   | [🤗 Hugging Face](https://huggingface.co/deepseek-ai/DeepSeek-V3-Base)   |
| DeepSeek-V3   | 671B | 37B |  128K   | [🤗 Hugging Face](https://huggingface.co/deepseek-ai/DeepSeek-V3)   |

</div>

> [!CHÚ Ý]
> Tổng dung lượng các mô hình DeepSeek-V3 trên Hugging Face là 685B, bao gồm 671B trọng số mô hình chính và 14B trọng số của Module Multi-Token Prediction (MTP).

Để đảm bảo hiệu năng tối ưu và tính linh hoạt, chúng tôi hợp tác với các cộng đồng mã nguồn mở và nhà cung cấp phần cứng để cung cấp nhiều phương thức chạy mô hình cục bộ. Tham khảo hướng dẫn từng bước tại Mục 6: [Chạy cục bộ](#6-chạy-cục-bộ).

Dành cho các nhà phát triển muốn tìm hiểu sâu hơn, hãy khám phá [README_WEIGHTS.md](./README_WEIGHTS.md) để biết chi tiết về trọng số Mô hình chính và các Module Multi-Token Prediction (MTP). Lưu ý rằng hỗ trợ MTP hiện đang được phát triển tích cực trong cộng đồng, và chúng tôi hoan nghênh đóng góp, phản hồi của bạn.

## 4. Kết quả đánh giá
### Mô hình nền tảng (Base Model)
#### Bộ benchmark tiêu chuẩn

<div align="center">


|  | Benchmark (Metric) | # Shots | DeepSeek-V2 | Qwen2.5 72B | LLaMA3.1 405B | DeepSeek-V3 |
|---|-------------------|----------|--------|-------------|---------------|---------|
| | Architecture | - | MoE | Dense | Dense | MoE |
| | # Activated Params | - | 21B | 72B | 405B | 37B |
| | # Total Params | - | 236B | 72B | 405B | 671B |
| English | Pile-test (BPB) | - | 0.606 | 0.638 | **0.542** | 0.548 |
| | BBH (EM) | 3-shot | 78.8 | 79.8 | 82.9 | **87.5** |
| | MMLU (Acc.) | 5-shot | 78.4 | 85.0 | 84.4 | **87.1** |
| | MMLU-Redux (Acc.) | 5-shot | 75.6 | 83.2 | 81.3 | **86.2** |
| | MMLU-Pro (Acc.) | 5-shot | 51.4 | 58.3 | 52.8 | **64.4** |
| | DROP (F1) | 3-shot | 80.4 | 80.6 | 86.0 | **89.0** |
| | ARC-Easy (Acc.) | 25-shot | 97.6 | 98.4 | 98.4 | **98.9** |
| | ARC-Challenge (Acc.) | 25-shot | 92.2 | 94.5 | **95.3** | **95.3** |
| | HellaSwag (Acc.) | 10-shot | 87.1 | 84.8 | **89.2** | 88.9 |
| | PIQA (Acc.) | 0-shot | 83.9 | 82.6 | **85.9** | 84.7 |
| | WinoGrande (Acc.) | 5-shot | **86.3** | 82.3 | 85.2 | 84.9 |
| | RACE-Middle (Acc.) | 5-shot | 73.1 | 68.1 | **74.2** | 67.1 |
| | RACE-High (Acc.) | 5-shot | 52.6 | 50.3 | **56.8** | 51.3 |
| | TriviaQA (EM) | 5-shot | 80.0 | 71.9 | 82.7 | **82.9** |
| | NaturalQuestions (EM) | 5-shot | 38.6 | 33.2 | **41.5** | 40.0 |
| | AGIEval (Acc.) | 0-shot | 57.5 | 75.8 | 60.6 | **79.6** |
| Code | HumanEval (Pass@1) | 0-shot | 43.3 | 53.0 | 54.9 | **65.2** |
| | MBPP (Pass@1) | 3-shot | 65.0 | 72.6 | 68.4 | **75.4** |
| | LiveCodeBench-Base (Pass@1) | 3-shot | 11.6 | 12.9 | 15.5 | **19.4** |
| | CRUXEval-I (Acc.) | 2-shot | 52.5 | 59.1 | 58.5 | **67.3** |
| | CRUXEval-O (Acc.) | 2-shot | 49.8 | 59.9 | 59.9 | **69.8** |
| Math | GSM8K (EM) | 8-shot | 81.6 | 88.3 | 83.5 | **89.3** |
| | MATH (EM) | 4-shot | 43.4 | 54.4 | 49.0 | **61.6** |
| | MGSM (EM) | 8-shot | 63.6 | 76.2 | 69.9 | **79.8** |
| | CMath (EM) | 3-shot | 78.7 | 84.5 | 77.3 | **90.7** |
| Chinese | CLUEWSC (EM) | 5-shot | 82.0 | 82.5 | **83.0** | 82.7 |
| | C-Eval (Acc.) | 5-shot | 81.4 | 89.2 | 72.5 | **90.1** |
| | CMMLU (Acc.) | 5-shot | 84.0 | **89.5** | 73.7 | 88.8 |
| | CMRC (EM) | 1-shot | **77.4** | 75.8 | 76.0 | 76.3 |
| | C3 (Acc.) | 0-shot | 77.4 | 76.7 | **79.7** | 78.6 |
| | CCPM (Acc.) | 0-shot | **93.0** | 88.5 | 78.6 | 92.0 |
| Multilingual | MMMLU-non-English (Acc.) | 5-shot | 64.0 | 74.8 | 73.8 | **79.4** |

</div>

> [!CHÚ Ý]
> Kết quả tốt nhất được in đậm. Các điểm số có chênh lệch không vượt quá 0,3 được coi là cùng mức. DeepSeek-V3 đạt hiệu năng tốt nhất trên phần lớn benchmark, đặc biệt ở các bài toán toán học và lập trình.
> Tham khảo bài báo của chúng tôi để biết chi tiết đánh giá. 

#### Cửa sổ ngữ cảnh
<p align="center">
  <img width="80%" src="figures/niah.png">
</p>

Kết quả đánh giá trên các bài kiểm tra ``Needle In A Haystack`` (NIAH). DeepSeek-V3 hoạt động tốt ở tất cả các chiều dài cửa sổ ngữ cảnh lên tới **128K**.

### Mô hình Chat
#### Bộ benchmark tiêu chuẩn (Các mô hình lớn hơn 67B)
<div align="center">

| | **Benchmark (Metric)** | **DeepSeek V2-0506** | **DeepSeek V2.5-0905** | **Qwen2.5 72B-Inst.** | **Llama3.1 405B-Inst.** | **Claude-3.5-Sonnet-1022** | **GPT-4o 0513** | **DeepSeek V3** |
|---|---------------------|---------------------|----------------------|---------------------|----------------------|---------------------------|----------------|----------------|
| | Architecture | MoE | MoE | Dense | Dense | - | - | MoE |
| | # Activated Params | 21B | 21B | 72B | 405B | - | - | 37B |
| | # Total Params | 236B | 236B | 72B | 405B | - | - | 671B |
| English | MMLU (EM) | 78.2 | 80.6 | 85.3 | **88.6** | **88.3** | 87.2 | **88.5** |
| | MMLU-Redux (EM) | 77.9 | 80.3 | 85.6 | 86.2 | **88.9** | 88.0 | **89.1** |
| | MMLU-Pro (EM) | 58.5 | 66.2 | 71.6 | 73.3 | **78.0** | 72.6 | 75.9 |
| | DROP (3-shot F1) | 83.0 | 87.8 | 76.7 | 88.7 | 88.3 | 83.7 | **91.6** |
| | IF-Eval (Prompt Strict) | 57.7 | 80.6 | 84.1 | 86.0 | **86.5** | 84.3 | 86.1 |
| | GPQA-Diamond (Pass@1) | 35.3 | 41.3 | 49.0 | 51.1 | **65.0** | 49.9 | 59.1 |
| | SimpleQA (Correct) | 9.0 | 10.2 | 9.1 | 17.1 | 28.4 | **38.2** | 24.9 |
| | FRAMES (Acc.) | 66.9 | 65.4 | 69.8 | 70.0 | 72.5 | **80.5** | 73.3 |
| | LongBench v2 (Acc.) | 31.6 | 35.4 | 39.4 | 36.1 | 41.0 | 48.1 | **48.7** |
| Code | HumanEval-Mul (Pass@1) | 69.3 | 77.4 | 77.3 | 77.2 | 81.7 | 80.5 | **82.6** |
| | LiveCodeBench (Pass@1-COT) | 18.8 | 29.2 | 31.1 | 28.4 | 36.3 | 33.4 | **40.5** |
| | LiveCodeBench (Pass@1) | 20.3 | 28.4 | 28.7 | 30.1 | 32.8 | 34.2 | **37.6** |
| | Codeforces (Percentile) | 17.5 | 35.6 | 24.8 | 25.3 | 20.3 | 23.6 | **51.6** |
| | SWE Verified (Resolved) | - | 22.6 | 23.8 | 24.5 | **50.8** | 38.8 | 42.0 |
| | Aider-Edit (Acc.) | 60.3 | 71.6 | 65.4 | 63.9 | **84.2** | 72.9 | 79.7 |
| | Aider-Polyglot (Acc.) | - | 18.2 | 7.6 | 5.8 | 45.3 | 16.0 | **49.6** |
| Math | AIME 2024 (Pass@1) | 4.6 | 16.7 | 23.3 | 23.3 | 16.0 | 9.3 | **39.2** |
| | MATH-500 (EM) | 56.3 | 74.7 | 80.0 | 73.8 | 78.3 | 74.6 | **90.2** |
| | CNMO 2024 (Pass@1) | 2.8 | 10.8 | 15.9 | 6.8 | 13.1 | 10.8 | **43.2** |
| Chinese | CLUEWSC (EM) | 89.9 | 90.4 | **91.4** | 84.7 | 85.4 | 87.9 | 90.9 |
| | C-Eval (EM) | 78.6 | 79.5 | 86.1 | 61.5 | 76.7 | 76.0 | **86.5** |
| | C-SimpleQA (Correct) | 48.5 | 54.1 | 48.4 | 50.4 | 51.3 | 59.3 | **64.8** |

</div>

> [!CHÚ Ý]
> Tất cả các mô hình được đánh giá với cấu hình giới hạn độ dài đầu ra ở mức 8K. Các benchmark có ít hơn 1000 mẫu sẽ được kiểm tra nhiều lần với các giá trị temperature khác nhau để đảm bảo kết quả cuối cùng ổn định. DeepSeek-V3 là mô hình mã nguồn mở có hiệu năng tốt nhất, đồng thời cạnh tranh mạnh với các mô hình mã nguồn đóng hàng đầu.


#### Đánh giá sinh đầu ra mở

<div align="center">



| Mô hình | Arena-Hard | AlpacaEval 2.0 |
|-------|------------|----------------|
| DeepSeek-V2.5-0905 | 76.2 | 50.5 |
| Qwen2.5-72B-Instruct | 81.2 | 49.1 |
| LLaMA-3.1 405B | 69.3 | 40.5 |
| GPT-4o-0513 | 80.4 | 51.1 |
| Claude-Sonnet-3.5-1022 | 85.2 | 52.0 |
| DeepSeek-V3 | **85.5** | **70.0** |

</div>

> [!CHÚ Ý]
> Đánh giá hội thoại tiếng Anh mở. Với AlpacaEval 2.0, chúng tôi sử dụng tỉ lệ thắng kiểm soát độ dài làm tiêu chí.

## 5. Trang web Chat & Nền tảng API
Bạn có thể trò chuyện với DeepSeek-V3 trên trang web chính thức của DeepSeek: [chat.deepseek.com](https://chat.deepseek.com/sign_in)

Chúng tôi cũng cung cấp API tương thích OpenAI tại DeepSeek Platform: [platform.deepseek.com](https://platform.deepseek.com/)

## 6. Chạy cục bộ

DeepSeek-V3 có thể triển khai cục bộ với các phần cứng và phần mềm mã nguồn mở sau:

1. **DeepSeek-Infer Demo**: Cung cấp demo nhẹ cho suy luận FP8 và BF16.
2. **SGLang**: Hỗ trợ đầy đủ mô hình DeepSeek-V3 ở cả hai chế độ suy luận BF16 và FP8, Multi-Token Prediction [sắp ra mắt](https://github.com/sgl-project/sglang/issues/2591).
3. **LMDeploy**: Cho phép suy luận hiệu quả FP8 và BF16 cho triển khai cục bộ và đám mây.
4. **TensorRT-LLM**: Hiện hỗ trợ suy luận BF16 và lượng tử hóa INT4/8, hỗ trợ FP8 sẽ ra mắt sớm.
5. **vLLM**: Hỗ trợ mô hình DeepSeek-V3 với chế độ FP8 và BF16 cho song song tensor và song song pipeline.
6. **LightLLM**: Hỗ trợ triển khai đơn node hoặc đa node hiệu quả cho FP8 và BF16.
7. **AMD GPU**: Cho phép chạy mô hình DeepSeek-V3 trên GPU AMD qua SGLang ở cả chế độ BF16 và FP8.
8. **Huawei Ascend NPU**: Hỗ trợ chạy DeepSeek-V3 trên thiết bị Huawei Ascend.

Vì huấn luyện FP8 được áp dụng gốc trong framework của chúng tôi, chúng tôi chỉ cung cấp trọng số FP8. Nếu bạn cần trọng số BF16 để thử nghiệm, hãy dùng script chuyển đổi đi kèm.

Ví dụ chuyển đổi trọng số FP8 sang BF16:

```shell
cd inference
python fp8_cast_bf16.py --input-fp8-hf-path /path/to/fp8_weights --output-bf16-hf-path /path/to/bf16_weights
```

> [!CHÚ Ý]
> Hugging Face Transformers chưa được hỗ trợ trực tiếp.

### 6.1 Suy luận với DeepSeek-Infer Demo (chỉ là ví dụ)

#### Yêu cầu hệ thống

> [!CHÚ Ý] 
> Chỉ hỗ trợ Linux với Python 3.10. Không hỗ trợ Mac và Windows.

Phụ thuộc:
```pip-requirements
torch==2.4.1
triton==3.0.0
transformers==4.46.3
safetensors==0.4.5
```
#### Chuẩn bị trọng số mô hình & mã demo

Đầu tiên, clone kho GitHub DeepSeek-V3 của chúng tôi:

```shell
git clone https://github.com/deepseek-ai/DeepSeek-V3.git
```

Di chuyển tới thư mục `inference` và cài đặt các phụ thuộc trong `requirements.txt`. Cách dễ nhất là dùng trình quản lý như `conda` hoặc `uv` để tạo môi trường ảo mới và cài đặt phụ thuộc.

```shell
cd DeepSeek-V3/inference
pip install -r requirements.txt
```

Tải trọng số mô hình từ Hugging Face và đặt vào thư mục `/path/to/DeepSeek-V3`.

#### Chuyển đổi trọng số mô hình

Chuyển đổi trọng số mô hình Hugging Face sang định dạng cụ thể:

```shell
python convert.py --hf-ckpt-path /path/to/DeepSeek-V3 --save-path /path/to/DeepSeek-V3-Demo --n-experts 256 --model-parallel 16
```

#### Chạy

Bây giờ bạn có thể chat với DeepSeek-V3:

```shell
torchrun --nnodes 2 --nproc-per-node 8 --node-rank $RANK --master-addr $ADDR generate.py --ckpt-path /path/to/DeepSeek-V3-Demo --config configs/config_671B.json --interactive --temperature 0.7 --max-new-tokens 200
```

Hoặc suy luận hàng loạt trên file cho trước:

```shell
torchrun --nnodes 2 --nproc-per-node 8 --node-rank $RANK --master-addr $ADDR generate.py --ckpt-path /path/to/DeepSeek-V3-Demo --config configs/config_671B.json --input-file $FILE
```

### 6.2 Suy luận với SGLang (khuyến nghị)

[SGLang](https://github.com/sgl-project/sglang) hiện hỗ trợ [tối ưu hóa MLA](https://lmsys.org/blog/2024-09-04-sglang-v0-3/#deepseek-multi-head-latent-attention-mla-throughput-optimizations), [DP Attention](https://lmsys.org/blog/2024-12-04-sglang-v0-4/#data-parallelism-attention-for-deepseek-models), FP8 (W8A8), FP8 KV Cache, và Torch Compile, mang lại độ trễ và thông lượng hàng đầu trong số các framework mã nguồn mở.

Đặc biệt, [SGLang v0.4.1](https://github.com/sgl-project/sglang/releases/tag/v0.4.1) hỗ trợ đầy đủ chạy DeepSeek-V3 trên cả **GPU NVIDIA và AMD**, giúp giải pháp này rất linh hoạt và mạnh mẽ.

SGLang còn hỗ trợ [song song tensor đa node](https://github.com/sgl-project/sglang/tree/main/benchmark/deepseek_v3#example-serving-with-2-h208), cho phép bạn chạy mô hình này trên nhiều máy kết nối mạng.

Multi-Token Prediction (MTP) đang được phát triển, theo dõi tiến độ tại [kế hoạch tối ưu hóa](https://github.com/sgl-project/sglang/issues/2591).

Hướng dẫn khởi chạy từ nhóm SGLang: https://github.com/sgl-project/sglang/tree/main/benchmark/deepseek_v3

### 6.3 Suy luận với LMDeploy (khuyến nghị)
[LMDeploy](https://github.com/InternLM/lmdeploy), framework suy luận và phục vụ hiệu suất cao, linh hoạt dành cho mô hình ngôn ngữ lớn, hiện hỗ trợ DeepSeek-V3. Cung cấp cả xử lý pipeline ngoại tuyến và triển khai trực tuyến, tích hợp mượt mà với workflow dựa trên PyTorch.

Hướng dẫn chi tiết từng bước sử dụng LMDeploy với DeepSeek-V3 tại: https://github.com/InternLM/lmdeploy/issues/2960

### 6.4 Suy luận với TRT-LLM (khuyến nghị)

[TensorRT-LLM](https://github.com/NVIDIA/TensorRT-LLM) hiện hỗ trợ mô hình DeepSeek-V3, cung cấp các tùy chọn chính xác như BF16 và INT4/INT8 weight-only. Hỗ trợ FP8 đang được phát triển và sẽ phát hành sớm. Bạn có thể truy cập branch tùy chỉnh TRTLLM dành riêng cho DeepSeek-V3 tại: https://github.com/NVIDIA/TensorRT-LLM/tree/main/examples/deepseek_v3. 

### 6.5 Suy luận với vLLM (khuyến nghị)

[vLLM](https://github.com/vllm-project/vllm) v0.6.6 hỗ trợ suy luận DeepSeek-V3 cho chế độ FP8 và BF16 trên cả GPU NVIDIA và AMD. Ngoài các kỹ thuật tiêu chuẩn, vLLM cung cấp _pipeline parallelism_ giúp chạy mô hình trên nhiều máy nối mạng. Xem hướng dẫn chi tiết tại [vLLM instructions](https://docs.vllm.ai/en/latest/serving/distributed_serving.html). Theo dõi [kế hoạch mở rộng](https://github.com/vllm-project/vllm/issues/11539).

### 6.6 Suy luận với LightLLM (khuyến nghị)

[LightLLM](https://github.com/ModelTC/lightllm/tree/main) v1.0.1 hỗ trợ triển khai song song tensor một máy và nhiều máy cho DeepSeek-R1 (FP8/BF16) và cung cấp triển khai hỗn hợp chính xác, với nhiều chế độ lượng tử hóa liên tục được tích hợp. Xem chi tiết tại [LightLLM instructions](https://lightllm-en.readthedocs.io/en/latest/getting_started/quickstart.html). Ngoài ra, LightLLM cung cấp triển khai PD-disaggregation cho DeepSeek-V2, và phiên bản cho DeepSeek-V3 đang được phát triển.

### 6.7 Suy luận khuyến nghị với GPU AMD

Hợp tác với đội ngũ AMD, chúng tôi đã đạt hỗ trợ Day-One cho GPU AMD sử dụng SGLang, tương thích đầy đủ cả FP8 và BF16. Xem hướng dẫn chi tiết tại [SGLang instructions](#63-inference-with-lmdeploy-recommended).

### 6.8 Suy luận khuyến nghị với Huawei Ascend NPU
Framework [MindIE](https://www.hiascend.com/en/software/mindie) từ cộng đồng Huawei Ascend đã thích ứng thành công phiên bản BF16 của DeepSeek-V3. Hướng dẫn từng bước cho Ascend NPUs tại [đây](https://modelers.cn/models/MindIE/deepseekv3).


## 7. Giấy phép
Kho mã nguồn này được cấp phép theo [Giấy phép MIT](LICENSE-CODE). Việc sử dụng các mô hình DeepSeek-V3 Base/Chat tuân theo [Giấy phép Mô hình](LICENSE-MODEL). Dòng DeepSeek-V3 (bao gồm Base và Chat) hỗ trợ sử dụng thương mại.

## 8. Trích dẫn
```
@misc{deepseekai2024deepseekv3technicalreport,
      title={DeepSeek-V3 Technical Report}, 
      author={DeepSeek-AI},
      year={2024},
      eprint={2412.19437},
      archivePrefix={arXiv},
      primaryClass={cs.CL},
      url={https://arxiv.org/abs/2412.19437}, 
}
```

## 9. Liên hệ
Nếu bạn có bất kỳ câu hỏi nào, vui lòng tạo issue hoặc liên hệ với chúng tôi qua [service@deepseek.com](service@deepseek.com).


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---