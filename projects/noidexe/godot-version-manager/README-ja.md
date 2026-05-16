<table><tr width=64px><td><img height=64px src="https://user-images.githubusercontent.com/526829/169241046-3087a41d-9606-43ab-90ae-ee0055bef039.png"/></td><td><h1>godot-version-manager</h1></td></tr></table>
  
シンプルなアプリから任意のGodot Engineのバージョンをダウンロード、インストール、管理します。

<img alt="screenshot with light theme" src="https://github.com/user-attachments/assets/5b504fa3-59ea-46c8-bb78-6a743759d984" />
<img alt="screenshot with dark theme" src="https://github.com/user-attachments/assets/08ff0100-fbd5-40be-a8a4-80bbb186d37e" />

## インストール
### Windows:
解凍してダブルクリックします。（Windows XPの場合はPowershellがインストールされていることを確認してください）
### Linux:
解凍してダブルクリックします。ダウンロードしたバージョンの解凍には `unzip` が必要で、未インストールの場合はディストリビューションのリポジトリから入手可能です
### OSX:
- ダウンロード後に自動で解凍されるはずです
- 署名されていないバイナリは信頼されないため、`sudo xattr -r -d com.apple.quarantine path/to/Godot Version Manager.app` を実行する必要があります。プリビルドバイナリを信頼しない場合は自分でビルドしてください
- Godot Version Manager.appをダブルクリックします

## 機能
- ドロップダウンメニューから任意のGodotバージョンを自動的にダウンロードおよびインストールします。（解凍にはpowershellが必要）
- アルファ、ベータ、RC、開発バージョンをダウンロードドロップダウンに表示または非表示に切り替え可能
- ファイルシステム上の任意の場所に独自のバイナリを追加可能
- 安定版、RC、ベータ、アルファ、マスターのビルドを簡単に識別できるカラフルなアイコン
- リストから任意のエントリを右クリックで削除
- エントリの並び替えはドラッグ＆ドロップで可能
- project.godotファイルやGodotプロジェクトフォルダをドラッグ＆ドロップしてプロジェクトを追加し、特定のバージョンで起動
- godotengine.org/news からニュースフィード取得

## よくある質問
**Q: ダウンロードしたバイナリはどこに保存されますか？**

A: プラットフォームにより異なりますが `user://versions` に保存されます。Windowsでは %appdata%/Godot/app_userdata/Godot Version Manager/versions です

**Q: HourglassやGodot Managerと何が違うのですか？**

A:
 - [Hourglass](https://hourglass.jwestman.net/) はより成熟した機能豊富なプロジェクトで、プロジェクト管理のサポートが優れています。GVMの唯一の利点は公式サイトからニュースもダウンロードすることかもしれません :)
 - [Godot Manager](https://github.com/eumario/godot-manager) もかなり成熟し機能豊富な代替ツールのようです。
 - [Godots](https://github.com/MakovWait/godots) は2023年8月に登場した新しい代替ツールで、多くの人に好評です。
 - [GodotEnv](https://github.com/chickensoft-games/GodotEnv) と [godot-version-manager](https://github.com/gaheldev/godot-version-manager) はCLI専用の代替ツールです。
 - [Godot Launcher](https://github.com/sebastianoboem/godot-launcher) は拡張機能やキャッシュ管理をサポートするPythonベースの代替ツールです。
 - [gdvm](https://github.com/adalinesimonian/gdvm) は、Rustで構築された別のCLIベースのバージョンマネージャーです。

## LICENSE
MITライセンス（LICENSE.mdを参照）
Copyright ©️2022 Lisandro Loreaおよび貢献者

Lilita Oneフォント ©️2011 Juan Montoreano
<a href="https://www.flaticon.com/free-icons/exe" title="exe icons">ExeアイコンはFreepik - Flaticonによって作成されました</a>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-16

---