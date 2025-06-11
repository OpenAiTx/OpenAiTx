<div align="center">

<img alt="LOGO" src="https://avatars.githubusercontent.com/u/122017386" width="256" height="256" />

# Bert-VITS2

Xương sống VITS2 với bert đa ngôn ngữ

Để hướng dẫn nhanh, vui lòng tham khảo `https://raw.githubusercontent.com/fishaudio/Bert-VITS2/master/webui_preprocess.py`.

简易教程请参见 `https://raw.githubusercontent.com/fishaudio/Bert-VITS2/master/webui_preprocess.py`。

## 【Giới thiệu dự án】
# TTS tự hồi quy hoàn toàn mới dưới FishAudio [Fish-Speech](https://github.com/fishaudio/fish-speech) hiện đã khả dụng, đạt hiệu quả chuẩn SOTA mã nguồn mở hiện nay, và đang được duy trì liên tục, khuyên dùng dự án này như một sự thay thế cho BV2/GSV. Dự án này sẽ không được bảo trì trong thời gian ngắn.
## Video Demo: https://www.bilibili.com/video/BV18E421371Q
## Video trình chiếu kỹ thuật: https://www.bilibili.com/video/BV1zJ4m1K7cj
## Xin lưu ý, ý tưởng cốt lõi của dự án này xuất phát từ [anyvoiceai/MassTTS](https://github.com/anyvoiceai/MassTTS), một dự án tts rất tốt
## Demo của MassTTS là [Phiên bản AI của Feng Ge đánh giá Feng Ge thật, và tìm lại quả thận bị mất ở Tam Giác Vàng](https://www.bilibili.com/video/BV1w24y1c7z9)

[//]: # (## Dự án này không liên quan gì đến [PlayVoice/vits_chinese]&#40;https://github.com/PlayVoice/vits_chinese&#41;)

[//]: # ()
[//]: # (Kho lưu trữ này xuất phát từ việc một người bạn đã chia sẻ video AI của Feng Ge, tôi đã rất ấn tượng với hiệu quả trong đó, sau khi tự thử MassTTS tôi nhận thấy fs có khoảng cách nhất định về chất lượng âm thanh so với vits, và pipeline huấn luyện phức tạp hơn vits, vì vậy tôi đã theo ý tưởng đó để tích hợp bert)

## Những người đi đường trưởng thành / nhà thám hiểm / thuyền trưởng / tiến sĩ / sensei / thợ săn quỷ / mèo meo / V nên tham khảo code để tự học cách huấn luyện.

### Nghiêm cấm sử dụng dự án này cho bất kỳ mục đích nào vi phạm Hiến pháp nước Cộng hòa Nhân dân Trung Hoa, Bộ luật Hình sự nước Cộng hòa Nhân dân Trung Hoa, Luật xử lý vi phạm an ninh trật tự công cộng nước Cộng hòa Nhân dân Trung Hoa và Bộ luật Dân sự nước Cộng hòa Nhân dân Trung Hoa.
### Nghiêm cấm sử dụng cho bất kỳ mục đích chính trị nào.
#### Video: https://www.bilibili.com/video/BV1hp4y1K78E
#### Demo: https://www.bilibili.com/video/BV1TF411k78w
## Tài liệu tham khảo
+ [anyvoiceai/MassTTS](https://github.com/anyvoiceai/MassTTS)
+ [jaywalnut310/vits](https://github.com/jaywalnut310/vits)
+ [p0p4k/vits2_pytorch](https://github.com/p0p4k/vits2_pytorch)
+ [svc-develop-team/so-vits-svc](https://github.com/svc-develop-team/so-vits-svc)
+ [PaddlePaddle/PaddleSpeech](https://github.com/PaddlePaddle/PaddleSpeech)
+ [emotional-vits](https://github.com/innnky/emotional-vits)
+ [fish-speech](https://github.com/fishaudio/fish-speech)
+ [Bert-VITS2-UI](https://github.com/jiangyuxiaoxiao/Bert-VITS2-UI)
## Cảm ơn tất cả các đóng góp viên đã nỗ lực
<a href="https://github.com/fishaudio/Bert-VITS2/graphs/contributors" target="_blank">
  <img src="https://contrib.rocks/image?repo=fishaudio/Bert-VITS2"/>
</a>

[//]: # (# Mọi mã nguồn trong dự án đều đã được ghi rõ nguồn, phần ý tưởng code bert xuất phát từ [AI Feng Ge]&#40;https://www.bilibili.com/video/BV1w24y1c7z9&#41;, không liên quan gì đến [vits_chinese]&#40;https://github.com/PlayVoice/vits_chinese&#41;. Chào mừng mọi người xem xét code. Đồng thời, chúng tôi cũng lên án mạnh mẽ hành vi [đạo nhái, thậm chí bóc hộp nhà phát triển]&#40;https://www.bilibili.com/read/cv27101514/&#41; của nhà phát triển đó.)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---