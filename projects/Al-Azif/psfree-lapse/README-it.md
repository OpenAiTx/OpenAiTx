# PSFree versione 1.5.1

PSFree è una raccolta di exploit per la console PS4. Il focus principale del repository è la PS4, ma cerchiamo di rendere le cose portabili anche su PS5.

## Funzionalità

- **Rilevamento automatico:** Rileva automaticamente il tipo di console e la versione del firmware (tramite [`src/config.mjs`](https://raw.githubusercontent.com/Al-Azif/psfree-lapse/main/src/config.mjs)).
- **Exploit WebKit (PSFree):** Punto di ingresso tramite il browser web della console.
- **Exploit Kernel (Lapse):** Eleva i privilegi al livello kernel.
- **Payload Loader:** Dopo un exploit kernel riuscito, ascolta un payload sulla porta 9020.

## Ambito delle vulnerabilità

|               | PSFree    | Lapse      |
| :------------ | :-------- | :--------- |
| PlayStation 4 | 6.00-9.60 | 1.01-12.02 |
| PlayStation 5 | 1.00-5.50 | 1.00-10.01 |

## Supportato da questo repository

Questa tabella indica le versioni del firmware per cui la _versione attuale_ di questo repository offre una catena di exploit funzionale e testata.

|               | PSFree    | Lapse     |
| :------------ | :-------- | :-------- |
| PlayStation 4 | 7.00-9.60 | 7.00-9.60 |
| PlayStation 5 | N/D       | N/D       |

_Nota: Il supporto per altri firmware elencati nella tabella "Ambito delle vulnerabilità" potrebbe essere in lavorazione, non attivamente sviluppato o essere stato supportato in versioni precedenti di questo repository. Si prega di consultare [`CHANGELOG.md`](https://raw.githubusercontent.com/Al-Azif/psfree-lapse/main/CHANGELOG.md) per informazioni sul supporto storico._

## TODO List

- [ ] Problema di schermo nero/salvataggio con alcuni giochi
- [ ] `lapse.mjs`: Impostare solo i bit per i privilegi JIT
- [ ] `view.mjs`: Presuppone PS4, aggiungere supporto PS5
- [ ] Aggiungere supporto PS5

## Copyright e Autori:

AGPL-3.0-o-successiva (vedi [`LICENSE`](https://raw.githubusercontent.com/Al-Azif/psfree-lapse/main/LICENSE)). Questo repository appartiene al gruppo `anonymous`. Ci riferiamo anche ai collaboratori anonimi come "anonymous".

## Crediti:

- anonymous per i dump del kernel del firmware PS4
- Controllare i file appropriati per eventuali **altri** collaboratori. Salvo diversa indicazione, tutto ciò che è qui può essere attribuito anche a noi.

## Donazioni

(Monero/XMR): **86Fk3X9AE94EGKidzRbvyiVgGNYD3qZnuKNq1ZbsomFWXHYm6TtAgz9GNGitPWadkS3Wr9uXoT29U1SfdMtJ7QNKQpW1CVS**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---