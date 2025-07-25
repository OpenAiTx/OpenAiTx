<div align="right">
  <details>
    <summary >🌐 Otros Idiomas</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>


[English](https://raw.githubusercontent.com/sz30/2048--/main/README.md) | [简体中文](https://raw.githubusercontent.com/sz30/2048--/main/README.zh-CN.md) | [繁體中文](https://raw.githubusercontent.com/sz30/2048--/main/README.zh-TW.md)

# 🎮 2048++

¡Una versión mejorada del clásico juego 2048, ahora con aún más funciones divertidas! Este es un pequeño proyecto que desarrollé en mi tiempo libre—¡espero que te brinde alegría!

## 🎯 Introducción al Juego

2048 es un juego sencillo pero adictivo de combinación de números. En una cuadrícula de 4x4, desliza hacia arriba, abajo, izquierda o derecha para combinar fichas con el mismo número. ¿El objetivo? ¡Llegar a 2048 (pero puedes seguir jugando para lograr puntuaciones más altas)!

**Cómo jugar:**
- Usa las teclas de flecha o WASD para mover las fichas.
- Cuando dos fichas con el mismo número chocan, se fusionan en una sola.
- Después de cada movimiento, un nuevo 2 o 4 aparecerá aleatoriamente en un espacio vacío.
- El juego termina cuando no quedan más movimientos posibles.

## ✨ Características Especiales

### 1. Función de Deshacer
- ¿Hiciste un movimiento equivocado? ¡No te preocupes!
- Solo pulsa el botón "Deshacer" para retroceder un paso.
- Puedes deshacer tantas veces como quieras, hasta volver al inicio.
- ¡Nunca dejes que un error con el dedo arruine tu partida otra vez!

### 2. Modo Trampa Secreto
- Introduce la secuencia mágica: ←←→→ →→←← (izquierda, izquierda, derecha, derecha,  derecha, derecha, izquierda, izquierda)
- ¡Todas las fichas mágicamente se convertirán en 128!
- Es un huevo de pascua, solo por diversión.
- Consejo: Hacer trampa es divertido, ¡pero no abuses! 😉

## 🎯 Demo

🎯 Juega aquí: [2048.765431.xyz](https://2048.765431.xyz/)
<img width="1279" alt="demo" src="https://github.com/user-attachments/assets/0df2c956-b6d9-4371-a916-f6ac3ae642be" />



## 📁 Estructura del Proyecto
```
2048/
├── static/
│ ├── css/
│ │ └── styles.css # Game styles
│ └── js/
│ └── script.js # Frontend game logic
├── index.html # Main game page
└── 2048.py # Backend server
```
**Descripciones de Archivos:**
- `2048.py`: Servidor backend escrito con Flask, maneja la lógica del juego y las solicitudes API.
- `script.js`: Lógica del juego en el frontend, incluye movimientos, animaciones y funciones especiales.
- `styles.css`: Estilos del juego, asegurando que todo luzca bien y sea responsivo.
- `index.html`: La página principal que integra todo.

## 🚀 Comenzando

**Método 1: Descargar Release**
1. Descarga la última versión.
2. Asegúrate de tener Python 3.x instalado.
3. Instala las dependencias: `pip install flask`
4. Ejecuta: `python 2048.py`
5. Abre tu navegador y ve a: [http://localhost:9969](http://localhost:9969)

**Método 2: Clonar desde GitHub**
```bash
git clone https://github.com/sz30/2048.git
cd 2048
pip install flask
python 2048.py
```

## 🎨 Personalización

¿Quieres hacerlo tuyo? Modifica `styles.css` para un nuevo aspecto, o sumérgete en `script.js` para cambiar la jugabilidad. ¡Todo el código está bien comentado para facilitar la personalización!

## 📝 Licencia

Licencia GPL-2.0

## 🤝 Contribuciones

¡Seguimos actualizando! Los Issues y Pull Requests son muy bienvenidos—¡hagamos este juego aún más increíble juntos!


## 🙏 Agradecimientos

Gracias a los siguientes patrocinadores por apoyar este proyecto:
- [IDC.REST](https://idc.rest/) por proporcionar el servidor
- [Serv00](https://www.serv00.com/) por proporcionar el servidor

---
_Última actualización: Jun. 2025_


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-25

---