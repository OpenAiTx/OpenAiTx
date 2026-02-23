
<div align="right">
  <details>
    <summary >🌐 Langue</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Chocolatey-for-wine

Gestionnaire de paquets Chocolatey, installateur automatique sous wine, pratique pour installer rapidement des programmes dans wine (et par la suite trouver des bugs dans wine ;) )  
Pour certains bugs, des contournements ont été ajoutés comme pour Visual Studio Community 2022 et nodejs, voir plus loin.  

Comme je m’ennuyais pendant le confinement, j’ai écrit un winetricks(.ps1) personnalisé avec des verbes que je trouve pratiques. Il suffit de faire ‘winetricks’ pour les voir.
Pour certains verbes, un redémarrage complet de wine est nécessaire (en raison de changements récents dans wine). Vous verrez une boîte de dialogue et la session sera terminée. Il suffit de relancer powershell et de réessayer le verbe. Si cela est fait une fois, ce ne sera plus nécessaire pour aucun verbe.  

Exemple :

'winetricks vs22_interactiveinstaller'  ( --> la session sera terminée)

faites 'wine powershell'

faites 'winetricks vs22_interactiveinstaller'


(À propos, via 'winetricks vs22_interactive_installer' vous pouvez choisir quoi installer via l’installateur de Visual Studio 2022 ; 'winetricks vs22_interactive_installer' m'a maintenant permis en dix minutes d'accéder au programme principal (choix : Développement Desktop avec C++)).

Installation :
- Téléchargez et décompressez le fichier zip de la release puis faites 'wine ChoCinstaller_0.5c.751.exe' (prend environ une minute)

Optionnel :
- Lancez l’installateur comme 'wine ChoCinstaller_0.5a.751.exe /s' , alors les fichiers d'installation (comme Powershell*.msi et dotnet48) sont enregistrés dans
  MesDocuments et ils n'ont pas besoin d'être téléchargés de nouveau si vous créez un nouveau préfixe)
Optionnel :
- Lancez l’installateur comme 'wine ChoCinstaller_0.5a.751.exe /q' pour empêcher le lancement automatique de la fenêtre powershell (donc installation uniquement).

Optionnel :
- Vérifiez si tout s'est bien passé : "choco install chromium" et "start chrome.exe (--no-sandbox n'est plus nécessaire depuis wine-8,4)"

![Capture d’écran du 2022-08-26 12-31-18](https://user-images.githubusercontent.com/26839562/186885380-d5a617c4-9cf4-4831-a475-2bd85a3b5784.png)
À propos de PowerShell :

Astuce : Chocolatey installe généralement la dernière version d’un programme, ce qui peut révéler de nouveaux bugs wine. Vous pourriez avoir plus de succès avec une version plus ancienne du logiciel.
Exemple :

choco search --exact microsoft-edge --all (--> liste toutes les versions)

choco install microsoft-edge --version --version='135.0.3179.98'

Infos générales :

- 'wine powershell.exe' lance la console PowerShell-Core.

 
À propos de ConEmu :

La console ConEmu présente quelques bugs liés à Wine :
  - Ctrl^C pour quitter un programme qui ne retourne pas à la console ne fonctionne pas. Utilisez Shift^Ctrl^C à la place.
  - Sélectionner du texte dans la fenêtre ConEmu (pour copier/coller) n’affiche pas la sélection. Un hack très triste contre les versions récentes de wine est inclus pour contourner ce problème, donc la surbrillance devrait maintenant fonctionner.

À propos de winetricks(.ps1) :

- Si vous ne l’appelez pas (‘winetricks’ dans la console powershell), rien n’est téléchargé donc pas de surcharge.
- Beaucoup de verbes (comme powershell 5.1) ont besoin de quelques fichiers essentiels pour extraire des éléments des paquets msu. Installer ces fichiers essentiels nécessite d’abord de gros téléchargements et prend beaucoup de temps lors de la première utilisation. Mais une fois les éléments mis en cache, cela va vite. Par exemple, si vous essayez ‘winetricks ps51’ en premier, cela prendra environ 15 minutes. D’autres verbes peuvent prendre 5 minutes lors de la première utilisation. Mais après avoir appelé un verbe une fois, cet inconvénient disparaît.
- Les fichiers sont mis en cache dans le dossier Mes Documents. Si vous appelez tous les verbes, cela prendra environ 800 Mo.
- Espérons un meilleur support 64 bits pour divers verbes.
- Possibilité d’extraire un fichier et (tenter) d’installer depuis un fichier msu. Faites ‘winetricks install_dll_from_msu’ pour voir comment.
- Un Powershell 5.1 rudimentaire.
- Installation expérimentale de dotnet481, et dotnet35 (peut être nécessaire pour des applications qui ne sont pas satisfaites de l’installation actuelle de dotnet48).
- Auto-complétion des onglets. Remarque : lors de l’utilisation de plusieurs verbes en ligne de commande, ils doivent désormais être séparés par une virgule (c’est ainsi que powershell gère plusieurs arguments)
  Donc ‘winetricks riched20 gdiplus’ ne fonctionnera plus, utilisez ‘winetricks riched20,gdiplus’ à la place
- Certains programmes échouent à l’installation/exécution via Chocolatey à cause de bugs wine. J’ai ajouté quelques solutions de contournement dans winetricks pour eux, voir ci-dessous.
- Verbes spéciaux (winetricks vs19, vs22 et vs22_interactive_installer) pour installer Visual Studio Community 2019 et 2022 fonctionnels (voir capture d’écran, >10 min pour installer et nécessite env. 10 Go !, après installation lancer devenv.exe depuis le dossier c:\Program\ Files (x86)\Microsoft Visual Studio\2019\Community\Common7\IDE/)
  ![capture d’écran](https://github.com/PietJankbal/Chocolatey-for-wine/assets/26839562/d576a619-c752-4eb1-81c2-6f6b66b50ff6)
- Verbe spécial pour accéder à diverses commandes unix comme grep, sed, file, less, curl, etc. (winetricks git.portable, Avertissement : certaines commandes ne fonctionnent pas encore à cause de bugs wine
- Quelques scripts powershell inclus, adaptés à partir d’extraits de code trouvés sur internet :
    - Comment intégrer un exe dans un script powershell via Invoke-ReflectivePEInjection (l’exe n’apparaîtra pas dans la liste des tâches).
    - Comment faire des boîtes de dialogue sophistiquées
    - Convertir un script powershell (ps1) en exe.
    - Et quelques autres

     
À propos des programmes système :

Une fonctionnalité est ajoutée pour remplacer de simples programmes système comme setx.exe par une fonction dans
c:\\Program Files\Powershell\7\profile.ps1. Ou ajouter des programmes système manquants comme getmac.exe.
Si des programmes échouent à cause de programmes système immatures ou manquants, on peut écrire une
fonction qui retourne ce que le programme attend.
Comme dans profile.ps1 j’ai ajouté (entre autres) un wmic.exe qui prend en charge un peu plus d’options,
et un setx.exe basique.
Ou vous pouvez simplement manipuler les arguments passés au programme système. Voir profile.ps1 et choc_install.ps1.
Aucune garantie que cela fonctionne aussi pour des programmes plus complexes...

Notes :


  - N'utilisez PAS sur un wineprefix existant, uniquement sur un nouveau préfixe fraîchement créé ! L'installateur installe bêtement dotnet48 lui-même et modifie les clés de registre.
    Si vous avez déjà une version de dotnet installée avec le winetricks.sh classique, cela échouera probablement, et même si cela réussit, vous risquez d'obtenir un préfixe cassé.
    Si vous devez installer des éléments avec le winetricks.sh classique pour des programmes, n'utilisez AUCUN des verbes dotnet*.
    À noter que les verbes 'Arial' et 'd3dcompiler_47' sont déjà installés par défaut.
  - WINEARCH=win32 n'est _pas_ supporté !
  - La mise à jour depuis une version précédente n'est pour l'instant pas (encore) prise en charge, peut-être plus tard

Compiler :
  - Si vous souhaitez compiler vous-même au lieu de télécharger les binaires : voir les instructions de compilation dans mainv1.c et installer.c
  - Ensuite, copiez choc_install.ps1 dans le même répertoire
  - Puis faites 'wine ChoCinstaller_0.5a.735.exe'
  


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-23

---