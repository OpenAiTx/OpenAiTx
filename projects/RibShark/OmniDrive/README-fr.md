# OmniDrive
Copyright © 2026 Rib

## Description
OmniDrive est une modification du firmware pour les lecteurs de disques optiques basés sur MediaTek MT1959 fabriqués par Hitachi-LG Data Storage, qui permet des fonctionnalités offrant une lecture meilleure et plus complète des disques, y compris les disques de jeux propriétaires.

## Fonctionnalités
* Lecture lead-in/lead-out pour CD/DVD/BD et dérivés.
* Lecture de secteurs bruts pour CD/DVD/BD et dérivés (2352 octets/secteur pour CD, 2064 octets/secteur pour DVD, 2072 octets/secteur pour BD).
* Commande personnalisée READ DISC RAW pour lire les disques, avec des indicateurs pour FUA (contournement du cache), adressage brut (MSF pour CD, PSN pour DVD/BD), et décrambling (pour DVD/BD).
* La capacité de lire divers disques de jeux propriétaires (voir tableau) :

| Type de disque | Support | Notes |
| ---: | :---: | --- |
| CD (ROM/R/RW) | ☑️ |
| DVD (ROM/RAM/±R/±RW) | ☑️ |
| BD (ROM/R/RE) | ☑️ |
| BD-XL (R/RE) | ☑️ |
| UHD-BD | ☑️ |
| PlayStation 3 BD-ROM | ☑️ | Le contenu du disque est chiffré, la clé du disque n’est pas récupérable
| PlayStation 4 BD-ROM | ☑️ | Le contenu du disque est chiffré, la clé du disque n’est pas récupérable
| PlayStation 5 BD-ROM | ☑️ | Le contenu du disque est chiffré, la clé du disque n’est pas récupérable
| Xbox (XGD1) | ✅ |
| Xbox 360 (XGD2/XGD3) | ✅ |
| Xbox One/Series (XGD4) | ✅ | Le contenu du disque est chiffré, la clé du disque n’est pas récupérable
| GameCube (NROM)/Wii (RVL-ROM) | ✅ |
| GameCube (NR)/Wii (RVT-R) | ❓ |
| Wii U (WUP-ROM?) | ⚠️ | Peut être lu en brut, mais l’algorithme de brouillage est actuellement inconnu |
| Wii U (CAT-R) | ☑️ |
| Dreamcast (GD-ROM/GD-R) | ❎ | Seule la zone basse densité peut être lue |

Clé :
* ☑️ - Support natif (sans firmware patché)
* ✅ - Supporté avec OmniDrive
* ⚠️ - Support partiel (voir notes)
* ❓ - Support inconnu (nécessite des tests)
* ❎ - Non supporté actuellement

## Compilation
### Dépendances
* CMake
* ninja
* chaîne d'outils arm-none-eabi-gcc
* [armips](https://github.com/Kingcom/armips)
* Python 3
* pycryptodome
### Instructions
1. Placez les fichiers firmware d'origine LG BU40N 1.00 et ASUS BW-16D1HT 3.02 dans le dossier `firmware`. Les fichiers doivent être nommés comme suit et avoir les sommes de contrôle suivantes :

| Nom de fichier | CRC32 | MD5 | SHA-1 |
| --- | --- | --- | --- |
| HL-DT-ST_BD-RE_BU40N_1.00.bin | `E3C1A315` | `EDB28FCD7A239281ACE26A468D382A9C` | `9C48677B155154D24A3B95A32B4A29CA02FF40B3` |
| ASUS_BW-16D1HT_3.02.bin | `84000B21` | `97F0EEABD0B675B4363B2C4749226016` | `F8DF5B579F25DA8D4E5AA5EF79F3005DAC5EB8C7` |
2. Créez un dossier `build` et lancez `cmake -G Ninja ..` depuis le dossier build.
3. Exécutez `ninja`. Les fichiers firmware patchés devraient être générés dans le dossier `patched_firmware`.

## Flashage
Actuellement, la méthode recommandée pour flasher les lecteurs est d'utiliser `sdftool` qui fait partie de [MakeMKV](https://makemkv.com/). Le firmware BU40N devrait fonctionner avec tous les lecteurs slim et le firmware BW-16D1HT devrait fonctionner avec tous les lecteurs de bureau.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-09

---