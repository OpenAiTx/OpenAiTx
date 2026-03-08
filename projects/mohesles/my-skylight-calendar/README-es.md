
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Calendario Familiar Inteligente DIY para el Hogar (Clon de Skylight)

![Calendario Sklylight](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/assets/main_view.jpeg)
![DIY Skylight](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/assets/sky2.png)

## 📖 Introducción

Recientemente, a mi esposa le han aparecido en redes sociales muchos anuncios de calendarios inteligentes para el hogar (Skylight, Cozyla, Hearth) y estaba dispuesta a gastar más de 300 dólares en uno. Antes de darle luz verde, le pedí la oportunidad de investigarlos.
Me di cuenta de que la mayoría ofrecía funcionalidades similares pero diferían significativamente en precio. Lo más importante, no vi ninguna característica destacada que no pudiera implementar en **Home Assistant**.

**El objetivo:** Un calendario con pantalla táctil, aprobado por el WAF (Factor de Aceptación de la Esposa), amigable para la encimera, que se integre profundamente en nuestro hogar inteligente sin cuotas mensuales.

## 💡 ¿Por qué hacerlo uno mismo?

Elegir la ruta DIY con Home Assistant proporcionó varios beneficios sobre comprar una pantalla Skylight/Hearth:

* **Sin cuotas mensuales:** Evita suscripciones por funciones "premium".
* **Integración total:** Se comunica con nuestras luces, tareas (Grocy) y sensores de presencia.
* **Hardware antiguo:** Reutilicé un Mini PC y un monitor estándar.
* **Privacidad:** Sin dependencia de proveedor ni riesgo de que la empresa cierre.

## 🛠 Selección de hardware

Actualmente está construido para mostrar el panel en cualquier pantalla HD (1920x1080).

En mi caso, el requisito era que "pareciera" skylight, fuera táctil, apto para la encimera, y tuviera posibilidad de moverlo a distintos lugares. Por eso elegí el hardware descrito abajo.
Sin embargo, tu caso puede ser diferente y necesitarás ajustarlo según tus necesidades, por ejemplo si quieres mostrarlo en una tablet o algo distinto.

El hardware que usé originalmente lo elegí basado en lo mencionado arriba, además con la esperanza de poder extender funcionalidades usando la webcam, altavoz y micrófono. Actualmente probablemente lo construiría diferente, ya que no he tenido tiempo de abordar esas ideas de hardware adicionales.

* **Monitor:** [HP Engage de 15 pulgadas con pantalla táctil](https://computers.woot.com/offers/hp-engage-16t-fhd-monitor). Lo elegí sobre monitores portátiles genéricos porque incluye **Altavoz, Webcam y Micrófono** integrados, permitiendo control por voz o videollamadas en el futuro.
* **Computadora:** Un Mini PC antiguo (NUC/Tiny PC) corriendo Windows/Linux en modo Kiosk, o una Raspberry Pi 4.~~

## ✨ Características

* **Vista familiar e individual:** Alterna los calendarios de miembros específicos de la familia.
* **Sincronización bidireccional:** Edita eventos en la pantalla o en nuestros teléfonos (Google Calendar).
* **Ventana emergente "Agregar evento":** Interfaz personalizada para agregar eventos a calendarios específicos directamente desde la pantalla.
* **Clima y fecha:** Encabezado bello y fácil de consultar.
* **Responsivo:** Ajusta automáticamente el número de días según el ancho de la pantalla (móvil vs escritorio).

---

## ⚙️ Guía de instalación

*Nota: Esta configuración utiliza un **Paquete YAML** para crear automáticamente todos los ayudantes, scripts y variables necesarios. No necesitas crearlos manualmente.*



### 1. Requisitos previos (HACS)

Debes tener [HACS](https://hacs.xyz/) instalado. Por favor, instala las siguientes integraciones de **Frontend**:

* `week-planner-card`
* `bubble-card`
* `config-template-card`
* `card-mod`
* `better-moment-card`
* `weather-card`
* `browser_mod` (Requerido para que funcionen los popups)
* `layout-card` (Requerido para la vista de Secciones)
* `button-card` (Requerido para el popup de añadir evento)

*Nota: En Configuración → Dispositivos y Servicios, asegúrate de que Browser Mod aparece como una Integración (azulejo) y no solo bajo HACS.
Si no está allí, haz clic en Añadir Integración → Browser Mod y completa el flujo, luego reinicia HA.
Instalar a través de HACS solo descarga archivos; debes añadir la integración para que HA registre sus acciones/entidades.

### 2. El Backend (El Cerebro)

1. Abre tu archivo `configuration.yaml` en Home Assistant.
2. Asegúrate de tener esta línea añadida bajo `homeassistant:` para habilitar paquetes:

   ```yaml
   homeassistant:
     packages: !include_dir_named packages
   ```
3. Crea una carpeta llamada `packages` en tu directorio de configuración de HA (si no tienes una).
4. Descarga [packages/family_calendar.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/packages/family_calendar.yaml) de este repositorio.
5. Busca la cadena [ #<--- UPDATE THIS ENTITY] y actualiza el ID de la entidad del calendario para que coincida con tu entorno. Consulta la sección 3 para más detalles.
6. Coloca el archivo dentro de tu carpeta `packages/`.
7. **Reinicia Home Assistant**.

### 3. Los Calendarios

Puedes usar **Google Calendars** o **Local Calendars**.

#### Opción A: Reutilizar Nombres de Calendario (Más Fácil)


1. Ve a **Ajustes > Dispositivos y Servicios**.
2. Añade la integración **Local Calendar**.
3. Crea calendarios llamados exactamente: `calendar1`, `calendar2`, `calendar3`, `calendar4`, `Family`.
    * *Si usas estos nombres, ¡el código funciona de inmediato!*

#### Opción B: Calendario Personalizado

1. Ve a **Ajustes > Dispositivos y Servicios**.
2. Añade la integración **Local Calendar** o **Google Calendar**.
3. Navega a **Configuración > Integraciones > Local Calendar** o **Google Calendar** y selecciona "Agregar Entrada"
4. Para cada entrada creada, obtén el ID de la entidad para actualizar el archivo dashboard.yaml.
5. Abre `dashboard.yaml`.
6. Busca `# <--- UPDATE THIS ENTITY`.
7. Actualiza el ID de la entidad para que coincida con tu entorno.


#### Configuración de Días Festivos

Desde las actualizaciones de Home Assistant, los días festivos ahora se agregan desde la interfaz:

1. Ve a **Ajustes > Dispositivos y Servicios > Añadir Integración > Holiday**.
2. Selecciona tu país.
3. Verifica el ID de la entidad (por ejemplo, `calendar.holidays`). Si difiere del predeterminado, actualízalo en el YAML del dashboard.

### 4. El Tablero (El Aspecto)


1. Ve a **Configuración > Panel de control**
2. Haz clic en **Agregar panel de control** (Selecciona la opción "Nuevo panel de control desde cero" y asegúrate de seleccionar "Agregar a la barra lateral").
3. En el menú de la izquierda, selecciona el panel de control recién creado y haz clic en el ícono de lápiz para editarlo.
5. Selecciona el ícono de 3 puntos y elige "Editor de configuración en bruto".
6. Copia y pega el código desde [dashboard.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/dashboard.yaml).

### Paso 5: El tema (Opcional)

Para obtener el aspecto específico de la fuente (Ovo):

1. Asegúrate de que tu `configuration.yaml` tenga esta línea bajo `frontend:`

   ```yaml
   frontend:
     themes: !include_dir_merge_named themes
   ```
2. Crea una carpeta llamada `themes` en tu directorio de configuración.
3. Descarga [themes/skylight.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/themes/skylight.yaml) y colócala en esa carpeta.
4. Usa el Editor de Archivos y sube calbackgrd.png a la carpeta /www/, lo que se traduce internamente a /local en el panel.
5. Reinicia Home Assistant.
6. Ve a tu Perfil (Icono de usuario abajo a la izquierda) y cambia el **Tema** a `Skylight`.
NOTA: El tema no es integral, así que tenlo en cuenta.

---

## 📐 Cómo Funciona (Por Dentro)

### Lógica de Filtro

La `week-planner-card` no admite de forma nativa ocultar calendarios específicos en tiempo real. Para solucionar esto, usé **Input Texts** que actúan como filtros Regex.

* Cuando haces clic en el botón de una persona, alterna su filtro entre `.*` (Mostrar todo) y `^$` (No mostrar nada).
* `config-template-card` inyecta estas variables en la tarjeta de calendario dinámicamente.

### Script de Creación de Evento

La ventana emergente "Agregar Evento" utiliza un único script que maneja la lógica para múltiples personas y tipos de eventos (Todo el día vs con horario).


```yaml
# Simplified Logic Example
target_calendar: "{{ calendar_map.get(states('input_select.calendar_select')) }}"

choose:
  - conditions: "All Day Event is ON"
    action: calendar.create_event (start_date, end_date)
  - conditions: "All Day Event is OFF"
    action: calendar.create_event (start_date_time, end_date_time)
```

## NOTAS

Mi publicación original fue solo para dar una visión general de alto nivel sobre cómo hacerlo y permitir que las personas ajusten el código para que funcione en sus escenarios específicos.

En particular, hice esto porque cada pantalla y necesidad es diferente. No puedo desarrollar para todos los tamaños potenciales de pantallas, paneles, etc. Así que está diseñado para funcionar en la pantalla que mencioné o en cualquier otra (1920x1080) pero debería ser editable para otras.

Hablando de la pantalla, originalmente sugerí esa porque estaba en oferta en Woot y era una forma muy económica de conseguir una pantalla táctil en ese momento. Esto podría no ser el caso ahora, así que usa la pantalla que funcione para ti. Tableta, pantalla táctil, teléfono, lo que sea. Lo principal que necesitarás editar es el panel.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-08

---