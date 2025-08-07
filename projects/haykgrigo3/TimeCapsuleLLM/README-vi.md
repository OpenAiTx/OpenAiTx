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
Một mô hình LLM chỉ được huấn luyện trên dữ liệu từ các thời kỳ nhất định để giảm thiên kiến hiện đại.

Hãy tưởng tượng nếu một mô hình AI không chỉ giả vờ là lịch sử mà thực sự là như vậy.

Được xây dựng trên [nanoGPT bởi Andrej Karpathy](https://github.com/karpathy/nanoGPT) Các tập lệnh huấn luyện cốt lõi và kiến trúc mô hình là của ông ấy.

# Mục tiêu dự án

TimeCapsule LLM là một dự án thử nghiệm chỉ được huấn luyện trên các văn bản được viết trong những thời kỳ nhất định. Mục tiêu là mô phỏng thế giới quan và ngôn ngữ của các thời đại lịch sử cụ thể.

# Tại sao chỉ tinh chỉnh là chưa đủ

Nếu bạn chỉ tinh chỉnh một mô hình đã được huấn luyện trước, LLM của bạn vẫn sẽ biết các khái niệm hiện đại. Dĩ nhiên đạt được mức độ không có thiên kiến hiện đại là rất khó nhưng tôi muốn đạt được gần nhất có thể. Để không có thiên kiến hiện đại đòi hỏi phải huấn luyện mô hình từ đầu.

# Kết quả kỳ vọng

Hy vọng khi hoàn thành, mô hình này sẽ không biết các khái niệm hiện đại và không thể suy luận vượt quá những gì nó đã được huấn luyện. Nó không nên nhận biết được khái niệm/từ vựng hiện đại và tôi hy vọng nó không bịa đặt kiến thức hiện đại.

# Cập nhật tiến độ

## Ngày 9 tháng 7, 2025

Tôi đã đặt thời kỳ cho dự án là 1800-1850 và khu vực: London

Tôi đã thu thập danh sách các văn bản, sách, tài liệu

Hiện tôi đã có được 50 tệp dạng txt và sẽ bắt đầu huấn luyện NanoGPT sớm

Sẽ tiếp tục cập nhật nếu có tiến triển

## Ngày 13 tháng 7, 2025

Đã huấn luyện nanoGPT với 187MB dữ liệu văn bản lịch sử.

## Ngày 15 tháng 7, 2025

Tôi bắt đầu tải về các văn bản cho lần huấn luyện thứ hai. Tôi lấy mọi thứ từ Internet Archive và đã mở rộng thời kỳ đến 1800-1875. Để có phạm vi văn bản đa dạng, bạn có thể dùng bộ lọc chủ đề và tìm kiếm theo vị trí xuất bản, thời kỳ và chủ đề trên Internet Archive.

![Bộ lọc tìm kiếm](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## Ngày 16 tháng 7, 2025

Tôi đã tải xuống khoảng 500 tệp txt từ Internet Archive và sau khi làm sạch (chỉ xóa khoảng trắng, tiêu đề Gutenberg, v.v.) tôi có khoảng 500MB dữ liệu. Đây là một tập dữ liệu nhỏ nhưng lần trước tôi chỉ huấn luyện với 187MB nên ít nhất cũng sẽ có sự khác biệt đáng chú ý về đầu ra sau khi tôi huấn luyện mô hình thứ hai. Tôi hy vọng mô hình này ít nhất có thể tạo ra các câu mạch lạc hơn, có ý nghĩa. Dĩ nhiên không phải đảm bảo vì đây vẫn là tập dữ liệu rất nhỏ, nhưng vẫn hơn lần trước.

Điều này có thể thực hiện trên phần cứng cá nhân của tôi, điều này cũng tốt vì tôi có thể hy vọng thấy được một số cải thiện trước khi chuyển sang tập dữ liệu lớn hơn cần thuê GPU. Nhưng đừng lo, tôi vẫn dự định thuê GPU sớm, nhưng trước đó tôi muốn đảm bảo tập dữ liệu của mình được chọn lọc và sạch nhất có thể. Một trong những vấn đề tôi gặp phải là làm sạch, nhiều tệp txt này bị lẫn chữ linh tinh. Các script tôi dùng để làm sạch hoạt động được nhưng không hiệu quả 100%.

Tôi sẽ huấn luyện tập dữ liệu này hôm nay và mất khoảng 4-5 giờ. Khi xong và kiểm tra, tôi sẽ cập nhật. Cảm ơn mọi người đã quan tâm đến dự án của tôi, thậm chí có vài người gửi tôi cả các tài nguyên OCR nên xin cảm ơn! Hy vọng sẽ có nhiều người thử làm điều này và thử nghiệm với bộ dữ liệu của riêng họ.


### Cập nhật huấn luyện

Tôi bắt đầu huấn luyện trên tập hợp 435MB (108 triệu token), hiện tại khá suôn sẻ. Độ mất mát huấn luyện giảm từ 10.9 xuống 4.9 sau 2800 lần lặp đầu tiên. Tôi dự đoán sẽ mất khoảng 8 hoặc 9 giờ để hoàn thành. Sẽ đăng cập nhật tiếp khi xong.

## Ngày 17 tháng 7, 2025

Đã hoàn thành huấn luyện cho mô hình thứ hai, chiếc 4060 của tôi mất khoảng 8 giờ 40 phút (3.900 vòng lặp/giờ) cho 33.000 vòng lặp (5 epoch). Độ mất mát huấn luyện cuối cùng là 3.73. Đầu ra thật sự tốt, giờ đây mô hình tạo ra các câu theo phong cách thế kỷ 19 rất mạch lạc.

## Ngày 28 tháng 7, 2025

Tôi đã tải lên bản v0.5 lên Hugging Face, [Xem tại đây](https://huggingface.co/haykgrigorian/TimeCapsuleLLM) nếu bạn muốn. Bạn có thể tải repo của tôi về và chạy cục bộ. Đáng tiếc nanoGPT không hoạt động trực tiếp với HuggingFace, nên bạn phải tải và chạy mô hình cục bộ.

Tôi cũng sẽ bắt đầu chọn lọc dữ liệu cho lần huấn luyện tiếp theo, tôi nghĩ sẽ cần khoảng 5-10 lần dữ liệu để đạt khả năng suy luận.

## Ngày 2 tháng 8, 2025

Tôi sẽ sớm bắt đầu làm việc cho Phiên bản 1. Tôi sẽ cần chuyển đổi từ kiến trúc của nanoGPT sang một thứ hiện đại hơn. Tôi đã cân nhắc vài kiến trúc LLM mã nguồn mở, gồm: OpenLLaMA v3, Phi-2 và Qwen 1.5B. Và để hỗ trợ chuyển sang V1, tôi sẽ phải chọn lọc một tập dữ liệu lớn và đa dạng hơn nhiều. Tôi sẽ cần ít nhất 5GB dữ liệu huấn luyện sạch.


# Hành Vi & Giới Hạn Của Mô Hình V0

Các prompt ban đầu cho thấy mô hình phản hồi bằng ngôn ngữ và hành vi của những năm 1800. Ví dụ, tôi đã nhập "Who art Henry?" và nó trả lời "I know that man, I have did not a black, the storm." và vâng, câu đó không có nghĩa gì nhưng LLM nhận ra tôi đang hỏi về một người.

![Kết Quả Mẫu TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

Không có đề cập đến các khái niệm hiện đại, kết quả chủ yếu chứa từ ngữ và cách diễn đạt của những năm 1800.

Nó vẫn cần rất nhiều cải thiện, việc huấn luyện từ 187MB sẽ không thể giúp bạn có một mô hình tạo ra văn bản với khả năng suy luận phức tạp.

Hiện tại nó tạo ra các câu thiếu cấu trúc đầy đủ và nhìn chung không có ý nghĩa gì, nhưng điều này là bình thường với kích thước dữ liệu huấn luyện như vậy.

# Hành Vi & Giới Hạn Của Mô Hình V0.5

Đây là một sự cải thiện đáng kể so với mô hình trước. Phong cách viết và từ vựng mang tính chất thời Victoria và gần như mọi câu đều đúng ngữ pháp với dấu câu đầy đủ. Và một lần nữa, đây là mô hình được huấn luyện từ đầu nên nó bám sát các chủ đề của những năm 1800.

![Kết Quả Mẫu TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

Có rất nhiều thông tin tưởng tượng. Rất nhiều (gần như 100%) chi tiết (ngày tháng, sự kiện, nhân vật lịch sử) đều là bịa đặt. Ngoài ra, các câu không thực sự liên kết với nhau, đôi khi có thể 2 câu có liên quan nhưng ngoài ra thì không. Một vấn đề nữa là đôi khi xuất hiện dòng footer “Digitized by Google” lạc lõng, nên lần huấn luyện tới tôi phải đảm bảo làm sạch dữ liệu thật kỹ. Nhìn chung tôi rất hài lòng với kết quả, nó chưa phải LLM nhưng chắc chắn là trình tạo câu.

Tôi học được rất nhiều và sẽ bắt đầu xác định những gì cần làm tốt hơn trong vài tuần tới. Tôi sẽ sớm tải lên các file!

# Kế Hoạch Sắp Tới

(Đã hoàn thành) Tôi sẽ bắt đầu làm việc trên phiên bản 0.5, thay vì huấn luyện với 50 cuốn sách, tôi sẽ huấn luyện với khoảng 500-600 cuốn. Hiện tại tôi đang huấn luyện nanoGPT với các sách từ 1800-1850 và cụ thể là từ London. Có những thách thức như đảm bảo các cuốn sách tôi tìm không bị chỉnh sửa hay thêm các diễn giải hiện đại mà là sách gốc xuất bản trong khoảng thời gian tôi chọn.

Tôi muốn huấn luyện một mô hình mới (v1) với tập dữ liệu lớn hơn nhiều, có thể gấp 5-10 lần cái tôi dùng cho v0.5. Mục tiêu của tôi là xem liệu khả năng suy luận có thể xuất hiện chỉ từ Quá Trình Huấn Luyện Theo Thời Gian Chọn Lọc hay không, đây sẽ là nhiệm vụ khó hơn và tôi cũng chưa chắc có thể do hạn chế dữ liệu lịch sử. Trong vài tuần tới, tôi sẽ cố gắng chọn lọc đủ dữ liệu cho một tập hợp 5-10GB. Tôi tin rằng nếu có dữ liệu sạch, chất lượng cao và thuê được GPU, sẽ có tiến triển.

# Cách Sử Dụng Dự Án Này

Dự án này chủ yếu tập trung vào việc chọn lọc dữ liệu lịch sử, chuẩn bị cho huấn luyện và xây dựng tokenizer. Tôi sẽ không hướng dẫn toàn bộ quá trình huấn luyện LLM, tham khảo nanoGPT của Andrej Karpathy để biết chi tiết.

# Bước 1: Thu Thập & Chuẩn Bị Văn Bản Lịch Sử

Thu thập các file .txt của các cuốn sách, tài liệu, v.v. thuộc phạm vi công cộng từ thời kỳ bạn chọn (ví dụ: London 1800-1850)

Bạn có thể sử dụng download_texts_improved.py để tải sách nếu cần.

Làm sạch các file văn bản bằng script hoặc xóa thủ công phần header/footer từ Project Gutenberg, chú thích hiện đại hay lỗi OCR.

prepare_dataset.py nên hoạt động tốt.

# Bước 2: Xây Dựng Tokenizer Tùy Chỉnh

Chạy train_tokenizer.py hoặc train_tokenizer_hf.py trên dữ liệu đã làm sạch.
Điều này sẽ tạo ra vocab.json và merges.txt

Các file này định nghĩa từ vựng và quy tắc gộp cho mô hình của bạn

# Bước 3: Huấn Luyện Mô Hình (nanoGPT)

Tham khảo [nanoGPT của Andrej Karpathy](https://github.com/karpathy/nanoGPT) để biết quy trình huấn luyện.

Bạn có thể huấn luyện LLM khác nếu muốn, nhưng tôi đã dùng nanoGPT

# FAQ

## Quá Trình Huấn Luyện Theo Thời Gian Chọn Lọc là gì?

Quá Trình Huấn Luyện Theo Thời Gian Chọn Lọc (Selective Temporal Training - STT) là một phương pháp học máy mà toàn bộ dữ liệu huấn luyện đều được chọn lọc để nằm trong một khoảng thời gian lịch sử cụ thể. Mục tiêu là mô hình hóa ngôn ngữ và tri thức của thời kỳ đó mà không chịu ảnh hưởng từ các khái niệm hiện đại. Ví dụ, mô hình hiện tại của tôi (v0.5) được huấn luyện chỉ từ dữ liệu 1800-1875, không tinh chỉnh mà huấn luyện từ đầu nên đầu ra phản ánh phong cách ngôn ngữ và bối cảnh lịch sử thời đó.

## Tại sao không chỉ tinh chỉnh hay dùng LoRA?

Với dự án này tôi muốn tạo ra một mô hình ngôn ngữ không bị ảnh hưởng bởi thiên kiến hiện đại. Nếu tôi tinh chỉnh GPT-2 chẳng hạn, nó đã được huấn luyện trước và thông tin đó không thể mất đi. Nếu tôi huấn luyện từ đầu thì mô hình sẽ không "giả vờ" là cổ xưa, mà nó thực sự như vậy. Mục tiêu dự án hiện tại là tạo ra thứ gì đó có thể suy luận chỉ dựa trên kiến thức từ các sách London xuất bản giữa 1800 và 1850.

## Bạn đã dùng loại dữ liệu nào để huấn luyện?

Tôi dùng sách, tài liệu pháp lý, báo chí và các văn bản khác từ London 1800–1850. Danh sách tôi đã dẫn có khoảng 200 tài liệu nhưng cho lần huấn luyện đầu tiên tôi chỉ dùng 50 file khoảng ~187 MB. Bạn có thể xem danh sách tài liệu tại:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## Mô hình Phiên bản 0 lớn cỡ nào?

Mô hình này hiện rất nhỏ, tôi chỉ làm cho vui và tuân thủ nghiêm ngặt quy tắc huấn luyện không dùng nguồn hiện đại. Nó có gần 16 triệu tham số nhưng tôi sẽ bắt đầu thu thập thêm các văn bản cổ để chuẩn bị cho lần huấn luyện mô hình tiếp theo. Sẽ cập nhật thêm khi có tiến triển.

## Thông Số Huấn Luyện?

GPU: Geforce rtx 4060
CPU: i5-13400F
Ram: 16GB DDR5.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-07

---