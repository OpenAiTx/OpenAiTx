
<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN">简体中文</a>
        | <a href="#" title="Coming soon">繁體中文 (sắp ra mắt)</a> |
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko">한국어</a>
        | <a href="#" title="Coming soon">हिन्दी (sắp ra mắt)</a> |
        | <a href="#" title="Coming soon">ไทย (sắp ra mắt)</a> |
        | <a href="#" title="Coming soon">Français (sắp ra mắt)</a>
        | <a href="#" title="Coming soon">Deutsch (sắp ra mắt)</a>
        | <a href="#" title="Coming soon">Español (sắp ra mắt)</a>
        | <a href="#" title="Coming soon">Italiano (sắp ra mắt)</a>
        | <a href="#" title="Coming soon">Русский (sắp ra mắt)</a>
        | <a href="#" title="Coming soon">Português (sắp ra mắt)</a>
        | <a href="#" title="Coming soon">Nederlands (sắp ra mắt)</a>
        | <a href="#" title="Coming soon">Polski (sắp ra mắt)</a>
        | <a href="#" title="Coming soon">العربية (sắp ra mắt)</a>
        | <a href="#" title="Coming soon">فارسی (sắp ra mắt)</a>
        | <a href="#" title="Coming soon">Türkçe (sắp ra mắt)</a>
        | <a href="#" title="Coming soon">Tiếng Việt (sắp ra mắt)</a>
        | <a href="#" title="Coming soon">Bahasa Indonesia (sắp ra mắt)</a>

      </div>
    </div>
  </details>
</div>

# TimeCapsule LLM

*Một mô hình ngôn ngữ được huấn luyện **từ đầu** hoàn toàn dựa trên dữ liệu từ một số địa điểm và thời kỳ nhất định để giảm thiên kiến hiện đại và mô phỏng giọng nói, từ vựng, cũng như thế giới quan của thời đại đó.*

Hãy tưởng tượng nếu một mô hình AI không chỉ giả vờ là lịch sử mà thực sự là như vậy.

v0 và v0.5 được xây dựng trên [nanoGPT của Andrej Karpathy](https://github.com/karpathy/nanoGPT) Các tập lệnh huấn luyện cốt lõi và kiến trúc mô hình là của ông ấy.

v1 được xây dựng dựa trên [Phi 1.5 của Microsoft](https://huggingface.co/microsoft/phi-1_5)

[Liên kết Hugging Face](https://huggingface.co/haykgrigorian/TimeCapsuleLLM)

##  Hành vi & Giới hạn của Mô hình

### **v0**  

Các prompt ban đầu cho thấy mô hình phản hồi với ngôn ngữ và hành vi của thập niên 1800. 
Ví dụ: Prompt: "Who art Henry?" và nó trả lời "I know that man, I have did not a black, the storm." 

![Đầu ra mẫu của TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- Không đề cập đến các khái niệm hiện đại  
- Chủ yếu sử dụng từ vựng phù hợp với thời kỳ  
- Câu văn phần lớn không mạch lạc (điều này được dự đoán với dữ liệu huấn luyện ~187MB)

### **v0.5** 

Cải tiến đáng kể so với v0.  
- Phong cách viết thời Victoria, chấm câu đúng, câu văn phần lớn ngữ pháp chuẩn  
- Tỷ lệ xuất hiện thông tin sai thực tế vẫn cao  
- Nhiễu OCR (“Digitized by Google”) vẫn xuất hiện trong kết quả

![Đầu ra mẫu của TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1**

Là mô hình đầu tiên nhớ và liên kết một sự kiện lịch sử thực với một nhân vật thực trong bộ dữ liệu.

Ví dụ: Prompt: "It was the year of our Lord 1834" 

Kết quả đầu ra: "It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity" 

Ban đầu tôi nghĩ rằng một cuộc biểu tình có thể tình cờ diễn ra trong năm đó, nhưng hãy xem điều này: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### Tại sao điều này quan trọng:

Đây là ví dụ đầu tiên về một trong các mô hình của tôi liên kết một năm với cả một sự kiện lịch sử thực và một nhân vật thực gắn liền với sự kiện đó (Lord Palmerston). Các mô hình trước (v0 và v0.5) có thể bắt chước phong cách viết của thế kỷ 19 nhưng luôn tưởng tượng các sự kiện, con người và thông tin. Điều này cho thấy mô hình bắt đầu ghi nhớ những dữ liệu từ bộ dữ liệu.


## Kế hoạch sắp tới

- Có gần 175.000 văn bản được xuất bản tại London từ năm 1800-1875 trên Internet Archive
- Tôi dự định sẽ mở rộng tập dữ liệu và làm sạch nó hơn nữa để tăng khả năng suy luận
- Mở rộng sang các khu vực và thời kỳ khác nhau để xây dựng các mô hình lịch sử đa dạng hơn

## Cách sử dụng

Dự án này tập trung chủ yếu vào việc thu thập dữ liệu lịch sử, chuẩn bị cho huấn luyện và xây dựng bộ tokenizer. Tôi sẽ không đề cập đến toàn bộ quy trình huấn luyện LLM, để biết chi tiết hãy tham khảo nanoGPT của Andrej Karpathy.

### Bước 1: Thu thập và chuẩn bị văn bản lịch sử

- Thu thập các tệp .txt của sách, tài liệu, v.v. thuộc phạm vi công cộng từ thời kỳ bạn chọn (ví dụ: London 1800-1850)
- Giữ chúng trong khung thời gian/vị trí bạn chọn
- Làm sạch các tệp văn bản bằng script hoặc thủ công, loại bỏ tiêu đề/đầu trang/cuối trang của Project Gutenberg, chú thích hiện đại hoặc các lỗi OCR.

### Bước 2: Xây dựng bộ Tokenizer tùy chỉnh

- Chạy train_tokenizer.py hoặc train_tokenizer_hf.py trên dữ liệu đã làm sạch.
- Điều này sẽ tạo ra vocab.json và merges.txt
- Các tệp này xác định từ vựng và quy tắc kết hợp cho mô hình của bạn

### Bước 3: Huấn luyện mô hình

- Tham khảo [nanoGPT của Andrej Karpathy](https://github.com/karpathy/nanoGPT) về quy trình huấn luyện hoặc tài liệu kiến trúc bạn chọn.

# FAQ

## Huấn luyện theo thời kỳ chọn lọc là gì?

Huấn luyện theo thời kỳ chọn lọc (Selective Temporal Training - STT) là phương pháp học máy mà tất cả dữ liệu huấn luyện được chọn lọc kỹ càng để nằm trong một khoảng thời gian lịch sử xác định. Điều này nhằm mô phỏng ngôn ngữ và tri thức của thời kỳ đó mà không bị ảnh hưởng bởi các khái niệm hiện đại. Ví dụ, mô hình hiện tại tôi đang có (v0.5) được huấn luyện trên dữ liệu chỉ từ 1800-1875, không phải fine-tune mà huấn luyện từ đầu nên đầu ra phản ánh đúng phong cách ngôn ngữ và bối cảnh lịch sử của thời kỳ đó.

## Tại sao không chỉ dùng fine-tuning hoặc LoRA?

Đối với dự án này, tôi muốn tạo ra mô hình ngôn ngữ không bị ảnh hưởng bởi thành kiến hiện đại. Nếu tôi fine-tune một mô hình như GPT-2, nó đã được huấn luyện trước và thông tin đó sẽ không biến mất. Nếu huấn luyện từ đầu, mô hình ngôn ngữ sẽ không giả vờ là cổ mà thực sự cổ. Mục tiêu hiện tại là tạo ra thứ có thể suy luận hoàn toàn dựa trên kiến thức từ sách London xuất bản giai đoạn 1800-1875.

## Bạn đã dùng dữ liệu gì để huấn luyện?


Tôi đang sử dụng sách, tài liệu pháp lý, báo chí và các bản viết khác từ London giai đoạn 1800–1875. Danh sách tôi đã liên kết (cho v0) có khoảng 200 tài liệu, nhưng cho lần huấn luyện đầu tiên tôi chỉ dùng 50 tệp khoảng ~187 MB. Bạn có thể xem danh sách các tài liệu tại:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

Kích thước bộ dữ liệu:
v0: ~187MB
v0.5: ~435MB 
v1: ~6.25GB 

## Các mô hình có kích thước bao nhiêu ?

V0: 16 triệu tham số

V0.5: 123 triệu tham số

V1: 700 triệu tham số

# Thông số huấn luyện ? 

# V0/V0.5
GPU: Geforce rtx 4060
CPU: i5-13400F 
Ram: 16GB DDR5.

# V1
GPU: A100 thuê ngoài

















---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-30

---