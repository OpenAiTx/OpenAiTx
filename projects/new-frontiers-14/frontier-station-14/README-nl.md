<div class="header" align="center">
<img alt="Frontier Station" height="300" src="https://github.com/new-frontiers-14/frontier-station-14/blob/master/Resources/Textures/_NF/Logo/logo.png?raw=true" />
</div>

Frontier Station is een fork van [Space Station 14](https://github.com/space-wizards/space-station-14) die draait op de [Robust Toolbox](https://github.com/space-wizards/RobustToolbox) engine, geschreven in C#.

Dit is de hoofdrepository voor Frontier Station.

Als je Frontier Station wilt hosten of content wilt maken, heb je deze repo nodig. Het bevat zowel RobustToolbox als het contentpack voor de ontwikkeling van nieuwe contentpacks.

## Links

<div class="header" align="center">  
[Discord](https://discord.gg/tpuAT7d3zm/) | [Steam](https://store.steampowered.com/app/1255460/Space_Station_14/) | [Patreon](https://www.patreon.com/frontierstation14) | [Wiki](https://frontierstation.wiki.gg/)
</div>

## Documentatie/Wiki

Onze [wiki](https://frontierstation.wiki.gg/) bevat documentatie over de inhoud van Frontier Station.

## Bijdragen

We accepteren graag bijdragen van iedereen. Kom op Discord als je wilt helpen. We hebben een [lijst met ideeën](https://discord.com/channels/1123826877245694004/1127017858833068114) die gedaan kunnen worden en die iedereen kan oppakken. Wees ook niet bang om hulp te vragen!

We accepteren momenteel geen vertalingen van het spel in onze hoofdrepository. Als je het spel naar een andere taal wilt vertalen, overweeg dan om een fork te maken of bij te dragen aan een fork.

Als je bijdragen levert, lees dan zeker het gedeelte over markers in [MARKERS.md](https://github.com/new-frontiers-14/frontier-station-14/blob/master/MARKERS.md).
Alle wijzigingen aan bestanden die behoren tot onze upstream moeten goed gemarkeerd worden volgens de daar gespecificeerde richtlijnen.

## Bouwen

1. Clone deze repo:
```shell
git clone https://github.com/new-frontiers-14/frontier-station-14.git
```
2. Ga naar de projectmap en voer `RUN_THIS.py` uit om de submodules te initialiseren en de engine te laden:
```shell
cd frontier-station-14
python RUN_THIS.py
```
3. Compileer de oplossing:  

Bouw de server met `dotnet build`.

[Meer gedetailleerde instructies voor het bouwen van het project.](https://docs.spacestation14.com/en/general-development/setup.html)

## Licentie

Content die aan deze repository is toegevoegd na commit 2fca06eaba205ae6fe3aceb8ae2a0594f0effee0 valt onder de GNU Affero General Public License versie 3.0, tenzij anders vermeld (let op de Attributies hieronder). Zie `LICENSE-AGPLv3.txt`.
Content die aan deze repository is toegevoegd vóór commit 2fca06eaba205ae6fe3aceb8ae2a0594f0effee0 valt onder de MIT-licentie, tenzij anders vermeld. Zie `LICENSE-MIT.txt`.

[2fca06eaba205ae6fe3aceb8ae2a0594f0effee0](https://github.com/new-frontiers-14/frontier-station-14/commit/2fca06eaba205ae6fe3aceb8ae2a0594f0effee0) werd gepusht op 1 juli 2024 om 16:04 UTC

De meeste assets zijn gelicentieerd onder [CC-BY-SA 3.0](https://creativecommons.org/licenses/by-sa/3.0/) tenzij anders vermeld. Assets hebben hun licentie en copyright gespecificeerd in het metadata-bestand. Zie bijvoorbeeld de [metadata voor een koevoet](https://raw.githubusercontent.com/new-frontiers-14/frontier-station-14/master/Resources/Textures/Objects/Tools/crowbar.rsi/meta.json).  

Let op dat sommige assets zijn gelicentieerd onder de niet-commerciële [CC-BY-NC-SA 3.0](https://creativecommons.org/licenses/by-nc-sa/3.0/) of vergelijkbare niet-commerciële licenties en verwijderd moeten worden als je dit project commercieel wilt gebruiken.

## Attributies

Wanneer we content van andere forks overnemen, organiseren we hun content in repo-specifieke submappen om attributie beter bij te houden en mergeconflicten te beperken.

Content onder deze submappen is afkomstig van de betreffende forks en kan wijzigingen bevatten. Deze wijzigingen worden aangeduid met opmerkingen rond de aangepaste regels.

| Subdirectory | Forknaam | Fork Repository | Licentie |
|--------------|----------|----------------|----------|
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

Extra repositories waarvan we features hebben geport zonder subdirectories zijn hieronder vermeld.

| Forknaam | Fork Repository | Licentie |
|----------|----------------|----------|
| Monolith | https://github.com/Monolith-Station/Monolith | AGPL 3.0 |
| Space Station 14 | https://github.com/space-wizards/space-station-14 | MIT |
| White Dream | https://github.com/WWhiteDreamProject/wwdpublic | AGPL 3.0 |

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---