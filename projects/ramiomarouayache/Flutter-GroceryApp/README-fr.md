# GroceryApp Starter

Modèle d’application d’épicerie simplifié pour une expérience d’achat sans effort. 🛒✨

N’hésitez pas à mettre une étoile ⭐ sur le dépôt si vous le trouvez utile.

## Design

**Cliquez sur l’image ci-dessous pour voir le design Figma :**

[![Aperçu du design](https://github.com/ramiomarouayache/Flutter-GroceryApp/blob/main/screenshots/Cover.jpg)](https://www.figma.com/embed?embed_host=oembed&amp;url=https://www.figma.com/file/eyeYwe0hoEch31j6d3EXyE/GroceryApp-Starter-(Community)?type=design&amp;node-id=3-2&amp;mode=design&amp;t=LwLW2onM0GKLuFdU-0)



## ✨Pré-requis

1. **Environnement de développement :**
   - N’importe quel IDE avec le SDK Flutter installé (ex. : VSCode, Android Studio, IntelliJ...etc)

2. **Base de connaissances :**
   - Connaissance basique à intermédiaire de Dart et Flutter
   - Compréhension de l’architecture MVVM
   - Familiarité avec la gestion des API
   - Notions de gestion d’état avec GetX
  
## Test
* Vous pouvez télécharger la version pré-release pour appareils Android depuis ici [releases](https://github.com/ramiomarouayache/Flutter-GroceryApp/releases/tag/v0.3.1).
<video src="https://github.com/ramiomarouayache/Flutter-GroceryApp/assets/98425058/5ae355c9-39e0-478e-9b3e-870953b566ca"></video>

  
## Installation
* Commencez par configurer votre endpoint produit, vos identifiants et paramètres dans `lib\constants\AppConstants`.
* **Ou bien**, utilisez l’endpoint gratuit fourni ci-dessous (à la date de ce partage) pour des tests réussis.
```dart
class AppConstants {
  // Remplacez "YOUR_API_PREFIX" par l’URL de base de votre propre API.
  static const String BASE_URL = "YOUR_API_PREFIX";
  static const String API_KEY = "YOUR_API_KEY"; //SI_EXISTE

  // Pour les tests, utilisez l’URL de base de l’API gratuite de la version publiée
  static const String BASE_URL = "https://world.openfoodfacts.org/api/v2";

  // Nom complet du propriétaire du projet.
  static const String projectOwnerName = "FULL_NAME";
}
```

## Remarque
* Pour utiliser vos propres endpoints API, personnalisez les couches logiques selon les principes de l’architecture MVVM et la documentation de votre API.
* Certaines images de la version pré-release ont été supprimées en raison de restrictions de droits d’auteur.

## Contribution

Merci de forker ce dépôt et de contribuer via
[pull requests](https://github.com/ramiomarouayache/Flutter-GroceryApp/pulls).

Toute contribution, grande ou petite, qu’il s’agisse de fonctionnalités majeures ou de corrections de bugs, est la bienvenue et appréciée,
mais sera soigneusement examinée.


## Pour bien démarrer
Ce projet est un point de départ pour une application Flutter.

Quelques ressources pour débuter si c’est votre premier projet Flutter :

- [Lab : Écrivez votre première application Flutter](https://flutter.io/docs/get-started/codelab)
- [Cookbook : Exemples pratiques de Flutter](https://flutter.io/docs/cookbook)

## Compteur de visiteurs

<img align="left" src = "https://profile-counter.glitch.me/GroceryApp/count.svg" alt ="Chargement">

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---