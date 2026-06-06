# 유로리그 API

이것은 *Euroleague* 및 *EuroCup* 리그를 위한 유로리그 API의 파이썬 패키지입니다. API 엔드포인트는 [swagger 플랫폼](https://api-live.euroleague.net/swagger/index.html)에서 찾았으며, 블로그와 토론에서 발견된 몇 가지 추가 API 엔드포인트(예: 슛 데이터)도 포함되어 있습니다. 더 많은 엔드포인트가 추가될 예정입니다.

이 라이브러리가 마음에 드시면, 기부를 고려해 주세요.


<a href="https://www.buymeacoffee.com/georgios.giasemidis" target="_blank"><img src="https://cdn.buymeacoffee.com/buttons/default-orange.png" alt="Buy Me A Coffee" height="41" width="174"></a>

## 설치 방법

```bash
pip install euroleague-api
```

## 예제

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
### 리그 일정
[schedule.py](https://htmlpreview.github.io/?https://github.com/giasemidis/euroleague_api/blob/main/site/euroleague_api/schedule.html)

### 보조 함수

[utils.py](https://htmlpreview.github.io/?https://github.com/giasemidis/euroleague_api/blob/main/site/euroleague_api/utils.html)

## 해야 할 일

- 테스트 추가하기



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-06

---