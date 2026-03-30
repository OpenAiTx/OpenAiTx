![image](https://user-images.githubusercontent.com/693717/210183526-1708c821-172e-4c71-9b02-2a9885654505.svg)

# QuickLook.Plugin.WebViewPlus

[QuickLook](https://github.com/QL-Win/QuickLook) plugin para previsualizar varios tipos de archivos con [WebViewPlus](https://github.com/mooflu/WebViewPlus).

## Prueba

1. Ve a la [página de Lanzamientos](https://github.com/mooflu/QuickLook.Plugin.WebViewPlus/releases) y descarga la última versión.
2. Asegúrate de que QuickLook esté ejecutándose en segundo plano. Ve a tu carpeta de Descargas y presiona <key>Barra espaciadora</key> sobre el archivo `.qlplugin` descargado.
3. Haz clic en el botón “Instalar” en la ventana emergente.
4. Reinicia QuickLook.
5. Para configurar qué tipos de archivos previsualizar con WebViewPlus, abre un archivo html y haz clic en el botón de engranajes en la esquina inferior derecha.

## Desarrollo

 1. Clona este proyecto. No olvides actualizar los submódulos.
 2. Copia la aplicación web WebViewPlus a `webApp` o configura el parámetro `WebAppUrl` del plugin - ver `WebpagePanel.cs`
 3. Establece la `Ruta de salida` en la configuración `Debug` a algo como `..\QuickLook.upstream\Build\Debug\QuickLook.Plugin\QuickLook.Plugin.WebViewPlus\`
 4. Compila el proyecto del plugin con el perfil `Debug`
 5. Compila y ejecuta QuickLook upstream con el perfil `Debug`

 # Lanzamiento
 1. Compila el proyecto con el perfil `Release`.
 2. Ejecuta `Scripts\pack-zip.ps1`.
 3. Deberías encontrar un archivo llamado `QuickLook.Plugin.WebViewPlus.qlplugin` en el directorio del proyecto.

## Licencia

Licencia MIT.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-30

---