

<p align="center">
  <img src="https://raw.githubusercontent.com/TheCSir/TerminalStart/main/extension/icon128.png" width="72" alt="Icono de TerminalStart">
</p>

<h1 align="center">TerminalStart</h1>

<p align="center">
  Panel de nueva pestaña modular con inspiración retro, diseñado para enfoque y rapidez.
</p>

<p align="center">
  <a href="https://thecsir.github.io/TerminalStart/">Demostración en Vivo</a>
</p>

<p align="center">
  <img src="https://raw.githubusercontent.com/TheCSir/TerminalStart/main/docs/mainPage.png" width="900" alt="Vista previa de TerminalStart">
</p>

<p align="center">
  <img src="https://raw.githubusercontent.com/TheCSir/TerminalStart/main/docs/settingsPage.png" width="900" alt="Configuración de TerminalStart">
</p>

---


## Instalar en Edge / Chrome

1. Abre `edge://extensions` (o `chrome://extensions`)
2. Activa el **Modo Desarrollador**
3. Haz clic en **Cargar descomprimida**
4. Selecciona la carpeta `extension`


## Integración con Todoist

Sincroniza tu widget de tareas con Todoist usando un token API personal.

1. Ve a **Configuración > Avanzado > Widget de Tareas**
2. Habilitar **Sincronización con Todoist**  
3. Pegue su token API (Configuración > Integraciones > Desarrollador en [todoist.com](https://todoist.com))  
4. Conceda permiso al host cuando se le solicite  

**Fechas de vencimiento** &mdash; agregue fechas en lenguaje natural al crear tareas:  

| Entrada | Tarea | Vence |  
|---|---|---|  
| `meet john tomorrow at 2pm` | conocer a john | mañana a las 2pm |  
| `buy groceries next monday` | comprar comestibles | el próximo lunes |  
| `call mom every friday` | llamar a mamá | todos los viernes |  
| `submit report jan 15` | enviar informe | 15 de enero |  

El procesamiento de lenguaje natural de Todoist se encarga del análisis. El modo local aún admite sintaxis solo de hora (p. ej., `standup 9am`).  

## Construir  

### Requisitos  

* Node.js v16+  
* Python 3  

### Pasos  

1. Instale las dependencias:

```
npm install
```

2. Construir:

```
npm run build
```

El script de compilación sincroniza automáticamente los recursos en la carpeta `extension/`.

3. Empaquetar:

```
python scripts/package_addon.py
```

Salida: `terminal-start-v1.0.0.zip`

### Pruebas

```
npx playwright test
```

Ejecuta pruebas e2e contra la extensión usando Chromium.

## Notas

- Pasa el cursor sobre la sección superior derecha para configurar.
- Los tokens API se almacenan localmente en tu navegador y nunca se envían a ningún lugar excepto a la API de Todoist.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-18

---