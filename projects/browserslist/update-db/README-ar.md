# تحديث قاعدة بيانات Browserslist

<img width="120" height="120" alt="شعار Browserslist بواسطة Anton Popov"
     src="https://browsersl.ist/logo.svg" align="right">

أداة CLI لتحديث `caniuse-lite` بقاعدة بيانات المتصفحات
من إعدادات [Browserslist](https://github.com/browserslist/browserslist/).

بعض الاستعلامات مثل `last 2 versions` أو `>1%` تعتمد على البيانات الفعلية
من `caniuse-lite`.

```sh
npx update-browserslist-db@latest
```

<a href="https://evilmartians.com/?utm_source=update-browserslist-db">
  <img src="https://evilmartians.com/badges/sponsored-by-evil-martians.svg"
       alt="برعاية Evil Martians" width="236" height="54">
</a>

## لماذا يجب عليك تشغيلها بانتظام

يعمل الأمر `npx update-browserslist-db@latest` على تحديث إصدار `caniuse-lite`
في ملف القفل الخاص بـ npm أو yarn أو pnpm لديك.

هذا التحديث سيجلب بيانات المتصفحات الجديدة إلى أدوات polyfill
مثل Autoprefixer أو Babel ويقلل من polyfills غير الضرورية.

يجب عليك القيام بذلك بانتظام للأسباب الثلاثة التالية:

1. لاستخدام أحدث إصدارات المتصفحات والإحصائيات في الاستعلامات مثل
   `last 2 versions` أو `>1%`. على سبيل المثال، إذا أنشأت مشروعك
   منذ عامين ولم تقم بتحديث التبعيات، فإن `last 1 version`
   ستعيد متصفحات عمرها عامان.
2. ستؤدي بيانات المتصفحات الفعلية إلى استخدام عدد أقل من polyfills، مما يقلل
   من حجم ملفات JS وCSS ويحسن أداء الموقع.
3. إزالة التكرار في `caniuse-lite`: لمزامنة الإصدارات بين الأدوات المختلفة.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---