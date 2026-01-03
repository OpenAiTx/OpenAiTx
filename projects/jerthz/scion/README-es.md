<img src="https://raw.githubusercontent.com/jerthz/scion/main/banner.png" alt="Scion" />

Scion es una biblioteca de juegos 2D hecha en Rust.

> Por favor, tenga en cuenta que este proyecto está en sus primeras etapas y está sujeto a cambios según las necesidades de conveniencia y las grandes características que se avecinan.
> 
> Puede usar Scion como desee, aunque hice este proyecto de código abierto para servir a la comunidad y no para competir con el ecosistema actual de motores de juegos en Rust.

## ¿Por qué este proyecto? 
Bueno, primero porque es una buena manera de aprender los diferentes aspectos del desarrollo de juegos bajo el capó. 
Luego, porque quería crear algo con objetivos modestos, enfocado en la facilidad de uso y una lista corta de principios que también sirven como guía.

Scion no está 'inspirado' en ningún otro motor, está inspirado en las necesidades de proyectos reales de juegos. Esto significa que no implemento características solo porque las haya visto en otro lugar, sino porque las necesito para el próximo proyecto que use Scion.

### Objetivos
- Enfoque fuerte solo en **2D**.
- **Fácil** y **Divertido** de usar. 
- Código fuente limpio y legible (al menos intentaremos reescribir cuando sea necesario)
- Sin editor, es una librería y siempre debería ser así

### No objetivos
- Código ultra/sobre optimizado y rendimiento extremo. Para esto, ¡por favor pruebe otros motores o construya el suyo propio!
- 3D

## ¿Documentación, Tutoriales?
Sí, están planeados y en desarrollo. Si quieres ver Scion en acción, revisa los ejemplos por ahora.

## ¿Por qué ECS?
Hoy en día, ECS es como una palabra 'mágica' para juegos, bibliotecas de juegos y motores de juegos. Pero ECS no es y no debe considerarse una respuesta universal a múltiples preguntas.
Creo que ECS tiene sus fortalezas y sus debilidades. 
La elección de ECS aquí se hizo porque los juegos objetivo principales de esta librería al inicio eran poder hacer: 
- un juego complejo de construcción de ciudades.
- un juego fan de pkmn con progresión de entrenador en tiempo real y pkmn salvajes.
- representación granular de paquetes de red y juegos de simulación de puntos.

## Dependencias notables
Estas son las dependencias en las que se basa este proyecto. Gracias a estas increíbles comunidades, podemos construir este tipo de proyectos pequeños. 

- <a href="https://github.com/rust-windowing/winit" target="blank">winit</a> y <a href="https://github.com/gfx-rs/wgpu/tree/master/wgpu" target="blank">wgpu</a> (ventanas y renderizado multi backend)
- <a href="https://github.com/Ralith/hecs" target="blank">hecs</a> (Sistema de componentes de entidades)
- <a href="https://github.com/termhn/ultraviolet" target="blank">ultraviolet</a> (Matemáticas)

## Requisitos previos
Para compilar Scion, necesitas instalar los paquetes requeridos para tu sistema: 
### Debian, Ubuntu, PopOS...
```sh
sudo apt install gcc cmake build-essential libx11-dev libxi-dev libgl1-mesa-dev libasound2-dev
```

### Fedora
```sh
sudo dnf install gcc cmake make automake gcc gcc-c++ kernel-devel libX11-devel libXi-devel mesa-libGL-devel alsa-lib-devel
```
### Arch, Manjaro...

```sh
sudo pacman -S gcc cmake make automake linux-headers libx11 libxi mesa alsa-lib
```

### Ejecutar un ejemplo
Luego, puedes ejecutar un ejemplo:
```sh
cargo run --example bomberman --release
```

## Exhibición

| <img src="https://raw.githubusercontent.com/jerthz/scion/main/./examples/taquin/taquin_2.gif" alt="Taquin" style="width:300px; border: 2px solid black;"/>  | <img src="https://raw.githubusercontent.com/jerthz/scion/main/./examples/tetris/tetris.gif" alt="Tetris" style="width:300px" />             | <img src="https://raw.githubusercontent.com/jerthz/scion/main/./examples/pixel-adventures/pixel-adventures.gif" alt="Pixel-adventures" style="width:300px" /> |
|---------------------------------------------------------------------------------------------------------|-----------------------------------------------------------------------------------------|-----------------------------------------------------------------------------------------------------------|
| <img src="https://raw.githubusercontent.com/jerthz/scion/main/./examples/bomberman/bomberman.gif" alt="Bomberman" style="width:300px" />                    | <img src="https://raw.githubusercontent.com/jerthz/scion/main/./examples/jezzball/jezzball.gif" alt="Jezzball" style="width:300px" />       | <img src="https://raw.githubusercontent.com/jerthz/scion/main/./examples/new-bark-town/new-bark-town.gif" alt="New bark town" style="width:300px" />          |
| <img src="https://raw.githubusercontent.com/jerthz/scion/main/./examples/starlight-1961/starlight.gif" alt="Starlight" style="width:300px" />               | <img src="https://raw.githubusercontent.com/jerthz/scion/main/./examples/klondike.gif" alt="Starlight" style="width:300px" /> | |



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-03

---