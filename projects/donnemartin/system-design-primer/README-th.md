*[English](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/README.md) ∙ [日本語](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/README-ja.md) ∙ [简体中文](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/README-zh-Hans.md) ∙ [繁體中文](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/README-zh-TW.md) | [العَرَبِيَّة‎](https://github.com/donnemartin/system-design-primer/issues/170) ∙ [বাংলা](https://github.com/donnemartin/system-design-primer/issues/220) ∙ [Português do Brasil](https://github.com/donnemartin/system-design-primer/issues/40) ∙ [Deutsch](https://github.com/donnemartin/system-design-primer/issues/186) ∙ [ελληνικά](https://github.com/donnemartin/system-design-primer/issues/130) ∙ [עברית](https://github.com/donnemartin/system-design-primer/issues/272) ∙ [Italiano](https://github.com/donnemartin/system-design-primer/issues/104) ∙ [한국어](https://github.com/donnemartin/system-design-primer/issues/102) ∙ [فارسی](https://github.com/donnemartin/system-design-primer/issues/110) ∙ [Polski](https://github.com/donnemartin/system-design-primer/issues/68) ∙ [русский язык](https://github.com/donnemartin/system-design-primer/issues/87) ∙ [Español](https://github.com/donnemartin/system-design-primer/issues/136) ∙ [ภาษาไทย](https://github.com/donnemartin/system-design-primer/issues/187) ∙ [Türkçe](https://github.com/donnemartin/system-design-primer/issues/39) ∙ [tiếng Việt](https://github.com/donnemartin/system-design-primer/issues/127) ∙ [Français](https://github.com/donnemartin/system-design-primer/issues/250) | [Add Translation](https://github.com/donnemartin/system-design-primer/issues/28)*

**ช่วย [แปล](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/TRANSLATIONS.md) คู่มือนี้!**

# The System Design Primer

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/jj3A5N8.png">
  <br/>
</p>

## แรงจูงใจ

> เรียนรู้วิธีออกแบบระบบขนาดใหญ่
>
> เตรียมตัวสำหรับสัมภาษณ์การออกแบบระบบ

### เรียนรู้วิธีออกแบบระบบขนาดใหญ่

การเรียนรู้วิธีออกแบบระบบที่สามารถขยายขนาดได้จะช่วยให้คุณเป็นวิศวกรที่ดีขึ้น

การออกแบบระบบเป็นหัวข้อที่กว้าง มี **แหล่งข้อมูลจำนวนมากกระจายอยู่ทั่วอินเทอร์เน็ต** เกี่ยวกับหลักการออกแบบระบบ

repo นี้คือ **การรวบรวมแหล่งข้อมูลอย่างเป็นระเบียบ** เพื่อช่วยให้คุณเรียนรู้วิธีสร้างระบบขนาดใหญ่

### เรียนรู้จากชุมชนโอเพ่นซอร์ส

นี่คือโปรเจกต์โอเพ่นซอร์สที่มีการอัปเดตอย่างต่อเนื่อง

[ยินดีรับการมีส่วนร่วม](#contributing)!

### เตรียมตัวสำหรับสัมภาษณ์การออกแบบระบบ

นอกเหนือจากการสัมภาษณ์เขียนโค้ดแล้ว การออกแบบระบบยังเป็น **องค์ประกอบสำคัญ** ของ **กระบวนการสัมภาษณ์ทางเทคนิค** ในหลายบริษัทเทคโนโลยี

**ฝึกตอบคำถามสัมภาษณ์การออกแบบระบบที่พบบ่อย** และ **เปรียบเทียบ** ผลลัพธ์ของคุณกับ **ตัวอย่างคำตอบ**: การอภิปราย โค้ด และไดอะแกรม

หัวข้อเพิ่มเติมเพื่อเตรียมสัมภาษณ์:

* [คู่มือการศึกษา](#study-guide)
* [วิธีเข้าหาคำถามสัมภาษณ์การออกแบบระบบ](#how-to-approach-a-system-design-interview-question)
* [คำถามสัมภาษณ์การออกแบบระบบ, **พร้อมคำตอบ**](#system-design-interview-questions-with-solutions)
* [คำถามสัมภาษณ์การออกแบบเชิงวัตถุ, **พร้อมคำตอบ**](#object-oriented-design-interview-questions-with-solutions)
* [คำถามสัมภาษณ์การออกแบบระบบเพิ่มเติม](#additional-system-design-interview-questions)

## บัตรคำ Anki

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/zdCAkB3.png">
  <br/>
</p>

ชุด [บัตรคำ Anki](https://apps.ankiweb.net/) ที่ให้มาใช้เทคนิคการทบทวนแบบเว้นระยะ เพื่อช่วยให้จดจำแนวคิดสำคัญในการออกแบบระบบ

* [ชุดบัตรคำการออกแบบระบบ](https://github.com/donnemartin/system-design-primer/tree/master/resources/flash_cards/System%20Design.apkg)
* [ชุดบัตรคำแบบฝึกหัดการออกแบบระบบ](https://github.com/donnemartin/system-design-primer/tree/master/resources/flash_cards/System%20Design%20Exercises.apkg)
* [ชุดบัตรคำแบบฝึกหัดการออกแบบเชิงวัตถุ](https://github.com/donnemartin/system-design-primer/tree/master/resources/flash_cards/OO%20Design.apkg)

เหมาะสำหรับใช้ขณะเดินทาง

### แหล่งข้อมูลการเขียนโค้ด: แบบฝึกหัดโค้ดเชิงโต้ตอบ

กำลังมองหาแหล่งข้อมูลเพื่อเตรียมตัวสำหรับ [**การสัมภาษณ์โค้ดดิ้ง**](https://github.com/donnemartin/interactive-coding-challenges)?

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/b4YtAEN.png">
  <br/>
</p>

ลองดูรีโปซิทอรีที่เกี่ยวข้อง [**Interactive Coding Challenges**](https://github.com/donnemartin/interactive-coding-challenges) ซึ่งมีชุดบัตรคำ Anki เพิ่มเติม:

* [ชุดบัตรคำการเขียนโค้ด](https://github.com/donnemartin/interactive-coding-challenges/tree/master/anki_cards/Coding.apkg)

## การมีส่วนร่วม

> เรียนรู้จากชุมชน

สามารถส่ง pull request เพื่อช่วยได้อย่างอิสระ:

* แก้ไขข้อผิดพลาด
* ปรับปรุงเนื้อหา
* เพิ่มส่วนใหม่
* [แปล](https://github.com/donnemartin/system-design-primer/issues/28)

เนื้อหาที่ต้องปรับปรุงจะถูกจัดไว้ [ระหว่างการพัฒนา](#under-development)

ตรวจสอบ [แนวทางการมีส่วนร่วม](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/CONTRIBUTING.md)

## ดัชนีหัวข้อการออกแบบระบบ

> สรุปหัวข้อต่างๆเกี่ยวกับการออกแบบระบบ รวมถึงข้อดีข้อเสีย  **ทุกสิ่งล้วนเป็นการแลกเปลี่ยนข้อดีข้อเสีย**.
>
> แต่ละส่วนมีลิงก์ไปยังแหล่งข้อมูลเชิงลึกเพิ่มเติม

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/jrUBAF7.png">
  <br/>
</p>

* [หัวข้อการออกแบบระบบ: เริ่มต้นที่นี่](#system-design-topics-start-here)
    * [ขั้นตอนที่ 1: ดูวิดีโอบรรยายเกี่ยวกับความสามารถในการขยายตัว](#step-1-review-the-scalability-video-lecture)
    * [ขั้นตอนที่ 2: อ่านบทความเกี่ยวกับความสามารถในการขยายตัว](#step-2-review-the-scalability-article)
    * [ขั้นตอนถัดไป](#next-steps)
* [ประสิทธิภาพเทียบกับความสามารถในการขยายตัว](#performance-vs-scalability)
* [ความหน่วงเทียบกับปริมาณงาน](#latency-vs-throughput)
* [ความพร้อมใช้งานเทียบกับความสอดคล้อง](#availability-vs-consistency)
    * [ทฤษฎี CAP](#cap-theorem)
        * [CP - ความสอดคล้องและการทนต่อการแบ่งส่วน](#cp---consistency-and-partition-tolerance)
        * [AP - ความพร้อมใช้งานและการทนต่อการแบ่งส่วน](#ap---availability-and-partition-tolerance)
* [รูปแบบความสอดคล้อง](#consistency-patterns)
    * [ความสอดคล้องแบบอ่อน](#weak-consistency)
    * [ความสอดคล้องในที่สุด](#eventual-consistency)
    * [ความสอดคล้องแบบแข็งแกร่ง](#strong-consistency)
* [รูปแบบความพร้อมใช้งาน](#availability-patterns)
    * [การสลับการทำงานเมื่อเกิดข้อผิดพลาด](#fail-over)
    * [การจำลองข้อมูล](#replication)
    * [ความพร้อมใช้งานในเชิงตัวเลข](#availability-in-numbers)
* [ระบบชื่อโดเมน](#domain-name-system)
* [เครือข่ายจัดส่งเนื้อหา](#content-delivery-network)
    * [Push CDN](#push-cdns)
    * [Pull CDN](#pull-cdns)
* [ตัวจัดสมดุลโหลด (Load balancer)](#load-balancer)
    * [แอคทีฟ-พาสซีฟ (Active-passive)](#active-passive)
    * [แอคทีฟ-แอคทีฟ (Active-active)](#active-active)
    * [การจัดสมดุลโหลดระดับชั้นที่ 4](#layer-4-load-balancing)
    * [การจัดสมดุลโหลดระดับชั้นที่ 7](#layer-7-load-balancing)
    * [การปรับขยายในแนวนอน (Horizontal scaling)](#horizontal-scaling)
* [พร็อกซีแบบย้อนกลับ (Reverse proxy) (เว็บเซิร์ฟเวอร์)](#reverse-proxy-web-server)
    * [ตัวจัดสมดุลโหลด vs พร็อกซีแบบย้อนกลับ](#load-balancer-vs-reverse-proxy)
* [เลเยอร์แอปพลิเคชัน](#application-layer)
    * [ไมโครเซอร์วิส (Microservices)](#microservices)
    * [การค้นหาบริการ (Service discovery)](#service-discovery)
* [ฐานข้อมูล](#database)
    * [ระบบจัดการฐานข้อมูลเชิงสัมพันธ์ (RDBMS)](#relational-database-management-system-rdbms)
        * [การจำลองข้อมูลแบบต้นทาง-ปลายทาง (Master-slave replication)](#master-slave-replication)
        * [การจำลองข้อมูลแบบต้นทาง-ต้นทาง (Master-master replication)](#master-master-replication)
        * [เฟเดอเรชัน (Federation)](#federation)
        * [การแบ่งชิ้นส่วนข้อมูล (Sharding)](#sharding)
        * [การทำข้อมูลให้ไม่ปกติ (Denormalization)](#denormalization)
        * [การปรับจูน SQL (SQL tuning)](#sql-tuning)
    * [NoSQL](#nosql)
        * [ที่เก็บคีย์-ค่า (Key-value store)](#key-value-store)
        * [ที่เก็บเอกสาร (Document store)](#document-store)
        * [ที่เก็บคอลัมน์แบบกว้าง (Wide column store)](#wide-column-store)
        * [ฐานข้อมูลกราฟ (Graph Database)](#graph-database)
    * [SQL หรือ NoSQL](#sql-or-nosql)
* [แคช (Cache)](#cache)
    * [การแคชฝั่งไคลเอนต์](#client-caching)
    * [การแคช CDN](#cdn-caching)
    * [การแคชเว็บเซิร์ฟเวอร์](#web-server-caching)
    * [การแคชฐานข้อมูล](#database-caching)
    * [การแคชแอปพลิเคชัน](#application-caching)
    * [การแคชในระดับคิวรีฐานข้อมูล](#caching-at-the-database-query-level)
    * [การแคชในระดับอ็อบเจ็กต์](#caching-at-the-object-level)
    * [เมื่อใดควรอัปเดตแคช](#when-to-update-the-cache)
        * [Cache-aside](#cache-aside)
        * [Write-through](#write-through)
        * [Write-behind (write-back)](#write-behind-write-back)
        * [Refresh-ahead](#refresh-ahead)
* [การทำงานแบบอะซิงโครนัส (Asynchronism)](#asynchronism)
    * [คิวข้อความ (Message queues)](#message-queues)
    * [คิวงาน (Task queues)](#task-queues)
    * [แรงดันย้อนกลับ (Back pressure)](#back-pressure)
* [การสื่อสาร (Communication)](#communication)
    * [โปรโตคอลควบคุมการส่งข้อมูล (TCP)](#transmission-control-protocol-tcp)
    * [โปรโตคอลดาตาแกรมของผู้ใช้ (UDP)](#user-datagram-protocol-udp)
    * [การเรียกใช้ฟังก์ชันระยะไกล (RPC)](#remote-procedure-call-rpc)
    * [การถ่ายโอนสถานะที่แทนด้วยตัวแทน (REST)](#representational-state-transfer-rest)
* [ความปลอดภัย (Security)](#security)
* [ภาคผนวก (Appendix)](#appendix)
    * [ตารางเลขยกกำลังสอง (Powers of two table)](#powers-of-two-table)
    * [ตัวเลขความหน่วงที่โปรแกรมเมอร์ทุกคนควรรู้](#latency-numbers-every-programmer-should-know)
    * [คำถามการออกแบบระบบเพิ่มเติมสำหรับสัมภาษณ์](#additional-system-design-interview-questions)
    * [สถาปัตยกรรมในโลกจริง](#real-world-architectures)
    * [สถาปัตยกรรมบริษัท](#company-architectures)
    * [บล็อกวิศวกรรมของบริษัท](#company-engineering-blogs)
* [อยู่ระหว่างการพัฒนา](#under-development)
* [เครดิต](#credits)
* [ข้อมูลติดต่อ](#contact-info)
* [ใบอนุญาต](#license)

## คู่มือการศึกษา

> หัวข้อที่แนะนำให้ทบทวนตามระยะเวลาสัมภาษณ์ของคุณ (สั้น, กลาง, ยาว)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/OfVllex.png)

**ถาม: สำหรับการสัมภาษณ์ ฉันจำเป็นต้องรู้ทุกอย่างที่นี่หรือไม่?**

**ตอบ: ไม่ คุณไม่จำเป็นต้องรู้ทุกอย่างที่นี่เพื่อเตรียมตัวสำหรับสัมภาษณ์**

สิ่งที่คุณจะถูกถามในการสัมภาษณ์ขึ้นอยู่กับตัวแปรต่างๆ เช่น:

* คุณมีประสบการณ์มากแค่ไหน
* คุณมีพื้นฐานทางเทคนิคอย่างไร
* คุณสมัครตำแหน่งอะไร
* คุณสัมภาษณ์กับบริษัทไหน
* โชค

ผู้สมัครที่มีประสบการณ์มากขึ้นมักจะถูกคาดหวังให้รู้เกี่ยวกับการออกแบบระบบมากกว่า  สถาปนิกหรือหัวหน้าทีมอาจถูกคาดหวังให้รู้มากกว่าผู้ร่วมงานทั่วไป  บริษัทเทคโนโลยีชั้นนำมักจะมีรอบสัมภาษณ์การออกแบบหนึ่งรอบหรือมากกว่า

เริ่มต้นจากภาพรวมและค่อยๆ เจาะลึกในบางส่วน การรู้พื้นฐานในหัวข้อการออกแบบระบบที่สำคัญหลายๆ ด้านจะช่วยได้ ปรับแต่งคู่มือด้านล่างนี้ตามระยะเวลาที่คุณมี ประสบการณ์ของคุณ ตำแหน่งงานที่คุณสมัคร และบริษัทที่คุณสมัคร

* **ระยะเวลาสั้น** - เน้นที่ **ความกว้าง** ของหัวข้อการออกแบบระบบ ฝึกฝนด้วยการแก้ไข **บาง** คำถามสัมภาษณ์
* **ระยะเวลาปานกลาง** - เน้นที่ **ความกว้าง** และ **ลึกบางส่วน** ของหัวข้อการออกแบบระบบ ฝึกฝนด้วยการแก้ไข **หลาย** คำถามสัมภาษณ์
* **ระยะเวลานาน** - เน้นที่ **ความกว้าง** และ **ความลึกมากขึ้น** ของหัวข้อการออกแบบระบบ ฝึกฝนด้วยการแก้ไข **ส่วนใหญ่** ของคำถามสัมภาษณ์

| | สั้น | ปานกลาง | นาน |
|---|---|---|---|
| อ่านหัวข้อ [การออกแบบระบบ](#index-of-system-design-topics) เพื่อเข้าใจภาพรวมการทำงานของระบบ | :+1: | :+1: | :+1: |
| อ่านบทความบางส่วนจาก [บล็อกวิศวกรรมของบริษัท](#company-engineering-blogs) ที่คุณสมัครงาน | :+1: | :+1: | :+1: |
| อ่านกรณีตัวอย่าง [สถาปัตยกรรมในโลกจริง](#real-world-architectures) | :+1: | :+1: | :+1: |
| ทบทวน [วิธีการรับมือกับคำถามสัมภาษณ์การออกแบบระบบ](#how-to-approach-a-system-design-interview-question) | :+1: | :+1: | :+1: |
| ฝึกทำ [คำถามสัมภาษณ์การออกแบบระบบพร้อมคำตอบ](#system-design-interview-questions-with-solutions) | บางข้อ | หลายข้อ | ส่วนใหญ่ |
| ฝึกทำ [คำถามสัมภาษณ์การออกแบบเชิงวัตถุพร้อมคำตอบ](#object-oriented-design-interview-questions-with-solutions) | บางข้อ | หลายข้อ | ส่วนใหญ่ |
| ทบทวน [คำถามสัมภาษณ์การออกแบบระบบเพิ่มเติม](#additional-system-design-interview-questions) | บางข้อ | หลายข้อ | ส่วนใหญ่ |

## วิธีรับมือกับคำถามสัมภาษณ์การออกแบบระบบ

> วิธีจัดการกับคำถามสัมภาษณ์การออกแบบระบบ

การสัมภาษณ์ออกแบบระบบเป็น **การสนทนาแบบเปิด** โดยคุณควรเป็นผู้นำการสนทนา

คุณสามารถใช้ขั้นตอนต่อไปนี้เพื่อช่วยนำการพูดคุย เพื่อช่วยให้เข้าใจขั้นตอนนี้ ฝึกทำส่วน [คำถามสัมภาษณ์การออกแบบระบบพร้อมคำตอบ](#system-design-interview-questions-with-solutions) โดยใช้ขั้นตอนดังต่อไปนี้

### ขั้นตอนที่ 1: สรุปกรณีใช้งาน ข้อจำกัด และสมมติฐาน

รวบรวมความต้องการและขอบเขตของปัญหา ตั้งคำถามเพื่อชี้แจงกรณีใช้งานและข้อจำกัด พูดคุยเกี่ยวกับสมมติฐาน

* ใครจะเป็นผู้ใช้ระบบ?
* ผู้ใช้จะใช้ระบบอย่างไร?
* มีผู้ใช้จำนวนเท่าไร?
* ระบบทำหน้าที่อะไร?
* ระบบรับและส่งข้อมูลอะไรบ้าง?
* คาดว่าจะต้องจัดการข้อมูลมากแค่ไหน?
* คาดว่าจะมีจำนวนคำขอต่อวินาทีเท่าไร?
* อัตราส่วนการอ่านต่อการเขียนที่คาดหวังคือเท่าไร?

### ขั้นตอนที่ 2: สร้างการออกแบบระดับสูง

สรุปภาพรวมการออกแบบระดับสูงโดยระบุองค์ประกอบสำคัญทั้งหมด

* ร่างส่วนประกอบหลักและการเชื่อมต่อ
* อธิบายเหตุผลของแนวคิดของคุณ

### ขั้นตอนที่ 3: ออกแบบส่วนประกอบหลัก

ลงรายละเอียดสำหรับแต่ละส่วนประกอบหลัก ตัวอย่างเช่น หากคุณถูกขอให้ [ออกแบบบริการย่อ URL](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/pastebin/README.md) ให้พูดถึง:

* การสร้างและจัดเก็บแฮชของ URL เต็ม
    * [MD5](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/pastebin/README.md) และ [Base62](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/pastebin/README.md)
    * การชนกันของแฮช
    * SQL หรือ NoSQL
    * โครงสร้างฐานข้อมูล
* การแปลง URL ที่ถูกแฮชกลับเป็น URL เต็ม
    * การค้นหาในฐานข้อมูล
* การออกแบบ API และเชิงวัตถุ

### ขั้นตอนที่ 4: ขยายการออกแบบ

ระบุและแก้ไขจุดคอขวดโดยพิจารณาจากข้อจำกัด ตัวอย่างเช่น คุณต้องการสิ่งเหล่านี้เพื่อแก้ปัญหาความสามารถในการปรับขนาดหรือไม่?

* ตัวกระจายโหลด
* การขยายแนวนอน
* การแคช
* การแบ่งฐานข้อมูล

อภิปรายแนวทางแก้ไขและข้อแลกเปลี่ยนที่อาจเกิดขึ้น ทุกอย่างมีข้อแลกเปลี่ยน แก้ไขจุดคอขวดโดยใช้ [หลักการออกแบบระบบที่ปรับขนาดได้](#index-of-system-design-topics)

### การคำนวณแบบหยาบๆ

คุณอาจถูกขอให้ประมาณค่าด้วยมือ ดู [ภาคผนวก](#appendix) สำหรับแหล่งข้อมูลต่อไปนี้:

* [ใช้การคำนวณแบบหยาบๆ](http://highscalability.com/blog/2011/1/26/google-pro-tip-use-back-of-the-envelope-calculations-to-choo.html)
* [ตารางเลขยกกำลังสอง](#powers-of-two-table)
* [ตัวเลขความหน่วงที่นักพัฒนาทุกคนควรรู้](#latency-numbers-every-programmer-should-know)

### แหล่งข้อมูลและการอ่านเพิ่มเติม

ดูที่ลิงก์ต่อไปนี้เพื่อให้เข้าใจมากขึ้นว่าควรคาดหวังอะไรบ้าง:

* [วิธีพิชิตการสัมภาษณ์ออกแบบระบบ](https://www.palantir.com/2011/10/how-to-rock-a-systems-design-interview/)
* [การสัมภาษณ์ออกแบบระบบ](http://www.hiredintech.com/system-design)
* [แนะนำสถาปัตยกรรมและการสัมภาษณ์ออกแบบระบบ](https://www.youtube.com/watch?v=ZgdS0EUmn70)
* [เทมเพลตออกแบบระบบ](https://leetcode.com/discuss/career/229177/My-System-Design-Template)

## คำถามสัมภาษณ์ออกแบบระบบพร้อมคำตอบ

> คำถามสัมภาษณ์ออกแบบระบบที่พบบ่อย พร้อมตัวอย่างการอภิปราย โค้ด และไดอะแกรม
>
> คำตอบเชื่อมโยงไปยังเนื้อหาในโฟลเดอร์ `solutions/`

| คำถาม | |
|---|---|
| ออกแบบ Pastebin.com (หรือ Bit.ly) | [คำตอบ](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/pastebin/README.md) |
| ออกแบบไทม์ไลน์และค้นหา Twitter (หรือฟีดและค้นหา Facebook) | [คำตอบ](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/twitter/README.md) |
| ออกแบบเว็บครอว์เลอร์ | [คำตอบ](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/web_crawler/README.md) |
| ออกแบบ Mint.com | [คำตอบ](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/mint/README.md) |
| ออกแบบโครงสร้างข้อมูลสำหรับโซเชียลเน็ตเวิร์ก | [คำตอบ](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/social_graph/README.md) |
| ออกแบบ key-value store สำหรับ search engine | [คำตอบ](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/query_cache/README.md) |
| ออกแบบฟีเจอร์จัดอันดับยอดขายตามหมวดหมู่ของ Amazon | [คำตอบ](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/sales_rank/README.md) |
| ออกแบบระบบที่ขยายรองรับผู้ใช้หลักล้านบน AWS | [คำตอบ](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/scaling_aws/README.md) |
| เพิ่มคำถามออกแบบระบบ | [ร่วมสมทบ](#contributing) |

### ออกแบบ Pastebin.com (หรือ Bit.ly)

[ดูแบบฝึกหัดและคำตอบ](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/pastebin/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/4edXG0T.png)

### ออกแบบไทม์ไลน์และค้นหา Twitter (หรือฟีดและค้นหา Facebook)

[ดูแบบฝึกหัดและคำตอบ](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/twitter/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/jrUBAF7.png)

### ออกแบบเว็บครอว์เลอร์

[ดูแบบฝึกหัดและคำตอบ](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/web_crawler/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/bWxPtQA.png)

### Design Mint.com

[View exercise and solution](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/mint/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/V5q57vU.png)

### Design the data structures for a social network

[View exercise and solution](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/social_graph/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/cdCv5g7.png)

### Design a key-value store for a search engine

[View exercise and solution](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/query_cache/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/4j99mhe.png)

### Design Amazon's sales ranking by category feature

[View exercise and solution](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/sales_rank/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/MzExP06.png)

### Design a system that scales to millions of users on AWS

[View exercise and solution](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/scaling_aws/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/jj3A5N8.png)

## Object-oriented design interview questions with solutions

> Common object-oriented design interview questions with sample discussions, code, and diagrams.
>
> Solutions linked to content in the `solutions/` folder.

>**Note: This section is under development**

| Question | |
|---|---|
| ออกแบบแฮชแมป | [คำตอบ](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/object_oriented_design/hash_table/hash_map.ipynb)  |
| ออกแบบแคชแบบ least recently used | [คำตอบ](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/object_oriented_design/lru_cache/lru_cache.ipynb)  |
| ออกแบบศูนย์บริการลูกค้า | [คำตอบ](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/object_oriented_design/call_center/call_center.ipynb)  |
| ออกแบบสำรับไพ่ | [คำตอบ](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/object_oriented_design/deck_of_cards/deck_of_cards.ipynb)  |
| ออกแบบที่จอดรถ | [คำตอบ](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/object_oriented_design/parking_lot/parking_lot.ipynb)  |
| ออกแบบเซิร์ฟเวอร์แชท | [คำตอบ](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/object_oriented_design/online_chat/online_chat.ipynb)  |
| ออกแบบอาร์เรย์วงกลม | [ร่วมสมทบ](#contributing)  |
| เพิ่มคำถามการออกแบบเชิงวัตถุ | [ร่วมสมทบ](#contributing) |

## หัวข้อการออกแบบระบบ: เริ่มต้นที่นี่

ใหม่กับการออกแบบระบบ?

ก่อนอื่น คุณต้องเข้าใจหลักการทั่วไปเกี่ยวกับสิ่งเหล่านี้ การใช้งาน และข้อดีข้อเสีย

### ขั้นตอนที่ 1: ทบทวนวิดีโอบรรยายเรื่องการขยายระบบ

[บรรยาย Scalability ที่ Harvard](https://www.youtube.com/watch?v=-W9F__D3oY4)

* หัวข้อที่ครอบคลุม:
    * การขยายแนวตั้ง
    * การขยายแนวนอน
    * การแคช
    * การบาลานซ์โหลด
    * การจำลองฐานข้อมูล
    * การแบ่งส่วนฐานข้อมูล

### ขั้นตอนที่ 2: ทบทวนบทความเกี่ยวกับการขยายระบบ

[Scalability](https://web.archive.org/web/20221030091841/http://www.lecloud.net/tagged/scalability/chrono)

* หัวข้อที่ครอบคลุม:
    * [โคลน](https://web.archive.org/web/20220530193911/https://www.lecloud.net/post/7295452622/scalability-for-dummies-part-1-clones)
    * [ฐานข้อมูล](https://web.archive.org/web/20220602114024/https://www.lecloud.net/post/7994751381/scalability-for-dummies-part-2-database)
    * [แคช](https://web.archive.org/web/20230126233752/https://www.lecloud.net/post/9246290032/scalability-for-dummies-part-3-cache)
    * [การทำงานแบบอะซิงโครนัส](https://web.archive.org/web/20220926171507/https://www.lecloud.net/post/9699762917/scalability-for-dummies-part-4-asynchronism)

### ขั้นตอนถัดไป

ต่อไป เราจะมาดูการชั่งน้ำหนักในระดับสูง:

* **ประสิทธิภาพ** เทียบกับ **ความสามารถในการขยายตัว**
* **ความหน่วง** เทียบกับ **อัตราการส่งผ่านข้อมูล**
* **ความพร้อมใช้งาน** เทียบกับ **ความสอดคล้อง**

โปรดจำไว้ว่า **ทุกอย่างคือการชั่งน้ำหนัก**

จากนั้นเราจะเจาะลึกในหัวข้อเฉพาะ เช่น DNS, CDN และโหลดบาลานเซอร์

## ประสิทธิภาพเทียบกับความสามารถในการขยายตัว

บริการจะ **ขยายตัวได้** ถ้าผลลัพธ์คือการเพิ่มขึ้นของ **ประสิทธิภาพ** ในสัดส่วนที่เหมาะสมกับทรัพยากรที่เพิ่มขึ้น โดยทั่วไป การเพิ่มประสิทธิภาพหมายถึงการให้บริการหน่วยงานมากขึ้น แต่ก็อาจรวมถึงการรองรับหน่วยงานที่ใหญ่ขึ้นด้วย เช่น เมื่อชุดข้อมูลเติบโตขึ้น<sup><a href=http://www.allthingsdistributed.com/2006/03/a_word_on_scalability.html>1</a></sup>

อีกวิธีหนึ่งในการมองประสิทธิภาพเทียบกับความสามารถในการขยายตัว:

* หากคุณมีปัญหา **ประสิทธิภาพ** ระบบของคุณจะช้าสำหรับผู้ใช้เพียงคนเดียว
* หากคุณมีปัญหา **การขยายตัว** ระบบของคุณจะเร็วสำหรับผู้ใช้คนเดียวแต่ช้าภายใต้ภาระงานหนัก

### แหล่งข้อมูลและอ่านเพิ่มเติม

* [A word on scalability](http://www.allthingsdistributed.com/2006/03/a_word_on_scalability.html)
* [Scalability, availability, stability, patterns](http://www.slideshare.net/jboner/scalability-availability-stability-patterns/)

## ความหน่วงเทียบกับอัตราการส่งผ่านข้อมูล

**ความหน่วง** คือเวลาที่ใช้ในการดำเนินการบางอย่างหรือเพื่อสร้างผลลัพธ์บางอย่าง

**อัตราการส่งผ่านข้อมูล** คือจำนวนของการกระทำหรือผลลัพธ์ดังกล่าวต่อหน่วยเวลา

โดยทั่วไป คุณควรมุ่งเน้นไปที่ **อัตราการส่งผ่านข้อมูลสูงสุด** พร้อม **ความหน่วงที่ยอมรับได้**

### แหล่งข้อมูลและอ่านเพิ่มเติม

* [Understanding latency vs throughput](https://community.cadence.com/cadence_blogs_8/b/fv/posts/understanding-latency-vs-throughput)

## ความพร้อมใช้งานเทียบกับความสอดคล้อง

### ทฤษฎี CAP

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/bgLMI2u.png">
  <br/>
  <i><a href=http://robertgreiner.com/2014/08/cap-theorem-revisited>ที่มา: ทบทวนทฤษฎี CAP</a></i>
</p>

ในระบบคอมพิวเตอร์แบบกระจาย คุณสามารถรองรับได้เพียงสองในสามของการรับประกันดังต่อไปนี้:

* **ความสอดคล้อง (Consistency)** - ทุกการอ่านจะได้รับการเขียนล่าสุดหรือเกิดข้อผิดพลาด
* **ความพร้อมใช้งาน (Availability)** - ทุกคำขอจะได้รับการตอบกลับ โดยไม่รับประกันว่าข้อมูลนั้นเป็นเวอร์ชันล่าสุด
* **ความทนทานต่อการแบ่งเครือข่าย (Partition Tolerance)** - ระบบยังคงทำงานต่อไปได้ แม้เกิดการแบ่งเครือข่ายอันเนื่องมาจากความล้มเหลวของเครือข่าย

*เครือข่ายไม่เสถียร ดังนั้นคุณจำเป็นต้องรองรับความทนทานต่อการแบ่งเครือข่าย คุณจะต้องเลือกแลกเปลี่ยนทางซอฟต์แวร์ระหว่างความสอดคล้องกับความพร้อมใช้งาน*

#### CP - ความสอดคล้องและความทนทานต่อการแบ่งเครือข่าย

การรอคำตอบจากโหนดที่ถูกแบ่งอาจทำให้เกิดข้อผิดพลาดแบบหมดเวลา CP เป็นตัวเลือกที่ดีหากธุรกิจของคุณต้องการการอ่านและเขียนแบบอะตอมิก

#### AP - ความพร้อมใช้งานและความทนทานต่อการแบ่งเครือข่าย

การตอบกลับจะส่งเวอร์ชันที่พร้อมใช้งานมากที่สุดของข้อมูลในโหนดใดๆ ซึ่งอาจไม่ใช่ข้อมูลล่าสุด การเขียนอาจใช้เวลาบางส่วนในการเผยแพร่เมื่อแบ่งเครือข่ายถูกแก้ไข

AP เป็นตัวเลือกที่ดีหากธุรกิจต้องการ [ความสอดคล้องในที่สุด](#eventual-consistency) หรือเมื่อระบบจำเป็นต้องทำงานต่อไปแม้เกิดข้อผิดพลาดภายนอก

### แหล่งข้อมูลและอ่านเพิ่มเติม

* [ทบทวนทฤษฎี CAP](http://robertgreiner.com/2014/08/cap-theorem-revisited/)
* [บทนำทฤษฎี CAP แบบภาษาอังกฤษง่ายๆ](http://ksat.me/a-plain-english-introduction-to-cap-theorem)
* [CAP FAQ](https://github.com/henryr/cap-faq)
* [ทฤษฎี CAP](https://www.youtube.com/watch?v=k-Yaq8AHlFA)

## รูปแบบความสอดคล้อง

เมื่อมีการสำเนาข้อมูลเดียวกันหลายชุด เราต้องตัดสินใจว่าจะซิงโครไนซ์ข้อมูลเหล่านั้นอย่างไร เพื่อให้ลูกค้ามีมุมมองข้อมูลที่สอดคล้องกัน จำคำนิยามของความสอดคล้องจาก [ทฤษฎี CAP](#cap-theorem) - ทุกการอ่านจะได้รับการเขียนล่าสุดหรือเกิดข้อผิดพลาด

### ความสอดคล้องแบบอ่อน (Weak consistency)

หลังจากการเขียน การอ่านอาจเห็นหรือไม่เห็นข้อมูลนั้นก็ได้ โดยใช้วิธีที่ดีที่สุดเท่าที่จะทำได้

แนวทางนี้พบในระบบเช่น memcached ความสอดคล้องแบบอ่อนเหมาะกับกรณีใช้งานเรียลไทม์ เช่น VoIP, วิดีโอแชท, และเกมผู้เล่นหลายคนแบบเรียลไทม์ ตัวอย่างเช่น หากคุณกำลังโทรศัพท์แล้วสัญญาณขาดหายไปสองสามวินาที เมื่อสัญญาณกลับมา คุณจะไม่ได้ยินสิ่งที่พูดในช่วงที่ขาดการเชื่อมต่อ

### ความสอดคล้องแบบสุดท้าย (Eventual consistency)

หลังจากการเขียน ข้อมูลที่อ่านจะสามารถเห็นการเปลี่ยนแปลงได้ในที่สุด (โดยปกติภายในไม่กี่มิลลิวินาที) ข้อมูลจะถูกจำลองแบบแบบอะซิงโครนัส

แนวทางนี้พบได้ในระบบเช่น DNS และอีเมล ความสอดคล้องแบบสุดท้ายเหมาะกับระบบที่ต้องการความพร้อมใช้งานสูง

### ความสอดคล้องแบบเข้มงวด (Strong consistency)

หลังจากการเขียน ข้อมูลที่อ่านจะสามารถเห็นการเปลี่ยนแปลงทันที ข้อมูลจะถูกจำลองแบบแบบซิงโครนัส

แนวทางนี้พบได้ในระบบไฟล์และ RDBMS ความสอดคล้องแบบเข้มงวดเหมาะกับระบบที่ต้องการธุรกรรม

### แหล่งข้อมูลและอ่านเพิ่มเติม

* [ธุรกรรมข้ามศูนย์ข้อมูล](http://snarfed.org/transactions_across_datacenters_io.html)

## รูปแบบความพร้อมใช้งาน

มีรูปแบบเสริมสองแบบเพื่อรองรับความพร้อมใช้งานสูง: **การสลับไปยังตัวสำรอง (fail-over)** และ **การจำลองแบบ (replication)**

### การสลับไปยังตัวสำรอง (Fail-over)

#### แอคทีฟ-พาสซีฟ (Active-passive)

ในการสลับแบบแอคทีฟ-พาสซีฟ จะมีการส่งสัญญาณหัวใจระหว่างเซิร์ฟเวอร์ที่ทำงาน (active) และเซิร์ฟเวอร์สำรอง (passive) ที่อยู่ในโหมด standby หากสัญญาณหัวใจขาดหาย เซิร์ฟเวอร์สำรองจะรับที่อยู่ IP ของเซิร์ฟเวอร์ active และเริ่มให้บริการต่อ

ระยะเวลาการหยุดทำงานขึ้นอยู่กับว่าเซิร์ฟเวอร์สำรองอยู่ในโหมด 'hot' standby หรือจะต้องเริ่มต้นจาก 'cold' standby เซิร์ฟเวอร์ active เท่านั้นที่รับส่งข้อมูล

การสลับแบบแอคทีฟ-พาสซีฟนี้ยังเรียกว่า master-slave failover

#### แอคทีฟ-แอคทีฟ (Active-active)

ในการสลับแบบแอคทีฟ-แอคทีฟ เซิร์ฟเวอร์ทั้งสองจะจัดการทราฟฟิกและแบ่งโหลดร่วมกัน

หากเซิร์ฟเวอร์เปิดเผยต่อสาธารณะ DNS จะต้องทราบที่อยู่ IP สาธารณะของทั้งสองเซิร์ฟเวอร์ หากเป็นเซิร์ฟเวอร์ภายในตรรกะของแอปพลิเคชันจะต้องทราบถึงทั้งสองเซิร์ฟเวอร์

การสลับแบบแอคทีฟ-แอคทีฟนี้ยังเรียกว่า master-master failover

### ข้อเสีย: การสลับไปยังตัวสำรอง (failover)

* การทำงานแบบ Fail-over ต้องเพิ่มฮาร์ดแวร์และความซับซ้อนเพิ่มเติม
* มีโอกาสสูญเสียข้อมูลหากระบบที่กำลังทำงานล้มเหลวก่อนที่ข้อมูลใหม่จะถูกจำลองไปยังระบบสำรอง

### การจำลองข้อมูล

#### แบบ Master-slave และ Master-master

หัวข้อนี้มีการพูดถึงเพิ่มเติมในส่วน [ฐานข้อมูล](#database):

* [การจำลองแบบ master-slave](#master-slave-replication)
* [การจำลองแบบ master-master](#master-master-replication)

### ความพร้อมใช้งานในตัวเลข

ความพร้อมใช้งานมักถูกระบุด้วยเวลาที่ระบบทำงาน (หรือเวลาที่ไม่ทำงาน) เป็นเปอร์เซ็นต์ของเวลาที่ให้บริการ โดยทั่วไปจะวัดเป็นจำนวนเลข 9--บริการที่มีความพร้อมใช้งาน 99.99% จะถูกเรียกว่า "สี่ 9"

#### ความพร้อมใช้งาน 99.9% - สาม 9

| ระยะเวลา            | เวลาหยุดทำงานที่ยอมรับได้ |
|---------------------|--------------------|
| หยุดทำงานต่อปี      | 8ชั่วโมง 45นาที 57วินาที |
| หยุดทำงานต่อเดือน   | 43นาที 49.7วินาที       |
| หยุดทำงานต่อสัปดาห์ | 10นาที 4.8วินาที        |
| หยุดทำงานต่อวัน     | 1นาที 26.4วินาที        |

#### ความพร้อมใช้งาน 99.99% - สี่ 9

| ระยะเวลา            | เวลาหยุดทำงานที่ยอมรับได้ |
|---------------------|--------------------|
| หยุดทำงานต่อปี      | 52นาที 35.7วินาที        |
| หยุดทำงานต่อเดือน   | 4นาที 23วินาที           |
| หยุดทำงานต่อสัปดาห์ | 1นาที 5วินาที            |
| หยุดทำงานต่อวัน     | 8.6วินาที                |

#### ความพร้อมใช้งานแบบขนาน vs แบบเรียงลำดับ

หากบริการประกอบด้วยหลายองค์ประกอบที่มีโอกาสล้มเหลว ความพร้อมใช้งานโดยรวมของบริการขึ้นอยู่กับว่าองค์ประกอบเหล่านั้นอยู่ในลำดับหรือขนานกัน

###### แบบเรียงลำดับ

ความพร้อมใช้งานโดยรวมจะลดลงเมื่อมีสององค์ประกอบที่มีความพร้อมใช้งานน้อยกว่า 100% ต่อเนื่องกัน:

```
Availability (Total) = Availability (Foo) * Availability (Bar)
```

หากทั้ง `Foo` และ `Bar` มีความพร้อมใช้งานอยู่ที่ 99.9% แต่ละตัว ความพร้อมใช้งานรวมกันในลำดับจะเหลือ 99.8%

###### แบบขนาน

ความพร้อมใช้งานโดยรวมจะเพิ่มขึ้นเมื่อมีสององค์ประกอบที่มีความพร้อมใช้งาน < 100% ทำงานแบบขนานกัน:

```
Availability (Total) = 1 - (1 - Availability (Foo)) * (1 - Availability (Bar))
```
ถ้าทั้ง `Foo` และ `Bar` มีความพร้อมใช้งาน 99.9% แต่ละตัว ความพร้อมใช้งานรวมกันแบบขนานจะเป็น 99.9999%

## ระบบชื่อโดเมน

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/IOyLj4i.jpg">
  <br/>
  <i><a href=http://www.slideshare.net/srikrupa5/dns-security-presentation-issa>ที่มา: การนำเสนอความปลอดภัยของ DNS</a></i>
</p>

ระบบชื่อโดเมน (DNS) ทำหน้าที่แปลงชื่อโดเมน เช่น www.example.com เป็นที่อยู่ IP

DNS มีลำดับชั้น โดยมีเซิร์ฟเวอร์ที่เชื่อถือได้ไม่กี่ตัวอยู่ระดับบนสุด เราเตอร์หรือ ISP จะให้ข้อมูลเกี่ยวกับเซิร์ฟเวอร์ DNS ที่จะติดต่อเมื่อทำการค้นหา เซิร์ฟเวอร์ DNS ระดับล่างจะเก็บแคชการจับคู่ซึ่งอาจล้าสมัยได้เนื่องจากการเผยแพร่ DNS ที่ล่าช้า ผลลัพธ์ DNS ยังสามารถถูกแคชโดยเบราว์เซอร์หรือระบบปฏิบัติการของคุณในระยะเวลาหนึ่ง โดยกำหนดจาก [time to live (TTL)](https://en.wikipedia.org/wiki/Time_to_live)

* **NS record (name server)** - กำหนดเซิร์ฟเวอร์ DNS สำหรับโดเมน/ซับโดเมนของคุณ
* **MX record (mail exchange)** - กำหนดเซิร์ฟเวอร์เมลสำหรับรับข้อความ
* **A record (address)** - ชี้ชื่อไปยังที่อยู่ IP
* **CNAME (canonical)** - ชี้ชื่อไปยังอีกชื่อหนึ่งหรือ `CNAME` (example.com ไป www.example.com) หรือไปยัง `A` record

บริการเช่น [CloudFlare](https://www.cloudflare.com/dns/) และ [Route 53](https://aws.amazon.com/route53/) ให้บริการ DNS แบบจัดการ บริการ DNS บางตัวสามารถจัดเส้นทางทราฟฟิกด้วยวิธีต่างๆ:

* [Weighted round robin](https://www.jscape.com/blog/load-balancing-algorithms)
    * ป้องกันทราฟฟิกไปยังเซิร์ฟเวอร์ที่อยู่ระหว่างการบำรุงรักษา
    * สมดุลระหว่างขนาดคลัสเตอร์ที่แตกต่างกัน
    * ทดสอบแบบ A/B
* [Latency-based](https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/routing-policy-latency.html)
* [Geolocation-based](https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/routing-policy-geo.html)

### ข้อเสีย: DNS

* การเข้าถึงเซิร์ฟเวอร์ DNS จะมีความล่าช้าเล็กน้อย แม้จะถูกลดผลกระทบด้วยการแคชที่กล่าวถึงข้างต้น
* การบริหารจัดการเซิร์ฟเวอร์ DNS อาจซับซ้อนและโดยทั่วไปจะถูกดูแลโดย [รัฐบาล, ISP และบริษัทขนาดใหญ่](http://superuser.com/questions/472695/who-controls-the-dns-servers/472729)
* บริการ DNS เมื่อเร็วๆ นี้ถูกโจมตีด้วย [DDoS](http://dyn.com/blog/dyn-analysis-summary-of-friday-october-21-attack/) ทำให้ผู้ใช้ไม่สามารถเข้าเว็บไซต์เช่น Twitter ได้หากไม่ทราบที่อยู่ IP ของ Twitter

### แหล่งข้อมูลและอ่านเพิ่มเติม

* [สถาปัตยกรรม DNS](https://technet.microsoft.com/en-us/library/dd197427(v=ws.10).aspx)
* [วิกิพีเดีย](https://en.wikipedia.org/wiki/Domain_Name_System)
* [บทความเกี่ยวกับ DNS](https://support.dnsimple.com/categories/dns/)


## เครือข่ายการส่งมอบเนื้อหา (Content delivery network)

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/h9TAuGI.jpg">
  <br/>
  <i><a href=https://www.creative-artworks.eu/why-use-a-content-delivery-network-cdn/>ที่มา: เหตุผลในการใช้ CDN</a></i>
</p>

เครือข่ายการส่งมอบเนื้อหา (CDN) คือเครือข่ายพร็อกซีเซิร์ฟเวอร์ที่กระจายอยู่ทั่วโลก มีหน้าที่ให้บริการเนื้อหาจากตำแหน่งที่ใกล้กับผู้ใช้มากที่สุด โดยทั่วไปไฟล์แบบสถาติก เช่น HTML/CSS/JS, รูปภาพ และวิดีโอ จะถูกให้บริการผ่าน CDN แม้ว่า CDN บางตัว เช่น CloudFront ของ Amazon จะรองรับเนื้อหาแบบไดนามิกด้วย การแก้ไข DNS ของเว็บไซต์จะบอกลูกค้าว่าควรติดต่อเซิร์ฟเวอร์ใด

การให้บริการเนื้อหาจาก CDN สามารถปรับปรุงประสิทธิภาพได้อย่างมากในสองลักษณะ:

* ผู้ใช้จะได้รับเนื้อหาจากศูนย์ข้อมูลที่อยู่ใกล้กับตนเอง
* เซิร์ฟเวอร์ของคุณไม่จำเป็นต้องตอบสนองคำขอที่ CDN ได้รับแทนแล้ว

### Push CDN

Push CDN จะได้รับเนื้อหาใหม่เมื่อมีการเปลี่ยนแปลงบนเซิร์ฟเวอร์ของคุณ คุณจะรับผิดชอบในการจัดเตรียมเนื้อหา อัปโหลดโดยตรงไปยัง CDN และแก้ไข URL เพื่อชี้ไปยัง CDN คุณสามารถกำหนดเวลาหมดอายุและการอัปเดตเนื้อหาได้ เนื้อหาจะถูกอัปโหลดก็ต่อเมื่อมีการเปลี่ยนแปลงหรือเป็นเนื้อหาใหม่เท่านั้น ซึ่งช่วยลดปริมาณการรับส่งข้อมูลแต่เพิ่มพื้นที่จัดเก็บ

เว็บไซต์ที่มีปริมาณการใช้งานน้อยหรือเนื้อหาที่ไม่ค่อยมีการอัปเดตเหมาะกับ Push CDN เนื้อหาจะถูกนำขึ้น CDN เพียงครั้งเดียวแทนที่จะดึงใหม่ตามช่วงเวลา

### Pull CDN

Pull CDN จะดึงเนื้อหาใหม่จากเซิร์ฟเวอร์ของคุณเมื่อผู้ใช้คนแรกขอเนื้อหานั้น คุณจะปล่อยให้เนื้อหาอยู่บนเซิร์ฟเวอร์และแก้ไข URL เพื่อชี้ไปที่ CDN ส่งผลให้การร้องขอครั้งแรกช้ากว่าจนกว่าเนื้อหาจะถูกแคชบน CDN

ค่า [time-to-live (TTL)](https://en.wikipedia.org/wiki/Time_to_live) จะกำหนดระยะเวลาการแคชเนื้อหา Pull CDN ช่วยลดพื้นที่จัดเก็บบน CDN แต่สามารถเกิดการรับส่งข้อมูลซ้ำซ้อนหากไฟล์หมดอายุก่อนที่เนื้อหาจะมีการเปลี่ยนแปลงจริง

เว็บไซต์ที่มีปริมาณการใช้งานสูงเหมาะกับ Pull CDN เพราะปริมาณการรับส่งข้อมูลจะแบ่งกระจายอย่างเหมาะสม โดยเนื้อหาที่มีการร้องขอล่าสุดเท่านั้นจะอยู่บน CDN

### ข้อเสีย: CDN

* ค่าใช้จ่ายของ CDN อาจสูงมากขึ้นอยู่กับปริมาณการใช้งาน แม้ว่าควรเปรียบเทียบกับค่าใช้จ่ายเพิ่มเติมหากไม่ใช้ CDN
* เนื้อหาอาจล้าสมัยหากมีการอัปเดตก่อนที่ TTL จะหมดอายุ
* การใช้ CDN จำเป็นต้องเปลี่ยน URL ของเนื้อหาสถาติกให้ชี้ไปยัง CDN

### แหล่งข้อมูลและการอ่านเพิ่มเติม

* [การส่งมอบเนื้อหาทั่วโลกแบบกระจาย](https://figshare.com/articles/Globally_distributed_content_delivery/6605972)
* [ความแตกต่างระหว่าง Push และ Pull CDN](http://www.travelblogadvice.com/technical/the-differences-between-push-and-pull-cdns/)
* [วิกิพีเดีย](https://en.wikipedia.org/wiki/Content_delivery_network)

## ตัวกระจายโหลด (Load balancer)

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/h81n9iK.png">
  <br/>
  <i><a href=http://horicky.blogspot.com/2010/10/scalable-system-design-patterns.html>ที่มา: รูปแบบการออกแบบระบบที่ปรับขยายได้</a></i>
</p>

ตัวกระจายโหลดจะกระจายคำขอจากลูกค้าที่เข้ามายังทรัพยากรคอมพิวเตอร์ เช่น เซิร์ฟเวอร์แอปพลิเคชันและฐานข้อมูล ในแต่ละกรณี ตัวกระจายโหลดจะส่งคืนการตอบกลับจากทรัพยากรคอมพิวเตอร์ไปยังลูกค้าที่เหมาะสม ตัวกระจายโหลดมีประสิทธิภาพในการ:

* ป้องกันไม่ให้คำขอถูกส่งไปยังเซิร์ฟเวอร์ที่ไม่พร้อมใช้งาน
* ป้องกันการใช้งานทรัพยากรเกินขีดจำกัด
* ช่วยขจัดจุดล้มเหลวเดียว

ตัวกระจายโหลดสามารถติดตั้งเป็นฮาร์ดแวร์ (ราคาแพง) หรือซอฟต์แวร์เช่น HAProxy

ประโยชน์เพิ่มเติม ได้แก่:

* **SSL termination** - ถอดรหัสคำขอที่เข้ามาและเข้ารหัสการตอบกลับของเซิร์ฟเวอร์เพื่อให้เซิร์ฟเวอร์เบื้องหลังไม่ต้องดำเนินการที่มีต้นทุนสูงเหล่านี้
    * ไม่จำเป็นต้องติดตั้ง [ใบรับรอง X.509](https://en.wikipedia.org/wiki/X.509) บนแต่ละเซิร์ฟเวอร์
* **Session persistence** - ออกคุกกี้และกำหนดเส้นทางคำขอของลูกค้ารายเดิมไปยังอินสแตนซ์เดียวกัน หากเว็บแอปไม่ได้ติดตามเซสชัน

เพื่อป้องกันปัญหาความล้มเหลว มักจะมีการตั้งค่าตัวกระจายโหลดหลายตัว ทั้งในโหมด [active-passive](#active-passive) หรือ [active-active](#active-active)

ตัวกระจายโหลดสามารถกำหนดเส้นทางการรับส่งข้อมูลตามตัวชี้วัดต่างๆ ได้แก่:

* สุ่ม
* โหลดน้อยที่สุด
* เซสชัน/คุกกี้
* [รอบโรบินหรือรอบโรบินแบบถ่วงน้ำหนัก](https://www.g33kinfo.com/info/round-robin-vs-weighted-round-robin-lb)
* [Layer 4](#layer-4-load-balancing)
* [Layer 7](#layer-7-load-balancing)

### การกระจายโหลดชั้นที่ 4

ตัวกระจายโหลดชั้นที่ 4 จะพิจารณาข้อมูลใน [เลเยอร์ขนส่ง](#communication) เพื่อใช้ตัดสินใจว่าจะกระจายคำขออย่างไร โดยทั่วไปจะเกี่ยวข้องกับที่อยู่ IP ต้นทางและปลายทาง และพอร์ตในส่วนหัว แต่จะไม่ดูเนื้อหาของแพ็กเก็ต ตัวกระจายโหลดชั้นที่ 4 จะส่งต่อแพ็กเก็ตเครือข่ายไปและกลับจากเซิร์ฟเวอร์ต้นทาง โดยดำเนินการ [Network Address Translation (NAT)](https://www.nginx.com/resources/glossary/layer-4-load-balancing/)

### การกระจายโหลดชั้นที่ 7
ตัวบาลานซ์โหลดเลเยอร์ 7 จะดูที่ [ชั้นแอปพลิเคชัน](#communication) เพื่อช่วยตัดสินใจว่าจะกระจายคำขออย่างไร ซึ่งอาจเกี่ยวข้องกับเนื้อหาของส่วนหัว ข้อความ และคุกกี้ ตัวบาลานซ์โหลดเลเยอร์ 7 จะยุติทราฟฟิกเครือข่าย อ่านข้อความ ตัดสินใจในการบาลานซ์โหลด แล้วเปิดการเชื่อมต่อกับเซิร์ฟเวอร์ที่เลือก ตัวอย่างเช่น ตัวบาลานซ์โหลดเลเยอร์ 7 สามารถนำทราฟฟิกวิดีโอไปยังเซิร์ฟเวอร์ที่โฮสต์วิดีโอ ในขณะที่นำทราฟฟิกที่เกี่ยวกับการเรียกเก็บเงินของผู้ใช้ที่มีความละเอียดอ่อนไปยังเซิร์ฟเวอร์ที่มีการเสริมความปลอดภัย

ด้วยต้นทุนด้านความยืดหยุ่น การบาลานซ์โหลดเลเยอร์ 4 ต้องการเวลาน้อยกว่าและทรัพยากรคอมพิวเตอร์น้อยกว่าเลเยอร์ 7 แม้ว่าผลกระทบต่อประสิทธิภาพจะน้อยมากในฮาร์ดแวร์ทั่วไปยุคใหม่

### การขยายแนวนอน

ตัวบาลานซ์โหลดยังช่วยในการขยายแนวนอน เพื่อปรับปรุงประสิทธิภาพและความพร้อมใช้งาน การขยายออกโดยใช้เครื่องราคาถูกจะมีประสิทธิภาพด้านต้นทุนมากกว่าและให้ความพร้อมใช้งานที่สูงกว่าการขยายเซิร์ฟเวอร์เดียวด้วยฮาร์ดแวร์ราคาแพง ซึ่งเรียกว่า **การขยายแนวตั้ง** นอกจากนี้ยังง่ายกว่าที่จะหาบุคลากรที่มีความสามารถทำงานกับฮาร์ดแวร์ทั่วไปมากกว่าระบบองค์กรเฉพาะทาง

#### ข้อเสีย: การขยายแนวนอน

* การขยายแนวนอนเพิ่มความซับซ้อนและเกี่ยวข้องกับการโคลนเซิร์ฟเวอร์
    * เซิร์ฟเวอร์ควรเป็นแบบไร้สถานะ: ไม่ควรมีข้อมูลที่เกี่ยวข้องกับผู้ใช้ เช่น เซสชันหรือรูปโปรไฟล์
    * เซสชันสามารถจัดเก็บไว้ในคลังข้อมูลแบบรวมศูนย์ เช่น [ฐานข้อมูล](#database) (SQL, NoSQL) หรือ [แคช](#cache) แบบถาวร (Redis, Memcached)
* เซิร์ฟเวอร์ปลายทาง เช่น แคชและฐานข้อมูล ต้องรองรับการเชื่อมต่อพร้อมกันมากขึ้นเมื่อเซิร์ฟเวอร์ต้นทางขยายตัว

### ข้อเสีย: ตัวบาลานซ์โหลด

* ตัวบาลานซ์โหลดอาจกลายเป็นคอขวดด้านประสิทธิภาพหากไม่มีทรัพยากรเพียงพอหรือไม่ได้รับการกำหนดค่าอย่างถูกต้อง
* การนำตัวบาลานซ์โหลดมาใช้เพื่อขจัดจุดล้มเหลวเพียงจุดเดียวจะเพิ่มความซับซ้อน
* ตัวบาลานซ์โหลดเดียวเป็นจุดล้มเหลวเพียงจุดเดียว การกำหนดค่าตัวบาลานซ์โหลดหลายตัวจะเพิ่มความซับซ้อนอีก

### แหล่งข้อมูลและอ่านเพิ่มเติม

* [โครงสร้างสถาปัตยกรรม NGINX](https://www.nginx.com/blog/inside-nginx-how-we-designed-for-performance-scale/)
* [คู่มือโครงสร้างสถาปัตยกรรม HAProxy](http://www.haproxy.org/download/1.2/doc/architecture.txt)
* [ความสามารถในการขยายตัว](https://web.archive.org/web/20220530193911/https://www.lecloud.net/post/7295452622/scalability-for-dummies-part-1-clones)
* [วิกิพีเดีย](https://en.wikipedia.org/wiki/Load_balancing_(computing))
* [การบาลานซ์โหลดเลเยอร์ 4](https://www.nginx.com/resources/glossary/layer-4-load-balancing/)
* [การบาลานซ์โหลดเลเยอร์ 7](https://www.nginx.com/resources/glossary/layer-7-load-balancing/)
* [การตั้งค่า ELB listener](http://docs.aws.amazon.com/elasticloadbalancing/latest/classic/elb-listener-config.html)

## รีเวิร์สพร็อกซี (เว็บเซิร์ฟเวอร์)

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/n41Azff.png">
  <br/>
  <i><a href=https://upload.wikimedia.org/wikipedia/commons/6/67/Reverse_proxy_h2g2bob.svg>แหล่งที่มา: วิกิพีเดีย</a></i>
  <br/>
</p>

รีเวิร์สพร็อกซี่คือเว็บเซิร์ฟเวอร์ที่รวมบริการภายในและให้บริการอินเตอร์เฟซแบบรวมถึงสาธารณะ คำขอจากไคลเอนต์จะถูกส่งต่อไปยังเซิร์ฟเวอร์ที่สามารถตอบสนองได้ก่อนที่รีเวิร์สพร็อกซี่จะส่งคืนการตอบสนองของเซิร์ฟเวอร์ไปยังไคลเอนต์

ประโยชน์เพิ่มเติมประกอบด้วย:

* **เพิ่มความปลอดภัย** - ซ่อนข้อมูลเกี่ยวกับแบ็กเอนด์เซิร์ฟเวอร์, แบล็กลิสต์ IP, จำกัดจำนวนการเชื่อมต่อต่อไคลเอนต์
* **เพิ่มความสามารถในการขยายและความยืดหยุ่น** - ไคลเอนต์จะเห็นแค่ IP ของรีเวิร์สพร็อกซี่ ทำให้สามารถขยายเซิร์ฟเวอร์หรือเปลี่ยนการตั้งค่าได้
* **SSL termination** - ถอดรหัสคำขอขาเข้าและเข้ารหัสการตอบสนองเซิร์ฟเวอร์เพื่อให้แบ็กเอนด์เซิร์ฟเวอร์ไม่ต้องดำเนินการเหล่านี้ซึ่งอาจมีค่าใช้จ่ายสูง
    * ไม่จำเป็นต้องติดตั้ง [ใบรับรอง X.509](https://en.wikipedia.org/wiki/X.509) บนแต่ละเซิร์ฟเวอร์
* **การบีบอัด** - บีบอัดการตอบสนองของเซิร์ฟเวอร์
* **การแคช** - ส่งคืนการตอบสนองสำหรับคำขอที่ถูกแคชไว้
* **เนื้อหาสถิต** - ให้บริการเนื้อหาสถิตโดยตรง
    * HTML/CSS/JS
    * รูปภาพ
    * วิดีโอ
    * ฯลฯ

### ตัวโหลดบาลานเซอร์ vs รีเวิร์สพร็อกซี่

* การติดตั้งโหลดบาลานเซอร์จะมีประโยชน์เมื่อคุณมีหลายเซิร์ฟเวอร์ โดยปกติโหลดบาลานเซอร์จะส่งทราฟฟิกไปยังชุดเซิร์ฟเวอร์ที่ให้บริการฟังก์ชันเดียวกัน
* รีเวิร์สพร็อกซี่มีประโยชน์แม้จะมีเว็บเซิร์ฟเวอร์หรือแอปพลิเคชันเซิร์ฟเวอร์เพียงตัวเดียว โดยเปิดใช้ประโยชน์ตามที่กล่าวไว้ในส่วนก่อนหน้า
* โซลูชันเช่น NGINX และ HAProxy รองรับทั้งการรีเวิร์สพร็อกซี่เลเยอร์ 7 และโหลดบาลานซิ่ง

### ข้อเสีย: รีเวิร์สพร็อกซี่

* การเพิ่มรีเวิร์สพร็อกซี่ทำให้เกิดความซับซ้อนเพิ่มขึ้น
* การมีรีเวิร์สพร็อกซี่เพียงตัวเดียวเป็นจุดล้มเหลวเดียว การตั้งค่าหลายรีเวิร์สพร็อกซี่ (เช่น [failover](https://en.wikipedia.org/wiki/Failover)) จะเพิ่มความซับซ้อนเข้าไปอีก

### แหล่งข้อมูลและอ่านเพิ่มเติม

* [Reverse proxy vs load balancer](https://www.nginx.com/resources/glossary/reverse-proxy-vs-load-balancer/)
* [NGINX architecture](https://www.nginx.com/blog/inside-nginx-how-we-designed-for-performance-scale/)
* [HAProxy architecture guide](http://www.haproxy.org/download/1.2/doc/architecture.txt)
* [Wikipedia](https://en.wikipedia.org/wiki/Reverse_proxy)

## เลเยอร์แอปพลิเคชัน

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/yB5SYwm.png">
  <br/>

  <i><a href=http://lethain.com/introduction-to-architecting-systems-for-scale/#platform_layer>ที่มา: แนะนำการออกแบบสถาปัตยกรรมระบบสำหรับการขยายขนาด</a></i>
</p>

การแยกชั้นเว็บออกจากชั้นแอปพลิเคชัน (หรือที่เรียกว่าชั้นแพลตฟอร์ม) ทำให้สามารถขยายและปรับแต่งแต่ละชั้นได้อย่างอิสระ การเพิ่ม API ใหม่จะนำไปสู่การเพิ่มเซิร์ฟเวอร์แอปพลิเคชันโดยไม่จำเป็นต้องเพิ่มเซิร์ฟเวอร์เว็บเพิ่มเติม หลักการ**ความรับผิดชอบเดียว**สนับสนุนบริการขนาดเล็กและอิสระที่ทำงานร่วมกัน ทีมขนาดเล็กที่มีบริการขนาดเล็กสามารถวางแผนการเติบโตอย่างรวดเร็วได้อย่างจริงจัง

Worker ในชั้นแอปพลิเคชันยังช่วยเปิดใช้งาน [การทำงานแบบอะซิงโครนัส](#asynchronism) ได้อีกด้วย

### ไมโครเซอร์วิส

ที่เกี่ยวข้องกับการอภิปรายนี้คือ [ไมโครเซอร์วิส](https://en.wikipedia.org/wiki/Microservices) ซึ่งสามารถอธิบายได้ว่าเป็นชุดของบริการขนาดเล็กแบบแยกติดตั้งได้แต่ละบริการทำงานเป็นกระบวนการเฉพาะและสื่อสารกันผ่านกลไกที่นิยามไว้อย่างชัดเจนและเบาเพื่อบรรลุเป้าหมายทางธุรกิจ <sup><a href=https://smartbear.com/learn/api-design/what-are-microservices>1</a></sup>

ตัวอย่างเช่น Pinterest อาจมีไมโครเซอร์วิสดังนี้: โปรไฟล์ผู้ใช้, ผู้ติดตาม, ฟีด, การค้นหา, อัปโหลดรูปภาพ ฯลฯ

### การค้นหาบริการ

ระบบอย่าง [Consul](https://www.consul.io/docs/index.html), [Etcd](https://coreos.com/etcd/docs/latest), และ [Zookeeper](http://www.slideshare.net/sauravhaloi/introduction-to-apache-zookeeper) สามารถช่วยให้บริการค้นหาซึ่งกันและกันโดยติดตามชื่อ, ที่อยู่, และพอร์ตที่ลงทะเบียน [Health checks](https://www.consul.io/intro/getting-started/checks.html) ใช้ตรวจสอบความสมบูรณ์ของบริการและมักดำเนินการโดยใช้ [HTTP](#hypertext-transfer-protocol-http) endpoint ทั้ง Consul และ Etcd มี [key-value store](#key-value-store) ในตัวซึ่งมีประโยชน์สำหรับจัดเก็บค่าคอนฟิกและข้อมูลที่ใช้ร่วมกันอื่น ๆ

### ข้อเสีย: ชั้นแอปพลิเคชัน

* การเพิ่มชั้นแอปพลิเคชันที่มีบริการเชื่อมโยงกันอย่างหลวมต้องการแนวทางที่แตกต่างในแง่สถาปัตยกรรม, การปฏิบัติการ, และกระบวนการ (เมื่อเทียบกับระบบแบบโมโนลิทิก)
* ไมโครเซอร์วิสอาจเพิ่มความซับซ้อนในด้านการติดตั้งและการปฏิบัติการ

### แหล่งข้อมูลและอ่านเพิ่มเติม

* [แนะนำการออกแบบสถาปัตยกรรมระบบสำหรับการขยายขนาด](http://lethain.com/introduction-to-architecting-systems-for-scale)
* [เตรียมตัวสัมภาษณ์ออกแบบระบบ](http://www.puncsky.com/blog/2016-02-13-crack-the-system-design-interview)
* [สถาปัตยกรรมแบบบริการเป็นศูนย์กลาง](https://en.wikipedia.org/wiki/Service-oriented_architecture)
* [แนะนำ Zookeeper](http://www.slideshare.net/sauravhaloi/introduction-to-apache-zookeeper)
* [สิ่งที่ควรรู้เกี่ยวกับการสร้างไมโครเซอร์วิส](https://cloudncode.wordpress.com/2016/07/22/msa-getting-started/)

## ฐานข้อมูล

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/Xkm5CXz.png">
  <br/>
  <i><a href=https://www.youtube.com/watch?v=kKjm4ehYiMs>ที่มา: การขยายระบบรองรับผู้ใช้ 10 ล้านคนแรก</a></i>
</p>

### ระบบจัดการฐานข้อมูลเชิงสัมพันธ์ (RDBMS)

ฐานข้อมูลเชิงสัมพันธ์เช่น SQL คือการรวบรวมรายการข้อมูลที่ถูกจัดระเบียบในรูปแบบตาราง

**ACID** คือชุดคุณสมบัติของ [ธุรกรรม](https://en.wikipedia.org/wiki/Database_transaction) ฐานข้อมูลเชิงสัมพันธ์

* **Atomicity** - แต่ละธุรกรรมต้องสำเร็จทั้งหมดหรือไม่สำเร็จเลย
* **Consistency** - ทุกธุรกรรมจะเปลี่ยนฐานข้อมูลจากสถานะที่ถูกต้องหนึ่งไปยังอีกสถานะที่ถูกต้อง
* **Isolation** - การดำเนินการธุรกรรมพร้อมกันจะให้ผลลัพธ์เหมือนกับการดำเนินการแบบเรียงลำดับทีละธุรกรรม
* **Durability** - เมื่อธุรกรรมถูกยืนยันแล้ว จะคงอยู่ถาวร

มีเทคนิคมากมายในการขยายฐานข้อมูลเชิงสัมพันธ์: **การจำลองแบบมาสเตอร์-สเลฟ**, **การจำลองแบบมาสเตอร์-มาสเตอร์**, **เฟเดอเรชั่น**, **ชาร์ดดิง**, **การลดการทำปกติ**, และ **การปรับแต่ง SQL**

#### การจำลองแบบมาสเตอร์-สเลฟ

มาสเตอร์ให้บริการการอ่านและเขียน โดยจำลองข้อมูลที่เขียนไปยังหนึ่งหรือหลายสเลฟ ซึ่งให้บริการอ่านเท่านั้น สเลฟยังสามารถจำลองข้อมูลไปยังสเลฟเพิ่มเติมในลักษณะเป็นต้นไม้ หากมาสเตอร์ออฟไลน์ ระบบยังคงให้บริการในโหมดอ่านอย่างเดียวจนกว่าสเลฟจะถูกยกระดับเป็นมาสเตอร์หรือมีการจัดเตรียมมาสเตอร์ใหม่

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/C9ioGtn.png">
  <br/>
  <i><a href=http://www.slideshare.net/jboner/scalability-availability-stability-patterns/>ที่มา: Scalability, availability, stability, patterns</a></i>
</p>

##### ข้อเสีย: การจำลองแบบมาสเตอร์-สเลฟ

* ต้องมีตรรกะเพิ่มเติมเพื่อยกระดับสเลฟเป็นมาสเตอร์
* ดู [ข้อเสีย: การจำลองแบบ](#disadvantages-replication) สำหรับประเด็นที่เกี่ยวข้องกับทั้งมาสเตอร์-สเลฟและมาสเตอร์-มาสเตอร์

#### การจำลองแบบมาสเตอร์-มาสเตอร์

ทั้งสองมาสเตอร์ให้บริการการอ่านและเขียน และประสานงานกันในการเขียน หากมาสเตอร์ใดมาสเตอร์หนึ่งล่ม ระบบยังคงให้บริการทั้งอ่านและเขียนได้

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/krAHLGg.png">
  <br/>
  <i><a href=http://www.slideshare.net/jboner/scalability-availability-stability-patterns/>ที่มา: Scalability, availability, stability, patterns</a></i>
</p>

##### ข้อเสีย: การจำลองแบบมาสเตอร์-มาสเตอร์

* คุณต้องมีตัวจัดสมดุลโหลด หรือคุณต้องปรับเปลี่ยนตรรกะของแอปพลิเคชันเพื่อกำหนดว่าจะเขียนที่ใด
* ระบบมาสเตอร์-มาสเตอร์ส่วนใหญ่จะมีความสอดคล้องหลวม (ละเมิด ACID) หรือมีความหน่วงในการเขียนเพิ่มขึ้นเนื่องจากต้องประสานข้อมูล
* การแก้ไขข้อขัดแย้งจะมีบทบาทมากขึ้นเมื่อมีการเพิ่มโหนดที่สามารถเขียนข้อมูลได้มากขึ้นและเมื่อความหน่วงเพิ่มสูงขึ้น
* ดู [ข้อเสีย: การทำสำเนา (replication)](#disadvantages-replication) สำหรับจุดที่เกี่ยวข้องกับ **ทั้ง** ระบบ master-slave และ master-master

##### ข้อเสีย: การทำสำเนา (replication)

* มีความเสี่ยงที่จะสูญเสียข้อมูลหากเครื่อง master ล้มเหลวก่อนที่ข้อมูลที่เขียนใหม่จะถูกส่งต่อไปยังโหนดอื่นๆ
* การเขียนข้อมูลจะถูกเล่นซ้ำไปยัง read replica หากมีการเขียนมาก read replica อาจประสบปัญหาเนื่องจากต้องเล่นซ้ำการเขียนและอาจอ่านข้อมูลได้ลดลง
* ยิ่งมี read slave มากเท่าไร ก็ยิ่งต้องทำสำเนามากขึ้น ส่งผลให้เกิดความล่าช้าในการทำสำเนามากขึ้น
* บางระบบสามารถเขียนไปยัง master ได้โดยสร้าง thread หลายตัวเพื่อเขียนแบบขนาน ขณะที่ read replica รองรับการเขียนแบบต่อเนื่องด้วย thread เดียวเท่านั้น
* การทำสำเนาเพิ่มฮาร์ดแวร์และความซับซ้อนมากขึ้น

##### แหล่งข้อมูลและอ่านเพิ่มเติม: การทำสำเนา (replication)

* [Scalability, availability, stability, patterns](http://www.slideshare.net/jboner/scalability-availability-stability-patterns/)
* [Multi-master replication](https://en.wikipedia.org/wiki/Multi-master_replication)

#### การแบ่งกลุ่ม (Federation)

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/U3qV33e.png">
  <br/>
  <i><a href=https://www.youtube.com/watch?v=kKjm4ehYiMs>ที่มา: Scaling up to your first 10 million users</a></i>
</p>

Federation (หรือการแบ่งกลุ่มตามหน้าที่) คือการแยกฐานข้อมูลตามฟังก์ชัน เช่น แทนที่จะใช้ฐานข้อมูลเดียวแบบ monolithic คุณอาจมีฐานข้อมูลสามส่วน: **forums**, **users** และ **products** ส่งผลให้การอ่านและเขียนข้อมูลแต่ละฐานข้อมูลลดลง และลดความล่าช้าในการทำสำเนา ฐานข้อมูลขนาดเล็กทำให้ข้อมูลจำนวนมากถูกเก็บในหน่วยความจำได้มากขึ้น ส่งผลให้ cache hit เพิ่มขึ้นเนื่องจาก locality ของ cache ดีขึ้น เมื่อไม่มี master กลางที่คอย serialize การเขียน คุณสามารถเขียนแบบขนานได้ ส่งผลให้ throughput เพิ่มขึ้น

##### ข้อเสีย: Federation

* Federation ไม่ได้ผลหาก schema ของคุณต้องการฟังก์ชันหรือ table ขนาดใหญ่
* คุณต้องปรับปรุงตรรกะของแอปพลิเคชันเพื่อกำหนดว่าจะอ่านหรือเขียนฐานข้อมูลใด
* การ join ข้อมูลจากสองฐานข้อมูลจะซับซ้อนมากขึ้นเมื่อใช้ [server link](http://stackoverflow.com/questions/5145637/querying-data-by-joining-two-tables-in-two-database-on-different-servers)
* Federation เพิ่มฮาร์ดแวร์และความซับซ้อนมากขึ้น

##### แหล่งข้อมูลและอ่านเพิ่มเติม: Federation

* [Scaling up to your first 10 million users](https://www.youtube.com/watch?v=kKjm4ehYiMs)

#### การแบ่งส่วนข้อมูล (Sharding)

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/wU8x5Id.png">
  <br/>
  <i><a href=http://www.slideshare.net/jboner/scalability-availability-stability-patterns/>ที่มา: Scalability, availability, stability, patterns</a></i>
</p>

Sharding คือการกระจายข้อมูลไปยังฐานข้อมูลต่าง ๆ โดยแต่ละฐานข้อมูลจะจัดการข้อมูลเพียงบางส่วนเท่านั้น ตัวอย่างเช่นฐานข้อมูลผู้ใช้ เมื่อจำนวนผู้ใช้เพิ่มขึ้น ก็จะมีการเพิ่ม shard ในคลัสเตอร์

เช่นเดียวกับข้อดีของ [federation](#federation) การ sharding จะช่วยลดปริมาณการอ่านและเขียน ลดการทำซ้ำข้อมูล และเพิ่มโอกาสในการ cache hit ขนาดของดัชนีก็ลดลง ซึ่งโดยทั่วไปจะช่วยให้ประสิทธิภาพดีขึ้นด้วยการ query ที่เร็วขึ้น หาก shard ใดล่ม shard อื่น ๆ ยังสามารถทำงานได้ตามปกติ แม้ว่าคุณจะต้องเพิ่มการทำ replication เพื่อป้องกันการสูญหายของข้อมูลก็ตาม เช่นเดียวกับ federation ไม่มี master กลางที่เป็นศูนย์กลางในการ serialize การเขียน ทำให้สามารถเขียนข้อมูลแบบขนานและ throughput เพิ่มขึ้น

วิธีการ sharding ฐานข้อมูลผู้ใช้ที่พบบ่อย คือการใช้ตัวอักษรแรกของนามสกุลผู้ใช้ หรือใช้ตำแหน่งทางภูมิศาสตร์ของผู้ใช้

##### ข้อเสีย: sharding

* คุณจะต้องปรับตรรกะของแอปพลิเคชันให้รองรับ shard ซึ่งอาจทำให้ query SQL ซับซ้อนมากขึ้น
* การกระจายข้อมูลใน shard อาจไม่สมดุล เช่น หากมีผู้ใช้ที่ใช้ระบบหนักมากอยู่ใน shard เดียวกัน อาจทำให้ shard นั้นรับโหลดมากกว่าชุดอื่น ๆ
    * การปรับสมดุล (rebalancing) เพิ่มความซับซ้อน ฟังก์ชัน sharding ที่ใช้ [consistent hashing](http://www.paperplanes.de/2011/12/9/the-magic-of-consistent-hashing.html) สามารถลดปริมาณข้อมูลที่ต้องโอนย้าย
* การ join ข้อมูลจากหลาย shard จะซับซ้อนมากขึ้น
* การ sharding เพิ่มความต้องการฮาร์ดแวร์และความซับซ้อนโดยรวม

##### แหล่งที่มาและอ่านเพิ่มเติม: sharding

* [The coming of the shard](http://highscalability.com/blog/2009/8/6/an-unorthodox-approach-to-database-design-the-coming-of-the.html)
* [Shard database architecture](https://en.wikipedia.org/wiki/Shard_(database_architecture))
* [Consistent hashing](http://www.paperplanes.de/2011/12/9/the-magic-of-consistent-hashing.html)

#### Denormalization

Denormalization คือการปรับปรุงประสิทธิภาพการอ่านโดยแลกกับประสิทธิภาพการเขียนในบางกรณี โดยเขียนข้อมูลสำรองซ้ำในหลายตารางเพื่อลดความจำเป็นในการ join ที่มีต้นทุนสูง RDBMS บางตัวเช่น [PostgreSQL](https://en.wikipedia.org/wiki/PostgreSQL) และ Oracle รองรับ [materialized views](https://en.wikipedia.org/wiki/Materialized_view) ที่ช่วยจัดการข้อมูลสำรองและทำให้ข้อมูลคัดลอกซ้ำกันมีความสอดคล้องกัน

เมื่อข้อมูลถูกกระจายด้วยเทคนิคอย่าง [federation](#federation) และ [sharding](#sharding) การจัดการ join ข้าม data center จะมีความซับซ้อนมากขึ้น การ denormalization อาจช่วยหลีกเลี่ยงความจำเป็นในการ join ที่ซับซ้อนเหล่านี้

ในระบบส่วนใหญ่ การอ่านมักจะมากกว่าการเขียน 100:1 หรือถึง 1000:1 การอ่านที่ต้อง join ฐานข้อมูลซับซ้อนอาจมีต้นทุนสูงมาก ใช้เวลาทำงานกับดิสก์นาน

##### ข้อเสีย: denormalization

* ข้อมูลถูกคัดลอกซ้ำ
* Constraint สามารถช่วยให้ข้อมูลซ้ำกันมีความสอดคล้องกัน ซึ่งเพิ่มความซับซ้อนของการออกแบบฐานข้อมูล
* ฐานข้อมูลที่ denormalized ภายใต้โหลดการเขียนหนัก อาจมีประสิทธิภาพแย่กว่าฐานข้อมูลที่ normalized

###### แหล่งที่มาและอ่านเพิ่มเติม: denormalization

* [Denormalization](https://en.wikipedia.org/wiki/Denormalization)

#### การปรับแต่ง SQL

การปรับแต่ง SQL เป็นหัวข้อที่กว้างและมี [หนังสือ](https://www.amazon.com/s/ref=nb_sb_noss_2?url=search-alias%3Daps&field-keywords=sql+tuning) จำนวนมากที่เขียนไว้เป็นข้อมูลอ้างอิง

สิ่งสำคัญคือการ **ทดสอบสมรรถนะ** และ **วิเคราะห์ประสิทธิภาพ** เพื่อจำลองและค้นหาคอขวด

* **ทดสอบสมรรถนะ** - จำลองสถานการณ์โหลดสูงด้วยเครื่องมือเช่น [ab](http://httpd.apache.org/docs/2.2/programs/ab.html)
* **วิเคราะห์ประสิทธิภาพ** - เปิดใช้งานเครื่องมือเช่น [slow query log](http://dev.mysql.com/doc/refman/5.7/en/slow-query-log.html) เพื่อช่วยติดตามปัญหาด้านประสิทธิภาพ

การทดสอบและวิเคราะห์ประสิทธิภาพอาจชี้ให้เห็นถึงการปรับแต่งดังต่อไปนี้

##### ปรับแต่ง schema ให้เหมาะสม

* MySQL จะ dump ข้อมูลลงดิสก์เป็นบล็อกที่ต่อเนื่องกันเพื่อการเข้าถึงที่รวดเร็ว
* ใช้ `CHAR` แทน `VARCHAR` สำหรับฟิลด์ที่มีความยาวคงที่
    * `CHAR` ให้การเข้าถึงแบบสุ่มที่รวดเร็ว ในขณะที่ `VARCHAR` ต้องค้นหาจุดสิ้นสุดของสตริงก่อนจึงจะไปยังรายการถัดไปได้
* ใช้ `TEXT` สำหรับบล็อกข้อความขนาดใหญ่เช่นโพสต์บล็อก `TEXT` ยังรองรับการค้นหาแบบ boolean ด้วย การใช้ฟิลด์ `TEXT` จะจัดเก็บพอยน์เตอร์บนดิสก์ที่ใช้ค้นหาบล็อกข้อความ
* ใช้ `INT` สำหรับตัวเลขขนาดใหญ่ถึง 2^32 หรือ 4 พันล้าน
* ใช้ `DECIMAL` สำหรับสกุลเงินเพื่อหลีกเลี่ยงข้อผิดพลาดในการแทนค่าตัวเลขทศนิยมแบบ floating point
* หลีกเลี่ยงการจัดเก็บ `BLOB` ขนาดใหญ่ ให้จัดเก็บตำแหน่งที่สามารถเรียกใช้อ็อบเจ็กต์แทน
* `VARCHAR(255)` คือจำนวนตัวอักษรมากที่สุดที่สามารถนับในตัวเลข 8 บิต มักใช้เพื่อให้เกิดการใช้ไบต์สูงสุดในบาง RDBMS
* กำหนด `NOT NULL` constraint เมื่อเหมาะสมเพื่อ [ปรับปรุงประสิทธิภาพการค้นหา](http://stackoverflow.com/questions/1017239/how-do-null-values-affect-performance-in-a-database-search)

##### ใช้อินเด็กซ์ที่ดี

* คอลัมน์ที่ใช้ในการ query (`SELECT`, `GROUP BY`, `ORDER BY`, `JOIN`) จะทำงานได้เร็วขึ้นเมื่อมีอินเด็กซ์
* อินเด็กซ์มักจะแทนด้วย [B-tree](https://en.wikipedia.org/wiki/B-tree) ที่ปรับสมดุลตัวเองและจัดเรียงข้อมูลรวมถึงช่วยในการค้นหา การเข้าถึงแบบลำดับ การแทรก และการลบในเวลาเชิงลอการิทึม
* การสร้างอินเด็กซ์จะทำให้ข้อมูลอยู่ในหน่วยความจำซึ่งต้องการพื้นที่มากขึ้น
* การเขียนข้อมูลอาจช้าลงเนื่องจากต้องอัปเดตอินเด็กซ์ด้วย
* เมื่อโหลดข้อมูลปริมาณมาก อาจเร็วกว่าถ้าปิดอินเด็กซ์ โหลดข้อมูล แล้วสร้างอินเด็กซ์ใหม่

##### หลีกเลี่ยงการ join ที่สิ้นเปลือง

* [Denormalize](#denormalization) เมื่อประสิทธิภาพเป็นสิ่งจำเป็น

##### แบ่งตารางออกเป็นส่วน ๆ

* แยกตารางโดยนำจุดสำคัญไปไว้ในตารางแยกเพื่อช่วยให้ข้อมูลอยู่ในหน่วยความจำ

##### ปรับแต่งแคชคำสั่งค้นหา (query cache)

* ในบางกรณี [query cache](https://dev.mysql.com/doc/refman/5.7/en/query-cache.html) อาจทำให้เกิด [ปัญหาด้านประสิทธิภาพ](https://www.percona.com/blog/2016/10/12/mysql-5-7-performance-tuning-immediately-after-installation/)

##### แหล่งข้อมูลและอ่านเพิ่มเติม: การปรับแต่ง SQL

* [เคล็ดลับการปรับแต่ง MySQL queries](http://aiddroid.com/10-tips-optimizing-mysql-queries-dont-suck/)
* [เหตุผลที่ใช้ VARCHAR(255) บ่อย ๆ คืออะไร?](http://stackoverflow.com/questions/1217466/is-there-a-good-reason-i-see-varchar255-used-so-often-as-opposed-to-another-l)
* [ค่า null มีผลต่อประสิทธิภาพอย่างไร?](http://stackoverflow.com/questions/1017239/how-do-null-values-affect-performance-in-a-database-search)
* [บันทึกคำสั่งค้นหาช้า (Slow query log)](http://dev.mysql.com/doc/refman/5.7/en/slow-query-log.html)

### NoSQL

NoSQL คือการจัดเก็บข้อมูลในรูปแบบ **key-value store**, **document store**, **wide column store** หรือ **graph database** ข้อมูลจะถูกทำให้ไม่เป็นปกติ (denormalized) และโดยทั่วไปการ join จะทำในโค้ดแอปพลิเคชัน ฐานข้อมูล NoSQL ส่วนมากจะไม่มีธุรกรรม ACID ที่แท้จริงและเน้นที่ [eventual consistency](#eventual-consistency)

**BASE** มักถูกใช้เพื่ออธิบายคุณสมบัติของฐานข้อมูล NoSQL เมื่อเปรียบเทียบกับ [ทฤษฎี CAP](#cap-theorem) ฐานข้อมูล BASE เลือกความพร้อมใช้งานมากกว่าความถูกต้อง

* **Basically available** - ระบบรับประกันความพร้อมใช้งาน
* **Soft state** - สถานะของระบบอาจเปลี่ยนแปลงได้ตลอดเวลา แม้ไม่มีอินพุต
* **Eventual consistency** - ระบบจะกลับมาสอดคล้องกันในช่วงเวลาหนึ่ง หากไม่มีอินพุตเข้ามาในช่วงเวลานั้น

นอกจากเลือก [SQL หรือ NoSQL](#sql-or-nosql) การเข้าใจประเภทฐานข้อมูล NoSQL ที่เหมาะกับการใช้งานก็เป็นประโยชน์ เราจะพูดถึง **key-value stores**, **document stores**, **wide column stores** และ **graph databases** ในหัวข้อถัดไป

#### Key-value store

> นามธรรม: hash table

Key-value store โดยทั่วไปจะรองรับการอ่านและเขียนแบบ O(1) และมักจัดเก็บข้อมูลในหน่วยความจำหรือ SSD ฐานข้อมูลแบบนี้สามารถจัดเรียงคีย์ตาม [ลำดับตัวอักษร](https://en.wikipedia.org/wiki/Lexicographical_order) เพื่อให้ดึงข้อมูลช่วงคีย์ได้อย่างมีประสิทธิภาพ Key-value store สามารถจัดเก็บข้อมูลเมตากับค่าได้

Key-value store ให้ประสิทธิภาพสูงและมักใช้กับโมเดลข้อมูลที่ง่ายหรือข้อมูลที่เปลี่ยนแปลงเร็ว เช่น cache ที่อยู่ในหน่วยความจำ เนื่องจากมีชุดคำสั่งจำกัด ความซับซ้อนจึงถูกผลักไปที่ชั้นแอปพลิเคชันหากต้องการคำสั่งเพิ่มเติม

Key-value store เป็นพื้นฐานของระบบที่ซับซ้อนกว่า เช่น document store และในบางกรณีคือ graph database

##### แหล่งข้อมูลและอ่านเพิ่มเติม: key-value store

* [Key-value database](https://en.wikipedia.org/wiki/Key-value_database)
* [ข้อเสียของ key-value store](http://stackoverflow.com/questions/4056093/what-are-the-disadvantages-of-using-a-key-value-table-over-nullable-columns-or)
* [สถาปัตยกรรม Redis](http://qnimate.com/overview-of-redis-architecture/)
* [สถาปัตยกรรม Memcached](https://adayinthelifeof.nl/2011/02/06/memcache-internals/)

#### Document store

> นามธรรม: คีย์-แวลูสโตร์ที่จัดเก็บเอกสารเป็นค่า

Document store จะเน้นที่เอกสาร (XML, JSON, ไบนารี ฯลฯ) ซึ่งเอกสารจะเก็บข้อมูลทั้งหมดสำหรับอ็อบเจกต์หนึ่ง ๆ Document store จะมี API หรือภาษาคิวรีสำหรับการค้นหาตามโครงสร้างภายในของเอกสารเอง *หมายเหตุ หลาย key-value store มีฟีเจอร์ในการทำงานกับ metadata ของค่า ทำให้เส้นแบ่งระหว่าง storage ทั้งสองประเภทนี้ไม่ชัดเจน*

ขึ้นอยู่กับการนำไปใช้ที่อยู่เบื้องหลัง เอกสารอาจถูกจัดกลุ่มโดย collections, tags, metadata หรือ directories แม้ว่าเอกสารจะถูกจัดหรือกลุ่มเข้าด้วยกันได้ แต่เอกสารแต่ละฉบับก็อาจมีฟิลด์ที่แตกต่างกันโดยสิ้นเชิง

Document store บางตัวเช่น [MongoDB](https://www.mongodb.com/mongodb-architecture) และ [CouchDB](https://blog.couchdb.org/2016/08/01/couchdb-2-0-architecture/) มีภาษาคิวรีที่คล้าย SQL สำหรับคิวรีที่ซับซ้อน [DynamoDB](http://www.read.seas.harvard.edu/~kohler/class/cs239-w08/decandia07dynamo.pdf) รองรับทั้งคีย์-แวลูและเอกสาร

Document store มีความยืดหยุ่นสูงและมักใช้กับข้อมูลที่เปลี่ยนแปลงเป็นครั้งคราว

##### แหล่งข้อมูลและอ่านเพิ่มเติม: document store

* [ฐานข้อมูลแบบ Document-oriented](https://en.wikipedia.org/wiki/Document-oriented_database)
* [สถาปัตยกรรม MongoDB](https://www.mongodb.com/mongodb-architecture)
* [สถาปัตยกรรม CouchDB](https://blog.couchdb.org/2016/08/01/couchdb-2-0-architecture/)
* [สถาปัตยกรรม Elasticsearch](https://www.elastic.co/blog/found-elasticsearch-from-the-bottom-up)

#### Wide column store

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/n16iOGk.png">
  <br/>
  <i><a href=http://blog.grio.com/2015/11/sql-nosql-a-brief-history.html>ที่มา: SQL & NoSQL, ประวัติย่อ</a></i>
</p>

> นามธรรม: แมพซ้อน `ColumnFamily<RowKey, Columns<ColKey, Value, Timestamp>>`

Wide column store มีหน่วยข้อมูลพื้นฐานเป็น column (คู่ชื่อ/ค่า) column สามารถจัดกลุ่มใน column families (คล้ายกับตาราง SQL) super column families จะกลุ่ม column families เพิ่มขึ้น คุณสามารถเข้าถึงแต่ละ column โดยใช้ row key และ column ที่มี row key เดียวกันจะรวมกันเป็นแถว แต่ละค่าสามารถมี timestamp สำหรับการจัดเวอร์ชันและแก้ไขข้อขัดแย้ง

Google ได้เปิดตัว [Bigtable](http://www.read.seas.harvard.edu/~kohler/class/cs239-w08/chang06bigtable.pdf) เป็น wide column store ตัวแรก ซึ่งมีอิทธิพลต่อ [HBase](https://www.edureka.co/blog/hbase-architecture/) ที่ใช้ในระบบ Hadoop และ [Cassandra](http://docs.datastax.com/en/cassandra/3.0/cassandra/architecture/archIntro.html) จาก Facebook สโตร์อย่าง BigTable, HBase และ Cassandra จะจัดคีย์ตามลำดับพจนานุกรม ทำให้สามารถดึงข้อมูลช่วงคีย์ที่ต้องการได้อย่างมีประสิทธิภาพ

Wide column store มีความพร้อมใช้งานสูงและขยายขนาดได้ดี มักใช้กับชุดข้อมูลขนาดใหญ่มาก

##### แหล่งข้อมูลและอ่านเพิ่มเติม: wide column store

* [SQL & NoSQL, ประวัติย่อ](http://blog.grio.com/2015/11/sql-nosql-a-brief-history.html)
* [สถาปัตยกรรม Bigtable](http://www.read.seas.harvard.edu/~kohler/class/cs239-w08/chang06bigtable.pdf)
* [สถาปัตยกรรม HBase](https://www.edureka.co/blog/hbase-architecture/)
* [สถาปัตยกรรม Cassandra](http://docs.datastax.com/en/cassandra/3.0/cassandra/architecture/archIntro.html)

#### ฐานข้อมูลแบบกราฟ

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/fNcl65g.png">
  <br/>
  <i><a href=https://en.wikipedia.org/wiki/File:GraphDatabase_PropertyGraph.png>ที่มา: ฐานข้อมูลแบบกราฟ</a></i>
</p>

> นามธรรม: กราฟ

ในฐานข้อมูลแบบกราฟ แต่ละโหนดคือเรคคอร์ดและแต่ละเส้นเชื่อมคือความสัมพันธ์ระหว่างสองโหนด ฐานข้อมูลกราฟถูกปรับแต่งเพื่อแสดงความสัมพันธ์ที่ซับซ้อน เช่น มีคีย์ต่างประเทศจำนวนมากหรือความสัมพันธ์แบบ many-to-many

ฐานข้อมูลกราฟให้ประสิทธิภาพสูงสำหรับโมเดลข้อมูลที่มีความสัมพันธ์ซับซ้อน เช่น เครือข่ายสังคม โดยยังค่อนข้างใหม่และยังไม่แพร่หลาย อาจจะหาทูลหรือทรัพยากรสำหรับพัฒนาได้ยาก หลายกราฟสามารถเข้าถึงได้แค่ [REST APIs](#representational-state-transfer-rest)

##### แหล่งข้อมูลและอ่านเพิ่มเติม: กราฟ

* [ฐานข้อมูลแบบกราฟ](https://en.wikipedia.org/wiki/Graph_database)
* [Neo4j](https://neo4j.com/)
* [FlockDB](https://blog.twitter.com/2010/introducing-flockdb)

#### แหล่งข้อมูลและอ่านเพิ่มเติม: NoSQL

* [คำอธิบายคำศัพท์พื้นฐาน](http://stackoverflow.com/questions/3342497/explanation-of-base-terminology)
* [สำรวจและแนวทางตัดสินใจฐานข้อมูล NoSQL](https://medium.com/baqend-blog/nosql-databases-a-survey-and-decision-guidance-ea7823a822d#.wskogqenq)
* [ความสามารถในการขยาย](https://web.archive.org/web/20220602114024/https://www.lecloud.net/post/7994751381/scalability-for-dummies-part-2-database)
* [แนะนำ NoSQL](https://www.youtube.com/watch?v=qI_g07C_Q5I)
* [รูปแบบ NoSQL](http://horicky.blogspot.com/2009/11/nosql-patterns.html)

### SQL หรือ NoSQL

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/wXGqG5f.png">
  <br/>
  <i><a href=https://www.infoq.com/articles/Transition-RDBMS-NoSQL/>ที่มา: การเปลี่ยนผ่านจาก RDBMS ไป NoSQL</a></i>
</p>

เหตุผลสำหรับ **SQL**:

* ข้อมูลที่มีโครงสร้าง
* สคีมาที่เข้มงวด
* ข้อมูลเชิงสัมพันธ์
* ต้องการการ join ที่ซับซ้อน
* ธุรกรรม (Transactions)
* รูปแบบที่ชัดเจนสำหรับการขยายขนาด
* เป็นที่ยอมรับมากกว่า: นักพัฒนา, ชุมชน, โค้ด, เครื่องมือ ฯลฯ
* การค้นหาด้วยดัชนีทำได้รวดเร็วมาก

เหตุผลสำหรับ **NoSQL**:

* ข้อมูลกึ่งโครงสร้าง
* สคีมาที่ยืดหยุ่นหรือเปลี่ยนแปลงได้
* ข้อมูลที่ไม่ใช่เชิงสัมพันธ์
* ไม่ต้องการ join ที่ซับซ้อน
* จัดเก็บข้อมูลขนาดหลาย TB (หรือ PB)
* งานที่ใช้ข้อมูลเข้มข้นมาก
* มี throughput สูงมากสำหรับ IOPS

ตัวอย่างข้อมูลที่เหมาะกับ NoSQL:

* รับข้อมูล clickstream และ log อย่างรวดเร็ว
* ข้อมูลกระดานผู้นำหรือคะแนน
* ข้อมูลชั่วคราว เช่น ตะกร้าสินค้า
* ตารางที่ถูกเข้าถึงบ่อย ('hot' tables)
* ตาราง metadata/lookup

##### แหล่งที่มาและอ่านเพิ่มเติม: SQL หรือ NoSQL

* [Scaling up to your first 10 million users](https://www.youtube.com/watch?v=kKjm4ehYiMs)
* [SQL vs NoSQL differences](https://www.sitepoint.com/sql-vs-nosql-differences/)

## แคช

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/Q6z24La.png">
  <br/>
  <i><a href=http://horicky.blogspot.com/2010/10/scalable-system-design-patterns.html>ที่มา: รูปแบบการออกแบบระบบที่ขยายขนาดได้</a></i>
</p>

การแคชช่วยปรับปรุงเวลาในการโหลดหน้าเว็บและสามารถลดภาระบนเซิร์ฟเวอร์และฐานข้อมูลของคุณได้ ในโมเดลนี้ dispatcher จะตรวจสอบก่อนว่ามีการร้องขอในลักษณะเดียวกันมาก่อนหรือไม่ และพยายามค้นหาผลลัพธ์เดิมเพื่อนำกลับมาใช้ เพื่อลดการประมวลผลที่แท้จริง

ฐานข้อมูลมักจะได้รับประโยชน์จากการกระจายการอ่านและเขียนอย่างสม่ำเสมอในแต่ละพาร์ติชัน รายการยอดนิยมสามารถทำให้การกระจายไม่เท่ากันและเกิดคอขวด การวางแคชไว้หน้าฐานข้อมูลสามารถช่วยดูดซับภาระที่ไม่สมดุลและการพุ่งขึ้นของทราฟฟิก

### การแคชฝั่งลูกข่าย

แคชสามารถอยู่ฝั่งลูกข่าย (OS หรือเบราว์เซอร์), [ฝั่งเซิร์ฟเวอร์](#reverse-proxy-web-server) หรืออยู่ในชั้นแคชโดยเฉพาะ

### การแคช CDN

[CDN](#content-delivery-network) ถือว่าเป็นประเภทหนึ่งของแคช

### การแคชเว็บเซิร์ฟเวอร์

[Reverse proxy](#reverse-proxy-web-server) และแคชอย่างเช่น [Varnish](https://www.varnish-cache.org/) สามารถให้บริการคอนเทนต์แบบสถิตและไดนามิกโดยตรง เว็บเซิร์ฟเวอร์ยังสามารถแคชคำร้องขอและคืนผลลัพธ์โดยไม่ต้องติดต่อกับแอปพลิเคชันเซิร์ฟเวอร์

### การแคชฐานข้อมูล

ฐานข้อมูลของคุณมักจะมีการตั้งค่าแคชในระดับหนึ่งในค่าคอนฟิกเริ่มต้นที่ปรับให้เหมาะกับการใช้งานทั่วไป การปรับแต่งค่าเหล่านี้ให้เหมาะกับรูปแบบการใช้งานเฉพาะสามารถช่วยเพิ่มประสิทธิภาพได้อีก

### การแคชแอปพลิเคชัน

แคชในหน่วยความจำเช่น Memcached และ Redis เป็น key-value store ที่อยู่ระหว่างแอปพลิเคชันของคุณกับที่เก็บข้อมูล เนื่องจากข้อมูลอยู่ใน RAM จึงเร็วกว่าฐานข้อมูลทั่วไปที่ข้อมูลอยู่บนดิสก์ RAM มีข้อจำกัดมากกว่าดิสก์ ดังนั้น [อัลกอริทึมการลบแคช](https://en.wikipedia.org/wiki/Cache_algorithms) เช่น [least recently used (LRU)](https://en.wikipedia.org/wiki/Cache_replacement_policies#Least_recently_used_(LRU)) จะช่วยลบข้อมูลที่ไม่ได้ใช้งานและเก็บข้อมูลที่ถูกใช้งานบ่อยไว้ใน RAM

Redis มีคุณสมบัติเพิ่มเติมดังนี้:

* ตัวเลือกการเก็บข้อมูลถาวร
* โครงสร้างข้อมูลในตัว เช่น sorted sets และ lists

มีหลายระดับที่คุณสามารถทำการแคช ซึ่งแบ่งออกเป็นสองประเภทหลัก: **คำสั่งฐานข้อมูล** และ **อ็อบเจกต์**:

* ระดับแถว
* ระดับคำสั่งค้นหา
* อ็อบเจกต์ที่จัดรูปแบบพร้อมทำการ serialize
* HTML ที่เรนเดอร์เสร็จสมบูรณ์

โดยทั่วไป คุณควรหลีกเลี่ยงการแคชไฟล์ เพราะจะทำให้การโคลนและการปรับขยายอัตโนมัติทำได้ยากขึ้น

### การแคชในระดับการคิวรีฐานข้อมูล

เมื่อใดก็ตามที่คุณคิวรีฐานข้อมูล ให้แฮชคิวรีเป็นคีย์และเก็บผลลัพธ์ไว้ในแคช วิธีนี้มีปัญหาเกี่ยวกับการหมดอายุ:

* ลบผลลัพธ์ที่แคชไว้ได้ยากในกรณีที่เป็นคิวรีซับซ้อน
* หากข้อมูลส่วนหนึ่งเปลี่ยนแปลง เช่น เซลล์ในตาราง คุณต้องลบคิวรีที่แคชไว้ทั้งหมดซึ่งอาจมีเซลล์ที่เปลี่ยนแปลงนั้น

### การแคชในระดับอ็อบเจกต์

มองข้อมูลของคุณเป็นอ็อบเจกต์ คล้ายกับที่คุณทำกับโค้ดแอปพลิเคชัน ให้แอปพลิเคชันของคุณประกอบชุดข้อมูลจากฐานข้อมูลเป็นอินสแตนซ์คลาสหรือโครงสร้างข้อมูล:

* ลบอ็อบเจกต์ออกจากแคชหากข้อมูลพื้นฐานของมันเปลี่ยนแปลง
* รองรับการประมวลผลแบบอะซิงโครนัส: worker ประกอบอ็อบเจกต์โดยใช้ข้อมูลแคชล่าสุด

ข้อเสนอแนะเกี่ยวกับสิ่งที่ควรแคช:

* เซสชันผู้ใช้
* หน้าเว็บที่แสดงผลเรียบร้อยแล้ว
* สตรีมกิจกรรม
* ข้อมูลกราฟผู้ใช้

### เมื่อใดควรอัปเดตแคช

เนื่องจากคุณสามารถเก็บข้อมูลในแคชได้จำนวนจำกัด คุณจะต้องกำหนดกลยุทธ์ในการอัปเดตแคชที่เหมาะสมกับการใช้งานของคุณ

#### Cache-aside

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/ONjORqk.png">
  <br/>
  <i><a href=http://www.slideshare.net/tmatyashovsky/from-cache-to-in-memory-data-grid-introduction-to-hazelcast>ที่มา: From cache to in-memory data grid</a></i>
</p>

แอปพลิเคชันรับผิดชอบในการอ่านและเขียนข้อมูลจากสตอเรจ แคชจะไม่ติดต่อกับสตอเรจโดยตรง แอปพลิเคชันจะดำเนินการดังนี้:

* ค้นหารายการในแคช หากไม่พบจะเกิด cache miss
* โหลดรายการจากฐานข้อมูล
* เพิ่มรายการลงในแคช
* ส่งคืนรายการ

```python
def get_user(self, user_id):
    user = cache.get("user.{0}", user_id)
    if user is None:
        user = db.query("SELECT * FROM users WHERE user_id = {0}", user_id)
        if user is not None:
            key = "user.{0}".format(user_id)
            cache.set(key, json.dumps(user))
    return user
```

[Memcached](https://memcached.org/) มักจะถูกใช้งานในลักษณะนี้

การอ่านข้อมูลซ้ำที่ถูกเพิ่มเข้าไปในแคชจะมีความรวดเร็ว  Cache-aside หรือที่เรียกอีกชื่อว่า lazy loading จะมีการแคชเฉพาะข้อมูลที่ถูกเรียกใช้งาน ซึ่งช่วยหลีกเลี่ยงการเติมข้อมูลที่ไม่ถูกเรียกใช้เข้าไปในแคช

##### ข้อเสีย: cache-aside

* ทุกครั้งที่แคชไม่พบข้อมูลจะต้องเดินทางสามครั้ง ซึ่งอาจทำให้เกิดความล่าช้าอย่างเห็นได้ชัด
* ข้อมูลอาจเก่าได้หากมีการอัปเดตในฐานข้อมูล ปัญหานี้สามารถลดลงได้ด้วยการตั้งค่า time-to-live (TTL) เพื่อบังคับให้อัปเดต entry ในแคช หรือโดยใช้ write-through
* เมื่อโหนดล้มเหลว จะถูกแทนที่ด้วยโหนดใหม่ที่ว่างเปล่า ซึ่งเพิ่มค่า latency

#### Write-through

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/0vBc0hN.png">
  <br/>
  <i><a href=http://www.slideshare.net/jboner/scalability-availability-stability-patterns/>ที่มา: Scalability, availability, stability, patterns</a></i>
</p>

แอปพลิเคชันจะใช้แคชเป็นแหล่งจัดเก็บข้อมูลหลัก โดยอ่านและเขียนข้อมูลกับแคช ในขณะที่แคชรับผิดชอบการอ่านและเขียนกับฐานข้อมูล:

* แอปพลิเคชันเพิ่ม/อัปเดต entry ในแคช
* แคชเขียน entry ไปยัง data store แบบ synchronous
* ส่งกลับ

โค้ดแอปพลิเคชัน:

```python
set_user(12345, {"foo":"bar"})
```

โค้ดแคช:

```python
def set_user(user_id, values):
    user = db.query("UPDATE Users WHERE id = {0}", user_id, values)
    cache.set(user_id, user)
```
การเขียนแบบ Write-through เป็นการดำเนินการที่ช้ากว่าโดยรวมเนื่องจากต้องมีการเขียนข้อมูล แต่การอ่านข้อมูลที่พึ่งเขียนล่าสุดจะเร็วมาก โดยทั่วไปผู้ใช้จะยอมรับความล่าช้าได้มากกว่าเมื่ออัปเดตข้อมูลมากกว่าการอ่านข้อมูล ข้อมูลในแคชจะไม่ล้าสมัย

##### ข้อเสีย: write through

* เมื่อมีการสร้างโหนดใหม่เนื่องจากความล้มเหลวหรือการขยายขนาด โหนดใหม่จะไม่แคชข้อมูลจนกว่าข้อมูลนั้นจะถูกอัปเดตในฐานข้อมูล การใช้ cache-aside ร่วมกับ write through สามารถช่วยลดปัญหานี้ได้
* ข้อมูลส่วนใหญ่ที่ถูกเขียนอาจไม่เคยถูกอ่าน ซึ่งสามารถลดได้ด้วยการกำหนด TTL

#### Write-behind (write-back)

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/rgSrvjG.png">
  <br/>
  <i><a href=http://www.slideshare.net/jboner/scalability-availability-stability-patterns/>ที่มา: Scalability, availability, stability, patterns</a></i>
</p>

ในการเขียนแบบ Write-behind แอปพลิเคชันจะดำเนินการดังนี้:

* เพิ่ม/อัปเดตรายการในแคช
* เขียนข้อมูลไปยัง data store แบบ asynchronous เพื่อเพิ่มประสิทธิภาพการเขียน

##### ข้อเสีย: write-behind

* อาจเกิดการสูญหายของข้อมูลหากแคชหยุดทำงานก่อนที่ข้อมูลจะถูกส่งไปยัง data store
* การเขียนแบบ write-behind มีความซับซ้อนมากกว่าการทำ cache-aside หรือ write-through

#### Refresh-ahead

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/kxtjqgE.png">
  <br/>
  <i><a href=http://www.slideshare.net/tmatyashovsky/from-cache-to-in-memory-data-grid-introduction-to-hazelcast>ที่มา: From cache to in-memory data grid</a></i>
</p>

คุณสามารถกำหนดค่าแคชให้รีเฟรชรายการที่เข้าถึงล่าสุดโดยอัตโนมัติก่อนหมดอายุ

Refresh-ahead สามารถลด latency ได้มากกว่า read-through หากแคชสามารถทำนายได้อย่างแม่นยำว่ารายการใดจะถูกใช้งานในอนาคต

##### ข้อเสีย: refresh-ahead


* การไม่สามารถคาดการณ์ได้อย่างถูกต้องว่าสินค้าใดจะถูกต้องการในอนาคต อาจทำให้ประสิทธิภาพลดลงมากกว่าการไม่ใช้ refresh-ahead

### ข้อเสีย: แคช

* จำเป็นต้องรักษาความสอดคล้องระหว่างแคชและแหล่งข้อมูลหลัก เช่น ฐานข้อมูล ผ่าน [การทำให้แคชไม่ถูกต้อง](https://en.wikipedia.org/wiki/Cache_algorithms)
* การทำให้แคชไม่ถูกต้องเป็นปัญหาที่ยาก มีความซับซ้อนเพิ่มเติมเกี่ยวกับเวลาที่จะอัปเดตแคช
* จำเป็นต้องเปลี่ยนแปลงแอปพลิเคชัน เช่น การเพิ่ม Redis หรือ memcached

### แหล่งข้อมูลและการอ่านเพิ่มเติม

* [จากแคชสู่ in-memory data grid](http://www.slideshare.net/tmatyashovsky/from-cache-to-in-memory-data-grid-introduction-to-hazelcast)
* [รูปแบบการออกแบบระบบที่ปรับขยายได้](http://horicky.blogspot.com/2010/10/scalable-system-design-patterns.html)
* [บทนำสู่การออกแบบสถาปัตยกรรมระบบเพื่อรองรับการขยายตัว](http://lethain.com/introduction-to-architecting-systems-for-scale/)
* [รูปแบบความสามารถในการขยาย, ความพร้อมใช้งาน, เสถียรภาพ](http://www.slideshare.net/jboner/scalability-availability-stability-patterns/)
* [ความสามารถในการขยาย](https://web.archive.org/web/20230126233752/https://www.lecloud.net/post/9246290032/scalability-for-dummies-part-3-cache)
* [กลยุทธ์ AWS ElastiCache](http://docs.aws.amazon.com/AmazonElastiCache/latest/UserGuide/Strategies.html)
* [วิกิพีเดีย](https://en.wikipedia.org/wiki/Cache_(computing))

## ความไม่ประสานกัน (Asynchronism)

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/54GYsSx.png">
  <br/>
  <i><a href=http://lethain.com/introduction-to-architecting-systems-for-scale/#platform_layer>ที่มา: Intro to architecting systems for scale</a></i>
</p>

เวิร์กโฟลว์แบบอะซิงโครนัสช่วยลดเวลาการร้องขอสำหรับการดำเนินการที่มีค่าใช้จ่ายสูงซึ่งปกติจะดำเนินการแบบอินไลน์ นอกจากนี้ยังช่วยโดยการทำงานที่ใช้เวลานานล่วงหน้า เช่น การรวมข้อมูลเป็นระยะ

### คิวข้อความ (Message queues)

คิวข้อความรับ, ถือ และส่งต่อข้อความ หากการดำเนินการใดช้าเกินไปที่จะทำแบบอินไลน์ คุณสามารถใช้คิวข้อความกับเวิร์กโฟลว์ดังนี้:

* แอปพลิเคชันเผยแพ่งานไปยังคิว จากนั้นแจ้งสถานะงานแก่ผู้ใช้
* พนักงาน (worker) จะรับงานจากคิว ประมวลผลงาน แล้วส่งสัญญาณว่างานเสร็จสิ้น

ผู้ใช้จะไม่ได้ถูกบล็อคและงานจะถูกประมวลผลในเบื้องหลัง ในระหว่างนี้ไคลเอนต์อาจดำเนินการบางอย่างเล็กน้อยเพื่อให้ดูเหมือนว่างานเสร็จสิ้นแล้ว เช่น หากโพสต์ทวีต ทวีตอาจถูกโพสต์ทันทีบนไทม์ไลน์ของคุณ แต่จะใช้เวลาสักครู่ก่อนที่ทวีตของคุณจะถูกส่งไปยังผู้ติดตามทั้งหมดของคุณจริงๆ

**[Redis](https://redis.io/)** มีประโยชน์ในฐานะ message broker ที่เรียบง่ายแต่ข้อความอาจสูญหายได้

**[RabbitMQ](https://www.rabbitmq.com/)** เป็นที่นิยมแต่คุณต้องปรับตัวเข้ากับโปรโตคอล 'AMQP' และจัดการโหนดของคุณเอง
**[Amazon SQS](https://aws.amazon.com/sqs/)** เป็นบริการที่โฮสต์อยู่แต่สามารถมีความหน่วงสูงและมีโอกาสที่ข้อความจะถูกส่งซ้ำสองครั้ง

### คิวงาน (Task queues)

คิวงานจะรับงานและข้อมูลที่เกี่ยวข้อง, ดำเนินการงานเหล่านั้น, แล้วส่งผลลัพธ์กลับ พวกมันสามารถรองรับการตั้งเวลาและใช้สำหรับประมวลผลงานที่ต้องใช้คำนวณหนักในเบื้องหลังได้

**[Celery](https://docs.celeryproject.org/en/stable/)** รองรับการตั้งเวลาและสนับสนุนภาษา python เป็นหลัก

### Back pressure

หากคิวเริ่มมีขนาดใหญ่ขึ้นอย่างมาก ขนาดของคิวอาจใหญ่กว่าหน่วยความจำ ส่งผลให้เกิดการพลาดแคช, อ่านข้อมูลจากดิสก์, และประสิทธิภาพที่ช้าลง [Back pressure](http://mechanical-sympathy.blogspot.com/2012/05/apply-back-pressure-when-overloaded.html) สามารถช่วยโดยการจำกัดขนาดของคิว, ซึ่งจะช่วยรักษาอัตราผ่านงานสูงและเวลาในการตอบสนองที่ดีสำหรับงานที่อยู่ในคิว เมื่อคิวเต็มแล้ว ลูกค้าจะได้รับสถานะเซิร์ฟเวอร์ไม่ว่างหรือ HTTP 503 ให้ลองใหม่ในภายหลัง ลูกค้าสามารถลองส่งคำขอใหม่อีกครั้งในภายหลัง, อาจใช้วิธี [exponential backoff](https://en.wikipedia.org/wiki/Exponential_backoff)

### ข้อเสีย: ความไม่ซิงโครนัส (asynchronism)

* กรณีการใช้งานเช่นการคำนวณต้นทุนต่ำและเวิร์กโฟลว์แบบเรียลไทม์อาจเหมาะกับการทำงานแบบซิงโครนัสมากกว่า เพราะการเพิ่มคิวอาจทำให้เกิดความล่าช้าและความซับซ้อน

### แหล่งข้อมูลและอ่านเพิ่มเติม

* [It's all a numbers game](https://www.youtube.com/watch?v=1KRYH75wgy4)
* [Applying back pressure when overloaded](http://mechanical-sympathy.blogspot.com/2012/05/apply-back-pressure-when-overloaded.html)
* [Little's law](https://en.wikipedia.org/wiki/Little%27s_law)
* [What is the difference between a message queue and a task queue?](https://www.quora.com/What-is-the-difference-between-a-message-queue-and-a-task-queue-Why-would-a-task-queue-require-a-message-broker-like-RabbitMQ-Redis-Celery-or-IronMQ-to-function)

## การสื่อสาร (Communication)

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/5KeocQs.jpg">
  <br/>
  <i><a href=http://www.escotal.com/osilayer.html>ที่มา: โมเดล OSI 7 ชั้น</a></i>
</p>

### โปรโตคอลการรับส่งข้อมูลแบบไฮเปอร์เท็กซ์ (HTTP)

HTTP เป็นวิธีสำหรับเข้ารหัสและขนส่งข้อมูลระหว่างไคลเอนต์และเซิร์ฟเวอร์ เป็นโปรโตคอลแบบ request/response: ไคลเอนต์จะส่งคำขอและเซิร์ฟเวอร์จะตอบกลับด้วยเนื้อหาที่เกี่ยวข้องและข้อมูลสถานะการดำเนินการของคำขอ HTTP เป็นระบบปิดในตัวเอง ช่วยให้คำขอและการตอบกลับไหลผ่านตัวกลางหลายตัว เช่น ตัวกระจายโหลด, แคช, การเข้ารหัส, และการบีบอัดข้อมูล

คำขอ HTTP พื้นฐานจะประกอบด้วยคำกริยา (method) และทรัพยากร (endpoint) ด้านล่างคือตัวอย่างคำกริยา HTTP ที่ใช้บ่อย:

| Verb | คำอธิบาย | Idempotent* | Safe | Cacheable |


| GET | อ่านทรัพยากร | ใช่ | ใช่ | ใช่ |
| POST | สร้างทรัพยากรหรือกระตุ้นกระบวนการที่จัดการข้อมูล | ไม่ | ไม่ | ใช่ถ้าการตอบกลับมีข้อมูลความสดใหม่ |
| PUT | สร้างหรือแทนที่ทรัพยากร | ใช่ | ไม่ | ไม่ |
| PATCH | อัปเดตทรัพยากรบางส่วน | ไม่ | ไม่ | ใช่ถ้าการตอบกลับมีข้อมูลความสดใหม่ |
| DELETE | ลบทรัพยากร | ใช่ | ไม่ | ไม่ |

*สามารถเรียกซ้ำหลายครั้งโดยไม่มีผลลัพธ์ที่ต่างกัน

HTTP เป็นโปรโตคอลชั้นแอปพลิเคชันที่อาศัยโปรโตคอลระดับล่างเช่น **TCP** และ **UDP**.

#### แหล่งข้อมูลและอ่านเพิ่มเติม: HTTP

* [HTTP คืออะไร?](https://www.nginx.com/resources/glossary/http/)
* [ความแตกต่างระหว่าง HTTP กับ TCP](https://www.quora.com/What-is-the-difference-between-HTTP-protocol-and-TCP-protocol)
* [ความแตกต่างระหว่าง PUT และ PATCH](https://laracasts.com/discuss/channels/general-discussion/whats-the-differences-between-put-and-patch?page=1)

### โปรโตคอลควบคุมการส่งข้อมูล (TCP)

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/JdAsdvG.jpg">
  <br/>
  <i><a href=http://www.wildbunny.co.uk/blog/2012/10/09/how-to-make-a-multi-player-game-part-1/>ที่มา: วิธีสร้างเกมผู้เล่นหลายคน</a></i>
</p>

TCP เป็นโปรโตคอลแบบเชื่อมต่อบนเครือข่าย [IP](https://en.wikipedia.org/wiki/Internet_Protocol) การเชื่อมต่อถูกสร้างและสิ้นสุดโดยใช้ [แฮนด์เชค](https://en.wikipedia.org/wiki/Handshaking) แพ็กเก็ตที่ถูกส่งจะถูกรับประกันว่าถึงปลายทางตามลำดับเดิมและไม่เสียหายด้วย:

* หมายเลขลำดับและ [ช่องตรวจสอบค่าถูกต้อง](https://en.wikipedia.org/wiki/Transmission_Control_Protocol#Checksum_computation) สำหรับแต่ละแพ็กเก็ต
* แพ็กเก็ต [การตอบรับ](https://en.wikipedia.org/wiki/Acknowledgement_(data_networks)) และการส่งซ้ำอัตโนมัติ

หากผู้ส่งไม่ได้รับการตอบกลับที่ถูกต้อง จะทำการส่งแพ็กเก็ตซ้ำ หากเกิดหมดเวลา (timeout) หลายครั้ง การเชื่อมต่อจะถูกตัด TCP ยังมีการควบคุม [การไหลของข้อมูล](https://en.wikipedia.org/wiki/Flow_control_(data)) และ [การควบคุมความแออัด](https://en.wikipedia.org/wiki/Network_congestion#Congestion_control) สิ่งเหล่านี้ทำให้เกิดความล่าช้าและโดยทั่วไปส่งผลให้การส่งข้อมูลมีประสิทธิภาพน้อยกว่า UDP

เพื่อให้เกิดปริมาณข้อมูลสูง เซิร์ฟเวอร์เว็บสามารถเปิดการเชื่อมต่อ TCP จำนวนมาก ส่งผลให้ใช้หน่วยความจำสูง การมีการเชื่อมต่อจำนวนมากระหว่างเธรดของเซิร์ฟเวอร์เว็บกับเซิร์ฟเวอร์ [memcached](https://memcached.org/) อาจมีค่าใช้จ่ายสูง [การรวมการเชื่อมต่อ](https://en.wikipedia.org/wiki/Connection_pool) สามารถช่วยได้ รวมถึงการเปลี่ยนไปใช้ UDP เมื่อเหมาะสม

TCP เหมาะสำหรับแอปพลิเคชันที่ต้องการความน่าเชื่อถือสูงแต่ไม่เร่งด่วนด้านเวลา ตัวอย่างเช่น เซิร์ฟเวอร์เว็บ ข้อมูลฐานข้อมูล SMTP FTP และ SSH

ใช้ TCP แทน UDP เมื่อ:

* คุณต้องการให้ข้อมูลทั้งหมดมาถึงอย่างครบถ้วน
* คุณต้องการให้ระบบประมาณการใช้งานความเร็วเครือข่ายอัตโนมัติ

### โปรโตคอล User datagram (UDP)

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/yzDrJtA.jpg">
  <br/>
  <i><a href=http://www.wildbunny.co.uk/blog/2012/10/09/how-to-make-a-multi-player-game-part-1/>ที่มา: วิธีสร้างเกมผู้เล่นหลายคน</a></i>
</p>

UDP เป็นโปรโตคอลแบบไม่มีการเชื่อมต่อ ข้อมูล datagram (คล้ายกับแพ็กเก็ต) จะได้รับประกันเฉพาะในระดับ datagram เท่านั้น ข้อมูล datagram อาจไปถึงปลายทางแบบไม่เรียงลำดับหรืออาจไม่ถึงเลย UDP ไม่รองรับการควบคุมความแออัด เนื่องจากไม่มีการรับประกันเหมือน TCP UDP จึงมีประสิทธิภาพมากกว่าโดยทั่วไป

UDP สามารถกระจายข้อมูล (broadcast) ส่ง datagram ไปยังทุกอุปกรณ์ในเครือข่ายย่อย ซึ่งมีประโยชน์กับ [DHCP](https://en.wikipedia.org/wiki/Dynamic_Host_Configuration_Protocol) เพราะไคลเอนต์ยังไม่ได้รับที่อยู่ IP ทำให้ไม่สามารถใช้ TCP สตรีมข้อมูลโดยไม่มี IP address ได้

UDP มีความน่าเชื่อถือน้อยกว่าแต่ทำงานได้ดีในกรณีใช้งานแบบเรียลไทม์ เช่น VoIP, วิดีโอแชท, สตรีมมิ่ง และเกมผู้เล่นหลายคนแบบเรียลไทม์

ใช้ UDP แทน TCP เมื่อ:

* คุณต้องการความหน่วงต่ำที่สุด
* ข้อมูลที่ล่าช้าแย่กว่าการสูญเสียข้อมูล
* คุณต้องการพัฒนาแก้ไขข้อผิดพลาดเอง

#### ที่มาและอ่านเพิ่มเติม: TCP และ UDP

* [Networking for game programming](http://gafferongames.com/networking-for-game-programmers/udp-vs-tcp/)
* [ความแตกต่างหลักระหว่างโปรโตคอล TCP และ UDP](http://www.cyberciti.biz/faq/key-differences-between-tcp-and-udp-protocols/)
* [ความแตกต่างระหว่าง TCP และ UDP](http://stackoverflow.com/questions/5970383/difference-between-tcp-and-udp)
* [โปรโตคอลควบคุมการส่งข้อมูล](https://en.wikipedia.org/wiki/Transmission_Control_Protocol)
* [โปรโตคอล User datagram](https://en.wikipedia.org/wiki/User_Datagram_Protocol)
* [การปรับขนาด memcache ที่ Facebook](http://www.cs.bu.edu/~jappavoo/jappavoo.github.com/451/papers/memcache-fb.pdf)

### การเรียกใช้ฟังก์ชันระยะไกล (RPC)

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/iF4Mkb5.png">
  <br/>
  <i><a href=http://www.puncsky.com/blog/2016-02-13-crack-the-system-design-interview>ที่มา: Crack the system design interview</a></i>
</p>

ในการเรียกใช้ RPC ไคลเอนต์จะสั่งให้ฟังก์ชันทำงานใน address space อื่น โดยปกติจะเป็นเซิร์ฟเวอร์ระยะไกล ฟังก์ชันจะถูกเขียนเหมือนเป็นการเรียกใช้ฟังก์ชันในเครื่อง โดยซ่อนรายละเอียดการสื่อสารกับเซิร์ฟเวอร์จากโปรแกรมไคลเอนต์ การเรียกใช้ระยะไกลจะช้ากว่าและเชื่อถือน้อยกว่าการเรียกใช้ในเครื่อง จึงควรแยกความแตกต่างระหว่าง RPC กับการเรียกใช้ในเครื่อง Framework RPC ที่นิยม ได้แก่ [Protobuf](https://developers.google.com/protocol-buffers/), [Thrift](https://thrift.apache.org/), และ [Avro](https://avro.apache.org/docs/current/)

RPC เป็นโปรโตคอลแบบ request-response:

* **โปรแกรมไคลเอนต์** - เรียกใช้งานขั้นตอนไคลเอนต์สตับ พารามิเตอร์จะถูกผลักลงบนสแต็กเหมือนการเรียกใช้งานขั้นตอนภายในเครื่อง
* **ขั้นตอนไคลเอนต์สตับ** - จัดเก็บ (แพ็ค) ไอดีของขั้นตอนและอาร์กิวเมนต์ลงในข้อความคำขอ
* **โมดูลการสื่อสารของไคลเอนต์** - ระบบปฏิบัติการส่งข้อความจากไคลเอนต์ไปยังเซิร์ฟเวอร์
* **โมดูลการสื่อสารของเซิร์ฟเวอร์** - ระบบปฏิบัติการส่งแพ็กเก็ตที่เข้ามาไปยังขั้นตอนเซิร์ฟเวอร์สตับ
* **ขั้นตอนเซิร์ฟเวอร์สตับ** - แกะผลลัพธ์ เรียกใช้งานขั้นตอนเซิร์ฟเวอร์ที่ตรงกับไอดีขั้นตอน และส่งผ่านอาร์กิวเมนต์ที่ได้รับ
* การตอบกลับของเซิร์ฟเวอร์จะทำตามขั้นตอนข้างต้นในลำดับย้อนกลับ

ตัวอย่างการเรียกใช้ RPC:

```
GET /someoperation?data=anId

POST /anotheroperation
{
  "data":"anId";
  "anotherdata": "another value"
}
```
RPC มุ่งเน้นไปที่การเปิดเผยพฤติกรรม  RPC มักถูกใช้ด้วยเหตุผลด้านประสิทธิภาพในการสื่อสารภายใน เนื่องจากสามารถสร้าง native calls ที่เหมาะสมกับกรณีการใช้งานของคุณได้

เลือกใช้ native library (หรือ SDK) เมื่อ:

* คุณทราบแพลตฟอร์มเป้าหมายของคุณ
* คุณต้องการควบคุมวิธีการเข้าถึง "ตรรกะ" ของคุณ
* คุณต้องการควบคุมการจัดการข้อผิดพลาดที่เกิดขึ้นจากไลบรารีของคุณ
* ประสิทธิภาพและประสบการณ์ผู้ใช้เป็นสิ่งสำคัญสูงสุดของคุณ

HTTP APIs ที่ใช้ **REST** มักถูกใช้บ่อยกว่าสำหรับ Public APIs

#### ข้อเสีย: RPC

* RPC client จะผูกติดกับการทำงานของ service มากเกินไป
* ต้องกำหนด API ใหม่สำหรับทุกการดำเนินการหรือกรณีการใช้งานใหม่
* อาจเป็นเรื่องยากในการ debug RPC
* คุณอาจไม่สามารถใช้เทคโนโลยีที่มีอยู่ได้ทันที ตัวอย่างเช่น อาจต้องใช้ความพยายามเพิ่มเติมเพื่อให้แน่ใจว่า [RPC calls ได้รับการแคชอย่างถูกต้อง](https://web.archive.org/web/20170608193645/http://etherealbits.com/2012/12/debunking-the-myths-of-rpc-rest/) บนเซิร์ฟเวอร์แคช เช่น [Squid](http://www.squid-cache.org/)

### Representational state transfer (REST)

REST เป็นรูปแบบสถาปัตยกรรมที่บังคับใช้โมเดล client/server โดยที่ client ทำงานกับชุดของ resource ที่ถูกจัดการโดย server  server จะให้การแสดงผลของ resource และการกระทำที่สามารถเปลี่ยนแปลงหรือรับการแสดงผลใหม่ของ resource ได้  การสื่อสารทั้งหมดต้องเป็นแบบไร้สถานะและสามารถแคชได้

RESTful interface มีคุณสมบัติ 4 ประการ:

* **ระบุ resource (URI ใน HTTP)** - ใช้ URI เดียวกันไม่ว่าจะเป็นการดำเนินการใด
* **เปลี่ยนด้วย representations (Verbs ใน HTTP)** - ใช้ verb, header และ body
* **ข้อความแสดงข้อผิดพลาดที่อธิบายตัวเอง (status response ใน HTTP)** - ใช้ status code ไม่ต้องสร้างใหม่เอง
* **[HATEOAS](http://restcookbook.com/Basics/hateoas/) (HTML interface สำหรับ HTTP)** - web service ของคุณควรเข้าถึงได้เต็มรูปแบบผ่าน browser

ตัวอย่าง REST calls:


```
GET /someresources/anId

PUT /someresources/anId
{"anotherdata": "another value"}
```
REST มุ่งเน้นไปที่การเปิดเผยข้อมูล โดยลดความเชื่อมโยงระหว่าง client/server และมักใช้สำหรับ HTTP API สาธารณะ REST ใช้วิธีที่เป็นกลางและสม่ำเสมอในการเปิดเผย resource ผ่าน URI, [การแสดงผลผ่าน header](https://github.com/for-GET/know-your-http-well/blob/master/headers.md), และการกระทำผ่าน verb เช่น GET, POST, PUT, DELETE และ PATCH ด้วยความเป็น stateless REST จึงเหมาะสำหรับการขยายระบบในแนวนอนและการแบ่งส่วน

#### ข้อเสีย: REST

* เนื่องจาก REST เน้นการเปิดเผยข้อมูล อาจไม่เหมาะหาก resource ไม่ถูกจัดระเบียบหรือเข้าถึงในลำดับชั้นที่ง่าย ตัวอย่างเช่น การคืนข้อมูลทั้งหมดที่ถูกอัปเดตในชั่วโมงที่ผ่านมาโดยตรงกับชุด event เฉพาะ ไม่สามารถแสดงเป็น path ได้ง่ายนัก ใน REST มักต้องใช้การรวมกันของ URI path, query parameters และอาจรวมถึง request body
* REST โดยทั่วไปจะใช้ verb เพียงไม่กี่ตัว (GET, POST, PUT, DELETE และ PATCH) ซึ่งบางครั้งอาจไม่ตรงกับ use case ของคุณ เช่น การย้ายเอกสารที่หมดอายุไปยังโฟลเดอร์ archive อาจไม่ตรงกับ verb เหล่านี้อย่างชัดเจน
* การดึง resource ที่ซับซ้อนและมีลำดับชั้นซ้อนกันต้องใช้การรับ-ส่งข้อมูลระหว่าง client และ server หลายรอบ เพื่อแสดงผลในมุมมองเดียว เช่น การดึงเนื้อหาของบล็อกและคอมเมนต์ สำหรับแอปมือถือที่ทำงานในเครือข่ายที่ไม่แน่นอน การรับ-ส่งข้อมูลหลายรอบเหล่านี้ไม่พึงประสงค์อย่างยิ่ง
* เมื่อเวลาผ่านไป อาจมีการเพิ่ม field ใหม่ใน API response และ client รุ่นเก่าจะได้รับข้อมูล field ใหม่ทั้งหมด แม้จะไม่ได้ต้องการ ส่งผลให้ payload ใหญ่ขึ้นและ latency สูงขึ้น

### การเปรียบเทียบ RPC และ REST

| Operation | RPC | REST |
|---|---|---|
| สมัครสมาชิก    | **POST** /signup | **POST** /persons |
| ลาออก    | **POST** /resign<br/>{<br/>"personid": "1234"<br/>} | **DELETE** /persons/1234 |
| อ่านข้อมูลบุคคล | **GET** /readPerson?personid=1234 | **GET** /persons/1234 |
| อ่านรายการสิ่งของของบุคคล | **GET** /readUsersItemsList?personid=1234 | **GET** /persons/1234/items |
| เพิ่มสิ่งของให้บุคคล | **POST** /addItemToUsersItemsList<br/>{<br/>"personid": "1234";<br/>"itemid": "456"<br/>} | **POST** /persons/1234/items<br/>{<br/>"itemid": "456"<br/>} |
| อัปเดตสิ่งของ    | **POST** /modifyItem<br/>{<br/>"itemid": "456";<br/>"key": "value"<br/>} | **PUT** /items/456<br/>{<br/>"key": "value"<br/>} |
| ลบสิ่งของ | **POST** /removeItem<br/>{<br/>"itemid": "456"<br/>} | **DELETE** /items/456 |

<p align="center">
  <i><a href=https://apihandyman.io/do-you-really-know-why-you-prefer-rest-over-rpc/>ที่มา: คุณรู้จริงหรือไม่ว่าทำไมคุณถึงชอบ REST มากกว่า RPC</a></i>
</p>

#### แหล่งข้อมูลและอ่านเพิ่มเติม: REST และ RPC

* [คุณรู้จริงหรือไม่ว่าทำไมคุณถึงชอบ REST มากกว่า RPC](https://apihandyman.io/do-you-really-know-why-you-prefer-rest-over-rpc/)
* [เมื่อไรที่แนวทาง RPC-ish เหมาะสมกว่า REST?](http://programmers.stackexchange.com/a/181186)
* [REST vs JSON-RPC](http://stackoverflow.com/questions/15056878/rest-vs-json-rpc)
* [หักล้างความเชื่อผิด ๆ เกี่ยวกับ RPC และ REST](https://web.archive.org/web/20170608193645/http://etherealbits.com/2012/12/debunking-the-myths-of-rpc-rest/)
* [ข้อเสียของการใช้ REST คืออะไร](https://www.quora.com/What-are-the-drawbacks-of-using-RESTful-APIs)
* [Crack the system design interview](http://www.puncsky.com/blog/2016-02-13-crack-the-system-design-interview)
* [Thrift](https://code.facebook.com/posts/1468950976659943/)
* [ทำไม REST สำหรับการใช้งานภายในจึงดีกว่า RPC](http://arstechnica.com/civis/viewtopic.php?t=1190508)

## ความปลอดภัย

ส่วนนี้อาจต้องการการอัปเดต กรุณา [ร่วมแก้ไข](#contributing)!

ความปลอดภัยเป็นหัวข้อที่กว้างใหญ่ หากคุณไม่มีประสบการณ์มาก หรือไม่มีพื้นฐานด้านความปลอดภัย หรือไม่ได้สมัครงานที่ต้องการความรู้ด้านความปลอดภัย คุณอาจไม่จำเป็นต้องรู้มากไปกว่าข้อมูลพื้นฐาน:

* เข้ารหัสข้อมูลทั้งขณะส่งผ่านและขณะเก็บรักษา
* กำจัดข้อมูลอินพุตจากผู้ใช้ หรือพารามิเตอร์อินพุตใด ๆ ที่ผู้ใช้สามารถเข้าถึงได้ เพื่อป้องกัน [XSS](https://en.wikipedia.org/wiki/Cross-site_scripting) และ [SQL injection](https://en.wikipedia.org/wiki/SQL_injection)
* ใช้การ query แบบมีการกำหนดพารามิเตอร์เพื่อป้องกัน SQL injection
* ใช้หลักการ [least privilege](https://en.wikipedia.org/wiki/Principle_of_least_privilege)

### แหล่งข้อมูลและบทความเพิ่มเติม

* [API security checklist](https://github.com/shieldfy/API-Security-Checklist)
* [Security guide for developers](https://github.com/FallibleInc/security-guide-for-developers)
* [OWASP top ten](https://www.owasp.org/index.php/OWASP_Top_Ten_Cheat_Sheet)

## ภาคผนวก

บางครั้งคุณอาจถูกขอให้ทำการประเมินโดยประมาณคร่าว ๆ เช่น คุณอาจต้องคำนวณว่าต้องใช้เวลากี่นาทีในการสร้างรูปย่อขนาด 100 ภาพจากดิสก์ หรือโครงสร้างข้อมูลหนึ่ง ๆ จะใช้หน่วยความจำเท่าใด ตาราง **กำลังสอง** และ **ตัวเลขความหน่วงที่โปรแกรมเมอร์ควรรู้** เป็นข้อมูลอ้างอิงที่มีประโยชน์

### ตารางกำลังสอง


```
Power           Exact Value         Approx Value        Bytes
---------------------------------------------------------------
7                             128
8                             256
10                           1024   1 thousand           1 KB
16                         65,536                       64 KB
20                      1,048,576   1 million            1 MB
30                  1,073,741,824   1 billion            1 GB
32                  4,294,967,296                        4 GB
40              1,099,511,627,776   1 trillion           1 TB
```

#### แหล่งข้อมูลและอ่านเพิ่มเติม

* [เลขยกกำลังสอง](https://th.wikipedia.org/wiki/เลขยกกำลังสอง)

### ตัวเลขค่า Latency ที่โปรแกรมเมอร์ทุกคนควรรู้

```
Latency Comparison Numbers
--------------------------
L1 cache reference                           0.5 ns
Branch mispredict                            5   ns
L2 cache reference                           7   ns                      14x L1 cache
Mutex lock/unlock                           25   ns
Main memory reference                      100   ns                      20x L2 cache, 200x L1 cache
Compress 1K bytes with Zippy            10,000   ns       10 us
Send 1 KB bytes over 1 Gbps network     10,000   ns       10 us
Read 4 KB randomly from SSD*           150,000   ns      150 us          ~1GB/sec SSD
Read 1 MB sequentially from memory     250,000   ns      250 us
Round trip within same datacenter      500,000   ns      500 us
Read 1 MB sequentially from SSD*     1,000,000   ns    1,000 us    1 ms  ~1GB/sec SSD, 4X memory
HDD seek                            10,000,000   ns   10,000 us   10 ms  20x datacenter roundtrip
Read 1 MB sequentially from 1 Gbps  10,000,000   ns   10,000 us   10 ms  40x memory, 10X SSD
Read 1 MB sequentially from HDD     30,000,000   ns   30,000 us   30 ms 120x memory, 30X SSD
Send packet CA->Netherlands->CA    150,000,000   ns  150,000 us  150 ms

Notes
-----
1 ns = 10^-9 seconds
1 us = 10^-6 seconds = 1,000 ns
1 ms = 10^-3 seconds = 1,000 us = 1,000,000 ns
```

ข้อมูลเมตริกที่เป็นประโยชน์จากตัวเลขข้างต้น:

* อ่านข้อมูลแบบลำดับจาก HDD ที่ 30 MB/s
* อ่านข้อมูลแบบลำดับจาก Ethernet 1 Gbps ที่ 100 MB/s
* อ่านข้อมูลแบบลำดับจาก SSD ที่ 1 GB/s
* อ่านข้อมูลแบบลำดับจากหน่วยความจำหลักที่ 4 GB/s
* เดินทางรอบโลก 6-7 ครั้งต่อวินาที
* เดินทางรอบในดาต้าเซ็นเตอร์ 2,000 ครั้งต่อวินาที

#### ตัวเลขความหน่วงแสดงภาพ

![](https://camo.githubusercontent.com/77f72259e1eb58596b564d1ad823af1853bc60a3/687474703a2f2f692e696d6775722e636f6d2f6b307431652e706e67)

#### แหล่งข้อมูลและอ่านเพิ่มเติม

* [ตัวเลขความหน่วงที่โปรแกรมเมอร์ควรรู้ - 1](https://gist.github.com/jboner/2841832)
* [ตัวเลขความหน่วงที่โปรแกรมเมอร์ควรรู้ - 2](https://gist.github.com/hellerbarde/2843375)
* [การออกแบบ, บทเรียน, และคำแนะนำจากการสร้างระบบกระจายขนาดใหญ่](http://www.cs.cornell.edu/projects/ladis2009/talks/dean-keynote-ladis2009.pdf)
* [คำแนะนำด้านวิศวกรรมซอฟต์แวร์จากการสร้างระบบกระจายขนาดใหญ่](https://static.googleusercontent.com/media/research.google.com/en//people/jeff/stanford-295-talk.pdf)

### คำถามสัมภาษณ์ออกแบบระบบเพิ่มเติม

> คำถามสัมภาษณ์ออกแบบระบบที่พบบ่อย พร้อมลิงก์แหล่งข้อมูลวิธีแก้แต่ละข้อ

| คำถาม | แหล่งอ้างอิง |
|---|---|
| ออกแบบบริการซิงค์ไฟล์แบบ Dropbox | [youtube.com](https://www.youtube.com/watch?v=PE4gwstWhmc) |
| ออกแบบเครื่องมือค้นหาเช่น Google | [queue.acm.org](http://queue.acm.org/detail.cfm?id=988407)<br/>[stackexchange.com](http://programmers.stackexchange.com/questions/38324/interview-question-how-would-you-implement-google-search)<br/>[ardendertat.com](http://www.ardendertat.com/2012/01/11/implementing-search-engines/)<br/>[stanford.edu](http://infolab.stanford.edu/~backrub/google.html) |
| ออกแบบเว็บครอเลอร์ที่ปรับขนาดได้เช่น Google | [quora.com](https://www.quora.com/How-can-I-build-a-web-crawler-from-scratch) |
| ออกแบบ Google docs | [code.google.com](https://code.google.com/p/google-mobwrite/)<br/>[neil.fraser.name](https://neil.fraser.name/writing/sync/) |
| ออกแบบระบบ key-value store เช่น Redis | [slideshare.net](http://www.slideshare.net/dvirsky/introduction-to-redis) |
| ออกแบบระบบแคชเช่น Memcached | [slideshare.net](http://www.slideshare.net/oemebamo/introduction-to-memcached) |
| ออกแบบระบบแนะนำสินค้าแบบ Amazon | [hulu.com](https://web.archive.org/web/20170406065247/http://tech.hulu.com/blog/2011/09/19/recommendation-system.html)<br/>[ijcai13.org](http://ijcai13.org/files/tutorial_slides/td3.pdf) |
| ออกแบบระบบ tinyurl เช่น Bitly | [n00tc0d3r.blogspot.com](http://n00tc0d3r.blogspot.com/) |
| ออกแบบแอพแชทเช่น WhatsApp | [highscalability.com](http://highscalability.com/blog/2014/2/26/the-whatsapp-architecture-facebook-bought-for-19-billion.html)
| ออกแบบระบบแชร์รูปภาพเช่น Instagram | [highscalability.com](http://highscalability.com/flickr-architecture)<br/>[highscalability.com](http://highscalability.com/blog/2011/12/6/instagram-architecture-14-million-users-terabytes-of-photos.html) |
| ออกแบบฟังก์ชันฟีดข่าว Facebook | [quora.com](http://www.quora.com/What-are-best-practices-for-building-something-like-a-News-Feed)<br/>[quora.com](http://www.quora.com/Activity-Streams/What-are-the-scaling-issues-to-keep-in-mind-while-developing-a-social-network-feed)<br/>[slideshare.net](http://www.slideshare.net/danmckinley/etsy-activity-feeds-architecture) |
| ออกแบบฟังก์ชันไทม์ไลน์ Facebook | [facebook.com](https://www.facebook.com/note.php?note_id=10150468255628920)<br/>[highscalability.com](http://highscalability.com/blog/2012/1/23/facebook-timeline-brought-to-you-by-the-power-of-denormaliza.html) |
| ออกแบบฟังก์ชันแชท Facebook | [erlang-factory.com](http://www.erlang-factory.com/upload/presentations/31/EugeneLetuchy-ErlangatFacebook.pdf)<br/>[facebook.com](https://www.facebook.com/note.php?note_id=14218138919&id=9445547199&index=0) |
| ออกแบบฟังก์ชันค้นหาแบบกราฟเหมือน Facebook | [facebook.com](https://www.facebook.com/notes/facebook-engineering/under-the-hood-building-out-the-infrastructure-for-graph-search/10151347573598920)<br/>[facebook.com](https://www.facebook.com/notes/facebook-engineering/under-the-hood-indexing-and-ranking-in-graph-search/10151361720763920)<br/>[facebook.com](https://www.facebook.com/notes/facebook-engineering/under-the-hood-the-natural-language-interface-of-graph-search/10151432733048920) |
| ออกแบบระบบ Content Delivery Network เหมือน CloudFlare | [figshare.com](https://figshare.com/articles/Globally_distributed_content_delivery/6605972) |
| ออกแบบระบบหัวข้อยอดนิยมเหมือน Twitter | [michael-noll.com](http://www.michael-noll.com/blog/2013/01/18/implementing-real-time-trending-topics-in-storm/)<br/>[snikolov .wordpress.com](http://snikolov.wordpress.com/2012/11/14/early-detection-of-twitter-trends/) |
| ออกแบบระบบสร้างรหัสสุ่ม | [blog.twitter.com](https://blog.twitter.com/2010/announcing-snowflake)<br/>[github.com](https://github.com/twitter/snowflake/) |
| ส่งคืนคำขอสูงสุด k ในช่วงเวลาหนึ่ง | [cs.ucsb.edu](https://www.cs.ucsb.edu/sites/default/files/documents/2005-23.pdf)<br/>[wpi.edu](http://davis.wpi.edu/xmdv/docs/EDBT11-diyang.pdf) |
| ออกแบบระบบให้บริการข้อมูลจากหลายดาต้าเซ็นเตอร์ | [highscalability.com](http://highscalability.com/blog/2009/8/24/how-google-serves-data-from-multiple-datacenters.html) |
| ออกแบบเกมไพ่ผู้เล่นหลายคนออนไลน์ | [indieflashblog.com](https://web.archive.org/web/20180929181117/http://www.indieflashblog.com/how-to-create-an-asynchronous-multiplayer-game.html)<br/>[buildnewgames.com](http://buildnewgames.com/real-time-multiplayer/) |
| ออกแบบระบบจัดการขยะ (Garbage Collection) | [stuffwithstuff.com](http://journal.stuffwithstuff.com/2013/12/08/babys-first-garbage-collector/)<br/>[washington.edu](http://courses.cs.washington.edu/courses/csep521/07wi/prj/rick.pdf) |
| ออกแบบ API rate limiter | [https://stripe.com/blog/](https://stripe.com/blog/rate-limiters) |
| ออกแบบตลาดหลักทรัพย์ (เช่น NASDAQ หรือ Binance) | [Jane Street](https://youtu.be/b1e4t2k2KJY)<br/>[Golang Implementation](https://around25.com/blog/building-a-trading-engine-for-a-crypto-exchange/)<br/>[Go Implementation](http://bhomnick.net/building-a-simple-limit-order-in-go/) |
| เพิ่มคำถามออกแบบระบบ | [ร่วมสมทบ](#contributing) |

### สถาปัตยกรรมในโลกจริง

> บทความเกี่ยวกับการออกแบบระบบในโลกจริง

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/TcUo2fw.png">
  <br/>
  <i><a href=https://www.infoq.com/presentations/Twitter-Timeline-Scalability>ที่มา: Twitter timelines at scale</a></i>
</p>

**ไม่ต้องเน้นรายละเอียดปลีกย่อยสำหรับบทความเหล่านี้ แต่ให้:**

* ระบุหลักการที่ใช้ร่วมกัน เทคโนโลยีทั่วไป และรูปแบบที่พบในบทความเหล่านี้
* ศึกษาว่าแต่ละองค์ประกอบแก้ไขปัญหาอะไร ตรงจุดไหนที่เหมาะสม และจุดไหนที่ไม่เหมาะสม
* ทบทวนบทเรียนที่ได้รับ

|ประเภท | ระบบ | แหล่งข้อมูล |
|---|---|---|
| ประมวลผลข้อมูล | **MapReduce** - การประมวลผลข้อมูลแบบกระจายจาก Google | [research.google.com](http://static.googleusercontent.com/media/research.google.com/zh-CN/us/archive/mapreduce-osdi04.pdf) |
| ประมวลผลข้อมูล | **Spark** - การประมวลผลข้อมูลแบบกระจายจาก Databricks | [slideshare.net](http://www.slideshare.net/AGrishchenko/apache-spark-architecture) |
| ประมวลผลข้อมูล | **Storm** - การประมวลผลข้อมูลแบบกระจายจาก Twitter | [slideshare.net](http://www.slideshare.net/previa/storm-16094009) |
| | | |
| ที่เก็บข้อมูล | **Bigtable** - ฐานข้อมูลแบบ column-oriented กระจายจาก Google | [harvard.edu](http://www.read.seas.harvard.edu/~kohler/class/cs239-w08/chang06bigtable.pdf) |
| ที่เก็บข้อมูล | **HBase** - การนำ Bigtable มาใช้แบบโอเพนซอร์ส | [slideshare.net](http://www.slideshare.net/alexbaranau/intro-to-hbase) |
| ที่เก็บข้อมูล | **Cassandra** - ฐานข้อมูลแบบ column-oriented กระจายจาก Facebook | [slideshare.net](http://www.slideshare.net/planetcassandra/cassandra-introduction-features-30103666)
| ที่เก็บข้อมูล | **DynamoDB** - ฐานข้อมูลแบบ document-oriented จาก Amazon | [harvard.edu](http://www.read.seas.harvard.edu/~kohler/class/cs239-w08/decandia07dynamo.pdf) |
| ที่เก็บข้อมูล | **MongoDB** - ฐานข้อมูลแบบ document-oriented | [slideshare.net](http://www.slideshare.net/mdirolf/introduction-to-mongodb) |
| ที่เก็บข้อมูล | **Spanner** - ฐานข้อมูลกระจายทั่วโลกจาก Google | [research.google.com](http://research.google.com/archive/spanner-osdi2012.pdf) |
| ที่เก็บข้อมูล | **Memcached** - ระบบแคชหน่วยความจำแบบกระจาย | [slideshare.net](http://www.slideshare.net/oemebamo/introduction-to-memcached) |
| ที่เก็บข้อมูล | **Redis** - ระบบแคชหน่วยความจำแบบกระจายที่มีการคงอยู่และประเภทค่า | [slideshare.net](http://www.slideshare.net/dvirsky/introduction-to-redis) |
| | | |
| ระบบไฟล์ | **Google File System (GFS)** - ระบบไฟล์แบบกระจาย | [research.google.com](http://static.googleusercontent.com/media/research.google.com/zh-CN/us/archive/gfs-sosp2003.pdf) |
| ระบบไฟล์ | **Hadoop File System (HDFS)** - การนำ GFS มาใช้แบบโอเพนซอร์ส | [apache.org](http://hadoop.apache.org/docs/stable/hadoop-project-dist/hadoop-hdfs/HdfsDesign.html) |
| | | |
| เบ็ดเตล็ด | **Chubby** - บริการล็อกสำหรับระบบกระจายจาก Google | [research.google.com](http://static.googleusercontent.com/external_content/untrusted_dlcp/research.google.com/en/us/archive/chubby-osdi06.pdf) |
| เบ็ดเตล็ด | **Dapper** - โครงสร้างพื้นฐานสำหรับติดตามระบบกระจาย | [research.google.com](http://static.googleusercontent.com/media/research.google.com/en//pubs/archive/36356.pdf)
| เบ็ดเตล็ด | **Kafka** - คิวข้อความ pub/sub จาก LinkedIn | [slideshare.net](http://www.slideshare.net/mumrah/kafka-talk-tri-hug) |
| เบ็ดเตล็ด | **Zookeeper** - โครงสร้างพื้นฐานแบบศูนย์กลางสำหรับการซิงโครไนซ์ | [slideshare.net](http://www.slideshare.net/sauravhaloi/introduction-to-apache-zookeeper) |
| | เพิ่มสถาปัตยกรรม | [ร่วมสมทบ](#contributing) |

### สถาปัตยกรรมของบริษัท

| บริษัท | แหล่งอ้างอิง |
|---|---|
| Amazon | [สถาปัตยกรรม Amazon](http://highscalability.com/amazon-architecture) |
| Cinchcast | [การผลิตไฟล์เสียง 1,500 ชั่วโมงต่อวัน](http://highscalability.com/blog/2012/7/16/cinchcast-architecture-producing-1500-hours-of-audio-every-d.html) |
| DataSift | [การทำเหมืองข้อมูลแบบเรียลไทม์ที่ 120,000 ทวีตต่อวินาที](http://highscalability.com/blog/2011/11/29/datasift-architecture-realtime-datamining-at-120000-tweets-p.html) |
| Dropbox | [วิธีที่ Dropbox ขยายตัว](https://www.youtube.com/watch?v=PE4gwstWhmc) |
| ESPN | [การดำเนินงานที่ 100,000 duh nuh nuhs ต่อวินาที](http://highscalability.com/blog/2013/11/4/espns-architecture-at-scale-operating-at-100000-duh-nuh-nuhs.html) |
| Google | [สถาปัตยกรรม Google](http://highscalability.com/google-architecture) |
| Instagram | [14 ล้านผู้ใช้, เทราไบต์ของรูปภาพ](http://highscalability.com/blog/2011/12/6/instagram-architecture-14-million-users-terabytes-of-photos.html)<br/>[สิ่งที่ขับเคลื่อน Instagram](http://instagram-engineering.tumblr.com/post/13649370142/what-powers-instagram-hundreds-of-instances) |
| Justin.tv | [สถาปัตยกรรมถ่ายทอดสดของ Justin.tv](http://highscalability.com/blog/2010/3/16/justintvs-live-video-broadcasting-architecture.html) |
| Facebook | [การขยาย memcached ที่ Facebook](https://cs.uwaterloo.ca/~brecht/courses/854-Emerging-2014/readings/key-value/fb-memcached-nsdi-2013.pdf)<br/>[TAO: ที่เก็บข้อมูลแบบกระจายสำหรับ social graph ของ Facebook](https://cs.uwaterloo.ca/~brecht/courses/854-Emerging-2014/readings/data-store/tao-facebook-distributed-datastore-atc-2013.pdf)<br/>[การจัดเก็บรูปภาพของ Facebook](https://www.usenix.org/legacy/event/osdi10/tech/full_papers/Beaver.pdf)<br/>[วิธีที่ Facebook ถ่ายทอดสดไปยัง 800,000 ผู้ชมพร้อมกัน](http://highscalability.com/blog/2016/6/27/how-facebook-live-streams-to-800000-simultaneous-viewers.html) |
| Flickr | [สถาปัตยกรรม Flickr](http://highscalability.com/flickr-architecture) |
| Mailbox | [จาก 0 ถึงหนึ่งล้านผู้ใช้ใน 6 สัปดาห์](http://highscalability.com/blog/2013/6/18/scaling-mailbox-from-0-to-one-million-users-in-6-weeks-and-1.html) |
| Netflix | [มุมมอง 360 องศาต่อสแต็กทั้งหมดของ Netflix](http://highscalability.com/blog/2015/11/9/a-360-degree-view-of-the-entire-netflix-stack.html)<br/>[Netflix: เกิดอะไรขึ้นเมื่อคุณกดเล่น?](http://highscalability.com/blog/2017/12/11/netflix-what-happens-when-you-press-play.html) |
| Pinterest | [จาก 0 ถึงหลายสิบพันล้าน page views ต่อเดือน](http://highscalability.com/blog/2013/4/15/scaling-pinterest-from-0-to-10s-of-billions-of-page-views-a.html)<br/>[18 ล้านผู้เข้าชม, เติบโต 10 เท่า, พนักงาน 12 คน](http://highscalability.com/blog/2012/5/21/pinterest-architecture-update-18-million-visitors-10x-growth.html) |
| Playfish | [50 ล้านผู้ใช้ต่อเดือนและยังคงเพิ่มขึ้น](http://highscalability.com/blog/2010/9/21/playfishs-social-gaming-architecture-50-million-monthly-user.html) |
| PlentyOfFish | [สถาปัตยกรรม PlentyOfFish](http://highscalability.com/plentyoffish-architecture) |
| Salesforce | [วิธีจัดการธุรกรรม 1.3 พันล้านรายการต่อวัน](http://highscalability.com/blog/2013/9/23/salesforce-architecture-how-they-handle-13-billion-transacti.html) |
| Stack Overflow | [สถาปัตยกรรม Stack Overflow](http://highscalability.com/blog/2009/8/5/stack-overflow-architecture.html) |
| TripAdvisor | [40 ล้านผู้เข้าชม, 200 ล้าน page views แบบไดนามิก, ข้อมูล 30TB](http://highscalability.com/blog/2011/6/27/tripadvisor-architecture-40m-visitors-200m-dynamic-page-view.html) |
| Tumblr | [15 พันล้าน page views ต่อเดือน](http://highscalability.com/blog/2012/2/13/tumblr-architecture-15-billion-page-views-a-month-and-harder.html) |
| Twitter | [ทำให้ Twitter เร็วขึ้น 10000 เปอร์เซ็นต์](http://highscalability.com/scaling-twitter-making-twitter-10000-percent-faster)<br/>[การจัดเก็บ 250 ล้านทวีตต่อวันด้วย MySQL](http://highscalability.com/blog/2011/12/19/how-twitter-stores-250-million-tweets-a-day-using-mysql.html)<br/>[150 ล้านผู้ใช้, 300K QPS, ข้อมูล 22 MB/S](http://highscalability.com/blog/2013/7/8/the-architecture-twitter-uses-to-deal-with-150m-active-users.html)<br/>[ไทม์ไลน์ที่ขยายได้](https://www.infoq.com/presentations/Twitter-Timeline-Scalability)<br/>[ข้อมูลใหญ่และเล็กที่ Twitter](https://www.youtube.com/watch?v=5cKTP36HVgI)<br/>[การดำเนินงานที่ Twitter: ขยายเกิน 100 ล้านผู้ใช้](https://www.youtube.com/watch?v=z8LU0Cj6BOU)<br/>[Twitter รับมือกับ 3,000 รูปภาพต่อวินาทีอย่างไร](http://highscalability.com/blog/2016/4/20/how-twitter-handles-3000-images-per-second.html) |
| Uber | [Uber ขยายแพลตฟอร์มตลาดแบบเรียลไทม์อย่างไร](http://highscalability.com/blog/2015/9/14/how-uber-scales-their-real-time-market-platform.html)<br/>[บทเรียนจากการขยาย Uber ไปยัง 2000 วิศวกร, 1000 บริการ, และ 8000 Git repositories](http://highscalability.com/blog/2016/10/12/lessons-learned-from-scaling-uber-to-2000-engineers-1000-ser.html) |
| WhatsApp | [สถาปัตยกรรม WhatsApp ที่ Facebook ซื้อไปในราคา 19 พันล้านเหรียญ](http://highscalability.com/blog/2014/2/26/the-whatsapp-architecture-facebook-bought-for-19-billion.html) |
| YouTube | [การปรับขนาดของ YouTube](https://www.youtube.com/watch?v=w5WVu624fY8)<br/>[สถาปัตยกรรม YouTube](http://highscalability.com/youtube-architecture) |

### บล็อกวิศวกรรมของบริษัท

> สถาปัตยกรรมสำหรับบริษัทที่คุณกำลังสัมภาษณ์งานด้วย
>
> คำถามที่คุณพบอาจมาจากโดเมนเดียวกัน

* [Airbnb Engineering](http://nerds.airbnb.com/)
* [Atlassian Developers](https://developer.atlassian.com/blog/)
* [AWS Blog](https://aws.amazon.com/blogs/aws/)
* [Bitly Engineering Blog](http://word.bitly.com/)
* [Box Blogs](https://blog.box.com/blog/category/engineering)
* [Cloudera Developer Blog](http://blog.cloudera.com/)
* [Dropbox Tech Blog](https://tech.dropbox.com/)
* [Engineering at Quora](https://www.quora.com/q/quoraengineering)
* [Ebay Tech Blog](http://www.ebaytechblog.com/)
* [Evernote Tech Blog](https://blog.evernote.com/tech/)
* [Etsy Code as Craft](http://codeascraft.com/)
* [Facebook Engineering](https://www.facebook.com/Engineering)
* [Flickr Code](http://code.flickr.net/)
* [Foursquare Engineering Blog](http://engineering.foursquare.com/)
* [GitHub Engineering Blog](https://github.blog/category/engineering)
* [Google Research Blog](http://googleresearch.blogspot.com/)
* [Groupon Engineering Blog](https://engineering.groupon.com/)
* [Heroku Engineering Blog](https://engineering.heroku.com/)
* [Hubspot Engineering Blog](http://product.hubspot.com/blog/topic/engineering)
* [High Scalability](http://highscalability.com/)
* [Instagram Engineering](http://instagram-engineering.tumblr.com/)
* [Intel Software Blog](https://software.intel.com/en-us/blogs/)
* [Jane Street Tech Blog](https://blogs.janestreet.com/category/ocaml/)
* [LinkedIn Engineering](http://engineering.linkedin.com/blog)
* [Microsoft Engineering](https://engineering.microsoft.com/)
* [Microsoft Python Engineering](https://blogs.msdn.microsoft.com/pythonengineering/)
* [Netflix Tech Blog](http://techblog.netflix.com/)
* [Paypal Developer Blog](https://medium.com/paypal-engineering)
* [Pinterest Engineering Blog](https://medium.com/@Pinterest_Engineering)
* [Reddit Blog](http://www.redditblog.com/)
* [Salesforce Engineering Blog](https://developer.salesforce.com/blogs/engineering/)
* [Slack Engineering Blog](https://slack.engineering/)
* [Spotify Labs](https://labs.spotify.com/)
* [Stripe Engineering Blog](https://stripe.com/blog/engineering)
* [Twilio Engineering Blog](http://www.twilio.com/engineering)
* [Twitter Engineering](https://blog.twitter.com/engineering/)
* [Uber Engineering Blog](http://eng.uber.com/)
* [Yahoo Engineering Blog](http://yahooeng.tumblr.com/)
* [Yelp Engineering Blog](http://engineeringblog.yelp.com/)
* [Zynga Engineering Blog](https://www.zynga.com/blogs/engineering)

#### แหล่งข้อมูลและอ่านเพิ่มเติม

กำลังมองหาบล็อกที่จะเพิ่ม? เพื่อหลีกเลี่ยงการทำงานซ้ำ โปรดพิจารณาเพิ่มบล็อกบริษัทของคุณลงใน repo ต่อไปนี้:

* [kilimchoi/engineering-blogs](https://github.com/kilimchoi/engineering-blogs)

## กำลังอยู่ระหว่างการพัฒนา

สนใจจะเพิ่มหัวข้อหรือช่วยเติมเต็มส่วนที่กำลังดำเนินการอยู่หรือไม่? [ร่วมสมทบ](#contributing)!

* การประมวลผลแบบกระจายด้วย MapReduce
* Consistent hashing
* Scatter gather
* [ร่วมสมทบ](#contributing)

## เครดิต

เครดิตและแหล่งข้อมูลมีให้ตลอดทั้ง repo นี้

ขอขอบคุณเป็นพิเศษแก่:

* [Hired in tech](http://www.hiredintech.com/system-design/the-system-design-process/)
* [Cracking the coding interview](https://www.amazon.com/dp/0984782850/)
* [High scalability](http://highscalability.com/)
* [checkcheckzz/system-design-interview](https://github.com/checkcheckzz/system-design-interview)
* [shashank88/system_design](https://github.com/shashank88/system_design)
* [mmcgrana/services-engineering](https://github.com/mmcgrana/services-engineering)
* [System design cheat sheet](https://gist.github.com/vasanthk/485d1c25737e8e72759f)
* [A distributed systems reading list](http://dancres.github.io/Pages/)
* [Cracking the system design interview](http://www.puncsky.com/blog/2016-02-13-crack-the-system-design-interview)

## ข้อมูลติดต่อ

สามารถติดต่อฉันได้หากต้องการพูดคุยเกี่ยวกับปัญหา คำถาม หรือข้อเสนอแนะใด ๆ

ข้อมูลการติดต่อของฉันสามารถพบได้ที่ [GitHub page](https://github.com/donnemartin)

## ใบอนุญาต

*ฉันให้โค้ดและทรัพยากรในรีโพซิทอรีนี้แก่คุณภายใต้สัญญาอนุญาตแบบโอเพนซอร์ส เนื่องจากนี่คือรีโพซิทอรีส่วนตัวของฉัน สัญญาอนุญาตที่คุณได้รับสำหรับโค้ดและทรัพยากรจึงเป็นจากฉัน ไม่ใช่นายจ้างของฉัน (Facebook)*

    Copyright 2017 Donne Martin

    ใบอนุญาต Creative Commons Attribution 4.0 International (CC BY 4.0)

    http://creativecommons.org/licenses/by/4.0/


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-09

---