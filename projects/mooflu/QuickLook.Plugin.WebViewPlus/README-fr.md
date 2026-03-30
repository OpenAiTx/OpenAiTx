![image](https://user-images.githubusercontent.com/693717/210183526-1708c821-172e-4c71-9b02-2a9885654505.svg)

# QuickLook.Plugin.WebViewPlus

Plugin [QuickLook](https://github.com/QL-Win/QuickLook) pour prévisualiser divers types de fichiers avec [WebViewPlus](https://github.com/mooflu/WebViewPlus).

## Essayez

1. Rendez-vous sur la [page des Releases](https://github.com/mooflu/QuickLook.Plugin.WebViewPlus/releases) et téléchargez la dernière version.
2. Assurez-vous que QuickLook fonctionne en arrière-plan. Allez dans votre dossier Téléchargements, et appuyez sur <key>Barre d’espace</key> sur le fichier `.qlplugin` téléchargé.
3. Cliquez sur le bouton « Installer » dans la fenêtre popup.
4. Redémarrez QuickLook.
5. Pour configurer les types de fichiers à prévisualiser via WebViewPlus, ouvrez un fichier html et cliquez sur le bouton engrenage en bas à droite.

## Développement

 1. Clonez ce projet. N’oubliez pas de mettre à jour les sous-modules.
 2. Copiez l’application web WebViewPlus dans `webApp` ou définissez la config du plugin `WebAppUrl` - voir `WebpagePanel.cs`
 3. Définissez le `Chemin de sortie` dans la configuration `Debug` vers un chemin comme `..\QuickLook.upstream\Build\Debug\QuickLook.Plugin\QuickLook.Plugin.WebViewPlus\`
 4. Compilez le projet du plugin avec le profil `Debug`
 5. Compilez et lancez QuickLook upstream avec le profil `Debug`

 # Release
 1. Compilez le projet avec le profil `Release`.
 2. Exécutez `Scripts\pack-zip.ps1`.
 3. Vous devriez trouver un fichier nommé `QuickLook.Plugin.WebViewPlus.qlplugin` dans le répertoire du projet.

## Licence

Licence MIT.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-30

---