# .NET Aspire

[![Tests](https://github.com/dotnet/aspire/actions/workflows/tests.yml/badge.svg?branch=main&event=push)](https://github.com/dotnet/aspire/actions/workflows/tests.yml)
[![Build Status](https://dev.azure.com/dnceng-public/public/_apis/build/status%2Fdotnet%2Faspire%2Fdotnet.aspire?branchName=main)](https://dev.azure.com/dnceng-public/public/_build/latest?definitionId=274&branchName=main)
[![Help Wanted](https://img.shields.io/github/issues/dotnet/aspire/help%20wanted?style=flat&color=%24EC820&label=help%20wanted)](https://github.com/dotnet/aspire/labels/help%20wanted)
[![Good First Issue](https://img.shields.io/github/issues/dotnet/aspire/good%20first%20issue?style=flat&color=%24EC820&label=good%20first%20issue)](https://github.com/dotnet/aspire/labels/good%20first%20issue)
[![Discord](https://img.shields.io/discord/732297728826277939?style=flat&logo=discord&logoColor=white&label=Join%20our%20Discord&labelColor=512bd4&color=cyan)](https://discord.com/invite/h87kDAHQgJ)

## .NET Aspire คืออะไร?

.NET Aspire คือชุดเทคโนโลยีที่ถูกออกแบบมาเพื่อรองรับการพัฒนาแอปพลิเคชันแบบ cloud-ready ที่สามารถสังเกตการณ์และพร้อมใช้งานในระดับ production สำหรับแอปพลิเคชันแบบกระจาย (distributed applications) .NET Aspire ถูกจัดส่งในรูปแบบของชุด NuGet packages ที่จัดการกับประเด็นสำคัญของระบบ cloud-native โดยเฉพาะ แอปพลิเคชัน cloud-native มักประกอบด้วยส่วนย่อยขนาดเล็กที่เชื่อมต่อกัน (microservices) แทนที่จะเป็นโค้ดเบสขนาดใหญ่เพียงชุดเดียว นอกจากนี้ยังมักใช้งานบริการต่างๆ จำนวนมาก เช่น ฐานข้อมูล ระบบส่งข้อความ และการแคช

.NET Aspire ช่วยในเรื่องต่างๆ ดังนี้:

[การจัดการ Orchestration](https://learn.microsoft.com/dotnet/aspire/get-started/aspire-overview?#orchestration): .NET Aspire มีฟีเจอร์สำหรับรันและเชื่อมต่อแอปพลิเคชันแบบหลายโปรเจกต์และการจัดการ dependency ของแต่ละโปรเจกต์

[การเชื่อมต่อ Integrations](https://learn.microsoft.com/dotnet/aspire/get-started/aspire-overview?#net-aspire-integrations): .NET Aspire integrations คือ NuGet packages สำหรับบริการยอดนิยม เช่น Redis หรือ Postgres โดยมีอินเทอร์เฟซที่เป็นมาตรฐาน ช่วยให้เชื่อมต่อกับแอปของคุณได้อย่างต่อเนื่องและไร้รอยต่อ

[เครื่องมือ Tooling](https://learn.microsoft.com/dotnet/aspire/get-started/aspire-overview?#project-templates-and-tooling): .NET Aspire มาพร้อมกับแม่แบบโปรเจกต์และเครื่องมือสำหรับ Visual Studio และ dotnet CLI เพื่อช่วยในการสร้างและโต้ตอบกับแอป .NET Aspire

หากต้องการเรียนรู้เพิ่มเติม โปรดอ่าน [.NET Aspire overview และเอกสารประกอบฉบับเต็ม](https://learn.microsoft.com/dotnet/aspire/) ตัวอย่างการใช้งานสามารถดูได้ที่ [.NET Aspire samples repository](https://github.com/dotnet/aspire-samples) คุณสามารถค้นหาตัวอย่าง [eShop ที่นี่](https://github.com/dotnet/eshop) และ [เวอร์ชัน Azure ที่นี่](https://github.com/Azure-Samples/eShopOnAzure)

## มีอะไรใน repo นี้บ้าง?

ในที่เก็บนี้จะประกอบด้วย .NET Aspire application host, dashboard, โครงสร้างพื้นฐานสำหรับ service discovery และ integration ทั้งหมดของ .NET Aspire รวมถึงแม่แบบโปรเจกต์ต่างๆ

## การใช้งาน daily builds ล่าสุด

ทำตามคำแนะนำใน [docs/using-latest-daily.md](https://raw.githubusercontent.com/dotnet/aspire/main/docs/using-latest-daily.md) เพื่อเริ่มใช้งาน .NET Aspire กับ daily build ล่าสุด

## ฉันจะมีส่วนร่วมได้อย่างไร?

เรายินดีรับการมีส่วนร่วม! มีผู้คนมากมายทั่วโลกที่ช่วยกันทำให้ .NET ดียิ่งขึ้น

ทำตามคำแนะนำใน [docs/contributing.md](https://raw.githubusercontent.com/dotnet/aspire/main/docs/contributing.md) เพื่อทำงานกับโค้ดในที่เก็บนี้

## รายงานปัญหาด้านความปลอดภัยและบั๊กด้านความปลอดภัย

ปัญหาและบั๊กด้านความปลอดภัยควรรายงานแบบส่วนตัวทางอีเมลไปที่ Microsoft Security Response Center (MSRC) <secure@microsoft.com> โดยคุณควรได้รับการตอบกลับภายใน 24 ชั่วโมง หากไม่ได้รับการตอบกลับ กรุณาติดต่อซ้ำทางอีเมลเพื่อยืนยันว่าเราได้รับข้อความของคุณแล้ว ข้อมูลเพิ่มเติม รวมถึง MSRC PGP key สามารถดูได้ที่ [Security TechCenter](https://www.microsoft.com/msrc/faqs-report-an-issue) และคุณสามารถอ่านคำแนะนำนี้ได้ใน [Security doc](https://raw.githubusercontent.com/dotnet/aspire/main/SECURITY.md) ของ repo นี้

ดูข้อมูลเพิ่มเติมเกี่ยวกับ [Microsoft .NET Core และ ASP.NET Core Bug Bounty Program](https://www.microsoft.com/msrc/bounty-dot-net-core)

### หมายเหตุเกี่ยวกับ container ที่ใช้โดย .NET Aspire resource และ client integrations

ทีม .NET ไม่สามารถประเมิน container ของบุคคลที่สามที่เรามี API รองรับได้ว่าสอดคล้องกับความต้องการเฉพาะของลูกค้าหรือไม่

คุณควรประเมิน container ที่คุณเลือกใช้ร่วมกับ Aspire ด้วยตนเอง เพื่อให้แน่ใจว่าสอดคล้องกับข้อกำหนดด้านความปลอดภัยและกฎระเบียบต่างๆ ของคุณ, นายจ้าง หรือรัฐบาลของคุณ รวมทั้งข้อกำหนดเกี่ยวกับการเข้ารหัสและมาตรฐานอื่นๆ ที่อาจเกี่ยวข้อง

## .NET Foundation

.NET Aspire เป็นโครงการของ [.NET Foundation](https://www.dotnetfoundation.org/projects)

มีโครงการที่เกี่ยวข้องกับ .NET มากมายบน GitHub

* [.NET home repo](https://github.com/Microsoft/dotnet) - รวบรวมลิงก์ไปยังโครงการ .NET หลายร้อยโครงการ จาก Microsoft และชุมชน
* [ASP.NET Core home](https://docs.microsoft.com/aspnet/core) - จุดเริ่มต้นที่ดีในการเรียนรู้เกี่ยวกับ ASP.NET Core

โครงการนี้ใช้จรรยาบรรณที่กำหนดไว้โดย [Contributor Covenant](https://contributor-covenant.org) เพื่อชี้แจงพฤติกรรมที่คาดหวังในชุมชนของเรา ดูข้อมูลเพิ่มเติมได้ที่ [.NET Foundation Code of Conduct](https://www.dotnetfoundation.org/code-of-conduct)

## ใบอนุญาต

โค้ดใน repo นี้อยู่ภายใต้สัญญาอนุญาต [MIT](https://raw.githubusercontent.com/dotnet/aspire/main/LICENSE.TXT)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---