# Jib

*Interactive Brokers API の Julia 実装*

`Jib` は [Julia](https://julialang.org/) ネイティブクライアントであり、
[Interactive Brokers](https://www.interactivebrokers.com/) API を実装して
TWS または IBGateway と通信します。

機能的には完全を目指していますが、レガシーバージョンはサポートしていません。

公式の IB API が最近、レガシーカスタムプロトコルに代わり
Protocol Buffers を基盤のワイヤフォーマットとして採用したことは
注目に値します。
このパッケージもそれに従い、後者のサポートは廃止されました。

現在は API バージョン `v213+` のみがサポートされており、
これは TWS バージョン `10.40` 以降に相当します。

パッケージの設計は公式の C++/Java
[IB API](https://interactivebrokers.github.io/tws-api/)
に従っており、TCP 上の非同期通信モデルをベースとしています。

## インストール
GitHub からインストールするには:
```julia
] add https://github.com/lbilli/Jib.jl
```
## 使用法
ユーザーは主に次の2つのオブジェクトと対話します：
- `Connection`：サーバーへの接続を保持するハンドル
- `Wrapper`：サーバーの応答が処理される際に呼び出されるコールバックのコンテナ

他のデータ構造、例えば `Contract` や `Order` はJuliaの `struct` として実装されており、
公式IB APIのそれぞれのクラスを反映しています。

完全な最小動作例が示されています。
このコードを動作させるには、IB TWSまたはIBGatewayのインスタンスが
ローカルマシンで動作しており、ポート `4002` で待機している必要があります。
**注意：** _デモ_または_ペーパー_アカウント推奨!! :smirk:


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
#### フォアグラウンド vs. バックグラウンド処理  
サーバーからの応答をメインプロセス内で処理することも、  
別のバックグラウンド `Task` で処理することも可能です:  
- **フォアグラウンド処理** は `Jib.check_all(ib, wrap)` を呼び出すことでトリガーされます。  
  データがストリーミングされている場合には、**定期的に**呼び出すのがユーザーの責任です。  
- **バックグラウンド処理** は `Jib.start_reader(ib, wrap)` で開始されます。  
  バックグラウンドで別の `Task` が起動し、接続を監視し応答を受信次第処理します。  
  
望ましくない影響を避けるために、同一接続でこれら二つのアプローチを混在させるべきではありません。  
  
## 実装の詳細  
このパッケージは名前をエクスポートしないため、ここで説明する関数や型はすべて `Jib.*` をプレフィックスとして使用してください。  
  
Julia はオブジェクト指向言語ではないため、IB の `EClient` クラスの機能は通常の関数として提供されています。具体的には:  
- `connect(port, clientId, connectOptions)`: 接続を確立し、`Connection` オブジェクトを返します。  
- `disconnect(::Connection)`: 接続を終了します。  
- `check_all(::Connection, ::Wrapper)`: 利用可能な応答を処理します。**ブロックしません**。  
  処理したメッセージ数を返します。**定期的に呼び出す必要があります！**  
- `start_reader(::Connection, ::Wrapper)`: バックグラウンド処理用に `Task` を開始します。  
- サーバーに特定のリクエストを送るメソッド群。  
  詳細およびメソッドのシグネチャについては公式の IB `EClient` クラスのドキュメントを参照してください。  
  唯一の注意点は、最初の引数に `Connection` を渡すことを忘れないことです。例:  
  `reqContractDetails(ib::Connection, reqId:Int, contract::Contract)`  
  
#### [`Wrapper`](https://raw.githubusercontent.com/lbilli/Jib.jl/master/src/wrapper.jl)  
公式の IB `EWrapper` クラスと同様に、この `struct` は応答処理時にディスパッチされるコールバックを保持します。  
ユーザーはコンストラクタのキーワード引数として、[上記](#usage) の例のようにコールバック定義を提供し、  
または既存インスタンスのプロパティを設定することで指定します。  
  
より包括的な例は [`simple_wrap()`](https://raw.githubusercontent.com/lbilli/Jib.jl/master/src/wrapper.jl#L130) にあります。  
使用例は以下の通りです:









```julia
using Jib: Jib, Contract, reqContractDetails, simple_wrap, start_reader

data, wrap = simple_wrap();

ib = Jib.connect(4002, 1);
start_reader(ib, wrap);

reqContractDetails(ib, 99, Contract(conId=208813720, exchange="SMART"))

# Wait for the response and then access the "ContractDetails" result:
data[:cd]
```
クロージャのおかげで、`data`（この場合は`Dict`）はすべての
`wrap`メソッドおよびメインプログラムからアクセス可能です。これは
受信データをプログラムの異なる部分に伝播させる一つの方法です。

コールバックの定義とシグネチャの詳細については、
公式のIB `EWrapper`クラスのドキュメントを参照してください。
参考として、このパッケージで使用されている正確なシグネチャは
[こちら](https://raw.githubusercontent.com/lbilli/Jib.jl/master/data/wrapper_signatures.jl)にあります。

## 注意点
コールバックは一般的に、公式ドキュメントに記載されているシグネチャに
一致する引数と型で呼び出されます。
ただし、いくつか例外があります：
- `tickPrice()` は追加の `size::Float64` 引数があり、
  これは `TickType ∈ {BID, ASK, LAST}` の場合にのみ意味を持ちます。
  これらの場合、公式IB APIは代わりに追加の `tickSize()` イベントを発火させます。
- `historicalData()` はリクエストごとに一度だけ呼び出され、
  すべての履歴データを単一の `Vector{Bar}` として提示しますが、
  公式IB APIは行ごとに呼び出します。
- `scannerData()` も同様にリクエストごとに一度だけ呼び出され、
  引数として `Vector{ScannerDataElement}` を取ります。
  したがって、`scannerDataEnd()` は冗長であり、
  このパッケージでは**使用されていません**。

これらの修正により、以下のルールを確立できます：
_サーバーのレスポンスごとに1つのコールバック_。

#### 欠損値
数値型において、値が存在しないことを表現する必要が
時折あります。

IB APIは統一的な解決策を持たず、
さまざまなセントネル値を採用しています。
それらは単純な `0` であったり、
32ビットおよび64ビット整数の場合はそれぞれ `2147483647` や `9223372036854775807`、
64ビット浮動小数点の場合は `1.7976931348623157E308` のような
型で表現可能な最大値であったりします。

このパッケージでは、すべての場合において
Julia組み込みの `Nothing` を使用するよう努めています。
#### データ構造
主にデータを保持する他のクラスも複製されています。  
それらはJuliaの`struct`または`mutable struct`として実装されており、名前、型、デフォルト値はIB APIの対応物と一致しています： _例_  
`Contract`、`Order`、`ComboLeg`、`ExecutionFilter`、`ScannerSubscription`  
および`Condition*`。  

`TagValueList`はJuliaの`NamedTuple`として実装されています。  
TagValueが必要な場合は、次のようなものを使用できます：

```julia
tagvaluelist = (tag1="value1", tag2="value2")
# or, in case of an empty list:
emptylist = (;)
```
値は `String` 型である必要はありません。`Int` や `Float64` も許可されています。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-06

---