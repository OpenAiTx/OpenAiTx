# Especificación del Protocolo Universal de Llamada de Herramientas (UTCP)

Este repositorio contiene la documentación oficial de la especificación para el Protocolo Universal de Llamada de Herramientas (UTCP). UTCP es un estándar moderno, flexible y escalable para definir e interactuar con herramientas a través de varios protocolos de comunicación.

## ¿Qué es UTCP?

UTCP proporciona una forma estandarizada para que los sistemas de IA y otros clientes descubran y llamen herramientas de diferentes proveedores, independientemente del protocolo subyacente utilizado (HTTP, WebSocket, CLI, etc.). Esta especificación define:

- Mecanismos de descubrimiento de herramientas
- Formatos de llamada de herramientas
- Configuración del proveedor
- Métodos de autenticación
- Manejo de respuestas

## Contribuir a la Especificación

¡Damos la bienvenida a las contribuciones a la especificación de UTCP! Así es como puedes contribuir:

1. **Haz un fork del repositorio**: Crea tu propio fork del repositorio de la especificación
2. **Realiza tus cambios**: Actualiza o agrega documentación según sea necesario
3. **Envía un pull request**: Abre un PR con tus cambios para su revisión
4. **Participa en las discusiones**: Únete a la conversación sobre los cambios propuestos

Al contribuir, sigue estas pautas:

- Asegúrate de que tus cambios estén alineados con la visión y los objetivos generales de UTCP
- Sigue la estructura y el formato establecidos de la documentación
- Incluye ejemplos al agregar nuevas características o conceptos
- Actualiza las secciones relevantes para mantener la coherencia en la documentación

## Construir la Documentación Localmente

### Requisitos previos

Para construir y previsualizar el sitio de documentación localmente, necesitarás:

- Ruby versión 2.5.0 o superior
- RubyGems
- Bundler

### Configuración

1. Clona el repositorio:
   ```bash
   git clone https://github.com/universal-tool-calling-protocol/utcp-specification.git
   cd utcp-specification
   ```
2. Instale las dependencias:

   ```bash
   bundle install
   ```
### Ejecutar el sitio de documentación

Para compilar y servir el sitio localmente:


```bash
bundle exec jekyll serve
```
Esto iniciará un servidor web local en `http://localhost:4000` donde puedes previsualizar la documentación.

## Estructura de la Documentación

La documentación de UTCP está organizada de la siguiente manera:

- `index.md`: Página principal e introducción a UTCP
- `docs/`
  - `introduction.md`: Introducción detallada y conceptos clave
  - `for-tool-providers.md`: Guía para implementar proveedores de herramientas
  - `for-tool-callers.md`: Guía para implementar llamadores de herramientas
  - `providers/`: Documentación para cada tipo de proveedor
    - `http.md`: Proveedor HTTP
    - `websocket.md`: Proveedor WebSocket
    - `cli.md`: Proveedor CLI
    - `sse.md`: Proveedor Server-Sent Events (SSE)
    - etc.
  - `implementation.md`: Guías de implementación y mejores prácticas

## Trabajo con la Especificación

### Modificación de la Documentación

La documentación está escrita en formato Markdown con front matter de Jekyll. Al realizar cambios:

1. Asegúrate de que tu Markdown siga el estilo establecido
2. Previsualiza los cambios localmente antes de enviar PRs
3. Mantén los ejemplos actualizados con la última especificación
4. Actualiza los elementos de navegación en `_config.yml` si añades nuevas páginas

### Organización de Archivos

Al agregar nueva documentación:

- Coloca la documentación específica de proveedores en `docs/providers/`
- Usa front matter coherente con un orden de navegación apropiado
- Incluye etiquetas para mejorar la buscabilidad en GitHub Pages

## Control de Versiones

La especificación UTCP sigue versionado semántico:

- Versiones mayores (1.0, 2.0): Cambios incompatibles en el protocolo
- Versiones menores (1.1, 1.2): Nuevas características añadidas de forma retrocompatible
- Versiones de parche (1.0.1, 1.0.2): Correcciones de errores y aclaraciones retrocompatibles

## Licencia

Esta especificación se distribuye bajo la Licencia Pública de Mozilla 2.0 (MPL-2.0).

## Recursos Adicionales

- [Organización UTCP en GitHub](https://github.com/universal-tool-calling-protocol)
- [Sitio Web de UTCP](https://utcp.io)
- [Implementaciones de Referencia](https://github.com/universal-tool-calling-protocol/python-utcp)
- [Debates de la Comunidad](https://github.com/universal-tool-calling-protocol/utcp-specification/discussions)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-24

---