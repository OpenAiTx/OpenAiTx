# Hand Gesture Arpeggiator

Arpeggiator, máy trống và bộ hiển thị hình ảnh phản ứng âm thanh điều khiển bằng tay. Giơ tay để "nâng mái nhà"!

Một ứng dụng web tương tác được xây dựng với threejs, mediapipe computer vision, rosebud AI và tone.js.

- Tay #1 điều khiển các arpeggio (giơ tay để tăng cao độ, chụm ngón tay để thay đổi âm lượng)
- Tay #2 điều khiển máy trống (giơ các ngón tay khác nhau để thay đổi mẫu nhịp)

[Video](https://youtu.be/JepIs-DTBgk?si=4Y-FrQDF6KNy662C) | [Trình diễn trực tiếp](https://collidingscopes.github.io/arpeggiator/) | [Thêm mã nguồn & Hướng dẫn](https://funwithcomputervision.com/)

<img src="https://raw.githubusercontent.com/collidingScopes/arpeggiator/main/assets/demo.png">

## Yêu cầu

- Trình duyệt web hiện đại hỗ trợ WebGL
- Bật quyền truy cập camera để nhận diện chuyển động tay

## Công nghệ

- **MediaPipe** để nhận diện bàn tay và cử chỉ
- **Three.js** để hiển thị hình ảnh phản ứng với âm thanh
- **Tone.js** cho âm thanh bộ tổng hợp
- **HTML5 Canvas** để phản hồi hình ảnh
- **JavaScript** cho tương tác thời gian thực
## Thiết lập cho Phát triển

```bash
# Sao chép kho lưu trữ này
git clone https://github.com/collidingScopes/arpeggiator

# Di chuyển vào thư mục dự án
cd arpeggiator

# Khởi chạy với phương pháp bạn ưa thích (ví dụ sử dụng Python)
python -m http.server
```

Sau đó truy cập vào `http://localhost:8000` trong trình duyệt của bạn.

## Giấy phép

Giấy phép MIT

## Ghi công
- Three.js - https://threejs.org/
- MediaPipe - https://mediapipe.dev/
- Rosebud AI - https://rosebud.ai/
- Tone.js - https://tonejs.github.io/

## Dự Án Liên Quan

Tôi đã phát hành một số dự án thị giác máy tính (bao gồm mã nguồn + hướng dẫn) tại đây:
[Fun With Computer Vision](https://www.funwithcomputervision.com/)

Bạn có thể mua quyền truy cập trọn đời và nhận đầy đủ tệp dự án cùng hướng dẫn. Tôi thường xuyên bổ sung thêm nội dung 🪬

Bạn cũng có thể thích một số dự án mã nguồn mở khác của tôi:

- [3D Model Playground](https://collidingScopes.github.io/3d-model-playground) - điều khiển mô hình 3D bằng giọng nói và cử chỉ tay
- [Threejs hand tracking tutorial](https://collidingScopes.github.io/threejs-handtracking-101) - Thiết lập cơ bản theo dõi bàn tay với threejs và thị giác máy tính MediaPipe
- [Particular Drift](https://collidingScopes.github.io/particular-drift) - Biến ảnh thành hoạt ảnh hạt chuyển động
- [Video-to-ASCII](https://collidingScopes.github.io/ascii) - Chuyển đổi video thành nghệ thuật pixel ASCII
## Liên hệ

- Instagram: [@stereo.drift](https://www.instagram.com/stereo.drift/)
- Twitter/X: [@measure_plan](https://x.com/measure_plan)
- Email: [stereodriftvisuals@gmail.com](https://raw.githubusercontent.com/collidingScopes/arpeggiator/main/mailto:stereodriftvisuals@gmail.com)
- GitHub: [collidingScopes](https://github.com/collidingScopes)

## Quyên góp

Nếu bạn thấy công cụ này hữu ích, hãy thoải mái mua cho tôi một ly cà phê.

Tôi tên là Alan, và tôi thích phát triển phần mềm mã nguồn mở cho thị giác máy tính, trò chơi và nhiều lĩnh vực khác. Điều này sẽ rất ý nghĩa trong những đêm lập trình khuya!

[![Buy Me A Coffee](https://www.buymeacoffee.com/assets/img/custom_images/yellow_img.png)](https://www.buymeacoffee.com/stereoDrift)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-11

---