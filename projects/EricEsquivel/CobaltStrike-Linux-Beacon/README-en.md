# Cobalt Strike Linux Beacon

A proof-of-concept custom Linux Beacon written in C that communicates with the Cobalt Strike teamserver using the HTTP/S protocol.

The goal of this project isn't to be a fully featured implant, nor is it limited to just Linux. It is to show that it is possible to make custom implants for Cobalt Strike for any platform. The only requirement is communicating with the teamserver correctly.

With custom implants you can define custom behavior, add new features, support different platforms and file types, apply obfuscation at compile time, and more. The possibilities are endless.

Hopefully one day Cobalt Strike will officially support developing custom Beacons by adding more documentation and quality of life features.


## Features
- HTTP/S listener support (default C2 profile)
- Contains some built-in commands: `sleep`, `cd`, `pwd`, `shell`, `ls`, `exit`, `upload`, `download`
- Linux BOF execution using TrustedSec's ELFLoader. Supports both TrustedSec & Outflank BOFs
- SOCKS proxy

## Demo
Generating payloads with the Aggressor Script
![Linux Beacon Payload Generation](https://raw.githubusercontent.com/EricEsquivel/CobaltStrike-Linux-Beacon/main/demo/generate_payloads.gif)

Running commands & BOFs in the Linux Beacon
![Linux Beacon Commands Demo](https://raw.githubusercontent.com/EricEsquivel/CobaltStrike-Linux-Beacon/main/demo/commands.gif)

## Setup
You can view the setup steps in the [SETUP](https://raw.githubusercontent.com/EricEsquivel/CobaltStrike-Linux-Beacon/main/SETUP.md) file.

## Special Thanks
Thank you to [Kyle Avery](https://x.com/kyleavery) for your help with integrating BOF execution and testing out the implant.

## Future goals
* Add support for custom C2 profiles
* Add TCP listener + connect functionality
* Continue fixing bugs

## Resources
- Cobalt Strike (wow!)
- [TrustedSec's ELFLoader & BOFs](https://github.com/trustedsec/ELFLoader)
- [Outflank's BOFs](https://github.com/outflanknl/nix_bof_template)
- [PaloAltoNetworks Unit42](https://unit42.paloaltonetworks.com/cobalt-strike-metadata-encryption-decryption/)
- [SANS ISC](https://isc.sans.edu/diary/27968)
- [cs-decrypt-metadata-py](https://blog.didierstevens.com/2021/10/22/new-tool-cs-decrypt-metadata-py/)
- [SentinelOne CobaltStrikeParser](https://github.com/Sentinel-One/CobaltStrikeParser)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-27

---