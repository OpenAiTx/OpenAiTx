# Wyvernbox

多用途インベントリシステム用のアドオン。

必要なシーンは `addons/wyvernbox_prefabs` 内にあります。ドラッグ＆ドロップするだけ！

`example/wyvernbox` フォルダには開始用のいくつかのアイテムと装備ステータスが含まれています。例のシーンもぜひ確認してください！

## 必要なもの:

- いずれかの `InventoryView` オブジェクト、
- アイテムを調べるための `InventoryTooltip`（*いくつかの `TooltipProperty` スクリプトをアタッチしても良い*）、
- マウスでアイテムを移動させるための `GrabbedItemStackView`、
- そしてアイテムタイプを定義するいくつかの `ItemType` リソース。

## 動作原理:

- `InventoryView` は対応するタイプの `Inventory` とユーザーインタラクションを提供する；
- Inventory は `ItemStack` を保持する；
- ItemStack は `ItemType` から作成される。
- ItemType はデフォルトデータを保存し、クラフトレシピやアイテムジェネレーターで使われる。

## 特徴:

- GUIコンテナと互換性のある多様なインベントリ、例えば：
  - ベーシック
  - グリッド（*アイテムはタイルの長方形を占める*）
  - 制限付き（*装備や弾薬など特定のフラグを持つアイテムのみ配置可能*）
  - 通貨（*カスタムの最大スタックサイズ、ただし指定されたアイテムのみ*）

- クラフトとショップ：
  - ベンディングはインベントリの組み込み機能ですが、より詳細な設定には `InventoryVendor` クラスを使用！
  - クラフトレシピは `ItemConversion` を通じて定義される — 事前決定された結果、ランダムな数、または `ItemGenerator` からの新規生成が可能！
  - `ItemPattern` を使って、異なる燃料効率など複数のアイテムをフィルタやレシピでマッチング！

- **ジェスチャー**: クイック転送（Shift-クリック）、同種アイテム全収集・転送（ダブルクリック）、1個または半分に分割（右クリック）
- 多機能な `ItemPattern` クラスで地面とインベントリ内のアイテムをフィルタリング！インベントリ挿入やクラフト入力の制御に使用可能。
- カスタムインスペクターのテーブルでアイテムとあなたのクラスの値をマッピング — ShopManager、ItemGenerator、ItemPattern オブジェクトで使用！プロジェクトからアイテムタイプ、ジェネレーター、パターンをドラッグ＆ドロップできるアイテムブラウザポップアップ付き。
- `TooltipProperty` クラスでツールチップを拡張可能！スクリプトを大量に付けるだけ。

#
2022年、Don Tnowe 制作。

[私のウェブサイト](https://redbladegames.netlify.app)

[Itch](https://don-tnowe.itch.io)

[Twitter](https://twitter.com/don_tnowe)

**助けが必要、または話したい？メッセージをどうぞ！** [Telegram](https://t.me/don_tnowe), [Discord](https://discord.com/channels/@me/726139164566880426)

**このツールがとても役立ったなら支援をお願いします！** [PayPalで寄付](https://redbladegames.netlify.app/tip/index.html)

#

MITライセンスに基づき、特に指定がない限りコピーと改変は許可されています。ライセンス文を同梱。

例で使用しているフォントは [Abaddon、クリエイティブ・コモンズ 表示 3.0 ライセンス](https://caffinate.itch.io/abaddon) です。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-25

---