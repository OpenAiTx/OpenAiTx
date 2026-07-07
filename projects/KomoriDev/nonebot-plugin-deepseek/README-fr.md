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
  <img src="https://img.shields.io/endpoint?url=https%3A%2F%2Fnbbdg.lgc2333.top%2Fplugin%2Fnonebot-plugin-deepseek" alt="NoneBot Registry" />
</a>
<a href="https://registry.nonebot.dev/plugin/nonebot-plugin-deepseek:nonebot_plugin_deepseek">
  <img src="https://img.shields.io/endpoint?url=https%3A%2F%2Fnbbdg.lgc2333.top%2Fplugin-adapters%2Fnonebot-plugin-deepseek" alt="Adaptateurs pris en charge" />
</a>

<br />
<a href="#-effets-visuels">
  <strong>📸 Démonstration et aperçu</strong>
</a>
&nbsp;&nbsp;|&nbsp;&nbsp;
<a href="#-installation">
  <strong>📦️ Télécharger le plugin</strong>
</a>
&nbsp;&nbsp;|&nbsp;&nbsp;
<a href="https://qm.qq.com/q/Vuipof2zug" target="__blank">
  <strong>💬 Rejoindre le groupe de discussion</strong>
</a>

</div>

## 📖 Introduction <img src="https://raw.githubusercontent.com/fenxer/llm-things/3eaaba79ddf48a784304493adfbaa614f410d6e6/images/human-coded.svg" width="100" alt="Codé par des humains" />

Plugin NoneBot DeepSeek. Intégration du modèle DeepSeek, offrant des fonctions de dialogue intelligent et de questions-réponses.

Wiki : 👉 [Portail](https://github.com/KomoriDev/nonebot-plugin-deepseek/wiki)

> [!IMPORTANT]
> **Ajoutez ce projet en favori**, vous recevrez toutes les notifications de publication sur GitHub sans délai～⭐️

<img width="100%" src="https://starify.komoridevs.icu/api/starify?owner=KomoriDev&repo=nonebot-plugin-deepseek" alt="starify" />

<details>
  <summary><kbd>Historique des étoiles</kbd></summary>
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=KomoriDev/nonebot-plugin-deepseek&theme=dark&type=Date" />
    <img width="100%" src="https://star-history.com/#KomoriDev/nonebot-plugin-deepseek&Date" />
  </picture>
</details>

## 💿 Installation

Choisissez une seule des méthodes mentionnées ci-dessous

> [!TIP]
> Pour activer la fonction de conversion Markdown en image, il faut installer `nonebot-plugin-deepseek[image]`

<details open>
<summary>[Recommandé] Installation avec nb-cli</summary>
Ouvrez la ligne de commande dans le répertoire racine du Bot, puis saisissez la commande suivante pour installer

```shell
nb plugin install nonebot-plugin-deepseek
```

</details>
<details>
<summary>Installation avec un gestionnaire de paquets</summary>

```shell
pip install nonebot-plugin-deepseek
# or, use poetry
poetry add nonebot-plugin-deepseek
# or, use pdm
pdm add nonebot-plugin-deepseek
```
Ouvrez le fichier de configuration à la racine du projet NoneBot, et ajoutez dans la section `[plugin]`


```toml
plugins = ["nonebot_plugin_deepseek"]
```

</details>

## ⚙️ Configuration

Ajoutez la configuration suivante dans le fichier de configuration du projet

> [!note]
> `api_key` veuillez l'obtenir depuis la [plateforme ouverte DeepSeek](https://platform.deepseek.com/)  
> `enable_models` est un dictionnaire de structure [`CustomModel`](https://github.com/KomoriDev/nonebot-plugin-deepseek/blob/ee9f0b0f0568eedb3eb87423e6c1bf271787ab76/nonebot_plugin_deepseek/config.py#L34), si vous n'avez pas besoin d'intégrer un modèle local, aucune modification n'est nécessaire  
> Pour intégrer un modèle local, veuillez consulter : 👉 [Wiki - Intégration de modèle local](https://github.com/KomoriDev/nonebot-plugin-deepseek/wiki/本地模型)  

|              Élément de configuration              | Obligatoire |                             Valeur par défaut                             |                                                                          Description                                                                          |
| :------------------------------------------------: | :---------: | :---------------------------------------------------------------------: | :----------------------------------------------------------------------------------------------------------------------------------------------------------: |
|               deepseek__api_key                     |     Oui     |                                   Aucun                                  |                                                                        Clé API                                                                         |
|           deepseek__enable_models                   |     Non     | [{ "name": "deepseek-chat" }, { "name": "deepseek-reasoner" }]          | Modèles activés [Description de la configuration](https://github.com/KomoriDev/nonebot-plugin-deepseek/wiki/%E9%85%8D%E7%BD%AE#enable_models-%E9%85%8D%E7%BD%AE%E8%AF%B4%E6%98%8E) |
|               deepseek__prompt                       |     Non     |                                   Aucun                                  |                                                                        Préconfiguration du modèle                                                                        |
|               deepseek__stream                       |     Non     |                                  False                                  |                                                                    Activer la transmission en flux                                                                    |
|               deepseek__timeout                      |     Non     |                    {"api_request": 100, "user_input": 60}               |                                                                        Paramètres de timeout                                                                        |
|              deepseek__md_to_pic                      |     Non     |                                  False                                  |                                                                Activer la conversion Markdown en image                                                                |
|        deepseek__enable_send_thinking                |     Non     |                                  False                                  |                                                                     Envoyer la chaîne de pensée                                                                     |

## 🎉 Utilisation

> [!note]
> Veuillez vérifier votre `COMMAND_START` ainsi que les éléments de configuration ci-dessus. Par défaut, `/` est utilisé

### Aide

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

Commande rapide : `/ds [contenu]` ou répondre par un message texte

### Dialogue multi-tours

```bash
/deepseek --with-context [内容]
```

Raccourcis : `/ds --with-context [contenu]` `/conversation multiple`

### Réflexion approfondie

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

Raccourcis : `/liste_modèles` `/définir_modèle_par_défaut [nom_modèle]`

### Raccourcis personnalisés

> Cette fonctionnalité dépend de [Alconna Raccourcis](https://nonebot.dev/docs/2.3.3/best-practice/alconna/command#command%E7%9A%84%E4%BD%BF%E7%94%A8). Les commandes personnalisées ne comportent pas `COMMAND_START`, il faut le saisir manuellement si nécessaire

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

## 📸 Capture d'écran

<p align="center">
  <a href="https://github.com/KomoriDev/nonebot-plugin-deepseek" target="__blank">
    <picture>
      <source media="(prefers-color-scheme: dark)" srcset="./docs/screenshot-dark.png">
      <source media="(prefers-color-scheme: light)" srcset="./docs/screenshot-light.png">
      <img src="https://raw.githubusercontent.com/KomoriDev/nonebot-plugin-deepseek/master/./docs/screenshot-light.png" alt="DeepSeek - Aperçu" width="100%" />
    </picture>
  </a>
</p>

## 💖 Remerciements
  
- [`KomoriDev/Starify`](https://github.com/KomoriDev/Starify) : a fourni des badges attrayants

### Contributeurs

<a href="#-鸣谢">
  <img src="https://img.shields.io/badge/all_contributors-5-orange.svg?style=flat-square" alt="contributors" />
</a>
<a href="https://afdian.com/@komoridev">
  <img src="https://img.shields.io/badge/all_sponsors-17-946ce6.svg?style=flat-square" alt="sponsors" />
</a>

Merci à ces experts pour leurs contributions au projet :

<a href="https://github.com/KomoriDev/nonebot-plugin-deepseek/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=KomoriDev/nonebot-plugin-deepseek&max=1000" alt="contributors" />
</a>

## 📄 Licence

Ce projet est open source sous licence [MIT](./LICENSE)

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