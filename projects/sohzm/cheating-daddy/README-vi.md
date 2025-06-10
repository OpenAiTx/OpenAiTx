# Cheating Daddy

> [!NOTE]  
> Sử dụng phiên bản MacOS và Windows mới nhất, các phiên bản cũ chỉ hỗ trợ hạn chế

> [!NOTE]  
> Trong quá trình thử nghiệm, nó sẽ không trả lời nếu bạn hỏi điều gì đó, bạn cần mô phỏng người phỏng vấn đặt câu hỏi, khi đó nó sẽ trả lời

Một trợ lý AI thời gian thực cung cấp hỗ trợ theo ngữ cảnh trong các cuộc gọi video, phỏng vấn, thuyết trình và họp bằng cách sử dụng chức năng chụp màn hình và phân tích âm thanh.

## Tính năng

- **Hỗ trợ AI trực tiếp**: Hỗ trợ thời gian thực sử dụng Google Gemini 2.0 Flash Live
- **Chụp màn hình & âm thanh**: Phân tích những gì bạn nhìn thấy và nghe thấy để phản hồi theo ngữ cảnh
- **Nhiều hồ sơ sử dụng**: Phỏng vấn, Cuộc gọi bán hàng, Họp kinh doanh, Thuyết trình, Đàm phán
- **Lớp phủ trong suốt**: Cửa sổ luôn hiển thị trên cùng có thể di chuyển đến bất cứ đâu
- **Chế độ click-through**: Làm cửa sổ trong suốt với các cú click khi cần thiết
- **Đa nền tảng**: Hoạt động trên macOS, Windows và Linux (kiểu vậy, không nên dùng, chỉ để thử nghiệm lúc này)

## Cài đặt

1. **Nhận khóa API Gemini**: Truy cập [Google AI Studio](https://aistudio.google.com/apikey)
2. **Cài đặt các phụ thuộc**: `npm install`
3. **Chạy ứng dụng**: `npm start`

## Sử dụng

1. Nhập khóa API Gemini vào cửa sổ chính
2. Chọn hồ sơ sử dụng và ngôn ngữ trong phần cài đặt
3. Nhấn "Start Session" để bắt đầu
4. Di chuyển cửa sổ bằng phím tắt
5. AI sẽ cung cấp hỗ trợ thời gian thực dựa trên màn hình của bạn và những gì người phỏng vấn hỏi

## Phím tắt

- **Di chuyển cửa sổ**: `Ctrl/Cmd + Các phím mũi tên` - Di chuyển cửa sổ
- **Click-through**: `Ctrl/Cmd + M` - Bật/tắt sự kiện chuột
- **Đóng/Quay lại**: `Ctrl/Cmd + \` - Đóng cửa sổ hoặc quay lại
- **Gửi tin nhắn**: `Enter` - Gửi văn bản đến AI

## Ghi âm thanh

- **macOS**: [SystemAudioDump](https://github.com/Mohammed-Yasin-Mulla/Sound) để ghi âm hệ thống 
- **Windows**: Ghi âm thanh loopback
- **Linux**: Đầu vào micro

## Yêu cầu

- Hệ điều hành tương thích Electron (macOS, Windows, Linux)
- Khóa API Gemini
- Quyền ghi màn hình
- Quyền truy cập micro/âm thanh

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---