![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen)
![Python 3.9+](https://img.shields.io/badge/python-3.9%2B-blue)
![Component Driven](https://img.shields.io/badge/architecture-component--driven-orange)
![Desktop App](https://img.shields.io/badge/platform-desktop-lightgrey)
![CLI Support](https://img.shields.io/badge/CLI-supported-critical)
![Live Reload](https://img.shields.io/badge/live--reload-enabled-blue)

## 画像例

![image](https://github.com/user-attachments/assets/81d016e9-e10a-4438-ab94-99b6d76b8efe)

![image](https://github.com/user-attachments/assets/154dc3f4-ea8c-4f6f-84d3-88c7ab74a46f)

![image](https://github.com/user-attachments/assets/2318f701-6ec8-4402-abcc-40c879bf1a10)

# WinUp 🚀

## 最新の安定版リリース（LSR）を必ずダウンロードしてください。最新/LFRではありません！現在のLSR：2.4.9

`pip install winup==2.4.9`

**美しいデスクトップアプリケーションを構築するための、非常にPython的で強力なフレームワーク。**

WinUpはPython向けのモダンなUIフレームワークで、PySide6（Qt）のパワーをシンプルで宣言的、開発者に優しいAPIでラップしています。アプリケーションの構築をより速く、コードをよりクリーンに、開発プロセスをより楽しくするよう設計されています。

### ✨ 今やWebサポートも！
WinUpは同じPython中心のコンポーネントベースアプローチを用いて、完全にインタラクティブで状態を持つWebアプリケーションの構築もサポートします。WebモジュールはFastAPIとWebSocketsを内部で使用し、WinUpのシンプルさをブラウザに持ち込みます。

[Webドキュメント](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/web/README.md)

> **免責事項：** Webサポートはオプション機能です。使用するにはweb依存関係をインストールしてください：
> ```bash
> pip install "winup[web]"
> ```

[貢献](https://raw.githubusercontent.com/mebaadwaheed/winup/main/CONTRIBUTING.md)
[更新履歴](https://raw.githubusercontent.com/mebaadwaheed/winup/main/CHANGELOG.md)
[ライセンス](LICENSE)

---

## なぜWinUp？（生のPySide6やTkinterの代わりに）

Pythonでのデスクトップ開発は使いにくく感じることがあります。WinUpはそれを解決するために作られました。

| 機能                    | WinUpの方法 ✨                                                                 | 生のPySide6 / Tkinterの方法 😟                                                             |
| ----------------------- | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------- |
| **レイアウト**          | `ui.Column(children=[...])`, `ui.Row(children=[...])`                          | `QVBoxLayout()`, `QHBoxLayout()`, `layout.addWidget()`, `pack()`, `grid()`                  |
| **スタイリング**        | `props={"background-color": "blue", "font-size": "16px"}`                      | 手動のQSS文字列、`widget.setStyleSheet(...)`、複雑なスタイルオブジェクト                    |
| **状態管理**            | `state.bind(widget, "prop", "key")`                                            | 手動のコールバック関数、getter/setter、`StringVar()`, いたるところにボイラープレート        |
| **双方向バインディング** | `state.bind_two_way(input_widget, "key")`                                      | なし。状態とUIの更新には手動の`on_change`ハンドラが必要                                   |
| **開発者ツール**        | **組み込みのホットリロード**、コードプロファイラ、ウィンドウツールが標準装備    | なし。UI変更ごとにアプリ全体を再起動する必要がある                                         |
| **コード構造**          | `@component`で再利用可能な自己完結型コンポーネント                              | 大きくモノリシックなクラスや手続き型スクリプトに陥りがち                                 |

**要するに、WinUpはデスクトップ向けにモダンWebフレームワーク（ReactやVueなど）の「キラーフィーチャー」を提供し、時間を節約し、アプリケーションのロジックに集中できるようにします。**

# 🧊 WinUp vs 🧱 PyEdifice（Redditユーザーのリクエスト）

| 機能                           | WinUp                                | PyEdifice                         |
|-------------------------------|------------------------------------|----------------------------------|
| 🧱 アーキテクチャ             | Reactスタイル + 状態                | Reactスタイル + 状態              |
| 🌐 組み込みルーティング       | ✅ はい (`Router(routes={...})`)    | ❌ 組み込みルーティングなし        |
| ♻️ ライフサイクルフック        | ✅ `on_mount`, `on_unmount` など     | ⚠️ 制限あり (`did_mount`など)      |
| 🎨 テーマ / スタイリングシステム | ✅ グローバル＆スコープドテーマ       | ❌ 手動のCSS注入                  |
| 🔲 レイアウトオプション         | ✅ Row, Column, Grid, Stack, Flexbox | ⚠️ 主にBox & HBox/VBox            |
| 🎞️ アニメーション             | ✅ 組み込み（フェード、スケールなど） | ❌ 組み込みなし                    |
| 🔁 ホットリロード (LHR)        | ✅ 安定かつ高速 (`loadup dev`)        | ⚠️ 実験的で限定的サポート          |
| 📦 パッケージング             | ✅ LoadUp付き（PyInstallerベース）   | ❌ PyInstallerを手動で統合する必要あり |
| 🧩 コンポーネントの再利用性    | ✅ 高い、宣言的                      | ✅ 高い                          |
| 🛠 開発者向けツール           | ✅ DevTools計画中、Inspectorも近々   | ❌ まだなし                      |
| 📱 モバイルサポート           | ❌ 未対応                          | ❌ 未対応                        |
| 🧠 学習曲線                   | ✅ Python+Reactユーザーに易しい       | ✅ 易しいがツールは少なめ          |

> ✅ = 組み込みまたは堅牢  
> ⚠️ = 部分的または限定的  
> ❌ = 完全に欠如
---

## コア機能

*   **宣言的でPython的なUI:** 複雑なレイアウトもシンプルな`Row`や`Column`オブジェクトで構築。面倒なボックスレイアウト不要。
*   **コンポーネントベースのアーキテクチャ:** `@component`デコレータでモジュール化され再利用可能なUIウィジェットを簡単に作成。
*   **強力なスタイリングシステム:** `props`を使ったシンプルなPython辞書でウィジェットをスタイリング。`style.add_style_dict`でグローバルな「CSS風」クラスも作成可能。
*   **フルアプリケーションシェル:** `MenuBar`、`ToolBar`、`StatusBar`、`SystemTrayIcon`の宣言的APIでプロフェッショナルなアプリを構築。
*   **非同期タスクランナー:** UIをフリーズさせずに長時間処理を実行できるシンプルな`@tasks.run`デコレータ。
*   **デフォルトで高性能:** コンポーネントの再レンダリングをキャッシュし不要な再計算を防ぐオプトインの`@memo`デコレータを含む。
*   **高度な拡張性:**
    *   **ウィジェットファクトリ:** `ui.register_widget()`で任意のデフォルトウィジェットをC++ベースなどのカスタム実装に置き換え可能。
    *   **複数ウィンドウ:** ツールパレットや音楽プレーヤーのような複雑なアプリのために複数の独立したウィンドウを作成・管理。
*   **リアクティブな状態管理:**
    *   **一方向バインディング:** データ変更時に`state.bind()`でUIを自動更新。
    *   **双方向バインディング:** `state.bind_two_way()`で入力ウィジェットと状態を簡単に同期。
    *   **サブスクリプション:** 状態変化に応じて任意の関数を`state.subscribe()`でトリガー。
*   **開発者に優しいツール:**
    *   **ホットリロード:** アプリを再起動せずにUI変更を即座に反映。
    *   **プロファイラ:** `@profiler.measure()`デコレータで関数のパフォーマンスを簡単に測定。
    *   **ウィンドウツール:** アプリのウィンドウを中央に配置、点滅、管理など簡単操作。
*   **組み込みルーティング:** 直感的で状態駆動のルーターでマルチページアプリを簡単作成。
*   **柔軟なデータレイヤー:** SQLite、PostgreSQL、MySQL、MongoDB、Firebase向けのシンプルで一貫したコネクタを含む。

---

# ドキュメント

WinUpの機能をさらに深く掘り下げましょう：

## コアコンセプト
- [**コンポーネントモデルとスタイリング**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/concepts.md)
- [**ステート管理**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/state.md)
- [**ライフサイクルフック**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/concepts.md#component-lifecycle-hooks-on_mount-and-on_unmount)
- [**ルーティング**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/concepts.md#routing)
- [**絶対配置（高度）**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/absolute-layout.md)

## 開発者ツール
- [**ライブホットリロード（LHR）**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/live-hot-reload.md)
- [**パフォーマンスプロファイラ**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/profiler.md)
- [**メモ化**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/memoization.md)
- [**非同期タスクランナー**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/tasks.md)

## UIコンポーネント
- [**フルコンポーネントライブラリ**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/components/README.md)

---

## コントリビュート

WinUpはオープンソースプロジェクトです。貢献を歓迎します！

## ライセンス

本プロジェクトはMITライセンスの下でライセンスされています。詳細は**LICENSE**をご覧ください。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-17

---