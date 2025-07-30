<center><div align="center">

<img src="https://avatars.githubusercontent.com/u/90495619?v=4" width="300" height="300" style="border-radius: 50%"></img>

<img alt="version" src="https://img.shields.io/github/last-commit/WAADRI/ChaoXing_node_signin.svg?style=for-the-badge&label=%E6%9C%80%E5%90%8E%E6%9B%B4%E6%96%B0&logo=velog&logoColor=BE95FF&color=7B68EE"/></img>
<img alt="stars" src="https://img.shields.io/github/stars/WAADRI/ChaoXing_node_signin.svg?style=for-the-badge&label=Stars&logo=undertale&logoColor=orange&color=orange"/></img>
<img alt="forks" src="https://img.shields.io/github/forks/WAADRI/ChaoXing_node_signin.svg?style=for-the-badge&label=Forks&logo=stackshare&logoColor=f92f60&color=f92f60"/></img>
<img alt="pr" src="https://img.shields.io/github/issues-pr-closed/WAADRI/ChaoXing_node_signin.svg?style=for-the-badge&label=PR&logo=addthis&logoColor=green&color=0AC18E"/></img>
<img alt="issues" src="https://img.shields.io/github/issues/WAADRI/ChaoXing_node_signin.svg?style=for-the-badge&label=Issues&logo=openbugbounty&logoColor=e38dff&color=e38dff"/></img>

</div></center>

<div align="center" style="font-weight:bold"><b>Système de connexion automatique en ligne Xuexitong - Programme d’intégration de nœuds tiers</b></div> 


Utilisé pour déployer soi-même des nœuds tiers pouvant être intégrés au [Système de connexion automatique en ligne Xuexitong](https://cx.waadri.top/login), ce programme de nœud doit être utilisé conjointement avec le système principal !

---


## 🎃 À propos de l’open source
En raison de ~~suspicions d’être ciblé par les officiels~~ des mises à jour fréquentes des interfaces dans le code source de Xuexitong, afin d’assurer la continuité de toutes les fonctionnalités, seules les versions les plus basiques du code de connexion seront publiées à l’avenir, pour une fonctionnalité complète, veuillez vous connecter au système automatique de connexion et utiliser les nœuds officiels pour l’expérience


## ✨ Différences de versions

|          |                                    Version exe                                    |                                    Version Python                                     |                        Version Docker                         |
| :------: | :----------------------------------------------------------------------------: | :---------------------------------------------------------------------------------: | :-----------------------------------------------------------: |
| Public cible |                             Expérience d’utilisation sur ordinateur Windows                             |                              Expérience en programmation ou Linux                              |                  Expérience NAS ou Linux                   |
| Différences fonctionnelles |                                       /                                       |                                        /                                        |                  Supporte uniquement amd64 et arm64                  |
| Lien de téléchargement | [Lien de téléchargement exe](https://cx-static.waadri.top/download/other-signin-node.exe) | [Lien de téléchargement Python](https://cx-static.waadri.top/download/other-signin-node.py) | `ccr.ccs.tencentyun.com/misaka-public/waadri-sign-node` |

## 🎉 Tutoriel d’installation

Exemple de fichier de configuration :

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

### Tutoriel version exécutable (version exe)

1. Double-cliquez pour exécuter, la première exécution générera un fichier de configuration `node_config.yaml` dans le répertoire actuel.  
2. Modifiez le champ `name` dans `node_config.yaml` avec le nom de nœud que vous préférez, vous pouvez modifier les autres options sauf `uuid` ou les laisser par défaut.  
3. Double-cliquez à nouveau pour exécuter.  

### Tutoriel version Python  
1. Installez un environnement `python3.10+`  
2. Utilisez la commande suivante pour exécuter, les bibliothèques tierces nécessaires seront automatiquement détectées et installées après l'exécution.
```bash
wget -O "main.py" "https://cx-static.waadri.top/download/other-signin-node.py"
python3 main.py
```
3. Modifiez le champ `name` dans `node_config.yaml` avec le nom de nœud de votre choix, les autres options sauf l'uuid peuvent être modifiées à votre convenance ou laissées par défaut.  
4. Exécutez à nouveau.  

### Tutoriel version Docker  

Image créée par un expert `ccr.ccs.tencentyun.com/misaka-public/waadri-sign-node` (supporte uniquement `amd64` et `arm64`)  

L'image est construite via Github Action, voir le [script de construction](https://github.com/Misaka-1314/SignNode-AutoBuild) pour plus de détails  

Exécutez dans le répertoire contenant les fichiers de configuration, la première exécution générera le fichier de configuration `node_config.yaml`.

```bash
docker run -d \
    --name=sign-node \
    -v $(pwd):/data \
    --restart=always \
    --dns=223.5.5.5 --dns=114.114.114.114 \
    ccr.ccs.tencentyun.com/misaka-public/waadri-sign-node
```

Référez-vous à Docker compose (modifiez selon les besoins)
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

## 🎉 Utilisation
![image](https://github.com/user-attachments/assets/a1808fbb-735d-46e1-86a1-67e81a969b9a)

Après mise en ligne, vous pouvez cliquer sur **Autres nœuds tiers sélectionnés** dans le système de pointage automatique en ligne, une liste de nœuds sélectionnés apparaîtra automatiquement, choisissez et saisissez votre mot de passe défini pour utiliser le nœud sélectionné pour la surveillance du pointage.

+ En 11/2024, plus de 50 nœuds ont été intégrés au système, plus d'une dizaine de nœuds sont ouverts à l'utilisation, nous invitons tout le monde à continuer de contribuer activement des ressources de nœuds.

![image](https://github.com/user-attachments/assets/bb4aee50-8ec7-4946-bc4c-0b55ca4a590c)

### 🎃 Remarques importantes
- Strictement pour l'apprentissage et l'échange, ne pas utiliser à des fins illégales
- Pour éviter que certaines interfaces ne soient utilisées malicieusement et garantir la durabilité du projet, les nœuds tiers ne supportent pas le mode de pointage manuel, le mode anti-phishing ou le mode d’usurpation d’informations de pointage, ni l’utilisation de l’interface 4 pour la surveillance du pointage. En outre, les nœuds tiers ne supportent pas le remplacement automatique de nœuds en cas de déconnexion, ni l’arrêt automatique de la surveillance du pointage sans pointage pendant 7 jours. Les restrictions spécifiques sont définies dans les instructions d’utilisation des nœuds tiers dans le système de pointage ; ces limitations visent à prévenir des dysfonctionnements causés par les mises à jour officielles. Pour une expérience complète, veuillez utiliser les nœuds officiels pour la surveillance du pointage.
- Ne pas déployer le programme de nœud sous une IP de fournisseur de serveur cloud, sinon l’adresse IP pourrait être bloquée par l’administration officielle de l’apprentissage en ligne, rendant impossible la surveillance du pointage. Veuillez déployer dans un environnement réseau d’un des quatre grands opérateurs ou du réseau éducatif.
- En cas d’atteinte aux droits, veuillez nous contacter pour suppression : [Email](https://raw.githubusercontent.com/WAADRI/ChaoXing_node_signin/main/mailto:WiFi86@qq.com)

## 🏆 Remerciements particuliers

+ Le serveur de téléchargement de la mini-application de ce projet est sponsorisé à but non lucratif par [LoliCat IDC](https://www.loricat.cn) !

+ L’accélération CDN et la protection de sécurité de ce projet sont sponsorisées par [Tencent EdgeOne](https://edgeone.ai/?from=github) !

<img src="https://doc.micono.eu.org/image/ad/腾讯云 EdgeOne.png" width="200"></img>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-30

---