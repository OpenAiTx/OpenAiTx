# <img src="https://brands.home-assistant.io/illuminance/icon.png" alt="Sun2 Sensor" width="50" height="50"/> 照度センサー
太陽高度または時刻に基づいて屋外の照度を推定する `sensor` エンティティを作成します。
いずれの場合も、値は別の既存のエンティティから取得した現在の天候条件や雲量に基づいてさらに調整できます。


## 動作モード
3つのモードが利用可能です：通常、放射照度、シンプル。

### 通常/放射照度モード - 太陽高度
これらのモードは、米国海軍天文台[^1] のアルゴリズムを使用して、太陽の高度（別名：仰角）に基づいて太陽の照度または放射照度を推定します。最大照度値は約150,000 lx、最大放射照度値は約1,250 ワット/㎡です。
以下は3日間の照度の例です。

<p align="center">
  <img src=images/normal.png>
</p>

[^1]: Janiczek, P. M., and DeYoung, J. A. _Computer Programs for Sun and Moon Illuminance With Contingent Tables and Diagrams_. Circular No. 171. Washington, D. C.: United States Naval Observatory, 1987 [Google Scholar](https://scholar.google.com/scholar_lookup?title=Computer%20programs%20for%20sun%20and%20moon%20illuminance%20with%20contingent%20tables%20and%20diagrams&author=P.%20M.%20Janiczek&author=J.%20A.%20Deyoung&publication_year=1987&book=Computer%20programs%20for%20sun%20and%20moon%20illuminance%20with%20contingent%20tables%20and%20diagrams)

### シンプルモード - 時刻
夜間の値は10 lxです。日の出前後の少しの間に、値は現在の条件に応じて上昇します。日の入り前後も同様ですが、値は減少します。歴史的な理由から、最大値は10,000 lxです。以下は3日間の例です。

<p align="center">
  <img src=images/simple.png>
</p>

## 対応している天気情報ソース
[標準の条件リスト](https://www.home-assistant.io/integrations/weather/#condition-mapping) を使用する、または雲量のパーセンテージを提供する任意の天気エンティティは、この統合で動作するはずです。
以下の天気データソースが対応していることが確認されています：

統合 | 備考
-|-
[AccuWeather](https://www.home-assistant.io/integrations/accuweather/) | `weather`
[Buienradar](https://www.home-assistant.io/integrations/buienradar/) | `weather`
[ecobee](https://www.home-assistant.io/integrations/ecobee/) |
[Meteorologisk institutt (Met.no)](https://www.home-assistant.io/integrations/met/) | `weather`
[OpenWeatherMap](https://www.home-assistant.io/integrations/openweathermap/) | `weather`; cloud_coverage と condition の `sensor`

## インストール

統合ソフトウェアはまずカスタムコンポーネントとしてインストールする必要があります。
HACSを使用してインストールを管理し、更新通知を受け取ることができます。  
または、ソフトウェアを手動でインストールすることも可能です。  

<details>  
<summary>HACSを使用する場合</summary>  

[![hacs_badge](https://img.shields.io/badge/HACS-Custom-41BDF5.svg)](https://hacs.xyz/)  

1. このリポジトリを[カスタムリポジトリ](https://hacs.xyz/docs/faq/custom_repositories/)として追加します。  
   そうすると新しい統合として表示されます。クリックしてください。必要に応じて「illuminance」で検索します。
   ```text
   https://github.com/pnbruckner/ha-illuminance
   ```
   またはこちらのボタンを使用してください：
  
   [![Home Assistant インスタンスを開き、Home Assistant Community Store 内のリポジトリを開きます。](https://my.home-assistant.io/badges/hacs_repository.svg)](https://my.home-assistant.io/redirect/hacs_repository/?owner=pnbruckner&repository=ha-illuminance&category=integration)

1. 適切なボタンを使用して統合をダウンロードしてください。

</details>

<details>
<summary>手動インストール</summary>

[`custom_components/illuminance`](custom_components/illuminance) からファイルのコピーを  
`<config>/custom_components/illuminance` に配置してください。  
ここで `<config>` はあなたの Home Assistant の設定ディレクトリです。

>__注意__: ダウンロード時は、各ファイルのページの `Raw` ボタンを必ず使用してください。

</details>

### インストール後

ダウンロード後、Home Assistant を再起動する必要があります。

### バージョン

このカスタム統合は HomeAssistant バージョン 2024.8.3 以降をサポートしています。

## サービス

### `illuminance.reload`

YAML 設定から Illuminance をリロードします。また、開発者ツール -> YAML ページに `ILLUMINANCE` を追加します。

## 設定変数

1つ以上のセンサーの設定オプションのリストです。各センサーは以下のオプションで定義されます。

> 注意: これは YAML による設定を定義しますが、同じセンサーは UI からも追加可能です。

キー | オプション | 説明
-|-|-
`unique_id` | いいえ | センサーの一意識別子。これにより、他のオプションを変更しても新しいセンサーのように見えません。（YAMLベースの設定でのみ必要。）
`entity_id` | はい | 現在の天気条件または雲量のパーセンテージを示す別のエンティティのID
`fallback` | はい | 天気データが利用できない場合に使用する照度除数。範囲は1（晴れ）から10（暗い）まで。`entity_id`が使用されている場合のデフォルトは10、そうでない場合は1。
`mode` | はい | 動作モード。選択肢は、太陽の高度を使う`normal`（デフォルト）、時刻を使う`simple`、および値がワット毎平方メートルの放射照度で表される`irradiance`（`normal`と同じ）です。
`name` | はい | センサーの名前。デフォルトは`Illuminance`。
`scan_interval` | はい | 更新間隔。最小は30秒。デフォルトは5分。

## 2.1.0以前のリリース
https://github.com/pnbruckner/homeassistant-config/blob/master/docs/illuminance.md を参照してください。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-28

---