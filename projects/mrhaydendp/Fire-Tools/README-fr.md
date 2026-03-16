# <p align="center">Outils Fire</p>

[![Statistiques de téléchargement GitHub)](https://img.shields.io/github/downloads/mrhaydendp/Fire-Tools/total?style=for-the-badge)](https://github.com/mrhaydendp/fire-tools/releases/latest/download/Fire-Tools.zip) [![Dernière version](https://img.shields.io/github/v/release/mrhaydendp/Fire-Tools?style=for-the-badge
)](https://github.com/mrhaydendp/fire-tools/releases/latest)

Fire Tools est une puissante collection d’outils qui aide à dégraisser et installer les services Google sur votre tablette Fire pour la rendre plus réactive et améliorer l’ergonomie. De plus, il prend en charge des lanceurs personnalisés tels que Nova, Lawnchair, ou tout fichier `.apk(m)`. Si vous devez installer plusieurs applications rapidement, il y a un installateur par lots. Il suffit de déposer tous vos `.apk(m)` dans le dossier Batch et de cliquer sur le bouton Batch Install ! Pas besoin d’avoir les droits root !

![Capture d’écran Fire Tools](https://raw.githubusercontent.com/mrhaydendp/Fire-Tools/main/Screenshot.png)

**Fonctionnalités :**
* Multi-plateforme (Linux, macOS & Windows)
* Outil puissant de dégraissage
* Limite le suivi et les publicités Amazon
* Installateur Google Play (Android 8+/Fire OS 7+)
* Support des lanceurs personnalisés (LauncherHijack sur les versions récentes de Fire OS)
* Désactivation des mises à jour OTA
* Extracteur d’APK
* Installateur par lots (fichiers .apk & .apkm)
* Sélecteur DNS personnalisé (AdGuard, Cloudflare, etc.)

**Instructions d’installation (Python) :**

Suivez d’abord les étapes décrites dans [Setup-Instructions.md](/Setup-Instructions.md) ! puis passez aux instructions d’installation. Après l’installation, lancez l’outil de mise à jour pour obtenir la dernière version des scripts !

**Linux/macOS :**

``` shell
# Download Latest Release & Extract, Then Run
curl -LO https://github.com/mrhaydendp/fire-tools/releases/latest/download/Fire-Tools.zip
unzip Fire-Tools.zip && rm Fire-Tools.zip
cd Fire-Tools
chmod +x Scripts/Posix/*.sh
pip3 install -r requirements.txt
python3 main.py
```

**Windows Powershell :**

``` powershell
# Download Latest Release & Extract, Then Run
Start-BitsTransfer "https://github.com/mrhaydendp/fire-tools/releases/latest/download/Fire-Tools.zip"
Expand-Archive .\Fire-Tools.zip .\; Remove-Item .\Fire-Tools.zip
Set-Location Fire-Tools
pip install -r requirements.txt
python main.py
```

**Notes importantes :**

* Bien que ce projet ait des objectifs similaires, il n'est pas affilié à Amazon Fire Toolbox de Datastream33
* Certaines fonctionnalités des Fire Tools peuvent ne plus fonctionner à cause des mises à jour de Fire OS, mais je ferai de mon mieux pour les maintenir.
* Configurez les paramètres de fuseau horaire avant le dégonflage ! (réactivez `com.amazon.kindle.otter.oobe` pour changer les paramètres de date et heure)
* Les applications Google sont téléchargées depuis [ApkMirror](https://www.apkmirror.com/) et sont incluses dans les versions pour plus de commodité, voir [termes](https://github.com/mrhaydendp/Fire-Tools/blob/main/Fire-Tools/Gapps/README.md). Les noms des APK et les URL correspondantes se trouvent dans Fire-Tools/Gapps/README.md
* Le dégonflage désactivera la plupart des applications Amazon à l'exception de : `Calculator`, `Camera`, `Clock`, `Files`, `Fire Launcher`, `Silk Browser` et `Settings`
* Garantie et réinitialisation : Utiliser Fire Tools ne fait pas sauter votre garantie et tous les changements peuvent être annulés par une réinitialisation d'usine.
* Avertissement : Bien que j'aie développé cet outil, je ne suis pas responsable des problèmes résultant de son utilisation.

**Crédits :**  Fire Tools remercie et reconnaît les projets suivants. Ils sont inclus pour votre commodité :

* [Google](https://www.android.com/) (GApps)
* [TeslaCoil Software](https://novalauncher.com/) (Nova Launcher)
* [Lawnchair](https://github.com/LawnchairLauncher/Lawnchair) (Lawnchair)
* [BaronKiko](https://github.com/BaronKiko/LauncherHijack) (LauncherHijack)
* [D0k3](https://github.com/d0k3/OneClick-for-Amazon-Fire) (Inspiré par leur outil OneClick-for-Amazon-Fire)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-16

---