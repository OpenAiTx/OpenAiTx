# Navigation BottomSheet Material3

Cette bibliothèque fournit une solution de navigation pour les projets Compose utilisant les BottomSheets Material3. Elle vous permet de définir vos BottomSheets comme des routes de navigation, éliminant ainsi le besoin des bibliothèques `androidx.compose.material.navigation` et ` androidx.compose.material:material` !
Cela simplifie les dépendances de votre application et garantit une expérience Material3 cohérente.
Cette bibliothèque exploite également la nouvelle fonctionnalité de `androidx.navigation:navigation-compose:2.8.0-beta0X` pour vous permettre de définir des routes avec des classes sérialisées.

[![Maven Central](https://img.shields.io/maven-central/v/io.github.stefanoq21/material3-navigation)](https://central.sonatype.com/artifact/io.github.stefanoq21/material3-navigation)

![Badge statique](https://img.shields.io/badge/minSdk-21-blue?link=https%3A%2F%2Fgithub.com%2Fstefanoq21%2FBottomSheetNavigator3%2Fblob%2Fmain%2Fmaterial3-navigation%2Fbuild.gradle.kts%23L15)

## Implémentation

Vous pouvez suivre l’approche d’implémentation utilisée dans le module [app](https://github.com/stefanoq21/BottomSheetNavigator3/tree/main/app "app"). Sinon, vous trouverez une explication détaillée ci-dessous.

### Dépendances
La bibliothèque est maintenant disponible sur MavenCentral !!! 
Ajoutez les dépendances à votre `libs.versions.toml`
```
[versions]
...
material3Navigation = "X.X.X" current release version

[libraries]
...
material3-navigation = { group = "io.github.stefanoq21", name = "material3-navigation", version.ref = "material3Navigation" }

```
Dans votre `build.gradle.kts`, implémentez vos dépendances :
```
...
dependencies {
...
 implementation(libs.material3.navigation)
```
### Utilisation
Définissez votre **BottomSheetNavigator**
```
...
   val bottomSheetNavigator =
                    rememberBottomSheetNavigator(skipPartiallyExpanded = true/false)
                val navController = rememberNavController(bottomSheetNavigator)
```
Ajoutez le **ModalBottomSheetLayout** au-dessus du composant **NavHost** et passez le **bottomSheetNavigator** en paramètre :
```
ModalBottomSheetLayout(
                        modifier = Modifier
                            .fillMaxSize(),
                        bottomSheetNavigator = bottomSheetNavigator
                    ) {
                        NavHost(
                            navController = navController,
                            startDestination = Screen.Home
                        ) {
...
```
Définissez vos routes en tant que chaînes de caractères ou classes de données (selon la version de la navigation compose que vous utilisez) :
```
...
   bottomSheet<Screen.BottomSheetFullScreen> {
                                BSFullScreenLayout()
                            }
  bottomSheet("BottomSheetFullScreen") {
                                BSFullScreenLayout()
                            }
...
```
Tout est prêt ! Il vous suffit de vous rendre à votre nouvelle destination comme d'habitude :
```
...
Button(onClick = { navController.navigate(Screen.BottomSheetFullScreen) }) {
                                        Text(text = "BottomSheetFullScreen")
                                    }
...
```

### Navigation arrière depuis un Bottom Sheet

Pour implémenter un bouton de retour ou de fermeture dans votre bottom sheet, je suggère d’utiliser `onBackPressedDispatcher.onBackPressed()`. En effet, si vous utilisez `navController.popBackStack()`, l’animation ne s’affichera pas. L’animation a été désactivée, dans ce cas, pour éviter des problèmes lors de la navigation qui démarre depuis les bottom sheets.

### Personnalisation

La bibliothèque prend actuellement en charge les mêmes options de personnalisation que le `androidx.compose.material3.ModalBottomSheet` standard. Vous pouvez personnaliser l’apparence de tous les bottom sheets utilisés dans votre graphe de navigation en passant les paramètres au `ModalBottomSheetLayout`.

## Aperçu
![](https://github.com/stefanoq21/BottomSheetNavigator3/assets/22545898/c971f6cf-bb04-41c1-b3ea-7b72757e09af)


## Contribution

Nous accueillons avec plaisir les contributions à cette bibliothèque ! Si vous avez des rapports de bugs, des demandes de fonctionnalités ou des améliorations de code, n’hésitez pas à créer une pull request. Je vous remercie de votre aide pour rendre cette bibliothèque encore meilleure.

## Licence

   Copyright 2024 stefanoq21

   Sous licence Apache, Version 2.0 (la « Licence ») ;
   vous ne pouvez utiliser ce fichier que conformément à la Licence.
   Vous pouvez obtenir une copie de la Licence à

       http://www.apache.org/licenses/LICENSE-2.0

   Sauf si la loi en vigueur l’exige ou un accord écrit le stipule,
   le logiciel distribué sous la Licence est distribué « EN L’ÉTAT »,
   SANS GARANTIES NI CONDITIONS D’AUCUNE SORTE, expresses ou implicites.
   Consultez la Licence pour connaître les autorisations spécifiques
   et les limitations régissant la Licence.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-13

---