# سمة Discord GNOME

سمة GNOME لـ Discord، تتبع أسلوب Adwaita وإرشادات واجهة المستخدم البشرية لـ GNOME (ضمن حدود ما يسمح به CSS الخاص بـ Discord).

## المتطلبات

1. Vesktop

   لتمكين شريط عنوان النوافذ.

2. الإعدادات > اللغة > اختر "English (US)"

   هذا يسمح باستخدام أيقونات مخصصة نظراً للطريقة التي يتم بها تحديد الأيقونات في Discord. يمكنك [توطين](https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/src/global/icons.scss) السمة، ولكن يرجى قراءة ملاحظة التوطين.

3. الإعدادات > الإضافات > تفعيل "ThemeAttributes"

   هذا يسمح بظهور الأيقونات في مربع حوار الإعدادات.

4. الإعدادات > إعدادات Vesktop > تفعيل "Discord Titlebar"

   اختياري، لكنه يُوصى به إذا كان لديك أشرطة عناوين.

### إضافات اختيارية

1. إزالة إشارات Nitro: https://github.com/CroissantDuNord/discord-adblock

## فلسفة التصميم

### إرشادات واجهة المستخدم البشرية

قد لا تلتزم السمة بشكل كامل بإرشادات HIG بسبب قيود CSS أو التصميم في Discord أو بسبب اختياراتي الشخصية.

### الدعم

هذه غير مدعومة:

- تجارب Discord

  أنا لا أعمل لدى Discord، لذلك ليست لدي وسيلة لمعرفة إذا ما كانت هذه التجارب ستتغير أو يُتخلى عنها، إلخ، أي عبء الصيانة — أنا أُدير عدة مشاريع أخرى.

- Nitro

  الاستثناءات — أي شيء يمكن الوصول إليه باستخدام إضافة FakeNitro.

يمكنك فتح تذكرة حول أي من هذه الأمور، لكنها ستُحل فقط إذا كان الحل سهلاً، مثل أيقونة مفقودة.

## التثبيت

### بدون إعدادات

انسخ ما يلي إلى مربع النص الموجود في الإعدادات > السمات > السمات المتصلة بالإنترنت:

```
https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/gnome.theme.css
```

### مع إعدادات

ضع [gnome.theme.css](https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/gnome.theme.css) في ~/.config/vesktop/themes. لا يزال يُحدّث تلقائياً.

## المعاينة

![الأولى](https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/assets/preview/Screenshot%20from%202024-04-27%2011-55-58.png)
![الثانية (الوضع المريح)](https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/assets/preview/Screenshot%20from%202024-04-27%2012-31-42.png)
![الثالثة](https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/assets/preview/Screenshot%20from%202024-04-27%2012-24-16.png)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---