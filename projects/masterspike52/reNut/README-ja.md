

<img width="1920" height="1080" alt="renut logo" src="https://github.com/user-attachments/assets/273bee28-755f-4494-920f-9333af72091e" />




Originally created with <a href="https://github.com/rexglue/rexglue-sdk">Rexglue-SDK</a>



DISCORD
--------------------------------------------
We have a discord, please join and direct any questions there. Myself or someone else will happily answer them.

https://discord.gg/D5Bz2ZsHdY



Credits
------------------------------------------------
<a href="https://github.com/rexglue/rexglue-sdk">Rexglue team</a> for creating Rexglue-SDK
<br>
the Rexglue SDK discord for helping with any info they have
<br>
SolarCookies for midasm hooks and future use of CRT functions and the reNut Launcher
<br>
ValcomDrifty for the renut logo
<br>
.
<br>
.
<br>
.
<br>
.
<br>
.
<br>
.
<br>
あなた、プレイヤーですか？
<br>
.


要件
-------------------------------------------------------------------
バンジョーとカズーイの大冒険：ナッツ＆ボルト 北米版 default.xex


ビルド方法
------------------------------------------------------
注意：.gitignore ファイルのすべてのインスタンスを削除しないと、コンパイルしたものがファイルのある場所を認識できません。
<br>
注意：REXGLUE-SDK をインストールする前、またはこのリポジトリをビルドする前に <a href="https://git-scm.com/install/windows">GIT</a> をインストールしてください。
<br>
注意：続行する前に <a href="https://github.com/rexglue/rexglue-sdk">Rexglue-SDK</a> のメインリポジトリをビルドしてインストールする必要があります。


1. ```git clone https://github.com/masterspike52/reNut.git``` でリポジトリをクローンします。
2. assets フォルダ内にバンジョーとカズーイの大冒険：ナッツ＆ボルトの ISO 内容と default.xex を抽出する必要があります。<a href="https://consolemods.org/wiki/images/5/5f/XBOX360_ISO_Extract.zip">iso extract</a> の使用を推奨します。（Linuxユーザーが何を使うかは分かりません。私はWindowsを使っていますが、iso extract は WINE 経由で Linux でも動作します。）
3. クローンした git の中でターミナルを開き、```rexglue migrate --app_root .``` を実行してください。これにより Rexglue の codegen に変更があった場合でも正しく codegen できます。
   3b. その後、out フォルダを削除するか、Windowsの場合は VS を開いて cmakelists.txt を右クリックし、キャッシュを削除して再構成し、使用しているバージョンで codegen してください。
4. ターミナルで ```rexglue codegen renut_config.toml``` を実行すると、生成されたフォルダに再コンパイル用の ppc ファイルが出力されます。
5. Windowsの場合、VSでプロジェクトを開き、ビルドタイプを `win-amd64-relwithdebinfo` に変更してからすべてビルドします。
   5b. Linuxの場合、VSが使えない場合はターミナルで ```cmake --preset linux-amd64-relwithdebinfo``` を実行し、その後 ```cmake --build --preset linux-amd64-relwithdebinfo``` を実行してください。（Windowsでも同様にできますが、`linux` を `windows` に置き換えてください。）
6. コンパイルが完了したら、ビルドした exe ファイルを assets と同じディレクトリに置く必要があります。そうしないとゲームが起動しません。

Linux 用フォークあり
-------------------------------------------------
Linux向けにビルドしたい場合は、etonedemid が作成した <a href="https://github.com/etonedemid/reNut">reNut</a> のこのフォークを使用してください。これは彼のフォーク <a href="https://github.com/etonedemid/rexglue-sdk">rexglue</a> を使用する必要があり、彼はこの機能をメインに取り込むためのプルリクエストを Rexglue に送っています。


ビルドしたくない場合
--------------------------------------------
ビルドは主に、自分や他の開発者と一緒にゲームの開発に参加したい方向けです。ビルドしたくない場合は；
* https://goopie.xyz/ にアクセスして goopie ランチャーをダウンロードしてください
* ランチャーでバンジョーとカズーイの大冒険：ナッツ＆ボルトを選択
* 「Select ISO」をクリックしてバンジョーとカズーイの大冒険：ナッツ＆ボルト（北米版）の ISO を選択し、抽出が完了するまで待ってください
* 抽出が完了したら更新ボタンをクリックすると、ランチャーが最新のWindows版renutをダウンロードします  
* プレイをクリックしてください  

  
既知の問題  
-----------------------------------------------  
1. アニメーションが少し不安定です（ジャダーが発生し、バンジョーや他の骨が壊れ、一部のアニメーションは途中までしか完成しておらず、その他細かい付随要素があります）が、ゲームプレイには支障なく、見ると面白いです。  

  
問題の作成  
--------------------------  
問題タブはゲーム中に発生するクラッシュなど、まだ報告されていない問題用です。「ゲームが起動しない」や「ISOを使う必要がある？」のような問題は作成をご遠慮ください。  
クラッシュに関する問題には必ずクラッシュ用テンプレートを使用してください（他のテンプレートも作成予定です）。ユーザーの誤操作による投稿が多発するのを防ぎたいからです。クラッシュ以外の問題はDiscordの#helpチャンネルをご利用ください。




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-01

---