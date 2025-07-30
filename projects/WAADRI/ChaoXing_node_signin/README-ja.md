<center><div align="center">

<img src="https://avatars.githubusercontent.com/u/90495619?v=4" width="300" height="300" style="border-radius: 50%"></img>

<img alt="version" src="https://img.shields.io/github/last-commit/WAADRI/ChaoXing_node_signin.svg?style=for-the-badge&label=%E6%9C%80%E5%90%8E%E6%9B%B4%E6%96%B0&logo=velog&logoColor=BE95FF&color=7B68EE"/></img>
<img alt="stars" src="https://img.shields.io/github/stars/WAADRI/ChaoXing_node_signin.svg?style=for-the-badge&label=Stars&logo=undertale&logoColor=orange&color=orange"/></img>
<img alt="forks" src="https://img.shields.io/github/forks/WAADRI/ChaoXing_node_signin.svg?style=for-the-badge&label=Forks&logo=stackshare&logoColor=f92f60&color=f92f60"/></img>
<img alt="pr" src="https://img.shields.io/github/issues-pr-closed/WAADRI/ChaoXing_node_signin.svg?style=for-the-badge&label=PR&logo=addthis&logoColor=green&color=0AC18E"/></img>
<img alt="issues" src="https://img.shields.io/github/issues/WAADRI/ChaoXing_node_signin.svg?style=for-the-badge&label=Issues&logo=openbugbounty&logoColor=e38dff&color=e38dff"/></img>

</div></center>

<div align="center" style="font-weight:bold"><b>学习通オンライン自動サインインシステム第三者ノード接続プログラム</b></div> 


自分でデプロイして [学习通オンライン自動サインインシステム](https://cx.waadri.top/login) に接続可能な第三者ノード用プログラムです。このノードプログラムはメインシステムと連携して使用してください！

---


## 🎃 オープンソースについて
学习通が頻繁にソースコード中のインターフェースを更新しているため（公式からの対応を疑って）、すべての機能を継続利用可能にするため、今後は最も基本的なサインインコードのみを公開します。完全な機能は自動サインインシステムで公式ノードを利用して体験してください。


## ✨ バージョンの違い

|          |                                    exe版                                    |                                    Python版                                     |                        Docker版                         |
| :------: | :---------------------------------------------------------------------------: | :-----------------------------------------------------------------------------: | :-----------------------------------------------------: |
| 対象者   |                             Windowsパソコン使用経験者向け                             |                              プログラミング経験者またはLinux経験者向け                              |                  NAS経験者またはLinux経験者向け                   |
| 機能差異 |                                       /                                       |                                        /                                        |                  amd64 と arm64 のみ対応                  |
| ダウンロードリンク | [exeダウンロードリンク](https://cx-static.waadri.top/download/other-signin-node.exe) | [Pythonダウンロードリンク](https://cx-static.waadri.top/download/other-signin-node.py) | `ccr.ccs.tencentyun.com/misaka-public/waadri-sign-node` |

## 🎉 セットアップガイド

設定ファイルの例：

```yaml
# 配置文件修改时注意在单引号内填写，不熟悉yaml文件格式的用户可在 https://www.json.cn/yaml-editor/ 中进行编辑并确认无误后粘贴回配置文件
# 邮件功能配置区
email:
  # 用来发送邮件的邮箱地址如XXX@qq.com，未填写则不发送邮件
  address: ''
  # 用来发送邮件的邮箱密码，某些邮箱可能需要填写授权码
  password: ''
  # 是否使用tls或ssl加密连接，默认true为使用加密连接，如不使用请填false，需注意大小写
  use_tls: true
  # 发送邮件服务器的host主机名，如QQ邮箱的发送邮件服务器主机名为smtp.qq.com
  host: ''
  # 发送邮件服务器端口号，请注意上方配置使用tls的状态，两种状态下的端口号一般不同
  port: 465
  # 发件人名称，可自行填写想让接收方看到的发件人名称，不填写则接收方看到的名称为发送人邮件地址
  user: ''
# 节点名称、密码和人数配置区
node:
  # 节点名称，不能和已接入在线自动签到系统的其它第三方节点名称重复
  name: ''
  # 节点密码，设置后用户需要在网站中输入正确的密码才能使用该节点，留空则为不设置密码，此时任何人均可使用该节点进行签到
  password: ''
  # 限制节点使用人数，0为不限制使用人数
  limit: 0
# 是否开启用户频繁信息显示，关闭后当用户使用接口2或接口3出现“请勿频繁操作”提示后将不会在控制台展示此类信息，默认true为显示，不显示请填false，需注意大小写
show_frequently: true
# 是否开启夜间签到监控，当关闭时接口2和接口3将在每日23时至次日6时暂停使用上述接口用户的签到监控，可尽量避免夜间频繁请求导致接口出现频繁提示，此配置不影响接口1在夜间进行监控，默认true为开启夜间监控，如不开启请填false，需注意大小写
night_monitor: true
# 是否启用debug模式，启用后日志输出更加详细，方便排查问题，建议使用时出现问题且命令行中未展示问题详细信息时再启用，默认false为不输出，要输出debug日志请填true，需注意大小写
debug: false
# 节点uuid，第一次启动程序时会随机生成，请勿更改，否则无法匹配已经使用该节点启动监控的用户信息
uuid: XXX
```

### 可执行版チュートリアル（exe版）

1. ダブルクリックで実行し、初回実行時に現在の場所に `node_config.yaml` 設定ファイルが生成されます。
2. `node_config.yaml` 内の `name` をお好きなノード名に変更し、uuid以外の他のオプションは任意で変更可能、またはデフォルトのままでも構いません。
3. 再度ダブルクリックで実行してください。

### Python版チュートリアル
1. `python3.10+` 環境をインストールしてください。
2. 以下のコマンドを使って実行します。実行後、必要なサードパーティライブラリが自動的に検出およびインストールされます。
```bash
wget -O "main.py" "https://cx-static.waadri.top/download/other-signin-node.py"
python3 main.py
```
3. `node_config.yaml` の `name` をお好みのノード名に変更してください。uuid以外の他のオプションは自由に変更しても、デフォルトのままにしても構いません。  
4. 再度実行してください。  

### Docker版チュートリアル  

エキスパートが作成したイメージ `ccr.ccs.tencentyun.com/misaka-public/waadri-sign-node`（`amd64` と `arm64` のみ対応）  

イメージはGithub Actionでビルドされています。詳細は [ビルドスクリプト](https://github.com/Misaka-1314/SignNode-AutoBuild) を参照してください。  

設定ファイルのディレクトリで実行してください。初回実行時に `node_config.yaml` 設定ファイルが生成されます。

```bash
docker run -d \
    --name=sign-node \
    -v $(pwd):/data \
    --restart=always \
    --dns=223.5.5.5 --dns=114.114.114.114 \
    ccr.ccs.tencentyun.com/misaka-public/waadri-sign-node
```
参考 Docker compose（必要に応じて適宜修正してください）

```
networks:
    1panel-network:
        external: true
        
services:
    AutoSign:
        container_name: ChaoXing-AutoSign
        image: ccr.ccs.tencentyun.com/misaka-public/waadri-sign-node
        volumes:
            - ./data:/data
        networks:
            - 1panel-network
        restart: always
        env_file:
            - 1panel.env
```

## 🎉 使用
![image](https://github.com/user-attachments/assets/a1808fbb-735d-46e1-86a1-67e81a969b9a)

運行開始後、オンライン自動サインインシステムで **その他の第三者選択ノード** をクリックすると、選択ノードリストが自動で表示され、選択して設定したパスワードを入力すると、選択したノードでサインイン監視が利用可能です。

+ 2024/11 現在、50以上のノードがシステムに接続されており、10以上のノードが公開利用可能です。皆様のノードリソースの積極的な提供を歓迎します。

![image](https://github.com/user-attachments/assets/bb4aee50-8ec7-4946-bc4c-0b55ca4a590c)

### 🎃 注意事項
- 学習交流目的のみで、違法な用途には使用しないでください
- 一部のインターフェースが悪用されるのを防ぎ、プロジェクトの持続可能性を確保するため、第三者ノードは手動サインインモード、フィッシング防止サインインモード、サインイン情報盗用モードをサポートせず、インターフェース4を使ったサインイン監視もサポートしていません。それ以外に、第三者ノードはノードオフライン時の自動切替機能をサポートせず、7日間サインインなしで自動停止する制限もありません。詳細な制限はサインインシステム内の第三者ノード使用注意書きをご確認ください。上記制限は公式アップデートによる機能不具合を防ぐためのもので、最も完全な機能を体験したい場合は公式ノードでのサインイン監視を推奨します。
- ノードプログラムはクラウドサーバー業者のIP環境下で構築しないでください。そうしないと学習通公式によりIPアドレスがブロックされ、サインイン監視ができなくなる可能性があります。四大通信事業者または教育ネットワークの環境で構築してください。
- 侵害があればご連絡ください。削除対応します：[Email](https://raw.githubusercontent.com/WAADRI/ChaoXing_node_signin/main/mailto:WiFi86@qq.com)

## 🏆 特別感謝

+ 本プロジェクトのミニプログラムアップロードサーバーは [萝莉猫 IDC](https://www.loricat.cn) の公益提供によります！

+ 本プロジェクトのCDN加速とセキュリティ保護は [腾讯 EdgeOne](https://edgeone.ai/?from=github) による提供です！

<img src="https://doc.micono.eu.org/image/ad/腾讯云 EdgeOne.png" width="200"></img>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-30

---