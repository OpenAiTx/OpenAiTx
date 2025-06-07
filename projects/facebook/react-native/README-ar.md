<h1 align="center">
  <a href="https://reactnative.dev/">
    React Native
  </a>
</h1>

<p align="center">
  <strong>تعلم مرة، واكتب في أي مكان:</strong><br>
  أنشئ تطبيقات الهواتف المحمولة باستخدام React.
</p>

<p align="center">
  <a href="https://github.com/facebook/react-native/blob/HEAD/LICENSE">
    <img src="https://img.shields.io/badge/license-MIT-blue.svg" alt="React Native is released under the MIT license." />
  </a>
  <a href="https://www.npmjs.org/package/react-native">
    <img src="https://img.shields.io/npm/v/react-native?color=brightgreen&label=npm%20package" alt="Current npm package version." />
  </a>
  <a href="https://reactnative.dev/docs/contributing">
    <img src="https://img.shields.io/badge/PRs-welcome-brightgreen.svg" alt="PRs welcome!" />
  </a>
  <a href="https://twitter.com/intent/follow?screen_name=reactnative">
    <img src="https://img.shields.io/twitter/follow/reactnative.svg?label=Follow%20@reactnative" alt="Follow @reactnative" />
  </a>
</p>

<h3 align="center">
  <a href="https://reactnative.dev/docs/getting-started">البدء السريع</a>
  <span> · </span>
  <a href="https://reactnative.dev/docs/tutorial">تعلم الأساسيات</a>
  <span> · </span>
  <a href="https://reactnative.dev/showcase">أمثلة المشاريع</a>
  <span> · </span>
  <a href="https://reactnative.dev/docs/contributing">ساهم</a>
  <span> · </span>
  <a href="https://reactnative.dev/help">المجتمع</a>
  <span> · </span>
  <a href="https://github.com/facebook/react-native/blob/HEAD/.github/SUPPORT.md">الدعم</a>
</h3>

يجلب React Native إطار واجهة المستخدم التصريحي الخاص بـ[**React**][r] إلى iOS وAndroid. مع React Native، يمكنك استخدام عناصر واجهة المستخدم الأصلية والوصول الكامل إلى منصة النظام الأصلي.

- **تصريحي.** يجعل React إنشاء واجهات المستخدم التفاعلية أمرًا سهلاً. العروض التصريحية تجعل الكود الخاص بك أكثر قابلية للتنبؤ وأسهل في التصحيح.
- **قائم على المكونات.** أنشئ مكونات مغلفة تدير حالتها، ثم قم بتركيبها لبناء واجهات مستخدم معقدة.
- **سرعة تطوير عالية.** شاهد التغييرات المحلية في ثوانٍ. يمكن إعادة تحميل تغييرات كود JavaScript مباشرة دون الحاجة لإعادة بناء التطبيق الأصلي.
- **قابلية النقل.** أعد استخدام الكود عبر iOS وAndroid و[منصات أخرى][p].

يتم تطوير React Native ودعمه من قبل العديد من الشركات والمساهمين الأساسيين الأفراد. تعرف على المزيد في [نظرة عامة على النظام البيئي][e].

[r]: https://react.dev/
[p]: https://reactnative.dev/docs/out-of-tree-platforms
[e]: https://github.com/facebook/react-native/blob/HEAD/ECOSYSTEM.md

## المحتويات

- [المتطلبات](#-requirements)
- [بناء أول تطبيق React Native لك](#-building-your-first-react-native-app)
- [التوثيق](#-documentation)
- [الترقية](#-upgrading)
- [كيفية المساهمة](#-how-to-contribute)
- [مدونة السلوك](#code-of-conduct)
- [الرخصة](#-license)


## 📋 المتطلبات

يمكن لتطبيقات React Native استهداف iOS 15.1 وAndroid 7.0 (API 24) أو أحدث. يمكنك استخدام Windows أو macOS أو Linux كنظام تشغيل للتطوير، مع العلم أن بناء وتشغيل تطبيقات iOS يقتصر على macOS. يمكن استخدام أدوات مثل [Expo](https://expo.dev) لتجاوز هذا القيد.

## 🎉 بناء أول تطبيق React Native لك

اتبع [دليل البدء السريع](https://reactnative.dev/docs/getting-started). تعتمد الطريقة الموصى بها لتثبيت React Native على مشروعك. هنا يمكنك العثور على أدلة قصيرة لأكثر السيناريوهات شيوعًا:

- [تجربة React Native][hello-world]
- [إنشاء تطبيق جديد][new-app]
- [إضافة React Native إلى تطبيق قائم][existing]

[hello-world]: https://snack.expo.dev/@samples/hello-world
[new-app]: https://reactnative.dev/docs/getting-started
[existing]: https://reactnative.dev/docs/integration-with-existing-apps

## 📖 التوثيق

يمكنك العثور على التوثيق الكامل لـReact Native على [موقعنا الإلكتروني][docs].

يناقش توثيق React Native المكونات وواجهات برمجة التطبيقات والمواضيع الخاصة بـReact Native. لمزيد من التوثيق حول واجهة React المشتركة بين React Native وReact DOM، راجع [توثيق React][r-docs].

يتم استضافة مصدر توثيق React Native والموقع الإلكتروني في مستودع منفصل، [**@facebook/react-native-website**][repo-website].

[docs]: https://reactnative.dev/docs/getting-started
[r-docs]: https://react.dev/learn
[repo-website]: https://github.com/facebook/react-native-website

## 🚀 الترقية

قد يمنحك الترقية إلى إصدارات جديدة من React Native إمكانية الوصول إلى المزيد من واجهات برمجة التطبيقات، والعروض، وأدوات المطورين، والمزايا الأخرى. راجع [دليل الترقية][u] للإرشادات.

يتم مناقشة إصدارات React Native [في هذا المستودع للنقاش](https://github.com/reactwg/react-native-releases/discussions).

[u]: https://reactnative.dev/docs/upgrading
[repo-releases]: https://github.com/react-native-community/react-native-releases

## 👏 كيفية المساهمة

الهدف الرئيسي من هذا المستودع هو الاستمرار في تطوير نواة React Native. نرغب في جعل المساهمة في هذا المشروع سهلة وشفافة قدر الإمكان، ونحن ممتنون للمجتمع على مساهماتهم في إصلاح الأخطاء والتحسينات. اقرأ أدناه لتتعرف على كيفية المشاركة في تحسين React Native.

### [مدونة السلوك][code]

اعتمدت Facebook مدونة سلوك نتوقع من المشاركين في المشروع الالتزام بها.
يرجى قراءة [النص الكامل][code] لفهم ما هي التصرفات المقبولة وغير المقبولة.

[code]: https://code.fb.com/codeofconduct/

### [دليل المساهمة][contribute]

اقرأ [**دليل المساهمة**][contribute] للتعرف على عملية التطوير لدينا، وكيفية اقتراح إصلاحات للأخطاء والتحسينات، وكيفية بناء واختبار تغييراتك على React Native.

[contribute]: https://reactnative.dev/docs/contributing

### [خارطة الطريق لمصدر مفتوح][roadmap]

يمكنك معرفة المزيد عن رؤيتنا لـReact Native في [**خارطة الطريق**][roadmap].

[roadmap]: https://github.com/facebook/react-native/wiki/Roadmap

### مشكلات جيدة للبداية

لدينا قائمة بـ[مشكلات جيدة للبداية][gfi] تتضمن أخطاء ذات نطاق محدود نسبيًا. هذا مكان رائع للبدء واكتساب الخبرة والتعرف على عملية المساهمة لدينا.

[gfi]: https://github.com/facebook/react-native/labels/good%20first%20issue

### المناقشات

يتم مناقشة المناقشات والمقترحات الأكبر في [**@react-native-community/discussions-and-proposals**][repo-meta].

[repo-meta]: https://github.com/react-native-community/discussions-and-proposals

## 📄 الرخصة

React Native مرخص بموجب رخصة MIT، كما هو موضح في ملف [LICENSE][l].

[l]: https://github.com/facebook/react-native/blob/main/LICENSE

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---