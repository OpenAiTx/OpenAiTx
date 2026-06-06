# 欧洲篮球联赛 API

这是一个针对 *Euroleague* 和 *EuroCup* 联赛的欧洲篮球联赛 API 的 Python 包。API 端点来源于 [swagger 平台](https://api-live.euroleague.net/swagger/index.html)，并补充了一些在博客和讨论中发现的额外 API 端点（例如投篮数据）。未来还会添加更多端点。

如果你喜欢这个库，考虑捐赠支持


<a href="https://www.buymeacoffee.com/georgios.giasemidis" target="_blank"><img src="https://cdn.buymeacoffee.com/buttons/default-orange.png" alt="Buy Me A Coffee" height="41" width="174"></a>

## 安装

```bash
pip install euroleague-api
```

## 示例

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

### 联赛赛程
[schedule.py](https://htmlpreview.github.io/?https://github.com/giasemidis/euroleague_api/blob/main/site/euroleague_api/schedule.html)

### 辅助函数

[utils.py](https://htmlpreview.github.io/?https://github.com/giasemidis/euroleague_api/blob/main/site/euroleague_api/utils.html)

## 待办事项

- 添加测试


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-06

---