# FramePFX

FramePFX est un éditeur vidéo non linéaire open source, écrit en C# utilisant Avalonia pour l’interface utilisateur.

## Refonte
Je travaille actuellement sur une refonte complète (dans la branche remake). Les principales différences sont un nouveau moteur audio, une lecture pilotée par l’audio plutôt que par la vidéo, et un positionnement basé sur TimeSpan plutôt que sur la frame.

# Docs

Voici quelques liens vers les fichiers de documentation, si vous souhaitez en savoir plus sur le frontend et le backend

[Système de plugins + API FramePFX](https://raw.githubusercontent.com/AngryCarrot789/FramePFX/master/docs/Plugins.md)

[Système d’automatisation/animation](https://raw.githubusercontent.com/AngryCarrot789/FramePFX/master/docs/Automation.md)

[Système de commandes, menu contextuel, raccourcis](https://raw.githubusercontent.com/AngryCarrot789/FramePFX/master/docs/Command%20System%20and%20Shortcuts.md)

[Système de rendu](https://raw.githubusercontent.com/AngryCarrot789/FramePFX/master/docs/Rendering.md)

[Vue d’ensemble du système de raccourcis](https://raw.githubusercontent.com/AngryCarrot789/FramePFX/master/docs/Shortcuts.md)

[Vue d’ensemble de l’interface utilisateur](https://raw.githubusercontent.com/AngryCarrot789/FramePFX/master/docs/TheUI.md)

# Aperçus

Voici la dernière version utilisant Avalonia :  
![](https://raw.githubusercontent.com/AngryCarrot789/FramePFX/master/FramePFX-DesktopUI_2024-12-06_17.33.20.png)

Voici un aperçu du processus d’exportation. Le bouton Exporter se trouve dans Fichier>Exporter, vous spécifiez un chemin puis cliquez sur Exporter.  
Pour annuler le rendu, il suffit de cliquer sur Annuler dans la boîte de dialogue derrière la fenêtre de progression d’exportation

Le panneau gris sous « Exporter : FFmpeg » affiche les détails spécifiques à l’encodeur  
![](https://raw.githubusercontent.com/AngryCarrot789/FramePFX/master/FramePFX-DesktopUI_2024-12-07_00.13.06.png)

## Interface graphique personnalisable !
Les thèmes peuvent être personnalisés à votre goût. Ils peuvent être sauvegardés sur disque et modifiés dans l’application.  
Les thèmes intégrés (Sombre et Clair) ne doivent pas être modifiés car les changements ne sont pas sauvegardés. Vous devez créer une copie et modifier cette copie à la place  
![](https://raw.githubusercontent.com/AngryCarrot789/FramePFX/master/FramePFX-DesktopUI_2024-12-29_08.30.49.png)

# Compilation
FramePFX suppose que tout est en 64 bits --- x86/32 bits/AnyCPU ne fonctionneront pas correctement !

Les projets natifs sont automatiquement téléchargés et compilés lors de la première compilation des projets C#,  
cependant, si vous souhaitez que les clips médias et l'export fonctionnent, FFmpeg doit être téléchargé séparément.  
Voici la version spécifique qui fonctionne actuellement (Windows uniquement) :  
https://github.com/BtbN/FFmpeg-Builds/releases/download/autobuild-2024-09-30-15-36/ffmpeg-N-117275-g04182b5549-win64-gpl-shared.zip

## Téléchargement  
Clonez le projet récursivement :

`git clone --recursive https://github.com/AngryCarrot789/FramePFX`

Si vous souhaitez installer FFmpeg pour utiliser les clips vidéo et l'export FFmpeg :  
- Créez un dossier ffmpeg dans la solution : `cd FramePFX && mkdir ffmpeg`  
- Depuis l'archive ffmpeg téléchargée, copiez les 4 dossiers et le fichier LICENCE.txt dans ce nouveau dossier ffmpeg

>Il devrait y avoir 8 fichiers DLL dans `\FramePFX\ffmpeg\bin`, et l'un d'eux doit être avcodec-61.dll. Si ce n'est pas le 61, vous avez la mauvaise version de FFmpeg.  
Vous pouvez supprimer les fichiers EXE si vous le souhaitez, car ils ne sont pas utilisés

## Compilation du projet  
- Ouvrez FramePFX.sln. Vous aurez une erreur indiquant que le projet `portaudio` n'est pas chargé ; ignorez-la, puis compilez la solution en allant dans le menu `Build` et en cliquant sur `Build Solution`

Avec un peu de chance, vous devriez alors pouvoir exécuter et modifier les projets FramePFX sans problème. Ce projet utilise Avalonia 11.2.2 et .NET 8 (C# 12).

>Ne modifiez pas le projet portaudio car il est généré automatiquement par cmake, vos modifications pourraient être écrasées.

### Commandes Windows uniquement

Les projets dans la solution utilisent des commandes Windows comme mkdir et xcopy, qui peuvent ne pas fonctionner sur d'autres plateformes.  
N'hésitez pas à créer une pull request pour une solution plus multiplateforme !

### Problèmes possibles de compilation  
Parfois, la bibliothèque nuget SkiaSharp ne copie pas les fichiers de la bibliothèque skia dans le dossier bin lorsque vous clonez ce dépôt et que vous le compilez. J'ai trouvé 2 solutions :  
- Copier `\packages\SkiaSharp.2.88.7\runtimes\win-x64\native\libSkiaSharp.dll` dans le dossier bin de l'éditeur.  
- Ou, supprimer le dossier `packages` dans le répertoire de la solution, puis faire un clic droit sur la solution dans Visual Studio et cliquer sur "Clean Solution", puis cliquer sur Restaurer les packages Nuget, puis reconstruire tout.  
  Si aucune de ces solutions ne fonctionne, essayez de désinstaller SkiaSharp dans le gestionnaire Nuget puis de le réinstaller. Si cela ne fonctionne toujours pas, alors je ne sais vraiment pas ce qui se passe...

# Plugins !  
FramePFX supporte maintenant les plugins ! L'API des plugins est encore très en développement, mais elle peut charger des plugins.  
Les plugins doivent actuellement être compilés avec les mêmes versions de dépendances que celles utilisées par FramePFX, car nous n'utilisons pas AssemblyLoadContext

Vous pouvez trouver plus d'informations ici : [Système de plugins + API FramePFX](https://raw.githubusercontent.com/AngryCarrot789/FramePFX/master/docs/Plugins.md) 

### Exemples
Le plugin `AnotherTestPlugin` ajoute une page de configuration de test (que l'on trouve dans `Fichier > Ouvrir les paramètres de l'éditeur`), et ajoute également un exportateur de test inutile dans la boîte de dialogue d'exportation.

Ajouter la page est très simple, et peut être fait depuis le gestionnaire `OnApplicationLoaded` du plugin :

```cs
public override async Task OnApplicationLoaded() {
    ApplicationConfigurationManager.Instance.RootEntry.AddEntry(new ConfigurationEntry() {
        DisplayName = "Test Plugin Settings", 
        Id = "config.testplugineditorsettings",
        
        // This page is just a PropertyEditor page. 
        // Completely custom xaml pages are a bit wonky at the moment, 
        // only user controls will work properly due to resource dictionaries
        Page = new TestPluginConfigurationPage()
    });
}
```

Cela donne :
![](https://raw.githubusercontent.com/AngryCarrot789/FramePFX/master/FramePFX-DesktopUI_2024-12-27_03.33.53.png)

# À FAIRE
### Remake Avalonia :
- Implémenter l’interface utilisateur pour la liste des effets pouvant être déposés dans un clip/piste
### Moteur de rendu
- Bien que nous ayons accès à port-audio, je pense que tout le moteur de rendu doit être repensé.
  Auparavant, le rendu audio se faisait en extrayant un nombre exact d’octets d’un clip basé sur le
  taux de rafraîchissement du projet. Cependant, cela provoque beaucoup de craquements car le FPS de lecture n’est pas parfaitement précis.

  Le rendu vidéo doit également être refait, car la zone de visualisation est généralement assez petite, mais nous rendons des images vidéo pleine taille
  de chaque clip puis nous les mettons à l’échelle. Ce n’est pas trop problématique pour, par exemple, les rectangles et formes primitives basiques.
  Cependant, rendre une image vidéo 4K à partir d’un fichier MP4 est une tâche longue et pénible, puis la réduire à 1080p (ou quelle que soit l’échelle média du clip)
  et enfin la réduire à la zone de visualisation (généralement environ 500x300) est extrêmement gaspilleur, donc nous avons besoin soit de méthodes RenderFull et
  RenderPreview, soit d’un nouveau système de rendu. La technique actuelle de rendu asynchrone ne semble pas si mauvaise.
### Moteur d’automatisation
- Ajouter le support pour une interpolation fluide (par exemple une courbe entre 2 images clés). J’ai essayé de faire cela, mais j’ai eu du mal à comprendre les mathématiques nécessaires pour faire l’interpolation, ainsi qu’à gérer le test de collision pour l’interface utilisateur.
### Clips
- AVMediaVideoClip est extrêmement lent pour les vidéos à haute résolution (par exemple 4K prend environ 40 ms pour décoder et afficher à l’écran),
  et seuls quelques codecs vidéo semblent fonctionner. Beaucoup de formats de fichiers courants renvoient une erreur du type « données invalides trouvées lors du décodage ».
  Je ne connais pas beaucoup FFmpeg mais j’espère pouvoir corriger cela d’une manière ou d’une autre à un moment donné.
- Implémenter un fondu entre 2 clips
### Système d’historique
- Il n’y a pas encore de fonctionnalité d’annulation. Je pourrais essayer de l’implémenter une fois que j’aurai réalisé quelques autres fonctionnalités comme l’audio et peut-être l’assemblage final des images accéléré par matériel dans le moteur de rendu.
### Bugs à corriger
- L’importation de certains fichiers vidéo peut provoquer un échec du rendu (une sorte d’erreur « données invalides trouvées lors du décodage »)
### Synchronisation multithread
- Nous devons créer des verrous pour rendre l’accès et la modification de l’état de l’application plus sûrs, surtout maintenant que le système d’activité fonctionne.

  Peut-être un verrou global de l’application pour écrire dans l’état des modèles ? C’est similaire à la façon dont IntelliJ IDEA fonctionne ; un verrou majoritairement en lecture, lecture-écriture.
  Les verrous d’écriture ne sont acquérables que sur le thread principal (nous utilisons le dispatcher pour y accéder), mais n’importe quel thread peut prendre le verrou de lecture. Prendre
  le verrou de lecture nécessite de bloquer jusqu’à ce qu’il n’y ait plus d’opérations d’écriture, et prendre le verrou d’écriture nécessite de bloquer jusqu’à ce que tous les lecteurs aient terminé (et
  il y a aussi un événement déclenché lors de la tentative d’acquisition du verrou d’écriture, pour permettre aux lecteurs d’annuler leurs opérations afin d’éviter de bloquer l’interface utilisateur)

## Contribution
Les contributions sont accueillies à bras ouverts ! Il suffit de créer une pull request, ou un problème puis une PR, comme vous préférez.
Vous pouvez trouver des informations sur la compilation et l’exécution/le débogage de l’application en remontant un peu.
La liste TODO est ci-dessus, mais vous pouvez aussi simplement chercher `// TODO:` dans la base de code.
Vous pouvez trouver des explications détaillées dans le dossier docs, qui explique les parties principales de l’éditeur (comme les
commandes, l’automatisation, etc.). Il reste encore beaucoup à documenter donc tout n’est pas expliqué

La base de code n’est pas parfaite, n’hésitez donc pas à aider à essayer de standardiser les choses !

# Licence
Tous les fichiers sources de FramePFX sont sous la licence publique générale GNU version 3.0 ou ultérieure (GPL v3.0+).
FramePFX utilise des bibliothèques qui ont d’autres licences, comme les licences MIT/LGPL.

Si un fichier source ne comporte pas d’avis de copyright, il est supposé être sous la même
licence que FramePFX

Actuellement, les parties LGPL utilisées sont :
- FFmpeg.AutoGen, qui est sous la licence publique générale GNU allégée version 3.0 (LGPL v3.0)
- FFmpeg



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-28

---