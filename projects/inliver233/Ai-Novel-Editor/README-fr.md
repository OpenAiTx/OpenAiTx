
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

# Éditeur de Roman IA

Éditeur de roman assisté par IA basé sur PyQt6, offrant des outils professionnels d’écriture tels que la complétion intelligente, la gestion de projet et l’organisation des concepts.

## Installation

1. Cloner le projet
```bash
git clone https://github.com/inliver233/Ai-Novel-Editor.git
cd ai-novel-editor
```

2. Création d'un environnement virtuel
```bash
python -m venv venv
venv\Scripts\activate     # Windows
```

3. Installer les dépendances
```bash
pip install -r requirements.txt
```

4. Exécuter le programme
```bash
python src/main.py
```

## Fonctionnalités principales

### Gestion de projet
- Structure documentaire hiérarchique (Œuvre > Chapitre > Scène)
- Import/export de projet (prise en charge des formats TEXT, MARKDOWN, DOCX, PDF, HTML)
- Sauvegarde automatique et contrôle des versions
- Gestion de plusieurs projets

### Fonctionnalité de complétion AI
- Trois modes de complétion : complétion automatique, complétion manuelle (recommandé : appuyer une fois sur Tab pour déclencher, puis une deuxième fois pour appliquer), désactivation de la complétion
- Trois modes de contexte :
  - Mode rapide : contexte léger, réponse rapide
  - Mode équilibré : contexte moyen, équilibre entre qualité et vitesse
  - Mode global : contexte complet du projet, effet optimal
- Prise en charge de plusieurs services AI : OpenAI, Claude, Tongyi Qianwen, Zhipu AI, DeepSeek, Groq, etc.

### Gestion des plans
- Structure arborescente du plan visualisable
- Tri et ajustement hiérarchique par glisser-déposer
- Navigation rapide dans les documents
- Analyse de plan et suggestions d’optimisation

### Configuration API
- Centre de configuration AI unifié
- Configuration prédéfinie pour plusieurs fournisseurs
- Fonction de test de connexion
- Sauvegarde et import/export des configurations

### Paramètres de complétion intelligente
- Délai de déclenchement réglable
- Limitation de la longueur de la complétion
- Configuration de la longueur du contexte
- Prise en charge de la réponse en streaming

### Édition de prompts
- Nombreux modèles d’écriture intégrés
- Modèles de prompts personnalisés
- Gestion par catégories des modèles
- Configuration de modèles spécifiques à chaque mode

### Fonctionnalités de l’interface
- Thème clair/sombre
- Disposition à trois colonnes (arborescence du projet, éditeur, panneau de concepts)
- Barre latérale repliable
- Mode écriture plein écran
- Mode concentration (phrase, paragraphe, machine à écrire, mode zen, mode immersion)

### Recherche et remplacement
- Recherche de texte dans tout le projet
- Prise en charge des expressions régulières
- Fonction de remplacement en lot
- Options de recherche avancée

### Gestion des concepts
- Détection automatique des personnages, lieux, objets
- Gestion des relations de concepts
- Système d’étiquettes et de catégories
- Insertion rapide de concepts

## Raccourcis clavier

- `Ctrl+N` : Nouveau projet
- `Ctrl+O` : Ouvrir un projet
- `Ctrl+S` : Sauvegarder le document
- `F11` : Mode plein écran
- `Tab` : Déclencher manuellement l’auto-complétion IA (en mode manuel)
- `Ctrl+F` : Recherche
- `Ctrl+H` : Recherche et remplacement
- `Ctrl+Shift+H` : Recherche et remplacement avancés


## Configuration requise

- Python 3.8+
- PyQt6
- Système d’exploitation : Windows, macOS, Linux

## Auteur

**inliver**
- E-mail : inliverapi@outlook.com  
- GitHub : https://github.com/inliver233

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-01

---