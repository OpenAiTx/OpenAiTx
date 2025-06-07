<div class="header" align="center">
<img alt="Frontier Station" height="300" src="https://github.com/new-frontiers-14/frontier-station-14/blob/master/Resources/Textures/_NF/Logo/logo.png?raw=true" />
</div>

Frontier Station è un fork di [Space Station 14](https://github.com/space-wizards/space-station-14) che funziona sul motore [Robust Toolbox](https://github.com/space-wizards/RobustToolbox) scritto in C#.

Questo è il repository principale di Frontier Station.

Se vuoi ospitare o creare contenuti per Frontier Station, questo è il repository di cui hai bisogno. Contiene sia RobustToolbox che il content pack per lo sviluppo di nuovi content pack.

## Link

<div class="header" align="center">  
[Discord](https://discord.gg/tpuAT7d3zm/) | [Steam](https://store.steampowered.com/app/1255460/Space_Station_14/) | [Patreon](https://www.patreon.com/frontierstation14) | [Wiki](https://frontierstation.wiki.gg/)
</div>

## Documentazione/Wiki

La nostra [wiki](https://frontierstation.wiki.gg/) contiene la documentazione sui contenuti di Frontier Station.

## Contribuire

Siamo felici di accettare contributi da chiunque. Unisciti al Discord se vuoi aiutare. Abbiamo una [lista di idee](https://discord.com/channels/1123826877245694004/1127017858833068114) che possono essere realizzate e chiunque può occuparsene. Non aver paura di chiedere aiuto!

Attualmente non accettiamo traduzioni del gioco nel nostro repository principale. Se desideri tradurre il gioco in un'altra lingua, considera la creazione di un fork o il contributo a un fork.

Se apporti modifiche, assicurati di leggere la sezione marker in [MARKERS.md](https://github.com/new-frontiers-14/frontier-station-14/blob/master/MARKERS.md)
Qualsiasi modifica ai file appartenenti al nostro upstream deve essere adeguatamente segnalata in conformità a quanto specificato lì.

## Compilazione

1. Clona questo repository:
```shell
git clone https://github.com/new-frontiers-14/frontier-station-14.git
```
2. Vai nella cartella del progetto ed esegui `RUN_THIS.py` per inizializzare i submoduli e caricare il motore:
```shell
cd frontier-station-14
python RUN_THIS.py
```
3. Compila la soluzione:

Compila il server usando `dotnet build`.

[Maggiori istruzioni dettagliate sulla compilazione del progetto.](https://docs.spacestation14.com/en/general-development/setup.html)

## Licenza

I contenuti contribuiti a questo repository dopo il commit 2fca06eaba205ae6fe3aceb8ae2a0594f0effee0 sono rilasciati sotto licenza GNU Affero General Public License versione 3.0, salvo diversa indicazione (vedi Attribuzioni di seguito). Vedi `LICENSE-AGPLv3.txt`.
I contenuti contribuiti a questo repository prima del commit 2fca06eaba205ae6fe3aceb8ae2a0594f0effee0 sono rilasciati sotto licenza MIT, salvo diversa indicazione. Vedi `LICENSE-MIT.txt`.

[2fca06eaba205ae6fe3aceb8ae2a0594f0effee0](https://github.com/new-frontiers-14/frontier-station-14/commit/2fca06eaba205ae6fe3aceb8ae2a0594f0effee0) è stato caricato il 1 luglio 2024 alle 16:04 UTC

La maggior parte delle risorse sono rilasciate sotto licenza [CC-BY-SA 3.0](https://creativecommons.org/licenses/by-sa/3.0/) salvo diversa indicazione. Le risorse riportano la loro licenza e il copyright nel file dei metadati. Ad esempio, vedi i [metadati per un piede di porco](https://github.com/new-frontiers-14/frontier-station-14/blob/master/Resources/Textures/Objects/Tools/crowbar.rsi/meta.json).

Nota che alcune risorse sono rilasciate sotto licenza non commerciale [CC-BY-NC-SA 3.0](https://creativecommons.org/licenses/by-nc-sa/3.0/) o simili licenze non commerciali e dovranno essere rimosse se desideri utilizzare questo progetto a scopo commerciale.

## Attribuzioni

Quando importiamo contenuti da altri fork, organizziamo i loro contenuti in sottocartelle specifiche del repository per tracciare meglio le attribuzioni e limitare i conflitti di merge.

I contenuti in queste sottodirectory provengono dai rispettivi fork e possono contenere modifiche. Queste modifiche sono segnalate tramite commenti attorno alle righe modificate.

| Sottodirectory | Nome Fork | Repository Fork | Licenza |
|----------------|-----------|-----------------|---------|
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

Ulteriori repository da cui abbiamo portato funzionalità senza sottodirectory sono elencati di seguito.

| Nome Fork | Repository Fork | Licenza |
|-----------|-----------------|---------|
| Monolith | https://github.com/Monolith-Station/Monolith | AGPL 3.0 |
| Space Station 14 | https://github.com/space-wizards/space-station-14 | MIT |
| White Dream | https://github.com/WWhiteDreamProject/wwdpublic | AGPL 3.0 |

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---