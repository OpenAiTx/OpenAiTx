# Chocolatey-for-wine

Instalador automático del gestor de paquetes Chocolatey en wine, útil para instalar rápidamente programas en wine (y posteriormente encontrar errores en wine ;) )  
Para algunos errores se añaden soluciones alternativas como para Visual Studio Community 2022 y nodejs, ver más adelante.  

Como estaba aburrido durante el confinamiento escribí un winetricks personalizado (.ps1) con verbos que me parecen útiles. Solo haz 'winetricks' para verlos.  
Para algunos verbos es necesario un reinicio completo de wine (debido a cambios recientes en wine). Verás un cuadro de mensaje y la sesión terminará. Solo inicia powershell de nuevo y vuelve a intentar el verbo. Si esto se hace una vez, ya no será necesario para ningún verbo.  

Ejemplo:  

'winetricks vs22_interactiveinstaller'  ( --> la sesión terminará)  

haz 'wine powershell'  

haz 'winetricks vs22_interactiveinstaller'  


(Por cierto, con 'winetricks vs22_interactive_installer' puedes seleccionar qué instalar vía el instalador de Visual Studio 2022; 'winetricks vs22_interactive_installer' me llevó en diez minutos al programa principal (seleccioné Desarrollo de escritorio con C++)).

Instalación:  
- Descarga y descomprime el archivo zip de la versión y ejecuta 'wine ChoCinstaller_0.5c.751.exe' (tarda alrededor de un minuto en completarse)

Opcional:  
- Ejecuta el instalador como 'wine ChoCinstaller_0.5a.751.exe /s', entonces los archivos de instalación (como Powershell*.msi y dotnet48) se guardan en  
  MisDocumentos y no necesitan descargarse de nuevo si creas un nuevo prefijo)  
Opcional:  
- Ejecuta el instalador como 'wine ChoCinstaller_0.5a.751.exe /q' para evitar el lanzamiento automático de la ventana de powershell (solo instalación).  

Opcional:  
- Verifica si todo fue bien: "choco install chromium" y  "start chrome.exe (--no-sandbox ya no es necesario desde wine-8,4)"  

![Captura de pantalla de 2022-08-26 12-31-18](https://user-images.githubusercontent.com/26839562/186885380-d5a617c4-9cf4-4831-a475-2bd85a3b5784.png)
Sobre PowerShell:

Consejo: Chocolatey usualmente instala la versión más reciente de un programa, lo que puede revelar nuevos errores en wine. Podrías tener más suerte con una versión antigua del software.  
Ejemplo:  

choco search --exact microsoft-edge --all (--> lista todas las versiones)  

choco install microsoft-edge --version --version='135.0.3179.98'
Información general:

- 'wine powershell.exe' inicia la consola PowerShell-Core.

 
Acerca de ConEmu:

La consola ConEmu sufre algunos errores de wine:
  - Ctrl^C para salir de un programa que no regresa a la consola no funciona. Use Shift^Ctrl^C en su lugar.
  - Seleccionar texto en la ventana de ConEmu (para copiar/pegar) no resalta la selección. Se incluye un hack muy triste contra versiones recientes de wine que lo soluciona, por lo que ahora el resaltado debería funcionar.
   
Acerca de winetricks(.ps1):

- Si no lo llamas ('winetricks' en la consola powershell), no se descarga nada, por lo que no hay sobrecarga.
- Muchos verbos (como powershell 5.1) necesitan algunos archivos esenciales para extraer cosas de paquetes msu. Instalar estos archivos esenciales requiere primero grandes descargas, y toma mucho tiempo en el primer uso. Pero después de que las cosas están en caché, va rápido. Por ejemplo, si quieres probar 'winetricks ps51' primero, tomará aproximadamente 15 minutos. Algunos otros verbos pueden tomar 5 minutos en el primer uso. Pero después de llamar un verbo una vez, esta molestia desaparece.
- Los archivos se almacenan en caché en el directorio MisDocumentos. Si llamas a todos los verbos, ocupará unos 800 MB allí.
- Esperamos mejor soporte para 64 bits en varios verbos.
- Posibilidad de extraer un archivo y (tratar de) instalar desde un archivo msu. Haz 'winetricks install_dll_from_msu' para ver cómo.
- Un PowerShell 5.1 rudimentario.
- Instalación experimental de dotnet481, y dotnet35 (puede ser necesario para aplicaciones que no se satisfacen con la instalación actual de dotnet48).
- Autocompletado con tabulación automática. Nota: al usar varios verbos desde la línea de comandos, deben separarse por coma a partir de ahora (así maneja PowerShell múltiples argumentos).
  Por lo tanto, 'winetricks riched20 gdiplus' ya no funciona, usa 'winetricks riched20,gdiplus' en su lugar.
- Algunos programas fallan al instalarse/ejecutarse cuando los pruebas vía Chocolatey debido a errores de wine. Añadí algunos métodos alternativos en winetricks para ellos, ver más abajo.
- Verbos especiales (winetricks vs19, vs22 y vs22_interactive_installer) para instalar Visual Studio Community 2019 y 2022 funcionando (ver captura, >10 mins para instalar y requiere aprox. 10GB!, después de instalar inicia devenv.exe desde el directorio c:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\IDE/)
  ![captura](https://github.com/PietJankbal/Chocolatey-for-wine/assets/26839562/d576a619-c752-4eb1-81c2-6f6b66b50ff6)
- Verbo especial para acceder a varios comandos unix como grep, sed, file, less, curl, etc. (winetricks git.portable, Descargo: algunos comandos aún no funcionan debido a errores de wine).
- También se incluyen algunos scripts de powershell adaptados de fragmentos de código encontrados en internet:
    - Cómo incrustar un exe en un script powershell vía Invoke-ReflectivePEInjection (el exe no aparece en tasklist).
    - Cómo hacer cuadros de mensaje elegantes.
    - Convertir un script powershell (ps1) en un exe.
    - Y algunos otros.
 
     
Acerca de programas del sistema:

Se añade una función para reemplazar programas simples del sistema como por ejemplo setx.exe por una función en
c:\\Program Files\Powershell\7\profile.ps1. O agregar programas del sistema que faltan como getmac.exe.
Si programas fallan por programas del sistema insuficientes, inmaduros o ausentes, se podría escribir un 


función para devolver lo que el programa espera.  
Como en profile.ps1 añadí (entre otros) un wmic.exe que soporta un poco más de opciones,  
y un setx.exe básico.  
O simplemente podrías manipular los argumentos pasados al programa del sistema. Ve profile.ps1 y choc_install.ps1.  
No garantizo que esto funcione para programas más complejos también...  
  
Notas:  
  
  - NO usar en un wineprefix existente, ¡solo en un prefijo recién creado! El instalador simplemente instala dotnet48 por sí mismo y modifica las claves del registro de forma incorrecta.  
    Si ya tienes alguna versión de dotnet instalada con winetricks.sh normal, probablemente fallará, y aunque tenga éxito, probablemente terminarás con un prefijo dañado.  
    Si necesitas instalar cosas con winetricks.sh normal para programas, NO uses ninguno de los verbos dotnet*.  
    Por cierto, los verbos 'Arial' y 'd3dcompiler_47' ya están instalados por defecto.  
  - ¡WINEARCH=win32 _no_ está soportado!  
  - Actualizar desde una versión anterior no está (todavía) soportado, tal vez más adelante  
  
Compilar:  
  - Si quieres compilar tú mismo en lugar de descargar binarios: consulta las instrucciones de compilación en mainv1.c y installer.c  
  - Luego copia choc_install.ps1 en el mismo directorio  
  - Luego ejecuta 'wine ChoCinstaller_0.5a.735.exe'  
  


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-03

---