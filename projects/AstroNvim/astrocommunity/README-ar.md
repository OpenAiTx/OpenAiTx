<div align="center" id="madewithlua">
  <img
    src="https://astronvim.com/logo/astronvim.svg"
    width="110"
    ,
    height="100"
  />
</div>
<h1 align="center">مستودع مجتمع AstroNvim</h1>

يحتوي مستودع مجتمع AstroNvim على مواصفات تكوين الإضافات — مجموعة من الإضافات التي ساهم بها المجتمع لـ AstroNvim، وهو تكوين لـ NeoVim. تساعد هذه المواصفات في إدارة مجموعة الإضافات المستخدمة في AstroNvim.

## 📦 الإعداد

لدمج إضافات المجتمع، أضف التكوينات المقدمة إلى إعداد `plugins` الخاص بك ويفضل أن يكون ذلك قبل استيراد إضافاتك الخاصة لضمان تحميل جميع تغييرات AstroCommunity قبل تجاوزاتك الخاصة. إذا كنت تستخدم [قالب AstroNvim](https://github.com/AstroNvim/template) يمكن القيام بذلك في ملف `lua/community.lua` الخاص بك. إذا لم تكن معتادًا على تكوين الإضافات، نوصي بالرجوع إلى [توثيق AstroNvim](https://docs.astronvim.com/configuration/customizing_plugins/).

### استيراد إضافات AstroCommunity

ادمج المحتوى التالي داخل ملف `lua/community.lua` الخاص بك:

```lua
return {
  "AstroNvim/astrocommunity",
  { import = "https://raw.githubusercontent.com/AstroNvim/astrocommunity/main/colorscheme/catppuccin" },
  -- ... استيراد أي إضافات ساهم بها المجتمع هنا
}
```

### تخصيص تثبيتات AstroCommunity

بمجرد تعريف استيرادات AstroCommunity في `lua/community.lua` الخاص بك، يمكنك بعد ذلك تخصيص التثبيتات أكثر في تعريفات الإضافات الخاصة بك (عادة في دليل `lua/plugins/`). إليك مثال بافتراض أنك قمت بتثبيت Catppuccin كما هو موضح أعلاه.

```lua
return {
  { -- تخصيص الخيارات التي وضعتها المجتمع بشكل أعمق
    "catppuccin",
    opts = {
      integrations = {
        sandwich = false,
        noice = true,
        mini = true,
        leap = true,
        markdown = true,
        neotest = true,
        cmp = true,
        overseer = true,
        lsp_trouble = true,
        rainbow_delimiters = true,
      },
    },
  },
}
```

**ملاحظات:**

- لتعطيل الاستيرادات، اضبط خيار `enabled` على `false`. لديك طريقتان لتعديل إضافة موجودة: استخدم اسم المستودع الكامل (مثلاً "m4xshen/smartcolumn.nvim") أو اسم الوحدة (مثلاً "catppuccin"). تذكر أن اسم الوحدة قد يختلف عن اسم المجلد.
- يُنصح باستخدام مسار الاستيراد الكامل عند تخصيص إضافة، وليس الاختصار الذي يقتصر على اسم المستودع فقط.
- يمكنك تجاوز العديد من جوانب إضافات المجتمع بما في ذلك الإعدادات، التبعيات، والإصدارات. لمزيد من التفاصيل حول الخيارات المتاحة، راجع [توثيق lazy.nvim](https://lazy.folke.io/).

## المساهمة

إذا قمت بكتابة تكوين إضافة وترغب في إضافته إلى مستودع AstroCommunity، يرجى اتباع [إرشادات المساهمة](https://raw.githubusercontent.com/AstroNvim/astrocommunity/main/CONTRIBUTING.md) وتقديم طلب سحب. تأكد من اختبار تغييراتك بدقة قبل التقديم. هذا ليس مستودعًا رسميًا، لذا تعتمد استقراريته على مساهمات المجتمع. نحن متحمسون لرؤية كيف ينمو هذا المشروع ويتطور!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---