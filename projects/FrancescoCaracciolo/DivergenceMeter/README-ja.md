# DivergenceMeter
現実のニュースを解析し、Steins;Gateの用語で現在の世界のダイバージェンス値を推定しようとします。
<div id="divergence-meter" style="cursor: pointer;">
  <img alt="Digit 0" class="digit" src="https://divergence.nyarchlinux.moe/images/11.gif" width="10%">
  <img alt="Digit 1" class="digit" src="https://divergence.nyarchlinux.moe/images/12.gif" width="10%">
  <img alt="Digit 2" class="digit" src="https://divergence.nyarchlinux.moe/images/11.gif" width="10%">
  <img alt="Digit 3" class="digit" src="https://divergence.nyarchlinux.moe/images/12.gif" width="10%">
  <img alt="Digit 4" class="digit" src="https://divergence.nyarchlinux.moe/images/11.gif" width="10%">
  <img alt="Digit 5" class="digit" src="https://divergence.nyarchlinux.moe/images/12.gif" width="10%">
  <img alt="Digit 6" class="digit" src="https://divergence.nyarchlinux.moe/images/11.gif" width="10%">
  <img alt="Digit 7" class="digit" src="https://divergence.nyarchlinux.moe/images/12.gif" width="10%">
</div>

- [ウェブサイト](https://divergence.nyarchlinux.moe)
- [APIドキュメント](https://divergence.nyarchlinux.moe/docs.html)
- [機能](#features)
- [スクリーンショット](#screenshots)
- [ワールドライン計算](#worldline-calculation)
- [Python例](https://github.com/FrancescoCaracciolo/DivergenceMeter/blob/main/src/client/client.py)
- [クレジット](#credits)

## 機能

- <img alt="Digit 0" class="digit" src="https://divergence.nyarchlinux.moe/images/11.gif" width="5px" /> <img alt="Digit 0" class="digit" src="https://divergence.nyarchlinux.moe/images/12.gif" width="5px" /> ウェブサイトは<a href="https://divergence.nyarchlinux.moe">https://divergence.nyarchlinux.moe</a>で閲覧可能です。 
- 🔄 **自動更新**: カウンターは15分ごとに自動で更新されます
- 🗞 **ニューステーブル**: 世界のニュースがタイムラインにどのように影響するかを確認できます
- 📊 **プロット**: 時間経過に伴うワールドラインの推定値を表示
- 🔉 **サウンド**: ワールドラインの推定が変わるとVNの音が再生されます
- 🪶 **ライトモード**: <a href="https://divergence.nyarchlinux.moe/lite.html">ライトモードが利用可能</a>で、リソースを消費するプロットを表示しません
- 🛠 **無料かつ公開API**: 測定値をプロジェクトに組み込みましょう。カスタムウィジェット、リアルワールドのダイバージェンスメーター、アプリなど多用途に活用可能！  
ダイバージェンスカウンターは15分ごとに自動でリフレッシュされます。<a href="https://divergence.nyarchlinux.moe/docs.html">APIドキュメント</a>
- ⏳ **分析間隔**: 15分ごとに現在の世界のニュースを分析し、現在のワールドラインのダイバージェンスを推定します

## スクリーンショット
**Divergence Meter**
![image](https://github.com/user-attachments/assets/4dfacc07-6d5e-4e66-9450-ada057e17725)

**ワールドラインステータスレポート**
![image](https://github.com/user-attachments/assets/2ee7c178-d182-4075-a9be-5e298bf83dbb)

**ダイバージェンスプロット**
![image](https://github.com/user-attachments/assets/abe100b6-4d88-46de-838a-f2a8227be1aa)

## ワールドライン計算
Steins;Gateでは、ダイバージェンスはワールドライン間の重力値の差から計算されます。
私はリーディングシュタイナーを持っていない（少なくとも私の知る限り）し、まだどのワールドラインにも旅していないため、ワールドラインは**推定**であり、
世界のニュースを使って推定しています。ニュースは世界ニュース、科学ニュース、地域ニュースを含む複数のRSSフィードから取得しています。

**ネタバレ注意**: これから示す方程式はChaos;Headで示された方程式の解釈に基づいています。方程式自体はネタバレではありませんが、検索するとChaos;Headのビジュアルノベルのネタバレに繋がる可能性があります。また、これらの概念の一部はSteins;GateのVNに対する軽いネタバレかもしれません。

**注記**: ここでの理論の一部はSciAdvシリーズと整合性のあるように作られています。

#### 基本理論
**仮定**: 各イベント $e$ は独立したダイバージェンス $d$ を持つ。これはイベント $e$ が最も強いアトラクターを持つワールドラインです。小さなイベントは適切なアトラクターフィールドを持たないが、他のワールドラインに影響を与えます。
例えば、Steins;GateではSERNのディストピアは独立したダイバージェンス0を持ちます。ワールドラインが0に近いほど、その結果に早く到達します。

#### ニュース分析
各ニュースはイベント $e$ が起きたことを記録します。（ニュースが発行された事実自体がイベント $e$ と見なせます）
各ニュースはアトラクターフィールド（例えば $\alpha$, $\beta$, ...）に分類され、どのアトラクターフィールドに属する可能性が高いかに基づきます。また、各ニュースにはそのアトラクターフィールドに対する影響度 $Im$ と、アトラクターフィールドの中心にどれだけ近いかを示すフィールドアトラクション $Fa$ が割り当てられます。

#### 独立ダイバージェンス計算
1. イベント $e$ の独立ダイバージェンスを計算するために、$Ir2$ の方程式から始めます：

$$Ir2 = fun^{10}*int^{40}$$

これはChaos;Headからの、世界を分岐させる基礎的な方程式です。
VN内ではこの方程式の意味は説明されていません（Ir2は「目は二つ」という意味を持つ以外）。ディラック海に関連すると考えると、次のように説明可能です：
- $Ir$ は真空領域の情報率。情報率が高いほど複雑で動的な真空構造を意味します。
- $fun$ はフィールドの均一性番号。均一でないフィールドはより多くの勾配やポテンシャルを持ち、粒子生成や相互作用に利用可能なエネルギーが多いことを示します。
- $int$ はディラック海状態の相互接続度。これは負のエネルギー状態がどれだけリンクまたは相関しているかを表します。

ダイバージェンス $d$ は真空の情報状態の変化の結果と仮定できます。重力も影響を受けるためです。
したがって、$d \propto Ir$ と仮定できます。定数 $k_1$ が存在し：

$$d = k_1 * Ir2$$

2. $Ir2$ の式を $d$ の定義に代入します：

  $$d = k_1 \cdot (fun^{10} * int^{40})$$

3. 次の関係を仮定します：
    *   **影響度（`Im`）と均一性（`fun`）:** 影響度の高いニュースイベント ($Im$) は局所的な真空フィールドを乱し、均一性 ($fun$) を下げます。逆比例としてモデル化可能です：

        $$fun = \frac{C_f}{Im}$$

        ここで $C_f$ は定数です。
    *   **フィールドアトラクション ($Fa$) と相互接続度 ($int$):** 強いアトラクション ($Fa$) はイベント $e$ がディラック海状態内に効率的な経路を作り、局所的な相互接続度 ($int$) を高めることを意味し、正比例とモデル化します：

        $$int = C_i \cdot Fa$$

        ここで $C_i$ は定数です。

4. 上記の式を代入します
    ステップ3の $fun$ と $int$ の式をステップ2の $d$ の式に代入します：
   
    $$d = k_1 \cdot \left( \left( \frac{C_f}{Im} \right)^{10} \cdot (C_i \cdot Fa)^{40} \right)$$

5. 最後に定数をまとめて式を簡略化します：

    $$d = k_1 \cdot \left( \frac{C_f^{10}}{Im^{10}} \cdot C_i^{40} \cdot Fa^{40} \right)$$
    $$d = (k_1 \cdot C_f^{10} \cdot C_i^{40}) \cdot \frac{Fa^{40}}{Im^{10}}$$

6. 新しい定数を作成します。これを発散定数 $K_d = k_1 \cdot C_f^{10} \cdot C_i^{40}$ と呼びます。
    独立発散 $d$ を計算する最終式は次の通りです：
   
    $$d = K_d \frac{Fa^{40}}{Im^{10}}$$

#### ワールドラインの更新
現在のワールドラインを推定するためには、ニュースが届き次第すぐに分析し、それらのニュースの独立発散に基づいて現在の発散を更新しなければなりません。
この目的のために、修正された加重オンライン勾配降下法が使用されます。

$$d(t) = d(t-1) - Im * \eta \nabla L(d(t-1))$$

## クレジット
- 発散に関する情報の一部は[Steins;Gate Wiki](https://steins-gate.fandom.com/wiki/Steins;Gate_Wiki)より
- 画像やGIFは[LuqueDaniel/Divergence-Meter](https://github.com/LuqueDaniel/Divergence-Meter/tree/master)より
- [SciAdv シリーズ](https://wikipedia.org/wiki/Science_Adventure)に感謝

プロジェクトを支援したい場合は、⭐️をお願いします

<a href="https://nyarchlinux.moe">Nyarch Linux</a> リード開発者による ❤️ を込めて作成しました



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---