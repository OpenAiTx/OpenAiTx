# Visage: ไลบรารี UI พบกับการเขียนโค้ดเชิงสร้างสรรค์

**Visage** คือไลบรารี C++ ข้ามแพลตฟอร์มที่เร่งด้วย GPU สำหรับ UI เนทีฟและกราฟิก 2D โดยผสานโครงสร้างของเฟรมเวิร์ก UI กับฟีเจอร์ของไลบรารีกราฟิกเชิงสร้างสรรค์

## ตัวอย่างพื้นฐานเต็ม
```cpp
#include <visage_app/application_window.h>

int main() {
  visage::ApplicationWindow app;

  app.onDraw() = [&app](visage::Canvas& canvas) {
    canvas.setColor(0xffff00ff);
    canvas.fill(0, 0, app.width(), app.height());
  };

  app.show(800, 600); // เปิดหน้าต่างขนาด 800 x 600 พิกเซล
  app.runEventLoop(); // รันเหตุการณ์ของหน้าต่าง คืนค่าเมื่อหน้าต่างถูกปิด
  return 0;
}
```

## ตัวอย่างสาธิต
- [Showcase](https://visage.dev/examples/Showcase/)
- [Blend Modes](https://visage.dev/examples/BlendModes/)
- [Bloom](https://visage.dev/examples/Bloom/)
- [Gradients](https://visage.dev/examples/Gradients/)
- [Post Shader Effects](https://visage.dev/examples/PostEffects/)
- [Live Shader Editing](https://visage.dev/examples/LiveShaderEditing/)
- [Layout Flexing](https://visage.dev/examples/Layout/)

## ฟีเจอร์ UI

- **การทำให้อีเวนต์เป็นมาตรฐานเดียวกัน**  
&nbsp;&nbsp;&nbsp;รองรับการป้อนข้อมูลแป้นพิมพ์และเมาส์ข้ามแพลตฟอร์มโดยปรับให้เป็นมาตรฐานเดียวกัน

- **การทำให้หน้าต่างเป็นมาตรฐานเดียวกัน**  
&nbsp;&nbsp;&nbsp;รองรับการเปิดและจัดการหน้าต่างข้ามแพลตฟอร์ม

- **การป้อนข้อความ**  
&nbsp;&nbsp;&nbsp;รองรับการป้อนข้อความยูนิโค้ดพร้อมแก้ไขข้อความหลายบรรทัด

- **✨ อิโมจิ ✨**  
&nbsp;&nbsp;&nbsp;หากคุณชอบสิ่งแบบนี้ 🤷

- **การเรนเดอร์บางส่วน**  
&nbsp;&nbsp;&nbsp;วาดซ้ำเฉพาะบริเวณที่เปลี่ยนแปลงเพื่อประสิทธิภาพสูงสุด

## ฟีเจอร์กราฟิก

- **การเคลื่อนไหวอย่างลื่นไหล**  
&nbsp;&nbsp;&nbsp;เฟรมใหม่แสดงตามอัตรารีเฟรชของหน้าจอและแอนิเมชันราบรื่น

- **การจัดกลุ่มรูปทรงอัตโนมัติ**  
&nbsp;&nbsp;&nbsp;จัดกลุ่มรูปทรงโดยอัตโนมัติสำหรับการเรนเดอร์ GPU ที่มีประสิทธิภาพ

- **โหมดผสมสี**  
&nbsp;&nbsp;&nbsp;รองรับการผสมชั้นเลเยอร์ด้วยการบวก, การลบ หรือการวาดหน้ากากกำหนดเองเพื่อให้ UI ผ่านได้

- **เชดเดอร์**  
&nbsp;&nbsp;&nbsp;เขียนเชดเดอร์เพียงครั้งเดียวและแปลงโค้ดให้สำหรับ Direct3D, Metal และ OpenGL

- **เอฟเฟกต์ที่รวมมา**  
&nbsp;&nbsp;&nbsp;เอฟเฟกต์แบบเรียลไทม์ เช่น เบลอขนาดใหญ่และบลูม

- **ความแม่นยำระดับพิกเซล**  
&nbsp;&nbsp;&nbsp;เข้าถึงขนาดพิกเซลอุปกรณ์เพื่อให้การเรนเดอร์แม่นยำไม่เบลอ

## แพลตฟอร์มที่รองรับ
- **Windows**: Direct3D11
- **MacOS**: Metal  
- **Linux**: Vulkan
- **Web/Emscripten**: WebGL

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---