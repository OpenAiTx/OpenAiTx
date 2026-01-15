<p align="center">
  <img src="https://raw.githubusercontent.com/toddmaustin/mojo-v/main/./docs/MojoV-logo1.png" alt="Mojo-V Logo" width="550"/>
</p>

# Mojo-V : Calcul secret pour RISC-V

**Mojo-V** (prononcé *« mojo-five »*) est une nouvelle extension RISC-V qui introduit des capacités de programmation orientées vers la confidentialité pour RISC-V. Mojo-V implémente le calcul secret, permettant une exécution sécurisée, efficace et data-oblivious sans dépendre d'un logiciel fragile ni de la confiance du programmeur. En isolant les données sensibles dans des registres secrets dédiés et en chiffrant la mémoire avec une clé tierce, Mojo-V empêche les divulgations et impose un calcul à la fois aveugle (sans divulgations directes) et silencieux (sans fuite par canal auxiliaire). La conception s’intègre parfaitement dans l’ISA RISC-V existante avec seulement un bit de mode et quatre nouvelles instructions, appliquées entièrement au décodage. Les premiers résultats montrent des vitesses d’exécution proches du natif tout en offrant une amélioration des performances de plus de 5 à 7 ordres de grandeur comparé au chiffrement homomorphe complet (FHE), avec une feuille de route claire pour une intégration dans les CPU, GPU et accélérateurs spécialisés.

Pour en savoir plus...  
- Voici une vidéo d’introduction décrivant Mojo-V : https://www.youtube.com/watch?v=HUT46TcNyyM  
- Des slides donnant un aperçu du projet Mojo-V :  https://drive.google.com/file/d/1VVzZqYHvQgnKMgXZjg7I_cX2GzF7awSN

La spécification actuelle de l’extension ISA Mojo-V (version 0.92) :  
- [Au format PDF.] (https://drive.google.com/file/d/1pargKATFoQdy94i6bI3P_9mfNA_GsYSw)

Pour contacter les développeurs de Mojo-V :  
- Email : [mojov-devs@umich.edu](https://raw.githubusercontent.com/toddmaustin/mojo-v/main/mailto:mojov-devs@umich.edu)

# 🧩 Plateforme de référence Mojo-V — Version 0.92

## 🚧 État du projet

La plateforme de référence Mojo-V version 0.92 implémente le calcul secret entier et à virgule flottante en utilisant un chiffrement symétrique fixe. Mojo-V supporte trois modes de chiffrement : rapide, fort et à preuve intégrée. À cette version, le calcul secret 64 bits est entièrement secretisé et cette plateforme de référence précoce peut être utilisée pour le développement logiciel et le red-teaming. Des fonctionnalités supplémentaires seront déployées dans les prochaines versions, incluant le support PKI, le support du compilateur LLVM, le support RISC-V 32 bits, le support des benchmarks VIP-Bench, etc.

**Version de la spécification :** 0.92  (novembre 2025)  
**Contact :** [mojov-devs@umich.edu](https://raw.githubusercontent.com/toddmaustin/mojo-v/main/mailto:mojov-devs@umich.edu)

## Composants actuels

1. **Spécification ISA Mojo-V v0.92**  
   - publiée dans `doc/`  
2. **Implémentation Spike (simulateur d’instructions)**  
   - Mojo-V intégré dans `riscv-isa-sim`, presque complet fonctionnellement  
   - Manque seulement : Support de l’infrastructure à clé publique (PKI) (utilise actuellement des clés fixes avec un chiffrement Simon-128)  
   - Pour lancer Spike avec les extensions Mojo-V activées, ajoutez l’option `--isa=rv64gc_zicond_zkmojov_zicntr` lors de l’exécution de `spike`  
3. **Benchmarks Bringup-Bench Mojo-V**  
   - Exemples codés à la main (par ex. tri à bulles) montrant le calcul secret avec Mojo-V  
   - Batterie complète de tests de sécurité pour RV64GC+Mojo-V  

Notez que le reste des benchmarks Bringup-bench N’A PAS encore été porté vers Mojo-V.

## ⚙️ Construction et exécution de la plateforme de référence Mojo-V

### A. Installer un compilateur LLVM RISC-V
Vous aurez besoin d’un compilateur croisé RISC-V basé sur LLVM capable de produire des binaires `RV64GC`.

Voici un bon point de départ : https://clang.llvm.org/get_started.html

### B. Cloner le dépôt Mojo-V
```bash
git clone https://github.com/toddmaustin/mojo-v.git
cd mojo-v
```

### C. Construire le simulateur RISC-V Spike avec le support Mojo-V
```bash
sudo apt-get install device-tree-compiler libboost-regex-dev libboost-system-dev
cd riscv-isa-sim
mkdir build
cd build
../configure --prefix=$RISCV
make
```

### D. Construire et Exécuter les Tests de Benchmark Mojo-V Bringup-Bench

1. **Construire le pilote de périphérique Spike**

   ```bash
   cd bringup-bench/target
   make
   ```

2. **Configurez votre compilateur**

   Modifiez `../Makefile` et définissez `TARGET_CC` pour la cible `mojov` à l'emplacement de votre compilateur RISC-V basé sur LVM Clang.

3. **Construisez et testez**

   ```bash
   cd ..                # go to the top-level bringup-bench directory
   make mojov-tests     # run all Mojo-V tests
   ```
  
   En alternative, vous pouvez exécuter un benchmark individuel en vous rendant dans son répertoire et en exécutant la commande suivante.

   ```bash
   cd ../mojov-test
   make TARGET=mojov clean build test
   ```

## 🧪 Aperçu des Benchmarks Bringup-Bench Mojo-V

| Programme | Description |
|:---------|:-------------|
| `mojov-test` | Exemple d’introduction tiré des diapositives |
| `mojov-test1` | Tests des sémantiques des registres secrets et de la mémoire chiffrée |
| `mojov-test2` | Benchmark tri à bulles entier oblivieux aux données codé à la main avec chiffrement rapide Mojo-V (int,fast) |
| `mojov-test3` | Benchmark tri à bulles flottant oblivieux aux données codé à la main avec chiffrement rapide Mojo-V (fp,fast) |
| `mojov-test4` | Benchmark tri à bulles entier oblivieux aux données codé à la main avec chiffrement fort Mojo-V (int,strong) |
| `mojov-test5` | Benchmark tri à bulles flottant oblivieux aux données codé à la main avec chiffrement fort Mojo-V (fp,strong) |
| `mojov-pctests` | Suite de tests d’intégrité codée à la main pour RV64GC+Mojo-V incluant tests positifs et négatifs pour le format de chiffrement à preuve de Mojo-V (proofcarrying) |
| `mojov-sectests` | Suite de tests de sécurité codée à la main pour RV64GC+Mojo-V comprenant 130 tests positifs + 245 négatifs = 375 au total (int,fp,fast,strong) |

Tous les benchmarks de test sont des programmes en assembleur codés à la main démontrant les règles ISA et les sémantiques de sécurité de Mojo-V. Les autres benchmarks Bringup-Bench n’ont pas encore été portés sur Mojo-V.

---
## Licence du Code
Tout le code lié à Mojo-V dans ce dépôt est publié sous la licence de l’outil qu’il modifie (par exemple, Spike, LLVM, Bringup-Bench). Veuillez consulter les répertoires respectifs des outils pour les détails de la licence.

---

## 💬 Questions & Retours
Nous accueillons vos contributions, rapports de bugs et suggestions !

📧 **Email :** [mojov-devs@umich.edu](https://raw.githubusercontent.com/toddmaustin/mojo-v/main/mailto:mojov-devs@umich.edu)  
🌐 **Page du Projet :** [https://github.com/toddmaustin/mojo-v](https://github.com/toddmaustin/mojo-v)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-15

---