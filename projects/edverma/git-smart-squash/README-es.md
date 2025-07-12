# Git Smart Squash

Deja de perder tiempo reorganizando commits manualmente. Deja que la IA lo haga por ti.

## El Problema

Ya has estado ahí: 15 commits para una función, la mitad son "fix", "typo" o "WIP". Ahora necesitas limpiarlos para la revisión del PR. Hacer squash y reescribir manualmente es tedioso.

## La Solución

Git Smart Squash analiza tus cambios y los reorganiza en commits lógicos con mensajes adecuados:

```bash
# Antes: tu rama desordenada
* fix tests
* typo  
* more auth changes
* WIP: working on auth
* update tests
* initial auth implementation

# Después: commits limpios y lógicos
* feat: implementar sistema de autenticación JWT
* test: agregar cobertura al endpoint de autenticación
```

## Inicio Rápido

### 1. Instalar

```bash
# Usando pip
pip install git-smart-squash

# Usando pipx (recomendado para instalación aislada)
pipx install git-smart-squash

# Usando uv (gestor de paquetes de Python rápido)
uv tool install git-smart-squash
```
### 2. Configurar IA

**Opción A: Local (Gratis, Privado)**
```bash
# Instalar Ollama desde https://ollama.com
ollama pull devstral  # Modelo por defecto
```

**Opción B: Nube (Mejores resultados)**
```bash
export OPENAI_API_KEY="tu-clave"
export ANTHROPIC_API_KEY="tu-clave"
export GEMINI_API_KEY="tu-clave"
```

### 3. Ejecutar

```bash
cd tu-repo
git-smart-squash
```
Eso es todo. Revisa el plan y apruébalo.

## Parámetros de Línea de Comandos

| Parámetro | Descripción | Predeterminado |
|-----------|-------------|---------------|
| `--base` | Rama base para comparar | Archivo de configuración o `main` |
| `--ai-provider` | Proveedor de IA a utilizar (openai, anthropic, local, gemini) | Configurado en ajustes |
| `--model` | Modelo de IA específico a utilizar (ver modelos recomendados abajo) | Predeterminado del proveedor |
| `--config` | Ruta al archivo de configuración personalizado | `.git-smart-squash.yml` o `~/.git-smart-squash.yml` |
| `--auto-apply` | Aplicar el plan de commits sin mensaje de confirmación | `false` |
| `--instructions`, `-i` | Instrucciones personalizadas para la IA (ej., "Agrupar por área de funcionalidad") | Ninguna |
| `--no-attribution` | Desactivar mensaje de atribución en los commits | `false` |
| `--debug` | Activar registros de depuración para información detallada | `false` |

## Modelos Recomendados

### Modelos Predeterminados
- **OpenAI**: `gpt-4.1` (predeterminado)
- **Anthropic**: `claude-sonnet-4-20250514` (predeterminado)
- **Gemini**: `gemini-2.5-pro` (predeterminado)
- **Local/Ollama**: `devstral` (predeterminado)

### Selección de Modelo
```bash
# Especificar un modelo diferente
git-smart-squash --ai-provider openai --model gpt-4.1-mini

# Para Ollama local
git-smart-squash --ai-provider local --model llama-3.1
```

## Instrucciones Personalizadas

El parámetro `--instructions` te permite controlar cómo se organizan los commits:

### Ejemplos
```bash
# Agregar prefijos de ticket
git-smart-squash -i "Prefija todos los commits con [ABC-1234]"

# Separar por tipo
git-smart-squash -i "Mantén los cambios de backend y frontend en commits separados"
```
# Limitar el número de commits
git-smart-squash -i "Crear como máximo 3 commits en total"
```

### Consejos para obtener mejores resultados
- **Sé específico**: "Agrupa las migraciones de base de datos por separado" funciona mejor que "organiza bien"
- **Una instrucción a la vez**: Las instrucciones complejas con varias partes pueden ser ignoradas parcialmente
- **Usa mejores modelos**: Los modelos más grandes siguen las instrucciones de manera más confiable que los modelos más pequeños

## Casos de uso comunes

### "Necesito limpiar antes de la revisión de PR"
```bash
git-smart-squash              # Muestra el plan y solicita confirmación
git-smart-squash --auto-apply # Aplica automáticamente sin solicitar confirmación
```

### "Trabajo con una rama principal diferente"
```bash
git-smart-squash --base develop
```
### "Quiero usar un proveedor de IA específico"
```bash
git-smart-squash --ai-provider openai
```

## Seguridad

**Tu código está seguro:**
- Muestra el plan antes de hacer cambios
- Crea una rama de respaldo automática
- Requiere un directorio de trabajo limpio
- Nunca hace push sin tu orden

**Si algo sale mal:**
```bash
# Encontrar respaldo
git branch | grep backup

# Restaurar
git reset --hard your-branch-backup-[timestamp]
```

## Proveedores de IA

| Proveedor   | Costo   | Privacidad |
|-------------|---------|------------|
| **Ollama**  | Gratis  | Local      |
| **OpenAI**  | ~$0.01  | Nube       |
| **Anthropic** | ~$0.01 | Nube      |
| **Gemini**  | ~$0.01  | Nube       |

## Configuración Avanzada (Opcional)

¿Quieres personalizar? Crea un archivo de configuración:

**Específico del proyecto** (`.git-smart-squash.yml` en tu repositorio):
```yaml
ai:
  provider: openai  # Usar OpenAI para este proyecto
base: develop       # Usar develop como rama base para este proyecto
```
**Global default** (`~/.git-smart-squash.yml`):
```yaml
ai:
  provider: local   # Siempre usar IA local por defecto
base: main          # Rama base predeterminada para todos los proyectos
```

## Solución de problemas

### Error de "JSON inválido"
Esto usualmente significa que el modelo de IA no pudo formatear la respuesta correctamente:
- **Con Ollama**: Cambia de `llama2` a `mistral` o `mixtral`
- **Solución**: `ollama pull mistral` y luego vuelve a intentar
- **Alternativa**: Usa un proveedor en la nube con `--ai-provider openai`

### El modelo no sigue las instrucciones
Algunos modelos tienen dificultades con instrucciones complejas:
- **Usa mejores modelos**: `--model gpt-4-turbo` o `--model claude-3-opus`
- **Simplifica las instrucciones**: Una directiva clara funciona mejor que varias
- **Sé explícito**: "Prefija con [ABC-123]" y no "agrega el número de ticket"

### "Ollama no encontrado"
```bash
# Instalar desde https://ollama.com
ollama serve
ollama pull devstral  # Modelo predeterminado
```

### Agrupación deficiente de commits
Si la IA crea demasiados commits o no los agrupa bien:
- **Modelo insuficiente**: Utiliza un modelo más grande
- **Agregar instrucciones**: `-i "Agrupa los cambios relacionados, máximo 3 commits"`
- **Proporciona comentarios**: Crea un issue en GitHub y cuéntanos lo que sucedió

### Problemas de instalación (Mac)
Si no tienes pip o prefieres instalaciones aisladas:
```bash
# Usando pipx (recomendado)
brew install pipx
pipx install git-smart-squash
```
### "Sin cambios para reorganizar"
```bash
git log --oneline main..HEAD  # Verifica que tienes commits
git diff main                 # Verifica que tienes cambios
```

### Diffs grandes / Límites de tokens
Los modelos locales tienen un límite de ~32k tokens. Para cambios grandes:
- Usa `--base` con un commit más reciente
- Cambia a la nube: `--ai-provider openai`
- Divide en PRs más pequeños

### ¿Necesitas más ayuda?

Consulta nuestra [documentación detallada](https://raw.githubusercontent.com/edverma/git-smart-squash/main/DOCUMENTATION.md) o abre un issue.

## Licencia

Licencia MIT - consulta el archivo [LICENSE](LICENSE) para más detalles.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-12

---