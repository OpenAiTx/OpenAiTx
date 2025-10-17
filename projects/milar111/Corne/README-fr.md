# Construction d’un Clavier Corne Sans Fil Économique

Un clavier scindé sans fil DIY basé sur la disposition Corne, construit pour environ 25 USD. Ce projet utilise un clone ProMicro avec puce nrf52840, offrant une alternative économique aux constructions classiques de claviers scindés sans fil.

## Caractéristiques
- Entièrement sans fil via Bluetooth
- Design ergonomique scindé (disposition Corne)
- Profil bas pour la portabilité
- Alimenté par batterie avec interrupteur d’alimentation
- Firmware ZMK
- Autonomie estimée de la batterie : plus d’un mois

## Liste des Matériaux

| Composant | Quantité | Coût (USD) | Lien |
|-----------|----------|------------|------|
| Cartes contrôleur (ProMicro nrf52840) | 2 | 6,82 | [AliExpress](https://a.aliexpress.com/_EIV3vwY) |
| Batteries | 2 | 4,20 | [AliExpress](https://a.aliexpress.com/_Eynt9TK) |
| Interrupteurs mécaniques | 50 | 7,47 | [AliExpress](https://a.aliexpress.com/_EGhMxEC) |
| Touches | Set | 3,79 | [Option 1](https://a.aliexpress.com/_EzQyNtA) / [Option 2](https://a.aliexpress.com/_EH8mNqs) |
| Diodes (1N4148) | 100 | 0,85 | [AliExpress](https://a.aliexpress.com/_EwZoG2G) |
| Interrupteurs à glissière | 2 | 0,11 | |
| Pièces imprimées en 3D | Set | 1,80 | Fichiers fournis |

**Coût total** : 25,04 $ (hors fils et vis)

## Disposition Actuelle des Touches

![image](https://github.com/user-attachments/assets/362ff580-5528-4f7a-ad09-1fa24acbc6c7)
![image](https://github.com/user-attachments/assets/3da97ceb-8e2a-43c5-a241-cf9ad4206688)
![image](https://github.com/user-attachments/assets/e262846d-57bf-43b6-b32c-b7e37d3ebb8c)
![image](https://github.com/user-attachments/assets/2a8999cc-e58c-4d51-a142-067cb7ca768c)
![image](https://github.com/user-attachments/assets/06909fd8-bb4d-4956-88a1-f5d6a8b80e5f)

## Instructions de Montage

### Prérequis
- Compétences de soudure de base
- Accès à une imprimante 3D
- Compréhension basique du firmware clavier
### Assemblage du boîtier  
1. Imprimez les fichiers du boîtier (fichiers STL fournis dans le répertoire `3DFiles`)  
2. Remarque : Vous devrez peut-être ajuster :  
   - La taille du compartiment de la batterie  
   - Les trous du commutateur à glissière  

### Câblage  
1. Câblez les interrupteurs en configuration matricielle  
2. Connectez les diodes :  
   - La direction est importante (la ligne noire indique la cathode)  
   - Utilisez les pattes des diodes pour les rangées  
   - Utilisez des fils séparés pour les colonnes  
3. Gardez le câblage éloigné des trous de vis  
4. Connectez la batterie :  
   - GND au pin GND  
   - Positif à l’une des pattes latérales du commutateur à glissière  
   - Broche centrale du commutateur à glissière au pin RAW  

### Connexions des broches pour les rangées et colonnes  
La configuration matricielle utilise les broches GPIO sur le clone nRF52840 Pro Micro. Voici les connexions :  

![pinout](https://github.com/user-attachments/assets/ae1bf9eb-8071-4a8f-8cac-c95a39f61f9e)  

#### Comment sont numérotées les rangées et les colonnes  

- **Rangées** : Les rangées sont toujours numérotées de haut en bas sur les deux moitiés.  
- **Colonnes** : Les colonnes sont toujours numérotées de gauche à droite (vu de l’arrière de la plaque (là où le câblage est fait)).  

⚠️ **Remarque** : Si vous soudez par erreur les rangées ou colonnes aux mauvaises broches, il n’est pas nécessaire de dessouder. Les correspondances peuvent être corrigées dans les fichiers de configuration du firmware :  
- `corne.dtsi` : Définit les rangées pour les deux moitiés.  
- `corne_left.overlay` : Définit les colonnes pour la moitié gauche.  
- `corne_right.overlay` : Définit les colonnes pour la moitié droite.  

#### Assignations des broches pour la moitié gauche  
- **Rangées (connectées à `row-gpios`)** :  
  - Rangée 0 : Broche 21  
  - Rangée 1 : Broche 20  
  - Rangée 2 : Broche 19  
  - Rangée 3 : Broche 18

- **Colonnes (Connectées à `col-gpios`)** :
  - Colonne 0 : Broche 2
  - Colonne 1 : Broche 7
  - Colonne 2 : Broche 6
  - Colonne 3 : Broche 5
  - Colonne 4 : Broche 4
  - Colonne 5 : Broche 3

#### Affectations des broches de la moitié droite
- **Lignes (`row-gpios`)** :
  - Ligne 0 : Broche 21
  - Ligne 1 : Broche 20
  - Ligne 2 : Broche 19
  - Ligne 3 : Broche 18
- **Colonnes (`col-gpios`)** :
  - Colonne 0 : Broche 3
  - Colonne 1 : Broche 4
  - Colonne 2 : Broche 5
  - Colonne 3 : Broche 6
  - Colonne 4 : Broche 7
  - Colonne 5 : Broche 2

### Configuration du firmware
Ce clavier utilise le firmware ZMK. La moitié gauche agit comme le contrôleur principal qui se connecte à votre appareil.

Pour flasher le firmware :
1. Appuyez deux fois sur le bouton de réinitialisation
2. La carte apparaîtra comme un périphérique de stockage de masse
3. Flashez le fichier firmware approprié

Si vous avez oublié le clavier sur votre appareil et ne pouvez pas vous reconnecter :
1. Flashez le fichier `settings_reset-nice_nano_v2-zmk.uf2`
2. Reflashez le firmware normal
3. Appairez

## Structure du dépôt
```
├── .github/workflows/
│   └── build.yml
├── 3DFiles/
│   ├── STEP/
│   │   └── CorneSTEP.step
│   ├── STL/
│   │   ├── Case_Left.stl
│   │   ├── Case_Right.stl
│   │   └── PlateCorne.stl
├── config/
│   ├── boards/shields/corne/
│   │   ├── corne_left.conf
│   │   ├── corne_left.overlay
│   │   ├── corne_right.conf
│   │   ├── corne_right.overlay
│   │   ├── corne.conf
│   │   ├── corne.dtsi
│   │   ├── Kconfig.defconfig
│   │   └── Kconfig.shield
│   ├── corne.keymap
│   └── west.yml
├── firmware/
│   ├── corne_left-nice_nano_v2-zmk.uf2
│   ├── corne_right-nice_nano_v2-zmk.uf2
│   └── settings_reset-nice_nano_v2-zmk.uf2
└── zephyr/
    ├── module.yml
    └── build.yaml
```
## Problèmes connus
- Le boîtier côté gauche peut présenter des déformations si la batterie gonfle
- Les trous pour l'interrupteur à glissière peuvent nécessiter un ajustement en fonction de vos composants

## Résultat final
![im1](https://github.com/user-attachments/assets/f57abe5a-585d-4f4e-b741-5c103c7af887)
![im3](https://github.com/user-attachments/assets/1ed52801-5bc1-44b9-8378-1a5e53600e92)




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-17

---