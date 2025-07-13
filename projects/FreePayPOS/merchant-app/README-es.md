# Terminal de Pago NFC

Un terminal de pago NFC multichain que procesa pagos con criptomonedas a través de 5 redes blockchain con monitoreo de transacciones en tiempo real y seguimiento histórico integral.

## 🌐 Redes Soportadas

- **Ethereum**
- **Base** 
- **Arbitrum** 
- **Optimism** 
- **Polygon** 

### 🎯 **Prioridad de Pago Inteligente**

En lugar de negociar una combinación de cadena/token con el comerciante, el terminal de pago lo gestiona automáticamente. Primero determina una cadena que el comerciante soporte y en la que también tengas fondos, luego envía una transacción con ETH o un token ERC-20 con la siguiente prioridad:

```
Stablecoin L2 > Otro L2 > ETH L2 > Stablecoin L1 > Otro L1 > ETH L1
```

## 🚀 Inicio Rápido

1. **Instala las dependencias:**
   ```bash
   npm install
   ```

2. **Configuración del entorno:**
   ```bash
   echo "ALCHEMY_API_KEY=tu_clave_api_de_alchemy_aquí" > .env
   ```

3. **Ejecuta la terminal:**
   ```bash
   npm start
   ```

4. **Abre la interfaz:**
   Navega a `http://localhost:3000`

## 🏗️ Arquitectura

```
src/
├── server.ts                   # Servidor Express y manejador de WebSocket
├── app.ts                      # Orquestador principal de la aplicación
├── web/index.html              # Interfaz de usuario del terminal de pago
├── config/index.ts             # Configuración multi-cadena
└── services/
    ├── nfcService.ts           # Lector NFC y escaneo de billeteras
    ├── alchemyService.ts       # Balance y monitoreo multi-cadena
    ├── paymentService.ts       # Selección de pago y generación de EIP-681
    ├── ethereumService.ts      # Utilidades para validación de direcciones
    └── addressProcessor.ts     # Prevención de procesamiento duplicado
scripts/
└── rpi-deploy/
    ├── setup-build-environment.sh  # Instala dependencias para permitir la construcción de una imagen de Raspberry Pi
    └── build-pi-image-osx.sh       # Construye una imagen de Raspberry Pi
```
## 💡 Uso

### **Procesamiento de Pagos**
1. Ingrese el monto usando el teclado (basado en centavos: "150" = $1.50)
2. Toque "Cobrar" para iniciar el pago
3. El cliente acerca el dispositivo NFC para enviar el pago
4. La monitorización en tiempo real confirma la transacción
5. Mensaje de "Aprobado" con enlace al explorador de bloques

### **Historial de Transacciones**
1. Toque el botón de historial 📜 en el teclado
2. Vea todas las transacciones o escanee una billetera para un historial específico
3. Toque "📱 Escanear Billetera para Historial" y pida al cliente que acerque su dispositivo
4. Navegue por las transacciones filtradas de esa billetera específica


## 🔄 Flujo de Pago

1. **Detección NFC** → El cliente acerca el dispositivo
2. **Obtención Multi-Cadena** → Análisis de portafolio en las 6 cadenas
3. **Selección Inteligente** → Token de pago óptimo basado en el sistema de prioridades
4. **Generación EIP-681** → Solicitud de pago con ID de cadena
5. **Monitorización en Tiempo Real** → WebSocket/sondeo para confirmación de transacción
6. **Registro de Historial** → Transacción almacenada con metadatos completos
## 🛡️ Monitoreo de Transacciones

- **Monitoreo por WebSocket** para Ethereum, Base, Arbitrum, Optimism, Polygon
- **Monitoreo basado en sondeo** como respaldo
- **Tiempo de espera automático** después de 5 minutos
- **Integración con exploradores de bloques** para verificación de transacciones
- **Seguimiento de estado**: detectado → confirmado → fallido

## 🍓 Despliegue en Raspberry Pi

Este terminal de pago NFC puede desplegarse como un **kiosco plug-and-play** en hardware Raspberry Pi para uso en producción.

### **Requisitos de Hardware**
- Raspberry Pi 4B (se recomienda 4GB+ de RAM)
- Pantalla táctil oficial de Raspberry Pi de 7"
- **Lector NFC ACR1252U-M1** (específicamente soportado)
- Tarjeta MicroSD de 32GB o más

### **Características de Despliegue**
- **Compilación con un solo comando** que crea una imagen de tarjeta SD booteable
- **WiFi preconfigurado** y credenciales de API
- **Inicio automático** con modo kiosco a pantalla completa
- **Validación de seguridad** que previene el despliegue con direcciones de prueba
- Soporte de compilación para **macOS y Linux**
### **Despliegue Rápido**
```bash
# Navega a los scripts de despliegue
cd scripts/rpi-deploy

# Configura tu despliegue
cp build-config.env.template build-config.env
# Edita build-config.env con tu WiFi, clave API y dirección del comerciante

# Construye la imagen booteable (macOS)
./build-pi-image-osx.sh

# Flashea el archivo generado nfc-terminal-<date>.img.gz a la tarjeta SD usando Raspberry Pi Imager ¡y arranca!
```

📖 **[Guía Completa de Despliegue](https://raw.githubusercontent.com/FreePayPOS/merchant-app/main/README-DEPLOYMENT.md)**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---