
<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# لا شيء سوى نيكس

**حوّل جهاز تشغيل GitHub Actions الخاص بك إلى قوة [نيكس](https://zero-to-nix.com/concepts/nix/) ❄️ من خلال القضاء التام على البرامج المثبتة غير الضرورية.**

يأتي جهاز تشغيل GitHub Actions بمساحة قرص محدودة جدًا لنيكس - حوالي ~20 جيجابايت فقط.
*لا شيء سوى نيكس* **يقوم بحذف البرمجيات غير الضرورية بشكل وحشي**، ليمنحك **65GB إلى 130GB** لمخزن نيكس الخاص بك! 💪

## كيفية الاستخدام 🔧

أضف هذا الإجراء **قبل** تثبيت نيكس في سير العمل الخاص بك:

```yaml
jobs:
  build:
    runs-on: ubuntu-latest
    permissions:
      contents: read
      id-token: write
    steps:
      - uses: actions/checkout@v4
      - uses: wimpysworld/nothing-but-nix@main
      - name: Install Nix
        uses: DeterminateSystems/nix-installer-action@main
      - name: Run Nix
        run: |
          nix --version
          # Your Nix-powered steps here...
```

### المتطلبات ️✔️

- يدعم فقط **عدّادات GitHub Actions الرسمية لأوبونتو**
- يجب أن يعمل **قبل** تثبيت Nix

## المشكلة: إتاحة المساحة لازدهار Nix 🌱

عدّادات GitHub Actions القياسية مليئة بـ *"البرمجيات الزائدة"* التي لن تستخدمها أبداً في سير عمل Nix:

- 🌍 متصفحات الويب. الكثير منها. يجب أن تتوفر كلها!
- 🐳 صور Docker تستهلك جيجابايتات من مساحة القرص الثمينة
- 💻 بيئات تشغيل لغات غير ضرورية (.NET، روبي، PHP، جافا...)
- 📦 مدراء الحزم يتجمع عليها الغبار الرقمي
- 📚 وثائق لن يقرأها أحد أبداً

هذه البرمجيات الزائدة تترك فقط ~20 جيجابايت لمخزن Nix الخاص بك - بالكاد تكفي لبناءات Nix جادة! 😞

## الحل: لا شيء سوى Nix ️❄️

**لا شيء سوى Nix** يتبع نهج الأرض المحروقة مع عدّادات GitHub Actions ويستعيد مساحة القرص بلا رحمة باستخدام هجوم من مرحلتين:

1. **الضربة الأولية:** ينشئ على الفور وحدة تخزين `/nix` كبيرة (~65 جيجابايت) عن طريق الاستحواذ على المساحة الحرة من `/mnt`
2. **الهجوم في الخلفية:** بينما يستمر سير عملك، نقوم بإزالة البرامج غير الضرورية بلا رحمة لتوسيع وحدة تخزين `/nix` حتى ~130 جيجابايت
   - متصفحات الويب؟ لا ⛔
   - صور Docker؟ تم حذفها 🗑️
   - بيئات تشغيل اللغات؟ تم محوها 💥
   - مدراء الحزم؟ تم تدميرهم 💣
   - الوثائق؟ تم تبخيرها ️👻

يتم تشغيل عملية التنظيف بواسطة `rmz` (من مشروع [أوامر يونكس السريعة (FUC)](https://github.com/SUPERCILEX/fuc)) - بديل عالي الأداء لأمر `rm` يجعل استعادة المساحة فائقة السرعة! ⚡
   - يتفوق على أمر `rm` التقليدي بفارق كبير
   - يحذف الملفات بشكل متوازي لتحقيق أقصى كفاءة
   - **يستعيد مساحة القرص في ثوانٍ بدلاً من دقائق!** ️⏱️

النتيجة النهائية؟ عدّاد GitHub Actions مع **65 جيجابايت إلى 130 جيجابايت** من المساحة الجاهزة لـ Nix! 😁

### نمو الحجم الديناميكي

على عكس الحلول الأخرى، يقوم **لا شيء سوى Nix** بزيادة حجم `/nix` الخاص بك بشكل ديناميكي:

1. **إنشاء الحجم الأولي (1-10 ثوان):** (*اعتماداً على بروتوكول Hatchet*)
   - ينشئ جهاز loop من المساحة الحرة على `/mnt`
   - يُعد نظام ملفات BTRFS بتكوين RAID0
   - يركب مع ضغط وضبط للأداء
   - يوفر `/nix` بسعة 65 جيجابايت فوراً، حتى قبل بدء التنظيف

2. **التوسعة في الخلفية (30-180 ثانية):** (*اعتماداً على بروتوكول Hatchet*)
   - ينفذ عمليات التنظيف
   - يراقب المساحة التي تم تحريرها حديثاً مع إزالة البرمجيات الزائدة
   - يضيف قرص توسعة ديناميكياً إلى وحدة تخزين `/nix`
   - يعيد موازنة نظام الملفات لدمج المساحة الجديدة

حجم `/nix` ينمو تلقائياً **أثناء تنفيذ سير العمل** 🎩🪄

### اختر أداتك: بروتوكول Hatchet 🪓

تحكم في مستوى الإزالة 💥 باستخدام المُدخل `hatchet-protocol`:

```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    hatchet-protocol: 'cleave'  # Options: holster, carve, cleave (default), rampage
```

#### مقارنة البروتوكولات ⚖️

| البروتوكول | `/nix` | الوصف                                               | تطهير apt  | تطهير docker | تطهير snap | أنظمة الملفات التي تم تطهيرها     |
|------------|--------|------------------------------------------------------|------------|--------------|------------|-------------------------------|
| Holster    | ~65GB  | احتفظ بالفأس في غمده، استخدم المساحة من `/mnt`      | لا         | لا           | لا         | لا شيء                         |
| Carve      | ~85GB  | صمم وادمج المساحة الحرة من `/` و `/mnt`              | لا         | لا           | لا         | لا شيء                         |
| Cleave     | ~115GB | إجراء تخفيضات قوية وحاسمة على الحزم الكبيرة          | حد أدنى    | نعم          | نعم        | `/opt` و `/usr/local`          |
| Rampage    | ~130GB | القضاء بلا هوادة وبقسوة على جميع الانتفاخات          | عدواني     | نعم          | نعم        | موهاهاها! 🔥🌎                |

اختر بحكمة:
- **Holster** عندما تحتاج أن تظل أدوات العداء تعمل بشكل كامل
- **Carve** للحفاظ على أدوات العداء الوظيفية ولكن للحصول على كل المساحة الحرة لـ Nix
- **Cleave** (*الإعداد الافتراضي*) لتحقيق توازن جيد بين المساحة والوظائف
- **Rampage** عندما تحتاج إلى أقصى مساحة لـ Nix ولا تهتم بما قد يتعطل `#nix-is-life`

### شاهد المجزرة 🩸

بشكل افتراضي، تتم عملية التطهير بصمت في الخلفية أثناء استمرار سير عملك. ولكن إذا كنت ترغب في مشاهدة المذبحة في الوقت الحقيقي:

```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    ️hatchet-protocol: 'cleave'
    witness-carnage: true  # Default: false
```

### تخصيص المناطق الآمنة 🛡️

تحكم في مقدار المساحة التي تريد استثناؤها من استحواذ متجر Nix باستخدام أحجام مخصصة للمناطق الآمنة:

```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    ️hatchet-protocol: 'cleave'
    root-safe-haven: '3072'   # Reserve 3GB on the / filesystem
    mnt-safe-haven: '2048'    # Reserve 2GB on the /mnt filesystem
```

تحدد هذه المناطق الآمنة مقدار المساحة (بالميجابايت) التي سيتم استثناؤها من عملية استعادة المساحة برحمة:
- القيمة الافتراضية لـ `root-safe-haven` هي 2048 ميجابايت (2 جيجابايت)
- القيمة الافتراضية لـ `mnt-safe-haven` هي 1024 ميجابايت (1 جيجابايت)

قم بزيادة هذه القيم إذا كنت بحاجة إلى مساحة أكبر على أنظمة الملفات لديك، أو قللها إذا أردت عدم الرحمة! 😈

### منح ملكية المستخدم لمجلد /nix (مرسوم أذونات Nix) 🧑‍⚖️

يتوقع بعض مثبتات أو إعدادات Nix أن يكون مجلد `/nix` قابلاً للكتابة من قبل المستخدم الحالي. افتراضياً، يكون `/nix` مملوكاً للمستخدم الجذر (root). إذا كنت بحاجة إلى منح الملكية للمستخدم (مثلاً لبعض نصوص تثبيت Nix التي لا تستخدم `sudo` لجميع العمليات داخل `/nix`)، يمكنك تفعيل `nix-permission-edict`:

```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    nix-permission-edict: true  # Default: false
```
عندما يتم تعيين `nix-permission-edict` إلى `true`، ستقوم العملية بتنفيذ الأمر `sudo chown -R "$(id --user)":"$(id --group)" /nix` بعد تركيب `/nix`.

الآن انطلق وابنِ شيئًا مذهلًا باستخدام كل تلك المساحة الرائعة في متجر Nix! ❄️


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-24

---