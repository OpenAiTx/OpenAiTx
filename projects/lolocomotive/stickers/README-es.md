# Stickers

Creador simple de stickers para Android para WhatsApp sin anuncios.

[![](https://upload.wikimedia.org/wikipedia/commons/7/78/Google_Play_Store_badge_EN.svg)](https://play.google.com/store/apps/details?id=de.loicezt.stickers)

O descarga desde la última [versión en GitHub](https://github.com/lolocomotive/stickers/releases)

## Características

- Modo rápido: compartir una imagen con la app la añade automáticamente a WhatsApp
- Editor
    - Recorta tu sticker tanto como quieras
    - Añade textos con diferentes tamaños, fuentes y colores
    - Dibuja con diferentes colores y tamaños de pincel, con soporte de deshacer/rehacer
    - Cada elemento tiene su propia capa bajo el capó, para que puedas dibujar encima y debajo de los textos
- Importar/Exportar
    - Exporta a `.zip` para compartir o hacer copias de seguridad de tus paquetes
    - Importa desde varios formatos (propio formato `.zip`, `.wastickers`, `.stickify`, no debería ser muy
      difícil añadir más porque la mayoría son solo un archivo ZIP con imágenes y un manifiesto simple)
- Crea, edita y elimina múltiples paquetes y sus metadatos (autor, título, icono de bandeja y más)

## Capturas de pantalla

| Inicio                            | Vista del paquete                 | Editor                                |
|-----------------------------------|-----------------------------------|---------------------------------------|
| ![home.png](https://raw.githubusercontent.com/lolocomotive/stickers/main/screenshots/home.png) | ![pack.png](https://raw.githubusercontent.com/lolocomotive/stickers/main/screenshots/pack.png) | ![editor.png](https://raw.githubusercontent.com/lolocomotive/stickers/main/screenshots/editor.png) |

## Compilación

`flutter run` debería funcionar perfectamente, sin embargo si quieres compilar la versión de lanzamiento de la app,
necesitarás o bien:

<details>
<summary>Usar tu propia clave de firma</summary>

En `android/` crea `key.properties` con

```properties
storeFile=path/to/keystore.jks
keyAlias=your key alias
storePassword=your store password
keyPassword=your key password
```

Más detalles: https://docs.flutter.dev/deployment/android#sign-the-app

</details>

o

<details>
<summary>Usar la configuración de firma de depuración</summary>

En `android/app/build.gradle` alrededor de la línea 29

```
buildTypes {
  release {
    signingConfig signingConfigs.release
  }
}
```

reemplazar `signingConfigs.release` con `signingConfigs.debug` y eliminar

```
def keystoreProperties = new Properties()
def keystorePropertiesFile = rootProject.file("key.properties")
if (keystorePropertiesFile.exists()) {
    keystorePropertiesFile.withReader('UTF-8') { reader ->
        keystoreProperties.load(reader)
    }
}
```

and

```
signingConfigs {
    create("release") {
        keyAlias = keystoreProperties["keyAlias"]
        keyPassword = keystoreProperties["keyPassword"]
        storeFile = new File(keystoreProperties["storeFile"])
        storePassword = keystoreProperties["storePassword"]
    }
}
```

Y *debería* funcionar, solo úsalo para pruebas.
</details>

Y luego solo necesitas

```
flutter build apk
```

## Contribuyendo

¡Cualquier contribución (Pull requests, solicitudes de funciones e informes de errores) es muy bienvenida!
Ten en cuenta que he configurado mi ancho de línea a 120 en lugar de 80, así que ten cuidado antes de reformatear archivos
enteros. Si estás usando vscode, coloca lo siguiente en `.vscode/settings.json` .

```json
{
  "dart.lineLength": 120,
  "[dart]": {
    "editor.rulers": [
      120
    ]
  }
}
```

También el código no está muy bien documentado todavía, así que disculpas de antemano a cualquiera que intente leerlo.

## POR HACER

Algunas funciones en las que planeo trabajar en el futuro

- [ ] Seleccionar múltiples paquetes a la vez en la pantalla principal
- [ ] Añadir opción para agregar un fondo a los textos
- [ ] Capas de imagen en los stickers
- [ ] Empezar con un sticker existente
- [ ] Crear stickers animados a partir de gifs
- [ ] Recortar y rotar videos

## Soporte para iOS

No poseo ningún dispositivo Apple, por lo tanto no puedo compilar para iOS ni probar la app de iOS. Es una app de Flutter
así que debería funcionar más o menos.
Si quieres añadir soporte para iOS, ¡eres bienvenido! Aquí algunas cosas a tener en cuenta:

- `image_editor` tendría que ser modificado para soportar WEBP en iOS (solo añadí soporte para WEBP en
  Android)
- El paquete `whatsapp_stickers_plus` podría no funcionar (no funcionó en Android).
- Muchos widgets tendrían que ser reemplazados por su equivalente `.adaptive` si quieres que se vea
  como una app de iOS


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-30

---