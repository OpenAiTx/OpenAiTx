# Cobalt Strike Linux Beacon

Un Beacon personalizado para Linux como prueba de concepto, escrito en C que se comunica con el teamserver de Cobalt Strike usando el protocolo HTTP/S.

El objetivo de este proyecto no es ser un implante completamente funcional, ni está limitado solo a Linux. Es para mostrar que es posible crear implantes personalizados para Cobalt Strike en cualquier plataforma. El único requisito es comunicarse correctamente con el teamserver.

Con implantes personalizados puedes definir comportamientos propios, agregar nuevas funciones, soportar diferentes plataformas y tipos de archivos, aplicar ofuscación en tiempo de compilación y más. Las posibilidades son infinitas.

Con suerte, algún día Cobalt Strike soportará oficialmente el desarrollo de Beacons personalizados agregando más documentación y funciones que mejoren la experiencia.


## Características
- Soporte para listener HTTP/S (perfil C2 por defecto)
- Contiene algunos comandos incorporados: `sleep`, `cd`, `pwd`, `shell`, `ls`, `exit`, `upload`, `download`
- Ejecución BOF en Linux usando ELFLoader de TrustedSec. Soporta BOFs tanto de TrustedSec como de Outflank
- Proxy SOCKS

## Demo
Generación de payloads con Aggressor Script
![Generación de Payloads Linux Beacon](https://raw.githubusercontent.com/EricEsquivel/CobaltStrike-Linux-Beacon/main/demo/generate_payloads.gif)

Ejecución de comandos y BOFs en el Linux Beacon
![Demo de Comandos Linux Beacon](https://raw.githubusercontent.com/EricEsquivel/CobaltStrike-Linux-Beacon/main/demo/commands.gif)

## Configuración
Puedes ver los pasos de configuración en el archivo [SETUP](https://raw.githubusercontent.com/EricEsquivel/CobaltStrike-Linux-Beacon/main/SETUP.md).

## Agradecimientos especiales
Gracias a [Kyle Avery](https://x.com/kyleavery) por tu ayuda integrando la ejecución de BOF y probando el implante.

## Metas futuras
* Agregar soporte para perfiles C2 personalizados
* Añadir listener TCP + funcionalidad de conexión
* Continuar corrigiendo errores

## Recursos
- Cobalt Strike (¡wow!)
- [ELFLoader & BOFs de TrustedSec](https://github.com/trustedsec/ELFLoader)
- [BOFs de Outflank](https://github.com/outflanknl/nix_bof_template)
- [PaloAltoNetworks Unit42](https://unit42.paloaltonetworks.com/cobalt-strike-metadata-encryption-decryption/)
- [SANS ISC](https://isc.sans.edu/diary/27968)
- [cs-decrypt-metadata-py](https://blog.didierstevens.com/2021/10/22/new-tool-cs-decrypt-metadata-py/)
- [SentinelOne CobaltStrikeParser](https://github.com/Sentinel-One/CobaltStrikeParser)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-27

---