# notify

[![referencia go.dev](https://img.shields.io/badge/go.dev-reference-007d9c?logo=go&logoColor=white&style=flat-square)](https://pkg.go.dev/github.com/esiqveland/notify?tab=doc)
[![Go Report Card](https://goreportcard.com/badge/github.com/esiqveland/notify)](https://goreportcard.com/report/github.com/esiqveland/notify)
![Build](https://github.com/esiqveland/notify/actions/workflows/go.yml/badge.svg?branch=master)

Notify es una biblioteca de go para interactuar con el servicio de notificaciones dbus definido por freedesktop.org:
https://specifications.freedesktop.org/notification/latest/

`notify` puede enviar notificaciones de escritorio a través de dbus, al estilo de cómo lo hace libnotify.

Tenga en cuenta que `notify` aún está en desarrollo y las APIs no están definitivas hasta que se lance la versión 1.0.

Se agradecen más probadores =)

Depende de:
 - [godbus](https://github.com/godbus/dbus).

## Registro de cambios
- v0.11.2: Introducción de ayudantes ExpireTimeoutSetByNotificationServer, ExpireTimeoutNever
- v0.11.1: Corrección de condición de carrera durante Close() #11
- v0.11.0: relanzamiento bajo licencia BSD
- v0.10.0: tipos más estrictos: [algunos cambios incompatibles](https://github.com/esiqveland/notify/releases/tag/v0.10.0)
- v0.9.0: [algunos cambios incompatibles](https://github.com/esiqveland/notify/releases/tag/v0.9.0)
- v0.2.1: dbus: gomod: bloqueo a dbus v5
- v0.2.0: `Notifier.Close()` ya no llama a `.Close()` en la `dbus.Conn` subyacente

## Introducción rápida
Vea el ejemplo: [main.go](https://github.com/esiqveland/notify/blob/master/example/main.go).

Clone el repositorio y vaya a la carpeta de ejemplos:

``` go run main.go ```


## PENDIENTE

- [x] Añadir soporte para callbacks, es decir, señales dbus.
- [ ] Pruebas. Estoy muy interesado en cualquier idea para escribir algunas pruebas (útiles) para esto.

## Véase también

La especificación de notificaciones de Gnome https://developer.gnome.org/notification-spec/.


## Colaboradores
Gracias al usuario [emersion](https://github.com/emersion) por las excelentes ideas sobre la recepción de señales.

Gracias a [Merovius](https://github.com/Merovius) por corregir la condición de carrera durante Close().

## Licencia

BSD 3-Clause



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-19

---