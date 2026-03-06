
<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

Auto bind Python from CC++
===================

> โครงการที่เรียบง่ายและใช้งานง่าย พร้อมความสามารถในการกำหนดค่า สำหรับการผูกโค้ดจาก C/C++ เป็นโค้ด Python แบบอัตโนมัติและสร้างแพ็คเกจ whl

> โครงการนี้โคลนมาจาก:
https://github.com/Neutree/c_cpp_project_framework
และส่วนการคอมไพล์โค้ดยังคงเหมือนกับที่อยู่ในคลังต้นฉบับ
> ตัวอย่างโค้ดอ้างอิงสำหรับการผูกอัตโนมัติด้วย pybind11:
https://github.com/sipeed/MaixPy/tree/main/components/maix


## เริ่มต้นอย่างรวดเร็ว

* 1.คลoning repository นี้, เข้าไปที่ไดเรกทอรี /examples/demo
ใช้ python project.py menuconfig เพื่อเข้าสู่หน้าต่างกราฟิกสำหรับกำหนดค่าชุดเครื่องมือคอมไพล์ และการแพ็คเกจไฟล์ whl
![alt text](https://raw.githubusercontent.com/Taoxuan-168/Auto-bind-Python-from-CC-/main/./assets/image.png)
> โดยที่ x86 คือคอมไพล์บนเครื่องปัจจุบัน, arm64 คือคอมไพล์สำหรับ MaixCam2, และ RISCV64 คือคอมไพล์สำหรับ MaiCam/Pro
![alt text](https://raw.githubusercontent.com/Taoxuan-168/Auto-bind-Python-from-CC-/main/./assets/image-1.png)
* 2.เขียนฟังก์ชัน C/C++ และไฟล์ hpp header โดยต้องตั้งชื่อไฟล์ให้เหมือนกับชื่อแพ็ก whl เพื่อให้ง่ายต่อการตรวจจับอัตโนมัติ:

```C++
namespace add::test
{
    int add(int a, int b) 
    {
        return a + b;
    }
}
```
ให้เขียน注释 @modul สำหรับฟังก์ชันที่เกี่ยวข้อง โดยตามด้วยเส้นทางของฟังก์ชัน:
```C++
namespace add::test
{
    /**
     * My function, add two integer.
     * @param a arg a, int type
     * @param b arg b, int type
     * @return int type, will a + b
     * @module add.test.add
     */
    int add(int a, int b);
}
```
บรรทัดแรกเป็นการแนะนำฟังก์ชัน, @param สำหรับอธิบายพารามิเตอร์, @return สำหรับอธิบายค่าที่คืน (สามารถเว้นว่างได้)
หากต้องการเพียงคอมไพล์และแพ็คเกจเป็นไฟล์ whl ไม่จำเป็นต้องแก้ไข main.cpp
เพียงใช้ python project build ก็สามารถเริ่มคอมไพล์และแพ็คเกจไฟล์ whl ได้ทันที
หลังจากคอมไพล์และติดตั้งไฟล์ whl แล้ว สามารถเรียกใช้งานได้โดยตรง:
```Python
import add
add.test.add(1,1)
```
ข้อควรระวัง:
-   ไฟล์หัวข้อหนึ่งแทนชื่อโมดูลหนึ่ง, หมายถึงโมดูลที่ต้อง import เช่น add.hpp ตรงกับ import add, โดยชื่อโมดูลต้องขึ้นต้นด้วย add
-   รัน cpp_bind_python.py โดยตรงจะสร้างเฉพาะไฟล์ cpp ที่ผูกไว้แล้ว, เพิ่ม --doc DOC เพื่อสร้างเอกสารอัตโนมัติจากคอมเมนต์

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-06

---