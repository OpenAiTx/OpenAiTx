# PSFree versión 1.5.1

PSFree es una colección de exploits para la consola PS4. El enfoque principal del repositorio es para la PS4, pero intentamos hacer que las cosas sean portables a la PS5.

## Características

- **Detección automática:** Detecta automáticamente el tipo de consola y la versión del firmware (a través de [`src/config.mjs`](https://raw.githubusercontent.com/Al-Azif/psfree-lapse/main/src/config.mjs)).
- **Exploit WebKit (PSFree):** Punto de entrada a través del navegador web de la consola.
- **Exploit de Kernel (Lapse):** Escala privilegios al nivel de kernel.
- **Cargador de Payload:** Tras la explotación exitosa del kernel, escucha un payload en el puerto 9020.

## Alcance de Vulnerabilidad

|               | PSFree    | Lapse      |
| :------------ | :-------- | :--------- |
| PlayStation 4 | 6.00-9.60 | 1.01-12.02 |
| PlayStation 5 | 1.00-5.50 | 1.00-10.01 |

## Soportado por este Repositorio

Esta tabla indica las versiones de firmware para las cuales la _versión actual_ de este repositorio proporciona una cadena de exploits funcional y probada.

|               | PSFree    | Lapse     |
| :------------ | :-------- | :-------- |
| PlayStation 4 | 7.00-9.60 | 7.00-9.60 |
| PlayStation 5 | N/A       | N/A       |

_Nota: El soporte para otros firmwares listados en la tabla "Alcance de Vulnerabilidad" puede, o no, estar siendo trabajado activamente o puede haber sido soportado en versiones previas de este repositorio. Por favor, revisa [`CHANGELOG.md`](https://raw.githubusercontent.com/Al-Azif/psfree-lapse/main/CHANGELOG.md) para soporte histórico._

## Lista de Tareas Pendientes

- [ ] Problema de pantalla negra/guardado con ciertos juegos
- [ ] `lapse.mjs`: Solo establecer los bits para privilegios JIT
- [ ] `view.mjs`: Asume PS4, también soportar PS5
- [ ] Añadir soporte para PS5

## Copyright y Autores:

AGPL-3.0-o-posterior (ver [LICENSE](https://raw.githubusercontent.com/Al-Azif/psfree-lapse/main/LICENSE)). Este repositorio pertenece al grupo `anonymous`. Nos referimos a los contribuyentes anónimos como "anonymous" también.

## Créditos:

- anonymous por los volcados de kernel de firmware de PS4
- Revisa los archivos correspondientes para cualquier contribuyente **extra**. A menos que se indique lo contrario, todo aquí también puede ser acreditado a nosotros.

## Donaciones

(Monero/XMR): **86Fk3X9AE94EGKidzRbvyiVgGNYD3qZnuKNq1ZbsomFWXHYm6TtAgz9GNGitPWadkS3Wr9uXoT29U1SfdMtJ7QNKQpW1CVS**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---