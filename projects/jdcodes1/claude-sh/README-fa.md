
<div align="right">
  <details>
    <summary >🌐 زبان</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=en">انگلیسی</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=ja">ژاپنی</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=ko">کره‌ای</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=hi">هندی</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=th">تایلندی</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=fr">فرانسوی</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=de">آلمانی</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=es">اسپانیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=it">ایتالیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=ru">روسی</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=pt">پرتغالی</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=nl">هلندی</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=pl">لهستانی</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=ar">العربیة</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=tr">ترکی</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=vi">ویتنامی</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=id">اندونزیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# claude.sh

کد کلود بازنویسی شده به صورت اسکریپت bash. تقریباً ۱۵۰۰ خط. بدون هیچ بسته npm.

## چرا

کد کلود اصلی تقریباً ۳۸۰،۰۰۰ خط تایپ‌اسکریپت با ۲۶۶ وابستگی npm دارد. این همان کار اصلی را در bash فقط با `curl` و `jq` انجام می‌دهد.

## ویژگی‌ها

- **پخش زنده** از طریق لوله FIFO — متن همزمان با تولید توسط کلود نمایش داده می‌شود
- **۶ ابزار**: بش، خواندن، ویرایش، نوشتن، گلوب، گرپ
- **زنجیره‌سازی ابزارها** — تا ۲۵ فراخوانی ابزار در هر نوبت
- **درخواست اجازه** — قبل از اجرای دستورات غیرایمن می‌پرسد (`y/n/a`)
- **بارگذاری CLAUDE.md** — خواندن دستورالعمل‌های پروژه از فایل‌های CLAUDE.md در مسیر شاخه‌ها
- **زمینه‌آگاه به گیت** — شاخه، وضعیت و کامیت‌های اخیر در پیام سیستمی
- **ذخیره/ادامه جلسه** — ذخیره خودکار هنگام خروج، ادامه با `--resume <id>`
- **تلاش مجدد با وقفه افزایشی** — تلاش مجدد نمایی در محدودیت نرخ ۴۲۹/۵۲۹
- **ردیابی هزینه** — به ازای هر نوبت و مجموع جلسه
- **اسپینر** — با افعال اسپینر اصلی (Clauding، Flibbertigibbeting، و غیره)
- **دستورات اسلش** — `/help`، `/cost`، `/model`، `/clear`، `/save`، `/resume`، `/commit`، `/diff`
- **حالت پایپ** — `echo "این را توضیح بده" | ./claude.sh`

## نصب

```bash
git clone https://github.com/jdcodes1/claude.sh.git
cd claude.sh
chmod +x claude.sh
```

## وابستگی‌ها

- `curl`
- `jq`
- اختیاری: `rg` (ripgrep) برای جستجوی بهتر
- اختیاری: `python3` برای ابزار ویرایش

نسخه‌های زمان اجرا در `.tool-versions` ثابت شده‌اند. آن‌ها را با [mise](https://mise.jdx.dev/) نصب کنید:

```bash
mise install
```

## نحوه استفاده

```bash
export ANTHROPIC_API_KEY="sk-ant-..."
./claude.sh
```

### متغیرهای محیطی

| متغیر | پیش‌فرض | توضیح |
| --- | --- | --- |
| `ANTHROPIC_API_KEY` | (ضروری) | کلید API شما برای Anthropic |
| `CLAUDE_MODEL` | `claude-sonnet-4-6` | مدل مورد استفاده |
| `CLAUDE_MAX_TOKENS` | `8192` | حداکثر تعداد توکن خروجی |
| `ANTHROPIC_API_URL` | `https://api.anthropic.com` | آدرس پایه API |
| `CLAUDE_SH_PERMISSIONS` | `ask` | حالت دسترسی: `ask`، `allow` یا `deny` |

### دستورات

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

### ادامه دادن یک جلسه

```bash
# List saved sessions
./claude.sh
> /resume

# Resume by number
> /resume 1

# Resume from CLI
./claude.sh --resume 20240101-120000-12345
```

## معماری

```txt
claude.sh          # Main REPL loop, slash commands, process_turn()
lib/
  api.sh           # Anthropic API client, SSE streaming via FIFO, retry
  json.sh          # Message construction, session persistence, CLAUDE.md, git context
  tools.sh         # 6 tool implementations + permission system
  tui.sh           # ANSI colors, spinner, display helpers
```

## چگونه کار می‌کند

1. دریافت ورودی کاربر
2. ساخت درخواست JSON با استفاده از `jq` (پیام‌ها، ابزارها، پرامپت سیستم)
3. ارسال پاسخ به صورت استریم با `curl` از طریق یک لوله FIFO
4. تجزیه رویدادهای SSE خط به خط، چاپ تغییرات متن به صورت آنی
5. زمانی که بلوک‌های tool_use می‌رسند، ابزارها را اجرا کنید
6. نتایج ابزار را به عنوان پیام مجدداً ارسال کنید
7. حلقه تا زمانی که کلود فراخوانی ابزار را متوقف کند

## مقایسه

| | claude.sh | Claude Code (TypeScript) |
| --- | --- | --- |
| خطوط کد | حدود ۱,۵۰۰ | حدود ۳۸۰,۰۰۰ |
| وابستگی‌ها | curl, jq | ۲۶۶ پکیج npm |
| اندازه باینری | ۰ (اسکریپت) | حدود ۲۰۰ مگابایت node_modules |
| زمان راه‌اندازی | فوری | حدود ۵۰۰ میلی‌ثانیه |

### آزمایش

تست‌ها با [bats](https://github.com/bats-core/bats-core) (سیستم تست خودکار Bash) انجام می‌شوند:

```bash
bats test/
```

## License

[MIT](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-14

---