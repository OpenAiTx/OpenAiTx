# mcp-chat

<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=as">অসমীয়া</
      </div>
    </div>
  </details>

</div>

ไคลเอนต์ MCP แบบโอเพ่นซอร์สทั่วไปสำหรับทดสอบและประเมินเซิร์ฟเวอร์และเอเจนต์ MCP

<p align="center">
  <img width="600" src="https://raw.githubusercontent.com/Flux159/mcp-chat/refs/heads/main/mcpchat.svg">
</p>


## เริ่มต้นอย่างรวดเร็ว

ตรวจสอบให้แน่ใจว่าคุณได้ส่งออก `ANTHROPIC_API_KEY` ไว้ใน environment ของคุณหรือในไฟล์ .env ที่ root ของโปรเจกต์ คุณสามารถรับ API key ได้โดยสมัครที่หน้า [Anthropic Console keys page](https://console.anthropic.com/settings/keys)

ตัวอย่างการใช้งานง่าย ๆ ที่เริ่มต้น prompt แชทแบบโต้ตอบกับเซิร์ฟเวอร์ MCP ของระบบไฟล์ผ่าน CLI:

```shell
npx mcp-chat --server "npx -y @modelcontextprotocol/server-filesystem /Users/$USER/Desktop"
```

สิ่งนี้จะเปิดหน้าต่างแชทที่คุณสามารถใช้โต้ตอบกับเซิร์ฟเวอร์และพูดคุยกับ LLM ได้

## การตั้งค่า

คุณยังสามารถระบุไฟล์ claude_desktop_config.json ของคุณได้โดยตรง (Mac):

```shell
npx mcp-chat --config "~/Library/Application Support/Claude/claude_desktop_config.json"
```
หรือ (Windows):


```shell
npx mcp-chat --config "%APPDATA%\Claude\claude_desktop_config.json"
```

## Web mode

https://github.com/user-attachments/assets/b7e8a648-8084-4955-8cdf-fc6eb141572e

You can also run mcp-chat in web mode by specifying the `--web` flag (make sure to have `ANTHROPIC_API_KEY` exported in your environment):

```shell
npx mcp-chat --web
```
ในโหมดเว็บ คุณสามารถเริ่มแชทใหม่ ส่งข้อความถึงโมเดล และตั้งค่าเซิร์ฟเวอร์ mcp แบบไดนามิกผ่าน UI โดยไม่จำเป็นต้องระบุผ่านบรรทัดคำสั่ง นอกจากนี้ แชทที่สร้างผ่าน Web UI จะถูกบันทึกไว้ที่ ~/.mcpchats/chats เช่นเดียวกับแชทที่สร้างผ่าน CLI

## คุณสมบัติ

- [x] รันผ่าน CLI ในโหมดโต้ตอบ หรือส่งพรอมต์โดยตรงด้วย `-p`
- [x] โหมดเว็บสำหรับสนทนากับโมเดลผ่านเว็บอินเตอร์เฟซ `--web`
- [x] เชื่อมต่อกับเซิร์ฟเวอร์ MCP ใดก็ได้ (JS, Python, Docker) ในการใช้งานจริงหรือขณะพัฒนา
- [x] เลือกโมเดลด้วย `-m`
- [x] ปรับแต่ง system prompt ด้วย `--system`
- [x] บันทึกประวัติแชทพร้อมการตั้งค่าใน `~/.mcpchat/chats` รวมถึงแชทเว็บ
- [x] บันทึกและเรียกคืนคำสั่งใน `~/.mcpchat/history`
- [x] ดูผลลัพธ์และอาร์กิวเมนต์ของการเรียกใช้เครื่องมือในแชทโดยตรง เพื่อช่วยดีบัคเซิร์ฟเวอร์ mcp

## การใช้งาน CLI

รันพรอมต์ผ่าน CLI ด้วยแฟลก `-p`:


```shell
npx mcp-chat --server "npx mcp-server-kubernetes" -p "List the pods in the default namespace"
```

สิ่งนี้จะรันพรอมต์กับเซิร์ฟเวอร์ mcp ของ kubernetes และออกจากระบบหลังจากได้รับการตอบกลับบน stdout

เลือกโมเดลสำหรับสนทนาผ่าน CLI ด้วยแฟล็ก `-m`:

```shell
npx mcp-chat --server "npx mcp-server-kubernetes" -m "claude-3.5"
```

ใช้โมเดล `claude-3.5` สำหรับสนทนา โปรดทราบว่าปัจจุบันรองรับเฉพาะโมเดลของ Anthropic เท่านั้น

พรอมต์ระบบแบบกำหนดเอง:

สามารถใช้แฟล็ก `--system` เพื่อระบุพรอมต์ของระบบ:

```shell
npx mcp-chat --system "Explain the output to the user in pirate speak." --server "npx mcp-server-kubernetes" -p "List the pods in the default namespace"
```

## ตัวแปร ENV

Mcp-chat รองรับการส่งผ่านตัวแปร env ไปยังเซิร์ฟเวอร์ mcp อย่างไรก็ตามสิ่งนี้ยังไม่ได้มาตรฐานในข้อกำหนด mcp และไคลเอนต์อื่น ๆ อาจไม่รองรับการใช้ค่าตัวแปร env แบบไดนามิก - อ่านเพิ่มเติม [ที่นี่](https://github.com/Flux159/mcp-server-kubernetes/issues/148#issuecomment-2950181666) เกี่ยวกับไคลเอนต์ mcp แบบ stdio มาตรฐาน

```shell
KUBECONFIG="~/.kube/config" npx mcp-chat --server "npx mcp-server-kubernetes"
```

## สำหรับนักพัฒนาของ mcp-servers

คุณสามารถส่งบิลด์ท้องถิ่นของ python หรือ node mcp-server เข้าไปเพื่อทดสอบกับ mcp-chat ได้:

Node JS:

```shell
# Directly executing built script
npx mcp-chat --server "/path/to/mcp-server-kubernetes/dist/index.js"
# Using node / bun
npx mcp-chat --server "node /path/to/mcp-server-kubernetes/dist/index.js"
```

ไพธอน:

```shell
# Python: Using uv
npx mcp-chat --server "uv --directory /path/to/mcp-server-weather/ run weather.py"
# Using python / python3 - make sure to run in venv or install deps globally
npx mcp-chat --server "/path/to/mcp-server-weather/weather.py"
```

## การพัฒนา

ติดตั้งไลบรารีที่จำเป็น & เรียกใช้ CLI:

```shell
git clone https://github.com/Flux159/mcp-chat
bun install
bun run dev
```
เพื่อพัฒนา mcp-chat ในขณะที่เชื่อมต่อกับ mcp-server ให้ทำการ build และรัน CLI พร้อมกับ server flag:


```shell
npm run build && node dist/index.js --server "npx mcp-server-kubernetes" -p "List the pods in the default namespace"
```

การทดสอบ:

```shell
bun run test
```

อาคาร:

```shell
bun run build
```
การเผยแพร่:


```shell
bun run publish
```

การเผยแพร่ Docker:

```shell
bun run dockerbuild
```

### โครงสร้างโครงการ

```
├── src/
│   ├── index.ts            # Main client implementation & CLI params
│   ├── constants.ts        # Default constants
│   ├── interactive.ts      # Interactive chat prompt handling & logic
├── test/                   # Test files
│   ├── cli.test.ts         # Test CLI params
│   ├── config.test.ts      # Test config file parsing
```

## การเผยแพร่เวอร์ชันใหม่

ไปที่หน้ากระดาน [releases](https://github.com/Flux159/mcp-chat/releases) คลิกที่ "Draft New Release" จากนั้นคลิก "Choose a tag" และสร้างแท็กใหม่โดยพิมพ์เลขเวอร์ชันใหม่ในรูปแบบ "v{major}.{minor}.{patch}" ตามมาตรฐาน semver แล้วตั้งชื่อหัวข้อรีลีสว่า "Release v{major}.{minor}.{patch}" และเขียนคำอธิบายหรือ changelog ตามต้องการ จากนั้นคลิก "Publish Release"

สิ่งนี้จะสร้างแท็กใหม่ซึ่งจะทริกเกอร์การสร้าง release ใหม่ผ่าน workflow cd.yml เมื่อสำเร็จแล้ว release ใหม่จะถูกเผยแพร่ไปยัง npm โปรดทราบว่าไม่จำเป็นต้องอัปเดตเลขเวอร์ชันใน package.json ด้วยตนเอง เพราะ workflow จะอัปเดตเวอร์ชันในไฟล์ package.json อัตโนมัติและจะ push commit ไปยัง main

## ใบอนุญาต

[ใบอนุญาต MIT](https://github.com/Flux159/mcp-chat/blob/main/LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-16

---