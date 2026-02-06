# Jib

*Una implementación en Julia de la API de Interactive Brokers*

`Jib` es un cliente nativo de [Julia](https://julialang.org/) que implementa
la API de [Interactive Brokers](https://www.interactivebrokers.com/) para comunicarse
con TWS o IBGateway.

Su objetivo es ser completo en cuanto a funcionalidades, sin embargo no soporta versiones antiguas.

Cabe mencionar que la API oficial de IB ha adoptado recientemente
Protocol Buffers como formato de transmisión, reemplazando el protocolo personalizado legado.
Este paquete siguió la misma línea y se eliminó el soporte para el anterior.

Actualmente, sólo se soportan versiones de API `v213+`, lo que equivale a
la versión `10.40` de TWS o superior.

El diseño del paquete sigue la API oficial en C++/Java
[IB API](https://interactivebrokers.github.io/tws-api/),
que se basa en un modelo de comunicación asíncrono sobre TCP.

## Instalación
Para instalar desde GitHub:
```julia
] add https://github.com/lbilli/Jib.jl
```

## Uso
El usuario interactúa principalmente con estos dos objetos:
- `Connection`: un manejador que mantiene una conexión con el servidor
- `Wrapper`: un contenedor para los callbacks que se invocan
   cuando se procesan las respuestas del servidor.

Otras estructuras de datos, como `Contract` y `Order`, están implementadas como `struct` de Julia
y reflejan las respectivas clases en la API oficial de IB.

Se muestra un ejemplo mínimo completo y funcional.
Para que este código funcione, debe estar ejecutándose una instancia de IB TWS o IBGateway
en la máquina local y escuchando en el puerto `4002`.
**Nota:** _cuenta demo_ o _cuenta paper_ recomendada!! :smirk:
```julia
using Jib

wrap = Jib.Wrapper(
         # Customized methods go here
         error= (id, errorTime, errorCode, errorString, advancedOrderRejectJson) ->
                  println("Error: $(something(id, "NA")) $errorTime $errorCode $errorString $advancedOrderRejectJson"),

         nextValidId= (orderId) -> println("Next OrderId: $orderId"),

         managedAccounts= (accountsList) -> println("Managed Accounts: $accountsList")

         # more method overrides can go here...
       );

# Connect to the server with clientId = 1
ib = Jib.connect(4002, 1);

# Start a background Task to process the server responses
Jib.start_reader(ib, wrap);

# Define contract
contract = Jib.Contract(symbol="GOOG",
                        secType="STK",
                        exchange="SMART",
                        currency="USD");

# Define order
order = Jib.Order();
order.action        = "BUY"
order.totalQuantity = 10
order.orderType     = "LMT"
order.lmtPrice      = 100

orderId = 1    # Should match whatever is returned by the server

# Send order
Jib.placeOrder(ib, orderId, contract, order)

# Disconnect
Jib.disconnect(ib)
```

#### Procesamiento en primer plano vs. segundo plano
Es posible procesar las respuestas del servidor ya sea dentro del proceso principal
o en una `Task` separada en segundo plano:
- **procesamiento en primer plano** se activa invocando `Jib.check_all(ib, wrap)`.
  Es responsabilidad del usuario llamarlo de forma **regular**,
  especialmente cuando los datos están llegando en streaming.
- **procesamiento en segundo plano** se inicia con `Jib.start_reader(ib, wrap)`.
  Se inicia una `Task` separada en segundo plano, que monitorea la conexión y procesa
  las respuestas a medida que llegan.

Para evitar efectos no deseados, no se deben mezclar ambos enfoques
en la misma conexión.

## Detalles de Implementación
El paquete no exporta ningún nombre, por lo que cualquier función
o tipo descrito aquí necesita ser prefijado con `Jib.*`.

Como Julia no es un lenguaje orientado a objetos, la funcionalidad del IB
`EClient` se provee aquí mediante funciones regulares. En particular:
- `connect(port, clientId, connectOptions)`: establece una conexión y devuelve
  un objeto `Connection`.
- `disconnect(::Connection)`: termina la conexión.
- `check_all(::Connection, ::Wrapper)`: procesa respuestas disponibles, **sin bloqueo**.
  Devuelve el número de mensajes procesados. **¡Debe llamarse regularmente!**
- `start_reader(::Connection, ::Wrapper)`: inicia una `Task` para procesamiento en segundo plano.
- métodos que envían solicitudes específicas al servidor.
  Consulte la documentación oficial de la clase IB `EClient` para más detalles y firmas de métodos.
  La única salvedad es recordar pasar un `Connection` como primer argumento: _p.ej._
  `reqContractDetails(ib::Connection, reqId:Int, contract::Contract)`

#### [`Wrapper`](https://raw.githubusercontent.com/lbilli/Jib.jl/master/src/wrapper.jl)
Al igual que la clase oficial IB `EWrapper`, este `struct` contiene los callbacks
que se despachan cuando se procesan las respuestas.
El usuario provee las definiciones de los callbacks como argumentos clave
en el constructor, como se mostró [arriba](#usage), y/o configurando
la propiedad de una instancia existente.

Un ejemplo más completo se provee en [`simple_wrap()`](https://raw.githubusercontent.com/lbilli/Jib.jl/master/src/wrapper.jl#L130),
que se utiliza así:
```julia
using Jib: Jib, Contract, reqContractDetails, simple_wrap, start_reader

data, wrap = simple_wrap();

ib = Jib.connect(4002, 1);
start_reader(ib, wrap);

reqContractDetails(ib, 99, Contract(conId=208813720, exchange="SMART"))

# Wait for the response and then access the "ContractDetails" result:
data[:cd]
```
Gracias a los cierres (closures), `data` (un `Dict` en este caso) es accesible por todos
los métodos `wrap` así como por el programa principal. Esta es una forma de
propagar datos entrantes a diferentes partes del programa.

Para más detalles sobre las definiciones y firmas de callbacks,
consulte la documentación oficial de la clase `EWrapper` de IB.
Como referencia, las firmas exactas usadas en este paquete
se encuentran [aquí](https://raw.githubusercontent.com/lbilli/Jib.jl/master/data/wrapper_signatures.jl).

## Notas
Los callbacks generalmente se invocan con argumentos y tipos que coinciden con las firmas
descritas en la documentación oficial.
Sin embargo, hay pocas excepciones:
- `tickPrice()` tiene un argumento extra `size::Float64`,
  que tiene sentido solo cuando `TickType ∈ {BID, ASK, LAST}`.
  En estos casos, la API oficial de IB dispara un evento extra `tickSize()` en su lugar.
- `historicalData()` se invoca solo una vez por solicitud,
  presentando todos los datos históricos como un único `Vector{Bar}`,
  mientras que la API oficial de IB lo invoca fila por fila.
- `scannerData()` se invoca de manera similar una vez por solicitud con un `Vector{ScannerDataElement}`
  como argumento. En consecuencia, `scannerDataEnd()` es redundante y
  **no** se usa en este paquete.

Estas modificaciones hacen posible establecer la regla:
_un callback por respuesta del servidor_.

#### Valores faltantes
Ocasionalmente, para tipos numéricos, existe la necesidad de representar
la falta de un valor.

La API de IB no tiene una solución uniforme en todos los casos, sino que
adopta una variedad de valores centinela.
Estos pueden ser el simple `0` o el valor representable más grande
de un tipo dado como `2147483647` y `9223372036854775807`
para enteros de 32 y 64 bits respectivamente o `1.7976931348623157E308`
para punto flotante de 64 bits.

Este paquete hace un esfuerzo para usar `Nothing` incorporado en Julia
en todas las circunstancias.

#### Estructuras de Datos
Otras clases que principalmente contienen datos también se replican.
Se implementan como `struct` o `mutable struct` de Julia con nombres,
tipos y valores predeterminados que coinciden con sus equivalentes en la API de IB: _p. ej._
`Contract`, `Order`, `ComboLeg`, `ExecutionFilter`, `ScannerSubscription`
y `Condition*`.

`TagValueList` se implementan como `NamedTuple` de Julia.
Donde sea necesario un TagValue, se puede usar algo así:
```julia
tagvaluelist = (tag1="value1", tag2="value2")
# or, in case of an empty list:
emptylist = (;)
```
Los valores no necesitan ser del tipo `String`. También se permiten `Int` y `Float64`.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-06

---