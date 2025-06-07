# إنثيوم - إنغرامر يلتقي Hands Down Promethium

![صورة فوتوغرافية لإنثيوم v7 على لوحة مفاتيح Glove80 الخاصة بي](
https://github.com/sunaku/glove80-keymaps/raw/main/README/base-layer-photograph-Enthium.jpg
)

هذا التكيف مع تخطيطات لوحة المفاتيح [Engrammer] و[Hands Down Promethium]
يحسن أداء الأخير في محللات تخطيط لوحة المفاتيح (انظر أدناه)
عن طريق عكسه أفقيًا لاستعادة الألفة مع تخطيط [إنغرام 2.0 لـ Arno]
(CIEA على صف الارتكاز لليد اليسرى؛ تم تبديل PF مع WV ليكون مثل إنغرام)
ومع تخطيط [دفوراك] (HTNS على صف الارتكاز لليد اليمنى)، وعن طريق تحسين
وضع علامات الترقيم للبرمجة على نهج تخطيط إنغرامر.

من الجدير بالذكر أن الفروق بين إنغرامر/إنغرام وإنثيوم ضئيلة للغاية بحيث
يمكن لأي شخص التحول إليه بالكامل بحوالي 6 ساعات من التدريب، موزعة على 2-3
أيام (ابدأ من الجمعة واستخدم عطلة نهاية الأسبوع)، لفتح جميع الحروف في تدريب [KeyBr].

انظر أيضاً: [مقالتي على المدونة](https://sunaku.github.io/enthium-keyboard-layout.html)
حول الرحلة غير المتوقعة "داخل جحر الأرنب" التي أدت بي إلى تطوير هذا التخطيط.

[Hands Down Promethium]: https://reddit.com/r/KeyboardLayouts/comments/1g66ivi
[Arno's Engram 2.0]:     https://engram.dev
[Engrammer]:             https://github.com/sunaku/engrammer
[Dvorak]:                https://www.dvzine.org
[KeyBr]:                 https://github.com/aradzie/keybr.com#readme

## التخطيط

      q y o u - x l d w z
    b c i e a , k h t n s v
      ' / = . ; j m g p f
                r

>![عرض إنثيوم v7 على لوحة مفاتيح لابتوب.](https://raw.githubusercontent.com/sunaku/enthium/main/linux/layout.png)
>![عرض إنثيوم v7 على لوحة مفاتيح Glove80 الخاصة بي.](
https://github.com/sunaku/glove80-keymaps/raw/main/README/base-layer-diagram-Enthium.png
)

<!-- vim-markdown-toc GFM -->

* [الدوافع](#rationale)
  * [انحراف: PF وWV](#deviation-pf-and-wv)
  * [انحراف: B وV](#deviation-b-and-v)
* [الأداء](#performance)
  * [محلل Cyanophage](#cyanophage-analyzer)
  * [محلل KeySolve](#keysolve-analyzer)
  * [محلل Oxey](#oxeys-analyzer)
  * [المقارنة](#comparison)
* [التثبيت](#installation)
  * [إعداد لينكس](#linux-setup)
  * [إعداد MacOS](#macos-setup)
    * [التثبيت](#installation-1)
    * [تعديل معقد](#complex-modification)
    * [إلغاء التثبيت](#uninstallation)
* [الترخيص](#license)

<!-- vim-markdown-toc -->

## الدوافع

* تم توزيع Q وZ على يدين مختلفتين لتحقيق التوازن والتماثل.

* تم وضع B وV على مفاتيح الخنصر الجانبية في صف الارتكاز (CapsLock، الفاصلة العليا)
  لتجنب مد اليد للأعلى، خاصة لمن لديهم أصابع خنصر قصيرة أو [ضعيفة].

* تم إبعاد الفاصلة العليا (Apostrophe) (على إصبع مختلف كلياً) عن YOU وI
  بحيث يمكن كتابتها دون توليد bigrams بنفس الإصبع مثل `you'd` و`I'd`.

* تم تجميع الفاصلة والمنقوطة لتسهيل البحث المتسلسل f/F/t/T في محرر Vim
  وأيضاً لعكس ترتيب K وJ النسبي على اليد اليمنى.

* رغم أن النقطة والفاصلة معكوسان من حيث رموز shift (`>` و`<`)، هذا الترتيب
  يقلل من bigrams التمدد الجانبي ويضعهما رأسياً فوق بعض على لوحات المفاتيح التقليدية.

* تم وضع علامة الطرح على إصبع السبابة (مثل الفاصلة، النقطة، المنقوطة)
  لتحمل مسؤولية علامات الترقيم الفاصلة بين الكلمات/الجمل
  ولسهولة الوصول إلى الشرطة السفلية `_` المتكررة في البرمجة،
  خاصة على لوحات المفاتيح المتدرجة الصفوف حيث يكون مكانها في اتجاه امتداد السبابة اليسرى.

* يسمح كل من الشرطة المائلة والنقطة بالتدوير السهل لمسارات الأنظمة مثل `/.` و`./` و`../`.

[ضعيفة]: https://reddit.com/r/KeyboardLayouts/comments/1fy8nve/_/lqulnww/

### انحراف: PF وWV

تم تبديل PF مع WV لمعالجة الإزعاجات التالية:

* WN هو bigram بنفس الإصبع بتسلسل "درج" كنت أتمنى لو أمكنني سحبه للأسفل بدلاً من ذلك
* DW (تخطي وحدتين) ليست مريحة في Vim كما كانت في Engram (حيث هما متجاورتان)
* FG (تخطي وحدتين) ليست مريحة لأوامر وظائف الخلفية في الشل (`bg`, `fg`) كما في Engram
* SW (نصف مقص) تبدو أضعف قليلاً عند الثني للداخل مقارنة بالوصول للأعلى (كما في Engram)
* FF (مثل "stu*ff*") مرهقة قليلاً لخنصر اليد للنقر مرتين في الصف العلوي

كنت حقاً لا أرغب في الانحراف عن تخطيط Hands Down Promethium الأصلي
(كان من المفترض أن يكون "إنثيوم" هذا مجرد مرآة أفقية بسيطة مع بعض علامات الترقيم المعاد ترتيبها)
لذا ذهبت على مضض إلى ساحات اللعب لمحللات تخطيط لوحة المفاتيح لأرى مدى سوء تبديل PF مع WV...
ولدهشتي التامة، لم يؤثر هذا التغيير تقريباً على أداء التخطيط:

* محلل Oxey لم يُظهر أي تغييرات في الإحصاءات!
* محلل KeySolve أظهر زيادة في FSB من 0.14% إلى 0.37% لكن بقية الإحصاءات تحسنت:
  انخفضت FSS من 0.82% إلى 0.48%، HSB من 6.05% إلى 5.64%، HSS من 5.97% إلى 5.50%؛
  والباقي بقي كما هو.
* زاد مجموع جهد الكلمات في محلل Cyanophage من 730.9 إلى 735.9 لكن باقي الإحصاءات لم تتغير!

أنا _سعيد جداً_ أن هذه التجربة نجحت لأنها جعلت التخطيط أكثر راحة لي عملياً
كما أنها ستقلل الحاجز أمام الآخرين الراغبين بالانتقال من تخطيط Engrammer إلى Enthium. :)

### انحراف: B وV

تم تدوير B وV من الصف العلوي إلى صف الارتكاز الجانبي
لتجنب مد اليد للأعلى لمن لديهم أصابع خنصر قصيرة أو [ضعيفة].
وتم إعادة تعيين مفاتيحهما إلى أقل الحروف شيوعاً في اللغة الإنجليزية: Q وZ.

في محلل Cyanophage، يقل هذا التغيير من مقصات الخنصر/البنصر من 0.49% إلى 0.35%
(انخفاض ضخم!) وSkip Bigrams (تخطي وحدتين) من 0.30% إلى 0.29%.
لا تفسر المحللات الأخرى تماماً وضع مفاتيح الخنصر الجانبية،
كما هو موضح في ملاحظة أعلى كل قسم فرعي لكل محلل،
لكن محلل Oxey أظهر انخفاضاً ملحوظاً في SFBs من 0.829% إلى 0.818%.

## الأداء

### [محلل Cyanophage][cNT]

> **ملاحظة:** هذا المحلل حالياً لديه قيد حيث يدعم وضع حرف على إبهام اليد اليسرى فقط وليس اليمنى،
> لذا يتم عكس هذا التخطيط أفقياً للتحليل. الانعكاس لا يؤثر على النتائج.

![لقطة شاشة](https://raw.githubusercontent.com/sunaku/enthium/main/stats/enthium/cyanophage.png)

الإحصاءات العامة:
* مجموع جهد الكلمات: 748.5
* الجهد:              432.54

استخدام الأصابع:
* Bigrams بنفس الإصبع: 0.55%
* Bigrams تخطي وحدتين: 0.29%
* Bigrams تمدد جانبي:  0.23%
* مقصات الخنصر/البنصر: 0.34%

إحصاءات Trigram:
* تبديل:             37.45%
* bigram roll in:    29.02%
* bigram roll out:   14.67%
* أخرى:              8.28%
* alt sfs:           5.10%
* redirect:          2.14%
* roll in:           1.71%
* weak redirect:     1.32%
* roll out:          0.31%

### [محلل KeySolve](https://grassfedreeve.github.io/keysolve-web/)

> **ملاحظة:** هذا المحلل حالياً لا يدعم وضع الحروف على مفاتيح الخنصر الجانبية
> في صف الارتكاز مثل مفتاح CapsLock التقليدي والفاصلة العليا،
> لذلك قد لا تكون النتائج دقيقة. على سبيل المثال، نسبة SFB هنا
> تفترض أن R B V جميعها تُكتب بالإبهام بينما هي في الواقع على أصابع مختلفة:
> R على إبهام اليد اليمنى، B على خنصر اليسار، V على خنصر اليمين.

![لقطة شاشة](https://raw.githubusercontent.com/sunaku/enthium/main/stats/enthium/keysolve1.png)
![لقطة شاشة](https://raw.githubusercontent.com/sunaku/enthium/main/stats/enthium/keysolve2.png)
![لقطة شاشة](https://raw.githubusercontent.com/sunaku/enthium/main/stats/enthium/keysolve3.png)

الإحصاءات العامة:

    BIGRAMS     SFB: 0.97%      LSB: 0.44%      HSB: 4.79%      FSB: 0.35%
    SKIPGRAMS   SFS: 6.99%      LSS: 0.92%      HSS: 4.66%      FSS: 0.38%
    TRIGRAMS    ALT: 41.24%     ROL: 40.71%     ONE: 2.47%      RED: 1.66%

استخدام الأصابع:

    LEFT        LI: 13.91%      LM: 20.17%      LR: 8.70%       LP: 3.05%
    RIGHT       RI: 13.12%      RM: 14.59%      RR: 10.60%      RP: 7.94%
    TOTAL               LH: 45.83%                      RH: 54.17%

مصدر مخصص للنسخ/اللصق:

    q y o u - x l d w z
    c i e a , k h t n s
    ' / = . ; j m g p f
    r b v

### [محلل Oxey](https://oxey.dev/playground/index.html)

> **ملاحظة:** هذا المحلل حالياً لا يدعم وضع الحروف على مفاتيح الخنصر الجانبية
> في صف الارتكاز مثل مفتاح CapsLock التقليدي والفاصلة العليا،
> لذلك قد لا تكون النتائج دقيقة. على سبيل المثال، نسبة SFB هنا
> تفترض أن B وV تكتبان بإبهام اليد اليسرى بينما هما في الواقع على أصابع مختلفة:
> B تكتب بخنصر اليسار وV بخنصر اليمين.

![لقطة شاشة](https://raw.githubusercontent.com/sunaku/enthium/main/stats/enthium/oxey.png)

الإحصاءات العامة:
* Sfb:              0.811%
* Dsfb:             6.286%
* Lsb:              0.372%
* Inrolls:          29.442%
* Outrolls:         15.841%
* Total Rolls:      45.283%
* Onehands:         2.348%
* Alternates:       31.877%
* Alternates (sfs): 7.284%
* Total Alternates: 39.161%
* Redirects:        3.864%
* BadRedirects:     1.002%
* Total Redirects:  4.866%
* Other:            8.341%
* Invalid:          0.001%

استخدام الأصابع:

    finger 0:   3.63%   finger 9:       8.60%
    finger 1:   9.08%   finger 8:       10.65%
    finger 2:   19.30%  finger 7:       14.56%
    finger 3:   13.28%  finger 6:       12.33%

    اليد اليسرى:   45.29% اليد اليمنى:     46.14%
    مركز اليسار:   1.384% مركز اليمين:   1.189%

    استخدام مفاتيح صف الارتكاز: 56.37%

Sfb% لكل إصبع:

    finger 0:   0.011%  finger 9:       0.024%
    finger 1:   0.047%  finger 8:       0.100%
    finger 2:   0.122%  finger 7:       0.051%
    finger 3:   0.339%  finger 6:       0.114%

### المقارنة

> **ملاحظة:** محلل Oxey حالياً لا يدعم وضع الحروف على مفاتيح الخنصر الجانبية
> في صف الارتكاز مثل مفتاح CapsLock التقليدي والفاصلة العليا،
> لذا قد لا تكون النتائج دقيقة. على سبيل المثال، نسبة SFB هنا
> تفترض أن B وV تكتبان بإبهام اليد اليسرى بينما هما في الواقع على أصابع مختلفة:
> B تكتب بخنصر اليسار وV بخنصر اليمين.
> بدلاً من ذلك، راجع [نتائج محلل Cyanophage](#cyanophage-analyzer)
> لأنه يأخذ في الاعتبار مفاتيح الخنصر الجانبية ومفتاح حرف واحد للإبهام.

يُنصح عادةً في [مجتمع تخطيطات لوحة المفاتيح][rKL] بدليل وجدول مقارنة [باسكال جيتروير][PGt]
كنقطة انطلاق لاستكشاف التخطيطات،
وستجد أن إنثيوم هو من بين أفضل التخطيطات (إحصائياً) هناك:

* 0.811% SFBs -- المركز الثاني 🥈؛ يتفوق عليه Focal فقط
* 0.372% LSBs -- المركز الأول 🥇؛ يتفوق على جميع الجدول!
* 45.283% تدوير -- يتفوق على Nerps, Gallium, MTGAP, Graphite, Dvorak, Halmak, إلخ.
* 4.866% إعادة توجيه -- يتفوق على MTGAP, Sturdy, Recurva, APTv3, Canary, Colemak, إلخ.
* 2.80% استخدام الخنصر خارج صف الارتكاز _باستثناء_ الجانبي -- يتفوق على Graphite, Canary, Gallium, MTGAP, إلخ.
  * `Q` (0.10%) + `'` (0.48%) + `Z` (0.10%) + `F` (2.12%)
* 5.35% استخدام الخنصر خارج صف الارتكاز _بما في ذلك_ الجانبي -- يتفوق على Engram, Halmak؛ ويتفوق عليه البقية
  * `Q` (0.10%) + `'` (0.48%) + `Z` (0.10%) + `F` (2.12%) + `B` (1.49%) + `V` (1.06%)

[rKL]: https://www.reddit.com/r/KeyboardLayouts/
[PGt]: https://getreuer.info/posts/keyboards/alt-layouts/index.html#which-alt-keyboard-layout-should-i-learn

للمزيد من الشمولية، قمت بجدولة جميع [الإحصاءات لهذا التخطيط والتخطيطات ذات الصلة](https://raw.githubusercontent.com/sunaku/enthium/main/stats/):

[cNT]: https://cyanophage.github.io/playground.html?layout=zwdlx-uoyq%5Csnthk%2Caeicbfpgmj%3B.%3D%2F%27vr&mode=ergo&lan=english
[cPM]: https://cyanophage.github.io/playground.html?layout=fpdlx%3Buoybzsnthk%2Caeicqvwgmj-.%27%3D%2F%5Cr&mode=ergo&lan=english
[cNG]: https://cyanophage.github.io/playground.html?layout=byou%27%3Bldwvzciea%2C.htsnqgxjk-%2Frmfp%5C%5E&mode=ergo&lan=english
[cDV]: https://cyanophage.github.io/playground.html?layout=%27%2C.pyfgcrl%2Faoeuidhtns-%3Bqjkxbmwvz%5C%5E&mode=ergo&lan=english
[cCD]: https://cyanophage.github.io/playground.html?layout=qwfpbjluy%3B-arstgmneio%27zxcdvkh%2C.%2F%5C%5E&mode=ergo&lan=english

| المحلل     | الفئة      | الإحصائية             | [Enthium][cNT] | [Promethium][cPM] | [Engrammer][cNG] | [Dvorak][cDV] | [Colemak-DH][cCD] |
| ---------- | ---------- | --------------------- | -------------- | ----------------- | ---------------- | ------------- | ----------------- |
| Oxey's     | Bigrams    | SFB                   | 0.811%         | 0.868%            | 1.511%           | 2.779%        | 1.367%            |
| Oxey's     | Bigrams    | DSFB                  | 6.286%         | 6.761%            | 7.620%           | 6.979%        | 8.767%            |
| Oxey's     | Bigrams    | LSB                   | 0.372%         | 0.404%            | 0.671%           | 1.255%        | 1.975%            |
| Oxey's     | Trigrams   | Inrolls               | 29.442%        | 29.333%           | 28.273%          | 23.820%       | 25.173%           |
| Oxey's     | Trigrams   | Outrolls              | 15.841%        | 14.526%           | 14.050%          | 15.104%       | 20.940%           |
| Oxey's     | Trigrams   | Total Rolls           | 45.283%        | 43.858%           | 42.323%          | 38.924%       | 46.113%           |
| Oxey's     | Trigrams   | Onehands              | 2.348%         | 2.189%            | 2.146%           | 0.624%        | 2.484%            |
| Oxey's     | Trigrams   | Alternates            | 31.877%        | 33.770%           | 32.483%          | 35.769%       | 22.913%           |
| Oxey's     | Trigrams   | Alternates (SFS)      | 7.284%         | 8.205%            | 8.752%           | 8.787%        | 7.461%            |
| Oxey's     | Trigrams   | Total Alternates      | 39.161%        | 41.974%           | 41.235%          | 44.556%       | 30.375%           |
| Oxey's     | Trigrams   | Redirects             | 3.864%         | 2.273%            | 3.103%           | 2.639%        | 9.081%            |
| Oxey's     | Trigrams   | BadRedirects          | 1.002%         | 1.236%            | 1.386%           | 0.818%        | 1.498%            |
| Oxey's     | Trigrams   | Total Redirects       | 4.866%         | 3.509%            | 4.489%           | 3.458%        | 10.579%           |
| Oxey's     | Trigrams   | Other                 | 8.341%         | 8.468%            | 9.806%           | 12.437%       | 9.202%            |
| Oxey's     | Trigrams   | Invalid               | 0.001%         | 0.001%            | 0.001%           | 0.001%        | 1.248%            |
| Oxey's     | Usage      | Finger 0              | 3.63%          | 9.56%             | 6.58%            | 8.50%         | 8.12%             |
| Oxey's     | Usage      | Finger 1              | 9.08%          | 10.65%            | 9.21%            | 8.72%         | 8.04%             |
| Oxey's     | Usage      | Finger 2              | 19.30%         | 14.56%            | 19.47%           | 12.99%        | 11.55%            |
| Oxey's     | Usage      | Finger 3              | 13.28%         | 12.33%            | 13.35%           | 14.95%        | 19.19%            |
| Oxey's     | Usage      | Finger 6              | 12.33%         | 13.28%            | 16.04%           | 16.33%        | 18.88%            |
| Oxey's     | Usage      | Finger 7              | 14.56%         | 19.77%            | 14.93%           | 13.73%        | 15.60%            |
| Oxey's     | Usage      | Finger 8              | 10.65%         | 9.01%             | 10.31%           | 13.84%        | 10.11%            |
| Oxey's     | Usage      | Finger 9              | 8.60%          | 4.62%             | 9.90%            | 10.59%        | 7.77%             |
| Oxey's     | Usage      | Left hand             | 45.29%         | 47.10%            | 48.61%           | 45.16%        | 46.89%            |
| Oxey's     | Usage      | Right hand            | 46.14%         | 46.68%            | 51.18%           | 54.49%        | 52.36%            |
| Oxey's     | Usage      | Left center           | 1.384%         | 1.189%            | 1.765%           | 9.208%        | 4.592%            |
| Oxey's     | Usage      | Right center          | 1.189%         | 1.384%            | 1.294%           | 7.257%        | 3.393%            |
| Oxey's     | Usage      | Home keys             | 56.37%         | 56.37%            | 56.37%           | 56.70%        | 62.31%            |
| Oxey's     | SFB%       | Finger 0              | 0.011%         | 0.028%            | 0.012%           | 0.020%        | 0.041%            |
| Oxey's     | SFB%       | Finger 1              | 0.047%         | 0.100%            | 0.089%           | 0.028%        | 0.047%            |
| Oxey's     | SFB%       | Finger 2              | 0.122%         | 0.051%            | 0.230%           | 0.253%        | 0.186%            |
| Oxey's     | SFB%       | Finger 3              | 0.339%         | 0.114%            | 0.591%           | 1.075%        | 0.219%            |
| Oxey's     | SFB%       | Finger 6              | 0.114%         | 0.339%            | 0.380%           | 0.433%        | 0.388%            |
| Oxey's     | SFB%       | Finger 7              | 0.051%         | 0.185%            | 0.053%           | 0.494%        | 0.341%            |
| Oxey's     | SFB%       | Finger 8              | 0.100%         | 0.040%            | 0.098%           | 0.256%        | 0.137%            |
| Oxey's     | SFB%       | Finger 9              | 0.024%         | 0.011%            | 0.058%           | 0.220%        | 0.007%            |
| KeySolve   | Bigrams    | SFB                   | 0.97%          | 0.94%             | 1.56%            | 2.62%         | 1.49%             |
| KeySolve   | Bigrams    | LSB                   | 0.44%          | 0.45%             | 0.98%            | 1.17%         | 2.21%             |
| KeySolve   | Bigrams    | HSB                   | 4.79%          | 6.04%             | 3.02%            | 6.11%         | 5.93%             |
| KeySolve   | Bigrams    | FSB                   | 0.35%          | 0.26%             | 0.30%            | 0.14%         | 0.37%             |
| KeySolve   | Skipgrams  | SFS                   | 6.99%          | 7.02%             | 7.50%            | 7.00%         | 7.95%             |
| KeySolve   | Skipgrams  | LSS                   | 0.92%          | 0.93%             | 1.34%            | 4.48%         | 1.75%             |
| KeySolve   | Skipgrams  | HSS                   | 4.66%          | 6.11%             | 6.91%            | 8.56%         | 6.49%             |
| KeySolve   | Skipgrams  | FSS                   | 0.38%          | 0.78%             | 0.81%            | 1.22%         | 0.78%             |
| KeySolve   | Trigrams   | ALT                   | 41.24%         | 40.37%            | 39.59%           | 41.70%        | 27.58%            |
| KeySolve   | Trigrams   | ROL                   | 40.71%         | 40.84%            | 39.35%           | 37.19%        | 42.78%            |
| KeySolve   | Trigrams   | ONE                   | 2.47%          | 2.66%             | 2.65%            | 0.43%         | 2.45%             |
| KeySolve   | Trigrams   | RED                   | 1.66%          | 1.78%             | 2.65%            | 2.25%         | 6.74%             |
| KeySolve   | Usage      | LI                    | 13.91%         | 13.91%            | 13.91%           | 14.56%        | 18.82%            |
| KeySolve   | Usage      | LM                    | 20.17%         | 20.92%            | 20.30%           | 13.96%        | 10.18%            |
| KeySolve   | Usage      | LR                    | 8.70%          | 8.70%             | 8.83%            | 9.55%         | 7.83%             |
| KeySolve   | Usage      | LP                    | 3.05%          | 3.64%             | 5.72%            | 8.24%         | 7.63%             |
| KeySolve   | Usage      | RI                    | 13.12%         | 13.12%            | 16.52%           | 16.90%        | 20.00%            |
| KeySolve   | Usage      | RM                    | 14.59%         | 14.59%            | 15.03%           | 13.35%        | 16.91%            |
| KeySolve   | Usage      | RR                    | 10.60%         | 10.60%            | 10.08%           | 13.36%        | 10.46%            |
| KeySolve   | Usage      | RP                    | 7.94%          | 8.95%             | 9.47%            | 10.08%        | 8.16%             |
| KeySolve   | Total      | LH                    | 45.83%         | 47.18%            | 48.75%           | 46.31%        | 44.46%            |
| KeySolve   | Total      | RH                    | 54.17%         | 52.82%            | 51.25%           | 53.69%        | 55.54%            |
| Cyanophage | الملخص     | مجموع جهد الكلمات     | 748.5          | 732.3             | 899.8            | 1185.5        | 1048.2            |
| Cyanophage | الملخص     | الجهد                 | 432.54         | 398.07            | 457.44           | 769.78        | 535.05            |
| Cyanophage | Bigrams    | Same Finger Bigrams   | 0.55%          | 0.58%             | 0.99%            | 1.87%         | 0.91%             |
| Cyanophage | Bigrams    | Skip Bigrams (2u)     | 0.29%          | 0.36%             | 0.39%            | 0.45%         | 0.41%             |
| Cyanophage | Bigrams    | Lat Stretch Bigrams   | 0.23%          | 0.24%             | 0.41%            | 0.80%         | 1.27%             |
| Cyanophage | Bigrams    | Pinky/Ring Scissors   | 0.34%          | 0.42%             | 0.71%            | 0.40%         | 0.65%             |
| Cyanophage | Trigrams   | Alt                   | 37.45%         | 36.98%            | 35.62%           | 39.08%        | 25.43%            |
| Cyanophage | Trigrams   | Alt SFS               | 5.10%          | 5.27%             | 5.93%            | 5.85%         | 5.47%             |
| Cyanophage | Trigrams   | Roll in               | 1.71%          | 1.37%             | 1.82%            | 0.86%         | 1.50%             |
| Cyanophage | Trigrams   | Roll out              | 0.31%          | 0.11%             | 0.29%            | 0.27%         | 0.98%             |
| Cyanophage | Trigrams   | Bigram roll in        | 29.02%         | 29.18%            | 28.14%           | 23.51%        | 25.18%            |
| Cyanophage | Trigrams   | Bigram roll out       | 14.67%         | 14.56%            | 14.03%           | 15.14%        | 21.55%            |
| Cyanophage | Trigrams   | Redirect              | 2.14%          | 2.03%             | 3.05%            | 2.57%         | 9.22%             |
| Cyanophage | Trigrams   | Weak redirect         | 1.32%          | 1.30%             | 1.40%            | 0.28%         | 1.52%             |
| Cyanophage | Trigrams   | Other                 | 8.28%          | 9.20%             | 9.72%            | 12.44%        | 9.17%             |

## التثبيت

### إعداد لينكس

>*الأسطورة:* QWERTY=أبيض؛ Engram=ذهبي؛ Enthium=أزرق/أخضر؛ Quirks=وردي.
>![عرض هذا التخطيط على لوحة مفاتيح متدرجة الصفوف.](https://raw.githubusercontent.com/sunaku/enthium/main/linux/layout.png)

التثبيت:

    cd linux/
    sudo make install
    echo أعد تشغيل الجلسة الرسومية الآن.

التفعيل:

    setxkbmap -layout us    -variant enthium         # تخطيط واحد؛ بدون تبديل
    setxkbmap -layout us,us -variant enthium,basic   # تبديل بين تخطيطين

الإصلاح (مثلاً عند ترقية حزمة XKB النظامية وإعادة التثبيت):

    cd linux/
    sudo make reinstall
    echo أعد تشغيل الجلسة الرسومية الآن.

إلغاء التثبيت:

    cd linux/
    sudo make uninstall
    echo أعد تشغيل الجلسة الرسومية الآن.

### إعداد MacOS

#### التثبيت

لاستخدام التخطيط على MacOS، ستحتاج لتثبيت [Karabiner-Elements](https://karabiner-elements.pqrs.org/).

يمكنك تثبيته عبر [Homebrew](https://brew.sh/):

    brew install --cask karabiner-elements

أو تحميله من [الموقع الرئيسي لـ Karabiner-Elements](https://karabiner-elements.pqrs.org/).

عند التحميل، فقط اتبع تعليمات [دليل التثبيت](https://karabiner-elements.pqrs.org/docs/getting-started/installation/).

#### تعديل معقد

بعد تثبيت كل شيء، يمكنك استخدام [ميزة التعديل المعقد](https://karabiner-elements.pqrs.org/docs/manual/configuration/configure-complex-modifications/)
لإعادة تعيين المفاتيح.

تعديل enthium المعقد متاح [هنا](https://ke-complex-modifications.pqrs.org/?q=enthium).

للعودة إلى التخطيط الأساسي، يمكنك ببساطة إزالة تعديل enthium المعقد.

#### إلغاء التثبيت

* عبر Brew : `brew uninstall --cask karabiner-elements`
* يدويًا : احذف تطبيق `Karabiner-Elements.app` من مجلد التطبيقات.

## الترخيص

تم الإتاحة بنفس شروط مصادر تخطيط لوحة مفاتيح [إنغرام 2.0 لـ Arno]:

> رخصة MIT
>
> حقوق النشر 2022 Ricard Figueroa <https://github.com/rfiga>  
> حقوق النشر 2021 Suraj Kurapati <https://github.com/sunaku>  
> حقوق النشر 2021 Arno Klein <https://github.com/binarybottle>  
>
> يُمنح الإذن بموجب هذه الرخصة، بدون مقابل، لأي شخص يحصل على نسخة
> من هذا البرنامج وملفات التوثيق المرتبطة به ("البرنامج")، للتعامل
> مع البرنامج دون قيود، بما في ذلك على سبيل المثال لا الحصر حقوق
> الاستخدام، النسخ، التعديل، الدمج، النشر، التوزيع، الترخيص الفرعي، و/أو بيع
> نسخ من البرنامج، والسماح للأشخاص الذين تم توفير البرنامج لهم بذلك،
> وفقًا للشروط التالية:
>
> يجب تضمين إشعار حقوق النشر أعلاه وإشعار الإذن هذا في جميع نسخ أو أجزاء كبيرة من البرنامج.
>
> يُقدَّم البرنامج "كما هو"، دون أي ضمان من أي نوع، صريح أو ضمني،
> بما في ذلك على سبيل المثال لا الحصر ضمانات القابلية للتسويق،
> الملاءمة لغرض معين وعدم الانتهاك. في أي حال من الأحوال لن يكون المؤلفون
> أو حاملو حقوق النشر مسؤولين عن أي مطالبة أو ضرر أو مسؤولية أخرى،
> سواء في إجراء قانوني أو تعاقدي أو غير ذلك، ناتجة عن أو مرتبطة بالبرنامج
> أو استخدامه أو غير ذلك من التعاملات في البرنامج.

---------------------------------------------------------------------------
[Spare A Life]: https://sunaku.github.io/vegan-for-life.html
> أعجبك عملي؟ 👍 من فضلك [أنقذ حياة] اليوم كنوع من الشكر! 🐄🐖🐑🐔🐣🐟✨🙊✌  
> لماذا؟ من أجل 💕 الأخلاق، 🌎 البيئة، و💪 الصحة؛ راجع الرابط أعلاه. 🙇

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---