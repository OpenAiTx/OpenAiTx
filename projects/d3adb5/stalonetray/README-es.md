# STAnd aLONE TRAY [![Build][badge-build]][yaml-build] [![Lint][badge-lint]][yaml-lint]

[badge-build]: https://github.com/d3adb5/stalonetray/actions/workflows/build.yml/badge.svg
[yaml-build]: https://github.com/d3adb5/stalonetray/actions/workflows/build.yml
[badge-lint]: https://github.com/d3adb5/stalonetray/actions/workflows/lint.yml/badge.svg
[yaml-lint]: https://github.com/d3adb5/stalonetray/actions/workflows/lint.yml

Stalonetray es un TRAY (área de notificaciones) STAnd-aLONE para escritorios Unix
que usan el sistema de ventanas X11. Tiene dependencias mínimas por defecto en
tiempo de compilación y ejecución: Xlib y libXinerama, aunque se puede prescindir
de esta última deshabilitando una función para aún más minimalismo. Stalonetray
funciona bajo prácticamente cualquier gestor de ventanas.

Para comenzar a usar stalonetray, simplemente copie `stalonetrayrc.sample` a
`~/.stalonetrayrc` o a `$XDG_CONFIG_HOME/stalonetrayrc`. Está bien comentado
y debería ser suficiente para un inicio rápido.

Tenga en cuenta que algunas funciones están deshabilitadas por defecto y pueden
no funcionar directamente, dependiendo de cómo se haya compilado stalonetray por
el mantenedor del paquete. Consulte la sección "Compilación desde el código fuente"
más abajo si desea compilarlo usted mismo con las funciones que necesite.

## Estado de mantenimiento

Este proyecto fue desarrollado originalmente por [Roman Dubtsov (kolbusa)][gh-kolbusa]
y recientemente cambió de manos. Roman aún está involucrado, pero ya no mantiene
activamente el proyecto.

**A él le corresponde todo el crédito por crear y mantener este proyecto durante
muchos años. ¡Gracias, Roman!**

[gh-kolbusa]: https://github.com/kolbusa

## Instalación

Los gestores de paquetes son la forma más conveniente de instalar stalonetray.
Está empaquetado para varias distribuciones de Linux y variantes BSD. En Debian y
Ubuntu, ejecute:

```sh
sudo apt install stalonetray
```

En Fedora ejecute:

```sh
sudo dnf install stalonetray
```

## Construcción desde el código fuente

Stalonetray utiliza [Meson](https://mesonbuild.com/). Consulte el archivo `meson.options`
para conocer las opciones de compilación disponibles y sus valores predeterminados.

Para compilar stalonetray usando Meson, asegúrese de que las dependencias necesarias estén instaladas
--- por defecto solo se requieren los paquetes de desarrollo Xlib y libXinerama ---
y ejecute los comandos estándar de compilación de Meson:

```sh
meson setup builddir
meson compile -C builddir stalonetray
```

Esto debería compilar el binario `stalonetray` en el directorio `builddir`.

Para compilar la documentación de stalonetray, necesitarás tener instalados primero `xsltproc` y las hojas de estilo DocBook.
Luego, compila el objetivo `manpage`:

```sh
meson compile -C builddir manpage
```

Esto crea el archivo `stalonetray.1` en el directorio `builddir`.

La instalación desde el código fuente se puede realizar con:

```sh
meson install -C builddir
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-11

---