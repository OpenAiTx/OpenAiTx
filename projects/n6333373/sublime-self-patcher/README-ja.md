## Sublime Self Patcher

これは Sublime Text 4 のプラグインで、Sublime Text と Sublime Merge をパッチできます。

🔥 サードパーティの依存関係は不要です。必要なのは Sublime Text だけです。

## 対応環境

| 記号 | 意味                                                                    |
| ---- | ----------------------------------------------------------------------- |
| ✅   | 対応しています。                                                        |
| ⚠️   | 不安定なパッチパターンです。頻繁にこのプラグインを更新する必要があるかもしれません。 |
| ☠️   | 申し訳ありませんが、使用していません。                                  |

|                   | Linux x64 | Windows x32 | Windows x64 | その他  |
| ----------------- | --------- | ----------- | ----------- | ------ |
| **Sublime Text**  | ✅        | ✅          | ✅          | ☠️     |
| **Sublime Merge** | ✅⚠️      |             | ✅          | ☠️     |

Windows 7 を使用している場合は、[Service Pack 2](https://answers.microsoft.com/en-us/windows/forum/all/how-to-obtain-and-install-windows-7-sp2/c2c7009f-3a10-4199-9c89-48e1e883051e) が必要です。

## ダウンロード

https://github.com/n6333373/sublime-self-patcher/archive/refs/heads/main.zip

## インストール

まず、`Packages` ディレクトリを見つける必要があります。

- ポータブル版の Sublime Text を使用している場合、`Data/Packages` です。
- インストール版の Sublime Text を使用している場合、
  - Windows では `%appdata%\Sublime Text\Packages` です。
  - Linux では `$HOME/.config/sublime_text/Packages` です。

次に、（必要なら解凍して）ダウンロードしたディレクトリを `Packages` ディレクトリに入れ、
ディレクトリ構造が以下のようになるようにしてください：

```text
Packages/
└── SelfPatcher/
    ├── boot.py
    ├── ...
```
そして、Sublime Textが起動している場合は再起動してください。

## 使い方

### 自身のパッチ（現在のSublime Text）

- 登録されていない開発版を使用している場合、このプラグインは起動時にパッチ適用のポップアップを表示します。
- 安定版を使用している場合は、メニューからパッチ適用が可能です：`Help ⇒ Patch This Application`

### 外部のSublime Text/Mergeにパッチを適用する

アプリケーションが管理者権限やroot権限が必要な場所にインストールされている場合、
このプラグインを使って一時ディレクトリにパッチ済みの実行ファイルを作成できます。

メニューからクリックしてください：`Help ⇒ Patch External Sublime Text/Merge` そしてSublime Text/Mergeの実行ファイルを選択します。

## Q&A

### Sublime Text/Mergeの自動更新を無効にするには？

このプラグインは通常、将来のSublime Text/Mergeのバージョンでも動作し続けます。
しかし、アプリケーションの自動更新を無効にしたい場合は、以下の設定を行ってください：


```jsonc
{
    "update_check": false, // this works only if you have registered
}
```

### このプラグインは疑わしいです

私は悪意のあることはしていないと思いますが、私を信用する必要はありません。あなたは

- 仮想マシンでパッチを当て、パッチ済みの実行ファイルを取り出すことができます。
- 自分で行うこともできます。https://gist.github.com/maboloshi/feaa63c35f4c2baab24c9aaf9b3f4e47 を参照してください。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-24

---