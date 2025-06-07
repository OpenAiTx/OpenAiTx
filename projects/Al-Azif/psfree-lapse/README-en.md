# PSFree version 1.5.1

PSFree is a collection of exploits for the PS4 console. The main focus of the repo is for the PS4, but we try to make things portable to PS5.

## Features

- **Auto-detection:** Automatically detects console type and firmware version (via [`src/config.mjs`](https://raw.githubusercontent.com/Al-Azif/psfree-lapse/main/src/config.mjs)).
- **WebKit Exploit (PSFree):** Entry point via the console's web browser.
- **Kernel Exploit (Lapse):** Escalates privileges to kernel level.
- **Payload Loader:** After successful kernel exploitation listens for a payload on port 9020.

## Vulnerability Scope

|               | PSFree    | Lapse      |
| :------------ | :-------- | :--------- |
| PlayStation 4 | 6.00-9.60 | 1.01-12.02 |
| PlayStation 5 | 1.00-5.50 | 1.00-10.01 |

## Supported by this Repository

This table indicates firmware versions for which the _current version_ of this repository provides a functional and tested exploit chain.

|               | PSFree    | Lapse     |
| :------------ | :-------- | :-------- |
| PlayStation 4 | 7.00-9.60 | 7.00-9.60 |
| PlayStation 5 | N/A       | N/A       |

_Note: Support for other firmwares listed in the "Vulnerability Scope" table may, or may not, be actively being worked on or may have been supported in previous versions of this repository. Please check [`CHANGELOG.md`](https://raw.githubusercontent.com/Al-Azif/psfree-lapse/main/CHANGELOG.md) for historical support._

## TODO List

- [ ] Blackscreen/Save issue with certain games
- [ ] [`lapse.mjs`](https://raw.githubusercontent.com/Al-Azif/psfree-lapse/main/lapse.mjs): Just set the bits for JIT privs
- [ ] [`view.mjs`](https://raw.githubusercontent.com/Al-Azif/psfree-lapse/main/view.mjs): Assumes PS4, support PS5 as well
- [ ] Add PS5 support

## Copyright and Authors:

AGPL-3.0-or-later (see [`LICENSE`](https://raw.githubusercontent.com/Al-Azif/psfree-lapse/main/LICENSE)). This repo belongs to the group `anonymous`. We refer to anonymous contributors as "anonymous" as well.

## Credits:

- anonymous for PS4 firmware kernel dumps
- Check the appropriate files for any **extra** contributors. Unless otherwise stated, everything here can also be credited to us.

## Donations

(Monero/XMR): **86Fk3X9AE94EGKidzRbvyiVgGNYD3qZnuKNq1ZbsomFWXHYm6TtAgz9GNGitPWadkS3Wr9uXoT29U1SfdMtJ7QNKQpW1CVS**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---