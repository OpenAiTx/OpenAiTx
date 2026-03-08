# cq - Motor de Consulta SQL de Alto Rendimiento para Archivos CSV

 [![Compilación Cruzada y Pruebas (con el sistema de compilación zig)](https://github.com/baldimario/cq/actions/workflows/build-zig-cross.yml/badge.svg)](https://github.com/baldimario/cq/actions/workflows/build-zig-cross.yml)

Un procesador de consultas SQL ligero y rápido escrito en C que permite ejecutar consultas SQL directamente sobre archivos CSV sin necesidad de una base de datos. Para la documentación completa, consulte el directorio /doc.

 ![cq en acción](https://raw.githubusercontent.com/baldimario/cq/main/assets/cq.png)

## Documentación

- Primeros Pasos: `doc/GettingStarted.md`
- Instalación: `doc/Installation.md`
- Interfaz de Línea de Comandos: `doc/CLI.md`
- **TUI (Interfaz de Usuario en Terminal)**: `doc/TUI.md`
- Arquitectura: `doc/Architecture.md`
- Pruebas: `doc/Testing.md`
- Hoja de Ruta: `doc/Roadmap.md`
- Contribuciones: `doc/Contributing.md`

## Inicio Rápido

Construir: `make`

### Línea de Comandos

Ejecute una consulta de ejemplo:
`./build/cq -q "SELECT name, age FROM 'data.csv' WHERE age > 25" -p`

### Interfaz de Terminal

Lanzar TUI interactivo:
`./build/cqtui data/`

Características:
- Navegar y abrir archivos CSV como tablas
- Ejecutar consultas SQL de forma interactiva
- Interfaz de pestañas múltiples para varias tablas
- Navegación mediante teclado
- Sin dependencias externas

## Archivos SQL de Ejemplo

El repositorio incluye ejemplos de SQL en assets/ (example_between.sql, example_aggregation.sql, etc.). Consulte assets/ para más detalles.

## Resumen de Datos y Características

- Consulte la carpeta /doc para secciones detalladas sobre tipos de datos, formatos de fecha, formato CSV y más.

## Licencia

Licencia MIT. Consulte el archivo LICENSE para más detalles.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-08

---