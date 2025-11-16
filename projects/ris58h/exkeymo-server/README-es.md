# ExKeyMo  
Desde Android 4.1, una aplicación puede proporcionar diseños de teclado adicionales mediante archivos de [Key Character Map](https://source.android.com/docs/core/input/key-character-map-files).  
Desde entonces, es posible personalizar un diseño de teclado sin acceso root instalando una aplicación que contenga el diseño requerido.  
ExKeyMo te ayuda a crear dicha aplicación incluso si no sabes nada sobre desarrollo en Android.  

ExKeyMo fue alojado por [Heroku](https://exkeymo.herokuapp.com/) pero ya no está disponible porque Heroku dejó de alojar proyectos gratis y no aprobó este proyecto para el Programa de Crédito de Software de Código Abierto de Heroku. Debes ejecutar ExKeyMo localmente para crear un APK con tu diseño personalizado o usar un APK precompilado listado a continuación.  

¿Necesitas más de dos diseños? Puedes crear un APK basado en el proyecto [Custom Keyboard Layout](https://github.com/ris58h/custom-keyboard-layout).  

¿Quieres apoyar? [Cómprame un café](https://www.buymeacoffee.com/ris58h).  

## APKs precompilados  
- CapsLock a Ctrl [ExKeyMo-caps2ctrl.zip](https://github.com/ris58h/exkeymo-server/files/12775514/ExKeyMo-caps2ctrl.zip)  
- CapsLock a Ctrl y viceversa [ExKeyMo-swap-caps-and-ctrl.zip](https://github.com/ris58h/exkeymo-server/files/12775516/ExKeyMo-swap-caps-and-ctrl.zip)  
- CapsLock a Esc [ExKeyMo-caps2esc.zip](https://github.com/ris58h/exkeymo-server/files/12775515/ExKeyMo-caps2esc.zip)  
- CapsLock a Esc y viceversa [ExKeyMo-swap-caps-and-esc.zip](https://github.com/ris58h/exkeymo-server/files/12775517/ExKeyMo-swap-caps-and-esc.zip)  

## Instalación y configuración de la app  

1. Instala la aplicación. La app está auto-firmada, por lo que Android te advertirá sobre una fuente no confiable o algo similar. Nota: si instalas la app y obtienes un error, intenta desinstalar la versión anterior primero, si tienes alguna.  
2. Ve a `Ajustes -> Idioma y entrada -> Teclado físico` (la ruta exacta puede variar), elige el teclado que quieres personalizar, y selecciona `Diseño ExKeyMo`.  

## Ejecutar el proyecto localmente  

### Requisitos  
- Java (17 o superior).  

### Obtener  
Clona el código fuente vía Git:
```
git clone git@github.com:ris58h/exkeymo-server.git
```
O [descárgalo](https://github.com/ris58h/exkeymo-server/archive/refs/heads/master.zip) como zip.

### Compilar
```
./mvnw clean install
```

### Run
```
java -jar target/exkeymo-server-*-jar-with-dependencies.jar
```
Para ejecutar en un puerto específico, use la propiedad del sistema `server.port`:
```
java -Dserver.port=PORT_NUMBER -jar target/exkeymo-server-*-jar-with-dependencies.jar
```

### Uso
Visite [http://localhost/](http://localhost/) y no olvide __RTFM__ ([http://localhost/docs.html](http://localhost/docs.html)).

### Ejecutar con Docker
Puede ejecutar la aplicación usando Docker. Hay dos formas de hacerlo: usando Docker Compose o solo Docker.

#### Usando Docker
Construya la imagen de Docker:
```bash
docker build -t exkeymo-server .
```

Ejecute el contenedor de Docker:
```bash
docker run -p 80:80 exkeymo-server
```
Esto iniciará el contenedor y expondrá la aplicación en el puerto 80.

#### Usando Docker Compose

Asegúrate de tener Docker y Docker Compose instalados. Luego, ejecuta el siguiente comando en el directorio que contiene el archivo `docker-compose.yml`:
```bash
docker-compose up
```
Esto construirá la imagen de Docker y arrancará el contenedor, exponiendo la aplicación en el puerto 80.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-16

---