
<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# claude.sh

Claude Code ถูกเขียนใหม่เป็นสคริปต์ bash ประมาณ 1,500 บรรทัด ไม่มีแพ็คเกจ npm เลย

## ทำไม

Claude Code ดั้งเดิมมีประมาณ 380,000 บรรทัด TypeScript และพึ่งพา npm 266 รายการ สิ่งนี้ทำงานหลักเดียวกันใน bash โดยใช้แค่ `curl` และ `jq`

## คุณสมบัติ

- **สตรีมมิ่งแบบเรียลไทม์** ผ่านท่อ FIFO — ข้อความจะแสดงทันทีที่ Claude สร้างขึ้น
- **6 เครื่องมือ**: Bash, Read, Edit, Write, Glob, Grep
- **การเชื่อมโยงเครื่องมือ** — เรียกใช้เครื่องมือสูงสุด 25 ครั้งต่อหนึ่งรอบ
- **การขออนุญาต** — แจ้งเตือนก่อนรันคำสั่งที่ไม่ปลอดภัย (`y/n/a`)
- **โหลดไฟล์ CLAUDE.md** — อ่านคำแนะนำโปรเจกต์จากไฟล์ CLAUDE.md ในไดเรกทอรีย่อยขึ้นไป
- **บริบทที่รับรู้ Git** — สาขา, สถานะ, และคอมมิตล่าสุดในพรอมต์ของระบบ
- **บันทึก/เรียกคืนเซสชัน** — บันทึกอัตโนมัติเมื่อออก, เรียกคืนด้วย `--resume <id>`
- **ลองใหม่พร้อมหน่วงเวลา** — ลองใหม่แบบทวีคูณเมื่อเจอข้อจำกัด 429/529
- **ติดตามค่าใช้จ่าย** — แสดงยอดรวมต่อรอบและตลอดทั้งเซสชัน
- **ตัวหมุน** — พร้อมคำกริยา spinner ดั้งเดิม (Clauding, Flibbertigibbeting ฯลฯ)
- **คำสั่ง slash** — `/help`, `/cost`, `/model`, `/clear`, `/save`, `/resume`, `/commit`, `/diff`
- **โหมดท่อ** — `echo "explain this" | ./claude.sh`

## การติดตั้ง

```bash
git clone https://github.com/jdcodes1/claude.sh.git
cd claude.sh
chmod +x claude.sh
```

## การขึ้นอยู่กับ

- `curl`
- `jq`
- ตัวเลือก: `rg` (ripgrep) สำหรับการค้นหาที่ดีกว่า
- ตัวเลือก: `python3` สำหรับเครื่องมือแก้ไข

เวอร์ชันที่ใช้ในการทำงานจะถูกตรึงไว้ใน `.tool-versions` ติดตั้งได้ด้วย [mise](https://mise.jdx.dev/):

```bash
mise install
```

## การใช้งาน

```bash
export ANTHROPIC_API_KEY="sk-ant-..."
./claude.sh
```

### ตัวแปรสิ่งแวดล้อม

| ตัวแปร | ค่าเริ่มต้น | คำอธิบาย |
| --- | --- | --- |
| `ANTHROPIC_API_KEY` | (จำเป็น) | รหัส API ของคุณสำหรับ Anthropic |
| `CLAUDE_MODEL` | `claude-sonnet-4-6` | โมเดลที่ใช้ |
| `CLAUDE_MAX_TOKENS` | `8192` | จำนวนโทเคนผลลัพธ์สูงสุด |
| `ANTHROPIC_API_URL` | `https://api.anthropic.com` | URL ฐานของ API |
| `CLAUDE_SH_PERMISSIONS` | `ask` | โหมดสิทธิ์: `ask`, `allow`, หรือ `deny` |

### คำสั่ง

```txt
/help      — Show help
/cost      — Show session cost
/model     — Show/change model
/clear     — Clear conversation
/save      — Save current session
/resume    — List/resume saved sessions
/commit    — Auto-generate a git commit
/diff      — Show git diff
/quit      — Exit
```

### ดำเนินการต่อเซสชัน

```bash
# List saved sessions
./claude.sh
> /resume

# Resume by number
> /resume 1

# Resume from CLI
./claude.sh --resume 20240101-120000-12345
```

## สถาปัตยกรรม

```txt
claude.sh          # Main REPL loop, slash commands, process_turn()
lib/
  api.sh           # Anthropic API client, SSE streaming via FIFO, retry
  json.sh          # Message construction, session persistence, CLAUDE.md, git context
  tools.sh         # 6 tool implementations + permission system
  tui.sh           # ANSI colors, spinner, display helpers
```

## วิธีการทำงาน

1. อ่านข้อมูลที่ผู้ใช้ป้อน
2. สร้างคำขอ JSON ด้วย `jq` (ข้อความ, เครื่องมือ, system prompt)
3. สตรีมผลลัพธ์ผ่าน `curl` ผ่านท่อ FIFO
4. แยกวิเคราะห์เหตุการณ์ SSE ทีละบรรทัด แสดงข้อความทีละส่วนแบบเรียลไทม์
5. เมื่อมีบล็อก tool_use เข้ามา ให้เรียกใช้งานเครื่องมือ
6. ป้อนผลลัพธ์เครื่องมือกลับไปเป็นข้อความ
7. ทำซ้ำจนกว่า Claude จะหยุดเรียกใช้งานเครื่องมือ

## การเปรียบเทียบ

| | claude.sh | Claude Code (TypeScript) |
| --- | --- | --- |
| จำนวนบรรทัดโค้ด | ~1,500 | ~380,000 |
| การพึ่งพา | curl, jq | 266 npm packages |
| ขนาดไบนารี | 0 (สคริปต์) | ~200MB node_modules |
| เวลาสตาร์ท | ทันที | ~500ms |

### การทดสอบ

การทดสอบใช้ [bats](https://github.com/bats-core/bats-core) (ระบบทดสอบอัตโนมัติด้วย Bash):

```bash
bats test/
```

## License

[MIT](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-14

---