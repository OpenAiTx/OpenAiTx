# opencode-anthropic-oauth

Plugin OpenCode para inicio de sesión OAuth de Anthropic Claude Pro/Max — no se necesita Claude Code.

## Qué hace

Permite autenticarse con su suscripción Claude Pro/Max directamente en OpenCode vía OAuth en el navegador. No es necesario instalar Claude Code ni gestionar archivos de credenciales.

## Instalación

```bash
npm install -g opencode-anthropic-oauth
```

Luego, añade a tu `opencode.json`:

```json
{
  "plugin": ["opencode-anthropic-oauth"]
}
```
## Uso

1. Ejecuta `/connect` en OpenCode (o `oc auth login` desde la CLI)  
2. Selecciona **Anthropic** > **Claude Pro/Max**  
3. Abre el enlace en tu navegador y autoriza  
4. Pega el código de vuelta en OpenCode  
5. Listo — todos los modelos de Anthropic ya están disponibles  

## Cómo funciona

- Implementa el flujo OAuth PKCE directamente contra los puntos de autenticación de Anthropic  
- Abre tu navegador para la autenticación — inicias sesión con tu cuenta Claude  
- Intercambia el código de autorización por tokens de acceso + refresco  
- **Renueva automáticamente los tokens** cuando expiran — no se requiere re-autenticación manual  
- Establece los encabezados API requeridos en las solicitudes a Anthropic  
- **Preserva el caché de prompts** para un uso eficiente de los tokens  

## Registro de cambios

### 0.4.1  
- **Corregido consumo alto de tokens** — se eliminó la eliminación de `cache_control` que deshabilitaba el caché de prompts  
- Añadido `x-anthropic-billing-header` para un seguimiento adecuado de tokens  
- Alineación de las banderas beta con el plugin oficial de Claude CLI  

### 0.4.0  
- Añadido el parámetro URL `?beta=true` para compatibilidad OAuth  
- Inyección del prefijo de identidad del sistema para claude-code beta  
- Eliminación de `cache_control` (ahora removido en 0.4.1)  

### 0.3.0  
- Añadida renovación automática de tokens mediante hook de cargador  
- Temporizador proactivo de renovación en segundo plano (intervalos de 5 min)  

## Variables de entorno para sobreescritura

Todos los parámetros OAuth pueden ser sobreescritos mediante variables de entorno. Si Anthropic cambia algo antes de que publiquemos una actualización, configura una variable de entorno y sigue trabajando:

| Variable | Descripción |  
|---|---|

| `ANTHROPIC_CLIENT_ID` | ID de cliente OAuth |
| `ANTHROPIC_CLI_VERSION` | Versión de Claude CLI para User-Agent |
| `ANTHROPIC_USER_AGENT` | Cadena completa de User-Agent (sobrescribe la versión) |
| `ANTHROPIC_AUTHORIZE_URL` | Punto final de autorización OAuth |
| `ANTHROPIC_TOKEN_URL` | Punto final de token OAuth |
| `ANTHROPIC_REDIRECT_URI` | URI de redirección OAuth |
| `ANTHROPIC_SCOPES` | Alcances OAuth |
| `ANTHROPIC_BETA_FLAGS` | Banderas de funciones beta de Anthropic |

Ejemplo:

```bash
export ANTHROPIC_CLI_VERSION=2.2.0
```

## Descargo de responsabilidad

Este complemento utiliza el ID de cliente OAuth público de Anthropic para autenticarse. Los Términos de Servicio de Anthropic (febrero de 2026) establecen que los tokens de suscripción Claude Pro/Max solo deben usarse con clientes oficiales de Anthropic. Este complemento existe como una solución comunitaria y puede dejar de funcionar si Anthropic cambia su infraestructura OAuth. Úselo bajo su propio criterio.

## Licencia

MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-20

---