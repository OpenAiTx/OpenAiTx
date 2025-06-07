<div class="header" align="center">
<img alt="Frontier Station" height="300" src="https://github.com/new-frontiers-14/frontier-station-14/blob/master/Resources/Textures/_NF/Logo/logo.png?raw=true" />
</div>

Frontier Station — это форк [Space Station 14](https://github.com/space-wizards/space-station-14), работающий на движке [Robust Toolbox](https://github.com/space-wizards/RobustToolbox), написанном на C#.

Это основной репозиторий Frontier Station.

Если вы хотите разместить сервер или создавать контент для Frontier Station, вам нужен именно этот репозиторий. Он содержит и RobustToolbox, и пакет контента для разработки новых пакетов контента.

## Ссылки

<div class="header" align="center">  
[Discord](https://discord.gg/tpuAT7d3zm/) | [Steam](https://store.steampowered.com/app/1255460/Space_Station_14/) | [Patreon](https://www.patreon.com/frontierstation14) | [Wiki](https://frontierstation.wiki.gg/)
</div>

## Документация/Вики

Наша [вики](https://frontierstation.wiki.gg/) содержит документацию по контенту Frontier Station.

## Вклад

Мы рады принимать вклад от всех желающих. Присоединяйтесь к Discord, если хотите помочь. У нас есть [список идей](https://discord.com/channels/1123826877245694004/1127017858833068114), которые может выполнить любой желающий. Не стесняйтесь спрашивать помощь!

В настоящее время мы не принимаем переводы игры в нашем основном репозитории. Если вы хотите перевести игру на другой язык, рассмотрите возможность создания форка или внесения вклада в форк.

Если вы делаете какие-либо изменения, пожалуйста, обязательно прочитайте раздел о маркерах в [MARKERS.md](https://github.com/new-frontiers-14/frontier-station-14/blob/master/MARKERS.md).
Любые изменения в файлах, принадлежащих нашему upstream, должны быть должным образом отмечены в соответствии с указанными там правилами.

## Сборка

1. Клонируйте этот репозиторий:
```shell
git clone https://github.com/new-frontiers-14/frontier-station-14.git
```
2. Перейдите в папку проекта и выполните `RUN_THIS.py` для инициализации подмодулей и загрузки движка:
```shell
cd frontier-station-14
python RUN_THIS.py
```
3. Скомпилируйте решение:  

Соберите сервер с помощью команды `dotnet build`.

[Более подробные инструкции по сборке проекта.](https://docs.spacestation14.com/en/general-development/setup.html)

## Лицензия

Контент, внесённый в этот репозиторий после коммита 2fca06eaba205ae6fe3aceb8ae2a0594f0effee0, лицензируется под GNU Affero General Public License версии 3.0, если не указано иное (см. Примечания по атрибуции ниже). См. файл `LICENSE-AGPLv3.txt`.
Контент, внесённый до коммита 2fca06eaba205ae6fe3aceb8ae2a0594f0effee0, лицензируется по лицензии MIT, если не указано иное. См. файл `LICENSE-MIT.txt`.

[2fca06eaba205ae6fe3aceb8ae2a0594f0effee0](https://github.com/new-frontiers-14/frontier-station-14/commit/2fca06eaba205ae6fe3aceb8ae2a0594f0effee0) был добавлен 1 июля 2024 года в 16:04 UTC.

Большинство ассетов лицензированы под [CC-BY-SA 3.0](https://creativecommons.org/licenses/by-sa/3.0/), если не указано иное. Лицензия и авторские права на ассеты указаны в файле метаданных. Например, смотрите [метаданные для лома](https://github.com/new-frontiers-14/frontier-station-14/blob/master/Resources/Textures/Objects/Tools/crowbar.rsi/meta.json).  

Обратите внимание, что некоторые ассеты лицензированы под некоммерческую [CC-BY-NC-SA 3.0](https://creativecommons.org/licenses/by-nc-sa/3.0/) или аналогичные некоммерческие лицензии и должны быть удалены, если вы планируете использовать этот проект в коммерческих целях.

## Атрибуция

Когда мы добавляем контент из других форков, мы размещаем его в отдельных подпапках для отслеживания атрибуции и уменьшения конфликтов при слиянии.

Контент в этих подпапках происходит из соответствующих форков и может содержать изменения. Эти изменения отмечаются комментариями вокруг изменённых строк.

| Подпапка | Название форка | Репозиторий форка | Лицензия |
|--------------|-----------|-----------------|---------|
| `_NF` | Frontier Station | https://github.com/new-frontiers-14/frontier-station-14 | AGPL 3.0 |
| `_CD` | Cosmatic Drift | https://github.com/cosmatic-drift-14/cosmatic-drift | MIT |
| `_Corvax` | Corvax | https://github.com/space-syndicate/space-station-14 | MIT |
| `_Corvax` | Corvax Frontier | https://github.com/Corvax-Frontier/Frontier | AGPL 3.0 |
| `_DV` | Delta-V | https://github.com/DeltaV-Station/Delta-v | AGPL 3.0 |
| `_EE` | Einstein Engines | https://github.com/Simple-Station/Einstein-Engines | AGPL 3.0 |
| `_Emberfall` | Emberfall | https://github.com/emberfall-14/emberfall | MPL 2.0 |
| `_EstacaoPirata` | Estacao Pirata | https://github.com/Day-OS/estacao-pirata-14 | AGPL 3.0 |
| `_Goobstation` | Goob Station | https://github.com/Goob-Station/Goob-Station | AGPL 3.0 |
| `_Impstation` | Impstation | https://github.com/impstation/imp-station-14 | AGPL 3.0 |
| `_NC14` | Nuclear 14 | https://github.com/Vault-Overseers/nuclear-14 | AGPL 3.0 |
| `Nyanotrasen` | Nyanotrasen | https://github.com/Nyanotrasen/Nyanotrasen | MIT |

Дополнительные репозитории, из которых мы портировали функции без подпапок, перечислены ниже.

| Название форка | Репозиторий форка | Лицензия |
|-----------|-----------------|---------|
| Monolith | https://github.com/Monolith-Station/Monolith | AGPL 3.0 |
| Space Station 14 | https://github.com/space-wizards/space-station-14 | MIT |
| White Dream | https://github.com/WWhiteDreamProject/wwdpublic | AGPL 3.0 |

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---