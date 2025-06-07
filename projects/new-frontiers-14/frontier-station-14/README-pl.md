<div class="header" align="center">
<img alt="Frontier Station" height="300" src="https://github.com/new-frontiers-14/frontier-station-14/blob/master/Resources/Textures/_NF/Logo/logo.png?raw=true" />
</div>

Frontier Station to fork [Space Station 14](https://github.com/space-wizards/space-station-14), działający na silniku [Robust Toolbox](https://github.com/space-wizards/RobustToolbox) napisanym w C#.

To jest główne repozytorium Frontier Station.

Jeśli chcesz hostować lub tworzyć zawartość dla Frontier Station, to jest repozytorium, którego potrzebujesz. Zawiera zarówno RobustToolbox, jak i pakiet zawartości do rozwoju nowych pakietów zawartości.

## Linki

<div class="header" align="center">  
[Discord](https://discord.gg/tpuAT7d3zm/) | [Steam](https://store.steampowered.com/app/1255460/Space_Station_14/) | [Patreon](https://www.patreon.com/frontierstation14) | [Wiki](https://frontierstation.wiki.gg/)
</div>

## Dokumentacja/Wiki

Nasza [wiki](https://frontierstation.wiki.gg/) zawiera dokumentację dotyczącą zawartości Frontier Station.

## Wkład

Z przyjemnością przyjmujemy wkład od każdego. Dołącz na Discorda, jeśli chcesz pomóc. Mamy [listę pomysłów](https://discord.com/channels/1123826877245694004/1127017858833068114), które można zrealizować i każdy może je podjąć. Nie bój się też prosić o pomoc!

Aktualnie nie przyjmujemy tłumaczeń gry w naszym głównym repozytorium. Jeśli chcesz przetłumaczyć grę na inny język, rozważ utworzenie forka lub współpracę z forkiem.

Jeśli dokonasz jakiegokolwiek wkładu, upewnij się, że przeczytałeś sekcję o markerach w [MARKERS.md](https://github.com/new-frontiers-14/frontier-station-14/blob/master/MARKERS.md)
Wszelkie zmiany w plikach pochodzących z naszego upstreamu powinny być odpowiednio oznaczone zgodnie z tym, co jest tam określone.

## Budowanie

1. Sklonuj to repozytorium:
```shell
git clone https://github.com/new-frontiers-14/frontier-station-14.git
```
2. Przejdź do folderu projektu i uruchom `RUN_THIS.py`, aby zainicjalizować submoduły i załadować silnik:
```shell
cd frontier-station-14
python RUN_THIS.py
```
3. Skompiluj rozwiązanie:  

Zbuduj serwer używając `dotnet build`.

[Bardziej szczegółowe instrukcje dotyczące budowania projektu.](https://docs.spacestation14.com/en/general-development/setup.html)

## Licencja

Zawartość dodana do tego repozytorium po commicie 2fca06eaba205ae6fe3aceb8ae2a0594f0effee0 jest licencjonowana na zasadach GNU Affero General Public License w wersji 3.0, chyba że zaznaczono inaczej (patrz Atrybucje poniżej). Zobacz `LICENSE-AGPLv3.txt`.
Zawartość dodana do tego repozytorium przed commitem 2fca06eaba205ae6fe3aceb8ae2a0594f0effee0 jest licencjonowana na zasadach licencji MIT, chyba że zaznaczono inaczej. Zobacz `LICENSE-MIT.txt`.

[2fca06eaba205ae6fe3aceb8ae2a0594f0effee0](https://github.com/new-frontiers-14/frontier-station-14/commit/2fca06eaba205ae6fe3aceb8ae2a0594f0effee0) został wypchnięty 1 lipca 2024 o godzinie 16:04 UTC.

Większość zasobów jest licencjonowana na zasadach [CC-BY-SA 3.0](https://creativecommons.org/licenses/by-sa/3.0/), chyba że zaznaczono inaczej. Zasoby mają określoną licencję i prawa autorskie w pliku z metadanymi. Na przykład zobacz [metadane łomu](https://raw.githubusercontent.com/new-frontiers-14/frontier-station-14/master/Resources/Textures/Objects/Tools/crowbar.rsi/meta.json).  

Zwróć uwagę, że niektóre zasoby są licencjonowane na zasadach niekomercyjnych [CC-BY-NC-SA 3.0](https://creativecommons.org/licenses/by-nc-sa/3.0/) lub podobnych licencji niekomercyjnych i będą musiały zostać usunięte, jeśli chcesz użyć tego projektu komercyjnie.

## Atrybucje

Gdy pobieramy zawartość z innych forków, organizujemy ich zawartość do podfolderów specyficznych dla repozytorium, aby lepiej śledzić atrybucję i ograniczyć konflikty podczas scalania.

Zawartość w tych podkatalogach pochodzi z odpowiednich forków i może zawierać modyfikacje. Te modyfikacje są oznaczane komentarzami wokół zmodyfikowanych linii.

| Podkatalog | Nazwa forka | Repozytorium forka | Licencja |
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

Dodatkowe repozytoria, z których przenieśliśmy funkcje bez podkatalogów, są wymienione poniżej.

| Nazwa forka | Repozytorium forka | Licencja |
|-----------|-----------------|---------|
| Monolith | https://github.com/Monolith-Station/Monolith | AGPL 3.0 |
| Space Station 14 | https://github.com/space-wizards/space-station-14 | MIT |
| White Dream | https://github.com/WWhiteDreamProject/wwdpublic | AGPL 3.0 |

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---