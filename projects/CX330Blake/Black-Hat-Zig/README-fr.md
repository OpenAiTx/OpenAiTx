# Black-Hat-Zig

<p align="center">
  <img alt="GitHub License" src="https://img.shields.io/github/license/CX330Blake/black-hat-zig">
  <img alt="GitHub top language" src="https://img.shields.io/github/languages/top/cx330blake/black-hat-zig">
  <img alt="GitHub repo size" src="https://img.shields.io/github/repo-size/cx330blake/black-hat-zig">
  <img alt="X (formerly Twitter) Follow" src="https://img.shields.io/twitter/follow/CX330Blake">
</p>

<p height="350px" align="center">
  <img src="https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Black-Hat-Zig.png">
  <br/>
  <b>Bonjour hackers. Bonjour maldevs. Bonjour reversers. Ravi de vous voir ici pour explorer le pouvoir obscur de Zig !</b><br/><br/>
  <b>Maintenu et géré par <a href="https://github.com/cx330blake">@CX330Blake</a></b>
</p>

---

## ToC

- [Intro](#intro)
- [Pourquoi Zig ?](#pourquoi-zig)
- [Compilation des codes](#compilation-des-codes)
- [Placement du payload](#placement-du-payload)
- [Obfuscation du payload](#obfuscation-du-payload)
- [Chiffrement du payload](#chiffrement-du-payload)
- [Exécution du payload](#exécution-du-payload)
- [Reverse Shell](#reverse-shell)
- [Techniques de malware](#techniques-de-malware)
- [Outils Maldev](#outils-maldev)
- [Contributeurs](#contributeurs)
- [Crédits & Références](#crédits--références)
- [Historique des étoiles](#historique-des-étoiles)
- [Avertissement](#avertissement)

## Intro

> [!IMPORTANT]
> Ce projet est continuellement mis à jour !

Ce projet propose de nombreuses implémentations de techniques de malware utilisant Zig, car j'en suis un grand fan. Vous pouvez utiliser ce dépôt pour armer Zig. Black-Hat-Zig est continuellement mis à jour afin de contenir autant de contenu que possible. Ce serait parfait si vous souhaitez créer une PR pour ce projet.

Ok, hackons la planète !

## Pourquoi Zig ?

- 🤝 Facile d'interagir avec du code source C/C++
- 🔎 C'est récent, donc plus difficile à détecter
- 💪 Contrôle bas niveau puissant, même inférieur à C
- 😱 Plus difficile à rétroconcevoir à cause du compilateur moderne
- 🛡️ Dépendances d'exécution minimales - Pas d'empreinte massive de bibliothèque standard
- 🎯 Aucun comportement indéfini - Gestion explicite des cas limites pour éviter les plantages

## Compilation des codes

Vous pouvez consulter les codes dans chaque répertoire. De plus, si le code utilise l'API Windows, vous verrez l'indication dans le fichier `README.md` du projet concerné, par exemple, [celui-ci](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/bcrypt_aes/).

J'ai déjà défini la cible de compilation par défaut sur `windows-x86_64` pour ceux nécessitant l'API Windows, vous pouvez donc simplement copier & coller la commande suivante pour compiler le code, que vous soyez sur Linux, Windows, ou même MacOS ! (Mais vous avez toujours besoin d'un environnement Windows pour exécuter les exécutables)

```bash
zig build
```

## Placement du payload

Techniques pour placer des payloads malveillants dans différentes sections d'un fichier exécutable.

- [.data Section](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_data_section/)
- [.rdata Section](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_rdata_section/)
- [.text Section](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_text_section/)
- [.rsrc Section](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_rsrc_section/)

## Obfuscation du payload

Techniques d'obfuscation pour dissimuler les payloads et éviter la détection par analyse statique ou correspondance de motifs.

- [Obfuscation d'adresse IP](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/)
  - [Obfuscation IPv4](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv4_obfuscation/)
  - [Déobfuscation IPv4](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv4_deobfuscation/)
  - [Obfuscation IPv6](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv6_obfuscation/)
  - [Déobfuscation IPv6](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv6_deobfuscation/)
- [Obfuscation d'adresse MAC](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/MAC-Address-Obfuscation/)
  - [Obfuscation d'adresse MAC](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/MAC-Address-Obfuscation/MACFuscation/)
  - [Déobfuscation d'adresse MAC](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/MAC-Address-Obfuscation/MACDeobfuscation/)
- [Obfuscation UUID](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/UUID-Obfuscation/)
  - [Obfuscation UUID](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/UUID-Obfuscation/UUIDFuscation/)
  - [Déobfuscation UUID](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/UUID-Obfuscation/UUIDDeobfuscation/)

## Chiffrement du payload

Divers schémas de chiffrement utilisés pour masquer l'objectif réel d'un payload lors du stockage ou de la transmission.

- [Chiffrement XOR](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/XOR/)
  - [XOR avec la bibliothèque standard](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/XOR/std_lib_xor/)
- [Chiffrement RC4](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/RC4/)
  - [RC4 avec SystemFunction032](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/RC4/system_function_032_rc4/)
- [Chiffrement AES](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/)
  - [AES avec Bcrypt.h](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/bcrypt_aes/)
  - [AES avec la bibliothèque standard](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/std_aes/)
  - [AES avec TinyAES](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/tiny_aes/)

## Exécution du payload

- [DLL](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Execution/dll/)
- [Shellcode](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Execution/shellcode/)

## Reverse Shell

Primitives pour établir des reverse shells pour l'accès C2 ou le contrôle post-exploitation.

- [Reverse shell avec la bibliothèque standard](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Reverse-Shell/std_reverse_shell/)

## Techniques de malware

Une collection de techniques offensives courantes adaptées à Zig.

- [Injection de processus](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Injection/)
  - [Injection de DLL](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Injection/dll_injection/)
  - [Injection de shellcode](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Injection/shellcode_injection/)
- [Staging de payload](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Payload-Staging/)
  - [Depuis un serveur web](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Payload-Staging/web_server/)
  - [Depuis le registre Windows](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Payload-Staging/windows_registry/)
- [Énumération des processus](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/)
  - [Avec CreateToolhelp32Snapshot](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/create_tool_help_32_snapshot/)
  - [Avec EnumProcesses](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/enum_processes/)
  - [Avec NtQuerySystemInformation](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/nt_query_system_information/)

## Outils Maldev

- [ZYRA : Votre protection à l'exécution](https://github.com/cx330blake/zyra)
  - Un packer exécutable écrit en Zig
- [ZYPE : Votre chiffreur de payload](https://github.com/cx330blake/zype)
  - Générez un modèle de code en Zig contenant votre payload chiffré/obfusqué et la fonction correspondante de déchiffrement/déobfuscation.

## Contributeurs

Ce projet est principalement maintenu & géré par [@CX330Blake](https://github.com/CX330Blake). Les PR sont les bienvenues. J'espère que plus de personnes utiliseront Zig pour le développement de malware afin que l'écosystème devienne plus mature.

Un grand merci à ces contributeurs !

<a href="https://github.com/CX330Blake/black-hat-zig/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=CX330Blake/black-hat-zig" />
</a>

## Crédits & Références

- [Maldev Academy](https://maldevacademy.com/)
- [OffensiveNim](https://github.com/byt3bl33d3r/OffensiveNim)

## Historique des étoiles

[![Star History Chart](https://api.star-history.com/svg?repos=CX330blake/black-hat-zig&type=Date)](https://www.star-history.com/#CX330blake/black-hat-zig&Date)

## Avertissement

Ce projet est uniquement à des fins éthiques et éducatives. Ne soyez pas un cybercriminel.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---