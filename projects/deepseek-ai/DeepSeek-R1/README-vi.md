# DeepSeek-R1
<!-- markdownlint-disable first-line-h1 -->
<!-- markdownlint-disable html -->
<!-- markdownlint-disable no-duplicate-header -->

<div align="center">
  <img src="https://github.com/deepseek-ai/DeepSeek-V2/blob/main/figures/logo.svg?raw=true" width="60%" alt="DeepSeek-R1" />
</div>
<hr>
<div align="center" style="line-height: 1;">
  <a href="https://www.deepseek.com/" target="_blank"><img alt="Homepage"
    src="https://github.com/deepseek-ai/DeepSeek-V2/blob/main/figures/badge.svg?raw=true"/></a>
  <a href="https://chat.deepseek.com/" target="_blank"><img alt="Chat"
    src="https://img.shields.io/badge/🤖%20Chat-DeepSeek%20R1-536af5?color=536af5&logoColor=white"/></a>
  <a href="https://huggingface.co/deepseek-ai" target="_blank"><img alt="Hugging Face"
    src="https://img.shields.io/badge/%F0%9F%A4%97%20Hugging%20Face-DeepSeek%20AI-ffc107?color=ffc107&logoColor=white"/></a>
  <br>
  <a href="https://discord.gg/Tc7c45Zzu5" target="_blank"><img alt="Discord"
    src="https://img.shields.io/badge/Discord-DeepSeek%20AI-7289da?logo=discord&logoColor=white&color=7289da"/></a>
  <a href="https://github.com/deepseek-ai/DeepSeek-V2/blob/main/figures/qr.jpeg?raw=true" target="_blank"><img alt="WeChat"
    src="https://img.shields.io/badge/WeChat-DeepSeek%20AI-brightgreen?logo=wechat&logoColor=white"/></a>
  <a href="https://twitter.com/deepseek_ai" target="_blank"><img alt="Twitter Follow"
    src="https://img.shields.io/badge/Twitter-deepseek_ai-white?logo=x&logoColor=white"/></a>
  <br>
  <a href="https://github.com/deepseek-ai/DeepSeek-R1/blob/main/LICENSE"><img alt="License"
    src="https://img.shields.io/badge/License-MIT-f5de53?&color=f5de53"/></a>
  <br>
  <a href="https://github.com/deepseek-ai/DeepSeek-R1/blob/main/DeepSeek_R1.pdf"><b>Paper Link</b>👁️</a>
</div>

## 1. Giới thiệu

Chúng tôi giới thiệu các mô hình suy luận thế hệ đầu tiên của mình, DeepSeek-R1-Zero và DeepSeek-R1.  
DeepSeek-R1-Zero, một mô hình được huấn luyện bằng học tăng cường quy mô lớn (RL) mà không qua bước tinh chỉnh có giám sát (SFT) sơ bộ, đã thể hiện hiệu suất vượt trội trong suy luận.  
Với RL, DeepSeek-R1-Zero tự nhiên xuất hiện nhiều hành vi suy luận mạnh mẽ và thú vị.  
Tuy nhiên, DeepSeek-R1-Zero gặp phải các thách thức như lặp đi lặp lại vô tận, khả năng đọc kém và trộn lẫn ngôn ngữ. Để khắc phục các vấn đề này và nâng cao hiệu suất suy luận,  
chúng tôi giới thiệu DeepSeek-R1, mô hình tích hợp dữ liệu khởi động lạnh trước RL.  
DeepSeek-R1 đạt hiệu suất tương đương OpenAI-o1 trên các tác vụ toán học, lập trình và suy luận.  
Nhằm hỗ trợ cộng đồng nghiên cứu, chúng tôi đã mã nguồn mở DeepSeek-R1-Zero, DeepSeek-R1 và sáu mô hình dense được trích xuất từ DeepSeek-R1 dựa trên Llama và Qwen. DeepSeek-R1-Distill-Qwen-32B vượt trội hơn OpenAI-o1-mini trên nhiều bộ chuẩn, thiết lập kỷ lục mới cho các mô hình dense.

**LƯU Ý: Trước khi chạy các mô hình DeepSeek-R1 trên máy cục bộ, chúng tôi khuyến nghị bạn xem xét mục [Khuyến nghị sử dụng](#usage-recommendations).**

<p align="center">
  <img width="80%" src="figures/benchmark.jpg">
</p>

## 2. Tóm tắt mô hình

---

**Huấn luyện sau: Học tăng cường quy mô lớn trên mô hình nền tảng**

-  Chúng tôi áp dụng trực tiếp học tăng cường (RL) lên mô hình nền tảng mà không dựa vào tinh chỉnh có giám sát (SFT) như một bước sơ bộ. Cách tiếp cận này cho phép mô hình khám phá chuỗi suy nghĩ (CoT) để giải quyết các bài toán phức tạp, dẫn đến sự phát triển của DeepSeek-R1-Zero. DeepSeek-R1-Zero thể hiện các khả năng như tự kiểm tra, phản ánh và sinh ra các chuỗi suy nghĩ dài, đánh dấu một cột mốc quan trọng cho cộng đồng nghiên cứu. Đáng chú ý, đây là nghiên cứu mở đầu tiên xác thực rằng khả năng suy luận của các LLM có thể được khuyến khích hoàn toàn bằng RL, không cần SFT. Đột phá này mở đường cho những tiến bộ trong tương lai ở lĩnh vực này.

-   Chúng tôi giới thiệu quy trình phát triển DeepSeek-R1. Quy trình này gồm hai giai đoạn RL nhằm phát hiện các mẫu suy luận tốt hơn và điều chỉnh theo sở thích của con người, cũng như hai giai đoạn SFT đóng vai trò hạt giống cho khả năng suy luận và phi suy luận của mô hình.
    Chúng tôi tin rằng quy trình này sẽ mang lại lợi ích cho ngành công nghiệp bằng việc tạo ra các mô hình tốt hơn.

---

**Distillation: Mô hình nhỏ hơn cũng có thể mạnh mẽ**

-  Chúng tôi chứng minh rằng các mẫu suy luận của mô hình lớn có thể được trích xuất vào mô hình nhỏ hơn, mang lại hiệu suất tốt hơn so với các mẫu suy luận phát hiện qua RL trên mô hình nhỏ. DeepSeek-R1 mã nguồn mở và API của nó sẽ giúp cộng đồng nghiên cứu trích xuất các mô hình nhỏ hơn tốt hơn trong tương lai.
- Dựa trên dữ liệu suy luận được sinh ra bởi DeepSeek-R1, chúng tôi đã tinh chỉnh một số mô hình dense phổ biến trong cộng đồng nghiên cứu. Kết quả đánh giá cho thấy các mô hình dense nhỏ được trích xuất đạt hiệu suất xuất sắc trên các bộ chuẩn. Chúng tôi mã nguồn mở các checkpoint trích xuất 1.5B, 7B, 8B, 14B, 32B và 70B dựa trên Qwen2.5 và dòng Llama3 cho cộng đồng.

## 3. Tải mô hình

### Các mô hình DeepSeek-R1

<div align="center">

| **Mô hình** | **#Tham số tổng** | **#Tham số kích hoạt** | **Độ dài ngữ cảnh** | **Tải về** |
| :------------: | :------------: | :------------: | :------------: | :------------: |
| DeepSeek-R1-Zero | 671B | 37B | 128K   | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Zero)   |
| DeepSeek-R1   | 671B | 37B |  128K   | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1)   |

</div>

DeepSeek-R1-Zero & DeepSeek-R1 được huấn luyện dựa trên DeepSeek-V3-Base.  
Để biết thêm chi tiết về kiến trúc mô hình, vui lòng tham khảo kho [DeepSeek-V3](https://github.com/deepseek-ai/DeepSeek-V3).

### Các mô hình DeepSeek-R1-Distill

<div align="center">

| **Mô hình** | **Mô hình nền tảng** | **Tải về** |
| :------------: | :------------: | :------------: |
| DeepSeek-R1-Distill-Qwen-1.5B  | [Qwen2.5-Math-1.5B](https://huggingface.co/Qwen/Qwen2.5-Math-1.5B) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Qwen-1.5B)   |
| DeepSeek-R1-Distill-Qwen-7B  | [Qwen2.5-Math-7B](https://huggingface.co/Qwen/Qwen2.5-Math-7B) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Qwen-7B)   |
| DeepSeek-R1-Distill-Llama-8B  | [Llama-3.1-8B](https://huggingface.co/meta-llama/Llama-3.1-8B) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Llama-8B)   |
| DeepSeek-R1-Distill-Qwen-14B   | [Qwen2.5-14B](https://huggingface.co/Qwen/Qwen2.5-14B) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Qwen-14B)   |
|DeepSeek-R1-Distill-Qwen-32B  | [Qwen2.5-32B](https://huggingface.co/Qwen/Qwen2.5-32B) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Qwen-32B)   |
| DeepSeek-R1-Distill-Llama-70B  | [Llama-3.3-70B-Instruct](https://huggingface.co/meta-llama/Llama-3.3-70B-Instruct) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Llama-70B)   |

</div>

Các mô hình DeepSeek-R1-Distill được tinh chỉnh dựa trên các mô hình mã nguồn mở, sử dụng các mẫu sinh ra bởi DeepSeek-R1.  
Chúng tôi có điều chỉnh nhẹ cấu hình và tokenizer. Vui lòng sử dụng thiết lập của chúng tôi để chạy các mô hình này.

## 4. Kết quả đánh giá

### Đánh giá DeepSeek-R1
 Đối với tất cả các mô hình của chúng tôi, độ dài sinh tối đa được đặt là 32.768 tokens. Đối với các bộ chuẩn yêu cầu sampling, chúng tôi sử dụng temperature $0.6$, top-p $0.95$ và sinh 64 đáp án mỗi truy vấn để ước lượng pass@1.
<div align="center">


| Phân loại | Bộ chuẩn (Chỉ số) | Claude-3.5-Sonnet-1022 | GPT-4o 0513 | DeepSeek V3 | OpenAI o1-mini | OpenAI o1-1217 | DeepSeek R1 |
|----------|-------------------|----------------------|------------|--------------|----------------|------------|--------------|
| | Kiến trúc | - | - | MoE | - | - | MoE |
| | # Tham số kích hoạt | - | - | 37B | - | - | 37B |
| | # Tham số tổng | - | - | 671B | - | - | 671B |
| Tiếng Anh | MMLU (Pass@1) | 88.3 | 87.2 | 88.5 | 85.2 | **91.8** | 90.8 |
| | MMLU-Redux (EM) | 88.9 | 88.0 | 89.1 | 86.7 | - | **92.9** |
| | MMLU-Pro (EM) | 78.0 | 72.6 | 75.9 | 80.3 | - | **84.0** |
| | DROP (3-shot F1) | 88.3 | 83.7 | 91.6 | 83.9 | 90.2 | **92.2** |
| | IF-Eval (Prompt Strict) | **86.5** | 84.3 | 86.1 | 84.8 | - | 83.3 |
| | GPQA-Diamond (Pass@1) | 65.0 | 49.9 | 59.1 | 60.0 | **75.7** | 71.5 |
| | SimpleQA (Correct) | 28.4 | 38.2 | 24.9 | 7.0 | **47.0** | 30.1 |
| | FRAMES (Acc.) | 72.5 | 80.5 | 73.3 | 76.9 | - | **82.5** |
| | AlpacaEval2.0 (LC-winrate) | 52.0 | 51.1 | 70.0 | 57.8 | - | **87.6** |
| | ArenaHard (GPT-4-1106) | 85.2 | 80.4 | 85.5 | 92.0 | - | **92.3** |
| Mã | LiveCodeBench (Pass@1-COT) | 33.8 | 34.2 | - | 53.8 | 63.4 | **65.9** |
| | Codeforces (Percentile) | 20.3 | 23.6 | 58.7 | 93.4 | **96.6** | 96.3 |
| | Codeforces (Rating) | 717 | 759 | 1134 | 1820 | **2061** | 2029 |
| | SWE Verified (Resolved) | **50.8** | 38.8 | 42.0 | 41.6 | 48.9 | 49.2 |
| | Aider-Polyglot (Acc.) | 45.3 | 16.0 | 49.6 | 32.9 | **61.7** | 53.3 |
| Toán | AIME 2024 (Pass@1) | 16.0 | 9.3 | 39.2 | 63.6 | 79.2 | **79.8** |
| | MATH-500 (Pass@1) | 78.3 | 74.6 | 90.2 | 90.0 | 96.4 | **97.3** |
| | CNMO 2024 (Pass@1) | 13.1 | 10.8 | 43.2 | 67.6 | - | **78.8** |
| Tiếng Trung | CLUEWSC (EM) | 85.4 | 87.9 | 90.9 | 89.9 | - | **92.8** |
| | C-Eval (EM) | 76.7 | 76.0 | 86.5 | 68.9 | - | **91.8** |
| | C-SimpleQA (Correct) | 55.4 | 58.7 | **68.0** | 40.3 | - | 63.7 |

</div>


### Đánh giá mô hình Distill


<div align="center">

| Mô hình                                    | AIME 2024 pass@1 | AIME 2024 cons@64 | MATH-500 pass@1 | GPQA Diamond pass@1 | LiveCodeBench pass@1 | CodeForces rating |
|------------------------------------------|------------------|-------------------|-----------------|----------------------|----------------------|-------------------|
| GPT-4o-0513                          | 9.3              | 13.4              | 74.6            | 49.9                 | 32.9                 | 759               |
| Claude-3.5-Sonnet-1022             | 16.0             | 26.7                 | 78.3            | 65.0                 | 38.9                 | 717               |
| o1-mini                              | 63.6             | 80.0              | 90.0            | 60.0                 | 53.8                 | **1820**          |
| QwQ-32B-Preview                              | 44.0             | 60.0                 | 90.6            | 54.5               | 41.9                 | 1316              |
| DeepSeek-R1-Distill-Qwen-1.5B       | 28.9             | 52.7              | 83.9            | 33.8                 | 16.9                 | 954               |
| DeepSeek-R1-Distill-Qwen-7B          | 55.5             | 83.3              | 92.8            | 49.1                 | 37.6                 | 1189              |
| DeepSeek-R1-Distill-Qwen-14B         | 69.7             | 80.0              | 93.9            | 59.1                 | 53.1                 | 1481              |
| DeepSeek-R1-Distill-Qwen-32B        | **72.6**         | 83.3              | 94.3            | 62.1                 | 57.2                 | 1691              |
| DeepSeek-R1-Distill-Llama-8B         | 50.4             | 80.0              | 89.1            | 49.0                 | 39.6                 | 1205              |
| DeepSeek-R1-Distill-Llama-70B        | 70.0             | **86.7**          | **94.5**        | **65.2**             | **57.5**             | 1633              |

</div>


## 5. Trang web trò chuyện & Nền tảng API
Bạn có thể trò chuyện với DeepSeek-R1 tại trang web chính thức của DeepSeek: [chat.deepseek.com](https://chat.deepseek.com), và bật nút "DeepThink"

Chúng tôi cũng cung cấp API tương thích OpenAI tại DeepSeek Platform: [platform.deepseek.com](https://platform.deepseek.com/)

## 6. Hướng dẫn chạy cục bộ

### Các mô hình DeepSeek-R1

Vui lòng truy cập kho [DeepSeek-V3](https://github.com/deepseek-ai/DeepSeek-V3) để biết thêm thông tin về cách chạy DeepSeek-R1 cục bộ.

**LƯU Ý: Transformers của Hugging Face hiện chưa được hỗ trợ trực tiếp.**

### Các mô hình DeepSeek-R1-Distill

Các mô hình DeepSeek-R1-Distill có thể sử dụng tương tự như các mô hình Qwen hoặc Llama.

Ví dụ, bạn có thể dễ dàng khởi động dịch vụ bằng [vLLM](https://github.com/vllm-project/vllm):

```shell
vllm serve deepseek-ai/DeepSeek-R1-Distill-Qwen-32B --tensor-parallel-size 2 --max-model-len 32768 --enforce-eager
```

Bạn cũng có thể dễ dàng khởi động dịch vụ bằng [SGLang](https://github.com/sgl-project/sglang)

```bash
python3 -m sglang.launch_server --model deepseek-ai/DeepSeek-R1-Distill-Qwen-32B --trust-remote-code --tp 2
```

### Khuyến nghị sử dụng

**Chúng tôi khuyến nghị tuân theo các cấu hình sau khi sử dụng dòng mô hình DeepSeek-R1, bao gồm cả đánh giá, để đạt được hiệu suất kỳ vọng:**

1. Đặt temperature trong khoảng 0.5-0.7 (khuyến nghị 0.6) để tránh lặp vô tận hoặc sinh đầu ra không nhất quán.
2. **Tránh thêm system prompt; tất cả hướng dẫn nên nằm trong prompt của người dùng.**
3. Đối với các bài toán toán học, nên bổ sung chỉ dẫn trong prompt như: "Vui lòng suy luận từng bước và đặt đáp án cuối cùng trong \boxed{}."
4. Khi đánh giá hiệu suất mô hình, nên thực hiện nhiều lần và lấy trung bình kết quả.

Bên cạnh đó, chúng tôi nhận thấy các mô hình dòng DeepSeek-R1 có xu hướng bỏ qua mẫu suy nghĩ (tức là xuất ra "\<think\>\n\n\</think\>") khi trả lời một số truy vấn, điều này có thể ảnh hưởng tiêu cực đến hiệu suất mô hình.
**Để đảm bảo mô hình thực hiện suy luận kỹ lưỡng, chúng tôi khuyến nghị bắt buộc mô hình bắt đầu phản hồi với "\<think\>\n" ở đầu mỗi đầu ra.**

### Prompt chính thức
Trên web/app chính thức của DeepSeek, chúng tôi không sử dụng system prompt mà thiết kế hai prompt riêng biệt cho tải tệp và tìm kiếm web nhằm nâng cao trải nghiệm người dùng. Ngoài ra, temperature trên web/app là 0.6. 

Đối với tải tệp, vui lòng làm theo mẫu để tạo prompt, trong đó {file_name}, {file_content} và {question} là các tham số.
```
file_template = \
"""[file name]: {file_name}
[file content begin]
{file_content}
[file content end]
{question}"""
```

Đối với tìm kiếm web, {search_results}, {cur_date}, và {question} là các tham số. 

Đối với truy vấn tiếng Trung, chúng tôi sử dụng prompt:
```
search_answer_zh_template = \
'''# 以下内容是基于用户发送的消息的搜索结果:
{search_results}
在我给你的搜索结果中，每个结果都是[webpage X begin]...[webpage X end]格式的，X代表每篇文章的数字索引。请在适当的情况下在句子末尾引用上下文。请按照引用编号[citation:X]的格式在答案中对应部分引用上下文。如果一句话源自多个上下文，请列出所有相关的引用编号，例如[citation:3][citation:5]，切记不要将引用集中在最后返回引用编号，而是在答案对应部分列出。
在回答时，请注意以下几点：
- 今天是{cur_date}。
- 并非搜索结果的所有内容都与用户的问题密切相关，你需要结合问题，对搜索结果进行甄别、筛选。
- 对于列举类的问题（如列举所有航班信息），尽量将答案控制在10个要点以内，并告诉用户可以查看搜索来源、获得完整信息。优先提供信息完整、最相关的列举项；如非必要，不要主动告诉用户搜索结果未提供的内容。
- 对于创作类的问题（如写论文），请务必在正文的段落中引用对应的参考编号，例如[citation:3][citation:5]，不能只在文章末尾引用。你需要解读并概括用户的题目要求，选择合适的格式，充分利用搜索结果并抽取重要信息，生成符合用户要求、极具思想深度、富有创造力与专业性的答案。你的创作篇幅需要尽可能延长，对于每一个要点的论述要推测用户的意图，给出尽可能多角度的回答要点，且务必信息量大、论述详尽。
- 如果回答很长，请尽量结构化、分段落总结。如果需要分点作答，尽量控制在5个点以内，并合并相关的内容。
- 对于客观类的问答，如果问题的答案非常简短，可以适当补充一到两句相关信息，以丰富内容。
- 你需要根据用户要求和回答内容选择合适、美观的回答格式，确保可读性强。
- 你的回答应该综合多个相关网页来回答，不能重复引用一个网页。
- 除非用户要求，否则你回答的语言需要和用户提问的语言保持一致。

# 用户消息为：
{question}'''
```


Đối với truy vấn tiếng Anh, chúng tôi sử dụng prompt:
```
search_answer_en_template = \
'''# The following contents are the search results related to the user's message:
{search_results}
In the search results I provide to you, each result is formatted as [webpage X begin]...[webpage X end], where X represents the numerical index of each article. Please cite the context at the end of the relevant sentence when appropriate. Use the citation format [citation:X] in the corresponding part of your answer. If a sentence is derived from multiple contexts, list all relevant citation numbers, such as [citation:3][citation:5]. Be sure not to cluster all citations at the end; instead, include them in the corresponding parts of the answer.
When responding, please keep the following points in mind:
- Today is {cur_date}.
- Not all content in the search results is closely related to the user's question. You need to evaluate and filter the search results based on the question.
- For listing-type questions (e.g., listing all flight information), try to limit the answer to 10 key points and inform the user that they can refer to the search sources for complete information. Prioritize providing the most complete and relevant items in the list. Avoid mentioning content not provided in the search results unless necessary.
- For creative tasks (e.g., writing an essay), ensure that references are cited within the body of the text, such as [citation:3][citation:5], rather than only at the end of the text. You need to interpret and summarize the user's requirements, choose an appropriate format, fully utilize the search results, extract key information, and generate an answer that is insightful, creative, and professional. Extend the length of your response as much as possible, addressing each point in detail and from multiple perspectives, ensuring the content is rich and thorough.
- If the response is lengthy, structure it well and summarize it in paragraphs. If a point-by-point format is needed, try to limit it to 5 points and merge related content.
- For objective Q&A, if the answer is very brief, you may add one or two related sentences to enrich the content.
- Choose an appropriate and visually appealing format for your response based on the user's requirements and the content of the answer, ensuring strong readability.
- Your answer should synthesize information from multiple relevant webpages and avoid repeatedly citing the same webpage.
- Unless the user requests otherwise, your response should be in the same language as the user's question.

# The user's message is:
{question}'''
```

## 7. Giấy phép
Kho mã nguồn và trọng số mô hình này được cấp phép theo [MIT License](https://github.com/deepseek-ai/DeepSeek-R1/blob/main/LICENSE).
Dòng mô hình DeepSeek-R1 hỗ trợ sử dụng thương mại, cho phép sửa đổi và tạo sản phẩm phái sinh, bao gồm nhưng không giới hạn ở việc distillation để huấn luyện các LLM khác. Lưu ý rằng:
- DeepSeek-R1-Distill-Qwen-1.5B, DeepSeek-R1-Distill-Qwen-7B, DeepSeek-R1-Distill-Qwen-14B và DeepSeek-R1-Distill-Qwen-32B được phát triển từ [dòng Qwen-2.5](https://github.com/QwenLM/Qwen2.5), vốn được cấp phép gốc theo [Apache 2.0 License](https://huggingface.co/Qwen/Qwen2.5-1.5B/blob/main/LICENSE), và hiện đã được tinh chỉnh với 800k mẫu do DeepSeek-R1 tổng hợp.
- DeepSeek-R1-Distill-Llama-8B được phát triển từ Llama3.1-8B-Base và được cấp phép gốc theo [Llama3.1 license](https://huggingface.co/meta-llama/Llama-3.1-8B/blob/main/LICENSE).
- DeepSeek-R1-Distill-Llama-70B được phát triển từ Llama3.3-70B-Instruct và được cấp phép gốc theo [Llama3.3 license](https://huggingface.co/meta-llama/Llama-3.3-70B-Instruct/blob/main/LICENSE).

## 8. Trích dẫn
```bibtex
@misc{deepseekai2025deepseekr1incentivizingreasoningcapability,
      title={DeepSeek-R1: Incentivizing Reasoning Capability in LLMs via Reinforcement Learning}, 
      author={DeepSeek-AI},
      year={2025},
      eprint={2501.12948},
      archivePrefix={arXiv},
      primaryClass={cs.CL},
      url={https://arxiv.org/abs/2501.12948}, 
}
```

## 9. Liên hệ
Nếu bạn có bất kỳ câu hỏi nào, vui lòng gửi issue hoặc liên hệ với chúng tôi tại [service@deepseek.com](mailto:service@deepseek.com).

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---