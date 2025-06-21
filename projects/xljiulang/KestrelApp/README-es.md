# KestrelApp
Ejemplo de aplicación de programación de red basada en Kestrel

### 1 Objetivo del proyecto
1. Comprender que la programación de red ya no necesita comenzar desde Socket
2. Comprender que la programación de red ya no necesita marcos de terceros (incluido Dotnetty)
3. Comprender la programación de red tipo "matrioska" de `telnet` sobre `websocket` sobre `tls` sobre `xxx cifrado privado` sobre `tcp`
4. Poder desarrollar aplicaciones de red basadas en KestrelFramework

### 2 Documentación
**Documentación interna**: [docs](https://raw.githubusercontent.com/xljiulang/KestrelApp/master/docs)

**Documentación externa**
* [Pipelines](https://learn.microsoft.com/zh-cn/dotnet/standard/io/pipelines)
* [Buffers](https://learn.microsoft.com/zh-cn/dotnet/standard/io/buffers)

### 3 KestrelFramework
Algunas bibliotecas básicas necesarias para la programación de red con kestrel
1. Interfaces de middleware en Kestrel y registro intermedio
2. System.Buffers: clases para la manipulación de buffers
3. System.IO: clases para la manipulación de flujos
4. System.IO.Pipelines: clases para la manipulación de canales dúplex
5. Middleware: algunos middlewares de kestrel

### 4 KestrelApp
Aplicación Kestrel, el contenido incluye
1. Configuración de EndPoint a escuchar
2. Configuración de protocolo utilizado por el EndPoint

### 5 KestrelApp.Middleware
Biblioteca de clases de middleware de KestrelApp
#### 5.1 Echo
Ejemplo de protocolo de aplicación Echo simple

#### 5.2 FlowAnalyze
Ejemplo de middleware para estadísticas de flujo a nivel de transporte

#### 5.3 FlowXor
Ejemplo de middleware para procesamiento XOR del flujo a nivel de transporte

#### 5.4 HttpProxy
Ejemplo de protocolo de aplicación proxy http

#### 5.5 Telnet
Ejemplo de protocolo de aplicación Telnet simple

#### 5.6 TelnetProxy
Ejemplo de reenvío de tráfico al servidor telnet

#### 5.6 Redis
Servidor de protocolo redis, muestra cómo usar middleware de aplicación

### El código abierto es más emocionante contigo
![Donación](https://raw.githubusercontent.com/xljiulang/KestrelApp/master/reward.png)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-21

---