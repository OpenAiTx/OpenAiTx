# Évaluation DROID Sim

Ce dépôt contient des scripts pour évaluer les politiques DROID dans un environnement simple ISAAC Sim.

Voici un exemple de déroulement d’une politique pi0-FAST-DROID :

Scène 1

![Scène 1](https://raw.githubusercontent.com/arhanjain/sim-evals/main/./docs/scene1.gif)

Scène 2

![Scène 2](https://raw.githubusercontent.com/arhanjain/sim-evals/main/./docs/scene2.gif)

Scène 3

![Scène 3](https://raw.githubusercontent.com/arhanjain/sim-evals/main/./docs/scene3.gif)

La simulation est réglée pour fonctionner en *zero-shot* avec les politiques DROID entraînées sur le jeu de données DROID du monde réel, donc aucune donnée de simulation séparée n’est requise.

**Note :** Le simulateur actuel fonctionne mieux pour les politiques entraînées avec un espace d’action en *position articulaire* (et *pas* en contrôle de vitesse articulaire). Nous fournissons des exemples pour évaluer les politiques pi0-FAST-DROID entraînées avec contrôle en position articulaire ci-dessous.


## Installation

Cloner le dépôt
```bash
git clone --recurse-submodules git@github.com:arhanjain/sim-evals.git
cd sim-evals
```

Installer uv (voir : https://github.com/astral-sh/uv#installation)

Par exemple (Linux/macOS) :
```bash
curl -LsSf https://astral.sh/uv/install.sh | sh
```

Créer et activer un environnement virtuel
```bash
uv sync
source .venv/bin/activate
```

## Démarrage rapide

Tout d'abord, assurez-vous de télécharger les ressources de simulation à la racine de ce répertoire
```bash
uvx hf download owhan/DROID-sim-environments --repo-type dataset --local-dir assets
```

Ensuite, dans un terminal séparé, lancez le serveur de politique sur `localhost:8000`.  
Par exemple, pour lancer une politique pi0-FAST-DROID (avec contrôle de position conjointe),  
consultez [openpi](https://github.com/Physical-Intelligence/openpi) et utilisez les configurations `polaris`  
```bash
XLA_PYTHON_CLIENT_MEM_FRACTION=0.5 uv run scripts/serve_policy.py policy:checkpoint --policy.config=pi05_droid_jointpos_polaris --policy.dir=gs://openpi-assets/checkpoints/pi05_droid_jointpos
```

**Remarque** : Nous avons défini `XLA_PYTHON_CLIENT_MEM_FRACTION=0.5` pour éviter que JAX ne monopolise toute la mémoire GPU (au cas où Isaac Sim utiliserait le même GPU).

Enfin, exécutez le script d’évaluation :
```bash
python run_eval.py --episodes [INT] --scene [INT] --headless
```

## Exemple minimal

```python
env_cfg.set_scene(scene) # pass scene integer
env = gym.make("DROID", cfg=env_cfg)

obs, _ = env.reset()
obs, _ = env.reset() # need second render cycle to get correctly loaded materials
client = # Your policy of choice

max_steps = env.env.max_episode_length
for _ in tqdm(range(max_steps), desc=f"Episode"):
    action = client.infer(obs, INSTRUCTION) # calling inference on your policy
    action = torch.tensor(ret["action"])[None]
    obs, _, term, trunc, _ = env.step(action)
    if term or trunc:
        break
env.close()
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-21

---