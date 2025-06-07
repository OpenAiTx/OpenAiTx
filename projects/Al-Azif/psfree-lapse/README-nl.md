# PSFree versie 1.5.1

PSFree is een verzameling exploits voor de PS4-console. De hoofd­focus van deze repo ligt op de PS4, maar we proberen dingen ook overdraagbaar te maken naar de PS5.

## Functies

- **Automatische detectie:** Detecteert automatisch het type console en de firmwareversie (via [`src/config.mjs`](https://raw.githubusercontent.com/Al-Azif/psfree-lapse/main/src/config.mjs)).
- **WebKit Exploit (PSFree):** Instappunt via de webbrowser van de console.
- **Kernel Exploit (Lapse):** Escaleert rechten naar kernel-niveau.
- **Payload Loader:** Na succesvolle kernel-exploitatie luistert deze op poort 9020 voor een payload.

## Kwetsbaarheidsbereik

|               | PSFree    | Lapse      |
| :------------ | :-------- | :--------- |
| PlayStation 4 | 6.00-9.60 | 1.01-12.02 |
| PlayStation 5 | 1.00-5.50 | 1.00-10.01 |

## Ondersteund door deze repository

Deze tabel geeft aan voor welke firmwareversies de _huidige versie_ van deze repository een functionele en geteste exploit-keten biedt.

|               | PSFree    | Lapse     |
| :------------ | :-------- | :-------- |
| PlayStation 4 | 7.00-9.60 | 7.00-9.60 |
| PlayStation 5 | N/B       | N/B       |

_Noot: Ondersteuning voor andere firmwares vermeld in de tabel "Kwetsbaarheidsbereik" kan mogelijk in ontwikkeling zijn, of was ondersteund in eerdere versies van deze repository. Raadpleeg [`CHANGELOG.md`](https://raw.githubusercontent.com/Al-Azif/psfree-lapse/main/CHANGELOG.md) voor historische ondersteuning._

## TODO-lijst

- [ ] Zwart scherm/opslaan probleem bij bepaalde spellen
- [ ] `lapse.mjs`: Zet alleen de bits voor JIT-rechten
- [ ] `view.mjs`: Gaat uit van PS4, voeg PS5-ondersteuning toe
- [ ] Voeg PS5-ondersteuning toe

## Copyright en auteurs:

AGPL-3.0-or-later (zie [`LICENSE`](https://raw.githubusercontent.com/Al-Azif/psfree-lapse/main/LICENSE)). Deze repo behoort tot de groep `anonymous`. We verwijzen naar anonieme bijdragers ook als "anonymous".

## Credits:

- anonymous voor PS4 firmware kernel dumps
- Controleer de betreffende bestanden voor eventuele **extra** bijdragers. Tenzij anders vermeld, kan alles hier ook aan ons worden toegeschreven.

## Donaties

(Monero/XMR): **86Fk3X9AE94EGKidzRbvyiVgGNYD3qZnuKNq1ZbsomFWXHYm6TtAgz9GNGitPWadkS3Wr9uXoT29U1SfdMtJ7QNKQpW1CVS**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---