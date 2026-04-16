# gnome-gamma-tool

Una herramienta de línea de comandos que te permite cambiar el gamma, el contraste y el brillo en GNOME y Cinnamon de forma persistente creando un perfil de color con la tabla VCGT.

## Descargo de responsabilidad
**Esto solo funciona con GNOME y Cinnamon**. Probado en Fedora con GNOME 42-48 y Cinnamon, podría no funcionar con versiones más antiguas/nuevas, aunque los perfiles ya generados deberían seguir funcionando.

Esto es bastante improvisado, los perfiles de color no fueron diseñados para usarse así. Pero creo que el caso de uso es lo suficientemente raro como para justificarlo. Después de todo, si tu monitor no te deja cambiar el gamma, ¿no es eso un problema del monitor?

Consulta [Cómo funciona](#how-it-works) para una descripción más detallada.

**Nota:** no es posible cambiar la saturación o el tono de la pantalla (debido a las limitaciones de VCGT), pero puedes probar usando [gnome-saturation-extension](https://github.com/zb3/gnome-saturation-extension) (que también tiene sus inconvenientes).

## Uso
No es necesario instalar esto, solo clona este repositorio:
```
git clone https://github.com/zb3/gnome-gamma-tool
cd gnome-gamma-tool
```
**Si** estás usando Debian/Ubuntu, es posible que también necesites instalar primero el paquete `gir1.2-colord-1.0`:

```
sudo apt install gir1.2-colord-1.0
```
para OpenSUSE, es posible que necesite instalar el paquete `typelib-1_0-Colord-1_0` en su lugar:
```
sudo zypper install typelib-1_0-Colord-1_0
```
si estás usando NixOS, consulta [este comentario](https://github.com/zb3/gnome-gamma-tool/issues/28#issuecomment-3112277504)

Luego puedes invocar la herramienta así:
```
./gnome-gamma-tool.py
```
(si esto no funciona, por favor abre un nuevo problema [aquí](https://github.com/zb3/gnome-gamma-tool/issues/new))

Una vez que el nuevo perfil esté instalado, esta herramienta puede ser eliminada con seguridad.


### Ajustando la gamma de la pantalla
El argumento `-g` te permite especificar el factor de corrección gamma. También puedes usar la forma `R:G:B` para configurarlo en canales individuales.

Por ejemplo:
```
./gnome-gamma-tool.py -g 0.8
```
or
```
./gnome-gamma-tool.py -g 0.8:0.8:0.8
```

### Ajustar el contraste (o invertir colores)
También puedes cambiar el contraste usando el parámetro `-c`. `1` es el valor predeterminado, mientras que `-1` invertirá efectivamente los colores. Asegúrate de no usar el valor `0` aquí porque hará que tu pantalla se vea completamente gris...

Por ejemplo:
```
./gnome-gamma-tool.py -c -1
```
Tenga en cuenta que siempre comienza desde el estado inicial, por lo que el comando anterior deshará cualquier ajuste previo de gamma, pero puede combinar diferentes opciones:


```
./gnome-gamma-tool.py -g 0.8 -c 0.5
```

Los ajustes por canal también funcionan aquí, por lo que, por ejemplo, es posible invertir el canal azul mientras se mantienen intactos el rojo y el verde. ¿Puedes adivinar cómo se vería esto? Inténtalo:
```
./gnome-gamma-tool.py -c=1:1:-1
```
¿Era eso lo que esperabas? :)

### Cambiar la temperatura de color
La temperatura de color también se puede cambiar, usa la opción `-t` para especificar la temperatura. Los valores funcionan igual que en `redshift` donde `6500` es el valor neutral. Ten en cuenta que esto no impide que la función de luz nocturna funcione, es solo que los ajustes de luz nocturna se hacen "encima de" lo que hace gnome-gamma-tool.
```
./gnome-gamma-tool.py -t 5000
```

### Ajustar brillo (más o menos)
También puedes ajustar el brillo con esta herramienta, pero no es posible aumentar el brillo físico de la pantalla, solo es posible disminuirlo reduciendo el valor máximo de brillo. Usa la opción `-b` para eso, acepta valores de `0` a `1`, donde `1` es el valor neutral:
```
./gnome-gamma-tool.py -b 0.7
```

Hay otra opción aquí que te permite *aumentar* el valor *mínimo* de brillo. Es la opción `-bm` que también acepta valores de `0` a `1`, esta vez siendo `0` el valor neutral. Después de hacer:
```
./gnome-gamma-tool.py -bm 0.3
```
el valor de salida nunca será menor que `0.3`, por lo que el negro no será negro sino gris, mientras que el blanco seguirá siendo blanco y los colores intermedios se multiplicarán en consecuencia. También es posible invertir los colores usando la combinación de `-b` y `-bm`:
```
./gnome-gamma-tool.py -b 0 -bm 1
```

Y... eso no es todo, porque estos también funcionan por canales individuales, gracias a la notación `R:G:B`. Esto abre nuevas posibilidades, como... hacer que tu pantalla sea más verde (lo que no podrías lograr con la temperatura de color):
```
./gnome-gamma-tool.py -b 1:2:1
```
Lo anterior se transforma primero en `0.5:1:0.5` y, técnicamente, hace que tu pantalla sea menos roja y menos azul, pero prácticamente hace que la pantalla parezca más verde. Qué característica tan útil, ¿no crees?


### Si tienes múltiples pantallas
Puedes especificar el *índice* de la pantalla usando la opción `-d` (la primera tiene el índice `0`, pero ese es el predeterminado, así que no necesitas usar este argumento en ese caso...). El orden de las pantallas es el mismo que en el panel `Configuración -> Color`. Aquí viene el ejemplo:
```
./gnome-gamma-tool.py -d 1 -g 0.7
```

También puede aplicar cambios a todas las pantallas usando la opción `-a`:
```
./gnome-gamma-tool.py -a -g 0.7
```

### Exportar a un archivo

Si solo desea crear un perfil ICC con la tabla VCGT adecuada pero sin interactuar con su configuración actual, puede usar el argumento `-o`/`--out-file`. Tenga en cuenta que no cargará su perfil actual, por lo que la salida será un perfil sRGB a menos que utilice el argumento `-i`/`--in-file` para especificar el perfil base.

Luego puede importarlo y aplicarlo usando una herramienta como `colormgr`.

```
# Create myprofile.icc file
python3 ./gnome-gamma-tool.py --min-brightness 0.05 --brightness 0.95 --out-file myprofile.icc

# This command will print Device ID, save it
colormgr get-devices

# This command will print Profile ID, save it
colormgr import-profile myprofile.icc

# This command will affect colors immediately
colormgr device-add-profile $displayId $profileId

# This command will remove imported profile and revert colors to original state immediately.
colormgr delete-profile $profileId
```
## Cómo funciona

Mutter (el compositor de GNOME) no implementa ningún protocolo Wayland que pueda ayudar, por lo que herramientas como `gammastep` o `wl-gammactl` no funcionarán. Sin embargo, Mutter expone el método `SetCrtcGamma` vía D-Bus, y ese método realmente funciona. Aún así, no es así como gnome-gamma-tool logra su propósito porque:
* el valor no se guarda en ningún lado, por lo que el efecto no es persistente
* este método ya es llamado por otro demonio, por lo que el efecto es solo temporal.

Normalmente, ese método es llamado por el demonio `gsd-color` (indirectamente), y actualmente hay dos cosas que pueden afectar sus argumentos:
* tabla VCGT del perfil de color habilitado actualmente (obtenida vía colord)
* temperatura de color derivada de la configuración de "luz nocturna"
(estos dos se combinan juntos)

Ahora, podría parecer que la solución obvia aquí es parchear `gsd-color` para que también tome en cuenta otras cosas (como una propiedad de GSettings), así podrías ajustar el gamma vía el comando `gsettings`. Esto también abriría la posibilidad de agregar una interfaz gráfica al panel de Pantalla más adelante.

Sin embargo, esto no es cómo opera gnome-gamma-tool, porque parchear `gsd-color` solo tiene sentido si este parche se fusiona upstream. De lo contrario, es completamente inaceptable para mí (y probablemente para ti también) tener que aplicar parches personalizados y recompilar partes de GNOME. Por eso gnome-gamma-tool instala un perfil de color con la tabla "VCGT" correcta configurada.

`gsd-color` no administra perfiles de color, los observa usando la API proporcionada por colord. Para que un perfil sea reconocido por `gsd-color`, deben hacerse estas cosas:
* los perfiles de color deben estar habilitados para un dispositivo dado
* ese perfil necesita estar instalado (en la base de datos de colord)
* ese perfil debe estar asociado con el dispositivo
* ese perfil debe estar habilitado

Todos esos pasos se realizan usando la API expuesta por colord vía D-Bus. gnome-gamma-tool no crea un perfil nuevo desde cero (a menos que especifiques `-o`/`--out-file`), sino que clona el actual y solo modifica la tabla VCGT. Por defecto, el perfil actual es el generado por `gsd-color` a partir de datos EDID.

`gsd-color` escucha cambios de dispositivo/perfil usando señales D-Bus, por lo que detecta nuestro cambio de perfil y luego eventualmente llama a `SetCrtcGamma`. ¡Eso es todo!

¿Entonces qué es esta "VCGT"? La VCGT (Tabla de Gamma de la Tarjeta de Video) básicamente mapea valores de canales de color (R, G y B). Como si un canal tiene valor `X`, la VCGT especifica que esto debe traducirse a `Y`. Por supuesto, no todos los valores de entrada tienen una entrada en la VCGT, esa tabla tiene solo 256 entradas y los valores se interpolan (pero esto no lo hace gnome-gamma-tool).

VCGT hace posible cambiar el gamma (vía exponenciación), contraste y brillo, pero no es posible cambiar el tono de esta manera, porque un canal no puede afectar a otro.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-16

---