<h1 align="center">
  Alist-MikananiRss
</h1>
<p align="center">
  Récupération automatique des mises à jour d’anime depuis <a href="https://mikanani.me/">Mikan Project</a> ou d’autres flux RSS liés aux animés, puis téléchargement hors ligne via Alist vers le cloud correspondant.
</p>  
<p align="center">
  Utilisation combinée de ChatGPT pour analyser les noms de ressources et renommer les fichiers dans un format reconnu par Emby.
</p>  

--- 

[Documentation d’utilisation](https://github.com/TwooSix/Alist-MikananiRss/wiki/%E5%BF%AB%E9%80%9F%E5%BC%80%E5%A7%8B)
## Fonctionnalités
- Récupération automatique des mises à jour d’anime et téléchargement vers le cloud correspondant
- Envoi de notifications de mise à jour via PushPlus, Telegram et autres canaux
- Renommage automatique au format reconnu par emby, avec prise en charge de remappages personnalisés pour affiner la précision du renommage

## Préparatifs 
1. Veuillez déployer Alist selon la documentation du projet [Alist](https://github.com/alist-org/alist) (version >= 3.42.0), et configurer Aria2/qBittorrent pour le téléchargement hors ligne
2. Inscrivez-vous sur Mikan Project, abonnez-vous aux animés et récupérez le lien d’abonnement

Note : Une certaine adaptation a été réalisée pour d’autres flux RSS, en théorie la plupart des flux liés aux animés sont supportés. Pour les flux non supportés, n’hésitez pas à ouvrir un issue.

## Comment utiliser
Docker, exécution depuis le code source et autres méthodes sont détaillées dans la [documentation d’utilisation](https://github.com/TwooSix/Alist-MikananiRss/wiki/%E5%BF%AB%E9%80%9F%E5%BC%80%E5%A7%8B) 

Installation et exécution via pip
1. Assurez-vous que votre version de Python est au moins 3.11
2. Installez avec pip : `pip install alist-mikananirss`
3. Créez un fichier `config.yaml` dans le répertoire et remplissez-le comme suit (exemple complet des fonctionnalités dans la [description de la configuration](https://github.com/TwooSix/Alist-MikananiRss/wiki/%E9%85%8D%E7%BD%AE%E8%AF%B4%E6%98%8E))
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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-22

---