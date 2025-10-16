Configuración Simple GeoIP para Quantumult X (QuantumultX), Loon, Stash El archivo preconfigurado incluye reglas de desbloqueo de Apple News, reglas de desvío para eliminar publicidad, reescritura de desbloqueo de TikTok, reglas de desvío Shenji y reescritura para análisis de video VIP, además de proporcionar accesos directos correspondientes

## Introducción
> + Utiliza las características de Quantumult X y GeoIP para integrar múltiples configuraciones de reescritura, eliminando la mayoría de las reglas para ahorrar recursos, simplificando reglas y archivos de configuración mediante redirección con Vercel
- [Método de uso](https://github.com/smxl/500#使用方法)
- [Reglas de desvío y reescritura](https://github.com/smxl/500#分流规则和重写)
- [Herramientas](https://github.com/smxl/500#小工具)
- [Actualización del archivo de configuración](https://github.com/smxl/500#配置文件更新)
- [Recomendaciones](https://github.com/smxl/500#推荐)

## Declaración

Descargo de responsabilidad: Algunos scripts y contenidos han sido escritos por ChatGPT

Este proyecto ha sido optimizado en varios archivos de configuración de [Quantumult X](https://apps.apple.com/us/app/quantumult-x/id1443988620)

Todo el contenido es solo para referencia, no nos hacemos responsables de ningún contenido de terceros en este proyecto, estos enlaces y contenidos son solo para consulta y conveniencia, y no representan la aprobación o reconocimiento del proyecto hacia dichos contenidos

Dirección Github: [https://github.com/smxl/500](https://github.com/smxl/500)

##  Método de uso

1. Descargar o copiar el archivo de configuración

[https://github.com/smxl/500/raw/main/500.conf](https://github.com/smxl/500/raw/main/500.conf)

[https://cnn.vercel.app/500.conf](https://cnn.vercel.app/500.conf)

2. Quantumult X - Rueda dentada - Archivo de configuración - Descargar - Pegar - Confirmar

3. Mitm - Generar certificado - Configurar certificado - Instalar certificado

4. Sistema - Ajustes - General - Información - Confiar en el certificado

5. Quantumult X - Rueda dentada - Nodos - Referencia (Suscripción) - Añadir arriba a la derecha - Rellenar etiqueta y ruta del recurso (enlace de suscripción propio del servidor)

6. Quantumult X - Rueda dentada - Otros ajustes - Origen GeoLite2 Añadir GeoIP

7. Seleccionar GeoIP2-CN (copiar enlace o descargar e importar)
> - [Loyalsoldier](https://github.com/Loyalsoldier/geoip/raw/release/Country-only-cn-private.mmdb)
> - [Hackl0us](https://github.com/Hackl0us/GeoIP2-CN/raw/release/Country.mmdb)
> - [soffchen](https://github.com/soffchen/GeoIP2-CN/raw/release/Country.mmdb)

8. Si no tienes tu propio enlace de suscripción, puedes usar este directamente. Si necesitas usar tu propia suscripción, cambia en el archivo de configuración bajo [server_remote] la URL https://cnn.vercel.app/xv-sub por tu enlace de suscripción.

9. Para iniciar, dado que Quantumult X no soporta el inicio con url schema / url-schema, se recomienda abrir Configuración > VPN > Siempre activado; el resto de interruptores se seleccionan según necesidad.

Nota 1: Este archivo de configuración usa enlaces de suscripción públicos, por lo que no se recomienda su uso prolongado para usuarios con alta demanda de privacidad ~~Además, este archivo usa un certificado MITM público, se recomienda generar y reemplazarlo por uno propio (al generar el certificado, al exportarlo no introducir contraseña para omitir passphrase)~~

Nota 2: Debido a que QX no ofrece soporte para NaïveProxy (naiveproxy), la versión actual se recomienda correr en OpenWRT dentro de la red local, conectándose a través del servicio local ```socks5=192.168.124.124:1080, tag=LAN```, y añadir el script de inicio en el router ```naive /[PATH]/config.json```

## Reglas de división de tráfico y reescritura

Etiqueta|Tipo|Enlace corto|Descripción - Tildado indica desactivado
-|-|-|-
ads|Regla|https://cnn.vercel.app/xf-ads|Bloqueo de anuncios
cn|Regla|https://cnn.vercel.app/xf-cn|Conexión directa a servicios del continente
global|Regla|https://cnn.vercel.app/xf-global|Servicios internacionales
hijacking|Regla|https://cnn.vercel.app/xf-hijacking|Prevención de secuestro
privacy|Regla|https://cnn.vercel.app/xf-privacy|Privacidad
tg|Regla|https://cnn.vercel.app/xf-tg|Telegram
unbreak|Regla|https://cnn.vercel.app/xf-unbreak|Corrección de reglas
-|-|-|-
adlite|Reescritura|https://cnn.vercel.app/xr-adlite|Reescritura para bloqueo de anuncios
ads|Reescritura|https://cnn.vercel.app/xr-ads|Reescritura para bloqueo de anuncios
adscript|Reescritura|https://cnn.vercel.app/xr-adscript|Bloqueo de anuncios por script
apple|Reescritura|https://cnn.vercel.app/xr-apple|Desbloqueo de servicios Apple limitados, elimina el clima compatible con iOS16, usar Scriptable/IQair/widget “Atención al aire” para mostrar AQI estándar estadounidense
bing|Reescritura|https://cnn.vercel.app/xr-bing|New Bing con Safari y Edge
bili|Reescritura|https://cnn.vercel.app/xr-bili|Optimización de interfaz Bilibili
box|Reescritura|https://cnn.vercel.app/xr-box|BoxJS
-|-|-|Agregar manualmente
covidsc|Reescritura|https://cnn.vercel.app/xr-covidsc|Informe de prueba de ácido nucleico en 24h, Sichuan Tianfu Health Pass con todas las funciones - Alipay + WeChat, desactivado por defecto
covidsc|Reescritura|https://cnn.vercel.app/xr-covidhn|Informe de prueba de ácido nucleico en 24h, Código de salud de Henan, desactivado por defecto
emby|Reescritura|https://cnn.vercel.app/xr-emby|Desbloqueo de Emby, sin notificaciones
fake|Reescritura|https://cnn.vercel.app/xr-fake|Desbloqueo Fake Pro, versión simplificada de lk, incluye Spotify Pro
jsc|Reescritura|https://cnn.vercel.app/xr-jsc|Script para obtención de Cookies
lk|Reescritura|https://cnn.vercel.app/xr-lk|Fake VIP para servicios extranjeros
upgrade|Reescritura|https://cnn.vercel.app/xr-upgrade|Bloqueo de comprobación de actualización de apps
res|Reescritura|https://cnn.vercel.app/xr-res|Optimización de software del continente
search|Reescritura|https://cnn.vercel.app/xr-search|Reescritura del motor de búsqueda DuckDuckGo
v|reescribir|https://cnn.vercel.app/xr-v|reescritura de análisis de vídeo

Puedes ajustar las reglas anteriores y si la reescritura debe estar habilitada según tu situación, por ejemplo: si rara vez usas software extranjero, entonces ```lk reescribir https://cnn.vercel.app/xr-lk servicios extranjeros Fake VIP``` el desbloqueo VIP/Pro de varios programas proporcionados no te será útil [algunas reescrituras ya no funcionan]

De manera similar ```fake https://cnn.vercel.app/xr-fake Fake Pro desbloqueo``` es una versión simplificada de esta regla

En 2024, debido a cambios en la API de iOS, la nueva versión de TikTok solo requiere modificar el país del sistema y una regla de enrutamiento para funcionar ```host-wildcard, *tiktok*, proxy```

## Herramientas pequeñas

Herramienta|Función|Enlace/Complemento
-|-|-
Búsqueda rápida|Configura el motor de búsqueda predeterminado de Safari a DuckDuckGo|Por defecto Google, prefijo de dos letras para otros motores Baidu:bd/Magi:mm/Twitter:tt/YouTube:yt/WolframAlpha:wa + espacio + palabra clave

Al habilitar la reescritura fake, estas apps tienen mejoras: Adguard, Day One, Draft, Documents, Lightroom, PS Express, Memrise, Spotify pro*... El asterisco indica que no está claro si desbloquea compras internas o simula VIP

Al habilitar la reescritura res, estas apps tienen mejoras: Bilibili, Caiyun Weather, WeChat, Baidu Netdisk...

## Actualización de archivos de configuración

500.conf

[https://github.com/smxl/500/raw/main/500.conf](https://github.com/smxl/500/raw/main/500.conf)

[https://cnn.vercel.app/q](https://cnn.vercel.app/q)

## Recomendaciones

Este archivo de configuración referencia algunos proyectos o servicios, puedes encontrarlos en vercel.json

Para facilitar el acceso al proyecto original, las referencias en el archivo usan el formato `https://github.com/usuario/proyecto/raw/rama/directorio/archivo`

Por favor copia `https://github.com/usuario/proyecto/` en la barra de direcciones para acceder al proyecto referenciado

--

Plantilla minimalista https://cnn.vercel.app elimina la mayoría de configuraciones inútiles, solo mantiene el marco básico

Gracias a ilovexjp ILoveNucleicAcidTest etc.

Gracias a la IA, Web3 y el libro blanco

Gracias al entretenimiento y a ti mismo


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-16

---