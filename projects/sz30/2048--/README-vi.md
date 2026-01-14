<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ khác</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>


[English](https://raw.githubusercontent.com/sz30/2048--/main/README.md) | [简体中文](https://raw.githubusercontent.com/sz30/2048--/main/README.zh-CN.md) | [繁體中文](https://raw.githubusercontent.com/sz30/2048--/main/README.zh-TW.md)

# 🎮 2048++

Phiên bản nâng cấp của trò chơi 2048 kinh điển, nay có thêm nhiều tính năng thú vị hơn! Đây là một dự án nhỏ mình làm lúc rảnh—hi vọng sẽ mang đến cho bạn chút niềm vui!

## 🎯 Giới thiệu trò chơi

2048 là trò chơi gộp số đơn giản nhưng gây nghiện. Trên bàn cờ 4x4, hãy vuốt lên, xuống, trái, phải để hợp nhất các ô có cùng số. Mục tiêu? Đạt 2048 (nhưng bạn có thể tiếp tục để ghi điểm cao hơn nữa)!

**Cách chơi:**
- Dùng phím mũi tên hoặc WASD để di chuyển các ô số.
- Khi hai ô có cùng số va chạm nhau, chúng sẽ hợp thành một ô.
- Sau mỗi lượt di chuyển, một số 2 hoặc 4 mới sẽ xuất hiện ngẫu nhiên ở một vị trí trống.
- Trò chơi kết thúc khi không còn lượt di chuyển nào nữa.

## ✨ Tính năng đặc biệt

### 1. Chức năng Hoàn tác
- Di chuyển sai? Đừng lo!
- Chỉ cần nhấn nút "Hoàn tác" để quay lại một bước.
- Bạn có thể hoàn tác bao nhiêu lần tùy thích, quay lại từ đầu cũng được.
- Đừng để một cú chạm nhầm làm hỏng cả ván chơi của bạn!

### 2. Chế độ gian lận bí mật
- Nhập chuỗi ma thuật: ←←→→ →→←← (trái, trái, phải, phải,  phải, phải, trái, trái)
- Tất cả ô sẽ biến thành số 128 một cách kỳ diệu!
- Đây là một "Easter egg", chỉ để vui thôi.
- Mẹo: Gian lận rất vui, nhưng đừng lạm dụng nhé! 😉

## 🎯 Demo

🎯 : [Chơi ngay](http://2048.765431.xyz/)
<img width="1279" alt="demo" src="https://github.com/user-attachments/assets/0df2c956-b6d9-4371-a916-f6ac3ae642be" />



## 📁 Cấu trúc dự án
```
2048/
├── static/
│ ├── css/
│ │ └── styles.css # Game styles
│ └── js/
│ └── script.js # Frontend game logic
├── index.html # Main game page
└── 2048.py # Backend server
```
**Mô tả tập tin:**
- `2048.py`: Máy chủ backend viết bằng Flask, xử lý logic trò chơi và các yêu cầu API.
- `script.js`: Logic trò chơi phía frontend, bao gồm di chuyển, hoạt ảnh và các tính năng đặc biệt.
- `styles.css`: Định kiểu cho trò chơi, đảm bảo mọi thứ đẹp và đáp ứng tốt trên các thiết bị.
- `index.html`: Trang chính, kết nối tất cả các thành phần lại với nhau.

## 🚀 Bắt đầu nhanh

**Cách 1: Tải bản phát hành**
1. Tải phiên bản mới nhất.
2. Đảm bảo bạn đã cài đặt Python 3.x.
3. Cài đặt các phụ thuộc: `pip install flask`
4. Chạy: `python 2048.py`
5. Mở trình duyệt và truy cập: [http://localhost:9969](http://localhost:9969)

**Cách 2: Clone từ GitHub**
```bash
git clone https://github.com/sz30/2048.git
cd 2048
pip install flask
python 2048.py
```

## 🎨 Tùy chỉnh

Muốn cá nhân hóa? Hãy chỉnh sửa `styles.css` để thay đổi giao diện, hoặc khám phá `script.js` để làm mới lối chơi. Tất cả mã nguồn đều có chú thích rõ ràng, dễ dàng cho việc tùy biến!

## 📝 Giấy phép

Giấy phép GPL-2.0

## 🤝 Đóng góp

Vẫn đang cập nhật! Rất hoan nghênh các Vấn đề và Yêu cầu Kéo—hãy cùng nhau làm cho trò chơi này tuyệt vời hơn nữa nhé!


## 🙏 Ghi nhận

Xin cảm ơn các nhà tài trợ sau đã hỗ trợ dự án này:
- [/](/) cung cấp máy chủ

## Lịch sử Sao

[![Biểu đồ Lịch sử Sao](https://api.star-history.com/svg?repos=sz30/2048--&type=date&legend=top-left)](https://www.star-history.com/#sz30/2048--&type=date&legend=top-left)

---
_Cập nhật lần cuối: Tháng 10, 2025_




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-14

---