<div align="right">
  <details>
    <summary >🌐 Langue</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=it">Itapano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>
</div>
# Éditeur de Romans IA

Éditeur de romans assisté par IA basé sur PyQt6, offrant des outils professionnels d’écriture tels que la complétion intelligente, la gestion de projets, l’organisation de concepts, etc.

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
Utiliser uv
```bash
uv venv -p 3.11
```
3. Installer les dépendances
```bash
pip install -r requirements.txt
```
Utiliser uv
```bash
uv sync
```

4. Exécuter le programme
```bash
python -m src
```

## Fonctionnalités principales

### Gestion de projet
- Structure hiérarchique des documents (Œuvre > Chapitre > Scène)
- Importation et exportation de projets (prise en charge des formats TEXT, MARKDOWN, DOCX, PDF, HTML)
- Sauvegarde automatique et contrôle de version
- Gestion multi-projets
### Fonctionnalité de complétion IA
- Trois modes de complétion : complétion automatique, complétion manuelle (recommandé : appuyez une fois sur Tab pour déclencher, appuyez de nouveau sur Tab pour appliquer la complétion), désactivation de la complétion
- Trois modes de contexte :
  - Mode rapide : contexte léger, réponse rapide
  - Mode équilibré : contexte moyen, équilibre entre qualité et rapidité
  - Mode global : contexte complet du projet, meilleurs résultats
- Prise en charge de plusieurs services IA : OpenAI, Claude, Tongyi Qianwen, Zhipu AI, DeepSeek, Groq, etc.

### Gestion de l’aperçu (Outline)
- Structure de l’arborescence de l’aperçu visuelle
- Classement par glisser-déposer et ajustement des niveaux
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
- Prise en charge de la réponse en flux continu

### Édition des invites
- Plusieurs modèles d'écriture intégrés
- Modèles d'invite personnalisés
- Gestion des catégories de modèles
- Configuration de modèles spécifiques à un mode

### Fonctionnalités de l'interface
- Double thème clair/sombre
- Disposition à trois colonnes (arborescence du projet, éditeur, panneau de concepts)
- Barre latérale repliable
- Mode d'écriture plein écran
- Mode concentration (phrase, paragraphe, machine à écrire, mode zen, mode immersion)

### Recherche et remplacement
- Recherche de texte dans tout le projet
- Prise en charge des expressions régulières
- Fonction de remplacement par lots
- Options de recherche avancées

### Gestion des concepts
- Détection automatique des rôles, lieux, objets
- Gestion des relations entre concepts
- Système de tags et de classification
- Insertion rapide de concepts

## Raccourcis clavier

- `Ctrl+N` : Nouveau projet
- `Ctrl+O` : Ouvrir un projet
- `Ctrl+S` : Enregistrer le document
- `F11` : Mode plein écran
- `Tab` : Déclencher manuellement la complétion IA (en mode manuel)
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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---