# Trimmer

[![ci](https://github.com/jonlabelle/Trimmer/actions/workflows/ci.yml/badge.svg?branch=master)](https://github.com/jonlabelle/Trimmer/actions/workflows/ci.yml)
[![Package Control Installs](https://img.shields.io/packagecontrol/dt/Trimmer.svg?label=installs)](https://packagecontrol.io/packages/Trimmer)
[![Latest Release](https://img.shields.io/github/tag/jonlabelle/Trimmer.svg?label=version)](https://github.com/jonlabelle/Trimmer/releases)
[![MIT License](https://img.shields.io/badge/License-MIT-blue.svg)](https://github.com/jonlabelle/Trimmer/blob/master/LICENSE.md)

> [Trimmer](https://github.com/jonlabelle/Trimmer) es un complemento para [Sublime Text](http://www.sublimetext.com) para limpiar espacios en blanco.

## Características

- Eliminar espacios en blanco al final de cada línea.
- Eliminar espacios en blanco al inicio de cada línea.
- Eliminar espacios en blanco al inicio y al final de cada línea.
- Eliminar espacios en blanco de la(s) selección(es).
- Eliminar líneas vacías que contienen solo espacios en blanco.
- Colapsar múltiples líneas vacías consecutivas en una sola línea vacía.
- Colapsar múltiples espacios consecutivos en un solo espacio.
- Eliminar líneas vacías que contienen solo espacios en blanco al principio y al final del archivo.
- Eliminar caracteres de espacio en blanco.
- Normalizar espacios (espacios consecutivos reducidos, líneas vacías eliminadas y líneas recortadas).
- Tokenizar una cadena colapsando espacios consecutivos y eliminando espacios al inicio y al final.
- Eliminar etiquetas HTML y XML vacías que contienen solo espacios en blanco.
- Eliminar comentarios de código y colapsar líneas.
- Eliminar líneas duplicadas adyacentes.

## Características Adicionales

Un comando **Reemplazar Caracteres Inteligentes** que realiza las siguientes acciones:

- **Comillas simples inteligentes:** `’` _a_ `'`
- **Comillas dobles inteligentes:** `“` _a_ `"`
- **Prima:** `′` _a_ `'`
- **Doble prima:** `″` _a_ `"`
- **Comillas alemanas:** `„` _a_ `"` y `‚` _a_ `'`
- **Elipsis:** `…` _a_ `...`
- **Guion largo (em dash):** `—` _a_ `---`
- **Guion corto (en dash):** `–` _a_ `--`
- **Viñeta:** `•` _a_ `*`
- **Punto medio:** `·` _a_ `-`
- **Espacio Em** _a_ tres espacios  
- **Espacio En** _a_ dos espacios  
- **Espacio de no separación** _a_ un espacio  
- **Espacio delgado** _a_ un espacio  
- **Espacio cabello** _a_ un espacio  
- **Comilla angular izquierda:** `«` _a_ `<<`  
- **Comilla angular derecha:** `»` _a_ `>>`  
- **Símbolo de copyright:** `©` _a_ `(C)`  
- **Símbolo de marca registrada:** `™` _a_ `(T)`  
- **Símbolo de marca registrada oficial:** `®` _a_ `(R)`  

![CapturaDePantalla](https://raw.githubusercontent.com/jonlabelle/Trimmer/master/screenshots/command_palette.png)  

Mira una [**Demostración Rápida**](https://raw.githubusercontent.com/jonlabelle/Trimmer/master/screenshots/demo.gif)  

## Instalación  

Trimmer es compatible con Sublime Text 2 y 3 y todos los Sistemas Operativos soportados.  

### Package Control  

La forma más fácil y recomendada para instalar Trimmer es usando [Package Control](https://packagecontrol.io).  

Desde el menú principal de la aplicación, navega a:  

- `Herramientas` -> `Paleta de comandos...` -> `Package Control: Install Package`, escribe  
  la palabra **_Trimmer_**, luego selecciónala para completar la instalación.  

### Git  

Para instalar Trimmer usando Git, cambia a tu directorio de **Paquetes de Sublime Text**  
y clona el [repositorio de Trimmer](https://github.com/jonlabelle/Trimmer).  

Por ejemplo, en **OS X**... inicia una nueva sesión de **Terminal** y escribe los siguientes  
comandos:

```shell
$ cd ~/Library/Application\ Support/Sublime\ Text\ 3/Packages/
$ git clone https://github.com/jonlabelle/Trimmer
```
### Manualmente

**Descargue** y **extraiga** el [zip](https://github.com/jonlabelle/Trimmer/zipball/master)
o [tarball](https://github.com/jonlabelle/Trimmer/tarball/master) en su
directorio de paquetes de Sublime Text.

**Rutas predeterminadas de paquetes de Sublime Text:**

- **OS X:** `~/Library/Application Support/Sublime Text [2|3]/Packages`
- **Linux:** `~/.Sublime Text [2|3]/Packages`
- **Windows:** `%APPDATA%/Sublime Text [2|3]/Packages`

> **NOTA** Reemplace la parte `[2|3]` con la versión apropiada de Sublime Text
> para su instalación.

## Uso

Todos los comandos son accesibles desde la **Paleta de Comandos** usando el prefijo
**_Trimmer_**, y en el **Menú Principal** bajo `Editar` -> `Línea` -> comando _Trimmer_.

- [Captura de pantalla de la Paleta de Comandos](https://raw.githubusercontent.com/jonlabelle/Trimmer/master/screenshots/command_palette.png)
- [Captura de pantalla del Menú Principal](https://raw.githubusercontent.com/jonlabelle/Trimmer/master/screenshots/main_menu.png)

### Atajos de Teclado

El atajo _predeterminado_ recortará los espacios en blanco al final de cada
línea (archivo completo).

- **OS X**: `Ctrl + S`
- **Linux**: `Ctrl + Alt + S`
- **Windows**: `Ctrl + Alt + S`

### API del Comando Trimmer

| Comando                            | Descripción                                                                                           | Contexto                  |
| ---------------------------------- | ----------------------------------------------------------------------------------------------------- | ------------------------- |
| `trimmer`                          | recorta los espacios en blanco al final de cada línea                                                  | archivo completo          |
| `trim_leading_whitespace`          | recorta los espacios en blanco al inicio de cada línea                                                | selección, o archivo completo |
| `trim_leading_trailing_whitespace` | recorta los espacios en blanco al inicio y al final de cada línea                                    | selección, o archivo completo |

| `trim_selections`                  | recortar espacios en blanco de la(s) selección(es)                                                   | selección                 |
| `delete_empty_lines`               | eliminar líneas vacías, solo con espacios en blanco                                                  | selección, o archivo completo |
| `collapse_lines`                   | colapsar múltiples líneas vacías consecutivas en una sola línea vacía                                | selección, o archivo completo |
| `collapse_spaces`                  | colapsar múltiples espacios consecutivos en un solo espacio                                         | selección, o archivo completo |
| `trim_edges`                      | recortar líneas vacías, solo con espacios en blanco, al inicio y al final del archivo               | archivo completo          |
| `remove_blank_spaces`              | eliminar todos los caracteres de espacio en blanco (tabulación, cr, ff, vt, espacio)                | selección, o archivo completo |
| `normalize_spaces`                 | espacios consecutivos reducidos, líneas vacías eliminadas y líneas recortadas                        | selección, o archivo completo |
| `replace_smart_characters`         | reemplazar caracteres inteligentes (comillas inteligentes, guion em/en, puntos suspensivos, nbsp) | selección, o archivo completo |
| `tokenize_string`                  | convertir una cadena en un token colapsando espacios consecutivos y recortando espacios al inicio y al final | selección, o archivo completo |
| `delete_empty_tags`                | eliminar etiquetas html y xml vacías, solo con espacios en blanco                                   | selección, o archivo completo |
| `remove_comments`                  | eliminar comentarios de código y colapsar líneas                                                    | selección, o archivo completo |
| `delete_adjacent_duplicate_lines`  | eliminar líneas duplicadas adyacentes                                                               | selección, o archivo completo |

## Autor

[Jon LaBelle](https://jonlabelle.com)

## Licencia

Trimmer está licenciado bajo la [licencia MIT](http://opensource.org/licenses/MIT).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-15

---