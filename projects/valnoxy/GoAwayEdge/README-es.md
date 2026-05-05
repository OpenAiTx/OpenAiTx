<div align="center">

  <!-- LOGO DEL PROYECTO -->
  <br />
    <a href="https://goawayedge.com">
      <img src="https://dl.exploitox.de/goawayedge/gh-banner-goawayedge.png" alt="Banner de GoAwayEdge">
    </a>
  <br />

  [![Versión][version-shield]][version-url]
  [![Contador de Descargas][downloads-shield]][downloads-url]
  [![Licencia][license-shield]][license-url]
  [![Weblate][weblate-shield]][weblate-url]
</div>

[version-shield]: https://img.shields.io/github/v/release/valnoxy/GoAwayEdge?color=9565F6
[version-url]: https://github.com/valnoxy/GoAwayEdge/releases

[weblate-shield]: http://translate.valnoxy.dev/widget/goawayedge/svg-badge.svg
[weblate-url]: https://translate.valnoxy.dev/engage/goawayedge/

[downloads-shield]: https://img.shields.io/github/downloads/valnoxy/GoAwayEdge/total.svg?color=431D93
[downloads-url]: https://github.com/valnoxy/GoAwayEdge/releases

[license-shield]: https://img.shields.io/github/license/valnoxy/GoAwayEdge?color=9565F6
[license-url]: https://img.shields.io/github/license/valnoxy/GoAwayEdge

<div align="center">
  <h3 align="center">GoAwayEdge</h3>
  <p align="center">
    <p>¿No te gusta Microsoft Edge? A mí tampoco. ¡Redirige todas las llamadas de Edge a tu navegador favorito!</p>
    <a href="https://github.com/valnoxy/GoAwayEdge/releases">Descargar ahora</a>
    ·
    <a href="https://github.com/valnoxy/GoAwayEdge/issues">Reportar error</a>
    ·
    <a href="https://github.com/valnoxy/GoAwayEdge/discussions/">Discusiones</a>
    ·
    <a href="https://translate.valnoxy.dev/engage/goawayedge/">Ayúdame a traducir</a>
    <br />
    <br />
    🎉 La versión 2.0.1 ya está disponible. Consulta las notas de la versión
    <a href="https://github.com/valnoxy/GoAwayEdge/releases">aquí</a>.
    <br />
    <br />
  </p>
</div>

---

> [!NOTE]
> Esta aplicación modificará el sistema. No seré responsable por cualquier daño que te hayas causado al intentar usar esta aplicación.

# 🚀Introducción
GoAwayEdge está diseñado para quienes, como yo, no son fans de Microsoft Edge o Windows Copilot. Si te molesta que Edge aparezca inesperadamente, ¡no temas! Esta utilidad inteligente redirige todas las llamadas relacionadas con Edge a tu navegador preferido, asegurando una experiencia de navegación fluida.

Aquí algunos puntos clave sobre GoAwayEdge:

- Propósito: El propósito principal de GoAwayEdge es interceptar cualquier solicitud o acción que normalmente activaría Microsoft Edge y redirigirla a tu navegador favorito.
- Cómo funciona: GoAwayEdge impide que el proceso de Edge se inicie mediante un hook vía Image File Execution Options. Luego lee los argumentos, los analiza y los redirige a tu navegador predeterminado.
- Compatibilidad: Funciona en sistemas Windows 10 / 11 y ofrece una solución sencilla para quienes desean evitar Edge por completo.

Siéntete libre de explorar el código, contribuir o simplemente disfrutar de una experiencia de navegación sin encuentros inesperados con Edge! 🚀

# 🤸 Métodos de instalación
## 💿 1. Instalación predeterminada
1. Descarga la última versión desde [GitHub](https://github.com/valnoxy/GoAwayEdge/releases).
2. Ejecuta la aplicación.
3. Acepta la licencia.
4. Personaliza GoAwayEdge a tu gusto.
5. ¡Listo!

## 📦 2. Gestor de paquetes
| Gestor de paquetes       | Comando                               |
| ------------------------ | ------------------------------------- |
| winget                   | `winget install Exploitox.GoAwayEdge`<br>También puedes preconfigurar GoAwayEdge con `--custom`: `winget install goawayedge --custom "-e:DuckDuckGo"` |                        

## 🤫 3. Instalación silenciosa
Puedes instalar GoAwayEdge en modo silencioso pasando los siguientes argumentos:

| Interruptor              | Descripción                                                                                                                   |
| ------------------------ | ------------------------------------------------------------------------------------------------------------------------------ |
| `-s`                     | Instalación silenciosa                                                                                                          |
| `-e:<Engine>`            | Especificar el motor de búsqueda: `Google` (predeterminado), `Bing`, `DuckDuckGo`, `Yahoo`, `Yandex`, `Ecosia`, `Ask`, `Qwant`, `Perplexity` |
| `-a:<AI Service>`        | Especificar el servicio de IA: `Default`, `Copilot`, `ChatGPT`, `Gemini`, `GitHub_Copilot`, `Grok`                              |
| `-w:<Weather Service>`   | Especificar el servicio meteorológico: `Default`, `WeatherCom`, `AccuWeather`                                                    |
| `--search-url:<Url>`     | URL personalizada para consulta de búsqueda (ej: `https://google.com/search?q=`)                                                |
| `--ai-url:<Url>`         | Sitio web personalizado de IA (ej: `https://chatgpt.com`)                                                                       |
| `--weather-url:<Url>`    | URL personalizada para consulta meteorológica (ej: `https://my-weather.com/{country-code}/{latitude},{longitude}`)              |

<b>Ejemplo</b>:

```bat
GoAwayEdge.exe -s -e:DuckDuckGo
```

# 🗑️ Eliminar GoAwayEdge
Puedes desinstalar GoAwayEdge como cualquier otra aplicación. Alternativamente, también puedes seguir este método: 
1. Descarga la última versión desde [GitHub](https://github.com/valnoxy/GoAwayEdge/releases).
2. Inicia la aplicación.
3. Haz clic en ```Desinstalar```.
4. ¡Hecho!

También puedes desinstalar GoAwayEdge silenciosamente pasando el siguiente argumento:
```bat
GoAwayEdge.exe -u
```

# 🖼️ Capturas de pantalla
<img src="https://dl.exploitox.de/goawayedge/GoAwayEdge_Screenshot2.png" alt="Configuración de GoAwayEdge" width=650>
<img src="https://dl.exploitox.de/goawayedge/GoAwayEdge_Screenshot3_Bar.png" alt="Reemplazo de Copilot" width=300>

# 🙏 Bibliotecas
Este proyecto utiliza las siguientes bibliotecas:
- [ManagedShell](https://github.com/cairoshell/ManagedShell)
- [Microsoft.Toolkit.Uwp.Notification](https://github.com/CommunityToolkit/WindowsCommunityToolkit)
- [TaskScheduler](https://github.com/dahall/taskscheduler)
- [WPF-UI](https://github.com/lepoco/wpfui)


# 🧾 Licencia
GoAwayEdge está licenciado bajo [MIT](https://github.com/valnoxy/GoAwayEdge/blob/main/LICENSE). Por lo tanto, se permite usar y modificar la aplicación libremente. No me responsabilizo de ningún resultado. Proceda con cualquier acción bajo su propio riesgo.

<hr>
<h6 align="center">© 2018 - 2026 valnoxy. Todos los derechos reservados. 
<br>
Por Jonas Günner &lt;jonas@exploitox.de&gt;</h6>
<p align="center">
	<a href="https://github.com/valnoxy/GoAwayEdge/blob/main/LICENSE"><img src="https://img.shields.io/static/v1.svg?style=for-the-badge&label=License&message=MIT&logoColor=d9e0ee&colorA=363a4f&colorB=b7bdf8"/></a>
</p


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-05

---