# Thème macOS pour Joplin

Thème macOS d'apparence native pour l'application de prise de notes [Joplin](https://joplinapp.org/) v2.2.4 et supérieure. Fonctionne également sur les appareils non macOS.

![Thème macOS pour Joplin](/images/macos-theme-for-joplin.png)

- ✨ Interface entièrement stylisée, incluant tous les contrôles,
- 🌜 Choisissez entre clair, sombre, clair avec barre latérale sombre ou auto (clair/sombre selon les préférences système),
- 👌 Utilisez les icônes natives (macOS uniquement) ou la famille d’icônes Phosphor,
- 👨‍🎨 Facile à personnaliser via les préférences de Joplin.

## Installation

- Ouvrez les préférences de Joplin › « Plugins », recherchez « macOS theme » et installez le thème.
- Redémarrez Joplin. Profitez-en !

Assurez-vous de régler « Apparence › Thème » sur « Clair » ou « Sombre ». Si vous constatez un flash lors du changement de carnet, synchronisez les réglages Clair/Sombre sous « Apparence › Thème » avec la valeur sélectionnée sous « macOS theme › Apparence ». Pour plus d’options de personnalisation, voir ci-dessous.

## Personnalisation

Après l’installation, vous trouverez un élément supplémentaire nommé « macOS theme » dans les préférences de Joplin. Vous devez redémarrer Joplin pour appliquer les modifications.

**Utilisateurs Mac** : Si vous souhaitez utiliser les icônes natives, téléchargez et installez SF Pro depuis le [site Apple ici](https://developer.apple.com/fonts/).

## Pas d’icônes ?

**Utilisateurs Windows** : Si les icônes apparaissent sous forme de carrés vides ou manquent, vous devez installer manuellement la police Phosphor. Téléchargez-la depuis [phosphoricons.com](https://phosphoricons.com/) ([téléchargement direct](https://phosphoricons.com/assets/phosphor-icons.zip)), décompressez le fichier, installez `Fonts/regular/Phosphor.ttf` et redémarrez Joplin.

**Utilisateurs Mac** : Si vous avez réglé la famille d’icônes sur « macOS native (SF Pro) », vous devez avoir SF Pro installé depuis le [site Apple](https://developer.apple.com/fonts/). Notez que cela ne fonctionne que sur les appareils macOS.

## Avertissement

⚠️ Joplin utilise styled-components pour le stylisme, ce qui rend très difficile la création d’un thème pour l’application. De nombreuses astuces CSS bricolées et des `!important` ont été utilisées. Cela peut causer des problèmes d’interface avec les futures versions de Joplin. Comme il s’agit uniquement de CSS, vos données restent sécurisées et vous pouvez facilement revenir aux styles précédents.

N’hésitez pas à [créer un problème](https://github.com/ajilderda/joplin-macos-native-theme/issues) ou à poster un message [sur le forum](https://discourse.joplinapp.org/t/plugin-macos-theme-for-joplin) si vous rencontrez des difficultés.

## Aide, j’obtiens un écran blanc après l’installation du plugin.

Si vous avez un écran blanc après l’installation du plugin, cela est probablement dû à un problème de gestion des émojis. Voici comment le résoudre :

1. Tout d'abord, localisez votre répertoire de configuration Joplin :

   - macOS : `~/.config/joplin-desktop`
   - Windows : `%APPDATA%\Joplin`
   - Linux : `~/.config/Joplin`

2. Naviguez vers le dossier `plugins` et supprimez le fichier `.jpl` du plugin de thème macOS.
3. Redémarrez Joplin.

### Prévention

Pour éviter que ce problème ne se reproduise :

- Au lieu d'utiliser la boîte de dialogue "Choisir un emoji..." de Joplin, ajoutez directement les emojis dans la zone de texte du titre du carnet (voir [cette discussion](https://github.com/andrejilderda/joplin-macos-native-theme/issues/96#issuecomment-1553517708) pour une référence visuelle).
- Vous pouvez maintenant réinstaller le plugin.

## Développement

Vous pouvez modifier le thème via les préférences de Joplin. Si vous souhaitez aller plus loin, suivez les étapes suivantes pour créer votre propre version.

Installez les dépendances :

```sh
npm install
```
Pour construire le plugin :


```sh
npm run dist
```

Pour mettre à jour le cadre du plugin :

```sh
npm run update
```
Pour construire le CSS et surveiller les modifications :


```sh
npm run dev
```

Le CSS généré sera disponible à : http://localhost:8080/macos-theme-for-joplin.css

## Contribution

Les contributions (en particulier les corrections) sont les bienvenues !

### Flux de développement

Devoir redémarrer Joplin à chaque modification est un peu pénible. Pour accélérer les choses et raccourcir la boucle de rétroaction :

1. Exécutez `npm run dev`. Cela surveillera les modifications des fichiers .scss et reconstruira le CSS.
2. Activez les outils de développement de Joplin (**Aide › Activer les outils de développement**)
3. Choisissez l’une des deux méthodes de rafraîchissement depuis [ce gist](https://gist.github.com/andrejilderda/f6673f1b1a986b2dc0cd01607acbff26).
4. Collez et exécutez le script dans la console des outils de développement pour rafraîchir automatiquement le CSS.

Cela fonctionne bien la plupart du temps, mais notez que dans certains cas, les styles modifiés interfèrent avec ceux du plugin installé. Pour vérifier si c’est le cas, vous pouvez assurer un environnement propre en :

1. Désinstallant le plugin thème macOS s’il est déjà installé.
2. Effectuant une compilation : `npm run build`
3. Dans Joplin, allez à **Plugins › Afficher les paramètres avancés**.
4. Sous **Plugins de développement**, collez le chemin vers votre dossier `dist`.
5. Redémarrez Joplin pour charger votre build local du plugin.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-23

---