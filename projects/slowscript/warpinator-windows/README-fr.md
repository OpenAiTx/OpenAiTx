# Warpinator pour Windows (non officiel)

Ceci est une réimplémentation non officielle de l'outil de partage de fichiers de Linux Mint [Warpinator](https://github.com/linuxmint/warpinator) pour Windows 7 et versions ultérieures.

Transférez des fichiers entre appareils Linux, Windows et Android

## ⚠️ Avertissement : Site web faux/malveillant

`http://warpinator.com` est un faux site web, potentiellement malveillant !

Ne **téléchargez pas** et ne lancez aucun logiciel provenant de ce site !

Nous ne savons pas qui le maintient. Voir [avis de l'équipe Linux Mint](https://github.com/linuxmint/warpinator?tab=readme-ov-file#%EF%B8%8F-warning-fakemalicious-website).

## Téléchargement
Maintenant disponible sur la page [Releases](https://github.com/slowscript/warpinator-windows/releases)

Peut également être installé via winget :  
`winget install slowscript.Warpinator`

## Compilation
Nécessite .NET SDK 4.7.2

Compiler avec Visual Studio

### Capture d'écran
![screenshot](https://raw.githubusercontent.com/slowscript/warpinator-windows/master/screenshot.png)

## Traduction
Vous aurez besoin d'une version récente de Visual Studio  
1) Créez un nouveau fichier Ressource dans le dossier Resources nommé Strings.xx.resx où xx est le code de la langue vers laquelle vous traduisez  
2) Copiez toute la table depuis Strings.resx et traduisez les valeurs. Les commentaires sont uniquement pour le contexte  
3) Ouvrez Controls\TransferPanel, Form1, SettingsForm et TransferFrom en mode designer et répétez 4-6 pour chacun d'eux  
4) Sélectionnez l'élément racine (la fenêtre entière) et dans Propriétés, changez la Langue vers votre langue  
5) Sélectionnez les contrôles avec du texte (boutons, étiquettes, menus) et traduisez leur propriété "Text". Vous n'avez pas besoin de traduire les espaces réservés évidents qui seront remplacés à l'exécution. Cela peut être vérifié simplement en lançant l'application (flèche verte dans la barre d'outils). De plus, deux boutons sur TransferPanel sont cachés sous les deux autres.  
6) Vous pouvez aussi déplacer et redimensionner les contrôles pour adapter les nouvelles chaînes, cela n'affectera que la langue sélectionnée actuellement


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-20

---