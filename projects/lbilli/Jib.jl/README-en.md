# Jib

*A Julia implementation of Interactive Brokers API*

`Jib` is a native [Julia](https://julialang.org/) client that implements
[Interactive Brokers](https://www.interactivebrokers.com/) API to communicate
with TWS or IBGateway.

It aims to be feature complete, however it does not support legacy versions.

It is noteworthy to mention that the official IB API has recently adopted
Protocol Buffers as the underlying wire format, replacing the legacy custom protocol.
This package followed suit and support for the latter has been dropped.

Currently, only API versions `v213+` are supported, which translates to
TWS version `10.40` or later.

The package design follows the official C++/Java
[IB API](https://interactivebrokers.github.io/tws-api/),
which is based on an asynchronous communication model over TCP.

## Installation
To install from GitHub:
```julia
] add https://github.com/lbilli/Jib.jl
```
## Usage
The user interacts mainly with these two objects:
- `Connection`: a handle holding a connection to the server
- `Wrapper`: a container for the callbacks that are invoked
   when the server responses are processed.

Other data structures, such as `Contract` and `Order`, are implemented as Julia `struct`
and mirror the respective classes in the official IB API.

A complete minimal working example is shown.
For this code to work, an instance of IB TWS or IBGateway needs to be running
on the local machine and listening on port `4002`.
**Note:** _demo_ or _paper_ account recommended!! :smirk:

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

#### Foreground vs. Background Processing
It is possible to process the server responses either within the main process
or in a separate background `Task`:
- **foreground processing** is triggered by invoking `Jib.check_all(ib, wrap)`.
  It is the user's responsibility to call it on a **regular basis**,
  especially when data are streaming in.
- **background processing** is started by `Jib.start_reader(ib, wrap)`.
  A separate `Task` is started in the background, which monitors the connection and processes
  the responses as they arrive.

To avoid undesired effects, the two approaches should not be mixed together
on the same connection.

## Implementation Details
The package does not export any name, therefore any functions
or types described here need to be prefixed by `Jib.*`.

As Julia is not an object-oriented language, the functionality of the IB
`EClient` class is provided here by regular functions. In particular:
- `connect(port, clientId, connectOptions)`: establish a connection and return
  a `Connection` object.
- `disconnect(::Connection)`: terminate the connection.
- `check_all(::Connection, ::Wrapper)`: process available responses, **not blocking**.
  Return the number of messages processed. **Needs to be called regularly!**
- `start_reader(::Connection, ::Wrapper)`: start a `Task` for background processing.
- methods that send specific requests to the server.
  Refer to the official IB `EClient` class documentation for further details and method signatures.
  The only caveat is to remember to pass a `Connection` as first argument: _e.g._
  `reqContractDetails(ib::Connection, reqId:Int, contract::Contract)`

#### [`Wrapper`](https://raw.githubusercontent.com/lbilli/Jib.jl/master/src/wrapper.jl)
Like the official IB `EWrapper` class, this `struct` holds the callbacks
that are dispatched when responses are processed.
The user provides the callback definitions as keyword arguments
in the constructor, as shown [above](#usage), and/or by setting
the property of an existing instance.

A more comprehensive example is provided by [`simple_wrap()`](https://raw.githubusercontent.com/lbilli/Jib.jl/master/src/wrapper.jl#L130),
which is used like this:
```julia
using Jib: Jib, Contract, reqContractDetails, simple_wrap, start_reader

data, wrap = simple_wrap();

ib = Jib.connect(4002, 1);
start_reader(ib, wrap);

reqContractDetails(ib, 99, Contract(conId=208813720, exchange="SMART"))

# Wait for the response and then access the "ContractDetails" result:
data[:cd]
```
Thanks to closures, `data` (a `Dict` in this case) is accessible by all
`wrap` methods as well as the main program. This is one way to
propagate incoming data to different parts of the program.

For more details about callback definitions and signatures,
refer to the official IB `EWrapper` class documentation.
As reference, the exact signatures used in this package
are found [here](https://raw.githubusercontent.com/lbilli/Jib.jl/master/data/wrapper_signatures.jl).

## Notes
Callbacks are generally invoked with arguments and types matching the signatures
as described in the official documentation.
However, there are few exceptions:
- `tickPrice()` has an extra `size::Float64` argument,
  which is meaningful only when `TickType ∈ {BID, ASK, LAST}`.
  In these cases, the official IB API fires an extra `tickSize()` event instead.
- `historicalData()` is invoked only once per request,
  presenting all the historical data as a single `Vector{Bar}`,
  whereas the official IB API invokes it row-by-row.
- `scannerData()` is similarly invoked once per request with a `Vector{ScannerDataElement}`
  as argument. Consequently, `scannerDataEnd()` is redundant and
  it is **not** used in this package.

These modifications make it possible to establish the rule:
_one callback per server response_.

#### Missing Values
Occasionally, for numerical types, there is the need to represent
the lack of a value.

IB API does not have a uniform solution across the board, but rather
it adopts a variety of sentinel values.
They can be either the plain `0` or the largest representable value
of a given type such as `2147483647` and `9223372036854775807`
for 32- and 64-bit integers respectively or `1.7976931348623157E308`
for 64-bit floating point.

This package makes an effort to use Julia built-in `Nothing`
in all circumstances.

#### Data Structures
Other classes that mainly hold data are also replicated.
They are implemented as Julia `struct` or `mutable struct` with names,
types and default values matching the IB API counterparts: _e.g._
`Contract`, `Order`, `ComboLeg`, `ExecutionFilter`, `ScannerSubscription`
and `Condition*`.

`TagValueList` are implemented as Julia `NamedTuple`.
Wherever a TagValue is needed, something like this can be used:
```julia
tagvaluelist = (tag1="value1", tag2="value2")
# or, in case of an empty list:
emptylist = (;)
```
Values don't need to be of type `String`. `Int` and `Float64` are also allowed.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-06

---