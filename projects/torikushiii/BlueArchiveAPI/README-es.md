
# API de Blue Archive

## *Esta API proporciona datos tanto para las versiones global y japonesa de Blue Archive.*

- [Blue Archive EN](https://bluearchive.nexon.com/home): Sitio oficial EN
- [Blue Archive JP](https://bluearchive.jp/): Sitio oficial JP

API que proporciona varios datos del juego Blue Archive. Si quieres contribuir a este proyecto, siéntete libre de abrir un pull request o un issue. Si quieres apoyarme, puedes donar en mi [Ko-Fi](https://ko-fi.com/torikushiii).

**API alojada en https://api.ennead.cc/buruaka**

## Requisitos previos

- [Go](https://go.dev/dl/): 1.24 o superior
- Instancia MongoDB accesible por la API (el URI predeterminado es `mongodb://localhost:27017`)

## Configuración

Las opciones en tiempo de ejecución se cargan desde un archivo YAML. Por defecto el servidor lee `config.yaml` en la raíz del proyecto. Establece la variable de entorno `CONFIG_PATH` para apuntar a un archivo de configuración alternativo si es necesario.

Consulta `config.yaml` para un ejemplo que coincide con los valores predeterminados locales.

## Ejecutando la API

Construye las dependencias y arranca el servidor usando Go:

```bash
go run ./cmd/server
```

La dirección del receptor se controla mediante la configuración (por defecto `0.0.0.0:9999`). Todos los puntos finales REST se sirven bajo la ruta base `/buruaka` (por ejemplo, `/buruaka/character`), y el servidor se conecta a MongoDB utilizando la URI configurada para entregar datos de personajes, incursiones y pancartas.

Para producir un binario independiente:

```bash
go build -o server ./cmd/server
```
Ejecutar pruebas con:


```bash
go test ./...
```

## Documentación de la API REST

Los detalles del endpoint están en la carpeta [docs](https://github.com/torikushiii/BlueArchiveAPI/tree/main/docs).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-31

---