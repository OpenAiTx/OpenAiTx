<samp>
  
<h1>Trình Biên Tập Video Mã Nguồn Mở</h1>
<p>Không phải ứng dụng Biên Tập Video thông thường, sử dụng React, Remotion & TypeScript.</p>
<br />

> [!NOTE]  
> Ứng dụng đang trong quá trình phát triển tích cực. Đây là phiên bản MVP sớm. Vui lòng tham gia [máy chủ Discord](https://discord.gg/GSknuxubZK) nếu bạn định chạy nó.

<br />

<p align="center">
  <img src="https://raw.githubusercontent.com/robinroy03/videoeditor/main/public/screenshot-app.png" alt="Ảnh chụp màn hình React Video Editor">
</p>
<p align="center">Một lựa chọn mã nguồn mở thay thế cho Capcut, Canva, và RVE.</p>
</samp>

## ✨Tính năng

- 🎬Biên tập video phi tuyến tính
- 🔀Hỗ trợ nhiều track
- 👀Xem trước trực tiếp
- 📤Xuất video
- 📜Cấp phép theo MIT

## 🐋Triển khai

```
git clone https://github.com/robinroy03/videoeditor.git
cd videoeditor
docker compose up
```

## 🧑‍💻Phát triển

```
pnpm i
pnpm run dev (frontend)
pnpm dlx tsx app/videorender/videorender.ts (backend)
uv run backend/main.py
flip `isProduction` sang `false` trong `/app/utils/api.ts`

Bạn cũng sẽ cần GEMINI_API_KEY nếu muốn sử dụng AI.
```

## 📃CẦN LÀM

Chúng tôi còn rất nhiều việc! Trước tiên, chúng tôi dự định tích hợp tất cả API của Remotion. Tôi sẽ sớm bổ sung lộ trình phù hợp. Tham gia [máy chủ Discord](https://discord.com/invite/GSknuxubZK) để nhận cập nhật và hỗ trợ.

## ❤️Đóng góp

Chúng tôi rất hoan nghênh sự đóng góp của bạn! ❤️ Xem [hướng dẫn đóng góp](https://raw.githubusercontent.com/robinroy03/videoeditor/main/CONTRIBUTING.md).

## 📜Giấy phép

Dự án này được cấp phép theo Giấy phép MIT. [Giấy phép Remotion](https://github.com/remotion-dev/remotion/blob/main/LICENSE.md) cũng áp dụng cho các phần liên quan của dự án.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---