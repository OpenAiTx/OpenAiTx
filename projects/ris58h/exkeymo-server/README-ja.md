# ExKeyMo
Android 4.1以降、アプリは[Key Character Map](https://source.android.com/docs/core/input/key-character-map-files)ファイルを通じて追加のキーボードレイアウトを提供できます。
それ以来、必要なレイアウトを含むアプリをインストールすることで、root権限なしにキーボードレイアウトをカスタマイズ可能になりました。
ExKeyMoは、Android開発の知識がなくてもそのようなアプリを作成するのを支援します。

ExKeyMoは[Heroku](https://exkeymo.herokuapp.com/)でホスティングされていましたが、Herokuが無料でのプロジェクトホスティングを停止し、本プロジェクトがHeroku Open Source Software Credit Programに承認されなかったため、現在は利用できません。カスタムレイアウトのAPKを作成するには、ExKeyMoをローカルで実行するか、以下のプリビルトAPKを使用してください。

2つ以上のレイアウトが必要ですか？[Custom Keyboard Layout](https://github.com/ris58h/custom-keyboard-layout)プロジェクトを基にそのようなAPKを構築できます。

サポートしたいですか？[コーヒーをください](https://www.buymeacoffee.com/ris58h)。

## プリビルトAPK
- CapsLockをCtrlに [ExKeyMo-caps2ctrl.zip](https://github.com/ris58h/exkeymo-server/files/12775514/ExKeyMo-caps2ctrl.zip)
- CapsLockをCtrlに、逆も可能 [ExKeyMo-swap-caps-and-ctrl.zip](https://github.com/ris58h/exkeymo-server/files/12775516/ExKeyMo-swap-caps-and-ctrl.zip)
- CapsLockをEscに [ExKeyMo-caps2esc.zip](https://github.com/ris58h/exkeymo-server/files/12775515/ExKeyMo-caps2esc.zip)
- CapsLockをEscに、逆も可能 [ExKeyMo-swap-caps-and-esc.zip](https://github.com/ris58h/exkeymo-server/files/12775517/ExKeyMo-swap-caps-and-esc.zip)

## アプリのインストールと設定

1. アプリをインストールします。アプリは自己署名されているため、Androidは信頼されていないソースについて警告します。注意：インストール時にエラーが発生した場合は、以前のバージョンがあれば先にアンインストールしてください。
2. `設定 -> 言語と入力 -> 物理キーボード`（正確なパスは異なる場合があります）に移動し、カスタマイズしたいキーボードを選択して`ExKeyMoレイアウト`を選択します。

## プロジェクトをローカルで実行する

### 必要条件
- Java（17以上）。

### 入手
Gitでソースコードをクローンしてください：
```
git clone git@github.com:ris58h/exkeymo-server.git
```
またはzipファイルとして[ダウンロード](https://github.com/ris58h/exkeymo-server/archive/refs/heads/master.zip)してください。

### ビルド
```
./mvnw clean install
```

### Run
```
java -jar target/exkeymo-server-*-jar-with-dependencies.jar
```
特定のポートで実行するには、`server.port` システムプロパティを使用します:
```
java -Dserver.port=PORT_NUMBER -jar target/exkeymo-server-*-jar-with-dependencies.jar
```

### 使用法
[http://localhost/](http://localhost/) にアクセスし、__RTFM__ を忘れずに行ってください（[http://localhost/docs.html](http://localhost/docs.html)）。

### Dockerでの実行
Dockerを使用してアプリケーションを実行できます。方法は2つあります：Docker Composeを使うか、単にDockerを使うかです。

#### Dockerを使用する場合
Dockerイメージをビルドします：
```bash
docker build -t exkeymo-server .
```

Dockerコンテナを実行する:
```bash
docker run -p 80:80 exkeymo-server
```
これによりコンテナが起動し、アプリケーションがポート80で公開されます。

#### Docker Composeの使用

DockerとDocker Composeがインストールされていることを確認してください。次に、`docker-compose.yml`ファイルがあるディレクトリで以下のコマンドを実行します：
```bash
docker-compose up
```
これによりDockerイメージがビルドされ、コンテナが起動し、アプリケーションがポート80で公開されます。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-16

---