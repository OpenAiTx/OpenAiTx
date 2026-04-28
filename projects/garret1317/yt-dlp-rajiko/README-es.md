# yt-dlp-rajiko

plugin mejorado para extractor de [radiko.jp](https://radiko.jp) para yt-dlp (rápido y sin restricciones regionales)

<p>yt-dlp-rajiko te permite descargar programas de radio japoneses desde <a href="https://radiko.jp">radiko.jp</a> sin necesidad de VPN, usando <a href="https://github.com/yt-dlp/yt-dlp">yt-dlp</a>.
Descarga rápido y funciona para cualquier emisora participante*, desde cualquier parte del mundo.<br>
<small>*excepto NHK, pero ellos tienen <a href="https://www.nhk.or.jp/radio/">su propio sitio</a> que está soportado
en yt-dlp propiamente dicho</small></p>


<p>Destinado para archivado personal, no para uso comercial. Por favor, suscríbete a radiko Premium si puedes.<br>
<small>(Es Software Libre, así que esto es solo una petición amable, no un requisito estricto. pero deberías hacerlo para que radiko pueda seguir existiendo)<br>
(también, si adquieres el plan timefree30 puedes usarlo con yt-dlp :P)
</small></p>

### [日本語  🇯🇵](https://427738.xyz/yt-dlp-rajiko/index.ja.html)

## Instalación

[Descarga el paquete del plugin](https://427738.xyz/yt-dlp-rajiko/dl/yt_dlp_rajiko-latest.bundle.zip) o `pip install yt-dlp-rajiko`

<p>Requiere yt-dlp 2025.02.19 o superior.</p>

<p>Si instalaste yt-dlp con pip, usa el comando pip arriba.
Si instalaste yt-dlp con <code>pipx</code>,
usa <code>pipx inject yt-dlp yt-dlp-rajiko</code> para instalar el plugin en el entorno de yt-dlp.</p>

<p>Si instalaste con el .exe/binario o cualquier otro método,
descarga el paquete y colócalo en una de estas ubicaciones: </p>

<ul>
	<li><code>%appdata%\yt-dlp\plugins\</code> (en Windows)</li>
	<li><code>~/.config/yt-dlp/plugins/</code> (en Linux y Mac)</li>
	<li>una carpeta <code>yt-dlp-plugins</code> al lado de tu <code>yt-dlp.exe</code> <a href="https://427738.xyz/yt-dlp-rajiko/i/installation-pluginsfolder2.png">(como esta)</a><br>
	<li>cualquier otro lugar listado en <a href="https://github.com/yt-dlp/yt-dlp#installing-plugins">la documentación de yt-dlp</a>.</li>
</ul>

<p>Deberás crear esas carpetas si no existen ya.<br>
<b>No es necesario extraer el archivo zip.</b></p>

<p>Puedes comprobar que la instalación se realizó correctamente ejecutando <code>yt-dlp -v</code> y buscando las líneas <code>[debug] Extractor Plugins:</code> o <code>[debug] Plugin directories:</code>. <a href="https://427738.xyz/yt-dlp-rajiko/i/plugincheck.png">(como esta)</a>
</p>

Más información sobre los plugins de yt-dlp está disponible en la [documentación de yt-dlp](https://github.com/yt-dlp/yt-dlp#plugins).

## Más información

[Por favor, consulta el sitio web para más información](https://427738.xyz/yt-dlp-rajiko/) (uso, métodos de contacto, etc)

[También hay traducción al japonés](https://427738.xyz/yt-dlp-rajiko/index.ja.html)

## sobre este repositorio

aquí es donde reside el código fuente y el rastreador de errores. la mayoría de la información está en el sitio web.

Generalmente deberías usar las versiones de lanzamiento.
la rama `master` usualmente funciona, pero debe considerarse experimental y puede tener errores


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-28

---