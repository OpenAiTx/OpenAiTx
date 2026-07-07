<!-- markdownlint-disable MD033 MD036 MD041 MD045 -->
<div align="center">
  <a href="https://v2.nonebot.dev/store">
    <img src="https://raw.githubusercontent.com/KomoriDev/nonebot-plugin-deepseek/master/./docs/NoneBotPlugin.svg" width="300" alt="logo">
  </a>

</div>

<div align="center">

# NoneBot-Plugin-DeepSeek

_✨ NoneBot DeepSeek Plugin ✨_

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
  <img src="https://img.shields.io/endpoint?url=https%3A%2F%2Fnbbdg.lgc2333.top%2Fplugin%2Fnonebot-plugin-deepseek" alt="NoneBot Registry" />
</a>
<a href="https://registry.nonebot.dev/plugin/nonebot-plugin-deepseek:nonebot_plugin_deepseek">
  <img src="https://img.shields.io/endpoint?url=https%3A%2F%2Fnbbdg.lgc2333.top%2Fplugin-adapters%2Fnonebot-plugin-deepseek" alt="Supported Adapters" />
</a>

<br />
<a href="#-demo-and-preview">
  <strong>📸 Demo & Preview</strong>
</a>
&nbsp;&nbsp;|&nbsp;&nbsp;
<a href="#-installation">
  <strong>📦️ Download Plugin</strong>
</a>
&nbsp;&nbsp;|&nbsp;&nbsp;
<a href="https://qm.qq.com/q/Vuipof2zug" target="__blank">
  <strong>💬 Join the Community</strong>
</a>

</div>

## 📖 Introduction <img src="https://raw.githubusercontent.com/fenxer/llm-things/3eaaba79ddf48a784304493adfbaa614f410d6e6/images/human-coded.svg" width="100" alt="Human coded" />

NoneBot DeepSeek plugin. Integrates the DeepSeek model, providing intelligent dialogue and Q&A capabilities.

Wiki: 👉 [Portal](https://github.com/KomoriDev/nonebot-plugin-deepseek/wiki)

> [!IMPORTANT]
> **Star the project**, you will receive all release notifications from GitHub without delay～⭐️

<img width="100%" src="https://starify.komoridevs.icu/api/starify?owner=KomoriDev&repo=nonebot-plugin-deepseek" alt="starify" />

<details>
  <summary><kbd>Star History</kbd></summary>
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=KomoriDev/nonebot-plugin-deepseek&theme=dark&type=Date" />
    <img width="100%" src="https://star-history.com/#KomoriDev/nonebot-plugin-deepseek&Date" />
  </picture>
</details>

## 💿 Installation

You can choose **either one** of the methods mentioned below

> [!TIP]
> To enable Markdown to image conversion, you need to install `nonebot-plugin-deepseek[image]`

<details open>
<summary>[Recommended] Install using nb-cli</summary>
Open the command line in the root directory of the Bot and enter the following command to install

```shell
nb plugin install nonebot-plugin-deepseek
```

</details>
<details>
<summary>Install Using Package Manager</summary>

```shell
pip install nonebot-plugin-deepseek
# or, use poetry
poetry add nonebot-plugin-deepseek
# or, use pdm
pdm add nonebot-plugin-deepseek
```

Open the configuration file in the root directory of the NoneBot project, and append the following under the `[plugin]` section

```toml
plugins = ["nonebot_plugin_deepseek"]
```

</details>

## ⚙️ Configuration

Add the configurations in the table below to the project's configuration file

> [!note]
> `api_key` Please obtain it from [DeepSeek Open Platform](https://platform.deepseek.com/)  
> `enable_models` is a dictionary of [`CustomModel`](https://github.com/KomoriDev/nonebot-plugin-deepseek/blob/ee9f0b0f0568eedb3eb87423e6c1bf271787ab76/nonebot_plugin_deepseek/config.py#L34) structures; no modification is needed if you do not need to connect local models  
> To connect local models, please refer to: 👉 [Wiki - Connect Local Models](https://github.com/KomoriDev/nonebot-plugin-deepseek/wiki/%E6%9C%AC%E5%9C%B0%E6%A8%A1%E5%9E%8B)  

|          Configuration Item          | Required |                             Default Value                             |                                                                          Description                                                                          |
| :---------------------------------: | :------: | :-------------------------------------------------------------------: | :-----------------------------------------------------------------------------------------------------------------------------------------------------------: |
|        deepseek__api_key             |   Yes    |                                None                                  |                                                                        API Key                                                                          |
|     deepseek__enable_models          |    No    | [{ "name": "deepseek-chat" }, { "name": "deepseek-reasoner" }]       | Enabled models [Configuration Explanation](https://github.com/KomoriDev/nonebot-plugin-deepseek/wiki/%E9%85%8D%E7%BD%AE#enable_models-%E9%85%8D%E7%BD%AE%E8%AF%B4%E6%98%8E) |
|         deepseek__prompt             |    No    |                                None                                  |                                                                        Model preset                                                                        |
|         deepseek__stream             |    No    |                               False                                 |                                                                    Whether to enable streaming transmission                                                                    |
|        deepseek__timeout             |    No    |               {"api_request": 100, "user_input": 60}                |                                                                        Timeout settings                                                                        |
|       deepseek__md_to_pic            |    No    |                               False                                 |                                                                Whether to enable Markdown to image                                                                |
|  deepseek__enable_send_thinking      |    No    |                               False                                 |                                                                     Whether to send the chain of thought                                                                     |

## 🎉 Usage

> [!note]
> Please check your `COMMAND_START` and the above configuration items. The default command prefix is `/`

### Help

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

Quick command: `/ds [content]` or reply to a text message

### Multi-turn conversation

```bash
/deepseek --with-context [内容]
```

Shortcut commands: `/ds --with-context [content]` `/multi-turn conversation`

### Deep Thinking

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

Quick Commands: `/model list` `/set default model [model name]`

### Custom Quick Commands

> This feature relies on [Alconna Quick Commands](https://nonebot.dev/docs/2.3.3/best-practice/alconna/command#command%E7%9A%84%E4%BD%BF%E7%94%A8). Custom commands do not include `COMMAND_START`; if necessary, it must be manually added

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

## 📸 Screenshots

<p align="center">
  <a href="https://github.com/KomoriDev/nonebot-plugin-deepseek" target="__blank">
    <picture>
      <source media="(prefers-color-scheme: dark)" srcset="./docs/screenshot-dark.png">
      <source media="(prefers-color-scheme: light)" srcset="./docs/screenshot-light.png">
      <img src="https://raw.githubusercontent.com/KomoriDev/nonebot-plugin-deepseek/master/./docs/screenshot-light.png" alt="DeepSeek - Preview" width="100%" />
    </picture>
  </a>
</p>

## 💖 Acknowledgements
  
- [`KomoriDev/Starify`](https://github.com/KomoriDev/Starify): Provided eye-catching badges

### Contributors

<a href="#-鸣谢">
  <img src="https://img.shields.io/badge/all_contributors-5-orange.svg?style=flat-square" alt="contributors" />
</a>
<a href="https://afdian.com/@komoridev">
  <img src="https://img.shields.io/badge/all_sponsors-17-946ce6.svg?style=flat-square" alt="sponsors" />
</a>

Thanks to these great people for their contributions to this project:

<a href="https://github.com/KomoriDev/nonebot-plugin-deepseek/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=KomoriDev/nonebot-plugin-deepseek&max=1000" alt="contributors" />
</a>

## 📄 License

This project is open source under the [MIT](./LICENSE) license

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