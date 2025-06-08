# [ری‌اکت (React)](https://react.dev/) &middot; [![مجوز گیت‌هاب](https://img.shields.io/badge/license-MIT-blue.svg)](https://github.com/facebook/react/blob/main/LICENSE) [![نسخه npm](https://img.shields.io/npm/v/react.svg?style=flat)](https://www.npmjs.com/package/react) [![(Runtime) Build and Test](https://github.com/facebook/react/actions/workflows/runtime_build_and_test.yml/badge.svg)](https://github.com/facebook/react/actions/workflows/runtime_build_and_test.yml) [![(Compiler) TypeScript](https://github.com/facebook/react/actions/workflows/compiler_typescript.yml/badge.svg?branch=main)](https://github.com/facebook/react/actions/workflows/compiler_typescript.yml) [![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen.svg)](https://legacy.reactjs.org/docs/how-to-contribute.html#your-first-pull-request)

ری‌اکت یک کتابخانه جاوااسکریپت برای ساخت رابط‌های کاربری است.

* **اعلانی (Declarative):** ری‌اکت ساخت رابط‌های کاربری تعاملی را بدون دردسر می‌کند. نماهای ساده‌ای برای هر وضعیت در برنامه خود طراحی کنید و ری‌اکت به طور مؤثر فقط اجزای صحیح را هنگام تغییر داده به‌روزرسانی و رندر می‌کند. نماهای اعلانی کد شما را قابل پیش‌بینی‌تر، ساده‌تر برای فهم و راحت‌تر برای رفع اشکال می‌نماید.
* **مبتنی بر کامپوننت:** کامپوننت‌های کپسوله‌شده‌ای بسازید که وضعیت خود را مدیریت می‌کنند، سپس آن‌ها را برای ساخت رابط‌های کاربری پیچیده ترکیب نمایید. از آنجا که منطق کامپوننت به جای قالب‌ها در جاوااسکریپت نوشته می‌شود، می‌توانید به راحتی داده‌های غنی را در سراسر برنامه خود عبور دهید و وضعیت را خارج از DOM نگه دارید.
* **یک بار بیاموزید، همه جا بنویسید:** ما در مورد بقیه پشته فناوری شما فرضی نمی‌گیریم، بنابراین می‌توانید ویژگی‌های جدید را در ری‌اکت توسعه دهید بدون اینکه نیاز به بازنویسی کدهای موجود داشته باشید. ری‌اکت همچنین می‌تواند با استفاده از [Node](https://nodejs.org/en) روی سرور رندر شود و برنامه‌های موبایل را با استفاده از [React Native](https://reactnative.dev/) پشتیبانی کند.

[یاد بگیرید چگونه ری‌اکت را در پروژه خود استفاده کنید](https://react.dev/learn).

## نصب

ری‌اکت از ابتدا برای پذیرش تدریجی طراحی شده است و **می‌توانید به اندازه نیاز خود از ری‌اکت استفاده کنید**:

* از [شروع سریع](https://react.dev/learn) برای تجربه اولیه ری‌اکت بهره بگیرید.
* [افزودن ری‌اکت به پروژه موجود](https://react.dev/learn/add-react-to-an-existing-project) تا به اندازه نیاز خود از ری‌اکت استفاده کنید.
* [ایجاد یک برنامه جدید ری‌اکت](https://react.dev/learn/start-a-new-react-project) اگر به دنبال یک ابزار قدرتمند جاوااسکریپت هستید.

## مستندات

شما می‌توانید مستندات ری‌اکت را [در وبسایت](https://react.dev/) بیابید.

صفحه [شروع سریع](https://react.dev/learn) را برای یک مرور سریع بررسی کنید.

مستندات به چند بخش تقسیم شده‌اند:

* [شروع سریع](https://react.dev/learn)
* [آموزش](https://react.dev/learn/tutorial-tic-tac-toe)
* [تفکر در ری‌اکت](https://react.dev/learn/thinking-in-react)
* [نصب](https://react.dev/learn/installation)
* [توصیف رابط کاربری](https://react.dev/learn/describing-the-ui)
* [افزودن تعامل](https://react.dev/learn/adding-interactivity)
* [مدیریت وضعیت](https://react.dev/learn/managing-state)
* [راهنماهای پیشرفته](https://react.dev/learn/escape-hatches)
* [مرجع API](https://react.dev/reference/react)
* [کجا پشتیبانی بگیرید](https://react.dev/community)
* [راهنمای مشارکت](https://legacy.reactjs.org/docs/how-to-contribute.html)

شما می‌توانید با ارسال پول ریکوئست به [این مخزن](https://github.com/reactjs/react.dev) آن را بهبود دهید.

## مثال‌ها

ما چندین مثال [در وبسایت](https://react.dev/) داریم. در اینجا اولین مثال برای شروع آورده شده است:

```jsx
import { createRoot } from 'react-dom/client';

function HelloMessage({ name }) {
  return <div>Hello {name}</div>;
}

const root = createRoot(document.getElementById('container'));
root.render(<HelloMessage name="Taylor" />);
```

این مثال عبارت "Hello Taylor" را در یک کانتینر در صفحه رندر خواهد کرد.

متوجه خواهید شد که ما از نگارشی شبیه HTML استفاده کردیم؛ [ما آن را JSX می‌نامیم](https://react.dev/learn#writing-markup-with-jsx). استفاده از JSX برای کار با ری‌اکت الزامی نیست، اما کد را خواناتر می‌کند و نوشتن آن شبیه نوشتن HTML است.

## مشارکت

هدف اصلی این مخزن، ادامه توسعه هسته ری‌اکت، سریع‌تر و آسان‌تر کردن آن است. توسعه ری‌اکت به صورت عمومی در گیت‌هاب انجام می‌شود و ما از جامعه برای رفع اشکال‌ها و بهبودها سپاسگزاریم. برای یادگیری نحوه مشارکت در بهبود ری‌اکت، ادامه را بخوانید.

### [کد رفتار](https://code.fb.com/codeofconduct)

فیسبوک یک کد رفتار را پذیرفته است که انتظار داریم شرکت‌کنندگان پروژه به آن پایبند باشند. لطفاً [متن کامل](https://code.fb.com/codeofconduct) را بخوانید تا بدانید چه اقداماتی پذیرفته و چه اقداماتی غیرقابل قبول هستند.

### [راهنمای مشارکت](https://legacy.reactjs.org/docs/how-to-contribute.html)

[راهنمای مشارکت](https://legacy.reactjs.org/docs/how-to-contribute.html) ما را بخوانید تا با فرآیند توسعه، نحوه پیشنهاد رفع اشکال و بهبودها و نحوه ساخت و آزمایش تغییرات خود در ری‌اکت آشنا شوید.

### [مسائل مناسب شروع](https://github.com/facebook/react/labels/good%20first%20issue)

برای کمک به آشنایی اولیه شما با فرآیند مشارکت، لیستی از [مسائل مناسب شروع](https://github.com/facebook/react/labels/good%20first%20issue) داریم که شامل باگ‌هایی با دامنه نسبتاً محدود هستند. اینجا مکان مناسبی برای شروع است.

### مجوز

ری‌اکت تحت [مجوز MIT](./LICENSE) منتشر شده است.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---