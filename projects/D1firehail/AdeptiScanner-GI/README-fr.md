# AdeptiScanner-GI  
Scanner d'inventaire basé sur la reconnaissance optique de caractères (OCR) pour Genshin Impact, avec un mode manuel et un mode automatique.  

### _Veuillez lire les instructions ci-dessous avant d'utiliser. Le lien de téléchargement de la dernière version se trouve [ici](https://github.com/D1firehail/AdeptiScanner-GI/releases)_  

AdeptiScanner nécessite certains outils produits par Microsoft pour fonctionner, ils sont couramment utilisés dans les jeux, vous les avez donc probablement déjà.  
 - Si le scanner génère une erreur au démarrage, il se peut que vous ne les ayez pas. [Les liens de téléchargement pour leurs installateurs se trouvent ici](https://docs.microsoft.com/en-us/cpp/windows/latest-supported-vc-redist?view=msvc-170#visual-studio-2015-2017-2019-and-2022). ***Vous avez besoin des versions x86 et x64***  

## Avertissements et notes importantes  
- ***Pour que le mode de scan automatisé de ce programme fonctionne, il doit être exécuté en tant qu’administrateur.***  
- Lors de l'utilisation du mode auto, le programme prendra le contrôle de votre souris. Vous pouvez appuyer sur Échap pendant le scan pour le mettre en pause. Ne déplacez pas et n’utilisez pas votre souris pendant l’auto sauf si le scan est en pause.  
- Selon mon interprétation des [CGU de Genshin](https://genshin.mihoyo.com/en/company/terms), l’utilisation de ce scanner devrait être autorisée car je ne pense pas qu’il confère un avantage compétitif déloyal. À ma connaissance, personne n’a eu de problème pour l’utilisation de ce programme ou de programmes similaires jusqu’à présent, mais si vous avez des doutes, je vous suggère d’éviter le mode auto.  
- AdeptiScanner s’appuie sur des valeurs de couleur spécifiques pour identifier le contenu de l’image  
    - Tout ce qui modifie les couleurs dans le jeu peut fausser les résultats. Des exemples de programmes/fonctionnalités pouvant interférer sont Reshade, Windows Night Light, F.lux, les filtres Nvidia et les outils de compensation pour daltoniens.  
    - Le renforcement de l’image affecte aussi les couleurs de cette manière. L’exemple le plus courant est le « Radeon Image Sharpening » dans le logiciel AMD Radeon.  

## Mise à jour pour une nouvelle version  
- Il existe un vérificateur de mise à jour optionnel dans l’application, qui peut vous notifier des mises à jour des données du jeu et du scanner  
  - Les mises à jour des données du jeu peuvent être effectuées d’un simple clic  
  - Les mises à jour du scanner ouvriront la page de téléchargement de la nouvelle version et exporteront vos paramètres pour que la nouvelle version puisse les importer lors de son prochain lancement  
- Vous pouvez mettre à jour manuellement les données du jeu en remplaçant le fichier `ArtifactInfo.json` dans `ScannerFiles` par une version mise à jour. La dernière version se trouve [ici](https://raw.githubusercontent.com/D1firehail/AdeptiScanner-GI/master/AdeptiScanner%20GI/ScannerFiles/ArtifactInfo.json)  

## Mode Arme  
- Le mode arme s’utilise de la même manière que le mode régulier (Artifact)  
- Il est recommandé de trier votre liste d’armes par niveau, afin d’éviter de manquer des armes de faible rareté qui vous intéressent réellement  
- En utilisant la fonctionnalité Auto en mode arme, le scan s’arrêtera lorsque ***toutes*** les armes d’une page seront identiques à une arme déjà scannée, contrairement au mode artifact où il s’arrête lorsqu’***une seule*** est identique  

## Importation de personnages via enka.network  
1. (optionnel) Scannez vos artefacts et/ou armes  
   - Cela permet à AdeptiScanner d’afficher les personnages que vous possédez mais que vous n’avez pas encore importés  
2. Assurez-vous que votre vitrine de profil est configurée pour afficher les détails des personnages  
   - Si vous avez modifié ce paramètre, quittez vers l’écran titre puis revenez pour rafraîchir rapidement les données de la vitrine  
3. Ouvrez l’onglet `Characters` dans AdeptiScanner, saisissez votre UID et cliquez sur Fetch  
4. Changez vos personnages exposés et répétez à partir de l’étape 3.  
   - Si vous avez suivi l’étape 1, la zone de texte sous le bouton Fetch devrait afficher une liste des personnages que vous n’avez pas encore importés mais que vous possédez selon les résultats de vos scans d’artefacts/armes  
   - Vous pouvez quitter vers l’écran titre puis revenir pour rafraîchir rapidement les données de la vitrine  

## Comment préparer le scan  
1. Il est recommandé de mettre le jeu en mode fenêtré avec une résolution de 1600x900, mais ce n’est pas obligatoire  

   - D'autres rapports d'aspect et résolutions sont susceptibles de fonctionner, mais n'ont pas été testés avec le même degré
   - Le mode plein écran fonctionne, mais nécessite que l'option `Avancé` -> `Gérer les fonctionnalités du processus` soit activée (**Activé par défaut**)
2. Ouvrez la section artefacts dans votre sac à dos principal et sélectionnez un artefact 5 étoiles avec une description d'objet complète
3. Appuyez sur "Capturer"
    - Assurez-vous que l'aperçu correspond au bon exemple, sinon, essayez de déplacer un peu votre caméra dans le jeu pour changer l'arrière-plan et répétez à partir de l'étape 2 ![quelque chose comme ça](https://github.com/D1firehail/AdeptiScanner-GI/blob/master/Capture-example.png?raw=true)
5. Entrez votre nom en jeu / nom de voyageur dans la zone de texte `Nom du voyageur`.
    - Ne pas entrer ce nom entraînera une détection incorrecte des artefacts scannés équipés sur votre Voyageur, soit comme équipés sur un mauvais personnage, soit comme non équipés du tout
    - Il existe un paramètre équivalent pour le nom du Vagabond

Vous êtes maintenant prêt pour le scan manuel ou automatique des artefacts

### Scan manuel
1. Suivez les instructions sous `Comment se préparer au scan`. Ne déplacez pas la fenêtre du jeu et ne couvrez pas la zone capturée pendant le scan
2. Sélectionnez l'artefact que vous souhaitez scanner et appuyez sur le bouton `Lire les statistiques`
    - Le scanner est principalement testé pour les artefacts 4 et 5 étoiles. Bien qu'il ait les informations sur tous les niveaux d'artefacts, il peut être incapable de lire certains de niveau inférieur
3. Répétez l'étape 2 pour chaque artefact que vous souhaitez scanner manuellement

### Scan automatisé
- En mode automatique, le programme prendra le contrôle de votre souris. Vous pouvez appuyer sur Échap pendant le scan pour le mettre en pause.
- Ne déplacez pas et n'utilisez pas votre souris pendant l'auto sauf si c'est en pause.
- Le scan automatisé ne fonctionnera correctement que si ce programme est exécuté en tant qu'administrateur
- Le scan automatisé fera défiler l'ensemble de votre inventaire d'artefacts, un filtrage est appliqué à l'exportation
1. Suivez les instructions sous `Comment se préparer au scan`
2. Faites défiler votre liste d'artefacts de manière à ce que les **étoiles** de la **rangée du haut** et l'**étiquette blanche/beige** de la **rangée du bas** soient **toutes deux entièrement visibles** avec une marge. ![quelque chose comme ça](https://github.com/D1firehail/AdeptiScanner-GI/blob/master/scroll-example.png?raw=true)
3. Appuyez sur le bouton `Démarrer Auto`
    - Pendant le scan, vous pouvez appuyer sur la touche Échap de votre clavier pour le mettre en pause
    - `Reprendre` fera reprendre le scan par le scanner
    - `Arrêter après traitement` fera arrêter le scanner de défiler dans les nouveaux artefacts immédiatement, mais finira de traiter tous les artefacts scannés
    - `Arrêter maintenant` fera quitter immédiatement le scan automatisé, sans enregistrer aucun artefact scanné
4. Le scanner s'arrêtera automatiquement une fois qu'il pense avoir fini de défiler la liste d'artefacts ou trouver un artefact avec des statistiques identiques à un précédent.
   - Si cela arrive trop tôt (par exemple, à cause de deux artefacts identiques), vous pouvez faire défiler manuellement vers l'écran suivant et appuyer sur `Démarrer Auto`. Les résultats de la session précédente ne sont pas supprimés automatiquement.

### Exportation des résultats
1. Scannez des artefacts en mode manuel, automatique ou une combinaison des deux
2. Configurez la section `Filtres d'export` selon vos souhaits
    - Vous pouvez utiliser un fichier modèle dont tout sauf les détails des artefacts sera copié. Pour cela, placez un json au format GOOD dans le dossier `ScannerFiles` et renommez-le en `ExportTemplate.json`    
    - Si vous le souhaitez, vous pouvez combiner les artefacts de plusieurs jsons au format GOOD avec le bouton `Avancé` -> `Charger fichier d'artefact`. Il n'y a pas de détection de doublons dans ce cas
3. Appuyez sur le bouton `Exporter les résultats`, vos résultats seront placés dans un fichier horodaté dans le dossier `ScannerFiles`
    - Vous pouvez modifier vos filtres d'export et appuyer plusieurs fois sur le bouton d'export si vous le souhaitez, chaque export apparaîtra comme un fichier distinct

## Informations spéciales lorsque vous ne lancez pas en tant qu’administrateur ou sans les fonctionnalités de gestion de processus  
<details>  
  <summary> Cliquez pour développer</summary>  
  
### Dans ces conditions, les exigences supplémentaires suivantes s’appliquent  
- Le mode plein écran de Genshin n’est pas pris en charge  
- Le processus de capture ne peut pas automatiquement basculer le focus vers le jeu, ainsi la fenêtre du jeu ne doit pas être couverte pendant le processus de capture ou toute autre fonction qui analyse la fenêtre du jeu  
- Pour capturer le jeu, il doit être sur votre écran principal, couvrir le milieu de cet écran, et avoir un en-tête de fenêtre blanc visible (cela peut être « simulé » en utilisant le bloc-notes ou un programme similaire)  
- Exemple d’image respectant ces conditions sur un écran 1080p  
![Exemple de position de fenêtre pour écran 1080p](https://github.com/D1firehail/AdeptiScanner-GI/blob/master/1080p-example.png?raw=true)  
  
</details>  
  
## Comment contacter  
- Créez un problème (issue) ou une demande de fusion (pull request) sur ce dépôt  
- Je n’ai pas créé de Discord, car je ne sais pas encore quel intérêt cela suscitera. Si cela devient nécessaire à l’avenir, j’en créerai un  
- Je suis dans le Discord communautaire [Genshin Dev Discord](https://discord.gg/CnmeBYSHaC), même nom d’utilisateur qu’ici  
- Je suis aussi dans le [Genshin Optimizer Discord](https://discord.com/invite/CXUbQXyfUs). N’hésitez pas à me mentionner pour des petits problèmes, mais pour des sujets plus longs, il vaut mieux utiliser le Discord Genshin Dev ou m’envoyer un message privé  
  
## Remerciements  
- L’importation des personnages repose sur l’API [Enka.Network](https://enka.network/)  
- Certaines fonctions utilisées sont fortement basées sur le code de [WFInfo](https://github.com/WFCD/WFinfo), un programme compagnon OCR pour Warframe  
- Le modèle tesseract utilisé a été entraîné et fourni par le créateur de [ce programme similaire](https://github.com/Andrewthe13th/Genshin_Scanner)  
- Le but principal de ce scanner est de faciliter l’importation de vos artefacts dans [Genshin Optimizer](https://frzyc.github.io/genshin-optimizer/), mais il devrait être compatible avec tout autre programme utilisant le format GOOD


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-04

---