# อาร์เพจเจียเตอร์ควบคุมด้วยท่าทางมือ

อาร์เพจเจียเตอร์ เครื่องกลอง และตัวสร้างภาพตอบสนองกับเสียงที่ควบคุมด้วยมือ ยกมือขึ้นเพื่อยกระดับความมันส์!

เว็บแอปแบบอินเทอร์แอคทีฟที่สร้างด้วย threejs, mediapipe computer vision, rosebud AI, และ tone.js

- มือ #1 ควบคุมอาร์เพจจิโอ (ยกมือเพื่อเพิ่มระดับเสียง, หนีบนิ้วเพื่อปรับระดับความดัง)
- มือ #2 ควบคุมกลอง (ยกนิ้วต่างๆ เพื่อเปลี่ยนรูปแบบจังหวะ)

[วิดีโอ](https://youtu.be/JepIs-DTBgk?si=4Y-FrQDF6KNy662C) | [เดโมสด](https://collidingscopes.github.io/arpeggiator/) | [โค้ดและบทเรียนเพิ่มเติม](https://funwithcomputervision.com/)

<img src="https://raw.githubusercontent.com/collidingScopes/arpeggiator/main/assets/demo.png">

## ข้อกำหนด

- เว็บเบราว์เซอร์รุ่นใหม่ที่รองรับ WebGL
- อนุญาตการเข้าถึงกล้องสำหรับติดตามมือ

## เทคโนโลยีที่ใช้

- **MediaPipe** สำหรับการติดตามมือและจดจำท่าทาง
- **Three.js** สำหรับเรนเดอร์ภาพที่ตอบสนองกับเสียง
- **Tone.js** สำหรับเสียงสังเคราะห์
- **HTML5 Canvas** สำหรับแสดงผลตอบสนอง
- **JavaScript** สำหรับการโต้ตอบแบบเรียลไทม์
## การตั้งค่าสำหรับการพัฒนา

```bash
# โคลน repository นี้
git clone https://github.com/collidingScopes/arpeggiator

# ไปยังไดเรกทอรีโปรเจกต์
cd arpeggiator

# ให้บริการด้วยวิธีที่คุณต้องการ (ตัวอย่างการใช้ Python)
python -m http.server
```

จากนั้นไปที่ `http://localhost:8000` ในเบราว์เซอร์ของคุณ

## ใบอนุญาต

MIT License

## เครดิต
- Three.js - https://threejs.org/
- MediaPipe - https://mediapipe.dev/
- Rosebud AI - https://rosebud.ai/
- Tone.js - https://tonejs.github.io/

## โครงการที่เกี่ยวข้อง

ผมได้ปล่อยโปรเจกต์วิชั่นคอมพิวเตอร์หลายโปรเจกต์ (พร้อมโค้ด + บทแนะนำ) ที่นี่:
[สนุกกับวิชั่นคอมพิวเตอร์](https://www.funwithcomputervision.com/)

คุณสามารถซื้อสิทธิ์เข้าถึงตลอดชีพและรับไฟล์โปรเจกต์เต็มรูปแบบและบทแนะนำ ผมเพิ่มเนื้อหาใหม่อย่างสม่ำเสมอ 🪬

คุณอาจจะชอบโปรเจกต์โอเพ่นซอร์สอื่น ๆ ของผมเช่นกัน:

- [3D Model Playground](https://collidingScopes.github.io/3d-model-playground) - ควบคุมโมเดล 3 มิติด้วยเสียงและท่าทางมือ
- [บทแนะนำการติดตามมือด้วย Threejs](https://collidingScopes.github.io/threejs-handtracking-101) - การตั้งค่าการติดตามมือขั้นพื้นฐานด้วย threejs และ MediaPipe วิชั่นคอมพิวเตอร์
- [Particular Drift](https://collidingScopes.github.io/particular-drift) - เปลี่ยนภาพถ่ายให้กลายเป็นแอนิเมชันอนุภาคที่ไหลลื่น
- [Video-to-ASCII](https://collidingScopes.github.io/ascii) - แปลงวิดีโอให้เป็นศิลปะพิกเซล ASCII
## ติดต่อ

- Instagram: [@stereo.drift](https://www.instagram.com/stereo.drift/)
- Twitter/X: [@measure_plan](https://x.com/measure_plan)
- อีเมล: [stereodriftvisuals@gmail.com](https://raw.githubusercontent.com/collidingScopes/arpeggiator/main/mailto:stereodriftvisuals@gmail.com)
- GitHub: [collidingScopes](https://github.com/collidingScopes)

## การสนับสนุน

หากคุณพบว่าเครื่องมือนี้มีประโยชน์ รู้สึกอิสระที่จะเลี้ยงกาแฟให้ฉันสักแก้ว

ผมชื่อ Alan และผมชอบสร้างซอฟต์แวร์โอเพ่นซอร์สสำหรับวิชันคอมพิวเตอร์ เกม และอื่น ๆ การสนับสนุนนี้จะเป็นที่ขอบคุณมากในช่วงดึกของการเขียนโค้ด!

[![Buy Me A Coffee](https://www.buymeacoffee.com/assets/img/custom_images/yellow_img.png)](https://www.buymeacoffee.com/stereoDrift)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-11

---