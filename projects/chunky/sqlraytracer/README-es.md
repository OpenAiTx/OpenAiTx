# Un Raytracer Puro en SQL

Todos escriben un raytracer tarde o temprano. Este es el mío.

## Ejemplos de Resultados

<img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/dielectricparty.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/oneglassball.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/onemirrorball.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/glassmatrix.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/airy.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/onediamondball.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/oneantiglassball.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/adjacentballs.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/onegreyball.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/reflectiontest.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/twodiffuseballs.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/onegreenball.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/threemirrors.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/twomirrorballs.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/busyday.png" width=200>

## Uso

```shell
sh create.sh
```

```postgres_connection.sh``` contiene host/base de datos/usuario/contraseña/etc.
No hay necesidades exóticas aparte de "postgres, como versión 10 en adelante
o algo así"

Para lo que vale, creé el mío así en mi escritorio Ubuntu:
```shell
sudo su - postgres
createuser --pwprompt raytracer
createdb -O raytracer raytracer
```

### Palancas para el desarrollo y renderizado

Mientras se realiza el desarrollo, obviamente un tiempo de renderizado de varios minutos es un ciclo bastante
lento. Hay algunas palancas que puedes accionar para acelerar las cosas
y reducir la calidad. Están en "camera" y "img" en setup.sql:

* *samples\_per\_px* - Este es el número de rayos/sub-muestras por píxel.
  - 1 o 2 está bien durante la depuración
  - 15-20 da imágenes "trabajables"
  - Pasar de 50 no genera mucha mejora visible
* *max\_ray\_depth* - El número máximo de rebotes del rayo
  - Para escenas simples, usualmente no hace más de 5 rebotes
* *res\_x* y *res\_y* - Resolución final de la imagen
  - Más pequeño es más rápido

El CTE principal lleva muchas cosas que no son necesarias para la salida final.
Esto es para que pueda examinar los rayos rebotando a través de la escena con:
```sql
SELECT * FROM rays WHERE img_x=100 AND img_y=250
```

Hay un script para obtener una vista rápida y sencilla de una escena usando gnuplot;
el script ```show_scene.sh``` debería generar una carpeta con salidas.

## Base de Datos

Esto está implementado en SQL puro. No hace nada como CREATE
FUNCTION u otros no portables, excepto el trigger para hacer animación,
que obviamente no cuenta.

Al mismo tiempo, hay algunas características no del todo comunes de SQL
que necesita:

* JOIN LATERAL
* PARTITION BY dentro de un CTE RECURSIVO
* Funciones matemáticas como SIN()

Así que aunque empecé desarrollando esto en SQLite, terminé
apoyándome en PostgreSQL. Mientras escribo esto, funciona en postgres y no ha sido
probado en nada más.

## Piezas Interesantes de la Implementación

Tal como es, me encontré resolviendo algunos problemas de maneras interesantes.

### JOIN LATERAL

JOIN LATERAL es una forma de hacer una subconsulta correlacionada en un JOIN, en lugar de
solo en una cláusula WHERE. Uso esto como una forma de extraer cálculos y
hacer muchos de ellos solo una vez y, en algunos casos, evitar duplicaciones excesivas.

### Dispersión Difusa

Esto requiere muestrear una esfera uniforme. Genero muchas muestras aleatorias
con anticipación [muestreo con rechazo -> escalar puntos a la superficie de la esfera],
y las numero.

Encontrar una manera de unir cada rayo a una fila aleatoria única de estos
dispersores precalculados fue raro; no se puede simplemente unir a RANDOM() porque
cada rayo se uniría al mismo dispersor aleatorio. Tampoco se puede seleccionar
con un cálculo típico sobre una normal porque eso lleva a franjas
en la imagen. Entonces, en cambio, saco unos pocos decimales posteriores de una
dimensión de una normal, y luego uno con eso. Es "aleatorio" pero también
lo suficientemente único por rayo.

### CTEs Recursivos

El trazado de rayos sigue muy naturalmente cómo funcionan los CTEs recursivos. Una de las
cosas que encontré fue una forma limpia de identificar cuál rayo es el que se debe
contabilizar. Usar una función ventana ordenando por intersección (t) funcionó
bien. En cada iteración, esta consulta intersecta un rayo con *todo*
lo que está delante de él y hace todos los cálculos asociados, pero luego en
la cláusula WHERE rechaza todo excepto la cosa que el rayo
realmente golpeó.

Además, hay algo realmente hermoso en la simplicidad del
núcleo del resumen final [editado para claridad]:
```sql
```
 SELECT img_x, img_y,
         SUM(POW(color_mult * ray_col_r/muestras_por_px, gamma)) col_r,
         SUM(POW(color_mult * ray_col_g/muestras_por_px, gamma)) col_g,
         SUM(POW(color_mult * ray_col_b/muestras_por_px, gamma)) col_b
    FROM rays
    GROUP BY img_y, img_x
```

### Escenas, materiales, etc.

Como esto está en SQL, puedo almacenar múltiples escenas en la base de datos. La que
realmente se renderiza se selecciona en la tabla "camera".

## Parados sobre los hombros de gigantes

Dos años antes de que escribiera esto, "El trazador de rayos MySQL más avanzado
del mercado en este momento" circuló en las redes sociales:
https://www.pouet.net/prod.php?which=83222

Tenía algunas cosas en mente que quería hacer de manera diferente [¿peor?]:

* Demoscene es una forma de arte. No estoy haciendo golf, esto no está minimizado
* Ni una sola consulta; eso se puede hacer con CTEs, pero eeeeeeh
* Animación como objetivo final [ver ```anim.sh```]
* Principalmente, solo estoy jugando con la herramienta equivocada para el trabajo

### Le pedí a Claude una opinión

*"¿Por qué alguien escribiría algo así en primer lugar?"*

> Este es un ejemplo fascinante de SQL como lenguaje de programación de propósito general llevado al extremo. Alguien escribió un trazador de rayos completo en PostgreSQL SQL, lo cual es impresionante y... cuestionable.
> 
> [...]
> 
> Esto parece ser un proyecto de tesis de un brillante estudiante de informática, el experimento de fin de semana de un ingeniero senior, o alguien atrapado en un entorno muy restrictivo solo de base de datos que se negó a renunciar a sus sueños de trazado de rayos.
> 
> Es el equivalente en programación a construir un coche de carreras con Lego: técnicamente impresionante, pero probablemente no deberías conducirlo en serio.

No sé si sentirme halagado o insultado.

## Referencias

La mayor parte de esto está construido siguiendo la serie "Ray Tracing in One Weekend":
https://raytracing.github.io/, y luego haciendo ajustes para la manera deliberadamente obtusa en que lo estoy codificando.


Gary <chunky@icculus.org>

```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-25

---