## Create React App [![Build & Test](https://github.com/facebook/create-react-app/actions/workflows/build-and-test.yml/badge.svg?branch=main)](https://github.com/facebook/create-react-app/actions/workflows/build-and-test.yml) [![PRs Welcome](https://img.shields.io/badge/PRs-welcome-green.svg)](https://github.com/facebook/create-react-app/blob/main/CONTRIBUTING.md)

> [!CAUTION]
>
> ## เลิกใช้แล้ว
>
> Create React App เป็นหนึ่งในเครื่องมือหลักสำหรับเริ่มต้นโปรเจกต์ React ในปี 2017-2021 ขณะนี้อยู่ในสถานะหยุดพัฒนาในระยะยาว และเราแนะนำให้คุณย้ายไปใช้เฟรมเวิร์ก React ที่มีเอกสารใน [Start a New React Project](https://react.dev/learn/start-a-new-react-project)
>
> หากคุณกำลังติดตามบทเรียนเพื่อเรียนรู้ React ยังมีคุณค่าในการเรียนต่อตามบทเรียน แต่เราไม่แนะนำให้เริ่มต้นแอปสำหรับใช้งานจริงโดยใช้ Create React App

<img alt="Logo" align="right" src="https://create-react-app.dev/img/logo.svg" width="20%" />

สร้างแอป React โดยไม่ต้องตั้งค่าการ build ใดๆ

- [การสร้างแอป](#creating-an-app) – วิธีสร้างแอปใหม่
- [คู่มือผู้ใช้](https://facebook.github.io/create-react-app/) – วิธีพัฒนาแอปที่บูตสแตรปด้วย Create React App

Create React App ใช้งานได้บน macOS, Windows และ Linux<br>
หากมีบางอย่างไม่ทำงาน กรุณา [แจ้งปัญหา](https://github.com/facebook/create-react-app/issues/new)<br>
หากคุณมีคำถามหรือขอความช่วยเหลือ กรุณาถามใน [GitHub Discussions](https://github.com/facebook/create-react-app/discussions)

## ภาพรวมอย่างรวดเร็ว

```sh
npx create-react-app my-app
cd my-app
npm start
```

หากคุณเคยติดตั้ง `create-react-app` แบบ global โดยใช้ `npm install -g create-react-app` มาก่อน เราแนะนำให้ถอนการติดตั้งแพ็กเกจด้วย `npm uninstall -g create-react-app` หรือ `yarn global remove create-react-app` เพื่อให้แน่ใจว่า npx ใช้เวอร์ชันล่าสุดเสมอ

_([npx](https://medium.com/@maybekatz/introducing-npx-an-npm-package-runner-55f7d4bd282b) มาพร้อมกับ npm 5.2+ ขึ้นไป ดู [คำแนะนำสำหรับ npm เวอร์ชันเก่า](https://gist.github.com/gaearon/4064d3c23a77c74a3614c498a8bb1c5f))_

จากนั้นเปิด [http://localhost:3000/](http://localhost:3000/) เพื่อดูแอปของคุณ<br>
เมื่อพร้อมสำหรับการนำขึ้น production ให้สร้าง bundle แบบ minified ด้วย `npm run build`

<p align='center'>
<img src='https://cdn.jsdelivr.net/gh/facebook/create-react-app@27b42ac7efa018f2541153ab30d63180f5fa39e0/screencast.svg' width='600' alt='npm start'>
</p>

### เริ่มต้นใช้งานทันที

คุณ **ไม่จำเป็น** ต้องติดตั้งหรือกำหนดค่าเครื่องมืออย่าง webpack หรือ Babel<br>
ทุกอย่างถูกตั้งค่าและซ่อนให้เรียบร้อย เพื่อให้คุณโฟกัสกับโค้ดได้เลย

สร้างโปรเจกต์แล้วเริ่มใช้งานได้ทันที

## การสร้างแอป

**คุณต้องมี Node เวอร์ชัน 14.0.0 หรือใหม่กว่าบนเครื่องสำหรับพัฒนา** (แต่ไม่จำเป็นต้องมีบนเซิร์ฟเวอร์) เราแนะนำให้ใช้ LTS เวอร์ชันล่าสุด คุณสามารถใช้ [nvm](https://github.com/creationix/nvm#installation) (macOS/Linux) หรือ [nvm-windows](https://github.com/coreybutler/nvm-windows#node-version-manager-nvm-for-windows) เพื่อสลับเวอร์ชัน Node ระหว่างโปรเจกต์ต่างๆ

ในการสร้างแอปใหม่ คุณสามารถเลือกวิธีใดวิธีหนึ่งต่อไปนี้:

### npx

```sh
npx create-react-app my-app
```

_([npx](https://medium.com/@maybekatz/introducing-npx-an-npm-package-runner-55f7d4bd282b) เป็นเครื่องมือรันแพ็กเกจที่มาพร้อม npm 5.2+ ดู [คำแนะนำสำหรับ npm เวอร์ชันเก่า](https://gist.github.com/gaearon/4064d3c23a77c74a3614c498a8bb1c5f))_

### npm

```sh
npm init react-app my-app
```

_`npm init <initializer>` มีให้ใช้ใน npm 6+_

### Yarn

```sh
yarn create react-app my-app
```

_[`yarn create <starter-kit-package>`](https://yarnpkg.com/lang/en/docs/cli/create/) มีให้ใช้ใน Yarn 0.25+_

คำสั่งนี้จะสร้างไดเรกทอรีชื่อ `my-app` ในโฟลเดอร์ปัจจุบัน<br>
ภายในโฟลเดอร์นั้นจะสร้างโครงสร้างโปรเจกต์เริ่มต้นและติดตั้ง dependencies ที่จำเป็น:

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

ไม่ต้องตั้งค่าหรือโครงสร้างโฟลเดอร์ที่ซับซ้อน มีเฉพาะไฟล์ที่คุณต้องใช้สร้างแอป<br>
เมื่อการติดตั้งเสร็จสมบูรณ์ คุณสามารถเปิดโฟลเดอร์โปรเจกต์ของคุณ:

```sh
cd my-app
```

ภายในโปรเจกต์ที่สร้างใหม่ คุณสามารถรันคำสั่งในตัวต่อไปนี้:

### `npm start` หรือ `yarn start`

รันแอปในโหมดพัฒนา<br>
เปิด [http://localhost:3000](http://localhost:3000) เพื่อดูในเบราว์เซอร์

หน้าเว็บจะรีโหลดอัตโนมัติเมื่อคุณเปลี่ยนแปลงโค้ด<br>
คุณจะเห็นข้อผิดพลาดในการ build และคำเตือน lint ในคอนโซล

<p align='center'>
<img src='https://cdn.jsdelivr.net/gh/marionebl/create-react-app@9f6282671c54f0874afd37a72f6689727b562498/screencast-error.svg' width='600' alt='Build errors'>
</p>

### `npm test` หรือ `yarn test`

รัน test watcher ในโหมด interactive<br>
โดยค่าเริ่มต้นจะรันทดสอบไฟล์ที่เปลี่ยนแปลงตั้งแต่ commit ล่าสุด

[อ่านเพิ่มเติมเกี่ยวกับการทดสอบ](https://facebook.github.io/create-react-app/docs/running-tests)

### `npm run build` หรือ `yarn build`

สร้างแอปสำหรับ production ไปยังโฟลเดอร์ `build`<br>
จะ bundle React ในโหมด production และปรับแต่ง build ให้ประสิทธิภาพดีที่สุด

ไฟล์ build จะถูก minified และชื่อไฟล์มี hash<br>

แอปของคุณพร้อมสำหรับการ deploy แล้ว

## คู่มือผู้ใช้

คุณสามารถค้นหาคำแนะนำโดยละเอียดเกี่ยวกับการใช้ Create React App และทิปส์มากมายใน [เอกสาร](https://facebook.github.io/create-react-app/) ของมัน

## วิธีอัปเดตเป็นเวอร์ชันใหม่

โปรดดูที่ [คู่มือผู้ใช้](https://facebook.github.io/create-react-app/docs/updating-to-new-releases) สำหรับข้อมูลนี้และข้อมูลอื่นๆ

## ปรัชญา

- **มี dependency เดียว:** มีเพียง dependency การ build เดียว ใช้ webpack, Babel, ESLint และโปรเจกต์อื่นๆ ที่ยอดเยี่ยม แต่ให้ประสบการณ์ที่กลมกลืนและคัดสรรมาแล้วบนพื้นฐานของเครื่องมือเหล่านี้

- **ไม่ต้องตั้งค่า:** คุณไม่ต้องตั้งค่าอะไรเอง ทั้ง build สำหรับพัฒนาและ production ถูกตั้งค่าให้เหมาะสม คุณจึงโฟกัสกับการเขียนโค้ดได้

- **ไม่ผูกขาด:** คุณสามารถ “eject” ไปสู่การตั้งค่าเองได้ทุกเมื่อ เพียงรันคำสั่งเดียว การตั้งค่าและ dependency ทั้งหมดจะถูกย้ายเข้าโปรเจกต์ของคุณ คุณจึงปรับแต่งต่อได้ทันที

## มีอะไรบ้าง?

สภาพแวดล้อมของคุณจะมีทุกอย่างที่จำเป็นสำหรับการสร้าง single-page app ด้วย React สมัยใหม่:

- รองรับ React, JSX, ES6, TypeScript และ Flow
- ฟีเจอร์ภาษาเพิ่มเติมนอกเหนือจาก ES6 เช่น object spread operator
- CSS ที่เติม prefix อัตโนมัติ โดยไม่ต้องใช้ `-webkit-` หรือ prefix อื่นๆ
- ยูนิตเทสต์รันเนอร์แบบ interactive ที่รองรับ coverage reporting ในตัว
- เซิร์ฟเวอร์สำหรับพัฒนาแบบ live ที่แจ้งเตือนข้อผิดพลาดทั่วไป
- สคริปต์ build สำหรับ bundle JS, CSS, และรูปภาพสำหรับ production พร้อม hash และ sourcemap
- [service worker](https://developers.google.com/web/fundamentals/getting-started/primers/service-workers) แบบ offline-first และ [web app manifest](https://developers.google.com/web/fundamentals/engage-and-retain/web-app-manifest/) ที่ตรงตาม [Progressive Web App](https://facebook.github.io/create-react-app/docs/making-a-progressive-web-app) (_หมายเหตุ: การใช้ service worker เป็น opt-in ตั้งแต่ `react-scripts@2.0.0` ขึ้นไป_)
- อัปเดตเครื่องมือข้างต้นได้อย่างง่ายดายด้วย dependency เดียว

ดู [คู่มือนี้](https://github.com/nitishdayal/cra_closer_look) สำหรับภาพรวมว่าเครื่องมือเหล่านี้ทำงานร่วมกันอย่างไร

ข้อแลกเปลี่ยนคือ **เครื่องมือเหล่านี้ถูกตั้งค่าให้ทำงานในรูปแบบเฉพาะ** หากโปรเจกต์ของคุณต้องการปรับแต่งมากขึ้น คุณสามารถ ["eject"](https://facebook.github.io/create-react-app/docs/available-scripts#npm-run-eject) และปรับแต่งเองได้ แต่คุณต้องดูแลคอนฟิกนี้เอง

## ทางเลือกยอดนิยม

Create React App เหมาะกับ:

- **เรียนรู้ React** ในสภาพแวดล้อมที่สะดวกและมีฟีเจอร์ครบ
- **เริ่มต้นสร้าง single-page React app ใหม่**
- **สร้างตัวอย่าง** React สำหรับไลบรารีและคอมโพเนนต์ของคุณ

กรณีตัวอย่างที่คุณอาจต้องการลองอย่างอื่น:

- หากคุณต้องการ **ลอง React** โดยไม่ต้องมี dependency build tools หลายร้อยตัว พิจารณา [ใช้ HTML ไฟล์เดียวหรือ online sandbox แทน](https://reactjs.org/docs/getting-started.html#try-react)

- หากคุณต้องการ **ผสานโค้ด React กับเฟรมเวิร์กฝั่งเซิร์ฟเวอร์** เช่น Rails, Django หรือ Symfony หรือหากคุณ **ไม่ได้สร้าง single-page app** ให้พิจารณาใช้ [nwb](https://github.com/insin/nwb) หรือ [Neutrino](https://neutrino.js.org/) ที่ยืดหยุ่นกว่า สำหรับ Rails โดยเฉพาะใช้ [Rails Webpacker](https://github.com/rails/webpacker) สำหรับ Symfony ใช้ [Symfony's webpack Encore](https://symfony.com/doc/current/frontend/encore/reactjs.html)

- หากคุณต้องการ **เผยแพร่ React component** [nwb](https://github.com/insin/nwb) [ก็ทำได้เช่นกัน](https://github.com/insin/nwb#react-components-and-libraries) รวมถึง [Neutrino's react-components preset](https://neutrino.js.org/packages/react-components/)

- หากคุณต้องการ **server rendering** ด้วย React และ Node.js ให้ดู [Next.js](https://nextjs.org/) หรือ [Razzle](https://github.com/jaredpalmer/razzle) Create React App ไม่ผูกกับ backend และสร้างได้แค่ bundle HTML/JS/CSS แบบ static

- หากเว็บไซต์ของคุณ **ส่วนใหญ่เป็น static** (เช่น portfolio หรือ blog) พิจารณาใช้ [Gatsby](https://www.gatsbyjs.org/) หรือ [Next.js](https://nextjs.org/) ต่างจาก Create React App, Gatsby จะ pre-render เว็บไซต์เป็น HTML ตอน build Next.js รองรับทั้ง server rendering และ pre-render

- สุดท้าย หากคุณต้องการ **ปรับแต่งมากขึ้น** ดู [Neutrino](https://neutrino.js.org/) และ [React preset](https://neutrino.js.org/packages/react/)

เครื่องมือข้างต้นสามารถทำงานได้ด้วยการตั้งค่าน้อยมากหรือไม่ต้องตั้งค่าเลย

หากคุณต้องการตั้งค่า build เอง [ดูคู่มือนี้](https://reactjs.org/docs/add-react-to-a-website.html)

## React Native

กำลังมองหาเครื่องมือคล้ายกันสำหรับ React Native อยู่หรือไม่<br>
ดู [Expo CLI](https://github.com/expo/expo-cli)

## การมีส่วนร่วม

เรายินดีรับความช่วยเหลือจากคุณใน `create-react-app`! ดู [CONTRIBUTING.md](CONTRIBUTING.md) สำหรับข้อมูลเพิ่มเติมเกี่ยวกับสิ่งที่เราต้องการและวิธีเริ่มต้น

## สนับสนุน Create React App

Create React App เป็นโปรเจกต์ที่ดูแลโดยชุมชนและผู้มีส่วนร่วมทุกคนเป็นอาสาสมัคร หากคุณต้องการสนับสนุนการพัฒนาในอนาคตของ Create React App โปรดพิจารณาบริจาคให้ [Open Collective](https://opencollective.com/create-react-app) ของเรา

## เครดิต

โปรเจกต์นี้ดำรงอยู่ได้ด้วยผู้ที่ [มีส่วนร่วม](CONTRIBUTING.md) ทุกคน<br>
<a href="https://github.com/facebook/create-react-app/graphs/contributors"><img src="https://opencollective.com/create-react-app/contributors.svg?width=890&button=false" /></a>

ขอบคุณ [Netlify](https://www.netlify.com/) สำหรับการโฮสต์เอกสารของเรา

## คำขอบคุณ

เราขอขอบคุณผู้เขียนโปรเจกต์ที่เกี่ยวข้องสำหรับแนวคิดและความร่วมมือ:

- [@eanplatter](https://github.com/eanplatter)
- [@insin](https://github.com/insin)
- [@mxstbr](https://github.com/mxstbr)

## ใบอนุญาต

Create React App เป็นซอฟต์แวร์ open source [ได้รับอนุญาตแบบ MIT](https://github.com/facebook/create-react-app/blob/main/LICENSE) โลโก้ Create React App ได้รับอนุญาตภายใต้ [Creative Commons Attribution 4.0 International license](https://creativecommons.org/licenses/by/4.0/)

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---