
<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN">简体中文</a>
        | <a href="#" title="Coming soon">繁體中文 (coming soon)</a> |
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko">한국어</a>
        | <a href="#" title="Coming soon">हिन्दी (coming soon)</a> |
        | <a href="#" title="Coming soon">ไทย (coming soon)</a> |
        | <a href="#" title="Coming soon">Français (coming soon)</a>
        | <a href="#" title="Coming soon">Deutsch (coming soon)</a>
        | <a href="#" title="Coming soon">Español (coming soon)</a>
        | <a href="#" title="Coming soon">Italiano (coming soon)</a>
        | <a href="#" title="Coming soon">Русский (coming soon)</a>
        | <a href="#" title="Coming soon">Português (coming soon)</a>
        | <a href="#" title="Coming soon">Nederlands (coming soon)</a>
        | <a href="#" title="Coming soon">Polski (coming soon)</a>
        | <a href="#" title="Coming soon">العربية (coming soon)</a>
        | <a href="#" title="Coming soon">فارسی (coming soon)</a>
        | <a href="#" title="Coming soon">Türkçe (coming soon)</a>
        | <a href="#" title="Coming soon">Tiếng Việt (coming soon)</a>
        | <a href="#" title="Coming soon">Bahasa Indonesia (coming soon)</a>

      </div>
    </div>
  </details>
</div>

# TimeCapsule LLM
Một mô hình LLM được huấn luyện chỉ trên dữ liệu từ các giai đoạn thời gian nhất định nhằm giảm thiên vị hiện đại.

Hãy tưởng tượng nếu một mô hình AI không chỉ giả vờ là lịch sử mà thực sự là như vậy.

Dựa trên [nanoGPT của Andrej Karpathy](https://github.com/karpathy/nanoGPT) Các script huấn luyện cốt lõi và kiến trúc mô hình là của ông ấy.

# Mục tiêu dự án

TimeCapsule LLM là một dự án thử nghiệm chỉ được huấn luyện trên các văn bản viết trong những giai đoạn lịch sử nhất định. Mục tiêu là mô phỏng thế giới quan và ngôn ngữ của các thời đại lịch sử cụ thể.

# Tại sao chỉ tinh chỉnh là chưa đủ

Nếu bạn chỉ tinh chỉnh một mô hình đã huấn luyện trước, LLM của bạn vẫn sẽ biết các khái niệm hiện đại. Tất nhiên, đạt được mức không thiên vị hiện đại là rất khó nhưng tôi muốn tiến gần nhất có thể tới điều này. Không có thiên vị hiện đại đòi hỏi phải huấn luyện mô hình từ đầu.

# Kết quả kỳ vọng

Hy vọng khi hoàn thành, mô hình này sẽ không biết các khái niệm hiện đại và sẽ không thể suy luận ngoài những gì nó đã được huấn luyện. Nó không nên nhận biết các từ vựng/khái niệm hiện đại và tôi hy vọng nó không tạo ra kiến thức hiện đại tưởng tượng.

# Cập nhật tiến độ

## Ngày 9 tháng 7, 2025

Tôi đã chọn giai đoạn thời gian 1800-1850 và khu vực: London

Tôi đã tập hợp một danh sách văn bản, sách, tài liệu

Cho đến nay tôi đã có 50 file dạng txt và sẽ bắt đầu huấn luyện NanoGPT sớm

Sẽ cập nhật phần này miễn là còn tiến triển

## Ngày 13 tháng 7, 2025

Đã huấn luyện nanoGPT với 187MB dữ liệu văn bản lịch sử.

## Ngày 15 tháng 7, 2025

Tôi bắt đầu tải về các văn bản cho đợt huấn luyện thứ hai. Tôi lấy mọi thứ từ Internet Archive và tôi đã mở rộng khoảng thời gian tới 1800-1875. Để có được dải văn bản đa dạng, bạn có thể dùng các bộ lọc chủ đề và tìm kiếm cho địa điểm xuất bản, khoảng thời gian và chủ đề trên Internet Archive.

![Search Filters](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## Ngày 16 tháng 7, 2025

Tôi đã tải về khoảng 500 file txt từ Internet Archive và sau khi dọn dẹp (chỉ xóa khoảng trắng, tiêu đề Gutenberg, vv) tôi có khoảng 500MB dữ liệu. Đây là một bộ dữ liệu rất nhỏ nhưng lần trước tôi chỉ huấn luyện với 187MB nên chắc chắn sẽ có sự khác biệt có thể nhận thấy trong đầu ra sau khi tôi huấn luyện mô hình thứ hai. Tôi hy vọng mô hình này ít nhất có thể tạo ra các câu mạch lạc hơn, hợp lý hơn. Tất nhiên không có gì đảm bảo vì bộ dữ liệu vẫn cực kỳ nhỏ, nhưng cũng đã nhiều hơn lần trước.

Việc này có thể thực hiện trên phần cứng của tôi, điều này cũng tốt vì tôi hy vọng sẽ thấy một số cải thiện trước khi chuyển sang bộ dữ liệu lớn hơn mà sẽ buộc tôi phải thuê GPU. Nhưng đừng lo tôi vẫn dự định thuê GPU sớm, nhưng trước khi làm vậy tôi muốn chắc chắn bộ dữ liệu của tôi được chọn lọc và sạch nhất có thể. Một trong các vấn đề tôi gặp phải là làm sạch, nhiều file txt này có lẫn chữ vô nghĩa. Các script tôi dùng để làm sạch có hiệu quả nhưng không phải lúc nào cũng đạt 100%.

Tôi sẽ huấn luyện bộ dữ liệu này hôm nay và dự kiến sẽ mất khoảng 4-5 giờ. Khi hoàn thành và tôi kiểm tra nó, tôi sẽ cập nhật. Cảm ơn mọi người đã quan tâm dự án của tôi, thậm chí có người còn gửi link tài nguyên OCR cho tôi nên cảm ơn rất nhiều! Tôi hy vọng nhiều người sẽ thử nghiệm và thử với bộ dữ liệu của riêng mình.


### Cập nhật huấn luyện

Tôi đã bắt đầu huấn luyện trên tập dữ liệu 435MB (108 triệu tokens), hiện tại khá suôn sẻ. Mất mát huấn luyện giảm từ 10.9 xuống 4.9 trong 2800 vòng lặp đầu. Tôi dự đoán sẽ mất khoảng 8 hoặc 9 giờ để hoàn thành. Tôi sẽ đăng cập nhật nữa khi xong.

## Ngày 17 tháng 7, 2025 2:13AM

Việc huấn luyện cho mô hình thứ hai đã hoàn thành, chiếc 4060 của tôi mất khoảng 8 tiếng 40 phút (3.900 lặp/giờ) cho 33.000 lặp (5 epoch). Mất mát huấn luyện cuối là 3.73. Đầu ra rất bất ngờ, nó thực sự tạo ra những câu văn phong thế kỷ 19 mạch lạc.

## Ngày 28 tháng 7, 2025

Tôi đã tiến hành tải lên phiên bản v0.5 lên Hugging Face, [Xem tại đây](https://huggingface.co/haykgrigorian/TimeCapsuleLLM) nếu bạn muốn. Giờ bạn có thể tải repo của tôi và chạy nó cục bộ. Đáng tiếc nanoGPT không làm việc trực tiếp với HuggingFace, nên bạn sẽ phải tải và chạy mô hình cục bộ.

Tôi cũng sẽ bắt đầu chọn lọc dữ liệu cho lần huấn luyện tiếp theo, tôi tin mình cần gấp 5-10 lần dữ liệu để đạt khả năng suy luận.


# Hành vi & hạn chế của mô hình V0

Các prompt ban đầu cho thấy mô hình phản hồi bằng ngôn ngữ và hành vi của những năm 1800. Ví dụ, tôi hỏi "Who art Henry?" và nó trả lời "I know that man, I have did not a black, the storm." và vâng, câu đó không có nghĩa gì nhưng LLM đang nhận biết tôi đang hỏi về một người.

![Kết quả mẫu TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

Không có đề cập đến các khái niệm hiện đại, đầu ra chủ yếu sử dụng từ ngữ và cách diễn đạt của thập niên 1800.

Vẫn còn rất nhiều việc phải làm, huấn luyện với 187MB sẽ không tạo ra một mô hình có khả năng lập luận phức tạp.

Hiện tại nó tạo ra các câu thiếu cấu trúc hoàn chỉnh và nhìn chung khá khó hiểu, nhưng điều này là bình thường với kích thước dữ liệu huấn luyện này.

# Hành vi & Giới hạn của Mô hình V0.5

Đây là một cải tiến đáng kể so với mô hình trước. Phong cách viết và từ vựng mang đậm chất thời Victoria và gần như mọi câu đều đúng ngữ pháp với dấu câu thích hợp. Và một lần nữa, mô hình này được huấn luyện từ đầu nên chỉ tập trung vào các chủ đề của thập niên 1800.

![Kết quả mẫu TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

Có rất nhiều "ảo giác thực tế". Rất nhiều (gần như 100%) chi tiết (ngày tháng, sự kiện, nhân vật lịch sử) là bịa đặt. Ngoài ra, các câu không thực sự liên kết với nhau, thỉnh thoảng có 2 câu liên quan nhưng ngoài ra thì không. Một vấn đề khác là đôi khi xuất hiện dòng footer “Digitized by Google” không mong muốn, nên lần huấn luyện tới tôi phải đảm bảo làm sạch văn bản thật kỹ. Nhìn chung tôi rất hài lòng với kết quả này, vẫn còn xa mới thành LLM nhưng chắc chắn đã là một trình tạo câu.

Tôi đang học hỏi rất nhiều và sẽ bắt đầu tìm hiểu những gì cần cải thiện trong vài tuần tới. Tôi sẽ sớm tải lên các tệp!

# Kế hoạch Sắp tới

(Đã hoàn thành) Tôi sẽ bắt đầu làm việc trên phiên bản 0.5, thay vì huấn luyện với 50 quyển sách, tôi sẽ huấn luyện với lý tưởng là 500-600 quyển. Hiện tại tôi đang huấn luyện nanoGPT bằng các cuốn sách từ 1800-1850 và cụ thể là ở London. Có một số thách thức như đảm bảo những cuốn sách tôi tìm không bị chỉnh sửa hoặc có giải thích hiện đại mà là sách gốc xuất bản trong thời gian tôi chọn.

Tôi muốn huấn luyện một mô hình mới (v1) với tập dữ liệu lớn hơn nhiều, có thể gấp 5-10 lần so với v0.5. Mục tiêu của tôi là xem liệu có thể khiến khả năng lập luận xuất hiện chỉ từ Huấn luyện Thời gian Chọn lọc hay không, đây sẽ là một nhiệm vụ khó khăn hơn và tôi cũng không chắc liệu có khả thi không vì có giới hạn về dữ liệu lịch sử. Trong vài tuần tới tôi sẽ cố gắng thu thập đủ dữ liệu cho một tập 5-10GB. Tôi tin rằng nếu có dữ liệu sạch, chất lượng cao và thuê được GPU, sẽ có tiến triển.

# Cách sử dụng dự án này

Dự án này chủ yếu tập trung vào việc thu thập dữ liệu lịch sử, chuẩn bị cho huấn luyện và xây dựng tokenizer. Tôi sẽ không hướng dẫn toàn bộ quá trình huấn luyện LLM, cho việc đó bạn hãy tham khảo nanoGPT của Andrej Karpathy.

# Bước 1: Thu thập và Chuẩn bị Văn bản Lịch sử

Thu thập các tệp .txt của sách, tài liệu, v.v. thuộc phạm vi công cộng từ thời kỳ bạn chọn (ví dụ, London 1800-1850)

Bạn có thể sử dụng download_texts_improved.py để tải sách nếu cần.

Làm sạch các tệp văn bản bằng script hoặc xóa thủ công header/footer của Project Gutenberg, chú thích hiện đại hay các lỗi OCR.

prepare_dataset.py nên hoạt động tốt.

# Bước 2: Xây dựng Tokenizer Tùy chỉnh

Chạy train_tokenizer.py hoặc train_tokenizer_hf.py trên dữ liệu đã làm sạch.
Bạn sẽ nhận được vocab.json và merges.txt

Các tệp này định nghĩa từ vựng và quy tắc gộp từ cho mô hình của bạn

# Bước 3: Huấn luyện Mô hình (nanoGPT)

Tham khảo [nanoGPT của Andrej Karpathy](https://github.com/karpathy/nanoGPT) cho quy trình huấn luyện.

Bạn có thể huấn luyện một LLM khác nếu muốn, nhưng tôi dùng nanoGPT

# Câu hỏi thường gặp

## Huấn luyện Thời gian Chọn lọc là gì?

Huấn luyện Thời gian Chọn lọc (Selective Temporal Training - STT) là một phương pháp học máy mà tất cả dữ liệu huấn luyện được chọn lọc để nằm hoàn toàn trong một giai đoạn lịch sử nhất định. Mục đích là để mô phỏng ngôn ngữ và tri thức của thời kỳ đó mà không bị ảnh hưởng bởi các khái niệm hiện đại. Ví dụ, mô hình hiện tại của tôi (v0.5) được huấn luyện độc quyền trên dữ liệu từ 1800-1875, không tinh chỉnh mà huấn luyện từ đầu, cho ra đầu ra phản ánh phong cách ngôn ngữ và bối cảnh lịch sử của thời kỳ đó.

## Tại sao không chỉ tinh chỉnh hoặc dùng LoRA?

Với dự án này tôi muốn tạo một mô hình ngôn ngữ không bị ảnh hưởng bởi thiên kiến hiện đại. Nếu tôi tinh chỉnh như GPT-2, nó đã được huấn luyện trước và thông tin đó sẽ không mất đi. Nếu huấn luyện từ đầu, mô hình sẽ không giả vờ cổ xưa, mà nó thực sự như thế. Mục tiêu hiện tại là tạo ra một mô hình có thể lập luận chỉ bằng kiến thức từ sách London xuất bản giai đoạn 1800-1850.

## Bạn đã dùng loại dữ liệu nào để huấn luyện?

Tôi sử dụng sách, tài liệu pháp lý, báo chí và các tác phẩm khác từ London 1800–1850. Danh sách tôi đã liên kết có khoảng 200 tài liệu nhưng lần huấn luyện đầu tôi chỉ dùng 50 tệp, khoảng ~187 MB. Bạn có thể xem danh sách tài liệu tại:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## Mô hình Phiên bản 0 lớn cỡ nào?

Mô hình này hiện rất nhỏ, tôi chỉ làm cho vui và tuân thủ nghiêm ngặt quy tắc không dùng nguồn hiện đại. Nó có gần 16 triệu tham số nhưng tôi sẽ bắt đầu thu thập thêm tài liệu cũ để huấn luyện một mô hình mới. Sẽ cập nhật thông tin sau.

## Thông số huấn luyện?

GPU: Geforce rtx 4060
CPU: i5-13400F
Ram: 16GB DDR5.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-02

---