<div class="header" align="center">
<img alt="Frontier Station" height="300" src="https://github.com/new-frontiers-14/frontier-station-14/blob/master/Resources/Textures/_NF/Logo/logo.png?raw=true" />
</div>

Frontier Station ist ein Fork von [Space Station 14](https://github.com/space-wizards/space-station-14), der auf der [Robust Toolbox](https://github.com/space-wizards/RobustToolbox) Engine basiert und in C# geschrieben ist.

Dies ist das Hauptrepository für Frontier Station.

Wenn du Frontier Station hosten oder Inhalte dafür erstellen möchtest, benötigst du dieses Repository. Es enthält sowohl RobustToolbox als auch das Content-Pack für die Entwicklung neuer Content-Packs.

## Links

<div class="header" align="center">  
[Discord](https://discord.gg/tpuAT7d3zm/) | [Steam](https://store.steampowered.com/app/1255460/Space_Station_14/) | [Patreon](https://www.patreon.com/frontierstation14) | [Wiki](https://frontierstation.wiki.gg/)
</div>

## Dokumentation/Wiki

Unser [Wiki](https://frontierstation.wiki.gg/) enthält Dokumentation zu den Inhalten von Frontier Station.

## Beitrag leisten

Wir freuen uns über Beiträge von jedem. Tritt unserem Discord bei, wenn du helfen möchtest. Wir haben eine [Liste mit Ideen](https://discord.com/channels/1123826877245694004/1127017858833068114), die umgesetzt werden können und die sich jeder aussuchen kann. Scheue dich auch nicht, nach Hilfe zu fragen!

Wir akzeptieren derzeit keine Übersetzungen des Spiels in unserem Hauptrepository. Wenn du das Spiel in eine andere Sprache übersetzen möchtest, erstelle einen Fork oder trage zu einem Fork bei.

Wenn du Beiträge leistest, lies bitte den Abschnitt zu Markern in [MARKERS.md](https://github.com/new-frontiers-14/frontier-station-14/blob/master/MARKERS.md)
Alle Änderungen an Dateien, die zu unserem Upstream gehören, müssen entsprechend den dort angegebenen Vorgaben gekennzeichnet werden.

## Kompilieren

1. Klone dieses Repository:
```shell
git clone https://github.com/new-frontiers-14/frontier-station-14.git
```
2. Wechsle in den Projektordner und führe `RUN_THIS.py` aus, um die Submodule zu initialisieren und die Engine zu laden:
```shell
cd frontier-station-14
python RUN_THIS.py
```
3. Kompiliere die Lösung:  

Baue den Server mit `dotnet build`.

[Ausführlichere Anweisungen zum Kompilieren des Projekts.](https://docs.spacestation14.com/en/general-development/setup.html)

## Lizenz

Alle Inhalte, die nach dem Commit 2fca06eaba205ae6fe3aceb8ae2a0594f0effee0 zu diesem Repository beigetragen wurden, stehen unter der GNU Affero General Public License Version 3.0, sofern nicht anders angegeben (siehe Hinweise zu Attributions unten). Siehe `LICENSE-AGPLv3.txt`.
Alle Inhalte, die vor dem Commit 2fca06eaba205ae6fe3aceb8ae2a0594f0effee0 beigetragen wurden, stehen unter der MIT-Lizenz, sofern nicht anders angegeben. Siehe `LICENSE-MIT.txt`.

[2fca06eaba205ae6fe3aceb8ae2a0594f0effee0](https://github.com/new-frontiers-14/frontier-station-14/commit/2fca06eaba205ae6fe3aceb8ae2a0594f0effee0) wurde am 1. Juli 2024 um 16:04 UTC gepusht.

Die meisten Assets stehen unter der Lizenz [CC-BY-SA 3.0](https://creativecommons.org/licenses/by-sa/3.0/), sofern nicht anders angegeben. Die jeweilige Lizenz und das Copyright der Assets sind in der Metadatei angegeben. Siehe zum Beispiel die [Metadaten für ein Brecheisen](https://raw.githubusercontent.com/new-frontiers-14/frontier-station-14/master/Resources/Textures/Objects/Tools/crowbar.rsi/meta.json).  

Beachte, dass einige Assets unter der nicht-kommerziellen [CC-BY-NC-SA 3.0](https://creativecommons.org/licenses/by-nc-sa/3.0/) oder ähnlichen nicht-kommerziellen Lizenzen stehen und entfernt werden müssen, falls du dieses Projekt kommerziell nutzen möchtest.

## Attributions

Wenn wir Inhalte aus anderen Forks übernehmen, ordnen wir deren Inhalte spezifischen Unterordnern im Repository zu, um die Attribution besser nachzuverfolgen und Merge-Konflikte zu minimieren.

Inhalte in diesen Unterverzeichnissen stammen aus den jeweiligen Forks und können Modifikationen enthalten. Diese Modifikationen sind durch Kommentare um die geänderten Zeilen gekennzeichnet.

| Unterverzeichnis | Fork-Name | Fork-Repository | Lizenz |
|------------------|-----------|-----------------|--------|
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

Weitere Repositories, aus denen wir Features übernommen haben, ohne Unterverzeichnisse zu nutzen, sind unten aufgeführt.

| Fork-Name | Fork-Repository | Lizenz |
|-----------|-----------------|--------|
| Monolith | https://github.com/Monolith-Station/Monolith | AGPL 3.0 |
| Space Station 14 | https://github.com/space-wizards/space-station-14 | MIT |
| White Dream | https://github.com/WWhiteDreamProject/wwdpublic | AGPL 3.0 |


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---