
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
Một mô hình LLM chỉ được huấn luyện từ dữ liệu thuộc các giai đoạn thời gian nhất định nhằm giảm thiên vị hiện đại.

Hãy tưởng tượng một mô hình AI không chỉ giả vờ là lịch sử mà thực sự như vậy.

Được xây dựng trên [nanoGPT của Andrej Karpathy](https://github.com/karpathy/nanoGPT) Các script huấn luyện lõi và kiến trúc mô hình là của ông ấy.

# Mục tiêu Dự án

TimeCapsule LLM là một dự án thử nghiệm chỉ được huấn luyện trên các văn bản được viết trong những giai đoạn lịch sử nhất định. Mục tiêu là mô phỏng thế giới quan và ngôn ngữ của các thời kỳ lịch sử cụ thể.

# Tại sao chỉ tinh chỉnh là chưa đủ

Nếu bạn chỉ tinh chỉnh một mô hình đã được huấn luyện trước, LLM của bạn vẫn sẽ biết các khái niệm hiện đại. Tất nhiên để đạt được mức không có thiên vị hiện đại là rất khó nhưng tôi muốn cố gắng gần nhất với điều này. Muốn loại bỏ hoàn toàn thiên vị hiện đại thì phải huấn luyện mô hình từ đầu.

# Kết quả kỳ vọng

Hy vọng khi hoàn thành, mô hình này sẽ không biết các khái niệm hiện đại và không thể suy luận ngoài phạm vi đã được huấn luyện. Nó không nên nhận biết các khái niệm/từ vựng hiện đại và tôi hy vọng nó không tự bịa ra kiến thức hiện đại.

# Cập nhật Tiến độ

## 9 tháng 7, 2025

Tôi đã xác định giai đoạn thời gian là 1800-1850 và khu vực: London

Tôi đã thu thập được danh sách văn bản, sách, tài liệu

Hiện tại tôi đã có 50 file txt và sẽ bắt đầu huấn luyện NanoGPT sớm

Sẽ cập nhật tại đây miễn là còn tiến triển

## 13 tháng 7, 2025

Đã huấn luyện nanoGPT với 187MB dữ liệu văn bản lịch sử.

## 15 tháng 7, 2025

Tôi đã bắt đầu tải về văn bản cho lần huấn luyện thứ hai. Tôi lấy tất cả từ Internet Archive và đã mở rộng giai đoạn lên 1800-1875. Để có được nhiều loại văn bản đa dạng, bạn có thể sử dụng bộ lọc chủ đề, vị trí xuất bản, thời kỳ và chủ đề trên Internet Archive.

![Bộ lọc tìm kiếm](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## 16 tháng 7, 2025

Tôi đã tải về khoảng 500 file txt từ Internet Archive và sau khi làm sạch (chỉ xóa khoảng trắng, tiêu đề Gutenberg, v.v.) tôi có khoảng 500MB dữ liệu. Đây là một tập dữ liệu nhỏ nhưng lần trước tôi chỉ huấn luyện với 187MB nên lần này chắc chắn sẽ có sự khác biệt đáng chú ý trong đầu ra sau khi huấn luyện mô hình thứ hai. Tôi hy vọng mô hình này ít nhất có thể sinh ra những câu rõ ràng hơn, hợp lý hơn. Tất nhiên không đảm bảo vì vẫn là tập dữ liệu rất nhỏ, nhưng vẫn nhiều hơn lần trước.

Việc này có thể thực hiện được trên phần cứng của tôi, điều này cũng tốt vì tôi hy vọng sẽ thấy được một số cải tiến trước khi chuyển sang tập dữ liệu lớn hơn cần thuê GPU. Nhưng đừng lo tôi vẫn dự định sẽ thuê GPU sớm, chỉ là trước khi làm vậy tôi muốn chắc chắn tập dữ liệu của mình đã được tuyển chọn và làm sạch tốt nhất có thể. Một vấn đề tôi gặp phải là làm sạch, nhiều file txt này lẫn lộn kí tự vô nghĩa. Các script tôi dùng để làm sạch có hiệu quả nhưng không hoàn toàn. 

Tôi sẽ huấn luyện tập dữ liệu này hôm nay và sẽ mất khoảng 4-5 giờ. Sau khi xong và kiểm tra, tôi sẽ cập nhật tiếp. Cảm ơn mọi người đã quan tâm đến dự án của tôi, thậm chí có người gửi tôi các liên kết tài nguyên OCR nên cảm ơn rất nhiều! Hy vọng sẽ có thêm nhiều người thử và thử nghiệm với bộ dữ liệu riêng của họ.

## 28 tháng 7, 2025

Tôi đã tải lên bản v0.5 lên Hugging Face, [Xem tại đây](https://huggingface.co/haykgrigorian/TimeCapsuleLLM) nếu bạn muốn. Bạn có thể tải repo của tôi và chạy nó cục bộ. Rất tiếc nanoGPT không hoạt động trực tiếp với HuggingFace, nên bạn sẽ phải tải về và chạy mô hình cục bộ.

Ngoài ra tôi sẽ bắt đầu chọn lọc dữ liệu cho lần huấn luyện tiếp theo, tôi nghĩ tôi sẽ cần nhiều dữ liệu hơn nữa, gấp 5-10 lần để đạt được khả năng suy luận.

### Cập nhật huấn luyện

Tôi đã bắt đầu huấn luyện trên một tập dữ liệu 435MB (108 triệu tokens), hiện tại mọi thứ diễn ra khá suôn sẻ. Train loss giảm từ 10.9 xuống 4.9 chỉ sau 2800 vòng lặp đầu tiên. Tôi dự đoán sẽ mất khoảng 8 hoặc 9 tiếng để hoàn thành. Sẽ đăng cập nhật khi hoàn thành.

## 17 tháng 7, 2025 2:13AM

Đã huấn luyện xong cho mô hình thứ hai, chiếc 4060 của tôi mất khoảng 8 tiếng 40 phút (3.900 vòng/giờ) cho 33.000 vòng (5 epoch). Train loss cuối cùng là 3.73. Kết quả đầu ra khá tốt, thực sự sinh ra những câu văn kiểu thế kỷ 19 có nghĩa.

# Hành vi & Giới hạn của Mô hình V0

Những gợi ý ban đầu cho thấy mô hình phản hồi với ngôn ngữ và hành vi của thập niên 1800. Ví dụ, tôi thử với "Who art Henry?" và nó trả lời "I know that man, I have did not a black, the storm." và vâng câu đó không có nghĩa nhưng LLM nhận ra tôi đang hỏi về một người.

![TimeLockLLM Mẫu đầu ra](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

Không có đề cập đến các khái niệm hiện đại, đầu ra chủ yếu chứa các từ ngữ và cách diễn đạt từ những năm 1800.

Vẫn còn rất nhiều việc cần làm, huấn luyện từ 187MB sẽ không cho bạn một mô hình tạo ra văn bản với lý luận phức tạp.

Hiện tại nó tạo ra các câu thiếu cấu trúc câu đầy đủ và nhìn chung là không có ý nghĩa, nhưng điều này là bình thường đối với kích thước tập huấn luyện này.

# Hành Vi & Giới Hạn của Mô Hình V0.5

Đây là một sự cải thiện đáng kể so với mô hình trước đó. Phong cách viết và vốn từ là thời Victoria và hầu như mọi câu đều đúng ngữ pháp với dấu câu đầy đủ. Và một lần nữa, mô hình này được huấn luyện từ đầu nên chỉ tập trung vào các chủ đề của thế kỷ 19.

![Ví dụ đầu ra TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

Có rất nhiều ảo giác thực tế. Rất nhiều (gần như 100%) chi tiết (ngày tháng, sự kiện, nhân vật lịch sử) đều là bịa đặt. Ngoài ra các câu không thực sự liên kết với nhau, đôi khi chỉ có 2 câu liên quan nhưng ngoài ra thì không. Một vấn đề khác là đôi khi xuất hiện dòng chân trang “Digitized by Google”, nên lần huấn luyện tới tôi phải chắc chắn làm sạch văn bản kỹ hơn. Nhìn chung tôi rất hài lòng với kết quả, nó chưa phải là một LLM nhưng chắc chắn là một trình tạo câu.

Tôi đang học hỏi rất nhiều và sẽ bắt đầu tìm ra những gì mình cần làm tốt hơn trong vài tuần tới. Tôi sẽ sớm tải lên các tệp!

# Kế Hoạch Sắp Tới

(Đã hoàn thành) Tôi sẽ bắt đầu làm việc với phiên bản 0.5, thay vì huấn luyện với 50 cuốn sách, tôi sẽ huấn luyện với lý tưởng là 500-600 cuốn. Hiện tại tôi đang huấn luyện nanoGPT với sách từ 1800-1850 và cụ thể là từ London. Có một số thách thức như đảm bảo các sách tôi tìm không bị cập nhật hoặc có diễn giải hiện đại mà là các sách gốc xuất bản trong giai đoạn tôi chọn.

Tôi muốn huấn luyện một mô hình mới (v1) với tập dữ liệu lớn hơn nhiều, có thể lớn hơn 5-10 lần so với v0.5. Mục tiêu là xem liệu tôi có thể làm xuất hiện khả năng lý luận chỉ từ Huấn Luyện Thời Gian Chọn Lọc hay không, đây sẽ là nhiệm vụ khó hơn và tôi cũng không chắc có thể vì dữ liệu lịch sử bị giới hạn. Trong vài tuần tới tôi sẽ cố gắng tổng hợp đủ dữ liệu cho tập dữ liệu 5-10GB. Tôi tin rằng nếu tôi có dữ liệu sạch, chất lượng cao và thuê được GPU, sẽ có tiến triển.

# Cách Sử Dụng Dự Án Này

Dự án này chủ yếu tập trung vào việc thu thập dữ liệu lịch sử, chuẩn bị cho huấn luyện và xây dựng tokenizer. Tôi sẽ không trình bày toàn bộ quá trình huấn luyện LLM, cho việc đó hãy tham khảo nanoGPT của Andrej Karpathy.

# Bước 1: Thu Thập và Chuẩn Bị Văn Bản Lịch Sử

Thu thập các tệp .txt của sách, tài liệu, v.v. thuộc phạm vi công cộng từ giai đoạn bạn chọn (ví dụ: London 1800-1850)

Bạn có thể sử dụng download_texts_improved.py để tải sách nếu cần.

Làm sạch các tệp văn bản bằng script hoặc loại bỏ thủ công header/footer từ Project Gutenberg, chú thích hiện đại hoặc lỗi OCR.

prepare_dataset.py nên hoạt động tốt.

# Bước 2: Xây Dựng Tokenizer Tùy Chỉnh

Chạy train_tokenizer.py hoặc train_tokenizer_hf.py trên dữ liệu đã làm sạch.
Bạn sẽ nhận được vocab.json và merges.txt

Các tệp này định nghĩa từ vựng và quy tắc gộp cho mô hình của bạn

# Bước 3: Huấn Luyện Mô Hình (nanoGPT)

Tham khảo [nanoGPT của Andrej Karpathy](https://github.com/karpathy/nanoGPT) để biết quy trình huấn luyện.

Bạn có thể huấn luyện LLM khác nếu muốn, nhưng tôi dùng nanoGPT

# FAQ

## Huấn Luyện Thời Gian Chọn Lọc là gì?

Huấn Luyện Thời Gian Chọn Lọc (Selective Temporal Training - STT) là một phương pháp học máy mà toàn bộ dữ liệu huấn luyện đều được chọn lọc nằm trong một thời kỳ lịch sử cụ thể. Việc này nhằm mô phỏng ngôn ngữ và tri thức của thời kỳ đó mà không bị ảnh hưởng bởi các khái niệm hiện đại. Ví dụ, mô hình hiện tại tôi có (v0.5) được huấn luyện hoàn toàn từ dữ liệu 1800-1875, không tinh chỉnh mà huấn luyện từ đầu nên đầu ra phản ánh phong cách ngôn ngữ và bối cảnh lịch sử thời đó.

## Tại sao không chỉ sử dụng fine-tuning hoặc LoRA?

Với dự án này tôi muốn tạo một mô hình ngôn ngữ không bị ảnh hưởng bởi thiên kiến hiện đại. Nếu tôi fine-tune như GPT-2, nó đã được huấn luyện trước và thông tin đó sẽ không mất đi. Nếu tôi huấn luyện từ đầu, mô hình sẽ không giả vờ là cũ, mà nó sẽ là như vậy. Mục tiêu hiện tại của dự án này là tạo ra thứ gì đó chỉ có thể lý luận dựa trên tri thức từ sách London xuất bản trong giai đoạn 1800-1850.

## Bạn đã sử dụng dữ liệu gì để huấn luyện?

Tôi sử dụng sách, tài liệu pháp lý, báo chí và các bản viết khác từ London 1800–1850. Danh sách tôi liên kết có khoảng 200 tài liệu nhưng lần đầu huấn luyện tôi chỉ dùng 50 tệp khoảng ~187 MB. Bạn có thể xem danh sách tài liệu:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## Mô hình Phiên bản 0 lớn cỡ nào?

Mô hình này rất nhỏ hiện tại, tôi chỉ làm cho vui và tuân thủ nghiêm ngặt quy tắc không sử dụng nguồn hiện đại. Nó có gần 16 triệu tham số nhưng tôi sẽ bắt đầu thu thập thêm văn bản cổ để bắt đầu huấn luyện mô hình khác. Sẽ cập nhật khi có tiến triển.

## Thông số Huấn Luyện?

GPU: Geforce rtx 4060
CPU: i5-13400F
Ram: 16GB DDR5.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---