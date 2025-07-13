# Botón Presionable 3D

Un componente de botón 3D realista construido con HTML, CSS y SVG que simula la sensación de presionar un botón físico. El botón cuenta con animaciones suaves, colores personalizables e interacciones responsivas.

Creado por [@BalintFerenczy](https://x.com/BalintFerenczy)

Inspirado por el increíble trabajo en [Resend](https://resend.com/)

## Características

- **Apariencia 3D realista** utilizando gráficos SVG en capas
- **Animaciones suaves** con funciones de aceleración personalizadas
- **Estados interactivos** - efectos al pasar el cursor y al presionar
- **Colores personalizables** mediante variables CSS
- **Diseño responsivo** que se adapta al tamaño del contenedor

## Demostración
El botón responde a las interacciones del usuario con tres estados distintos:
- **Normal**: El botón en su posición de reposo
- **Hover**: Movimiento sutil hacia abajo cuando el mouse pasa por encima
- **Activo**: Movimiento significativo hacia abajo cuando se presiona/hace clic

## Uso

### Personalización

El botón puede personalizarse fácilmente usando propiedades personalizadas de CSS:

```css
.frame {
    /* Dimensiones del botón */
    width: 400px; 
    height: 400px; 

    /* Distancias de movimiento */
    --hover-travel: 3px;
    --press-travel: 40px;
    
    /* Personalización de color */
    --color: black;
    --brightness: 1;
    --blend-mode: color;

    /* Configuración de transición */
    --transition-duration: 0.4s;
    --transition-easing: ease-in-out;
}
```
#### Cambiar el texto del botón

Simplemente modifica el contenido del texto:

```html
<p class="text">¡Haz clic aquí!</p>
```

#### Cambiar el tamaño del botón

Ajusta las dimensiones del marco:

```css
.frame {
    width: 200px;
    height: 200px;
}
```
## Licencia

Este proyecto es de código abierto y está disponible bajo la Licencia MIT.

## Contribuciones

¡No dudes en bifurcar este proyecto y enviar pull requests para mejoras o nuevas funciones!

## Autor

Creado por [@BalintFerenczy](https://x.com/BalintFerenczy)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---