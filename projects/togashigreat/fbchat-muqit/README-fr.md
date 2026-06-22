<div align="center">

# fbchat-muqit API Facebook & Messenger

![PyPI - Python Version](https://img.shields.io/pypi/pyversions/fbchat-muqit)
![PyPI - Version](https://img.shields.io/pypi/v/fbchat-muqit)
[![License: GPLv3](https://img.shields.io/badge/License-GPLv3-blue.svg)](https://www.gnu.org/licenses/gpl-3.0)

**fbchat-muqit** Une API asynchrone non officielle pour Facebook Messenger conçue pour interagir avec Facebook et Messenger. Étant une API non officielle, nous ne sommes pas responsables si vous êtes banni par Facebook. Nous recommandons d’utiliser un compte Facebook fictif. Pour plus de détails, consultez la [Documentation](http://fbchat-muqit.rtfd.io/).

</div>

> [!Note]
> Passage de la version `1.1.31` à la `1.2.0` ; la version `1.2.0` est une réécriture complète, ce qui signifie que la bibliothèque a été entièrement réécrite et que des changements majeurs ont été apportés. L’API est désormais entièrement documentée et les exemples d’utilisation ont été mis à jour.

> [!WARNING]
> En raison du chiffrement `de bout en bout`, l’envoi de messages à d’autres utilisateurs n’est plus pris en charge. Vous pouvez envoyer des messages aux discussions de groupe, aux salons de discussion et aux pages. [Voir plus](https://about.fb.com/news/2024/03/end-to-end-encryption-on-messenger-explained/)
> Vous pouvez toujours être en mesure d’envoyer des messages à un autre utilisateur si ce compte est inactif depuis plusieurs années, car le chiffrement `de bout en bout` n’est pas appliqué lors de l’envoi de messages à ces comptes, sauf si le compte est réactivé.

## 🛠️ Installation

Vous pouvez installer fbchat-muqit avec pip :

```bash
pip install fbchat-muqit

```
Pour la dernière version de développement :


```bash
pip install git+https://github.com/togashigreat/fbchat-muqit.git

```

## 📙 Documentation

L'API est documentée. [Lire la documentation](http://fbchat-muqit.rtfd.io/).
La version plus ancienne [1.1.31](https://fbchat-muqit.readthedocs.io/en/v1.1.31/) de la documentation est également disponible.

## 🔧 Prérequis

- Python 3.9+
- Un compte Facebook (Il est plus sûr d'utiliser un ancien compte inutilisé)
- Cookies du compte Facebook 🍪

## 📖 Exemple d'utilisation

Pour se connecter à Facebook, vous aurez besoin des cookies du compte Facebook. La connexion via email et mot de passe n'est plus prise en charge.

Pour obtenir les cookies de votre compte Facebook. Connectez-vous d'abord à votre compte Facebook, puis ajoutez l'[extension Chrome C3C](https://github.com/c3cbot/c3c-ufc-utility) dans votre navigateur. Ouvrez votre compte Facebook dans un onglet du navigateur et utilisez cette extension pour récupérer les cookies de votre compte. Copiez les cookies et enregistrez-les dans un fichier json. Nous utiliserons ces cookies pour interagir avec le serveur Facebook. Nous appellerons ce compte le compte `Client`.

Un exemple basique de son utilisation.

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

Enregistrez le code dans le fichier `test.py` et exécutez maintenant le code.

```bash
python3 test.py
```

Si la connexion réussit, utilisez un autre compte Facebook pour créer un groupe Messenger et ajoutez les deux comptes au groupe. Maintenant, envoyez un message au groupe et le compte client fbchat_muqit écoutera tous les messages et événements entrants. Si tout fonctionne correctement, il devrait répondre et réagir au message envoyé par votre autre compte avec un emoji.

### 📄 Licence

Ce projet est distribué sous un modèle de double licence :

- **Licence BSD-3-Clause** : Des parties du code sont réutilisées et adaptées de la bibliothèque originale [fbchat](https://github.com/fbchat-dev/fbchat), sous licence BSD-3-Clause.
  Voir [LICENSE-BSD](https://raw.githubusercontent.com/togashigreat/fbchat-muqit/main/./LICENSE-BSD.md) pour plus de détails.

- **Licence GPL v3** : Les nouvelles contributions et modifications par Muhammad MuQiT/togashigreat sont sous licence GPL v3.0.
  Voir [LICENSE](https://raw.githubusercontent.com/togashigreat/fbchat-muqit/main/./LICENSE.md) pour plus de détails.

### ✉️Contactez-moi

- [Facebook](https://facebook.com/muqit.dev)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-22

---