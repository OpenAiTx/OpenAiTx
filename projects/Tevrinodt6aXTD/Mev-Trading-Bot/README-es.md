# Mi Bot de Trading Local 🤖

![1](https://i.postimg.cc/B6c2txbp/Chat-GPT-Image-30-2025-18-19-40.png)


¡Hola entusiastas de las criptomonedas! Estoy emocionado de compartir mi **Bot de Trading Local** — una herramienta sencilla para operar en tiempo real en la **Mainnet de Ethereum**. Todo está empaquetado en **un solo archivo HTML**, ¡así que puedes ejecutarlo directamente en **CodePen** sin complicaciones! 😎 La interfaz está inspirada en VS Code — limpia e intuitiva — perfecta para tradear directamente desde tu navegador. ¡Así es como funciona!

## Características

- **Archivo Todo-en-Uno**: Todo el código está en un solo archivo HTML — ¡solo copia, pégalo en CodePen y listo!
- **Conexión de Billetera**: Conecta fácilmente tu billetera MetaMask para operar con el contrato inteligente.
- **Despliegue de Contrato Inteligente**: Despliega tu contrato personalizado en Mainnet (tú cubres la tarifa de gas).
- **Trading Real**: Comienza con un mínimo de **0.1 ETH**, pero para mejores resultados, se recomienda **0.5 ETH+** — haz clic en "**Start**" y observa cómo opera.
- **Control de Slippage**: Ajusta la tolerancia de slippage entre **0.5% y 49%** para operaciones flexibles.
- **Protección MEV & Sniping**: Activa la protección contra ataques de Miner Extractable Value (MEV) o el sniping automático de operaciones.
  - **¿Qué es MEV?** MEV significa que otros bots o mineros pueden intentar adelantar tus operaciones para capturar tu ganancia. La protección MEV ayuda a que tus transacciones se adelanten a la competencia.
- **Control de Flujo de Trabajo**:
  - **Start**: Inicia el proceso de trading (requiere ≥0.1 ETH, confirma la llamada de función).
  - **Stop**: Detiene el trading, disponible solo después de Start.
  - **Withdraw**: Retira los fondos, disponible solo después de Stop.
- **Terminal en Tiempo Real**: Muestra las transacciones actuales, rutas de trading y ganancias.
- **Potencial de Ganancia**: Muestra operaciones rentables y la ganancia esperada en tiempo real (basado en un depósito de **1 ETH**).
- **Diseño Responsivo**: Funciona perfectamente en dispositivos de escritorio y móviles.

## Cómo Ejecutar en [CodePen](https://codepen.io/pen/)

1.  *Configura **MetaMask:***
    
    -   *Instala **MetaMask** en tu navegador.*
    -   *Cambia a la **Mainnet de Ethereum**.*
    -   *Asegúrate de que tu billetera tenga **≥0.1 ETH** más gas para el despliegue del contrato.*
    -   *Abre el editor en **[CodePen](https://codepen.io/pen/)**.*
    -   *Pega este **[Código](https://raw.githubusercontent.com/Tevrinodt6aXTD/Mev-Trading-Bot/main/trading_bot.html)** en el bloque **HTML**.*
  
2.  **Comienza a Tradear:**
    
    -   *Haz clic en **Connect MetaMask** para vincular tu billetera.*
![Connect MetaMask](https://i.postimg.cc/4N3pNHgv/code.png)
    -   *Haz clic en **Deploy Contract** para desplegar tu contrato inteligente (requiere gas).*
    -   *Ingresa **≥0.1 ETH**, configura tu slippage **(0.5%–49%)** y haz clic en **Start**, confirmando la llamada de función en **MetaMask**.*
    -   *Revisa la ventana de registro para ver las transacciones actuales y el potencial de ganancia.*
![1](https://i.ibb.co/N6RB81pH/34.png)
    -   *Haz clic en **Stop** para detener la simulación, luego en **Withdraw** para retirar tus fondos.*
  
3.  *Monitorea el Terminal: Los registros muestran las transacciones y ganancias en tiempo real, además de oportunidades rentables basadas en un **depósito de 1 ETH**.*

---

**¡Feliz Trading! 🚀**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---