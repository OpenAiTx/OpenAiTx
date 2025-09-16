# mcp-chat

<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
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

عميل MCP عام مفتوح المصدر لاختبار وتقييم خوادم وعوامل mcp

<p align="center">
  <img width="600" src="https://raw.githubusercontent.com/Flux159/mcp-chat/refs/heads/main/mcpchat.svg">
</p>


## البدء السريع

تأكد من أنك قد صدّرت `ANTHROPIC_API_KEY` في بيئة العمل الخاصة بك أو في ملف .env في جذر المشروع. يمكنك الحصول على مفتاح API من خلال التسجيل في [صفحة مفاتيح وحدة التحكم في Anthropic](https://console.anthropic.com/settings/keys).

حالة استخدام بسيطة تقوم بإنشاء محادثة تفاعلية مع خادم MCP لنظام الملفات من سطر الأوامر:

```shell
npx mcp-chat --server "npx -y @modelcontextprotocol/server-filesystem /Users/$USER/Desktop"
```

سيؤدي هذا إلى فتح نافذة دردشة يمكنك استخدامها للتفاعل مع الخوادم والدردشة مع نموذج اللغة الكبير (LLM).

## الإعدادات

يمكنك أيضًا تحديد ملف claude_desktop_config.json الخاص بك (ماك):

```shell
npx mcp-chat --config "~/Library/Application Support/Claude/claude_desktop_config.json"
```

أو (ويندوز):

```shell
npx mcp-chat --config "%APPDATA%\Claude\claude_desktop_config.json"
```

## Web mode

https://github.com/user-attachments/assets/b7e8a648-8084-4955-8cdf-fc6eb141572e

You can also run mcp-chat in web mode by specifying the `--web` flag (make sure to have `ANTHROPIC_API_KEY` exported in your environment):

```shell
npx mcp-chat --web
```

في وضع الويب، يمكنك بدء محادثات جديدة، إرسال رسائل إلى النموذج، وتكوين خوادم mcp ديناميكيًا عبر واجهة المستخدم - دون الحاجة للتحديد عبر سطر الأوامر. بالإضافة إلى ذلك، يتم حفظ المحادثات التي يتم إنشاؤها عبر واجهة الويب في ~/.mcpchats/chats تمامًا مثل المحادثات التي يتم إنشاؤها عبر CLI.

## الميزات

- [x] التشغيل عبر CLI في وضع تفاعلي أو تمرير المطالبات مباشرة باستخدام `-p`
- [x] وضع الويب للدردشة مع النماذج عبر واجهة ويب `--web`
- [x] الاتصال بأي خادم MCP (JS، Python، Docker) في الإنتاج أو أثناء التطوير
- [x] اختيار النماذج باستخدام `-m`
- [x] تخصيص مطالبة النظام باستخدام `--system`
- [x] حفظ سجل المحادثة مع الإعدادات في `~/.mcpchat/chats` بما في ذلك محادثات الويب
- [x] حفظ واستعادة الأوامر في `~/.mcpchat/history`
- [x] عرض مخرجات وأوامر الأدوات مباشرة في الدردشة للمساعدة في تصحيح خوادم mcp

## استخدام CLI

تشغيل المطالبات عبر CLI باستخدام علامة `-p`:

```shell
npx mcp-chat --server "npx mcp-server-kubernetes" -p "List the pods in the default namespace"
```

يقوم هذا بتشغيل الموجه باستخدام خادم mcp الخاص بـ kubernetes ويخرج بعد استلام الاستجابة على المخرجات القياسية.

اختر نموذجاً للدردشة معه عبر سطر الأوامر باستخدام الخيار `-m`:

```shell
npx mcp-chat --server "npx mcp-server-kubernetes" -m "claude-3.5"
```

يستخدم النموذج `claude-3.5` للدردشة معه. يرجى ملاحظة أن النماذج المدعومة حالياً هي نماذج Anthropic فقط.

موجه النظام المخصص:

يمكن استخدام علم `--system` لتحديد موجه النظام:

```shell
npx mcp-chat --system "Explain the output to the user in pirate speak." --server "npx mcp-server-kubernetes" -p "List the pods in the default namespace"
```

## متغيرات البيئة

يدعم Mcp-chat تمرير متغيرات البيئة إلى خوادم mcp. ومع ذلك، هذا غير موحد في مواصفة mcp وقد لا تقوم العملاء الأخرى بذلك باستخدام قيم متغيرة لمتغيرات البيئة - اقرأ المزيد [هنا](https://github.com/Flux159/mcp-server-kubernetes/issues/148#issuecomment-2950181666) حول عملاء mcp القياسية لـ stdio.

```shell
KUBECONFIG="~/.kube/config" npx mcp-chat --server "npx mcp-server-kubernetes"
```

## للمطورين العاملين على خوادم mcp

يمكنك تمرير نسخة محلية مبنية من خادم mcp بلغة بايثون أو نود لاختبارها مع mcp-chat:

Node JS:

```shell
# Directly executing built script
npx mcp-chat --server "/path/to/mcp-server-kubernetes/dist/index.js"
# Using node / bun
npx mcp-chat --server "node /path/to/mcp-server-kubernetes/dist/index.js"
```

بايثون:

```shell
# Python: Using uv
npx mcp-chat --server "uv --directory /path/to/mcp-server-weather/ run weather.py"
# Using python / python3 - make sure to run in venv or install deps globally
npx mcp-chat --server "/path/to/mcp-server-weather/weather.py"
```

## التطوير

ثبّت الاعتمادات وشغّل واجهة الأوامر:

```shell
git clone https://github.com/Flux159/mcp-chat
bun install
bun run dev
```
لتطوير mcp-chat أثناء الاتصال بـ mcp-server، قم بإنشاء بناء وشغّل واجهة الأوامر مع علم الخادم:


```shell
npm run build && node dist/index.js --server "npx mcp-server-kubernetes" -p "List the pods in the default namespace"
```

الاختبار:

```shell
bun run test
```

البناء:

```shell
bun run build
```
النشر:


```shell
bun run publish
```

نشر Docker:

```shell
bun run dockerbuild
```

### هيكل المشروع

```
├── src/
│   ├── index.ts            # Main client implementation & CLI params
│   ├── constants.ts        # Default constants
│   ├── interactive.ts      # Interactive chat prompt handling & logic
├── test/                   # Test files
│   ├── cli.test.ts         # Test CLI params
│   ├── config.test.ts      # Test config file parsing
```

## نشر إصدار جديد

انتقل إلى صفحة [الإصدارات](https://github.com/Flux159/mcp-chat/releases)، وانقر على "صياغة إصدار جديد"، ثم انقر على "اختيار علامة" وأنشئ علامة جديدة بكتابة رقم إصدار جديد باستخدام تنسيق semver "v{major}.{minor}.{patch}". بعد ذلك، اكتب عنوان الإصدار "Release v{major}.{minor}.{patch}" والوصف / سجل التغييرات إذا لزم الأمر، ثم انقر على "نشر الإصدار".

سيؤدي ذلك إلى إنشاء علامة جديدة ستؤدي إلى بدء بناء إصدار جديد عبر سير العمل cd.yml. بمجرد النجاح، سيتم نشر الإصدار الجديد على npm. لاحظ أنه لا حاجة لتحديث إصدار package.json يدويًا، حيث سيقوم سير العمل بتحديث رقم الإصدار تلقائيًا في ملف package.json ويدفع التعديل إلى الفرع الرئيسي.

## الرخصة

[رخصة MIT](https://github.com/Flux159/mcp-chat/blob/main/LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-16

---