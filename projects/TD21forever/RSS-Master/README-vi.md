# RSS-Master

Tùy chỉnh lọc và sàng lọc nguồn RSS, sử dụng AI để tóm tắt, khái quát, đánh giá điểm, v.v. Phiên bản tối ưu hiệu năng, hỗ trợ xử lý bất đồng bộ và tóm tắt AI song song.

### Lời nói đầu

Đầu tháng 9, tôi bắt đầu sử dụng Inoreader + RSSHub để tổng hợp, đăng ký các nguồn RSS mà tôi quan tâm, kết hợp với Reeder để đọc, cố gắng kiểm soát hoàn toàn nguồn thông tin đầu vào hàng ngày. Sau một tháng, số lượng nguồn RSS ngày càng tăng, số lượng bài chưa đọc ngày càng nhiều, khiến tôi khá căng thẳng khi đọc. Vì vậy, tôi nghĩ liệu có cách nào để tùy chỉnh một số quy tắc lọc không, tốt nhất là có thể tích hợp AI hỗ trợ tôi đọc, giảm gánh nặng đọc cho tôi.

Inoreader có sẵn bộ lọc, nhưng chỉ để trả tiền cho chức năng này thì có vẻ không đáng; NewsBlur có "Intelligence Trainer" để phân loại thông minh, nhưng tôi thử đơn giản thì cảm thấy phản hồi không rõ ràng, trong thời gian ngắn không thấy được sự thông minh; Feedly vừa có lọc vừa có chức năng AI, nghe có vẻ đáp ứng nhu cầu của tôi, khi tôi đang do dự có nên chuyển từ Inoreader sang người dùng trả phí của Feedly thì tôi đã thấy hai dự án này

- [Để ChatGPT giúp chúng ta tóm tắt Hacker News](https://blog.betacat.io/post/2023/06/summarize-hacker-news-by-chatgpt/)
- [Hướng dẫn sử dụng RSS-GPT](http://yinan.me/rss-gpt-manual-zh.html)

Ý tưởng chung của hai dự án này đều là thông qua GitAction để thực thi một script, lấy thông tin rồi dùng API của Open AI để dịch, tóm tắt, sau đó render thành mẫu, triển khai lên GitHub Page. Cách làm trong RSS-GPT sẽ đáp ứng tốt hơn nhu cầu của tôi, bằng cách thực thi script theo định kỳ để trực tiếp lấy file xml của RSS, xử lý rồi triển khai xml lên GitHub Page, từ đó có thể lấy được link truy cập file xml này, cuối cùng để trình đọc đăng ký nguồn tin trực tiếp qua link này.

Tôi rất cần đồng bộ đa đầu của Inoreader, với các nguồn RSS mới thêm trong file cấu hình config, cần kịp thời thông báo đến Inoreader để đồng bộ, vì vậy tôi đã mở rộng ý tưởng từ [RSS-GPT](https://github.com/yinan-c/), gọi là RSS-Master.

### Tính năng nổi bật

- **Hỗ trợ xử lý song song**: Sử dụng bất đồng bộ và thread pool để xử lý song song nguồn RSS và tóm tắt AI, tăng tốc đáng kể
- **Cơ chế cache nâng cao**: Hệ thống cache ổn định hơn, ngăn ngừa mất dữ liệu và tăng hiệu năng truy cập lặp lại
- **Xử lý lỗi tốt hơn**: Mọi thao tác đều có xử lý lỗi đầy đủ và ghi log, cải thiện độ ổn định
- **Tối ưu trích xuất nội dung HTML**: Trích xuất thông minh nội dung bài viết, bỏ qua thông tin không liên quan, nâng cao chất lượng tóm tắt AI
- **Hỗ trợ API OpenAI mới nhất**: Tương thích hoàn toàn với phiên bản API OpenAI mới nhất
- **Thông tin thống kê chi tiết**: Sau khi xử lý cung cấp thời gian chạy, tỷ lệ thành công và thống kê chi phí
- **Hỗ trợ tạo file opml**: Cũng như chuyển đổi qua lại với config.yml: `script/convert_opml_to_yaml.sh` `script/convert_yaml_to_opml.sh`
- **Hỗ trợ quy tắc lọc tùy chỉnh**: Hỗ trợ hai loại include, exclude, với hai phạm vi title và article
- **Mô hình AI có thể tùy chỉnh**: Cấu hình sử dụng các mô hình OpenAI khác nhau qua biến môi trường
- **URL cơ sở tùy chỉnh**: Có thể cấu hình URL cơ sở truy cập file RSS, thuận tiện triển khai ở môi trường khác nhau
- **Notebook thử nghiệm tương tác**: Cung cấp Jupyter notebook để thử nghiệm các tính năng

### Cấu hình biến môi trường

Dự án hỗ trợ cấu hình các tham số sau qua file `.env`:

```
# Tham số bắt buộc
OPENAI_API_KEY=your_openai_api_key_here

# Tham số tùy chọn
RSS_BASE_URL=https://example.com/rss-feeds/  # URL cơ sở RSS
OPENAI_MODEL=gpt-4o-mini-2024-07-18          # Mô hình OpenAI
LOG_LEVEL=INFO                               # Mức độ log
PARALLEL_WORKERS=5                           # Số lượng xử lý song song
```

Bạn có thể sao chép file `.env.example` và đổi tên thành `.env`, sau đó sửa các giá trị tương ứng.

### Cải tiến hiệu năng

Phiên bản này so với bản gốc có các cải tiến hiệu năng sau:

1. **Xử lý song song nguồn RSS**: Sử dụng `asyncio` để xử lý đồng thời nhiều nguồn RSS
2. **Tóm tắt AI song song**: Dùng thread pool để xử lý đồng thời nhiều bài viết tóm tắt AI
3. **Tối ưu xử lý văn bản**: Cải tiến thuật toán trích xuất nội dung HTML, trích xuất thông minh hơn nội dung trọng điểm bài viết
4. **Xử lý file an toàn**: Áp dụng cơ chế ghi file an toàn, tránh mất dữ liệu khi chương trình bị crash
5. **Tối ưu sử dụng bộ nhớ**: Tối ưu cấu trúc dữ liệu và quy trình xử lý, giảm sử dụng bộ nhớ

### Hướng dẫn sử dụng

1. Clone dự án về máy
2. Cài đặt phụ thuộc: `pip install -r requirements.txt`
3. Tạo file `.env` và thiết lập khóa API OpenAI: `OPENAI_API_KEY=your_key`
4. Sửa `resource/config.yml` cấu hình nguồn RSS của bạn
5. Chạy `python main.py` để bắt đầu xử lý

### Kiểm thử và gỡ lỗi

Dự án cung cấp notebook thử nghiệm tương tác `test.ipynb`, có thể dùng để thử các tính năng:

1. Lấy và phân tích nguồn RSS
2. Tính năng bộ lọc
3. Tính năng tóm tắt AI
4. Cơ chế cache
5. URL cơ sở tùy chỉnh
6. Kiểm thử hiệu năng

Cách dùng:

```bash
# Cài đặt Jupyter
pip install jupyter

# Khởi động notebook
jupyter notebook test.ipynb
```

### Ví dụ quy tắc lọc tùy chỉnh

```yaml
- htmlUrl: http://www.smzdm.com
  name: c5738f
  text: 什么值得买 | 优惠精选
  url: http://feed.smzdm.com
  filters:
    - type: include
      field: title
      keywords:
        [
          '可乐',
          '雪碧',
          '芬达',
          '柠檬',
          '茶叶',
          '纸巾',
          '酒精',
          '湿纸巾',
          '餐巾纸',
        ]
```

### Ảnh chụp màn hình sử dụng

- Tính năng tóm tắt và khái quát AI

<div style="display: flex;">
    <img src="https://qiniu.dcts.top/typora/202310031757486.png" alt="image-20231003174334231" style="width: 45%;">
    <img src="https://qiniu.dcts.top/typora/202310031757686.png" alt="image-20231003175143405" style="width: 45%;">
</div>

- Lọc tùy chỉnh: lọc kênh giá tốt của "什么值得买", chỉ đề xuất các mặt hàng muốn tích trữ gần đây, như nước ngọt

<img src="https://qiniu.dcts.top/typora/%E4%BB%80%E4%B9%88%E5%80%BC%E5%BE%97%E4%B9%B0-%E6%B1%BD%E6%B0%B4.png" alt="image-20231003164248923" style="width: 400px; height: 400px;" />

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---