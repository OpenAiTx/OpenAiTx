[![Scorecard supply-chain security](https://github.com/edwinm/carbonium/actions/workflows/scorecard.yml/badge.svg)](https://github.com/edwinm/carbonium/actions/workflows/scorecard.yml) [![CodeQL](https://github.com/edwinm/carbonium/actions/workflows/codeql.yml/badge.svg)](https://github.com/edwinm/carbonium/actions/workflows/codeql.yml) [![Coverage Status](https://coveralls.io/repos/github/edwinm/carbonium/badge.svg?branch=master)](https://coveralls.io/github/edwinm/carbonium?branch=master) [![Socket Badge](https://socket.dev/api/badge/npm/package/carbonium)](https://socket.dev/npm/package/carbonium) [![CodeFactor](https://www.codefactor.io/repository/github/edwinm/carbonium/badge)](https://www.codefactor.io/repository/github/edwinm/carbonium) [![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=edwinm_carbonium&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=edwinm_carbonium) [![Snyk test results](https://snyk.io/test/github/edwinm/carbonium/badge.svg)](https://snyk.io/test/github/edwinm/carbonium) [![Size](https://badgen.net/bundlephobia/minzip/carbonium)](https://bundlephobia.com/package/carbonium) [![npm version](https://badge.fury.io/js/carbonium.svg)](https://www.npmjs.com/package/carbonium) [![GitHub](https://img.shields.io/github/license/edwinm/carbonium.svg)](https://github.com/edwinm/carbonium/blob/master/LICENSE) ![CodeRabbit Pull Request Reviews](https://img.shields.io/coderabbit/prs/github/edwinm/carbonium?utm_source=oss&utm_medium=github&utm_campaign=edwinm%2Fcarbonium&labelColor=171717&color=FF570A&link=https%3A%2F%2Fcoderabbit.ai&label=CodeRabbit+Reviews)

[![Carbonium](https://raw.githubusercontent.com/edwinm/carbonium/master/assets/carbonium.svg)](#readme)

> 一个一千字节的库，用于简便的DOM操作

使用carbonium，你可以调用`$(selector)`，结果既可以作为DOM元素访问，也可以作为匹配元素数组访问。
DOM元素操作会应用于所有匹配的元素。

## 示例

将所有类名为`indent`的元素的`left` CSS属性设置为40像素：

```javascript
$(".indent").style.left = "40px";
```

要向所有内容为 "priority" 的 div 添加类 `important`：

```javascript
$("div")
  .filter((el) => el.textContent == "priority")
  .classList.add("important");
```

你可以使用碳正离子来创建元素：

```javascript
const error = $("<div class='error'>An error has occured!</div>")[0];
```

## 安装

```bash
npm install --save-dev carbonium
```
现在您可以导入 carbonium：


```javascript
import { $ } from "carbonium";
```
如果您不想安装或使用像 webpack 或 rollup.js 这样的打包工具，您可以这样导入 carbonium：


```javascript
const { $ } = await import(
  "https://cdn.jsdelivr.net/npm/carbonium@1/dist/bundle.min.js"
);
```

## API

### 选择元素

### `$(selector [, parentNode])`

#### 参数

| 名称       | 类型                           | 描述                                                                      |
| ---------- | ------------------------------ | -------------------------------------------------------------------------- |
| selector   | string                         | 用于选择元素的选择器                                                      |
| parentNode | Document \| Element (可选)     | 应用选择器的文档或元素，默认为 `document`                                 |

#### 返回值

匹配元素的数组，也可以作为单个元素访问。

### 创建元素

### `$(html [, parentNode])`

#### 参数

| 名称       | 类型                           | 描述                                                                      |
| ---------- | ------------------------------ | -------------------------------------------------------------------------- |
| html       | string                         | 要创建元素的 HTML，必须以 "<" 开头                                       |
| parentNode | Document \| Element (可选)     | 应用选择器的文档或元素，默认为 `document`                                 |

#### 返回值

包含一个创建元素的数组。

## TypeScript

如果你使用 TypeScript，值得知道 Carbonium 是用 TypeScript 编写的并提供所有类型定义。  
你可以使用泛型声明特定类型的元素，  
例如 `HTMLInputElement`，以使 `disabled` 属性可用：

```typescript
$<HTMLInputElement>("input, select, button").disabled = true;
```

## 为什么？

你可能会发现大多数框架都相当庞大且性能较差（[1](https://css-tricks.com/radeventlistener-a-tale-of-client-side-framework-performance/)）。
另一方面，你可能会发现每次想进行一些 DOM 操作时都写 `document.querySelectorAll(selector)` 很繁琐。
你可以编写自己的辅助函数，但那只能缓解部分痛点。

Carbonium 旨在找到使用框架与使用原生 DOM 之间的最佳平衡点。

## jQuery

这不就是 jQuery 吗？那不是过时且不好的做法吗？

不是。Carbonium 没有 jQuery 的缺点：

1. Carbonium 非常小：只有大约一千字节。
2. 没有新的 API 需要学习，carbonium 只提供标准 DOM API。

## 浏览器支持

Carbonium 被所有现代浏览器支持。经测试可在桌面和移动端的 Firefox 79、Chrome 84、Safari 13 和 Edge 84 上运行。
它应该能在所有支持 Proxy 的浏览器上工作，支持表见 [Can I use Proxy](https://caniuse.com/#feat=proxy)。

## 名称

[<img src="https://raw.githubusercontent.com/edwinm/carbonium/master/assets/Diamond_and_graphite.jpg" align="right"
     alt="钻石和石墨照片" width="178" height="120">](https://commons.wikimedia.org/wiki/File:Diamond_and_graphite_without_structures.jpg)

Carbonium 是碳的拉丁语名称。碳有两种形态（同素异形体）：石墨和钻石。
就像这个库，结果既表现为单个元素，也表现为元素列表。

[照片 CC BY-SA 3.0](https://commons.wikimedia.org/wiki/File:Diamond_and_graphite_without_structures.jpg)

## 许可证

版权所有 2023 [Edwin Martin](https://bitstorm.org/) 并在 MIT 许可证下发布。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-05

---