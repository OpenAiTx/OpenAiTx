<h1 align="center">Patch de traduction communautaire Master Duel en chinois</h1>
<div align="center">

![GitHub releases](https://img.shields.io/github/v/release/mikualpha/master-duel-chinese-switch?style=flat-square)
![GitHub license](https://img.shields.io/github/license/mikualpha/master-duel-chinese-switch?style=flat-square)
![GitHub last commit](https://img.shields.io/github/last-commit/mikualpha/master-duel-chinese-switch?style=flat-square)
![GitHub Gist last commit](https://img.shields.io/github/gist/last-commit/de53fb59b1c63a8be98539e04aba5d42?style=flat-square&label=metadata%20version)
![GitHub download count](https://img.shields.io/github/downloads/mikualpha/master-duel-chinese-switch/total?style=flat-square)

[Adresse du projet original](https://gitee.com/fetiss/master-duel-chinese-switch) | [Page de publication originale](https://www.bilibili.com/read/cv21869124) | [Source API](https://ygocdb.com/)
  
</div>

Depuis la version début mai 2023, MD a modifié la méthode d’appel des fichiers cache, ce qui rend le patch de traduction initial obsolète. Des modifications ont donc été apportées sur la base du projet original.

Ce projet est basé sur le travail des auteurs [@叶lf](https://space.bilibili.com/23834819) / [@Timelic](https://space.bilibili.com/8664322), à qui nous adressons nos remerciements ! Merci également à [@拓王神](https://space.bilibili.com/483116312) pour son soutien dans la partie analyse des données.

## Mode d’emploi
Rendez-vous sur la [page Releases](https://github.com/mikualpha/master-duel-chinese-switch/releases) pour télécharger `MDTR_vx.x.x.exe` et consultez la page [Wiki](https://github.com/mikualpha/master-duel-chinese-switch/wiki) de ce projet pour les instructions d’utilisation.

## À propos du projet
Ce projet est open source sous licence `AGPL-3.0`. Toute distribution ou modification doit impérativement respecter la [licence open source](https://www.chinasona.org/gnu/agpl-3.0-cn.html). La page Release de ce projet est la seule source officielle de distribution. Il n’existe aucun groupe officiel, aucun fichier exécutable ne sera publié sur des plateformes tierces, ni aucune option d’achat, don ou récompense payante proposée sur ces plateformes. Méfiez-vous des virus ou arnaques.

En cas d’erreur ou de plantage, vous pouvez ouvrir un `issue`. **Les contributions via PR sont les bienvenues !**

**Si ce projet vous est utile, pensez à lui donner une `Star`, merci !**

## Développement
Ce projet utilise `UnityPy` pour le dépaquetage et `flet` pour l’interface. L’environnement de compilation est `Python 3.10`.

<div align="center">
  <img src="https://raw.githubusercontent.com/mikualpha/master-duel-chinese-switch/master/./images/display.png" width="400">
</div>

#### Préparation

```
pip install -r requirements.txt
```

#### 开发

无界面

```
python3 index.py
```

interface flet

```
flet run interface.py
```

#### 打包

PowerShell:

```
./release.ps1
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-24

---