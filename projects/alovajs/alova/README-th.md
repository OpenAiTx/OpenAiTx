<p align="center">
<img width="200px" src="https://alova.js.org/img/logo-text-vertical.svg" />
</p>

<p align="center"><b>เครื่องมือขอข้อมูลรุ่นใหม่ที่ออกแบบมาเพื่อปรับปรุงการทำงานให้เป็นระบบ<br />เพิ่มประสิทธิภาพในการใช้งาน API ของคุณได้อย่างมากและประหยัดพลังสมอง เพียงขั้นตอนเดียว</b></p>

<p align="center">English | <a href="./README.zh-CN.md">Chinese</a></p>

[![npm](https://img.shields.io/npm/v/alova)](https://www.npmjs.com/package/alova)
[![build](https://github.com/alovajs/alova/actions/workflows/release.yml/badge.svg?branch=main)](https://github.com/alovajs/alova/actions/workflows/release.yml)
[![coverage status](https://coveralls.io/repos/github/alovajs/alova/badge.svg?branch=main)](https://coveralls.io/github/alovajs/alova?branch=main)
[![stars](https://img.shields.io/github/stars/alovajs/alova?style=social)](https://github.com/alovajs/alova)
[![discord](https://img.shields.io/badge/chat-Discord-515ff1)](https://discord.gg/S47QGJgkVb)
[![wechat](https://img.shields.io/badge/chat_with_CH-Wechat-07c160)](https://alova.js.org/img/wechat_qrcode.jpg)
[![tree shaking](https://badgen.net/bundlephobia/tree-shaking/alova)](https://bundlephobia.com/package/alova)
![typescript](https://badgen.net/badge/icon/typescript?icon=typescript&label)
![license](https://img.shields.io/badge/license-MIT-blue.svg)

## alova คืออะไร?

alova (อ่านว่า /əˈləʊva/) คือไลบรารีขอข้อมูลรุ่นใหม่ที่ช่วยให้คุณรวม API ได้ง่ายขึ้นอย่างมาก ลดขั้นตอนที่เคยยุ่งยากถึง 7 ขั้นตอน ให้เหลือเพียงแค่ 1 ขั้นตอน - เพียงเลือก API ของคุณแล้วเริ่มใช้งานได้ทันที

![](https://alova.js.org/img/overview_flow_en.png)

## คุณสมบัติ

- ใช้งานง่ายอย่างไม่น่าเชื่อ พร้อมเส้นโค้งการเรียนรู้ที่ต่ำมาก
- โซลูชัน OpenAPI ที่ทันสมัยกว่า - ไม่ต้องยุ่งยากกับการเขียนเอกสาร API ขั้นกลางอีกต่อไป
- เข้ากันได้กับเทคโนโลยีฝั่งไคลเอนต์และไลบรารีขอข้อมูล: `react/vue/svelte/solid/next/nuxt/sveltkit/solid-start/uniapp/taro/...` + `fetch/XMLHttpRequest/axios/...`
- เข้ากันได้กับเทคโนโลยีฝั่งเซิร์ฟเวอร์และไลบรารีขอข้อมูล: `nodejs/deno/bun/...` + `fetch/XMLHttpRequest/axios/...`
- กลยุทธ์ขอข้อมูลประสิทธิภาพสูงกว่า 15 แบบเพื่อรองรับสถานการณ์การขอข้อมูลที่ซับซ้อน ช่วยให้คุณพัฒนาแอปพลิเคชันได้อย่างมีประสิทธิภาพมากขึ้นและรวดเร็วยิ่งขึ้น

## ตัวอย่างสด

เยี่ยมชมที่ [ลิงก์](https://alova.js.org/examples) เพื่อดูตัวอย่าง

## มีความแตกต่างหรือไม่?

ไม่เหมือนกับไลบรารีอย่าง `@tanstack/react-request`, `swrjs`, และ `useRequest` จาก `ahooks` alova มีเป้าหมายเพื่อให้การขอข้อมูลง่ายที่สุดและรักษาการโต้ตอบข้อมูลให้มีประสิทธิภาพสูงสุด เราคำนึงถึงทั้งนักพัฒนาและผู้ใช้แอป สำหรับนักพัฒนา alova มอบประสบการณ์ผู้ใช้ที่ดีที่สุด และสำหรับผู้ใช้แอปก็สามารถเพลิดเพลินกับความลื่นไหลจากการโต้ตอบข้อมูลที่มีประสิทธิภาพสูงของ alova ได้เช่นกัน

> คุณสามารถดู [การเปรียบเทียบกับไลบรารีขอข้อมูลอื่น ๆ](https://alova.js.org/about/comparison) เพื่อศึกษาข้อแตกต่างของ alova เพิ่มเติม

## เอกสาร

เยี่ยมชม [เว็บไซต์ alova](https://alova.js.org) เพื่อดูข้อมูลเพิ่มเติม หรือ [ดูตัวอย่างเพื่อทดลองใช้งาน](https://alova.js.org/category/examples)

## เข้าร่วมชุมชน

- [ติดตามเราบน X](https://x.com/alovajs)

- [เข้าร่วม Discord](https://discord.gg/S47QGJgkVb)

- [เข้าร่วมกลุ่ม WeChat](https://alova.js.org/img/wechat_qrcode.jpg)

## เราต้องการการสนับสนุนจากคุณ

หากคุณชอบ alova เราขอขอบคุณอย่างยิ่งหากคุณจะให้ดาวที่มุมขวาบน เพื่อเป็นการยอมรับและให้กำลังใจในการทำงานของเรา

## ยินดีต้อนรับผู้ร่วมพัฒนา

เรารู้สึกเป็นเกียรติที่ได้รับความร่วมมืออย่างแข็งขันจากนักพัฒนาทั่วโลกใน Issues และ Discussions

เราหวังจะทำให้ alova เป็นโปรเจกต์ร่วมของทุกคนที่ต้องการมีส่วนร่วม ไม่ใช่แค่ทีม alova เท่านั้น เราสนับสนุนให้ทุกคนกลายเป็นผู้ร่วมพัฒนาชุมชน alova ด้วยทัศนคติที่เปิดกว้างและมีน้ำใจ แม้คุณจะเป็นนักพัฒนามือใหม่ หากไอเดียของคุณสอดคล้องกับแนวทางการพัฒนาของ alova ก็ขอเชิญเข้าร่วมอย่างเต็มที่

การมีส่วนร่วมที่มีประสิทธิภาพจะทำให้คุณได้รับชื่อเสียงในชุมชน alova ก่อนร่วมพัฒนา กรุณาอ่าน [คู่มือการมีส่วนร่วม](https://raw.githubusercontent.com/alovajs/alova/main/CONTRIBUTING.zh-CN.md) อย่างละเอียดเพื่อให้แน่ใจว่าการมีส่วนร่วมของคุณจะได้ผลลัพธ์

## บันทึกการเปลี่ยนแปลง

[ลิงก์](https://github.com/alovajs/alova/releases)

## ผู้ร่วมพัฒนา

<a href="https://github.com/alovajs/alova/graphs/contributors">
<img src="https://contrib.rocks/image?repo=alovajs/alova&max=30&columns=10" />
</a>

## สัญญาอนุญาต

[MIT](https://en.wikipedia.org/wiki/MIT_License)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---