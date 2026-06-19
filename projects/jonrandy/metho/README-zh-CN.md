
# Metho - 一种新的方法方法

<img align="right" height=100 src="https://user-images.githubusercontent.com/1510194/173243187-08fdcc0f-204d-43c0-b07e-5b7bcb2713a4.png">一个小型库，允许你借助 Symbols 安全地向对象添加“动态属性”。这在（除其他用途外）“猴子补丁”原生 JavaScript 类型以赋予它们新功能时非常有用（参见 [metho-number](https://github.com/jonrandy/metho-number), [metho-set](https://github.com/jonrandy/metho-set), [metho-function](https://github.com/jonrandy/metho-function), [metho-array](https://github.com/jonrandy/metho-array), 和 [metho-string](https://github.com/jonrandy/metho-string)）。

一些可能的示例：

```js
import * as Metho from 'metho'

const asHex = Metho.add(
  Number.prototype,
  function() { return this.toString(16) }
)

console.log(65534[asHex])  // fffe

const upper = Metho.add(
  String.prototype,
  function() { return this.toUpperCase() }
)
const chunk = Metho.add(
  String.prototype,
  function(length) {
    return this.match(new RegExp('.{1,' + length + '}', 'g'))
  }
)

console.log("Hello World!"[upper][chunk(2)])  // ['HE', 'LL', 'O ', 'WO', 'RL', 'D!']
```
## 如何使用

Metho 非常简单，提供了 4 个基本功能，用于向目标对象添加这些“动态属性”。所有函数都会返回一个 Symbol，或者返回一个返回 Symbol 的函数。这些 Symbol 是属性的“名称”。

### `add(targetOrTargets, function, [options={}])`
这可能是你最常用的函数。它会根据传入函数预期的参数数量使用 `addWithParams` 或 `addSimple` —— 参数为 0 时使用 `addSimple`，否则根据 `outerSyntax` 选项的状态使用 `addWithParams` 或 `addProperty`。当 `outerSyntax` 设置为 `true` 时，属性的语法将类似于常规函数调用：

```js
// options.outerSyntax = false
object[property(x)]

// options.outerSyntax = true
object[property](x)
```
不使用 `outerSyntax` 时性能会略有下降——这就是切换的原因。要为函数指定多个目标，应传递目标数组。

**重要提示** - 有人指出带有从第一个参数开始的默认参数的函数在使用 `add` 方法时似乎无法正常工作。虽然它们看起来表现得很奇怪，但实际上它们的行为是正确的，因为它们实际上并不*期望*任何参数（更清楚的解释，请参见 MDN 上关于 [`function.length`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Function/length) 的信息）。如果你想添加这类方法，应直接使用 `addWithParams` 方法。

### `addWithParams(targetOrTargets, function, [options={}])`
添加一个可以接受参数的“动态属性”。如果你希望调用时**不**传递参数，可以省略括号——这在所有参数都有默认值或完全可选的函数中特别有用。
```js
console.log(object[property(param1, param2)]  // call the dynamic property and pass parameters
console.log(object[propertyWithDefaultParams])  // equivalent to object[propertyWithDefaultParams()]

```

### `addSimple(targetOrTargets, function, [options={}])`
添加一个没有参数的“动态属性”
```js
console.log(object[property])
```

### `addProperty(targetOrTargets, propertyValue, [options={}])`
向目标添加一个普通属性（如果是函数，则不会自动调用）
```js
console.log(object[property])
```

## 高级用法和 `options`

下面大部分（如果不是全部的话）都是为了支持 Metho “方法” 能够在不同库中的不同目标之间共享（例如，当导入第二个使用该方法的库时，该“方法”会获得更多功能）。有关此功能的示例，请参见 [metho-string](https://github.com/jonrandy/metho-string) 和 [metho-array](https://github.com/jonrandy/metho-array) 库 —— 这些库使用该功能创建共享的“方法”，如 `reverse` 和 `chunk`。

### 选项 `symbolName`
用于为生成的 Symbol 命名（即在使用 `new Symbol(symbolName` 创建时）

### 选项 `register`
用于在 Metho 内部注册创建/使用的 `Symbol`（或函数），配合 `symbolName` 使用，`symbolName` 将成为注册表中的“键”

### 选项 `useSymbol`
允许使用已存在的 Symbol，而不是创建新的。此选项仅适用于 `addProperty` 和 `addSimple` —— 也就是说，它可以传递给 `add`

### `data`
这是 Metho 创建的一个 Symbol，目的是用作在目标对象上存储任意“数据”的键
```js
myTarget[Metho.data] = "Arbitrary value"
```

### `getRegistered(name)`
这将返回使用给定名称作为键存储在注册表中的 Symbol 或函数

### `addWithSharedSymbolName(target, function, symbolName)`
一个辅助函数，用于在向新目标添加新的“方法”时使用，该“方法”可能已经存在。结合上面提到的 `metho-string` 和 `metho-array` 最易理解


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-19

---