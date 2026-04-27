usb-gadget
==========

[![página de crates.io](https://img.shields.io/crates/v/usb-gadget)](https://crates.io/crates/usb-gadget)
[![página de docs.rs](https://docs.rs/usb-gadget/badge.svg)](https://docs.rs/usb-gadget)
[![licencia Apache 2.0](https://img.shields.io/crates/l/usb-gadget)](https://github.com/surban/usb-gadget/blob/master/LICENSE)

Esta biblioteca permite la implementación de periféricos USB, llamados **gadgets USB**,
en dispositivos Linux que cuentan con un controlador de dispositivo USB (UDC).
Se soportan tanto funciones USB predefinidas como implementaciones completamente personalizadas de la interfaz USB.

Las siguientes funciones USB predefinidas, implementadas por controladores del kernel, están disponibles:

* interfaz de red
    * CDC ECM
    * CDC ECM (subconjunto)
    * CDC EEM
    * CDC NCM
    * RNDIS
* puerto serie
    * CDC ACM
    * genérico
* dispositivo de interfaz humana (HID)
* dispositivo de almacenamiento masivo (MSD)
* dispositivo de impresora
* interfaz digital para instrumentos musicales (MIDI)
* dispositivo de audio (UAC1 y UAC2)
* dispositivo de video (UVC)

Además, se pueden implementar funciones USB completamente personalizadas en código Rust en modo usuario.

También se proporciona soporte para descriptores específicos del sistema operativo y WebUSB.

Herramienta CLI
---------------

La herramienta CLI `usb-gadget` permite configurar gadgets USB desde archivos de configuración TOML
sin necesidad de escribir código Rust.


### Instalación

    cargo install usb-gadget --features cli

### Uso

Cree un archivo de configuración TOML que describa su gadget, luego use la CLI para gestionarlo:

    usb-gadget up gadget.toml       # registrar y vincular un gadget
    usb-gadget list                 # listar gadgets registrados
    usb-gadget down my-gadget       # eliminar un gadget por nombre
    usb-gadget down --all           # eliminar todos los gadgets
    usb-gadget check gadget.toml    # validar un archivo de configuración

También puede pasar un directorio a `up` o `check` para procesar todos los archivos `.toml` en él.

### Configuración de ejemplo

```toml
name = "serial-debug"

[device]
vendor = 0x1209
product = 0x0002
manufacturer = "Example Inc."
product_name = "Debug Console"
serial = "0001"

[[config]]
description = "Serial Config"

[[config.function]]
type = "serial"
class = "acm"
```

Se pueden combinar múltiples funciones en un solo dispositivo agregando más entradas `[[config.function]]`. Ejecute `usb-gadget template --list` para ver todas las plantillas disponibles.

Características
--------

Esta crate proporciona las siguientes características opcionales:

* `cli`: construye la herramienta CLI `usb-gadget` para configurar dispositivos a partir de archivos TOML.
* `tokio`: habilita soporte asíncrono para funciones USB personalizadas sobre el runtime Tokio.

Requisitos
------------

La versión mínima soportada de Rust (MSRV) es 1.77.

Se requiere un controlador de dispositivo USB (UDC) soportado por Linux. Normalmente, los
PCs estándar *no* incluyen un UDC.
Un Raspberry Pi 4 contiene un UDC, que está conectado a su puerto USB-C.

Las siguientes opciones de configuración del kernel de Linux deben estar habilitadas para funcionalidad completa:

  * `CONFIG_USB_GADGET`
  * `CONFIG_USB_CONFIGFS`
  * `CONFIG_USB_CONFIGFS_SERIAL`
  * `CONFIG_USB_CONFIGFS_ACM`
  * `CONFIG_USB_CONFIGFS_NCM`
  * `CONFIG_USB_CONFIGFS_ECM`
  * `CONFIG_USB_CONFIGFS_ECM_SUBSET`
  * `CONFIG_USB_CONFIGFS_RNDIS`
  * `CONFIG_USB_CONFIGFS_EEM`
  * `CONFIG_USB_CONFIGFS_MASS_STORAGE`
  * `CONFIG_USB_CONFIGFS_F_FS`
  * `CONFIG_USB_CONFIGFS_F_HID`
  * `CONFIG_USB_CONFIGFS_F_PRINTER`
  * `CONFIG_USB_CONFIGFS_F_MIDI`
  * `CONFIG_USB_CONFIGFS_F_UAC1`
  * `CONFIG_USB_CONFIGFS_F_UAC2`
  * `CONFIG_USB_CONFIGFS_F_UVC`


Se requieren permisos de root para configurar dispositivos USB en Linux y
el sistema de archivos `configfs` debe estar montado.


Licencia
--------

usb-gadget está licenciado bajo la [licencia Apache 2.0].

[licencia Apache 2.0]: https://github.com/surban/usb-gadget/blob/master/LICENSE

### Contribución

A menos que declares explícitamente lo contrario, cualquier contribución enviada
intencionalmente para su inclusión en usb-gadget por ti, se licenciará como Apache 2.0, sin
términos o condiciones adicionales.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-27

---