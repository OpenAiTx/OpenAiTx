# Terminara

[![Ask DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/luyiourwong/Terminara)

Un jeu de simulation d’IA en ligne de commande.

## Comment utiliser

Vous pouvez télécharger l’application exécutable depuis la [dernière version](https://github.com/luyiourwong/Terminara/releases/latest).

Le fichier compressé complet inclut le fichier exécutable et le fichier de configuration du monde par défaut. Vous pouvez uniquement télécharger le fichier exécutable si vous mettez à jour le jeu vers la dernière version.

| OS      | Version                                          |
|---------|--------------------------------------------------|
| Windows | Windows 10, Windows 11                           |
| Linux   | (GLIBC 2.35+) Ubuntu 22.04 LTS, Ubuntu 24.04 LTS |
| MacOS   | macOS 13, macOS 14, macOS 15, macOS 26           |

<details>
<summary><strong>Exécution manuelle</strong></summary>

### Installation

1.  **Cloner le dépôt :**
    ```bash
    git clone https://github.com/luyiourwong/Terminara
    cd Terminara
    ```
2.  **Créer un environnement virtuel :**

    ```bash
    python -m venv .venv
    source .venv/bin/activate
    ```
    Sous Windows, utilisez `.venv\Scripts\activate`

3.  **Installez les dépendances :**
    ```bash
    pip install -e .
    ```

### Méthode 1 : Utilisation de la commande installée (Recommandé)
Après l'installation, lancez le jeu avec :
```bash
terminara
```

### Démarrer la méthode 2 : Exécution directe
Méthode multiplateforme
```bash
python -m terminara.main
```
or
```bash
python terminara/main.py
```
Sous Windows, utilisez `terminara\main.py`

pour plus d'informations, consultez le [Guide de contribution et développement](https://raw.githubusercontent.com/luyiourwong/Terminara/main/CONTRIBUTING.md).
</details>

## Configuration de l'IA

Après avoir démarré l'application, vous devez configurer les paramètres de l'IA depuis le menu principal.

![Paramètres IA](https://raw.githubusercontent.com/luyiourwong/Terminara/main/docs/assets/ai_settings.png)

Vous devez remplir les champs suivants : (API compatible OpenAI)
- **Hôte** : Le point de terminaison de l'API. Laissez vide pour utiliser le point de terminaison OpenAI par défaut.
- **Clé API** : Votre clé API pour le service d'IA.
- **Modèle** : Le modèle que vous souhaitez utiliser.

Cliquez sur "Appliquer" pour enregistrer les paramètres.

### Exemples

#### 1. [OpenAI](https://platform.openai.com/) (Par défaut)
- **Hôte** : (laisser vide)
- **Clé API** : `VOTRE_CLÉ_API_OPENAI`
- **Modèle** : `gpt-4o-mini-2024-07-18`

#### 2. [Google AI Studio](http://aistudio.google.com/)
- **Hôte** : `https://generativelanguage.googleapis.com/v1beta/openai/`
- **Clé API** : `VOTRE_CLÉ_API_GEMINI`
- **Modèle** : `gemini-2.0-flash`

## Configuration du Monde

### Stockage de la Configuration
Les paramètres du monde sont stockés dans le répertoire `terminara/data/worlds`. (dans la version complète)
```
.
|-- terminara/
|   `-- data/
|       |-- schema/           # Json schema files for world settings
|       `-- worlds/           # Directory for world setting files
`-- terminara_platform_version        # Executable file
```

### Créer un nouveau monde
Il existe un monde exemple [aethelgard.json](https://raw.githubusercontent.com/luyiourwong/Terminara/main/terminara/data/worlds/aethelgard.json). Vous pouvez suivre le [schéma](https://raw.githubusercontent.com/luyiourwong/Terminara/main/terminara/data/schema/world_schema.json) pour créer un nouveau monde.

## Liens

- [Pages GitHub](https://luyiourwong.github.io/Terminara)
- [Dépôt GitHub](https://github.com/luyiourwong/Terminara)
- [Guide de contribution et de développement](https://raw.githubusercontent.com/luyiourwong/Terminara/main/CONTRIBUTING.md)

## Licence

Ce projet est sous licence [MIT License](LICENSE).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-25

---