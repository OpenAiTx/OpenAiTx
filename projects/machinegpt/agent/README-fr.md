![2](https://github.com/user-attachments/assets/a18257a3-a678-4fd4-bf77-750dab4d99bb)

# Agent

Un framework d'agent IA Python autonome et à grande vitesse qui exploite le SDK Python d’OpenAI pour interpréter les commandes en langage naturel, générer et exécuter dynamiquement du code, et gérer son environnement d’exécution sans friction. Il propose l’installation automatique des dépendances, la configuration sécurisée de l’environnement, la journalisation structurée et une interface minimaliste de plugins pour intégrer des outils Python puissants—le tout sous la licence permissive Apache 2.0.

## ⭐ Historique des étoiles

<p align="center">
  <a href="https://star-history.com/#machinegpt/agent&Date">
    <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=machinegpt/agent&type=Date&theme=dark" onerror="this.src='https://api.star-history.com/svg?repos=machinegpt/agent&type=Date'" />
  </a>
</p>

## 🔧 Configuration de l’environnement

### Environnement virtuel Python
Avant de configurer le projet, il est recommandé de créer un environnement virtuel. Suivez ces étapes :

En savoir plus sur les environnements virtuels : [Guide d’empaquetage Python](https://packaging.python.org/en/latest/guides/installing-using-pip-and-virtual-environments/)

Créez et activez un environnement virtuel :

**Windows :**

```
py -m venv .venv
.venv\Scripts\activate
```

**macOS/Linux :**
```
python3 -m venv .venv
source .venv/bin/activate
```

### Configuration du projet
Ce projet nécessite une clé API OpenAI pour fonctionner. Pour la fournir, créez un fichier .env à la racine du projet avec le contenu suivant :
```
OPENAI_API_KEY=
```
Vous pouvez aussi copier le fichier .env.example fourni et mettre à jour la clé :
```
cp .env.example .env
```

## 🧠 Démarrage
Pour démarrer l’agent, exécutez simplement :
```
git clone https://github.com/machinegpt/agent.git
cd agent

python machine.py
```

## ✨ Contributions

Les contributions, suggestions, rapports de bugs et correctifs sont les bienvenus !

Pour toute nouvelle fonctionnalité, composant ou extension, veuillez ouvrir une issue et en discuter avant d’envoyer une PR.

## 💖 Ce projet existe dans son état actuel grâce à toutes les personnes qui contribuent
<a href="https://github.com/machinegpt/agent/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=machinegpt/agent" />
</a>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-04

---