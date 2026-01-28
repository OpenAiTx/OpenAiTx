# PacketSniffer - Herramienta de captura y análisis de protocolos de red en tiempo real

Una herramienta de captura de paquetes de red en tiempo real desarrollada en C#, que soporta el reconocimiento automático de protocolos, análisis y distribución de lógica de negocio.

## Características

- 🔍 **Captura en tiempo real**: Utiliza SharpPcap para la captura de paquetes de red  
- 🔄 **Reconocimiento automático de protocolos**: Soporta reconocimiento automático de JSON, HTTP y protocolos binarios  
- 📊 **Análisis inteligente**: Extracción automática de campos y contenido del protocolo  
- 🎯 **Distribución de negocios**: Soporta el manejo personalizado de la lógica de negocio  
- 🛡️ **Alta extensibilidad**: Fácil de agregar nuevos analizadores de protocolos  

## Estructura del proyecto

```
PacketSniffer/
├── PacketSniffer.csproj      # 项目配置文件
├── Program.cs                 # 程序入口
├── Core/
│   ├── Sniffer.cs            # 抓包核心模块
│   └── PacketRouter.cs       # 数据包路由分发器
├── Parsers/
│   ├── IParser.cs            # 解析器接口
│   ├── JsonParser.cs         # JSON 协议解析器
│   ├── HttpParser.cs         # HTTP 协议解析器
│   └── BinaryParser.cs       # 二进制协议解析器（兜底）
└── Models/
    └── ParsedResult.cs       # 解析结果数据模型
```
## Requisitos del entorno

- .NET 6.0 o versión superior
- Sistema operativo Windows (requiere ejecución con privilegios de administrador)
- Adaptador de red instalado

## Pasos de instalación

### 1. Clonar o descargar el proyecto


```bash
cd "D:\C# Project\zhuabao"
```

### 2. Restaurar dependencias de NuGet

```bash
dotnet restore
```

### 3. Construcción del proyecto

```bash
dotnet build
```

## Método de uso

### Ejecución básica

**Importante: ¡Debe ejecutarse con privilegios de administrador!**

```bash
# 默认模式：只打印 HTTP Request 的时间 + 方法 + 路径
dotnet run

# 完整模式：打印完整数据包信息（包含 IP/MAC/端口/Body 等）
dotnet run -- --full

# 先构建后运行
dotnet build
dotnet bin/Debug/net6.0/PacketSniffer.exe
```

### 配置文件 `config.json`

所有需要手动调整的内容都集中在根目录的 `config.json`，程序运行时会从 **exe 所在目录** 读取该文件。

示例：

```json
{
  "DeviceKeyword": "loopback",
  "Ports": [5005],
  "FilterSourcePort": true,
  "FilterDestinationPort": true,
  "HttpPathFilters": [
    "/api/"
  ]
}
```
- **DeviceKeyword**：Palabras clave para filtrar la tarjeta de red (coincide con Name/Description).  
  Por ejemplo `"Intel"`, `"Realtek"`, `"Npcap Loopback"`, `"loopback"`. Si está vacío u omitido, seleccionará automáticamente la tarjeta física primero, luego Npcap Loopback.
- **Ports**：Lista de puertos a escuchar (coincide con puerto origen o destino). Si está vacío u omitido, escucha en todos los puertos.
- **FilterSourcePort / FilterDestinationPort**：Si se filtra por puerto origen / puerto destino.
- **HttpPathFilters**：Palabras clave para filtrar la ruta de la solicitud HTTP, solo efectivo para **HTTP Request**.  
  Por ejemplo `["/api/"]` significa que solo imprime solicitudes HTTP cuya ruta contiene `/api/`.

### Flujo de ejecución

1. Al iniciar, lee `config.json`, determinando: palabras clave de la tarjeta, puertos a escuchar, reglas de filtrado de ruta HTTP.
2. Según `DeviceKeyword` realiza una búsqueda difusa en la lista de tarjetas, seleccionando primero la tarjeta configurada; si no hay configuración, selecciona automáticamente la tarjeta física primero, luego Npcap Loopback.  
   La consola listará todas las tarjetas con etiquetas `[PHYSICAL]` / `[VIRTUAL]` / `[LOOPBACK]`.
3. Activa el modo promiscuo para la captura de paquetes.
4. Captura en tiempo real el payload de paquetes TCP/UDP y filtra según la configuración de puertos (`Ports` + FilterSource/FilterDestination).
5. Detecta automáticamente el tipo de protocolo (JsonParser → HttpParser → BinaryParser).
6. Modo por defecto: solo procesa solicitudes HTTP, analiza la línea de petición e imprime `hora + método + ruta + puerto`, con opción de filtrar por palabra clave en la ruta.
7. Modo completo (`--full`): para cada paquete construye `PacketInfo`, imprime la estructura completa del paquete, información de encabezados y resumen del Payload.

### Detener el programa

Presione `Ctrl+C` para salir elegantemente, el programa detendrá la captura y limpiará los recursos automáticamente.

## Descripción del análisis de protocolos

### Análisis de protocolo JSON

- **Método de identificación**: comprueba si el payload comienza con `{` o `[`
- **Contenido analizado**: extrae todos los pares clave-valor de primer nivel
- **Formato de salida**: `Protocol=json, Fields={key1=value1, key2=value2, ...}`

### Análisis de protocolo HTTP

- **Método de identificación**: comprueba si comienza con método HTTP (GET/POST, etc.) o `HTTP/1.x`
- **Contenido analizado**:
  - Analiza los encabezados HTTP (todos los campos header)
  - Analiza la línea de petición o línea de estado
  - Si el cuerpo es JSON, analiza automáticamente los campos JSON
- **Formato de salida**: `Protocol=http, Fields={request_line=..., header_Content-Type=..., ...}`


### Análisis del Protocolo Binario

- **Método de identificación**: Como analizador de respaldo, todos los protocolos no reconocidos usarán este analizador  
- **Contenido del análisis**: Convierte el payload a una cadena hexadecimal  
- **Formato de salida**: `Protocol=binary, Fields={hex=AA BB CC DD ...}`  
- **Consejo de extensión**: Puedes agregar lógica personalizada de análisis de protocolos en `BinaryParser.cs`  

## Procesamiento de la Lógica de Negocio

La versión actual por defecto solo realiza "captura + análisis + impresión", para facilitar la observación del tráfico real:

- En modo predeterminado: solo imprime el tiempo, método, ruta e información del puerto de la solicitud HTTP.  
- En modo completo: imprime el `PacketInfo` completo, incluyendo información de capa de enlace/IP/capa de transporte y resumen del Payload.  
- La entrada para el procesamiento de negocio `HandleBusinessLogic(ParsedResult result)` se mantiene para que puedas realizar procesamiento personalizado según el resultado del análisis.  

## Extensión Personalizada

### Añadir un nuevo analizador de protocolo

1. Implementa la interfaz `IParser`:

```csharp
public class CustomParser : IParser
{
    public bool CanParse(byte[] payload)
    {
        // 判断逻辑
        return false;
    }

    public ParsedResult Parse(byte[] payload)
    {
        // 解析逻辑
        return new ParsedResult { ... };
    }
}
```

2. Regístrelo en `Program.cs`:

```csharp
router.RegisterParser(new CustomParser());
```

### Lógica de negocio extendida

Agrega lógica personalizada en el método `HandleBusinessLogic()` de `PacketRouter.cs`:

```csharp
private void HandleBusinessLogic(ParsedResult result)
{
    // 添加你的业务逻辑
    if (result.Fields.ContainsKey("yourKey"))
    {
        // 处理逻辑
    }
}
```

## Ejemplo de salida

### Modo predeterminado: solo imprimir la ruta de la solicitud HTTP

Usar la siguiente configuración (archivo `config.json`) como ejemplo:

```json
{
  "DeviceKeyword": "loopback",
  "Ports": [5005],
  "FilterSourcePort": true,
  "FilterDestinationPort": true,
  "HttpPathFilters": [
    "/api/"
  ]
}
```

Ejemplo de salida de ejecución:

```text
=== Packet Sniffer - Protocol Parse Mode ===
已加载配置文件: C:\...\bin\Debug\net6.0\config.json
端口过滤: 已启用，监听端口: 5005
过滤模式: 源端口=True, 目标端口=True
网卡关键字: "loopback"（将优先匹配 Name/Description）
HTTP 路径过滤已启用，关键字列表：
  - /api/

Using device (from config/auto): Npcap Loopback Adapter
Packet capture started. Press Ctrl+C to stop.

======================================================================================================================
[2025-12-01 16:30:12.345] GET /api/user/123  (src:52345 -> dst:5005)
======================================================================================================================
[2025-12-01 16:30:13.001] POST /api/order/create  (src:52346 -> dst:5005)
```

### Modo completo: imprimir información completa del paquete

```bash
dotnet run -- --full
```
Ejemplo de salida (truncado):


```text
================================================================================
数据包捕获时间: 2025-12-01 16:31:00.123
--------------------------------------------------------------------------------
数据包长度: 1500 字节
链路层类型: Ethernet
源 MAC 地址: AA:BB:CC:DD:EE:FF
目标 MAC 地址: 11:22:33:44:55:66

网络层协议: IPv4Packet
IP 版本: IPv4
源 IP 地址: 192.168.1.100
目标 IP 地址: 192.168.1.1
TTL: 64

传输层协议: TCP
源端口: 52345
目标端口: 5005
TCP 标志: Syn, Ack

Payload 长度: 256 字节
Payload (十六进制):
0000: 47 45 54 20 2F 61 70 69 2F 75 73 65 72 2F 31 32 | GET /api/user/12
...
================================================================================
```

## Notas importantes

1. **Permisos de administrador**: La función de captura requiere permisos de administrador, de lo contrario no se podrá abrir el adaptador de red  
2. **Cortafuegos**: Algunos cortafuegos pueden bloquear la operación de captura  
3. **Impacto en el rendimiento**: Un gran volumen de tráfico de red puede afectar el rendimiento del programa, se recomienda usar filtros de puerto para reducir la carga  
4. **Privacidad y seguridad**: Asegúrese de usar en un entorno legal y conforme a normativas, no capture datos privados de terceros  
5. **Filtro de puerto**: Usar filtro de puerto puede reducir significativamente la cantidad de paquetes procesados y mejorar el rendimiento  

## Solución de problemas

### Problema 1: No se encuentran dispositivos de red

**Mensaje de error**: `No network devices found`

**Solución**:  
- Asegúrese de que el controlador del adaptador de red esté instalado  
- Verifique que haya una conexión de red disponible  
- Intente ejecutar con permisos de administrador  

### Problema 2: No se puede abrir el dispositivo

**Mensaje de error**: `Failed to open device`

**Solución**:  
- Asegúrese de ejecutar con permisos de administrador  
- Verifique que ningún otro programa esté usando el adaptador de red  
- Intente reiniciar el programa  

### Problema 3: Error de análisis

**Síntoma**: Algunos paquetes no se pueden analizar

**Explicación**: Esto es normal, los protocolos no reconocidos se mostrarán con BinaryParser en formato hexadecimal  

## Tecnología utilizada

- **.NET 6.0** - Marco de desarrollo  
- **SharpPcap 6.2.5** - Biblioteca de captura de red  
- **PacketDotNet 1.4.7** - Biblioteca de análisis de paquetes  
- **Newtonsoft.Json 13.0.3** - Biblioteca de análisis JSON

## Licencia

Este proyecto es solo para uso de aprendizaje e investigación.

## Registro de cambios

### v1.0.0 (2024)
- ✅ Implementación de captura de red en tiempo real
- ✅ Soporte para reconocimiento automático de protocolos JSON/HTTP/binarios
- ✅ Implementación del mecanismo de distribución de lógica de negocio
- ✅ Soporte para salida elegante (Ctrl+C)

## Contacto

Si tiene preguntas o sugerencias, por favor envíe un Issue o Pull Request.

---

**⚠️ Aviso legal**: Esta herramienta es solo para uso educativo y legal, y el usuario asume toda la responsabilidad legal derivada de su uso.


## Stargazers over time
[![Stargazers over time](https://starchart.cc/Preserved-name/PacketSniffer.svg?variant=adaptive)](https://starchart.cc/Preserved-name/PacketSniffer)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-28

---