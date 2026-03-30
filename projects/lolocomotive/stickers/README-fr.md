# Stickers

Créateur simple de stickers Android pour WhatsApp sans publicités.

[![](https://upload.wikimedia.org/wikipedia/commons/7/78/Google_Play_Store_badge_EN.svg)](https://play.google.com/store/apps/details?id=de.loicezt.stickers)

Ou téléchargez depuis la dernière [version GitHub](https://github.com/lolocomotive/stickers/releases)

## Fonctionnalités

- Mode rapide : partager une image vers l'application l'ajoute automatiquement à WhatsApp
- Éditeur
    - Recadrez votre sticker à volonté
    - Ajoutez des textes avec différentes tailles, polices et couleurs
    - Dessinez avec différentes couleurs et tailles de pinceau, avec support annuler/refaire
    - Chaque élément a sa propre couche sous le capot, vous pouvez donc dessiner au-dessus et en dessous des textes
- Import/Export
    - Exportez en `.zip` pour partager ou sauvegarder vos packs
    - Importez depuis plusieurs formats (format `.zip` propriétaire, `.wastickers`, `.stickify`, il ne devrait pas être trop difficile d'en ajouter d'autres car la plupart sont juste un fichier ZIP avec des images et un manifeste simple)
- Créez, éditez et supprimez plusieurs packs et leurs métadonnées (auteur, titre, icône du plateau et plus)

## Captures d’écran

| Accueil                           | Vue du pack                      | Éditeur                              |
|----------------------------------|---------------------------------|------------------------------------|
| ![home.png](https://raw.githubusercontent.com/lolocomotive/stickers/main/screenshots/home.png) | ![pack.png](https://raw.githubusercontent.com/lolocomotive/stickers/main/screenshots/pack.png) | ![editor.png](https://raw.githubusercontent.com/lolocomotive/stickers/main/screenshots/editor.png) |

## Compilation

`flutter run` devrait très bien fonctionner, cependant si vous souhaitez compiler la version release de l'application,  
vous devrez soit :

<details>
<summary>Utiliser votre propre clé de signature</summary>

Dans `android/`, créez `key.properties` avec


```properties
storeFile=path/to/keystore.jks
keyAlias=your key alias
storePassword=your store password
keyPassword=your key password
```

Plus de détails : https://docs.flutter.dev/deployment/android#sign-the-app

</details>

ou

<details>
<summary>Utiliser la configuration de signature de débogage</summary>

Dans `android/app/build.gradle` vers la ligne 29

```
buildTypes {
  release {
    signingConfig signingConfigs.release
  }
}
```

remplacez `signingConfigs.release` par `signingConfigs.debug` et supprimez

```
def keystoreProperties = new Properties()
def keystorePropertiesFile = rootProject.file("key.properties")
if (keystorePropertiesFile.exists()) {
    keystorePropertiesFile.withReader('UTF-8') { reader ->
        keystoreProperties.load(reader)
    }
}
```

and

```
signingConfigs {
    create("release") {
        keyAlias = keystoreProperties["keyAlias"]
        keyPassword = keystoreProperties["keyPassword"]
        storeFile = new File(keystoreProperties["storeFile"])
        storePassword = keystoreProperties["storePassword"]
    }
}
```

Et cela *devrait* fonctionner, à utiliser uniquement pour les tests.
</details>

Et ensuite, vous avez juste besoin de

```
flutter build apk
```

## Contribution

Toutes les contributions (pull requests, demandes de fonctionnalités et rapports de bugs) sont les bienvenues !
Sachez que j'ai réglé ma largeur de ligne à 120 au lieu de 80, donc faites attention avant de reformater des fichiers entiers.
Si vous utilisez vscode, mettez ce qui suit dans `.vscode/settings.json` .

```json
{
  "dart.lineLength": 120,
  "[dart]": {
    "editor.rulers": [
      120
    ]
  }
}
```

De plus, le code n'est pas encore très bien documenté, donc désolé d'avance à toute personne essayant de le lire.

## À FAIRE

Quelques fonctionnalités sur lesquelles je prévois de travailler à l'avenir

- [ ] Sélectionner plusieurs packs à la fois sur l'écran d'accueil
- [ ] Ajouter une option pour ajouter un fond aux textes
- [ ] Couches d'images sur les autocollants
- [ ] Commencer avec un autocollant existant
- [ ] Créer des autocollants animés à partir de gifs
- [ ] Rogner et faire pivoter les vidéos

## Support iOS

Je ne possède aucun appareil Apple, donc je ne peux pas compiler pour iOS ni tester l'application iOS. C'est une application flutter
donc elle devrait plus ou moins fonctionner.
Si vous souhaitez ajouter le support iOS, vous êtes les bienvenus ! Voici quelques points à surveiller :

- `image_editor` devrait être modifié pour supporter WEBP sur iOS (j'ai seulement ajouté le support de WEBP sur
  Android)
- Le paquet `whatsapp_stickers_plus` pourrait ne pas fonctionner (il ne fonctionnait pas sur Android).
- De nombreux widgets devraient être remplacés par leur équivalent `.adaptive` si vous voulez que cela ressemble
  à une application iOS


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-30

---