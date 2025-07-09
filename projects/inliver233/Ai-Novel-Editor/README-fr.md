# Éditeur de Roman IA

Éditeur de roman assisté par IA basé sur PyQt6, offrant des outils professionnels d'écriture tels que la complétion intelligente, la gestion de projet et l'organisation des concepts.

## Installation

1. Cloner le projet
```bash
git clone https://github.com/inliver233/Ai-Novel-Editor.git
cd ai-novel-editor
```

2. Créer un environnement virtuel
```bash
python -m venv venv
venv\Scripts\activate     # Windows
```

3. Installer les dépendances
```bash
pip install -r requirements.txt
```
4. Exécution du programme
```bash
python src/main.py
```

## Fonctionnalités principales

### Gestion de projet
- Structure de document hiérarchique (Œuvre > Chapitre > Scène)
- Importation et exportation de projet (prise en charge des formats TEXT, MARKDOWN, DOCX, PDF, HTML)
- Sauvegarde automatique et contrôle de version
- Gestion multi-projets

### Fonctionnalité de complétion AI
- Trois modes de complétion : complétion automatique, complétion manuelle (recommandé : appuyez une fois sur tab pour déclencher, puis une autre fois pour appliquer la complétion), désactivation de la complétion
- Trois modes de contexte :
  - Mode rapide : contexte léger, réponse rapide
  - Mode équilibré : contexte moyen, équilibre entre qualité et rapidité
  - Mode global : contexte du projet complet, meilleurs résultats
- Prise en charge de plusieurs services AI : OpenAI, Claude, Tongyi Qianwen, Zhipu AI, DeepSeek, Groq, etc.
### Gestion de l’aperçu
- Structure arborescente de l’aperçu visualisable
- Tri par glisser-déposer et ajustement de la hiérarchie
- Navigation rapide dans le document
- Analyse de l’aperçu et suggestions d’optimisation

### Configuration de l’API
- Centre de configuration IA unifié
- Configurations prédéfinies pour plusieurs fournisseurs
- Fonction de test de connexion
- Sauvegarde, importation et exportation des configurations

### Paramètres de complétion intelligente
- Délai de déclenchement réglable
- Limite de longueur de complétion
- Configuration de la longueur du contexte
- Prise en charge de la réponse en flux

### Édition des prompts
- Divers modèles d’écriture intégrés
- Modèles de prompt personnalisés
- Gestion de la classification des modèles
- Configuration de modèles spécifiques aux modes
### Fonctionnalités de l’interface
- Double thème clair/sombre
- Disposition à trois colonnes (arborescence du projet, éditeur, panneau des concepts)
- Barre latérale rétractable
- Mode écriture plein écran
- Mode concentration (phrase, paragraphe, machine à écrire, mode zen, mode immersion)

### Recherche et remplacement
- Recherche de texte dans tout le projet
- Prise en charge des expressions régulières
- Fonction de remplacement en lot
- Options de recherche avancées

### Gestion des concepts
- Détection automatique des personnages, lieux, objets
- Gestion des relations entre concepts
- Système de tags et de classification
- Insertion rapide de concepts

## Raccourcis clavier
- `Ctrl+N` : Nouveau projet  
- `Ctrl+O` : Ouvrir un projet  
- `Ctrl+S` : Enregistrer le document  
- `F11` : Mode plein écran  
- `Tab` : Déclencher manuellement la complétion AI (en mode manuel)  
- `Ctrl+F` : Rechercher  
- `Ctrl+H` : Rechercher et remplacer  
- `Ctrl+Shift+H` : Recherche et remplacement avancés  


## Exigences du système

- Python 3.8+
- PyQt6
- Système d'exploitation : Windows, macOS, Linux

## Auteur

**inliver**
- Email : inliverapi@outlook.com  
- GitHub : https://github.com/inliver233

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---