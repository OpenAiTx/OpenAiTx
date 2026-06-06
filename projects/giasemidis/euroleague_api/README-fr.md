# API Euroleague

Ceci est un package Python de l'API Euroleague pour les ligues *Euroleague* et *EuroCup*. Les points de terminaison de l'API ont été trouvés sur la [plateforme swagger](https://api-live.euroleague.net/swagger/index.html), avec l'ajout de quelques points de terminaison supplémentaires (par exemple, les données de tir) trouvés sur des blogs et des discussions. D'autres points de terminaison seront ajoutés.

Si vous aimez cette bibliothèque, envisagez de faire un don sur


<a href="https://www.buymeacoffee.com/georgios.giasemidis" target="_blank"><img src="https://cdn.buymeacoffee.com/buttons/default-orange.png" alt="Buy Me A Coffee" height="41" width="174"></a>

## Installation

```bash
pip install euroleague-api
```
## Exemple


```python
from euroleague_api.shot_data import ShotData

season = 2022
game_code = 1
competition_code = "E"

shotdata = ShotData(competition_code)
df = shotdata.get_game_shot_data(season, game_code)
```

See also the `notebooks/get-season-stats.ipynb` notebook for examples.

## Documentation

### Euroleague Data class

[EuroleagueData.py](https://htmlpreview.github.io/?https://github.com/giasemidis/euroleague_api/blob/main/site/euroleague_api/EuroLeagueData.html)

### Game stats

[game_stats.py](https://htmlpreview.github.io/?https://github.com/giasemidis/euroleague_api/blob/main/site/euroleague_api/game_stats.html)

### Player stats

[player_stats.py](https://htmlpreview.github.io/?https://github.com/giasemidis/euroleague_api/blob/main/site/euroleague_api/player_stats.html)

### Team stats

[team_stats.py](https://htmlpreview.github.io/?https://github.com/giasemidis/euroleague_api/blob/main/site/euroleague_api/team_stats.html)

### Standings

[standings.py](https://htmlpreview.github.io/?https://github.com/giasemidis/euroleague_api/blob/main/site/euroleague_api/standings.html)

### Shot data

[shot_data.py](https://htmlpreview.github.io/?https://github.com/giasemidis/euroleague_api/blob/main/site/euroleague_api/shot_data.html)

### Play-by-play data

[play_by_play_data.py](https://htmlpreview.github.io/?https://github.com/giasemidis/euroleague_api/blob/main/site/euroleague_api/play_by_play_data.html)

### Boxscore data

[boxscore_data.py](https://htmlpreview.github.io/?https://github.com/giasemidis/euroleague_api/blob/main/site/euroleague_api/boxscore_data.html)

### Game Metadata

[game_metadata.py](https://htmlpreview.github.io/?https://github.com/giasemidis/euroleague_api/blob/main/site/euroleague_api/game_metadata.html)

### Calendrier de la Ligue
[schedule.py](https://htmlpreview.github.io/?https://github.com/giasemidis/euroleague_api/blob/main/site/euroleague_api/schedule.html)

### Fonctions auxiliaires

[utils.py](https://htmlpreview.github.io/?https://github.com/giasemidis/euroleague_api/blob/main/site/euroleague_api/utils.html)

## À FAIRE

- Ajouter des tests


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-06

---