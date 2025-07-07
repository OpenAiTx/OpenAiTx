<p align="center">
  <img src="https://raw.githubusercontent.com/aadya940/autoresume/main/main_app/frontend/public/autoresume-logo.png" alt="autoResume Logo" title="autoResume Logo" width="180"/>
</p>

<h1 align="center">autoResume</h1>

<p align="center">
  <b>Constructor de currículums de código abierto: pega tus enlaces, edita manualmente y deja que la IA te ayude a pulir, actualizar y adaptar tu currículum.</b>
</p>

---

### ¿Cómo usar esto?

[Enlace al Blog en Medium](https://medium.com/@aadyachinubhai/autoresume-copy-and-paste-links-its-that-simple-8e50e6d155a1)

El blog está desactualizado con respecto a la Interfaz de Usuario y la plantilla utilizada.

## Características

- <b>Importación fácil de enlaces:</b> Pega enlaces de sitios web y crea rápidamente un currículum en PDF.
- <b>Editor manual incluido:</b> Ajusta o construye tu currículum desde cero con un editor de código integrado.
- <b>Sugerencias inteligentes:</b> Comparte comentarios o nuevos enlaces, y las ediciones inteligentes te ayudarán a refinar y actualizar tu currículum.
- <b>Adaptado para empleos:</b> Pega una descripción de puesto y obtén recomendaciones para alinear tu currículum.
- <b>Calidad LaTeX:</b> Todos los currículums se generan usando LaTeX para un diseño limpio y profesional.
- <b>Vista previa instantánea:</b> Visualiza tu currículum como PDF en tiempo real.
- <b>Reinicio fácil:</b> Borra y reinicia tu currículum con un solo clic.
- <b>Local:</b> Funciona completamente en tu máquina usando Docker.

---

## Primeros pasos

### Requisitos previos
- [Docker](https://www.docker.com/get-started)
- [Docker Compose](https://docs.docker.com/compose/)

### Configuración

1. Clona el repositorio:
   ```bash
   git clone https://github.com/aadya940/autoresume.git
   cd autoresume
   ```
2. Construye e inicia la aplicación:
   ```bash
   docker compose up --build
   ```
3. Accede a las aplicaciones:
   
   [_http://localhost:5173_](http://localhost:5173)
---

## Uso

1. Abre autoResume en tu navegador.
2. Haz clic en el icono :gear:, pega tu [CLAVE DE API DE GOOGLE](https://aistudio.google.com/) y tu correo electrónico.
3. Pega enlaces a tu información profesional (por ejemplo, Github, sitio web personal, etc.).
4. Opcionalmente, añade comentarios o el enlace de una oferta de trabajo para una mayor personalización.
5. Haz clic en <b>Generar Currículum</b> y deja que la IA haga el resto.

---

## Licencia

Este proyecto está licenciado bajo la Licencia Apache 2.0.

## Guía de contribución

### Frontend
- Implementa componentes de React en la carpeta `frontend/src/components/`
- Usamos Chakra UI para implementar los componentes.
- Importa y utiliza tus componentes en `frontend/src/App.jsx`

### Backend
- Implementa rutas API en el directorio `backend/src/routes/`
- Añade funcionalidad de IA en el directorio `backend/src/ai/`
- Usamos el formateador de código `black` para código Python
- Mantén los controladores de rutas limpios y la lógica separada

### Pautas generales
- Crea una nueva rama para tu funcionalidad/arreglo: `git checkout -b tu-nombre-de-rama`
- Escribe mensajes de commit claros
- Prueba tus cambios antes de enviar un PR

### Envío de cambios
1. Crea un Pull Request
2. En la descripción de tu PR, incluye:
   - Qué cambios realizaste
   - Por qué los realizaste
   - Cualquier captura de pantalla o resultado de pruebas relevante
   - Cualquier cambio importante o pasos de migración necesarios

¡Agradecemos tus contribuciones y revisaremos tu PR lo antes posible!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-07

---