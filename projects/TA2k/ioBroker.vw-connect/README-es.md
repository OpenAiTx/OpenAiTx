![Logo](https://raw.githubusercontent.com/TA2k/ioBroker.vw-connect/master/admin/vw-connect.png)

# ioBroker.vw-connect

[![NPM version](http://img.shields.io/npm/v/iobroker.vw-connect.svg)](https://www.npmjs.com/package/iobroker.vw-connect)
[![Downloads](https://img.shields.io/npm/dm/iobroker.vw-connect.svg)](https://www.npmjs.com/package/iobroker.vw-connect)
[![Dependency Status](https://img.shields.io/david/ta2k/iobroker.vw-connect.svg)](https://david-dm.org/ta2k/iobroker.vw-connect)
[![Known Vulnerabilities](https://snyk.io/test/github/ta2k/ioBroker.vw-connect/badge.svg)](https://snyk.io/test/github/ta2k/ioBroker.vw-connect)

[![NPM](https://nodei.co/npm/iobroker.vw-connect.png?downloads=true)](https://nodei.co/npm/iobroker.vw-connect/)

**Tests:**: [![Travis-CI](http://img.shields.io/travis/ta2k/ioBroker.vw-connect/master.svg)](https://travis-ci.org/ta2k/ioBroker.vw-connect)

## Adaptador vw-connect para ioBroker

Adaptador para VW We Connect, We Connect ID, We Charge, myAudi, Skoda Connect, Seat Connect y We Connect Go

Por favor actualice su sistema a Node 10.
<https://forum.iobroker.net/topic/22867/how-to-node-js-f%C3%BCr-iobroker-richtig-updaten>

## Uso

Use el estado bajo control remoto para controlar su coche a distancia.
El refresco normal es el intervalo de sondeo para recibir datos de la nube VAG
El refresco forzado es para coches no eléctricos para forzar una actualización, este número está limitado por VAG hasta que el coche se encienda de nuevo.
Los datos del viaje solo están disponibles para coches no eléctricos.

Puede configurar la temperatura de climatización en
.climater.settings.targetTemperature.content

## Discusión y Preguntas

<https://forum.iobroker.net/topic/26438/test-adapter-vw-connect-für-vw-id-audi-seat-skoda>

## Explicación de campos de estado

### Lista de entradas

```

```
## Registro de cambios

### 0.7.12 (2025-05-05)

- corrección para el token de actualización de skoda  
- corrección para la activación de ventilación  
- añadir nuevos endpoints no soportados  

### 0.7.9 (2025-03-20)

- corrección para cargador de pared id  

### 0.7.7 (2025-03-02)

- corrección para calefacción auxiliar y duración en skoda  
- corrección para bloqueo/desbloqueo en skoda  

### 0.7.6 (2025-02-28)

- corrección para actualizaciones de estado de carga solo al inicio  
- corrección para estado ismoving de skoda  

### 0.7.3 (2025-02-26)

- corrección para establecer setTemperature  
- corrección para desbloqueo y bloqueo en Skoda  

### 0.7.0 (2025-02-25)

- corrección para skoda y seat  
- Estructura del estado cambiada completamente, por favor elimine los estados antiguos bajo Objetos  

### 0.6.1 (2024-10-01)

- corrección para login de skoda  

### 0.6.0 (2024-04-11)

- añadir estados adicionales de cupra  

### 0.5.4 (2024-03-17)

- corrección de estados de ventana de puerta  

### 0.4.1

- Corrección de actualización de estado VW  

### 0.0.65

- Corrección de login de Cupra  

### 0.0.63

- Corrección de login VW/Skoda etron  

### 0.0.62

- Corrección de login Audi etron  

### 0.0.61

- Corrección de login ID  

### 0.0.60

- Mejoras menores. El intervalo mínimo de WeCharge ahora es de 15 minutos  

### 0.0.55

- corrección de actualización de estado id  

### 0.0.51

- corrección de login audi etron  

### 0.0.48

- corrección de login, corrección de actualización audi, añadir límite para wallbox  

### 0.0.43

- aumento de tiempos de espera del token de actualización  

### 0.0.42

- corrección de login skoda  

### 0.0.40

- añadir clima v3 para coches más nuevos. Añadir Powerpass y Seat Elli  

### 0.0.39

- corrección de login id  

### 0.0.36

- añadir soporte para Skoda Enyaq  


### 0.0.35

- añadir compatibilidad con nodeJS v10

### 0.0.34

- añadir aceptación automática del nuevo consentimiento de privacidad

### 0.0.32

- corregir selección de los últimos viajes recientes

### 0.0.31

- habilitar selección múltiple de tipos de viaje

### 0.0.30

- solucionar problema con múltiples coches, añadir modo VWv2, por el momento no hay diferencia entre VW y VWv2

### 0.0.29

- corregir refreshToken de skoda, pequeñas mejoras

### 0.0.26

- corrección de errores

### 0.0.25

- añadir we charge

### 0.0.24

- añadir actualización remota de estado

### 0.0.23

- añadir Seat y nueva climatización v2

### 0.0.22

- calcular temperatura exterior en °C también para Skoda y Audi

### 0.0.21

- añadir controles remotos para id

### 0.0.20

- corregir login de audi, añadir login ID

### 0.0.19

- guardar objetos de estado en state por id en lugar de números consecutivos

### 0.0.18

- corregir estado de batería para modelos 2020

### 0.0.17

- añadir soporte para modelos 2020

### 0.0.16

- corregir problemas con js.controller 3

### 0.0.11

- corregir error de audi con múltiples vehículos
- ocultar error de actualización de estado si la función no está disponible

## Licencia

Licencia MIT

Copyright (c) 2019-2030 ta2k <tombox2020@gmail.com>

Por la presente se concede permiso, sin cargo, a cualquier persona que obtenga una copia
de este software y los archivos de documentación asociados (el "Software"), para usar
el Software sin restricción, incluyendo sin limitación los derechos de usar, copiar,
modificar, fusionar, publicar, distribuir, sublicenciar y/o vender copias del Software,
y permitir a las personas a quienes se les proporcione el Software hacerlo, sujeto a las
siguientes condiciones:

El aviso de copyright anterior y este aviso de permiso deberán incluirse en todas
las copias o partes sustanciales del Software.

EL SOFTWARE SE PROPORCIONA "TAL CUAL", SIN GARANTÍA DE NINGÚN TIPO, EXPRESA O
IMPLÍCITA, INCLUYENDO PERO NO LIMITADO A LAS GARANTÍAS DE COMERCIABILIDAD,
IDONEIDAD PARA UN PROPÓSITO PARTICULAR Y NO INFRACCIÓN. EN NINGÚN CASO LOS
AUTORES O LOS TITULARES DEL COPYRIGHT SERÁN RESPONSABLES DE NINGUNA RECLAMACIÓN, DAÑOS U OTRA
RESPONSABILIDAD, YA SEA EN UNA ACCIÓN DE CONTRATO, AGRAVIO O DE OTRO TIPO, QUE SURJA DE,
FUERA O EN CONEXIÓN CON EL SOFTWARE O EL USO U OTROS TRATOS EN EL SOFTWARE.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-01

---