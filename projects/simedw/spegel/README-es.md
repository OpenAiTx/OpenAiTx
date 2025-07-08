# Spegel – Refleja la web a través de la IA

Reescribe automáticamente los sitios web en markdown optimizado para su visualización en la terminal.
Lee la publicación introductoria en el blog [aquí](https://simedw.com/2025/06/23/introducing-spegel/)

Esto es una prueba de concepto, se esperan errores, pero siéntete libre de abrir un issue o un pull request.

##  Captura de pantalla
A veces no quieres leer la historia de vida de alguien solo para llegar a una receta
![Ejemplo de Receta](https://simedw.com/2025/06/23/introducing-spegel/images/recipe_example.png)


## Instalación

Requiere Python 3.11+

```
pip install spegel
```
o clona el repositorio e instálalo en modo editable

```bash
# Clona y entra en el directorio
$ git clone <repo-url>
$ cd spegel

# Instala las dependencias y la CLI
$ pip install -e .
```

## Claves API
Spegel actualmente solo soporta Gemini 2.5 Flash, para usarlo necesitas proporcionar tu clave API en el entorno

```
GEMINI_API_KEY=...
```


## Uso

### Inicia el navegador

```bash
spegel                # Inicia con la pantalla de bienvenida
spegel bbc.com        # Abre una URL inmediatamente
```

O, de forma equivalente:

```bash
python -m spegel      # Inicia con la pantalla de bienvenida
python -m spegel bbc.com
```

### Controles básicos
- `/`         – Abrir entrada de URL
- `Tab`/`Shift+Tab` – Ciclar enlaces
- `Enter`     – Abrir el enlace seleccionado
- `e`         – Editar el prompt del LLM para la vista actual
- `b`         – Volver atrás
- `q`         – Salir

## Edición de configuraciones

Spegel carga la configuración desde un archivo TOML. Puedes personalizar vistas, prompts y opciones de la interfaz.

**Orden de búsqueda del archivo de configuración:**
1. `./.spegel.toml` (directorio actual)
2. `~/.spegel.toml`
3. `~/.config/spegel/config.toml`

Para editar la configuración:
1. Copia el archivo de ejemplo:
   ```bash
   cp example_config.toml .spegel.toml
   # o crea ~/.spegel.toml
   ```
2. Edita `.spegel.toml` en tu editor favorito.

Fragmento de ejemplo:
```toml
[settings]
default_view = "terminal"
app_title = "Spegel"

[[views]]
id = "raw"
name = "Raw View"
prompt = ""

[[views]]
id = "terminal"
name = "Terminal"
prompt = "¡Transforma esta página web en la experiencia de navegación perfecta para terminal! ..."
```

---

Para más información, revisa el código o abre un issue.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---