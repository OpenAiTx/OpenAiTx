# Turbodrone
API y cliente invertidos para controlar algunos de los drones "juguete" más vendidos de ~$50 en Amazon desde una computadora, reemplazando las aplicaciones móviles de código cerrado con las que vienen.

![S20 Drone Short Clip](https://raw.githubusercontent.com/marshallrichards/turbodrone/master/docs/images/s20-drone-short-clip-small.gif)

## Introducción
Hoy en día, hay drones "juguete" increíblemente baratos disponibles en Amazon que son básicamente clones simplificados del DJI Mavic temprano. Solo ~$50 para tener una cámara 1080p para FPV y grabación, un pequeño sensor óptico de flujo hacia abajo para posición y mantenimiento de altitud, y un perfil de vuelo bien ajustado desde el primer momento. El único problema con drones como este es que ejecutan firmware de código cerrado y están bloqueados para ser controlados solo por una aplicación móvil personalizada. Pensé que sería genial liberar algunos de estos drones de su "cárcel" y escribir una API y un cliente para acceder al video y enviar comandos de control al drone mediante ingeniería inversa de cómo funcionan las aplicaciones móviles. De esa forma puedes convertir un drone "juguete" altamente capaz de $50 en algo que pueda ser controlado programáticamente y usado para todo tipo de aplicaciones y experimentos.

## Hardware
* Drone con cámara WiFi (ordenados por recomendación):

    | Marca      | Número(s) de Modelo    | Compatibilidad | Enlace de Compra                                               | Notas |
    |------------|-----------------|---------------|-------------------------------------------------------------|-------|
    | Karuisrc | K417 | Probado | [Amazon](https://www.amazon.com/Electric-Adjustable-AIdrones-Quadcopter-Beginners/dp/B0CYPSJ34H/) | Mi favorito ahora mismo. ¡El único en la lista con motores sin escobillas! Calidad de construcción fantástica. |
    | Loiley     | S29             | Probado    | [Amazon](https://www.amazon.com/Beginners-Altitude-Gestures-Adjustable-Batteries/dp/B0CFDVKJKC)                  | Mejor calidad de construcción, tiene servo para inclinar la cámara (_aún no implementado en la API_)|
    | Hiturbo    | S20             | Probado    | [Amazon](https://www.amazon.com/dp/B0BBVZ849G), [Listado alternativo en Amazon](https://www.amazon.com/Beginners-Foldable-Quadcopter-Gestures-Batteries/dp/B0D8LK1KJ3)                  | Plataforma de prueba original, gran calidad de construcción|
    | FlyVista | V88 | Probado | [Amazon](https://www.amazon.com/dp/B0D5CXY6X8) | |
    | ? | D16/GT3/V66 | Probado | más barato en [Aliexpress](https://www.aliexpress.us/item/3256808590663347.html), [Amazon](https://www.amazon.com/THOAML-Batteries-Altitude-Headless-360%C2%B0Flip/dp/B0F1D6F62J/) | Clon DJI Neo un 20% más pequeño. Solo realmente bueno para vuelo interior. 
    | Varias marcas | E58 | Probado | [Amazon](https://www.amazon.com/Foldable-Quadcopter-Beginners-Batteries-Waypoints/dp/B09KV8L7WN/) |  |
    | Varias marcas | E88/E88 Pro | Sospechado | [Amazon](https://www.amazon.com/Foldable-Camera-Quadcopter-Altitude-Beginner/dp/B0DZCLFQXN) | |
    | Varias marcas | E99/E99 Pro | Sospechado | [Amazon](https://www.amazon.com/LJN53-Foldable-Drone-Dual-Cameras/dp/B0DRH9C6RF) | |
    | Swifsen | A35 | Sospechado | [Amazon](https://a.co/d/bqKvloz) | Drone "juguete" muy pequeño|
    | Desconocido | LSRC-S1S | Sospechado | | mencionado en otro esfuerzo de ingeniería inversa para la app WiFi UAV|
    | Velcase    | S101            | POR HACER | [Amazon](https://www.amazon.com/Foldable-Beginners-Quadcopter-Carrying-Positioning/dp/B0CH341G5F/)  | calidad de construcción inferior, batería y hélices más pequeñas que S29 y S20|
    | Redrie | X29 | POR HACER | [Amazon](https://www.amazon.com/Adults-1080P-Foldable-Altitude-Auto-Follow-Batteries/dp/B0CZQKNYL5) | Trabajando en este ahora|

    _**Probado** significa que el drone ha sido físicamente usado con turbodrone para asegurar su compatibilidad._

  _**Sospechado** significa que el APK para el drone parece usar los mismos paquetes y librerías exactas que uno de los drones probados._

  _**POR HACER** significa que el APK opera con paquetes y protocolos diferentes y tendrá que ser agregado como una nueva implementación en la API._

* Dongle WiFi ([recomiendo ALFA Network AWUS036ACM](https://www.amazon.com/Network-AWUS036ACM-Long-Range-Wide-Coverage-High-Sensitivity/dp/B08BJS8FXD) o similar) 
  * El drone transmite su propia red WiFi, por lo que tu computadora tendrá que conectarse a ella.
  * No es estrictamente necesario porque puedes usar el radio WiFi integrado de tu computadora para conectarte a la red del drone, pero es bueno tenerlo para poder seguir conectado a internet mientras vuelas el drone.


## Configuración
Muévete al directorio `backend`
```
cd backend
```
Añadir venv

```
python -m venv venv
source venv/bin/activate
```

Instalar las dependencias
```
pip install -r requirements.txt
```
_Si_ estás en Windows, necesitarás instalar manualmente la biblioteca `curses`.

```
pip install windows-curses
```

Abre una nueva ventana de terminal e instala las dependencias para el frontend.
_Asegúrate de tener instalado Node.js 20 o superior._
```
cd frontend
npm install
```

Asegúrese de que el dongle WiFi esté conectado, el dron esté encendido y conectado a la red "BRAND-MODEL-XXXXXX" antes de continuar.

Cree un archivo `.env` en el directorio `backend`. Agregue un DRONE_TYPE según el dron que tenga:
```
# For "com.vison.macrochip" (s2x) based drones like S20 and S29:
DRONE_TYPE=s2x
# For WiFi UAV-based drones like V88 and D16:
# DRONE_TYPE=wifi_uav 
```

Lanzar el backend: 
```
uvicorn web_server:app
```

En una terminal separada, inicie el cliente web frontend:
```
npm run dev
```

Abre el cliente web que estará en `http://localhost:5173` y deberías ver la transmisión de video del dron y poder controlarlo.

Para controlar mediante un mando de juegos, conéctalo y mueve las palancas para que sea detectado y luego presiona el botón de alternar para cambiar entre control por teclado y por mando.

Asegúrate de volar en un área segura, preferiblemente al aire libre con poco viento. Y nota que el botón "Aterrizar" _actualmente_ es más un botón de paro de emergencia que detendrá los motores del dron inmediatamente.


## Estado
La lógica de reconexión se resolvió recientemente.

Transmisión de video: estable.

Controles: mejorados significativamente a través del cliente web. La implementación para drones basados en WiFi UAV podría necesitar algunos ajustes.

Cliente web: soporte para varias entradas como teclado, mandos de juego y el mouse TrackPoint de ThinkPad (lol).

Estamos trabajando en añadir soporte para más drones de la [lista de drones más vendidos de Amazon](https://www.amazon.com/best-selling-drones/s?k=best+selling+drones).


## Contribuir
Para contribuir con soporte para un nuevo dron "juguete", descarga el APK que usa el dron en un sitio espejo y comienza a hacer ingeniería inversa descompilando a archivos Java con [jadx](https://github.com/skylot/jadx).
Desde ahí, revisa el `AndroidManifest.xml` y busca si puedes encontrar las clases que son puntos de entrada para la app. Busca uso de puertos o protocolos explícitamente mencionados como TCP o UDP. La mayoría de estas apps harán la comunicación real y el procesamiento de la transmisión de video en librerías nativas C++ que estarán incrustadas dentro del APK. Puedes usar una herramienta como Ghidra para descompilar las librerías nativas y ver si descubres algo útil. Para el procesamiento de la transmisión de video quieres averiguar qué formato usa, por ejemplo JPEG, YUV, etc., y también si usa compresión y cómo es la estructura de bytes cuando reconstruye un cuadro de imagen a partir de paquetes.
Adicionalmente, Wireshark es tu amigo para entender los paquetes de datos crudos que la app envía y recibe. Mira este [video](https://x.com/marshallrichrds/status/1923165437698670818) para una visión general del proceso de ingeniería inversa usado para añadir soporte para el dron Hiturbo S20.

Una vez que tengas los protocolos y el procesamiento para el control remoto y video resueltos, crea un pequeño programa de prueba y añádelo al directorio `experimental` si quieres que otros puedan probarlo.
Después de eso, puedes trabajar en una implementación compatible con la arquitectura de back-end existente; ejemplos de esto son las implementaciones de ingeniería inversa `s2x` y `wifi_uav`.


## Soporte Experimental
Para drones y apps con soporte limitado que aún no están completamente integrados en Turbodrone, consulta el directorio `experimental`.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-29

---