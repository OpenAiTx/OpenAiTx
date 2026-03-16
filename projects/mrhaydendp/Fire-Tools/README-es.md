# <p align="center">Fire Tools</p>

[![GitHub Download Stats)](https://img.shields.io/github/downloads/mrhaydendp/Fire-Tools/total?style=for-the-badge)](https://github.com/mrhaydendp/fire-tools/releases/latest/download/Fire-Tools.zip) [![Latest Release](https://img.shields.io/github/v/release/mrhaydendp/Fire-Tools?style=for-the-badge
)](https://github.com/mrhaydendp/fire-tools/releases/latest)

Fire Tools es una poderosa colección de herramientas que ayuda a eliminar bloatware e instalar servicios de Google en tu Fire Tablet para que se sienta más ágil y mejore la usabilidad. Además, soporta lanzadores personalizados como Nova, Lawnchair, o cualquier `.apk(m)`. Si necesitas instalar múltiples aplicaciones rápidamente, hay un instalador por lotes. ¡Es tan fácil como colocar todos tus `.apk(m)` en la carpeta Batch y hacer clic en el botón Batch Install! ¡No se requiere root!

![Fire Tools Screenshot](https://raw.githubusercontent.com/mrhaydendp/Fire-Tools/main/Screenshot.png)

**Características:**
* Multiplataforma (Linux, macOS y Windows)
* Herramienta poderosa para eliminar bloatware
* Limita el seguimiento y anuncios de Amazon
* Instalador de Google Play (Android 8+/Fire OS 7+)
* Soporte para lanzadores personalizados (LauncherHijack en versiones más recientes de Fire OS)
* Deshabilitar actualizaciones OTA
* Extractor de Apk
* Instalador por lotes (archivos .apk y .apkm)
* Selector de DNS personalizado (AdGuard, Cloudflare, etc.)

**Instrucciones de instalación (Python):**

¡Sigue primero los pasos indicados en [Setup-Instructions.md](/Setup-Instructions.md)! luego procede con las instrucciones de instalación. ¡Después de la instalación ejecuta la herramienta de actualización para obtener la versión más reciente de los scripts!

**Linux/macOS:**

``` shell
# Download Latest Release & Extract, Then Run
curl -LO https://github.com/mrhaydendp/fire-tools/releases/latest/download/Fire-Tools.zip
unzip Fire-Tools.zip && rm Fire-Tools.zip
cd Fire-Tools
chmod +x Scripts/Posix/*.sh
pip3 install -r requirements.txt
python3 main.py
```

**Windows Powershell:**

``` powershell
# Download Latest Release & Extract, Then Run
Start-BitsTransfer "https://github.com/mrhaydendp/fire-tools/releases/latest/download/Fire-Tools.zip"
Expand-Archive .\Fire-Tools.zip .\; Remove-Item .\Fire-Tools.zip
Set-Location Fire-Tools
pip install -r requirements.txt
python main.py
```

**Notas Importantes:**

* Aunque este proyecto tiene objetivos similares, no está afiliado con Amazon Fire Toolbox de Datastream33
* Algunas funciones de Fire Tools pueden dejar de funcionar debido a actualizaciones de Fire OS, pero haré todo lo posible para mantenerlas operativas.
* ¡Configura la zona horaria antes de desinstalar aplicaciones! (vuelve a habilitar `com.amazon.kindle.otter.oobe` para cambiar la configuración de fecha y hora)
* Las aplicaciones de Google se descargan desde [ApkMirror](https://www.apkmirror.com/) y están incluidas en las versiones para conveniencia, ver [términos](https://github.com/mrhaydendp/Fire-Tools/blob/main/Fire-Tools/Gapps/README.md). Los nombres de los APK y las URL correspondientes se pueden encontrar en Fire-Tools/Gapps/README.md
* El desinstalador deshabilitará la mayoría de las aplicaciones de Amazon con la excepción de: `Calculator`, `Camera`, `Clock`, `Files`, `Fire Launcher`, `Silk Browser` y `Settings`
* Garantía y Restablecimiento: Usar Fire Tools no anula tu garantía y todos los cambios pueden revertirse con un restablecimiento de fábrica.
* Descargo de responsabilidad: Aunque desarrollé esta herramienta, no me hago responsable de ningún problema derivado de su uso.

**Créditos:** Fire Tools agradece y reconoce los siguientes proyectos. Están incluidos para tu conveniencia:

* [Google](https://www.android.com/) (GApps)
* [TeslaCoil Software](https://novalauncher.com/) (Nova Launcher)
* [Lawnchair](https://github.com/LawnchairLauncher/Lawnchair) (Lawnchair)
* [BaronKiko](https://github.com/BaronKiko/LauncherHijack) (LauncherHijack)
* [D0k3](https://github.com/d0k3/OneClick-for-Amazon-Fire) (Inspirado en su herramienta OneClick-for-Amazon-Fire)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-16

---