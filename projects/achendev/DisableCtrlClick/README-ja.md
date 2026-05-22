# DisableCtrlClick for macOS

<p align="center">
  <img src="https://raw.githubusercontent.com/achendev/DisableCtrlClick/master/DisableCtrlClick.png" alt="App Icon" width="128">
</p>

<p align="center">
  <a href="https://github.com/achendev/DisableCtrlClick/releases">
    <img src="https://img.shields.io/github/downloads/achendev/DisableCtrlClick/total.svg" alt="Total Downloads">
  </a>
  <a href="https://github.com/achendev/DisableCtrlClick">
    <img src="https://img.shields.io/github/stars/achendev/DisableCtrlClick?style=social" alt="Star on GitHub">
  </a>
</p>

Controlキーを使おうとしているだけなのに、誤ってコンテキストメニューが開いてしまうのにうんざりしていませんか？私もです。

多くのアプリケーション、特にプログラミング、デザイン、ゲームでは、`Control`が主要なアクションの修飾キーとして使われています。もし右クリックに二本指タップや専用のマウスボタンを使い慣れているなら、デフォルトの`Ctrl-Click`動作は煩わしい中断になることがあります。このアプリがそれを解決します。

## 何をするのか

これはメニューバーに常駐する小さなネイティブmacOSユーティリティで、たった一つのことをします：**`Control + 左クリック`**を通常の**`左クリック`**として扱い、右クリック/コンテキストメニューのデフォルト動作を無効にします。

それだけです。もう勝手に右クリックされることはありません。

## 特徴

*   ✅ **軽量 & ネイティブ:** 最小限のリソース使用のシンプルなSwiftアプリ。
*   ✅ **メニューバーから設定可能:** アイコンをクリックして機能を一時的に無効化したり、「ログイン時に起動」を切り替えたり、アプリを終了できます。
*   ✅ **メニューバーアプリ:** メニューバーに目立たず常駐。Cmd+ドラッグで隠せ、再度起動すると戻せます。
*   ✅ **ログイン時に起動（オプション）:** ログイン時に自動起動。アプリのメニューから切り替え可能。
*   ✅ **設定不要:** 実行して権限を許可するだけ。それだけです。
*   ✅ **モダンで安全:** 最新のAPIで構築され、機能に必要な権限以外は不要。
*   ✅ **透明かつ小型:** 非常に小さく、アプリの全コードを読んだり、AIに解析させて何をしているか正確に理解できます。



## インストールと使い方

1.  **ダウンロード:** [**Releasesページ**](https://github.com/achendev/DisableCtrlClick/releases)にアクセスし、最新の`DisableCtrlClick.dmg`をダウンロードしてください。
2.  **インストール:** ファイルを開き、`DisableCtrlClick.app` を `/Applications` フォルダにドラッグします。  
3.  **起動:** Applications フォルダからアプリを開きます。  
4.  **権限の付与:** 初回起動時に、アプリは権限付与を促し、その後終了します。`DisableCtrlClick` に対して **アクセシビリティ** と **入力監視** を以下で有効にする必要があります:  
    *   `システム設定 > プライバシーとセキュリティ > アクセシビリティ`  
    > **なぜ？** これは、マウスやキーボードのイベントをシステム全体で監視・変更する必要があるアプリケーションに必須です。アプリは `Ctrl-Click` のみを検出し、それ以外は何もしません。  

5.  **完了！** もう一度アプリを再起動します。これで起動中となり、デフォルトでログイン時に自動起動します。この動作はメニューバーアイコンから変更可能です。  

アプリはメニューバーに小さなアイコンを表示します。  
*   アイコンをクリックすると、一時的に機能を無効化したり、ログイン時の起動設定やアプリの終了を行うメニューが開きます。  
*   `⌘`（コマンド）キーを押しながらアイコンをメニューバーからドラッグするとアイコンを非表示にできます。再表示したい場合は、再度アプリを起動してください。  

## ソースからビルドする場合  

自分でアプリをビルドしたい場合:  

1.  このリポジトリをクローンします:
    ```bash
    git clone https://github.com/achendev/DisableCtrlClick.git
    cd DisableCtrlClick
    ```
2.  Xcode のコマンドラインツールがインストールされていることを確認してください。
3.  ターミナルからビルドスクリプトを実行してください。
    ```bash
    ./build.sh
    ```
4.  `DisableCtrlClick.app` バンドルがプロジェクトディレクトリに作成されます。これを `/Applications` フォルダに移動できます。

5.  /Applications にドラッグし、起動します。デフォルトで「ログイン時に開く」に自動的に追加されます。

6.  システム設定でアクセシビリティと入力監視の権限を付与してください。

## トラブルシューティング

本アプリは現状のまま提供されており、明示的または暗示的な保証はありません。

macOS 13.0（Ventura）以降が必要です。

**終了方法**  
メニューバーのアイコンをクリックして「終了」を選択します。アイコンを非表示にしている場合は、再度アプリを起動して表示するか、ターミナルで `killall DisableCtrlClick` コマンドを使用してください。

**権限をリセットする方法**  
アプリが動作しない場合は、権限のリセットを試みてください：
    ```bash
    tccutil reset Accessibility com.usr.DisableCtrlClick
    ```

## ライセンス

このプロジェクトはMITライセンスの下で公開されています。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-22

---