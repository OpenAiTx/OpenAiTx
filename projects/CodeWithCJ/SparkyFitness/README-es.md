# SparkyFitness - Alternativa autoalojada a MyFitnessPal

SparkyFitness es una aplicación integral de seguimiento y gestión fitness diseñada para ayudar a los usuarios a monitorear su nutrición, ejercicio y mediciones corporales. Proporciona herramientas para el seguimiento diario del progreso, establecimiento de metas e informes detallados para apoyar un estilo de vida saludable.


## ✨ Características

### 🍎 Seguimiento de Nutrición

* **Registra tus comidas diarias**
* **Crea y gestiona alimentos y categorías personalizadas**
* **Visualiza resúmenes y analiza tendencias con gráficos interactivos**

### 💪 Registro de Ejercicio

* **Registra tus entrenamientos**
* **Explora y busca en una base de datos completa de ejercicios**
* **Haz seguimiento del progreso fitness a lo largo del tiempo**

### 💧 Monitoreo de Ingesta de Agua

* **Haz seguimiento de tus metas diarias de hidratación**
* **Registro de agua simple y rápido**

### 📏 Mediciones Corporales

* **Registra métricas corporales** (por ejemplo, peso, cintura, brazos)
* **Agrega tipos de medición personalizados**
* **Visualiza el progreso mediante gráficos**

### 🎯 Establecimiento de Metas

* **Establece y gestiona metas de fitness y nutrición**
* **Haz seguimiento del progreso en el tiempo**

### 🗓️ Chequeos Diarios

* **Monitorea la actividad diaria**
* **Mantén la constancia con el seguimiento de hábitos**

### 🤖 Coach Nutricional con IA (SparkyAI)

* **Registra alimentos, ejercicio, estadísticas corporales y pasos vía chat**
* **Carga imágenes de alimentos para registrar comidas automáticamente**
* **Incluye historial de chat y orientación personalizada**

### 🔒 Autenticación de Usuario y Perfiles

* **Sistema de inicio de sesión seguro**
* **Cambia entre perfiles de usuario**
* **Soporte para acceso y gestión familiar**

### 📊 Informes Completos

* **Genera resúmenes de nutrición y métricas corporales**
* **Haz seguimiento de tendencias a largo plazo por semanas o meses**

### 🎨 Temas Personalizables

* **Alterna entre modo claro y oscuro**
* **Diseño minimalista y sin distracciones**

### ¿Necesitas ayuda?
* **Únete a Discord**
  https://discord.gg/vcnMT5cPEA
* **Publica en la discusión**


![image](https://github.com/user-attachments/assets/ccc7f34e-a663-405f-a4d4-a9888c3197bc)


## 🚀 Primeros Pasos

Para ejecutar la aplicación SparkyFitness en tu máquina local, sigue estos pasos:

### Requisitos Previos

*   **Proyecto Supabase**: Necesitarás tener un proyecto Supabase configurado.
    *   **Crea un nuevo proyecto en Supabase**: Ve a [Supabase](https://app.supabase.com/) y crea un nuevo proyecto. (También puedes intentar configurar un proyecto Supabase local si lo prefieres.)
    *   Obtén la URL de tu Proyecto Supabase y la Anon Key desde la configuración del proyecto (sección API).
    *   **Nota importante sobre la autenticación de Supabase:** Actualiza la configuración de URL en los ajustes de autenticación de Supabase para que coincida con tu dominio. Esto es crucial para que tu dominio funcione y para recibir invitaciones por correo electrónico para el registro. Supabase ofrece amplias funciones de seguridad y opciones SSO de terceros; configúralas según las necesidades de tu proyecto.
    *   El despliegue automatizado de la base de datos en Supabase no funciona con IPV4 si tienes la versión gratuita de Supabase. Por lo tanto, debes configurar tu red para usar conexión IPV6. De lo contrario, la migración de la base de datos fallará y tendrás que desplegar manualmente.       


    

### Instalación

1.  **Configura las variables de entorno:**
    Crea un archivo `.env` en la carpeta privada. Si utilizas Portainer, créalo directamente allí.
    Agrega tus credenciales de Supabase:
    ```
    VITE_SUPABASE_URL="TU_URL_DEL_PROYECTO_SUPABASE"
    VITE_SUPABASE_ANON_KEY="TU_ANON_KEY_SUPABASE"
    SUPABASE_PROJECT_REF="TU_SUPABASE_PROJECT_REF"    
    ```

2.  **Ejecuta con Docker Compose:**
    Descarga las imágenes de Docker e inicia los servicios:
    ```sh
```markdown
    docker compose pull
    docker compose up -d
    ```

3.  **Accede a la Aplicación:**
    Una vez que los servicios estén en funcionamiento, accede a SparkyFitness en tu navegador web en:
    ```
    http://localhost:3000
    ```

4.  **Chatbot IA - Configuración Opcional:**
    Para habilitar la funcionalidad completa del Chatbot de IA, incluida el almacenamiento seguro de la clave API y el acceso a la base de datos, sigue estos pasos:

    *   **Configura `AI_API_ENCRYPTION_KEY`:** Genera un secreto en "Supabase -> Edge Functions" -> "Environment Variables". Esta clave se utiliza para cifrar tus claves de IA cuando se almacenan en Supabase.

    *   **Genera `SUPABASE_ACCESS_TOKEN`:**
        1.  Accede a tu consola de Docker.
        2.  Ejecuta `supabase login` y autentícate usando la URL proporcionada.
        3.  Recupera el token de acceso ejecutando `cat ~/.supabase/access-token`.
        4.  Actualiza tu `docker-compose.yml` o la configuración de Portainer con este token para volver a desplegar.
        5.  Después del redepliegue, inicia sesión en SparkyFitness y configura el servicio de IA con tu proveedor preferido.
     

### Despliegue Manual de la Base de Datos y Funciones en Supabase
**Método 1:  
**Si no tienes habilitada la conexión de red IPV6, la migración de la base de datos fallará ya que la versión gratuita de Supabase no soporta conexión directa por IPV4.

   1. Descarga la última versión y descomprímela en tu PC.
   2. Navega a la carpeta del proyecto. Docker debe estar en funcionamiento.
   3. Ejecuta los siguientes comandos. (el despliegue de funciones solo es necesario para la configuración de IA. Si no necesitas ChatBOT, puedes omitirlo)
``
      supabase login  
      supabase link  
      supabase db push  
      supabase functions deploy chat   
``
Vuelve a ejecutar Docker compose. La aplicación Front end comenzará a funcionar.

**Método 2:  
   1. Descarga la última versión y descomprímela en tu PC.  
   2. Navega a la carpeta del proyecto.  
   3. Ve a supabase/migrations. Copia las sentencias SQL y ejecútalas en Supabase-->Project-->SQL Editor una por una en orden ASC.  
   4. [Opcional] Haz lo mismo para supabase/functions/chat si necesitas el ChatBOT de IA. Copia index.js y ejecútalo en Supabase-->Project-->Edge Function-->Deploy new function.  
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-04

---