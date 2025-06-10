# Gantt

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
Gráfico de Gantt desarrollado con Vue, se puede utilizar para colaboración en equipo y división de tareas en escenarios ágiles.

Soporta agrupación
Soporta arrastrar y soltar
Soporta estiramiento
Soporta porcentaje
Soporta rangos de tiempo: día, semana, mes
Actualmente solo se ha implementado agrupación de un nivel, pero para evitar futuras necesidades de agrupación de dos o más niveles, en la última entrega se reestructuró parte del código para soportar agrupación multinivel, aunque en la versión actual no está desarrollado.

Ventajas: Al arrastrar, estirar o modificar el progreso, los datos no se actualizan en tiempo real, sino que se actualizan después de la operación, lo que reduce la pérdida de rendimiento.
          Al editar, eliminar o agregar, no se modifica de forma recursiva toda la instancia, sino que solo se agregan, eliminan o modifican las partes afectadas.

Se está preparando una reorganización para convertirlo en un componente. Actualmente, para utilizarlo en un proyecto solo es necesario importar `gant.vue` de este proyecto.
¡El método para importar y exportar datos en lote ya está escrito, solo copia y usa!~
```

### Notas de actualización

- Soporta edición
- Soporta eliminación
- Solucionado el bug que impedía el desplazamiento vertical (además se añadió desplazamiento bidireccional simultáneo) [#4](https://github.com/GGBeng1/Gantt/issues/4)
- Solucionado el bug causado por elementUI
- Sobre el problema de los rangos de tiempo [#5](https://github.com/GGBeng1/Gantt/issues/5)
- Actualmente no es posible configurar otros rangos, como añadir horas, modificando la configuración de rango. Debido a que algunas configuraciones están fijadas durante la inicialización. Se cambiará en el futuro y se publicará como API.


### Ver ejemplo

Ver [demo](https://ggbeng1.github.io/Gantt/#/)

### Imagen de muestra

<img src="https://raw.githubusercontent.com/GGBeng1/Gantt/master/public/demo.png" alt="">

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---