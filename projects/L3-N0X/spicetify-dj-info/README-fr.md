# Spicetify DJ Info

Bienvenue dans l'extension Spicetify DJ Info ! Cette extension améliore votre expérience Spicetify en fournissant des données d'analyse précieuses pour chaque piste, y compris la tonalité, le BPM, la popularité et l'année. Avec cette extension, vous pouvez approfondir vos connaissances sur votre bibliothèque musicale et découvrir des chansons parfaitement adaptées à votre set DJ ou playlist.

## ⭐Fonctionnalités

- **Tonalité :** Identifiez la tonalité de chaque chanson en notation standard (Dbm) ou selon le système Camelot (3B). Le système Camelot simplifie le mixage harmonique en classant les tonalités en groupes harmonieux compatibles. Cela permet des transitions plus fluides entre les morceaux lors des sets DJ ou lors de la création de playlists cohérentes.
- **BPM ♫ (Battements Par Minute) :** Obtenez le tempo de chaque chanson, indiquant la vitesse ou le rythme de la musique. Le BPM est utile pour créer des playlists avec une vitesse similaire ou pour sélectionner des chansons adaptées à des activités spécifiques.
- **Popularité ♥ :** Découvrez la popularité de vos chansons en accédant à leurs notes de popularité. Ces données peuvent aider à comprendre la réception globale et la popularité d’un morceau.
- **Année :** Découvrez quand vos chansons ont été publiées. Ces données peuvent être utiles pour créer des playlists avec des morceaux d’une période spécifique.

![Capture d’écran](https://raw.githubusercontent.com/L3-N0X/spicetify-dj-info/main/img/playlist.png)
![Capture d’écran](https://raw.githubusercontent.com/L3-N0X/spicetify-dj-info/main/img/now-playing.png)

## 💻 Installation

Copiez `dist/djinfo.mjs` dans le répertoire des extensions de votre [Spicetify](https://github.com/spicetify/spicetify-cli) :

| **Plateforme** | **Chemin**                                                                            |
| -------------- | ------------------------------------------------------------------------------------- |
| **Linux**      | `~/.config/spicetify/Extensions` ou `$XDG_CONFIG_HOME/.config/spicetify/Extensions/`  |
| **MacOS**      | `~/.config/spicetify/Extensions` ou `$SPICETIFY_CONFIG/Extensions`                    |
| **Windows**    | `%appdata%/spicetify/Extensions/`                                                    |

Après avoir placé le fichier de l’extension dans le dossier approprié, exécutez la commande suivante pour installer l’extension :

```bash
spicetify config extensions djinfo.mjs
spicetify apply
```

Ou vous pouvez modifier manuellement votre fichier `config-xpui.ini`. Ajoutez les noms de fichiers d'extension souhaités dans la clé extensions, séparés par le caractère |.
Exemple :

```ini
[AdditionalOptions]
...
extensions = autoSkipExplicit.js|shuffle+.js|trashbin.js|djinfo.mjs
```

Ensuite, exécutez :

```bash
spicetify apply
```

**Peut causer des problèmes avec les évaluations par étoiles !**

## ❌ Désinstallation

Exécutez la commande suivante pour désinstaller l'extension (notez le - à la fin) :

```bash
spicetify config extensions djinfo.mjs-
spicetify apply
```

Vous pouvez également modifier manuellement votre fichier `config-xpui.ini`. Il suffit de supprimer complètement le nom de fichier des extensions.  
Exemple :  

```ini
[AdditionalOptions]
...
extensions = autoSkipExplicit.js|shuffle+.js|trashbin.js
```

Ensuite, exécutez :

```bash
spicetify apply
```

## ⚙️ Paramètres

Vous avez la possibilité de basculer la visibilité des informations DJ dans l'extension. Par défaut, les informations DJ telles que la tonalité, le BPM, la popularité et l'année sont affichées pour chaque chanson et également à côté de la chanson en cours de lecture. Cependant, si vous préférez une interface plus épurée, vous pouvez facilement les masquer séparément.

Pour basculer la visibilité des informations DJ, suivez ces étapes :

1. Ouvrez Spotify
2. Trouvez l'icône de menu en haut à droite de l'interface (votre photo de profil) et cliquez sur l'icône
3. Dans le menu, trouvez l'option 'Infos DJ'
4. Dans le sous-menu, cliquez sur l'interrupteur pour masquer ou afficher ce que vous voulez
5. Cliquez sur Appliquer les modifications pour rendre vos réglages visibles

## 📜 Journal des modifications

### V 2.4.0

- Mise à jour vers une API différente
- Amélioration du style
- Ajout de nouvelles options pour les nouvelles fonctionnalités audio

### V 2.3.3

- Correction du spam de logs

### V 2.3.2

- Correction de la mise en page avec la nouvelle interface de mix

### V 2.3.1

- Correction de l'API qui cassait l'extension
- Suppression de la danseabilité et de l'énergie car elles ne sont pas disponibles dans la nouvelle API
- Ajout d'une nouvelle interface pour les infos DJ et amélioration de l'ancienne version, qui peut toujours être utilisée en désactivant l'interface riche
- Correction de la mise en cache et migration vers un nouveau système utilisant IndexedDB au lieu de LocalStorage
- Les nouvelles couleurs de la tonalité Camelot peuvent être personnalisées en écrasant les variables CSS

### V 2.2.1

- Fonctionne désormais correctement dans les recommandations
- Le cache a été considérablement amélioré  
- Les données sont récupérées par lots, corrigeant les données manquantes dues aux limites de taux  
- Fonctionne à nouveau avec la nouvelle interface Playlist  
- Amélioration des performances de chargement  
- Amélioration de la journalisation des erreurs  
- Corrections de bugs pour #16, #23, #24 et #25  

### V 2.1.1  

- Correction des styles dans la section des chansons recommandées  

### V 2.1.0  

- Ajout de l’option pour voir les infos DJ dans la section des chansons recommandées  
- Correction d’un bug où les infos DJ n’apparaissaient pas dans la section Discographie ([#2](https://github.com/L3-N0X/spicetify-dj-info/issues/2))  
- Correction d’un bug dans la file d’attente ([#9](https://github.com/L3-N0X/spicetify-dj-info/issues/9))  

### V 2.0.0  

- Amélioration des performances grâce au stockage local des données pour accélérer le temps de chargement et réduire les appels API  
- Refondation du menu Paramètres pour basculer plus facilement la visibilité des informations DJ  

### V 1.1.0  

- Ajout de l’option pour activer/désactiver l’Année, la Popularité, la Dansabilité et la Tonalité en notation standard  
- Corrections de bugs  

## 🌐 Crédits & Remerciements  

Un grand merci à [obafgkmdh](https://github.com/obafgkmdh) et [FixeQD](https://github.com/FixeQD) pour avoir réparé l’extension après la rupture de l’API interne, migré toute l’API vers l’API interne basée sur protobuf et également pour avoir ajouté une meilleure structure de fichiers avec le bundling !  

Et aussi merci à [Golevka2001](https://github.com/Golevka2001) pour l’idée d’un meilleur alignement des infos DJ dans la playlist !  

Un grand merci à [duffey](https://github.com/Tetrax-10) pour le code principal affichant les informations dans la playlist et le widget « maintenant en lecture » !  

Merci également à [je09](https://github.com/je09) pour sa contribution au code affichant à la fois la notation standard et le système Camelot pour la tonalité ainsi que l’option de l’afficher sur le côté gauche dans le widget « maintenant en lecture » !  

## 💬 Retour d’expérience et contributions  

Si vous rencontrez des problèmes ou avez des suggestions pour améliorer cette extension, n’hésitez pas à ouvrir un ticket dans le [répertoire GitHub](https://github.com/L3-N0X/spicetify-dj-info). Les contributions sont également les bienvenues ! Forkez le dépôt, effectuez vos modifications, puis soumettez une pull request avec vos améliorations.

## ⚖️ Licence

Ce projet est sous licence [MIT License](https://raw.githubusercontent.com/L3-N0X/spicetify-dj-info/main/LICENSE.md). N'hésitez pas à utiliser, modifier et distribuer le code conformément aux termes de cette licence.

---

Profitez d'une expérience d'analyse musicale améliorée avec l'extension Spicetify DJ Info ! Si vous trouvez cette extension utile, pensez à lui donner une ⭐️ sur GitHub. Merci d'utiliser DJ Info !


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-06

---