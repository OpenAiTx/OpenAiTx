<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-TW">繁體中文</a> 
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=as">हिन्दी</a> 
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=th">ไทย</a> 
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=es">Español</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ar">العربية</a>
        | <a href="#" title="Coming soon">فارسی (coming soon)</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=vi">Tiếng Việt</a>
        | <a href="#" title="Coming soon">Bahasa Indonesia (coming soon)</a>

      </div>
    </div>
  </details>
</div>


# TimeCapsule LLM

*Một mô hình ngôn ngữ được huấn luyện **từ đầu** chỉ dựa trên dữ liệu từ những địa điểm và thời kỳ nhất định nhằm giảm thiên vị hiện đại và mô phỏng giọng điệu, từ vựng, cũng như thế giới quan của thời đại đó.*

Hãy tưởng tượng nếu một mô hình AI không chỉ giả vờ là lịch sử mà thực sự là như vậy.

v0 và v0.5 được xây dựng dựa trên [nanoGPT của Andrej Karpathy](https://github.com/karpathy/nanoGPT) Các tập lệnh huấn luyện cốt lõi và kiến trúc mô hình là công trình của ông ấy. 

v1 được xây dựng trên [Phi 1.5 của Microsoft](https://huggingface.co/microsoft/phi-1_5)

[Liên kết Hugging Face](https://huggingface.co/haykgrigorian/TimeCapsuleLLM)

##  Hành Vi & Hạn Chế của Mô Hình

### **v0**  

Những prompt ban đầu cho thấy mô hình phản hồi với ngôn ngữ và cách hành xử của thế kỷ 19. 
Ví dụ: Prompt: "Who art Henry?" và nó trả lời "I know that man, I have did not a black, the storm." 

![Kết quả mẫu của TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- Không đề cập đến các khái niệm hiện đại  
- Chủ yếu sử dụng từ vựng đúng với thời kỳ  
- Câu văn phần lớn không mạch lạc (điều này được mong đợi với dữ liệu huấn luyện ~187MB)

### **v0.5** 

Cải tiến đáng kể so với v0.  
- Phong cách viết thời Victoria, dấu câu đầy đủ, câu văn phần lớn đúng ngữ pháp  
- Tỷ lệ ảo giác thông tin thực tế vẫn cao  
- Nhiễu OCR (“Digitized by Google”) vẫn xuất hiện trong kết quả đầu ra

![Kết quả mẫu của TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1**

Mô hình đầu tiên có thể nhớ và kết nối một sự kiện lịch sử thực với một nhân vật có thật trong bộ dữ liệu.

Ví dụ: Prompt: "It was the year of our Lord 1834" 

Kết quả: "It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity" 

Ban đầu tôi nghĩ rằng có thể một cuộc biểu tình đã diễn ra trùng hợp vào năm đó nhưng hãy xem điều này: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### **v2mini-eval1**

Huấn luyện bằng mẫu 15GB từ bộ dữ liệu 90GB của v2.

Mô hình chỉ được huấn luyện đến 10.000 bước.

Đã có vấn đề với quá trình mã hóa token khiến kết quả đầu ra trông như sau:

LỆNH:
Charles Dickens là ai?


W ho is Charles D ic ens ? D oes that work more of h ise x cell ent st ir ring , in his pl ays , int he G reat C omp any 's f arm ? What I have y et to qu ote from J ack P ick ett ? D oy oun ot know th att hey were as pe cies of g all oping , ors aw ing oft heir bre asts , or what w ast ob ed one about the t im ew hen J acks on was looking ont hew ind ow ? What ist hes uccess of an English man , and which h isson has not be end is cover ing t ome , where by to acc omp lish such a we ight ? D idy ou ever m ake ap ass age int othe old road way , ort o an anch or - b ree ze att he foot of our boat , which you m ust le ave us ? The fact is , that whe ther the wind would rise up from the pl ain on S atur day night orn o ont ide , ort ill then orth , or other wise , wes hall be com pelled t od esc ribe af orm idable bar rier , with t hes ame e ffect s ast he p resent . In th iss itu ation , at le ast , itis not to omuch t os ay that we have le ft that room . I bel ieve there are three c op ies int he " F ive H undred - fold ," to bere fer red to , ast he first n umber of our read ers wh ow is ht
Đã chỉnh sửa:

"Charles Dickens là ai? Liệu tác phẩm đó có phải là sự khuấy động xuất sắc hơn nữa của ông, trong các vở kịch của ông, tại nông trại của Công ty Lớn không? Tôi còn phải trích dẫn gì từ Jack Pickett? Bạn không biết rằng họ là một loài phi nước đại, hoặc cưa ngực họ, hoặc phải làm gì vào thời điểm Jackson đang nhìn qua cửa sổ? Thành công của một người Anh là gì, và điều mà con trai ông ta chưa phát hiện ra với tôi, qua đó thực hiện được một trọng lượng như vậy? Bạn đã bao giờ đi qua con đường cũ, hoặc tới một làn gió neo đậu ở chân thuyền của chúng tôi, nơi bạn phải rời chúng tôi chưa? Thực tế là, dù gió có nổi lên từ đồng bằng vào đêm thứ Bảy hay giữa trưa, hoặc đến từ phương bắc, hoặc khác đi, chúng tôi sẽ buộc phải mô tả một rào cản đáng gờm, với cùng những hiệu ứng như hiện tại. Trong tình huống này, ít nhất, không quá lời khi nói rằng chúng tôi đã rời khỏi căn phòng đó. Tôi tin rằng có ba bản sao trong 'Năm Trăm lần,' để tham khảo, như số đầu tiên của độc giả chúng tôi mong muốn t[o]..."

### **v2mini-eval2**

Được huấn luyện sử dụng cùng mẫu 15GB đã dùng để huấn luyện eval1.
Mô hình lại được huấn luyện tới 10K bước mà thôi.

PROMPT:Charles Darwin

Charles DarwinECCEMACY. Thưa ngài, — Trường hợp sau đây khiến tôi quan tâm : — Tôi đã ở London hai tuần, và bị ảnh hưởng nhiều bởi một cơn thấp khớp. Cơn thấp khớp đầu tiên xảy ra một tuần trước khi tôi gặp ngài, và cơn thứ hai khi tôi gặp ngài, và cơn thứ ba khi tôi gặp ngài, và cơn thứ ba trong cùng thời gian đó. Tuy nhiên, cơn gút thứ hai không kèm theo triệu chứng sốt nào, mà lại kèm theo lượng nước tiểu tăng, và lượng nước tiểu bài tiết nhiều hơn. Cơn thứ ba xuất hiện một giờ sau khi tôi gặp ngài, và tiếp sau đó là một đợt tái phát gút, và một lần trở lại nhanh hơn của bệnh gút. Cơn thứ tư cũng kèm theo sốt, nhưng không phải lúc nào cũng có triệu chứng sốt. Cơn gút thứ ba là hai tuần sau khi ngài bị bệnh, và cơn thứ tư tiếp theo một đợt tái phát gút. Cơn thứ tư là hai tuần sau khi ngài bị tấn công, và kèm theo cảm giác

##  Bộ dữ liệu

### **v2**

- 90GB văn bản London giai đoạn 1800-1875
- 136.344 tài liệu
- Toàn bộ 90GB hiện chưa có sẵn vì chưa được mã hóa, nhưng bạn có thể tìm một mẫu 15GB tại đây: https://huggingface.co/datasets/haykgrigorian/TimeCapsuleLLM-London-1800-1875-v2-15GB

 ### Thống kê thiên lệch 
  ![Thiên lệch đại từ nhân xưng](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/pronoun_bias.png)

  ![Thiên lệch địa lý](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/geographic_bias.png)

  ![Thiên lệch thời gian](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/temporal_bias.png)

Xem [báo cáo thiên lệch v2](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/v2_bias_report.json) để biết thêm thông tin.


## Hướng dẫn sử dụng

Dự án này tập trung chủ yếu vào việc thu thập dữ liệu lịch sử, chuẩn bị dữ liệu cho huấn luyện và xây dựng một bộ mã hóa từ vựng. Tôi sẽ không đề cập đến toàn bộ quy trình huấn luyện LLM, cho điều đó hãy tham khảo nanoGPT của Andrej Karpathy.

### Bước 1: Thu thập và chuẩn bị văn bản lịch sử 

- Thu thập các tệp .txt của sách, tài liệu miền công cộng, v.v. từ khoảng thời gian bạn chọn (ví dụ: London 1800-1850)


- Giữ chúng trong khung thời gian/địa điểm bạn đã chọn  
- Làm sạch các tệp văn bản bằng script hoặc thủ công loại bỏ tiêu đề/chân trang từ Project Gutenberg, chú thích hiện đại hoặc các lỗi như OCR.

### Bước 2: Xây dựng Bộ phân tách Token tùy chỉnh

- Chạy train_tokenizer.py hoặc train_tokenizer_hf.py trên dữ liệu đã được làm sạch.
- Điều này sẽ tạo ra vocab.json và merges.txt
- Các tệp này xác định từ vựng và quy tắc hợp nhất cho mô hình của bạn

### Bước 3: Huấn luyện Mô hình của bạn 

- Tham khảo [nanoGPT của Andrej Karpathy](https://github.com/karpathy/nanoGPT) cho quy trình huấn luyện hoặc tài liệu kiến trúc bạn chọn.

# Câu hỏi thường gặp

## Đào tạo theo thời kỳ chọn lọc là gì?

Đào tạo theo thời kỳ chọn lọc (Selective Temporal Training - STT) là một phương pháp học máy trong đó tất cả dữ liệu huấn luyện được chọn lọc để nằm trong một giai đoạn lịch sử cụ thể. Việc này được thực hiện để mô phỏng ngôn ngữ và tri thức của thời kỳ đó mà không bị ảnh hưởng bởi các khái niệm hiện đại. Ví dụ, mô hình hiện tại tôi có (v0.5) được huấn luyện độc quyền trên dữ liệu từ 1800-1875, không phải tinh chỉnh mà huấn luyện từ đầu nên cho ra kết quả phản ánh đúng phong cách ngôn ngữ và bối cảnh lịch sử của thời kỳ đó.

## Tại sao không chỉ dùng fine-tuning hoặc LoRA?

Với dự án này tôi muốn tạo ra một mô hình ngôn ngữ không bị ảnh hưởng bởi thành kiến hiện đại. Nếu tôi fine-tune thứ gì đó như GPT-2, nó đã được huấn luyện trước và thông tin đó sẽ không mất đi. Nếu tôi huấn luyện từ đầu, mô hình ngôn ngữ sẽ không giả vờ là cổ điển, mà thực sự sẽ là như vậy. Mục tiêu hiện tại là tạo ra một mô hình có thể suy luận hoàn toàn dựa trên kiến thức từ các sách London xuất bản giai đoạn 1800 đến 1875.

## Bạn đã dùng loại dữ liệu nào để huấn luyện?

Tôi sử dụng sách, tài liệu pháp lý, báo chí và các bài viết khác từ London giai đoạn 1800–1875. Danh sách tôi đã liên kết (cho v0) có khoảng 200 nhưng cho lần huấn luyện đầu tiên tôi chỉ dùng 50 tệp khoảng ~187 MB. Bạn có thể xem danh sách tài liệu tại:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

Kích thước bộ dữ liệu:
- v0: ~187MB
- v0.5: ~435MB 
- v1: ~6.25GB 
- v2mini-eval1: 15GB

## Kích thước các mô hình là bao nhiêu?

v0: 16 triệu tham số

v0.5: 123 triệu tham số

v1: 700M Parameters

v2mini-eval1: 300M Parameters

# Training Specs ? 

# v0/v0.5
GPU: Geforce rtx 4060
CPU: i5-13400F 
Ram: 16GB DDR5.

# v1
GPU: A100 SXM rented

# v2mini-eval1

GPU: A100 SXM rented





























---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-09

---