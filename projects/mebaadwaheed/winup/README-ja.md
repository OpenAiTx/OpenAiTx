<div align="right">
  <details>
    <summary >🌐 言語</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=en">英語</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=zh-CN">簡体字中国語</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=zh-TW">繁體字中国語</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=ko">韓国語</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=hi">ヒンディー語</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=th">タイ語</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=fr">フランス語</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=de">ドイツ語</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=es">スペイン語</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=it">イタリア語</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=ru">ロシア語</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=pt">ポルトガル語</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=nl">オランダ語</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=pl">ポーランド語</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=ar">アラビア語</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=fa">ペルシャ語</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=tr">トルコ語</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=vi">ベトナム語</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=id">インドネシア語</a>
      </div>
    </div>
  </details>
</div>

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

## 最新の安定版リリース（LSR）を必ずダウンロードしてください！最新/LFRではありません！現在のLSR: 2.4.9

`pip install winup==2.4.9`

**驚くほどPythonicで強力な、美しいデスクトップアプリケーションを構築するためのフレームワークです。**

WinUpは、PySide6（Qt）のパワーを、シンプルで宣言的かつ開発者に優しいAPIでラップした、Python向けのモダンなUIフレームワークです。アプリケーションの構築を高速化し、よりクリーンなコードを書き、開発プロセスを楽しめるよう設計されています。

### ✨ Webサポートが追加されました！
WinUpは、同じPython中心・コンポーネントベースのアプローチで、完全にインタラクティブかつ状態管理されたWebアプリケーションの構築もサポートします。WebモジュールはFastAPIとWebSocketsを内部で利用し、WinUpのシンプルさをブラウザにもたらします。

[Webドキュメント](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/web/README.md)

> **注意:** Webサポートはオプション機能です。使用するにはWeb依存関係のインストールが必要です:
> ```bash
> pip install "winup[web]"
> ```

[コントリビューションガイド](https://raw.githubusercontent.com/mebaadwaheed/winup/main/CONTRIBUTING.md)
[変更履歴](https://raw.githubusercontent.com/mebaadwaheed/winup/main/CHANGELOG.md)
[ライセンス](LICENSE)

---

## なぜWinUpなのか？（生のPySide6やTkinterではなく）

Pythonによるデスクトップ開発はぎこちなく感じることがあります。WinUpはそれを解決するために作られました。

| 機能                    | WinUp流 ✨                                                                   | 生PySide6 / Tkinter流 😟                                                                |
| ----------------------- | -------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| **レイアウト**          | `ui.Column(children=[...])`, `ui.Row(children=[...])`                      | `QVBoxLayout()`, `QHBoxLayout()`, `layout.addWidget()`, `pack()`, `grid()`              |
| **スタイリング**        | `props={"background-color": "blue", "font-size": "16px"}`                 | 手動QSS文字列、`widget.setStyleSheet(...)`、複雑なスタイルオブジェクト                  |
| **状態管理**            | `state.bind(widget, "prop", "key")`                                        | 手動コールバック関数、getter/setter、`StringVar()`、ボイラープレートだらけ             |
| **双方向バインディング**| `state.bind_two_way(input_widget, "key")`                                  | 存在しない。状態とUIを更新するため手動で`on_change`ハンドラが必要                      |
| **開発者ツール**        | **ビルトインホットリロード**、コードプロファイラ、ウィンドウツールを標準搭載 | 存在しない。UI変更ごとにアプリ全体を再起動する必要あり                                |
| **コード構造**          | `@component`による再利用可能な自己完結型コンポーネント                     | 大規模なモノリシッククラスや手続き的スクリプトになりがち                              |

**要するに、WinUpはモダンなWebフレームワーク（ReactやVueなど）の「キラーフィーチャー」をデスクトップにもたらし、時間を節約しアプリ本来のロジックに集中できます。**

# 🧊 WinUp vs 🧱 PyEdifice（Redditユーザーリクエスト）

| 機能                              | WinUp      | PyEdifice                        |
|----------------------------------|--------------------------------------|----------------------------------|
| 🧱 アーキテクチャ                | Reactスタイル + 状態管理            | Reactスタイル + 状態管理          |
| 🌐 ルーティング内蔵              | ✅ あり（`Router(routes={...})`）    | ❌ ルーティング内蔵なし            |
| ♻️ ライフサイクルフック          | ✅ `on_mount`、`on_unmount`など      | ⚠️ 制限あり（`did_mount`など）     |
| 🎨 テーマ/スタイリングシステム   | ✅ グローバル＆スコープテーマ        | ❌ 手動CSSインジェクション         |
| 🔲 レイアウトオプション           | ✅ Row, Column, Grid, Stack, Flexbox | ⚠️ 主にBoxとHBox/VBox             |
| 🎞️ アニメーション                | ✅ ビルトイン（フェード・スケール等）| ❌ ビルトインなし                  |
| 🔁 ホットリロード（LHR）         | ✅ 安定＆高速（`loadup dev`）        | ⚠️ 実験的でサポート限定            |
| 📦 パッケージング                | ✅ LoadUp（PyInstallerベース）で可能 | ❌ PyInstallerの手動統合が必要     |
| 🧩 コンポーネント再利用性        | ✅ 高い、宣言的                      | ✅ 高い                            |

| 🛠 開発者ツール                | ✅ DevTools 計画中、Inspector 近日公開 | ❌ まだなし                        |
| 📱 モバイル対応                | ❌ 未対応                             | ❌ 非対応                          |
| 🧠 学習コスト                   | ✅ Python+React ユーザーに簡単         | ✅ 簡単だがツールが少ない           |

> ✅ = 標準搭載または堅牢  
> ⚠️ = 部分的または限定的  
> ❌ = 完全に未対応
---

## コア機能

*   **宣言的かつPythonicなUI:** 複雑なレイアウトも `Row` や `Column` オブジェクトで簡単に構築。煩雑なボックスレイアウトは不要です。
*   **コンポーネントベース設計:** `@component` デコレーターで、シンプルな関数から再利用可能なUIウィジェットを作成できます。
*   **強力なスタイリング:** `props` でPython辞書を使った簡単なウィジェット装飾。`style.add_style_dict` でグローバルな「CSS風」クラスも実現。
*   **アプリケーションシェル:** `MenuBar`、`ToolBar`、`StatusBar`、`SystemTrayIcon` の宣言的APIで本格的なアプリケーションを構築。
*   **非同期タスクランナー:** `@tasks.run` デコレーターでUIをフリーズさせずにバックグラウンドで長時間処理を実行。
*   **標準で高パフォーマンス:** `@memo` デコレーターによる描画キャッシュで無駄な再計算を防止（任意）。
*   **高度な拡張性:**
    *   **ウィジェットファクトリー:** `ui.register_widget()` で任意のウィジェットを自作実装（例：C++ベース）に置き換え可能。
    *   **複数ウィンドウ:** ツールパレットや音楽プレーヤーのような複雑アプリ向けに独立した複数ウィンドウを作成・管理。
*   **リアクティブな状態管理:**
    *   **片方向バインディング:** `state.bind()` でデータ変更に自動追従してUIを更新。
    *   **双方向バインディング:** `state.bind_two_way()` で入力ウィジェットと状態を簡単同期。
    *   **サブスクリプション:** `state.subscribe()` で状態変化時に任意の関数を実行。
*   **開発者フレンドリーなツール:**
    *   **ホットリロード:** アプリ再起動なしでUI変更を即時反映。
    *   **プロファイラ:** `@profiler.measure()` デコレーターで任意関数のパフォーマンス計測が簡単。
    *   **ウィンドウツール:** アプリウィンドウの中央寄せ・点滅・各種管理が簡単。
*   **ルーティング内蔵:** 直感的で状態駆動なルーターによりマルチページアプリも簡単構築。
*   **柔軟なデータレイヤー:** SQLite、PostgreSQL、MySQL、MongoDB、Firebase 用のシンプルで一貫したコネクタを内蔵。

---

# ドキュメント

WinUp の機能をさらに詳しく知る：

## コアコンセプト
- [**コンポーネントモデルとスタイリング**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/concepts.md)
- [**状態管理**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/state.md)
- [**ライフサイクルフック**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/concepts.md#component-lifecycle-hooks-on_mount-and-on_unmount)
- [**ルーティング**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/concepts.md#routing)
- [**絶対位置指定（上級）**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/absolute-layout.md)

## 開発者ツール
- [**ライブホットリロード（LHR）**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/live-hot-reload.md)
- [**パフォーマンスプロファイラ**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/profiler.md)
- [**メモ化**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/memoization.md)
- [**非同期タスクランナー**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/tasks.md)

## UIコンポーネント
- [**コンポーネントライブラリ全体**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/components/README.md)

---

## コントリビュート

WinUp はオープンソースプロジェクトです。貢献は大歓迎です！

## ライセンス

本プロジェクトはMITライセンスです。詳細は **LICENSE** をご覧ください。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---