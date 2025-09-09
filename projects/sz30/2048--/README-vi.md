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
- Khi hai ô có cùng số va chạm, chúng sẽ hợp nhất thành một ô.
- Sau mỗi lần di chuyển, một số 2 hoặc 4 mới sẽ xuất hiện ngẫu nhiên ở một vị trí trống.
- Trò chơi kết thúc khi không còn nước đi nào nữa.

## ✨ Tính năng đặc biệt

### 1. Chức năng Hoàn tác
- Lỡ di chuyển sai? Đừng lo!
- Chỉ cần nhấn nút "Hoàn tác" để quay lại một bước.
- Bạn có thể hoàn tác bao nhiêu lần tùy thích, quay lại tận lúc bắt đầu.
- Đừng để một lần trượt tay phá hỏng cuộc chơi nữa nhé!

### 2. Chế độ gian lận bí mật
- Nhập chuỗi phép thuật: ←←→→ →→←← (trái, trái, phải, phải,  phải, phải, trái, trái)
- Tất cả các ô sẽ biến thành 128 một cách kỳ diệu!
- Đây là một trò vui ẩn, chỉ để giải trí thôi.
- Mẹo nhỏ: Gian lận thì vui, nhưng đừng quá lạm dụng nhé! 😉

## 🎯 Demo

🎯 : [Chơi tại đây](http://34.150.49.127:5000/)
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

Muốn biến nó thành của riêng bạn? Chỉnh sửa `styles.css` để tạo diện mạo mới, hoặc khám phá `script.js` để thay đổi cách chơi. Mọi đoạn mã đều được chú thích rõ ràng giúp bạn dễ dàng chỉnh sửa!

## 📝 Giấy phép

Giấy phép GPL-2.0

## 🤝 Đóng góp

Vẫn đang cập nhật! Mọi Vấn đề và Pull Request đều rất được hoan nghênh—hãy cùng nhau làm cho trò chơi này tuyệt vời hơn nữa nhé!


## 🙏 Lời cảm ơn

Cảm ơn các nhà tài trợ sau đã hỗ trợ cho dự án này:
- [Không có](https://#/) cung cấp máy chủ
- [Serv00](https://www.serv00.com/) cung cấp máy chủ

---
_Cập nhật lần cuối: Tháng 8, 2025_




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-09

---