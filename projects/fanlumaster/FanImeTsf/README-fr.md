## FanImeTsf

Ceci est l'extrémité TSF de [FanImeServer](https://github.com/fanlumaster/FanImeServer).

Remarque : actuellement, seules les applications 64 bits sont prises en charge.

## Comment construire

### Prérequis

- Visual Studio 2022
- CMake
- vcpkg
- Python3
- gsudo

Assurez-vous que vcpkg et gsudo sont installés via **Scoop**.

## Étapes de compilation

### Compilation

Tout d'abord, clonez le dépôt,

```powershell
git clone --recursive https://github.com/fanlumaster/FanImeTsf.git
```

Ensuite, préparez l'environnement,

```powershell
cd FanImeTsf
python .\scripts\prepare_env.py
```

Ensuite, compilez,

```powershell
.\scripts\lcompile.ps1
```

### Installation

Lancez PowerShell en tant qu'administrateur et assurez-vous d'activer l'option système `Enable sudo`.

![](https://i.postimg.cc/zJCn9Cnn/image.png)

Ensuite, créez un dossier dans `C:\Program Files\` nommé `FanImeTsf`, puis copiez-y le fichier `FanImeTsf.dll`,

```powershell
gsudo
Copy-Item -Path ".\FanImeTsf\build64\Debug\FanImeTsf.dll" -Destination "C:\Program Files\FanImeTsf"
```

Ensuite, installez-le,

```powershell
cd "C:\Program Files\FanImeTsf"
sudo regsvr32 .\FanImeTsf.dll
```

### Désinstallation

```powershell
cd "C:\Program Files\FanImeTsf"
sudo regsvr32 /u .\FanImeTsf.dll
```

## Captures d'écran

![](https://i.postimg.cc/v8Bpx6Gf/image.png)

![](https://i.postimg.cc/ssBgtM5M/image.png)

![](https://i.postimg.cc/ryDqXH0B/image.png)

![](https://i.postimg.cc/2m9WJTgR/image.png)

![](https://i.postimg.cc/L96qQZT8/image.png)

![](https://i.postimg.cc/FNcz9QTv/image.png)

## Feuille de route

Actuellement, seul Xiaohe Shuangpin est pris en charge.

### Chinois

- Xiaohe Shuangpin
- Quanpin
- Codes d'aide pour l'utilisation des composants Hanzi
- Dictionnaire personnalisable
- Moteur IME personnalisable
- Thèmes personnalisés
- Basculement entre le chinois simplifié et le chinois traditionnel
- Autocomplétion en anglais
- API IME Cloud open source
- Basculement de l'interface de la fenêtre de candidats entre le mode vertical et le mode horizontal
- Commutateurs de fonctionnalités : la plupart des fonctionnalités devraient pouvoir être activées/désactivées ou personnalisées librement par l'utilisateur

### Support du japonais

Peut-être un autre projet.

Et peut-être la prise en charge d'autres langues.

### Références

- [MS-TSF-IME-Demo](https://github.com/microsoft/Windows-classic-samples/tree/main/Samples/IME/cpp/SampleIME)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---