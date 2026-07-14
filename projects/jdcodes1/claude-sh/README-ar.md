<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
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

إعادة كتابة Claude Code كبرنامج نصي bash. حوالي 1500 سطر. بدون حزم npm نهائياً.

## لماذا

النسخة الأصلية من Claude Code تحتوي على حوالي 380,000 سطر TypeScript مع 266 تبعية npm. هذا البرنامج يقوم بنفس الوظيفة الأساسية باستخدام bash فقط مع `curl` و `jq`.


## الميزات

- **البث في الوقت الحقيقي** عبر أنبوب FIFO — يظهر النص أثناء إنشائه بواسطة Claude
- **6 أدوات**: Bash، قراءة، تحرير، كتابة، Glob، Grep
- **سلسلة الأدوات** — حتى 25 استدعاء للأدوات في كل دورة
- **طلب الإذن** — يسأل قبل تنفيذ الأوامر غير الآمنة (`y/n/a`)
- **تحميل CLAUDE.md** — يقرأ تعليمات المشروع من ملفات CLAUDE.md في شجرة الدليل
- **سياق معرف بـ Git** — الفرع، الحالة، والالتزامات الأخيرة في موجه النظام
- **حفظ/استئناف الجلسة** — حفظ تلقائي عند الخروج، الاستئناف بـ `--resume <id>`
- **إعادة المحاولة مع التراجع** — إعادة المحاولة بشكل أُسّي عند حدود 429/529
- **تتبع التكلفة** — الإجمالي لكل دورة وجلسة
- **مؤشر التحميل** — مع أفعال المؤشر الأصلية (Clauding، Flibbertigibbeting، إلخ)
- **أوامر الشريط** — `/help`، `/cost`، `/model`، `/clear`، `/save`، `/resume`، `/commit`، `/diff`
- **وضع الأنابيب** — `echo "اشرح هذا" | ./claude.sh`

## التثبيت

```bash
git clone https://github.com/jdcodes1/claude.sh.git
cd claude.sh
chmod +x claude.sh
```

## الاعتمادات

- `curl`
- `jq`
- اختياري: `rg` (ripgrep) لتحسين البحث
- اختياري: `python3` لأداة التحرير

إصدارات وقت التشغيل محددة في `.tool-versions`. قم بتثبيتها باستخدام [mise](https://mise.jdx.dev/):

```bash
mise install
```

## الاستخدام

```bash
export ANTHROPIC_API_KEY="sk-ant-..."
./claude.sh
```

### متغيرات البيئة

| المتغير | الافتراضي | الوصف |
| --- | --- | --- |
| `ANTHROPIC_API_KEY` | (مطلوب) | مفتاح واجهة برمجة التطبيقات الخاص بـ Anthropic |
| `CLAUDE_MODEL` | `claude-sonnet-4-6` | النموذج المستخدم |
| `CLAUDE_MAX_TOKENS` | `8192` | الحد الأقصى لعدد الرموز الناتجة |
| `ANTHROPIC_API_URL` | `https://api.anthropic.com` | عنوان واجهة برمجة التطبيقات الأساسي |
| `CLAUDE_SH_PERMISSIONS` | `ask` | وضع الأذونات: `ask`، `allow`، أو `deny` |

### الأوامر

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

### استئناف جلسة

```bash
# List saved sessions
./claude.sh
> /resume

# Resume by number
> /resume 1

# Resume from CLI
./claude.sh --resume 20240101-120000-12345
```

## المعمارية

```txt
claude.sh          # Main REPL loop, slash commands, process_turn()
lib/
  api.sh           # Anthropic API client, SSE streaming via FIFO, retry
  json.sh          # Message construction, session persistence, CLAUDE.md, git context
  tools.sh         # 6 tool implementations + permission system
  tui.sh           # ANSI colors, spinner, display helpers
```

## كيف يعمل

1. قراءة مدخلات المستخدم
2. بناء طلب JSON باستخدام `jq` (الرسائل، الأدوات، موجه النظام)
3. بث الاستجابة عبر `curl` من خلال أنبوب FIFO
4. تحليل أحداث SSE سطرًا بسطر، وطباعة تغييرات النص في الوقت الحقيقي
5. عند وصول كتل tool_use، تنفيذ الأدوات
6. إعادة إرسال نتائج الأدوات كرسائل
7. التكرار حتى يتوقف Claude عن استدعاء الأدوات

## المقارنة

| | claude.sh | Claude Code (TypeScript) |
| --- | --- | --- |
| عدد الأسطر البرمجية | ~1,500 | ~380,000 |
| الاعتمادات | curl, jq | 266 حزمة npm |
| حجم الملف التنفيذي | 0 (سكريبت) | ~200MB node_modules |
| زمن البدء | فوري | ~500ms |

### الاختبار

تستخدم الاختبارات [bats](https://github.com/bats-core/bats-core) (نظام اختبار Bash الآلي):

```bash
bats test/
```

## License

[MIT](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-14

---