# Jib

*一个 Julia 实现的 Interactive Brokers API*

`Jib` 是一个原生的 [Julia](https://julialang.org/) 客户端，实现了
[Interactive Brokers](https://www.interactivebrokers.com/) API，用于与
TWS 或 IBGateway 通信。

它旨在功能完整，但不支持旧版本。

值得一提的是，官方 IB API 最近采用了
Protocol Buffers 作为底层传输格式，取代了旧的自定义协议。
本包也随之更新，不再支持旧协议。

目前仅支持 API 版本 `v213+`，对应 TWS 版本 `10.40` 或更高。

该包的设计遵循官方 C++/Java
[IB API](https://interactivebrokers.github.io/tws-api/)，
基于 TCP 的异步通信模型。

## 安装
从 GitHub 安装：

```julia
] add https://github.com/lbilli/Jib.jl
```
## 使用方法
用户主要与以下两个对象交互：
- `Connection`：一个持有与服务器连接的句柄
- `Wrapper`：一个包含回调函数的容器，
   当服务器响应被处理时调用这些回调。

其他数据结构，如 `Contract` 和 `Order`，实现为 Julia 的 `struct`
并且对应官方 IB API 中的相应类。

以下展示了一个完整的最小可运行示例。
要使该代码运行，需在本地机器上运行 IB TWS 或 IBGateway 实例，
并监听端口 `4002`。
**注意：** _推荐使用演示_或_模拟_账户！！ :smirk:

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

#### 前台与后台处理
可以在主进程中或单独的后台 `Task` 中处理服务器响应：
- **前台处理** 通过调用 `Jib.check_all(ib, wrap)` 触发。
  用户有责任**定期调用**它，
  尤其是在数据流入时。
- **后台处理** 通过 `Jib.start_reader(ib, wrap)` 启动。
  在后台启动一个单独的 `Task`，监控连接并处理
  到达的响应。

为了避免不良影响，不应在同一连接上混合使用这两种方法。

## 实现细节
该包不导出任何名称，因此这里描述的任何函数
或类型都需要以 `Jib.*` 为前缀。

由于 Julia 不是面向对象的语言，IB 的
`EClient` 类的功能通过常规函数提供。具体而言：
- `connect(port, clientId, connectOptions)`：建立连接并返回
  一个 `Connection` 对象。
- `disconnect(::Connection)`：终止连接。
- `check_all(::Connection, ::Wrapper)`：处理可用响应，**非阻塞**。
  返回处理的消息数量。**需要定期调用！**
- `start_reader(::Connection, ::Wrapper)`：启动后台处理的 `Task`。
- 发送特定请求到服务器的方法。
  详情和方法签名请参阅官方 IB `EClient` 类文档。
  唯一的注意事项是记得将 `Connection` 作为第一个参数传入：例如
  `reqContractDetails(ib::Connection, reqId:Int, contract::Contract)`

#### [`Wrapper`](https://raw.githubusercontent.com/lbilli/Jib.jl/master/src/wrapper.jl)
与官方 IB `EWrapper` 类类似，该 `struct` 保存了
处理响应时分发的回调。
用户在构造函数中以关键字参数形式提供回调定义，
如上文所示 [上文](#usage)，和/或通过设置
现有实例的属性。

更全面的示例由 [`simple_wrap()`](https://raw.githubusercontent.com/lbilli/Jib.jl/master/src/wrapper.jl#L130) 提供，
用法如下：


```julia
using Jib: Jib, Contract, reqContractDetails, simple_wrap, start_reader

data, wrap = simple_wrap();

ib = Jib.connect(4002, 1);
start_reader(ib, wrap);

reqContractDetails(ib, 99, Contract(conId=208813720, exchange="SMART"))

# Wait for the response and then access the "ContractDetails" result:
data[:cd]
```
得益于闭包，`data`（在此案例中为一个 `Dict`）可以被所有
`wrap` 方法以及主程序访问。这是一种将传入数据传递给程序不同部分的方法。

有关回调定义和签名的更多详细信息，
请参阅官方 IB `EWrapper` 类文档。
作为参考，本包中使用的确切签名
可在[此处](https://raw.githubusercontent.com/lbilli/Jib.jl/master/data/wrapper_signatures.jl)找到。

## 说明
回调通常以与官方文档中描述的签名
匹配的参数和类型被调用。
不过，有几个例外：
- `tickPrice()` 有一个额外的 `size::Float64` 参数，
  仅当 `TickType ∈ {BID, ASK, LAST}` 时才有意义。
  在这些情况下，官方 IB API 会触发一个额外的 `tickSize()` 事件。
- `historicalData()` 每个请求只调用一次，
  以一个包含所有历史数据的单个 `Vector{Bar}` 作为参数，
  而官方 IB API 是逐行调用的。
- `scannerData()` 也类似，每个请求调用一次，参数为 `Vector{ScannerDataElement}`。
  因此，`scannerDataEnd()` 是多余的，
  并且本包**不**使用它。

这些修改使得可以确立如下规则：
_每个服务器响应对应一个回调_。

#### 缺失值
有时，对于数值类型，需要表示
缺少值的情况。

IB API 并没有统一的解决方案，
而是采用了各种哨兵值。
它们可能是简单的 `0`，或者是给定类型的最大可表示值，
例如 32 位和 64 位整数分别为 `2147483647` 和 `9223372036854775807`，
64 位浮点数为 `1.7976931348623157E308`。

本包尽力在所有情况下使用 Julia 内置的 `Nothing`。




#### 数据结构
其他主要用于存储数据的类也被复刻。
它们被实现为 Julia 的 `struct` 或 `mutable struct`，名称、
类型和默认值与 IB API 对应项匹配，例如
`Contract`、`Order`、`ComboLeg`、`ExecutionFilter`、`ScannerSubscription`
和 `Condition*`。

`TagValueList` 被实现为 Julia 的 `NamedTuple`。
无论何时需要 TagValue，都可以使用类似如下内容：
```julia
tagvaluelist = (tag1="value1", tag2="value2")
# or, in case of an empty list:
emptylist = (;)
```
值不需要是 `String` 类型。`Int` 和 `Float64` 也被允许。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-06

---