# frp-android

Un cliente frp para Android. 一个 Android 平台的 frp 客户端。

## Acerca de frp

[frp](https://github.com/fatedier/frp) es una aplicación de proxy inverso de alto rendimiento enfocada en la penetración de redes internas, que soporta múltiples protocolos como TCP, UDP, HTTP, HTTPS, entre otros.

## Características

- **Modo dual frpc y frps**: soporta ejecución como cliente o servidor  
- **Múltiples formatos de configuración**: soporta INI, TOML, YAML, JSON  
- **Gestión de configuraciones**: ordenar con pulsación larga y arrastre, importar y exportar configuraciones  
- **Sin Root**: no requiere root en el dispositivo móvil  
- **Ejecución en segundo plano**: soporta servicios en background, con inicio/parada individual por configuración  

## Instrucciones de construcción

### Requisitos del entorno

- [Android Studio](https://developer.android.com/studio) 3.2+  
- JDK 8+  
- Android SDK API 19+ (minSdk)  
- Biblioteca dinámica frp: debe prepararse por cuenta propia o descargarse mediante la gestión de versiones dentro de la aplicación  

### Pasos para construir  

```bash
# 克隆仓库
git clone https://github.com/jahen/frp-android.git
cd frp-android

# 构建 Debug
./gradlew assembleDebug

# 构建 Release（默认使用 debug 签名，如需正式签名请配置 keystore）
./gradlew assembleRelease
```

### Firma de Release (Opcional)

Para firmar el paquete Release con un keystore personalizado:

1. Copia `keystore.properties.example` y renómbralo a `keystore.properties` (colócalo en el directorio raíz del proyecto)
2. Abre `keystore.properties` con un editor de texto y rellena la información de tu keystore:
   - `storeFile`: ruta al archivo keystore (relativa al directorio raíz del proyecto, por ejemplo `../release.keystore` indica el directorio superior)
   - `storePassword`: contraseña del keystore
   - `keyAlias`: alias de la clave
   - `keyPassword`: contraseña de la clave
3. Asegúrate de que el archivo keystore exista en la ruta especificada en `storeFile`

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