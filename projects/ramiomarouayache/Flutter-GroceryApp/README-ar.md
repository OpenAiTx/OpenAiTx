# تطبيق GroceryApp للمبتدئين

قالب تطبيق تسوق بقالة مبسط لتجربة تسوق سهلة ومباشرة. 🛒✨

لا تتردد في وضع نجمة ⭐ على المستودع إذا وجدته مفيدًا.

## التصميم

**انقر على الصورة أدناه لعرض تصميم Figma:**

[![معاينة التصميم](https://raw.githubusercontent.com/ramiomarouayache/Flutter-GroceryApp/main/screenshots/Cover.jpg)](https://www.figma.com/embed?embed_host=oembed&amp;url=https://www.figma.com/file/eyeYwe0hoEch31j6d3EXyE/GroceryApp-Starter-(Community)?type=design&amp;node-id=3-2&amp;mode=design&amp;t=LwLW2onM0GKLuFdU-0)

## ✨المتطلبات

1. **بيئة التطوير:**
   - أي بيئة تطوير متكاملة مع تثبيت Flutter SDK (مثل VSCode، Android Studio، IntelliJ...إلخ)

2. **قاعدة المعرفة:**
   - معرفة أساسية إلى متوسطة بلغة Dart وFlutter
   - فهم بنية MVVM
   - الإلمام بكيفية التعامل مع واجهات برمجة التطبيقات (API)
   - أساسيات إدارة الحالة باستخدام GetX

## التجربة
* يمكنك تنزيل النسخة ما قبل الإصدار لأجهزة أندرويد من هنا [releases](https://github.com/ramiomarouayache/Flutter-GroceryApp/releases/tag/v0.3.1).
<video src="https://github.com/ramiomarouayache/Flutter-GroceryApp/assets/98425058/5ae355c9-39e0-478e-9b3e-870953b566ca"></video>

## الإعداد
* ابدأ بتكوين نقطة النهاية للمنتج، وبيانات الاعتماد، والمعلمات في `lib\constants\AppConstants`.
* **بدلاً من ذلك**، استخدم نقطة النهاية المجانية المتوفرة أدناه (حتى تاريخ المشاركة) من أجل اختبار ناجح.
```dart
class AppConstants {
  // استبدل "YOUR_API_PREFIX" بعنوان قاعدة بيانات API الخاص بك.
  static const String BASE_URL = "YOUR_API_PREFIX";
  static const String API_KEY = "YOUR_API_KEY"; //إن وجد

  // للاختبار، استخدم عنوان قاعدة بيانات API المجانية من النسخة المفرج عنها
  static const String BASE_URL = "https://world.openfoodfacts.org/api/v2";

  // اسم مالك المشروع بالكامل.
  static const String projectOwnerName = "FULL_NAME";
}
```

## ملاحظة
* لاستخدام نقاط النهاية الخاصة بك، قم بتخصيص الطبقات المنطقية باتباع إرشادات بنية MVVM استنادًا إلى توثيق API الخاص بك.
* تم حذف بعض الصور في النسخة ما قبل الإصدار بسبب قيود حقوق النشر.

## المساهمة

يرجى عمل fork لهذا المستودع والمساهمة من خلال
[طلبات السحب](https://github.com/ramiomarouayache/Flutter-GroceryApp/pulls).

أي مساهمات، سواء كانت صغيرة أو كبيرة، ميزات رئيسية، إصلاحات للأخطاء، كلها مرحب بها ومقدرة
ولكن سيتم مراجعتها بدقة.

## البدء
هذا المشروع هو نقطة انطلاق لتطبيق Flutter.

بعض الموارد لمساعدتك على البدء إذا كان هذا أول مشروع Flutter لك:

- [المعمل: أنشئ أول تطبيق Flutter لك](https://flutter.io/docs/get-started/codelab)
- [كتاب الطهي: أمثلة مفيدة لـ Flutter](https://flutter.io/docs/cookbook)

## عداد الزوار

<img align="left" src = "https://profile-counter.glitch.me/GroceryApp/count.svg" alt ="جارٍ التحميل">

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---