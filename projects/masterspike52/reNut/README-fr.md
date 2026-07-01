

<img width="1920" height="1080" alt="renut logo" src="https://github.com/user-attachments/assets/273bee28-755f-4494-920f-9333af72091e" />




Originally created with <a href="https://github.com/rexglue/rexglue-sdk">Rexglue-SDK</a>



DISCORD
--------------------------------------------
We have a discord, please join and direct any questions there. Myself or someone else will happily answer them.

https://discord.gg/D5Bz2ZsHdY



Credits
------------------------------------------------
<a href="https://github.com/rexglue/rexglue-sdk">Rexglue team</a> for creating Rexglue-SDK
<br>
the Rexglue SDK discord for helping with any info they have
<br>
SolarCookies for midasm hooks and future use of CRT functions and the reNut Launcher
<br>
ValcomDrifty for the renut logo
<br>
.
<br>
.
<br>
.
<br>
.
<br>
.
<br>
.
<br>
vous, le joueur ?
<br>
.


EXIGENCES
-------------------------------------------------------------------
Version US de banjo-kazooie : nuts and bolts default.xex


COMMENT CONSTRUIRE
------------------------------------------------------
REMARQUE : VOUS DEVEZ SUPPRIMER TOUTES LES INSTANCES DE .gitignore SINON CE QUE VOUS COMPILEZ NE VERRA PAS LES FICHIERS DANS LES ZONES OÙ ILS SE TROUVENT.
<br>
REMARQUE : VOUS DEVEZ INSTALLER <a href="https://git-scm.com/install/windows">GIT</a> AVANT D'INSTALLER LE REXGLUE-SDK, OU DE CONSTRUIRE CE REPO.
<br>
REMARQUE : REMARQUE : VOUS DEVEZ CONSTRUIRE ET INSTALLER LE REPO PRINCIPAL DE <a href="https://github.com/rexglue/rexglue-sdk">Rexglue-SDK</a> AVANT DE CONTINUER


1. Clonez le dépôt avec ```git clone https://github.com/masterspike52/reNut.git```
2. Dans le dossier assets, vous devez extraire le contenu de votre iso banjo-kazooie : Nuts&Bolts ainsi que le default.xex. Je recommande d’utiliser <a href="https://consolemods.org/wiki/images/5/5f/XBOX360_ISO_Extract.zip">iso extract</a>. (Je ne sais pas ce que les utilisateurs Linux utilisent. J’utilise Windows, cependant iso extract fonctionne aussi sous Linux via WINE.)
3. Dans votre dépôt cloné, ouvrez un terminal et exécutez ```rexglue migrate --app_root .``` Cela garantit que si quelque chose change avec codegen sur Rexglue, vous pouvez générer correctement le code.
   3b. Vous devez ensuite soit supprimer votre dossier out, soit, si vous êtes sous Windows, ouvrir VS, faire un clic droit sur votre cmakelists.txt, supprimer le cache et reconfigurer pour générer le code avec la version que vous utilisez.
4. Vous pouvez maintenant ouvrir un terminal et exécuter ```rexglue codegen renut_config.toml``` ce qui vous donnera les fichiers ppc à recompiler dans le dossier generated.
5. Si vous êtes sous Windows, vous pouvez ouvrir le projet dans VS, changer le type de build en `win-amd64-relwithdebinfo`, puis tout compiler.
   5b. Si vous êtes sous Linux, et que vous n’avez pas accès à VS, vous devrez utiliser un terminal et exécuter ```cmake --preset linux-amd64-relwithdebinfo``` puis ```cmake --build --preset linux-amd64-relwithdebinfo```. (Vous pouvez faire cela sous Windows aussi, il suffit de remplacer `linux` par `windows`.)
6. Une fois compilé, vous devez avoir l’exécutable construit dans le même répertoire que les assets, sinon le jeu ne s’ouvrira pas.

IL EXISTE UN FORK LINUX
-------------------------------------------------
si vous souhaitez construire pour linux, veuillez utiliser ce fork de <a href="https://github.com/etonedemid/reNut">reNut</a> réalisé par etonedemid, il nécessite d’utiliser son fork de <a href="https://github.com/etonedemid/rexglue-sdk">rexglue</a> et il a fait une PR sur rexglue pour que ces éléments deviennent partie intégrante du main. 


SI VOUS NE VOULEZ PAS CONSTRUIRE
--------------------------------------------
La compilation est principalement destinée à ceux qui préfèrent construire ou veulent aider à développer le jeu avec moi et d’autres. Si vous ne voulez pas construire ;
* Allez sur https://goopie.xyz/ et téléchargez le lanceur goopie
* Dans le lanceur, sélectionnez banjo-kazooie : nuts and bolts
* Cliquez sur Sélectionner ISO et sélectionnez votre iso pour banjo-kazooie : nuts and bolts (doit être la version nord-américaine) et attendez la fin de l’extraction
* Après la fin de l'extraction, cliquez sur le bouton de mise à jour, le lanceur téléchargera alors la dernière version de Windows de renut  
* Cliquez sur jouer  

  
PROBLÈMES CONNUS  
-----------------------------------------------  
1. Les animations sont un peu saccadées (il y a des tremblements, les os de banjo et d'autres se cassent, certaines animations sont à moitié faites, et quelques petits accessoires) mais elles n'entravent pas le gameplay, c'est juste amusant à voir.  

  
CRÉER UN PROBLÈME  
--------------------------  
L'onglet Problèmes est un endroit pour des choses comme des plantages qui se produisent dans le jeu et qui ne sont pas déjà notés, veuillez éviter de créer des problèmes comme "Le jeu ne s'ouvre pas" ou "Faut-il utiliser des ISOs ?".  
Vous devez utiliser le modèle de plantage pour tout problème lié à des plantages (je ferai probablement d'autres modèles), car je ne veux pas que ce soit inondé principalement de messages d'erreur utilisateur. Veuillez rejoindre le discord et utiliser le canal #help si vous avez un problème sans rapport avec un plantage.




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-01

---