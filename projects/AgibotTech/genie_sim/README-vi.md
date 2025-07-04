![image.png](https://raw.githubusercontent.com/AgibotTech/genie_sim/main/./docs/image.jpg)
<div align="center">
  <a href="https://github.com/AgibotTech/genie_sim">
    <img src="https://img.shields.io/badge/GitHub-grey?logo=GitHub" alt="GitHub">
  </a>
  <a href="https://huggingface.co/datasets/agibot-world/GenieSimAssets">
    <img src="https://img.shields.io/badge/HuggingFace-yellow?logo=HuggingFace" alt="HuggingFace">
  </a>
  <a href="https://agibot-world.com/sim-evaluation">
    <img src="https://img.shields.io/badge/Genie%20Sim%20Benchmark-blue?style=plastic" alt="Genie Sim Benchmark">
  </a>
  <a href="https://genie.agibot.com/en/geniestudio">
    <img src="https://img.shields.io/badge/Genie_Studio-green?style=flat" alt="Genie Studio">
  </a>
</div>

# 1. Genie Sim Benchmark
Genie Sim là một khung mô phỏng từ AgiBot, cung cấp cho các nhà phát triển khả năng tạo dữ liệu hiệu quả và các tiêu chuẩn đánh giá để tăng tốc phát triển trí tuệ hiện thân. Genie Sim đã xây dựng một quy trình khép kín toàn diện, bao gồm tạo quỹ đạo, huấn luyện mô hình, đánh giá chuẩn và xác thực triển khai. Người dùng có thể nhanh chóng xác thực hiệu suất thuật toán và tối ưu hóa mô hình thông qua chuỗi công cụ mô phỏng hiệu quả này. Dù là nhiệm vụ gắp nhặt đơn giản hay các thao tác phức tạp tầm xa, Genie Sim đều có thể cung cấp môi trường mô phỏng chân thực cao và các chỉ số đánh giá chính xác, giúp các nhà phát triển hoàn thành hiệu quả quá trình phát triển và lặp lại công nghệ robot.

Genie Sim Benchmark, với vai trò là phiên bản đánh giá mã nguồn mở của Genie Sim, hướng tới việc cung cấp kiểm thử hiệu suất chính xác và hỗ trợ tối ưu hóa cho các mô hình AI hiện thân.

# 2. Tính năng
- Cấu hình mô phỏng linh hoạt, thân thiện với người dùng và giao diện dễ sử dụng
- Các bài đánh giá mô phỏng và nhiệm vụ thao tác cho hơn 10 nhiệm vụ điều khiển
- Khả năng điều khiển từ xa dựa trên VR và bàn phím
- Ghi lại và phát lại vị trí tất cả các khớp và vị trí đầu cuối hiệu quả
- Hơn 550 môi trường mô phỏng 3D trung thực cao và chính xác vật lý cùng các tài sản đi kèm
- Các chỉ số đánh giá được chuẩn hóa để định lượng hiệu suất của các mô hình AI hiện thân
- Kết quả đánh giá đạt sai số đánh giá mô phỏng-thực tế nhỏ hơn 5% trên mô hình GO-1
- Hỗ trợ mô hình baseline UniVLA trong đánh giá mô phỏng

# 3. Cập nhật
- [25/6/2025] v2.1
  - Thêm 10 nhiệm vụ thao tác mới cho Agibot World Challenge 2025 bao gồm tất cả tài sản mô phỏng
  - Mở mã nguồn bộ dữ liệu tổng hợp cho 10 nhiệm vụ thao tác trên Huggingface
  https://huggingface.co/datasets/agibot-world/AgiBotWorldChallenge-2025/tree/main/Manipulation-SimData
  - Tích hợp chính sách UniVLA và hỗ trợ đánh giá mô phỏng suy luận mô hình
  - Cập nhật sdk giải IK hỗ trợ giải IK xuyên hiện thân cho các robot khác
  - Tối ưu hóa khung giao tiếp và tăng tốc độ chạy mô phỏng lên gấp 2 lần
  - Cập nhật khung đánh giá tự động cho các nhiệm vụ phức tạp tầm xa hơn

# 4. Nội dung

## 4.1 Giới thiệu
Các bộ tiêu chuẩn mô phỏng trí tuệ hiện thân trong Genie Sim được thiết kế để đánh giá và thúc đẩy phát triển các mô hình AI hiện thân. Những tiêu chuẩn này cung cấp môi trường chân thực, nhiệm vụ đa dạng và các chỉ số chuẩn hóa để đo lường hiệu suất của hệ thống AI robot, giúp giảm yêu cầu về phần cứng vật lý đắt đỏ và kiểm thử thực tế, tránh các kịch bản kiểm thử nguy hiểm và tăng tốc quá trình huấn luyện, đánh giá của các tác tử AI.

## 4.2 Bắt đầu
Vui lòng tham khảo [trang này](https://agibot-world.com/sim-evaluation/docs/#/v2) để biết hướng dẫn cài đặt, hướng dẫn sử dụng và tham chiếu API

## 4.3 Hỗ trợ
<img src="https://raw.githubusercontent.com/AgibotTech/genie_sim/main/./docs/wechat.JPEG" width="30%"/>

## 4.4 Danh sách TODO
- [x] Phát hành thêm các nhiệm vụ thao tác chuẩn dài hạn
- [x] Thêm nhiều cảnh và tài sản cho mỗi nhiệm vụ chuẩn
- [x] Hỗ trợ mô hình baseline Agibot World Challenge
- [ ] Bộ công cụ tổng quát hóa bố cục kịch bản và quỹ đạo thao tác

## 4.5 Câu hỏi thường gặp
- Làm thế nào để tắt máy chủ isaac sim khi xảy ra lỗi khiến tiến trình không phản hồi?
  Kết thúc tiến trình trong terminal bằng `pkill -9 -f raise_standalone_sim`
- Làm thế nào để chọn các chế độ kết xuất khác nhau?
  Chế độ kết xuất mặc định là `RaytracedLighting(RealTime)`. Đối với các nhiệm vụ chứa vật thể trong suốt, sử dụng `RealTimePathTracing(RealTime-2.0)` để đảm bảo quan hệ phối cảnh của vật thể

## 4.6 Giấy phép và Trích dẫn
Tất cả dữ liệu và mã nguồn trong repo này đều thuộc giấy phép Mozilla Public License 2.0
Vui lòng trích dẫn công trình của chúng tôi theo một trong các cách dưới đây nếu nó hữu ích cho nghiên cứu của bạn.
```
@misc{2025geniesim,
  title={GenieSim},
  author={GenieSim Team},
  year={2025},
  url={https://github.com/AgibotTech/genie_sim}
}
```

## 4.7 Tham khảo
1. PDDL Parser (2020). Phiên bản 1.1. [Mã nguồn]. https://github.com/pucrs-automated-planning/pddl-parser.
2. BDDL. Phiên bản 1.x.x [Mã nguồn]. https://github.com/StanfordVL/bddl
3. CUROBO [Mã nguồn]. https://github.com/NVlabs/curobo
4. Isaac Lab [Mã nguồn]. https://github.com/isaac-sim/IsaacLab
5. Omni Gibson [Mã nguồn]. https://github.com/StanfordVL/OmniGibson

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-04

---