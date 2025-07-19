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


[English](https://raw.githubusercontent.com/sz30/2048-magic/main/README.md) | [简体中文](https://raw.githubusercontent.com/sz30/2048-magic/main/README.zh-CN.md) | [繁體中文](https://raw.githubusercontent.com/sz30/2048-magic/main/README.zh-TW.md)

# 🎮 2048++

Một phiên bản nâng cấp của trò chơi 2048 cổ điển, giờ đây với nhiều tính năng thú vị hơn! Đây là một dự án nhỏ tôi thực hiện vào thời gian rảnh — mong rằng nó sẽ mang lại niềm vui cho bạn!

## 🎯 Giới thiệu trò chơi

2048 là một trò chơi hợp nhất số đơn giản nhưng gây nghiện. Trên bàn cờ 4x4, bạn vuốt lên, xuống, trái hoặc phải để hợp nhất các ô có cùng số. Mục tiêu? Đạt đến 2048 (nhưng bạn có thể tiếp tục để đạt điểm cao hơn nữa)!

**Cách chơi:**
- Sử dụng phím mũi tên hoặc WASD để di chuyển các ô.
- Khi hai ô có cùng số va chạm, chúng sẽ hợp nhất thành một ô.
- Sau mỗi lần di chuyển, một số 2 hoặc 4 mới sẽ xuất hiện ngẫu nhiên ở một ô trống.
- Trò chơi kết thúc khi không còn nước đi nào nữa.

## ✨ Tính năng đặc biệt

### 1. Chức năng Hoàn tác
- Di chuyển sai? Đừng lo!
- Chỉ cần nhấn nút "Hoàn tác" để quay lại một bước trước đó.
- Bạn có thể hoàn tác bao nhiêu lần tùy thích, quay lại tận lúc bắt đầu.
- Đừng để một cú nhấp nhầm làm hỏng ván chơi của bạn nữa!

### 2. Chế độ gian lận bí mật
- Nhập chuỗi ma thuật: ←←→→ →→←← (trái, trái, phải, phải,  phải, phải, trái, trái)
- Tất cả các ô sẽ biến thành 128 một cách kỳ diệu!
- Đây là một Easter egg, chỉ để vui thôi.
- Mẹo: Gian lận thì vui, nhưng đừng lạm dụng nhé! 😉

## 🎯 Demo

🎯 Chơi tại đây: [http://2048.ct8.pl](http://2048.ct8.pl:9969/)
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
**Mô tả tệp:**
- `2048.py`: Máy chủ backend viết bằng Flask, xử lý logic trò chơi và các yêu cầu API.
- `script.js`: Logic trò chơi frontend, bao gồm di chuyển, hoạt ảnh và các tính năng đặc biệt.
- `styles.css`: Định dạng trò chơi, đảm bảo giao diện đẹp và đáp ứng tốt.
- `index.html`: Trang chính để kết nối mọi thứ lại với nhau.

## 🚀 Bắt đầu nhanh

**Cách 1: Tải bản phát hành**
1. Tải xuống bản phát hành mới nhất.
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
## 🎨 Tuỳ chỉnh

Muốn làm nó theo ý bạn? Hãy chỉnh sửa `styles.css` để có giao diện mới, hoặc khám phá `script.js` để thay đổi cách chơi. Tất cả mã nguồn đều có chú thích rõ ràng để dễ dàng chỉnh sửa!

## 📝 Giấy phép

Giấy phép GPL-2.0

## 🤝 Đóng góp

Vẫn đang cập nhật! Các vấn đề và Pull Request luôn được hoan nghênh—hãy cùng nhau làm cho trò chơi này tuyệt vời hơn nữa!


## 🙏 Lời cảm ơn

Cảm ơn các nhà tài trợ sau đã hỗ trợ dự án này:
- [Serv00](https://www.serv00.com/) cung cấp máy chủ

---
_Cập nhật lần cuối: Tháng 6, 2025_



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-19

---