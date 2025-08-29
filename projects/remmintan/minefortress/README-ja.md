![あなたのMinecraftをリアルタイムストラテジーに変えるMOD](https://raw.githubusercontent.com/remmintan/minefortress/master/docs/main-banner.png)
# MineFortress
[![プロジェクトをサポート](https://img.shields.io/badge/PATREON-SUPPORT_THE_PROJECT-f96854?style=for-the-badge&logo=patreon&logoColor=f96854&labelColor=052d49&color=f96854)](https://www.patreon.com/minefortress)
[![Discordに参加](https://img.shields.io/discord/906943962659561515?style=for-the-badge&logo=discord&label=discord&color=5865F2)](https://discord.gg/6rt7VJxPcq)
[![ウェブサイト](https://img.shields.io/badge/website-minefortress-CC9966?style=for-the-badge)](https://minefortress.net/)

MinecraftをRTSに変えるMOD。村のリーダーとなり、資源を集め、家を建て、専門職を雇い、村を成長・拡大させ、隣人を征服しよう！一人称視点は忘れて、クラシックなRTSゲームのようにマウスポインターで全てを操作しよう。
## リンク
* **[ウェブサイト](https://minecraftfortress.org/)**
* **[Patreon](https://www.patreon.com/minefortress)**
* **[Modrinth](https://modrinth.com/mod/minefortress)**
* **[CurseForge](https://www.curseforge.com/minecraft/mc-mods/minefortress-rts)**
## プレイヤー向け
このリポジトリは開発者向けです。MODをプレイしたい場合は、[CurseForge](https://www.curseforge.com/minecraft/mc-mods/minefortress-rts)または[Modrinth](https://modrinth.com/mod/minefortress)からダウンロードしてください。

MODの動作にはFabric LoaderとFabric APIが必要です。
詳細なインストール手順は[wiki](https://wiki.minecraftfortress.org/wiki/Installation:Curseforge_Launcher)をご覧ください。

## 開発者向け
### 前提条件
プロジェクトに貢献したい方は、Java/Kotlin開発に一般的に慣れていることを前提としています。
基本的な開発環境のインストール詳細には触れませんが、プロジェクト作業に必要なツールは以下の通りです：
* Java 17 - [Adoptium](https://adoptium.net/)ビルドの使用を推奨します
* IntelliJ IDEA - 最も快適な開発体験と私の結果と一致する成果を得るために、IntelliJ IDEAの使用を推奨します。こちらからダウンロードできます：[ここ](https://www.jetbrains.com/idea/download/)。
* Git - リポジトリのクローンや変更のコミットに使用します。こちらからダウンロードできます：[ここ](https://git-scm.com/downloads)。

開発環境のセットアップ支援が必要な場合は、こちらの記事を参照してください：[IntelliJ IDEAでのJava開発](https://www.jetbrains.com/help/idea/getting-started.html)

質問があれば、[Discordサーバー](https://discord.gg/6rt7VJxPcq)でお気軽にお尋ねください。
### はじめに / インストール
1. Gitを使ってリポジトリをクローンします。
2. プロジェクトが`minefortress`という名前のディレクトリにクローンされていることを確認してください。これはGradleをIDEAで正しく動作させるために必要です。
3. IntelliJ IDEAでプロジェクトを開きます。
4. Gradleのインポートが完了するまで待ちます。
5. Run Configurationsを動作させる必要があります。Fabricプラグインが自動で行いますが、一旦プロジェクトを閉じる必要があります。
6. プロジェクトを閉じて再度開きます。
7. 新しいRun Configurationsが表示されるはずです。表示されない場合はIDEAを再起動してください。
8. Run Configurationに小さな×印が付いている場合があります。これはFabricプラグインが設定時に間違ったモジュールを使用したことを意味します。
![](https://raw.githubusercontent.com/remmintan/minefortress/master/docs/run-configurations-1.png)
9. 修正するには、設定を編集し、`minefortress.main`モジュールのクラスパスドロップダウンを選択してください。
![](https://raw.githubusercontent.com/remmintan/minefortress/master/docs/run-configurations-2.png)
10. これで `Minecraft Client` 設定を使ってプロジェクトを実行できます。
![](https://raw.githubusercontent.com/remmintan/minefortress/master/docs/run-configurations-3.png)

### 貢献について
どんな助けも非常に感謝します！プロジェクトに貢献したい場合は、以下の手順に従ってください：
1. リポジトリをフォークします。
2. `master` ブランチから新しいブランチを作成します。
3. 変更を加えます。
4. 変更をコミットし、フォークにプッシュします。
5. このリポジトリの `master` ブランチへのプルリクエストを作成します。

まだ貢献ガイドはありませんが、作業できるものを見つけるために[issues](https://github.com/remmintan/minefortress/issues)をチェックできます。
バグや機能リクエストはissuesにまとめるようにしますが、ご質問があれば[Discordサーバー](https://discord.gg/6rt7VJxPcq)で気軽にお尋ねください。

また、バグを見つけたり機能リクエストがあれば、遠慮なくissuesを作成してください。

時間をかけて、貢献ガイドと初心者向けの良いissuesのリストを作成しようと思います。

## ライセンス
このプロジェクトはMITライセンスの下でライセンスされています。詳細は[LICENSE](LICENSE)ファイルをご覧ください。

## 寄付
オープンソース開発を支援するために、プロジェクトへ寄付をお願いします。以下の方法で寄付が可能です：
* **[Patreon](https://www.patreon.com/minefortress)**


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-29

---