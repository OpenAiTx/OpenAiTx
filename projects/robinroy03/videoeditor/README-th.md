<samp>
  
<h1>โปรแกรมตัดต่อวิดีโอแบบโอเพ่นซอร์ส</h1>
<p>ไม่ใช่แอปพลิเคชันตัดต่อวิดีโอธรรมดา ใช้ React, Remotion & TypeScript</p>
<br />

> [!NOTE]  
> แอปพลิเคชันนี้กำลังอยู่ในระหว่างการพัฒนาอย่างต่อเนื่อง นี่เป็นเวอร์ชัน MVP แรกเริ่ม กรุณาเข้าร่วม [Discord server](https://discord.gg/GSknuxubZK) หากคุณต้องการรันแอปนี้

<br />

<p align="center">
  <img src="https://raw.githubusercontent.com/robinroy03/videoeditor/main/public/screenshot-app.png" alt="React Video Editor Screenshot">
</p>
<p align="center">ทางเลือกโอเพ่นซอร์สสำหรับ Capcut, Canva และ RVE</p>
</samp>

## ✨คุณสมบัติ

- 🎬ตัดต่อวิดีโอแบบไม่เป็นเส้นตรง (Non Linear Video Editing)
- 🔀รองรับหลายแทร็ก (Multi-track Support)
- 👀ดูตัวอย่างสด (Live Preview)
- 📤ส่งออกวิดีโอ (Export Video)
- 📜ได้รับอนุญาตภายใต้ MIT

## 🐋การปรับใช้งาน

```
git clone https://github.com/robinroy03/videoeditor.git
cd videoeditor
docker compose up
```

## 🧑‍💻การพัฒนา

```
pnpm i
pnpm run dev (frontend)
pnpm dlx tsx app/videorender/videorender.ts (backend)
uv run backend/main.py
flip `isProduction` to `false` in `/app/utils/api.ts`

คุณจะต้องใช้ GEMINI_API_KEY หากต้องการใช้งาน AI
```

## 📃สิ่งที่ต้องทำ

ยังมีงานอีกมาก! สำหรับเริ่มต้น เราวางแผนที่จะรวม API ของ Remotion ทั้งหมด จะมีการเพิ่มโร้ดแมปที่เหมาะสมในเร็วๆ นี้ เข้าร่วม [Discord Server](https://discord.com/invite/GSknuxubZK) เพื่อรับข่าวสารและการสนับสนุน

## ❤️การมีส่วนร่วม

เรายินดีต้อนรับการมีส่วนร่วมจากคุณ! ❤️ ดู [คู่มือการมีส่วนร่วม](https://raw.githubusercontent.com/robinroy03/videoeditor/main/CONTRIBUTING.md)

## 📜สัญญาอนุญาต

โปรเจกต์นี้ได้รับอนุญาตภายใต้สัญญาอนุญาต MIT สัญญาอนุญาต [Remotion](https://github.com/remotion-dev/remotion/blob/main/LICENSE.md) ยังใช้กับส่วนที่เกี่ยวข้องของโปรเจกต์นี้ด้วย

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---