[![شعار Nuxt](https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/banner.svg)](https://nuxt.com)

# Nuxt

<p>
  <a href="https://www.npmjs.com/package/nuxt"><img src="https://img.shields.io/npm/v/nuxt.svg?style=flat&colorA=18181B&colorB=28CF8D" alt="الإصدار"></a>
  <a href="https://www.npmjs.com/package/nuxt"><img src="https://img.shields.io/npm/dm/nuxt.svg?style=flat&colorA=18181B&colorB=28CF8D" alt="التنزيلات"></a>
  <a href="https://github.com/nuxt/nuxt/tree/main/LICENSE"><img src="https://img.shields.io/github/license/nuxt/nuxt.svg?style=flat&colorA=18181B&colorB=28CF8D" alt="الرخصة"></a>
  <a href="https://nuxt.com"><img src="https://img.shields.io/badge/Nuxt%20Docs-18181B?logo=nuxt" alt="الموقع"></a>
  <a href="https://chat.nuxt.dev"><img src="https://img.shields.io/badge/Nuxt%20Discord-18181B?logo=discord" alt="ديسكورد"></a>
  <a href="https://securityscorecards.dev/"><img src="https://api.securityscorecards.dev/projects/github.com/nuxt/nuxt/badge" alt="درجة Nuxt openssf scorecard"></a>
</p>

Nuxt هو إطار عمل مجاني ومفتوح المصدر يوفر طريقة بديهية وقابلة للتوسعة لإنشاء تطبيقات ومواقع ويب متكاملة وآمنة من حيث النوع وعالية الأداء وجاهزة للإنتاج باستخدام Vue.js.

يوفر العديد من الميزات التي تجعل من السهل بناء تطبيقات ويب سريعة وصديقة لمحركات البحث وقابلة للتوسع، بما في ذلك:
- التصيير من جانب الخادم، وإنشاء مواقع ثابتة، والتصيير الهجين، والتصيير على الحافة
- التوجيه التلقائي مع تقسيم الشيفرة وجلب مسبق
- جلب البيانات وإدارة الحالة
- تحسين محركات البحث وتعريف العلامات الوصفية
- الاستيراد التلقائي للمكونات، composables والأدوات
- TypeScript بدون إعداد مسبق
- بناء متكامل مع دليل server/
- قابل للتوسعة مع [أكثر من 200 وحدة](https://nuxt.com/modules)
- النشر على مجموعة متنوعة من [منصات الاستضافة](https://nuxt.com/deploy)
- ...[والمزيد](https://nuxt.com) 🚀

### جدول المحتويات

- 🚀 [البدء](#getting-started)
- 💻 [تطوير Vue](#vue-development)
- 📖 [التوثيق](#documentation)
- 🧩 [الوحدات](#modules)
- ❤️  [المساهمة](#contribute)
- 🏠 [التطوير المحلي](#local-development)
- 🛟 [الدعم الاحترافي](#professional-support)
- 🔗 [تابعنا](#follow-us)
- ⚖️ [الرخصة](#license)

---

## <a name="getting-started">🚀 البدء</a>

استخدم الأمر التالي لإنشاء مشروع جديد. سيقوم هذا بإنشاء مشروع بداية مع جميع الملفات والاعتمادات اللازمة:

```bash
npm create nuxt <my-project>
```

> [!TIP]
> اكتشف أيضًا [nuxt.new](https://nuxt.new): افتح مشروع Nuxt على CodeSandbox أو StackBlitz أو محليًا لتبدأ في غضون ثوانٍ.

## <a name="vue-development">💻 تطوير Vue</a>

بسيط، بديهي وقوي، يتيح لك Nuxt كتابة مكونات Vue بطريقة منطقية. كل المهام المتكررة مؤتمتة، حتى تتمكن من التركيز على كتابة تطبيق Vue متكامل بثقة.

مثال على `app.vue`:

```vue
<script setup lang="ts">
useSeoMeta({
  title: 'Meet Nuxt',
  description: 'The Intuitive Vue Framework.'
})
</script>

<template>
  <div id="app">
    <AppHeader />
    <NuxtPage />
    <AppFooter />
  </div>
</template>

<style scoped>
#app {
  background-color: #020420;
  color: #00DC82;
}
</style>
```

## <a name="documentation">📖 التوثيق</a>

نوصيك بشدة بإلقاء نظرة على [توثيق Nuxt](https://nuxt.com/docs) لتطوير مهاراتك. إنه مصدر رائع لتعلم المزيد عن الإطار. يغطي كل شيء من البداية حتى المواضيع المتقدمة.

## <a name="modules">🧩 الوحدات</a>

اكتشف [قائمة الوحدات](https://nuxt.com/modules) لتعزيز مشروعك بـ Nuxt، تم إنشاؤها من قبل فريق Nuxt والمجتمع.

## <a name="contribute">❤️ المساهمة</a>

ندعوك للمساهمة والمساعدة في تحسين Nuxt 💚

إليك بعض الطرق التي يمكنك من خلالها المشاركة:
- **الإبلاغ عن الأخطاء:** إذا صادفت أي أخطاء أو مشاكل، يرجى مراجعة [دليل الإبلاغ عن الأخطاء](https://nuxt.com/docs/community/reporting-bugs) لمعرفة كيفية إرسال تقرير خطأ.
- **الاقتراحات:** لديك أفكار لتحسين Nuxt؟ يسعدنا سماعها! راجع [دليل المساهمة](https://nuxt.com/docs/community/contribution) لمشاركة اقتراحاتك.
- **الأسئلة:** إذا كان لديك أسئلة أو تحتاج إلى مساعدة، يوفر [دليل الحصول على المساعدة](https://nuxt.com/docs/community/getting-help) مصادر لمساعدتك.

## <a name="local-development">🏠 التطوير المحلي</a>

اتبع الوثائق [لإعداد بيئة تطوير محلية](https://nuxt.com/docs/community/framework-contribution#setup) للمساهمة في تطوير الإطار والتوثيق.

## <a name="professional-support">🛟 الدعم الاحترافي</a>

- تدقيق واستشارات تقنية: [خبراء Nuxt](https://nuxt.com/enterprise/support)
- تطوير مخصص وأكثر: [شركاء وكالات Nuxt](https://nuxt.com/enterprise/agencies)

## <a name="follow-us">🔗 تابعنا</a>

<p valign="center">
  <a href="https://go.nuxt.com/discord"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/discord.svg" alt="ديسكورد"></a>&nbsp;&nbsp;<a href="https://go.nuxt.com/x"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/twitter.svg" alt="تويتر"></a>&nbsp;&nbsp;<a href="https://go.nuxt.com/github"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/github.svg" alt="جيت هب"></a>&nbsp;&nbsp;<a href="https://go.nuxt.com/bluesky"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/bluesky.svg" alt="بلوسكاي"></a>
</p>

## <a name="license">⚖️ الرخصة</a>

[MIT](https://github.com/nuxt/nuxt/tree/main/LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---