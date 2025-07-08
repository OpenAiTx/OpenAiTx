# Spegel – Reflétez le web grâce à l’IA

Réécrit automatiquement les sites web en markdown optimisé pour l’affichage dans le terminal.
Lisez l’article de présentation [ici](https://simedw.com/2025/06/23/introducing-spegel/)

Ceci est une preuve de concept, des bugs sont à prévoir mais n’hésitez pas à signaler un problème ou à proposer une pull request.

## Capture d’écran
Parfois, vous ne voulez pas lire toute l’histoire de quelqu’un juste pour accéder à une recette
![Exemple de recette](https://simedw.com/2025/06/23/introducing-spegel/images/recipe_example.png)


## Installation

Nécessite Python 3.11+

```
pip install spegel
```
ou clonez le dépôt et installez-le en mode éditable

```bash
# Cloner et entrer dans le répertoire
$ git clone <repo-url>
$ cd spegel

# Installer les dépendances et l’interface en ligne de commande
$ pip install -e .
```

## Clés API
Spegel ne prend actuellement en charge que Gemini 2.5 Flash ; pour l’utiliser vous devez fournir votre clé API dans l’environnement

```
GEMINI_API_KEY=...
```


## Utilisation

### Lancer le navigateur

```bash
spegel                # Démarrer avec l’écran d’accueil
spegel bbc.com        # Ouvrir une URL immédiatement
```

Ou, de façon équivalente :

```bash
python -m spegel      # Démarrer avec l’écran d’accueil
python -m spegel bbc.com
```

### Commandes de base
- `/`         – Ouvrir la saisie d’URL
- `Tab`/`Shift+Tab` – Parcourir les liens
- `Entrée`     – Ouvrir le lien sélectionné
- `e`         – Modifier l’invite LLM pour la vue actuelle
- `b`         – Revenir en arrière
- `q`         – Quitter

## Modification des paramètres

Spegel charge les paramètres à partir d’un fichier de configuration TOML. Vous pouvez personnaliser les vues, les invites et les options d’interface.

**Ordre de recherche du fichier de config :**
1. `./.spegel.toml` (répertoire courant)
2. `~/.spegel.toml`
3. `~/.config/spegel/config.toml`

Pour modifier les paramètres :
1. Copiez la configuration d’exemple :
   ```bash
   cp example_config.toml .spegel.toml
   # ou créez ~/.spegel.toml
   ```
2. Modifiez `.spegel.toml` dans votre éditeur préféré.

Exemple de section :
```toml
[settings]
default_view = "terminal"
app_title = "Spegel"

[[views]]
id = "raw"
name = "Vue brute"
prompt = ""

[[views]]
id = "terminal"
name = "Terminal"
prompt = "Transforme cette page web pour une expérience de navigation terminal parfaite ! ..."
```

---

Pour en savoir plus, consultez le code ou ouvrez un ticket !

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---