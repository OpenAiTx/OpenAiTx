# 🗺️ Pathfinder

<div align="center">
  <img src="https://raw.githubusercontent.com/shadowoff09/pathfinder/master/public/banner-readme.png" alt="Pathfinder Banner" width="1280"/>
  
  Una aplicación moderna e interactiva de mapas construida con Next.js 15, MapboxGL y TypeScript. Pathfinder ofrece una experiencia de mapeo fluida con funciones como datos meteorológicos en tiempo real, búsqueda de ubicaciones y estilos de mapa personalizables.

  [Demo](https://link.shadowdev.xyz/r/m3tydbf12hb) · [Reportar error](https://github.com/shadowoff09/pathfinder/issues) · [Solicitar función](https://github.com/shadowoff09/pathfinder/issues)
</div>

## ✨ Características

- 🌓 Soporte para modo oscuro/claro
- 🏢 Visualización de edificios en 3D
- 🔍 Búsqueda de ubicación con autocompletado
- 🌤️ Información meteorológica en tiempo real
- 📍 Detección de ubicación actual
- 🛰️ Alternar vista de calle/satélite
- 📱 Diseño completamente adaptable
- ⌨️ Soporte para atajos de teclado
- 🎨 Interfaz moderna con Tailwind CSS y shadcn/ui

## 🚀 Primeros pasos

### Requisitos previos

- Node.js 22+ 
- Una clave API de Mapbox (consíguela en [Mapbox](https://www.mapbox.com/))
- Una clave API de OpenWeather (consíguela en [OpenWeather](https://openweathermap.org/api))
- npm o yarn

### Instalación

1. Clona el repositorio:
```bash
git clone https://github.com/shadowoff09/pathfinder.git
cd pathfinder
```
2. Instalar dependencias:

```bash
npm install
# or
yarn install
```

3. Configure las variables de entorno:
   - Copie el archivo `.env.example` a `.env.local`:
     ```bash
     cp .env.example .env.local
     ```
   - Abre `.env.local` y agrega tu clave API de Mapbox:
     ```env
     NEXT_PUBLIC_MAPBOX_ACCESS_TOKEN=your_mapbox_token_here
     NEXT_PUBLIC_WEATHER_API_KEY=your_weather_api_key_here
     ```
   - Obtén tus claves API de:
     - [Mapbox](https://www.mapbox.com/) - para la funcionalidad de mapas
     - [OpenWeather](https://openweathermap.org/api) - para datos meteorológicos

4. Inicia el servidor de desarrollo:
```bash
npm run dev
# or
yarn dev
```
5. Abre [http://localhost:3000](http://localhost:3000) en tu navegador.

## 🎮 Uso

### Navegación del Mapa
- Desplazar: Haz clic y arrastra
- Zoom: Desplázate con la rueda o usa los controles de zoom
- Rotar: Haz clic derecho y arrastra
- Restablecer Vista: Presiona Ctrl+Q

### Funcionalidades
- Buscar ubicaciones usando la barra de búsqueda
- Alternar entre vista de calles y satélite
- Ver edificios 3D en modo vista de calles (nivel de zoom 15+)
- Consultar información del clima (nivel de zoom 14+)
- Obtener ubicación actual con un clic
- Copiar coordenadas al portapapeles

## 🛠️ Construido Con

- [Next.js 15](https://nextjs.org/) - Framework React
- [TypeScript](https://www.typescriptlang.org/) - Seguridad de tipos
- [Mapbox GL JS](https://www.mapbox.com/mapbox-gl-js) - API de mapas
- [Tailwind CSS](https://tailwindcss.com/) - Estilos
- [shadcn/ui](https://ui.shadcn.com/) - Componentes UI
- [React Map GL](https://visgl.github.io/react-map-gl/) - Wrapper React para Mapbox GL

## 🤝 Contribuciones

¡Las contribuciones son bienvenidas! Por favor, no dudes en enviar un Pull Request. Para cambios importantes, primero abre un issue para discutir lo que te gustaría cambiar.

1. Haz un fork del proyecto
2. Crea tu rama de característica (`git checkout -b feature/AmazingFeature`)
3. Haz commit de tus cambios (`git commit -m 'Add some AmazingFeature'`)
4. Sube la rama (`git push origin feature/AmazingFeature`)
5. Abre un Pull Request

## 📝 Licencia


Este proyecto está licenciado bajo la Licencia MIT - vea el archivo [LICENSE](LICENSE) para más detalles.

## 🙏 Agradecimientos

- [Mapbox](https://www.mapbox.com/) por su excelente plataforma de mapas
- [shadcn/ui](https://ui.shadcn.com/) por los hermosos componentes de UI
- [Vercel](https://vercel.com) por el alojamiento y despliegue

## 📫 Contacto

X - [@shadowdev09](https://twitter.com/shadowdev09)

Portafolio - [https://shadowdev.xyz](https://shadowdev.xyz)

## 💖 Apoya el Proyecto

Si disfrutas usando Pathfinder y deseas apoyar su desarrollo, considera hacer una donación:

- [Donar vía PayPal](https://paypal.me/diogogaspar123)
- [Donar vía Ko-Fi](ko-fi.com/shadowoff09)
- [GitHub Sponsors](https://github.com/sponsors/shadowoff09)


¡Tus contribuciones ayudan a mantener el proyecto vivo y a mejorar sus funciones! ¡Gracias por tu apoyo!

---
<a href="https://www.producthunt.com/posts/pathfinder-11?embed=true&utm_source=badge-featured&utm_medium=badge&utm_souce=badge-pathfinder&#0045;11" target="_blank"><img src="https://api.producthunt.com/widgets/embed-image/v1/featured.svg?post_id=915601&theme=dark&t=1740532963013" alt="Pathfinder - Navega&#0032;Tu&#0032;Mundo&#0044;&#0032;Hermosamente | Product Hunt" style="width: 250px; height: 54px;" width="250" height="54" /></a>

⭐️ ¡Si te gusta este proyecto, por favor dale una estrella!

[![Stargazers over time](https://starchart.cc/shadowoff09/pathfinder.svg?variant=adaptive)](https://starchart.cc/shadowoff09/pathfinder)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-20

---