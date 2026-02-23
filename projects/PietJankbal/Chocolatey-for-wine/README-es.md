
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Chocolatey-for-wine

Instalador automático del gestor de paquetes Chocolatey en wine, útil para instalar rápidamente programas en wine (y posteriormente encontrar errores en wine ;) )  
Se han añadido soluciones para algunos errores, como para Visual Studio Community 2022 y nodejs, véase más adelante.  

Como estaba aburrido durante el confinamiento, escribí un winetricks personalizado (.ps1) con verbos que considero útiles. Simplemente haz 'winetricks' para verlos.
Para algunos verbos se necesita un reinicio completo de wine (debido a cambios recientes en wine). Verás un cuadro de mensaje y la sesión terminará. Simplemente inicia powershell de nuevo y vuelve a intentar el verbo. Si esto se hace una vez, ya no será necesario para ningún verbo.  

Ejemplo:  

'winetricks vs22_interactiveinstaller'  ( --> la sesión se finalizará)  

haz 'wine powershell'  

haz 'winetricks vs22_interactiveinstaller'  


(Por cierto, con 'winetricks vs22_interactive_installer' puedes elegir qué instalar mediante el instalador de Visual Studio 2022; 'winetricks vs22_interactive_installer' ahora me permitió en diez minutos entrar al programa principal (seleccionando Desarrollo de escritorio con C++)).

Instalación :
- Descarga y descomprime el archivo zip de la versión y ejecuta 'wine ChoCinstaller_0.5c.751.exe' (toma alrededor de un minuto en completarse)

Opcional:
- Ejecuta el instalador como 'wine ChoCinstaller_0.5a.751.exe /s' , entonces los archivos de instalación (como Powershell*.msi y dotnet48) se guardan en 
  MisDocumentos y no necesitan ser descargados nuevamente si creas un nuevo prefijo)
Opcional:
- Ejecuta el instalador como 'wine ChoCinstaller_0.5a.751.exe /q' para evitar el lanzamiento automático de la ventana de powershell (solo instalar). 

Opcional:
- Verifica si todo salió bien: "choco install chromium" y  "start chrome.exe (--no-sandbox ya no es necesario a partir de wine-8,4)" 

![Screenshot from 2022-08-26 12-31-18](https://user-images.githubusercontent.com/26839562/186885380-d5a617c4-9cf4-4831-a475-2bd85a3b5784.png)
Sobre PowerShell:

Consejo: Chocolatey normalmente instala la última versión de un programa, lo que podría revelar nuevos bugs en wine. Puede que tengas más éxito con una versión anterior del software.  
Ejemplo:  

choco search --exact microsoft-edge --all (--> lista todas las versiones)  

choco install microsoft-edge --version --version='135.0.3179.98'

Información general:

- 'wine powershell.exe' inicia la consola PowerShell-Core.

 
Sobre ConEmu:

La consola ConEmu sufre de algunos errores de Wine:
  - Ctrl^C para salir de un programa que no vuelve a la consola no funciona. Use Shift^Ctrl^C en su lugar.
  - Seleccionar texto en la ventana de ConEmu (para copiar/pegar) no resalta la selección. Se incluye un hack muy triste contra versiones recientes de Wine que soluciona esto, así que el resaltado debería funcionar ahora.

Sobre winetricks(.ps1):

- Si no lo llama ('winetricks' en la consola de powershell), no se descarga nada, así que no hay sobrecarga.
- Muchos verbos (como powershell 5.1) necesitan algunos archivos esenciales para extraer cosas de paquetes msu. Instalar estos archivos esenciales requiere primero descargas enormes y toma mucho tiempo en el primer uso. Pero después de que las cosas están en caché, va rápido. Por ejemplo, si quiere probar 'winetricks ps51' primero, tomará aproximadamente 15 minutos. Algunos otros verbos pueden tomar 5 minutos en el primer uso. Pero después de llamar a un verbo una vez, esta molestia desaparece.
- Los archivos se almacenan en caché en el directorio Mis Documentos. Si llama a todos los verbos, ocupará unos 800 MB allí.
- Esperemos que haya mejor soporte de 64 bits para varios verbos.
- Posibilidad de extraer un archivo e (intentar) instalar desde un archivo msu. Haga 'winetricks install_dll_from_msu' para ver cómo.
- Un Powershell 5.1 rudimentario.
- Instalación experimental de dotnet481, y dotnet35 (puede ser necesario para apps que no se conforman con la instalación actual de dotnet48).
- Autocompletado de pestañas. Nota: al usar varios verbos desde la línea de comandos, deben separarse por una coma
  a partir de ahora (así es como powershell maneja múltiples argumentos)
  Así que 'winetricks riched20 gdiplus' ya no funciona, use 'winetricks riched20,gdiplus' en su lugar.
- Algunos programas fallan al instalarse/ejecutarse si los prueba vía Chocolatey debido a errores de Wine. Añadí algunos arreglos en winetricks para ellos, vea abajo.
- Verbos especiales (winetricks vs19, vs22 y vs22_interactive_installer) para instalar Visual Studio Community 2019 y 2022 que funcionan (ver captura de pantalla, >10 minutos para instalar y requiere aproximadamente 10GB!, después de la instalación inicie devenv.exe desde el directorio c:\Program\ Files (x86)\Microsoft Visual Studio\2019\Community\Common7\IDE/)
  ![screenshot](https://github.com/PietJankbal/Chocolatey-for-wine/assets/26839562/d576a619-c752-4eb1-81c2-6f6b66b50ff6)
- Verbo especial para acceder a varios comandos unix como grep, sed, file, less, curl, etc. (winetricks git.portable, Descargo de responsabilidad: algunos comandos aún no funcionan debido a errores de Wine)
- También se incluyen algunos scripts de powershell adaptados de fragmentos de código encontrados en internet:
    - Cómo incrustar un exe en un script de powershell vía Invoke-ReflectivePEInjection (el exe no aparecerá en tasklist).
    - Cómo hacer cuadros de mensaje elegantes.
    - Convertir un script de powershell (ps1) en un exe.
    - Y algunos otros

     

Sobre programas del sistema:

Se añadió la función para reemplazar programas simples del sistema como por ejemplo setx.exe por una función en
c:\\Program Files\Powershell\7\profile.ps1. O agregar programas del sistema que faltan como getmac.exe.
Si los programas fallan por insuficiente madurez o por falta de programas del sistema, se puede escribir una
función que devuelva lo que el programa espera.
Como en profile.ps1, añadí (entre otros) un wmic.exe que soporta algunas opciones más,
y un setx.exe básico.
O simplemente puede manipular los argumentos que se pasan al programa del sistema. Vea profile.ps1 y choc_install.ps1.
No garantizo que esto funcione para programas más complejos también...

Notas:
  - ¡NO use en un wineprefix existente, solo en un prefix recién creado! El instalador simplemente instala dotnet48 por sí mismo y altera las claves del registro.
    Si ya tiene instalada alguna versión de dotnet con winetricks.sh regular, probablemente falle, y aunque tenga éxito, probablemente terminará con un prefix roto.
    Si necesita instalar cosas con winetricks.sh regular para programas, NO use ninguno de los verbos dotnet*.
    Por cierto, los verbos 'Arial' y 'd3dcompiler_47' ya están instalados por defecto.
  - ¡WINEARCH=win32 NO está soportado!
  - Actualizar desde una versión anterior por ahora no está (aún) soportado, quizás más adelante

Compilar:
  - Si desea compilar usted mismo en lugar de descargar binarios: vea las instrucciones de compilación en mainv1.c y installer.c
  - Luego copie choc_install.ps1 en el mismo directorio
  - Luego ejecute 'wine ChoCinstaller_0.5a.735.exe'
  


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-23

---