
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

v1 được xây dựng trên [Phi 1.5 của Microsoft](https://huggingface.co/microsoft/phi-1_5)

##  Hành vi & Giới hạn của Mô hình

### **v0**  

Những lời nhắc ban đầu cho thấy mô hình phản hồi với ngôn ngữ và hành vi của những năm 1800.  
Ví dụ: Lời nhắc: "Who art Henry?" và nó trả lời "I know that man, I have did not a black, the storm." 

![TimeLockLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- Không đề cập đến các khái niệm hiện đại  
- Chủ yếu sử dụng từ vựng phù hợp với thời kỳ  
- Câu trả lời phần lớn không rõ ràng (dự kiến với dữ liệu huấn luyện ~187MB)

### **v0.5** 

Cải thiện đáng kể so với v0.  
- Phong cách viết kiểu Victorian, dấu câu đầy đủ, câu phần lớn ngữ pháp đúng  
- Tỉ lệ ảo giác thực tế vẫn cao  
- Nhiễu OCR (“Digitized by Google”) vẫn xuất hiện trong đầu ra

![TimeLockLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1**

Mô hình đầu tiên có khả năng nhớ và liên kết sự kiện lịch sử thực với nhân vật thực từ bộ dữ liệu.

Ví dụ: Lời nhắc: "It was the year of our Lord 1834" 

Đầu ra: "It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity" 

Ban đầu tôi nghĩ rằng một cuộc biểu tình có thể tình cờ diễn ra cùng năm nhưng hãy xem điều này: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### Tại sao điều này quan trọng:

Đây là ví dụ đầu tiên về một trong các mô hình của tôi kết nối một năm với cả một sự kiện lịch sử thực và một người thực gắn với sự kiện đó (Lord Palmerston). Các mô hình trước đó (v0 và v0.5) chỉ có thể bắt chước phong cách viết thế kỷ 19 nhưng luôn ảo giác về sự kiện, con người và dữ kiện. Điều này cho thấy mô hình đã bắt đầu ghi nhớ thông tin từ bộ dữ liệu

## Kế hoạch sắp tới


- Có gần 175.000 văn bản được xuất bản tại London từ năm 1800-1875 trên Internet Archive
- Tôi dự định sẽ mở rộng kho ngữ liệu và làm sạch hơn nữa để cải thiện khả năng suy luận
- Mở rộng sang các khu vực và thời kỳ khác để xây dựng các mô hình lịch sử đa dạng hơn


## Cách sử dụng

Dự án này chủ yếu tập trung vào việc thu thập dữ liệu lịch sử, chuẩn bị dữ liệu để huấn luyện và xây dựng bộ tách từ. Tôi sẽ không trình bày toàn bộ quy trình huấn luyện LLM, để biết thêm hãy tham khảo nanoGPT của Andrej Karpathy.

### Bước 1: Thu thập và Chuẩn bị Văn bản Lịch sử

- Thu thập các tệp .txt của sách, tài liệu, v.v. thuộc phạm vi công cộng từ thời kỳ bạn chọn (ví dụ: London 1800-1850)
- Giữ văn bản trong khung thời gian/địa điểm bạn chọn
- Làm sạch các tệp văn bản bằng script hoặc tự xóa header/footer từ Project Gutenberg, chú thích hiện đại hoặc các lỗi OCR.

### Bước 2: Xây dựng Bộ Tách Từ Tùy Chỉnh

- Chạy train_tokenizer.py hoặc train_tokenizer_hf.py trên dữ liệu đã làm sạch.
- Điều này sẽ tạo ra vocab.json và merges.txt
- Các tệp này xác định từ vựng và quy tắc ghép từ cho mô hình của bạn

### Bước 3: Huấn luyện Mô hình của Bạn

- Tham khảo [nanoGPT của Andrej Karpathy](https://github.com/karpathy/nanoGPT) cho quy trình huấn luyện hoặc tài liệu kiến trúc bạn chọn.

# FAQ

## Huấn luyện Thời gian Chọn lọc (Selective Temporal Training) là gì?

Huấn luyện Thời gian Chọn lọc (STT) là phương pháp học máy mà toàn bộ dữ liệu huấn luyện đều được chọn lọc cẩn thận nằm trong một giai đoạn lịch sử nhất định. Việc này nhằm mô phỏng ngôn ngữ và tri thức của thời kỳ đó mà không bị ảnh hưởng bởi các khái niệm hiện đại. Ví dụ, mô hình hiện tại của tôi (v0.5) được huấn luyện hoàn toàn từ dữ liệu giai đoạn 1800-1875, không tinh chỉnh mà huấn luyện từ đầu nên đầu ra phản ánh phong cách ngôn ngữ và bối cảnh lịch sử của thời kỳ đó.

## Tại sao không dùng fine-tuning hay LoRA?

Với dự án này tôi muốn tạo ra một mô hình ngôn ngữ không bị ảnh hưởng bởi định kiến hiện đại. Nếu tôi fine-tune GPT-2 chẳng hạn, nó đã được huấn luyện trước và thông tin đó không thể xóa bỏ hoàn toàn. Nếu huấn luyện từ đầu thì mô hình ngôn ngữ sẽ không giả vờ là cũ, mà thực sự là như vậy. Mục tiêu hiện tại là tạo ra mô hình có thể suy luận chỉ dựa trên tri thức từ sách London xuất bản giữa 1800 và 1875.

## Bạn dùng loại dữ liệu nào để huấn luyện?

Tôi sử dụng sách, văn bản pháp lý, báo chí và các tài liệu khác từ London giai đoạn 1800–1875. Danh sách tôi liên kết (cho v0) có khoảng 200 tài liệu nhưng cho lần huấn luyện đầu tiên tôi chỉ dùng 50 tệp dung lượng khoảng ~187 MB. Bạn có thể xem danh sách các tài liệu tại:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

Kích thước bộ dữ liệu:
v0: ~187MB
v0.5: ~435MB
v1: ~6.25GB

## Các mô hình lớn đến mức nào?

V0: 16 triệu tham số

V0.5: 123 triệu tham số

V1: 700 triệu tham số

# Thông số huấn luyện?

# V0/V0.5
GPU: Geforce rtx 4060
CPU: i5-13400F
Ram: 16GB DDR5.

# V1
GPU: A100 thuê














---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-19

---