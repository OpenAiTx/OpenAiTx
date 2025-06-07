## Create React App [![Build & Test](https://github.com/facebook/create-react-app/actions/workflows/build-and-test.yml/badge.svg?branch=main)](https://github.com/facebook/create-react-app/actions/workflows/build-and-test.yml) [![PRs Welcome](https://img.shields.io/badge/PRs-welcome-green.svg)](https://github.com/facebook/create-react-app/blob/main/CONTRIBUTING.md)

> [!CAUTION]
>
> ## منسوخ شده
>
> Create React App یکی از ابزارهای کلیدی برای راه‌اندازی سریع پروژه‌های React در سال‌های ۲۰۱۷ تا ۲۰۲۱ بود، اما اکنون در وضعیت نگهداری بلندمدت قرار دارد و توصیه می‌کنیم به یکی از فریمورک‌های React که در [شروع یک پروژه React جدید](https://react.dev/learn/start-a-new-react-project) مستند شده‌اند مهاجرت کنید.
>
> اگر برای یادگیری React در حال دنبال کردن یک آموزش هستید، ادامه دادن آموزش ارزشمند است، اما توصیه نمی‌کنیم برای ساخت برنامه‌های تولیدی جدید از Create React App استفاده کنید.

<img alt="Logo" align="right" src="https://create-react-app.dev/img/logo.svg" width="20%" />

ایجاد برنامه‌های React بدون نیاز به پیکربندی ساخت.

- [ایجاد یک برنامه](#creating-an-app) – نحوه ایجاد یک برنامه جدید.
- [راهنمای کاربر](https://facebook.github.io/create-react-app/) – نحوه توسعه برنامه‌هایی که با Create React App ساخته شده‌اند.

Create React App بر روی macOS، ویندوز و لینوکس کار می‌کند.<br>
اگر چیزی کار نکرد، لطفاً [یک issue ثبت کنید](https://github.com/facebook/create-react-app/issues/new).<br>
اگر سوالی دارید یا نیاز به کمک دارید، لطفاً در [گفتگوهای گیت‌هاب](https://github.com/facebook/create-react-app/discussions) مطرح کنید.

## مرور سریع

```sh
npx create-react-app my-app
cd my-app
npm start
```

اگر قبلاً `create-react-app` را به صورت سراسری با دستور `npm install -g create-react-app` نصب کرده‌اید، توصیه می‌کنیم بسته را با `npm uninstall -g create-react-app` یا `yarn global remove create-react-app` حذف کنید تا اطمینان حاصل شود که npx همواره جدیدترین نسخه را استفاده می‌کند.

_([npx](https://medium.com/@maybekatz/introducing-npx-an-npm-package-runner-55f7d4bd282b) همراه با npm 5.2+ و بالاتر ارائه می‌شود، [دستورالعمل‌ها برای نسخه‌های قدیمی‌تر npm](https://gist.github.com/gaearon/4064d3c23a77c74a3614c498a8bb1c5f))_

سپس [http://localhost:3000/](http://localhost:3000/) را باز کنید تا برنامه خود را مشاهده کنید.<br>
زمانی که آماده انتشار به محیط تولید شدید، یک بسته‌ی کم‌حجم با `npm run build` بسازید.

<p align='center'>
<img src='https://cdn.jsdelivr.net/gh/facebook/create-react-app@27b42ac7efa018f2541153ab30d63180f5fa39e0/screencast.svg' width='600' alt='npm start'>
</p>

### بلافاصله شروع کنید

شما **نیازی به نصب یا پیکربندی ابزارهایی مانند webpack یا Babel ندارید**.<br>
این ابزارها از پیش پیکربندی شده و مخفی هستند تا بتوانید روی کد تمرکز کنید.

یک پروژه ایجاد کنید و آماده‌ی شروع باشید.

## ایجاد یک برنامه

**شما باید Node نسخه ۱۴.۰.۰ یا بالاتر را روی دستگاه توسعه محلی خود داشته باشید** (اما روی سرور الزامی نیست). توصیه می‌کنیم از آخرین نسخه LTS استفاده کنید. می‌توانید از [nvm](https://github.com/creationix/nvm#installation) (برای macOS/Linux) یا [nvm-windows](https://github.com/coreybutler/nvm-windows#node-version-manager-nvm-for-windows) برای تغییر نسخه Node بین پروژه‌های مختلف استفاده کنید.

برای ایجاد یک برنامه جدید، می‌توانید یکی از روش‌های زیر را انتخاب کنید:

### npx

```sh
npx create-react-app my-app
```

_([npx](https://medium.com/@maybekatz/introducing-npx-an-npm-package-runner-55f7d4bd282b) یک ابزار اجرای بسته است که همراه با npm 5.2+ و بالاتر ارائه می‌شود، [دستورالعمل‌ها برای نسخه‌های قدیمی‌تر npm](https://gist.github.com/gaearon/4064d3c23a77c74a3614c498a8bb1c5f))_

### npm

```sh
npm init react-app my-app
```

_`npm init <initializer>` در npm 6+ قابل استفاده است_

### Yarn

```sh
yarn create react-app my-app
```

_[`yarn create <starter-kit-package>`](https://yarnpkg.com/lang/en/docs/cli/create/) در Yarn 0.25+ در دسترس است_

این دستور یک پوشه با نام `my-app` در داخل پوشه فعلی ایجاد می‌کند.<br>
در داخل این پوشه، ساختار اولیه پروژه و وابستگی‌های مورد نیاز را نصب می‌کند:

```
my-app
├── README.md
├── node_modules
├── package.json
├── .gitignore
├── public
│   ├── favicon.ico
│   ├── index.html
│   └── manifest.json
└── src
    ├── App.css
    ├── App.js
    ├── App.test.js
    ├── index.css
    ├── index.js
    ├── logo.svg
    └── serviceWorker.js
    └── setupTests.js
```

بدون پیکربندی و ساختار پوشه‌های پیچیده، فقط فایل‌هایی که برای ساخت برنامه نیاز دارید.<br>
پس از پایان نصب، می‌توانید پوشه پروژه را باز کنید:

```sh
cd my-app
```

در داخل پروژه ایجاد شده، می‌توانید چند دستور داخلی اجرا کنید:

### `npm start` یا `yarn start`

برنامه را در حالت توسعه اجرا می‌کند.<br>
[http://localhost:3000](http://localhost:3000) را در مرورگر باز کنید تا برنامه را ببینید.

صفحه به طور خودکار با تغییر کد، بارگذاری مجدد می‌شود.<br>
خطاهای ساخت و هشدارهای lint در کنسول نمایش داده می‌شوند.

<p align='center'>
<img src='https://cdn.jsdelivr.net/gh/marionebl/create-react-app@9f6282671c54f0874afd37a72f6689727b562498/screencast-error.svg' width='600' alt='Build errors'>
</p>

### `npm test` یا `yarn test`

واچر تست را به صورت تعاملی اجرا می‌کند.<br>
به طور پیش‌فرض، تست‌های مرتبط با فایل‌هایی که از آخرین commit تغییر یافته‌اند را اجرا می‌کند.

[بیشتر درباره تست بخوانید.](https://facebook.github.io/create-react-app/docs/running-tests)

### `npm run build` یا `yarn build`

برنامه را برای محیط تولید به پوشه `build` می‌سازد.<br>
React را به درستی در حالت production bundle و build را برای بهترین عملکرد بهینه می‌کند.

ساخت نهایی کم‌حجم است و نام فایل‌ها شامل hash می‌شود.<br>

برنامه شما آماده انتشار است.

## راهنمای کاربر

دستورالعمل‌های کامل برای استفاده از Create React App و نکات فراوان را در [مستندات آن](https://facebook.github.io/create-react-app/) بیابید.

## چگونه به نسخه‌های جدید به‌روزرسانی کنیم؟

لطفاً برای این مورد و اطلاعات بیشتر به [راهنمای کاربر](https://facebook.github.io/create-react-app/docs/updating-to-new-releases) مراجعه کنید.

## فلسفه

- **یک وابستگی:** تنها یک وابستگی build وجود دارد. این ابزار از webpack، Babel، ESLint و پروژه‌های دیگر استفاده می‌کند، اما تجربه‌ای یکپارچه و منسجم بر روی آن‌ها ارائه می‌دهد.

- **بدون نیاز به پیکربندی:** نیازی به پیکربندی چیزی ندارید. یک پیکربندی مناسب برای هر دو حالت توسعه و تولید برای شما مدیریت می‌شود تا بتوانید روی نوشتن کد تمرکز کنید.

- **بدون قفل شدن:** هر زمان می‌توانید به تنظیمات دلخواه خود “eject” کنید. با اجرای یک دستور، تمام پیکربندی و وابستگی‌های ساخت مستقیماً به پروژه شما منتقل می‌شود تا بتوانید از همان‌جایی که بودید ادامه دهید.

## چه چیزهایی شامل می‌شود؟

محیط شما هر آنچه برای ساخت یک برنامه React تک‌صفحه‌ای مدرن نیاز دارید را خواهد داشت:

- پشتیبانی از React، JSX، ES6، TypeScript و Flow.
- قابلیت‌های اضافی زبانی فراتر از ES6 مانند عملگر spread شیء.
- CSS با پیشوند خودکار، پس نیازی به `-webkit-` یا پیشوندهای دیگر ندارید.
- اجرای سریع تست‌های واحد تعاملی با پشتیبانی داخلی از گزارش‌گیری پوشش تست.
- سرور توسعه زنده که درباره خطاهای متداول هشدار می‌دهد.
- اسکریپت build برای بسته‌بندی JS، CSS و تصاویر برای تولید، همراه با hash و sourcemap.
- [service worker](https://developers.google.com/web/fundamentals/getting-started/primers/service-workers) آفلاین و [manifest برنامه وب](https://developers.google.com/web/fundamentals/engage-and-retain/web-app-manifest/) که تمام معیارهای [برنامه وب پیش‌رونده](https://facebook.github.io/create-react-app/docs/making-a-progressive-web-app) را دارا هستند. (_توجه: استفاده از service worker از نسخه `react-scripts@2.0.0` به بعد اختیاری است_)
- به‌روزرسانی آسان ابزارهای بالا تنها با یک وابستگی.

برای درک نحوه یکپارچگی این ابزارها [این راهنما](https://github.com/nitishdayal/cra_closer_look) را ببینید.

نکته این است که **این ابزارها به صورت پیش‌فرض برای کار به یک روش خاص پیکربندی شده‌اند**. اگر پروژه شما به سفارشی‌سازی بیشتری نیاز دارد، می‌توانید ["eject"](https://facebook.github.io/create-react-app/docs/available-scripts#npm-run-eject) کنید و آن را سفارشی کنید، اما در این صورت باید پیکربندی را خودتان نگهداری کنید.

## جایگزین‌های محبوب

Create React App انتخابی عالی برای موارد زیر است:

- **یادگیری React** در یک محیط توسعه راحت و پر امکانات.
- **شروع برنامه‌های جدید تک‌صفحه‌ای React.**
- **ایجاد مثال** برای کتابخانه‌ها و کامپوننت‌های خود با React.

در این چند حالت معمول شاید بخواهید ابزار دیگری را امتحان کنید:

- اگر می‌خواهید **React را بدون وابستگی‌های متعدد ابزارهای build امتحان کنید**، [به‌جای آن از یک فایل HTML ساده یا sandbox آنلاین استفاده کنید](https://reactjs.org/docs/getting-started.html#try-react).

- اگر نیاز دارید **کد React را با یک فریمورک قالب‌ساز سمت سرور** مانند Rails، Django یا Symfony ترکیب کنید، یا اگر **برنامه تک‌صفحه‌ای نمی‌سازید**، از [nwb](https://github.com/insin/nwb) یا [Neutrino](https://neutrino.js.org/) که انعطاف‌پذیرتر هستند استفاده کنید. برای Rails به طور خاص می‌توانید از [Rails Webpacker](https://github.com/rails/webpacker) استفاده کنید. برای Symfony از [webpack Encore سیمفونی](https://symfony.com/doc/current/frontend/encore/reactjs.html) بهره بگیرید.

- اگر می‌خواهید **یک کامپوننت React منتشر کنید**، [nwb](https://github.com/insin/nwb) [این کار را هم انجام می‌دهد](https://github.com/insin/nwb#react-components-and-libraries)، همین‌طور [preset کامپوننت Neutrino](https://neutrino.js.org/packages/react-components/).

- اگر می‌خواهید **render سمت سرور** با React و Node.js انجام دهید، به [Next.js](https://nextjs.org/) یا [Razzle](https://github.com/jaredpalmer/razzle) مراجعه کنید. Create React App مستقل از backend است و فقط بسته‌های HTML/JS/CSS ایستا تولید می‌کند.

- اگر وب‌سایت شما **عمدتاً ایستا** است (مثلاً پرتفولیو یا وبلاگ)، از [Gatsby](https://www.gatsbyjs.org/) یا [Next.js](https://nextjs.org/) استفاده کنید. برخلاف Create React App، Gatsby وب‌سایت را در زمان build به HTML پیش‌پردازش می‌کند. Next.js هم رندر سمت سرور و هم پیش‌رندر را پشتیبانی می‌کند.

- در نهایت، اگر به **سفارشی‌سازی بیشتر** نیاز دارید، به [Neutrino](https://neutrino.js.org/) و [preset React آن](https://neutrino.js.org/packages/react/) مراجعه کنید.

تمام ابزارهای بالا با کمترین پیکربندی یا بدون نیاز به پیکربندی کار می‌کنند.

اگر ترجیح می‌دهید build را خودتان پیکربندی کنید، [این راهنما را دنبال کنید](https://reactjs.org/docs/add-react-to-a-website.html).

## React Native

به دنبال ابزاری مشابه برای React Native هستید؟<br>
به [Expo CLI](https://github.com/expo/expo-cli) مراجعه کنید.

## مشارکت

خوشحال می‌شویم که شما هم در توسعه `create-react-app` مشارکت داشته باشید! برای اطلاعات بیشتر در مورد موارد مورد نیاز و نحوه شروع، [CONTRIBUTING.md](CONTRIBUTING.md) را ببینید.

## حمایت از Create React App

Create React App یک پروژه جامعه‌محور است و همه مشارکت‌کنندگان داوطلب هستند. اگر می‌خواهید از توسعه آینده Create React App حمایت کنید، لطفاً به [Open Collective ما](https://opencollective.com/create-react-app) کمک مالی کنید.

## اعتبار

این پروژه به لطف همه کسانی که [مشارکت کرده‌اند](CONTRIBUTING.md) وجود دارد.<br>
<a href="https://github.com/facebook/create-react-app/graphs/contributors"><img src="https://opencollective.com/create-react-app/contributors.svg?width=890&button=false" /></a>

از [Netlify](https://www.netlify.com/) بابت میزبانی مستندات تشکر می‌کنیم.

## قدردانی

ما از نویسندگان پروژه‌های مرتبط برای ایده‌ها و همکاری‌شان سپاسگزاریم:

- [@eanplatter](https://github.com/eanplatter)
- [@insin](https://github.com/insin)
- [@mxstbr](https://github.com/mxstbr)

## مجوز

Create React App یک نرم‌افزار متن‌باز است که [بر اساس مجوز MIT](https://github.com/facebook/create-react-app/blob/main/LICENSE) منتشر شده است. لوگوی Create React App تحت [مجوز Creative Commons Attribution 4.0 International](https://creativecommons.org/licenses/by/4.0/) منتشر شده است.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---