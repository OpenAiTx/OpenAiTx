<!-- markdownlint-disable MD033 MD036 MD041 MD045 -->
<div align="center">
  <a href="https://v2.nonebot.dev/store">
    <img src="https://raw.githubusercontent.com/KomoriDev/nonebot-plugin-deepseek/master/./docs/NoneBotPlugin.svg" width="300" alt="logo">
  </a>

</div>

<div align="center">

# NoneBot-Plugin-DeepSeek

_✨ Plugin NoneBot DeepSeek ✨_

<a href="https://github.com/fenxer/llm-things">
  <img src="https://raw.githubusercontent.com/fenxer/llm-things/3eaaba79ddf48a784304493adfbaa614f410d6e6/images/deepseek.svg" width="200" alt="DeepSeek" />
</a>

<br/>

<a href="">
  <img src="https://img.shields.io/pypi/v/nonebot-plugin-deepseek.svg" alt="pypi" />
</a>
<img src="https://img.shields.io/badge/python-3.9+-blue.svg" alt="python">
<a href="https://github.com/astral-sh/uv">
  <img src="https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/astral-sh/uv/main/assets/badge/v0.json" alt="uv-managed">
</a>
<a href="https://github.com/nonebot/plugin-alconna">
  <img src="https://img.shields.io/badge/Alconna-resolved-2564C2" alt="alc-resolved">
</a>

<br/>

<a href="https://registry.nonebot.dev/plugin/nonebot-plugin-deepseek:nonebot_plugin_deepseek">
  <img src="https://img.shields.io/endpoint?url=https%3A%2F%2Fnbbdg.lgc2333.top%2Fplugin%2Fnonebot-plugin-deepseek" alt="Registro NoneBot" />
</a>
<a href="https://registry.nonebot.dev/plugin/nonebot-plugin-deepseek:nonebot_plugin_deepseek">
  <img src="https://img.shields.io/endpoint?url=https%3A%2F%2Fnbbdg.lgc2333.top%2Fplugin-adapters%2Fnonebot-plugin-deepseek" alt="Adaptadores Soportados" />
</a>

<br />
<a href="#-efectos-visuales">
  <strong>📸 Demostración y vista previa</strong>
</a>
&nbsp;&nbsp;|&nbsp;&nbsp;
<a href="#-instalacion">
  <strong>📦️ Descargar plugin</strong>
</a>
&nbsp;&nbsp;|&nbsp;&nbsp;
<a href="https://qm.qq.com/q/Vuipof2zug" target="__blank">
  <strong>💬 Unirse al grupo de chat</strong>
</a>

</div>

## 📖 Introducción <img src="https://raw.githubusercontent.com/fenxer/llm-things/3eaaba79ddf48a784304493adfbaa614f410d6e6/images/human-coded.svg" width="100" alt="Human coded" />

Plugin NoneBot DeepSeek. Integra el modelo DeepSeek, ofreciendo funciones de diálogo inteligente y preguntas y respuestas.

Wiki: 👉 [Enlace](https://github.com/KomoriDev/nonebot-plugin-deepseek/wiki)

> [!IMPORTANT]
> **Marca el proyecto como favorito**, recibirás todas las notificaciones de lanzamientos en GitHub sin demora～⭐️

<img width="100%" src="https://starify.komoridevs.icu/api/starify?owner=KomoriDev&repo=nonebot-plugin-deepseek" alt="starify" />

<details>
  <summary><kbd>Historial de estrellas</kbd></summary>
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=KomoriDev/nonebot-plugin-deepseek&theme=dark&type=Date" />
    <img width="100%" src="https://star-history.com/#KomoriDev/nonebot-plugin-deepseek&Date" />
  </picture>
</details>

## 💿 Instalación

Puedes elegir **una** de las siguientes formas mencionadas

> [!TIP]
> Para habilitar la función de conversión de Markdown a imagen, necesitas instalar `nonebot-plugin-deepseek[image]`

<details open>
<summary>[Recomendado] Instalación usando nb-cli</summary>
Abra la línea de comandos en el directorio raíz del Bot y escriba el siguiente comando para instalar

```shell
nb plugin install nonebot-plugin-deepseek
```

</details>
<details>
<summary>Instalación usando el gestor de paquetes</summary>

```shell
pip install nonebot-plugin-deepseek
# or, use poetry
poetry add nonebot-plugin-deepseek
# or, use pdm
pdm add nonebot-plugin-deepseek
```

Abra el archivo de configuración en el directorio raíz del proyecto NoneBot y agregue la siguiente línea en la sección `[plugin]`

```toml
plugins = ["nonebot_plugin_deepseek"]
```

</details>

## ⚙️ Configuración

Agrega la configuración siguiente en el archivo de configuración del proyecto

> [!note]
> `api_key` Por favor obténlo de [DeepSeek Plataforma Abierta](https://platform.deepseek.com/)  
> `enable_models` es un diccionario con la estructura de [`CustomModel`](https://github.com/KomoriDev/nonebot-plugin-deepseek/blob/ee9f0b0f0568eedb3eb87423e6c1bf271787ab76/nonebot_plugin_deepseek/config.py#L34), si no necesitas conectar modelos locales no es necesario modificarlo  
> Para conectar modelos locales, consulta: 👉 [Wiki - Conectar modelos locales](https://github.com/KomoriDev/nonebot-plugin-deepseek/wiki/本地模型)  

|             Ítem de configuración             | Obligatorio |                             Valor por defecto                             |                                                                          Descripción                                                                          |
| :--------------------------------------------: | :---------: | :----------------------------------------------------------------------: | :-----------------------------------------------------------------------------------------------------------------------------------------------------------: |
|            deepseek__api_key                   |     Sí      |                                Ninguno                                  |                                                                         Clave API                                                                         |
|       deepseek__enable_models                  |     No      | [{ "name": "deepseek-chat" }, { "name": "deepseek-reasoner" }]          | Modelos habilitados [Explicación de configuración](https://github.com/KomoriDev/nonebot-plugin-deepseek/wiki/%E9%85%8D%E7%BD%AE#enable_models-%E9%85%8D%E7%BD%AE%E8%AF%B4%E6%98%8E) |
|            deepseek__prompt                     |     No      |                                Ninguno                                  |                                                                        Preset del modelo                                                                        |
|            deepseek__stream                     |     No      |                               False                                    |                                                                    Habilitar transmisión en streaming                                                                    |
|           deepseek__timeout                     |     No      |                  {"api_request": 100, "user_input": 60}                |                                                                        Configuración de tiempo de espera                                                                        |
|          deepseek__md_to_pic                     |     No      |                               False                                    |                                                                Habilitar conversión de Markdown a imagen                                                                |
|   deepseek__enable_send_thinking                |     No      |                               False                                    |                                                                     Enviar cadena de pensamiento                                                                     |

## 🎉 Uso

> [!note]
> Por favor verifica tu `COMMAND_START` y los ítems de configuración anteriores. Aquí se usa `/` por defecto

### Ayuda

```bash
deepseek --help
         --balance

         [...content] 
           --use-model [model]
           --with-context
           --render | -r

         model
           --list | -l
           --set-default [model]
           --render-markdown ['enable' | 'disable' | 'on' | 'off']
```

### 问答

```bash
/deepseek [内容]
```
Comando rápido: `/ds [contenido]` o responder con un mensaje de texto

### Diálogo multi-turno


```bash
/deepseek --with-context [内容]
```

Atajos: `/ds --with-context [contenido]` `/conversación-múltiple`

### Pensamiento profundo

```bash
/deepseek [内容] --use-model deepseek-reasoner
```

快捷指令：`/深度思考 [内容]`

### 余额

> 权限：SUPERUSER

```bash
/deepseek --balance
```

快捷指令：`/ds --balance` `/余额`

### 设置

> 权限：`设置默认模型` 指令仅 SUPERUSER 可用

```bash
# 查看支持的模型列表
/deepseek model -l|--list
# 设置默认模型
/deepseek model --set-default [模型名]
# 设置 Markdown 转图片
/deepseek model --render-markdown ['enable' | 'disable' | 'on' | 'off']
```

Atajos: `/lista de modelos` `/establecer modelo predeterminado [nombre del modelo]`

### Atajos personalizados

> Esta función depende de [Alconna Atajos](https://nonebot.dev/docs/2.3.3/best-practice/alconna/command#command%E7%9A%84%E4%BD%BF%E7%94%A8). Los comandos personalizados no incluyen `COMMAND_START`, si es necesario debe completarse manualmente

```bash
# 增加
/deepseek --shortcut <自定义指令> /deepseek
# 删除
/deepseek --shortcut delete <自定义指令>
# 列出
/deepseek --shortcut list
```

例子:

```bash
user: /deepseek --shortcut /chat /deepseek --use-model deepseek-chat
bot: deepseek::deepseek 的快捷指令: "/chat" 添加成功
user: /chat
bot: (使用模型 deepseek-chat)
```

## 📸 Capturas de pantalla

<p align="center">
  <a href="https://github.com/KomoriDev/nonebot-plugin-deepseek" target="__blank">
    <picture>
      <source media="(prefers-color-scheme: dark)" srcset="./docs/screenshot-dark.png">
      <source media="(prefers-color-scheme: light)" srcset="./docs/screenshot-light.png">
      <img src="https://raw.githubusercontent.com/KomoriDev/nonebot-plugin-deepseek/master/./docs/screenshot-light.png" alt="DeepSeek - Vista previa" width="100%" />
    </picture>
  </a>
</p>

## 💖 Agradecimientos
  
- [`KomoriDev/Starify`](https://github.com/KomoriDev/Starify): Proporcionó insignias llamativas

### Colaboradores

<a href="#-鸣谢">
  <img src="https://img.shields.io/badge/all_contributors-5-orange.svg?style=flat-square" alt="contributors" />
</a>
<a href="https://afdian.com/@komoridev">
  <img src="https://img.shields.io/badge/all_sponsors-17-946ce6.svg?style=flat-square" alt="sponsors" />
</a>

Agradecemos a estas personas por sus contribuciones a este proyecto:

<a href="https://github.com/KomoriDev/nonebot-plugin-deepseek/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=KomoriDev/nonebot-plugin-deepseek&max=1000" alt="contributors" />
</a>

## 📄 Licencia

Este proyecto está bajo la licencia [MIT](./LICENSE) de código abierto

```text
THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-07

---