# Calendario Familiar Inteligente DIY para el Hogar (Clon de Skylight)

![Calendario Skylight](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/assets/main_view.jpeg)
![Skylight DIY](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/assets/sky2.png)

## 📖 Introducción

Mi esposa ha estado recientemente bombardeada en redes sociales con anuncios de calendarios inteligentes para el hogar (Skylight, Cozyla, Hearth) y estaba lista para gastar más de $300 en uno. Antes de darle luz verde, pedí la oportunidad de investigarlos.

Me di cuenta de que la mayoría ofrecía funcionalidades similares pero diferían significativamente en precio. Lo más importante, no vi ninguna característica destacada que no pudiera implementar en **Home Assistant**.

**El Objetivo:** Un calendario táctil aprobado por el factor de aceptación de la esposa (WAF), amigable para colocarse en la encimera que se integre profundamente en nuestro hogar inteligente sin tarifas mensuales.

## 💡 ¿Por qué DIY?

Elegir la ruta DIY con Home Assistant proporcionó varios beneficios sobre comprar un display Skylight/Hearth:

* **Sin Tarifas Mensuales:** Evita suscripciones para funciones "premium".
* **Integración Perfecta:** Se comunica con nuestras luces, tareas (Grocy) y sensores de presencia.
* **Hardware Viejo:** Reutilicé una Mini PC y un monitor estándar.
* **Privacidad:** Sin dependencia del proveedor ni riesgo de que la empresa cierre.

## 🛠 Selección de Hardware

Actualmente está diseñado para mostrar el panel en cualquier pantalla HD (1920x1080).

En mi caso, el requisito era que "se viera como" Skylight, fuera táctil, de encimera, con posibilidad de moverlo a diferentes ubicaciones. Por eso elegí el hardware descrito abajo.
Sin embargo, tu caso podría ser diferente y necesitarás ajustarlo según sea necesario, por ejemplo si quieres mostrarlo en una tablet u otro dispositivo.

El hardware que usé originalmente lo escogí basado en lo mencionado arriba además de la esperanza de poder extender la funcionalidad usando la webcam, altavoz y micrófono. Actualmente probablemente lo construiría diferente en retrospectiva, ya que no he tenido tiempo para abordar estas ideas adicionales de hardware.

* **Monitor:** [HP Engage de 15 pulgadas táctil](https://computers.woot.com/offers/hp-engage-16t-fhd-monitor). Elegí este sobre monitores portátiles genéricos porque incluye **Altavoz, Webcam y Micrófono** integrados, permitiendo control de voz o videollamadas en el futuro.
* **Computadora:** Una Mini PC antigua (NUC/Tiny PC) corriendo Windows/Linux en modo Kiosco, o una Raspberry Pi 4.~~


## ✨ Características

* **Vistas Familiares e Individuales:** Alterna calendarios de miembros específicos de la familia.
* **Sincronización Bidireccional:** Edita eventos en la pantalla o en nuestros teléfonos (Google Calendar).
* **Popup "Agregar Evento":** Una interfaz personalizada para añadir eventos a calendarios específicos directamente desde la pantalla.
* **Clima y Fecha:** Encabezado hermoso y fácil de consultar.  
* **Responsivo:** Ajusta automáticamente el conteo de días según el ancho de pantalla (Móvil vs Escritorio).  

---  

## ⚙️ Guía de Instalación  

*Nota: Esta configuración utiliza un **Paquete YAML** para crear automáticamente todos los ayudantes, scripts y variables necesarios para ti. No necesitas crearlos manualmente.*  

### 1. Requisitos Previos (HACS)  

Debes tener instalado [HACS](https://hacs.xyz/). Por favor, instala las siguientes integraciones **Frontend**:  

* `week-planner-card`  
* `bubble-card`  
* `config-template-card`  
* `card-mod`  
* `better-moment-card`  
* `weather-card`  
* `browser_mod` (Requerido para que funcionen los popups)  
* `layout-card` (Requerido para la vista de Secciones)  
* `button-card` (Requerido para el popup para añadir evento)  

### 2. El Backend (El Cerebro)  

1. Abre tu archivo `configuration.yaml` en Home Assistant.  
2. Asegúrate de tener esta línea añadida bajo `homeassistant:` para habilitar los paquetes:

   ```yaml
   homeassistant:
     packages: !include_dir_named packages
   ```
3. Crea una carpeta llamada `packages` en tu directorio de configuración de HA (si no tienes una).
4. Descarga [packages/family_calendar.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/packages/family_calendar.yaml) de este repositorio.
5. Coloca el archivo dentro de tu carpeta `packages/`.
6. **Reinicia Home Assistant**.

### 3. Los Calendarios

Puedes usar **Calendarios de Google** o **Calendarios Locales**.

#### Opción A: Calendario Local (Más fácil)

Ten en cuenta que esto no ha sido probado ya que uso exclusivamente Calendarios de Google

1. Ve a **Configuración > Dispositivos y Servicios**.
2. Añade la integración **Calendario Local**.
3. Crea calendarios con los nombres exactos: `Alice`, `Bob`, `Charlie`, `Daisy`, `Family`.
    * *¡Si usas estos nombres, el código funciona directamente!*

#### Opción B: Calendario de Google

1. Abre `packages/family_calendar.yaml`.
2. Desplázate hasta el script `add_google_calendar_event`.
3. Actualiza el `calendar_map` para que apunte a tus entidades reales de Google:


    ```yaml
    calendar_map:
      "Alice": "calendar.alice_gmail_com"
      "Bob": "calendar.bob_work_account"
    ```

#### Configuración de Días Festivos

Desde las actualizaciones de Home Assistant, los Días Festivos ahora se agregan vía la interfaz gráfica:

1. Ve a **Configuración > Dispositivos y Servicios > Añadir Integración > Día Festivo**.
2. Selecciona tu país.
3. Verifica el ID de la entidad (por ejemplo, `calendar.holidays`). Si es diferente al predeterminado, actualízalo en el YAML del panel.

### 4. El Panel (La Apariencia)

1. Crea una nueva Vista del Panel (Configura el Tipo de Vista a **Secciones**).
2. Copia el código desde [dashboard.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/dashboard.yaml).
3. **Personaliza:**
   * **Buscar y Reemplazar:** Sustituye `person.alice` por las entidades reales de los miembros de tu familia.
   * **Clima:** Cambia `weather.home` por tu proveedor de clima.
   * **Fondo:** Actualiza la URL de la imagen en la parte inferior del yaml.

### Paso 5: El Tema (Opcional)

Para obtener la fuente específica (Ovo):

1. Asegúrate de que tu `configuration.yaml` tenga esta línea bajo `frontend:`

   ```yaml
   frontend:
     themes: !include_dir_merge_named themes
   ```
2. Crea una carpeta llamada `themes` en tu directorio de configuración.  
3. Descarga [themes/skylight.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/themes/skylight.yaml) y colócalo en esa carpeta.  
4. Reinicia Home Assistant.  
5. Ve a tu Perfil (Icono de Usuario en la parte inferior izquierda) y cambia el **Tema** a `Skylight`.  
NOTA: El tema no es completo, tenlo en cuenta  

---  

## 📐 Cómo Funciona (Bajo el Capó)  

### Lógica del Filtro  

La `week-planner-card` no soporta nativamente ocultar calendarios específicos al vuelo. Para resolver esto, usé **Input Texts** que actúan como filtros Regex.  

* Cuando haces clic en el botón de una persona, alterna su filtro entre `.*` (Mostrar todo) y `^$` (No mostrar nada).  
* `config-template-card` inyecta estas variables en la tarjeta del calendario dinámicamente.  

### Script de Creación de Eventos  

El popup "Agregar Evento" usa un único script que maneja la lógica para múltiples personas y tipos de evento (Todo el día vs Con horario).


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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-06

---