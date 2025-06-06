# [React](https://react.dev/) &middot; [![GitHub license](https://img.shields.io/badge/license-MIT-blue.svg)](https://github.com/facebook/react/blob/main/LICENSE) [![npm version](https://img.shields.io/npm/v/react.svg?style=flat)](https://www.npmjs.com/package/react) [![(Runtime) Build and Test](https://github.com/facebook/react/actions/workflows/runtime_build_and_test.yml/badge.svg)](https://github.com/facebook/react/actions/workflows/runtime_build_and_test.yml) [![(Compiler) TypeScript](https://github.com/facebook/react/actions/workflows/compiler_typescript.yml/badge.svg?branch=main)](https://github.com/facebook/react/actions/workflows/compiler_typescript.yml) [![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen.svg)](https://legacy.reactjs.org/docs/how-to-contribute.html#your-first-pull-request)

ريأكت هي مكتبة جافاسكريبت لبناء واجهات المستخدم.

* **إعلانية:** تجعل ريأكت من السهل إنشاء واجهات مستخدم تفاعلية. صمّم مشاهد بسيطة لكل حالة في تطبيقك، وستقوم ريأكت بتحديث وعرض المكونات المناسبة بكفاءة عند تغير بياناتك. تجعل العروض الإعلانية كودك أكثر قابلية للتنبؤ وأسهل في الفهم وأسهل في التصحيح.
* **مبنية على المكونات:** قم ببناء مكونات مغلقة تدير حالتها الخاصة، ثم قم بتجميعها لصنع واجهات مستخدم معقدة. نظرًا لأن منطق المكونات يُكتب بجافاسكريبت بدلاً من القوالب، يمكنك بسهولة تمرير بيانات غنية عبر تطبيقك والحفاظ على الحالة خارج الـ DOM.
* **تعلم مرة، اكتب في أي مكان:** لا نفترض شيئًا عن بقية تقنيتك، لذا يمكنك تطوير ميزات جديدة في ريأكت دون إعادة كتابة الكود الموجود. يمكن أيضًا لريأكت العرض على الخادم باستخدام [Node](https://nodejs.org/en) وتشغيل تطبيقات الهواتف باستخدام [React Native](https://reactnative.dev/).

[تعلم كيف تستخدم ريأكت في مشروعك](https://react.dev/learn).

## التثبيت

تم تصميم ريأكت لتكون قابلة للاعتماد التدريجي منذ البداية، و**يمكنك استخدام القليل أو الكثير من ريأكت حسب حاجتك**:

* استخدم [البدء السريع](https://react.dev/learn) لتجربة ريأكت.
* [أضف ريأكت إلى مشروع موجود](https://react.dev/learn/add-react-to-an-existing-project) لاستخدام القليل أو الكثير من ريأكت حسب حاجتك.
* [أنشئ تطبيق ريأكت جديد](https://react.dev/learn/start-a-new-react-project) إذا كنت تبحث عن سلسلة أدوات جافاسكريبت قوية.

## التوثيق

يمكنك العثور على توثيق ريأكت [على الموقع الإلكتروني](https://react.dev/).

اطلع على صفحة [البدء السريع](https://react.dev/learn) للحصول على نظرة سريعة.

ينقسم التوثيق إلى عدة أقسام:

* [البدء السريع](https://react.dev/learn)
* [الدليل التعليمي](https://react.dev/learn/tutorial-tic-tac-toe)
* [التفكير بأسلوب ريأكت](https://react.dev/learn/thinking-in-react)
* [التثبيت](https://react.dev/learn/installation)
* [وصف واجهة المستخدم](https://react.dev/learn/describing-the-ui)
* [إضافة التفاعلية](https://react.dev/learn/adding-interactivity)
* [إدارة الحالة](https://react.dev/learn/managing-state)
* [أدلة متقدمة](https://react.dev/learn/escape-hatches)
* [مرجع API](https://react.dev/reference/react)
* [أين تحصل على الدعم](https://react.dev/community)
* [دليل المساهمة](https://legacy.reactjs.org/docs/how-to-contribute.html)

يمكنك تحسينه بإرسال طلبات سحب إلى [هذا المستودع](https://github.com/reactjs/react.dev).

## أمثلة

لدينا عدة أمثلة [على الموقع الإلكتروني](https://react.dev/). إليك أول مثال لتبدأ به:

```jsx
import { createRoot } from 'react-dom/client';

function HelloMessage({ name }) {
  return <div>Hello {name}</div>;
}

const root = createRoot(document.getElementById('container'));
root.render(<HelloMessage name="Taylor" />);
```

سيقوم هذا المثال بعرض "Hello Taylor" في حاوية على الصفحة.

ستلاحظ أننا استخدمنا صيغة تشبه HTML؛ [نسميها JSX](https://react.dev/learn#writing-markup-with-jsx). لا يُشترط استخدام JSX مع ريأكت، لكنها تجعل الكود أكثر قابلية للقراءة، وكتابتها تشبه كتابة HTML.

## المساهمة

الغرض الرئيسي من هذا المستودع هو الاستمرار في تطوير نواة ريأكت، وجعلها أسرع وأسهل في الاستخدام. يتم تطوير ريأكت بشكل مفتوح على GitHub، ونحن ممتنون للمجتمع على مساهماتهم في إصلاح الأخطاء والتحسينات. اقرأ أدناه لتتعلم كيف يمكنك أن تساهم في تحسين ريأكت.

### [مدونة السلوك](https://code.fb.com/codeofconduct)

اعتمدت فيسبوك مدونة سلوك نتوقع من المشاركين في المشروع الالتزام بها. يرجى قراءة [النص الكامل](https://code.fb.com/codeofconduct) لتتعرف على الأفعال المسموح بها وغير المسموح بها.

### [دليل المساهمة](https://legacy.reactjs.org/docs/how-to-contribute.html)

اقرأ [دليل المساهمة](https://legacy.reactjs.org/docs/how-to-contribute.html) لتتعرف على عملية التطوير لدينا، وكيفية اقتراح إصلاحات وتحسينات، وكيفية بناء واختبار تغييراتك على ريأكت.

### [مشاكل جيدة للبداية](https://github.com/facebook/react/labels/good%20first%20issue)

لمساعدتك على البدء والتعرف على عملية المساهمة لدينا، لدينا قائمة من [مشاكل جيدة للبداية](https://github.com/facebook/react/labels/good%20first%20issue) تحتوي على أخطاء ذات نطاق محدود نسبيًا. هذا مكان رائع للبدء.

### الترخيص

ريأكت مرخصة بموجب [رخصة MIT](./LICENSE).


---

[Powered By DeepAiTx](https://github.com/DeepAiTx)

---