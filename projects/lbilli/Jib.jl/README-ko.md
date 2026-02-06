# Jib

*Interactive Brokers API의 Julia 구현체*

`Jib`는 TWS 또는 IBGateway와 통신하기 위해
[Interactive Brokers](https://www.interactivebrokers.com/) API를 구현한
네이티브 [Julia](https://julialang.org/) 클라이언트입니다.

기능적으로 완전함을 목표로 하지만, 레거시 버전은 지원하지 않습니다.

공식 IB API가 최근 프로토콜 버퍼(Protocol Buffers)를 기본 전송 형식으로 채택하여
기존의 커스텀 프로토콜을 대체했다는 점도 주목할 만합니다.
이 패키지도 이를 따라 후자를 지원하지 않게 되었습니다.

현재는 API 버전 `v213+`만 지원하며, 이는
TWS 버전 `10.40` 이상에 해당합니다.

패키지 설계는 비동기 통신 모델을 기반으로 하는 공식 C++/Java
[IB API](https://interactivebrokers.github.io/tws-api/)를 따릅니다.

## 설치
GitHub에서 설치하려면:

```julia
] add https://github.com/lbilli/Jib.jl
```
## 사용법
사용자는 주로 이 두 객체와 상호작용합니다:
- `Connection`: 서버와의 연결을 유지하는 핸들
- `Wrapper`: 서버 응답이 처리될 때 호출되는 콜백을 담는 컨테이너

`Contract` 및 `Order`와 같은 다른 데이터 구조체는 Julia `struct`로 구현되어 있으며
공식 IB API의 해당 클래스와 동일하게 설계되었습니다.

완전한 최소 작동 예제가 제시됩니다.
이 코드가 작동하려면 로컬 머신에서 IB TWS 또는 IBGateway 인스턴스가 실행 중이어야 하며
포트 `4002`를 수신 대기해야 합니다.
**참고:** _데모_ 또는 _페이퍼_ 계정 사용을 권장합니다!! :smirk:


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
#### 전경 처리 vs. 배경 처리  
서버 응답을 메인 프로세스 내에서 처리하거나  
별도의 배경 `Task`에서 처리할 수 있습니다:  
- **전경 처리**는 `Jib.check_all(ib, wrap)`을 호출하여 트리거됩니다.  
  특히 데이터가 스트리밍될 때 **정기적으로** 호출하는 것은 사용자 책임입니다.  
- **배경 처리**는 `Jib.start_reader(ib, wrap)`에 의해 시작됩니다.  
  별도의 `Task`가 배경에서 시작되어 연결을 모니터링하고  
  응답이 도착하면 처리합니다.  
  
원하지 않는 효과를 피하기 위해 같은 연결에서 두 접근 방식을 혼용하지 않아야 합니다.  
  
## 구현 세부사항  
이 패키지는 어떤 이름도 내보내지 않으므로, 여기서 설명하는 함수나  
타입은 모두 `Jib.*` 접두어를 붙여야 합니다.  
  
Julia는 객체지향 언어가 아니므로, IB의 `EClient` 클래스 기능은  
일반 함수로 제공됩니다. 특히:  
- `connect(port, clientId, connectOptions)`: 연결을 설정하고  
  `Connection` 객체를 반환합니다.  
- `disconnect(::Connection)`: 연결을 종료합니다.  
- `check_all(::Connection, ::Wrapper)`: 사용 가능한 응답을 처리하며, **블로킹하지 않습니다.**  
  처리한 메시지 개수를 반환합니다. **정기적으로 호출해야 합니다!**  
- `start_reader(::Connection, ::Wrapper)`: 배경 처리를 위한 `Task`를 시작합니다.  
- 서버에 특정 요청을 보내는 메서드들.  
  자세한 내용과 메서드 시그니처는 공식 IB `EClient` 클래스 문서를 참조하세요.  
  유의할 점은 첫 번째 인자로 `Connection`을 전달해야 한다는 것입니다: _예를 들어_  
  `reqContractDetails(ib::Connection, reqId:Int, contract::Contract)`  
  
#### [`Wrapper`](https://raw.githubusercontent.com/lbilli/Jib.jl/master/src/wrapper.jl)  
공식 IB `EWrapper` 클래스처럼, 이 `struct`는  
응답이 처리될 때 호출되는 콜백들을 보유합니다.  
사용자는 생성자에서 키워드 인수로 콜백 정의를 제공하거나  
기존 인스턴스의 프로퍼티를 설정하여 정의할 수 있습니다.  
  
더 포괄적인 예시는 [`simple_wrap()`](https://raw.githubusercontent.com/lbilli/Jib.jl/master/src/wrapper.jl#L130)  
에서 제공하며, 다음과 같이 사용됩니다:




```julia
using Jib: Jib, Contract, reqContractDetails, simple_wrap, start_reader

data, wrap = simple_wrap();

ib = Jib.connect(4002, 1);
start_reader(ib, wrap);

reqContractDetails(ib, 99, Contract(conId=208813720, exchange="SMART"))

# Wait for the response and then access the "ContractDetails" result:
data[:cd]
```
클로저 덕분에 `data`(이 경우 `Dict`)는 모든 `wrap` 메서드와 메인 프로그램에서 접근할 수 있습니다.  
이는 들어오는 데이터를 프로그램의 다양한 부분으로 전파하는 한 가지 방법입니다.  

콜백 정의 및 서명에 대한 자세한 내용은 공식 IB `EWrapper` 클래스 문서를 참조하세요.  
참고로, 이 패키지에서 사용되는 정확한 서명은  
[여기](https://raw.githubusercontent.com/lbilli/Jib.jl/master/data/wrapper_signatures.jl)에서 확인할 수 있습니다.  

## 참고 사항  
콜백은 일반적으로 공식 문서에 기술된 서명과 일치하는 인수 및 타입으로 호출됩니다.  
하지만 몇 가지 예외가 있습니다:  
- `tickPrice()`는 추가 `size::Float64` 인수를 가지며,  
  이는 `TickType ∈ {BID, ASK, LAST}`일 때만 의미가 있습니다.  
  이 경우 공식 IB API는 대신 추가 `tickSize()` 이벤트를 발생시킵니다.  
- `historicalData()`는 요청당 한 번만 호출되며,  
  모든 히스토리 데이터를 단일 `Vector{Bar}`로 제공합니다.  
  반면 공식 IB API는 데이터를 행 단위로 호출합니다.  
- `scannerData()` 역시 요청당 한 번 호출되며, 인수로 `Vector{ScannerDataElement}`를 받습니다.  
  따라서 `scannerDataEnd()`는 중복되어 이 패키지에서는 **사용하지 않습니다**.  

이러한 변경사항은 다음 규칙을 확립할 수 있게 합니다:  
_서버 응답당 하나의 콜백_.  

#### 누락된 값  
가끔 수치형 타입에서 값이 없음을 표현해야 할 필요가 있습니다.  

IB API는 일관된 해결책이 없으며,  
다양한 센티넬 값을 사용합니다.  
이는 단순한 `0`이거나, 주어진 타입의 최대 표현 가능한 값일 수 있습니다.  
예를 들어 32비트 및 64비트 정수의 경우 각각 `2147483647` 및 `9223372036854775807`,  
64비트 부동소수점의 경우 `1.7976931348623157E308` 등이 있습니다.  

이 패키지는 모든 상황에서 Julia 내장 `Nothing`을 사용하려 노력합니다.








#### 데이터 구조
주로 데이터를 보유하는 다른 클래스들도 복제됩니다.
이들은 IB API 대응물과 이름, 타입, 기본값이 일치하도록 Julia `struct` 또는 `mutable struct`로 구현됩니다: _예를 들어_ `Contract`, `Order`, `ComboLeg`, `ExecutionFilter`, `ScannerSubscription` 및 `Condition*` 등이 있습니다.

`TagValueList`는 Julia `NamedTuple`로 구현됩니다.
TagValue가 필요한 곳에서는 다음과 같은 것을 사용할 수 있습니다:



```julia
tagvaluelist = (tag1="value1", tag2="value2")
# or, in case of an empty list:
emptylist = (;)
```
값은 `String` 타입일 필요가 없습니다. `Int`와 `Float64`도 허용됩니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-06

---