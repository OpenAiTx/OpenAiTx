[![Scorecard supply-chain security](https://github.com/edwinm/carbonium/actions/workflows/scorecard.yml/badge.svg)](https://github.com/edwinm/carbonium/actions/workflows/scorecard.yml) [![CodeQL](https://github.com/edwinm/carbonium/actions/workflows/codeql.yml/badge.svg)](https://github.com/edwinm/carbonium/actions/workflows/codeql.yml) [![Coverage Status](https://coveralls.io/repos/github/edwinm/carbonium/badge.svg?branch=master)](https://coveralls.io/github/edwinm/carbonium?branch=master) [![Socket Badge](https://socket.dev/api/badge/npm/package/carbonium)](https://socket.dev/npm/package/carbonium) [![CodeFactor](https://www.codefactor.io/repository/github/edwinm/carbonium/badge)](https://www.codefactor.io/repository/github/edwinm/carbonium) [![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=edwinm_carbonium&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=edwinm_carbonium) [![Snyk test results](https://snyk.io/test/github/edwinm/carbonium/badge.svg)](https://snyk.io/test/github/edwinm/carbonium) [![Size](https://badgen.net/bundlephobia/minzip/carbonium)](https://bundlephobia.com/package/carbonium) [![npm version](https://badge.fury.io/js/carbonium.svg)](https://www.npmjs.com/package/carbonium) [![GitHub](https://img.shields.io/github/license/edwinm/carbonium.svg)](https://github.com/edwinm/carbonium/blob/master/LICENSE) ![CodeRabbit Pull Request Reviews](https://img.shields.io/coderabbit/prs/github/edwinm/carbonium?utm_source=oss&utm_medium=github&utm_campaign=edwinm%2Fcarbonium&labelColor=171717&color=FF570A&link=https%3A%2F%2Fcoderabbit.ai&label=CodeRabbit+Reviews)

[![Carbonium](https://raw.githubusercontent.com/edwinm/carbonium/master/assets/carbonium.svg)](#readme)

> One kilobyte library for easy DOM manipulation

With carbonium, you can call `$(selector)` and the result can be accessed as both an DOM element and an array of matched elements.
DOM element operations are applied to all matched elements.

## Examples

To set the `left` CSS property of all elements with the class `indent` to 40 pixels:

```javascript
$(".indent").style.left = "40px";
```

To add the class `important` to all div's with "priority" as content:

```javascript
$("div")
  .filter((el) => el.textContent == "priority")
  .classList.add("important");
```

You can use carbonium to create elements:

```javascript
const error = $("<div class='error'>An error has occured!</div>")[0];
```

## Installation

```bash
npm install --save-dev carbonium
```

Now you can import carbonium:

```javascript
import { $ } from "carbonium";
```

If you don't want to install or use a bundler like webpack or rollup.js, you can import carbonium like this:

```javascript
const { $ } = await import(
  "https://cdn.jsdelivr.net/npm/carbonium@1/dist/bundle.min.js"
);
```

## API

### Select elements

### `$(selector [, parentNode])`

#### Parameters

| Name       | Type                           | Description                                                                |
| ---------- | ------------------------------ | -------------------------------------------------------------------------- |
| selector   | string                         | Selector to select elements                                                |
| parentNode | Document \| Element (optional) | Document or element in which to apply the selector, defaults to `document` |

#### Returns

An array of the matched elements, which can also be accessed as a single element.

### Create element

### `$(html [, parentNode])`

#### Parameters

| Name       | Type                           | Description                                                                |
| ---------- | ------------------------------ | -------------------------------------------------------------------------- |
| html       | string                         | HTML of element to create, starting with "<"                               |
| parentNode | Document \| Element (optional) | Document or element in which to apply the selector, defaults to `document` |

#### Returns

An array with one created element.

## TypeScript

If you use TypeScript, it's good to know Carbonium is written in TypeScript and provides all typings.
You can use generics to declare a specific type of element,
for example `HTMLInputElement` to make the `disabled` property available:

```typescript
$<HTMLInputElement>("input, select, button").disabled = true;
```

## Why?

You might find most frameworks are quite bulky and bad for performance ([1](https://css-tricks.com/radeventlistener-a-tale-of-client-side-framework-performance/)).
On the other side, you might find using native DOM and writing `document.querySelectorAll(selector)` each time you want to do some DOM operations to become tedious.
You can write your own helper function, but that only takes part of the pain away.

Carbonium seeks to find the sweet spot between using a framework and using the native DOM.

## jQuery

Isn't this just jQuery and isn't that obsolete and bad practice?

No. Carbonium doesn't have the disadvantages of jQuery:

1. Carbonium is very small: just around one kilobyte.
2. There's no new API to learn, carbonium provides only standard DOM API's.

## Browser support

Carbonium is supported by all modern browsers. It is tested to work on desktop and mobile with Firefox 79, Chrome 84, Safari 13 and Edge 84.
It should work with all browsers supporting Proxy, see [Can I use Proxy](https://caniuse.com/#feat=proxy) for support tables.

## Name

[<img src="https://raw.githubusercontent.com/edwinm/carbonium/master/assets/Diamond_and_graphite.jpg" align="right"
     alt="Photo of diamond and graphite" width="178" height="120">](https://commons.wikimedia.org/wiki/File:Diamond_and_graphite_without_structures.jpg)

Carbonium is the Latin name for carbon. Carbon has two forms (allotropes): graphite and diamond.
Just like this library, in which the result presents itself both as one element and as a list of elements.

[Photo CC BY-SA 3.0](https://commons.wikimedia.org/wiki/File:Diamond_and_graphite_without_structures.jpg)

## License

Copyright 2023 [Edwin Martin](https://bitstorm.org/) and released under the MIT license.
