
<div align="right">
  <details>
    <summary >🌐 Langue</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

<h1 align="center">
  Alist-MikananiRss
</h1>
<p align="center">
  Récupérez automatiquement les mises à jour d’animes depuis la <a href="https://mikanani.me/">Mikan Project</a> ou d’autres flux RSS liés aux animés, puis téléchargez-les hors ligne vers le cloud correspondant via Alist.
</p>  
<p align="center">
  Utilisez également ChatGPT pour analyser le nom des ressources et les renommer dans un format lisible par Emby.
</p>
</p>  

--- 

[Documentation d'utilisation](https://github.com/TwooSix/Alist-MikananiRss/wiki/%E5%BF%AB%E9%80%9F%E5%BC%80%E5%A7%8B)
## Fonctionnalités
- Obtention automatique des mises à jour d’anime et téléchargement vers le cloud correspondant
- Envoi de notifications de mise à jour via PushPlus, Telegram, etc.
- Renommage automatique au format reconnu par emby, avec support de la remapping personnalisée des résultats pour une précision accrue

## Pré-requis 
1. Veuillez déployer Alist vous-même selon la documentation du projet [Alist](https://github.com/alist-org/alist) (version >=3.42.0 requise), et configurer le téléchargement hors ligne Aria2/qBittorrent
2. Inscrivez-vous sur Mikan Project, abonnez-vous aux anime et obtenez le lien d’abonnement

Note : D’autres flux RSS ont également été adaptés, en théorie la plupart des sources d’abonnement RSS (liées aux anime) sont supportées. Si un flux RSS n’est pas pris en charge, n’hésitez pas à soumettre un issue.

## Comment utiliser
Voir la [documentation d'utilisation](https://github.com/TwooSix/Alist-MikananiRss/wiki/%E5%BF%AB%E9%80%9F%E5%BC%80%E5%A7%8B) pour les méthodes de lancement via Docker, exécution du code source, etc.

Installation et exécution via pip
1. Assurez-vous que votre version de python est supérieure à 3.11
2. Installer via pip : `pip install alist-mikananirss`
3. Créez un nouveau fichier de configuration `config.yaml` dans le répertoire, puis remplissez-le comme suit (pour un exemple complet, voir [Explications de configuration](https://github.com/TwooSix/Alist-MikananiRss/wiki/%E9%85%8D%E7%BD%AE%E8%AF%B4%E6%98%8E))
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
4. Exécutez le code : `python -m alist_mikananirss --config /path/to/config.yaml`  
5. Profitez-en


## Présentation de l'effet de renommage
<div align=center>
<img src="https://github.com/TwooSix/Alist-MikananiRss/blob/master/imgs/show_pic1.png"/>
</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-23

---