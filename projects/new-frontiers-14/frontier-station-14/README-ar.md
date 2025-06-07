<div class="header" align="center">
<img alt="Frontier Station" height="300" src="https://github.com/new-frontiers-14/frontier-station-14/blob/master/Resources/Textures/_NF/Logo/logo.png?raw=true" />
</div>

Frontier Station هو تفرع من [Space Station 14](https://github.com/space-wizards/space-station-14) يعمل على محرك [Robust Toolbox](https://github.com/space-wizards/RobustToolbox) المكتوب بلغة C#.

هذا هو المستودع الأساسي لـ Frontier Station.

إذا كنت ترغب في استضافة أو إنشاء محتوى لـ Frontier Station، فهذا هو المستودع الذي تحتاجه. يحتوي على كل من RobustToolbox وحزمة المحتوى لتطوير حزم محتوى جديدة.

## الروابط

<div class="header" align="center">  
[Discord](https://discord.gg/tpuAT7d3zm/) | [Steam](https://store.steampowered.com/app/1255460/Space_Station_14/) | [Patreon](https://www.patreon.com/frontierstation14) | [Wiki](https://frontierstation.wiki.gg/)
</div>

## التوثيق/الويكي

يحتوي [الويكي الخاص بنا](https://frontierstation.wiki.gg/) على توثيق لمحتوى Frontier Station.

## المساهمة

نحن سعداء بقبول المساهمات من أي شخص. انضم إلى Discord إذا كنت ترغب في المساعدة. لدينا [قائمة بالأفكار](https://discord.com/channels/1123826877245694004/1127017858833068114) التي يمكن تنفيذها ويمكن لأي شخص اختيارها. لا تتردد في طلب المساعدة أيضًا!

نحن لا نقبل حاليًا ترجمات للعبة في مستودعنا الرئيسي. إذا كنت ترغب في ترجمة اللعبة إلى لغة أخرى، فكر في إنشاء تفرع أو المساهمة في تفرع.

إذا قمت بأي مساهمات، يرجى التأكد من قراءة قسم العلامات في [MARKERS.md](https://github.com/new-frontiers-14/frontier-station-14/blob/master/MARKERS.md)
يجب تعليم أي تغييرات تطرأ على الملفات التابعة لمصدرنا الأصلي بشكل صحيح وفقًا لما هو محدد هناك.

## البناء

1. استنسخ هذا المستودع:
```shell
git clone https://github.com/new-frontiers-14/frontier-station-14.git
```
2. انتقل إلى مجلد المشروع وشغل `RUN_THIS.py` لتهيئة الوحدات الفرعية وتحميل المحرك:
```shell
cd frontier-station-14
python RUN_THIS.py
```
3. قم بترجمة الحل:  

ابنِ الخادم باستخدام `dotnet build`.

[تعليمات أكثر تفصيلًا حول بناء المشروع.](https://docs.spacestation14.com/en/general-development/setup.html)

## الرخصة

المحتوى المساهم به في هذا المستودع بعد الالتزام 2fca06eaba205ae6fe3aceb8ae2a0594f0effee0 مرخص بموجب رخصة جنو العمومية العامة للبرمجيات الحرة (AGPL) الإصدار 3.0، ما لم يُذكر خلاف ذلك (انظر قسم النسب أدناه). انظر `LICENSE-AGPLv3.txt`.
المحتوى المساهم به في هذا المستودع قبل الالتزام 2fca06eaba205ae6fe3aceb8ae2a0594f0effee0 مرخص برخصة MIT، ما لم يُذكر خلاف ذلك. انظر `LICENSE-MIT.txt`.

[2fca06eaba205ae6fe3aceb8ae2a0594f0effee0](https://github.com/new-frontiers-14/frontier-station-14/commit/2fca06eaba205ae6fe3aceb8ae2a0594f0effee0) تم دفعه في 1 يوليو 2024 الساعة 16:04 بالتوقيت العالمي.

معظم الأصول مرخصة بموجب [CC-BY-SA 3.0](https://creativecommons.org/licenses/by-sa/3.0/) ما لم يُذكر خلاف ذلك. تم تحديد رخصة وحقوق الأصول في ملف البيانات الوصفية. على سبيل المثال، انظر [البيانات الوصفية للعتلة](https://github.com/new-frontiers-14/frontier-station-14/blob/master/Resources/Textures/Objects/Tools/crowbar.rsi/meta.json).  

يرجى ملاحظة أن بعض الأصول مرخصة بموجب [CC-BY-NC-SA 3.0](https://creativecommons.org/licenses/by-nc-sa/3.0/) غير التجاري أو تراخيص غير تجارية مماثلة ويجب إزالتها إذا كنت ترغب في استخدام هذا المشروع تجاريًا.

## النسب

عندما نقوم بجلب محتوى من تفرعات أخرى، نقوم بتنظيم محتواها في مجلدات فرعية خاصة بالمستودع لتتبع النسب بشكل أفضل وتقليل تعارضات الدمج.

المحتوى الموجود تحت هذه المجلدات الفرعية مصدره من التفرعات الخاصة به وقد يحتوي على تعديلات. يتم تمييز هذه التعديلات بتعليقات حول الأسطر المعدلة.

| المجلد الفرعي | اسم التفرع | مستودع التفرع | الرخصة |
|--------------|-----------|-----------------|---------|
| `_NF` | Frontier Station | https://github.com/new-frontiers-14/frontier-station-14 | AGPL 3.0 |
| `_CD` | Cosmatic Drift | https://github.com/cosmatic-drift-14/cosmatic-drift | MIT |
| `_Corvax` | Corvax | https://github.com/space-syndicate/space-station-14 | MIT |
| `_Corvax` | Corvax Frontier | https://github.com/Corvax-Frontier/Frontier | AGPL 3.0 |
| `_DV` | Delta-V | https://github.com/DeltaV-Station/Delta-v | AGPL 3.0 |
| `_EE` | Einstein Engines | https://github.com/Simple-Station/Einstein-Engines | AGPL 3.0 |
| `_Emberfall` | Emberfall | https://github.com/emberfall-14/emberfall | MPL 2.0 |
| `_EstacaoPirata` | Estacao Pirata | https://github.com/Day-OS/estacao-pirata-14 | AGPL 3.0 |
| `_Goobstation` | Goob Station | https://github.com/Goob-Station/Goob-Station | AGPL 3.0 |
| `_Impstation` | Impstation | https://github.com/impstation/imp-station-14 | AGPL 3.0 |
| `_NC14` | Nuclear 14 | https://github.com/Vault-Overseers/nuclear-14 | AGPL 3.0 |
| `Nyanotrasen` | Nyanotrasen | https://github.com/Nyanotrasen/Nyanotrasen | MIT |

المستودعات الإضافية التي قمنا بنقل ميزات منها بدون مجلدات فرعية مذكورة أدناه.

| اسم التفرع | مستودع التفرع | الرخصة |
|-----------|-----------------|---------|
| Monolith | https://github.com/Monolith-Station/Monolith | AGPL 3.0 |
| Space Station 14 | https://github.com/space-wizards/space-station-14 | MIT |
| White Dream | https://github.com/WWhiteDreamProject/wwdpublic | AGPL 3.0 |

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---