
<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=matkuki&project=ExCo&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=matkuki&project=ExCo&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=matkuki&project=ExCo&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=matkuki&project=ExCo&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=matkuki&project=ExCo&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=matkuki&project=ExCo&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=matkuki&project=ExCo&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=matkuki&project=ExCo&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=matkuki&project=ExCo&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=matkuki&project=ExCo&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=matkuki&project=ExCo&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=matkuki&project=ExCo&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=matkuki&project=ExCo&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=matkuki&project=ExCo&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=matkuki&project=ExCo&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=matkuki&project=ExCo&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=matkuki&project=ExCo&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=matkuki&project=ExCo&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=matkuki&project=ExCo&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=matkuki&project=ExCo&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=matkuki&project=ExCo&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Ex&#46;Co&#46; <img src="https://github.com/matkuki/Ex-Co/blob/master/resources/exco-icon.png" align="top" width="48" height="48">
### คำอธิบาย: ###
Ex&#46;Co&#46; (Extensible Coder) เป็นโปรแกรมแก้ไขข้อความแบบ GUI ที่เขียนด้วยภาษา Python โดยใช้ไลบรารี PyQt/QScintilla พร้อมกับ lexer บางตัวที่มีใน Cython เพื่อเพิ่มประสิทธิภาพในการไฮไลท์ข้อความ
ฉันพัฒนาโปรแกรมนี้โดยคำนึงถึงความเรียบง่ายในการใช้งานและความสามารถในการขยายฟังก์ชัน<br>
สำหรับชุดโปรแกรมที่คอมไพล์ไว้ล่วงหน้าสำหรับ Windows สามารถดูได้ที่หน้าปล่อยเวอร์ชัน (https://github.com/matkuki/ExCo/releases/latest)
<br><br>
### เว็บไซต์: ###
http://matkuki.github.io/ExCo/
<br>
### วิดีโอฟีเจอร์โดยย่อ: ###
https://www.youtube.com/watch?v=v-7fqJGv7Ts&feature

### ใบอนุญาต: ###
__GNU General Public License v3.0__

ลิขสิทธิ์ (c) 2013-2025 Matic Kukovec. สงวนลิขสิทธิ์ทั้งหมด
  
#### ใบอนุญาตเพิ่มเติม: ####
ใบอนุญาตเพิ่มเติมทั้งหมดระบุไว้ที่ต้นไฟล์ซอร์สโค้ดแต่ละไฟล์ และในรูปแบบไฟล์ข้อความในไดเรกทอรี ```additional_licenses``` หากพบข้อผิดพลาดใด ๆ กรุณาแจ้งปัญหา
<br><br>

### คุณสมบัติบางส่วน: ###
- **ระบบจัดวางหน้าต่างหลายหน้าต่างแบบใหม่**
- ฟังก์ชันพื้นฐานของโปรแกรมแก้ไขข้อความทั้งหมด (คัดลอก, ตัด, วาง, ...)
- 'Function wheel' สำหรับเข้าถึงฟังก์ชันหลักของ Ex&#46;Co&#46; ได้อย่างรวดเร็ว
- รวม REPL (Read-Eval-Print Loop) ของ Python แบบบรรทัดเดียว/หลายบรรทัด เพื่อเข้าถึงและจัดการข้อความในแต่ละหน้าต่างแก้ไขและฟังก์ชันอื่น ๆ โดยตรง
- เปรียบเทียบความแตกต่างของข้อความ (ระหว่างหน้าต่างแก้ไขด้วย)
- รันคำสั่ง Terminal/Shell ได้โดยตรงจาก REPL (Windows หรือ Linux)
- สามารถเพิ่มฟังก์ชัน Python ที่คุณสร้างเอง
- ไฮไลท์ไวยากรณ์ภาษา: AVS, Ada, Bash, Batch, CMake, CPP, CSS, CSharp, CoffeeScript, Cython, D, Diff, Fortran, Fortran77, HTML, IDL, Java, JavaScript, Lua, Makefile, Matlab, Nim, Oberon, Octave, PO, POV, Pascal, Perl, PostScript, Properties, Python, RouterOS (MikroTik), Ruby, SQL, Spice, TCL, TeX, Text, VHDL, Verilog, XML และ YAML
- แสดงโครงสร้างโค้ดสำหรับ: 
    - Python 3
    - Nim
    - C
    - และจะมีเพิ่มเติมอีกในอนาคต ...
<br><br>

### แพลตฟอร์มที่รองรับ: ###
- __Windows__ ([มีไฟล์ไบนารีสำเร็จรูปให้ดาวน์โหลด](https://github.com/matkuki/ExCo/releases))
- __Linux__ (ทดสอบบน Ubuntu, Lubuntu, Mint, Fedora, Raspbian (Raspberry pi, pi2, pi3 และ pi4))
- __Mac OS__ (ขอขอบคุณ __zenlc2000__ สำหรับการทดสอบบน Mac OS 10.11)

### ข้อกำหนด: ###
- __Python__ 3.6 ขึ้นไป
- __แพ็กเกจ__ ติดตั้งด้วยคำสั่ง: `pip install -r requirements.txt` (ตรวจสอบไฟล์เพื่อรายละเอียดเพิ่มเติม)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-02

---