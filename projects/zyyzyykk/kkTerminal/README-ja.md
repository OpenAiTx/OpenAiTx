# kkTerminal

> kkTerminal、Web SSH接続用ターミナル
>
> 作者: [zyyzyykk](https://github.com/zyyzyykk/)
>
> ソースコード: https://github.com/zyyzyykk/kkTerminal
>
> Docker Hubアドレス: https://hub.docker.com/repository/docker/zyyzyykk/kkterminal/general
>
> プレビュー: https://ssh.kkbpro.com/
>
> 更新日時: 2025-03-15
>

<p align="center"><a href="https://ssh.kkbpro.com/" target="_blank" rel="noopener noreferrer"><img width="100" src="https://kkbapps.oss-cn-shanghai.aliyuncs.com/logo/terminal.png" alt="kkTerminal"></a></p>

<p align="center">
  <a href="https://hub.docker.com/repository/docker/zyyzyykk/kkterminal/general"><img src="https://img.shields.io/docker/pulls/zyyzyykk/kkterminal?logo=docker" alt="Docker Image"></a>
  <a href="https://www.oracle.com/cn/java/technologies/downloads/#java8-windows"><img src="https://img.shields.io/badge/jdk-1.8-orange?logo=openjdk&logoColor=%23e3731c" alt="JDK Version"></a>
  <a href="https://spring.io/projects/spring-boot"><img src="https://img.shields.io/badge/springboot-2.7.15-green?color=6db33f&logo=springboot" alt="SpringBoot Version"></a>
  <a href="https://cn.vuejs.org/"><img src="https://img.shields.io/badge/vue-3.x-green?color=42b883&logo=vue.js" alt="Vue Version"></a>
  <a href="https://www.apache.org/licenses/"><img src="https://img.shields.io/badge/licence-Apache-red?logo=apache&logoColor=%23D22128" alt="Apache Licence"></a>
  <a href="https://github.com/zyyzyykk/kkTerminal"><img src="https://img.shields.io/github/stars/zyyzyykk/kkterminal" alt="GitHub"></a>
</p>
<p align="center">English ｜ <a href="https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/zh_CN/README.md" >简体中文</a></p>

### ⚡ クイック統合

HTMLのWebページにて `iframe` タグを利用して素早く統合できます:

```html
<iframe src="https://ssh.kkbpro.com/" height="400px" width="600px" ></iframe>
```

### 🐳 Dockerでデプロイ

1. イメージを取得:

```bash
docker pull zyyzyykk/kkterminal
```

2. ポートマッピングでコンテナを作成・実行: `-p ポート:3000`

```bash
docker run -d --name kkterminal -p 3000:3000 zyyzyykk/kkterminal
```

3. アートワードのカスタマイズ: `-e TITLE="ArtWord"`

```bash
docker run -d --name kkterminal -p 3000:3000 -e TITLE="kkbpro" zyyzyykk/kkterminal
```

4. ブラウザでアクセス: `http://server-ip:3000/`

### 🛸 プレビュー

下記のWebサイトにアクセスしてください: https://ssh.kkbpro.com/

![Connect](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/Connect.png)

![Preference](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/Preference.png)

![File](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/File.png)

![Editor](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/Editor.png)

[**その他のモジュールプレビュー**](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/MODULE.md)

### 💡 機能説明

1. kkTerminalはWeb SSH接続用ターミナルです。左上のターミナルアイコンをクリックし、接続設定を選択してSSH接続を確立します。

2. Webページで `iframe` タグを利用し、サードパーティサイトへのクイック統合をサポート

3. [URLパラメータ](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/PARAMS.md) によるターミナル構成のカスタマイズ対応

4. 国際化対応、中国語・英語の言語切替をサポート

5. ローカルPCでのデプロイをサポート、起動時自動でブラウザウィンドウを開きます

6. ウィンドウサイズの自動調整と中国語入力に対応

7. カスタム設定機能をサポートし、ユーザーは背景色/文字色、フォントサイズ、カーソル表示スタイル、ターミナルTCode有効化等を選択可能

8. 再起動をサポート：SSH接続設定やカスタム設定を変更した際に自動再起動、またはSSH接続切断後に手動で再起動可能

9. コピー＆ペースト対応：

   - コピー：`Git`ターミナルと同様、テキスト選択で自動コピー
   - ペースト：`Cmd`ターミナルと同様、右クリックでペースト（ブラウザのアクセス許可が必要）

9. ファイル管理をサポート、ファイル管理モジュールを開いてファイル/フォルダの閲覧・解凍・アップロード・ダウンロードが可能

10. 複数/全選択、コピー＆ペースト、カット、選択切替、オープン等のショートカットキー操作をサポート

11. ファイル閲覧・編集機能をサポートし、`ctrl+s`でリモートサーバーに保存可能

12. [TCode（ターミナルコード）](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/TCODE.md) をサポート、カスタマイズTCodeによりShellスクリプトのような自動化ワークフローを実現

13. 操作記録・クラウド同期機能対応

14. Cooperate、Monitor、Docker各機能に対応

### 👨‍💻 更新履歴

##### zyyzyykk/kkterminal:3.6.0: latest

- 高度なCooperate機能追加
- 高度なMonitor機能追加
- 高度なDocker機能追加
- パッケージ容量・Web表示の最適化

##### zyyzyykk/kkterminal:3.5.6: 

- より多くのURLパラメータ対応
- エディタのテキスト＆画像サイズのパーセンテージ指定追加
- Web表示の最適化

##### zyyzyykk/kkterminal:3.5.3: 

- ターミナル構成カスタマイズ用URLパラメータ追加
- 複数ウィンドウ再起動のバグ修正
- 操作記録＆クラウド同期機能追加
- 一部コードロジックのリファクタリング

[**過去の更新履歴**](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/UPDATE.md)

### 🧬 アーキテクチャ

```markdown
+---------+     http      +-------------+    ssh     +---------------+
| browser | <===========> | kk Terminal | <========> | remote server |
+---------+   websocket   +-------------+    sftp    +---------------+
Vue + Xterm              SpringBoot + SSHJ                Linux OS    
```

### 🏘️ 本プロジェクトについて

ユーザーの皆様へ

時間と労力の制約により、今後 `kkTerminal` のメンテナンスを継続することができません。

`kkTerminal` にご興味がある方、または保守を継続したい方は、お気軽にご連絡いただくか、Issueを立ててください。

バグの報告や新機能の要望等も、どうぞIssueをご利用ください。

最後に、`kkTerminal` をご支援いただきありがとうございました。心より、`kkTerminal` が皆様のお役に立てることを願っています。

敬具

[zyyzyykk](https://github.com/zyyzyykk/)

2025.03.15

### 🌟 スター

[![Stars](https://starchart.cc/zyyzyykk/kkTerminal.svg?variant=adaptive)](https://starchart.cc/zyyzyykk/kkTerminal)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---