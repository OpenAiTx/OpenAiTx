# API de Euroleague

Este es un paquete de Python de la API de Euroleague para las ligas *Euroleague* y *EuroCup*. Los endpoints de la API fueron encontrados en la [plataforma swagger](https://api-live.euroleague.net/swagger/index.html), con la adición de algunos endpoints más (por ejemplo, datos de tiros) encontrados en blogs y discusiones. Se agregarán más endpoints.

Si te gusta esta biblioteca, considera donar en


<a href="https://www.buymeacoffee.com/georgios.giasemidis" target="_blank"><img src="https://cdn.buymeacoffee.com/buttons/default-orange.png" alt="Buy Me A Coffee" height="41" width="174"></a>

## Instalación

```bash
pip install euroleague-api
```

## Ejemplo

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

### Calendario de la Liga
[schedule.py](https://htmlpreview.github.io/?https://github.com/giasemidis/euroleague_api/blob/main/site/euroleague_api/schedule.html)

### Funciones auxiliares

[utils.py](https://htmlpreview.github.io/?https://github.com/giasemidis/euroleague_api/blob/main/site/euroleague_api/utils.html)

## POR HACER

- Añadir pruebas


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-06

---