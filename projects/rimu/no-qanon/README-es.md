# No-QAnon

Una lista de bloqueo de dominios antifascista de QAnon, conspiraciones, noticias falsas, sitios web de extrema derecha y discriminatorios.

Al bloquear los sitios web vinculados a grupos de odio y actores malintencionados, busca desactivar el reclutamiento, la propaganda y ralentizar la difusión de desinformación mediante tácticas como operaciones psicológicas, astroturfing, trolls, falsas banderas, sockpuppeting, terrorismo estocástico, FUD.

Una lista de bloqueo de dominios solo bloquea sitios web completos: desafortunadamente no puede bloquear nada en redes sociales donde a menudo ocurre la radicalización.
Aún así, definitivamente reducirá la exposición a información falsa y dañina.
Los fascistas se aprovechan de los vulnerables, así que mantente vigilante y considera también usar una lista de bloqueo para redes sociales si es necesario.

Distribuido bajo la [licencia antifascista](https://github.com/rimu/no-qanon/blob/master/LICENSE.txt).

## Formato Hosts

[Lista de bloqueo en formato Hosts](https://raw.githubusercontent.com/rimu/no-qanon/master/hosts.txt) para usar en un archivo [hosts](https://es.wikipedia.org/wiki/Hosts_(inform%C3%A1tica)) o PiHole.

[Versión IPV6](https://raw.githubusercontent.com/rimu/no-qanon/master/hosts.txt.ipv6).

- [Instrucciones para instalar en un equipo Windows.](https://github.com/yui-konnu/qanon-block-guide)

- [Instrucciones para instalar en un PiHole.](https://www.reddit.com/r/QAnonCasualties/comments/wekhem/how_to_use_pihole_to_block_q_related_websites/)

Problema conocido: la opción DNS sobre HTTPS de Firefox elude las reglas del archivo hosts del equipo. https://bugzilla.mozilla.org/show_bug.cgi?id=1453207

## Formato Dnsmasq

[Lista de bloqueo en formato Dnsmasq](https://raw.githubusercontent.com/rimu/no-qanon/master/dnsmasq.txt) para usar con el software servidor DNS [Dnsmasq](https://thekelleys.org.uk/dnsmasq/doc.html).

## Extensiones para navegador

### Formato Netsane

[Lista de bloqueo en formato Netsane](https://raw.githubusercontent.com/rimu/no-qanon/master/netsane.txt) para usar con el software [Netsane](https://github.com/rimu/netsane).

### Sintaxis AdBlock Plus

[Lista de bloqueo en formato AdBlock](https://raw.githubusercontent.com/rimu/no-qanon/master/adblock.txt) para usar con un bloqueador de anuncios ([uBlock Origin](https://ublockorigin.com), [Adguard](https://adguard.com)…) o Adguard Home. Usa una [regla de bloqueo estricta](https://github.com/gorhill/uBlock/wiki/Strict-blocking) para bloquear el acceso a esos sitios en tu navegador.

[Haz clic aquí para suscribirte.](https://subscribe.adblockplus.org/?location=https://raw.githubusercontent.com/rimu/no-qanon/master/adblock.txt&title=No-QAnon)

### Sintaxis de uBlacklist

[Lista de bloqueo en formato uBlacklist](https://raw.githubusercontent.com/rimu/no-qanon/master/ublacklist.txt) para usar con [uBlacklist](https://github.com/iorate/ublacklist). Elimina sitios bloqueados de los resultados de motores de búsqueda.

[Haz clic aquí para suscribirte.](https://iorate.github.io/ublacklist/subscribe?name=No-QAnon&url=https://raw.githubusercontent.com/rimu/no-qanon/master/ublacklist.txt) (¡Este enlace de suscripción automática solo es compatible con Chrome, en otros navegadores debes añadirlo tú mismo!)

### Lista de dominios

[Formato de lista de dominios](https://raw.githubusercontent.com/rimu/no-qanon/master/domains.txt) para usar con [Search Engine Spam Blocker](https://github.com/no-cmyk/Search-Engine-Spam-Blocker). Elimina sitios bloqueados de los resultados de motores de búsqueda.

## Cómo contribuir

Clona este repositorio y agrega nuevos dominios en los archivos `.txt` correspondientes dentro de la carpeta `sources`. Si no quieres categorizar, solo ponlo en el archivo `sources/default.txt` y será bloqueado.

> Para el sitio `https://www.example.com`, añade `example.com` en el archivo `sources/default.txt`.

Luego, cuando hagas push de tus cambios en la carpeta `sources`, las acciones de GitHub deberían activarse y generar automáticamente nuevas versiones de las listas de bloqueo. Si quieres generarlas tú mismo, puedes ejecutar el script `scripts/update.sh` (requisitos: bash, python).

Finalmente, crea una pull request: la revisaremos y aprobaremos en unos días.

### Categorización

Los sitios bloqueados se organizan usando subcarpetas y archivos `.txt` en la carpeta `sources`. Usa archivos markdown (`.md`) y comentarios (`#`) para añadir más información y referencias.

### Cómo contribuir (modo fácil)

Si no tienes idea de cómo funciona Git, ¡aún puedes contribuir! Solo [abre un issue](https://github.com/rimu/no-qanon/issues) con las URLs que te gustaría añadir a la lista, agrupándolas por idioma y categorías si es posible. Las revisaremos y añadiremos pronto.

## Otras listas útiles

[Listas de bloqueo de Jmdugan](https://github.com/jmdugan/blocklists/tree/master/corporations): considera bloquear Twitter, YouTube y Facebook ya que publican muchas noticias falsas.

[Lista de bloqueo de Antifa-n](https://github.com/antifa-n/pihole/blob/master/blocklist.txt) también es una excelente lista enfocada en sitios fascistas.

[Lista de bloqueo de métodos de bypass](https://github.com/nextdns/metadata/blob/master/parentalcontrol/bypass-methods) puede usarse para bloquear métodos de bypass (VPNs, proxies, DNS, etc.).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-13

---