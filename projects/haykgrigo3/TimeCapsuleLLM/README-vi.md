<div align="right">
  <details>
<summary>🌐 Ngôn ngữ</summary>

[English](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=en) | [简体中文](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN) | [繁體中文](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-TW) | [日本語](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja) | [한국어](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko) | [हिन्दी](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=hi) | [ไทย](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=th) | [Français](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fr) | [Deutsch](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=de) | [Español](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=es) | [Italiano](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=it) | [Русский](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ru) | [Português](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pt) | [Nederlands](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=nl) | [Polski](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pl) | [العربية](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ar) | [فارسی](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fa) | [Türkçe](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=tr) | [Tiếng Việt](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=vi) | [Bahasa Indonesia](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=id) | [অসমীয়া](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=as)
</details>
</div>


# TimeCapsule LLM

*Một mô hình ngôn ngữ được huấn luyện **từ đầu** chỉ trên dữ liệu từ các địa điểm và giai đoạn thời gian nhất định để giảm thiên vị hiện đại và mô phỏng lại giọng nói, từ vựng và thế giới quan của thời đại đó.*

Hãy tưởng tượng nếu một mô hình AI không chỉ giả vờ là lịch sử mà thực sự là như vậy.

v0 và v0.5 được xây dựng dựa trên [nanoGPT của Andrej Karpathy](https://github.com/karpathy/nanoGPT) Các tập lệnh huấn luyện cốt lõi và kiến trúc mô hình là công trình của ông.

v1 được xây dựng dựa trên [Phi 1.5 của Microsoft](https://huggingface.co/microsoft/phi-1_5)

v2 được xây dựng dựa trên llamaforcausallm

[Liên kết Hugging Face](https://huggingface.co/collections/haykgrigorian/timecapsulellm-1800-1875-london)

## Tình trạng nghiên cứu
Dự án này được khởi xướng và phát triển độc lập.

Hiện tại đang được tiến hành dưới sự giám sát học thuật, với sự hợp tác nghiên cứu liên kết tại Muhlenberg College.

## Trích dẫn

Nếu bạn sử dụng bộ dữ liệu hoặc mô hình này trong các công trình học thuật, xin hãy trích dẫn:


```bibtex
@misc{london_llm_1800,
  author = {Grigorian, Hayk and Yaghoobian, Hamed},
  title = {Historic London English (1800–1875)},
  year = {2025},
  publisher = {Hugging Face},
  howpublished = {\url{https://huggingface.co/datasets/postgrammar/london-llm-1800}}
}
```

##  Hành Vi & Giới Hạn Của Mô Hình

### **v0**  

Các prompt ban đầu cho thấy mô hình phản hồi bằng ngôn ngữ và hành vi của những năm 1800. 
Ví dụ: Prompt: "Who art Henry?" và nó trả lời "I know that man, I have did not a black, the storm." 

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- Không đề cập tới khái niệm hiện đại  
- Chủ yếu sử dụng từ vựng chính xác của thời kỳ  
- Câu văn phần lớn không mạch lạc (điều này được dự đoán với dữ liệu huấn luyện ~187MB)

### **v0.5** 

Cải thiện rõ rệt so với v0.  
- Văn phong thời Victoria, dấu câu đúng, câu phần lớn đúng ngữ pháp  
- Tỷ lệ bịa đặt thông tin vẫn cao  
- Nhiễu OCR (“Digitized by Google”) vẫn còn trong đầu ra

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1**

Mô hình đầu tiên nhớ và liên kết một sự kiện lịch sử thực với một nhân vật thực trong bộ dữ liệu.

Ví dụ: Prompt: "It was the year of our Lord 1834" 

Kết quả: "It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity" 

Lúc đầu tôi cho rằng một cuộc biểu tình có thể tình cờ diễn ra cùng năm nhưng hãy xem điều này: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### **v2mini-eval1**

Huấn luyện bằng mẫu 15GB từ bộ dữ liệu 90GB của v2.
Mô hình chỉ được huấn luyện đến 10K bước.

Có một vấn đề với tokenization khiến đầu ra trông như thế này:

Charles Dickens là ai?



W ho is Charles D ic ens ? D oes that work more of h ise x cell ent st ir ring , in his pl ays , int he G reat C omp any 's f arm ? What I have y et to qu ote from J ack P ick ett ? D oy oun ot know th att hey were as pe cies of g all oping , ors aw ing oft heir bre asts , or what w ast ob ed one about the t im ew hen J acks on was looking ont hew ind ow ? What ist hes uccess of an English man , and which h isson has not be end is cover ing t ome , where by to acc omp lish such a we ight ? D idy ou ever m ake ap ass age int othe old road way , ort o an anch or - b ree ze att he foot of our boat , which you m ust le ave us ? The fact is , that whe ther the wind would rise up from the pl ain on S atur day night orn o ont ide , ort ill then orth , or other wise , wes hall be com pelled t od esc ribe af orm idable bar rier , with t hes ame e ffect s ast he p resent . In th iss itu ation , at le ast , itis not to omuch t os ay that we have le ft that room . I bel ieve there are three c op ies int he " F ive H undred - fold ," to bere fer red to , ast he first n umber of our read ers wh ow is ht

Đã chỉnh sửa:

"Charles Dickens là ai? Tác phẩm đó có mang nhiều nét tuyệt vời lay động trong các vở kịch của ông, tại nông trại của Đại Công Ty không? Tôi còn phải trích dẫn gì từ Jack Pickett? Bạn không biết rằng họ là một loài phi nước đại, hay vỗ ngực họ, hoặc phải làm gì vào lúc Jackson đang nhìn qua cửa sổ? Thành công của một người Anh là gì, và mà con trai ông ấy chưa khám phá cho tôi, để thực hiện một trọng lượng như vậy? Bạn đã từng đi qua con đường cũ, hoặc đến một làn gió neo ở chân thuyền của chúng tôi, nơi bạn phải rời bỏ chúng tôi? Thực tế là, dù gió có nổi lên từ đồng bằng vào tối thứ Bảy hay giữa trưa, hoặc đến phía bắc, hoặc cách khác, chúng ta sẽ buộc phải mô tả một rào cản đáng sợ, với những hiệu ứng giống như hiện tại. Trong hoàn cảnh này, ít nhất, không quá lời khi nói rằng chúng ta đã rời khỏi căn phòng đó. Tôi tin rằng có ba bản sao trong 'Năm Trăm Lần,' để tham khảo, là số đầu tiên của độc giả chúng ta muốn t[...]..."

### **v2mini-eval2**

Được huấn luyện bằng mẫu 15GB giống như đã dùng để huấn luyện eval1.
Mô hình lại được huấn luyện chỉ đến 10K bước.

PROMPT: Charles Darwin

Charles DarwinECCEMACY. Thưa ngài, — Trường hợp sau đây rất thú vị đối với tôi: — Tôi ở London hai tuần, và bị ảnh hưởng khá nhiều bởi một cơn đau thấp khớp. Đợt đau thấp khớp đầu tiên xảy ra một tuần trước khi tôi gặp ngài, đợt thứ hai khi tôi gặp ngài, đợt thứ ba cũng khi tôi gặp ngài, và đợt thứ ba trong cùng thời điểm. Tuy nhiên, đợt đau gout thứ hai không kèm triệu chứng sốt, nhưng lại có lượng nước tiểu tăng lên và có sự bài tiết nước tiểu nhiều hơn. Đợt thứ ba xảy ra một giờ sau khi tôi gặp ngài, và tiếp theo là một đợt tái phát cơn gout, và cơn gout trở lại nhanh hơn. Đợt thứ tư cũng kèm theo sốt, nhưng không phải lúc nào cũng có triệu chứng sốt. Đợt đau gout thứ ba xảy ra hai tuần sau khi ngài bị bệnh, và đợt thứ tư là sau một đợt tái phát gout. Đợt thứ tư xảy ra hai tuần sau khi ngài bị tấn công, và kèm theo cảm giác

### **v2**

Được huấn luyện bằng bộ dữ liệu 90GB (112GB đã mã hóa)
Huấn luyện đến 182K bước

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output1.png)

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output2.png)

##  Bộ Dữ liệu

### **v2**

- 90GB (thô) các văn bản London giai đoạn 1800-1875
- 136.344 tài liệu
- Bộ dữ liệu đã mã hóa đầy đủ hiện đã có tại: https://huggingface.co/datasets/postgrammar/london-llm-1800

 ### Thống kê Định kiến
  ![Định kiến đại từ](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/pronoun_bias.png)

  ![Định kiến địa lý](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/geographic_bias.png)

  ![Định kiến thời gian](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/temporal_bias.png)

Tham khảo [báo cáo định kiến v2](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/v2_bias_report.json) để biết thêm thông tin.

## Hướng Dẫn Sử Dụng

Dự án này chủ yếu tập trung vào việc tuyển chọn dữ liệu lịch sử, chuẩn bị dữ liệu cho huấn luyện và xây dựng một tokenizer. Tôi sẽ không đề cập đến toàn bộ quy trình huấn luyện LLM, để biết chi tiết hãy tham khảo nanoGPT của Andrej Karpathy.

### Bước 1: Thu Thập và Chuẩn Bị Văn Bản Lịch Sử

- Thu thập các file .txt của sách, tài liệu, v.v. thuộc phạm vi công cộng từ giai đoạn bạn chọn (ví dụ: London 1800-1850) 
- Đảm bảo chúng nằm trong khung thời gian/địa điểm bạn chọn  
- Làm sạch các file văn bản bằng script hoặc thủ công loại bỏ đầu/cuối từ Project Gutenberg, chú thích hiện đại hoặc các lỗi như nhận dạng ký tự quang học (OCR).

### Bước 2: Xây Dựng Tokenizer Tùy Chỉnh

- Chạy train_tokenizer.py hoặc train_tokenizer_hf.py trên dữ liệu đã làm sạch.
- Kết quả bạn sẽ có vocab.json và merges.txt
- Các file này định nghĩa từ vựng và quy tắc trộn cho mô hình của bạn

### Bước 3: Huấn Luyện Mô Hình Của Bạn

- Tham khảo [nanoGPT của Andrej Karpathy](https://github.com/karpathy/nanoGPT) để biết quy trình huấn luyện hoặc tài liệu của kiến trúc bạn chọn.

# Câu Hỏi Thường Gặp

## Selective Temporal Training là gì?

Selective Temporal Training (STT) là một phương pháp học máy, trong đó tất cả dữ liệu huấn luyện đều được tuyển chọn để nằm trong một giai đoạn lịch sử cụ thể. Việc này nhằm mô phỏng ngôn ngữ và tri thức của thời kỳ đó mà không bị ảnh hưởng bởi các khái niệm hiện đại. Ví dụ, mô hình hiện tại tôi có (v0.5) được huấn luyện hoàn toàn từ dữ liệu giai đoạn 1800-1875, không phải tinh chỉnh mà huấn luyện từ đầu nên kết quả phản ánh phong cách ngôn ngữ và bối cảnh lịch sử của thời kỳ đó.

## Tại sao không chỉ dùng fine-tuning hoặc LoRA?

Trong dự án này tôi muốn tạo ra một mô hình ngôn ngữ không bị ảnh hưởng bởi thành kiến hiện đại. Nếu tôi fine-tune một mô hình như GPT-2, nó đã được huấn luyện trước và thông tin đó sẽ không mất đi. Nếu tôi huấn luyện từ đầu thì mô hình ngôn ngữ sẽ không “giả vờ” là cổ, mà thực sự như vậy. Mục tiêu hiện tại của dự án là tạo ra một thứ có thể suy luận chỉ dựa trên tri thức từ sách London xuất bản giai đoạn 1800 đến 1875.

## Bạn đã sử dụng loại dữ liệu nào để huấn luyện?

Tôi sử dụng sách, tài liệu pháp lý, báo chí và các văn bản khác từ London giai đoạn 1800–1875. Danh sách tôi liên kết (cho v0) có khoảng 200 tài liệu nhưng lần đầu huấn luyện tôi chỉ dùng 50 file khoảng ~187 MB. Bạn có thể xem danh sách tài liệu tại:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

Kích thước bộ dữ liệu:
- v0: ~187MB
- v0.5: ~435MB 
- v1: ~6.25GB 

- v2mini-eval1: 15GB(mẫu từ 90GB của v2)
- v2: 90GB

## Kích thước mô hình là bao nhiêu?

v0: 16M Tham số

v0.5: 123M Tham số

v1: 700M Tham số

v2mini-eval1: 300M Tham số

v2mini-eval2: 200M Tham số

v2: 1.2B Tham số

## Thông số huấn luyện?

### v0/v0.5
GPU: Geforce rtx 4060
CPU: i5-13400F 
Ram: 16GB DDR5.

### v1
GPU: A100 SXM thuê

### v2mini-eval1/eval2
GPU: A100 SXM thuê

### v2
GPU: H100 SXM thuê

## Lời cảm ơn

Tôi xin cảm ơn [TS. Hamed Yaghoobian](https://hamedyaghoobian.com) vì đã hướng dẫn học thuật, chỉ dẫn về khung nghiên cứu và đánh giá, cũng như hỗ trợ huấn luyện tokenizer và chuẩn bị bộ dữ liệu cho bản phát hành v2. Phản hồi và kinh nghiệm của ông rất quan trọng trong việc hoàn thiện cách trình bày công trình này.










































---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-03

---