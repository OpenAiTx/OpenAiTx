# ARGOS — Beta
<img align="right" width="86" height="150" src="https://github.com/SOsintOps/Argos/blob/master/multimedia/images/scribblenauts-argos.png">

> **WARNING: BETA VERSION**
> This script has been updated for Ubuntu 24.04 LTS and Ubuntu Budgie 24.04 LTS.
> It is under active testing. Always run it on a clean VM before using it in production.
> Report any problems by opening an issue.

Argos automatically configures an open-source OSINT workstation from a clean Ubuntu 24.04 LTS virtual machine.

Best practice recommends using a dedicated VM for each OSINT investigation.
This script follows the methods described by Michael Bazzell in [Open Source Intelligence Techniques](https://inteltechniques.com/book1.html).

## Contents
- [Requirements](#requirements)
- [Tools](#tools)
- [Installation](#installation)
- [Installation Log](#installation-log)
- [To Do](#to-do)
- [Resources](#resources)
- [Credits](#credits)
- [Licences](#licences)
- [Version History](https://raw.githubusercontent.com/SOsintOps/Argos/master/docs/VERSION_HISTORY.md)
- [OSINT Analysis Guidelines](https://raw.githubusercontent.com/SOsintOps/Argos/master/docs/guidelines.md)
- [FAQ](https://raw.githubusercontent.com/SOsintOps/Argos/master/docs/faq.md)

---

## Requirements

- Ubuntu **24.04 LTS** or **Ubuntu Budgie 24.04 LTS** (VM or workstation)
- Any Linux username (the previous requirement to use `osint` has been removed)
- System language: **English**
- Active internet connection during installation
- **VirtualBox Guest Additions already installed** — the script does not install them. Install Guest Additions before running `setup.sh` to enable clipboard sharing, drag-and-drop, and fullscreen support.

> The script is optimised for VirtualBox. Code for VMware Tools is available in the comments.

**Tested on:**
- Ubuntu Budgie 24.04 LTS (VM)
- Ubuntu 24.04 LTS (VM)

**No longer supported:**
- Ubuntu 22.04 LTS (some dependencies are incompatible)
- Ubuntu 20.04 LTS

---

## Tools

### OSINT

| Tool | Status | Notes |
|------|--------|-------|
| [Amass](https://github.com/owasp-amass/amass) | Active | Subdomain enumeration |
| [Instaloader](https://instaloader.github.io/) | Active | Instagram OSINT |
| [Toutatis](https://github.com/megadose/toutatis) | Limited | Requires Instagram session ID |
| [HTTrack](https://www.httrack.com/) | Active | Web crawling and mirroring |
| [MediaInfo](https://mediaarea.net/en/MediaInfo) | Active | Media metadata analysis |
| [ExifTool](https://exiftool.org/) | Active | Metadata from documents and images |
| [EyeWitness](https://github.com/FortyNorthSecurity/EyeWitness) | Active | Website screenshots |
| [The Harvester](https://github.com/laramies/theHarvester) | Active | Email and domain recon |
| [Metagoofil](https://github.com/opsdisk/metagoofil) | Active | Metadata from public documents |
| [recon-ng](https://github.com/lanmaster53/recon-ng) | Active | Modular OSINT framework |
| [Sherlock](https://github.com/sherlock-project/sherlock) | Active | Username search |
| [SpiderFoot](https://github.com/smicallef/spiderfoot) | Active | OSINT automation |
| [blackbird](https://github.com/p1ngul1n0/blackbird) | Active | Advanced username search |
| [holehe](https://github.com/megadose/holehe) | Active | Email OSINT |
| [maigret](https://github.com/soxoj/maigret) | Active | Username search (advanced Sherlock fork) |
| [Maltego](https://www.maltego.com/) | Active | Link analysis (requires account) |
| [yt-dlp](https://github.com/yt-dlp/yt-dlp) | Active | Video downloader (replaces youtube-dl) |

**Removed tools (abandoned or discontinued):**
- ~~Instalooter~~: use Instaloader
- ~~Sublist3r~~: use Amass
- ~~Photon~~: use Katana or GoSpider
- ~~youtube-dl~~: replaced by yt-dlp
- ~~Moriarty-Project~~: use PhoneInfoga
- ~~Elasticsearch-Crawler~~: use Shodan CLI
- ~~Atom Editor~~ (discontinued December 2022): replaced by VSCodium

### General Tools

| Tool | Status |
|------|--------|
| [VLC](https://www.videolan.org/vlc/) | Active |
| [Google Earth Pro](https://www.google.com/earth/versions/#earth-pro) | Active |
| [VSCodium](https://vscodium.com/) | Active (replaces Atom) |
| [CherryTree](https://www.giuspen.com/cherrytree/) | Active |
| [KeePassXC](https://keepassxc.org/) | Active |
| [Kazam](https://launchpad.net/kazam) | Active |
| [Audacity](https://www.audacityteam.org/) | Active |
| [Tor Browser](https://www.torproject.org/) | Active |
| [OpenShot](https://www.openshot.org/) | Active |
| [Obsidian](https://obsidian.md/) | Active (latest version fetched dynamically) |
| [Ripgrep](https://github.com/BurntSushi/ripgrep) | Active |
| [Threat Intelligence Resources](https://github.com/pstirparo/threatintel-resources) | Active |

---

## Installation

1. Open a terminal.

2. Install Git if it is not already present:
    ```bash
    sudo apt install -y git
    ```

3. Clone the repository into the `Downloads` directory:
    ```bash
    git clone https://github.com/SOsintOps/Argos ~/Downloads/Argos
    ```

4. Make the script executable:
    ```bash
    chmod +x ~/Downloads/Argos/setup.sh
    ```

5. Run the script:
    ```bash
    ~/Downloads/Argos/setup.sh
    ```

    > Firefox does not need to be closed or opened manually. The script initialises the Firefox profile automatically if it has not been created yet.

---

## Installation Log

The script automatically generates a log file in the Downloads directory:

```
~/Downloads/argos_install_YYYYMMDD_HHMMSS.log
```

The log contains the full installation output with timestamps. If an error occurs, the exact line number is recorded in the log.

---

## To Do

- Add PhoneInfoga as a replacement for Moriarty-Project
- Add Katana or GoSpider as a replacement for Photon
- Update LibreOffice report templates for OSINT investigations
- Complete end-to-end testing on Ubuntu Budgie 24.04 LTS VM
- Add shortcuts for holehe, maigret standalone, and blackbird standalone

---

## Resources

- [OSIntOps website](https://osintops.com/en/)
- [Argos project presentation (Italian)](https://osintops.com/progetto-argos/)
- [OSInt Daily News](https://t.me/Osintlatestnews)
- [Open Source Intelligence Techniques by Michael Bazzell](https://inteltechniques.com/book1.html)

---

## Credits

- Skykn0t for the original OSINT_VM_Setup script
- [oh6hay](https://github.com/oh6hay) for the script name
- [pinkevilpimp](https://github.com/pinkevilpimp) for the wallpaper script

---

## Licences

See the licence files included in the repository.
