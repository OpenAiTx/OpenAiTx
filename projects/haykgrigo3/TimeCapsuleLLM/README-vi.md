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
Một mô hình LLM chỉ được huấn luyện trên dữ liệu từ các giai đoạn thời gian nhất định nhằm giảm thiên kiến hiện đại.

Hãy tưởng tượng nếu một mô hình AI không chỉ giả vờ là lịch sử mà thực sự là như vậy.

Dựa trên [nanoGPT của Andrej Karpathy](https://github.com/karpathy/nanoGPT). Các script huấn luyện cốt lõi và kiến trúc mô hình là công việc của ông ấy.

# Mục tiêu dự án

TimeCapsule LLM là một dự án thử nghiệm chỉ được huấn luyện trên các văn bản được viết trong một số giai đoạn lịch sử nhất định. Mục tiêu là mô phỏng thế giới quan và ngôn ngữ của các thời đại lịch sử cụ thể.

# Tại sao tinh chỉnh là chưa đủ

Nếu bạn chỉ tinh chỉnh một mô hình đã huấn luyện trước, LLM của bạn vẫn sẽ biết các khái niệm hiện đại. Đương nhiên việc đạt đến mức không có thiên kiến hiện đại là rất khó nhưng tôi muốn cố gắng đạt gần nhất có thể. Để không có thiên kiến hiện đại thì cần huấn luyện một mô hình từ đầu.

# Kết quả kỳ vọng

Hy vọng sau khi hoàn thành, mô hình này sẽ không biết các khái niệm hiện đại và sẽ không thể suy luận vượt quá những gì nó đã được huấn luyện. Nó không nên nhận biết các khái niệm/từ vựng hiện đại và tôi hy vọng nó không bịa đặt kiến thức hiện đại.

# Cập nhật tiến độ

## Ngày 9 tháng 7, 2025

Tôi đã chọn giai đoạn thời gian từ 1800-1850 và khu vực: London

Tôi đã tập hợp một danh sách văn bản, sách, tài liệu

Hiện tại tôi đã có được 50 file txt và sẽ bắt đầu huấn luyện NanoGPT sớm

Sẽ cập nhật mục này nếu có tiến triển

## Ngày 13 tháng 7, 2025

Đã huấn luyện nanoGPT với 187MB dữ liệu văn bản lịch sử.

## Ngày 15 tháng 7, 2025

Tôi bắt đầu tải về các văn bản cho lần huấn luyện thứ hai. Tôi đang lấy tất cả từ Internet Archive và đã mở rộng giai đoạn thời gian lên 1800-1875. Để có được nhiều loại văn bản đa dạng, bạn có thể sử dụng các bộ lọc chủ đề và tìm kiếm theo địa điểm xuất bản, khoảng thời gian và chủ đề trên Internet Archive.

![Bộ lọc tìm kiếm](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## Ngày 16 tháng 7, 2025

Tôi đã tải về khoảng 500 file txt từ Internet Archive và sau khi làm sạch (chỉ xóa khoảng trắng, tiêu đề Gutenberg, v.v.) tôi có khoảng 500MB dữ liệu. Đây là một bộ dữ liệu rất nhỏ nhưng lần trước tôi chỉ huấn luyện với 187MB nên lần này hy vọng sẽ thấy sự khác biệt rõ rệt trong đầu ra sau khi huấn luyện mô hình thứ hai. Tôi hy vọng mô hình này có thể tạo ra các câu hoàn chỉnh hơn, có ý nghĩa hơn. Tất nhiên điều này không đảm bảo vì bộ dữ liệu vẫn rất nhỏ, nhưng vẫn nhiều hơn lần trước.

Điều này có thể thực hiện được trên phần cứng cá nhân, cũng tốt vì tôi có thể thấy được một số cải thiện trước khi chuyển sang bộ dữ liệu lớn hơn và cần thuê GPU. Nhưng đừng lo, tôi vẫn dự định sẽ thuê GPU sớm, nhưng trước đó tôi muốn chắc chắn bộ dữ liệu của mình được chọn lọc và làm sạch tốt nhất có thể. Một trong những vấn đề tôi gặp phải là làm sạch, rất nhiều file txt có lẫn ký tự vô nghĩa. Các script tôi dùng để làm sạch có hiệu quả nhưng không phải 100%.

Tôi sẽ huấn luyện bộ dữ liệu này hôm nay và dự kiến mất khoảng 4-5 tiếng. Khi xong và tôi kiểm tra, tôi sẽ cập nhật. Cảm ơn mọi người đã quan tâm dự án của tôi, thậm chí có người còn gửi cho tôi các liên kết tài nguyên OCR nên xin cảm ơn! Tôi hy vọng sẽ có nhiều người thử nghiệm với bộ dữ liệu riêng của mình.

### Cập nhật huấn luyện

Tôi đã bắt đầu huấn luyện trên tập dữ liệu 435MB (108 triệu tokens), quá trình hiện tại khá suôn sẻ. Train loss giảm từ 10.9 xuống 4.9 trong 2800 vòng lặp đầu tiên. Tôi dự kiến sẽ mất khoảng 8 hoặc 9 tiếng để hoàn thành. Tôi sẽ đăng cập nhật nữa khi xong.

## Ngày 17 tháng 7, 2025 2:13AM

Đã hoàn thành huấn luyện mô hình thứ hai, 4060 của tôi mất khoảng 8 tiếng 40 phút (3.900 vòng/giờ) cho 33.000 vòng (5 epochs). Train loss cuối cùng là 3.73. Kết quả đầu ra khá bất ngờ, mô hình thực sự tạo ra câu văn kiểu thế kỷ 19 khá mạch lạc.

# Hành vi & Hạn chế của Mô hình V0

Các prompt ban đầu cho thấy mô hình trả lời với ngôn ngữ và hành vi của những năm 1800. Ví dụ, tôi nhập "Who art Henry?" và nó trả lời "I know that man, I have did not a black, the storm." và vâng, câu này không có ý nghĩa nhưng LLM nhận biết tôi đang hỏi về một người.

![TimeLockLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

Không có đề cập đến các khái niệm hiện đại, đầu ra chủ yếu chứa từ ngữ và cách diễn đạt của những năm 1800.

Mô hình vẫn cần cải thiện nhiều, huấn luyện với 187MB sẽ không cho ra mô hình sinh văn bản có suy luận phức tạp.

Hiện tại nó tạo ra các câu thiếu cấu trúc hoàn chỉnh và nhìn chung là không hợp lý nhưng điều này là bình thường với kích thước dữ liệu huấn luyện như vậy.

# Hành Vi & Giới Hạn của Mô Hình V0.5

Đây là một cải tiến tốt so với mô hình trước. Phong cách viết và từ vựng mang tính thời Victoria và hầu như mọi câu đều đúng ngữ pháp với dấu câu chuẩn. Và một lần nữa, mô hình này được huấn luyện từ đầu nên chỉ tập trung vào các chủ đề của thế kỷ 19.

![TimeLockLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

Có rất nhiều thông tin không chính xác. Rất nhiều (gần như 100%) các chi tiết (ngày tháng, sự kiện, nhân vật lịch sử) đều là bịa đặt. Ngoài ra, các câu không thật sự liên kết với nhau, đôi lúc chỉ có 2 câu liên quan nhưng thường thì không. Một vấn đề khác là đôi khi xuất hiện footer “Digitized by Google” lạc lõng, nên lần huấn luyện tiếp theo tôi phải đảm bảo làm sạch văn bản kỹ hơn. Nhìn chung tôi rất hài lòng với kết quả, tuy chưa đạt đến mức LLM nhưng chắc chắn là một bộ sinh câu tốt.

Tôi đang học hỏi rất nhiều và sẽ bắt đầu xác định những gì cần cải thiện trong vài tuần tới. Tôi sẽ sớm tải lên các tệp!

# Kế Hoạch Sắp Tới

(Đã hoàn thành) Tôi sẽ bắt đầu làm việc với phiên bản 0.5, thay vì huấn luyện với 50 cuốn sách, tôi sẽ huấn luyện với khoảng 500-600 cuốn. Hiện tại tôi đang huấn luyện nanoGPT bằng sách từ năm 1800-1850, đặc biệt là tại London. Có một số thách thức như đảm bảo những cuốn sách tìm được không bị cập nhật hoặc giải thích hiện đại mà là sách gốc xuất bản trong khoảng thời gian tôi chọn.

Tôi muốn huấn luyện một mô hình mới (v1) với tập dữ liệu lớn hơn nhiều, có thể gấp 5-10 lần so với v0.5. Mục tiêu là xem liệu có thể xuất hiện khả năng suy luận chỉ nhờ Huấn Luyện Thời Gian Có Chọn Lọc hay không, đây sẽ là một nhiệm vụ khó hơn và tôi cũng không chắc liệu có khả thi không do hạn chế về dữ liệu lịch sử. Trong vài tuần tới tôi sẽ cố gắng chọn lọc đủ dữ liệu cho một tập 5-10GB. Tôi tin rằng nếu có dữ liệu sạch chất lượng cao và thuê được GPU, sẽ có tiến triển.

# Hướng Dẫn Sử Dụng Dự Án Này

Dự án này chủ yếu tập trung vào việc thu thập dữ liệu lịch sử, chuẩn bị cho huấn luyện và xây dựng tokenizer. Tôi sẽ không đề cập toàn bộ quy trình huấn luyện LLM, bạn hãy tham khảo nanoGPT của Andrej Karpathy.

# Bước 1: Thu Thập và Chuẩn Bị Văn Bản Lịch Sử

Thu thập các tệp .txt của sách, tài liệu, v.v. thuộc phạm vi công cộng trong khoảng thời gian bạn chọn (ví dụ: London 1800-1850)

Bạn có thể dùng download_texts_improved.py để tải sách nếu cần.

Làm sạch tệp văn bản bằng script hoặc thủ công để loại bỏ header/footer của Project Gutenberg, chú thích hiện đại hoặc lỗi OCR.

prepare_dataset.py nên hoạt động tốt.

# Bước 2: Xây Dựng Tokenizer Tùy Chỉnh

Chạy train_tokenizer.py hoặc train_tokenizer_hf.py trên dữ liệu đã làm sạch.
Bạn sẽ nhận được vocab.json và merges.txt

Các tệp này xác định từ vựng và quy tắc gộp cho mô hình của bạn

# Bước 3: Huấn Luyện Mô Hình (nanoGPT)

Tham khảo [nanoGPT của Andrej Karpathy](https://github.com/karpathy/nanoGPT) để biết quy trình huấn luyện.

Bạn có thể huấn luyện LLM khác nếu muốn, nhưng tôi dùng nanoGPT

# Hỏi Đáp

## Huấn Luyện Thời Gian Có Chọn Lọc là gì?

Huấn Luyện Thời Gian Có Chọn Lọc (Selective Temporal Training - STT) là phương pháp học máy trong đó toàn bộ dữ liệu huấn luyện được tuyển chọn để nằm trong một giai đoạn lịch sử nhất định. Điều này nhằm mô phỏng ngôn ngữ và kiến thức của thời kỳ đó mà không bị ảnh hưởng bởi các khái niệm hiện đại. Ví dụ, mô hình hiện tại của tôi (v0.5) được huấn luyện hoàn toàn bằng dữ liệu từ 1800-1875, không tinh chỉnh mà huấn luyện từ đầu nên đầu ra phản ánh đúng phong cách ngôn ngữ và bối cảnh lịch sử thời đó.

## Tại sao không chỉ tinh chỉnh hoặc dùng LoRA?

Trong dự án này, tôi muốn tạo một mô hình ngôn ngữ không bị ảnh hưởng bởi thành kiến hiện đại. Nếu tôi tinh chỉnh một mô hình như GPT-2, nó đã được huấn luyện sẵn và thông tin đó không thể mất đi. Nếu huấn luyện từ đầu, mô hình sẽ không giả vờ cổ xưa, nó thực sự là như vậy. Mục tiêu dự án lúc này là tạo ra một thứ có thể suy luận chỉ dựa trên kiến thức từ các sách London xuất bản trong khoảng 1800-1850.

## Bạn đã dùng dữ liệu gì để huấn luyện?

Tôi dùng sách, tài liệu pháp lý, báo chí và các bài viết khác từ London 1800–1850. Danh sách tôi đã liên kết có khoảng 200 tài liệu nhưng huấn luyện đầu tiên tôi chỉ dùng 50 tệp khoảng ~187 MB. Bạn có thể xem danh sách tài liệu tại:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## Mô Hình Phiên Bản 0 lớn cỡ nào?

Mô hình này hiện rất nhỏ, tôi chỉ làm cho vui và tuân thủ nghiêm ngặt quy tắc không dùng nguồn hiện đại. Nó có gần 16 triệu tham số nhưng tôi sẽ bắt đầu thu thập thêm văn bản cổ để bắt đầu huấn luyện mô hình mới. Sẽ cập nhật tiến độ sau.

## Thông Số Huấn Luyện?

GPU: Geforce rtx 4060
CPU: i5-13400F
Ram: 16GB DDR5.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-21

---