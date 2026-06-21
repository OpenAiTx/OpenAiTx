# gnome-shell-extension-ideapad
Funciones para Lenovo IdeaPad en GNOME Shell

*Por el momento, la extensión solo proporciona una forma fácil y amigable de alternar el modo de conservación de batería disponible en portátiles Lenovo Ideapad y mostrar visualmente su estado actual.*

# Instalación
Simplemente instala la extensión desde la [página oficial de extensiones de GNOME](https://extensions.gnome.org/extension/2992/ideapad/) (recomendado). Alternativamente, descarga o clona manualmente el repositorio en `~/.local/share/gnome-shell/extensions/ideapad@laurento.frittella`

En ambos casos, se requieren algunos pasos adicionales. Por favor, consulta la siguiente sección dedicada.

En caso de que desees revisar el código, considera que la rama `master` apunta a la última versión estable de GNOME Shell. Versiones anteriores siguen siendo compatibles en ramas dedicadas (p.ej. `pre-43`).

# Uso
La extensión añade una nueva entrada *Alternar modo de conservación* al panel y muestra un ícono en el menú de estado para indicar cuando el modo de conservación de batería está activado.

Si tu modelo particular de portátil lo soporta, el modo de conservación limita la carga de batería al 55-60% de su capacidad para mejorar la vida útil de la batería. Es especialmente útil cuando el portátil funciona con alimentación externa la mayor parte del tiempo.

| GNOME Shell < 43    | GNOME Shell >= 43      |
|---------------------|------------------------|
| ![](https://raw.githubusercontent.com/laurento/gnome-shell-extension-ideapad/master/screenshot.png) | ![](https://raw.githubusercontent.com/laurento/gnome-shell-extension-ideapad/master/screenshot-43.png) |

# Configuraciones Adicionales Requeridas
Tu usuario de escritorio necesita acceso de lectura y escritura a un archivo sysfs específico que normalmente es propiedad del usuario root. La forma más sencilla de lograrlo es usando `sudo`. Los siguientes pasos han sido probados en Debian, pero deberían funcionar en cualquier sistema GNU/Linux moderno. En caso de duda, consulta la documentación de tu distribución específica.

* Dependiendo de tu distro, necesitas usar el grupo `sudo` (p.ej. Debian y Ubuntu) o `wheel` (p.ej. Arch y Fedora) aquí. En caso de duda, ejecuta el comando `groups` en una terminal y verifica cuál de los dos aparece en la salida.

  Añade la siguiente entrada a la configuración de sudoers de tu sistema (p.ej. `/etc/sudoers.d/ideapad`). **Asegúrate de reemplazar** `%sudo` por `%wheel` si es necesario.
  ~~~
  %sudo ALL=(ALL) NOPASSWD: /usr/bin/tee /sys/bus/platform/drivers/ideapad_acpi/VPC????\:??/conservation_mode
  ~~~

* Para asegurarte de que el módulo del kernel `ideapad_laptop` se cargue automáticamente al iniciar, simplemente añádelo al archivo `/etc/modules`

Para resumir y para referencia fácil...
~~~
# ¡No olvides reemplazar %sudo por %wheel si es necesario!
#
$ echo "%sudo ALL=(ALL) NOPASSWD: /usr/bin/tee /sys/bus/platform/drivers/ideapad_acpi/VPC????\:??/conservation_mode" | sudo tee /etc/sudoers.d/ideapad
$ echo "ideapad_laptop" | sudo tee -a /etc/modules
~~~

# Estimación incorrecta de la batería mostrada
Dependiendo de la versión del kernel que estés usando, podría existir un problema cosmético menor. Sin embargo, si te molesta el estado permanente de batería "Estimando..." mostrado en GNOME, también hay una solución.

De hecho, este problema debería estar corregido en los kernels 5.19+. Si estás usando un kernel más antiguo, puedes intentar aplicar [el parche aquí](https://git.kernel.org/pub/scm/linux/kernel/git/torvalds/linux.git/commit/?id=185d20694a8aceb4eda9fc1314cbaad0df0aab07). Gracias a Martino Fontana por señalarlo.

Alternativamente, podrías usar el parche que sugerí inicialmente en [esta solicitud de fusión de uPower](https://gitlab.freedesktop.org/upower/upower/-/merge_requests/46). Sin embargo, personalmente aconsejaría optar por el parche del kernel. Es una solución mucho más limpia.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-21

---