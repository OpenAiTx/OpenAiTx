<h1 align="center">
  Alist-MikananiRss
</h1>
<p align="center">
  <a href="https://mikanani.me/">蜜柑計画</a>やその他のアニメ関連のRSS購読元から自動的にアニメの更新を取得し、Alistを通じて対応するクラウドストレージにオフラインダウンロードします
</p>  
<p align="center">
  またChatGPTを活用してリソース名を解析し、Embyが解析可能な形式にリネームします。
</p>  

--- 

[使用ドキュメント](https://github.com/TwooSix/Alist-MikananiRss/wiki/%E5%BF%AB%E9%80%9F%E5%BC%80%E5%A7%8B)
## 機能
- アニメの更新を自動取得し対応するクラウドストレージにダウンロード
- PushPlusやTelegramなどのチャネルを通じて更新通知を送信
- Embyが認識可能な形式へ自動リネームし、自動解析結果に対するカスタムマッピングもサポートし、リネーム結果の精度を向上

## 準備作業 
1. [Alist](https://github.com/alist-org/alist)プロジェクトのドキュメントに従いAlistをデプロイしてください（バージョンは>=3.42.0必須）、およびAria2/qBittorrentによるオフラインダウンロード環境を構築
2. 蜜柑計画のアカウントを自身で登録し、アニメを購読し購読リンクを取得

補足：その他のRSS購読元にもある程度対応しており、理論上ほとんどのアニメ関連購読元をサポートしています。未対応のRSSについてはissueの提出も歓迎します。

## 使い方
Dockerやソースコード実行などの詳細な実行方法は[使用ドキュメント](https://github.com/TwooSix/Alist-MikananiRss/wiki/%E5%BF%AB%E9%80%9F%E5%BC%80%E5%A7%8B)を参照

pipを使ったインストールと実行
1. Pythonのバージョンが3.11以上であることを確認
2. pipでインストール: `pip install alist-mikananirss`
3. 作業ディレクトリに`config.yaml`ファイルを新規作成し、以下の設定を記入（完全な機能サンプル解説は[設定説明](https://github.com/TwooSix/Alist-MikananiRss/wiki/%E9%85%8D%E7%BD%AE%E8%AF%B4%E6%98%8E)を参照）
   ```yaml
   common:
     interval_time: 300
   
   alist:
     base_url: https://example.com # 修改为你的alist访问地址
     token: alist-xxx # 修改为你的alist token；可在"管理员后台->设置->其他"中找到
     downloader: qBittorrent # 或者 aria2
     download_path: Onedrive/Anime # 修改为你的下载路径(Alist中的路径)

   mikan:
     subscribe_url:
       - https://mikanani.me/RSS/MyBangumi?token=xxx # 修改为你的蜜柑订阅地址
       # - https://mikanani.me/RSS/MyBangumi?token=xxx2 # 多条RSS订阅链接情况
   
     filters:
       - 非合集 # 程序暂不支持合集等形式的重命名，若使用重命名功能推荐使用此过滤器
   ```
4. コードを実行：`python -m alist_mikananirss --config /path/to/config.yaml`  
5. お楽しみください


## リネーム効果の表示
<div align=center>
<img src="https://github.com/TwooSix/Alist-MikananiRss/blob/master/imgs/show_pic1.png"/>
</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-22

---