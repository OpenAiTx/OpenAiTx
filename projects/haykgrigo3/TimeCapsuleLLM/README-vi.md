
<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN">简体中文</a>
        | <a href="#" title="Sắp ra mắt">繁體中文 (sắp ra mắt)</a> |
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko">한국어</a>
        | <a href="#" title="Sắp ra mắt">हिन्दी (sắp ra mắt)</a> |
        | <a href="#" title="Sắp ra mắt">ไทย (sắp ra mắt)</a> |
        | <a href="#" title="Sắp ra mắt">Français (sắp ra mắt)</a>
        | <a href="#" title="Sắp ra mắt">Deutsch (sắp ra mắt)</a>
        | <a href="#" title="Sắp ra mắt">Español (sắp ra mắt)</a>
        | <a href="#" title="Sắp ra mắt">Italiano (sắp ra mắt)</a>
        | <a href="#" title="Sắp ra mắt">Русский (sắp ra mắt)</a>
        | <a href="#" title="Sắp ra mắt">Português (sắp ra mắt)</a>
        | <a href="#" title="Sắp ra mắt">Nederlands (sắp ra mắt)</a>
        | <a href="#" title="Sắp ra mắt">Polski (sắp ra mắt)</a>
        | <a href="#" title="Sắp ra mắt">العربية (sắp ra mắt)</a>
        | <a href="#" title="Sắp ra mắt">فارسی (sắp ra mắt)</a>
        | <a href="#" title="Sắp ra mắt">Türkçe (sắp ra mắt)</a>
        | <a href="#" title="Sắp ra mắt">Tiếng Việt (sắp ra mắt)</a>
        | <a href="#" title="Sắp ra mắt">Bahasa Indonesia (sắp ra mắt)</a>

      </div>
    </div>
  </details>
</div>

# TimeCapsule LLM
Một mô hình LLM được huấn luyện chỉ trên dữ liệu từ các giai đoạn thời gian nhất định để giảm thiên vị hiện đại.

Hãy tưởng tượng nếu một mô hình AI không chỉ giả vờ là lịch sử mà thực sự đúng như vậy.

Được xây dựng trên [nanoGPT của Andrej Karpathy](https://github.com/karpathy/nanoGPT) Các tập lệnh huấn luyện cốt lõi và kiến trúc mô hình là của ông ấy.

# Mục tiêu dự án
TimeCapsule LLM là một dự án thử nghiệm chỉ được huấn luyện trên các văn bản được viết trong những khoảng thời gian nhất định. Mục tiêu là mô phỏng thế giới quan và ngôn ngữ của các thời kỳ lịch sử cụ thể.

# Tại sao tinh chỉnh thôi là chưa đủ

Nếu bạn chỉ tinh chỉnh một mô hình đã được huấn luyện trước, LLM của bạn vẫn sẽ biết các khái niệm hiện đại. Tất nhiên, đạt được mức độ không thiên vị hiện đại là rất khó nhưng tôi muốn tiến gần nhất có thể đến điều này. Để không có thiên vị hiện đại thì cần phải huấn luyện mô hình từ đầu.

# Kết quả kỳ vọng

Hy vọng khi hoàn thành, mô hình này sẽ không biết các khái niệm hiện đại và không thể suy luận vượt quá những gì đã được huấn luyện. Nó không nên nhận ra các từ vựng/khái niệm hiện đại và không nên tạo ra kiến thức hiện đại giả tưởng.

# Cập nhật tiến độ

## Ngày 9 tháng 7 năm 2025

Tôi đã chọn thời kỳ 1800-1850 và khu vực: London

Tôi đã thu thập danh sách các văn bản, sách, tài liệu

Hiện tại tôi đã có 50 tệp txt và sẽ bắt đầu huấn luyện NanoGPT sớm

Sẽ cập nhật tiếp khi có tiến triển

## Ngày 13 tháng 7 năm 2025

Đã huấn luyện nanoGPT với 187MB dữ liệu văn bản lịch sử.

## Ngày 15 tháng 7 năm 2025

Tôi bắt đầu tải về các văn bản cho lần huấn luyện thứ hai. Tôi lấy tất cả từ Internet Archive và đã mở rộng thời kỳ sang 1800-1875. Để có được nhiều loại văn bản đa dạng, bạn có thể sử dụng bộ lọc chủ đề và tìm kiếm theo vị trí xuất bản, thời kỳ và chủ đề trên Internet Archive.

![Bộ lọc tìm kiếm](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## Ngày 16 tháng 7 năm 2025

Tôi đã tải về khoảng 500 tệp txt từ Internet Archive và sau khi làm sạch chúng (chỉ xóa khoảng trắng, tiêu đề Gutenberg, v.v) tôi có khoảng 500MB dữ liệu. Đây là một bộ dữ liệu rất nhỏ nhưng lần trước tôi đã huấn luyện với 187MB nên chắc chắn sẽ có sự khác biệt rõ rệt nào đó trong đầu ra sau khi tôi huấn luyện mô hình thứ hai. Tôi hy vọng mô hình này ít nhất có thể tạo ra các câu mạch lạc hơn, có ý nghĩa hơn. Dĩ nhiên không có gì đảm bảo vì đây vẫn là bộ dữ liệu cực nhỏ, nhưng vẫn nhiều hơn lần trước.

Điều này có thể thực hiện được trên phần cứng của tôi, cũng tốt vì tôi hy vọng sẽ thấy một số cải tiến trước khi chuyển sang bộ dữ liệu lớn hơn, cái mà sẽ buộc tôi phải thuê GPU. Nhưng đừng lo, tôi vẫn dự định sẽ thuê GPU sớm, tuy nhiên trước khi làm vậy tôi muốn đảm bảo bộ dữ liệu của mình được tuyển chọn và sạch nhất có thể. Một trong những vấn đề tôi gặp phải là khâu làm sạch, rất nhiều tệp txt có lẫn dữ liệu vô nghĩa. Các script tôi dùng để làm sạch có hiệu quả nhưng không hoàn toàn 100%.

Tôi sẽ huấn luyện bộ dữ liệu này hôm nay và quá trình sẽ mất khoảng 4-5 tiếng. Khi hoàn thành và tôi kiểm tra, tôi sẽ cập nhật tiến độ. Một lần nữa cảm ơn tất cả những ai đang quan tâm tới dự án của tôi, thậm chí có người gửi tôi các link tài nguyên OCR nên xin cảm ơn! Tôi hy vọng nhiều người sẽ thử làm điều này và thử nghiệm với bộ dữ liệu của chính họ.


## Ngày 12 tháng 8 năm 2025

Phiên bản 1 đã hoàn thành, phiên bản này sử dụng Phi 1.5 (700 triệu tham số) và được huấn luyện trên bộ dữ liệu gần 7000 văn bản. Cải tiến chính của mô hình này là khả năng đôi khi tham chiếu đến tên thật và các sự kiện lịch sử. Phiên bản 0 và 0.5 không thể làm được điều này, bất cứ khi nào tôi yêu cầu những mô hình đó bằng một câu như "Vào năm 1821" thì kết quả chỉ là các tưởng tượng, những thứ chưa từng xảy ra. Một ví dụ về điều này với Phiên bản 1:

Lời nhắc của tôi: Đó là năm Chúa chúng ta 1834,

Kết quả: "Đó là năm Chúa chúng ta 1834 và các con phố London đầy những cuộc biểu tình và kiến nghị. Lý do, như nhiều người kể lại, không bị ràng buộc ở phương diện cá nhân, nhưng đã được tiếp nhận trong cùng ngày của ngày Chúa Palmerston, công chúng sẽ nhận được một tuyên bố ngắn về những khó khăn mà ngày luật pháp đã đến với chúng ta. Đó là điều đáng tiếc sâu sắc, rằng các sự kiện hiện tại trong lịch sử thế giới rất rõ ràng, và sẽ được biết đến. Không đúng khi những người đầu tiên truyền giáo tại Jerusalem lại có một ghi chép rộng lớn và thú vị đến thế về thịnh vượng và phát triển" 

Ban đầu tôi nghĩ đây có thể là sự trùng hợp, nhưng hãy nhìn vào đây: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)


### Cập nhật quá trình huấn luyện 

Tôi bắt đầu huấn luyện trên một tập dữ liệu 435MB (108 triệu token), mọi thứ hiện đang diễn ra khá suôn sẻ. Độ mất mát huấn luyện giảm từ 10.9 xuống 4.9 chỉ sau 2800 lượt lặp đầu tiên. Tôi dự đoán sẽ mất khoảng 8 hoặc 9 giờ để hoàn thành. Tôi sẽ đăng cập nhật mới khi hoàn tất.

## Ngày 17 tháng 7 năm 2025

Việc huấn luyện cho mô hình thứ hai đã hoàn thành, chiếc 4060 của tôi mất khoảng 8 giờ 40 phút (3.900 lượt lặp/giờ) cho 33.000 lượt lặp (5 epoch). Độ mất mát huấn luyện cuối cùng là 3.73. Kết quả đầu ra thật sự rất tốt, mô hình tạo ra các câu theo phong cách thế kỷ 19 rất mạch lạc.

## Ngày 28 tháng 7 năm 2025 

Tôi đã tải lên v0.5 lên Hugging Face, [Xem tại đây](https://huggingface.co/haykgrigorian/TimeCapsuleLLM) nếu bạn muốn. Giờ đây bạn có thể tải repo của tôi và chạy nó tại máy cá nhân. Đáng tiếc nanoGPT không hoạt động trực tiếp với HuggingFace, nên bạn sẽ phải tải về và chạy mô hình tại máy.

Ngoài ra tôi sẽ bắt đầu chọn lọc dữ liệu cho lần huấn luyện tiếp theo, tôi tin là sẽ cần nhiều hơn khoảng 5-10 lần dữ liệu để đạt được khả năng suy luận.

## Ngày 2 tháng 8 năm 2025

Tôi sẽ bắt đầu làm việc trên Phiên bản 1 sớm thôi. Tôi sẽ cần chuyển từ kiến trúc của nanoGPT sang một thứ hiện đại hơn. Tôi có vài kiến trúc LLM mã nguồn mở đang cân nhắc, bao gồm: OpenLLaMA v3, Phi-2 và Qwen 1.5B. Và để hỗ trợ cho bước tiến lên V1, tôi cần chọn lọc một bộ dữ liệu huấn luyện lớn hơn và đa dạng hơn nhiều. Tôi sẽ cần ít nhất 5GB dữ liệu huấn luyện sạch.

# Hành vi & Giới hạn của mô hình V0

Các lời nhắc ban đầu cho thấy mô hình phản hồi bằng ngôn ngữ và hành vi của những năm 1800. Ví dụ, tôi hỏi "Who art Henry?" và nó trả lời "I know that man, I have did not a black, the storm." và vâng, câu này không có nghĩa gì nhưng LLM nhận ra tôi đang hỏi về một người.

![TimeLockLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

Không có đề cập đến các khái niệm hiện đại, kết quả đầu ra chủ yếu là từ ngữ và cách diễn đạt của những năm 1800.

Nó vẫn còn cần rất nhiều cải thiện, huấn luyện trên 187MB sẽ không tạo ra mô hình sinh văn bản với khả năng suy luận phức tạp. 

Hiện tại mô hình tạo ra các câu thiếu cấu trúc đầy đủ và nhìn chung là không có ý nghĩa, nhưng điều này là bình thường với kích thước dữ liệu huấn luyện.

# Hành Vi & Giới Hạn của Mô Hình V0.5

Đây là một cải tiến đáng kể so với mô hình trước. Phong cách viết và từ vựng mang màu sắc thời Victorian, và hầu như mọi câu đều đúng ngữ pháp với dấu câu chuẩn. Một lần nữa, mô hình được huấn luyện từ đầu nên nội dung vẫn tập trung vào các chủ đề của thế kỷ 19.

![Ví dụ đầu ra TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

Có rất nhiều thông tin tưởng tượng. Rất nhiều chi tiết (ngày tháng, sự kiện, nhân vật lịch sử) đều là bịa đặt. Ngoài ra, các câu không thực sự liên kết với nhau, đôi khi chỉ có 2 câu liên quan đến nhau nhưng ngoài ra thì không. Một vấn đề nữa là đôi khi xuất hiện dòng chân trang “Digitized by Google”, nên lần huấn luyện tới tôi thật sự phải đảm bảo văn bản được làm sạch kỹ. Nhìn chung tôi rất hài lòng với kết quả, dù chưa thể gọi là LLM nhưng chắc chắn là một trình tạo câu.

Tôi đang học hỏi rất nhiều và sẽ bắt đầu xác định điều cần cải thiện trong vài tuần tới. Tôi sẽ sớm tải lên các file!

# Hành Vi & Giới Hạn của Mô Hình V1

Tôi sẽ sớm tải lên một số đầu ra ví dụ và so sánh giữa 3 mô hình với cùng một đề bài. Tôi cũng sẽ tải lên V1 lên huggingface như phiên bản trước, bạn có thể tìm tài khoản huggingface của tôi tại đây: https://huggingface.co/haykgrigorian/TimeCapsuleLLM

# Kế Hoạch Sắp Tới

(Đã hoàn thành) Tôi sẽ bắt đầu phát triển phiên bản 0.5, thay vì huấn luyện với 50 cuốn sách, tôi sẽ huấn luyện với 500-600 cuốn. Hiện tại tôi đang huấn luyện nanoGPT với các sách từ năm 1800-1850 và cụ thể là từ London. Có một số thách thức như đảm bảo sách tôi tìm không bị cập nhật hoặc có diễn giải hiện đại, mà là sách gốc xuất bản đúng thời gian tôi chọn.

Tôi muốn huấn luyện một mô hình mới (v1) với tập dữ liệu lớn hơn nhiều, có thể lớn hơn 5-10 lần so với v0.5. Mục tiêu của tôi là xem liệu khả năng suy luận có xuất hiện chỉ từ Quá Trình Huấn Luyện Thời Gian Có Chọn Lọc hay không; đây sẽ là nhiệm vụ khó hơn và tôi cũng chưa chắc khả thi do hạn chế dữ liệu lịch sử. Trong vài tuần tới tôi sẽ cố gắng tổng hợp đủ dữ liệu cho tập 5-10GB. Tôi tin nếu có dữ liệu sạch, chất lượng cao và thuê được GPU, sẽ có tiến triển.

# Cách Sử Dụng Dự Án Này

Dự án này chủ yếu tập trung vào việc thu thập dữ liệu lịch sử, chuẩn bị cho huấn luyện và xây dựng tokenizer. Tôi sẽ không đề cập đầy đủ quá trình huấn luyện LLM, bạn có thể tham khảo nanoGPT của Andrej Karpathy.

# Bước 1: Thu Thập và Chuẩn Bị Văn Bản Lịch Sử

Thu thập các file .txt của sách, tài liệu trong phạm vi công cộng từ thời gian bạn chọn (ví dụ: London 1800-1850)

Bạn có thể sử dụng download_texts_improved.py để tải sách nếu cần.

Làm sạch các file văn bản bằng script hoặc thủ công để loại bỏ đầu trang/cuối trang từ Project Gutenberg, chú thích hiện đại hoặc các lỗi OCR.

prepare_dataset.py nên hoạt động tốt.

# Bước 2: Xây Dựng Tokenizer Tùy Chỉnh

Chạy train_tokenizer.py hoặc train_tokenizer_hf.py trên dữ liệu đã làm sạch.
Việc này sẽ tạo ra vocab.json và merges.txt
Các tệp này định nghĩa từ vựng và quy tắc ghép cho mô hình của bạn

# Bước 3: Huấn luyện Mô hình của bạn (nanoGPT)

Tham khảo [nanoGPT của Andrej Karpathy](https://github.com/karpathy/nanoGPT) cho quá trình huấn luyện.

Bạn có thể huấn luyện một LLM khác nếu muốn, nhưng tôi đã dùng nanoGPT

# Câu hỏi thường gặp

## Đào tạo Thời kỳ Chọn lọc (Selective Temporal Training) là gì?

Selective Temporal Training (STT) là một phương pháp học máy mà toàn bộ dữ liệu huấn luyện được chọn lọc để rơi vào một khoảng thời gian lịch sử cụ thể. Việc này nhằm mô phỏng ngôn ngữ và kiến thức của thời đại đó mà không bị ảnh hưởng bởi các khái niệm hiện đại. Ví dụ, mô hình hiện tại tôi đang có (v0.5) được huấn luyện hoàn toàn trên dữ liệu từ năm 1800-1875, không tinh chỉnh mà huấn luyện từ đầu nên kết quả phản ánh phong cách ngôn ngữ và bối cảnh lịch sử thời kỳ đó.

## Tại sao không chỉ dùng tinh chỉnh (fine-tuning) hoặc LoRA?

Với dự án này tôi muốn tạo một mô hình ngôn ngữ không bị ảnh hưởng bởi các thành kiến hiện đại. Nếu tôi tinh chỉnh thứ như GPT-2, nó đã được huấn luyện trước và thông tin đó sẽ không mất đi. Nếu tôi huấn luyện từ đầu thì mô hình ngôn ngữ sẽ không giả vờ là cổ xưa, nó thực sự sẽ như vậy. Mục tiêu hiện tại là tạo ra thứ gì đó chỉ có thể suy luận dựa trên kiến thức từ các sách London xuất bản trong giai đoạn 1800 đến 1850.

## Loại dữ liệu nào bạn dùng để huấn luyện?

Tôi sử dụng sách, tài liệu pháp luật, báo chí và các bài viết khác từ London giai đoạn 1800–1850. Danh sách tôi đính kèm có khoảng 200 tài liệu nhưng cho lần huấn luyện đầu tôi chỉ dùng 50 tệp khoảng ~187 MB. Bạn có thể xem danh sách tài liệu:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## Mô hình có kích thước bao nhiêu?

V0: 16M Tham số

V0.5: 123M Tham số

V1: 700M Tham số

# Thông số huấn luyện?

#V0/V0.5
GPU: Geforce rtx 4060
CPU: i5-13400F
Ram: 16GB DDR5.

#V1

GPU: A100 rented









---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-12

---