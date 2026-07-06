# 🎯 Pilote MT7902 en tant que sous-partie du pilote MT7921 (✅ Fonctionne)
Chip wifi 6E Mediatek mt7902 Support Bluetooth et WiFi

> [!IMPORTANT]
> Le noyau Linux 7.1 prend officiellement en charge la puce WIFI 6E MT7902


## 📁 Cloner le dépôt
Clonez le dépôt sur votre PC local
  ```
  git clone https://github.com/OnlineLearningTutorials/mt7902_temp
  ```
Si vous ne souhaitez pas cloner l'historique passé alors
  ```
  git clone --depth 1 https://github.com/OnlineLearningTutorials/mt7902_temp
  ```

## Installation


### 🚀 Script de guide d'installation (Recommandé pour les systèmes basés sur Ubuntu)
Rendez le script exécutable s'il ne l'est pas déjà
```
chmod +x ./install_guide.sh
```
Exécutez maintenant ce script
```
./install_guide.sh
```
Il vous demandera automatiquement le mot de passe si nécessaire  
* Ce script vous demandera d’installer le firmware, le pilote bluetooth et wifi un par un  
* Testé sur Ubuntu avec le noyau linux 7.0  

### 🚀 Correction automatique facile (Recommandée pour les systèmes basés sur Arch)  
Si vous souhaitez réparer rapidement votre WiFi et Bluetooth sur n’importe quel noyau moderne, suivez ces étapes :  

Rendez le script exécutable s’il ne l’est pas déjà
```
chmod +x ./fix_my_wifi.sh
```
**Exécutez le script de correction automatique** avec sudo :

```bash
sudo bash fix_my_wifi.sh
```

#### 📖 Ce que fait ce script :
* **Vérifie les dépendances :** S’assure que vous avez `gcc`/`clang`, `make`, `bc` et les `kernel-headers` actuels installés. Sinon - installe avec votre gestionnaire de paquets préféré.
* **Compile les pilotes :** Construit automatiquement les pilotes WiFi et Bluetooth pour la version exacte de votre noyau.
* **Correction persistante :** Installe un service système qui garantit que votre WiFi reste actif même après un redémarrage de votre ordinateur.
* **Sécurité :** Installe les modules dans un répertoire personnalisé (`/lib/modules/mt7902_custom`) pour éviter de perturber vos fichiers système par défaut.

> [!NOTE]
> Vous aurez besoin d’une connexion internet (via Ethernet ou partage USB depuis votre téléphone) la première fois que vous lancez ceci pour télécharger les outils de compilation nécessaires. (Comme le compilateur, linux-headers, etc)


## ✅ Testé sur (Fonctionne vérifié)
Cette correction a été vérifiée et fonctionne sur :

* **Marque :** ASUS
* **Modèle :** Vivobook Go (E1404FA), Vivobook 14 (X1404ZA)
* **Chipset :** MediaTek MT7902 (WiFi 6E)
* **Version du noyau :** 6.19.0 (Linux), 6.19.11, 7.0.7
* **Systèmes d’exploitation :** Arch, Ubuntu
* **Gestionnaire de paquets :** pacman, apt

## Disponible pour :
* **OS** : Tout OS supportant un des gestionnaires de paquets
* **Gestionnaires de paquets préférés :** apt, pacman, dnf, zypper, nix-shell
* **Versions du noyau :** 6.14-7.0.7


## 🔧 Firmwares utilisés
Les firmwares sont stockés dans le dossier `firmware`.


## 📱 Bluetooth ✅ (Fonctionnel)
> [!AVERTISSEMENT]
> Si le pilote bluetooth entre en conflit avec `gen4-mt7902`, veuillez supprimer le firmware bluetooth afin qu’il n’interfère pas avec ce pilote
> ``` sudo rm /lib/firmware/mediatek/mt7902/BT_RAM_CODE_MT7902_1_1_hdr.bin.zst ```
> Ce projet utilise le firmware
> ``` /lib/firmware/mediatek/BT_RAM_CODE_MT7902_1_1_hdr.bin.zst ```

Pour activer le bluetooth, allez dans le répertoire de votre version actuelle du noyau. ``
Par exemple, si vous avez le noyau linux-6.16, allez dans le répertoire `./linux-6.16/drivers/bluetooth` .
Ouvrez un terminal dans ce répertoire et compilez avec la commande `make`.  
Deux modules du noyau sont compilés : `btusb.ko` et `btmtk.ko`.  
Pour activer le bluetooth sur votre appareil, supprimez btusb et btmtk de votre système et installez ces deux fichiers, utilisez les commandes
```
sudo rmmod btusb 
sudo rmmod btmtk

sudo insmod btmtk.ko
sudo insmod btusb.ko

```
Vérifiez maintenant si votre Bluetooth fonctionne.

## 💻 WiFi ✅ (Fonctionnel)
> [!IMPORTANT]
> Un dépôt fonctionnel avec certaines limitations est [ici](https://github.com/hmtheboy154/gen4-mt7902)

Le pilote WiFi pour le mt7902, récemment publié par mediatek, se trouve dans le dossier `latest`.

Si vous utilisez Ubuntu, allez simplement dans le dossier `latest` et exécutez la commande suivante dans le terminal.
```
make
```
Il compilera tous les modules, les compressera et les installera (remplaçant le module noyau original par le module modifié). Si vous utilisez une autre distribution ou ne souhaitez pas toutes les étapes et souhaitez uniquement compiler le code, alors exécutez dans le terminal  

```
make module_compile
```
Pour compresser le module que vous avez compilé, exécutez ensuite dans le terminal
```
make module_compress
```
Pour installer le module compressé dans le module noyau du système, exécutez dans le terminal
```
make module_install
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-06

---