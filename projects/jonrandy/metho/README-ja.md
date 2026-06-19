
# Metho - メソッドのための新しいメソッド

<img align="right" height=100 src="https://user-images.githubusercontent.com/1510194/173243187-08fdcc0f-204d-43c0-b07e-5b7bcb2713a4.png">シンボルの助けを借りて、オブジェクトに安全に「動的プロパティ」を追加できる小さなライブラリです。これは（他の用途の中でも）ネイティブなJavaScript型に「モンキーパッチ」を施し、新しい機能を与えるのに役立ちます（[metho-number](https://github.com/jonrandy/metho-number)、[metho-set](https://github.com/jonrandy/metho-set)、[metho-function](https://github.com/jonrandy/metho-function)、[metho-array](https://github.com/jonrandy/metho-array)、および[metho-string](https://github.com/jonrandy/metho-string)を参照）。

可能な例のいくつか：

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

## 使い方

Methoは非常にシンプルで、ターゲットオブジェクトにこれらの「動的プロパティ」を追加するための基本的な4つの関数を提供します。すべての関数はSymbolか、Symbolを返す関数を返します。これらのSymbolがプロパティの「名前」となります。

### `add(targetOrTargets, function, [options={}])`
これはおそらく最も頻繁に使う関数でしょう。渡された関数が期待する引数の数に基づいて、`addWithParams`か`addSimple`のどちらかを使用します。引数が0の場合は`addSimple`が使用され、それ以外の場合は`outerSyntax`オプションの状態に基づいて`addWithParams`または`addProperty`が使用されます。`outerSyntax`が`true`に設定されて追加された場合、プロパティの構文はより通常の関数呼び出しの形式になります。
```js
// options.outerSyntax = false
object[property(x)]

// options.outerSyntax = true
object[property](x)
```
`outerSyntax`を使用しない場合、わずかなパフォーマンス低下があります。そのためスイッチが存在します。関数のターゲットを複数指定するには、ターゲットの配列を渡してください。

**重要な注意点** - 最初の引数から始まるデフォルト引数を持つ関数は、`add`メソッドで正しく動作しないように見えると指摘されています。奇妙に動作するように*見える*かもしれませんが、実際には引数を*期待していない*ため正しく動作しています（詳細はMDNの[`function.length`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Function/length)の説明を参照）。このようなメソッドを追加したい場合は、`addWithParams`メソッドを直接使用してください。

### `addWithParams(targetOrTargets, function, [options={}])`
パラメータを受け取れる「動的プロパティ」を追加します。呼び出し時に**パラメータを渡さない**場合は、単に括弧を省略できます。これはすべてのパラメータにデフォルト値があるか完全に任意の関数の場合に特に便利です。
```js
console.log(object[property(param1, param2)]  // call the dynamic property and pass parameters
console.log(object[propertyWithDefaultParams])  // equivalent to object[propertyWithDefaultParams()]

```

### `addSimple(targetOrTargets, function, [options={}])`
パラメータを持たない「動的プロパティ」を追加します
```js
console.log(object[property])
```

### `addProperty(targetOrTargets, propertyValue, [options={}])`
ターゲットに通常のプロパティを追加します（関数の場合は自動的に呼び出されません）
```js
console.log(object[property])
```

## 高度な使用法と`options`

以下のほとんど、あるいはすべては、異なるライブラリの異なるターゲット間で共有可能なMethoの「メソッド」を持つ能力を促進するために追加されました（例：2番目のライブラリがインポートされてそれを使用すると、メソッドはより多くの機能を獲得します）。この機能の実例については、[metho-string](https://github.com/jonrandy/metho-string)および[metho-array](https://github.com/jonrandy/metho-array)ライブラリを参照してください。ここでは、この機能を使って`reverse`や`chunk`のような共有「メソッド」が作成されています。

### オプション`symbolName`
これは生成されたSymbolに名前を付けるために使用されます（つまり、`new Symbol(symbolName`で作成されるとき）。

### オプション`register`
作成または使用された`Symbol`（または関数）をMetho内部の内部レジストリに登録するために使用されます。`symbolName`と組み合わせて使われ、レジストリ内の「キー」となります。

### オプション`useSymbol`
これは新しいSymbolを作成する代わりに既存のSymbolを使用できるようにします。これは`addProperty`と`addSimple`でのみ利用可能であり、`add`にも渡すことができます。

### `data`
これはMethoによって作成されたシンボルで、ターゲットオブジェクト上に任意の「データ」を格納するためのキーとしての目的で作られています。
```js
myTarget[Metho.data] = "Arbitrary value"
```

### `getRegistered(name)`
これは、指定された名前をキーとしてレジストリに格納されているシンボルまたは関数を返します

### `addWithSharedSymbolName(target, function, symbolName)`
新しいターゲットに新しい「メソッド」を追加する際に役立つ便利な関数で、その「メソッド」が既に存在している場合にも対応します。これは上記で言及した `metho-string` および `metho-array` と併せて理解するのが最適です


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-19

---