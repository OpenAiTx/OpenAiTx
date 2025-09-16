# mcp-chat

<div align="right">
  <details>
    <summary >🌐 زبان</summary>
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

کلاینت عمومی منبع‌باز MCP برای تست و ارزیابی سرورها و عامل‌های MCP

<p align="center">
  <img width="600" src="https://raw.githubusercontent.com/Flux159/mcp-chat/refs/heads/main/mcpchat.svg">
</p>


## شروع سریع

اطمینان حاصل کنید که `ANTHROPIC_API_KEY` را در محیط خود یا در یک فایل .env در ریشه پروژه وارد کرده‌اید. می‌توانید با ثبت‌نام در [صفحه کلید Anthropic Console](https://console.anthropic.com/settings/keys) یک کلید API دریافت کنید.

نمونه استفاده ساده که یک درخواست گفتگوی تعاملی را با سرور MCP فایل سیستم از طریق خط فرمان اجرا می‌کند:

```shell
npx mcp-chat --server "npx -y @modelcontextprotocol/server-filesystem /Users/$USER/Desktop"
```

این یک پنجره گفت‌وگو باز می‌کند که می‌توانید برای تعامل با سرورها و گفت‌وگو با یک مدل زبانی بزرگ (LLM) از آن استفاده کنید.

## پیکربندی

همچنین می‌توانید فقط فایل claude_desktop_config.json خود را مشخص کنید (مک):

```shell
npx mcp-chat --config "~/Library/Application Support/Claude/claude_desktop_config.json"
```

یا (ویندوز):

```shell
npx mcp-chat --config "%APPDATA%\Claude\claude_desktop_config.json"
```

## Web mode

https://github.com/user-attachments/assets/b7e8a648-8084-4955-8cdf-fc6eb141572e

You can also run mcp-chat in web mode by specifying the `--web` flag (make sure to have `ANTHROPIC_API_KEY` exported in your environment):

```shell
npx mcp-chat --web
```
در حالت وب، می‌توانید چت‌های جدید شروع کنید، پیام‌ها را به مدل ارسال کنید و سرورهای mcp را به صورت پویا از طریق رابط کاربری پیکربندی کنید - نیازی به تعیین در خط فرمان نیست. علاوه بر این، چت‌هایی که از طریق رابط وب ایجاد می‌شوند مانند چت‌هایی که از طریق CLI ساخته شده‌اند در مسیر ~/.mcpchats/chats ذخیره می‌شوند.

## قابلیت‌ها

- [x] اجرا از طریق CLI در حالت تعاملی یا ارسال مستقیم پرامپت با `-p`
- [x] حالت وب برای گفتگو با مدل‌ها از طریق رابط وب `--web`
- [x] اتصال به هر سرور MCP (JS، Python، Docker) در تولید یا حین توسعه
- [x] انتخاب بین مدل‌ها با `-m`
- [x] سفارشی‌سازی پرامپت سیستمی با `--system`
- [x] ذخیره تاریخچه چت با تنظیمات در `~/.mcpchat/chats` شامل چت‌های وب
- [x] ذخیره و بازیابی دستورات در `~/.mcpchat/history`
- [x] مشاهده خروجی و آرگومان‌های فراخوانی ابزار مستقیماً در چت برای کمک به اشکال‌زدایی سرورهای mcp

## نحوه استفاده از CLI

اجرای پرامپت‌ها از طریق CLI با پرچم `-p`:


```shell
npx mcp-chat --server "npx mcp-server-kubernetes" -p "List the pods in the default namespace"
```
این فرمان درخواست را با سرور mcp کوبرنتیز اجرا کرده و پس از دریافت پاسخ در خروجی استاندارد، خارج می‌شود.

برای انتخاب یک مدل جهت گفتگو از طریق CLI از فلگ `-m` استفاده کنید:


```shell
npx mcp-chat --server "npx mcp-server-kubernetes" -m "claude-3.5"
```

از مدل `claude-3.5` برای گفتگو استفاده می‌کند. توجه داشته باشید که در حال حاضر فقط مدل‌های Anthropic پشتیبانی می‌شوند.

پرامپت سیستم سفارشی:

فلگ `--system` می‌تواند برای مشخص کردن یک پرامپت سیستم استفاده شود:

```shell
npx mcp-chat --system "Explain the output to the user in pirate speak." --server "npx mcp-server-kubernetes" -p "List the pods in the default namespace"
```

## متغیرهای محیطی (ENV vars)

Mcp-chat از انتقال متغیرهای محیطی به سرورهای mcp پشتیبانی می‌کند. این موضوع در مشخصات mcp استاندارد نشده است و سایر کلاینت‌ها ممکن است این کار را با مقادیر پویا متغیرهای محیطی انجام ندهند - برای اطلاعات بیشتر [اینجا](https://github.com/Flux159/mcp-server-kubernetes/issues/148#issuecomment-2950181666) درباره کلاینت‌های استاندارد stdio mcp مطالعه کنید.

```shell
KUBECONFIG="~/.kube/config" npx mcp-chat --server "npx mcp-server-kubernetes"
```

## برای توسعه‌دهندگان mcp-servers

شما می‌توانید یک نسخه محلی ساخته شده از mcp-server پایتون یا نود را وارد کنید تا آن را با mcp-chat تست کنید:

Node JS:

```shell
# Directly executing built script
npx mcp-chat --server "/path/to/mcp-server-kubernetes/dist/index.js"
# Using node / bun
npx mcp-chat --server "node /path/to/mcp-server-kubernetes/dist/index.js"
```

پایتون:

```shell
# Python: Using uv
npx mcp-chat --server "uv --directory /path/to/mcp-server-weather/ run weather.py"
# Using python / python3 - make sure to run in venv or install deps globally
npx mcp-chat --server "/path/to/mcp-server-weather/weather.py"
```

## توسعه

وابستگی‌ها را نصب کنید و رابط خط فرمان را اجرا کنید:

```shell
git clone https://github.com/Flux159/mcp-chat
bun install
bun run dev
```
برای توسعه mcp-chat در حالی که به یک mcp-server متصل هستید، یک بیلد بسازید و CLI را با فلگ سرور اجرا کنید:


```shell
npm run build && node dist/index.js --server "npx mcp-server-kubernetes" -p "List the pods in the default namespace"
```

آزمایش:

```shell
bun run test
```
ساختمان:


```shell
bun run build
```
انتشار:


```shell
bun run publish
```
انتشار داکر:


```shell
bun run dockerbuild
```

### ساختار پروژه

```
├── src/
│   ├── index.ts            # Main client implementation & CLI params
│   ├── constants.ts        # Default constants
│   ├── interactive.ts      # Interactive chat prompt handling & logic
├── test/                   # Test files
│   ├── cli.test.ts         # Test CLI params
│   ├── config.test.ts      # Test config file parsing
```

## انتشار نسخه جدید

به صفحه [انتشارها](https://github.com/Flux159/mcp-chat/releases) بروید، روی "Draft New Release" کلیک کنید، روی "Choose a tag" کلیک کنید و با وارد کردن شماره نسخه جدید با فرمت semver یعنی "v{major}.{minor}.{patch}" یک تگ جدید بسازید. سپس عنوان انتشار "Release v{major}.{minor}.{patch}" و توضیحات / changelog را در صورت نیاز بنویسید و روی "Publish Release" کلیک کنید.

این کار یک تگ جدید ایجاد می‌کند که باعث اجرای build انتشار جدید از طریق workflow فایل cd.yml خواهد شد. پس از موفقیت‌آمیز بودن، نسخه جدید در npm منتشر می‌شود. توجه داشته باشید که نیازی به بروزرسانی دستی نسخه package.json نیست، زیرا workflow به طور خودکار شماره نسخه را در فایل package.json بروزرسانی کرده و یک commit به شاخه main ارسال می‌کند.

## مجوز

[مجوز MIT](https://github.com/Flux159/mcp-chat/blob/main/LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-16

---