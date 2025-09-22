# BookHaven

![Inicio de BookHaven](https://raw.githubusercontent.com/HrBingR/BookHaven/master/./bookhaven_home.png)

## Tabla de Contenidos
1. [Qué Hace la Aplicación](#qué-hace-la-aplicación)
2. [Características](#características)
3. [Despliegue](#despliegue)
   - [Docker](#docker)
   - [Desarrollo](#desarrollo)
4. [Construcción de la Aplicación](#construcción-de-la-aplicación)
5. [Registro de Cambios](#registro-de-cambios)


## Qué Hace la Aplicación
BookHaven escanea y gestiona tu biblioteca local de libros electrónicos EPUB, y te permite leer y descargar tus ebooks en cualquiera de tus dispositivos, con una interfaz moderna, elegante y responsiva.

## Características
- **Leer eBooks en el Navegador**
  Los usuarios pueden acceder y leer sus eBooks en formato EPUB directamente sin necesidad de software adicional.
- **Descargar eBooks**
  Descarga fácilmente una copia de cualquier eBook en la colección a tu dispositivo.
- **Edición No Destructiva de Metadatos**
  Los cambios en los metadatos del eBook (por ejemplo, título, autor, serie) se almacenan en la base de datos, dejando los archivos EPUB originales intactos.
- **Escaneo Automático o Manual de la Biblioteca**
  Una vez desplegada, la aplicación escaneará periódicamente, en un intervalo configurable, tu biblioteca en busca de cambios, permitiendo también escaneos manuales.
- **Página Principal con Orden Alfabético**
  Los libros se ordenan primero alfabéticamente por autor y luego por serie, ofreciendo una experiencia de navegación limpia e intuitiva.
- **Búsqueda Potente**
  La función de búsqueda en la página principal permite a los usuarios filtrar su biblioteca por autor, título del libro o serie, ayudando a localizar contenido específico rápidamente.
- **Filtros**
  Se ofrecen filtros básicos para permitir filtrar libros marcados como favoritos, como terminados o libros que no han sido marcados como terminados.
- **Página del Autor con Navegación Intuitiva**
  Una página dedicada al autor organiza a los autores en una cuadrícula alfabética clickeable. Los usuarios pueden hacer clic en una letra para expandir la lista de autores, navegar a la página de un autor y ver sus libros ordenados alfabéticamente por series y títulos independientes.
- **Soporte para CloudFlare Access**
  Tiene una opción para omitir la pantalla de inicio de sesión cuando se utiliza CloudFlare Access. Ver `.env.example` para detalles.
- **Soporte OIDC**
  Permite la configuración de OIDC para el registro de nuevos usuarios y para usuarios existentes.
- **Soporte OPDS**
  Usa tu lector o aplicación compatible con OPDS favorito para navegar, descargar y leer libros de tu biblioteca.
- **Subidas**  
  Los usuarios ahora pueden subir ebooks directamente a través de la interfaz de usuario, con un formulario posterior a la subida para corregir los metadatos.  
- **Soporte básico de RBAC**  
  Los administradores ahora pueden asignar a los usuarios diferentes roles con distintos niveles de acceso.  
- **Solicitudes de libros**  
  Los usuarios ahora pueden solicitar libros específicos que les gustaría ver en el sitio. Los administradores y editores pueden ver y resolver estas solicitudes una vez que se hayan subido/agregado.  

## Despliegue  

### Requisitos  

Como mínimo para ejecutar la aplicación necesitas:  

- Una base de datos (MySQL, SQLite, PostgreSQL)  
- Una instancia de Redis  

Para un despliegue rápido y sencillo, el archivo .compose.yml.example ya define ambos.  

### Docker  
Sigue estos pasos para desplegar la aplicación con Docker Compose:  
1. **Descargar archivos de configuración**  
Descarga o clona el repositorio para obtener `compose.yml.example` y `.env.example`.  

2. **Renombrar los archivos de ejemplo**
``` bash
   mv compose.yml.example compose.yml
   mv .env.example .env
```
3. **Personaliza el archivo `.env`**

Edita `.env` para configurar los ajustes esenciales.

4. **Inicia la aplicación**

Ejecuta el siguiente comando:
``` bash
   docker compose up -d
```
Esto inicia los contenedores `BookHaven`, Redis y MySQL.  
5. **Acceder a la Aplicación**  

Abra su navegador y navegue a la `BASE_URL`:`APP_PORT` que configuró (el valor predeterminado es `http://localhost:5000`).  

6. **Detener la Aplicación**

``` bash
   docker compose down
```
### Desarrollo
Sigue estos pasos para desplegar en desarrollo:
1. **Clona el repositorio**:

``` bash
   git clone https://github.com/HrBingR/BookHaven.git
   cd BookHaven
```

2. **Renombrar los archivos de ejemplo**:
```bash
   mv compose.exmaple.yml compose.yml
   mv .env.example .env
```

3. **Personaliza el archivo `.env`**:

Edita `.env` para configurar ajustes esenciales.

4. **Modifica el archivo `compose.yml`**:

Cambia:

```yaml
    epub-reader:
       image: hrbingr/bookhaven:latest
```

To:

```yaml
  epub-reader:
     build:
        context: .
        dockerfile: Dockerfile
```
5. **Construir el contenedor**:

```bash
   docker compose up --build -d
```

6. **Acceder a la aplicación**:

Accede a la aplicación en la `BASE_URL` y `APP_PORT` definidos en el archivo `.env`.

## Construcción de la Aplicación
Para construir la aplicación para producción:
1. **Construir el Frontend**:
``` bash
   cd frontend
   npm run build:dev
```
2. **Construir la Imagen de Docker**:

En el directorio raíz del proyecto (BookHaven), ejecute:
``` bash
   docker build -t tag:version .
```
Reemplace `tag:version` con el nombre y la versión de imagen que prefiera (por ejemplo, `bookhaven:1.0.0`).

## Registro de cambios:

Para el registro detallado de cambios, consulte [CHANGELOG](https://raw.githubusercontent.com/HrBingR/BookHaven/master/CHANGELOG.md)

- v1.0.x
  - Lanzamiento inicial
- v1.1.0 - v1.1.1
  - Se añadió soporte OIDC
  - Se corrigió un error donde los componentes front-end de OIDC aún se renderizaban con OIDC deshabilitado.
- v1.2.0 - v1.2.2
  - Se añadió soporte para escribir opcionalmente metadatos en el archivo ePub, en lugar de solo en la base de datos.
  - Se corrigió un problema donde Celery detectaba PERIODIC_SCAN_INTERVAL, si estaba explícitamente definido, como una cadena y lanzaba una excepción.
  - Se corrigió la migración y la lógica del modelo de BD que impedían a los usuarios de Postgres inicializar correctamente la base de datos.
- v1.3.0 - v1.3.5
  - Se añadió soporte rudimentario para OPDS.
  - Se mejoró la funcionalidad de OPDS.
  - Se corrigieron problemas de la UI en la página de Autores
  - Se corrigieron algunos problemas de UX relacionados con el desplazamiento en la página de Inicio
  - Se mejoró la carga de imágenes de portada en el front-end
  - Se aumentó el límite predeterminado de tasa de API y se hizo personalizable
  - Se implementó bloqueo para el proceso de escaneo para asegurar que solo se ejecute un escaneo a la vez
  - Se mejoró el componente de BD de la lógica de escaneo
  - Se corrigió la renderización de listas de autores expandidas en móviles en la página "Autores"
  - Se actualizó la lógica de escaneo - la biblioteca ahora se escaneará automáticamente al iniciar
- v1.4.0 - v1.4.1
  - Se añadió funcionalidad de carga - consulte .env.example para saber cómo habilitar y usar
  - Se actualizaron los identificadores de respaldo del escáner de rutas relativas a nombres de archivo
  - Se creó migración para actualizar los identificadores de respaldo existentes
  - Se cambió de gunicorn sync a gunicorn gthread para mejor rendimiento en cargas
  - Se corrigieron importaciones de tareas de celery para escaneos programados
  - Se corrigió ocultar el botón de carga cuando la función de cargas está deshabilitada
- v1.5.0 - v1.5.2
  - Se añadió acceso basado en roles (RBAC). Los administradores ahora pueden asignar diferentes roles a los usuarios como sigue:
    - Usuario: Acceso a todas las funciones básicas excepto cargas, edición de metadatos y gestión de usuarios.
    - Editor: Incluye acceso a cargas y edición de metadatos.
    - Administrador: Incluye acceso a la gestión de otros usuarios.
  - Se mejoró la lógica al iniciar sesión vía Cloudflare Access.
  - Se corrigió un error menor que afectaba columnas heredadas que nunca fueron eliminadas.
  - Hacer el script de migración más resistente.
- v.1.6.0
  - Se añadió la función de solicitudes para que los usuarios puedan pedir que se agreguen nuevos libros al sitio.

## POR HACER:

- Actualizar las pruebas con las últimas incorporaciones
- Explorar el soporte para otros formatos
- Explorar la adición de más campos de metadatos para editar

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-22

---