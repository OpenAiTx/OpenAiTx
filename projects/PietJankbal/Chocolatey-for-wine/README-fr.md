# Chocolatey-for-wine

Installateur automatique du gestionnaire de paquets Chocolatey dans wine, pratique pour installer rapidement des programmes dans wine (et par la suite trouver des bugs dans wine ;) )  
Pour certains bugs, des contournements sont ajoutés comme pour Visual Studio Community 2022 et nodejs, voir plus loin.  

Comme je m'ennuyais pendant le confinement, j'ai écrit un winetricks(.ps1) personnalisé avec des verbes que je trouve pratiques. Faites simplement 'winetricks' pour les voir.  
Pour certains verbes, un redémarrage complet de wine est nécessaire (à cause des récents changements de wine). Vous verrez une boîte de message et la session sera terminée. Il suffit de relancer powershell et de réessayer le verbe. Une fois cela fait une fois, ce ne sera plus nécessaire pour aucun verbe.  

Exemple :  

'winetricks vs22_interactiveinstaller'  ( --> la session sera terminée)  

faire 'wine powershell'  

faire 'winetricks vs22_interactiveinstaller'  


(PS via 'winetricks vs22_interactive_installer' vous pouvez sélectionner ce que vous voulez installer via l'installateur Visual Studio 2022 ; 'winetricks vs22_interactive_installer' m'a maintenant permis en dix minutes d'accéder au programme principal (sélectionné Développement de bureau avec C++)).

Installation :  
- Télécharger et dézipper le fichier zip de la release et faire 'wine ChoCinstaller_0.5c.751.exe' (prend environ une minute pour se terminer)

Optionnel :  
- Lancer l'installateur comme 'wine ChoCinstaller_0.5a.751.exe /s', alors les fichiers d'installation (comme Powershell*.msi et dotnet48) sont sauvegardés dans  
  MesDocuments et ils n'ont pas besoin d'être retéléchargés si vous créez un nouveau préfixe)  
Optionnel :  
- Lancer l'installateur comme 'wine ChoCinstaller_0.5a.751.exe /q' pour empêcher le lancement automatique de la fenêtre powershell (installation seule).  

Optionnel :  
- Vérifiez si tout s'est bien passé : "choco install chromium" et  "start chrome.exe (--no-sandbox plus nécessaire depuis wine-8.4)"  

![Screenshot from 2022-08-26 12-31-18](https://user-images.githubusercontent.com/26839562/186885380-d5a617c4-9cf4-4831-a475-2bd85a3b5784.png)  
À propos de PowerShell :  

Astuce : Chocolatey installe généralement la dernière version d’un programme, ce qui peut révéler de nouveaux bugs dans wine. Vous aurez peut-être plus de chance avec une version plus ancienne du logiciel.  
Exemple :  

choco search --exact microsoft-edge --all (--> liste toutes les versions)  

choco install microsoft-edge --version --version='135.0.3179.98'
Informations générales :

- 'wine powershell.exe' lance la console PowerShell-Core.

 
À propos de ConEmu :

La console ConEmu souffre de quelques bugs liés à wine :
  - Ctrl^C pour quitter un programme qui ne revient pas à la console ne fonctionne pas. Utilisez plutôt Shift^Ctrl^C.
  - La sélection de texte dans la fenêtre ConEmu (pour copier/coller) ne met pas en surbrillance la sélection. Un hack très triste est inclus contre les versions récentes de wine qui contourne ce problème, donc la mise en surbrillance devrait maintenant fonctionner.
   
À propos de winetricks(.ps1) :

- Si vous ne l'appelez pas ('winetricks' dans la console powershell), rien n'est téléchargé, donc aucun surcoût.
- Beaucoup de verbes (comme powershell 5.1) nécessitent quelques fichiers essentiels pour extraire des éléments des paquets msu. Installer ces fichiers essentiels requiert d'abord des téléchargements volumineux, et prend beaucoup de temps lors de la première utilisation. Mais après mise en cache, cela va vite. Par exemple, si vous voulez essayer 'winetricks ps51' en premier, cela prendra environ 15 minutes. Certains autres verbes peuvent prendre 5 minutes lors de la première utilisation. Mais après avoir appelé un verbe une fois, cette nuisance disparaît.
- Les fichiers sont mis en cache dans le répertoire MesDocuments. Si vous appelez tous les verbes, cela prendra environ 800 Mo là-bas.
- Espoir d'un meilleur support 64 bits pour divers verbes.
- Possibilité d'extraire un fichier et (essayer de) l'installer à partir d'un fichier msu. Faites 'winetricks install_dll_from_msu' pour voir comment.
- Un Powershell 5.1 rudimentaire.
- Installation expérimentale de dotnet481, et dotnet35 (peut être nécessaire pour des applications non satisfaites par l'installation actuelle de dotnet48).
- Auto-complétion par tabulation. Note : lors de l'utilisation de plusieurs verbes en ligne de commande, ils doivent être séparés par une virgule
  désormais (c'est ainsi que powershell gère plusieurs arguments).
  Donc 'winetricks riched20 gdiplus' ne fonctionne plus, utilisez 'winetricks riched20,gdiplus' à la place.
- Certains programmes échouent à s'installer/s'exécuter lorsqu'on les essaie via Chocolatey à cause de bugs de wine. J'ai ajouté quelques contournements dans winetricks pour eux, voir ci-dessous.
- Verbes spéciaux (winetricks vs19, vs22 et vs22_interactive_installer) pour installer Visual Studio Community 2019 et 2022 fonctionnels (voir capture d'écran, >10 min pour installer et nécessite environ 10 Go !, après installation, lancez devenv.exe depuis le répertoire c:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\IDE/)
  ![capture d'écran](https://github.com/PietJankbal/Chocolatey-for-wine/assets/26839562/d576a619-c752-4eb1-81c2-6f6b66b50ff6)
- Verbe spécial pour accéder à diverses commandes unix comme grep, sed, file, less, curl etc. etc. (winetricks git.portable, avertissement : certaines commandes ne fonctionnent pas encore à cause de bugs wine)
- Inclus également quelques scripts powershell adaptés de snippets trouvés sur internet :
    - Comment intégrer un exe dans un script powershell via Invoke-ReflectivePEInjection (l'exe n'apparaît pas dans tasklist).
    - Comment créer des boîtes de dialogue élégantes
    - Convertir un script powershell (ps1) en exe.
    - Et quelques autres
 
     
À propos des programmes système :

Une fonctionnalité est ajoutée pour remplacer les programmes système simples comme par exemple setx.exe par une fonction dans
c:\\Program Files\Powershell\7\profile.ps1. Ou ajouter des programmes système manquants comme getmac.exe.
Si des programmes échouent à cause de programmes système immatures ou manquants, on pourrait écrire un 

fonction pour retourner ce que le programme attend.  
Comme dans profile.ps1, j'ai ajouté (entre autres) un wmic.exe qui supporte un peu plus d'options,  
et un setx.exe basique.  
Ou vous pouvez simplement manipuler les arguments passés au programme système. Voir profile.ps1 et choc_install.ps1.  
Aucune garantie que cela fonctionne aussi pour des programmes plus complexes...  
  
Notes :  
  
  - NE PAS utiliser sur un wineprefix existant, uniquement sur un nouveau prefix fraîchement créé ! L'installateur installe bêtement dotnet48 lui-même et perturbe les clés du registre.  
    Si vous avez déjà une version de dotnet installée avec winetricks.sh classique, cela échouera probablement, et même si cela réussit, vous risquez d'avoir un prefix cassé.  
    Si vous devez installer des choses avec winetricks.sh classique pour des programmes, N'UTILISEZ PAS les verbes dotnet*.  
    Au fait, les verbes 'Arial' et 'd3dcompiler_47' sont déjà installés par défaut.  
  - WINEARCH=win32 n'est _pas_ supporté !  
  - La mise à jour depuis une version précédente n'est pour l'instant pas (encore) supportée, peut-être plus tard  
  
Compiler :  
  - Si vous voulez compiler vous-même au lieu de télécharger les binaires : voir les instructions de compilation dans mainv1.c et installer.c  
  - Puis copiez choc_install.ps1 dans le même répertoire  
  - Ensuite faites 'wine ChoCinstaller_0.5a.735.exe'  
  


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-03

---