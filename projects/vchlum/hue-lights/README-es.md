# OBSOLETO
Esta extensión ha sido obsoleta pero se ha lanzado una nueva extensión llamada Smart Home para reemplazarla. Por favor visite https://github.com/vchlum/smart-home

# hue-lights
![captura de pantalla](https://github.com/vchlum/hue-lights/blob/main/screenshot.png)

## Extensión de Gnome Shell
hue-lights es una extensión de Gnome Shell para luces Philips Hue controladas por Philips Hue Bridge en la red local. La extensión agrupa las luces en zonas y habitaciones. Es posible controlar el estado, el brillo y el color o la temperatura. Se pueden activar escenas para las zonas o habitaciones. Es posible controlar múltiples puentes. También es posible configurar luces que parpadeen en caso de notificación.

## Áreas de entretenimiento Philips Hue
Esta extensión soporta las áreas de entretenimiento. Usando la aplicación original en el teléfono, puede crear un área de entretenimiento. Luego puede comenzar a sincronizar sus luces con su pantalla. La función de sincronización requiere una clave especial generada en el emparejamiento del puente. La actualización desde la versión 8 o anterior requiere eliminar y conectar el puente Philips Hue. Por favor mantenga su puente actualizado. La función también necesita la versión de API 1.22 o superior.

## Soporte para Philips Hue HDMI sync box
Esta extensión permite controlar la caja de sincronización HDMI Philips Hue en la red local. Puede activar/desactivar la sincronización, cambiar el modo, cambiar la intensidad, ajustar el brillo, seleccionar el área de entretenimiento y seleccionar la entrada HDMI.

## Solución de problemas
 1. Si experimenta algún problema con la actualización, intente cerrar sesión y volver a iniciarla.
 1. Si sus problemas persisten, restablezca esta extensión restableciendo la clave: "/org/gnome/shell/extensions/hue-lights/" en gnome.
    * Puede ejecutar: `dconf reset -f /org/gnome/shell/extensions/hue-lights/` o usar `dconf-editor`.
 1. Si su problema no desaparece, por favor abra un issue en GitHub. Si puede, active el modo debug en la configuración y adjunte el archivo de registro.
    * Puede obtener el archivo de registro así: `journalctl -f /usr/bin/gnome-shell 2>&1 | grep -i hue > hue-lights.log`.

## Advertencia
Esta aplicación usa condiciones de efectos de luz que cambian rápidamente, sola o en combinación con cierto contenido en pantalla, puede desencadenar síntomas epilépticos o convulsiones en personas que no tienen historial previo de convulsiones o epilepsia.

## Versión de Gnome Shell soportada
Esta extensión soporta Gnome Shell versión 45 y superiores.

## Instalación desde e.g.o
https://extensions.gnome.org/extension/3737/hue-lights

## Instalación manual

 1. `git clone https://github.com/vchlum/hue-lights.git`
 1. `cd hue-lights`
 1. `make build`
 1. `make install`
 1. Cierre sesión y vuelva a iniciar sesión
 1. `gnome-extensions enable hue-lights@chlumskyvaclav.gmail.com`

## Instalar dependencias
  - Estas solo son necesarias para instalar desde el código fuente
  - `make`
  - `gnome-shell` (comando `gnome-extensions`)
  - `glib-compile-resources`
  - `libglib2.0-dev-bin`
  - `gettext`
  - Estas se recomiendan para ejecutar la extensión
  - `avahi-tools` (comando `avahi-browse` para descubrir dispositivos en la red local)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---