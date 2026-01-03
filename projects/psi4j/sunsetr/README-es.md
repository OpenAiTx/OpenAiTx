# sunsetr

<p align="center">
    <img src="https://raw.githubusercontent.com/psi4j/sunsetr/main/.github/assets/logo.png" alt="logo de sunsetr" width="144" />
</p>
<p align="center">
    Filtro automático de luz azul para Hyprland, Niri y todo Wayland
</p>

<p align="center">
  <a href="https://psi4j.github.io/sunsetr/"><img src="https://img.shields.io/badge/Documentation-mdBook-blue" alt="Documentación"></a>
  <a href="https://github.com/psi4j/sunsetr/blob/main/LICENSE"><img src="https://img.shields.io/github/license/psi4j/sunsetr" alt="Licencia"></a>
  <a href="https://github.com/psi4j/sunsetr/releases"><img src="https://img.shields.io/github/v/release/psi4j/sunsetr" alt="Versión"></a>
</p>

<p align="center">
  <a href="https://psi4j.github.io/sunsetr/installation.html">Instalación</a> | <a href="https://psi4j.github.io/sunsetr/quick-start.html">Inicio Rápido</a> | <a href="https://psi4j.github.io/sunsetr/configuration/">Configuración</a> | <a href="https://psi4j.github.io/sunsetr/commands/">Comandos</a>
</p>

![Esta imagen fue tomada usando un shader para simular el efecto de sunsetr](https://raw.githubusercontent.com/psi4j/sunsetr/main/.github/assets/sunsetr.png)

Sunsetr es un filtro automático de luz azul para compositores Wayland. Automatiza transiciones suaves de temperatura de color desde tonos neutrales hasta más cálidos, diseñado para reducir la fatiga visual y mejorar el sueño. Sunsetr ajusta automáticamente tus pantallas según tu geolocalización o configuraciones manuales de tiempo. También puede usarse para mantener la misma temperatura de color y gamma indefinidamente, y puede alternar entre varios perfiles definidos por el usuario. El controlador puede integrarse y automatizar cambios en tu shell o aplicaciones UI mediante IPC.

## Características

- **Soporte Multi-Compositor**: Funciona con Hyprland, Niri, Sway, River, Wayfire y otros compositores Wayland
- **Backend CTM Nativo para Hyprland**: Soporte directo de Matriz de Transformación de Color para Hyprland
- **Gestión Mejorada de hyprsunset**: Añade transiciones de puesta/amanecer más largas, limpias y precisas a hyprsunset (Hyprland)
- **Transiciones Suaves**: Efectos de fundido configurables con algoritmo adaptativo
- **Gestión de Perfiles**: Cambio rápido entre perfiles de configuración (por ejemplo, día, juegos, fin de semana)
- **Recarga en Caliente**: Actualizaciones en vivo cuando cambian los archivos de configuración - no requiere reinicio
- **IPC para Automatización**: IPC basado en socket Unix para scripting e integraciones externas
- **Transiciones Basadas en Geolocalización**: Cálculo automático de amanecer/atardecer según tu ubicación
- **Selección Interactiva de Ciudades**: Elige entre más de 10,000 ciudades en todo el mundo para coordenadas precisas
- **Detección Automática de Zona Horaria**: Usa la zona horaria del sistema como aproximación de ubicación
- **Soporte Universal Wayland**: Comunicación directa de protocolo en compositores Wayland
- **Valores Predeterminados Inteligentes**: Funciona perfectamente desde el primer uso con configuraciones cuidadosamente ajustadas
- **Configuración Flexible**: Amplias opciones de personalización para usuarios avanzados

## POR HACER
- [x] Configurar paquete AUR  
- [x] Hacer disponible la instalación de Nix  
- [x] Implementar transiciones graduales  
- [x] Soporte para múltiples compositores Wayland  
- [x] Transiciones basadas en geolocalización  
- [x] Implementar backend CTM nativo de Hyprland  
- [x] Implementar IPC para scripting e integraciones externas  
- [ ] Hacer disponible la instalación en Fedora Copr  
- [ ] Hacer disponible la instalación en Debian/Ubuntu  

## 💛 Agradecimientos  

- a wlsunset, hyprsunset y redshift por la inspiración  
- al equipo de Hyprwm por hacer posible Hyprland  
- al equipo de niri por crear el mejor compositor Wayland basado en Rust  
- a la comunidad de Wayland por el ecosistema robusto del protocolo  



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-03

---