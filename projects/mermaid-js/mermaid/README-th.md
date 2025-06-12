<p align="center">
<img src="https://raw.githubusercontent.com/mermaid-js/mermaid/develop/docs/public/favicon.svg" height="150">
</p>
<h1 align="center">
Mermaid
</h1>
<p align="center">
สร้างไดอะแกรมจากข้อความที่มีลักษณะคล้าย Markdown
<p>
<p align="center">
  <a href="https://www.npmjs.com/package/mermaid"><img src="https://img.shields.io/npm/v/mermaid?color=ff3670&label="></a>
<p>

<p align="center">
<a href="https://mermaid.live/"><b>Live Editor!</b></a>
</p>
<p align="center">
 <a href="https://mermaid.js.org">📖 เอกสารประกอบ</a> | <a href="https://mermaid.js.org/intro/">🚀 เริ่มต้นใช้งาน</a> | <a href="https://www.jsdelivr.com/package/npm/mermaid">🌐 CDN</a> | <a href="https://discord.gg/sKeNQX4Wtj" title="Discord invite">🙌 เข้าร่วมกับเรา</a>
</p>
<p align="center">
<a href="./README.zh-CN.md">简体中文</a>
</p>
<p align="center">
ทดลอง Live Editor สำหรับเวอร์ชันในอนาคต: <a href="https://develop.git.mermaid.live/" title="ลองใช้ mermaid เวอร์ชันจาก develop branch">Develop</a> | <a href="https://next.git.mermaid.live/" title="ลองใช้ mermaid เวอร์ชันจาก next branch.">Next</a>
</p>

<br>
<br>

[![NPM](https://img.shields.io/npm/v/mermaid)](https://www.npmjs.com/package/mermaid)
[![Build CI Status](https://github.com/mermaid-js/mermaid/actions/workflows/build.yml/badge.svg)](https://github.com/mermaid-js/mermaid/actions/workflows/build.yml)
[![npm minified gzipped bundle size](https://img.shields.io/bundlephobia/minzip/mermaid)](https://bundlephobia.com/package/mermaid)
[![Coverage Status](https://codecov.io/github/mermaid-js/mermaid/branch/develop/graph/badge.svg)](https://app.codecov.io/github/mermaid-js/mermaid/tree/develop)
[![CDN Status](https://img.shields.io/jsdelivr/npm/hm/mermaid)](https://www.jsdelivr.com/package/npm/mermaid)
[![NPM Downloads](https://img.shields.io/npm/dm/mermaid)](https://www.npmjs.com/package/mermaid)
[![Join our Discord!](https://img.shields.io/static/v1?message=join%20chat&color=9cf&logo=discord&label=discord)](https://discord.gg/sKeNQX4Wtj)
[![Twitter Follow](https://img.shields.io/badge/Social-mermaidjs__-blue?style=social&logo=X)](https://twitter.com/mermaidjs_)
[![Covered by Argos Visual Testing](https://argos-ci.com/badge.svg)](https://argos-ci.com?utm_source=mermaid&utm_campaign=oss)
[![OpenSSF Scorecard](https://api.securityscorecards.dev/projects/github.com/mermaid-js/mermaid/badge)](https://securityscorecards.dev/viewer/?uri=github.com/mermaid-js/mermaid)

<img src="./img/header.png" alt="" />

:trophy: **Mermaid ได้รับการเสนอชื่อและชนะรางวัล [JS Open Source Awards (2019)](https://osawards.com/javascript/2019) ในหมวด "The most exciting use of technology"!!!**

**ขอขอบคุณทุกคนที่มีส่วนร่วม ไม่ว่าจะเป็นผู้ส่ง pull request และผู้ที่ช่วยตอบคำถาม! 🙏**

<a href="https://mermaid.js.org/landing/"><img src="https://github.com/mermaid-js/mermaid/blob/master/docs/intro/img/book-banner-post-release.jpg" alt='แบนเนอร์หนังสือ "The Official Guide to Mermaid.js"'></a>

## สารบัญ

<details>
<summary>ขยายเนื้อหา</summary>

- [เกี่ยวกับ](#about)
- [ตัวอย่าง](#examples)
- [รุ่น](#release)
- [โปรเจกต์ที่เกี่ยวข้อง](#related-projects)
- [ผู้มีส่วนร่วม](#contributors---)
- [ความปลอดภัยและไดอะแกรมที่ปลอดภัย](#security-and-safe-diagrams)
- [รายงานช่องโหว่](#reporting-vulnerabilities)
- [คำขอบคุณ](#appreciation)

</details>

## เกี่ยวกับ

<!-- <Main description>   -->

Mermaid เป็นเครื่องมือสำหรับสร้างไดอะแกรมและกราฟด้วย JavaScript โดยใช้ข้อความที่มีโครงสร้างคล้าย Markdown และเรนเดอเรอร์เพื่อสร้างและแก้ไขไดอะแกรมที่ซับซ้อน จุดประสงค์หลักของ Mermaid คือช่วยให้เอกสารตามทันการพัฒนา

> Doc-Rot คือวงจรอุบาทว์ที่ Mermaid ช่วยแก้ไข

การสร้างไดอะแกรมและเอกสารใช้เวลาของนักพัฒนามากและมักจะล้าสมัยอย่างรวดเร็ว แต่หากไม่มีไดอะแกรมหรือเอกสารก็จะลดประสิทธิภาพการทำงานและทำให้องค์กรเรียนรู้ได้ช้าลง<br/>
Mermaid เข้ามาแก้ปัญหานี้ด้วยการช่วยให้ผู้ใช้สามารถสร้างไดอะแกรมที่แก้ไขได้ง่าย นอกจากนี้ยังสามารถนำไปใช้เป็นส่วนหนึ่งของสคริปต์ในการผลิต (และโค้ดอื่นๆ)<br/>
<br/>

Mermaid ช่วยให้แม้แต่ผู้ที่ไม่ใช่นักพัฒนาก็สามารถสร้างไดอะแกรมที่ละเอียดได้อย่างง่ายดายผ่าน [Mermaid Live Editor](https://mermaid.live/)<br/>
สำหรับวิดีโอสอนใช้งาน สามารถเยี่ยมชมหน้ารวม [Tutorials](https://mermaid.js.org/ecosystem/tutorials.html)
ใช้ Mermaid กับแอปพลิเคชันที่คุณชื่นชอบ ดูรายชื่อ [การเชื่อมต่อและการใช้งานของ Mermaid](https://mermaid.js.org/ecosystem/integrations-community.html)

คุณยังสามารถใช้ Mermaid ใน [GitHub](https://github.blog/2022-02-14-include-diagrams-markdown-files-mermaid/) รวมถึงแอปพลิเคชันยอดนิยมอื่น ๆ ของคุณได้เช่นกัน — ดูรายชื่อ [การเชื่อมต่อและการใช้งานของ Mermaid](https://mermaid.js.org/ecosystem/integrations-community.html)

หากต้องการข้อมูลเบื้องต้นเกี่ยวกับ Mermaid และการใช้งานพื้นฐาน โปรดดู [คู่มือสำหรับผู้เริ่มต้น](https://mermaid.js.org/intro/getting-started.html), [การใช้งาน](https://mermaid.js.org/config/usage.html) และ [Tutorials](https://mermaid.js.org/ecosystem/tutorials.html)

PR Visual Regression Testing ของเราได้รับการสนับสนุนโดย [Argos](https://argos-ci.com/?utm_source=mermaid&utm_campaign=oss) ด้วยแผน Open Source ที่เอื้อเฟื้อ ทำให้การตรวจสอบ PR ที่มีการเปลี่ยนแปลงด้านภาพเป็นเรื่องง่าย

[![Covered by Argos Visual Testing](https://argos-ci.com/badge-large.svg)](https://argos-ci.com?utm_source=mermaid&utm_campaign=oss)

ในการปล่อยเวอร์ชัน เราใช้การทดสอบ Visual Regression อย่างหนักโดยใช้ [applitools](https://applitools.com/) ซึ่งเป็นบริการที่ยอดเยี่ยมและใช้งานได้ง่ายสำหรับทดสอบของเรา

<a href="https://applitools.com/">
<svg width="170" height="32" viewBox="0 0 170 32" fill="none" xmlns="http://www.w3.org/2000/svg"><mask id="a" maskUnits="userSpaceOnUse" x="27" y="0" width="143" height="32"><path fill-rule="evenodd" clip-rule="evenodd" d="M27.732.227h141.391v31.19H27.733V.227z" fill="#fff"></path></mask><g mask="url(#a)"><path fill-rule="evenodd" clip-rule="evenodd" d="M153.851 22.562l1.971-3.298c1.291 1.219 3.837 2.402 5.988 2.402 1.971 0 2.903-.753 2.903-1.829 0-2.832-10.253-.502-10.253-7.313 0-2.904 2.51-5.45 7.099-5.45 2.904 0 5.234 1.004 6.955 2.367l-1.829 3.226c-1.039-1.075-3.011-2.008-5.126-2.008-1.65 0-2.725.717-2.725 1.685 0 2.546 10.289.395 10.289 7.386 0 3.19-2.724 5.52-7.528 5.52-3.012 0-5.916-1.003-7.744-2.688zm-5.7 2.259h4.553V.908h-4.553v23.913zm-6.273-8.676c0-2.689-1.578-5.02-4.446-5.02-2.832 0-4.409 2.331-4.409 5.02 0 2.724 1.577 5.055 4.409 5.055 2.868 0 4.446-2.33 4.446-5.055zm-13.588 0c0-4.912 3.442-9.07 9.142-9.07 5.736 0 9.178 4.158 9.178 9.07 0 4.911-3.442 9.106-9.178 9.106-5.7 0-9.142-4.195-9.142-9.106zm-5.628 0c0-2.689-1.577-5.02-4.445-5.02-2.832 0-4.41 2.331-4.41 5.02 0 2.724 1.578 5.055 4.41 5.055 2.868 0 4.445-2.33 4.445-5.055zm-13.587 0c0-4.912 3.441-9.07 9.142-9.07 5.736 0 9.178 4.158 9.178 9.07 0 4.911-3.442 9.106-9.178 9.106-5.701 0-9.142-4.195-9.142-9.106zm-8.425 4.338v-8.999h-2.868v-3.98h2.868V2.773h4.553v4.733h3.514v3.979h-3.514v7.78c0 1.111.574 1.936 1.578 1.936.681 0 1.326-.251 1.577-.538l.968 3.478c-.681.609-1.9 1.11-3.8 1.11-3.191 0-4.876-1.648-4.876-4.767zm-8.962 4.338h4.553V7.505h-4.553V24.82zm-.43-21.905a2.685 2.685 0 012.688-2.69c1.506 0 2.725 1.184 2.725 2.69a2.724 2.724 0 01-2.725 2.724c-1.47 0-2.688-1.219-2.688-2.724zM84.482 24.82h4.553V.908h-4.553v23.913zm-6.165-8.676c0-2.976-1.793-5.02-4.41-5.02-1.47 0-3.119.825-3.908 1.973v6.094c.753 1.111 2.438 2.008 3.908 2.008 2.617 0 4.41-2.044 4.41-5.055zm-8.318 6.453v8.82h-4.553V7.504H70v2.187c1.327-1.685 3.227-2.618 5.342-2.618 4.446 0 7.672 3.299 7.672 9.07 0 5.773-3.226 9.107-7.672 9.107-2.043 0-3.907-.86-5.342-2.653zm-10.718-6.453c0-2.976-1.793-5.02-4.41-5.02-1.47 0-3.119.825-3.908 1.973v6.094c.753 1.111 2.438 2.008 3.908 2.008 2.617 0 4.41-2.044 4.41-5.055zm-8.318 6.453v8.82H46.41V7.504h4.553v2.187c1.327-1.685 3.227-2.618 5.342-2.618 4.446 0 7.672 3.299 7.672 9.07 0 5.773-3.226 9.107-7.672 9.107-2.043 0-3.908-.86-5.342-2.653zm-11.758-1.936V18.51c-.753-1.004-2.187-1.542-3.657-1.542-1.793 0-3.263.968-3.263 2.617 0 1.65 1.47 2.582 3.263 2.582 1.47 0 2.904-.502 3.657-1.506zm0 4.159v-1.829c-1.183 1.434-3.227 2.259-5.485 2.259-2.761 0-5.988-1.864-5.988-5.736 0-4.087 3.227-5.593 5.988-5.593 2.33 0 4.337.753 5.485 2.115V13.85c0-1.756-1.506-2.904-3.8-2.904-1.829 0-3.55.717-4.984 2.044L28.63 9.8c2.115-1.901 4.84-2.726 7.564-2.726 3.98 0 7.6 1.578 7.6 6.561v11.186h-4.588z" fill="#00A298"></path></g><path fill-rule="evenodd" clip-rule="evenodd" d="M14.934 16.177c0 1.287-.136 2.541-.391 3.752-1.666-1.039-3.87-2.288-6.777-3.752 2.907-1.465 5.11-2.714 6.777-3.753.255 1.211.39 2.466.39 3.753m4.6-7.666V4.486a78.064 78.064 0 01-4.336 3.567c-1.551-2.367-3.533-4.038-6.14-5.207C11.1 4.658 12.504 6.7 13.564 9.262 5.35 15.155 0 16.177 0 16.177s5.35 1.021 13.564 6.915c-1.06 2.563-2.463 4.603-4.507 6.415 2.607-1.169 4.589-2.84 6.14-5.207a77.978 77.978 0 014.336 3.568v-4.025s-.492-.82-2.846-2.492c.6-1.611.93-3.354.93-5.174a14.8 14.8 0 00-.93-5.174c2.354-1.673 2.846-2.492 2.846-2.492" fill="#00A298"></path></svg>
</a>

<!-- </Main description> -->

## Mermaid AI Bot

[Mermaid](https://codeparrot.ai/oracle?owner=mermaid-js&repo=mermaid) Bot จะช่วยให้คุณเข้าใจรีโพซิทอรีนี้ได้ดียิ่งขึ้น คุณสามารถสอบถามตัวอย่างโค้ด วิธีติดตั้ง การแก้ไขปัญหา และอื่น ๆ อีกมากมาย

## ตัวอย่าง

**ต่อไปนี้คือตัวอย่างบางส่วนของไดอะแกรม กราฟ และชาร์ตที่สามารถสร้างด้วย Mermaid คลิกที่นี่เพื่อข้ามไปดู [ไวยากรณ์ข้อความ](https://mermaid.js.org/intro/syntax-reference.html)**

<!-- <Flowchart> -->

### ไดอะแกรมลำดับขั้น [<a href="https://mermaid.js.org/syntax/flowchart.html">docs</a> - <a href="https://mermaid.live/edit#pako:eNpNkMtqwzAQRX9FzKqFJK7t1km8KDQP6KJQSLOLvZhIY1tgS0GWmgbb_165IaFaiXvOFTPqgGtBkEJR6zOv0Fj2scsU8-ft8I5G5Gw6fe339GN7tnrYaafE45WvRsLW3Ya4bKVWwzVe_xU-FfVsc9hR62rLwvw_2591z7Y3FuUwgYZMg1L4ObrRzMBW1FAGqb8KKtCLGWRq8Ko7CbS0FdJqA2mBdUsTQGf110VxSK1xdJM2EkuDzd2qNQrypQ7s5TQuXcrW-ie5VoUsx9yZ2seVtac2DYIRz0ppK3eccd0ErRTjD1XfyyRIomSBUUzJPMaXOBb8GC4XRfQcFmL-FEYIwzD8AggvcHE">live editor</a>]

```
flowchart LR

A[Hard] -->|Text| B(Round)
B --> C{Decision}
C -->|One| D[Result 1]
C -->|Two| E[Result 2]
```

```mermaid
flowchart LR

A[Hard] -->|Text| B(Round)
B --> C{Decision}
C -->|One| D[Result 1]
C -->|Two| E[Result 2]
```

### ไดอะแกรมลำดับเหตุการณ์ [<a href="https://mermaid.js.org/syntax/sequenceDiagram.html">docs</a> - <a href="https://mermaid.live/edit#pako:eNo9kMluwjAQhl_F-AykQMuSA1WrbuLQQ3v1ZbAnsVXHkzrjVhHi3etQwKfRv4w-z0FqMihL2eF3wqDxyUEdoVHhwTuNk-12RzaU4g29JzHMY2HpV0BE0VO6V8ETtdkGz1Zb1F8qiPyG5LX84mrLAmpwoWNh-5a0pWCiAxUwGBXeiVHEU4oq8V_6AHYUwAu2lLLTjVQ4bc1rT2yleI0IfJG320faZ9ABbk-Jz3hZnFxBduR9L2oiM5Jj2WBswJn8-cMArSRbbFDJMo8GK0ielVThmKOpNcD4bBxTlGUFvsOxhMT02QctS44JL6HzAS-iJzCYOwfJfTscunYd542aQuXqQU_RZ9kyt11ZFIM9rR3btJ9qaorOGQuR7c9mWSznyzXMF7hcLeBusTB6P9usq_ntrDKrm9kc5PF4_AMJE56Z">live editor</a>]

```
sequenceDiagram
Alice->>John: Hello John, how are you?
loop HealthCheck
    John->>John: Fight against hypochondria
end
Note right of John: Rational thoughts!
John-->>Alice: Great!
John->>Bob: How about you?
Bob-->>John: Jolly good!
```

```mermaid
sequenceDiagram
Alice->>John: Hello John, how are you?
loop HealthCheck
    John->>John: Fight against hypochondria
end
Note right of John: Rational thoughts!
John-->>Alice: Great!
John->>Bob: How about you?
Bob-->>John: Jolly good!
```

### แผนภูมิแกนต์ [<a href="https://mermaid.js.org/syntax/gantt.html">docs</a> - <a href="https://mermaid.live/edit#pako:eNp90cGOgyAQBuBXIZxtFbG29bbZ3fsmvXKZylhJEAyOTZrGd1_sto3xsHMBhu-HBO689hp5xS_giJQbsCbjHTv9jcp9-q63SKhZpb3DhMXSOIiE5ZkoNpnYZGXynh6U-4jBK7JnVfBYJo9QvgjtEya1cj8QwFq0TMz4lZqxTBg0hOF5m1jifI2Lf7Bc490CyxUu1rhc4GLGPOEdhg6Mjq92V44xxanFDhWv4lRjA6MlxZWbIh17DYTf2pAPvGrADphwGMmfbq7mFYURX-jLwCVA91bWg8YYunO69Y8vMgPFI2vvGnOZ-2Owsd0S9UOVpvP29mKoHc_b2nfpYHQLgdrrsUzLvDxALrHcS9hJqeuzOB6avBCN3mciBz5N0y_wxZ0J">live editor</a>]

```
gantt
    section Section
    Completed :done,    des1, 2014-01-06,2014-01-08
    Active        :active,  des2, 2014-01-07, 3d
    Parallel 1   :         des3, after des1, 1d
    Parallel 2   :         des4, after des1, 1d
    Parallel 3   :         des5, after des3, 1d
    Parallel 4   :         des6, after des4, 1d
```

```mermaid
gantt
    section Section
    Completed :done,    des1, 2014-01-06,2014-01-08
    Active        :active,  des2, 2014-01-07, 3d
    Parallel 1   :         des3, after des1, 1d
    Parallel 2   :         des4, after des1, 1d
    Parallel 3   :         des5, after des3, 1d
    Parallel 4   :         des6, after des4, 1d
```

### ไดอะแกรมคลาส [<a href="https://mermaid.js.org/syntax/classDiagram.html">docs</a> - <a href="https://mermaid.live/edit#pako:eNpdkTFPwzAQhf-K5QlQ2zQJJG1UBaGWDYmBgYEwXO1LYuTEwXYqlZL_jt02asXm--690zvfgTLFkWaUSTBmI6DS0BTt2lfzkKx-p1PytEO9f1FtdaQkI2ulZNGuVqK1qEtgmOfk7BitSzKdOhg59XuNGgk0RDxed-_IOr6uf8cZ6UhTZ8bvHqS5ub1mr9svZPbjk6DEBlu7AQuXyBkx4gcvDk9cUMJq0XT_YaW0kNK5j-ufAoRzcihaQvLcoN4Jv50vvVxw_xrnD3RCG9QNCO4-8OgpqK1dpoJm7smxhF7agp6kfcfB4jMXVmmalW4tnFDorXrbt4xmVvc4is53GKFUwNF5DtTuO3-sShjrJjLVlqLyvNfS4drazmRB4NuzSti6386YagIjeA3a1rtlEiRRsoAoxiSN4SGOOduGy0UZ3YclT-dhBHQYhj8dc6_I">live editor</a>]

```
classDiagram
Class01 <|-- AveryLongClass : Cool
<<Interface>> Class01
Class09 --> C2 : Where am I?
Class09 --* C3
Class09 --|> Class07
Class07 : equals()
Class07 : Object[] elementData
Class01 : size()
Class01 : int chimp
Class01 : int gorilla
class Class10 {
  <<service>>
  int id
  size()
}

```

```mermaid
classDiagram
Class01 <|-- AveryLongClass : Cool
<<Interface>> Class01
Class09 --> C2 : Where am I?
Class09 --* C3
Class09 --|> Class07
Class07 : equals()
Class07 : Object[] elementData
Class01 : size()
Class01 : int chimp
Class01 : int gorilla
class Class10 {
  <<service>>
  int id
  size()
}

```

### ผังสถานะ [<a href="https://mermaid.js.org/syntax/stateDiagram.html">เอกสาร</a> - <a href="https://mermaid.live/edit#pako:eNpdkEFvgzAMhf8K8nEqpYSNthx22Xbcqcexg0sCiZQQlDhIFeK_L8A6TfXp6fOz9ewJGssFVOAJSbwr7ByadGR1n8T6evpO0vQ1uZDSekOrXGFsPqJPO6q-2-imH8f_0TeHXm50lfelsAMjnEHFY6xpMdRAUhhRQxUlFy0GTTXU_RytYeAx-AdXZB1ULWovdoCB7OXWN1CRC-Ju-r3uz6UtchGHJqDbsPygU57iysb2reoWHpyOWBINvsqypb3vFMlw3TfWZF5xiY7keC6zkpUnZIUojwW-FAVvrvn51LLnvOXHQ84Q5nn-AVtLcwk">live editor</a>]

```
stateDiagram-v2
[*] --> Still
Still --> [*]
Still --> Moving
Moving --> Still
Moving --> Crash
Crash --> [*]
```

```mermaid
stateDiagram-v2
[*] --> Still
Still --> [*]
Still --> Moving
Moving --> Still
Moving --> Crash
Crash --> [*]
```

### แผนภูมิวงกลม [<a href="https://mermaid.js.org/syntax/pie.html">เอกสาร</a> - <a href="https://mermaid.live/edit#pako:eNo9jsFugzAMhl8F-VzBgEEh13Uv0F1zcYkTIpEEBadShXj3BU3dzf_n77e8wxQUgYDVkvQSbsFsEgpRtEN_5i_kvzx05XiC-xvUHVzAUXRoVe7v0heFBJ7JkQSRR0Ua08ISpD-ymlaFTN_KcoggNC4bXQATh5-Xn0BwTPSWbhZNRPdvLQEV5dIO_FrPZ43dOJ-cgtfWnDzFJeOZed1EVZ3r0lie06Ocgqs2q2aMPD_HvuqbfsCmpf7aYte2anrU46Cbz1qr60fdIBzH8QvW9lkl">live editor</a>]

```
pie
"สุนัข" : 386
"แมว" : 85.9
"หนู" : 15
```

```mermaid
pie
"สุนัข" : 386
"แมว" : 85.9
"หนู" : 15
```

### กราฟ Git [ทดลอง - <a href="https://mermaid.live/edit#pako:eNqNkMFugzAMhl8F-VyVAR1tOW_aA-zKxSSGRCMJCk6lCvHuNZPKZdM0n-zf3_8r8QIqaIIGMqnB8kfEybQ--y4VnLP8-9RF9Mpkmm40hmlnDKmvkPiH_kfS7nFo_VN0FAf6XwocQGgxa_nGsm1bYEOOWmik1dRjGrmF1q-Cpkkj07u2HCI0PY4zHQATh8-7V9BwTPSE3iwOEd1OjQE1iWkBvk_bzQY7s0Sq4Hs7bHqKo8iGeZqbPN_WR7mpSd1RHpvPVhuMbG7XOq_L-oJlRfW5wteq0qorrpe-PBW9Pr8UJcK6rg-BLYPQ">live editor</a>]

```
gitGraph
  commit
  commit
  branch develop
  checkout develop
  commit
  commit
  checkout main
  merge develop
  commit
  commit
```

```mermaid
gitGraph
  commit
  commit
  branch develop
  checkout develop
  commit
  commit
  checkout main
  merge develop
  commit
  commit
```

### แผนภูมิแท่ง (ใช้แกนต์) [<a href="https://mermaid.js.org/syntax/gantt.html">เอกสาร</a> - <a href="https://mermaid.live/edit#pako:eNptkU1vhCAQhv8KIenNugiI4rkf6bmXpvEyFVxJFDYyNt1u9r8X63Z7WQ9m5pknLzieaBeMpQ3dg0dsPUkPOhwteXZIXmJcbCT3xMAxkuh8Z8kIEclyMIB209fqKcwTICFvG4IvFy_oLrZ-g9F26ILfQgvNFN94VaRXQ1iWqpumZBcu1J8p1E1TXDx59eQNr5LyEqjJn6hv5QnGNlxevZJmdLLpy5xJSzut45biYCfb0iaVxvawjNjS1p-TCguG16PvaIPzYjO67e3BwX6GiTY9jPFKH43DMF_hGMDY1J4oHg-_f8hFTJFd8L3br3yZx4QHxENsdrt1nO8dDstH3oVpF50ZYMbhU6ud4qoGLqyqBJRCmO6j0HXPZdGbihUc6Pmc0QP49xD-b5X69ZQv2gjO81IwzWqhC1lKrjJ6pA3nVS7SMiVjrKirWlYp5fs3osgrWeo00lorLWvOzz8JVbXm">live editor</a>]

```
gantt
    title Git Issues - จำนวนวันนับจากอัปเดตล่าสุด
    dateFormat  X
    axisFormat %s

    section Issue19062
    71   : 0, 71
    section Issue19401
    36   : 0, 36
    section Issue193
    34   : 0, 34
    section Issue7441
    9    : 0, 9
    section Issue1300
    5    : 0, 5
```

```mermaid
gantt
    title Git Issues - จำนวนวันนับจากอัปเดตล่าสุด
    dateFormat  X
    axisFormat %s

    section Issue19062
    71   : 0, 71
    section Issue19401
    36   : 0, 36
    section Issue193
    34   : 0, 34
    section Issue7441
    9    : 0, 9
    section Issue1300
    5    : 0, 5
```

### ผัง User Journey [<a href="https://mermaid.js.org/syntax/userJourney.html">เอกสาร</a> - <a href="https://mermaid.live/edit#pako:eNplkMFuwjAQRH9l5TMiTVIC-FqqnjhxzWWJN4khsSN7XRSh_HsdKBVt97R6Mzsj-yoqq0hIAXCywRkaSwNxWHNHsB_hYt1ZmwYUfiueKtbWwIcFtjf5zgH2eCZgQgkrCXt64GgMg2fUzkvIn5Xd_V5COtMFvCH_62ht_5yk7MU8sn61HDTfxD8VYiF6cj1qFd94nWkpuKWYKWRcFdUYOi5FaaZoDYNCpnel2Toha-w8LQQGtofRVEKyC_Qw7TQ2DvsfV2dRUTy6Ch6H-UMb7TlGVtbUupl5cF3ELfPgZZLM8rLR3IbjsrJ94rVq0XH7uS2SIis2mOVUrHNc5bmqjul2U2evaa3WL2mGYpqmL2BGiho">live editor</a>]

```
  journey
    title วันทำงานของฉัน
    section ไปทำงาน
      ชงชา: 5: ฉัน
      ขึ้นไปชั้นบน: 3: ฉัน
      ทำงาน: 1: ฉัน, แมว
    section กลับบ้าน
      ลงไปชั้นล่าง: 5: ฉัน
      นั่งพัก: 3: ฉัน
```

```mermaid
  journey
    title วันทำงานของฉัน
    section ไปทำงาน
      ชงชา: 5: ฉัน
      ขึ้นไปชั้นบน: 3: ฉัน
      ทำงาน: 1: ฉัน, แมว
    section กลับบ้าน
      ลงไปชั้นล่าง: 5: ฉัน
      นั่งพัก: 3: ฉัน
```

### ผัง C4 [<a href="https://mermaid.js.org/syntax/c4.html">เอกสาร</a>]

```
C4Context
title ผัง System Context สำหรับระบบธนาคารอินเทอร์เน็ต

Person(customerA, "ลูกค้าธนาคาร A", "ลูกค้าของธนาคาร ที่มีบัญชีธนาคารส่วนตัว")
Person(customerB, "ลูกค้าธนาคาร B")
Person_Ext(customerC, "ลูกค้าธนาคาร C")
System(SystemAA, "ระบบธนาคารอินเทอร์เน็ต", "อนุญาตให้ลูกค้าดูข้อมูลเกี่ยวกับบัญชีธนาคารของตน และชำระเงินได้")

Person(customerD, "ลูกค้าธนาคาร D", "ลูกค้าของธนาคาร <br/> ที่มีบัญชีธนาคารส่วนตัว")

Enterprise_Boundary(b1, "ขอบเขตธนาคาร") {

  SystemDb_Ext(SystemE, "ระบบเมนเฟรมธนาคาร", "จัดเก็บข้อมูลหลักทั้งหมดของธนาคารเกี่ยวกับลูกค้า, บัญชี, ธุรกรรม ฯลฯ")

  System_Boundary(b2, "ขอบเขตธนาคาร2") {
    System(SystemA, "ระบบธนาคาร A")
    System(SystemB, "ระบบธนาคาร B", "ระบบของธนาคารที่มีบัญชีธนาคารส่วนตัว")
  }

  System_Ext(SystemC, "ระบบอีเมล", "ระบบ Microsoft Exchange อีเมลภายใน")
  SystemDb(SystemD, "ฐานข้อมูลระบบธนาคาร D", "ระบบของธนาคารที่มีบัญชีธนาคารส่วนตัว")

  Boundary(b3, "ขอบเขตธนาคาร3", "boundary") {
    SystemQueue(SystemF, "คิวระบบธนาคาร F", "ระบบของธนาคารที่มีบัญชีธนาคารส่วนตัว")
    SystemQueue_Ext(SystemG, "คิวระบบธนาคาร G", "ระบบของธนาคารที่มีบัญชีธนาคารส่วนตัว")
  }
}

BiRel(customerA, SystemAA, "ใช้งาน")
BiRel(SystemAA, SystemE, "ใช้งาน")
Rel(SystemAA, SystemC, "ส่งอีเมล", "SMTP")
Rel(SystemC, customerA, "ส่งอีเมลถึง")
```

```mermaid
C4Context
title ผัง System Context สำหรับระบบธนาคารอินเทอร์เน็ต

Person(customerA, "ลูกค้าธนาคาร A", "ลูกค้าของธนาคาร ที่มีบัญชีธนาคารส่วนตัว")
Person(customerB, "ลูกค้าธนาคาร B")
Person_Ext(customerC, "ลูกค้าธนาคาร C")
System(SystemAA, "ระบบธนาคารอินเทอร์เน็ต", "อนุญาตให้ลูกค้าดูข้อมูลเกี่ยวกับบัญชีธนาคารของตน และชำระเงินได้")

Person(customerD, "ลูกค้าธนาคาร D", "ลูกค้าของธนาคาร <br/> ที่มีบัญชีธนาคารส่วนตัว")

Enterprise_Boundary(b1, "ขอบเขตธนาคาร") {
```markdown
  SystemDb_Ext(SystemE, "Mainframe Banking System", "จัดเก็บข้อมูลหลักของธนาคารทั้งหมดเกี่ยวกับลูกค้า บัญชีธุรกรรม ฯลฯ")

  System_Boundary(b2, "BankBoundary2") {
    System(SystemA, "Banking System A")
    System(SystemB, "Banking System B", "ระบบของธนาคารที่มีบัญชีธนาคารส่วนบุคคล")
  }

  System_Ext(SystemC, "E-mail system", "ระบบอีเมลภายใน Microsoft Exchange")
  SystemDb(SystemD, "Banking System D Database", "ระบบของธนาคารที่มีบัญชีธนาคารส่วนบุคคล")

  Boundary(b3, "BankBoundary3", "boundary") {
    SystemQueue(SystemF, "Banking System F Queue", "ระบบของธนาคารที่มีบัญชีธนาคารส่วนบุคคล")
    SystemQueue_Ext(SystemG, "Banking System G Queue", "ระบบของธนาคารที่มีบัญชีธนาคารส่วนบุคคล")
  }
}

BiRel(customerA, SystemAA, "ใช้งาน")
BiRel(SystemAA, SystemE, "ใช้งาน")
Rel(SystemAA, SystemC, "ส่งอีเมล", "SMTP")
Rel(SystemC, customerA, "ส่งอีเมลถึง")
```

## การเผยแพร่

สำหรับผู้ที่มีสิทธิ์ในการดำเนินการ:

อัปเดตหมายเลขเวอร์ชันใน `package.json`

```sh
npm publish
```

คำสั่งด้านบนจะสร้างไฟล์ลงในโฟลเดอร์ `dist` และเผยแพร่ไปที่ <https://www.npmjs.com>

## โครงการที่เกี่ยวข้อง

- [Command Line Interface](https://github.com/mermaid-js/mermaid-cli)
- [Live Editor](https://github.com/mermaid-js/mermaid-live-editor)
- [HTTP Server](https://github.com/TomWright/mermaid-server)

## ผู้ร่วมพัฒนา [![Good first issue](https://img.shields.io/github/labels/mermaid-js/mermaid/Good%20first%20issue%21)](https://github.com/mermaid-js/mermaid/issues?q=is%3Aissue+is%3Aopen+label%3A%22Good+first+issue%21%22) [![Contributors](https://img.shields.io/github/contributors/mermaid-js/mermaid)](https://github.com/mermaid-js/mermaid/graphs/contributors) [![Commits](https://img.shields.io/github/commit-activity/m/mermaid-js/mermaid)](https://github.com/mermaid-js/mermaid/graphs/contributors)

Mermaid เป็นชุมชนที่เติบโตอย่างต่อเนื่องและยินดีต้อนรับผู้ร่วมใหม่อยู่เสมอ มีหลายวิธีในการช่วยเหลือและเรากำลังมองหาผู้ช่วยเพิ่มเติมอยู่ตลอด! ดูที่ [issue นี้](https://github.com/mermaid-js/mermaid/issues/866) หากคุณต้องการทราบว่าจะเริ่มช่วยอย่างไร

ข้อมูลรายละเอียดเกี่ยวกับวิธีการร่วมพัฒนาสามารถดูได้ที่ [คู่มือการร่วมพัฒนา](https://mermaid.js.org/community/contributing.html)

## ความปลอดภัยและไดอะแกรมที่ปลอดภัย

สำหรับเว็บไซต์สาธารณะ การดึงข้อความจากผู้ใช้บนอินเทอร์เน็ตและจัดเก็บเนื้อหานั้นเพื่อนำเสนอในเบราว์เซอร์ภายหลังอาจมีความเสี่ยง สาเหตุคือเนื้อหาจากผู้ใช้อาจมีสคริปต์ที่เป็นอันตรายแฝงอยู่ซึ่งจะทำงานเมื่อแสดงผลข้อมูลนั้น สำหรับ Mermaid นี่เป็นความเสี่ยงโดยเฉพาะอย่างยิ่งเพราะไดอะแกรม Mermaid มีอักขระจำนวนมากที่ใช้ใน html ซึ่งทำให้การกรองมาตรฐานไม่สามารถใช้งานได้เพราะจะทำให้ไดอะแกรมเสีย เรายังคงพยายามกรองโค้ดที่เข้ามาและปรับปรุงกระบวนการอย่างต่อเนื่อง แต่ยากที่จะรับประกันว่าไม่มีช่องโหว่เลย

เพื่อความปลอดภัยระดับสูงขึ้นสำหรับเว็บไซต์ที่มีผู้ใช้ภายนอก เรายินดีที่จะแนะนำระดับความปลอดภัยใหม่ ซึ่งไดอะแกรมจะถูกเรนเดอร์ใน sandboxed iframe เพื่อป้องกันไม่ให้ javascript ในโค้ดถูกเรียกใช้ นี่ถือเป็นก้าวสำคัญเพื่อความปลอดภัยที่ดียิ่งขึ้น

_อย่างไรก็ตาม คุณไม่สามารถมีทั้งสองอย่างพร้อมกันได้ ในกรณีนี้หมายถึงฟังก์ชันแบบโต้ตอบบางอย่างจะถูกบล็อกพร้อมกับโค้ดที่อาจเป็นอันตราย_

## รายงานช่องโหว่

หากต้องการรายงานช่องโหว่ โปรดส่งอีเมลไปที่ <security@mermaid.live> พร้อมรายละเอียดปัญหา ขั้นตอนที่คุณดำเนินการเพื่อสร้างปัญหา เวอร์ชันที่ได้รับผลกระทบ และถ้าทราบ แนวทางแก้ไขปัญหา

## คำขอบคุณ

ข้อความจาก Knut Sveidqvist:

> _ขอขอบคุณโครงการ [d3](https://d3js.org/) และ [dagre-d3](https://github.com/cpettitt/dagre-d3) สำหรับการให้บริการไลบรารีจัดรูปแบบและวาดกราฟิก!_
>
> _ขอบคุณโครงการ [js-sequence-diagram](https://bramp.github.io/js-sequence-diagrams) สำหรับการใช้งานไวยากรณ์สำหรับไดอะแกรมลำดับ ขอบคุณ Jessica Peter สำหรับแรงบันดาลใจและจุดเริ่มต้นของการเรนเดอร์ gantt_
>
> _ขอบคุณ [Tyler Long](https://github.com/tylerlong) ซึ่งเป็นผู้ร่วมงานมาตั้งแต่เดือนเมษายน 2017_
>
> _ขอบคุณผู้ร่วมพัฒนาที่เพิ่มขึ้นอย่างต่อเนื่องใน [contributors](https://github.com/mermaid-js/mermaid/graphs/contributors) ที่ทำให้โครงการเดินทางมาถึงจุดนี้!_

---

_Mermaid ถูกสร้างขึ้นโดย Knut Sveidqvist เพื่อให้งานเอกสารง่ายขึ้น_
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-12

---