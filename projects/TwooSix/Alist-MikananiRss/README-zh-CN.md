<h1 align="center">
  Alist-MikananiRss
</h1>
<p align="center">
  从<a href="https://mikanani.me/">蜜柑计划</a>或其他动漫番剧相关的RSS订阅源中自动获取番剧更新并通过Alist离线下载至对应网盘
</p>  
<p align="center">
  并结合使用ChatGPT分析资源名，将资源重命名为Emby可解析的格式。
</p>  

--- 

[使用文档](https://github.com/TwooSix/Alist-MikananiRss/wiki/%E5%BF%AB%E9%80%9F%E5%BC%80%E5%A7%8B)
## 功能
- 自动获取番剧更新并下载至对应网盘
- 通过PushPlus, Telegram等渠道发送更新通知
- 自动重命名为emby可识别格式，同时支持对自动解析的结果进行自定义重映射，让重命名结果更准确

## 准备工作 
1. 请自行参照[Alist](https://github.com/alist-org/alist)项目文档部署Alist（版本须>=3.42.0），并搭建好Aria2/qBittorrent离线下载
2. 自行注册蜜柑计划账户，订阅番剧，获取订阅链接

附：对其余RSS订阅源也作了一定适配，理论上支持绝大多数订阅源(番剧相关)，对于未能支持的RSS，也欢迎上交issue

## 如何使用
Docker，源码运行等更多的运行方法详见[使用文档](https://github.com/TwooSix/Alist-MikananiRss/wiki/%E5%BF%AB%E9%80%9F%E5%BC%80%E5%A7%8B) 

使用pip安装运行
1. 请确保你的python版本在3.11以上
2. 使用pip安装: `pip install alist-mikananirss`
3. 在目录下新建一个`config.yaml`配置文件，并填写配置文件如下(完整功能示例详解见[配置说明](https://github.com/TwooSix/Alist-MikananiRss/wiki/%E9%85%8D%E7%BD%AE%E8%AF%B4%E6%98%8E))
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
4. 运行代码：`python -m alist_mikananirss --config /path/to/config.yaml`  
5. 享受吧


## 重命名效果展示
<div align=center>
<img src="https://github.com/TwooSix/Alist-MikananiRss/blob/master/imgs/show_pic1.png"/>
</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-22

---