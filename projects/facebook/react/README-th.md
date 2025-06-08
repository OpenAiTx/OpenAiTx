# [React](https://react.dev/) &middot; [![GitHub license](https://img.shields.io/badge/license-MIT-blue.svg)](https://github.com/facebook/react/blob/main/LICENSE) [![npm version](https://img.shields.io/npm/v/react.svg?style=flat)](https://www.npmjs.com/package/react) [![(Runtime) Build and Test](https://github.com/facebook/react/actions/workflows/runtime_build_and_test.yml/badge.svg)](https://github.com/facebook/react/actions/workflows/runtime_build_and_test.yml) [![(Compiler) TypeScript](https://github.com/facebook/react/actions/workflows/compiler_typescript.yml/badge.svg?branch=main)](https://github.com/facebook/react/actions/workflows/compiler_typescript.yml) [![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen.svg)](https://legacy.reactjs.org/docs/how-to-contribute.html#your-first-pull-request)

React เป็นไลบรารี JavaScript สำหรับสร้างส่วนติดต่อผู้ใช้

* **เชิงประกาศ (Declarative):** React ช่วยให้การสร้าง UI ที่โต้ตอบได้เป็นเรื่องง่าย ออกแบบมุมมองอย่างง่ายสำหรับแต่ละสถานะในแอปพลิเคชันของคุณ และ React จะอัปเดตและแสดงผลเฉพาะคอมโพเนนต์ที่เหมาะสมเมื่อข้อมูลของคุณเปลี่ยนไป มุมมองเชิงประกาศทำให้โค้ดของคุณคาดเดาได้ง่ายขึ้น เข้าใจง่ายขึ้น และแก้ไขข้อบกพร่องได้ง่ายขึ้น
* **เชิงคอมโพเนนต์ (Component-Based):** สร้างคอมโพเนนต์ที่แยกส่วนและดูแลสถานะของตัวเอง จากนั้นนำมาประกอบกันเพื่อสร้าง UI ที่ซับซ้อนขึ้น เนื่องจากตรรกะของคอมโพเนนต์ถูกเขียนด้วย JavaScript แทนที่จะเป็นเทมเพลต คุณจึงสามารถส่งผ่านข้อมูลที่ซับซ้อนได้อย่างง่ายดายและแยกสถานะออกจาก DOM
* **เรียนรู้ครั้งเดียว ใช้ได้ทุกที่ (Learn Once, Write Anywhere):** เราไม่กำหนดข้อสมมติใดๆ เกี่ยวกับเทคโนโลยีสแต็กที่เหลือของคุณ คุณจึงสามารถพัฒนาฟีเจอร์ใหม่ใน React ได้โดยไม่ต้องเขียนโค้ดเดิมใหม่ React ยังสามารถแสดงผลฝั่งเซิร์ฟเวอร์โดยใช้ [Node](https://nodejs.org/en) และรองรับแอปมือถือโดยใช้ [React Native](https://reactnative.dev/)

[เรียนรู้วิธีใช้ React ในโปรเจกต์ของคุณ](https://react.dev/learn)

## การติดตั้ง

React ถูกออกแบบมาให้สามารถนำไปใช้งานได้อย่างค่อยเป็นค่อยไปตั้งแต่แรกเริ่ม และ **คุณสามารถใช้ React เท่าที่คุณต้องการ ไม่ว่าจะมากหรือน้อยก็ตาม**:

* ใช้ [Quick Start](https://react.dev/learn) เพื่อทดลองใช้งาน React
* [เพิ่ม React ในโปรเจกต์ที่มีอยู่](https://react.dev/learn/add-react-to-an-existing-project) เพื่อใช้ React เท่าที่คุณต้องการ
* [สร้างแอป React ใหม่](https://react.dev/learn/start-a-new-react-project) หากคุณต้องการเครื่องมือ JavaScript ที่ทรงพลัง

## เอกสารประกอบ

คุณสามารถดูเอกสารของ React ได้ที่ [เว็บไซต์](https://react.dev/)

ดูหน้า [Getting Started](https://react.dev/learn) สำหรับภาพรวมแบบรวดเร็ว

เอกสารถูกแบ่งออกเป็นหลายส่วน:

* [Quick Start](https://react.dev/learn)
* [Tutorial](https://react.dev/learn/tutorial-tic-tac-toe)
* [Thinking in React](https://react.dev/learn/thinking-in-react)
* [Installation](https://react.dev/learn/installation)
* [Describing the UI](https://react.dev/learn/describing-the-ui)
* [Adding Interactivity](https://react.dev/learn/adding-interactivity)
* [Managing State](https://react.dev/learn/managing-state)
* [Advanced Guides](https://react.dev/learn/escape-hatches)
* [API Reference](https://react.dev/reference/react)
* [Where to Get Support](https://react.dev/community)
* [Contributing Guide](https://legacy.reactjs.org/docs/how-to-contribute.html)

คุณสามารถปรับปรุงเอกสารนี้ได้โดยส่ง pull request ไปยัง [repository นี้](https://github.com/reactjs/react.dev)

## ตัวอย่าง

เรามีตัวอย่างหลายรายการอยู่ที่ [เว็บไซต์](https://react.dev/) นี่คือตัวอย่างแรกสำหรับเริ่มต้น:

```jsx
import { createRoot } from 'react-dom/client';

function HelloMessage({ name }) {
  return <div>Hello {name}</div>;
}

const root = createRoot(document.getElementById('container'));
root.render(<HelloMessage name="Taylor" />);
```

ตัวอย่างนี้จะแสดงผล "Hello Taylor" ลงในคอนเทนเนอร์บนหน้าเว็บ

คุณจะสังเกตได้ว่าเราใช้ไวยากรณ์ที่คล้าย HTML; [เราเรียกมันว่า JSX](https://react.dev/learn#writing-markup-with-jsx) แม้จะไม่จำเป็นต้องใช้ JSX กับ React แต่ JSX จะช่วยให้โค้ดอ่านง่ายขึ้น และการเขียนก็คล้ายกับการเขียน HTML

## การมีส่วนร่วม

วัตถุประสงค์หลักของ repository นี้ คือการพัฒนาแกนหลักของ React ให้ดีขึ้น เร็วขึ้น และใช้งานง่ายขึ้น การพัฒนา React เกิดขึ้นอย่างเปิดเผยบน GitHub และเราขอขอบคุณชุมชนที่ช่วยรายงานข้อผิดพลาดและปรับปรุงต่างๆ อ่านรายละเอียดด้านล่างเพื่อเรียนรู้วิธีที่คุณสามารถมีส่วนร่วมในการพัฒนา React

### [จรรยาบรรณในการร่วมโครงการ](https://code.fb.com/codeofconduct)

Facebook ได้นำจรรยาบรรณในการร่วมโครงการมาใช้ ซึ่งเราคาดหวังให้ผู้มีส่วนร่วมในโปรเจกต์ทุกคนปฏิบัติตาม กรุณาอ่าน [ฉบับเต็ม](https://code.fb.com/codeofconduct) เพื่อให้เข้าใจว่าพฤติกรรมใดที่ยอมรับได้และไม่ได้รับการยอมรับ

### [คู่มือการมีส่วนร่วม](https://legacy.reactjs.org/docs/how-to-contribute.html)

อ่าน [คู่มือการมีส่วนร่วมของเรา](https://legacy.reactjs.org/docs/how-to-contribute.html) เพื่อเรียนรู้กระบวนการพัฒนา วิธีเสนอการแก้ไขข้อผิดพลาดและการปรับปรุง และวิธีสร้างและทดสอบการเปลี่ยนแปลงของคุณใน React

### [Good First Issues](https://github.com/facebook/react/labels/good%20first%20issue)

เพื่อช่วยให้คุณเริ่มต้นและคุ้นเคยกับกระบวนการมีส่วนร่วมของเรา เรามีรายชื่อ [Good First Issues](https://github.com/facebook/react/labels/good%20first%20issue) ซึ่งเป็นบั๊กที่มีขอบเขตจำกัด เหมาะสำหรับผู้เริ่มต้น

### ใบอนุญาต

React อยู่ภายใต้ [ใบอนุญาต MIT](./LICENSE)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---