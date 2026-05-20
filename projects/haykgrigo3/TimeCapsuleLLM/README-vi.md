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
## Tham gia Discord Vintage LLM

Nếu bạn quan tâm đến **mô hình ngôn ngữ lịch sử**, **bộ dữ liệu theo thời gian**, hoặc tương lai của các dự án như **TimeCapsuleLLM**, **Violet-1.4B**, **Mr. Chatterbox** hãy tham gia cộng đồng cùng chúng tôi.

Chúng tôi sử dụng máy chủ để thảo luận ý tưởng, chia sẻ tiến trình và kết nối với những người khác đang xây dựng trong lĩnh vực này.

[Tham gia Discord](https://discord.gg/JeWkk4z5)

##  Hành vi & Giới hạn của Mô hình

### **v0**  

Những lời nhắc ban đầu cho thấy mô hình phản hồi bằng ngôn ngữ và hành vi của thế kỷ 19.
Ví dụ: Lời nhắc: "Who art Henry?" và mô hình trả lời "I know that man, I have did not a black, the storm."

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- Không đề cập đến các khái niệm hiện đại  
- Từ vựng chủ yếu đúng với thời kỳ  
- Câu chủ yếu không mạch lạc (dự kiến với dữ liệu huấn luyện ~187MB)

### **v0.5-london** 

Một cải tiến đáng kể so với v0.  
- Phong cách viết thời Victoria, dấu câu đúng, câu chủ yếu ngữ pháp chuẩn  
- Tỷ lệ ảo giác thực tế vẫn cao  
- Nhiễu OCR (“Digitized by Google”) vẫn xuất hiện trong kết quả

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1-london**

Mô hình đầu tiên nhớ và kết nối một sự kiện lịch sử thực với một nhân vật thực trong bộ dữ liệu.

Ví dụ: Lời nhắc: "It was the year of our Lord 1834" 

Kết quả: "It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity" 

Lúc đầu tôi nghĩ rằng một cuộc biểu tình có thể đã tình cờ xảy ra cùng năm đó nhưng hãy xem điều này: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)


### **v2mini-eval1-london**

Được huấn luyện bằng mẫu 15GB từ bộ dữ liệu 90GB của v2.
Mô hình chỉ được huấn luyện đến 10K bước.

Có một vấn đề với việc mã hóa token khiến đầu ra trông như thế này:

ĐỀ BÀI:
Charles Dickens là ai?


W ho is Charles D ic ens ? D oes that work more of h ise x cell ent st ir ring , in his pl ays , int he G reat C omp any 's f arm ? What I have y et to qu ote from J ack P ick ett ? D oy oun ot know th att hey were as pe cies of g all oping , ors aw ing oft heir bre asts , or what w ast ob ed one about the t im ew hen J acks on was looking ont hew ind ow ? What ist hes uccess of an English man , and which h isson has not be end is cover ing t ome , where by to acc omp lish such a we ight ? D idy ou ever m ake ap ass age int othe old road way , ort o an anch or - b ree ze att he foot of our boat , which you m ust le ave us ? The fact is , that whe ther the wind would rise up from the pl ain on S atur day night orn o ont ide , ort ill then orth , or other wise , wes hall be com pelled t od esc ribe af orm idable bar rier , with t hes ame e ffect s ast he p resent . In th iss itu ation , at le ast , itis not to omuch t os ay that we have le ft that room . I bel ieve there are three c op ies int he " F ive H undred - fold ," to bere fer red to , ast he first n umber of our read ers wh ow is ht

Đã chỉnh sửa:

"Charles Dickens là ai? Liệu tác phẩm của ông có nhiều sự khuấy động xuất sắc hơn trong các vở kịch, ở trang trại của Công ty Lớn không? Tôi còn phải trích dẫn gì từ Jack Pickett? Bạn không biết rằng họ thuộc một loài phi nước đại, hoặc cưa ngực, hoặc những gì sẽ phải làm vào lúc Jackson đang nhìn ra cửa sổ? Thành công của một người Anh là gì, và điều mà con trai ông ấy vẫn chưa khám phá ra với tôi, để thực hiện một trọng trách như vậy? Bạn đã từng đi qua con đường cũ, hoặc đến một làn gió neo ở chân thuyền của chúng tôi, nơi bạn phải rời bỏ chúng tôi chưa? Thực tế là, dù gió có nổi lên từ đồng bằng vào tối thứ Bảy hoặc giữa trưa, hoặc đến phía bắc, hoặc cách khác, chúng ta sẽ buộc phải mô tả một rào cản đáng gờm, với những hiệu ứng giống như hiện tại. Trong tình huống này, ít nhất cũng không quá lời khi nói rằng chúng ta đã rời khỏi căn phòng đó. Tôi tin rằng có ba bản sao trong 'Năm trăm lần,' để tham khảo, như là số đầu tiên cho những độc giả muốn t[o]..."

### **v2mini-eval2-london**

Được huấn luyện bằng mẫu 15GB giống như đã dùng cho eval1.
Mô hình lại được huấn luyện chỉ đến 10K bước.

PROMPT:Charles Darwin

Charles DarwinECCEMACY. Thưa ngài, — Trường hợp sau đây khiến tôi quan tâm: — Tôi ở London hai tuần, và bị ảnh hưởng nhiều bởi một cơn đau thấp khớp. Cơn đau thấp khớp đầu tiên xảy ra một tuần trước khi tôi gặp ngài, cơn thứ hai khi tôi gặp ngài, và cơn thứ ba cũng khi tôi gặp ngài, và cơn thứ ba vào cùng thời điểm. Tuy nhiên, cơn đau gout thứ hai không đi kèm với triệu chứng sốt, mà lại có tăng lượng nước tiểu và sự bài tiết nước tiểu nhiều hơn. Cơn thứ ba xảy ra một giờ sau khi tôi gặp ngài, và tiếp theo là sự trở lại của cơn gout, và sự trở lại nhanh hơn của gout. Cơn thứ tư cũng đi kèm với sốt, nhưng không phải lúc nào cũng có triệu chứng sốt. Cơn gout thứ ba là hai tuần sau khi ngài bị bệnh, và cơn thứ tư theo sau một cơn gout. Cơn thứ tư là hai tuần sau khi ngài bị tấn công, và đi kèm với một cảm giác

### **v2-london**

Được huấn luyện trên bộ dữ liệu 90GB (112GB đã mã hóa token)
Được huấn luyện đến 182K bước

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output1.png)

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output2.png)

### **Tiếp theo là gì?**

- Đã bắt đầu phát triển TimeCapsuleLLM v3
- Đang mở rộng kích thước bộ dữ liệu và phạm vi địa lý
- Mở rộng vượt ra khỏi London đến các thành phố khác

Công việc đang được thực hiện cùng các nhà nghiên cứu từ University College London (UCL) và việc tham gia thêm các tổ chức khác đang được thảo luận.


##  Bộ dữ liệu

### **v2**

- 90GB (dữ liệu thô) các văn bản London giai đoạn 1800-1875
- 136.344 tài liệu
- Toàn bộ bộ dữ liệu đã mã hóa token hiện có tại: https://huggingface.co/datasets/postgrammar/london-llm-1800

### Thống Kê Độ Thiên Lệch
![Độ thiên lệch đại từ](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/pronoun_bias.png)

![Độ thiên lệch địa lý](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/geographic_bias.png)

![Độ thiên lệch thời gian](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/temporal_bias.png)

Tham khảo [báo cáo độ thiên lệch v2](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/v2_bias_report.json) để biết thêm chi tiết.


-


## Hướng Dẫn Sử Dụng

Dự án này tập trung chủ yếu vào việc sưu tầm dữ liệu lịch sử, chuẩn bị cho quá trình huấn luyện và xây dựng tokenizer. Tôi sẽ không đề cập đến toàn bộ quy trình huấn luyện LLM, hãy tham khảo nanoGPT của Andrej Karpathy để biết thêm chi tiết.

### Bước 1: Thu Thập và Chuẩn Bị Văn Bản Lịch Sử

- Thu thập các file .txt của sách, tài liệu, v.v. thuộc phạm vi công cộng từ giai đoạn lịch sử bạn chọn (ví dụ: London 1800-1875)
- Đảm bảo chúng nằm trong khung thời gian/địa điểm bạn chọn
- Làm sạch các file văn bản bằng script hoặc thủ công, loại bỏ header/footer từ Project Gutenberg, chú thích hiện đại hoặc lỗi OCR.

### Bước 2: Xây Dựng Tokenizer Tuỳ Chỉnh

- Chạy train_tokenizer.py hoặc train_tokenizer_hf.py trên dữ liệu đã làm sạch.
- Bạn sẽ nhận được vocab.json và merges.txt
- Các file này xác định từ vựng và quy tắc ghép cho mô hình của bạn

### Bước 3: Huấn Luyện Mô Hình

- Tham khảo [nanoGPT của Andrej Karpathy](https://github.com/karpathy/nanoGPT) về quy trình huấn luyện hoặc tài liệu của kiến trúc bạn chọn.

# FAQ

## Huấn Luyện Thời Gian Có Chọn Lọc là gì?

Huấn Luyện Thời Gian Có Chọn Lọc (STT) là phương pháp học máy mà toàn bộ dữ liệu huấn luyện được tuyển chọn để nằm trong một giai đoạn lịch sử cụ thể. Điều này nhằm mô phỏng ngôn ngữ và kiến thức của thời kỳ đó mà không bị ảnh hưởng bởi các khái niệm hiện đại. Ví dụ, mô hình hiện tại của tôi (v0.5) được huấn luyện chỉ với dữ liệu từ 1800-1875, không tinh chỉnh mà huấn luyện từ đầu, dẫn đến kết quả phản ánh phong cách ngôn ngữ và bối cảnh lịch sử của thời kỳ đó.

## Vì sao không chỉ dùng fine-tuning hoặc LoRA?
Đối với dự án này, tôi đang cố gắng tạo ra một mô hình ngôn ngữ không bị ảnh hưởng bởi các thành kiến hiện đại. Nếu tôi fine-tune một thứ như GPT-2, nó đã được huấn luyện trước và thông tin đó sẽ không biến mất. Nếu tôi huấn luyện từ đầu thì mô hình ngôn ngữ sẽ không giả vờ là cũ, mà nó thực sự sẽ như vậy. Mục tiêu hiện tại của dự án này là tạo ra một thứ có thể lập luận hoàn toàn dựa trên kiến thức từ các cuốn sách London xuất bản trong khoảng 1800 đến 1875.

## Bạn đã sử dụng loại dữ liệu nào để huấn luyện?

Tôi đang sử dụng sách, tài liệu pháp lý, báo chí và các bài viết khác từ London giai đoạn 1800–1875. Danh sách tôi đã liên kết (cho bản v0) có khoảng 200 nhưng cho lần huấn luyện đầu tiên, tôi chỉ sử dụng 50 tệp với dung lượng khoảng ~187 MB. Bạn có thể xem danh sách tài liệu tại:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

Kích thước tập dữ liệu:
- v0: ~187MB
- v0.5: ~435MB 
- v1: ~6.25GB 
- v2mini-eval1: 15GB (lấy mẫu từ v2's 90GB)
- v2: 90GB

## Các mô hình lớn cỡ nào?

v0: 16 triệu tham số

v0.5: 123 triệu tham số

v1: 700 triệu tham số

v2mini-eval1: 300 triệu tham số

v2mini-eval2: 200 triệu tham số

v2: 1,2 tỷ tham số

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

## Công trình liên quan

- **[talkie-1930-13b](https://talkie-lm.com/introducing-talkie)**
  -  LLM 13B tham số được huấn luyện trên 260 tỷ token văn bản trước năm 1930 với Q&A. Ngoài ra còn có phiên bản [base](https://huggingface.co/talkie-lm/talkie-1930-13b-base).
 
- **[Violet 1.4B](https://huggingface.co/zakarth/violet-1b4-chat)**
  -  LLM 1,4B tham số được huấn luyện trên các văn bản 1800-1899 với Q&A. Ngoài ra còn có phiên bản [160M](https://huggingface.co/zakarth/violet-160m-chat).
 
- **[Mr. Chatterbox](https://huggingface.co/tventurella/mr_chatterbox_model)**
  -  LLM 340M tham số được huấn luyện trên hơn 28.000 văn bản từ 1837-1899 với Q&A.

- **[Ranke-4B](https://github.com/DGoettlich/history-llms/blob/main/ranke-4b/prerelease_notes.md)** 
  - một họ LLM 4B tham số dựa trên kiến trúc Qwen3 được huấn luyện từ đầu trên 80 tỷ token dữ liệu lịch sử đến các mốc kiến thức 1913,1929,1933,1939,1946.

- **[MondadGPT](https://huggingface.co/Pclanglais/MonadGPT)** 
  - MonadGPT là bản tinh chỉnh của Mistral-Hermes 2 trên 11.000 văn bản đầu thời cận đại bằng tiếng Anh, Pháp và Latinh, chủ yếu từ EEBO và Gallica.

## Lời cảm ơn

Tôi xin cảm ơn [Tiến sĩ Hamed Yaghoobian](https://hamedyaghoobian.com) vì đã giám sát học thuật, hướng dẫn về khung nghiên cứu và đánh giá, cũng như hỗ trợ huấn luyện tokenizer và chuẩn bị bộ dữ liệu cho bản phát hành v2. Những góp ý và kinh nghiệm của ông rất quan trọng trong việc hoàn thiện cách trình bày công trình này.










































---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-20

---