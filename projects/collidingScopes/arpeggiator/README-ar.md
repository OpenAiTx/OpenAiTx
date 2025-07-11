# مبدل الإيقاعات بالإيماءات اليدوية

مُبدل الإيقاعات، آلة الطبول، ومرئي صوتي تفاعلي يتم التحكم فيه باليد. ارفع يديك لرفع السقف!

تطبيق ويب تفاعلي مبني باستخدام threejs، ورؤية الحاسوب mediapipe، وrosebud AI، وtone.js.

- اليد #1 تتحكم في الإيقاعات (ارفع اليد لرفع النغمة، استخدم القرص لتغيير مستوى الصوت)
- اليد #2 تتحكم في الطبول (ارفع أصابع مختلفة لتغيير النمط)

[فيديو](https://youtu.be/JepIs-DTBgk?si=4Y-FrQDF6KNy662C) | [عرض حي](https://collidingscopes.github.io/arpeggiator/) | [المزيد من الشيفرات والدروس](https://funwithcomputervision.com/)

<img src="https://raw.githubusercontent.com/collidingScopes/arpeggiator/main/assets/demo.png">

## المتطلبات

- متصفح ويب حديث يدعم WebGL
- تفعيل الوصول إلى الكاميرا لتتبع اليد

## التقنيات

- **MediaPipe** لتتبع اليد والتعرف على الإيماءات
- **Three.js** لعرض المؤثرات البصرية التفاعلية مع الصوت
- **Tone.js** لأصوات المولد الموسيقي
- **HTML5 Canvas** لتغذية بصرية راجعة
- **JavaScript** للتفاعل اللحظي
## الإعداد للتطوير

```bash
# استنساخ هذا المستودع
git clone https://github.com/collidingScopes/arpeggiator

# الانتقال إلى دليل المشروع
cd arpeggiator

# تقديم الخدمة بالطريقة التي تفضلها (مثال باستخدام بايثون)
python -m http.server
```

ثم انتقل إلى `http://localhost:8000` في متصفحك.

## الرخصة

رخصة MIT

## الشكر والتقدير
- Three.js - https://threejs.org/
- MediaPipe - https://mediapipe.dev/
- Rosebud AI - https://rosebud.ai/
- Tone.js - https://tonejs.github.io/

## مشاريع ذات صلة

لقد أصدرت عدة مشاريع رؤية حاسوبية (مع الشيفرة + دروس تعليمية) هنا:
[المرح مع الرؤية الحاسوبية](https://www.funwithcomputervision.com/)

يمكنك شراء وصول مدى الحياة والحصول على جميع ملفات المشاريع والدروس الكاملة. أقوم بإضافة المزيد من المحتوى بانتظام 🪬

قد تعجبك أيضًا بعض مشاريعي مفتوحة المصدر الأخرى:

- [ملعب النماذج ثلاثية الأبعاد](https://collidingScopes.github.io/3d-model-playground) - التحكم بالنماذج ثلاثية الأبعاد باستخدام الصوت وإيماءات اليد
- [دليل تتبع اليد مع Threejs](https://collidingScopes.github.io/threejs-handtracking-101) - إعداد تتبع يد أساسي باستخدام threejs وMediaPipe للرؤية الحاسوبية
- [الانجراف الجزيئي](https://collidingScopes.github.io/particular-drift) - تحويل الصور إلى رسوم متحركة جسيمية متدفقة
- [الفيديو إلى ASCII](https://collidingScopes.github.io/ascii) - تحويل مقاطع الفيديو إلى فن بيكسل ASCII
## التواصل

- إنستغرام: [@stereo.drift](https://www.instagram.com/stereo.drift/)
- تويتر/X: [@measure_plan](https://x.com/measure_plan)
- البريد الإلكتروني: [stereodriftvisuals@gmail.com](https://raw.githubusercontent.com/collidingScopes/arpeggiator/main/mailto:stereodriftvisuals@gmail.com)
- جيت هب: [collidingScopes](https://github.com/collidingScopes)

## التبرعات

إذا وجدت هذه الأداة مفيدة، لا تتردد في أن تشتري لي كوب قهوة.

اسمي آلان، وأستمتع ببناء البرمجيات مفتوحة المصدر لرؤية الحاسوب، الألعاب، وأكثر من ذلك. سأكون ممتناً جداً لدعمك خلال جلسات البرمجة المتأخرة!

[![اشترِ لي كوب قهوة](https://www.buymeacoffee.com/assets/img/custom_images/yellow_img.png)](https://www.buymeacoffee.com/stereoDrift)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-11

---