# Partition Kit

![partition kit logo](https://github.com/kieranb662/PartitionKit/blob/master/partition-kit-logo.png)

Récemment présenté dans [Top 10 des bibliothèques Android et iOS tendances en octobre](https://medium.com/better-programming/top-10-trending-android-and-ios-libraries-in-october-e7dd18f8b75b) et dans [5 bibliothèques iOS pour améliorer votre application](https://medium.com/better-programming/5-ios-libraries-to-enhance-your-app-17ae7ed350db) !

![grid](/nestedGrid.gif)

Qu'est-ce que PartitionKit ?  
- C’est la solution au besoin de contenus d’interface utilisateur composables et de taille dynamique dans SwiftUI.  
- C’est aussi le premier logiciel que j’ai jamais transformé en bibliothèque, alors soyez indulgents (tant avec les cas d’utilisation qu’avec mon cœur).

Ce que PartitionKit **n’est pas** ?  
- PartitionKit n’est pas un moyen de travailler avec une forme de données stockées, ce n’est pas pour partitionner des disques durs ou tout autre type de support de données formatable.  


## Exigences 

PartitionKit nécessite par défaut que le framework SwiftUI soit opérationnel, ainsi seules ces plateformes sont supportées :

*  macOS 10.15 ou supérieur  
* iOS 13 ou supérieur  
* tvOS 13 ou supérieur  
* watchOS 6 ou supérieur  


## Comment l’ajouter à votre projet

1. Récupérez cette URL depuis le dépôt GitHub  
2. Dans Xcode -> Fichier -> Swift Packages -> Ajouter une dépendance de paquet  
3.  Collez l’URL dans la boîte  
4. Spécifiez le numéro de version minimum (C’est nouveau donc 1.0.0 et plus fonctionneront).

## Tutoriel vidéo de moins de 2 minutes

[![Vidéo tutoriel : Comment utiliser PartitionKit](https://img.youtube.com/vi/RSnEevQcqjk/0.jpg)](https://www.youtube.com/watch?v=RSnEevQcqjk)


## Comment utiliser 


### Partition verticale

1. Décidez de la vue que vous souhaitez avoir en `Haut`, celle que vous souhaitez avoir en `Bas` et éventuellement une `Poignée` à utiliser pour faire glisser les partitions à différentes tailles.
2. Faites cela
``` Swift
VPart(top: {
    MyTopView()
    }, bottom: {
    MyBottomView()
    }) {
    MyHandle()
}
```

### Partition horizontale 

1. Décidez de la vue que vous souhaitez avoir à gauche (`Left`), de celle que vous souhaitez avoir à droite (`Right`) et éventuellement d’une `Poignée` à utiliser pour faire glisser les partitions à différentes tailles.
2. Faites ceci 
``` Swift
HPart(left: {
    MyLeftView()
    }, right: {
    MyRightView()
    }) {
    MyHandle()
}
```

### GridPartition 

1. Décidez quelles Vues iront dans chaque coin `TopLeft`, `TopRight`, `BottomLeft`, `BottomRight` et éventuellement une `Handle` pour que l'utilisateur puisse faire glisser et redimensionner les vues. 
2. Faites cela 
``` Swift
    GridPart(topLeft: {
        MyTopLeftView()
        }, topRight: {
        MyTopRightView()
        }, bottomLeft: {
        MyBottomLeftView()
        }, bottomRight: {
        MyBottomRightView()
        }) {
        MyHandle()
}
```
## Exemples 

Copiez et collez ceci, j'ai ajouté des images nommées pour montrer à quoi les vues devraient ressembler, j'utilise le mode sombre donc les couleurs en mode clair peuvent sembler différentes. 

| HPart                   | VPart                   | GridPart                      | NestGrids                              | Mixed                       |
|-------------------------|-------------------------|-------------------------------|----------------------------------------|-----------------------------|
| ![HPart](/hExample.png) | ![VPart](/vExample.png) | ![GridPart](/gridExample.png) | ![Nested Grid](/nestedGridExample.png) | ![Mixed](/nestedExample.png) |





``` Swift
import SwiftUI
import PartitionKit



struct ContentView: View {
    var vExample: some View {
        VPart(top: {
            RoundedRectangle(cornerRadius: 25).foregroundColor(.purple)
        }) {
            Circle().foregroundColor(.yellow)
        }
    }
    
    var hExample: some View {
        HPart(left: {
            RoundedRectangle(cornerRadius: 10).foregroundColor(.blue)
        }) {
            Circle().foregroundColor(.orange)
        }
    }
    
    var nestedExample: some View {
        VPart(top: {
            hExample
        }) {
            vExample
        }
    }
    
    var gridExample: some View {
        GridPart(topLeft: {
            RoundedRectangle(cornerRadius: 25).foregroundColor(.purple)
        }, topRight: {
            Circle().foregroundColor(.yellow)
        }, bottomLeft: {
            Circle().foregroundColor(.green)
        }) {
            RoundedRectangle(cornerRadius: 25).foregroundColor(.blue)
        }
    }
    
    var nestedGridsExample: some View {
        GridPart(topLeft: {
            gridExample
        }, topRight: {
            gridExample
        }, bottomLeft: {
            gridExample
        }) {
            gridExample
        }
    }
    
    var body: some View {
        nestedExample
        
    }
}


struct ContentView_Previews: PreviewProvider {
    static var previews: some View {
        ContentView()
    }
}
```
## À faire 
* Ajouter des contraintes afin que les partitions ne provoquent pas de valeurs de cadre négatives qui inversent les vues lorsque la poignée est déplacée au-delà du cadre du conteneur 
* Ajouter plus de personnalisation aux mises en page initiales 
* Ajouter une mise en page de collection en grille de style `List` qui peut être initialisée avec une liste d’éléments de données Identifiables. 
* Nettoyage général, certaines choses n’étaient pas censées rester, je les trouverai à un moment donné. 






---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-11

---