<div align="center">

# fbchat-muqit API de Facebook y Messenger

![PyPI - Python Version](https://img.shields.io/pypi/pyversions/fbchat-muqit)
![PyPI - Version](https://img.shields.io/pypi/v/fbchat-muqit)
[![License: GPLv3](https://img.shields.io/badge/License-GPLv3-blue.svg)](https://www.gnu.org/licenses/gpl-3.0)

**fbchat-muqit** Una API asincrónica no oficial de Facebook Messenger diseñada para interactuar con Facebook y Messenger. Como es una API no oficial, no nos hacemos responsables si Facebook te bloquea. Recomendamos usar una cuenta dummy de Facebook. Para más detalles consulta la [Documentación](http://fbchat-muqit.rtfd.io/).

</div>

> [!Note]
> Actualizado de la versión `1.1.31` a `1.2.0` y la versión `1.2.0` es una versión reescrita, lo que significa que la biblioteca ha sido completamente reescrita y se han realizado cambios importantes. La API ahora está completamente documentada y los ejemplos de uso están actualizados.

> [!WARNING]
> Debido a la encriptación `end-to-end` enviar mensajes a otros usuarios ya no está soportado. Puedes enviar mensajes a chats grupales, chats de sala y a páginas. [Ver más](https://about.fb.com/news/2024/03/end-to-end-encryption-on-messenger-explained/)
> Aún puedes enviar mensajes a otro usuario si esa cuenta de usuario está inactiva por muchos años porque la encriptación `end-to-end` no se aplica al enviar mensajes a esas cuentas a menos que la cuenta se reactive.

## 🛠️ Instalación

Puedes instalar fbchat-muqit usando pip:

```bash
pip install fbchat-muqit

```

Para la última versión de desarrollo:

```bash
pip install git+https://github.com/togashigreat/fbchat-muqit.git

```

## 📙 Documentación

La API está documentada. [Leer la documentación](http://fbchat-muqit.rtfd.io/).
La versión antigua [1.1.31](https://fbchat-muqit.readthedocs.io/en/v1.1.31/) de la documentación también está disponible.

## 🔧 Requisitos previos

- Python 3.9+
- Una cuenta de Facebook (es más seguro usar una cuenta antigua no utilizada)
- Cookies de la cuenta de Facebook 🍪

## 📖 Ejemplo de uso

Para iniciar sesión en Facebook necesitarás las cookies de la cuenta de Facebook. Ya que el inicio de sesión vía correo y contraseña ya no es soportado.

Para obtener las cookies de tu cuenta de Facebook. Primero inicia sesión en tu cuenta de Facebook y luego añade la [extensión C3C para Chrome](https://github.com/c3cbot/c3c-ufc-utility) en tu navegador. Abre tu cuenta de Facebook en una pestaña del navegador y usa esta extensión para obtener las cookies de tu cuenta. Copia las cookies y guárdalas en un archivo json. Usaremos las cookies para interactuar con el servidor de Facebook. Llamaremos a esta cuenta `Cliente`.

Un ejemplo básico de cómo usarlo.

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
Guarde el código en el archivo `test.py` y ahora ejecute el código.


```bash
python3 test.py
```
Si inicia sesión correctamente, use otra cuenta de Facebook para crear un grupo de Messenger y agregue ambas cuentas al grupo. Ahora, envíe un mensaje al grupo y la cuenta cliente fbchat_muqit escuchará todos los mensajes y eventos entrantes. Si todo funciona correctamente, debería responder y reaccionar al mensaje enviado por su otra cuenta con un emoji.

### 📄 Licencia

Este proyecto se distribuye bajo un modelo de doble licencia:

- **Licencia BSD-3-Clause**: Partes del código se reutilizan y adaptan de la biblioteca original [fbchat](https://github.com/fbchat-dev/fbchat), licenciada bajo BSD-3-Clause.
  Vea [LICENSE-BSD](https://raw.githubusercontent.com/togashigreat/fbchat-muqit/main/./LICENSE-BSD.md) para detalles.

- **Licencia GPL v3**: Nuevas contribuciones y modificaciones por Muhammad MuQiT/togashigreat están licenciadas bajo GPL v3.0.
  Vea [LICENSE](https://raw.githubusercontent.com/togashigreat/fbchat-muqit/main/./LICENSE.md) para detalles.

### ✉️Contáctame

- [Facebook](https://facebook.com/muqit.dev)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-22

---