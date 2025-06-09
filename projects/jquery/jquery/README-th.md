# [jQuery](https://jquery.com/) — JavaScript ยุคใหม่

ขณะนี้มีการจัดประชุมบนแพลตฟอร์ม [matrix.org](https://matrix.to/#/#jquery_meeting:gitter.im)

บันทึกการประชุมสามารถดูได้ที่ [meetings.jquery.org](https://meetings.jquery.org/category/core/)

เวอร์ชันล่าสุดของ jQuery สามารถดาวน์โหลดได้ที่ [https://jquery.com/download/](https://jquery.com/download/)

## การสนับสนุนเวอร์ชัน

| เวอร์ชัน | สาขา        | สถานะ    |
| -------- | ----------- | -------- |
| 4.x      | main        | Beta     |
| 3.x      | 3.x-stable  | ใช้งานอยู่ |
| 2.x      | 2.x-stable  | ไม่ใช้งาน |
| 1.x      | 1.x-stable  | ไม่ใช้งาน |

เมื่อ jQuery 4.0.0 ตัวเต็มถูกปล่อยออกมาแล้ว สาขา 3.x จะยังคงได้รับการอัปเดตในระยะเวลาจำกัด สาขา 2.x และ 1.x จะไม่ได้รับการสนับสนุนอีกต่อไป

บริการสนับสนุนเชิงพาณิชย์สำหรับเวอร์ชันที่ไม่ใช้งานมีให้บริการโดย [HeroDevs](https://herodevs.com/nes)

เรียนรู้เพิ่มเติมเกี่ยวกับ [การสนับสนุนเวอร์ชัน](https://jquery.com/support/)

## คู่มือการมีส่วนร่วม

ในจิตวิญญาณของการพัฒนาซอฟต์แวร์โอเพ่นซอร์ส jQuery สนับสนุนให้ชุมชนมีส่วนร่วมในโค้ดเสมอ เพื่อช่วยให้คุณเริ่มต้นและก่อนที่คุณจะเริ่มเขียนโค้ด โปรดอ่านแนวทางการมีส่วนร่วมที่สำคัญเหล่านี้ให้ละเอียด:

1. [การมีส่วนร่วม](https://contribute.jquery.org/)
2. [คู่มือการเขียนสไตล์โค้ดหลัก](https://contribute.jquery.org/style-guide/js/)
3. [การเขียนโค้ดสำหรับโครงการ jQuery](https://contribute.jquery.org/code/)

### การอ้างอิงถึง issue/PR

โดยทั่วไป issue/PR บน GitHub จะถูกอ้างอิงด้วย `gh-หมายเลข` โดยที่ `หมายเลข` คือ ID ตัวเลขของ issue/PR นั้น คุณสามารถค้นหา issue/PR ดังกล่าวได้ที่ `https://github.com/jquery/jquery/issues/หมายเลข`

jQuery เคยใช้ตัวติดตามบั๊กที่แตกต่างกัน - โดยใช้ Trac - ในอดีต ซึ่งยังคงเปิดให้ดูแบบอ่านได้ที่ [bugs.jquery.com](https://bugs.jquery.com/) เพื่อให้สามารถอ้างอิงถึงการอภิปรายในอดีตได้ เมื่อมีการอ้างอิงถึง issue เหล่านั้นในซอร์สโค้ด jQuery จะใช้รูปแบบ `trac-หมายเลข` โดยที่ `หมายเลข` คือ ID ตัวเลขของ issue นั้น คุณสามารถค้นหา issue ดังกล่าวได้ที่ `https://bugs.jquery.com/ticket/หมายเลข`

## สภาพแวดล้อมที่ใช้ jQuery ได้

- [การสนับสนุนเบราว์เซอร์](https://jquery.com/browser-support/)
- jQuery ยังรองรับ Node, ส่วนขยายเบราว์เซอร์ และสภาพแวดล้อมที่ไม่ใช่เบราว์เซอร์อื่น ๆ ด้วย

## สิ่งที่คุณต้องมีเพื่อสร้าง jQuery ด้วยตนเอง

ในการ build jQuery คุณจำเป็นต้องมี Node.js/npm เวอร์ชันล่าสุด และ git 1.7 ขึ้นไป เวอร์ชันก่อนหน้าอาจใช้ได้ แต่จะไม่ได้รับการสนับสนุน

สำหรับ Windows คุณต้องดาวน์โหลดและติดตั้ง [git](https://git-scm.com/downloads) และ [Node.js](https://nodejs.org/en/download/)

ผู้ใช้ macOS ควรติดตั้ง [Homebrew](https://brew.sh/) เมื่อ Homebrew ถูกติดตั้งแล้ว ให้รัน `brew install git` เพื่อติดตั้ง git และ `brew install node` เพื่อติดตั้ง Node.js

ผู้ใช้ Linux/BSD ควรใช้ package manager ที่เหมาะสมในการติดตั้ง git และ Node.js หรือ build จากซอร์สหากต้องการ ง่ายมาก

## วิธีการ build jQuery ด้วยตนเอง

ก่อนอื่น [โคลน repo git ของ jQuery](https://help.github.com/en/github/creating-cloning-and-archiving-repositories/cloning-a-repository)

จากนั้น เข้าสู่ไดเรกทอรี jquery ติดตั้ง dependencies และรันสคริปต์ build:

```bash
cd jquery
npm install
npm run build
```

ไฟล์ jQuery ที่ถูก build แล้วจะอยู่ในไดเรกทอรี `dist/` พร้อมไฟล์ที่ถูกย่อขนาดและไฟล์ map ที่เกี่ยวข้อง

## สร้างไฟล์ release ทั้งหมดของ jQuery

เพื่อ build jQuery ในทุกรูปแบบ ให้รันคำสั่งต่อไปนี้:

```bash
npm run build:all
```

คำสั่งนี้จะสร้างไฟล์ jQuery ทุกรูปแบบที่รวมอยู่ใน release รวมถึง `jquery.js`, `jquery.slim.js`, `jquery.module.js`, และ `jquery.slim.module.js` พร้อมไฟล์ที่ถูก minify และ sourcemap ที่เกี่ยวข้อง

`jquery.module.js` และ `jquery.slim.module.js` เป็น [ECMAScript modules](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Guide/Modules) ที่ export `jQuery` และ `$` แบบ named export จะถูกวางไว้ในไดเรกทอรี `dist-module/` แทนที่จะเป็น `dist/`

## การสร้าง jQuery แบบกำหนดเอง

สคริปต์ build สามารถใช้สร้าง jQuery เวอร์ชันกำหนดเองที่มีเฉพาะ modules ที่คุณต้องการ

สามารถยกเว้น module ใดก็ได้ ยกเว้น `core` หากยกเว้น `selector` จะไม่ถูกลบ แต่จะถูกแทนที่ด้วยตัว wrapper เล็ก ๆ ที่ใช้ `querySelectorAll` ของเบราว์เซอร์ (ดูข้อมูลเพิ่มเติมด้านล่าง)

### วิธีใช้สคริปต์ Build

เพื่อดูตัวเลือกทั้งหมดที่มีสำหรับสคริปต์ build ให้รันคำสั่งนี้:

```bash
npm run build -- --help
```

### Modules

หากต้องการยกเว้น module ให้ส่ง path ของ module (สัมพัทธ์กับโฟลเดอร์ `src` และไม่ต้องมีนามสกุล `.js`) ไปยัง option `--exclude` หากใช้ `--include` จะตัด include ค่า default ออกและ build เฉพาะ modules ที่ระบุเท่านั้น

ตัวอย่าง modules ที่สามารถยกเว้นหรือเพิ่มได้ เช่น:

- **ajax**: ฟังก์ชัน AJAX ทั้งหมด: `$.ajax()`, `$.get()`, `$.post()`, `$.ajaxSetup()`, `.load()`, ระบบขนส่ง และ event ช็อตคัทของ ajax เช่น `.ajaxStart()`
- **ajax/xhr**: ระบบขนส่ง AJAX ที่ใช้ XMLHTTPRequest เท่านั้น
- **ajax/script**: ระบบขนส่ง AJAX ที่ใช้ `<script>` เท่านั้น; ใช้สำหรับดึง script
- **ajax/jsonp**: ระบบขนส่ง AJAX แบบ JSONP เท่านั้น; ขึ้นอยู่กับ ajax/script
- **css**: เมธอด `.css()` และจะลบ modules ที่ขึ้นกับ css ทั้งหมด (รวมถึง **effects**, **dimensions**, และ **offset**)
- **css/showHide**: `.show()`, `.hide()` และ `.toggle()` ที่ไม่ใช่อนิเมชัน; สามารถยกเว้นได้หากคุณใช้ class หรือเรียก `.css()` ตรง ๆ เพื่อ set `display` จะลบ module **effects** ด้วย
- **deprecated**: เมธอดที่ถูกระบุว่าเลิกใช้แล้ว แต่ยังไม่ได้ลบออก
- **dimensions**: เมธอด `.width()` และ `.height()` รวมถึงรูปแบบ `inner-` และ `outer-`
- **effects**: เมธอด `.animate()` และช็อตคัทเช่น `.slideUp()` หรือ `.hide("slow")`
- **event**: เมธอด `.on()` และ `.off()` และฟังก์ชัน event ทั้งหมด
- **event/trigger**: เมธอด `.trigger()` และ `.triggerHandler()`
- **offset**: เมธอด `.offset()`, `.position()`, `.offsetParent()`, `.scrollLeft()`, และ `.scrollTop()`
- **wrap**: เมธอด `.wrap()`, `.wrapAll()`, `.wrapInner()`, และ `.unwrap()`
- **core/ready**: ยกเว้น ready module หากคุณวาง script ที่ท้าย body callback ที่ผูกกับ `jQuery()` จะถูกเรียกทันที แต่ `jQuery(document).ready()` จะไม่ใช่ฟังก์ชัน และ `.on("ready", ...)` หรือแบบคล้ายกันจะไม่ถูก trigger
- **deferred**: ยกเว้น jQuery.Deferred ซึ่งจะยกเว้น module ที่ต้องใช้ Deferred ทั้งหมดรวมถึง **ajax**, **effects**, และ **queue** แต่จะแทนที่ **core/ready** ด้วย **core/ready-no-deferred**
- **exports/global**: ยกเว้นการผูกตัวแปร global ของ jQuery ($ และ jQuery) เข้ากับ window
- **exports/amd**: ยกเว้นการกำหนดแบบ AMD

- **selector**: เอ็นจินเลือก (selector engine) แบบเต็มของ jQuery เมื่อยกเว้น module นี้ จะถูกแทนที่ด้วยเอ็นจินเลือกพื้นฐานที่ใช้ `querySelectorAll` ของเบราว์เซอร์ ซึ่งไม่รองรับส่วนขยาย selector ของ jQuery หรือ semantic ที่เพิ่มขึ้น ดูรายละเอียดได้ที่ไฟล์ [selector-native.js](https://github.com/jquery/jquery/blob/main/src/selector-native.js)

*หมายเหตุ*: การยกเว้น module `selector` แบบเต็ม จะยกเว้นส่วนขยาย selector ของ jQuery ทั้งหมด (เช่น `effects/animatedSelector` และ `css/hiddenVisibleSelectors`)

##### ชื่อ AMD

คุณสามารถตั้งชื่อ module สำหรับการกำหนด AMD ของ jQuery ได้ โดยค่าเริ่มต้นจะเป็น "jquery" ซึ่งเหมาะกับปลั๊กอินและไลบรารีจาก third-party แต่คุณอาจต้องการเปลี่ยนชื่อได้ ให้ระบุผ่านพารามิเตอร์ `--amd`:

```bash
npm run build -- --amd="custom-name"
```

หรือจะกำหนดแบบไม่ระบุชื่อ ให้เว้นชื่อไว้

```bash
npm run build -- --amd
```

##### ชื่อไฟล์และไดเรกทอรี

ชื่อเริ่มต้นของไฟล์ jQuery ที่ถูก build คือ `jquery.js` จะถูกวางไว้ใต้ไดเรกทอรี `dist/` คุณสามารถเปลี่ยนชื่อไฟล์ได้โดยใช้ `--filename` และเปลี่ยนไดเรกทอรีได้โดยใช้ `--dir` ซึ่ง `--dir` จะสัมพันธ์กับ root ของโปรเจ็กต์

```bash
npm run build -- --slim --filename="jquery.slim.js" --dir="/tmp"
```

คำสั่งนี้จะสร้าง jQuery แบบ slim และวางไว้ที่ `tmp/jquery.slim.js`

##### โหมด ECMAScript Module (ESM)

โดยปกติ jQuery จะสร้างไฟล์ JavaScript แบบ script ทั่วไป คุณสามารถสร้าง ECMAScript module ที่ export `jQuery` เป็น default export โดยใช้พารามิเตอร์ `--esm` ได้เช่นกัน:

```bash
npm run build -- --filename=jquery.module.js --esm
```

##### โหมด Factory

โดยปกติ jQuery จะขึ้นอยู่กับ global `window` สำหรับสภาพแวดล้อมที่ไม่มี window คุณสามารถสร้าง factory build ที่เปิดเผยฟังก์ชันรับ `window` เป็นพารามิเตอร์ภายนอกได้ (ดู [`README` ของแพ็คเกจที่เผยแพร่](build/fixtures/README.md) สำหรับวิธีใช้งาน) คุณสามารถสร้าง factory แบบนี้โดยใช้พารามิเตอร์ `--factory`:

```bash
npm run build -- --filename=jquery.factory.js --factory
```

ตัวเลือกนี้สามารถใช้ร่วมกับตัวเลือกอื่น ๆ เช่น `--esm` หรือ `--slim` ได้ด้วย:

```bash
npm run build -- --filename=jquery.factory.slim.module.js --factory --esm --slim --dir="/dist-module"
```

#### ตัวอย่างการ build แบบกำหนดเอง

สร้าง build แบบกำหนดเองโดยใช้ `npm run build` พร้อมระบุ modules ที่ต้องการยกเว้น การยกเว้น module ระดับบนจะยกเว้น modules ย่อยในไดเรกทอรีเดียวกันด้วย

ยกเว้นความสามารถ **ajax** ทั้งหมด:

```bash
npm run build -- --exclude=ajax
```

การยกเว้น **css** จะลบ modules ที่ขึ้นกับ CSS: **effects**, **offset**, **dimensions**

```bash
npm run build -- --exclude=css
```

ยกเว้นหลาย modules (`-e` คือ alias ของ `--exclude`):

```bash
npm run build -- -e ajax/jsonp -e css -e deprecated -e dimensions -e effects -e offset -e wrap
```

มี alias พิเศษสำหรับสร้าง build ด้วยค่าคอนฟิกเดียวกับ jQuery Slim อย่างเป็นทางการ:

```bash
npm run build -- --filename=jquery.slim.js --slim
```

หรือ หากต้องการสร้าง slim build แบบ esm module:

```bash
npm run build -- --filename=jquery.slim.module.js --slim --esm
```
```

*บิลด์แบบกำหนดเองที่ไม่เป็นทางการจะไม่ได้รับการทดสอบอย่างสม่ำเสมอ โปรดใช้งานโดยยอมรับความเสี่ยงด้วยตนเอง*

## การรัน Unit Tests

ตรวจสอบให้แน่ใจว่าคุณมี dependencies ที่จำเป็น:

```bash
npm install
```

เริ่ม `npm start` เพื่อให้ jQuery ถูก build อัตโนมัติขณะที่คุณทำงาน:

```bash
npm start
```

รัน unit tests ด้วยเซิร์ฟเวอร์โลคอลที่รองรับ PHP ตรวจสอบให้แน่ใจว่าคุณรันไซต์จากไดเรกทอรีราก ไม่ใช่ไดเรกทอรี "test" ไม่ต้องใช้ฐานข้อมูล เซิร์ฟเวอร์ PHP โลคอลที่ตั้งค่าล่วงหน้ามีให้สำหรับ Windows และ Mac มีตัวเลือกดังนี้:

- Windows: [WAMP download](https://www.wampserver.com/en/)
- Mac: [MAMP download](https://www.mamp.info/en/downloads/)
- Linux: [การตั้งค่า LAMP](https://www.linux.com/training-tutorials/easy-lamp-server-installation/)
- [Mongoose (รองรับหลายแพลตฟอร์ม)](https://code.google.com/p/mongoose/)

## Git ที่จำเป็น

เนื่องจากซอร์สโค้ดถูกจัดการโดยระบบควบคุมเวอร์ชัน Git จึงเป็นประโยชน์ที่จะรู้จักฟีเจอร์บางอย่างที่ใช้

### การล้างข้อมูล (Cleaning)

หากคุณต้องการล้างไดเรกทอรีการทำงานของคุณให้กลับไปสถานะเดียวกับ upstream สามารถใช้คำสั่งต่อไปนี้ (โปรดจำไว้ว่าทุกอย่างที่คุณทำงานจะหายไปหลังจากนี้):

```bash
git reset --hard upstream/main
git clean -fdx
```

### การรีเบส (Rebasing)

สำหรับ branch ฟีเจอร์/ท็อปปิก ควรใช้ flag `--rebase` กับ `git pull` เสมอ หรือหากคุณจัดการ branch ชั่วคราวหลายๆ อันที่เตรียมไว้สำหรับ pull request บน github ให้รันคำสั่งนี้เพื่อทำให้เป็นอัตโนมัติ:

```bash
git config branch.autosetuprebase local
```

(ดูรายละเอียดเพิ่มเติมที่ `man git-config`)

### การจัดการ merge conflicts

หากคุณพบ merge conflict ขณะ merging แทนที่จะไปแก้ไฟล์ที่ขัดแย้งด้วยตนเอง คุณสามารถใช้ฟีเจอร์
`git mergetool` ได้ แม้ว่าเครื่องมือเริ่มต้น `xxdiff` จะดูเก่า/ไม่สวย แต่ก็ใช้งานได้ดี

คำสั่งที่สามารถใช้ได้มีดังนี้:

- `Ctrl + Alt + M` - automerge เท่าที่จะทำได้
- `b` - ข้ามไปยัง merge conflict ถัดไป
- `s` - เปลี่ยนลำดับบรรทัดที่ขัดแย้ง
- `u` - ยกเลิกการ merge
- `คลิกซ้าย` - เลือกบล็อกให้เป็นผู้ชนะ
- `คลิกกลาง` - เลือกบรรทัดให้เป็นผู้ชนะ
- `Ctrl + S` - บันทึก
- `Ctrl + Q` - ออกจากโปรแกรม

## อ้างอิง [QUnit](https://api.qunitjs.com)

### เมธอดทดสอบ

```js
expect( numAssertions );
stop();
start();
```

*หมายเหตุ*: การเพิ่มอาร์กิวเมนต์ใน stop/start ของ QUnit ในอนาคตจะถูกละเว้นใน test suite นี้ เพื่อให้ start และ stop สามารถถูกส่งเป็น callback ได้โดยไม่ต้องกังวลกับพารามิเตอร์

### การตรวจสอบผลลัพธ์ (Assertions)

```js
ok( value, [message] );
equal( actual, expected, [message] );
notEqual( actual, expected, [message] );
deepEqual( actual, expected, [message] );
notDeepEqual( actual, expected, [message] );
strictEqual( actual, expected, [message] );
notStrictEqual( actual, expected, [message] );
throws( block, [expected], [message] );
```

## อ้างอิงเมธอดอำนวยความสะดวกสำหรับ Test Suite

ดูที่ [test/data/testinit.js](https://github.com/jquery/jquery/blob/main/test/data/testinit.js)

### คืนค่ารายการอาร์เรย์ของ element ที่มี ID ที่กำหนด

```js
q( ... );
```

ตัวอย่าง:

```js
q( "main", "foo", "bar" );

=> [ div#main, span#foo, input#bar ]
```

### ตรวจสอบว่า selection ตรงกับ ID ที่กำหนด

```js
t( testName, selector, [ "array", "of", "ids" ] );
```

ตัวอย่าง:

```js
t("Check for something", "//[a]", ["foo", "bar"]);
```

### ยิงเหตุการณ์ DOM แบบ native โดยไม่ผ่าน jQuery

```js
fireNative( node, eventType );
```

ตัวอย่าง:

```js
fireNative( jQuery( "#elem" )[ 0 ], "click" );
```

### เพิ่มเลขสุ่มใน url เพื่อป้องกันการ cache

```js
url( "some/url" );
```

ตัวอย่าง:

```js
url( "index.html" );

=> "data/index.html?10538358428943"


url( "mock.php?foo=bar" );

=> "data/mock.php?foo=bar&10538358345554"
```

### รันทดสอบใน iframe

บางการทดสอบอาจต้องใช้เอกสารที่แตกต่างจาก test fixture มาตรฐาน
และสามารถรันใน iframe แยกต่างหากได้ โค้ดทดสอบหลักและ assertions
ยังคงอยู่ในไฟล์ทดสอบหลักของ jQuery เฉพาะ markup และโค้ดตั้งค่า fixture ขั้นต่ำ
เท่านั้นที่ควรใส่ในไฟล์ iframe

```js
testIframe( testName, fileName,
  function testCallback(
      assert, jQuery, window, document,
	  [ additional args ] ) {
	...
  } );
```

จะโหลดหน้าโดยสร้าง url ด้วย fileName `"./data/" + fileName`
หน้าที่อยู่ใน iframe จะเป็นตัวกำหนดว่า callback จะเกิดขึ้นเมื่อไร
โดยการ include สคริปต์ "/test/data/iframeTest.js" และเรียก
`startIframeTest( [ additional args ] )` เมื่อเหมาะสม โดยปกติจะหลังจาก document ready หรือ `window.onload` ทำงาน

`testCallback` จะได้รับวัตถุ QUnit `assert` ที่ถูกสร้างโดย `testIframe`
สำหรับการทดสอบนี้ ตามด้วย global `jQuery`, `window`, และ `document` จาก iframe
ถ้าโค้ดใน iframe ส่งอาร์กิวเมนต์ไปยัง `startIframeTest`
อาร์กิวเมนต์เหล่านั้นจะตามหลัง `document`

## คำถาม?

หากคุณมีคำถามใด ๆ สามารถสอบถามได้ที่
[Developing jQuery Core forum](https://forum.jquery.com/developing-jquery-core) หรือที่ #jquery บน [libera](https://web.libera.chat/)
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---