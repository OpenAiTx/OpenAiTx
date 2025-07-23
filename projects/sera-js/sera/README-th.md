<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>


![serajs (2)](https://github.com/user-attachments/assets/7ccff260-491d-420b-8e22-4579f9bad50a)

## 📖 **แนะนำเบื้องต้น**

> 📚 โปรเจกต์  —  seraJs

🔗(ผลงาน)[https://seraprogrammer.github.io/seraportfolio/]

🔗(บล็อกสาธิต)[https://seraprogrammer.github.io/serajsBlogsDemo/]


```bash
npx degit sera-js/template my-app
cd my-app
```
**SeraJS** คือไลบรารี JavaScript แบบ **reactive ที่ใช้สัญญาณ (signal-based)** และมีน้ำหนักเบา
สำหรับสร้างส่วนติดต่อผู้ใช้ (UI) แบบไดนามิก

ด้วยขนาดเพียง **969 ไบต์เมื่อบีบอัดด้วย gzip** และมีโค้ดแค่ **135 บรรทัด** จึงเป็นไลบรารี UI แบบ reactive ที่เบามาก — ให้การโต้ตอบที่ทรงพลังโดยมีโอเวอร์เฮดน้อยที่สุด

> ⚡️ _SeraJS เน้นที่ **ความเรียบง่าย** และ **ประสิทธิภาพ** โดยไม่ลดทอน
> ประสบการณ์ของนักพัฒนา_


*เปรียบเทียบขนาด Bundle (Minified + Gzipped)*

| ไลบรารี | ขนาด (gzipped) | ต้องใช้ขั้นตอน build หรือไม่ | จุดประสงค์หลัก | คุณสมบัติเด่น |
|---------|----------------|---------------------|-------------|--------------|
| SeraJS | 1.25kb | ไม่จำเป็น 😎 | Reactive UI | โค้ด 135 บรรทัด น้ำหนักเบามาก |
| React | ~40kb | ใช่ | UI components | Virtual DOM, โครงสร้างแบบคอมโพเนนต์, JSX |
| Vue | ~33kb | ไม่จำเป็น | Progressive framework | การ bind ข้อมูลแบบ reactive, ระบบคอมโพเนนต์, single-file components |
| Solid.js | ~7kb | ใช่ | Reactive UI | ไม่มี virtual DOM, เทมเพลตแบบคอมไพล์, การอัปเดตละเอียด |
| Alpine.js | ~7.1kb | ไม่ | เฟรมเวิร์กน้ำหนักเบา | จัดการ DOM น้อย, ไวยากรณ์ declarative, ใช้งานกับ HTML เดิมได้ |
| Preact | ~4kb | ใช่ | ทางเลือกของ React | API เข้ากันกับ React, ขนาดเล็ก, ประสิทธิภาพเร็ว |
| htmx | ~14kb | ไม่ | เพิ่มความสามารถ AJAX | ใช้แอตทริบิวต์ HTML กับ AJAX, JavaScript น้อย, เหมาะกับ server-side rendering |



---

## ⚙️ **แนวคิดหลัก**

### 🔄 **Reactivity ด้วย Signal**

SeraJS ใช้ **ระบบ reactive ที่อาศัย signal** ซึ่งเป็นแนวทางการจัดการสถานะ (state)
แบบสมัยใหม่ที่ช่วยให้อัปเดตได้อย่างมีประสิทธิภาพ:

- 🧠 **Signals**  
  ค่าที่ reactive ในตัวเองซึ่งจะคอยแจ้งเตือน subscriber เมื่อเปลี่ยนแปลง

- 🌀 **Effects**  
  ฟังก์ชันที่ทำงานซ้ำโดยอัตโนติเมื่อ dependencies (signal)  
  เปลี่ยนแปลง

- 🧭 **Memo**  
  ตัวช่วย memoization คล้ายกับ `useMemo` ของ React ใช้สำหรับแคชผลลัพธ์  
  จากการคำนวณที่อาศัย dependencies แบบ reactive เพื่อหลีกเลี่ยงการคำนวณซ้ำที่ไม่จำเป็น

- 🔬 **การอัปเดตแบบละเอียด (Fine-Grained Updates)**  
  จะอัปเดตเฉพาะ DOM ที่ได้รับผลกระทบจากการเปลี่ยน state  
  ช่วยลดการ render ซ้ำ และทำงานได้เร็วมาก

> 💡 **SeraJS ถูกออกแบบมาให้ใช้งานง่าย เร็ว และเชื่อมต่อกับโปรเจกต์ใดก็ได้
> จึงเหมาะสำหรับงาน frontend ยุคใหม่**


## ทำไมต้อง SeraJS?

SeraJS รวบรวมข้อดีของไลบรารีอย่าง React, Solid และ Lit — ผสมผสานแนวคิดที่คุ้นเคยกับแนวทางใหม่ที่เรียบง่ายและเบาสุดๆ

ด้วยขนาดเพียง 1.25KB (gzip) และโค้ดเพียง 135 บรรทัด ไลบรารี reactive UI ตัวนี้ยังคงบางเบาสุดขีดแต่ยังมอบความสามารถด้านความ reactive ได้อย่างทรงพลัง

ไม่ว่าคุณจะต้องการระบบ build หรือชอบ workflow แบบไม่ต้อง build SeraJS ก็ตอบโจทย์ สามารถปรับให้เข้ากับสไตล์ dev ของคุณ — ใช้แบบที่ *คุณ* ต้องการ


## 🌱 **ตัวอย่างพื้นฐาน Sera.js**

ตัวอย่างสั้นๆ แสดงข้อความ Hello World ด้วย Sera.js

### 📄 App.jsx



```jsx
import { h } from "serajs";

export default function App() {
  return (
    <h1>Hello world</h1>
  );
}
```
## ไม่ต้องสร้าง ไม่ต้องมีการพึ่งพา


```html
<!DOCTYPE html>
<html>
  <head>
    <title>Sera js 😎</title>
  </head>
  <body>
    <script type="module">
      import { h, setSignal, setEffect } from "//unpkg.com/serajs";

      function Hello() {
        const [count, setCount] = setSignal(0);

        setEffect(() => {
          console.log(count());
        });

        return h(
          "div",
          null,
          h("h1", null, "Hello World!"),
          h("p", { style: { color: "red" } }, "Do you Like Serajs?"),
          h("h1", null, () => `Count: ${count()}`),
          h(
            "button",
            { onclick: () => setCount(count() + 1) },
            "Increase Count"
          )
        );
      }

      const root = document.body;
      root.appendChild(Hello());
    </script>
  </body>
</html>
```





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-16

---