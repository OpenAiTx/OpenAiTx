# gnome-randr-rust

Una reimplementación de `xrandr` para Gnome en Wayland, especialmente para sistemas que no soportan `wlr-output-management-unstable-v1` (por ejemplo, Manjaro). Escrito desde cero en Rust para rendimiento y diversión. ¡Este también es mi primer proyecto en Rust, así que cualquier sugerencia es bienvenida!

> [!NOTE]  
> Actualmente no puedo mantener esto, ya que ya no tengo acceso a una máquina Linux funcional. Si alguien está interesado en mantenerlo, ¡por favor avísenme!
>
> En Gnome 48+, prueben el CLI [gdctl](https://gitlab.gnome.org/GNOME/mutter/-/blob/main/doc/man/gdctl.rst) que viene con él, es muy probable que se mantenga actualizado.

(Para compositores no Gnome, ver enlaces de configuración de pantalla en https://arewewaylandyet.com/)

## Instalación

La instalación requiere `pkg-config` y `cargo`, parte del conjunto de herramientas de Rust. [Instrucciones de instalación de Cargo/Rust](https://doc.rust-lang.org/cargo/getting-started/installation.html).

Para instalar esta herramienta, ejecute `cargo install gnome-randr`. También se expone una biblioteca para uso en otros programas Rust.

## Método

`gnome-randr-rust` usa el objeto `dbus` `org.gnome.Mutter.DisplayConfig`. Vea https://wiki.gnome.org/Initiatives/Wayland/Gaps/DisplayConfig para la propuesta original, aunque la especificación listada allí está algo desactualizada (verificado mediante `dbus introspect` en Gnome shell 40.5). Gnome mantiene el archivo XML en evolución [aquí](https://gitlab.gnome.org/GNOME/mutter/-/blob/main/data/dbus-interfaces/org.gnome.Mutter.DisplayConfig.xml).

El método `GetCurrentState` se usa para listar información sobre las pantallas, mientras que `ApplyMonitorsConfig` se usa para modificar la configuración actual.

## Inspiración

Este proyecto fue fuertemente inspirado por `xrandr` (obviamente) y también por [`gnome-randr`](https://gitlab.com/Oschowa/gnome-randr/). Lamentablemente, `gnome-randr.py` parece estar roto en mi versión de gnome (40.5) al intentar modificar configuraciones de pantalla.

`gnome-randr.py` también es más lento que mi reimplementación en rust: la consulta al script python toma alrededor de 30ms en mi sistema de 3 monitores, mientras que la implementación en rust toma alrededor de 3ms (`xrandr` toma alrededor de 1.5ms, pero también muestra información diferente debido a limitaciones en el puente de `xrandr`).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-30

---