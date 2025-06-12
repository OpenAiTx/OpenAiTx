<p align="center">
<img src="https://raw.githubusercontent.com/mermaid-js/mermaid/develop/docs/public/favicon.svg" height="150">
</p>
<h1 align="center">
Mermaid
</h1>
<p align="center">
从类似 Markdown 的文本生成图表。
<p>
<p align="center">
  <a href="https://www.npmjs.com/package/mermaid"><img src="https://img.shields.io/npm/v/mermaid?color=ff3670&label="></a>
<p>

<p align="center">
<a href="https://mermaid.live/"><b>在线编辑器！</b></a>
</p>
<p align="center">
 <a href="https://mermaid.js.org">📖 文档</a> | <a href="https://mermaid.js.org/intro/">🚀 快速开始</a> | <a href="https://www.jsdelivr.com/package/npm/mermaid">🌐 CDN</a> | <a href="https://discord.gg/sKeNQX4Wtj" title="Discord 邀请">🙌 加入我们</a>
</p>
<p align="center">
<a href="./README.zh-CN.md">简体中文</a>
</p>
<p align="center">
尝试体验未来版本的在线编辑器预览：<a href="https://develop.git.mermaid.live/" title="试用 develop 分支的 mermaid 版本。">Develop</a> | <a href="https://next.git.mermaid.live/" title="试用 next 分支的 mermaid 版本。">Next</a>
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

:trophy: **Mermaid 获得了 [JS 开源奖（2019）](https://osawards.com/javascript/2019)“最令人兴奋的技术应用”类别的提名并获奖！！！**

**感谢所有参与者，提交 PR 的朋友们，解答问题的朋友们！🙏**

<a href="https://mermaid.js.org/landing/"><img src="https://github.com/mermaid-js/mermaid/blob/master/docs/intro/img/book-banner-post-release.jpg" alt='《Mermaid.js 官方指南》图书横幅'></a>

## 目录

<details>
<summary>展开内容</summary>

- [关于](#about)
- [示例](#examples)
- [发布](#release)
- [相关项目](#related-projects)
- [贡献者](#contributors---)
- [安全与安全图表](#security-and-safe-diagrams)
- [漏洞报告](#reporting-vulnerabilities)
- [致谢](#appreciation)

</details>

## 关于

<!-- <Main description>   -->

Mermaid 是一个基于 JavaScript 的图表和流程图工具，它使用受 Markdown 启发的文本定义和渲染器来创建和修改复杂图表。Mermaid 的主要目的是帮助文档与开发保持同步。

> 文档腐烂（Doc-Rot）是 Mermaid 助力解决的 Catch-22 问题。

绘制图表和文档会消耗宝贵的开发者时间，而且很快会过时。
但如果没有图表或文档，会严重影响生产力并阻碍组织学习。<br/>
Mermaid 通过让用户轻松地修改图表来应对这一问题。它也可以集成到生产脚本（及其他代码片段）中。<br/>
<br/>

Mermaid 允许即使不是程序员的用户，也能通过 [Mermaid 在线编辑器](https://mermaid.live/) 轻松创建详细图表。<br/>
如需视频教程，请访问我们的 [教程](https://mermaid.js.org/ecosystem/tutorials.html) 页面。
你可以在你喜欢的应用程序中使用 Mermaid，详见 [Mermaid 的集成与应用列表](https://mermaid.js.org/ecosystem/integrations-community.html)。

你还可以在 [GitHub](https://github.blog/2022-02-14-include-diagrams-markdown-files-mermaid/) 以及许多其他你喜欢的应用中使用 Mermaid——详见 [Mermaid 的集成与应用列表](https://mermaid.js.org/ecosystem/integrations-community.html)。

如需更详细的 Mermaid 介绍及其基本用法，请参阅 [新手入门](https://mermaid.js.org/intro/getting-started.html)、[用法](https://mermaid.js.org/config/usage.html) 和 [教程](https://mermaid.js.org/ecosystem/tutorials.html)。

我们的 PR 可视化回归测试由 [Argos](https://argos-ci.com/?utm_source=mermaid&utm_campaign=oss) 提供支持，其慷慨的开源计划让带有可视化变更的 PR 审查变得轻松高效。

[![Covered by Argos Visual Testing](https://argos-ci.com/badge-large.svg)](https://argos-ci.com?utm_source=mermaid&utm_campaign=oss)

在我们的发布流程中，我们大量依赖基于 [applitools](https://applitools.com/) 的可视化回归测试。Applitools 是一项非常棒的服务，易于使用并能与我们的测试集成。

<a href="https://applitools.com/">
<svg width="170" height="32" viewBox="0 0 170 32" fill="none" xmlns="http://www.w3.org/2000/svg"><mask id="a" maskUnits="userSpaceOnUse" x="27" y="0" width="143" height="32"><path fill-rule="evenodd" clip-rule="evenodd" d="M27.732.227h141.391v31.19H27.733V.227z" fill="#fff"></path></mask><g mask="url(#a)"><path fill-rule="evenodd" clip-rule="evenodd" d="M153.851 22.562l1.971-3.298c1.291 1.219 3.837 2.402 5.988 2.402 1.971 0 2.903-.753 2.903-1.829 0-2.832-10.253-.502-10.253-7.313 0-2.904 2.51-5.45 7.099-5.45 2.904 0 5.234 1.004 6.955 2.367l-1.829 3.226c-1.039-1.075-3.011-2.008-5.126-2.008-1.65 0-2.725.717-2.725 1.685 0 2.546 10.289.395 10.289 7.386 0 3.19-2.724 5.52-7.528 5.52-3.012 0-5.916-1.003-7.744-2.688zm-5.7 2.259h4.553V.908h-4.553v23.913zm-6.273-8.676c0-2.689-1.578-5.02-4.446-5.02-2.832 0-4.409 2.331-4.409 5.02 0 2.724 1.577 5.055 4.409 5.055 2.868 0 4.446-2.33 4.446-5.055zm-13.588 0c0-4.912 3.442-9.07 9.142-9.07 5.736 0 9.178 4.158 9.178 9.07 0 4.911-3.442 9.106-9.178 9.106-5.7 0-9.142-4.195-9.142-9.106zm-5.628 0c0-2.689-1.577-5.02-4.445-5.02-2.832 0-4.41 2.331-4.41 5.02 0 2.724 1.578 5.055 4.41 5.055 2.868 0 4.445-2.33 4.445-5.055zm-13.587 0c0-4.912 3.441-9.07 9.142-9.07 5.736 0 9.178 4.158 9.178 9.07 0 4.911-3.442 9.106-9.178 9.106-5.701 0-9.142-4.195-9.142-9.106zm-8.425 4.338v-8.999h-2.868v-3.98h2.868V2.773h4.553v4.733h3.514v3.979h-3.514v7.78c0 1.111.574 1.936 1.578 1.936.681 0 1.326-.251 1.577-.538l.968 3.478c-.681.609-1.9 1.11-3.8 1.11-3.191 0-4.876-1.648-4.876-4.767zm-8.962 4.338h4.553V7.505h-4.553V24.82zm-.43-21.905a2.685 2.685 0 012.688-2.69c1.506 0 2.725 1.184 2.725 2.69a2.724 2.724 0 01-2.725 2.724c-1.47 0-2.688-1.219-2.688-2.724zM84.482 24.82h4.553V.908h-4.553v23.913zm-6.165-8.676c0-2.976-1.793-5.02-4.41-5.02-1.47 0-3.119.825-3.908 1.973v6.094c.753 1.111 2.438 2.008 3.908 2.008 2.617 0 4.41-2.044 4.41-5.055zm-8.318 6.453v8.82h-4.553V7.504H70v2.187c1.327-1.685 3.227-2.618 5.342-2.618 4.446 0 7.672 3.299 7.672 9.07 0 5.773-3.226 9.107-7.672 9.107-2.043 0-3.907-.86-5.342-2.653zm-10.718-6.453c0-2.976-1.793-5.02-4.41-5.02-1.47 0-3.119.825-3.908 1.973v6.094c.753 1.111 2.438 2.008 3.908 2.008 2.617 0 4.41-2.044 4.41-5.055zm-8.318 6.453v8.82H46.41V7.504h4.553v2.187c1.327-1.685 3.227-2.618 5.342-2.618 4.446 0 7.672 3.299 7.672 9.07 0 5.773-3.226 9.107-7.672 9.107-2.043 0-3.908-.86-5.342-2.653zm-11.758-1.936V18.51c-.753-1.004-2.187-1.542-3.657-1.542-1.793 0-3.263.968-3.263 2.617 0 1.65 1.47 2.582 3.263 2.582 1.47 0 2.904-.502 3.657-1.506zm0 4.159v-1.829c-1.183 1.434-3.227 2.259-5.485 2.259-2.761 0-5.988-1.864-5.988-5.736 0-4.087 3.227-5.593 5.988-5.593 2.33 0 4.337.753 5.485 2.115V13.85c0-1.756-1.506-2.904-3.8-2.904-1.829 0-3.55.717-4.984 2.044L28.63 9.8c2.115-1.901 4.84-2.726 7.564-2.726 3.98 0 7.6 1.578 7.6 6.561v11.186h-4.588z" fill="#00A298"></path></g><path fill-rule="evenodd" clip-rule="evenodd" d="M14.934 16.177c0 1.287-.136 2.541-.391 3.752-1.666-1.039-3.87-2.288-6.777-3.752 2.907-1.465 5.11-2.714 6.777-3.753.255 1.211.39 2.466.39 3.753m4.6-7.666V4.486a78.064 78.064 0 01-4.336 3.567c-1.551-2.367-3.533-4.038-6.14-5.207C11.1 4.658 12.504 6.7 13.564 9.262 5.35 15.155 0 16.177 0 16.177s5.35 1.021 13.564 6.915c-1.06 2.563-2.463 4.603-4.507 6.415 2.607-1.169 4.589-2.84 6.14-5.207a77.978 77.978 0 014.336 3.568v-4.025s-.492-.82-2.846-2.492c.6-1.611.93-3.354.93-5.174a14.8 14.8 0 00-.93-5.174c2.354-1.673 2.846-2.492 2.846-2.492" fill="#00A298"></path></svg>
</a>

<!-- </Main description> -->

## Mermaid AI 机器人

[Mermaid](https://codeparrot.ai/oracle?owner=mermaid-js&repo=mermaid) 机器人可以帮助你更好地理解本仓库。你可以咨询代码示例、安装指南、调试帮助等更多内容。

## 示例

**以下是 Mermaid 可制作的图表、流程图和关系图示例。点击这里直达 [文本语法](https://mermaid.js.org/intro/syntax-reference.html)。**

<!-- <Flowchart> -->

### 流程图 [<a href="https://mermaid.js.org/syntax/flowchart.html">文档</a> - <a href="https://mermaid.live/edit#pako:eNpNkMtqwzAQRX9FzKqFJK7t1km8KDQP6KJQSLOLvZhIY1tgS0GWmgbb_165IaFaiXvOFTPqgGtBkEJR6zOv0Fj2scsU8-ft8I5G5Gw6fe339GN7tnrYaafE45WvRsLW3Ya4bKVWwzVe_xU-FfVsc9hR62rLwvw_2591z7Y3FuUwgYZMg1L4ObrRzMBW1FAGqb8KKtCLGWRq8Ko7CbS0FdJqA2mBdUsTQGf110VxSK1xdJM2EkuDzd2qNQrypQ7s5TQuXcrW-ie5VoUsx9yZ2seVtac2DYIRz0ppK3eccd0ErRTjD1XfyyRIomSBUUzJPMaXOBb8GC4XRfQcFmL-FEYIwzD8AggvcHE">在线编辑器</a>]

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

### 时序图 [<a href="https://mermaid.js.org/syntax/sequenceDiagram.html">文档</a> - <a href="https://mermaid.live/edit#pako:eNo9kMluwjAQhl_F-AykQMuSA1WrbuLQQ3v1ZbAnsVXHkzrjVhHi3etQwKfRv4w-z0FqMihL2eF3wqDxyUEdoVHhwTuNk-12RzaU4g29JzHMY2HpV0BE0VO6V8ETtdkGz1Zb1F8qiPyG5LX84mrLAmpwoWNh-5a0pWCiAxUwGBXeiVHEU4oq8V_6AHYUwAu2lLLTjVQ4bc1rT2yleI0IfJG320faZ9ABbk-Jz3hZnFxBduR9L2oiM5Jj2WBswJn8-cMArSRbbFDJMo8GK0ielVThmKOpNcD4bBxTlGUFvsOxhMT02QctS44JL6HzAS-iJzCYOwfJfTscunYd542aQuXqQU_RZ9kyt11ZFIM9rR3btJ9qaorOGQuR7c9mWSznyzXMF7hcLeBusTB6P9usq_ntrDKrm9kc5PF4_AMJE56Z">在线编辑器</a>]

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

### 甘特图 [<a href="https://mermaid.js.org/syntax/gantt.html">文档</a> - <a href="https://mermaid.live/edit#pako:eNp90cGOgyAQBuBXIZxtFbG29bbZ3fsmvXKZylhJEAyOTZrGd1_sto3xsHMBhu-HBO689hp5xS_giJQbsCbjHTv9jcp9-q63SKhZpb3DhMXSOIiE5ZkoNpnYZGXynh6U-4jBK7JnVfBYJo9QvgjtEya1cj8QwFq0TMz4lZqxTBg0hOF5m1jifI2Lf7Bc490CyxUu1rhc4GLGPOEdhg6Mjq92V44xxanFDhWv4lRjA6MlxZWbIh17DYTf2pAPvGrADphwGMmfbq7mFYURX-jLwCVA91bWg8YYunO69Y8vMgPFI2vvGnOZ-2Owsd0S9UOVpvP29mKoHc_b2nfpYHQLgdrrsUzLvDxALrHcS9hJqeuzOB6avBCN3mciBz5N0y_wxZ0J">在线编辑器</a>]

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

### 类图 [<a href="https://mermaid.js.org/syntax/classDiagram.html">文档</a> - <a href="https://mermaid.live/edit#pako:eNpdkTFPwzAQhf-K5QlQ2zQJJG1UBaGWDYmBgYEwXO1LYuTEwXYqlZL_jt02asXm--690zvfgTLFkWaUSTBmI6DS0BTt2lfzkKx-p1PytEO9f1FtdaQkI2ulZNGuVqK1qEtgmOfk7BitSzKdOhg59XuNGgk0RDxed-_IOr6uf8cZ6UhTZ8bvHqS5ub1mr9svZPbjk6DEBlu7AQuXyBkx4gcvDk9cUMJq0XT_YaW0kNK5j-ufAoRzcihaQvLcoN4Jv50vvVxw_xrnD3RCG9QNCO4-8OgpqK1dpoJm7smxhF7agp6kfcfB4jMXVmmalW4tnFDorXrbt4xmVvc4is53GKFUwNF5DtTuO3-sShjrJjLVlqLyvNfS4drazmRB4NuzSti6386YagIjeA3a1rtlEiRRsoAoxiSN4SGOOduGy0UZ3YclT-dhBHQYhj8dc6_I">在线编辑器</a>]

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
Class01 <|-- AveryLongClass : 酷
<<接口>> Class01
Class09 --> C2 : 我在哪里？
Class09 --* C3
Class09 --|> Class07
Class07 : equals()
Class07 : Object[] elementData
Class01 : size()
Class01 : int chimp
Class01 : int gorilla
class Class10 {
  <<服务>>
  int id
  size()
}

```

### 状态图 [<a href="https://mermaid.js.org/syntax/stateDiagram.html">文档</a> - <a href="https://mermaid.live/edit#pako:eNpdkEFvgzAMhf8K8nEqpYSNthx22Xbcqcexg0sCiZQQlDhIFeK_L8A6TfXp6fOz9ewJGssFVOAJSbwr7ByadGR1n8T6evpO0vQ1uZDSekOrXGFsPqJPO6q-2-imH8f_0TeHXm50lfelsAMjnEHFY6xpMdRAUhhRQxUlFy0GTTXU_RytYeAx-AdXZB1ULWovdoCB7OXWN1CRC-Ju-r3uz6UtchGHJqDbsPygU57iysb2reoWHpyOWBINvsqypb3vFMlw3TfWZF5xiY7keC6zkpUnZIUojwW-FAVvrvn51LLnvOXHQ84Q5nn-AVtLcwk">在线编辑器</a>]

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

### 饼图 [<a href="https://mermaid.js.org/syntax/pie.html">文档</a> - <a href="https://mermaid.live/edit#pako:eNo9jsFugzAMhl8F-VzBgEEh13Uv0F1zcYkTIpEEBadShXj3BU3dzf_n77e8wxQUgYDVkvQSbsFsEgpRtEN_5i_kvzx05XiC-xvUHVzAUXRoVe7v0heFBJ7JkQSRR0Ua08ISpD-ymlaFTN_KcoggNC4bXQATh5-Xn0BwTPSWbhZNRPdvLQEV5dIO_FrPZ43dOJ-cgtfWnDzFJeOZed1EVZ3r0lie06Ocgqs2q2aMPD_HvuqbfsCmpf7aYte2anrU46Cbz1qr60fdIBzH8QvW9lkl">在线编辑器</a>]

```
pie
"狗" : 386
"猫" : 85.9
"老鼠" : 15
```

```mermaid
pie
"狗" : 386
"猫" : 85.9
"老鼠" : 15
```

### Git 图 [实验性 - <a href="https://mermaid.live/edit#pako:eNqNkMFugzAMhl8F-VyVAR1tOW_aA-zKxSSGRCMJCk6lCvHuNZPKZdM0n-zf3_8r8QIqaIIGMqnB8kfEybQ--y4VnLP8-9RF9Mpkmm40hmlnDKmvkPiH_kfS7nFo_VN0FAf6XwocQGgxa_nGsm1bYEOOWmik1dRjGrmF1q-Cpkkj07u2HCI0PY4zHQATh8-7V9BwTPSE3iwOEd1OjQE1iWkBvk_bzQY7s0Sq4Hs7bHqKo8iGeZqbPN_WR7mpSd1RHpvPVhuMbG7XOq_L-oJlRfW5wteq0qorrpe-PBW9Pr8UJcK6rg-BLYPQ">在线编辑器</a>]

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

### 条形图（使用甘特图）[<a href="https://mermaid.js.org/syntax/gantt.html">文档</a> - <a href="https://mermaid.live/edit#pako:eNptkU1vhCAQhv8KIenNugiI4rkf6bmXpvEyFVxJFDYyNt1u9r8X63Z7WQ9m5pknLzieaBeMpQ3dg0dsPUkPOhwteXZIXmJcbCT3xMAxkuh8Z8kIEclyMIB209fqKcwTICFvG4IvFy_oLrZ-g9F26ILfQgvNFN94VaRXQ1iWqpumZBcu1J8p1E1TXDx59eQNr5LyEqjJn6hv5QnGNlxevZJmdLLpy5xJSzut45biYCfb0iaVxvawjNjS1p-TCguG16PvaIPzYjO67e3BwX6GiTY9jPFKH43DMF_hGMDY1J4oHg-_f8hFTJFd8L3br3yZx4QHxENsdrt1nO8dDstH3oVpF50ZYMbhU6ud4qoGLqyqBJRCmO6j0HXPZdGbihUc6Pmc0QP49xD-b5X69ZQv2gjO81IwzWqhC1lKrjJ6pA3nVS7SMiVjrKirWlYp5fs3osgrWeo00lorLWvOzz8JVbXm">在线编辑器</a>]

```
gantt
    title Git 问题 - 距上次更新的天数
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
    title Git 问题 - 距上次更新的天数
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

### 用户旅程图 [<a href="https://mermaid.js.org/syntax/userJourney.html">文档</a> - <a href="https://mermaid.live/edit#pako:eNplkMFuwjAQRH9l5TMiTVIC-FqqnjhxzWWJN4khsSN7XRSh_HsdKBVt97R6Mzsj-yoqq0hIAXCywRkaSwNxWHNHsB_hYt1ZmwYUfiueKtbWwIcFtjf5zgH2eCZgQgkrCXt64GgMg2fUzkvIn5Xd_V5COtMFvCH_62ht_5yk7MU8sn61HDTfxD8VYiF6cj1qFd94nWkpuKWYKWRcFdUYOi5FaaZoDYNCpnel2Toha-w8LQQGtofRVEKyC_Qw7TQ2DvsfV2dRUTy6Ch6H-UMb7TlGVtbUupl5cF3ELfPgZZLM8rLR3IbjsrJ94rVq0XH7uS2SIis2mOVUrHNc5bmqjul2U2evaa3WL2mGYpqmL2BGiho">在线编辑器</a>]

```
  journey
    title 我的工作日
    section 去上班
      泡茶: 5: 我
      上楼: 3: 我
      工作: 1: 我, 猫
    section 回家
      下楼: 5: 我
      坐下: 3: 我
```

```mermaid
  journey
    title 我的工作日
    section 去上班
      泡茶: 5: 我
      上楼: 3: 我
      工作: 1: 我, 猫
    section 回家
      下楼: 5: 我
      坐下: 3: 我
```

### C4 图 [<a href="https://mermaid.js.org/syntax/c4.html">文档</a>]

```
C4Context
title 互联网银行系统的系统上下文图

Person(customerA, "银行客户A", "银行的一名客户，拥有个人银行账户。")
Person(customerB, "银行客户B")
Person_Ext(customerC, "银行客户C")
System(SystemAA, "互联网银行系统", "允许客户查看其银行账户信息并进行支付。")

Person(customerD, "银行客户D", "银行的一名客户，<br/>拥有个人银行账户。")

Enterprise_Boundary(b1, "银行边界") {

  SystemDb_Ext(SystemE, "主机银行系统", "存储所有关于客户、账户、交易等核心银行信息。")

  System_Boundary(b2, "银行边界2") {
    System(SystemA, "银行系统A")
    System(SystemB, "银行系统B", "银行的一个系统，拥有个人银行账户。")
  }

  System_Ext(SystemC, "邮件系统", "内部 Microsoft Exchange 邮件系统。")
  SystemDb(SystemD, "银行系统D数据库", "银行的一个系统，拥有个人银行账户。")

  Boundary(b3, "银行边界3", "边界") {
    SystemQueue(SystemF, "银行系统F队列", "银行的一个系统，拥有个人银行账户。")
    SystemQueue_Ext(SystemG, "银行系统G队列", "银行的一个系统，拥有个人银行账户。")
  }
}

BiRel(customerA, SystemAA, "使用")
BiRel(SystemAA, SystemE, "使用")
Rel(SystemAA, SystemC, "发送邮件", "SMTP")
Rel(SystemC, customerA, "发送邮件至")
```

```mermaid
C4Context
title 互联网银行系统的系统上下文图

Person(customerA, "银行客户A", "银行的一名客户，拥有个人银行账户。")
Person(customerB, "银行客户B")
Person_Ext(customerC, "银行客户C")
System(SystemAA, "互联网银行系统", "允许客户查看其银行账户信息并进行支付。")

Person(customerD, "银行客户D", "银行的一名客户，<br/>拥有个人银行账户。")

Enterprise_Boundary(b1, "银行边界") {
```markdown
  SystemDb_Ext(SystemE, "主机银行系统", "存储所有关于客户、账户、交易等核心银行信息。")

  System_Boundary(b2, "银行边界2") {
    System(SystemA, "银行系统A")
    System(SystemB, "银行系统B", "银行的一个系统，拥有个人银行账户。")
  }

  System_Ext(SystemC, "电子邮件系统", "内部的 Microsoft Exchange 电子邮件系统。")
  SystemDb(SystemD, "银行系统D数据库", "银行的一个系统，拥有个人银行账户。")

  Boundary(b3, "银行边界3", "边界") {
    SystemQueue(SystemF, "银行系统F队列", "银行的一个系统，拥有个人银行账户。")
    SystemQueue_Ext(SystemG, "银行系统G队列", "银行的一个系统，拥有个人银行账户。")
  }
}

BiRel(customerA, SystemAA, "使用")
BiRel(SystemAA, SystemE, "使用")
Rel(SystemAA, SystemC, "发送电子邮件", "SMTP")
Rel(SystemC, customerA, "向其发送电子邮件")
```

## 发布

对于有权限的用户：

请在 `package.json` 中更新版本号。

```sh
npm publish
```

上述命令会将文件生成到 `dist` 文件夹并发布到 <https://www.npmjs.com>。

## 相关项目

- [命令行界面](https://github.com/mermaid-js/mermaid-cli)
- [在线编辑器](https://github.com/mermaid-js/mermaid-live-editor)
- [HTTP服务器](https://github.com/TomWright/mermaid-server)

## 贡献者 [![Good first issue](https://img.shields.io/github/labels/mermaid-js/mermaid/Good%20first%20issue%21)](https://github.com/mermaid-js/mermaid/issues?q=is%3Aissue+is%3Aopen+label%3A%22Good+first+issue%21%22) [![Contributors](https://img.shields.io/github/contributors/mermaid-js/mermaid)](https://github.com/mermaid-js/mermaid/graphs/contributors) [![Commits](https://img.shields.io/github/commit-activity/m/mermaid-js/mermaid)](https://github.com/mermaid-js/mermaid/graphs/contributors)

Mermaid 是一个不断壮大的社区，始终欢迎新的贡献者加入。有许多不同的方式可以参与进来，我们也一直在寻找更多的帮手！如果你想知道从哪里开始贡献，请查看 [这个 issue](https://github.com/mermaid-js/mermaid/issues/866)。

关于如何贡献的详细信息可以在[贡献指南](https://mermaid.js.org/community/contributing.html)中找到。

## 安全与安全图表

对于公共网站，从互联网上获取用户的文本，并在后期将这些内容存储以在浏览器中展示，这可能是危险的。原因在于用户内容可能包含嵌入的恶意脚本，当数据被展示时这些脚本会运行。对于 Mermaid 来说，这是一个风险，特别是因为 mermaid 图表包含许多 HTML 中使用的字符，这导致标准的内容清洗方法无法使用，因为它也会破坏图表。我们仍然努力对传入代码进行清洗并持续完善该过程，但很难保证没有漏洞。

作为对有外部用户的网站的额外安全保障，我们很高兴引入了一个新的安全等级，在该等级下，图表会在沙盒 iframe 中渲染，从而防止代码中的 JavaScript 被执行。这是提升安全性的一个重要步骤。

_很遗憾，鱼与熊掌不可兼得，这意味着某些交互功能会与可能的恶意代码一起被屏蔽。_

## 漏洞报告

如需报告漏洞，请发送电子邮件至 <security@mermaid.live>，邮件内容请描述问题、您复现该问题的步骤、受影响的版本，以及（如有）该问题的缓解方法。

## 致谢

来自 Knut Sveidqvist 的简短致辞：

> _非常感谢 [d3](https://d3js.org/) 和 [dagre-d3](https://github.com/cpettitt/dagre-d3) 项目为我们提供了图形布局和绘图库！_
>
> _还要感谢 [js-sequence-diagram](https://bramp.github.io/js-sequence-diagrams) 项目在时序图语法方面的贡献。感谢 Jessica Peter 对甘特图渲染的灵感和起点的贡献。_
>
> _感谢自2017年4月以来成为协作者的 [Tyler Long](https://github.com/tylerlong)。_
>
> _感谢越来越多的 [贡献者](https://github.com/mermaid-js/mermaid/graphs/contributors)，是你们让项目发展至今！_

---

_Mermaid 由 Knut Sveidqvist 创建，旨在简化文档编写。_
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-12

---