# Double Love

<div align="center">

[![GitHub license](https://img.shields.io/github/license/Ahua9527/Double-Love)](https://github.com/Ahua9527/Double-Love/blob/main/LICENSE)
![GitHub stars](https://img.shields.io/github/stars/Ahua9527/Double-Love)

🎬 L'amour entre les images, efficacité doublée

[//]: # (Œuf de Pâques caché dans le code)
<!Double Love : Que chaque plan cache le framerate que je n'ai pas osé dire -->

[English](./README.en.md) · 简体中文 · [Expérience en ligne](https://double-love.ahua.space)

</div>

Double Love fournit un traitement automatisé et standardisé des métadonnées de rapport de script. Prise en charge hors ligne. Par le traitement par lots et localisé, il permet une intégration transparente avec Adobe Premiere, Silverstack, DTG Slate pour garantir la cohérence des métadonnées. Améliore efficacement l'efficacité du workflow de postproduction.

## ✨ Fonctionnalités

- 🎬 Prise en charge des workflows industrialisés du cinéma
- 📝 Traitement intelligent de la normalisation des métadonnées
- ⚡ Traitement local sans latence
- 🧩 Intégration transparente avec Adobe Premiere

## 🚀 Démarrage rapide

### Workflow de base

1. Prise de notes plateau : Générer une fiche technique interactive avec DTG Slate
2. Gestion des données : Importer les données de script avec Silverstack Lab
3. Exportation de fichier : Générer un XML pour Adobe Premiere Pro
4. Traitement standardisé : Optimisation intelligente avec Double Love

Exemple :
- XML d'entrée : `UnitA_304_20250127.xml`
- XML de sortie : `UnitA_304_20250127_Double_LOVE.xml`

### Exemple détaillé

#### Optimisation de la dénomination des fichiers
- Le programme traite automatiquement le format du numéro de scène, du plan et de la prise
- Ajoute automatiquement des zéros initiaux aux chiffres
- Gère automatiquement la casse
- Nettoie automatiquement les traits de soulignement superflus

#### Règles de nommage des segments

Le nom du segment traité suit le format suivant :
```
{préfixeProjet}{scène}_{plan}_{prise}{caméra}{note}
```

- `prefix` : Préfixe personnalisé (optionnel)
- `scene` : Numéro de scène (3 chiffres, ex. 001)
- `shot` : Numéro de plan (2 chiffres, ex. 01)
- `take` : Numéro de prise (2 chiffres, ex. 01)
- `camera` : Identifiant caméra (lettre minuscule, ex. a)
- `Rating` : Évaluation (ok/kp/ng)

#### Traitement des évaluations
- `Circle` → `ok`
- `KEEP` → `kp`
- `NG` → `ng`

#### Informations DIT
- Ajoute automatiquement l'information DIT : 'DIT : 哆啦Ahua 🌱'
- Pour la retirer, merci de déployer vous-même 😁😁

#### Exemple de préfixe personnalisé

1. Définir le préfixe sur "PROJECT_A_" :
   - Fichier d'entrée : `A304C007_250123G3`
   - Fichier de sortie : `PROJECT_A_004_01_07a_kp`

2. Sans préfixe :
   - Fichier d'entrée : `A304C007_250123G3`
   - Fichier de sortie : `004_01_07a_kp`

#### Exemple de réglage de la résolution de la séquence

1. Résolution FHD (par défaut) :
   - Largeur : 1920
   - Hauteur : 1080   
2. Résolution DCI 2K (personnalisée) :
   - Largeur : 2048
   - Hauteur : 1080   

#### Exemple de traitement par lots

1. Importez plusieurs fichiers en même temps :
   ```
   UnitA_304_20250123.xml
   UnitA_305_20250124.xml
   UnitA_306_20250125.xml
   ```

2. Après traitement, vous obtiendrez :
   ```
   UnitA_304_20250123_Double_LOVE.xml
   UnitA_305_20250124_Double_LOVE.xml
   UnitA_306_20250125_Double_LOVE.xml
   ```

## 🛠️ Stack technique

- React 18
- TypeScript
- Vite
- Tailwind CSS
- Lucide Icons
- Support PWA

## 📦 Installation et utilisation

1. Cloner le projet

```bash
git clone https://github.com/Ahua9527/Double-Love.git
cd Double-Love
```

2. Installer les dépendances

```bash
npm install
```

3. Développement local

```bash
npm run dev
```

4. Construire le projet

```bash
npm run build
```

## 🔒 Sécurité

- Tous les traitements de fichiers sont effectués localement dans le navigateur, sans upload vers un serveur
- Taille maximale de fichier prise en charge : 50 Mo
- Seuls les fichiers au format XML sont pris en charge

## 🌈 Guide du développeur

### Structure du projet

```
Double-Love/
├── src/
│   ├── components/     # Composants React
│   ├── context/       # Context React
│   ├── utils/         # Fonctions utilitaires
│   ├── styles/        # Fichiers de styles
│   └── App.tsx        # Composant principal
├── public/            # Ressources statiques
└── ...fichiers de configuration
```

## 📃 Licence

[Licence MIT](LICENSE)

## 🤝 Guide de contribution

Issues et Pull Requests sont les bienvenus !

## 👨‍💻 Auteur

哆啦Ahua🌱

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-17

---