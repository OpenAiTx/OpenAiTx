<div align="center">

Inglés | [简体中文](https://raw.githubusercontent.com/Byaidu/PDFMathTranslate/main/docs/README_zh-CN.md) | [繁體中文](https://raw.githubusercontent.com/Byaidu/PDFMathTranslate/main/docs/README_zh-TW.md) | [日本語](https://raw.githubusercontent.com/Byaidu/PDFMathTranslate/main/docs/README_ja-JP.md) | [한국어](https://raw.githubusercontent.com/Byaidu/PDFMathTranslate/main/docs/README_ko-KR.md)

<img src="https://raw.githubusercontent.com/Byaidu/PDFMathTranslate/main/./docs/images/banner.png" width="320px"  alt="PDF2ZH"/>

<h2 id="title">PDFMathTranslate</h2>

<p>
  <!-- PyPI -->
  <a href="https://pypi.org/project/pdf2zh/">
    <img src="https://img.shields.io/pypi/v/pdf2zh"></a>
  <a href="https://pepy.tech/projects/pdf2zh">
    <img src="https://static.pepy.tech/badge/pdf2zh"></a>
  <a href="https://hub.docker.com/r/byaidu/pdf2zh">
    <img src="https://img.shields.io/docker/pulls/byaidu/pdf2zh"></a>
  <a href="https://hellogithub.com/repository/8ec2cfd3ef744762bf531232fa32bc47" target="_blank"><img src="https://api.hellogithub.com/v1/widgets/recommend.svg?rid=8ec2cfd3ef744762bf531232fa32bc47&claim_uid=JQ0yfeBNjaTuqDU&theme=small" alt="Featured｜HelloGitHub" /></a>
  <a href="https://gitcode.com/Byaidu/PDFMathTranslate/overview">
    <img src="https://gitcode.com/Byaidu/PDFMathTranslate/star/badge.svg"></a>
  <a href="https://huggingface.co/spaces/reycn/PDFMathTranslate-Docker">
    <img src="https://img.shields.io/badge/%F0%9F%A4%97-Online%20Demo-FF9E0D"></a>
  <a href="https://www.modelscope.cn/studios/AI-ModelScope/PDFMathTranslate">
    <img src="https://img.shields.io/badge/ModelScope-Demo-blue"></a>
  <a href="https://github.com/Byaidu/PDFMathTranslate/pulls">
    <img src="https://img.shields.io/badge/contributions-welcome-green"></a>
  <a href="https://t.me/+Z9_SgnxmsmA5NzBl">
    <img src="https://img.shields.io/badge/Telegram-2CA5E0?style=flat-squeare&logo=telegram&logoColor=white"></a>
  <!-- License -->
  <a href="./LICENSE">
    <img src="https://img.shields.io/github/license/Byaidu/PDFMathTranslate"></a>
</p>

<a href="https://trendshift.io/repositories/12424" target="_blank"><img src="https://trendshift.io/api/badge/repositories/12424" alt="Byaidu%2FPDFMathTranslate | Trendshift" style="width: 250px; height: 55px;" width="250" height="55"/></a>

</div>

Traducción de artículos científicos en PDF y comparación bilingüe.

- 📊 Conserva fórmulas, gráficos, tabla de contenidos y anotaciones _([vista previa](#preview))_.
- 🌐 Soporta [múltiples idiomas](#language), y diversos [servicios de traducción](#services).
- 🤖 Proporciona [herramienta de línea de comandos](#usage), [interfaz de usuario interactiva](#gui) y [Docker](#docker)

No dude en enviar sus comentarios en [GitHub Issues](https://github.com/Byaidu/PDFMathTranslate/issues) o en el [Grupo de Telegram](https://t.me/+Z9_SgnxmsmA5NzBl).

Para detalles sobre cómo contribuir, consulte la [Guía de Contribución](https://github.com/Byaidu/PDFMathTranslate/wiki/Contribution-Guide---%E8%B4%A1%E7%8C%AE%E6%8C%87%E5%8D%97).

<h2 id="updates">Actualizaciones</h2>

- [9 de mayo de 2025] Vista previa de pdf2zh 2.0 [#586](https://github.com/Byaidu/PDFMathTranslate/issues/586): El archivo ZIP para Windows y la imagen de Docker ya están disponibles.

> [!NOTE]
>
> 2.0 Se trasladó a un nuevo repositorio bajo la organización: [PDFMathTranslate/PDFMathTranslate-next](https://github.com/PDFMathTranslate/PDFMathTranslate-next)
> 
> La versión oficial 2.0 ha sido publicada.

- [3 de marzo de 2025] Soporte experimental para el nuevo backend [BabelDOC](https://github.com/funstory-ai/BabelDOC) WebUI añadido como opción experimental (por [@awwaawwa](https://github.com/awwaawwa))
- [22 de febrero de 2025] Mejor integración de CI para lanzamientos y ejecutable windows-amd64 bien empaquetado (por [@awwaawwa](https://github.com/awwaawwa))
- [24 de diciembre de 2024] El traductor ahora soporta modelos locales en [Xinference](https://github.com/xorbitsai/inference) _(por [@imClumsyPanda](https://github.com/imClumsyPanda))_
- [19 de diciembre de 2024] Documentos no PDF/A ahora soportados usando `-cp` _(por [@reycn](https://github.com/reycn))_
- [13 de diciembre de 2024] Soporte adicional para backend _(por [@YadominJinta](https://github.com/YadominJinta))_
- [10 de diciembre de 2024] El traductor ahora soporta modelos OpenAI en Azure _(por [@yidasanqian](https://github.com/yidasanqian))_

<h2 id="preview">Vista previa</h2>

<div align="center">
<img src="https://raw.githubusercontent.com/Byaidu/PDFMathTranslate/main/./docs/images/preview.gif" width="80%"/>
</div>

<h2 id="demo">Servicio en línea 🌟</h2>

Puede probar nuestra aplicación usando cualquiera de las siguientes demostraciones:

- [Servicio público gratuito](https://pdf2zh.com/) en línea sin instalación _(recomendado)_.
- [Immersive Translate - BabelDOC](https://app.immersivetranslate.com/babel-doc/) 1000 páginas gratuitas por mes. _(recomendado)_
- [Demostración alojada en HuggingFace](https://huggingface.co/spaces/reycn/PDFMathTranslate-Docker)
- [Demostración alojada en ModelScope](https://www.modelscope.cn/studios/AI-ModelScope/PDFMathTranslate) sin instalación.

Tenga en cuenta que los recursos computacionales de la demo son limitados, por favor evite abusar de ellos.

<h2 id="install">Instalación y Uso</h2>

### Métodos

Para diferentes casos de uso, ofrecemos métodos distintos para usar nuestro programa:

<details open>
  <summary>1. Instalación UV</summary>

1. Python instalado (3.10 <= versión <= 3.12)

2. Instale nuestro paquete:

   ```bash
   pip install uv
   uv tool install --python 3.12 pdf2zh
   ```
3. Ejecutar la traducción, archivos generados en [directorio de trabajo actual](https://chatgpt.com/share/6745ed36-9acc-800e-8a90-59204bd13444):


   ```bash
   pdf2zh document.pdf
   ```

</details>

<details>
  <summary>2. Windows exe</summary>

1. Descargue pdf2zh-version-win64.zip desde la [página de lanzamientos](https://github.com/Byaidu/PDFMathTranslate/releases)

2. Descomprima y haga doble clic en `pdf2zh.exe` para ejecutar.

</details>

<details>
  <summary>3. Interfaz gráfica de usuario</summary>

1. Python instalado (3.10 <= versión <= 3.12)

2. Instale nuestro paquete:

```bash
pip install pdf2zh
```

3. Comience a usar en el navegador:

   ```bash
   pdf2zh -i
   ```
4. Si su navegador no se ha iniciado automáticamente, vaya a


   ```bash
   http://localhost:7860/
   ```

   <img src="https://raw.githubusercontent.com/Byaidu/PDFMathTranslate/main/./docs/images/gui.gif" width="500"/>

Vea [la documentación para GUI](https://raw.githubusercontent.com/Byaidu/PDFMathTranslate/main/./docs/README_GUI.md) para más detalles.

</details>

<details>
  <summary>4. Docker</summary>

1. Descargar y ejecutar:

   ```bash
   docker pull byaidu/pdf2zh
   docker run -d -p 7860:7860 byaidu/pdf2zh
   ```
2. Abrir en el navegador:


   ```
   http://localhost:7860/
   ```

Para despliegue de Docker en servicio en la nube:

<div>
<a href="https://www.heroku.com/deploy?template=https://github.com/Byaidu/PDFMathTranslate">
  <img src="https://www.herokucdn.com/deploy/button.svg" alt="Deploy" height="26"></a>
<a href="https://render.com/deploy">
  <img src="https://render.com/images/deploy-to-render-button.svg" alt="Deploy to Koyeb" height="26"></a>
<a href="https://zeabur.com/templates/5FQIGX?referralCode=reycn">
  <img src="https://zeabur.com/button.svg" alt="Deploy on Zeabur" height="26"></a>
<a href="https://template.sealos.io/deploy?templateName=pdf2zh">
  <img src="https://sealos.io/Deploy-on-Sealos.svg" alt="Deploy on Sealos" height="26"></a>
<a href="https://app.koyeb.com/deploy?type=git&builder=buildpack&repository=github.com/Byaidu/PDFMathTranslate&branch=main&name=pdf-math-translate">
  <img src="https://www.koyeb.com/static/images/deploy/button.svg" alt="Deploy to Koyeb" height="26"></a>
</div>

</details>

<details>
  <summary>5. Plugin de Zotero</summary>


Consulta [Zotero PDF2zh](https://github.com/guaguastandup/zotero-pdf2zh) para más detalles.

</details>

<details>
  <summary>6. Línea de comandos</summary>

1. Python instalado (3.10 <= versión <= 3.12)
2. Instala nuestro paquete:

   ```bash
   pip install pdf2zh
   ```

3. Ejecutar la traducción, archivos generados en [directorio de trabajo actual](https://chatgpt.com/share/6745ed36-9acc-800e-8a90-59204bd13444):

   ```bash
   pdf2zh document.pdf
   ```

</details>

> [!TIP]
>
> - Si estás usando Windows y no puedes abrir el archivo después de descargarlo, por favor instala [vc_redist.x64.exe](https://aka.ms/vs/17/release/vc_redist.x64.exe) y vuelve a intentarlo.
>
> - Si no puedes acceder a Docker Hub, prueba la imagen en [GitHub Container Registry](https://github.com/Byaidu/PDFMathTranslate/pkgs/container/pdfmathtranslate).
> ```bash
> docker pull ghcr.io/byaidu/pdfmathtranslate
> docker run -d -p 7860:7860 ghcr.io/byaidu/pdfmathtranslate
> ```

### ¿No se puede instalar?

El programa actual necesita un modelo de IA (`wybxc/DocLayout-YOLO-DocStructBench-onnx`) antes de funcionar y algunos usuarios no pueden descargarlo debido a problemas de red. Si tienes problemas para descargar este modelo, ofrecemos una solución alternativa usando la siguiente variable de entorno:

```shell
set HF_ENDPOINT=https://hf-mirror.com
```

Para usuarios de PowerShell:

```shell
$env:HF_ENDPOINT = https://hf-mirror.com
```
Si la solución no funciona para usted / encontró otros problemas, por favor consulte las [preguntas frecuentes](https://github.com/Byaidu/PDFMathTranslate/wiki#-faq--%E5%B8%B8%E8%A7%81%E9%97%AE%E9%A2%98).

<h2 id="usage">Opciones Avanzadas</h2>

Ejecute el comando de traducción en la línea de comandos para generar el documento traducido `example-mono.pdf` y el documento bilingüe `example-dual.pdf` en el directorio de trabajo actual. Use Google como el servicio de traducción predeterminado. Puede encontrar más servicios de traducción compatibles [AQUÍ](https://github.com/Byaidu/PDFMathTranslate/blob/main/docs/ADVANCED.md#services).

<img src="https://raw.githubusercontent.com/Byaidu/PDFMathTranslate/main/./docs/images/cmd.explained.png" width="580px"  alt="cmd"/>

En la siguiente tabla, enumeramos todas las opciones avanzadas para referencia:

| Opción                | Función                                                                                                      | Ejemplo                                        |
| --------------------- | ------------------------------------------------------------------------------------------------------------- | ---------------------------------------------- |
| files                 | Archivos locales                                                                                              | `pdf2zh ~/local.pdf`                           |
| links                 | Archivos en línea                                                                                             | `pdf2zh http://arxiv.org/paper.pdf`            |
| `-i`                  | [Entrar a la interfaz gráfica](#gui)                                                                         | `pdf2zh -i`                                    |
| `-p`                  | [Traducción parcial del documento](https://github.com/Byaidu/PDFMathTranslate/blob/main/docs/ADVANCED.md#partial) | `pdf2zh example.pdf -p 1`                      |
| `-li`                 | [Idioma de origen](https://github.com/Byaidu/PDFMathTranslate/blob/main/docs/ADVANCED.md#languages)            | `pdf2zh example.pdf -li en`                    |
| `-lo`                 | [Idioma de destino](https://github.com/Byaidu/PDFMathTranslate/blob/main/docs/ADVANCED.md#languages)           | `pdf2zh example.pdf -lo zh`                    |
| `-s`                  | [Servicio de traducción](https://github.com/Byaidu/PDFMathTranslate/blob/main/docs/ADVANCED.md#services)       | `pdf2zh example.pdf -s deepl`                  |
| `-t`                  | [Multihilos](https://github.com/Byaidu/PDFMathTranslate/blob/main/docs/ADVANCED.md#threads)                    | `pdf2zh example.pdf -t 1`                      |
| `-o`                  | Directorio de salida                                                                                           | `pdf2zh example.pdf -o output`                 |
| `-f`, `-c`            | [Excepciones](https://github.com/Byaidu/PDFMathTranslate/blob/main/docs/ADVANCED.md#exceptions)                | `pdf2zh example.pdf -f "(MS.*)"`               |
| `-cp`                 | Modo de compatibilidad                                                                                        | `pdf2zh example.pdf --compatible`              |
| `--skip-subset-fonts` | [Omitir subconjunto de fuentes](https://github.com/Byaidu/PDFMathTranslate/blob/main/docs/ADVANCED.md#font-subset) | `pdf2zh example.pdf --skip-subset-fonts`       |
| `--ignore-cache`      | [Ignorar caché de traducción](https://github.com/Byaidu/PDFMathTranslate/blob/main/docs/ADVANCED.md#cache)     | `pdf2zh example.pdf --ignore-cache`            |
| `--share`             | Enlace público                                                                                                | `pdf2zh -i --share`                            |
| `--authorized`        | [Autorización](https://github.com/Byaidu/PDFMathTranslate/blob/main/docs/ADVANCED.md#auth)                     | `pdf2zh -i --authorized users.txt [auth.html]` |
| `--prompt`            | [Indicador personalizado](https://github.com/Byaidu/PDFMathTranslate/blob/main/docs/ADVANCED.md#prompt)        | `pdf2zh --prompt [prompt.txt]`                 |
| `--onnx`              | [Usar modelo personalizado DocLayout-YOLO ONNX]                                                              | `pdf2zh --onnx [onnx/model/path]`              |
| `--serverport`        | [Usar puerto personalizado para WebUI]                                                                       | `pdf2zh --serverport 7860`                     |
| `--dir`               | [traducción por lotes]                                                                                        | `pdf2zh --dir /path/to/translate/`             |
| `--config`            | [Archivo de configuración](https://github.com/Byaidu/PDFMathTranslate/blob/main/docs/ADVANCED.md#cofig)       | `pdf2zh --config /path/to/config/config.json`  |
| `--serverport`        | [puerto personalizado para servidor gradio]                                                                  | `pdf2zh --serverport 7860`                     |
| `--babeldoc`          | Usar backend experimental [BabelDOC](https://funstory-ai.github.io/BabelDOC/) para traducir                   | `pdf2zh --babeldoc` -s openai example.pdf      |
| `--mcp`               | Habilitar modo MCP STDIO                                                                                       | `pdf2zh --mcp`                                 |
| `--sse`               | Habilitar modo MCP SSE                                                                                        | `pdf2zh --mcp --sse`                           |

Para explicaciones detalladas, por favor consulte nuestro documento sobre [Uso Avanzado](https://raw.githubusercontent.com/Byaidu/PDFMathTranslate/main/./docs/ADVANCED.md) para una lista completa de cada opción.


<h2 id="downstream">Desarrollo Secundario (APIs)</h2>

Para aplicaciones descendentes, por favor consulte nuestro documento sobre [Detalles de la API](https://raw.githubusercontent.com/Byaidu/PDFMathTranslate/main/./docs/APIS.md) para obtener más información sobre:

- [API de Python](https://raw.githubusercontent.com/Byaidu/PDFMathTranslate/main/./docs/APIS.md#api-python), cómo usar el programa en otros programas Python
- [API HTTP](https://raw.githubusercontent.com/Byaidu/PDFMathTranslate/main/./docs/APIS.md#api-http), cómo comunicarse con un servidor que tenga el programa instalado

<h2 id="todo">Tareas Pendientes</h2>

- [ ] Analizar diseño con modelos basados en DocLayNet, [PaddleX](https://github.com/PaddlePaddle/PaddleX/blob/17cc27ac3842e7880ca4aad92358d3ef8555429a/paddlex/repo_apis/PaddleDetection_api/object_det/official_categories.py#L81), [PaperMage](https://github.com/allenai/papermage/blob/9cd4bb48cbedab45d0f7a455711438f1632abebe/README.md?plain=1#L102), [SAM2](https://github.com/facebookresearch/sam2)

- [ ] Corregir rotación de página, tabla de contenidos, formato de listas

- [ ] Corregir fórmulas en píxeles en artículos antiguos

- [ ] Reintentos asíncronos excepto KeyboardInterrupt

- [ ] Algoritmo Knuth–Plass para lenguas occidentales

- [ ] Soporte para archivos no PDF/A

- [ ] Plugins de [Zotero](https://github.com/zotero/zotero) y [Obsidian](https://github.com/obsidianmd/obsidian-releases)

<h2 id="acknowledgement">Agradecimientos</h2>

- [Immersive Translation](https://immersivetranslate.com) patrocina códigos de redención mensuales de membresía Pro para colaboradores activos en este proyecto, vea detalles en: [CONTRIBUTOR_REWARD.md](https://github.com/funstory-ai/BabelDOC/blob/main/docs/CONTRIBUTOR_REWARD.md)

- Nuevo backend: [BabelDOC](https://github.com/funstory-ai/BabelDOC)

- Fusión de documentos: [PyMuPDF](https://github.com/pymupdf/PyMuPDF)

- Análisis de documentos: [Pdfminer.six](https://github.com/pdfminer/pdfminer.six)

- Extracción de documentos: [MinerU](https://github.com/opendatalab/MinerU)

- Vista previa de documentos: [Gradio PDF](https://github.com/freddyaboulton/gradio-pdf)

- Traducción multihilo: [MathTranslate](https://github.com/SUSYUSTC/MathTranslate)

- Análisis de diseño: [DocLayout-YOLO](https://github.com/opendatalab/DocLayout-YOLO)

- Estándar del documento: [PDF Explained](https://zxyle.github.io/PDF-Explained/), [PDF Cheat Sheets](https://pdfa.org/resource/pdf-cheat-sheets/)

- Fuente multilingüe: [Go Noto Universal](https://github.com/satbyy/go-noto-universal)

<h2 id="contrib">Colaboradores</h2>

<a href="https://github.com/Byaidu/PDFMathTranslate/graphs/contributors">
  <img src="https://opencollective.com/PDFMathTranslate/contributors.svg?width=890&button=false" />
</a>

![Alt](https://repobeats.axiom.co/api/embed/dfa7583da5332a11468d686fbd29b92320a6a869.svg "Imagen analítica de Repobeats")

<h2 id="star_hist">Historial de estrellas</h2>

<a href="https://star-history.com/#Byaidu/PDFMathTranslate&Date">
 <picture>
   <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=Byaidu/PDFMathTranslate&type=Date&theme=dark" />
   <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=Byaidu/PDFMathTranslate&type=Date" />
   <img alt="Gráfico de historial de estrellas" src="https://api.star-history.com/svg?repos=Byaidu/PDFMathTranslate&type=Date"/>
 </picture>
</a>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-13

---