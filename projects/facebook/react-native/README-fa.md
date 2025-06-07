<h1 align="center">
  <a href="https://reactnative.dev/">
    ری اکت نیتیو
  </a>
</h1>

<p align="center">
  <strong>یک‌بار بیاموزید، همه‌جا بنویسید:</strong><br>
  اپلیکیشن‌های موبایل را با ری اکت بسازید.
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
  <a href="https://reactnative.dev/docs/getting-started">شروع به کار</a>
  <span> · </span>
  <a href="https://reactnative.dev/docs/tutorial">آموزش اصول اولیه</a>
  <span> · </span>
  <a href="https://reactnative.dev/showcase">نمونه‌ها</a>
  <span> · </span>
  <a href="https://reactnative.dev/docs/contributing">مشارکت</a>
  <span> · </span>
  <a href="https://reactnative.dev/help">جامعه</a>
  <span> · </span>
  <a href="https://github.com/facebook/react-native/blob/HEAD/.github/SUPPORT.md">پشتیبانی</a>
</h3>

ری اکت نیتیو [**چارچوب رابط کاربری اعلامی ری اکت**][r] را به iOS و اندروید می‌آورد. با ری اکت نیتیو، شما از کنترل‌های رابط کاربری بومی استفاده می‌کنید و به پلتفرم بومی به طور کامل دسترسی دارید.

- **اعلامی.** ری اکت ساخت رابط‌های کاربری تعاملی را بدون دردسر می‌کند. نماهای اعلامی کد شما را قابل پیش‌بینی‌تر و اشکال‌زدایی آن را ساده‌تر می‌کند.
- **مبتنی بر مؤلفه.** مؤلفه‌های محصور بسازید که وضعیت خود را مدیریت می‌کنند، سپس آن‌ها را برای ساخت رابط‌های کاربری پیچیده‌تر ترکیب کنید.
- **سرعت توسعه‌دهنده.** تغییرات محلی را در عرض چند ثانیه مشاهده کنید. تغییرات در کد جاوااسکریپت بدون نیاز به بازسازی برنامه بومی می‌تواند به صورت زنده بارگذاری شود.
- **قابلیت حمل.** کد را میان iOS، اندروید و [سایر پلتفرم‌ها][p] مجدداً استفاده کنید.

ری اکت نیتیو توسط شرکت‌ها و مشارکت‌کنندگان اصلی زیادی توسعه یافته و پشتیبانی می‌شود. برای اطلاعات بیشتر، به [مرور اجمالی اکوسیستم][e] مراجعه کنید.

[r]: https://react.dev/
[p]: https://reactnative.dev/docs/out-of-tree-platforms
[e]: https://github.com/facebook/react-native/blob/HEAD/ECOSYSTEM.md

## فهرست مطالب

- [پیش‌نیازها](#-requirements)
- [ساخت اولین برنامه ری اکت نیتیو](#-building-your-first-react-native-app)
- [مستندات](#-documentation)
- [ارتقا](#-upgrading)
- [نحوه مشارکت](#-how-to-contribute)
- [منشور رفتار](#code-of-conduct)
- [مجوز](#-license)

## 📋 پیش‌نیازها

برنامه‌های ری اکت نیتیو می‌توانند iOS 15.1 و اندروید 7.0 (API 24) یا جدیدتر را هدف قرار دهند. شما می‌توانید از ویندوز، macOS یا لینوکس به عنوان سیستم عامل توسعه خود استفاده کنید، گرچه ساخت و اجرای برنامه‌های iOS محدود به macOS است. ابزارهایی مانند [اکسپو](https://expo.dev) می‌توانند برای رفع این محدودیت استفاده شوند.

## 🎉 ساخت اولین برنامه ری اکت نیتیو

راهنمای [شروع به کار](https://reactnative.dev/docs/getting-started) را دنبال کنید. روش پیشنهادی نصب ری اکت نیتیو به پروژه شما بستگی دارد. در اینجا راهنماهای کوتاهی برای رایج‌ترین سناریوها آورده شده است:

- [امتحان کردن ری اکت نیتیو][hello-world]
- [ایجاد یک برنامه جدید][new-app]
- [افزودن ری اکت نیتیو به یک برنامه موجود][existing]

[hello-world]: https://snack.expo.dev/@samples/hello-world
[new-app]: https://reactnative.dev/docs/getting-started
[existing]: https://reactnative.dev/docs/integration-with-existing-apps

## 📖 مستندات

مستندات کامل ری اکت نیتیو در [وبسایت ما][docs] موجود است.

مستندات ری اکت نیتیو به مؤلفه‌ها، APIها و موضوعاتی می‌پردازد که مختص ری اکت نیتیو هستند. برای مستندات بیشتر درباره API ری اکت که بین ری اکت نیتیو و React DOM مشترک است، به [مستندات ری اکت][r-docs] مراجعه کنید.

سورس مستندات و وبسایت ری اکت نیتیو در مخزن جداگانه [**@facebook/react-native-website**][repo-website] میزبانی می‌شود.

[docs]: https://reactnative.dev/docs/getting-started
[r-docs]: https://react.dev/learn
[repo-website]: https://github.com/facebook/react-native-website

## 🚀 ارتقا

ارتقا به نسخه‌های جدید ری اکت نیتیو می‌تواند دسترسی به APIهای بیشتر، نماها، ابزارهای توسعه‌دهنده و امکانات دیگر را برای شما فراهم کند. برای راهنمایی، به [راهنمای ارتقا][u] مراجعه کنید.

انتشارهای ری اکت نیتیو [در این مخزن گفتگو](https://github.com/reactwg/react-native-releases/discussions) بررسی می‌شوند.

[u]: https://reactnative.dev/docs/upgrading
[repo-releases]: https://github.com/react-native-community/react-native-releases

## 👏 نحوه مشارکت

هدف اصلی این مخزن، تداوم توسعه هسته ری اکت نیتیو است. ما می‌خواهیم مشارکت در این پروژه را تا حد امکان ساده و شفاف کنیم و از جامعه برای رفع اشکال‌ها و بهبودها سپاسگزاریم. برای آشنایی با نحوه مشارکت در بهبود ری اکت نیتیو، ادامه را بخوانید.

### [منشور رفتار][code]

فیسبوک منشور رفتاری را اتخاذ کرده است که انتظار داریم شرکت‌کنندگان پروژه به آن پایبند باشند.
لطفاً [متن کامل][code] را بخوانید تا بدانید چه اقداماتی قابل قبول و چه اقداماتی غیرقابل قبول است.

[code]: https://code.fb.com/codeofconduct/

### [راهنمای مشارکت][contribute]

برای آشنایی با فرآیند توسعه ما، نحوه پیشنهاد رفع اشکال و بهبودها، و نحوه ساخت و تست تغییرات خود در ری اکت نیتیو، [**راهنمای مشارکت**][contribute] را بخوانید.

[contribute]: https://reactnative.dev/docs/contributing

### [نقشه راه متن‌باز][roadmap]

می‌توانید درباره چشم‌انداز ما برای ری اکت نیتیو در [**نقشه راه**][roadmap] بیشتر بدانید.

[roadmap]: https://github.com/facebook/react-native/wiki/Roadmap

### مسائل مناسب برای شروع

ما فهرستی از [مسائل مناسب برای شروع][gfi] داریم که شامل باگ‌هایی با دامنه نسبتاً محدود هستند. این مکان خوبی برای شروع، کسب تجربه و آشنایی با فرآیند مشارکت ماست.

[gfi]: https://github.com/facebook/react-native/labels/good%20first%20issue

### بحث‌ها

بحث‌ها و پیشنهادات گسترده‌تر در [**@react-native-community/discussions-and-proposals**][repo-meta] مطرح می‌شوند.

[repo-meta]: https://github.com/react-native-community/discussions-and-proposals

## 📄 مجوز

ری اکت نیتیو تحت مجوز MIT منتشر شده است که در فایل [LICENSE][l] آمده است.

[l]: https://github.com/facebook/react-native/blob/main/LICENSE

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---