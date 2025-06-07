<h1 align="center">
  <a href="https://reactnative.dev/">
    React Native
  </a>
</h1>

<p align="center">
  <strong>เรียนรู้เพียงครั้งเดียว เขียนได้ทุกที่:</strong><br>
  สร้างแอปมือถือด้วย React
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
  <a href="https://reactnative.dev/docs/getting-started">เริ่มต้นใช้งาน</a>
  <span> · </span>
  <a href="https://reactnative.dev/docs/tutorial">เรียนรู้พื้นฐาน</a>
  <span> · </span>
  <a href="https://reactnative.dev/showcase">ตัวอย่างผลงาน</a>
  <span> · </span>
  <a href="https://reactnative.dev/docs/contributing">ร่วมพัฒนา</a>
  <span> · </span>
  <a href="https://reactnative.dev/help">ชุมชน</a>
  <span> · </span>
  <a href="https://github.com/facebook/react-native/blob/HEAD/.github/SUPPORT.md">สนับสนุน</a>
</h3>

React Native นำเสนอ [**React**'s][r] เฟรมเวิร์ก UI แบบ declarative สู่ iOS และ Android ด้วย React Native คุณจะได้ใช้คอนโทรล UI แบบเนทีฟและเข้าถึงแพลตฟอร์มเนทีฟได้อย่างเต็มที่

- **แบบ Declarative.** React ช่วยให้การสร้าง UI แบบโต้ตอบเป็นเรื่องง่าย มุมมองแบบ declarative ทำให้โค้ดของคุณทำนายผลลัพธ์ได้ง่ายและดีบักได้สะดวกขึ้น
- **Component-Based.** สร้างคอมโพเนนต์ที่มีขอบเขตของตัวเองและจัดการ state ได้เอง แล้วนำมาประกอบกันเพื่อสร้าง UI ที่ซับซ้อน
- **Developer Velocity.** เห็นการเปลี่ยนแปลงในเครื่องทันที การเปลี่ยนแปลงโค้ด JavaScript สามารถรีโหลดแบบสดได้โดยไม่ต้องสร้างแอปเนทีฟใหม่
- **Portability.** นำโค้ดกลับมาใช้ใหม่ได้ทั้งบน iOS, Android และ [แพลตฟอร์มอื่นๆ][p]

React Native ถูกพัฒนาและสนับสนุนโดยหลายบริษัทและผู้ร่วมพัฒนาหลักมากมาย ดูข้อมูลเพิ่มเติมใน [ภาพรวม ecosystem][e] ของเรา

[r]: https://react.dev/
[p]: https://reactnative.dev/docs/out-of-tree-platforms
[e]: https://github.com/facebook/react-native/blob/HEAD/ECOSYSTEM.md

## สารบัญ

- [ความต้องการ](#-requirements)
- [สร้างแอป React Native แรกของคุณ](#-building-your-first-react-native-app)
- [เอกสารประกอบ](#-documentation)
- [การอัปเกรด](#-upgrading)
- [วิธีการร่วมพัฒนา](#-how-to-contribute)
- [จรรยาบรรณ](#code-of-conduct)
- [สัญญาอนุญาต](#-license)


## 📋 ความต้องการ

แอป React Native สามารถรองรับ iOS 15.1 และ Android 7.0 (API 24) หรือใหม่กว่า คุณสามารถใช้ Windows, macOS หรือ Linux เป็นระบบปฏิบัติการสำหรับพัฒนาได้ แต่การสร้างและรันแอป iOS จะจำกัดเฉพาะบน macOS เท่านั้น เครื่องมืออย่าง [Expo](https://expo.dev) สามารถใช้เพื่อแก้ปัญหานี้ได้

## 🎉 สร้างแอป React Native แรกของคุณ

ทำตาม [คู่มือเริ่มต้นใช้งาน](https://reactnative.dev/docs/getting-started) วิธีการติดตั้ง React Native ที่แนะนำขึ้นอยู่กับโปรเจกต์ของคุณ ที่นี่คุณจะพบคำแนะนำสั้นๆ สำหรับสถานการณ์ที่พบได้บ่อย:

- [ลองใช้ React Native][hello-world]
- [สร้างแอปใหม่][new-app]
- [เพิ่ม React Native ลงในแอปที่มีอยู่แล้ว][existing]

[hello-world]: https://snack.expo.dev/@samples/hello-world
[new-app]: https://reactnative.dev/docs/getting-started
[existing]: https://reactnative.dev/docs/integration-with-existing-apps

## 📖 เอกสารประกอบ

เอกสารฉบับสมบูรณ์ของ React Native สามารถดูได้ที่ [เว็บไซต์][docs] ของเรา

เอกสารของ React Native ครอบคลุมเกี่ยวกับคอมโพเนนต์, API และหัวข้อที่เฉพาะสำหรับ React Native สำหรับเอกสารเพิ่มเติมเกี่ยวกับ React API ที่ใช้ร่วมกันระหว่าง React Native และ React DOM ดูได้ที่ [เอกสาร React][r-docs]

ซอร์สโค้ดของเอกสารและเว็บไซต์ React Native จัดเก็บไว้ที่ repository แยกต่างหาก [**@facebook/react-native-website**][repo-website]

[docs]: https://reactnative.dev/docs/getting-started
[r-docs]: https://react.dev/learn
[repo-website]: https://github.com/facebook/react-native-website

## 🚀 การอัปเกรด

การอัปเกรดเป็นเวอร์ชันใหม่ของ React Native จะช่วยให้คุณสามารถเข้าถึง API, มุมมอง, เครื่องมือสำหรับนักพัฒนา และฟีเจอร์ใหม่ๆ ได้ ดู [คู่มือการอัปเกรด][u] สำหรับคำแนะนำ

การปล่อยเวอร์ชันของ React Native มีการพูดคุยกัน [ใน discussion repo นี้](https://github.com/reactwg/react-native-releases/discussions)

[u]: https://reactnative.dev/docs/upgrading
[repo-releases]: https://github.com/react-native-community/react-native-releases

## 👏 วิธีการร่วมพัฒนา

จุดประสงค์หลักของ repository นี้ คือการพัฒนา React Native core อย่างต่อเนื่อง เราต้องการให้การร่วมพัฒนาโปรเจกต์นี้เป็นเรื่องง่ายและโปร่งใสมากที่สุด และขอขอบคุณชุมชนสำหรับการช่วยแก้ไขบั๊กและปรับปรุงฟีเจอร์ต่างๆ อ่านข้อมูลด้านล่างเพื่อเรียนรู้ว่าคุณจะมีส่วนร่วมในการพัฒนา React Native ได้อย่างไร

### [จรรยาบรรณ][code]

Facebook ได้นำจรรยาบรรณมาใช้กับโครงการนี้ และคาดหวังให้ผู้เข้าร่วมโครงการปฏิบัติตาม โปรดอ่าน [ข้อความฉบับเต็ม][code] เพื่อทำความเข้าใจว่าการกระทำใดที่ยอมรับได้และไม่ได้รับการยอมรับ

[code]: https://code.fb.com/codeofconduct/

### [คู่มือการร่วมพัฒนา][contribute]

อ่าน [**คู่มือการร่วมพัฒนา**][contribute] ของเราเพื่อเรียนรู้เกี่ยวกับกระบวนการพัฒนา วิธีการเสนอแก้ไขบั๊กและปรับปรุง และวิธีการสร้างและทดสอบการเปลี่ยนแปลงของคุณใน React Native

[contribute]: https://reactnative.dev/docs/contributing

### [แผนงานโอเพ่นซอร์ส][roadmap]

คุณสามารถเรียนรู้เพิ่มเติมเกี่ยวกับวิสัยทัศน์ของเราเกี่ยวกับ React Native ใน [**แผนงาน**][roadmap]

[roadmap]: https://github.com/facebook/react-native/wiki/Roadmap

### โจทย์สำหรับมือใหม่

เรามีรายการ [โจทย์สำหรับมือใหม่][gfi] ที่เป็นบั๊กขอบเขตจำกัด เหมาะสำหรับเริ่มต้น เก็บประสบการณ์ และทำความคุ้นเคยกับกระบวนการร่วมพัฒนาของเรา

[gfi]: https://github.com/facebook/react-native/labels/good%20first%20issue

### การพูดคุย

การพูดคุยและข้อเสนอขนาดใหญ่จะมีการพูดคุยกันใน [**@react-native-community/discussions-and-proposals**][repo-meta]

[repo-meta]: https://github.com/react-native-community/discussions-and-proposals

## 📄 สัญญาอนุญาต

React Native อยู่ภายใต้สัญญาอนุญาต MIT ตามที่ระบุในไฟล์ [LICENSE][l]

[l]: https://github.com/facebook/react-native/blob/main/LICENSE

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---