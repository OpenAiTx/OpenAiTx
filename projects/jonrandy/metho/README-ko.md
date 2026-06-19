
# Metho - 메서드를 위한 새로운 방법

<img align="right" height=100 src="https://user-images.githubusercontent.com/1510194/173243187-08fdcc0f-204d-43c0-b07e-5b7bcb2713a4.png">심볼(Symbol)의 도움으로 객체에 '동적 속성'을 안전하게 추가할 수 있게 해주는 작은 라이브러리입니다. 이것은 네이티브 자바스크립트 타입에 새로운 기능을 부여하는 '몽키 패칭(monkey patching)' 등 여러 용도에 유용합니다 ([metho-number](https://github.com/jonrandy/metho-number), [metho-set](https://github.com/jonrandy/metho-set), [metho-function](https://github.com/jonrandy/metho-function), [metho-array](https://github.com/jonrandy/metho-array), 그리고 [metho-string](https://github.com/jonrandy/metho-string)을 참조).

가능한 몇 가지 예시는 다음과 같습니다:

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
## 사용 방법

Metho는 상당히 간단하며, 대상 객체에 이러한 '동적 속성'을 추가하기 위한 4가지 기본 기능을 제공합니다. 모든 함수는 Symbol 또는 Symbol을 반환하는 함수를 반환합니다. 이 Symbol들은 속성의 '이름'입니다.

### `add(targetOrTargets, function, [options={}])`
이 함수가 아마 가장 자주 필요할 것입니다. 전달된 함수가 기대하는 인수의 수에 따라 `addWithParams` 또는 `addSimple`을 사용합니다 - 0이면 `addSimple`이 사용되고, 그 외의 경우에는 `outerSyntax` 옵션의 상태에 따라 `addWithParams` 또는 `addProperty`가 사용됩니다. `outerSyntax`가 `true`로 설정된 상태에서 추가하면 - 속성의 문법은 보다 일반적인 함수 호출 문법이 됩니다:

```js
// options.outerSyntax = false
object[property(x)]

// options.outerSyntax = true
object[property](x)
```
`outerSyntax`를 사용하지 않을 때 약간의 성능 저하가 발생하므로 스위치를 사용하는 이유입니다. 함수에 대해 여러 대상(target)을 지정하려면 대상의 배열을 전달해야 합니다.

**중요 참고 사항** - 첫 번째 인수부터 시작하는 기본 인수가 있는 함수는 `add` 메서드와 함께 올바르게 작동하지 않는 것처럼 보인다는 지적이 있었습니다. 이상하게 보일 수 있지만, 실제로는 인수를 *실제로 기대하지 않기* 때문에 정상적으로 작동하는 것입니다 (자세한 설명은 MDN의 [`function.length`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Function/length) 정보를 참조하십시오). 이러한 메서드를 추가하려면 `addWithParams` 메서드를 직접 사용해야 합니다.

### `addWithParams(targetOrTargets, function, [options={}])`
매개변수를 받을 수 있는 '동적 속성'을 추가합니다. 호출 시 **매개변수를 전혀** 전달하지 않으려면 괄호를 생략할 수 있으며, 이는 모든 매개변수가 기본값이거나 완전히 선택적인 함수에 특히 유용합니다.
```js
console.log(object[property(param1, param2)]  // call the dynamic property and pass parameters
console.log(object[propertyWithDefaultParams])  // equivalent to object[propertyWithDefaultParams()]

```

### `addSimple(targetOrTargets, function, [options={}])`
매개변수가 없는 '동적 속성'을 추가합니다.
```js
console.log(object[property])
```

### `addProperty(targetOrTargets, propertyValue, [options={}])`
대상에 일반 속성을 추가합니다(함수일 경우 자동으로 호출되지 않음).
```js
console.log(object[property])
```
## 고급 사용법 및 `options`

아래 내용 중 대부분은 Metho 'methods'가 서로 다른 라이브러리의 서로 다른 대상 간에 공유될 수 있는 기능을 지원하기 위해 추가되었습니다(예: 두 번째 라이브러리가 해당 메서드를 사용할 때 'method'가 더 많은 기능을 획득함). 이 기능이 실제로 어떻게 사용되는지에 대한 예는 [metho-string](https://github.com/jonrandy/metho-string) 및 [metho-array](https://github.com/jonrandy/metho-array) 라이브러리를 참조하십시오 - 여기서 이 기능은 `reverse`와 `chunk`와 같은 공유 'methods'를 생성하는 데 사용됩니다.

### 옵션 `symbolName`
이 옵션은 생성된 Symbol에 이름을 부여하는 데 사용됩니다(즉, `new Symbol(symbolName`으로 생성될 때).

### 옵션 `register`
생성되거나 사용된 `Symbol`(또는 함수)을 Metho 내의 내부 레지스트리에 등록하는 데 사용됩니다 - `symbolName`과 함께 사용되며, 레지스트리 내에서 '키'가 됩니다.

### 옵션 `useSymbol`
새로운 Symbol을 생성하는 대신 기존 Symbol을 사용할 수 있게 합니다. 이 옵션은 `addProperty`와 `addSimple`에만 제공되며, 따라서 `add`에도 전달할 수 있습니다.

### `data`
Metho가 의도한 목적을 위해 생성한 심볼로, 대상 객체에 임의의 '데이터'를 저장하는 키로 사용됩니다.

```js
myTarget[Metho.data] = "Arbitrary value"
```

### `getRegistered(name)`
이는 주어진 이름을 키로 하여 레지스트리에 저장된 Symbol 또는 함수를 반환합니다.

### `addWithSharedSymbolName(target, function, symbolName)`
새로운 대상에 새로운 '메서드'를 추가할 때, 해당 '메서드'가 이미 존재할 수 있는 경우를 지원하는 편의 함수입니다. 이는 위에서 언급한 `metho-string` 및 `metho-array`와 함께 이해하는 것이 가장 좋습니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-19

---