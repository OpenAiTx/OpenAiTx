# Componente Web de Imagen Fluida

Imágenes que se escalan inteligentemente a cualquier tamaño deseado (dentro de límites razonables).

![Imágenes Fluidas](https://raw.githubusercontent.com/VoiceNGO/fluid-img/refs/heads/main/resources/images/responsive-images.jpg)

**¡Pequeño!:** 7kb minificado y comprimido con gzip

## Uso

```html
<script src="fluid-img.js"></script>
<fluid-img src="image.jpg"></fluid-img>
```

Eso es todo. Escala las imágenes como desees, y ellas simplemente funcionarán.

## Demostración

[Demostración Aquí](https://voicengo.github.io/fluid-img/public/fluid-demo.html)

También hay un entorno de pruebas disponible para [experimentar con tus propias imágenes](https://voicengo.github.io/fluid-img/public).
## Instalación

### Biblioteca de Cliente

```sh
npm install fluid-img
```

Luego importa `fluid-img` en tu proyecto, lo cual proporciona y registra el web-component:

```ts
import 'fluid-img';
```

O incluye el script desde jsdelivr o unpkg:

```html
<script src="https://cdn.jsdelivr.net/npm/fluid-img@latest/dist/fluid-img.js" />

<!-- o -->

<script src="https://unpkg.com/fluid-img@latest/dist/fluid-img.js" />
```
### Advertencias

El componente de imagen fluida funciona mejor para escalar imágenes horizontal o verticalmente dentro de un rango de aproximadamente 0.5x a 1.5x su tamaño original. Si bien puede manejar escalas mayores o menores, la calidad visual puede degradarse rápidamente. No se recomienda para imágenes donde la integridad de píxeles precisa es crítica, como retratos, gráficos o dibujos técnicos detallados, ya que el seam carving introduce distorsiones. Se recomienda encarecidamente probar tus imágenes en varios tamaños para asegurarte de que cumplen con tus expectativas visuales.

#### CORS

Debido a las restricciones de seguridad del navegador, las imágenes cargadas desde un origen diferente (dominio, protocolo o puerto) al de la página web generarán un error de Cross-Origin Resource Sharing (CORS). Este componente requiere acceso a los datos de píxeles sin procesar de la imagen, lo cual está restringido por CORS.

Para usar imágenes de un origen diferente, el servidor que aloja las imágenes debe estar configurado para enviar los encabezados CORS apropiados (por ejemplo, `Access-Control-Allow-Origin: *` o `Access-Control-Allow-Origin: tu-dominio.com`). Sin estos encabezados, el componente no podrá procesar la imagen.

(Para tu información, para fines de prueba, cualquier imagen en imgur tiene los encabezados CORS necesarios)

#### Reemplazo

Si el componente no puede cargar o procesar la imagen, o lanza un error interno, degradará de manera elegante inyectando una etiqueta estándar `<img>` dentro del componente `<fluid-img>`, con un ancho y alto del 100%, asegurando que la imagen aún se muestre.

## Opciones

Uso: `<fluid-img src="image.jpg" generator="random" max-carve-up-scale="5"></fluid-img>`

Por defecto, se utiliza el generador `random` ya que es el más rápido.

| Opción                         | Valores                           | Predeterminado | Descripción                                                                                                           |
| ------------------------------ | --------------------------------- | -------------- | --------------------------------------------------------------------------------------------------------------------- |
| `src`                          | URL                               |                | La URL de la imagen a procesar.                                                                                       |
| `generator`                    | `random`, `predictive`            | `predictive`   | El generador de seam carving a utilizar. `random` es más rápido pero de menor calidad.                                |
| `scaling-axis`                 | `horizontal`, `vertical`, `auto`  | `horizontal`   | El eje para el escalado. `auto` escala horizontal o vertical según los cambios de relación de aspecto.                |
| `mask`                         | URL                               |                | La URL de una imagen de máscara. Las áreas negras de la máscara tienen menor energía y es más probable que se conserven.|
| `carving-priority`             | Número (0-1, ej. `0.5`)           | `1`            | El porcentaje de escalado que se hará mediante seam carving frente a escalado de imagen tradicional.                  |
| `max-carve-up-seam-percentage` | Número (0-1, ej. `0.5`)           | `0.6`          | El porcentaje máximo de seams a insertar al escalar hacia arriba. Limita la creación de nuevos seams para preservar la calidad de la imagen. |
| `max-carve-up-scale`           | Número (ej. `3`)                  | `3`            | El factor máximo de ampliación usando seam carving. Más allá de esto, se usa escalado tradicional.                    |
| `max-carve-down-scale`         | Número (0-1, ej. `0.7`)           | `0.7`          | El porcentaje máximo de la imagen que se puede eliminar mediante seam carving al reducir el tamaño.                   |
### Opciones específicas del generador

Las opciones específicas del generador se agregan al componente `<fluid-img>`, pero solo son válidas cuando el atributo
`generator` correspondiente también está establecido.

#### Opciones del Generador Aleatorio y Predictivo

| Opción              | Valores                | Predeterminado | Descripción                                            |
| ------------------- | ---------------------- | -------------- | ------------------------------------------------------ |
| `batch-percentage`  | Número (0-1, p. ej. 0.1) | 0.1            | El porcentaje de costuras a generar por lote           |
| `min-batch-size`    | Número (p. ej. `10`)     | 10             | El número mínimo de costuras a generar por lote        |

## Cómo funciona

El seam carving es una técnica de redimensionamiento de imágenes consciente del contenido que elimina o agrega píxeles de manera inteligente, permitiendo cambiar el tamaño de una imagen sin distorsionar el contenido importante. Para más información, consulta el [artículo de Wikipedia](https://en.wikipedia.org/wiki/Seam_carving) sobre el tema.

Históricamente, el seam carving era demasiado intensivo computacionalmente para su uso en tiempo real en navegadores web. Sin embargo, esta limitación puede superarse usando algoritmos alternativos que son menos exigentes y funcionan bien en muchos escenarios.

Existen dos implementaciones del generador de seam carving:
### Tallado Aleatorio

El enfoque de tallado de costuras aleatorio abandona el algoritmo tradicional de tallado de costuras, que es demasiado lento para la ejecución en tiempo real en el navegador.

En su lugar, genera un conjunto de costuras aleatorias que proporcionan una cobertura del 100% de la imagen al conectar cada píxel en una fila con un píxel vecino en la siguiente. Luego, itera a través de cada costura, calcula su energía y descarta un lote de las costuras de menor energía. Este proceso se repite hasta alcanzar el número deseado de costuras. Este método produce resultados sorprendentemente buenos para muchas imágenes.

### Tallado Predictivo

Similar al tallado aleatorio, este método genera un mapa de energía y crea costuras en lotes. También genera un mapa de energía mínima para cada lote. La idea central es crear tanto costuras “buenas” como “malas”. Las buenas tienen baja energía y se conservan. Las malas incorporan píxeles de alta energía, lo que permite filtrarlas posteriormente.

Comenzando desde la primera fila, conecta pares de píxeles con los pares correspondientes en la siguiente fila. La costura de menor energía del cálculo en curso se conecta con la costura de menor energía del mapa de energía mínima.

El resultado es una costura realmente óptima, muchas costuras “muy buenas”, muchas “muy malas” y muchas mediocres. Seleccionamos un lote de las costuras “buenas”, descartamos el resto y repetimos el proceso.

##

## PENDIENTE

### Alta Prioridad

- [x] Componente web
- [x] Renderizador que toma datos de los generadores y escala a cualquier tamaño
- [x] Generador aleatorio
- [x] Tallado vertical
- [x] Generador predictivo
- [ ] Web workers para todos los generadores
### Baja Prioridad

- [x] Enmascaramiento
- [ ] Reconocimiento facial

### Sueño Imposible

- [ ] Tallado en 2D

## Licencia

Este software está licenciado bajo la Licencia Limitada por Ingresos de Fluid-Img.

**Uso gratuito** para individuos y organizaciones con ingresos brutos anuales inferiores a $10,000,000 USD.

**Se requiere licencia comercial** para organizaciones con ingresos anuales de $10M o más. Contacte a [licensing@voice.ngo] para términos de licencia comercial.

Consulte el archivo [LICENSE](./LICENSE) para conocer los términos completos.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-11

---