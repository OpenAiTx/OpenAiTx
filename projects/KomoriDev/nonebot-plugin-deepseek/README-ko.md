<!-- markdownlint-disable MD033 MD036 MD041 MD045 -->
<div align="center">
  <a href="https://v2.nonebot.dev/store">
    <img src="https://raw.githubusercontent.com/KomoriDev/nonebot-plugin-deepseek/master/./docs/NoneBotPlugin.svg" width="300" alt="logo">
  </a>

</div>

<div align="center">

# NoneBot-Plugin-DeepSeek

_✨ NoneBot DeepSeek 플러그인 ✨_

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
<a href="#-효과 그림">
  <strong>📸 데모 및 미리보기</strong>
</a>
&nbsp;&nbsp;|&nbsp;&nbsp;
<a href="#-설치">
  <strong>📦️ 플러그인 다운로드</strong>
</a>
&nbsp;&nbsp;|&nbsp;&nbsp;
<a href="https://qm.qq.com/q/Vuipof2zug" target="__blank">
  <strong>💬 커뮤니티 참여</strong>
</a>

</div>

## 📖 소개 <img src="https://raw.githubusercontent.com/fenxer/llm-things/3eaaba79ddf48a784304493adfbaa614f410d6e6/images/human-coded.svg" width="100" alt="Human coded" />

NoneBot DeepSeek 플러그인. DeepSeek 모델을 접목하여 지능형 대화 및 질문응답 기능을 제공합니다.

Wiki: 👉 [바로가기](https://github.com/KomoriDev/nonebot-plugin-deepseek/wiki)

> [!IMPORTANT]
> **프로젝트 즐겨찾기**를 하면 GitHub에서 모든 릴리스 알림을 지연 없이 받을 수 있습니다～⭐️

<img width="100%" src="https://starify.komoridevs.icu/api/starify?owner=KomoriDev&repo=nonebot-plugin-deepseek" alt="starify" />

<details>
  <summary><kbd>별 히스토리</kbd></summary>
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=KomoriDev/nonebot-plugin-deepseek&theme=dark&type=Date" />
    <img width="100%" src="https://star-history.com/#KomoriDev/nonebot-plugin-deepseek&Date" />
  </picture>
</details>

## 💿 설치

아래 언급된 방법 중 **하나**만 선택하면 됩니다.

> [!TIP]
> Markdown을 이미지로 변환 기능을 활성화하려면 `nonebot-plugin-deepseek[image]`를 설치해야 합니다.
<details open>
<summary>[추천] nb-cli 사용하여 설치</summary>
Bot의 루트 디렉토리에서 명령어 창을 열고, 다음 명령어를 입력하여 설치할 수 있습니다


```shell
nb plugin install nonebot-plugin-deepseek
```

</details>
<details>
<summary>패키지 관리자 사용하여 설치</summary>

```shell
pip install nonebot-plugin-deepseek
# or, use poetry
poetry add nonebot-plugin-deepseek
# or, use pdm
pdm add nonebot-plugin-deepseek
```

NoneBot 프로젝트 루트 디렉토리의 설정 파일을 열고, `[plugin]` 부분에 다음 내용을 추가로 작성하세요.

```toml
plugins = ["nonebot_plugin_deepseek"]
```
</details>

## ⚙️ 구성

프로젝트의 구성 파일에 아래 표의 구성을 추가하세요

> [!note]
> `api_key` 는 [DeepSeek 오픈 플랫폼](https://platform.deepseek.com/)에서 받아야 합니다  
> `enable_models` 는 [`CustomModel`](https://github.com/KomoriDev/nonebot-plugin-deepseek/blob/ee9f0b0f0568eedb3eb87423e6c1bf271787ab76/nonebot_plugin_deepseek/config.py#L34) 구조의 딕셔너리이며, 로컬 모델 연동이 필요하지 않으면 수정할 필요가 없습니다  
> 로컬 모델 연동을 원한다면: 👉 [Wiki - 로컬 모델 연동](https://github.com/KomoriDev/nonebot-plugin-deepseek/wiki/本地模型) 을 참고하세요  

|              구성 항목              | 필수  |                             기본값                             |                                                                          설명                                                                          |
| :------------------------------: | :---: | :------------------------------------------------------------: | :----------------------------------------------------------------------------------------------------------------------------------------------------: |
|        deepseek__api_key         |  예   |                               없음                              |                                                                        API Key                                                                         |
|     deepseek__enable_models      |  아니오   | [{ "name": "deepseek-chat" }, { "name": "deepseek-reasoner" }] | 활성화된 모델 [구성 설명](https://github.com/KomoriDev/nonebot-plugin-deepseek/wiki/%E9%85%8D%E7%BD%AE#enable_models-%E9%85%8D%E7%BD%AE%E8%AF%B4%E6%98%8E) |
|         deepseek__prompt         |  아니오   |                               없음                              |                                                                        모델 프롬프트                                                                        |
|         deepseek__stream         |  아니오   |                             False                              |                                                                    스트리밍 전송 사용 여부                                                                    |
|        deepseek__timeout         |  아니오   |             {"api_request": 100, "user_input": 60}             |                                                                        타임아웃 설정                                                                        |
|       deepseek__md_to_pic        |  아니오   |                             False                              |                                                                Markdown을 이미지로 변환 사용 여부                                                                |
|  deepseek__enable_send_thinking  |  아니오   |                             False                              |                                                                     사고 사슬 전송 여부                                                                     |

## 🎉 사용법

> [!note]
> `COMMAND_START` 와 위 구성 항목을 확인하세요. 기본적으로 `/`를 사용합니다

### 도움말


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

빠른 명령어: `/ds [내용]` 또는 텍스트 메시지로 답장

### 다중 대화

```bash
/deepseek --with-context [内容]
```

단축 명령어: `/ds --with-context [내용]` `/다중 대화`

### 심층 사고

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

단축 명령어: `/모델목록` `/기본모델설정 [모델명]`

### 사용자 정의 단축 명령어

> 이 기능은 [Alconna 단축 명령어](https://nonebot.dev/docs/2.3.3/best-practice/alconna/command#command%E7%9A%84%E4%BD%BF%E7%94%A8)에 의존합니다. 사용자 정의 명령어에는 `COMMAND_START`가 포함되지 않으며, 필요시 수동으로 입력해야 합니다.

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
## 📸 효과 이미지

<p align="center">
  <a href="https://github.com/KomoriDev/nonebot-plugin-deepseek" target="__blank">
    <picture>
      <source media="(prefers-color-scheme: dark)" srcset="./docs/screenshot-dark.png">
      <source media="(prefers-color-scheme: light)" srcset="./docs/screenshot-light.png">
      <img src="https://raw.githubusercontent.com/KomoriDev/nonebot-plugin-deepseek/master/./docs/screenshot-light.png" alt="DeepSeek - Preview" width="100%" />
    </picture>
  </a>
</p>

## 💖 감사의 말
  
- [`KomoriDev/Starify`](https://github.com/KomoriDev/Starify)：매력적인 배지를 제공해 주셨습니다

### 기여자들

<a href="#-鸣谢">
  <img src="https://img.shields.io/badge/all_contributors-5-orange.svg?style=flat-square" alt="contributors" />
</a>
<a href="https://afdian.com/@komoridev">
  <img src="https://img.shields.io/badge/all_sponsors-17-946ce6.svg?style=flat-square" alt="sponsors" />
</a>

이 프로젝트에 기여해 주신 분들께 감사드립니다:

<a href="https://github.com/KomoriDev/nonebot-plugin-deepseek/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=KomoriDev/nonebot-plugin-deepseek&max=1000" alt="contributors" />
</a>

## 📄 라이선스

이 프로젝트는 [MIT](./LICENSE) 라이선스로 오픈소스화 되어 있습니다


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