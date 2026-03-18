
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

# لا شيء سوى نكس

**حوّل مشغّل GitHub Actions الخاص بك إلى قوة [Nix](https://zero-to-nix.com/concepts/nix/) ❄️ حقيقية من خلال إزالة البرامج المثبتة مسبقًا بلا رحمة.**

يأتي مشغّل GitHub Actions بمساحة قرص ضئيلة لـ Nix — حوالي ~20 جيجابايت فقط.
*لا شيء سوى نكس* **يقوم بحذف البرامج غير الضرورية بقسوة**، ليمنحك **65 جيجابايت إلى 130 جيجابايت** لمخزن نكس الخاص بك! 💪

## الاستخدام 🔧

أضف هذا الإجراء **قبل** تثبيت Nix في سير العمل الخاص بك:

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

- يدعم فقط مشغلات GitHub Actions الرسمية لنظام **Ubuntu**
- يجب أن يعمل **قبل** تثبيت Nix
- **مشغلات macOS/Darwin**: ستتخطى هذه العملية بشكل سلس مع تحذير إذا تم تشغيلها على macOS. مشغلات macOS توفر مساحة كافية لـ Nix ولا تحتاج إلى هذه العملية
- **مشغلات Windows**: ستتخطى هذه العملية بشكل سلس مع تحذير إذا تم تشغيلها على Windows. مشغلات Windows لها تخطيطات نظام ملفات وقيود مختلفة

## المشكلة: توفير مساحة لازدهار Nix 🌱

مشغلات GitHub Actions القياسية مليئة بـ *"البرامج غير الضرورية"* التي لن تستخدمها أبداً في سير عمل Nix:

- 🌍 متصفحات ويب. الكثير منها. يجب أن تمتلكهم جميعاً!
- 🐳 صور Docker تستهلك جيجابايتات من مساحة القرص الثمينة
- 💻 بيئات لغات غير ضرورية (.NET، Ruby، PHP، Java...)
- 📦 مدراء الحزم يجمعون غباراً رقمياً
- 📚 وثائق لن يقرأها أحد

هذا التضخم يترك فقط ~20 جيجابايت لمخزن Nix الخاص بك - بالكاد يكفي لبناءات Nix الجادة! 😞

## الحل: لا شيء سوى Nix ️❄️

**لا شيء سوى Nix** يتبع نهجاً حاسماً مع مشغلات GitHub Actions ويستعيد مساحة القرص بلا رحمة باستخدام هجوم من مرحلتين:

1. **القطع الأولي:** ينشئ فوراً حجم `/nix` كبير (~65 جيجابايت) عبر الاستيلاء على المساحة الحرة من `/mnt`
2. **الهجوم الخلفي:** بينما يستمر سير العمل الخاص بك، نقوم بإزالة البرامج غير الضرورية لتوسيع حجم `/nix` حتى ~130 جيجابايت
   - متصفحات الويب؟ لا ⛔
   - صور Docker؟ انتهت 🗑️
   - بيئات لغات البرمجة؟ تم تدميرها 💥
   - مدراء الحزم؟ تم القضاء عليهم 💣
   - الوثائق؟ تبخرت ️👻

تتم عملية تطهير نظام الملفات بواسطة `rmz` (من مشروع [Fast Unix Commands (FUC)](https://github.com/SUPERCILEX/fuc)) - بديل عالي الأداء لـ `rm` يجعل استعادة المساحة سريعاً جداً! ⚡
   - يتفوق على `rm` القياسي بمقدار كبير
   - يحذف بشكل متوازي لتحقيق أعلى كفاءة
   - **يستعيد مساحة القرص في ثوانٍ بدلاً من دقائق!** ️⏱️

النتيجة النهائية؟ مشغل GitHub Actions مع **65 جيجابايت إلى 130 جيجابايت** من المساحة الجاهزة لـ Nix! 😁

### نمو الحجم الديناميكي
على عكس الحلول الأخرى، يقوم **Nothing but Nix** بتوسيع وحدة التخزين `/nix` بشكل ديناميكي:

1. **إنشاء وحدة التخزين الأولية (1-10 ثواني):** (*اعتماداً على بروتوكول Hatchet*)
   - ينشئ جهاز حلقة من المساحة الحرة على `/mnt`
   - يجهز نظام ملفات BTRFS بتكوين RAID0
   - يقوم بالتركيب مع ضغط وتحسين الأداء
   - يوفر `/nix` بسعة 65GB فوراً، حتى قبل بدء عملية التطهير

2. **التوسع في الخلفية (30-180 ثانية):** (*اعتماداً على بروتوكول Hatchet*)
   - ينفذ عمليات التطهير
   - يراقب المساحة التي تم تحريرها حديثاً مع التخلص من الانتفاخ
   - يضيف قرص توسعة ديناميكياً إلى وحدة التخزين `/nix`
   - يعيد توازن نظام الملفات لدمج المساحة الجديدة

وحدة التخزين `/nix` تتوسع تلقائياً **أثناء تنفيذ سير العمل** 🎩🪄

### اختر أداتك: بروتوكول Hatchet 🪓

تحكم في مستوى الإبادة 💥 عبر خيار `hatchet-protocol`:


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
عندما يتم تعيين `nix-permission-edict` إلى `true`، ستقوم العملية بتشغيل الأمر `sudo chown -R "$(id --user)":"$(id --group)" /nix` بعد تركيب مجلد `/nix`.

### إعداد Nix لاستخدام /nix/build

تقوم هذه العملية بإنشاء `/nix/build` حتى تتمكن إنشاءات Nix من استخدام المساحة المستعادة. أضف `build-dir` إلى إعدادات Nix الخاصة بك:


```yaml
- uses: cachix/install-nix-action@v31
  with:
    extra_nix_config: |
      build-dir = /nix/build
```
أو مع DeterminateSystems:


```yaml
- uses: DeterminateSystems/nix-installer-action@main
  with:
    extra-conf: |
      build-dir = /nix/build
```

يُوجّه هذا الأمر Nix لتنفيذ عمليات البناء على وحدة تخزين BTRFS الكبيرة بدلاً من دليل الملفات المؤقت الافتراضي للنظام.

## استكشاف الأخطاء وإصلاحها 🔍

### "لا توجد مساحة متبقية على الجهاز" أثناء عمليات البناء الكبيرة

إذا نفدت المساحة أثناء عملية البناء على الرغم من استخدامك Nothing but Nix، فمن المرجح أن عملية التطهير في الخلفية لم تكتمل قبل أن تستهلك عملية البناء المساحة المتاحة. غالبًا ما يؤثر هذا على:

- اختبارات NixOS VM التي تجمع صور أقراص كبيرة
- عمليات البناء التي تحتوي على العديد من التبعيات غير المخزنة مؤقتًا
- سلاسل أدوات Rust وغيرها من عمليات التجميع الكبيرة

**الحل:** استخدم `witness-carnage: true` لفرض التطهير المتزامن. يضمن هذا استعادة كل المساحة *قبل* بدء عملية البناء:

```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    hatchet-protocol: 'rampage'
    witness-carnage: true
```

يضيف هذا من 30 إلى 180 ثانية لإعداد سير العمل الخاص بك، لكنه يضمن توفر أقصى مساحة عند بدء البناء الخاص بك.

الآن انطلق وابنِ شيئًا مذهلًا بكل تلك المساحة الرائعة لمخزن Nix! ❄️

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-18

---