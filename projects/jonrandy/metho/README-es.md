
# Metho - Un nuevo método para métodos

<img align="right" height=100 src="https://user-images.githubusercontent.com/1510194/173243187-08fdcc0f-204d-43c0-b07e-5b7bcb2713a4.png">Una pequeña biblioteca que te permite añadir 'propiedades dinámicas' a objetos de forma segura, con la ayuda de Símbolos. Esto es útil (entre otras cosas) para 'monkey patching' de tipos nativos de JavaScript para darles nuevas capacidades (ver [metho-number](https://github.com/jonrandy/metho-number), [metho-set](https://github.com/jonrandy/metho-set), [metho-function](https://github.com/jonrandy/metho-function), [metho-array](https://github.com/jonrandy/metho-array), y [metho-string](https://github.com/jonrandy/metho-string)).

Algunos ejemplos de lo que es posible:

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

## Cómo usar

Metho es bastante simple y ofrece 4 funciones básicas para agregar estas 'propiedades dinámicas' a su(s) objeto(s) objetivo. Todas las funciones devolverán ya sea un Símbolo, o una función que devuelve un Símbolo. Estos Símbolos son los 'nombres' de las propiedades.

### `add(targetOrTargets, function, [options={}])`
Esta es probablemente la función que necesitará con más frecuencia. Usará `addWithParams` o `addSimple` según el número de argumentos que espere la función pasada: 0 hará que se use `addSimple`, cualquier otro valor hará que se use `addWithParams` o `addProperty`, según el estado de la opción `outerSyntax`. Cuando se agrega con `outerSyntax` establecido en `true`, la sintaxis para su propiedad será la de una llamada de función más regular:
```js
// options.outerSyntax = false
object[property(x)]

// options.outerSyntax = true
object[property](x)
```
Hay una pequeña pérdida de rendimiento al no usar `outerSyntax`, de ahí la razón del interruptor. Para especificar más de un objetivo para la función, debe pasar un array de objetivos.

**Nota importante** - se ha señalado que las funciones con un argumento(s) por defecto que comienzan desde el primer argumento no parecen funcionar correctamente con el método `add`. Aunque *parecen* comportarse de manera extraña, en realidad están funcionando correctamente ya que no *esperan* realmente ningún argumento (para una explicación más clara, consulte la información sobre [`function.length`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Function/length) en MDN). Si desea agregar tales métodos, debe usar directamente el método `addWithParams`.

### `addWithParams(targetOrTargets, function, [options={}])`
Agrega una 'propiedad dinámica' que puede aceptar parámetros. Si desea pasar **ningún** parámetro al llamarla, simplemente puede omitir los paréntesis; esto es particularmente útil en el caso de funciones donde todos los parámetros tienen valores predeterminados o son completamente opcionales.
```js
console.log(object[property(param1, param2)]  // call the dynamic property and pass parameters
console.log(object[propertyWithDefaultParams])  // equivalent to object[propertyWithDefaultParams()]

```

### `addSimple(targetOrTargets, function, [options={}])`
Añade una 'propiedad dinámica' que no tiene parámetros
```js
console.log(object[property])
```

### `addProperty(targetOrTargets, propertyValue, [options={}])`
Agrega una propiedad regular al(los) objetivo(s) (no se llamará automáticamente si es una función)
```js
console.log(object[property])
```

## Uso avanzado y `options`

La mayoría, si no todos los siguientes, fueron añadidos para facilitar la capacidad de tener 'métodos' Metho que puedan ser compartidos entre diferentes objetivos en diferentes bibliotecas (por ejemplo, el 'método' adquiriría más capacidades cuando se importa una segunda biblioteca que lo utiliza). Para un ejemplo de esto en acción, por favor refiérase a las bibliotecas [metho-string](https://github.com/jonrandy/metho-string) y [metho-array](https://github.com/jonrandy/metho-array), donde esta funcionalidad se usa para crear 'métodos' compartidos como `reverse` y `chunk`.

### Opción `symbolName`
Esto se usa para dar un nombre al Símbolo generado (es decir, cuando se crea con `new Symbol(symbolName`)

### Opción `register`
Se usa para registrar internamente el `Symbol` (o función) creado/usado en un registro interno dentro de Metho - se usa junto con `symbolName` que se convertirá en la 'clave' en el registro

### Opción `useSymbol`
Esto permite que se use un Símbolo existente en lugar de crear uno nuevo. Esto está disponible solo para `addProperty` y `addSimple` - lo que significa que también puede pasarse a `add`

### `data`
Este es un símbolo creado por Metho con el propósito de ser una clave para almacenar 'datos' arbitrarios en un objeto objetivo
```js
myTarget[Metho.data] = "Arbitrary value"
```

### `getRegistered(name)`
Esto devolverá el Símbolo o función almacenada en el registro con el nombre dado como clave

### `addWithSharedSymbolName(target, function, symbolName)`
Una función de conveniencia para ayudar al agregar nuevos 'métodos' a nuevos objetivos, donde el 'método' puede ya existir. Esto se entiende mejor en conjunto con `metho-string` y `metho-array` mencionados arriba


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-19

---