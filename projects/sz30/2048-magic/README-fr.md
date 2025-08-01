<div align="right">
  <details>
    <summary >🌐 Autre langue</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>


[Anglais](https://raw.githubusercontent.com/sz30/2048-magic/main/README.md) | [简体中文](https://raw.githubusercontent.com/sz30/2048-magic/main/README.zh-CN.md) | [繁體中文](https://raw.githubusercontent.com/sz30/2048-magic/main/README.zh-TW.md)

# 🎮 2048++

Une version améliorée du jeu classique 2048, avec encore plus de fonctionnalités amusantes ! C'est un petit projet que j'ai développé pendant mon temps libre—j'espère qu'il vous apportera un peu de joie !

## 🎯 Introduction au jeu

2048 est un jeu d'assemblage de chiffres simple mais addictif. Sur une grille 4x4, glissez vers le haut, le bas, la gauche ou la droite pour fusionner les tuiles de même valeur. Le but ? Atteindre 2048 (mais vous pouvez continuer pour faire encore plus de points) !

**Comment jouer :**
- Utilisez les flèches directionnelles ou les touches WASD pour déplacer les tuiles.
- Lorsque deux tuiles du même nombre se rencontrent, elles fusionnent en une seule.
- Après chaque mouvement, un nouveau 2 ou 4 apparaît aléatoirement sur une case vide.
- La partie se termine lorsqu'il n'y a plus de mouvements possibles.

## ✨ Fonctionnalités spéciales

### 1. Fonction Annuler
- Une mauvaise manipulation ? Pas de panique !
- Appuyez simplement sur le bouton « Annuler » pour revenir en arrière d’un coup.
- Vous pouvez annuler autant de fois que vous le souhaitez, jusqu’au début de la partie.
- Ne laissez plus jamais une fausse manœuvre gâcher votre partie !

### 2. Mode triche secret
- Entrez la séquence magique : ←←→→ →→←← (gauche, gauche, droite, droite, droite, droite, gauche, gauche)
- Toutes les tuiles deviendront magiquement des 128 !
- C’est un œuf de Pâques, juste pour s’amuser.
- Astuce : Tricher c’est amusant, mais n’en abusez pas ! 😉

## 🎯 Démo

🎯 Jouez ici : [2048.765431.xyz](https://2048.765431.xyz/)
<img width="1279" alt="demo" src="https://github.com/user-attachments/assets/0df2c956-b6d9-4371-a916-f6ac3ae642be" />



## 📁 Structure du projet
```
2048/
├── static/
│ ├── css/
│ │ └── styles.css # Game styles
│ └── js/
│ └── script.js # Frontend game logic
├── index.html # Main game page
└── 2048.py # Backend server
```
**Descriptions des fichiers :**
- `2048.py` : Serveur backend écrit avec Flask, gère la logique du jeu et les requêtes API.
- `script.js` : Logique du jeu côté frontend, incluant mouvements, animations et fonctionnalités spéciales.
- `styles.css` : Styles du jeu, assurant un rendu agréable et réactif.
- `index.html` : La page principale qui rassemble tous les éléments.

## 🚀 Pour commencer

**Méthode 1 : Télécharger la version**
1. Téléchargez la dernière version.
2. Assurez-vous d’avoir Python 3.x installé.
3. Installez les dépendances : `pip install flask`
4. Exécutez : `python 2048.py`
5. Ouvrez votre navigateur et allez sur : [http://localhost:9969](http://localhost:9969)

**Méthode 2 : Cloner depuis GitHub**
```bash
git clone https://github.com/sz30/2048.git
cd 2048
pip install flask
python 2048.py
```
## 🎨 Personnalisation

Envie de le personnaliser ? Modifiez `styles.css` pour un nouveau look, ou plongez dans `script.js` pour changer le gameplay. Tout le code est bien commenté pour faciliter le hacking !

## 📝 Licence

Licence GPL-2.0

## 🤝 Contribution

Toujours en cours de mise à jour ! Les Issues et Pull Requests sont les bienvenus—rendons ce jeu encore plus génial ensemble !


## 🙏 Remerciements

Merci aux sponsors suivants pour leur soutien à ce projet :
- [IDC.REST](https://idc.rest/) qui fournit le serveur
- [Serv00](https://www.serv00.com/) qui fournit le serveur

---
_Dernière mise à jour : juin 2025_



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---