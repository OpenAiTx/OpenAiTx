# ASP.NET SignalR 

**สำคัญ**: จะไม่มีการเพิ่มฟีเจอร์ใหม่ให้กับผลิตภัณฑ์นี้ เราอยู่ในโหมดบำรุงรักษาและจะแก้ไขเฉพาะปัญหาสำคัญเท่านั้น ดูรายละเอียดที่ [บล็อกของเรา](https://devblogs.microsoft.com/aspnet/the-future-of-asp-net-signalr/) 
ที่เก็บนี้โฮสต์โค้ดและการจัดการโปรเจ็กต์สำหรับ ASP.NET SignalR สำหรับใช้งานในแอปพลิเคชัน .NET Framework ที่ใช้ System.Web หรือ Katana หากคุณกำลังมองหาข้อมูลเกี่ยวกับ ASP.NET Core SignalR ดูที่ https://github.com/aspnet/AspNetCore/tree/main/src/SignalR

ASP.NET SignalR เป็นไลบรารีสำหรับนักพัฒนา ASP.NET ที่ทำให้การเพิ่มฟังก์ชันเว็บแบบเรียลไทม์ลงในแอปพลิเคชันของคุณเป็นเรื่องง่ายมาก ฟังก์ชัน "เว็บแบบเรียลไทม์" คืออะไร? คือความสามารถที่โค้ดฝั่งเซิร์ฟเวอร์ของคุณสามารถส่งเนื้อหาไปยังลูกค้าที่เชื่อมต่อแบบทันทีที่เกิดขึ้น แบบเรียลไทม์

## สามารถใช้ทำอะไรได้บ้าง?
การส่งข้อมูลจากเซิร์ฟเวอร์ไปยังไคลเอนต์ (ไม่ใช่แค่เบราว์เซอร์ไคลเอนต์) เป็นปัญหาที่ยากเสมอ SignalR ทำให้สิ่งนี้กลายเป็นเรื่องง่ายมากและจัดการงานหนักทั้งหมดให้คุณ

## เอกสารประกอบ
ดู [เอกสารประกอบ](https://docs.microsoft.com/aspnet/signalr/overview/getting-started/introduction-to-signalr)

## รับได้บน NuGet!

    Install-Package Microsoft.AspNet.SignalR

## รับตัวอย่างบน NuGet ตรงเข้าสู่แอปของคุณ!

    Install-Package Microsoft.AspNet.SignalR.Sample
	
## ใบอนุญาต
[ใบอนุญาต Apache 2.0](https://github.com/SignalR/SignalR/blob/main/LICENSE.txt)

## การมีส่วนร่วม

ดู [แนวทางการมีส่วนร่วม](https://github.com/SignalR/SignalR/blob/main/CONTRIBUTING.md)

## การสร้างซอร์สโค้ด

```
git clone git@github.com:SignalR/SignalR.git (หรือ https หากคุณใช้ https)
```

### Windows
หลังจากโคลน repository แล้ว ให้รัน `build.cmd`

**หมายเหตุ:** การเปิดโซลูชันนี้ต้องใช้ VS 2017

## มีคำถาม?
* ถามใน StackOverflow โดยใช้แท็ก [signalr](https://stackoverflow.com/questions/tagged/signalr)
* โพสต์ปัญหาใน [Issue Tracker](https://github.com/SignalR/SignalR/issues)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---