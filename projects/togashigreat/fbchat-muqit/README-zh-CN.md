<div align="center">

# fbchat-muqit Facebook 与 Messenger API

![PyPI - Python Version](https://img.shields.io/pypi/pyversions/fbchat-muqit)
![PyPI - Version](https://img.shields.io/pypi/v/fbchat-muqit)
[![License: GPLv3](https://img.shields.io/badge/License-GPLv3-blue.svg)](https://www.gnu.org/licenses/gpl-3.0)

**fbchat-muqit** 是一个非官方的异步 Facebook Messenger API，旨在与 Facebook 和 Messenger 交互。由于这是非官方 API，我们不对您被 Facebook 禁止使用负责。建议使用一个虚拟 Facebook 账户。更多详情请查看 [文档](http://fbchat-muqit.rtfd.io/)。

</div>

> [!Note]
> 从版本 `1.1.31` 升级到 `1.2.0`，版本 `1.2.0` 是重写版本，意味着库已被完全重写并进行了重大更改。API 现已完全文档化，使用示例也已更新。

> [!WARNING]
> 由于 `端到端` 加密，发送消息给其他用户已不再支持。您可以发送消息到群聊、房间聊天和页面。[查看更多](https://about.fb.com/news/2024/03/end-to-end-encryption-on-messenger-explained/)
> 如果另一个用户账户多年未激活，您仍可能能够发送消息，因为发送消息到这些账户时不会应用 `端到端` 加密，除非该账户重新启用。

## 🛠️ 安装

您可以使用 pip 安装 fbchat-muqit：

```bash
pip install fbchat-muqit

```

对于最新的开发版本：

```bash
pip install git+https://github.com/togashigreat/fbchat-muqit.git

```

## 📙 文档

该 API 有文档。[阅读文档](http://fbchat-muqit.rtfd.io/)。
旧版本 [1.1.31](https://fbchat-muqit.readthedocs.io/en/v1.1.31/) 的文档也可用。

## 🔧 先决条件

- Python 3.9+
- 一个 Facebook 账户（使用旧的未使用账户更安全）
- Facebook 账户 Cookies 🍪

## 📖 使用示例

登录 Facebook 需要 Facebook 账户 Cookies。因为不再支持通过邮箱和密码登录。

获取 Facebook 账户 Cookies，首先登录你的 Facebook 账户，然后在浏览器中添加 [C3C Chrome 扩展](https://github.com/c3cbot/c3c-ufc-utility)。在浏览器标签页打开你的 Facebook 账户，使用该扩展获取账户 Cookies。复制 Cookies 并保存到 json 文件中。我们将使用这些 Cookies 与 Facebook 服务器交互。我们称该账户为 `Client` 账户。

以下是一个基本的使用示例。

```python
from fbchat_muqit import Client, Message, EventType

client = Client(cookies_file_path="cookies.json")

@client.event
async def on_message(message: Message):
    # To avoid spam check if sender_id is client's id or not
    if message.sender_id != client.uid:
        # echo the message
        await client.send_message(message.text, message.thread_id)

client.run()

```
将代码保存到文件 `test.py` 中，然后运行该代码。


```bash
python3 test.py
```
如果登录成功，则使用另一个 Facebook 账户创建一个 Messenger 群组，并将两个账户都添加到该群组中。现在，向群组发送消息，fbchat_muqit 客户端账户将监听所有传入的消息和事件。如果一切正常，它应该会回复并用表情符号对你另一个账户发送的消息做出反应。

### 📄 许可证

本项目采用双许可证模式分发：

- **BSD-3-Clause 许可证**：部分代码重用并改编自原始的 [fbchat](https://github.com/fbchat-dev/fbchat) 库，许可协议为 BSD-3-Clause 许可证。  
  详情请参见 [LICENSE-BSD](https://raw.githubusercontent.com/togashigreat/fbchat-muqit/main/./LICENSE-BSD.md)。

- **GPL v3 许可证**：Muhammad MuQiT/togashigreat 的新贡献和修改均采用 GPL v3.0 许可证。  
  详情请参见 [LICENSE](https://raw.githubusercontent.com/togashigreat/fbchat-muqit/main/./LICENSE.md)。

### ✉️联系我

- [Facebook](https://facebook.com/muqit.dev)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-22

---