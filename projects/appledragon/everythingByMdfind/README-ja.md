[English](https://raw.githubusercontent.com/appledragon/everythingByMdfind/master/README.md) | [中文](https://raw.githubusercontent.com/appledragon/everythingByMdfind/master/README_CN.md) | [한국어](https://raw.githubusercontent.com/appledragon/everythingByMdfind/master/README_KO.md) | [日本語](https://raw.githubusercontent.com/appledragon/everythingByMdfind/master/README_JP.md) | [Français](https://raw.githubusercontent.com/appledragon/everythingByMdfind/master/README_FR.md) | [Deutsch](https://raw.githubusercontent.com/appledragon/everythingByMdfind/master/README_DE.md) | [Español](https://raw.githubusercontent.com/appledragon/everythingByMdfind/master/README_ES.md)

<img width="3836" height="2026" alt="image" src="https://github.com/user-attachments/assets/d86c3d6b-6fd4-4cfe-b64f-67c465bb3d3c" /><img width="3832" height="2024" alt="image" src="https://github.com/user-attachments/assets/a91d2b13-07ac-4cae-ab33-506f1fa3bca6" />


# mdfindによるEverything

macOSのネイティブなSpotlightエンジンを活用し、超高速な結果を実現する強力で効率的なファイル検索ツール。

## 主な機能

*   **超高速検索：** macOSのSpotlightインデックスを利用し、ほぼ瞬時にファイルを検索。
*   **柔軟な検索オプション：** ファイル名または内容で検索し、必要なファイルを素早く特定。
*   **高度なフィルタリング：** さまざまなフィルターで検索を絞り込み：
    *   ファイルサイズの範囲指定（バイト単位の最小・最大サイズ）
    *   特定のファイル拡張子（例：`pdf`、`docx`）
    *   大文字・小文字の区別
    *   完全一致または部分一致のオプション
*   **特定ディレクトリ検索：** 指定したディレクトリに検索を限定し、目的に合った結果を取得。
*   **豊富なプレビュー機能：** アプリ内でさまざまなファイルタイプをプレビュー可能：
    *   エンコーディング検出対応のテキストファイル
    *   画像（JPEG、PNG、GIF（アニメーション対応）、BMP、WEBP、HEIC）
    *   適切なスケーリングとセンタリング対応のSVGファイル
    *   再生コントロール付きの動画ファイル
    *   オーディオファイル
*   **統合メディアプレーヤー：**
    *   標準コントロールによる動画・音声再生
    *   メディアファイル用の独立プレーヤーウィンドウ
    *   連続再生モード
    *   ボリューム調整とミュート機能
*   **ブックマーク機能：** よく使う検索へのクイックアクセス：
    *   大容量ファイル（50MB以上）
    *   動画ファイル
    *   音声ファイル
    *   画像
    *   アーカイブ
    *   アプリケーション
*   **ディスク容量分析：** 任意のディレクトリのディスク使用量を分析：
    *   ワンクリックでホームディレクトリの容量分析
    *   上位容量消費フォルダを示すインタラクティブな棒グラフ表示
    *   検索結果の任意のフォルダーを右クリックして、そのスペース使用状況を分析
    *   チャートのバーをダブルクリックして、サブディレクトリの詳細分析にドリルダウン
    *   カラーコード化されたチャートによるサブディレクトリサイズの視覚的内訳
    *   サイズによる自動ソートで最大のフォルダーを特定
*   **並べ替え可能な結果：** 名前、サイズ、更新日時、パスで検索結果を整理。
*   **複数ファイル操作：** 複数ファイルに対して同時に操作を実行：
    *   ShiftキーまたはCommand（⌘）キーで複数選択
    *   一括操作：開く、削除、コピー、移動、名前変更
    *   追加操作のためのコンテキストメニュー
*   **マルチタブ検索インターフェース：** 複数の検索セッションを同時に操作：
    *   異なる検索クエリ用の新規タブ作成
    *   右クリックコンテキストメニューでタブの閉鎖、並べ替え、管理
    *   タブごとに独立した検索結果と設定
    *   多数のタブに対応するスクロールボタン付きのChrome風タブ体験
*   **カスタマイズ可能なインターフェース：**
    *   6つの美しいテーマから選択可能：
        *   ライト＆ダーク（システムデフォルト）
        *   Tokyo Night＆Tokyo Night Storm
        *   Chinolor Dark＆Chinolor Light（中国伝統色）
    *   選択したテーマに合わせたシステムタイトルバーのテーマ設定
    *   プレビューパネルの表示/非表示
    *   設定可能な検索履歴
*   **マルチフォーマットエクスポート：** 検索結果を複数形式でエクスポート：
    *   JSON - 構造化データ形式
    *   Excel（.xlsx）- 書式付きスプレッドシート
    *   HTML - ウェブ対応テーブル形式
    *   Markdown - ドキュメント向け形式
    *   CSV - クラシックなカンマ区切り値形式
*   **レイジーローディング：** スクロールに応じて項目をバッチで読み込み、大量の結果を効率的に処理。
*   **ドラッグ＆ドロップ：** ファイルを直接外部アプリケーションにドラッグ可能。
*   **パス操作：** ファイルパス、ディレクトリパス、またはファイル名をクリップボードにコピー。

## インストール

1.  **前提条件：**
    *   Python 3.6以上
    *   PyQt6

2.  **リポジトリをクローン：**

    ```bash
    git clone https://github.com/appledragon/everythingByMdfind
    cd everythingByMdfind
    ```
3.  **依存関係のインストール：**


    ```bash
    pip install -r requirements.txt
    ```

4.  **アプリケーションを実行する：**

    ```bash
    python everything.py
    ```
## 事前構築済みアプリケーションのダウンロード

準備済みのmacOSアプリケーション（.dmg）は、[GitHub Releases](https://github.com/appledragon/everythingByMdfind/releases)ページから直接ダウンロードできます。

## 貢献について

貢献は歓迎します！バグ修正、機能リクエスト、一般的な改善のためにプルリクエストの提出やイシューの作成をお気軽にどうぞ。

## ライセンス

このプロジェクトはApache License 2.0の下でライセンスされています。詳細は[LICENSE.md](https://raw.githubusercontent.com/appledragon/everythingByMdfind/master/LICENSE.md)ファイルをご参照ください。

## 作者

Apple Dragon

## バージョン

1.4.2

## 謝辞

*   強力で多用途なGUIフレームワークを提供してくれたPyQt6チームに感謝します。
*   他の優れたファイル検索ツールからのインスピレーション。





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-03

---