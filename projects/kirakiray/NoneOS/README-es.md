# NoneOS - Un Sistema Operativo Virtual Ligero Basado en Navegador

[中文](https://raw.githubusercontent.com/kirakiray/NoneOS/main/./md/README_CN.md) | [日本語](https://raw.githubusercontent.com/kirakiray/NoneOS/main/./md/README_JP.md)

## Introducción al Proyecto

NoneOS es una solución innovadora de sistema operativo virtual basado en navegador que adopta una arquitectura de archivos estáticos puros y puede funcionar sin el soporte de un servidor backend.

Objetivo a corto plazo: Crear un sistema NAS ligero basado en navegador, logrando conexión y colaboración sin interrupciones entre dispositivos.

- [x] Soporte para gestión de archivos basada en navegador
- [x] Aplicación de sincronización de marcadores
- [x] Aplicación de sincronización de notas (similar a Notion)
- [x] Aplicación de transferencia de archivos (similar a LocalSend)
- [ ] Reconstruir la aplicación de sincronización de notas

## Inicio Rápido

Visite directamente el sitio oficial: [https://os.noneos.com/](https://os.noneos.com/)

### Ejecución Local
1. Clone o descargue el proyecto y asegúrese de que nodejs esté instalado localmente.
2. Instale las dependencias:
```bash
npm install
```
3. Inicie el servidor:
```bash
npm run static
```
1. Visite: `http://localhost:5559/`

## ¿Cómo Crear una Aplicación?

NoneOS adopta una arquitectura avanzada de microaplicaciones web, con cada aplicación construida sobre el potente framework ofa.js. Los desarrolladores pueden crear fácilmente sus propias aplicaciones simplemente importando el directorio de la aplicación (como la aplicación de ejemplo `others/hello-world.napp`) en la carpeta "Apps" del sistema para desplegarla y ejecutarla rápidamente.

Actualmente estamos redactando una documentación de desarrollo más detallada. Mientras tanto, los desarrolladores pueden:
- Consultar la documentación oficial de ofa.js para entender las características del framework.
- Revisar las aplicaciones de ejemplo en el directorio `packages/apps` como referencia para el desarrollo.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-22

---