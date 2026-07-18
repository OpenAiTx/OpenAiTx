# bevy_dev_console

`bevy_dev_console` は [Bevy Game Engine](https://github.com/bevyengine/bevy) 向けの Source に触発された開発者コンソールプラグインです。

![開発者コンソールの画像](https://raw.githubusercontent.com/doonv/bevy_dev_console/master/doc/console.png)

> [!WARNING]  
>
> `bevy_dev_console` は現在初期開発段階にあります。近い将来（特に組み込みコマンドパーサー使用時）に破壊的変更が予想されます。そのため、現時点では git パッケージとしてのみ利用可能です。

## 機能

- ログ表示
  - ログメッセージの隠れた全データをホバーで確認可能。
- `bevy_dev_console` 専用に設計された強力な組み込みパーサー言語。 ([ドキュメント](https://github.com/doonv/bevy_dev_console/wiki/Built%E2%80%90in-Parser))
  - 計算
  - 変数
    - 簡略化された所有権と借用を使用
  - 標準ライブラリ（現時点ではあまり多くない）
  - [カスタムネイティブ関数](https://github.com/doonv/bevy_dev_console/blob/master/examples/custom_functions.rs)（`World` へのアクセスも含む！）
  - [多様な型](https://github.com/doonv/bevy_dev_console/wiki/Built%E2%80%90in-Parser#types)
  - リソースの閲覧と修正
    - 列挙型
    - 構造体
  - ~~エンティティクエリ~~ [*近日公開予定...*](https://github.com/doonv/bevy_dev_console/issues/3)（構文の提案歓迎！）
  - …その他多数！

## 使用方法

1. `bevy_dev_console` git パッケージを追加。

    ```bash
    cargo add --git https://github.com/doonv/bevy_dev_console.git
    ```

2. `prelude` をインポートします。

    ```rust
    use bevy_dev_console::prelude::*;
    ```

3. プラグインを追加します。

    ```rust,no_run
    use bevy::{prelude::*, log::LogPlugin};
    use bevy_dev_console::prelude::*;

    App::new()
        .add_plugins((
            // Add the log plugin with the custom log layer
            DefaultPlugins.set(LogPlugin {
                custom_layer: custom_log_layer,
                ..default()
            }),
            // Add the dev console plugin itself.
            DevConsolePlugin,
        ))
        .run();
    ```

4. これで完了です！キーボードの `` ` `` / `~` キーを押すとコンソールが開くはずです！

## 切り替え可能な機能

**(デフォルト)** `builtin-parser` はデフォルトのパーサーを含みます。これを無効にすると、組み込みパーサーを削除して自分のパーサーに置き換えることができます（または何もせずコンソールをログリーダーにすることも可能です）。

## Bevy 互換性

| bevy   | bevy_dev_console |
| ------ | ---------------- |
| 0.14.* | git (master)     |


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-18

---