# Django Ninja Shortener - บริการย่อ URL แบบ Bitly

บริการย่อ URL สมัยใหม่ สร้างด้วย Django, Django Ninja และ Tailwind CSS ได้รับแรงบันดาลใจในการออกแบบจาก Bitly

ผู้ใช้สามารถสมัครสมาชิกและเข้าสู่ระบบ จากนั้นนำ URL มาย่อและติดตามจำนวนการคลิกของแต่ละลิงก์ย่อได้

โปรเจคนี้ใช้ [Cline](https://github.com/twtrubiks/mcp-vscode-cline?tab=readme-ov-file#cline) ช่วยในการพัฒนา สามารถดูรายละเอียดได้ที่ [.clinerules/01_doc.md](https://raw.githubusercontent.com/twtrubiks/django-ninja-shortener/main/.clinerules/01_doc.md)

## ภาพหน้าจอ

หน้าลิงก์ย่อ (ไม่ต้องสมัครสมาชิกก็ใช้ได้)

![alt tag](https://cdn.imgpile.com/f/qPDKjsy_xl.png)

ถ้าสมัครสมาชิกจะติดตามจำนวนคลิกได้

![alt tag](https://cdn.imgpile.com/f/4R3cy01_xl.png)

## ✨ จุดเด่นของฟีเจอร์

* **ระบบยืนยันตัวตน**: รองรับการสมัครสมาชิก, เข้าสู่ระบบ, ออกจากระบบ
* **สร้างลิงก์ย่อ**: ผู้ใช้ที่เข้าสู่ระบบสามารถสร้างลิงก์ย่อที่ไม่ซ้ำใครสำหรับ URL ยาว
* **เปลี่ยนเส้นทางลิงก์ย่อ**: เมื่อคลิกลิงก์ย่อจะนำผู้ใช้ไปยัง URL ต้นทาง
* **ติดตามจำนวนคลิก**: ระบบจะนับจำนวนครั้งที่แต่ละลิงก์ย่อถูกคลิกให้อัตโนมัติ
* **แดชบอร์ดส่วนตัว**: ผู้ใช้สามารถดูรายการลิงก์ย่อทั้งหมดที่สร้างและสถิติการคลิก
* **RESTful API**: ให้ API endpoint สำหรับสร้างลิงก์ย่อด้วยวิธีโปรแกรมมิ่ง
* **รองรับ Docker**: มี Dockerfile และ Docker Compose สำหรับง่ายต่อการพัฒนาและปรับใช้

## 🛠️ สแต็กเทคโนโลยี

* **เฟรมเวิร์คฝั่งเซิร์ฟเวอร์**: [Django](https://github.com/twtrubiks/django-tutorial)
* **เฟรมเวิร์ค API**: [Django Ninja](https://github.com/twtrubiks/django_ninja_tutorial)
* **สไตล์ฝั่งหน้าเว็บ**: [Tailwind CSS](https://tailwindcss.com/) (เชื่อมผ่าน `django-tailwind`)
* **ฐานข้อมูล**:
  * สภาพแวดล้อมสำหรับพัฒนา: SQLite (ค่าเริ่มต้น)
  * สภาพแวดล้อม production: เปลี่ยนเป็น PostgreSQL ได้ง่าย (ตั้งค่ารอใน `settings.py` แล้ว)
* **รหัสลิงก์ย่อ**: สร้างด้วย `shortuuid`
* **การทดสอบ**: [Pytest](https://github.com/twtrubiks/django_pytest_tutorial)
* **Containerization**: [Docker](https://github.com/twtrubiks/docker-tutorial)

## 🚀 เริ่มต้นอย่างรวดเร็ว (ด้วย Docker, แนะนำวิธีนี้)

นี่คือวิธีที่แนะนำที่สุด เพื่อความสอดคล้องของสภาพแวดล้อมการพัฒนา

**ขั้นตอนการเริ่มต้น:**

1. **เริ่มบริการ:**

    ใช้ Docker Compose เพื่อเริ่มต้นทุกบริการในคำสั่งเดียว

    ```bash
    docker compose up --build
    ```

    คำสั่งนี้จะสร้าง image ของ Docker, ติดตั้ง dependencies, ทำการ migrate ฐานข้อมูล และรัน development server

2. **สร้างผู้ใช้ superuser (ตัวเลือกเสริม):**

    หากต้องการเข้า Django Admin ให้เปิด terminal อีกหน้าต่างแล้วรัน

    ```bash
    docker compose exec django-ninja python manage.py createsuperuser
    ```

3. **เข้าใช้งานแอปพลิเคชัน:**

    * **หน้าเว็บหลัก**: [http://localhost:8000](http://localhost:8000)

    * **API Docs (Swagger UI)**: [http://localhost:8000/api/docs](http://localhost:8000/api/docs)

## 🔧 การพัฒนาแบบ local (ไม่ใช้ Docker)

หากคุณต้องการตั้งค่าบนเครื่องโดยตรง

**สิ่งที่ต้องมี:**

* Python 3.12
* Node.js และ npm (สำหรับ Tailwind CSS)

**ขั้นตอนการตั้งค่า:**

1. **สร้างและเปิดใช้งาน virtual environment:**

    ```bash
    python -m venv venv
    source venv/bin/activate  # บน Windows ใช้ `venv\Scripts\activate`
    ```

2. **ติดตั้ง dependencies ของ Python:**

    ```bash
    pip install -r requirements.txt
    ```

3. **ติดตั้งและตั้งค่า Tailwind CSS:**

    `django-tailwind` จะจัดการตั้งค่าส่วนใหญ่ให้

    ```bash
    python manage.py tailwind install
    ```

    ดูรายละเอียดเพิ่มเติมที่ [https://django-tailwind.readthedocs.io/en/latest/installation.html](https://django-tailwind.readthedocs.io/en/latest/installation.html)

4. **รัน migrate ฐานข้อมูล:**

    ```bash
    python manage.py migrate
    ```

5. **สร้างผู้ใช้ superuser (ตัวเลือกเสริม):**

    ```bash
    python manage.py createsuperuser
    ```

6. **เริ่ม development server:**

    คุณต้องรัน Django server และ process compile Tailwind CSS พร้อมกัน

    ```bash
    python manage.py runserver
    ```

    เปิด terminal อีกหน้าต่างแล้วรัน

    ```bash
    python manage.py tailwind start
    ```

7. **เข้าใช้งานแอปพลิเคชัน:**

    * **หน้าเว็บหลัก**: [http://localhost:8000](http://localhost:8000)

    * **API Docs (Swagger UI)**: [http://localhost:8000/api/docs](http://localhost:8000/api/docs)

## 🧪 การรันทดสอบ

โปรเจคนี้ใช้ `pytest` สำหรับการทดสอบและวัด coverage

แผนการทดสอบดูได้ที่ [TESTING_PLAN.md](https://raw.githubusercontent.com/twtrubiks/django-ninja-shortener/main/TESTING_PLAN.md)

* **รันทดสอบด้วย Docker:**

    ```bash
    docker compose --profile test up
    ```

    รายงานผลทดสอบจะอยู่ที่ `htmlcov/index.html`

* **รันทดสอบบนเครื่อง local:**

    ```bash
    # ตรวจสอบว่าติดตั้ง dependencies สำหรับ dev แล้ว
    pytest --cov=. --cov-report=html
    ```

![alt tag](https://cdn.imgpile.com/f/UZnApNQ_xl.png)

## 📄 API Endpoint

API ให้ช่องทางสำหรับเชื่อมต่อกับบริการย่อ URL ด้วยวิธีโปรแกรมมิ่ง ทุก endpoint อยู่ภายใต้ path `/api/`

แนะนำให้ดูที่ **API Docs (Swagger UI)**: [http://localhost:8000/api/docs](http://localhost:8000/api/docs)

![alt tag](https://cdn.imgpile.com/f/Foa4p5C_md.png)

ใช้ [Ninja JWT](https://github.com/twtrubiks/django_ninja_tutorial/tree/main?tab=readme-ov-file#ninja-jwt), ให้เรียก `/api/token/pair` พร้อมใส่ username/password เพื่อรับ token ของคุณ

![alt tag](https://cdn.imgpile.com/f/84ABFA4_xl.png)

จากนั้นให้นำ token ไปวางที่มุมขวาบน ก็สามารถเรียก API ได้เลย

![alt tag](https://cdn.imgpile.com/f/aCbUddW_md.png)

## 📂 โครงสร้างโปรเจค

```cmd
ninja_shortener/
├── Dockerfile
├── docker-compose.yml
├── manage.py
├── requirements.txt
├── ninja_shortener/      # ตั้งค่าโปรเจค Django
│   ├── settings.py
│   └── urls.py
├── shortener/            # แอปหลักสำหรับย่อ URL
│   ├── models.py         # โมเดลฐานข้อมูล (Link)
│   ├── api.py            # Endpoint ของ Django Ninja API
│   ├── views.py          # logic สำหรับหน้าเว็บและ redirect
│   └── utils.py          # เครื่องมือสร้างรหัสย่อ
└── theme/                # ธีมและ template ของ Django
    ├── templates/        # ไฟล์ HTML template
    └── static_src/       # ไฟล์ต้นฉบับ Tailwind CSS
```

## 💡 แผนพัฒนาต่อไป

* **เปลี่ยนไปใช้ PostgreSQL**: เตรียมฐานข้อมูลที่เสถียรกว่าสำหรับ production (ดำเนินการแล้ว)
* **แดชบอร์ดวิเคราะห์ละเอียด**: แสดงข้อมูลคลิกเชิงลึก เช่น เวลา, แหล่งที่มา, ตำแหน่งทางภูมิศาสตร์ เป็นต้น
* **กำหนดรหัสลิงก์สั้นเอง**: อนุญาตให้ผู้ใช้กำหนดรหัสของลิงก์สั้นเองได้
* **สร้าง QR Code**: สร้าง QR Code ให้กับแต่ละลิงก์สั้นที่มีอยู่
* **งานแบบไม่ประสานเวลา (Asynchronous tasks)**: ใช้ Celery ในการประมวลผลงานที่ใช้เวลานาน เช่น การวิเคราะห์ข้อมูล

## การสนับสนุน (Donation)

บทความทั้งหมดนี้เป็นงานวิจัยและเขียนขึ้นเอง หากบทความนี้เป็นประโยชน์กับคุณและอยากให้กำลังใจผม สามารถเลี้ยงกาแฟผมสักแก้วได้นะครับ :laughing:

ECPAY (ไม่จำเป็นต้องสมัครสมาชิก)

![alt tag](https://payment.ecpay.com.tw/Upload/QRCode/201906/QRCode_672351b8-5ab3-42dd-9c7c-c24c3e6a10a0.png)

[ชำระเงินสนับสนุน](http://bit.ly/2F7Jrha)

O'Pay (ต้องสมัครสมาชิก)

![alt tag](https://i.imgur.com/LRct9xa.png)

[ชำระเงินสนับสนุน](https://payment.opay.tw/Broadcaster/Donate/9E47FDEF85ABE383A0F5FC6A218606F8)

## รายชื่อผู้สนับสนุน

[รายชื่อผู้สนับสนุน](https://github.com/twtrubiks/Thank-you-for-donate)

## ใบอนุญาต

MIT license

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---