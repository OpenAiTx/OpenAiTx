# Habilidad de Simulador iOS para Claude Code

Automatización lista para producción para pruebas y compilación de aplicaciones iOS. 21 scripts optimizados tanto para desarrolladores humanos como para agentes de IA.

Esto es básicamente una versión Habilidad de mi MCP de XCode: [https://github.com/conorluddy/xc-mcp](https://github.com/conorluddy/xc-mcp)

Los MCPs cargan muchos tokens en la ventana de contexto cuando están activos, pero también parecen funcionar muy bien. Las habilidades no cargan ningún contexto. Crearé un plugin a continuación e intentaré encontrar el equilibrio...

Actualizado: La versión Plugin te permite desactivar fácilmente los MCPs para diferentes grupos de herramientas. Optimiza tu ventana de contexto habilitando solo las herramientas que estás usando activamente, como xcodebuild: [https://github.com/conorluddy/xclaude-plugin](https://github.com/conorluddy/xclaude-plugin)

## Qué Hace

En lugar de navegación basada en píxeles que falla cuando la UI cambia:

```bash
# Fragile - breaks if UI changes
idb ui tap 320 400

# Robust - finds by meaning
python scripts/navigator.py --find-text "Login" --tap
```
Utiliza la navegación semántica en las APIs de accesibilidad para interactuar con los elementos por su significado, no por coordenadas. Funciona en diferentes tamaños de pantalla y sobrevive a rediseños de la interfaz.

## Características

- **21 scripts de producción** para construcción, pruebas y automatización
- **Navegación semántica** - encuentra elementos por texto, tipo o ID
- **Optimizado en tokens** - reducción del 96% vs herramientas sin procesar (3-5 líneas por defecto)
- **Configuración cero** - funciona inmediatamente en macOS con Xcode
- **Salida estructurada** - JSON y texto formateado, fácil de analizar
- **Detección automática de UDID** - no es necesario especificar el dispositivo cada vez
- **Operaciones en lote** - arrancar, eliminar, borrar múltiples simuladores a la vez
- **Pruebas integrales** - cumplimiento WCAG, diferencias visuales, auditorías de accesibilidad
- **Preparado para CI/CD** - salida JSON, códigos de salida, ciclo de vida automatizado del dispositivo

## Instalación

### Como Skill de Código Claude


```bash
# Personal installation
git clone https://github.com/conorluddy/ios-simulator-skill.git ~/.claude/skills/ios-simulator-skill

# Project installation
git clone https://github.com/conorluddy/ios-simulator-skill.git .claude/skills/ios-simulator-skill
```
Reiniciar Claude Code. La habilidad se carga automáticamente.

### Desde la versión publicada


```bash
# Download latest release
curl -L https://github.com/conorluddy/ios-simulator-skill/releases/download/vX.X.X/ios-simulator-skill-vX.X.X.zip -o skill.zip

# Extract
unzip skill.zip -d ~/.claude/skills/ios-simulator-skill
```

## Requisitos previos

- macOS 12+
- Herramientas de línea de comandos de Xcode (`xcode-select --install`)
- Python 3
- IDB (opcional, para funciones interactivas: `brew tap facebook/fb && brew install idb-companion`)

## Inicio rápido

```bash
# 1. Check environment
bash ~/.claude/skills/ios-simulator-skill/scripts/sim_health_check.sh

# 2. Launch your app
python ~/.claude/skills/ios-simulator-skill/scripts/app_launcher.py --launch com.example.app

# 3. See what's on screen
python ~/.claude/skills/ios-simulator-skill/scripts/screen_mapper.py
# Output:
# Screen: LoginViewController (45 elements, 7 interactive)
# Buttons: "Login", "Cancel", "Forgot Password"
# TextFields: 2 (0 filled)

# 4. Tap login button
python ~/.claude/skills/ios-simulator-skill/scripts/navigator.py --find-text "Login" --tap

# 5. Enter text
python ~/.claude/skills/ios-simulator-skill/scripts/navigator.py --find-type TextField --enter-text "user@test.com"

# 6. Check accessibility
python ~/.claude/skills/ios-simulator-skill/scripts/accessibility_audit.py
```
## 21 Scripts Organizados por Categoría

### Construcción y Desarrollo
- **build_and_test.py** - Construir proyectos, ejecutar pruebas, analizar resultados
- **log_monitor.py** - Monitoreo de registros en tiempo real

### Navegación e Interacción
- **screen_mapper.py** - Analizar pantalla actual
- **navigator.py** - Encontrar e interactuar con elementos
- **gesture.py** - Deslizamientos, desplazamientos, pellizcos
- **keyboard.py** - Entrada de texto y botones físicos
- **app_launcher.py** - Control del ciclo de vida de la app

### Pruebas y Análisis
- **accessibility_audit.py** - Verificación de cumplimiento WCAG
- **visual_diff.py** - Comparación de capturas de pantalla
- **test_recorder.py** - Documentación automática de pruebas
- **app_state_capture.py** - Capturas para depuración
- **sim_health_check.sh** - Verificación del entorno

### Pruebas Avanzadas y Permisos
- **clipboard.py** - Gestión del portapapeles
- **status_bar.py** - Control de la barra de estado
- **push_notification.py** - Notificaciones push
- **privacy_manager.py** - Gestión de permisos

### Ciclo de Vida del Dispositivo
- **simctl_boot.py** - Arrancar simulador
- **simctl_shutdown.py** - Apagar simulador
- **simctl_create.py** - Crear simulador
- **simctl_delete.py** - Eliminar simulador
- **simctl_erase.py** - Restauración de fábrica

Consulta **SKILL.md** para referencia completa.

## Cómo Funciona con Claude Code

Claude Code detecta automáticamente cuándo usar esta habilidad según tu solicitud. No necesitas invocarla manualmente.


**Ejemplo de conversación:**

```
You: "Set up my iOS app for testing"
Claude: [Uses simctl_boot.py and app_launcher.py automatically]

You: "Tap the login button"
Claude: [Uses navigator.py to find and tap]

You: "Check if the form is accessible"
Claude: [Uses accessibility_audit.py]
```

También puedes ejecutar scripts manualmente cuando sea necesario.

## Ejemplos de Uso

### Ejemplo 1: Flujo de Inicio de Sesión

```bash
# Launch app
python scripts/app_launcher.py --launch com.example.app

# Map screen to find fields
python scripts/screen_mapper.py

# Enter credentials
python scripts/navigator.py --find-type TextField --index 0 --enter-text "user@test.com"
python scripts/navigator.py --find-type SecureTextField --enter-text "password"

# Tap login
python scripts/navigator.py --find-text "Login" --tap

# Verify accessibility
python scripts/accessibility_audit.py
```

### Ejemplo 2: Documentación de Pruebas

```bash
# Record test execution
python scripts/test_recorder.py --test-name "Login Flow" --output test-reports/

# Generates:
# - Screenshots per step
# - Accessibility trees
# - Markdown report with timing
```

### Ejemplo 3: Pruebas Visuales

```bash
# Capture baseline
python scripts/app_state_capture.py --output baseline/

# Make changes...

# Compare
python scripts/visual_diff.py baseline/screenshot.png current/screenshot.png
```

### Ejemplo 4: Pruebas de Permisos

```bash
# Grant permissions
python scripts/privacy_manager.py --bundle-id com.example.app --grant camera,location

# Test app behavior with permissions...

# Revoke permissions
python scripts/privacy_manager.py --bundle-id com.example.app --revoke camera,location
```

### Ejemplo 5: Ciclo de vida del dispositivo en CI/CD

```bash
# Create test device
DEVICE_ID=$(python scripts/simctl_create.py --device "iPhone 16 Pro" --json | jq -r '.new_udid')

# Run tests
python scripts/build_and_test.py --project MyApp.xcodeproj

# Clean up
python scripts/simctl_delete.py --udid $DEVICE_ID --yes
```

## Principios de Diseño

**Navegación Semántica**: Encuentra elementos por significado (texto, tipo, ID) no por coordenadas de píxeles. Sobrevive cambios en la interfaz y funciona en distintos tamaños de dispositivo.

**Eficiencia de Tokens**: La salida por defecto es de 3-5 líneas. Usa `--verbose` para detalles o `--json` para análisis automático. Reducción del 96% frente a herramientas sin procesar.

**Accesibilidad Primero**: Construido sobre APIs de accesibilidad de iOS para mayor fiabilidad. Mejor para usuarios con necesidades de accesibilidad y más robusto para automatización.

**Sin Configuración**: Funciona inmediatamente en cualquier macOS con Xcode. Sin configuraciones complejas ni archivos de configuración.

**Datos Estructurados**: Los scripts generan JSON o texto formateado, no registros sin procesar. Fácil de analizar, integrar y entender.

**Autoaprendizaje**: El sistema aprende la preferencia de tu dispositivo y la recuerda para la próxima vez.

## Requisitos

**Sistema:**
- macOS 12 o superior
- Herramientas de línea de comandos de Xcode
- Python 3

**Opcional:**
- IDB (para funciones interactivas)
- Pillow (para visual_diff.py: `pip3 install pillow`)

## Documentación

- **SKILL.md** - Referencia completa de scripts y tabla de contenidos
- **CLAUDE.md** - Arquitectura y guía para desarrolladores
- **references/** - Documentación profunda sobre temas específicos
- **examples/** - Flujos de trabajo completos de automatización

## Eficiencia de Salida

Todos los scripts minimizan la salida por defecto:

| Tarea | Herramientas sin procesar | Esta Skill | Ahorro |
|-------|---------------------------|------------|--------|
| Análisis de pantalla | 200+ líneas | 5 líneas | 97.5% |
| Buscar y tocar botón | Más de 100 líneas | 1 línea | 99% |
| Ingresar texto | Más de 50 líneas | 1 línea | 98% |
| Flujo de inicio de sesión | Más de 400 líneas | 15 líneas | 96% |

Esta eficiencia mantiene las conversaciones con el agente de IA enfocadas y rentables.

## Solución de problemas

### Problemas del entorno

```bash
# Run health check
bash ~/.claude/skills/ios-simulator-skill/scripts/sim_health_check.sh

# Checks: macOS, Xcode, simctl, IDB, Python, simulators, packages
```

### Ayuda del Script

```bash
# All scripts support --help
python scripts/navigator.py --help
python scripts/accessibility_audit.py --help
```

### No Encontrar Elementos

```bash
# Use verbose mode to see all elements
python scripts/screen_mapper.py --verbose

# Check for exact text match
python scripts/navigator.py --find-text "Exact Button Text" --tap
```
## Contributing

Las contribuciones deben:
- Mantener la eficiencia de tokens (salida predeterminada mínima)
- Seguir un diseño con accesibilidad como prioridad
- Soportar documentación `--help`
- Soportar `--json` para CI/CD
- Pasar el formateador Black y el linter Ruff
- Incluir anotaciones de tipo
- Actualizar SKILL.md

## License

Licencia MIT - Permite uso y distribución comercial.

## Support

- **Issues**: Crear un issue en GitHub con pasos para reproducir
- **Documentation**: Ver SKILL.md y references/
- **Examples**: Revisar el directorio examples/
- **Skills Docs**: https://docs.claude.com/en/docs/claude-code/skills

---

**Construido para agentes de IA. Optimizado para desarrolladores.**



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-18

---