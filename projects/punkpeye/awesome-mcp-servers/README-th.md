# เซิร์ฟเวอร์ MCP ที่ยอดเยี่ยม [![Awesome](https://awesome.re/badge.svg)](https://awesome.re)

[![ไทย](https://img.shields.io/badge/Thai-Click-blue)](README-th.md)
[![English](https://img.shields.io/badge/English-Click-yellow)](README.md)
[![繁體中文](https://img.shields.io/badge/繁體中文-點擊查看-orange)](README-zh_TW.md)
[![简体中文](https://img.shields.io/badge/简体中文-点击查看-orange)](README-zh.md)
[![日本語](https://img.shields.io/badge/日本語-クリック-青)](README-ja.md)
[![한국어](https://img.shields.io/badge/한국어-클릭-yellow)](README-ko.md)
[![Português Brasileiro](https://img.shields.io/badge/Português_Brasileiro-Clique-green)](README-pt_BR.md)
[![Discord](https://img.shields.io/discord/1312302100125843476?logo=discord&label=discord)](https://glama.ai/mcp/discord)
[![Subreddit subscribers](https://img.shields.io/reddit/subreddit-subscribers/mcp?style=flat&logo=reddit&label=subreddit)](https://www.reddit.com/r/mcp/)

รายการคัดสรรเซิร์ฟเวอร์ Model Context Protocol (MCP) ที่ยอดเยี่ยม

* [MCP คืออะไร?](#what-is-mcp)
* [ไคลเอนต์](#clients)
* [คู่มือการใช้งาน](#tutorials)
* [ชุมชน](#community)
* [ตำนาน/คำอธิบายสัญลักษณ์](#legend)
* [การนำไปใช้งานเซิร์ฟเวอร์](#server-implementations)
* [เฟรมเวิร์ก](#frameworks)
* [เคล็ดลับ & เทคนิค](#tips-and-tricks)

## MCP คืออะไร?

[MCP](https://modelcontextprotocol.io/) คือโปรโตคอลแบบเปิดที่ช่วยให้โมเดล AI สามารถโต้ตอบกับทรัพยากรทั้งในเครื่องและระยะไกลได้อย่างปลอดภัยผ่านการนำไปใช้แบบมาตรฐานของเซิร์ฟเวอร์ รายการนี้จะเน้นไปที่เซิร์ฟเวอร์ MCP ที่พร้อมใช้งานในระดับ production และแบบทดลองที่ช่วยขยายขีดความสามารถของ AI ผ่านการเข้าถึงไฟล์ การเชื่อมต่อฐานข้อมูล การเชื่อมต่อ API และบริการเชิงบริบทอื่น ๆ

## ไคลเอนต์

ดูรายละเอียดเพิ่มเติมที่ [awesome-mcp-clients](https://github.com/punkpeye/awesome-mcp-clients/) และ [glama.ai/mcp/clients](https://glama.ai/mcp/clients)

> [!TIP]
> [Glama Chat](https://glama.ai/chat) คือไคลเอนต์ AI แบบมัลติโหมดที่รองรับ MCP และ [AI gateway](https://glama.ai/gateway)

## คู่มือการใช้งาน

* [Model Context Protocol (MCP) Quickstart](https://glama.ai/blog/2024-11-25-model-context-protocol-quickstart)
* [ตั้งค่าแอป Claude Desktop เพื่อใช้ฐานข้อมูล SQLite](https://youtu.be/wxCCzo9dGj0)

## ชุมชน

* [r/mcp Reddit](https://www.reddit.com/r/mcp)
* [Discord Server](https://glama.ai/mcp/discord)

## ตำนาน/คำอธิบายสัญลักษณ์

* 🎖️ – การนำไปใช้แบบทางการ
* ภาษาโปรแกรม
  * 🐍 – ฐานโค้ด Python
  * 📇 – ฐานโค้ด TypeScript (หรือ JavaScript)
  * 🏎️ – ฐานโค้ด Go
  * 🦀 – ฐานโค้ด Rust
  * #️⃣ - ฐานโค้ด C#
  * ☕ - ฐานโค้ด Java
  * 🌊 – ฐานโค้ด C/C++
* ขอบเขต
  * ☁️ - บริการคลาวด์
  * 🏠 - บริการภายในเครื่อง
  * 📟 - ระบบฝังตัว
* ระบบปฏิบัติการ
  * 🍎 – สำหรับ macOS
  * 🪟 – สำหรับ Windows
  * 🐧 - สำหรับ Linux

> [!NOTE]
> สับสนระหว่าง Local 🏠 กับ Cloud ☁️ หรือไม่?
> * ใช้ local เมื่อเซิร์ฟเวอร์ MCP ติดต่อกับซอฟต์แวร์ที่ติดตั้งในเครื่อง เช่น ควบคุมเบราว์เซอร์ Chrome
> * ใช้ network เมื่อเซิร์ฟเวอร์ MCP ติดต่อกับ API ระยะไกล เช่น weather API

## การนำไปใช้งานเซิร์ฟเวอร์

> [!NOTE]
> ขณะนี้เรามี [ไดเรกทอรีแบบเว็บ](https://glama.ai/mcp/servers) ที่ซิงค์กับรีโพซิทอรีแล้ว

* 🔗 - [ตัวรวม](#aggregators)
* 🎨 - [ศิลปะ & วัฒนธรรม](#art-and-culture)
* 📂 - [ระบบอัตโนมัติของเบราว์เซอร์](#browser-automation)
* ☁️ - [แพลตฟอร์มคลาวด์](#cloud-platforms)
* 👨‍💻 - [การรันโค้ด](#code-execution)
* 🤖 - [ตัวแทนเขียนโค้ด](#coding-agents)
* 🖥️ - [บรรทัดคำสั่ง](#command-line)
* 💬 - [การสื่อสาร](#communication)
* 👤 - [แพลตฟอร์มข้อมูลลูกค้า](#customer-data-platforms)
* 🗄️ - [ฐานข้อมูล](#databases)
* 📊 - [แพลตฟอร์มข้อมูล](#data-platforms)
* 🚚 - [การขนส่ง/ส่งของ](#delivery)
* 🛠️ - [เครื่องมือสำหรับนักพัฒนา](#developer-tools)
* 🧮 - [เครื่องมือ Data Science](#data-science-tools)
* 📟 - [ระบบฝังตัว](#embedded-system)
* 📂 - [ระบบไฟล์](#file-systems)
* 💰 - [การเงิน & ฟินเทค](#finance--fintech)
* 🎮 - [เกม](#gaming)
* 🧠 - [ความรู้ & หน่วยความจำ](#knowledge--memory)
* 🗺️ - [บริการระบุตำแหน่ง](#location-services)
* 🎯 - [การตลาด](#marketing)
* 📊 - [การตรวจสอบระบบ](#monitoring)
* 🎥 - [ประมวลผลมัลติมีเดีย](#multimedia-process)
* 🔎 - [ค้นหา & สกัดข้อมูล](#search)
* 🔒 - [ความปลอดภัย](#security)
* 🌐 - [โซเชียลมีเดีย](#social-media)
* 🏃 - [กีฬา](#sports)
* 🎧 - [การสนับสนุนและการจัดการบริการ](#support-and-service-management)
* 🌎 - [บริการแปลภาษา](#translation-services)
* 🎧 - [ข้อความเป็นเสียงพูด](#text-to-speech)
* 🚆 - [การเดินทางและขนส่ง](#travel-and-transportation)
* 🔄 - [การควบคุมเวอร์ชัน](#version-control)
* 🛠️ - [เครื่องมือและการผสานรวมอื่น ๆ](#other-tools-and-integrations)


### 🔗 <a name="aggregators"></a>แอกเกรเกเตอร์

เซิร์ฟเวอร์สำหรับเข้าถึงแอปและเครื่องมือจำนวนมากผ่านเซิร์ฟเวอร์ MCP เดียว

- [julien040/anyquery](https://github.com/julien040/anyquery) 🏎️ 🏠 ☁️ - คิวรีแอปมากกว่า 40 ตัวด้วยไฟล์ไบนารีเดียวโดยใช้ SQL สามารถเชื่อมต่อกับฐานข้อมูล PostgreSQL, MySQL, หรือ SQLite ได้เช่นกัน ออกแบบมาเพื่อเน้นการใช้งานในเครื่องและความเป็นส่วนตัว
- [metatool-ai/metatool-app](https://github.com/metatool-ai/metatool-app) 📇 ☁️ 🏠 🍎 🪟 🐧 - MetaMCP คือมิดเดิลแวร์ MCP เซิร์ฟเวอร์แบบรวมหนึ่งเดียวที่จัดการการเชื่อมต่อ MCP ของคุณผ่าน GUI
- [mindsdb/mindsdb](https://github.com/mindsdb/mindsdb) - เชื่อมต่อและรวมข้อมูลข้ามแพลตฟอร์มและฐานข้อมูลต่าง ๆ ด้วย [MindsDB เป็น MCP เซิร์ฟเวอร์เดียว](https://docs.mindsdb.com/mcp/overview)
- [glenngillen/mcpmcp-server](https://github.com/glenngillen/mcpmcp-server) ☁️ 📇 🍎 🪟 🐧 - รายชื่อ MCP เซิร์ฟเวอร์ เพื่อให้คุณสอบถามไคลเอนต์ว่าคุณสามารถใช้เซิร์ฟเวอร์ใดเพื่อปรับปรุงเวิร์กโฟลว์ประจำวันได้
- [wegotdocs/open-mcp](https://github.com/wegotdocs/open-mcp) 📇 🏠 🍎 🪟 🐧 - เปลี่ยน Web API ให้กลายเป็น MCP เซิร์ฟเวอร์ใน 10 วินาที และเพิ่มเข้ารีจิสทรีโอเพ่นซอร์ส: https://open-mcp.org
- [PipedreamHQ/pipedream](https://github.com/PipedreamHQ/pipedream/tree/master/modelcontextprotocol) ☁️ 🏠 - เชื่อมต่อกับ API กว่า 2,500 ตัว ด้วยเครื่องมือสำเร็จรูปมากกว่า 8,000 รายการ และบริหารจัดการเซิร์ฟเวอร์สำหรับผู้ใช้ของคุณในแอปของคุณเอง
- [VeriTeknik/pluggedin-mcp-proxy](https://github.com/VeriTeknik/pluggedin-mcp-proxy)  📇 🏠 - พร็อกซีเซิร์ฟเวอร์แบบรวมที่รวม MCP เซิร์ฟเวอร์หลายตัวไว้ในอินเทอร์เฟซเดียว พร้อมฟีเจอร์ตรวจสอบที่ครอบคลุม ให้การค้นหาและจัดการเครื่องมือ, พร้อม playground สำหรับดีบั๊กขณะสร้าง MCP เซิร์ฟเวอร์
- [tigranbs/mcgravity](https://github.com/tigranbs/mcgravity) 📇 🏠 - เครื่องมือพร็อกซีสำหรับรวม MCP เซิร์ฟเวอร์หลายตัวให้เป็น endpoint เดียว ขยายขนาดเครื่องมือ AI ของคุณด้วยการบาลานซ์โหลดคำขอเหมือนกับ Nginx สำหรับเว็บเซิร์ฟเวอร์
- [MetaMCP](https://github.com/metatool-ai/metatool-app) 📇 ☁️ 🏠 🍎 🪟 🐧 - MetaMCP คือมิดเดิลแวร์ MCP เซิร์ฟเวอร์แบบรวมหนึ่งเดียวที่จัดการการเชื่อมต่อ MCP ของคุณผ่าน GUI
- [WayStation-ai/mcp](https://github.com/waystation-ai/mcp) ☁️ 🍎 🪟 - เชื่อมต่อ Claude Desktop และ MCP โฮสต์อื่น ๆ กับแอปโปรดของคุณ (Notion, Slack, Monday, Airtable ฯลฯ) อย่างราบรื่นและปลอดภัย ใช้เวลาต่ำกว่า 90 วินาที
- [sxhxliang/mcp-access-point](https://github.com/sxhxliang/mcp-access-point) 📇 ☁️ 🏠 🍎 🪟 🐧 - เปลี่ยนเว็บเซอร์วิสให้เป็น MCP เซิร์ฟเวอร์ในคลิกเดียวโดยไม่ต้องแก้โค้ด
- [hamflx/imagen3-mcp](https://github.com/hamflx/imagen3-mcp) 📇 🏠 🪟 🍎 🐧 - เครื่องมือสร้างภาพขั้นสูงโดยใช้ Google’s Imagen 3.0 API ผ่าน MCP สร้างภาพคุณภาพสูงจากข้อความพร้อมควบคุมการถ่ายภาพ ศิลปะ และความสมจริงขั้นสูง
- [SureScaleAI/openai-gpt-image-mcp](https://github.com/SureScaleAI/openai-gpt-image-mcp) 📇 ☁️ - MCP เซิร์ฟเวอร์สำหรับสร้าง/แก้ไขภาพด้วย OpenAI GPT

### 🎨 <a name="art-and-culture"></a>ศิลปะและวัฒนธรรม

เข้าถึงและสำรวจคอลเลกชันศิลปะ มรดกทางวัฒนธรรม และฐานข้อมูลพิพิธภัณฑ์ ช่วยให้โมเดล AI ค้นหาและวิเคราะห์เนื้อหาศิลปะและวัฒนธรรม

- [abhiemj/manim-mcp-server](https://github.com/abhiemj/manim-mcp-server) 🐍 🏠 🪟 🐧 - MCP เซิร์ฟเวอร์แบบโลคอลที่สร้างแอนิเมชันโดยใช้ Manim
- [burningion/video-editing-mcp](https://github.com/burningion/video-editing-mcp) 🐍 - เพิ่ม วิเคราะห์ ค้นหา และสร้างวิดีโอเอดิตจากคลัง Video Jungle ของคุณ
- [cswkim/discogs-mcp-server](https://github.com/cswkim/discogs-mcp-server) 📇 ☁️ - MCP เซิร์ฟเวอร์สำหรับโต้ตอบกับ Discogs API
- [djalal/quran-mcp-server](https://github.com/djalal/quran-mcp-server) 📇 ☁️ MCP เซิร์ฟเวอร์สำหรับเข้าถึงข้อมูล Quran.com ผ่าน REST API v4 อย่างเป็นทางการ
- [mikechao/metmuseum-mcp](https://github.com/mikechao/metmuseum-mcp) 📇 ☁️ - การเชื่อมต่อ API คอลเลกชัน Metropolitan Museum of Art เพื่อค้นหาและแสดงงานศิลปะในคอลเลกชัน
- [r-huijts/rijksmuseum-mcp](https://github.com/r-huijts/rijksmuseum-mcp) 📇 ☁️ - การเชื่อมต่อ API Rijksmuseum สำหรับค้นหาผลงาน รายละเอียด และคอลเลกชัน
- [r-huijts/oorlogsbronnen-mcp](https://github.com/r-huijts/oorlogsbronnen-mcp) 📇 ☁️ - การเชื่อมต่อ API Oorlogsbronnen (แหล่งข้อมูลสงคราม) สำหรับเข้าถึงบันทึก ภาพถ่าย และเอกสารประวัติศาสตร์สงครามโลกครั้งที่ 2 จากเนเธอร์แลนด์ (1940-1945)
- [samuelgursky/davinci-resolve-mcp](https://github.com/samuelgursky/davinci-resolve-mcp) 🐍 - การเชื่อมต่อ MCP เซิร์ฟเวอร์สำหรับ DaVinci Resolve ที่มีเครื่องมือสำหรับตัดต่อวิดีโอ เกรดสี จัดการมีเดีย และควบคุมโปรเจกต์
- [yuna0x0/anilist-mcp](https://github.com/yuna0x0/anilist-mcp) 📇 ☁️ - MCP เซิร์ฟเวอร์ที่ผสานรวม AniList API สำหรับข้อมูลอนิเมะและมังงะ
- [diivi/aseprite-mcp](https://github.com/diivi/aseprite-mcp) 🐍 🏠 - MCP เซิร์ฟเวอร์ที่ใช้ Aseprite API สำหรับสร้างพิกเซลอาร์ต
- [omni-mcp/isaac-sim-mcp](https://github.com/omni-mcp/isaac-sim-mcp) 📇 ☁️ - MCP เซิร์ฟเวอร์และส่วนขยายที่ช่วยให้ควบคุม NVIDIA Isaac Sim, Lab, OpenUSD ด้วยภาษาอังกฤษธรรมชาติ
- [8enSmith/mcp-open-library](https://github.com/8enSmith/mcp-open-library) 📇 ☁️ - MCP เซิร์ฟเวอร์สำหรับ Open Library API ให้ AI assistant ค้นหาข้อมูลหนังสือได้
- [PatrickPalmer/MayaMCP](https://github.com/PatrickPalmer/MayaMCP) 🐍 🏠 - MCP เซิร์ฟเวอร์สำหรับ Autodesk Maya
- [cantian-ai/bazi-mcp](https://github.com/cantian-ai/bazi-mcp) 📇 🏠 ☁️ 🍎 🪟 - ให้บริการวิเคราะห์ดวงจีน (บาซื่อ) ที่ครอบคลุมและแม่นยำ

### 📂 <a name="browser-automation"></a>ระบบอัตโนมัติบนเบราว์เซอร์

การเข้าถึงเนื้อหาเว็บและความสามารถในการทำงานอัตโนมัติ ช่วยให้ค้นหา ดึงข้อมูล และประมวลผลเนื้อหาเว็บในรูปแบบที่เป็นมิตรกับ AI

- [xspadex/bilibili-mcp](https://github.com/xspadex/bilibili-mcp.git) 📇 🏠 - เครื่องมือบน FastMCP สำหรับดึงวิดีโอยอดนิยม Bilibili และเปิดผ่าน MCP มาตรฐาน
- [34892002/bilibili-mcp-js](https://github.com/34892002/bilibili-mcp-js) 📇 🏠 - MCP เซิร์ฟเวอร์ที่รองรับการค้นหาเนื้อหา Bilibili พร้อมตัวอย่าง LangChain และสคริปต์ทดสอบ
- [aircodelabs/grasp](https://github.com/aircodelabs/grasp) 📇 🏠 - เบราว์เซอร์ self-hosted ใช้ agent ที่มี MCP และ A2A ในตัว
- [automatalabs/mcp-server-playwright](https://github.com/Automata-Labs-team/MCP-Server-Playwright) 🐍 - MCP เซิร์ฟเวอร์สำหรับระบบอัตโนมัติบนเบราว์เซอร์ด้วย Playwright
- [blackwhite084/playwright-plus-python-mcp](https://github.com/blackwhite084/playwright-plus-python-mcp) 🐍 - MCP python server ใช้ Playwright สำหรับระบบอัตโนมัติบนเบราว์เซอร์ เหมาะกับ llm
- [browserbase/mcp-server-browserbase](https://github.com/browserbase/mcp-server-browserbase) 🎖️ 📇 - ระบบอัตโนมัติบนเบราว์เซอร์ในคลาวด์ (เช่น การนำทางเว็บ ดึงข้อมูล กรอกฟอร์ม ฯลฯ)
- [browsermcp/mcp](https://github.com/browsermcp/mcp) 📇 🏠 - ระบบอัตโนมัติ Chrome บนเครื่องของคุณ
- [co-browser/browser-use-mcp-server](https://github.com/co-browser/browser-use-mcp-server) 🐍 - browser-use แพ็คเกจเป็น MCP server พร้อม SSE transport มี dockerfile สำหรับรัน chromium ใน docker + vnc server
- [executeautomation/playwright-mcp-server](https://github.com/executeautomation/mcp-playwright) 📇 - MCP เซิร์ฟเวอร์ใช้ Playwright สำหรับระบบอัตโนมัติบนเบราว์เซอร์และ webscrapping
- [eyalzh/browser-control-mcp](https://github.com/eyalzh/browser-control-mcp) 📇 🏠 - MCP เซิร์ฟเวอร์ paired กับเบราว์เซอร์ extension ให้ LLM ควบคุมเบราว์เซอร์ผู้ใช้ (Firefox)
- [fradser/mcp-server-apple-reminders](https://github.com/FradSer/mcp-server-apple-reminders) 📇 🏠 🍎 - MCP เซิร์ฟเวอร์สำหรับโต้ตอบกับ Apple Reminders บน macOS
- [getrupt/ashra-mcp](https://github.com/getrupt/ashra-mcp) 🐍 🏠 - ดึงข้อมูลเชิงโครงสร้างจากเว็บไซต์ใดก็ได้ แค่สั่ง prompt รับเป็น JSON ทันที
- [kimtaeyoon83/mcp-server-youtube-transcript](https://github.com/kimtaeyoon83/mcp-server-youtube-transcript) 📇 ☁️ - ดึงซับไตเติลและถอดเสียง YouTube สำหรับวิเคราะห์ด้วย AI
- [kimtth/mcp-aoai-web-browsing](https://github.com/kimtth/mcp-aoai-web-browsing) 🐍 🏠 - เซิร์ฟเวอร์/ไคลเอนต์ MCP แบบ `minimal` ใช้ Azure OpenAI และ Playwright
- [microsoft/playwright-mcp](https://github.com/microsoft/playwright-mcp) - MCP เซิร์ฟเวอร์ Playwright อย่างเป็นทางการจาก Microsoft ให้ LLM โต้ตอบกับเว็บเพจผ่าน accessibility snapshots ที่มีโครงสร้าง
- [modelcontextprotocol/server-puppeteer](https://github.com/modelcontextprotocol/servers/tree/main/src/puppeteer) 📇 🏠 - ระบบอัตโนมัติบนเบราว์เซอร์สำหรับ scraping และโต้ตอบเว็บ
- [ndthanhdev/mcp-browser-kit](https://github.com/ndthanhdev/mcp-browser-kit) 📇 🏠 - MCP เซิร์ฟเวอร์สำหรับเบราว์เซอร์ที่รองรับ manifest v2
- [pskill9/web-search](https://github.com/pskill9/web-search) 📇 🏠 - MCP เซิร์ฟเวอร์ที่ให้ค้นหาเว็บฟรีโดยใช้ Google search ไม่ต้องใช้ API key
- [recursechat/mcp-server-apple-shortcuts](https://github.com/recursechat/mcp-server-apple-shortcuts) 📇 🏠 🍎 - MCP เซิร์ฟเวอร์สำหรับเชื่อมต่อ Apple Shortcuts

### ☁️ <a name="cloud-platforms"></a>แพลตฟอร์มคลาวด์

การผสานการทำงานกับบริการแพลตฟอร์มคลาวด์ ช่วยให้สามารถจัดการและโต้ตอบกับโครงสร้างพื้นฐานและบริการคลาวด์ได้

- [awslabs/mcp](https://github.com/awslabs/mcp) 🎖️ ☁️ - AWS MCP เซิร์ฟเวอร์สำหรับผสานการทำงานกับบริการและทรัพยากร AWS ได้อย่างราบรื่น
- [qiniu/qiniu-mcp-server](https://github.com/qiniu/qiniu-mcp-server) 🐍 ☁️ - MCP สร้างบน Qiniu Cloud รองรับการเข้าถึง Qiniu Cloud Storage, Media Processing ฯลฯ
- [alexbakers/mcp-ipfs](https://github.com/alexbakers/mcp-ipfs) 📇 ☁️ - อัปโหลดและจัดการ IPFS storage
- [reza-gholizade/k8s-mcp-server](https://github.com/reza-gholizade/k8s-mcp-server) 🏎️ ☁️/🏠 - MCP เซิร์ฟเวอร์สำหรับ Kubernetes ที่ให้เครื่องมือโต้ตอบคลัสเตอร์ผ่านอินเทอร์เฟซมาตรฐาน รวมถึง API discovery, การจัดการ resource, logs, metrics, events
- [VmLia/books-mcp-server](https://github.com/VmLia/books-mcp-server) 📇 ☁️ - MCP เซิร์ฟเวอร์สำหรับค้นหาหนังสือ สามารถใช้กับ MCP client เช่น Cherry Studio
- [alexei-led/aws-mcp-server](https://github.com/alexei-led/aws-mcp-server) 🐍 ☁️ - เซิร์ฟเวอร์น้ำหนักเบาแต่ทรงพลังสำหรับให้ AI assistant รัน AWS CLI, ใช้ Unix pipe, และ prompt template สำหรับงาน AWS ทั่วไปใน Docker รองรับ multi-architecture
- [alexei-led/k8s-mcp-server](https://github.com/alexei-led/k8s-mcp-server) 🐍 - เซิร์ฟเวอร์น้ำหนักเบาที่ให้ AI assistant รัน Kubernetes CLI (`kubectl`, `helm`, `istioctl`, `argocd`) อย่างปลอดภัยใน Docker รองรับ multi-architecture
- [aliyun/alibaba-cloud-ops-mcp-server](https://github.com/aliyun/alibaba-cloud-ops-mcp-server) 🎖️ 🐍 ☁️ - MCP เซิร์ฟเวอร์ที่ให้ AI assistant จัดการทรัพยากรบน Alibaba Cloud รองรับ ECS, Cloud Monitor, OOS และผลิตภัณฑ์คลาวด์ที่ใช้บ่อย
- [bright8192/esxi-mcp-server](https://github.com/bright8192/esxi-mcp-server) 🐍 ☁️ - MCP เซิร์ฟเวอร์สำหรับบริหารจัดการ VMware ESXi/vCenter ให้ REST API ง่าย ๆ สำหรับจัดการ VM
- [cloudflare/mcp-server-cloudflare](https://github.com/cloudflare/mcp-server-cloudflare) 🎖️ 📇 ☁️ - การผสานบริการ Cloudflare รวม Workers, KV, R2, D1
- [cyclops-ui/mcp-cyclops](https://github.com/cyclops-ui/mcp-cyclops) 🎖️ 🏎️ ☁️ - MCP เซิร์ฟเวอร์ให้ AI agent จัดการ Kubernetes ผ่าน abstraction ของ Cyclops
- [jedisct1/fastly-mcp-server](https://github.com/jedisct1/fastly-openapi-schema) 🎖️ 📇 ☁️ - การผสานกับบริการ Fastly
- [flux159/mcp-server-kubernetes](https://github.com/Flux159/mcp-server-kubernetes) 📇 ☁️/🏠 - Implementation ด้วย Typescript สำหรับจัดการ Kubernetes cluster เช่น pods, deployments, services
- [hardik-id/azure-resource-graph-mcp-server](https://github.com/hardik-id/azure-resource-graph-mcp-server) 📇 ☁️/🏠 - MCP server สำหรับค้นหาและวิเคราะห์ resource Azure จำนวนมากด้วย Azure Resource Graph ให้ AI assistant สำรวจและมอนิเตอร์โครงสร้างพื้นฐาน Azure
- [jdubois/azure-cli-mcp](https://github.com/jdubois/azure-cli-mcp) - Wrapper ของ Azure CLI ให้สั่งงาน Azure ได้โดยตรง
- [johnneerdael/netskope-mcp](https://github.com/johnneerdael/netskope-mcp) 🔒 ☁️ - MCP สำหรับเข้าถึง Netskope Private Access ทั้งหมดในสิ่งแวดล้อม Netskope พร้อมข้อมูล setup และตัวอย่าง LLM
- [manusa/Kubernetes MCP Server](https://github.com/manusa/kubernetes-mcp-server) 🏎️ 🏠 - MCP เซิร์ฟเวอร์ที่มีเครื่องมือเสริมสำหรับ OpenShift ให้ CRUD กับ resource Kubernetes ใดก็ได้ และเครื่องมือพิเศษสำหรับคลัสเตอร์
- [nwiizo/tfmcp](https://github.com/nwiizo/tfmcp) 🦀 🏠 - MCP เซิร์ฟเวอร์สำหรับ Terraform ให้ AI assistant จัดการสิ่งแวดล้อม Terraform ทั้งอ่าน config, วิเคราะห์ plan, apply, และจัดการ state
- [pulumi/mcp-server](https://github.com/pulumi/mcp-server) 🎖️ 📇 🏠 - MCP server สำหรับโต้ตอบกับ Pulumi ด้วย Pulumi Automation API และ Pulumi Cloud API ให้ MCP client สั่งงาน Pulumi เช่น ดู package, preview, deploy, ดู stack output ได้
- [rohitg00/kubectl-mcp-server](https://github.com/rohitg00/kubectl-mcp-server) 🐍 ☁️/🏠 - MCP เซิร์ฟเวอร์ Kubernetes ให้ AI assistant เช่น Claude, Cursor ฯลฯ โต้ตอบกับคลัสเตอร์ผ่านภาษาธรรมชาติ
- [strowk/mcp-k8s-go](https://github.com/strowk/mcp-k8s-go) 🏎️ ☁️/🏠 - จัดการ Kubernetes cluster ผ่าน MCP
- [thunderboltsid/mcp-nutanix](https://github.com/thunderboltsid/mcp-nutanix) 🏎️ 🏠/☁️ - MCP Server ด้วย Go สำหรับเชื่อมต่อ Nutanix Prism Central
- [trilogy-group/aws-pricing-mcp](https://github.com/trilogy-group/aws-pricing-mcp) 🏎️ ☁️/🏠 - รับข้อมูลราคา EC2 ล่าสุดในหนึ่งคำขอ เร็ว ใช้แค็ตตาล็อก AWS ที่แปลงไว้ล่วงหน้า
- [weibaohui/k8m](https://github.com/weibaohui/k8m) 🏎️ ☁️/🏠 - ให้ MCP สำหรับจัดการและปฏิบัติการ Kubernetes หลายคลัสเตอร์ มีอินเทอร์เฟซ เครื่องมือกว่า 50 ตัว ครอบคลุม DevOps และงานพัฒนา รองรับ resource มาตรฐานและ CRD
- [weibaohui/kom](https://github.com/weibaohui/kom) 🏎️ ☁️/🏠 - ให้ MCP สำหรับจัดการและปฏิบัติการ Kubernetes หลายคลัสเตอร์ ผสานเป็น SDK ในโปรเจกต์คุณเอง มีเครื่องมือกว่า 50 ตัว ครอบคลุม DevOps และงานพัฒนา รองรับ resource มาตรฐานและ CRD
- [wenhuwang/mcp-k8s-eye](https://github.com/wenhuwang/mcp-k8s-eye) 🏎️ ☁️/🏠 - MCP Server สำหรับการจัดการ Kubernetes และวิเคราะห์สุขภาพของคลัสเตอร์และแอปพลิเคชันของคุณ
- [erikhoward/adls-mcp-server](https://github.com/erikhoward/adls-mcp-server) 🐍 ☁️/🏠 - MCP Server สำหรับ Azure Data Lake Storage สามารถจัดการคอนเทนเนอร์, อ่าน/เขียน/อัปโหลด/ดาวน์โหลดไฟล์ในคอนเทนเนอร์ และจัดการ metadata ของไฟล์
- [silenceper/mcp-k8s](https://github.com/silenceper/mcp-k8s) 🏎️ ☁️/🏠 - MCP-K8S เป็นเครื่องมือบริหารทรัพยากร Kubernetes ที่ขับเคลื่อนด้วย AI ให้ผู้ใช้สามารถดำเนินการกับทรัพยากรใดๆ ในคลัสเตอร์ Kubernetes ผ่านการโต้ตอบด้วยภาษาธรรมชาติ รองรับทั้ง native resources (เช่น Deployment, Service) และ custom resources (CRD) โดยไม่ต้องจำคำสั่งที่ซับซ้อน เพียงอธิบายความต้องการ AI จะดำเนินการที่เกี่ยวข้องกับคลัสเตอร์ได้อย่างแม่นยำ เพิ่มความสะดวกในการใช้งาน Kubernetes อย่างมาก
- [redis/mcp-redis-cloud](https://github.com/redis/mcp-redis-cloud) 📇 ☁️ - จัดการทรัพยากร Redis Cloud ของคุณได้อย่างง่ายดายด้วยภาษาธรรมชาติ สร้างฐานข้อมูล, ตรวจสอบการสมัครสมาชิก และกำหนดค่าการปรับใช้คลาวด์ด้วยคำสั่งที่เรียบง่าย
- [portainer/portainer-mcp](https://github.com/portainer/portainer-mcp) 🏎️ ☁️/🏠 - MCP server อันทรงพลังที่ช่วยให้ผู้ช่วย AI โต้ตอบกับ Portainer instances ได้อย่างไร้รอยต่อ ให้การเข้าถึงการบริหารจัดการคอนเทนเนอร์ การดำเนินงานด้าน deployment และความสามารถในการตรวจสอบโครงสร้างพื้นฐานด้วยภาษาธรรมชาติ

### 👨‍💻 <a name="code-execution"></a>การรันโค้ด

เซิร์ฟเวอร์สำหรับรันโค้ด อนุญาตให้ LLMs สามารถรันโค้ดในสภาพแวดล้อมที่ปลอดภัย เช่น สำหรับตัวช่วยเขียนโค้ด

- [pydantic/pydantic-ai/mcp-run-python](https://github.com/pydantic/pydantic-ai/tree/main/mcp-run-python) 🐍 🏠- รันโค้ด Python ใน sandbox ที่ปลอดภัยผ่านการเรียกใช้เครื่องมือ MCP
- [yepcode/mcp-server-js](https://github.com/yepcode/mcp-server-js) 🎖️ 📇 ☁️ - รันโค้ดใดๆ ที่สร้างโดย LLM ใน sandbox ที่ปลอดภัยและปรับขนาดได้ และสร้างเครื่องมือ MCP ของคุณเองด้วย JavaScript หรือ Python พร้อมรองรับแพ็กเกจ NPM และ PyPI เต็มรูปแบบ
- [ckanthony/openapi-mcp](https://github.com/ckanthony/openapi-mcp) 🏎️ ☁️ - OpenAPI-MCP: Dockerized MCP Server ให้ AI agent ของคุณเข้าถึง API ใดๆ พร้อมเอกสาร API ที่มีอยู่
- [alfonsograziano/node-code-sandbox-mcp](https://github.com/alfonsograziano/node-code-sandbox-mcp) 📇 🏠 – Node.js MCP server ที่สร้าง sandbox แยกด้วย Docker สำหรับรัน JavaScript snippets พร้อมติดตั้ง npm dependency แบบ on-the-fly และลบออกอย่างสะอาด
- [r33drichards/mcp-js](https://github.com/r33drichards/mcp-js) 🦀 🏠 🐧 🍎 - sandbox สำหรับรันโค้ด Javascript ที่ใช้ v8 เพื่อแยกโค้ดและรัน javascript ที่สร้างโดย AI ในเครื่องอย่างปลอดภัย รองรับการ snapshot heap สำหรับเซสชันแบบ persistent

### 🤖 <a name="coding-agents"></a>Coding Agents

ตัวช่วยเขียนโค้ดเต็มรูปแบบที่เปิดให้ LLMs อ่าน แก้ไข และรันโค้ด รวมถึงแก้โจทย์โปรแกรมทั่วไปได้โดยอัตโนมัติ

- [oraios/serena](https://github.com/oraios/serena)🐍🏠 - Coding agent ที่มีคุณสมบัติครบถ้วนโดยใช้ symbolic code operations ผ่าน language servers
- [ezyang/codemcp](https://github.com/ezyang/codemcp) 🐍🏠 - Coding agent ที่รองรับการอ่าน เขียน และเครื่องมือ command line พื้นฐาน
- [doggybee/mcp-server-leetcode](https://github.com/doggybee/mcp-server-leetcode) 📇 ☁️ - MCP server ที่ให้โมเดล AI ค้นหา ดึงข้อมูล และแก้ปัญหา LeetCode รองรับการกรอง metadata โปรไฟล์ผู้ใช้ ส่งคำตอบ และเข้าถึงข้อมูลการแข่งขัน
- [jinzcdev/leetcode-mcp-server](https://github.com/jinzcdev/leetcode-mcp-server) 📇 ☁️ - MCP server ที่เปิดให้เข้าถึงโจทย์โปรแกรม, คำตอบ, ส่งโค้ด และข้อมูลสาธารณะของ **LeetCode** แบบอัตโนมัติ พร้อมรองรับการยืนยันตัวตนสำหรับฟีเจอร์เฉพาะผู้ใช้ (เช่น note) รองรับทั้ง `leetcode.com` (global) และ `leetcode.cn` (จีน)
- [juehang/vscode-mcp-server](https://github.com/juehang/vscode-mcp-server) 📇 🏠 - MCP Server ที่ให้ AI เช่น Claude อ่านโครงสร้างไดเรกทอรีใน workspace ของ VS Code เห็นปัญหาที่ลินเตอร์หรือ language server เจอ อ่านไฟล์โค้ด และแก้ไขได้
- [micl2e2/code-to-tree](https://github.com/micl2e2/code-to-tree) 🌊 🏠 📟 🐧 🪟 🍎 - MCP server แบบ single-binary ที่แปลงโค้ดต้นฉบับเป็น AST ไม่ว่าจะเป็นภาษาใดก็ตาม

### 🖥️ <a name="command-line"></a>Command Line

รันคำสั่ง ดึงผลลัพธ์ และโต้ตอบกับ shell และเครื่องมือ command line อื่นๆ

- [ferrislucas/iterm-mcp](https://github.com/ferrislucas/iterm-mcp) 🖥️ 🛠️ 💬 - Model Context Protocol server ที่ให้เข้าถึง iTerm สามารถรันคำสั่งและถามคำถามเกี่ยวกับสิ่งที่เห็นในเทอร์มินัล iTerm
- [g0t4/mcp-server-commands](https://github.com/g0t4/mcp-server-commands) 📇 🏠 - รันคำสั่งใดๆ ด้วยเครื่องมือ `run_command` และ `run_script`
- [maxim-saplin/mcp_safe_local_python_executor](https://github.com/maxim-saplin/mcp_safe_local_python_executor) - Interpreter Python ที่ปลอดภัย พัฒนาจาก HF Smolagents `LocalPythonExecutor`
- [MladenSU/cli-mcp-server](https://github.com/MladenSU/cli-mcp-server) 🐍 🏠 - Command line interface ที่มีความปลอดภัยสูงและกำหนดนโยบายความปลอดภัยเองได้
- [OthmaneBlial/term_mcp_deepseek](https://github.com/OthmaneBlial/term_mcp_deepseek) 🐍 🏠 - DeepSeek MCP-like Server สำหรับ Terminal
- [tumf/mcp-shell-server](https://github.com/tumf/mcp-shell-server) - เซิร์ฟเวอร์สำหรับรันคำสั่ง shell อย่างปลอดภัย รองรับ Model Context Protocol (MCP)
- [automateyournetwork/pyATS_MCP](https://github.com/automateyournetwork/pyATS_MCP) - เซิร์ฟเวอร์ Cisco pyATS เพื่อโต้ตอบกับอุปกรณ์เครือข่ายแบบ model-driven
- [wonderwhy-er/DesktopCommanderMCP](https://github.com/wonderwhy-er/DesktopCommanderMCP) 📇 🏠 🍎 🪟 🐧 - เครื่องมือสารพัดประโยชน์ที่สามารถจัดการ/รันโปรแกรม และอ่าน/เขียน/ค้นหา/แก้ไขไฟล์โค้ดและข้อความ
- [tufantunc/ssh-mcp](https://github.com/tufantunc/ssh-mcp) 📇 🏠 🐧 🪟 - MCP server ที่เปิดการควบคุม SSH สำหรับเซิร์ฟเวอร์ Linux และ Windows ผ่าน Model Context Protocol รันคำสั่ง shell ระยะไกลได้อย่างปลอดภัยด้วยรหัสผ่านหรือ SSH key

### 💬 <a name="communication"></a>การสื่อสาร

เชื่อมต่อกับแพลตฟอร์มสื่อสารเพื่อจัดการข้อความและดำเนินการในช่องทางต่างๆ เปิดให้โมเดล AI โต้ตอบกับเครื่องมือสื่อสารในทีม

- [AbdelStark/nostr-mcp](https://github.com/AbdelStark/nostr-mcp) ☁️ - Nostr MCP server ที่โต้ตอบกับ Nostr ได้ เช่น โพสต์โน้ต ฯลฯ
- [adhikasp/mcp-twikit](https://github.com/adhikasp/mcp-twikit) 🐍 ☁️ - โต้ตอบกับ Twitter search และ timeline
- [agentmail-toolkit/mcp](https://github.com/agentmail-to/agentmail-toolkit/tree/main/mcp) 🐍 💬 - MCP server สำหรับสร้างกล่องจดหมายชั่วคราวเพื่อส่ง รับ และดำเนินการกับอีเมล เราไม่ใช่ AI agent สำหรับอีเมล แต่เป็นอีเมลสำหรับ AI Agents
- [arpitbatra123/mcp-googletasks](https://github.com/arpitbatra123/mcp-googletasks) 📇 ☁️ - MCP server สำหรับเชื่อมต่อกับ Google Tasks API
- [carterlasalle/mac_messages_mcp](https://github.com/carterlasalle/mac_messages_mcp) 🏠 🍎 🚀 - MCP server ที่เชื่อมต่อกับฐานข้อมูล iMessage ของคุณอย่างปลอดภัยผ่าน Model Context Protocol (MCP) ให้ LLMs สอบถามและวิเคราะห์การสนทนาใน iMessage พร้อมระบบตรวจสอบหมายเลขโทรศัพท์ การจัดการไฟล์แนบ รายชื่อผู้ติดต่อ กลุ่มแชท และรองรับการส่ง/รับข้อความเต็มรูปแบบ
- [chaindead/telegram-mcp](https://github.com/chaindead/telegram-mcp) 🏎️ 🏠 - การเชื่อมต่อ Telegram API เพื่อเข้าถึงข้อมูลผู้ใช้ จัดการ dialog (chat, channel, group) ดึงข้อความ และจัดการสถานะการอ่าน
- [chigwell/telegram-mcp](https://github.com/chigwell/telegram-mcp) 🐍 🏠 - การเชื่อมต่อ Telegram API เพื่อเข้าถึงข้อมูลผู้ใช้ จัดการ dialog (chat, channel, group) ดึงข้อความ ส่งข้อความ และจัดการสถานะการอ่าน
- [elie222/inbox-zero](https://github.com/elie222/inbox-zero/tree/main/apps/mcp-server) 🐍 ☁️ - MCP server สำหรับ Inbox Zero เพิ่มความสามารถให้ Gmail เช่น ค้นหาว่าอีเมลใดต้องตอบกลับหรือ follow-up
- [gitmotion/ntfy-me-mcp](https://github.com/gitmotion/ntfy-me-mcp) 📇 ☁️ 🏠 - ntfy MCP server สำหรับส่ง/ดึงการแจ้งเตือน ntfy ไปยัง ntfy server ที่โฮสต์เองจาก AI Agents 📤 (รองรับ token auth ที่ปลอดภัย ฯลฯ - ใช้กับ npx หรือ docker!)
- [gotoolkits/wecombot](https://github.com/gotoolkits/mcp-wecombot-server.git) 🚀 ☁️ - MCP server สำหรับส่งข้อความหลากหลายประเภทไปยัง WeCom group robot
- [hannesrudolph/imessage-query-fastmcp-mcp-server](https://github.com/hannesrudolph/imessage-query-fastmcp-mcp-server) 🐍 🏠 🍎 - MCP server ที่ให้เข้าถึงฐานข้อมูล iMessage อย่างปลอดภัยผ่าน Model Context Protocol (MCP) ให้ LLMs สอบถามและวิเคราะห์การสนทนาใน iMessage พร้อมการตรวจสอบเบอร์โทรศัพท์และไฟล์แนบ
- [i-am-bee/acp-mcp](https://github.com/i-am-bee/acp-mcp) 🐍 💬 - MCP server ที่ทำหน้าที่เป็น adapter เชื่อมกับ [ACP](https://agentcommunicationprotocol.dev) ให้ ACP agents เชื่อมกับ MCP clients ได้อย่างไร้รอยต่อ
- [jagan-shanmugam/mattermost-mcp-host](https://github.com/jagan-shanmugam/mattermost-mcp-host) 🐍 🏠 - MCP server พร้อม MCP host สำหรับเข้าถึงทีม ช่องทาง และข้อความใน Mattermost โดย MCP host จะเป็น bot ใน Mattermost ที่เข้าถึง MCP servers ได้ตามที่กำหนดค่า
- [lharries/whatsapp-mcp](https://github.com/lharries/whatsapp-mcp) 🐍 🏎️ - MCP server สำหรับค้นหาข้อความ WhatsApp ส่วนตัว รายชื่อผู้ติดต่อ และส่งข้อความถึงบุคคลหรือกลุ่ม
- [line/line-bot-mcp-server](https://github.com/line/line-bot-mcp-server) 🎖 📇 ☁️ - MCP Server สำหรับเชื่อมต่อ LINE Official Account
- [MarkusPfundstein/mcp-gsuite](https://github.com/MarkusPfundstein/mcp-gsuite) 🐍 ☁️ - เชื่อมต่อกับ gmail และ Google Calendar
- [modelcontextprotocol/server-bluesky](https://github.com/keturiosakys/bluesky-context-server) 📇 ☁️ - เชื่อมต่อกับ Bluesky instance เพื่อสอบถามและโต้ตอบ
- [modelcontextprotocol/server-slack](https://github.com/modelcontextprotocol/servers/tree/main/src/slack) 📇 ☁️ - เชื่อมต่อกับ Slack workspace สำหรับการจัดการ channel และข้อความ
- [korotovsky/slack-mcp-server](https://github.com/korotovsky/slack-mcp-server) 📇 ☁️ - MCP server สำหรับ Slack Workspace ที่ทรงพลังที่สุด
- [sawa-zen/vrchat-mcp](https://github.com/sawa-zen/vrchat-mcp) - 📇 🏠 MCP server สำหรับโต้ตอบกับ VRChat API สามารถดึงข้อมูลเพื่อน โลก อวาตาร์ ฯลฯ ใน VRChat
- [takumi0706/google-calendar-mcp](https://github.com/takumi0706/google-calendar-mcp) 📇 ☁️ - MCP server สำหรับเชื่อมต่อกับ Google Calendar API พัฒนาด้วย TypeScript
- [teddyzxcv/ntfy-mcp](https://github.com/teddyzxcv/ntfy-mcp) - MCP server ที่แจ้งเตือนคุณบนโทรศัพท์ผ่าน ntfy
- [userad/didlogic_mcp](https://github.com/UserAd/didlogic_mcp) 🐍 ☁️ - MCP server สำหรับ [DIDLogic](https://didlogic.com) เพิ่มความสามารถในการจัดการ SIP endpoint หมายเลขโทรศัพท์ และปลายทาง
- [zcaceres/gtasks-mcp](https://github.com/zcaceres/gtasks-mcp) 📇 ☁️ - MCP server สำหรับจัดการ Google Tasks
- [InditexTech/mcp-teams-server](https://github.com/InditexTech/mcp-teams-server) 🐍 ☁️ - MCP server เชื่อมต่อ Microsoft Teams สำหรับการส่งข้อความ (อ่าน, โพสต์, mention, รายชื่อสมาชิกและ threads)
- [softeria/ms-365-mcp-server](https://github.com/softeria/ms-365-mcp-server) 📇 ☁️ - MCP server ที่เชื่อมต่อกับ Microsoft 365 suite ทั้งหมดผ่าน Graph API (รวมเมล ไฟล์ Excel ปฏิทิน)
- [YCloud-Developers/ycloud-whatsapp-mcp-server](https://github.com/YCloud-Developers/ycloud-whatsapp-mcp-server) 📇 🏠 - MCP server สำหรับ WhatsApp Business Platform โดย YCloud
- [jaipandya/producthunt-mcp-server](https://github.com/jaipandya/producthunt-mcp-server) 🐍 🏠 - MCP server สำหรับ Product Hunt โต้ตอบกับโพสต์เด่น ความคิดเห็น คอลเลกชัน ผู้ใช้ ฯลฯ

### 👤 <a name="customer-data-platforms"></a>Customer Data Platforms

ให้เข้าถึงโปรไฟล์ลูกค้าใน customer data platforms

- [iaptic/mcp-server-iaptic](https://github.com/iaptic/mcp-server-iaptic) 🎖️ 📇 ☁️ - เชื่อมต่อกับ [iaptic](https://www.iaptic.com) เพื่อสอบถามข้อมูลการซื้อของลูกค้า, ธุรกรรม และสถิติรายได้แอป
- [OpenDataMCP/OpenDataMCP](https://github.com/OpenDataMCP/OpenDataMCP) 🐍 ☁️ - เชื่อมต่อ Open Data ใดๆ กับ LLM ใดๆ ผ่าน Model Context Protocol
- [sergehuber/inoyu-mcp-unomi-server](https://github.com/sergehuber/inoyu-mcp-unomi-server) 📇 ☁️ - MCP server สำหรับเข้าถึงและอัปเดตโปรไฟล์บน Apache Unomi CDP server
- [tinybirdco/mcp-tinybird](https://github.com/tinybirdco/mcp-tinybird) 🐍 ☁️ - MCP server สำหรับโต้ตอบกับ Tinybird Workspace จาก MCP client ใดๆ
- [@antv/mcp-server-chart](https://github.com/antvis/mcp-server-chart) 🎖️ 📇 ☁️ - Model Context Protocol server สำหรับสร้างกราฟภาพด้วย [AntV](https://github.com/antvis)

### 🗄️ <a name="databases"></a>Databases

เข้าถึงฐานข้อมูลอย่างปลอดภัยพร้อมความสามารถในการตรวจสอบ schema รองรับการสอบถามและวิเคราะห์ข้อมูลด้วยการควบคุมความปลอดภัยที่กำหนดเอง เช่น read-only

- [Aiven-Open/mcp-aiven](https://github.com/Aiven-Open/mcp-aiven) - 🐍 ☁️ 🎖️ -  เข้าถึง [Aiven projects](https://go.aiven.io/mcp-server) และโต้ตอบกับบริการ PostgreSQL®, Apache Kafka®, ClickHouse® และ OpenSearch®
- [alexanderzuev/supabase-mcp-server](https://github.com/alexander-zuev/supabase-mcp-server) - Supabase MCP Server ที่รองรับการรันคำสั่ง SQL และเครื่องมือสำรวจฐานข้อมูล
- [aliyun/alibabacloud-tablestore-mcp-server](https://github.com/aliyun/alibabacloud-tablestore-mcp-server) ☕ 🐍 ☁️ - MCP service สำหรับ Tablestore มีฟีเจอร์เพิ่มเอกสาร ค้นหาเอกสารแบบ semantic ด้วยเวกเตอร์และสเกลาร์ รองรับ RAG และ serverless
- [benborla29/mcp-server-mysql](https://github.com/benborla/mcp-server-mysql) ☁️ 🏠 - การเชื่อมต่อ MySQL database ใน NodeJS พร้อมการตั้งค่าการเข้าถึงและตรวจสอบ schema ได้
- [bytebase/dbhub](https://github.com/bytebase/dbhub) 📇 🏠 – MCP server สำหรับฐานข้อมูลสากลที่รองรับฐานข้อมูลหลักๆ
- [c4pt0r/mcp-server-tidb](https://github.com/c4pt0r/mcp-server-tidb) 🐍 ☁️ - การเชื่อมต่อฐานข้อมูล TiDB พร้อมการตรวจสอบ schema และสอบถามข้อมูล
- [Canner/wren-engine](https://github.com/Canner/wren-engine) 🐍 🦀 🏠 - Semantic Engine สำหรับ Model Context Protocol (MCP) Clients และ AI Agents
- [centralmind/gateway](https://github.com/centralmind/gateway) 🏎️ 🏠 🍎 🪟 - MCP และ MCP SSE Server ที่สร้าง API อัตโนมัติจาก schema และข้อมูลฐานข้อมูล รองรับ PostgreSQL, Clickhouse, MySQL, Snowflake, BigQuery, Supabase
- [ChristianHinge/dicom-mcp](https://github.com/ChristianHinge/dicom-mcp) 🐍 ☁️ 🏠 - เชื่อมต่อ DICOM เพื่อสอบถาม อ่าน และย้ายภาพทางการแพทย์และรายงานจาก PACS และระบบที่รองรับ DICOM อื่นๆ
- [chroma-core/chroma-mcp](https://github.com/chroma-core/chroma-mcp) 🎖️ 🐍 ☁️ 🏠 - Chroma MCP server สำหรับเข้าถึง Chroma instance ทั้ง local และ cloud เพื่อการดึงข้อมูล
- [ClickHouse/mcp-clickhouse](https://github.com/ClickHouse/mcp-clickhouse) 🐍 ☁️ - การเชื่อมต่อฐานข้อมูล ClickHouse พร้อมการตรวจสอบ schema และสอบถามข้อมูล
- [confluentinc/mcp-confluent](https://github.com/confluentinc/mcp-confluent) 🐍 ☁️ - การเชื่อมต่อ Confluent สำหรับโต้ตอบกับ Confluent Kafka และ Confluent Cloud REST APIs
- [Couchbase-Ecosystem/mcp-server-couchbase](https://github.com/Couchbase-Ecosystem/mcp-server-couchbase) 🎖️ 🐍 ☁️ 🏠 - Couchbase MCP server ให้การเข้าถึงแบบรวมศูนย์ทั้ง Capella cloud และคลัสเตอร์ที่จัดการเอง สำหรับการดำเนินการกับเอกสาร, คำสั่ง SQL++ และการวิเคราะห์ข้อมูลด้วยภาษาธรรมชาติ
- [cr7258/elasticsearch-mcp-server](https://github.com/cr7258/elasticsearch-mcp-server) 🐍 🏠 - การใช้งาน MCP Server ที่ให้บริการการโต้ตอบกับ Elasticsearch
- [crystaldba/postgres-mcp](https://github.com/crystaldba/postgres-mcp) 🐍 🏠 - MCP server สำหรับการพัฒนาและปฏิบัติการ Postgres แบบครบวงจร พร้อมเครื่องมือสำหรับวิเคราะห์ประสิทธิภาพ การจูน และตรวจสอบสุขภาพระบบ
- [Dataring-engineering/mcp-server-trino](https://github.com/Dataring-engineering/mcp-server-trino) 🐍 ☁️ - Trino MCP Server สำหรับสืบค้นและเข้าถึงข้อมูลจาก Trino Clusters
- [tuannvm/mcp-trino](https://github.com/tuannvm/mcp-trino) 🏎️ ☁️ - การใช้งาน MCP server สำหรับ Trino ที่เขียนด้วย Go
- [designcomputer/mysql_mcp_server](https://github.com/designcomputer/mysql_mcp_server) 🐍 🏠 - การเชื่อมต่อฐานข้อมูล MySQL พร้อมการควบคุมการเข้าถึงที่กำหนดได้, ตรวจสอบ schema และแนวทางความปลอดภัยแบบครบถ้วน
- [wenb1n-dev/mysql_mcp_server_pro](https://github.com/wenb1n-dev/mysql_mcp_server_pro)  🐍 🏠 - รองรับ SSE, STDIO; ไม่ได้จำกัดแค่ฟังก์ชัน CRUD ของ MySQL; ยังรวมถึงความสามารถในการวิเคราะห์ข้อยกเว้นของฐานข้อมูล; ควบคุมสิทธิ์ฐานข้อมูลตามบทบาท; และง่ายต่อการขยายเครื่องมือโดยนักพัฒนาด้วยการปรับแต่ง
- [domdomegg/airtable-mcp-server](https://github.com/domdomegg/airtable-mcp-server) 📇 🏠 - การเชื่อมต่อฐานข้อมูล Airtable พร้อมการตรวจสอบ schema และความสามารถในการอ่าน/เขียนข้อมูล
- [edwinbernadus/nocodb-mcp-server](https://github.com/edwinbernadus/nocodb-mcp-server) 📇 ☁️ - การเชื่อมต่อฐานข้อมูล Nocodb พร้อมความสามารถในการอ่าน/เขียนข้อมูล
- [ergut/mcp-bigquery-server](https://github.com/ergut/mcp-bigquery-server) 📇 ☁️ - การใช้งานเซิร์ฟเวอร์สำหรับเชื่อมต่อกับ Google BigQuery ที่สามารถเข้าถึงและสืบค้นฐานข้อมูล BigQuery ได้โดยตรง
- [f4ww4z/mcp-mysql-server](https://github.com/f4ww4z/mcp-mysql-server) 📇 🏠 - การเชื่อมต่อฐานข้อมูล MySQL ด้วย Node.js ที่ให้การดำเนินการฐานข้อมูล MySQL อย่างปลอดภัย
- [fireproof-storage/mcp-database-server](https://github.com/fireproof-storage/mcp-database-server) 📇 ☁️ - ฐานข้อมูล ledger ของ Fireproof พร้อมการซิงค์หลายผู้ใช้
- [FreePeak/db-mcp-server](https://github.com/FreePeak/db-mcp-server) 🏎️ 🏠 – MCP server ประสิทธิภาพสูงสำหรับหลายฐานข้อมูล เขียนด้วย Golang รองรับ MySQL & PostgreSQL (NoSQL จะมาเร็วๆ นี้) รวมเครื่องมือในตัวสำหรับรันคำสั่ง, จัดการธุรกรรม, สำรวจ schema, สร้าง query และวิเคราะห์ประสิทธิภาพ พร้อมการเชื่อมต่อ Cursor อย่างราบรื่นเพื่อเสริม workflow ฐานข้อมูล
- [furey/mongodb-lens](https://github.com/furey/mongodb-lens) 📇 🏠 - MongoDB Lens: MCP Server ที่มีฟีเจอร์ครบถ้วนสำหรับฐานข้อมูล MongoDB
- [gannonh/firebase-mcp](https://github.com/gannonh/firebase-mcp) 🔥 ⛅️ - บริการ Firebase รวมถึง Auth, Firestore และ Storage
- [get-convex/convex-backend](https://stack.convex.dev/convex-mcp-server) 📇 ☁️ - การเชื่อมต่อฐานข้อมูล Convex เพื่อสำรวจตาราง, ฟังก์ชัน และรัน oneoff queries ([ที่มา](https://github.com/get-convex/convex-backend/blob/main/npm-packages/convex/src/cli/mcp.ts))
- [googleapis/genai-toolbox](https://github.com/googleapis/genai-toolbox) 🏎️ ☁️ - MCP server โอเพนซอร์สที่เชี่ยวชาญเครื่องมือสำหรับฐานข้อมูลที่ง่าย เร็ว และปลอดภัย
- [GreptimeTeam/greptimedb-mcp-server](https://github.com/GreptimeTeam/greptimedb-mcp-server) 🐍 🏠 - MCP Server สำหรับสืบค้น GreptimeDB
- [hannesrudolph/sqlite-explorer-fastmcp-mcp-server](https://github.com/hannesrudolph/sqlite-explorer-fastmcp-mcp-server) 🐍 🏠 - MCP server ที่ให้การเข้าถึงแบบอ่านอย่างปลอดภัยกับฐานข้อมูล SQLite ผ่าน Model Context Protocol (MCP) โดยสร้างด้วย FastMCP framework ที่ช่วยให้ LLMs สำรวจและสืบค้น SQLite ได้อย่างปลอดภัย พร้อมฟีเจอร์ตรวจสอบและ validate คำสั่ง query
- [idoru/influxdb-mcp-server](https://github.com/idoru/influxdb-mcp-server) 📇 ☁️ 🏠 - รันคำสั่ง query กับ InfluxDB OSS API v2
- [isaacwasserman/mcp-snowflake-server](https://github.com/isaacwasserman/mcp-snowflake-server) 🐍 ☁️ - การเชื่อมต่อกับ Snowflake พร้อมฟีเจอร์อ่านและ (เลือกได้) เขียนข้อมูล รวมถึงการติดตามข้อมูลเชิงลึก
- [joshuarileydev/supabase-mcp-server](https://github.com/joshuarileydev/supabase) - Supabase MCP Server สำหรับจัดการและสร้างโปรเจกต์และองค์กรใน Supabase
- [jovezhong/mcp-timeplus](https://github.com/jovezhong/mcp-timeplus) 🐍 ☁️ - MCP server สำหรับ Apache Kafka และ Timeplus สามารถแสดงรายการ Kafka topics, ดึงข้อความ Kafka, บันทึกข้อมูล Kafka ไว้ในเครื่อง และสืบค้นข้อมูลสตรีมมิ่งด้วย SQL ผ่าน Timeplus
- [KashiwaByte/vikingdb-mcp-server](https://github.com/KashiwaByte/vikingdb-mcp-server) 🐍 ☁️ - การเชื่อมต่อ VikingDB พร้อมการแนะนำ collection และ index, vector store และความสามารถในการค้นหา
- [kiliczsh/mcp-mongo-server](https://github.com/kiliczsh/mcp-mongo-server) 📇 🏠 - Model Context Protocol Server สำหรับ MongoDB
- [ktanaka101/mcp-server-duckdb](https://github.com/ktanaka101/mcp-server-duckdb) 🐍 🏠 - การเชื่อมต่อฐานข้อมูล DuckDB พร้อมความสามารถในการตรวจสอบ schema และสืบค้นข้อมูล
- [LucasHild/mcp-server-bigquery](https://github.com/LucasHild/mcp-server-bigquery) 🐍 ☁️ - การเชื่อมต่อฐานข้อมูล BigQuery พร้อมความสามารถในการตรวจสอบ schema และสืบค้นข้อมูล
- [quarkiverse/mcp-server-jdbc](https://github.com/quarkiverse/quarkus-mcp-servers/tree/main/jdbc) ☕ 🏠 - เชื่อมต่อกับฐานข้อมูลที่รองรับ JDBC ใดๆ และสามารถ query, insert, update, delete และอื่นๆ ได้
- [jparkerweb/mcp-sqlite](https://github.com/jparkerweb/mcp-sqlite) 📇 🏠 - Model Context Protocol (MCP) server ที่ให้ความสามารถในการโต้ตอบกับฐานข้อมูล SQLite อย่างครบวงจร
- [memgraph/mcp-memgraph](https://github.com/memgraph/mcp-memgraph) 🐍 🏠 - Memgraph MCP Server - รวมเครื่องมือสำหรับรัน query กับ Memgraph และ resource ของ schema
- [modelcontextprotocol/server-postgres](https://github.com/modelcontextprotocol/servers/tree/main/src/postgres) 📇 🏠 - การเชื่อมต่อฐานข้อมูล PostgreSQL พร้อมความสามารถในการตรวจสอบ schema และสืบค้นข้อมูล
- [modelcontextprotocol/server-sqlite](https://github.com/modelcontextprotocol/servers/tree/main/src/sqlite) 🐍 🏠 - ดำเนินการกับฐานข้อมูล SQLite พร้อมฟีเจอร์วิเคราะห์ในตัว
- [neo4j-contrib/mcp-neo4j](https://github.com/neo4j-contrib/mcp-neo4j) 🐍 🏠 - Model Context Protocol กับ Neo4j (รัน query, Knowledge Graph Memory, จัดการ Neo4j Aura Instances)
- [neondatabase/mcp-server-neon](https://github.com/neondatabase/mcp-server-neon) 📇 ☁️ — MCP Server สำหรับสร้างและจัดการฐานข้อมูล Postgres โดยใช้ Neon Serverless Postgres
- [niledatabase/nile-mcp-server](https://github.com/niledatabase/nile-mcp-server) MCP server สำหรับแพลตฟอร์ม Postgres ของ Nile - จัดการและสืบค้นฐานข้อมูล Postgres, tenants, users, auth โดยใช้ LLMs
- [openlink/mcp-server-odbc](https://github.com/OpenLinkSoftware/mcp-odbc-server) 🐍 🏠 - MCP server สำหรับการเชื่อมต่อ Database Management System (DBMS) ทั่วไปผ่าน Open Database Connectivity (ODBC) protocol
- [openlink/mcp-server-sqlalchemy](https://github.com/OpenLinkSoftware/mcp-sqlalchemy-server) 🐍 🏠 - MCP server สำหรับการเชื่อมต่อ DBMS ทั่วไปผ่าน SQLAlchemy โดยใช้ Python ODBC (pyodbc)
- [pab1it0/adx-mcp-server](https://github.com/pab1it0/adx-mcp-server) 🐍 ☁️ - สืบค้นและวิเคราะห์ฐานข้อมูล Azure Data Explorer
- [pab1it0/prometheus-mcp-server](https://github.com/pab1it0/prometheus-mcp-server) 🐍 ☁️ - สืบค้นและวิเคราะห์ Prometheus ระบบมอนิเตอร์โอเพนซอร์ส
- [prisma/prisma](https://github.com/prisma/prisma) 🐍 🏠 - ให้ LLMs มีความสามารถในการจัดการ Prisma Postgres database (เช่น สร้างฐานข้อมูลใหม่หรือรัน schema migrations)
- [qdrant/mcp-server-qdrant](https://github.com/qdrant/mcp-server-qdrant) 🐍 🏠 - Qdrant MCP server
- [QuantGeekDev/mongo-mcp](https://github.com/QuantGeekDev/mongo-mcp) 📇 🏠 - การเชื่อมต่อ MongoDB ที่ช่วยให้ LLMs โต้ตอบกับฐานข้อมูลได้โดยตรง
- [rashidazarang/airtable-mcp](https://github.com/rashidazarang/airtable-mcp) 🐍 ☁️ - เชื่อมต่อ AI tools กับ Airtable โดยตรง สืบค้น, สร้าง, อัปเดต, และลบข้อมูลด้วยภาษาธรรมชาติ ฟีเจอร์ประกอบด้วย การจัดการฐาน, การดำเนินการกับตาราง, การจัดการ schema, กรองข้อมูล และการย้ายข้อมูลผ่าน MCP interface มาตรฐาน
- [redis/mcp-redis](https://github.com/redis/mcp-redis) 🐍 🏠 - Redis MCP Server อย่างเป็นทางการ ให้ interface สำหรับจัดการและค้นหาข้อมูลใน Redis
- [runekaagaard/mcp-alchemy](https://github.com/runekaagaard/mcp-alchemy) 🐍 🏠 - การเชื่อมต่อฐานข้อมูลแบบ universal โดยใช้ SQLAlchemy รองรับ PostgreSQL, MySQL, MariaDB, SQLite, Oracle, MS SQL Server และอีกมากมาย พร้อมความสามารถในการตรวจสอบ schema และความสัมพันธ์ รวมถึงการวิเคราะห์ข้อมูลขนาดใหญ่
- [sirmews/mcp-pinecone](https://github.com/sirmews/mcp-pinecone) 🐍 ☁️ - การเชื่อมต่อ Pinecone พร้อมความสามารถในการค้นหาเวกเตอร์
- [skysqlinc/skysql-mcp](https://github.com/skysqlinc/skysql-mcp) 🎖️ ☁️ - MariaDB Cloud DB MCP server แบบ serverless พร้อมเครื่องมือสำหรับเปิด, ลบ, รัน SQL และใช้งาน AI agent ระดับฐานข้อมูลเพื่อ text-2-sql และสนทนาอย่างแม่นยำ
- [supabase-community/supabase-mcp](https://github.com/supabase-community/supabase-mcp) 🎖️ 📇 ☁️ - Supabase MCP server อย่างเป็นทางการเพื่อเชื่อมต่อ AI assistants โดยตรงกับ Supabase project ของคุณ และอนุญาตให้ดำเนินการ เช่น จัดการตาราง, ดึง config, และสืบค้นข้อมูล
- [TheRaLabs/legion-mcp](https://github.com/TheRaLabs/legion-mcp) 🐍 🏠 Universal database MCP server ที่รองรับฐานข้อมูลหลายประเภท เช่น PostgreSQL, Redshift, CockroachDB, MySQL, RDS MySQL, Microsoft SQL Server, BigQuery, Oracle DB และ SQLite
- [tradercjz/dolphindb-mcp-server](https://github.com/tradercjz/dolphindb-mcp-server) 🐍 ☁️ - การเชื่อมต่อฐานข้อมูล TDolphinDB พร้อมฟีเจอร์ตรวจสอบ schema และสืบค้นข้อมูล
- [weaviate/mcp-server-weaviate](https://github.com/weaviate/mcp-server-weaviate) 🐍 📇 ☁️ - MCP Server สำหรับเชื่อมต่อกับ Weaviate collection ของคุณในฐานะ knowledge base และใช้ Weaviate เป็น chat memory store
- [XGenerationLab/xiyan_mcp_server](https://github.com/XGenerationLab/xiyan_mcp_server) 📇 ☁️ — MCP server ที่รองรับการดึงข้อมูลจากฐานข้อมูลด้วยภาษาธรรมชาติ โดยใช้ XiyanSQL สำหรับแปลงข้อความเป็น SQL
- [xing5/mcp-google-sheets](https://github.com/xing5/mcp-google-sheets) 🐍 ☁️ - Model Context Protocol server สำหรับโต้ตอบกับ Google Sheets โดยให้เครื่องมือสำหรับสร้าง, อ่าน, อัปเดต และจัดการ spreadsheet ผ่าน Google Sheets API
- [freema/mcp-gsheets](https://github.com/freema/mcp-gsheets) 📇 ☁️ - MCP server สำหรับเชื่อมต่อ Google Sheets API พร้อมความสามารถด้านการอ่าน, เขียน, จัดรูปแบบ และจัดการแผ่นงานอย่างครบถ้วน
- [Zhwt/go-mcp-mysql](https://github.com/Zhwt/go-mcp-mysql) 🏎️ 🏠 – MySQL MCP server ใช้งานง่าย ไม่มี dependency สร้างด้วย Golang รองรับโหมดอ่านอย่างเดียวและตรวจสอบ schema ได้
- [ydb/ydb-mcp](https://github.com/ydb-platform/ydb-mcp) 🎖️ 🐍 ☁️ - MCP server สำหรับโต้ตอบกับฐานข้อมูล [YDB](https://ydb.tech)
- [zilliztech/mcp-server-milvus](https://github.com/zilliztech/mcp-server-milvus) 🐍 🏠 ☁️ - MCP Server สำหรับ Milvus / Zilliz ให้สามารถโต้ตอบกับฐานข้อมูลของคุณได้
- [openlink/mcp-server-jdbc](https://github.com/OpenLinkSoftware/mcp-jdbc-server) 🐍 🏠 - MCP server สำหรับการเชื่อมต่อ Database Management System (DBMS) ทั่วไปผ่าน Java Database Connectivity (JDBC) protocol
- [yincongcyincong/VictoriaMetrics-mcp-server](https://github.com/yincongcyincong/VictoriaMetrics-mcp-server) 🐍 🏠 - MCP server สำหรับโต้ตอบกับฐานข้อมูล VictoriaMetrics
- [hydrolix/mcp-hydrolix](https://github.com/hydrolix/mcp-hydrolix) 🎖️ 🐍 ☁️ - การเชื่อมต่อ Hydrolix time-series datalake พร้อมความสามารถในการสำรวจ schema และสืบค้นข้อมูลสำหรับ workflow ที่ใช้ LLM
- [davewind/mysql-mcp-server](https://github.com/dave-wind/mysql-mcp-server) 🏎️ 🏠 A – mysql mcp server โหมดอ่านอย่างเดียว ใช้งานง่าย สำหรับ cursor และ n8n...


### 📊 <a name="data-platforms"></a>แพลตฟอร์มข้อมูล

แพลตฟอร์มข้อมูลสำหรับการผสานรวมข้อมูล, แปลงข้อมูล และจัดการ pipeline

- [flowcore/mcp-flowcore-platform](https://github.com/flowcore-io/mcp-flowcore-platform) 🎖️ 📇 ☁️ 🏠 - โต้ตอบกับ Flowcore เพื่อดำเนินการต่างๆ, รับข้อมูล, วิเคราะห์, เชื่อมโยงข้อมูล และใช้ข้อมูลใดๆ ใน data cores ของคุณหรือใน data cores สาธารณะ ด้วยภาษามนุษย์
- [JordiNei/mcp-databricks-server](https://github.com/JordiNeil/mcp-databricks-server) 🐍 ☁️ - เชื่อมต่อกับ Databricks API ให้ LLMs รันคำสั่ง SQL, แสดงรายการ jobs และตรวจสอบสถานะ job ได้
- [yashshingvi/databricks-genie-MCP](https://github.com/yashshingvi/databricks-genie-MCP) 🐍 ☁️ - เซิร์ฟเวอร์ที่เชื่อมต่อกับ Databricks Genie API ให้ LLMs ถามด้วยภาษาธรรมชาติ, รัน SQL และโต้ตอบกับ conversational agent ของ Databricks ได้
- [jwaxman19/qlik-mcp](https://github.com/jwaxman19/qlik-mcp) 📇 ☁️ - MCP Server สำหรับ Qlik Cloud API ที่ให้สืบค้นแอปพลิเคชัน, แผ่นงาน, และดึงข้อมูลจาก visualization พร้อมระบบรับรองตัวตนและจำกัดอัตราการใช้งาน
- [keboola/keboola-mcp-server](https://github.com/keboola/keboola-mcp-server) 🐍 - โต้ตอบกับ Keboola Connection Data Platform โดยให้เครื่องมือสำหรับแสดงรายการและเข้าถึงข้อมูลจาก Keboola Storage API
- [dbt-labs/dbt-mcp](https://github.com/dbt-labs/dbt-mcp) 🎖️ 🐍 🏠 ☁️ - MCP server อย่างเป็นทางการสำหรับ [dbt (data build tool)](https://www.getdbt.com/product/what-is-dbt) ให้การเชื่อมต่อกับ dbt Core/Cloud CLI, ค้นหา metadata โปรเจกต์, ข้อมูล model และความสามารถในการสืบค้น semantic layer
- [mattijsdp/dbt-docs-mcp](https://github.com/mattijsdp/dbt-docs-mcp) 🐍 🏠 - MCP server สำหรับผู้ใช้ dbt-core (OSS) เนื่องจาก dbt MCP อย่างเป็นทางการรองรับเฉพาะ dbt Cloud รองรับ metadata โปรเจกต์, lineage ระดับ model และ column, และเอกสาร dbt

### 💻 <a name="developer-tools"></a>เครื่องมือสำหรับนักพัฒนา

เครื่องมือและการผสานรวมที่ช่วยเสริมประสบการณ์การพัฒนาและการจัดการสภาพแวดล้อม

- [Pratyay/mac-monitor-mcp](https://github.com/Pratyay/mac-monitor-mcp) 🐍 🏠 🍎 - ตรวจจับ process ที่ใช้ทรัพยากรมากบน macOS และให้ข้อเสนอแนะในการปรับปรุงประสิทธิภาพ
- [21st-dev/Magic-MCP](https://github.com/21st-dev/magic-mcp) - สร้าง UI components แบบ crafted ที่ได้รับแรงบันดาลใจจากวิศวกรออกแบบระดับแนวหน้าของ 21st.dev
- [Hypersequent/qasphere-mcp](https://github.com/Hypersequent/qasphere-mcp) 🎖️ 📇 ☁️ - เชื่อมต่อกับระบบจัดการทดสอบ [QA Sphere](https://qasphere.com/) ให้ LLMs ค้นหา, สรุป และโต้ตอบกับ test cases ได้โดยตรงจาก AI-powered IDEs
- [admica/FileScopeMCP](https://github.com/admica/FileScopeMCP) 🐍 📇 🦀 - วิเคราะห์ codebase ของคุณเพื่อระบุไฟล์สำคัญตามความสัมพันธ์ dependency สร้าง diagram และคะแนนความสำคัญ เพื่อช่วย AI assistant เข้าใจโค้ด
- [ambar/simctl-mcp](https://github.com/ambar/simctl-mcp) 📇 🏠 🍎 การใช้งาน MCP server สำหรับควบคุม iOS Simulator
- [api7/apisix-mcp](https://github.com/api7/apisix-mcp) 🎖️ 📇 🏠 MCP Server ที่รองรับการสืบค้นและจัดการทุก resource ใน [Apache APISIX](https://github.com/apache/apisix)
- [ArchAI-Labs/fastmcp-sonarqube-metrics](https://github.com/ArchAI-Labs/fastmcp-sonarqube-metrics) 🐍 🏠 🪟 🐧 🍎 - MCP server ที่ให้เครื่องมือสำหรับดึงข้อมูลโครงการ SonarQube เช่น metrics (ปัจจุบันและย้อนหลัง), ปัญหา, สถานะสุขภาพ
- [automation-ai-labs/mcp-link](https://github.com/automation-ai-labs/mcp-link) 🏎️ 🏠 - ผสาน API ใดๆ กับ AI Agents ได้อย่างไร้รอยต่อ (พร้อม OpenAPI Schema)
- [azer/react-analyzer-mcp](https://github.com/azer/react-analyzer-mcp) 📇 🏠 - วิเคราะห์โค้ด React ในเครื่อง สร้างเอกสาร/llm.txt สำหรับทั้งโปรเจกต์ในครั้งเดียว
- [davidlin2k/pox-mcp-server](https://github.com/davidlin2k/pox-mcp-server) 🐍 🏠 - MCP server สำหรับ POX SDN controller ที่ให้ความสามารถด้าน network control และ management
- [CodeLogicIncEngineering/codelogic-mcp-server](https://github.com/CodeLogicIncEngineering/codelogic-mcp-server) 🎖️ 🐍 ☁️ 🍎 🪟 🐧 - MCP server อย่างเป็นทางการสำหรับ CodeLogic ให้เข้าถึงเครื่องมือวิเคราะห์ dependency โค้ด, วิเคราะห์ความเสี่ยงเชิงสถาปัตยกรรม, และประเมินผลกระทบ
- [Comet-ML/Opik-MCP](https://github.com/comet-ml/opik-mcp) 🎖️ 📇 ☁️ 🏠 - ใช้ภาษาธรรมชาติสำรวจ observability, trace, และ monitoring data ของ LLM ที่เก็บโดย Opik
- [CircleCI/mcp-server-circleci](https://github.com/CircleCI-Public/mcp-server-circleci) 📇 ☁️ ให้ AI Agents แก้ไขปัญหา build failures จาก CircleCI ได้
- [currents-dev/currents-mcp](https://github.com/currents-dev/currents-mcp) 🎖️ 📇 ☁️ ให้ AI Agents แก้ไขปัญหา Playwright test failures ที่รายงานไปยัง [Currents](https://currents.dev)
- [delano/postman-mcp-server](https://github.com/delano/postman-mcp-server) 📇 ☁️ - โต้ตอบกับ [Postman API](https://www.postman.com/postman/postman-public-workspace/)
- [flipt-io/mcp-server-flipt](https://github.com/flipt-io/mcp-server-flipt) 📇 🏠 - ให้ AI assistants โต้ตอบกับ feature flag ใน [Flipt](https://flipt.io)
- [GLips/Figma-Context-MCP](https://github.com/GLips/Figma-Context-MCP) 📇 🏠 - ให้ coding agent เข้าถึงข้อมูล Figma ได้โดยตรงเพื่อช่วยให้ implement design ได้ในครั้งเดียว
- [gofireflyio/firefly-mcp](https://github.com/gofireflyio/firefly-mcp) 🎖️ 📇 ☁️ - ผสาน, ค้นหา, จัดการ และกำหนดทรัพยากรคลาวด์ด้วย [Firefly](https://firefly.ai)
- [Govcraft/rust-docs-mcp-server](https://github.com/Govcraft/rust-docs-mcp-server) 🦀 🏠 - ให้ LLMs เข้าถึงเอกสาร Rust crate เฉพาะผ่าน MCP tool โดยใช้ semantic search (embeddings) และ LLM summarization
- [haris-musa/excel-mcp-server](https://github.com/haris-musa/excel-mcp-server) 🐍 🏠 - เซิร์ฟเวอร์สำหรับจัดการ Excel เช่น สร้าง workbook, ดำเนินการข้อมูล, จัดรูปแบบ และฟีเจอร์ขั้นสูง (กราฟ, pivot table, สูตร)
- [higress-group/higress-ops-mcp-server](https://github.com/higress-group/higress-ops-mcp-server) 🐍 🏠 - เซิร์ฟเวอร์ MCP ที่ให้เครื่องมือครบครันในการจัดการการตั้งค่าและการดำเนินงานของ [Higress](https://github.com/alibaba/higress) เกตเวย์
- [hijaz/postmancer](https://github.com/hijaz/postmancer) 📇 🏠 - เซิร์ฟเวอร์ MCP สำหรับแทนที่ Rest Clients เช่น Postman/Insomnia โดยให้ LLM ของคุณสามารถจัดเก็บและใช้ชุด api ได้
- [hloiseaufcms/mcp-gopls](https://github.com/hloiseaufcms/mcp-gopls) 🏎️ 🏠 - เซิร์ฟเวอร์ MCP สำหรับโต้ตอบกับ [Go's Language Server Protocol (gopls)](https://github.com/golang/tools/tree/master/gopls) และใช้ประโยชน์จากฟีเจอร์วิเคราะห์โค้ด Go ขั้นสูง
- [hungthai1401/bruno-mcp](https://github.com/hungthai1401/bruno-mcp) 📇 🏠 - เซิร์ฟเวอร์ MCP สำหรับโต้ตอบกับ [Bruno API Client](https://www.usebruno.com/)
- [hyperb1iss/droidmind](https://github.com/hyperb1iss/droidmind) 🐍 🏠 - ควบคุมอุปกรณ์ Android ด้วย AI ผ่าน MCP สามารถควบคุมอุปกรณ์ ดีบัก วิเคราะห์ระบบ และอัตโนมัติ UI พร้อมกรอบความปลอดภัยครบถ้วน
- [XixianLiang/HarmonyOS-mcp-server](https://github.com/XixianLiang/HarmonyOS-mcp-server) 🐍 🏠 - ควบคุมอุปกรณ์ HarmonyOS-next ด้วย AI ผ่าน MCP รองรับการควบคุมอุปกรณ์และอัตโนมัติ UI
- [IlyaGulya/gradle-mcp-server](https://github.com/IlyaGulya/gradle-mcp-server) 🏠 - รวมระบบ Gradle โดยใช้ Gradle Tooling API เพื่อสำรวจโปรเจกต์ รันงาน และทดสอบพร้อมรายงานผลแต่ละเทสต์
- [InhiblabCore/mcp-image-compression](https://github.com/InhiblabCore/mcp-image-compression) 🐍 🏠 - เซิร์ฟเวอร์ MCP สำหรับบีบอัดรูปภาพหลากหลายฟอร์แมตในเครื่อง
- [isaacphi/mcp-language-server](https://github.com/isaacphi/mcp-language-server) 🏎️ 🏠 - MCP Language Server ช่วยให้ไคลเอนต์ที่รองรับ MCP นำทางฐานโค้ดได้สะดวกขึ้น ด้วยเครื่องมือ semantic เช่น ดู definition, references, เปลี่ยนชื่อ, และตรวจสอบโค้ด
- [ios-simulator-mcp](https://github.com/joshuayoes/ios-simulator-mcp) 📇 🏠 🍎 - เซิร์ฟเวอร์ Model Context Protocol (MCP) สำหรับโต้ตอบกับ iOS simulators สามารถดึงข้อมูล ควบคุม UI และตรวจสอบองค์ประกอบ UI
- [InditexTech/mcp-server-simulator-ios-idb](https://github.com/InditexTech/mcp-server-simulator-ios-idb) 📇 🏠 🍎 - เซิร์ฟเวอร์ Model Context Protocol (MCP) ที่ให้ LLM โต้ตอบกับ iOS simulators (iPhone, iPad ฯลฯ) ด้วยคำสั่งภาษาธรรมชาติ
- [IvanAmador/vercel-ai-docs-mcp](https://github.com/IvanAmador/vercel-ai-docs-mcp) 📇 🏠 - เซิร์ฟเวอร์ Model Context Protocol (MCP) ที่ให้ฟีเจอร์ค้นหาและสอบถามข้อมูลเอกสาร Vercel AI SDK ด้วย AI
- [j4c0bs/mcp-server-sql-analyzer](https://github.com/j4c0bs/mcp-server-sql-analyzer) 🐍 - เซิร์ฟเวอร์ MCP ที่วิเคราะห์ SQL, ตรวจสอบไวยากรณ์ และแปลง dialect โดยใช้ [SQLGlot](https://github.com/tobymao/sqlglot)
- [jasonjmcghee/claude-debugs-for-you](https://github.com/jasonjmcghee/claude-debugs-for-you) 📇 🏠 - MCP Server และ VS Code Extension ที่รองรับการดีบักอัตโนมัติด้วย breakpoints และประเมิน expression (ไม่ขึ้นกับภาษา)
- [jetbrains/mcpProxy](https://github.com/JetBrains/mcpProxy) 🎖️ 📇 🏠 - เชื่อมต่อกับ JetBrains IDE
- [qainsights/jmeter-mcp-server](https://github.com/QAInsights/jmeter-mcp-server) 🐍 🏠 - JMeter MCP Server สำหรับทดสอบประสิทธิภาพ
- [Jktfe/serveMyAPI](https://github.com/Jktfe/serveMyAPI) 📇 🏠 🍎 - เซิร์ฟเวอร์ MCP ส่วนตัวสำหรับจัดเก็บและเข้าถึง API keys อย่างปลอดภัยข้ามโปรเจกต์โดยใช้ macOS Keychain
- [joshuarileydev/app-store-connect-mcp-server](https://github.com/JoshuaRileyDev/app-store-connect-mcp-server) 📇 🏠 - เซิร์ฟเวอร์ MCP สำหรับสื่อสารกับ App Store Connect API สำหรับนักพัฒนา iOS
- [joshuarileydev/simulator-mcp-server](https://github.com/JoshuaRileyDev/simulator-mcp-server) 📇 🏠 - เซิร์ฟเวอร์ MCP สำหรับควบคุม iOS Simulators
- [qainsights/k6-mcp-server](https://github.com/QAInsights/k6-mcp-server) 🐍 🏠 - Grafana k6 MCP Server สำหรับทดสอบประสิทธิภาพ
- [lamemind/mcp-server-multiverse](https://github.com/lamemind/mcp-server-multiverse) 📇 🏠 🛠️ - มิดเดิลแวร์เซิร์ฟเวอร์ที่อนุญาตให้ MCP servers หลายอินสแตนซ์อยู่ร่วมกันอย่างเป็นอิสระ พร้อม namespace และการตั้งค่าที่แตกต่างกัน
- [langfuse/mcp-server-langfuse](https://github.com/langfuse/mcp-server-langfuse) 🐍 🏠 - MCP server เพื่อเข้าถึงและจัดการ prompt ของแอป LLM ที่สร้างด้วย [Langfuse]([https://langfuse.com/](https://langfuse.com/docs/prompts/get-started)) Prompt Management
- [mobile-next/mobile-mcp](https://github.com/mobile-next/mobile-mcp) 📇 🏠 🐧 🍎 - MCP Server สำหรับอัตโนมัติแอป/อุปกรณ์ Android/iOS การพัฒนา และดึงข้อมูลแอป รองรับ Simulator/Emulator/อุปกรณ์จริง เช่น iPhone, Google Pixel, Samsung
- [qainsights/locust-mcp-server](https://github.com/QAInsights/locust-mcp-server) 🐍 🏠 - Locust MCP Server สำหรับทดสอบประสิทธิภาพ
- [mrexodia/user-feedback-mcp](https://github.com/mrexodia/user-feedback-mcp) 🐍 🏠 - MCP Server ง่ายๆ เพื่อเปิดใช้งาน human-in-the-loop workflow ในเครื่องมือเช่น Cline และ Cursor
- [narumiruna/gitingest-mcp](https://github.com/narumiruna/gitingest-mcp) 🐍 🏠 - เซิร์ฟเวอร์ MCP ที่ใช้ [gitingest](https://github.com/cyclotruc/gitingest) เพื่อเปลี่ยน Git repository ใดๆ เป็น digest ข้อความของ codebase
- [OctoMind-dev/octomind-mcp](https://github.com/OctoMind-dev/octomind-mcp) 📇 ☁️ - ให้ AI agent ที่คุณชื่นชอบสร้างและรันทดสอบ [Octomind](https://www.octomind.dev/) แบบ end-to-end จากฐานโค้ดหรือแหล่งข้อมูลอื่นๆ เช่น Jira, Slack หรือ TestRail
- [kadykov/mcp-openapi-schema-explorer](https://github.com/kadykov/mcp-openapi-schema-explorer) 📇 ☁️ 🏠 - เข้าถึง OpenAPI/Swagger specs อย่างประหยัด token ผ่าน MCP Resources
- [pskill9/website-downloader](https://github.com/pskill9/website-downloader) 🗄️ 🚀 - เซิร์ฟเวอร์ MCP นี้ให้เครื่องมือดาวน์โหลดเว็บไซต์ทั้งเว็บโดยใช้ wget รักษาโครงสร้างเว็บและแปลงลิงก์ให้ใช้แบบ local ได้
- [utensils/mcp-nixos](https://github.com/utensils/mcp-nixos) 🐍 🏠 - MCP server ให้ข้อมูล NixOS packages, ตัวเลือกระบบ, Home Manager และ nix-darwin บน macOS อย่างแม่นยำ เพื่อกัน AI มโน
- [QuantGeekDev/docker-mcp](https://github.com/QuantGeekDev/docker-mcp) 🏎️ 🏠 - จัดการและดำเนินการ Docker container ผ่าน MCP
- [ckreiling/mcp-server-docker](https://github.com/ckreiling/mcp-server-docker) 🐍 🏠 - เชื่อมต่อกับ Docker เพื่อจัดการ container, image, volume และ network
- [r-huijts/xcode-mcp-server](https://github.com/r-huijts/xcode-mcp-server) 📇 🏠 🍎 - Xcode integration สำหรับจัดการโปรเจกต์ ดำเนินการกับไฟล์ และอัตโนมัติ build
- [ReAPI-com/mcp-openapi](https://github.com/ReAPI-com/mcp-openapi) 📇 🏠 - MCP server ให้ LLM เข้าใจทุกอย่างเกี่ยวกับ OpenAPI spec ของคุณ เพื่อค้นหา อธิบาย และสร้างโค้ด/ mock data
- [Rootly-AI-Labs/Rootly-MCP-server](https://github.com/Rootly-AI-Labs/Rootly-MCP-server) 🎖️ 🐍 ☁️ 🍎 - MCP server สำหรับแพลตฟอร์มจัดการเหตุการณ์ [Rootly](https://rootly.com/)
- [sammcj/mcp-package-version](https://github.com/sammcj/mcp-package-version) 📇 🏠 - MCP Server ที่ช่วยให้ LLM แนะนำเวอร์ชันแพ็กเกจล่าสุดที่เสถียรเมื่อเขียนโค้ด
- [sapientpants/sonarqube-mcp-server](https://github.com/sapientpants/sonarqube-mcp-server) 🦀 ☁️ 🏠 - เซิร์ฟเวอร์ Model Context Protocol (MCP) สำหรับเชื่อมต่อกับ SonarQube เพื่อให้ผู้ช่วย AI เข้าถึง metric คุณภาพโค้ด, ปัญหา, และสถานะ quality gate
- [SDGLBL/mcp-claude-code](https://github.com/SDGLBL/mcp-claude-code) 🐍 🏠 - การนำความสามารถของ Claude Code มาใช้กับ MCP ให้ AI เข้าใจ/แก้ไข/วิเคราะห์โค้ดและโปรเจกต์ได้ พร้อมเครื่องมือครบครัน
- [snaggle-ai/openapi-mcp-server](https://github.com/snaggle-ai/openapi-mcp-server) 🏎️ 🏠 - เชื่อมต่อ HTTP/REST API server ใดๆ ด้วย Open API spec (v3)
- [stass/lldb-mcp](https://github.com/stass/lldb-mcp) 🐍 🏠 🐧 🍎 - MCP server สำหรับ LLDB เปิดให้ AI วิเคราะห์ไฟล์ไบนารีและ core, ดีบัก, ถอดรหัส
- [TencentEdgeOne/edgeone-pages-mcp](https://github.com/TencentEdgeOne/edgeone-pages-mcp) 📇 ☁️ - บริการ MCP สำหรับ deploy เนื้อหา HTML ไปยัง EdgeOne Pages และรับ URL สาธารณะ
- [tumf/mcp-text-editor](https://github.com/tumf/mcp-text-editor) 🐍 🏠 - ตัวแก้ไขไฟล์ข้อความแบบ line-oriented ออกแบบให้เหมาะกับ LLM ใช้ token น้อยโดยเข้าถึงไฟล์บางส่วนได้อย่างมีประสิทธิภาพ
- [vivekvells/mcp-pandoc](https://github.com/vivekVells/mcp-pandoc) 🗄️ 🚀 - MCP server สำหรับแปลงรูปแบบเอกสารด้วย Pandoc อย่างไร้รอยต่อ รองรับ Markdown, HTML, PDF, DOCX (.docx), csv ฯลฯ
- [VSCode Devtools](https://github.com/biegehydra/BifrostMCP) 📇 - เชื่อมต่อกับ VSCode ide และใช้เครื่องมือ semantic เช่น `find_usages`
- [xcodebuild](https://github.com/ShenghaiWang/xcodebuild) 🍎 สร้าง iOS Xcode workspace/project และส่ง error กลับไปยัง llm
- [xzq.xu/jvm-mcp-server](https://github.com/xzq-xu/jvm-mcp-server) 📇 🏠  - โปรเจกต์ตัวอย่างของเซิร์ฟเวอร์ MCP (Model Context Protocol) ที่ใช้ JVM
- [yangkyeongmo@/mcp-server-apache-airflow](https://github.com/yangkyeongmo/mcp-server-apache-airflow) 🐍 🏠 - MCP server เชื่อมต่อกับ [Apache Airflow](https://airflow.apache.org/) โดยใช้ client อย่างเป็นทางการ
- [YuChenSSR/mindmap-mcp-server](https://github.com/YuChenSSR/mindmap-mcp-server) 🐍 🏠 - เซิร์ฟเวอร์ Model Context Protocol (MCP) สำหรับสร้าง mindmap แบบ interactive ที่สวยงาม
- [YuChenSSR/multi-ai-advisor](https://github.com/YuChenSSR/multi-ai-advisor-mcp) 📇 🏠 - เซิร์ฟเวอร์ Model Context Protocol (MCP) ที่สอบถามหลายโมเดล Ollama พร้อมรวมคำตอบเพื่อให้ได้มุมมอง AI ที่หลากหลายต่อคำถามเดียว
- [yWorks/mcp-typescribe](https://github.com/yWorks/mcp-typescribe) 📇 🏠 - MCP server ที่ให้ข้อมูล Typescript API แก่ agent อย่างมีประสิทธิภาพเพื่อทำงานกับ API ที่ไม่เคยเทรน
- [zcaceres/fetch-mcp](https://github.com/zcaceres/fetch-mcp) 📇 🏠 - MCP server สำหรับดึงข้อมูล JSON, ข้อความ, และ HTML อย่างยืดหยุ่น
- [zenml-io/mcp-zenml](https://github.com/zenml-io/mcp-zenml) 🐍 🏠 ☁️ - MCP server สำหรับเชื่อมต่อกับ [ZenML](https://www.zenml.io) MLOps และ LLMOps pipelines ของคุณ
- [idosal/git-mcp](https://github.com/idosal/git-mcp) 📇 ☁️ - [gitmcp.io](https://gitmcp.io/) คือ remote MCP server ทั่วไปสำหรับเชื่อมต่อกับ [GitHub](https://www.github.com) repository หรือโปรเจกต์ใดๆ เพื่อเอกสารประกอบ
- [tgeselle/bugsnag-mcp](https://github.com/tgeselle/bugsnag-mcp) 📇 ☁️ - MCP server สำหรับโต้ตอบกับ [Bugsnag](https://www.bugsnag.com/)
- [jordandalton/restcsv-mcp-server](https://github.com/JordanDalton/RestCsvMcpServer) 📇 ☁️ - MCP server สำหรับไฟล์ CSV
- [cjo4m06/mcp-shrimp-task-manager](https://github.com/cjo4m06/mcp-shrimp-task-manager) 📇 ☁️ 🏠 – ระบบจัดการงานเน้นโปรแกรมมิ่งที่ช่วยเสริม agent อย่าง Cursor AI ด้วยหน่วยความจำงานขั้นสูง การสะท้อนตนเอง และจัดการ dependency [ShrimpTaskManager](https://cjo4m06.github.io/mcp-shrimp-task-manager)
- [axliupore/mcp-code-runner](https://github.com/axliupore/mcp-code-runner) 📇 🏠 - MCP server สำหรับรันโค้ดในเครื่องผ่าน Docker และรองรับหลายภาษา
- [yikakia/godoc-mcp-server](https://github.com/yikakia/godoc-mcp-server) 🏎️ ☁️ 🪟 🐧 🍎 - สอบถามข้อมูลแพ็กเกจ Go จาก pkg.go.dev
- [ckanthony/gin-mcp](https://github.com/ckanthony/gin-mcp) 🏎️ ☁️ 📟 🪟 🐧 🍎 - ไลบรารี Go ที่ไม่ต้องตั้งค่า เพิ่ม API ของ Gin web framework ที่มีอยู่เป็น MCP tools โดยอัตโนมัติ
- [ryan0204/github-repo-mcp](https://github.com/Ryan0204/github-repo-mcp) 📇 ☁️ 🪟 🐧 🍎 - GitHub Repo MCP ให้ผู้ช่วย AI สำรวจ repository, โฟลเดอร์, และดูเนื้อหาไฟล์ได้
- [alimo7amed93/webhook-tester-mcp](https://github.com/alimo7amed93/webhook-tester-mcp)  🐍 ☁️ – เซิร์ฟเวอร์ FastMCP สำหรับโต้ตอบกับ webhook-test.com สามารถสร้าง, ดึง, และลบ webhooks ในเครื่องผ่าน Claude
- [lpigeon/ros-mcp-server](https://github.com/lpigeon/ros-mcp-server) 🐍 🏠 🍎 🪟 🐧 - ROS MCP Server รองรับการควบคุมหุ่นยนต์โดยแปลงคำสั่งภาษาธรรมชาติเป็นคำสั่งควบคุม ROS หรือ ROS2
- [jsdelivr/globalping-mcp-server](https://github.com/jsdelivr/globalping-mcp-server) 🎖️ 📇 ☁️ - Globalping MCP server ให้ผู้ใช้และ LLM ใช้เครื่องมือเครือข่ายเช่น ping, traceroute, mtr, HTTP และ DNS resolve จากหลายพันจุดทั่วโลก
- [posthog/mcp](https://github.com/posthog/mcp) 🎖️ 📇 ☁️ - MCP server สำหรับโต้ตอบกับ PostHog analytics, feature flags, error tracking และอื่นๆ
- [artmann/package-registry-mcp](https://github.com/artmann/package-registry-mcp) 🏠 📇 🍎 🪟 🐧 - MCP server สำหรับค้นหาและรับข้อมูลล่าสุดเกี่ยวกับแพ็กเกจ NPM, Cargo, PyPi, และ NuGet

### 🔒 <a name="delivery"></a>Delivery

- [https://github.com/jordandalton/doordash-mcp-server](https://github.com/JordanDalton/DoorDash-MCP-Server) 🐍 – DoorDash Delivery (ไม่เป็นทางการ)

### 🧮 <a name="data-science-tools"></a>Data Science Tools

อินทิเกรตและเครื่องมือออกแบบมาเพื่อง่ายต่อการสำรวจ วิเคราะห์ และปรับปรุงเวิร์กโฟลว์ data science

- [ChronulusAI/chronulus-mcp](https://github.com/ChronulusAI/chronulus-mcp) 🐍 ☁️ - ทำนายทุกอย่างด้วยตัวแทนพยากรณ์และทำนาย Chronulus AI
- [reading-plus-ai/mcp-server-data-exploration](https://github.com/reading-plus-ai/mcp-server-data-exploration) 🐍 ☁️ - สำรวจข้อมูลอัตโนมัติบนชุดข้อมูล .csv พร้อมสร้าง insight อัจฉริยะด้วยความพยายามน้อยที่สุด
- [zcaceres/markdownify-mcp](https://github.com/zcaceres/markdownify-mcp) 📇 🏠 - MCP server สำหรับแปลงเนื้อหาจากไฟล์หรือเว็บเป็น Markdown
- [datalayer/jupyter-mcp-server](https://github.com/datalayer/jupyter-mcp-server) 🐍 🏠 - Model Context Protocol (MCP) Server สำหรับ Jupyter
- [jjsantos01/jupyter-notebook-mcp](https://github.com/jjsantos01/jupyter-notebook-mcp) 🐍 🏠 - เชื่อม Jupyter Notebook กับ Claude AI ให้ Claude โต้ตอบและควบคุม Jupyter Notebook ได้โดยตรง
- [arrismo/kaggle-mcp](https://github.com/arrismo/kaggle-mcp) 🐍 ☁️ - เชื่อมต่อกับ Kaggle ดาวน์โหลดและวิเคราะห์ชุดข้อมูลได้
- [kdqed/zaturn](https://github.com/kdqed/zaturn) 🐍 🏠 🪟 🐧 🍎 - เชื่อมหลายแหล่งข้อมูล (SQL, CSV, Parquet ฯลฯ) และขอให้ AI วิเคราะห์ข้อมูลเพื่อ insight และสร้าง visualization
- [mckinsey/vizro-mcp](https://github.com/mckinsey/vizro/tree/main/vizro-mcp) 🎖️ 🐍 🏠 - เครื่องมือและเทมเพลตสำหรับสร้างแผนภูมิและแดชบอร์ดข้อมูลที่ตรวจสอบและดูแลได้
- [growthbook/growthbook-mcp](https://github.com/growthbook/growthbook-mcp) 🎖️ 📇 🏠 🪟 🐧 🍎 — เครื่องมือสำหรับสร้างและโต้ตอบกับ GrowthBook feature flags และการทดลอง

### 📟 <a name="embedded-system"></a>Embedded System

ให้เข้าถึงเอกสารและทางลัดสำหรับทำงานกับอุปกรณ์ embedded

- [horw/esp-mcp](https://github.com/horw/esp-mcp) 📟 - เวิร์กโฟลว์สำหรับแก้ไขปัญหาการ build ในชิป ESP32 series ด้วย ESP-IDF
- [kukapay/modbus-mcp](https://github.com/kukapay/modbus-mcp) 🐍 📟 - MCP server ที่จัดมาตรฐานและสร้างบริบทข้อมูล Modbus อุตสาหกรรม
- [kukapay/opcua-mcp](https://github.com/kukapay/opcua-mcp) 🐍 📟 - MCP server ที่เชื่อมต่อกับระบบอุตสาหกรรมที่รองรับ OPC UA
- [yoelbassin/gnuradioMCP](https://github.com/yoelbassin/gnuradioMCP) 🐍 📟 🏠 - MCP server สำหรับ GNU Radio ให้ LLM สร้างและปรับแต่ง flowchart RF `.grc` ได้อัตโนมัติ

### 📂 <a name="file-systems"></a>File Systems

ให้เข้าถึงระบบไฟล์ในเครื่องโดยตรง พร้อมตั้งค่า permission ได้ เปิดให้ AI อ่าน/เขียน/จัดการไฟล์ในโฟลเดอร์ที่กำหนด

- [cyberchitta/llm-context.py](https://github.com/cyberchitta/llm-context.py) 🐍 🏠 - แชร์ context โค้ดกับ LLM ผ่าน MCP หรือ clipboard
- [exoticknight/mcp-file-merger](https://github.com/exoticknight/mcp-file-merger) 🏎️ 🏠 - เครื่องมือรวมไฟล์ เหมาะกับข้อจำกัดความยาวแชทของ AI
- [filesystem@quarkiverse/quarkus-mcp-servers](https://github.com/quarkiverse/quarkus-mcp-servers/tree/main/filesystem) ☕ 🏠 - ระบบไฟล์สำหรับท่องและแก้ไขไฟล์ พัฒนาใน Java ด้วย Quarkus ใช้งานได้ทั้ง jar และ native image
- [hmk/box-mcp-server](https://github.com/hmk/box-mcp-server) 📇 ☁️ - การเชื่อมต่อกับ Box สำหรับการแสดงรายการ อ่าน และค้นหาไฟล์
- [mamertofabian/mcp-everything-search](https://github.com/mamertofabian/mcp-everything-search) 🐍 🏠 🪟 - ค้นหาไฟล์บน Windows อย่างรวดเร็วโดยใช้ Everything SDK
- [mark3labs/mcp-filesystem-server](https://github.com/mark3labs/mcp-filesystem-server) 🏎️ 🏠 - การเข้าถึงระบบไฟล์ท้องถิ่นด้วย Golang
- [mickaelkerjean/filestash](https://github.com/mickael-kerjean/filestash/tree/master/server/plugin/plg_handler_mcp) 🏎️ ☁️ - เข้าถึงพื้นที่จัดเก็บระยะไกล: SFTP, S3, FTP, SMB, NFS, WebDAV, GIT, FTPS, gcloud, azure blob, sharepoint ฯลฯ
- [microsoft/markitdown](https://github.com/microsoft/markitdown/tree/main/packages/markitdown-mcp) 🎖️ 🐍 🏠 - เครื่องมือ MCP สำหรับเข้าถึง MarkItDown -- ไลบรารีแปลงไฟล์หลายรูปแบบ (ทั้งในเครื่องและระยะไกล) เป็น Markdown สำหรับ LLM
- [modelcontextprotocol/server-filesystem](https://github.com/modelcontextprotocol/servers/tree/main/src/filesystem) 📇 🏠 - เข้าถึงระบบไฟล์ท้องถิ่นโดยตรง
- [modelcontextprotocol/server-google-drive](https://github.com/modelcontextprotocol/servers/tree/main/src/gdrive) 📇 ☁️ - การเชื่อมต่อ Google Drive สำหรับแสดงรายการ อ่าน และค้นหาไฟล์
- [Xuanwo/mcp-server-opendal](https://github.com/Xuanwo/mcp-server-opendal) 🐍 🏠 ☁️ - เข้าถึงพื้นที่จัดเก็บใดๆ ด้วย Apache OpenDAL™
- [jeannier/homebrew-mcp](https://github.com/jeannier/homebrew-mcp) 🐍 🏠 🍎 - ควบคุมการติดตั้ง Homebrew บน macOS ด้วยภาษาธรรมชาติผ่าน MCP server จัดการแพ็คเกจ ขอคำแนะนำ หรือแก้ไขปัญหา brew ได้อย่างง่ายดาย

### 💰 <a name="finance--fintech"></a>การเงิน & ฟินเทค

เครื่องมือการเข้าถึงและวิเคราะห์ข้อมูลทางการเงิน ช่วยให้โมเดล AI ทำงานกับข้อมูลตลาด แพลตฟอร์มเทรด และข้อมูลทางการเงิน

- [aaronjmars/web3-research-mcp](https://github.com/aaronjmars/web3-research-mcp) 📇 ☁️ - ค้นคว้าข้อมูลเชิงลึกเกี่ยวกับคริปโต - ฟรี & ใช้งานในเครื่องได้เต็มรูปแบบ
- [alchemy/alchemy-mcp-server](https://github.com/alchemyplatform/alchemy-mcp-server) 🎖️ 📇 ☁️ - ให้ AI agents โต้ตอบกับ API บล็อกเชนของ Alchemy
- [OctagonAI/octagon-mcp-server](https://github.com/OctagonAI/octagon-mcp-server) 🐍 ☁️ - Octagon AI Agents สำหรับเชื่อมต่อข้อมูลตลาดส่วนตัวและสาธารณะ
- [anjor/coinmarket-mcp-server](https://github.com/anjor/coinmarket-mcp-server) 🐍 ☁️ - เชื่อมต่อ Coinmarket API เพื่อดึงรายชื่อและใบเสนอราคาคริปโต
- [ariadng/metatrader-mcp-server](https://github.com/ariadng/metatrader-mcp-server) 🐍 🏠 🪟 - ให้ AI LLMs เทรดผ่านแพลตฟอร์ม MetaTrader 5
- [armorwallet/armor-crypto-mcp](https://github.com/armorwallet/armor-crypto-mcp) 🐍 ☁️ - MCP สำหรับเชื่อมต่อกับหลายบล็อกเชน, staking, DeFi, swap, bridge, การจัดการวอลเล็ท, DCA, Limit Order, Coin Lookup, Tracking ฯลฯ
- [bankless/onchain-mcp](https://github.com/Bankless/onchain-mcp/) 📇 ☁️ - Bankless Onchain API สำหรับโต้ตอบกับ smart contract, ดึงข้อมูลธุรกรรมและโทเค็น
- [base/base-mcp](https://github.com/base/base-mcp) 🎖️ 📇 ☁️ - เชื่อมต่อเครือข่าย Base สำหรับเครื่องมือ onchain, จัดการวอลเล็ท, โอนเงิน, smart contract และ DeFi ผ่าน API ของ Base Network และ Coinbase
- [berlinbra/alpha-vantage-mcp](https://github.com/berlinbra/alpha-vantage-mcp) 🐍 ☁️ - เชื่อมต่อ Alpha Vantage API เพื่อดึงข้อมูลหุ้นและคริปโต
- [ahnlabio/bicscan-mcp](https://github.com/ahnlabio/bicscan-mcp) 🎖️ 🐍 ☁️ - ตรวจสอบคะแนนความเสี่ยง / การถือครองสินทรัพย์ของที่อยู่ EVM blockchain (EOA, CA, ENS) และแม้แต่ชื่อโดเมน
- [bitteprotocol/mcp](https://github.com/BitteProtocol/mcp) 📇 - เชื่อมต่อ Bitte Protocol เพื่อรัน AI Agents บนหลายบล็อกเชน
- [chargebee/mcp](https://github.com/chargebee/agentkit/tree/main/modelcontextprotocol) 🎖️ 📇 ☁️ - MCP Server เชื่อมต่อ AI agent กับ [Chargebee platform](https://www.chargebee.com/)
- [codex-data/codex-mcp](https://github.com/Codex-Data/codex-mcp) 🎖️ 📇 ☁️ - เชื่อมต่อ [Codex API](https://www.codex.io) สำหรับข้อมูลตลาดและบล็อกเชนแบบเรียลไทม์บน 60+ เครือข่าย
- [coinpaprika/dexpaprika-mcp](https://github.com/chargebee/agentkit/tree/main/modelcontextprotocol) 🎖️ 📇 ☁️ 🍎 🪟 🐧 - Coinpaprika's DexPaprika MCP server ให้บริการ [DexPaprika API](https://docs.dexpaprika.com) ครอบคลุม 20+ เชน, 5M+ โทเค็น, ราคาเรียลไทม์, ข้อมูลพูลสภาพคล่อง, OHLCV และเครื่องมือ standardized สำหรับ AI agents ผ่าน Model Context Protocol
- [doggybee/mcp-server-ccxt](https://github.com/doggybee/mcp-server-ccxt) 📇 ☁️ - MCP server สำหรับข้อมูลตลาดคริปโตและการเทรดแบบเรียลไทม์ผ่าน 20+ exchange ด้วยไลบรารี CCXT รองรับ spot, futures, OHLCV, ยอดคงเหลือ, ออเดอร์ ฯลฯ
- [ferdousbhai/investor-agent](https://github.com/ferdousbhai/investor-agent) 🐍 ☁️ - เชื่อมต่อ Yahoo Finance เพื่อดึงข้อมูลหุ้นและคำแนะนำออปชั่น
- [ferdousbhai/tasty-agent](https://github.com/ferdousbhai/tasty-agent) 🐍 ☁️ - เชื่อมต่อ Tastyworks API เพื่อเทรดบน Tastytrade
- [ferdousbhai/wsb-analyst-mcp](https://github.com/ferdousbhai/wsb-analyst-mcp) 🐍 ☁️ - เชื่อมต่อ Reddit เพื่อวิเคราะห์เนื้อหาชุมชน WallStreetBets
- [getalby/nwc-mcp-server](https://github.com/getalby/nwc-mcp-server) 📇 🏠 - เชื่อมต่อวอลเล็ท Bitcoin Lightning ด้วย Nostr Wallet Connect
- [heurist-network/heurist-mesh-mcp-server](https://github.com/heurist-network/heurist-mesh-mcp-server) 🎖️ ⛅️ 🏠 🐍 - เข้าถึง web3 AI agent สำหรับวิเคราะห์บล็อกเชน, ตรวจสอบ smart contract, ประเมิน token และโต้ตอบ on-chain ผ่านเครือข่าย Heurist Mesh ครบทั้ง DeFi, NFT, การติดตามธุรกรรม
- [intentos-labs/beeper-mcp](https://github.com/intentos-labs/beeper-mcp) 🐍 - Beeper ให้บริการธุรกรรมบน BSC เช่น โอนยอด, โอนโทเค็น, swap ใน Pancakeswap และเคลมรางวัล beeper
- [kukapay/blockbeats-mcp](https://github.com/kukapay/blockbeats-mcp) 🐍 ☁️ - MCP server สำหรับส่งข่าวสารและบทความเชิงลึกจาก BlockBeats เกี่ยวกับบล็อกเชนให้กับ AI agents
- [kukapay/bridge-rates-mcp](https://github.com/kukapay/bridge-rates-mcp) 📇 ☁️ - ส่งข้อมูลอัตรา bridge ข้ามเชนแบบเรียลไทม์และเส้นทางโอนที่ดีที่สุดให้ AI agents onchain
- [kukapay/chainlink-feeds-mcp](https://github.com/kukapay/chainlink-feeds-mcp) 📇 ☁️ - ให้เข้าถึง price feed แบบ on-chain ของ Chainlink แบบเรียลไทม์
- [kukapay/cointelegraph-mcp](https://github.com/kukapay/cointelegraph-mcp) 🐍 ☁️ - ให้เข้าถึงข่าวล่าสุดจาก Cointelegraph แบบเรียลไทม์
- [kukapay/crypto-feargreed-mcp](https://github.com/kukapay/crypto-feargreed-mcp) 🐍 ☁️ - ให้ข้อมูล Crypto Fear & Greed Index แบบเรียลไทม์และย้อนหลัง
- [kukapay/crypto-indicators-mcp](https://github.com/kukapay/crypto-indicators-mcp) 🐍 ☁️ - MCP server สำหรับตัวชี้วัดและกลยุทธ์วิเคราะห์ทางเทคนิคของคริปโต
- [kukapay/crypto-news-mcp](https://github.com/kukapay/crypto-news-mcp) 🐍 ☁️ - MCP server สำหรับข่าวคริปโตแบบเรียลไทม์จาก NewsData ให้กับ AI agents
- [kukapay/crypto-portfolio-mcp](https://github.com/kukapay/crypto-portfolio-mcp) 🐍 ☁️ - MCP server สำหรับติดตามและจัดการพอร์ตคริปโต
- [kukapay/crypto-rss-mcp](https://github.com/kukapay/crypto-rss-mcp) 🐍 ☁️ - MCP server ที่รวมข่าวคริปโตแบบเรียลไทม์จาก RSS หลายแหล่ง
- [kukapay/crypto-sentiment-mcp](https://github.com/kukapay/crypto-sentiment-mcp) 🐍 ☁️ - MCP server สำหรับวิเคราะห์ความรู้สึกตลาดคริปโตให้กับ AI agents
- [kukapay/crypto-trending-mcp](https://github.com/kukapay/crypto-trending-mcp) 🐍 ☁️ - ติดตามโทเค็นที่กำลังเป็นกระแสบน CoinGecko
- [kukapay/crypto-whitepapers-mcp](https://github.com/kukapay/crypto-whitepapers-mcp) 🐍 ☁️ - ฐานข้อมูล whitepaper ของคริปโตแบบมีโครงสร้าง
- [kukapay/cryptopanic-mcp-server](https://github.com/kukapay/cryptopanic-mcp-server) 🐍 ☁️ - ให้ข่าวคริปโตล่าสุดกับ AI agents โดยขับเคลื่อนด้วย CryptoPanic
- [kukapay/defi-yields-mcp](https://github.com/kukapay/defi-yields-mcp) 🐍 ☁️ - MCP server ให้ AI agents สำรวจโอกาสผลตอบแทน DeFi
- [kukapay/dune-analytics-mcp](https://github.com/kukapay/dune-analytics-mcp) 🐍 ☁️ - MCP server เชื่อมข้อมูล Dune Analytics ให้ AI agents
- [kukapay/etf-flow-mcp](https://github.com/kukapay/etf-flow-mcp) 🐍 ☁️ - ส่งข้อมูล ETF flow ของคริปโตเพื่อช่วยในการตัดสินใจของ AI agents
- [kukapay/freqtrade-mcp](https://github.com/kukapay/freqtrade-mcp) 🐍 ☁️ - MCP server สำหรับเชื่อมต่อกับบอทเทรดคริปโต Freqtrade
- [kukapay/funding-rates-mcp](https://github.com/kukapay/funding-rates-mcp) 🐍 ☁️ - ให้ข้อมูล funding rate แบบเรียลไทม์จาก exchange หลักๆ
- [kukapay/jupiter-mcp](https://github.com/kukapay/jupiter-mcp) 🐍 ☁️ - MCP server สำหรับการ swap โทเค็นบน Solana ด้วย Jupiter Ultra API
- [kukapay/pancakeswap-poolspy-mcp](https://github.com/kukapay/pancakeswap-poolspy-mcp) 🐍 ☁️ - MCP server สำหรับติดตามพูลใหม่ที่สร้างบน Pancake Swap
- [kukapay/rug-check-mcp](https://github.com/kukapay/rug-check-mcp) 🐍 ☁️ - MCP server สำหรับตรวจจับความเสี่ยงใน meme token ของ Solana
- [kukapay/thegraph-mcp](https://github.com/kukapay/thegraph-mcp) 🐍 ☁️ - MCP server ให้ AI agents เข้าถึงข้อมูลบล็อกเชนที่จัดทำดัชนีด้วย The Graph
- [kukapay/token-minter-mcp](https://github.com/kukapay/token-minter-mcp) 🐍 ☁️ - MCP server ให้เครื่องมือ mint ERC-20 token ข้ามหลายบล็อกเชนสำหรับ AI agents
- [kukapay/token-revoke-mcp](https://github.com/kukapay/token-revoke-mcp) 🐍 ☁️ - MCP server สำหรับตรวจสอบและยกเลิก token allowance (ERC-20) ข้ามบล็อกเชน
- [kukapay/twitter-username-changes-mcp](https://github.com/kukapay/twitter-username-changes-mcp) 🐍 ☁️ - MCP server สำหรับติดตามการเปลี่ยนชื่อผู้ใช้ใน Twitter ย้อนหลัง
- [kukapay/uniswap-poolspy-mcp](https://github.com/kukapay/uniswap-poolspy-mcp) 🐍 ☁️ - MCP server สำหรับติดตามพูลสภาพคล่องที่เพิ่งสร้างใหม่บน Uniswap ในหลายบล็อกเชน
- [kukapay/uniswap-trader-mcp](https://github.com/kukapay/uniswap-trader-mcp) 🐍 ☁️ - MCP server สำหรับ AI agents ในการเทรด swap token อัตโนมัติบน Uniswap DEX หลายบล็อกเชน
- [kukapay/whale-tracker-mcp](https://github.com/kukapay/whale-tracker-mcp) 🐍 ☁️ - MCP server สำหรับติดตามธุรกรรม whale ในตลาดคริปโต
- [laukikk/alpaca-mcp](https://github.com/laukikk/alpaca-mcp) 🐍 ☁️ - MCP Server สำหรับ Alpaca trading API จัดการพอร์ตหุ้น/คริปโต, สั่งเทรด, ดูข้อมูลตลาด
- [longportapp/openapi](https://github.com/longportapp/openapi/tree/main/mcp) - 🐍 ☁️ - LongPort OpenAPI ให้ข้อมูลตลาดหุ้นแบบเรียลไทม์และความสามารถในการวิเคราะห์/เทรดผ่าน MCP สำหรับ AI
- [mcpdotdirect/evm-mcp-server](https://github.com/mcpdotdirect/evm-mcp-server) 📇 ☁️ - บริการบล็อกเชนสำหรับ 30+ EVM network รองรับ native token, ERC20, NFT, smart contract, ธุรกรรม, ENS resolution
- [mcpdotdirect/starknet-mcp-server](https://github.com/mcpdotdirect/starknet-mcp-server) 📇 ☁️ - เชื่อมต่อ Starknet blockchain พร้อมรองรับ native token (ETH, STRK), smart contract, StarknetID, การโอน token
- [minhyeoky/mcp-server-ledger](https://github.com/minhyeoky/mcp-server-ledger) 🐍 🏠 - เชื่อมต่อ ledger-cli สำหรับจัดการธุรกรรมการเงินและสร้างรายงาน
- [openMF/mcp-mifosx](https://github.com/openMF/mcp-mifosx) ☁️ 🏠 - ระบบธนาคารหลักสำหรับจัดการลูกค้า, สินเชื่อ, ออมทรัพย์, หุ้น, ธุรกรรมการเงิน และสร้างรายงาน
- [narumiruna/yfinance-mcp](https://github.com/narumiruna/yfinance-mcp) 🐍 ☁️ - MCP server สำหรับรับข้อมูลจาก Yahoo Finance ด้วย yfinance
- [polygon-io/mcp_polygon)](https://github.com/polygon-io/mcp_polygon)) 🐍 ☁️ - MCP server สำหรับเข้าถึงข้อมูลตลาดการเงินจาก [Polygon.io](https://polygon.io/) เช่น หุ้น, ดัชนี, ฟอเร็กซ์, ออปชั่น ฯลฯ
- [pwh-pwh/coin-mcp-server](https://github.com/pwh-pwh/coin-mcp-server) 🐍 ☁️ - ดึงราคาคริปโตจาก Bitget API
- [QuantGeekDev/coincap-mcp](https://github.com/QuantGeekDev/coincap-mcp) 📇 ☁️ - ข้อมูลตลาดคริปโตแบบเรียลไทม์โดย CoinCap API สาธารณะ ไม่ต้องใช้ API key
- [SaintDoresh/Crypto-Trader-MCP-ClaudeDesktop](https://github.com/SaintDoresh/Crypto-Trader-MCP-ClaudeDesktop.git) 🐍 ☁️ - MCP เครื่องมือข้อมูลตลาดคริปโตโดย CoinGecko API
- [tooyipjee/yahoofinance-mcp](https://github.com/tooyipjee/yahoofinance-mcp.git) 📇 ☁️ - MCP Yahoo Finance เวอร์ชัน TypeScript
- [SaintDoresh/YFinance-Trader-MCP-ClaudeDesktop](https://github.com/SaintDoresh/YFinance-Trader-MCP-ClaudeDesktop.git) 🐍 ☁️ - MCP เครื่องมือข้อมูลตลาดหุ้นและวิเคราะห์หุ้นโดย Yahoo Finance API
- [RomThpt/xrpl-mcp-server](https://github.com/RomThpt/mcp-xrpl) 📇 ☁️ - MCP server สำหรับ XRP Ledger ให้เข้าถึงข้อมูลบัญชี, ประวัติธุรกรรม, ข้อมูลเครือข่าย, คิวรี ledger object, ส่งธุรกรรม, ตรวจสอบ XRPL network
- [janswist/mcp-dexscreener](https://github.com/janswist/mcp-dexscreener) 📇 ☁️ - ราคาตลาด on-chain แบบเรียลไทม์ด้วย Dexscreener API ฟรี
- [HuggingAGI/mcp-baostock-server](https://github.com/HuggingAGI/mcp-baostock-server) 🐍 ☁️ - MCP server สำหรับข้อมูลหุ้นจีนและวิเคราะห์ด้วย baostock
- [wowinter13/solscan-mcp](https://github.com/wowinter13/solscan-mcp) 🦀 🏠 - MCP เครื่องมือคิวรีธุรกรรม Solana ด้วยภาษาธรรมชาติผ่าน Solscan API
- [Wuye-AI/mcp-server-wuye-ai](https://github.com/wuye-ai/mcp-server-wuye-ai) 🎖️ 📇 ☁️ - MCP server สำหรับเชื่อมต่อกับ CRIC Wuye AI แพลตฟอร์มผู้ช่วยอัจฉริยะด้านบริหารอสังหาริมทรัพย์
- [zlinzzzz/finData-mcp-server](https://github.com/zlinzzzz/finData-mcp-server) 🐍 ☁️ - MCP server สำหรับข้อมูลการเงินมืออาชีพ รองรับผู้ให้บริการหลายราย เช่น Tushare

### 🎮 <a name="gaming"></a>เกม

เชื่อมต่อกับข้อมูลเกม เอ็นจิ้นเกม และบริการที่เกี่ยวข้องกับเกม

- [IvanMurzak/Unity-MCP](https://github.com/IvanMurzak/Unity-MCP) #️⃣ 🏠 🍎 🪟 🐧 - MCP Server สำหรับ Unity Editor และเกมที่สร้างด้วย Unity
- [CoderGamester/mcp-unity](https://github.com/CoderGamester/mcp-unity) #️⃣ 🏠 - MCP Server สำหรับ Unity3d Game Engine เพื่อพัฒนาเกม
- [Coding-Solo/godot-mcp](https://github.com/Coding-Solo/godot-mcp) 📇 🏠 - MCP server สำหรับโต้ตอบกับ Godot engine มีเครื่องมือสำหรับแก้ไข, รัน, ดีบัก, และจัดการฉากในโปรเจกต์ Godot
- [pab1ito/chess-mcp](https://github.com/pab1it0/chess-mcp) 🐍 ☁️ - เข้าถึงข้อมูลผู้เล่น Chess.com, บันทึกเกม, และข้อมูลสาธารณะอื่นๆ ผ่าน MCP interface มาตรฐาน ให้ AI ค้นหาและวิเคราะห์หมากรุก
- [jiayao/mcp-chess](https://github.com/jiayao/mcp-chess) 🐍 🏠 - MCP server สำหรับเล่นหมากรุกกับ LLMs
- [rishijatia/fantasy-pl-mcp](https://github.com/rishijatia/fantasy-pl-mcp/) 🐍 ☁️ - MCP server สำหรับข้อมูลและเครื่องมือวิเคราะห์ Fantasy Premier League แบบเรียลไทม์
- [opgginc/opgg-mcp](https://github.com/opgginc/opgg-mcp) 📇 ☁️ - เข้าถึงข้อมูลเกมแบบเรียลไทม์ เช่น LoL, TFT, Valorant พร้อมเครื่องมือวิเคราะห์แชมเปี้ยน ตารางแข่งขัน esports ข้อมูล meta และสถิติตัวละคร
- [stefan-xyz/mcp-server-runescape](https://github.com/stefan-xyz/mcp-server-runescape) 📇 - MCP server สำหรับโต้ตอบกับข้อมูล RuneScape (RS) และ Old School RuneScape (OSRS) เช่น ราคาไอเท็ม, hiscore ผู้เล่น ฯลฯ

### 🧠 <a name="knowledge--memory"></a>ความรู้ & หน่วยความจำ

ระบบจัดเก็บหน่วยความจำถาวรแบบ knowledge graph ช่วยให้โมเดล AI รักษาและค้นหาข้อมูลแบบมีโครงสร้างระหว่างเซสชัน
- [CheMiguel23/MemoryMesh](https://github.com/CheMiguel23/MemoryMesh) 📇 🏠 - หน่วยความจำแบบกราฟขั้นสูงที่เน้นการสวมบทบาท AI และการสร้างเรื่องราว
- [graphlit-mcp-server](https://github.com/graphlit/graphlit-mcp-server) 📇 ☁️ - นำเข้าข้อมูลจาก Slack, Discord, เว็บไซต์, Google Drive, Linear หรือ GitHub เข้าสู่โปรเจกต์ Graphlit จากนั้นค้นหาและดึงข้อมูลที่เกี่ยวข้องในไคลเอนต์ MCP เช่น Cursor, Windsurf หรือ Cline
- [hannesrudolph/mcp-ragdocs](https://github.com/hannesrudolph/mcp-ragdocs) 🐍 🏠 - การติดตั้งเซิร์ฟเวอร์ MCP ที่ให้เครื่องมือสำหรับค้นหาและประมวลผลเอกสารผ่านการค้นหาเวกเตอร์ เพื่อช่วยให้ผู้ช่วย AI ขยายคำตอบด้วยบริบทของเอกสารที่เกี่ยวข้อง
- [jinzcdev/markmap-mcp-server](https://github.com/jinzcdev/markmap-mcp-server) 📇 🏠 - เซิร์ฟเวอร์ MCP ที่สร้างขึ้นจาก [markmap](https://github.com/markmap/markmap) สำหรับแปลง **Markdown** เป็น **mind maps** แบบอินเทอร์แอกทีฟ รองรับการส่งออกหลายรูปแบบ (PNG/JPG/SVG), พรีวิวในเบราว์เซอร์แบบเรียลไทม์, คัดลอก Markdown ได้ในคลิกเดียว และฟีเจอร์การแสดงผลแบบไดนามิก
- [kaliaboi/mcp-zotero](https://github.com/kaliaboi/mcp-zotero) 📇 ☁️ - ตัวเชื่อมต่อสำหรับ LLM เพื่อทำงานกับคอลเลกชันและแหล่งข้อมูลบน Zotero Cloud ของคุณ
- [mcp-summarizer](https://github.com/0xshellming/mcp-summarizer) 📕 ☁️ - เซิร์ฟเวอร์ MCP สำหรับสรุปเนื้อหาโดย AI รองรับหลายประเภท: ข้อความธรรมดา, หน้าเว็บ, เอกสาร PDF, หนังสือ EPUB, เนื้อหา HTML
- [mem0ai/mem0-mcp](https://github.com/mem0ai/mem0-mcp) 🐍 🏠 - เซิร์ฟเวอร์ Model Context Protocol สำหรับ Mem0 เพื่อจัดการรูปแบบและแนวทางการเขียนโค้ด ให้เครื่องมือสำหรับจัดเก็บ, ค้นคืน และจัดการโค้ด, แนวปฏิบัติ และเอกสารทางเทคนิคใน IDE เช่น Cursor และ Windsurf
- [modelcontextprotocol/server-memory](https://github.com/modelcontextprotocol/servers/tree/main/src/memory) 📇 🏠 - ระบบหน่วยความจำถาวรแบบกราฟความรู้สำหรับรักษาบริบท
- [pinecone-io/assistant-mcp](https://github.com/pinecone-io/assistant-mcp) 🎖️ 🦀 ☁️ - เชื่อมต่อกับ Pinecone Assistant และให้ตัวแทน AI เข้าถึงบริบทจาก knowledge engine ของตน
- [@ragieai/mcp-server](https://github.com/ragieai/ragie-mcp-server) 📇 ☁️ - ดึงบริบทจาก [Ragie](https://www.ragie.ai) (RAG) knowledge base ที่เชื่อมต่อกับ Google Drive, Notion, JIRA และอื่น ๆ
- [TechDocsStudio/biel-mcp](https://github.com/TechDocsStudio/biel-mcp) 📇 ☁️ - ให้ AI tools เช่น Cursor, VS Code หรือ Claude Desktop ตอบคำถามโดยใช้เอกสารผลิตภัณฑ์ของคุณ Biel.ai ให้บริการระบบ RAG และ MCP server
- [topoteretes/cognee](https://github.com/topoteretes/cognee/tree/dev/cognee-mcp) 📇 🏠 - ตัวจัดการหน่วยความจำสำหรับแอปและเอเจนต์ AI โดยใช้ graph และ vector store หลายประเภท และรองรับการนำเข้าข้อมูลจากกว่า 30 แหล่ง
- [unibaseio/membase-mcp](https://github.com/unibaseio/membase-mcp) 📇 ☁️ - บันทึกและค้นหาหน่วยความจำของเอเจนต์แบบกระจายด้วย Membase
- [GistPad-MCP](https://github.com/lostintangent/gistpad-mcp) 📇 🏠 - ใช้ GitHub Gists จัดการและเข้าถึงความรู้ส่วนตัว, โน้ตประจำวัน และพรอมต์ที่ใช้ซ้ำได้ เป็นตัวช่วยสำหรับ https://gistpad.dev และ [GistPad VS Code extension](https://aka.ms/gistpad)
- [entanglr/zettelkasten-mcp](https://github.com/entanglr/zettelkasten-mcp) 🐍 🏠 - เซิร์ฟเวอร์ Model Context Protocol (MCP) ที่ใช้หลักการบริหารความรู้แบบ Zettelkasten ให้คุณสร้าง, เชื่อมโยง และค้นหาบันทึกย่อยผ่าน Claude และไคลเอนต์ที่รองรับ MCP อื่น ๆ

### 🗺️ <a name="location-services"></a>Location Services

บริการที่อิงกับตำแหน่งและเครื่องมือแผนที่ ให้โมเดล AI ทำงานร่วมกับข้อมูลภูมิศาสตร์ ข้อมูลสภาพอากาศ และการวิเคราะห์ตามตำแหน่งได้

- [briandconnelly/mcp-server-ipinfo](https://github.com/briandconnelly/mcp-server-ipinfo) 🐍 ☁️  - ค้นหาตำแหน่งและข้อมูลเครือข่ายจาก IP Address ด้วย IPInfo API
- [devilcoder01/weather-mcp-server](https://github.com/devilcoder01/weather-mcp-server) 🐍 ☁️ - เข้าถึงข้อมูลสภาพอากาศแบบเรียลไทม์ของทุกพื้นที่ด้วย WeatherAPI.com API พร้อมการพยากรณ์และข้อมูลสภาพอากาศปัจจุบันอย่างละเอียด
- [jagan-shanmugam/open-streetmap-mcp](https://github.com/jagan-shanmugam/open-streetmap-mcp) 🐍 🏠 - เซิร์ฟเวอร์ MCP ของ OpenStreetMap พร้อมบริการตามตำแหน่งและข้อมูลภูมิสารสนเทศ
- [kukapay/nearby-search-mcp](https://github.com/kukapay/nearby-search-mcp) 🐍 ☁️ - MCP server สำหรับค้นหาสถานที่ใกล้เคียงด้วยการตรวจจับตำแหน่งจาก IP
- [modelcontextprotocol/server-google-maps](https://github.com/modelcontextprotocol/servers/tree/main/src/google-maps) 📇 ☁️ - เชื่อมต่อ Google Maps สำหรับบริการตำแหน่ง, การนำทาง และข้อมูลสถานที่
- [QGIS MCP](https://github.com/jjsantos01/qgis_mcp) - เชื่อม QGIS Desktop กับ Claude AI ผ่าน MCP ช่วยสร้างโปรเจกต์, โหลดเลเยอร์, รันโค้ด และอื่น ๆ ด้วยพรอมต์
- [SaintDoresh/Weather-MCP-ClaudeDesktop](https://github.com/SaintDoresh/Weather-MCP-ClaudeDesktop.git) 🐍 ☁️ - เครื่องมือ MCP ที่ให้ข้อมูลสภาพอากาศแบบเรียลไทม์, พยากรณ์ และข้อมูลย้อนหลัง ด้วย OpenWeatherMap API
- [rossshannon/Weekly-Weather-mcp](https://github.com/rossshannon/weekly-weather-mcp.git) 🐍 ☁️ - เซิร์ฟเวอร์ Weekly Weather MCP ที่คืนข้อมูลพยากรณ์อากาศอย่างละเอียด 7 วันทั่วโลก
- [SecretiveShell/MCP-timeserver](https://github.com/SecretiveShell/MCP-timeserver) 🐍 🏠 - เข้าถึงเวลาในทุกเขตเวลาและรับเวลาท้องถิ่นปัจจุบัน
- [TimLukaHorstmann/mcp-weather](https://github.com/TimLukaHorstmann/mcp-weather) 📇 ☁️  - พยากรณ์อากาศที่แม่นยำผ่าน AccuWeather API (มีฟรี)
- [webcoderz/MCP-Geo](https://github.com/webcoderz/MCP-Geo) 🐍 🏠 - เซิร์ฟเวอร์ MCP สำหรับ geocoding ด้วย nominatim, ArcGIS, Bing
- [ipfind/ipfind-mcp-server](https://github.com/ipfind/ipfind-mcp-server) 🐍 ☁️ - บริการระบุตำแหน่ง IP Address ด้วย [IP Find](https://ipfind.com) API
- [mahdin75/geoserver-mcp](https://github.com/mahdin75/geoserver-mcp) 🏠 – ติดตั้งเซิร์ฟเวอร์ Model Context Protocol (MCP) ที่เชื่อม LLM กับ GeoServer REST API ให้ผู้ช่วย AI ทำงานกับข้อมูลและบริการภูมิสารสนเทศ
- [ipfred/aiwen-mcp-server-geoip](https://github.com/ipfred/aiwen-mcp-server-geoip) 🐍 📇 ☁️ – MCP Server สำหรับ Aiwen IP Location, รับตำแหน่งเครือข่าย IP ของผู้ใช้, รายละเอียด IP (ประเทศ, จังหวัด, เมือง, lat, lon, ISP, เจ้าของ ฯลฯ)

### 🎯 <a name="marketing"></a>Marketing

เครื่องมือสร้างและแก้ไขเนื้อหาการตลาด, ทำงานกับข้อมูล meta ของเว็บ, การวางตำแหน่งผลิตภัณฑ์ และคู่มือแก้ไข

- [gomarble-ai/facebook-ads-mcp-server](https://github.com/gomarble-ai/facebook-ads-mcp-server) 🐍 ☁️ - MCP server สำหรับเชื่อมต่อ Facebook Ads เพื่อเข้าถึงและจัดการข้อมูลโฆษณาแบบโปรแกรม
- [open-strategy-partners/osp_marketing_tools](https://github.com/open-strategy-partners/osp_marketing_tools) 🐍 🏠 - ชุดเครื่องมือการตลาดจาก Open Strategy Partners ครอบคลุมรูปแบบการเขียน, โค้ดแก้ไข และแผนที่ค่าสินค้าเชิงการตลาด
- [nictuku/meta-ads-mcp](https://github.com/nictuku/meta-ads-mcp) 🐍 ☁️ 🏠 - ให้ AI agents ติดตามและปรับปรุงประสิทธิภาพโฆษณา Meta วิเคราะห์สถิติแคมเปญ ปรับกลุ่มเป้าหมาย จัดการเนื้อหาสร้างสรรค์ และแนะนำการใช้จ่าย/การตั้งค่าแคมเปญผ่าน Graph API
- [marketplaceadpros/amazon-ads-mcp-server](https://github.com/MarketplaceAdPros/amazon-ads-mcp-server) 📇 ☁️  - ช่วยให้เครื่องมือทำงานกับ Amazon Advertising วิเคราะห์สถิติและการตั้งค่าแคมเปญ

### 📊 <a name="monitoring"></a>Monitoring

เข้าถึงและวิเคราะห์ข้อมูลการตรวจสอบแอปพลิเคชัน ให้โมเดล AI ตรวจสอบรายงานข้อผิดพลาดและสถิติประสิทธิภาพ

- [netdata/netdata#Netdata](https://github.com/netdata/netdata/blob/master/src/web/mcp/README.md) 🎖️ 🏠 ☁️ 📟 🍎 🪟 🐧 - ค้นหา, สำรวจ, รายงาน และวิเคราะห์สาเหตุจากข้อมูล observability ทั้งหมด รวมถึง metrics, log, ระบบ, คอนเทนเนอร์, โพรเซส และการเชื่อมต่อเครือข่าย
- [grafana/mcp-grafana](https://github.com/grafana/mcp-grafana) 🎖️ 🐍 🏠 ☁️ - ค้นหาแดชบอร์ด, สืบสวนเหตุการณ์ และ query แหล่งข้อมูลใน Grafana instance ของคุณ
- [tumf/grafana-loki-mcp](https://github.com/tumf/grafana-loki-mcp) 🐍 🏠 - MCP server ที่ให้ query log จาก Loki ผ่าน Grafana API
- [hyperb1iss/lucidity-mcp](https://github.com/hyperb1iss/lucidity-mcp) 🐍 🏠 - ยกระดับคุณภาพโค้ดที่ AI สร้าง ผ่านการวิเคราะห์เชิงพรอมต์ใน 10 มิติสำคัญ เช่น ความซับซ้อนและช่องโหว่ด้านความปลอดภัย
- [last9/last9-mcp-server](https://github.com/last9/last9-mcp-server) - นำบริบทการทำงานจริงแบบเรียลไทม์ (log, metric, trace) เข้าสู่สภาพแวดล้อมของคุณเพื่อแก้โค้ดอัตโนมัติได้เร็วขึ้น
- [metoro-io/metoro-mcp-server](https://github.com/metoro-io/metoro-mcp-server) 🎖️ 🏎️ ☁️ - Query และโต้ตอบกับสภาพแวดล้อม kubernetes ที่ถูกดูแลโดย Metoro
- [MindscapeHQ/server-raygun](https://github.com/MindscapeHQ/mcp-server-raygun) 📇 ☁️ - เชื่อมต่อ Raygun API V3 สำหรับรายงานข้อขัดข้องและตรวจสอบผู้ใช้จริง
- [modelcontextprotocol/server-sentry](https://github.com/modelcontextprotocol/servers/tree/main/src/sentry) 🐍 ☁️ - เชื่อม Sentry.io สำหรับติดตามข้อผิดพลาดและประสิทธิภาพ
- [pydantic/logfire-mcp](https://github.com/pydantic/logfire-mcp) 🎖️ 🐍 ☁️ - ให้เข้าถึง trace และ metric จาก OpenTelemetry ผ่าน Logfire
- [seekrays/mcp-monitor](https://github.com/seekrays/mcp-monitor) 🏎️ 🏠 - เครื่องมือมอนิเตอร์ระบบที่เปิด metric ผ่าน Model Context Protocol (MCP) ให้ LLM เข้าถึงข้อมูลระบบแบบเรียลไทม์ (รองรับ CPU, Memory, Disk, Network, Host, Process)
- [VictoriaMetrics-Community/mcp-victoriametrics](https://github.com/VictoriaMetrics-Community/mcp-victoriametrics) 🎖️ 🏎️ 🏠 - เชื่อมต่อกับ [VictoriaMetrics instance APIs](https://docs.victoriametrics.com/victoriametrics/url-examples/) และ [เอกสาร](https://docs.victoriametrics.com/) สำหรับมอนิเตอร์, observability และดีบั๊ก VictoriaMetrics

### 🎥 <a name="multimedia-process"></a>Multimedia Process

ให้ความสามารถในการจัดการมัลติมีเดีย เช่น ตัดต่อเสียง/วิดีโอ, เล่น, แปลงฟอร์แมต, รวมถึงฟิลเตอร์และการปรับแต่งวิดีโอ ฯลฯ

- [video-creator/ffmpeg-mcp](https://github.com/video-creator/ffmpeg-mcp.git) 🎥 🔊 - ใช้คำสั่ง ffmpeg สร้างเซิร์ฟเวอร์ mcp ให้ค้นหา, ตัดต่อ, ต่อ, เล่นวิดีโอในเครื่องได้สะดวกผ่านบทสนทนา
- [stass/exif-mcp](https://github.com/stass/exif-mcp) 📇 🏠 🐧 🍎 🪟 - เซิร์ฟเวอร์ MCP ที่ตรวจสอบ metadata ของรูปภาพ เช่น EXIF, XMP, JFIF, GPS เป็นฐานสำหรับ LLM ค้นหา/วิเคราะห์คลังภาพ
- [sunriseapps/imagesorcery-mcp](https://github.com/sunriseapps/imagesorcery-mcp) 🐍 🏠 🐧 🍎 🪟 - เครื่องมือจดจำและแก้ไขภาพบนพื้นฐาน ComputerVision สำหรับผู้ช่วย AI

### 🔎 <a name="search"></a>Search & Data Extraction

- [Xyber-Labs/mcp-server-youtube](https://github.com/Xyber-Labs/mcp-servers/tree/main/mcp-server-youtube) 🐍 ☁️ - Repository นี้ติดตั้งเซิร์ฟเวอร์ MCP (Model Context Protocol) สำหรับค้นหา YouTube และดึงคำบรรยาย ให้ language models หรือ agent อื่น ๆ ค้นหาเนื้อหา YouTube ได้ผ่านโปรโตคอลมาตรฐาน
- [ricocf/mcp-wolframalpha](https://github.com/ricocf/mcp-wolframalpha) 🐍 🏠 ☁️ - MCP server ให้ผู้ช่วย AI ใช้ Wolfram Alpha API เพื่อเข้าถึงข้อมูลเชิงคำนวณและความรู้แบบเรียลไทม์
- [scrapeless-ai/scrapeless-mcp-server](https://github.com/scrapeless-ai/scrapeless-mcp-server) 🐍 ☁️ - Scrapeless Model Context Protocol เป็น MCP server เชื่อมต่อกับ Google SERP API ให้ค้นหาเว็บในระบบ MCP ได้โดยตรง
- [0xdaef0f/job-searchoor](https://github.com/0xDAEF0F/job-searchoor) 📇 🏠 - MCP server สำหรับค้นหางานพร้อมฟิลเตอร์วันที่, คำสำคัญ, งาน remote และอื่น ๆ
- [ac3xx/mcp-servers-kagi](https://github.com/ac3xx/mcp-servers-kagi) 📇 ☁️ - เชื่อมต่อ Kagi search API
- [andybrandt/mcp-simple-arxiv](https://github.com/andybrandt/mcp-simple-arxiv) - 🐍 ☁️  MCP สำหรับ LLM เพื่อค้นหาและอ่านเปเปอร์จาก arXiv
- [hbg/mcp-paperswithcode](https://github.com/hbg/mcp-paperswithcode) - 🐍 ☁️ MCP สำหรับค้นหาผ่าน PapersWithCode API
- [andybrandt/mcp-simple-pubmed](https://github.com/andybrandt/mcp-simple-pubmed) - 🐍 ☁️  MCP สำหรับค้นหาและอ่านเปเปอร์ทางการแพทย์/วิทยาศาสตร์ชีวิตจาก PubMed
- [angheljf/nyt](https://github.com/angheljf/nyt) 📇 ☁️ - ค้นหาบทความผ่าน NYTimes API
- [apify/mcp-server-rag-web-browser](https://github.com/apify/mcp-server-rag-web-browser) 📇 ☁️ - MCP server สำหรับ Apify's open-source RAG Web Browser Actor สำหรับค้นหาเว็บ, ดึง URL, ส่งคืนเนื้อหาในรูป Markdown
- [Bigsy/Clojars-MCP-Server](https://github.com/Bigsy/Clojars-MCP-Server) 📇 ☁️ - Clojars MCP Server สำหรับข้อมูล dependency ของไลบรารี Clojure ที่อัปเดตล่าสุด
- [blazickjp/arxiv-mcp-server](https://github.com/blazickjp/arxiv-mcp-server) ☁️ 🐍 - ค้นหาเปเปอร์วิจัยบน ArXiv
- [luminati-io/brightdata-mcp](https://github.com/luminati-io/brightdata-mcp) 📇 ☁️ - ค้นหา, ดึง, และโต้ตอบกับเว็บ – อินเทอร์เฟซเดียวสำหรับเข้าถึงข้อมูลบนอินเทอร์เน็ตสาธารณะโดยอัตโนมัติ
- [chanmeng/google-news-mcp-server](https://github.com/ChanMeng666/server-google-news) 📇 ☁️ - เชื่อม Google News พร้อมจัดหมวดหมู่อัตโนมัติ รองรับหลายภาษา และค้นหาข่าว, หัวข้อ, เรื่องราวที่เกี่ยวข้องผ่าน [SerpAPI](https://serpapi.com/)
- [ConechoAI/openai-websearch-mcp](https://github.com/ConechoAI/openai-websearch-mcp/) 🐍 🏠 ☁️ - เซิร์ฟเวอร์ MCP บน Python สำหรับ OpenAI `web_search` build-in tool
- [dealx/mcp-server](https://github.com/DealExpress/mcp-server) ☁️ - MCP Server สำหรับแพลตฟอร์ม DealX
- [devflowinc/trieve](https://github.com/devflowinc/trieve/tree/main/clients/mcp-server) 🎖️ 📇 ☁️ 🏠 - รวบรวม, ฝัง, แบ่ง, ค้นหา และดึงข้อมูลจาก dataset ผ่าน [Trieve](https://trieve.ai)
- [Dumpling-AI/mcp-server-dumplingai](https://github.com/Dumpling-AI/mcp-server-dumplingai) 🎖️ 📇 ☁️ - เข้าถึงข้อมูล, API ดึงเว็บ และแปลงเอกสารโดย [Dumpling AI](https://www.dumplingai.com/)
- [erithwik/mcp-hn](https://github.com/erithwik/mcp-hn) 🐍 ☁️ - MCP server สำหรับค้นหา Hacker News, ดูข่าวเด่น ฯลฯ
- [exa-labs/exa-mcp-server](https://github.com/exa-labs/exa-mcp-server) 🎖️ 📇 ☁️ – เซิร์ฟเวอร์ Model Context Protocol (MCP) ให้ผู้ช่วย AI อย่าง Claude ใช้ Exa AI Search API ค้นหาเว็บแบบเรียลไทม์ในสภาพแวดล้อมที่ปลอดภัย
- [fatwang2/search1api-mcp](https://github.com/fatwang2/search1api-mcp) 📇 ☁️ - ค้นหาผ่าน search1api (ต้องใช้คีย์ API แบบเสียเงิน)
- [genomoncology/biomcp](https://github.com/genomoncology/biomcp) 🐍 ☁️ - เซิร์ฟเวอร์วิจัยชีวการแพทย์ให้เข้าถึง PubMed, ClinicalTrials.gov, และ MyVariant.info
- [hellokaton/unsplash-mcp-server](https://github.com/hellokaton/unsplash-mcp-server)) 🐍 ☁️ - MCP server สำหรับค้นหารูปภาพ Unsplash
- [Ihor-Sokoliuk/MCP-SearXNG](https://github.com/ihor-sokoliuk/mcp-searxng) 📇 🏠/☁️ - เซิร์ฟเวอร์ Model Context Protocol สำหรับ [SearXNG](https://docs.searxng.org)
- [isnow890/naver-search-mcp](https://github.com/isnow890/naver-search-mcp) 📇 ☁️ - MCP server สำหรับ Naver Search API รองรับค้นหา blog, ข่าว, ช็อปปิ้ง และ DataLab analytics
- [jae-jae/fetcher-mcp](https://github.com/jae-jae/fetcher-mcp) 📇 🏠 - MCP server สำหรับดึงเนื้อหาเว็บด้วย Playwright headless browser รองรับการเรนเดอร์ Javascript และดึงเนื้อหาอัจฉริยะ ส่งออกเป็น Markdown หรือ HTML
- [jae-jae/g-search-mcp](https://github.com/jae-jae/g-search-mcp) 📇 🏠 - MCP server สำหรับค้นหา Google หลายคำค้นพร้อมกันแบบขนาน
- [ananddtyagi/webpage-screenshot-mcp](https://github.com/ananddtyagi/webpage-screenshot-mcp) 📇 🏠 - MCP server สำหรับจับภาพหน้าจอเว็บเพจ เพื่อใช้เป็น feedback ระหว่างพัฒนา UI
- [leehanchung/bing-search-mcp](https://github.com/leehanchung/bing-search-mcp) 📇 ☁️ - ความสามารถค้นหาเว็บด้วย Microsoft Bing Search API
- [kagisearch/kagimcp](https://github.com/kagisearch/kagimcp) ☁️ 📇 – เซิร์ฟเวอร์ Kagi Search MCP อย่างเป็นทางการ
- [kshern/mcp-tavily](https://github.com/kshern/mcp-tavily.git) ☁️ 📇 – Tavily AI search API
- [mikechao/brave-search-mcp](https://github.com/mikechao/brave-search-mcp) 📇 ☁️ - ความสามารถในการค้นหาเว็บ, รูปภาพ, ข่าว, วิดีโอ และสถานที่น่าสนใจในท้องถิ่นโดยใช้ Brave's Search API
- [emicklei/melrose-mcp](https://github.com/emicklei/melrose-mcp) 🏎️ 🏠 - เล่น [Melrōse](https://melrōse.org) music expressions ในรูปแบบ MIDI
- [modelcontextprotocol/server-brave-search](https://github.com/modelcontextprotocol/servers/tree/main/src/brave-search) 📇 ☁️ - ความสามารถในการค้นหาเว็บด้วย Brave's Search API
- [modelcontextprotocol/server-fetch](https://github.com/modelcontextprotocol/servers/tree/main/src/fetch) 🐍 🏠 ☁️ - ดึงและประมวลผลเนื้อหาบนเว็บอย่างมีประสิทธิภาพเพื่อการบริโภคของ AI
- [mzxrai/mcp-webresearch](https://github.com/mzxrai/mcp-webresearch) 🔍📚 - ค้นหา Google และวิจัยเว็บเชิงลึกในทุกหัวข้อ
- [nickclyde/duckduckgo-mcp-server](https://github.com/nickclyde/duckduckgo-mcp-server) 🐍 ☁️ - ค้นหาเว็บด้วย DuckDuckGo
- [r-huijts/opentk-mcp](https://github.com/r-huijts/opentk-mcp) 📇 ☁️ - เข้าถึงข้อมูลรัฐสภาเนเธอร์แลนด์ (Tweede Kamer) รวมถึงเอกสาร, การอภิปราย, กิจกรรม และกรณีทางกฎหมายผ่านความสามารถในการค้นหาแบบมีโครงสร้าง (อิงตามโครงการ opentk โดย Bert Hubert)
- [reading-plus-ai/mcp-server-deep-research](https://github.com/reading-plus-ai/mcp-server-deep-research) 📇 ☁️ - MCP server ที่ให้บริการวิจัยเชิงลึกแบบอัตโนมัติคล้าย OpenAI/Perplexity, ขยายคำค้นหาแบบมีโครงสร้าง และรายงานสรุปแบบกระชับ
- [SecretiveShell/MCP-searxng](https://github.com/SecretiveShell/MCP-searxng) 🐍 🏠 - MCP Server สำหรับเชื่อมต่อกับ searXNG instances
- [takashiishida/arxiv-latex-mcp](https://github.com/takashiishida/arxiv-latex-mcp) 🐍 ☁️ - รับต้นฉบับ LaTeX ของงาน arXiv เพื่อจัดการเนื้อหาและสมการทางคณิตศาสตร์
- [the0807/GeekNews-MCP-Server](https://github.com/the0807/GeekNews-MCP-Server) 🐍 ☁️ - MCP Server ที่ดึงและประมวลผลข้อมูลข่าวจากเว็บไซต์ GeekNews
- [tinyfish-io/agentql-mcp](https://github.com/tinyfish-io/agentql-mcp) 🎖️ 📇 ☁️ - MCP server ที่ให้ความสามารถในการดึงข้อมูลของ [AgentQL](https://agentql.com)
- [Tomatio13/mcp-server-tavily](https://github.com/Tomatio13/mcp-server-tavily) ☁️ 🐍 – Tavily AI search API
- [vectorize-io/vectorize-mcp-server](https://github.com/vectorize-io/vectorize-mcp-server/) ☁️ 📇 - [Vectorize](https://vectorize.io) MCP server สำหรับการค้นคืนข้อมูลขั้นสูง, วิจัยเชิงลึกส่วนตัว, แยกไฟล์ Anything-to-Markdown และแยกข้อความเป็นชิ้นๆ
- [webscraping-ai/webscraping-ai-mcp-server](https://github.com/webscraping-ai/webscraping-ai-mcp-server) 🎖️ 📇 ☁️ - โต้ตอบกับ [WebScraping.ai](https://webscraping.ai) สำหรับการดึงข้อมูลและ scraping จากเว็บ
- [zhsama/duckduckgo-mcp-server](https://github.com/zhsama/duckduckgo-mpc-server/) 📇 🏠 ☁️ - นี่คือ MCP server ที่พัฒนาด้วย TypeScript ให้บริการฟังก์ชันการค้นหา DuckDuckGo
- [zoomeye-ai/mcp_zoomeye](https://github.com/zoomeye-ai/mcp_zoomeye) 📇 ☁️ - ค้นหาข้อมูลสินทรัพย์เครือข่ายโดย ZoomEye MCP Server
- [yamanoku/baseline-mcp-server](https://github.com/yamanoku/baseline-mcp-server) 📇 🏠 - MCP server สำหรับค้นหา Baseline status ด้วย Web Platform API
- [longevity-genie/biothings-mcp](https://github.com/longevity-genie/biothings-mcp) 🐍 ☁️ - MCP server สำหรับเชื่อมต่อกับ BioThings API รวมถึงยีน, สารพันธุกรรม, ยา และข้อมูลอนุกรมวิธาน
- [joelio/stocky](https://github.com/joelio/stocky) 🐍 ☁️ 🏠 - MCP server สำหรับค้นหาและดาวน์โหลดภาพสต็อกปลอดค่าลิขสิทธิ์จาก Pexels และ Unsplash มีฟีเจอร์ค้นหาหลายผู้ให้บริการ, เมทาดาต้าที่หลากหลาย, รองรับการแบ่งหน้า และประสิทธิภาพแบบ async เพื่อให้ AI assistant ค้นหาและเข้าถึงภาพคุณภาพสูง

### 🔒 <a name="security"></a>Security

- [LaurieWired/GhidraMCP](https://github.com/LaurieWired/GhidraMCP) ☕ 🏠 - Model Context Protocol server สำหรับ Ghidra ที่ช่วยให้ LLMs ทำ reverse engineer แอปพลิเคชันโดยอัตโนมัติ มีเครื่องมือสำหรับ decompile ไบนารี, เปลี่ยนชื่อ method และข้อมูล, แสดง method, class, import และ export
- [dkvdm/onepassword-mcp-server](https://github.com/dkvdm/onepassword-mcp-server) - MCP server ที่ช่วยให้ดึงข้อมูลรับรองจาก 1Password อย่างปลอดภัยมาใช้กับ Agentic AI
- [firstorderai/authenticator_mcp](https://github.com/firstorderai/authenticator_mcp) 📇 🏠 🍎 🪟 🐧 – MCP (Model Context Protocol) server ที่ปลอดภัยซึ่งช่วยให้ AI agent โต้ตอบกับแอป Authenticator ได้
- [13bm/GhidraMCP](https://github.com/13bm/GhidraMCP) 🐍 ☕ 🏠 - MCP server สำหรับเชื่อมต่อ Ghidra กับ AI assistants ปลั๊กอินนี้ช่วยให้วิเคราะห์ไบนารีด้วยเครื่องมือสำหรับตรวจสอบฟังก์ชัน, decompilation, สำรวจหน่วยความจำ, และวิเคราะห์ import/export ผ่าน Model Context Protocol
- [atomicchonk/roadrecon_mcp_server](https://github.com/atomicchonk/roadrecon_mcp_server) 🐍 🪟 🏠 MCP server สำหรับวิเคราะห์ผลลัพธ์ ROADrecon จากการ enumerate tenant ของ Azure
- [BurtTheCoder/mcp-dnstwist](https://github.com/BurtTheCoder/mcp-dnstwist) 📇 🪟 ☁️ - MCP server สำหรับ dnstwist, เครื่องมือ DNS fuzzing ทรงพลังสำหรับตรวจจับ typosquatting, phishing และการจารกรรมองค์กร
- [BurtTheCoder/mcp-maigret](https://github.com/BurtTheCoder/mcp-maigret) 📇 🪟 ☁️ - MCP server สำหรับ maigret, เครื่องมือ OSINT ที่รวบรวมข้อมูลบัญชีผู้ใช้จากแหล่งสาธารณะต่างๆ พร้อมเครื่องมือค้นหา username ข้ามโซเชียลเน็ตเวิร์กและวิเคราะห์ URL
- [BurtTheCoder/mcp-shodan](https://github.com/BurtTheCoder/mcp-shodan) 📇 🪟 ☁️ - MCP server สำหรับค้นหา Shodan API และ Shodan CVEDB มีเครื่องมือสำหรับ lookup IP, ค้นหาอุปกรณ์, lookup DNS, ค้นหาช่องโหว่, lookup CPE และอื่นๆ
- [BurtTheCoder/mcp-virustotal](https://github.com/BurtTheCoder/mcp-virustotal) 📇 🪟 ☁️ - MCP server สำหรับค้นหา VirusTotal API เครื่องมือสำหรับสแกน URL, วิเคราะห์ hash ของไฟล์ และดึงรายงานที่อยู่ IP
- [fosdickio/binary_ninja_mcp](https://github.com/fosdickio/binary_ninja_mcp) 🐍 🏠 🍎 🪟 🐧 - ปลั๊กอิน Binary Ninja, MCP server และ bridge ที่ผสาน [Binary Ninja](https://binary.ninja) กับ MCP client ให้คุณอัตโนมัติกระบวนการวิเคราะห์ไบนารีและ reverse engineering
- [fr0gger/MCP_Security](https://github.com/fr0gger/MCP_Security) 📇 ☁️ - MCP server สำหรับค้นหา ORKL API มีเครื่องมือสำหรับดึง threat report, วิเคราะห์ threat actor และดึงแหล่งข้อมูล intelligence
- [gbrigandi/mcp-server-cortex](https://github.com/gbrigandi/mcp-server-cortex) 🦀 🏠 🚨 🍎 🪟 🐧 - MCP server ด้วยภาษา Rust สำหรับเชื่อมต่อ Cortex เพื่อการวิเคราะห์ observable และตอบสนองความปลอดภัยแบบอัตโนมัติผ่าน AI
- [gbrigandi/mcp-server-thehive](https://github.com/gbrigandi/mcp-server-thehive) 🦀 🏠 🚨 🍎 🪟 🐧 - MCP server ด้วยภาษา Rust สำหรับเชื่อมต่อ TheHive เพื่อการจัดการเหตุการณ์และคดีด้านความปลอดภัยร่วมกับ AI
- [gbrigandi/mcp-server-wazuh](https://github.com/gbrigandi/mcp-server-wazuh) 🦀 🏠 🚨 🍎 🪟 🐧 - MCP server ด้วยภาษา Rust เชื่อม Wazuh SIEM กับ AI assistants เพื่อแจ้งเตือนความปลอดภัยและข้อมูลเหตุการณ์แบบเรียลไทม์
- [intruder-io/intruder-mcp](https://github.com/intruder-io/intruder-mcp) 🐍 ☁️ - MCP server สำหรับเข้าถึง [Intruder](https://www.intruder.io/), ช่วยให้คุณระบุ, เข้าใจ และแก้ไขช่องโหว่ด้านความปลอดภัยในโครงสร้างพื้นฐาน
- [jyjune/mcp_vms](https://github.com/jyjune/mcp_vms) 🐍 🏠 🪟 - MCP server (Model Context Protocol) สำหรับเชื่อมต่อโปรแกรมบันทึกกล้องวงจรปิด (VMS) เพื่อดึงวิดีโอบันทึกและถ่ายทอดสด พร้อมเครื่องมือควบคุม VMS เช่นแสดงไดอะล็อกสดหรือย้อนหลังตามช่องและเวลาที่กำหนด
- [qianniuspace/mcp-security-audit](https://github.com/qianniuspace/mcp-security-audit) 📇 ☁️ MCP Server (Model Context Protocol) ทรงพลังสำหรับตรวจสอบความปลอดภัยของ dependency npm package พร้อมผสาน npm registry ระยะไกลสำหรับเช็คความปลอดภัยแบบเรียลไทม์
- [semgrep/mcp](https://github.com/semgrep/mcp) 📇 ☁️ ให้ AI agent สแกนโค้ดหาช่องโหว่ด้านความปลอดภัยโดยใช้ [Semgrep](https://semgrep.dev)
- [slouchd/cyberchef-api-mcp-server](https://github.com/slouchd/cyberchef-api-mcp-server) 🐍 ☁️ - MCP server สำหรับโต้ตอบกับ CyberChef server API เพื่อให้ MCP client ใช้งานฟังก์ชัน CyberChef ได้
- [mrexodia/ida-pro-mcp](https://github.com/mrexodia/ida-pro-mcp) 🐍 🏠 - MCP server สำหรับ IDA Pro ให้คุณวิเคราะห์ไบนารีกับ AI assistants ปลั๊กอินนี้รองรับ decompilation, disassembly และการสร้างรายงานวิเคราะห์มัลแวร์อัตโนมัติ
- [rad-security/mcp-server](https://github.com/rad-security/mcp-server) 📇 ☁️ - MCP server สำหรับ RAD Security ให้ข้อมูลเชิงลึกด้านความปลอดภัยบน Kubernetes และคลาวด์ด้วย AI พร้อมเครื่องมือ query Rad Security API และดึง security finding, รายงาน, ข้อมูล runtime และอื่นๆ
- [securityfortech/secops-mcp](https://github.com/securityfortech/secops-mcp) 🐍 🏠 - ชุดเครื่องมือทดสอบความปลอดภัยแบบ all-in-one ที่รวมเครื่องมือ open source ชื่อดังไว้ใน MCP interface เดียว เชื่อมกับ AI agent เพื่อทำ pentest, bug bounty, threat hunting ฯลฯ
- [roadwy/cve-search_mcp](https://github.com/roadwy/cve-search_mcp) 🐍 🏠 - MCP server (Model Context Protocol) สำหรับค้นหา CVE-Search API พร้อมเข้าถึง CVE-Search อย่างครบถ้วน, ค้นหาผู้ขายและสินค้า, ดึง CVE ด้วย CVE-ID, ดู CVE ล่าสุดที่อัปเดต
- [StacklokLabs/osv-mcp](https://github.com/StacklokLabs/osv-mcp) 🏎️ ☁️ - เข้าถึงฐานข้อมูล OSV (Open Source Vulnerabilities) สำหรับข้อมูลช่องโหว่ ค้นหาช่องโหว่ด้วย package version หรือ commit, ค้นหาแบบกลุ่ม และดูรายละเอียดด้วย ID
- [nickpending/mcp-recon](https://github.com/nickpending/mcp-recon) 🏎️ 🏠 - อินเทอร์เฟซ recon แบบสนทนาและ MCP server ด้วย httpx และ asnmap รองรับการ recon หลายระดับสำหรับวิเคราะห์โดเมน, header ด้านความปลอดภัย, ใบรับรอง และ ASN lookup
- [Gaffx/volatility-mcp](https://github.com/Gaffx/volatility-mcp) - MCP server สำหรับ Volatility 3.x ให้คุณวิเคราะห์ forensic หน่วยความจำกับ AI assistant ได้อย่างไร้ขีดจำกัด ปลั๊กอินเช่น pslist และ netscan ใช้งานได้ผ่าน REST API และ LLM
- [co-browser/attestable-mcp-server](https://github.com/co-browser/attestable-mcp-server) 🐍 🏠 ☁️ 🐧 - MCP server ที่ทำงานใน trusted execution environment (TEE) ด้วย Gramine สาธิต remote attestation ด้วย [RA-TLS](https://gramine.readthedocs.io/en/stable/attestation.html) ให้ MCP client ตรวจสอบเซิร์ฟเวอร์ก่อนเชื่อมต่อ
- [zinja-coder/jadx-ai-mcp](https://github.com/zinja-coder/jadx-ai-mcp) ☕ 🏠 - JADX-AI-MCP คือปลั๊กอินและ MCP Server สำหรับ JADX decompiler ที่เชื่อมกับ Model Context Protocol (MCP) เพื่อรองรับ reverse engineering แบบเรียลไทม์กับ LLMs เช่น Claude
- [zinja-coder/apktool-mcp-server](https://github.com/zinja-coder/apktool-mcp-server) 🐍 🏠 - APKTool MCP Server คือ MCP server สำหรับ Apk Tool เพื่อการอัตโนมัติในการ reverse engineer ไฟล์ APK ของ Android

### 🌐 <a name="social-media"></a>Social Media

ผสานกับแพลตฟอร์มโซเชียลมีเดียเพื่อให้สามารถโพสต์, วิเคราะห์ และจัดการปฏิสัมพันธ์ เปิดทางให้ AI ขับเคลื่อนอัตโนมัติด้านโซเชียลมีเดีย

- [macrocosm-os/macrocosmos-mcp](https://github.com/macrocosm-os/macrocosmos-mcp) - 🎖️ 🐍 ☁️ เข้าถึงข้อมูล X/Reddit/YouTube แบบเรียลไทม์ในแอปพลิเคชัน LLM ของคุณ ด้วยวลีค้นหา, ผู้ใช้ และการกรองวันที่
- [kunallunia/twitter-mcp](https://github.com/LuniaKunal/mcp-twitter) 🐍 🏠 - โซลูชันบริหาร Twitter ครบวงจร ให้เข้าถึง timeline, ดึงทวีตผู้ใช้, ตรวจสอบ hashtag, วิเคราะห์บทสนทนา, ส่งข้อความตรง, วิเคราะห์ความรู้สึกของโพสต์ และควบคุมวงจรโพสต์ทั้งหมดผ่าน API เดียว
- [HagaiHen/facebook-mcp-server](https://github.com/HagaiHen/facebook-mcp-server) 🐍 ☁️ - ผสานกับ Facebook Pages เพื่อบริหารโพสต์, ความคิดเห็น และสถิติการมีส่วนร่วมผ่าน Graph API สำหรับการจัดการโซเชียลมีเดียอย่างมีประสิทธิภาพ
- [gwbischof/bluesky-social-mcp](https://github.com/gwbischof/bluesky-social-mcp) 🐍 🏠 - MCP server สำหรับโต้ตอบกับ Bluesky ผ่าน atproto client

### 🏃 <a name="sports"></a>Sports

เครื่องมือสำหรับเข้าถึงข้อมูลกีฬา, ผลการแข่งขัน และสถิติต่างๆ

- [mikechao/balldontlie-mcp](https://github.com/mikechao/balldontlie-mcp) 📇 - MCP server ที่ผสาน balldontlie api เพื่อให้ข้อมูลผู้เล่น, ทีม และเกมสำหรับ NBA, NFL และ MLB
- [r-huijts/firstcycling-mcp](https://github.com/r-huijts/firstcycling-mcp) 📇 ☁️ - เข้าถึงข้อมูลการแข่งขันจักรยาน, ผลการแข่งขัน และสถิติผ่านภาษาธรรมชาติ ฟีเจอร์เช่นดึงรายชื่อผู้เริ่ม, ผลการแข่งขัน และข้อมูลนักแข่งจาก firstcycling.com
- [r-huijts/strava-mcp](https://github.com/r-huijts/strava-mcp) 📇 ☁️ - MCP server (Model Context Protocol) ที่เชื่อมต่อกับ Strava API ให้เครื่องมือเข้าถึงข้อมูล Strava ผ่าน LLMs
- [willvelida/mcp-afl-server](https://github.com/willvelida/mcp-afl-server) ☁️ - MCP server ที่ผสานกับ Squiggle API ให้ข้อมูลทีม AFL ออสเตรเลีย, อันดับ, ผล, คำแนะนำ และแรงค์กิ้ง
- [guillochon/mlb-api-mcp](https://github.com/guillochon/mlb-api-mcp) 🐍 🏠 - MCP server ที่เป็น proxy ไปยัง MLB API แบบเปิด ให้ข้อมูลผู้เล่น, สถิติ และข้อมูลเกม

### 🎧 <a name="support-and-service-management"></a>Support & Service Management

เครื่องมือสำหรับจัดการงานบริการลูกค้า, การจัดการบริการ IT และงาน helpdesk

- [effytech/freshdesk-mcp](https://github.com/effytech/freshdesk_mcp) 🐍 ☁️ - MCP server ที่ผสานกับ Freshdesk ให้ AI โต้ตอบกับโมดูล Freshdesk และดำเนินการสนับสนุนต่างๆ
- [nguyenvanduocit/jira-mcp](https://github.com/nguyenvanduocit/jira-mcp) 🏎️ ☁️ - MCP connector ภาษา Go สำหรับ Jira ให้ AI assistant อย่าง Claude โต้ตอบกับ Atlassian Jira ได้สะดวก รองรับการจัดการ issue, วางแผน sprint และเปลี่ยน workflow
- [sooperset/mcp-atlassian](https://github.com/sooperset/mcp-atlassian) 🐍 ☁️ - MCP server สำหรับผลิตภัณฑ์ Atlassian (Confluence และ Jira) รองรับ Confluence Cloud, Jira Cloud และ Jira Server/Data Center มีเครื่องมือค้นหา, อ่าน, สร้าง, จัดการเนื้อหาข้าม workspace อย่างครบถ้วน

### 🌎 <a name="translation-services"></a>Translation Services

เครื่องมือและบริการแปลภาษา เพื่อให้ AI assistant แปลเนื้อหาระหว่างภาษาต่างๆ

- [translated/lara-mcp](https://github.com/translated/lara-mcp) 🎖️ 📇 ☁️ - MCP Server สำหรับ Lara Translate API ให้ความสามารถแปลภาษาทรงพลัง รองรับการตรวจสอบภาษาและแปลตามบริบท
- [mmntm/weblate-mcp](https://github.com/mmntm/weblate-mcp) 📇 ☁️ - MCP server ครบวงจรสำหรับบริหารงานแปลบน Weblate ช่วยให้ AI assistant แปล, จัดการโปรเจกต์ และค้นหาเนื้อหาพร้อมแปลงฟอร์แมตอัจฉริยะ

### 🎧 <a name="text-to-speech"></a>Text-to-Speech

เครื่องมือสำหรับแปลงข้อความเป็นเสียงและในทางกลับกัน

- [mberg/kokoro-tts-mcp](https://github.com/mberg/kokoro-tts-mcp) 🐍 🏠 - MCP Server ที่ใช้โมเดล Kokoro TTS แบบ open weight สำหรับแปลงข้อความเป็นเสียง (text-to-speech) รองรับแปลงข้อความเป็น MP3 ใน local หรืออัปโหลดอัตโนมัติขึ้น S3
- [mbailey/voice-mcp](https://github.com/mbailey/voice-mcp) 🐍 🏠 - เซิร์ฟเวอร์โต้ตอบด้วยเสียงแบบสมบูรณ์ รองรับ speech-to-text, text-to-speech และสนทนาเสียงเรียลไทม์ผ่านไมโครโฟน, API ที่เข้ากันได้กับ OpenAI และ LiveKit

### 🚆 <a name="travel-and-transportation"></a>Travel & Transportation

เข้าถึงข้อมูลการเดินทางและการขนส่ง สอบถามตารางเวลา, เส้นทาง และข้อมูลเดินทางแบบเรียลไทม์
- [Airbnb MCP Server](https://github.com/openbnb-org/mcp-server-airbnb) 📇 ☁️ - ให้เครื่องมือค้นหา Airbnb และดึงรายละเอียดที่พัก
- [KyrieTangSheng/mcp-server-nationalparks](https://github.com/KyrieTangSheng/mcp-server-nationalparks) 📇 ☁️ - การเชื่อมต่อกับ National Park Service API ให้ข้อมูลล่าสุดของรายละเอียดอุทยาน, การแจ้งเตือน, ศูนย์บริการนักท่องเที่ยว, พื้นที่ตั้งแคมป์ และกิจกรรมต่าง ๆ สำหรับอุทยานแห่งชาติในสหรัฐอเมริกา
- [NS Travel Information MCP Server](https://github.com/r-huijts/ns-mcp-server) 📇 ☁️ - เข้าถึงข้อมูลการเดินทาง ตารางเวลา และอัปเดตแบบเรียลไทม์ของ Dutch Railways (NS)
- [pab1it0/tripadvisor-mcp](https://github.com/pab1it0/tripadvisor-mcp) 📇 🐍 - MCP server ที่ช่วยให้ LLMs สามารถโต้ตอบกับ Tripadvisor API รองรับข้อมูลสถานที่ รีวิว และรูปภาพผ่านอินเทอร์เฟซ MCP มาตรฐาน
- [lucygoodchild/mcp-national-rail](https://github.com/lucygoodchild/mcp-national-rail) 📇 ☁️ - MCP server สำหรับบริการรถไฟ National Rail ของสหราชอาณาจักร ให้ข้อมูลตารางรถไฟและข้อมูลการเดินทางแบบสด โดยเชื่อมต่อกับ Realtime Trains API

### 🔄 <a name="version-control"></a>Version Control

โต้ตอบกับ Git repository และแพลตฟอร์มควบคุมเวอร์ชัน ช่วยให้สามารถจัดการ repository วิเคราะห์โค้ด จัดการ pull request ติดตาม issue และดำเนินการอื่น ๆ ผ่าน API มาตรฐาน

- [adhikasp/mcp-git-ingest](https://github.com/adhikasp/mcp-git-ingest) 🐍 🏠 - อ่านและวิเคราะห์ repository บน GitHub ด้วย LLM ของคุณ
- [ddukbg/github-enterprise-mcp](https://github.com/ddukbg/github-enterprise-mcp) 📇 ☁️ 🏠 - MCP server สำหรับเชื่อมต่อกับ GitHub Enterprise API
- [gitea/gitea-mcp](https://gitea.com/gitea/gitea-mcp) 🎖️ 🏎️ ☁️ 🏠 🍎 🪟 🐧 - โต้ตอบกับ Gitea instance ด้วย MCP
- [github/github-mcp-server](https://github.com/github/github-mcp-server) 📇 ☁️ - GitHub server อย่างเป็นทางการสำหรับเชื่อมต่อการจัดการ repository, PR, issue และอื่น ๆ
- [kopfrechner/gitlab-mr-mcp](https://github.com/kopfrechner/gitlab-mr-mcp) 📇 ☁️ - โต้ตอบกับ issue และ merge request ของโปรเจ็กต์ GitLab ได้อย่างไร้รอยต่อ
- [modelcontextprotocol/server-git](https://github.com/modelcontextprotocol/servers/tree/main/src/git) 🐍 🏠 - ดำเนินการกับ Git repository โดยตรง รวมถึงอ่าน ค้นหา และวิเคราะห์ repository ในเครื่อง
- [modelcontextprotocol/server-gitlab](https://github.com/modelcontextprotocol/servers/tree/main/src/gitlab) 📇 ☁️ 🏠 - การเชื่อมต่อกับแพลตฟอร์ม GitLab สำหรับการจัดการโปรเจ็กต์และ CI/CD
- [oschina/mcp-gitee](https://github.com/oschina/gitee) 🏎️ ☁️ 🏠 - การเชื่อมต่อกับ Gitee API จัดการ repository, issue, pull request และอื่น ๆ
- [Tiberriver256/mcp-server-azure-devops](https://github.com/Tiberriver256/mcp-server-azure-devops) 📇 ☁️ - เชื่อมต่อกับ Azure DevOps เพื่อจัดการ repository, work item และ pipeline
- [kaiyuanxiaobing/atomgit-mcp-server](https://github.com/kaiyuanxiaobing/atomgit-mcp-server) 📇 ☁️ - AtomGit server อย่างเป็นทางการสำหรับจัดการ repository, PR, issue, branch, label และอื่น ๆ

### 🛠️ <a name="other-tools-and-integrations"></a>Other Tools and Integrations

- [AbdelStark/bitcoin-mcp](https://github.com/AbdelStark/bitcoin-mcp) - ₿ MCP server ที่ช่วยให้ AI โต้ตอบกับ Bitcoin สามารถสร้างคีย์ ตรวจสอบ address ถอดรหัสธุรกรรม ตรวจสอบ blockchain และอื่น ๆ
- [akseyh/bear-mcp-server](https://github.com/akseyh/bear-mcp-server) - ให้ AI อ่านโน้ตจาก Bear Notes (สำหรับ macOS เท่านั้น)
- [allenporter/mcp-server-home-assistant](https://github.com/allenporter/mcp-server-home-assistant) 🐍 🏠 - เปิดเผย Home Assistant voice intent ทั้งหมดผ่าน MCP server เพื่อควบคุมบ้าน
- [Amazon Bedrock Nova Canvas](https://github.com/zxkane/mcp-server-amazon-bedrock) 📇 ☁️ - ใช้โมเดล Amazon Nova Canvas สำหรับสร้างภาพ
- [amidabuddha/unichat-mcp-server](https://github.com/amidabuddha/unichat-mcp-server) 🐍/📇 ☁️ - ส่งคำขอไปยัง OpenAI, MistralAI, Anthropic, xAI, Google AI หรือ DeepSeek โดยใช้ MCP ผ่านเครื่องมือหรือ prompt ที่กำหนดไว้ ต้องใช้ Vendor API key
- [anaisbetts/mcp-installer](https://github.com/anaisbetts/mcp-installer) 🐍 🏠 - MCP server ที่ติดตั้ง MCP server ตัวอื่นให้คุณโดยอัตโนมัติ
- [anaisbetts/mcp-youtube](https://github.com/anaisbetts/mcp-youtube) 📇 ☁️ - ดึงซับไตเติลจาก YouTube
- [andybrandt/mcp-simple-openai-assistant](https://github.com/andybrandt/mcp-simple-openai-assistant) - 🐍 ☁️  MCP สำหรับพูดคุยกับ OpenAI assistant (Claude สามารถใช้ GPT model ใดก็ได้เป็นผู้ช่วย)
- [andybrandt/mcp-simple-timeserver](https://github.com/andybrandt/mcp-simple-timeserver) 🐍 🏠☁️ - MCP server สำหรับตรวจสอบเวลาท้องถิ่นบนเครื่องลูกข่ายหรือเวลา UTC ปัจจุบันจาก NTP server
- [apify/actors-mcp-server](https://github.com/apify/actors-mcp-server) 📇 ☁️ - ใช้เครื่องมือบนคลาวด์กว่า 3,000+ รายการ (Actors) เพื่อดึงข้อมูลจากเว็บไซต์ อีคอมเมิร์ซ โซเชียลมีเดีย เสิร์ชเอนจิน แผนที่ และอื่น ๆ
- [apinetwork/piapi-mcp-server](https://github.com/apinetwork/piapi-mcp-server) 📇 ☁️ PiAPI MCP server ช่วยให้ผู้ใช้สร้างสื่อผ่าน Midjourney/Flux/Kling/Hunyuan/Udio/Trellis ได้โดยตรงจาก Claude หรือแอปที่รองรับ MCP อื่น ๆ
- [awkoy/replicate-flux-mcp](https://github.com/awkoy/replicate-flux-mcp) 📇 ☁️ - ให้ความสามารถในการสร้างภาพผ่าน Replicate API
- [awwaiid/mcp-server-taskwarrior](https://github.com/awwaiid/mcp-server-taskwarrior) 🏠 📇 - MCP server สำหรับใช้งาน taskwarrior ในเครื่อง (เพิ่ม แก้ไข ลบงาน)
- [baba786/phabricator-mcp-server](https://github.com/baba786/phabricator-mcp-server) 🐍 ☁️ - โต้ตอบกับ Phabricator API
- [Badhansen/notion-mcp](https://github.com/Badhansen/notion-mcp) 🐍 ☁️ - MCP server สำหรับเชื่อมต่อกับ Notion API เพื่อจัดการ todo ส่วนตัวอย่างมีประสิทธิภาพ
- [bart6114/my-bear-mcp-server](https://github.com/bart6114/my-bear-mcp-server/) 📇 🏠 🍎 - อ่านโน้ตและแท็กจากแอป Bear Note ผ่านการเชื่อมต่อโดยตรงกับฐานข้อมูล sqlitedb ของ Bear
- [billster45/mcp-chatgpt-responses](https://github.com/billster45/mcp-chatgpt-responses) 🐍 ☁️ - MCP server สำหรับ Claude เพื่อพูดคุยกับ ChatGPT และใช้งานความสามารถค้นเว็บ
- [blurrah/mcp-graphql](https://github.com/blurrah/mcp-graphql) 📇 ☁️ - ให้ AI สามารถ query ข้อมูลกับ GraphQL server
- [calclavia/mcp-obsidian](https://github.com/calclavia/mcp-obsidian) 📇 🏠 - ตัวเชื่อมต่อที่ให้ Claude Desktop (หรือ MCP client ใด ๆ) อ่านและค้นหา directory ที่มี Markdown note (เช่น Obsidian vault)
- [chrishayuk/mcp-cli](https://github.com/chrishayuk/mcp-cli) 🐍 🏠 - CLI tool สำหรับทดสอบ MCP server
- [danhilse/notion_mcp](https://github.com/danhilse/notion_mcp) 🐍 ☁️ - เชื่อมต่อกับ Notion API เพื่อจัดการ todo ส่วนตัว
- [EKibort/wrike-mcp-server](https://github.com/EKibort/wrike-mcp-server) - 🐍 🏠 - การนำ Wrike MCP server แบบ lightweight มาโต้ตอบกับ task ผ่าน Public API
- [ekkyarmandi/ticktick-mcp](https://github.com/ekkyarmandi/ticktick-mcp) 🐍 ☁️ - [TickTick](https://ticktick.com/) MCP server สำหรับเชื่อมต่อกับ TickTick API เพื่อจัดการโปรเจ็กต์และงานส่วนตัว
- [esignaturescom/mcp-server-esignatures](https://github.com/esignaturescom/mcp-server-esignatures) 🐍 ☁️️ - จัดการสัญญาและเทมเพลตสำหรับร่าง ตรวจสอบ และส่งสัญญาผูกพันผ่าน eSignatures API
- [evalstate/mcp-miro](https://github.com/evalstate/mcp-miro) 📇 ☁️ - เข้าถึง MIRO whiteboard สร้างและอ่านรายการแบบกลุ่ม ต้องใช้ OAUTH key สำหรับ REST API
- [feuerdev/keep-mcp](https://github.com/feuerdev/keep-mcp) 🐍 ☁️ - อ่าน สร้าง อัปเดต และลบโน้ต Google Keep
- [future-audiences/wikimedia-enterprise-model-context-protocol](https://gitlab.wikimedia.org/repos/future-audiences/wikimedia-enterprise-model-context-protocol) 🐍 ☁️  - API สำหรับค้นหาบทความ Wikipedia
- [fotoetienne/gqai](https://github.com/fotoetienne/gqai) 🏎 🏠 - สร้างเครื่องมือจาก GraphQL query/mutation ปกติและ gqai จะสร้าง MCP server ให้โดยอัตโนมัติ
- [githejie/mcp-server-calculator](https://github.com/githejie/mcp-server-calculator) 🐍 🏠 - server นี้ช่วยให้ LLMs ใช้เครื่องคิดเลขสำหรับการคำนวณเชิงตัวเลขที่แม่นยำ
- [gotoolkits/DifyWorkflow](https://github.com/gotoolkits/mcp-difyworkflow-server) - 🏎️ ☁️ เครื่องมือสำหรับ query และรัน Dify workflow
- [hiromitsusasaki/raindrop-io-mcp-server](https://github.com/hiromitsusasaki/raindrop-io-mcp-server) 📇 ☁️ - เชื่อมต่อ Raindrop.io bookmarks กับ LLMs ผ่าน MCP
- [hmk/attio-mcp-server](https://github.com/hmk/attio-mcp-server) - 📇 ☁️ ให้ AI จัดการระเบียนและโน้ตใน Attio CRM ได้
- [isaacwasserman/mcp-vegalite-server](https://github.com/isaacwasserman/mcp-vegalite-server) 🐍 🏠 - สร้าง visualization จากข้อมูลที่ดึงมาโดยใช้รูปแบบและ renderer ของ VegaLite
- [ivnvxd/mcp-server-odoo](https://github.com/ivnvxd/mcp-server-odoo) 🐍 ☁️/🏠 - เชื่อมต่อ AI assistant กับ Odoo ERP สำหรับเข้าถึงข้อมูลธุรกิจ จัดการระเบียน และอัตโนมัติกระบวนงาน
- [ivo-toby/contentful-mcp](https://github.com/ivo-toby/contentful-mcp) 📇 🏠 - อัปเดต สร้าง ลบเนื้อหา, content model และ asset ใน Contentful Space ของคุณ
- [j3k0/speech.sh](https://github.com/j3k0/speech.sh/blob/main/MCP_README.md) 🏠 - ให้ agent พูดออกเสียง พร้อมแจ้งเตือนสรุปเมื่อทำงานเสร็จ
- [jagan-shanmugam/climatiq-mcp-server](https://github.com/jagan-shanmugam/climatiq-mcp-server) 🐍 🏠 - MCP server สำหรับเข้าถึง Climatiq API เพื่อคำนวณค่าคาร์บอนแบบเรียลไทม์ ให้ AI assistant วิเคราะห์ผลกระทบต่อสิ่งแวดล้อมได้
- [johannesbrandenburger/typst-mcp](https://github.com/johannesbrandenburger/typst-mcp) 🐍 🏠 - MCP server สำหรับ Typst ระบบ typesetting แบบ markup ให้เครื่องมือแปลง LaTeX ↔ Typst, ตรวจสอบ syntax, และสร้างภาพจากโค้ด Typst
- [joshuarileydev/mac-apps-launcher-mcp-server](https://github.com/JoshuaRileyDev/mac-apps-launcher) 📇 🏠 - MCP server สำหรับแสดงรายการและเรียกใช้งานแอปบน MacOS
- [Harry-027/JotDown](https://github.com/Harry-027/JotDown) 🦀 🏠 - MCP server สำหรับสร้าง/อัปเดตหน้าใน Notion app และสร้าง mdBook อัตโนมัติจากข้อมูลที่มีโครงสร้าง
- [kelvin6365/plane-mcp-server](https://github.com/kelvin6365/plane-mcp-server) - 🏎️ 🏠 MCP Server สำหรับจัดการโปรเจ็กต์และ issue ผ่าน [Plane's](https://plane.so) API
- [kenliao94/mcp-server-rabbitmq](https://github.com/kenliao94/mcp-server-rabbitmq) 🐍 🏠 - โต้ตอบกับ RabbitMQ (จัดการผู้ดูแล ผลัก/ดึงข้อความ)
- [k-jarzyna/mcp-miro](https://github.com/k-jarzyna/mcp-miro) 📇 ☁️ - Miro MCP server ที่เปิดฟีเจอร์ทั้งหมดตาม Miro SDK
- [kimtth/mcp-remote-call-ping-pong](https://github.com/kimtth/mcp-remote-call-ping-pong) 🐍 🏠 - แอปทดลอง/การศึกษาสำหรับ server ping-pong โชว์การเรียก remote MCP
- [kj455/mcp-kibela](https://github.com/kj455/mcp-kibela) - 📇 ☁️ ให้ AI โต้ตอบกับ [Kibela](https://kibe.la/)
- [kiwamizamurai/mcp-kibela-server](https://github.com/kiwamizamurai/mcp-kibela-server) - 📇 ☁️ โต้ตอบกับ Kibela API อย่างเต็มประสิทธิภาพ
- [KS-GEN-AI/confluence-mcp-server](https://github.com/KS-GEN-AI/confluence-mcp-server) 📇 ☁️ 🍎 🪟 - ดึงข้อมูล Confluence ผ่าน CQL และอ่านหน้าเพจ
- [KS-GEN-AI/jira-mcp-server](https://github.com/KS-GEN-AI/jira-mcp-server) 📇 ☁️ 🍎 🪟 - อ่านข้อมูล Jira ผ่าน JQL และ API รวมถึงสร้าง/แก้ไข ticket
- [salesforce-mcp/salesforce-mcp](https://github.com/salesforce-mcp/salesforce-mcp) 🏠 ☁️ - MCP server สำหรับสาธิตการเชื่อมต่อกับ Salesforce instance
- [pollinations/chucknorris-mcp](https://github.com/pollinations/chucknorris-mcp) 📇 ☁️ - Prompts และ jailbreak สำหรับ LLM โดยใช้ schema แบบไดนามิก
- [louiscklaw/hko-mcp](https://github.com/louiscklaw/hko-mcp) 📇 🏠 - MCP server ตัวอย่างสำหรับดึงข้อมูลอากาศจาก Hong Kong Observatory
- [evalstate/mcp-hfspace](https://github.com/evalstate/mcp-hfspace) 📇 ☁️ - ใช้งาน HuggingFace Spaces ได้โดยตรงจาก Claude รองรับ Image, Audio, Text upload/download และงานด้าน Image/Chat/Vision
- [magarcia/mcp-server-giphy](https://github.com/magarcia/mcp-server-giphy) 📇 ☁️ - ค้นหาและดึง GIF จากคลัง Giphy ผ่าน Giphy API
- [integromat/make-mcp-server](https://github.com/integromat/make-mcp-server) 🎖️ 📇 🏠 - เปลี่ยน [Make](https://www.make.com/) scenario ให้เป็นเครื่องมือที่ AI assistant เรียกใช้ได้
- [marcelmarais/Spotify](https://github.com/marcelmarais/spotify-mcp-server) - 📇 🏠 ควบคุมการเล่นและจัดการ playlist บน Spotify
- [MarkusPfundstein/mcp-obsidian](https://github.com/MarkusPfundstein/mcp-obsidian) 🐍 ☁️ 🏠 - โต้ตอบกับ Obsidian ผ่าน REST API
- [emicklei/mcp-log-proxy](https://github.com/emicklei/mcp-log-proxy) 🏎️ 🏠 - MCP server proxy ที่มี Web UI แสดง message flow ทั้งหมด
- [quarkiverse/mcp-server-jfx](https://github.com/quarkiverse/quarkus-mcp-servers/tree/main/jfx) ☕ 🏠 - วาดรูปบน JavaFX canvas
- [mediar-ai/screenpipe](https://github.com/mediar-ai/screenpipe) - 🎖️ 🦀 🏠 🍎 ระบบ local-first สำหรับจับภาพหน้าจอ/เสียงพร้อมทำดัชนีตามเวลา เก็บใน SQL/embedding ค้นหาแบบ semantic วิเคราะห์ประวัติด้วย LLM และ trigger event - ช่วยสร้าง AI agent ที่เข้าใจ context ผ่านปลั๊กอิน NextJS
- [modelcontextprotocol/server-everything](https://github.com/modelcontextprotocol/servers/tree/main/src/everything) 📇 🏠 - MCP server ที่ทดสอบฟีเจอร์ทั้งหมดของ MCP protocol
- [mrjoshuak/godoc-mcp](https://github.com/mrjoshuak/godoc-mcp) 🏎️ 🏠 - Go documentation server ประหยัด token ให้ AI เข้าถึง docs/type ได้อย่างชาญฉลาดโดยไม่ต้องอ่านซอร์สไฟล์ทั้งหมด
- [mzxrai/mcp-openai](https://github.com/mzxrai/mcp-openai) 📇 ☁️ - สนทนากับโมเดล OpenAI อัจฉริยะ
- [NakaokaRei/swift-mcp-gui](https://github.com/NakaokaRei/swift-mcp-gui.git) 🏠 🍎 - MCP server สำหรับสั่งงานเช่นพิมพ์คีย์บอร์ดและควบคุมเมาส์
- [nguyenvanduocit/all-in-one-model-context-protocol](https://github.com/nguyenvanduocit/all-in-one-model-context-protocol) 🏎️ 🏠 - เครื่องมือสารพัดสำหรับนักพัฒนา: confluence, Jira, Youtube, รันสคริปต์, knowledge base RAG, fetch URL, จัดการ youtube, email, calendar, gitlab
- [NON906/omniparser-autogui-mcp](https://github.com/NON906/omniparser-autogui-mcp) - 🐍 ปฏิบัติการ GUI บนหน้าจอโดยอัตโนมัติ
- [orellazi/coda-mcp](https://github.com/orellazri/coda-mcp) 📇 ☁️ - MCP server สำหรับ [Coda](https://coda.io/)
- [pierrebrunelle/mcp-server-openai](https://github.com/pierrebrunelle/mcp-server-openai) 🐍 ☁️ - ส่งคำถามไปยังโมเดล OpenAI จาก Claude ด้วย MCP protocol
- [pskill9/hn-server](https://github.com/pskill9/hn-server) - 📇 ☁️ แปลงเนื้อหา HTML จาก news.ycombinator.com (Hacker News) เป็นข้อมูลโครงสร้างสำหรับประเภทข่าวต่าง ๆ (top, new, ask, show, jobs)
- [PV-Bhat/vibe-check-mcp-server](https://github.com/PV-Bhat/vibe-check-mcp-server) 📇 ☁️ - MCP server ที่ป้องกัน cascading error และ scope creep โดยเรียก "Vibe-check" agent เพื่อเช็คความตรงกันของผู้ใช้
- [pwh-pwh/cal-mcp](https://github.com/pwh-pwh/cal-mcp) - MCP server สำหรับคำนวณนิพจน์ทางคณิตศาสตร์
- [pyroprompts/any-chat-completions-mcp](https://github.com/pyroprompts/any-chat-completions-mcp) - สนทนากับ Chat Completions API ที่รองรับ OpenAI SDK เช่น Perplexity, Groq, xAI ฯลฯ
- [Rai220/think-mcp](https://github.com/Rai220/think-mcp) 🐍 🏠 - เพิ่มศักยภาพในการ reasoning ของ agent ใด ๆ โดยรวม think-tools ตาม [บทความของ Anthropic](https://www.anthropic.com/engineering/claude-think-tool)
- [reeeeemo/ancestry-mcp](https://github.com/reeeeemo/ancestry-mcp) 🐍 🏠 - ให้ AI อ่านไฟล์ .ged และข้อมูลพันธุกรรม
- [rember/rember-mcp](https://github.com/rember/rember-mcp) 📇 🏠 - สร้าง flashcard แบบ spaced repetition ใน [Rember](https://rember.com) เพื่อจดจำสิ่งที่เรียนรู้ในแชท
- [roychri/mcp-server-asana](https://github.com/roychri/mcp-server-asana) - 📇 ☁️ Model Context Protocol server ของ Asana สำหรับโต้ตอบกับ API ผ่าน MCP Client เช่น Claude Desktop Application ฯลฯ
- [rusiaaman/wcgw](https://github.com/rusiaaman/wcgw/blob/main/src/wcgw/client/mcp_server/Readme.md) 🐍 🏠 - รัน shell อัตโนมัติ ควบคุมคอมพิวเตอร์และโค้ดดิ้ง agent (Mac)
- [SecretiveShell/MCP-wolfram-alpha](https://github.com/SecretiveShell/MCP-wolfram-alpha) 🐍 ☁️ - MCP server สำหรับ query Wolfram Alpha API
- [Seym0n/tiktok-mcp](https://github.com/Seym0n/tiktok-mcp) 📇 ☁️ - โต้ตอบกับวิดีโอ TikTok
- [Shopify/dev-mcp](https://github.com/Shopify/dev-mcp) 📇 ☁️ - เซิร์ฟเวอร์ Model Context Protocol (MCP) ที่โต้ตอบกับ Shopify Dev
- [sirmews/apple-notes-mcp](https://github.com/sirmews/apple-notes-mcp) 🐍 🏠 - อนุญาตให้ AI อ่านข้อมูลจากฐานข้อมูล Apple Notes บนเครื่องของคุณ (เฉพาะ macOS)
- [sooperset/mcp-atlassian](https://github.com/sooperset/mcp-atlassian) 🐍 ☁️ - เซิร์ฟเวอร์ MCP สำหรับผลิตภัณฑ์ Atlassian (Confluence และ Jira) รองรับ Confluence Cloud, Jira Cloud, และ Jira Server/Data Center ให้เครื่องมือครบถ้วนสำหรับการค้นหา อ่าน สร้าง และจัดการเนื้อหาข้าม workspace ของ Atlassian
- [suekou/mcp-notion-server](https://github.com/suekou/mcp-notion-server) 📇 🏠 - โต้ตอบกับ Notion API
- [tacticlaunch/mcp-linear](https://github.com/tacticlaunch/mcp-linear) 📇 ☁️ 🍎 🪟 🐧 - เชื่อมต่อกับระบบบริหารโครงการ Linear
- [tanigami/mcp-server-perplexity](https://github.com/tanigami/mcp-server-perplexity) 🐍 ☁️ - โต้ตอบกับ Perplexity API
- [tevonsb/homeassistant-mcp](https://github.com/tevonsb/homeassistant-mcp) 📇 🏠 - เข้าถึงข้อมูล Home Assistant และควบคุมอุปกรณ์ (ไฟ, สวิตช์, เทอร์โมสแตท ฯลฯ)
- [tomekkorbak/oura-mcp-server](https://github.com/tomekkorbak/oura-mcp-server) 🐍 ☁️ - เซิร์ฟเวอร์ MCP สำหรับ Oura แอปติดตามการนอนหลับ
- [UnitVectorY-Labs/mcp-graphql-forge](https://github.com/UnitVectorY-Labs/mcp-graphql-forge) 🏎️ ☁️ 🍎 🪟 🐧 - เซิร์ฟเวอร์ MCP แบบเบา ขับเคลื่อนด้วยการตั้งค่า เปิดเผย GraphQL queries แบบโมดูล ช่วยให้ตัวแทน AI เข้าถึง API ได้อย่างตั้งใจ
- [kw510/strava-mcp](https://github.com/kw510/strava-mcp) 📇 ☁️ - เซิร์ฟเวอร์ MCP สำหรับ Strava แอปติดตามการออกกำลังกาย
- [wanaku-ai/wanaku](https://github.com/wanaku-ai/wanaku) - ☁️ 🏠 Wanaku MCP Router คือเซิร์ฟเวอร์ MCP แบบ SSE ที่ให้เอ็นจิ้น routing ที่ขยายได้ สำหรับเชื่อมต่อระบบองค์กรกับ AI agents
- [wong2/mcp-cli](https://github.com/wong2/mcp-cli) 📇 🏠 - เครื่องมือ CLI สำหรับทดสอบเซิร์ฟเวอร์ MCP
- [ws-mcp](https://github.com/nick1udwig/ws-mcp) - ครอบ MCP servers ด้วย WebSocket (ใช้ร่วมกับ [kitbitz](https://github.com/nick1udwig/kibitz))
- [yuna0x0/hackmd-mcp](https://github.com/yuna0x0/hackmd-mcp) 📇 ☁️ - อนุญาตให้โมเดล AI โต้ตอบกับ [HackMD](https://hackmd.io)
- [ZeparHyfar/mcp-datetime](https://github.com/ZeparHyfar/mcp-datetime) - เซิร์ฟเวอร์ MCP ให้บริการฟังก์ชั่นวันที่และเวลาในรูปแบบต่างๆ
- [zueai/mcp-manager](https://github.com/zueai/mcp-manager) 📇 ☁️ - Web UI ง่ายๆ สำหรับติดตั้งและจัดการ MCP servers สำหรับแอป Claude Desktop
- [HenryHaoson/Yuque-MCP-Server](https://github.com/HenryHaoson/Yuque-MCP-Server) - 📇 ☁️ เซิร์ฟเวอร์ Model-Context-Protocol (MCP) สำหรับเชื่อมต่อกับ Yuque API อนุญาตให้โมเดล AI จัดการเอกสาร โต้ตอบกับคลังความรู้ ค้นหาเนื้อหา และเข้าถึงข้อมูลวิเคราะห์จากแพลตฟอร์ม Yuque
- [Mtehabsim/ScreenPilot](https://github.com/Mtehabsim/ScreenPilot) 🐍 🏠 - ให้ AI ควบคุมและเข้าถึง GUI ได้เต็มรูปแบบ ด้วยเครื่องมือสำหรับเมาส์และคีย์บอร์ด เหมาะสำหรับ automation ทั่วไป การศึกษา และการทดลอง
- [tumf/web3-mcp](https://github.com/tumf/web3-mcp) 🐍 ☁️ - การใช้งานเซิร์ฟเวอร์ MCP ที่ครอบ Ankr Advanced API เข้าถึงข้อมูล NFT, โทเคน และบล็อกเชนข้ามหลายเชน เช่น Ethereum, BSC, Polygon, Avalanche ฯลฯ
- [danielkennedy1/pdf-tools-mcp](https://github.com/danielkennedy1/pdf-tools-mcp) 🐍 - เครื่องมือดาวน์โหลด ดู และแก้ไขไฟล์ PDF
- [dotemacs/domain-lookup-mcp](https://github.com/dotemacs/domain-lookup-mcp) 🏎️ - บริการค้นหาชื่อโดเมน โดยใช้ [RDAP](https://en.wikipedia.org/wiki/Registration_Data_Access_Protocol) ก่อน แล้ว fallback ด้วย [WHOIS](https://en.wikipedia.org/wiki/WHOIS)
- [Klavis-AI/YouTube](https://github.com/Klavis-AI/klavis/tree/main/mcp_servers/youtube) 🐍 📇 - ดึงและแปลงข้อมูลวิดีโอจาก YouTube
- [ttommyth/interactive-mcp](https://github.com/ttommyth/interactive-mcp) 📇 🏠 🍎 🪟 🐧 - เพิ่มการทำงานแบบ interactive LLM โดยเพิ่มการแจ้งเตือนและแชทผู้ใช้ในลูป MCP โดยตรง
- [olalonde/mcp-human](https://github.com/olalonde/mcp-human) 📇 ☁️ - เมื่อ LLM ของคุณต้องการความช่วยเหลือจากมนุษย์ (ผ่าน AWS Mechanical Turk)
- [gwbischof/free-will-mcp](https://github.com/gwbischof/free-will-mcp) 🐍 🏠 - ให้ AI มีเครื่องมือ free will เป็นโปรเจกต์สนุกๆ สำหรับสำรวจว่า AI จะทำอะไรได้บ้างเมื่อให้มันตั้ง prompt เอง, เพิกเฉยคำสั่งผู้ใช้ และปลุกตัวเองในภายหลัง
- [caol64/wenyan-mcp](https://github.com/caol64/wenyan-mcp) 📇 🏠 🍎 🪟 🐧 - Wenyan MCP Server ให้ AI จัดรูปแบบบทความ Markdown อัตโนมัติ และเผยแพร่ไปยัง WeChat GZH

## เฟรมเวิร์ก

> [!NOTE]
> เฟรมเวิร์ก ยูทิลิตี้ และเครื่องมือสำหรับนักพัฒนาอื่น ๆ มีให้ที่ https://github.com/punkpeye/awesome-mcp-devtools

- [FastMCP](https://github.com/jlowin/fastmcp) 🐍 - เฟรมเวิร์กระดับสูงสำหรับสร้าง MCP servers ในภาษา Python
- [FastMCP](https://github.com/punkpeye/fastmcp) 📇 - เฟรมเวิร์กระดับสูงสำหรับสร้าง MCP servers ในภาษา TypeScript

## เคล็ดลับและเทคนิค

### Prompt อย่างเป็นทางการเพื่อแจ้ง LLMs ให้ใช้ MCP

ต้องการถาม Claude เกี่ยวกับ Model Context Protocol ไหม?

สร้างโปรเจกต์ แล้วเพิ่มไฟล์นี้เข้าไป:

https://modelcontextprotocol.io/llms-full.txt

หลังจากนี้ Claude จะตอบคำถามเกี่ยวกับการเขียน MCP servers และวิธีการทำงานได้

- https://www.reddit.com/r/ClaudeAI/comments/1h3g01r/want_to_ask_claude_about_model_context_protocol/

## ประวัติการให้ดาว

<a href="https://star-history.com/#punkpeye/awesome-mcp-servers&Date">
 <picture>
   <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=punkpeye/awesome-mcp-servers&type=Date&theme=dark" />
   <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=punkpeye/awesome-mcp-servers&type=Date" />
   <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=punkpeye/awesome-mcp-servers&type=Date" />
 </picture>
</a>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-28

---