# PSFree Version 1.5.1

PSFree ist eine Sammlung von Exploits für die PS4-Konsole. Der Hauptfokus des Repos liegt auf der PS4, aber wir versuchen, die Funktionen auch auf die PS5 portierbar zu machen.

## Funktionen

- **Auto-Erkennung:** Erkennt automatisch den Konsolentyp und die Firmware-Version (über [`src/config.mjs`](https://raw.githubusercontent.com/Al-Azif/psfree-lapse/main/src/config.mjs)).
- **WebKit-Exploit (PSFree):** Einstiegspunkt über den Webbrowser der Konsole.
- **Kernel-Exploit (Lapse):** Erhöht die Privilegien auf Kernel-Ebene.
- **Payload Loader:** Nach erfolgreichem Kernel-Exploit wird auf Port 9020 auf ein Payload gewartet.

## Verwundbarkeitsbereich

|               | PSFree    | Lapse      |
| :------------ | :-------- | :--------- |
| PlayStation 4 | 6.00-9.60 | 1.01-12.02 |
| PlayStation 5 | 1.00-5.50 | 1.00-10.01 |

## Von diesem Repository unterstützt

Diese Tabelle zeigt die Firmware-Versionen, für die die _aktuelle Version_ dieses Repositories eine funktionierende und getestete Exploit-Kette bereitstellt.

|               | PSFree    | Lapse     |
| :------------ | :-------- | :-------- |
| PlayStation 4 | 7.00-9.60 | 7.00-9.60 |
| PlayStation 5 | N/V       | N/V       |

_Hinweis: Die Unterstützung für andere Firmware-Versionen, die in der Tabelle „Verwundbarkeitsbereich“ aufgeführt sind, wird möglicherweise noch entwickelt oder wurde in früheren Versionen dieses Repositories bereits unterstützt. Bitte prüfen Sie die [`CHANGELOG.md`](https://raw.githubusercontent.com/Al-Azif/psfree-lapse/main/CHANGELOG.md) für eine Übersicht der bisherigen Unterstützung._

## TODO-Liste

- [ ] Blackscreen/Speicherproblem bei bestimmten Spielen
- [ ] `lapse.mjs`: Nur die Bits für JIT-Privilegien setzen
- [ ] `view.mjs`: Geht von PS4 aus, auch PS5 unterstützen
- [ ] PS5-Unterstützung hinzufügen

## Urheberrecht und Autoren:

AGPL-3.0-or-later (siehe [`LICENSE`](https://raw.githubusercontent.com/Al-Azif/psfree-lapse/main/LICENSE)). Dieses Repository gehört der Gruppe `anonymous`. Anonyme Mitwirkende werden ebenfalls als "anonymous" bezeichnet.

## Danksagungen:

- anonymous für PS4-Firmware-Kernel-Dumps
- Weitere Mitwirkende finden Sie in den jeweiligen Dateien. Sofern nicht anders angegeben, kann alles hier ebenfalls uns zugeschrieben werden.

## Spenden

(Monero/XMR): **86Fk3X9AE94EGKidzRbvyiVgGNYD3qZnuKNq1ZbsomFWXHYm6TtAgz9GNGitPWadkS3Wr9uXoT29U1SfdMtJ7QNKQpW1CVS**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---