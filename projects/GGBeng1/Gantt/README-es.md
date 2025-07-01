# Gantt
<div style="text-align: center"><p><a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> </p></div>
## Instalación

```
yarn install
```

### Ejecución

```
yarn run serve
```

### Descripción

```
Gráfico de Gantt desarrollado en vue, puede utilizarse para colaboración en equipo, división de tareas y otros escenarios ágiles.

Soporta agrupación
Soporta arrastrar y soltar
Soporta estiramiento
Soporta porcentaje
Soporta rangos de tiempo: día, semana, mes
Actualmente solo se ha implementado agrupación de un solo nivel. Para evitar futuras necesidades de agrupación de dos o más niveles, en la última entrega se reestructuró parte del código para soportar agrupación multinivel, pero la versión actual no la incluye.

Ventajas: Al arrastrar, estirar, modificar el progreso, etc., los datos no se actualizan en tiempo real, sino después de la operación, lo que reduce el consumo de recursos.
      Al editar, eliminar o agregar, no se modifica toda la instancia de forma recursiva, solo se agregan, eliminan o modifican las partes necesarias.

Actualmente se está reorganizando el código para modularizarlo como componente. Por ahora, para usarlo en un proyecto solo es necesario importar `gant.vue` de este proyecto.
Los métodos para importar y exportar datos en lote ya están escritos, ¡solo hay que copiarlos!~

```

### Notas de actualización

- Soporta edición
- Soporta eliminación
- Corrección de bug que impedía el desplazamiento vertical (además se agregó desplazamiento bidireccional simultáneo) [#4](https://github.com/GGBeng1/Gantt/issues/4)
- Corrección de bug causado por elementUI
- Sobre el tema del rango de tiempo [#5](https://github.com/GGBeng1/Gantt/issues/5)
- Actualmente no es posible configurar otros rangos de tiempo, como agregar horas, solo cambiando la configuración de rango. Algunas configuraciones están fijas durante la inicialización; en el futuro esto se modificará y se ofrecerá como API.


### Ver ejemplo

Ver [demo](https://ggbeng1.github.io/Gantt/#/)

### Imagen de muestra

<img src="https://raw.githubusercontent.com/GGBeng1/Gantt/master/public/demo.png" alt="">

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-01

---