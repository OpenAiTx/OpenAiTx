# frp-android

Un client frp pour Android. Un client frp pour la plateforme Android.

## À propos de frp

[frp](https://github.com/fatedier/frp) est une application de proxy inverse haute performance axée sur le contournement de réseau local, prenant en charge plusieurs protocoles tels que TCP, UDP, HTTP, HTTPS.

## Fonctionnalités

- **Mode double frpc et frps** : prend en charge l'exécution en tant que client ou serveur
- **Formats de configuration multiples** : prise en charge des formats INI, TOML, YAML, JSON
- **Gestion de configuration** : tri par glisser-déposer long, importation et exportation de configurations
- **Sans Root** : utilisation possible sur mobile sans accès root
- **Exécution en arrière-plan** : prise en charge du service en arrière-plan, possibilité de démarrer/arrêter chaque configuration individuellement

## Instructions de compilation

### Exigences environnementales

- [Android Studio](https://developer.android.com/studio) 3.2+
- JDK 8+
- Android SDK API 19+ (minSdk)
- Bibliothèque dynamique frp : doit être préparée par l'utilisateur ou téléchargée via la gestion de version intégrée à l'application

### Étapes de compilation

```bash
# 克隆仓库
git clone https://github.com/jahen/frp-android.git
cd frp-android

# 构建 Debug
./gradlew assembleDebug

# 构建 Release（默认使用 debug 签名，如需正式签名请配置 keystore）
./gradlew assembleRelease
```

### Signature de la Release (optionnel)

Pour signer un paquet Release avec un keystore personnalisé :

1. Copiez `keystore.properties.example` et renommez-le en `keystore.properties` (à placer à la racine du projet)
2. Ouvrez `keystore.properties` avec un éditeur de texte et remplissez vos informations de keystore :
   - `storeFile` : chemin du fichier keystore (par rapport à la racine du projet, par exemple `../release.keystore` signifie le dossier parent)
   - `storePassword` : mot de passe du keystore
   - `keyAlias` : alias de la clé
   - `keyPassword` : mot de passe de la clé
3. Assurez-vous que le fichier keystore existe au chemin indiqué dans `storeFile`

```properties
# keystore.properties 示例
storeFile=../release.keystore
storePassword=your_store_password
keyAlias=your_key_alias
keyPassword=your_key_password
```

**注意：`keystore.properties` 和 `*.keystore` 已加入 `.gitignore`，切勿提交！**

## 许可证

[Apache License 2.0](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-16

---