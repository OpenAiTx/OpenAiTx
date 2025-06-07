# ch32fun

Un environnement de développement open source (outils, en-têtes, exemples) pour le [CH32V003](http://www.wch-ic.com/products/CH32V003.html) (et de nombreuses autres puces de la famille CH32V) avec gcc-riscv64, utilisable sous Windows (Natif), Linux et/ou WSL. Le CH32V003 est un composant à 10 centimes doté d'un cœur RISC-V EC fonctionnant à 48 MHz, avec 16 kB de flash, 2 kB de RAM et de nombreux périphériques. Il est disponible en boîtiers SOP-8, QFN-20 et SOIC. Vous pouvez obtenir la fiche technique [ici](http://www.wch-ic.com/downloads/CH32V003DS0_PDF.html).

L'objectif de ce projet est de développer les outils et l'environnement pour une utilisation efficace du CH32V003. Évitez les HAL compliqués, et exploitez pleinement le matériel ! L'EVT existant est massif, et l'environnement de développement lourd. Ce projet évite spécifiquement le HAL et permet d'utiliser simplement le [TRM](http://www.wch-ic.com/downloads/CH32V003RM_PDF.html). À titre de comparaison, un blinky ne fait que 500 octets avec ch32fun, démarre plus vite, et est bien plus simple dans l'ensemble.

ch32fun contient :
1. Des exemples utilisant ch32fun, mais moins nombreux que ceux utilisant le HAL. La plupart sont centrés autour du ch32v003, mais beaucoup sont compatibles avec d'autres processeurs.
2. "minichlink" qui utilise le WCH CH-Link avec libusb, pour une utilisation multiplateforme.
  * Un programmateur STM32F042, le [NHC-Link042](https://github.com/NgoHungCuong/NHC-Link042)
  * Un programmateur ESP32S2, le [esp32s2-funprog](https://github.com/cnlohr/esp32s2-cookbook/tree/master/ch32v003programmer)
  * Le programmateur officiel WCH Link-E.
  * Une interface basée sur Arduino, [Ardulink](https://gitlab.com/BlueSyncLine/arduino-ch32v003-swio).
  * Prise en charge du débogage de type gdbserver pour une utilisation avec Visual Studio.
  * Prise en charge de printf via un seul fil. (À environ 400 kBaud)
3. Une copie supplémentaire de libgcc pour pouvoir utiliser des chaînes de compilation risc-v inhabituelles, située dans `misc/libgcc.a`.
4. Un dossier nommé "ch32fun" contenant un seul fichier source autonome et un fichier d'en-tête pour compiler des applications pour le ch32v003.
5. Sur certains systèmes, possibilité de faire un "printf" en retour via
6. Un bootloader de démonstration.

## Support de la famille

Actuellement, il existe un support expérimental pour les ch32v103, ch32v203, ch32v208, ch32v303, ch32v305 et ch32v307. GDB est principalement testé sur le 003, mais fonctionne, dans une certaine mesure, sur les autres processeurs.

## Pour commencer

Pour les instructions d'installation/paramétrage, voir la [page wiki ici](https://github.com/cnlohr/ch32fun/wiki/Installation)

## Fonctionnalités !

### Un débogage rapide "printf" via l'interface de programmation.

Et par rapide, j'entends vraiment rapide. Typiquement autour de 36 kOctets/sec.

```
./minichlink -T | pv > /dev/null
Found ESP32S2 Programmer
 536KiB 0:00:15 [36.7KiB/s] [        <=>                     ]
```

Vous pouvez simplement essayer le projet debugprintf, ou appeler SetupDebugPrintf(); et utiliser printf() librement.

### Prise en charge du débogage !

Via gdbserver intégré dans minichlink ! Fonctionne avec `gdb-multiarch` ainsi que dans Visual Studio Code.

## Compilation et Flashage

```
cd examples/blink
make
```

text = code, data = constantes et valeurs d'initialisation, bss = valeurs non initialisées.  
dec est la somme des trois et reflète le nombre d'octets en flash qui seront utilisés par le programme.

Le .bin généré est utilisé par minichlink et le fichier .hex est compatible avec l'outil officiel de flash WCH.

## VSCode +/- PlatformIO

Note : PlatformIO est généralement utilisé pour l'intégration continue sur ce dépôt. Bien que PlatformIO puisse être utilisé pour coder et déboguer un projet ch32fun dans VSCode, il est aussi possible de le faire sans PlatformIO : pour cela, voir le [projet modèle](https://github.com/cnlohr/ch32fun/tree/master/examples/template/.vscode).

Ce projet peut être compilé, téléversé et débogué avec VSCode et l'extension PlatformIO. Il suffit de cloner et d'ouvrir ce projet dans VSCode avec l'extension PlatformIO installée. Utilisez le [sélecteur d'environnement du projet](https://docs.platformio.org/en/latest/integration/ide/vscode.html#project-tasks) pour choisir un exemple spécifique, tel que "blink".

Pour créer un nouveau projet firmware PlatformIO basé sur ch32fun, utilisez simplement l'assistant "Nouveau Projet" du [PlatformIO Home](https://docs.platformio.org/en/latest/home/index.html) et réglez "Framework" sur "ch32v003fun". Il existe [divers exemples](https://github.com/Community-PIO-CH32V/platform-ch32v/tree/develop/examples/blinky-ch32v003fun).

![pio_proj](https://raw.githubusercontent.com/cnlohr/ch32fun/master/.github/pio_project_creation.png)

La commande équivalente en [PlatformIO Core CLI](https://docs.platformio.org/en/latest/integration/ide/vscode.html#platformio-core-cli) serait :
```sh
pio init -b genericCH32V003F4P6 -O "framework = ch32v003fun"
```

Si vous souhaitez ajouter votre code directement au projet ch32fun, veuillez étendre les environnements disponibles dans le `platformio.ini` [selon les instructions](https://raw.githubusercontent.com/cnlohr/ch32fun/master/platformio.ini#L48-L53).

Veuillez également noter que lorsque vous ouvrez ce projet dans PlatformIO, vous pouvez utiliser le [sélecteur d'environnement du projet](https://docs.platformio.org/en/latest/integration/ide/vscode.html#project-tasks) en bas de la barre des tâches VSCode pour sélectionner un dossier exemple spécifique. Sinon, "Build" compilera par défaut **tous** les exemples.

Voir [platform-ch32v](https://github.com/Community-PIO-CH32V/platform-ch32v) pour plus de détails et l'installation de la plateforme.

## clangd

Si le serveur de langage C/C++ clangd n'arrive pas à trouver `ch32fun.h`, il faudra nettoyer l'exemple `make clean` et le construire une fois avec `bear -- make build`, ce qui générera un fichier `compile_commands.json`, utilisé par clangd pour retrouver les chemins d'inclusion spécifiés dans les makefiles.  
`make clangd` fait cela en une étape.  
`build_all_clangd.sh` dans `build scripts` le fait pour tous les exemples.

## Référence rapide
 * **REQUIS** pour la programmation/le débogage : `SWIO` est sur `PD1`. Ne pas réutiliser PD1 pour plusieurs fonctions.
 * **OPTIONNEL** `NRST` est sur `PD7`. Non nécessaire, par défaut en GPIO dans certaines configurations.
 * **OPTIONNEL** UART `TX` est sur : `PD5`. Il est recommandé d'utiliser SWIO pour le débogage `printf`.

![ch32v003a4m6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003a4m6.svg)
![ch32v003f4p6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003f4p6.svg)
![ch32v003f4u6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003f4u6.svg)
![ch32v003j4m6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003j4m6.svg)

## Plus d'exemples / projets ?

D'autres outils tiers ajoutent de nombreux exemples, etc. Consultez les dépôts suivants pour des bibliothèques supplémentaires, etc.
 * [ch32v003fun_wildwest](https://github.com/recallmenot/ch32v003fun_wildwest)
 * [ch32v003fun_libs](https://github.com/hexeguitar/ch32v003fun_libs)
 * [CH32V003_lib_uart](https://github.com/ADBeta/CH32V003_lib_uart)
 * [CH32Vxxx_lib_i2c](https://github.com/ADBeta/CH32Vxxx_lib_i2c)
 * [CH32Vxxx_lib_swi2c](https://github.com/ADBeta/CH32Vxxx_lib_swi2c)
 * [ch32v003fun_shenanigans](https://github.com/DeadBugEngineering/ch32v003fun_shenanigans)
 * [ch32fun-bmp280-driver](https://github.com/pabloestrado/ch32fun-bmp280-driver)
 * [ch32fun-aht20-driver](https://github.com/pabloestrado/ch32fun-aht20-driver)

## Support

Vous pouvez ouvrir un ticket GitHub ou rejoindre mon Discord dans le canal #ch32fun. Pour l'instant les invitations sont privées, donc envoyez-moi un message @cnlohr pour obtenir un lien d'invitation. Mes messages privés sont ouverts.

### Notes de bas de page/liens

 * https://raw.githubusercontent.com/openwch/ch32v003/main/RISC-V%20QingKeV2%20Microprocessor%20Debug%20Manual.pdf Manuel de débogage
 * http://www.wch-ic.com/downloads/QingKeV2_Processor_Manual_PDF.html Manuel du processeur
 * http://www.wch-ic.com/downloads/CH32V003RM_PDF.html Manuel de référence technique
 * http://www.wch-ic.com/downloads/CH32V003DS0_PDF.html Datasheet
 * https://github.com/CaiB/CH32V003-Architecture-Exploration/blob/main/InstructionTypes.md Détails sur l'ISA compressé de cette puce.
 * Le CH32V003 possède des extensions xv, vous pouvez utiliser cette version personnalisée de rvcodec.js pour travailler avec ses opcodes : https://xw.macyler.moe/

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---