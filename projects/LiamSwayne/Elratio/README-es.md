# EʅɾαՇισ
<a href="https://liamswayne.github.io/elratio/security.mp4">
    <img src="https://img.shields.io/badge/Visitor_IP_address-66.122.23.197-blue" height="25">
</a>

# ~~Actualización final.~~ [Actualización final inversa.](https://github.com/LiamSwayne/Elratio/blob/main/announcements.md)

Un lenguaje de programación basado en Python que combina el rendimiento de Ruby con la legibilidad de Perl.

> "La solución para Assembly"

Para escribir tu propio programa Elratio, descarga [template.py](https://raw.githubusercontent.com/LiamSwayne/Elratio/main/template.py) y escribe tu programa en el espacio indicado.

# Características
¡Elratio ofrece numerosas ventajas sobre cualquier otro lenguaje!

## Espacios en blanco audaces y nuevos
Ningún lenguaje moderno indica que una línea vacía está vacía. Elratio lleva los espacios en blanco en una dirección audaz y nueva con la palabra clave `empty`.
###### Python/Java/R/C/Go/JavaScript:
<pre>

</pre>
###### Elratio:
```python
empty;
```
Elratio no permite líneas en blanco. Cada línea vacía debe contener la palabra clave `empty`.

## Finalización clara de líneas y programas
Muchos lenguajes de programación modernos se han vuelto progresistas y han popularizado una sintaxis poco inspirada para los finales de línea. Elratio, por otro lado, utiliza el símbolo claramente definido `;` para definir los finales de línea (excepto las líneas que terminan con `:`).

###### Python:
<pre>
if True:
    pass
</pre>

###### Elratio:
```python
    if True:
pass;
```

Además, todo programa debe terminar con la palabra clave `end`. Una vez más, Elratio aplasta a la competencia.
###### Python/R/JavaScript:
<pre>

</pre>
###### Elratio:
```python
end;
```

## Sangría invertida
Las líneas ejecutadas en main necesitaban ser rebajadas, por lo que introdujimos un sistema de sangría invertida.

```python
        while True:
    if True:
1000;
```
Nunca más tendrás que preocuparte por indentar una línea sin cuestionar las increíbles líneas que la rodean.

## El poder de la creación misma
Elratio te permite jugar a ser dios con la palabra clave `create`. Desbloquea posibilidades numéricas ilimitadas creando números.
<pre>
SystemOutPrint(7);
>>> Error en la línea 1: SystemOutPrint(7);
>>> ¿Es esto una broma? El dígito "7" aún no ha sido creado. Usa "create 7" primero.
</pre>

```python
create 7;
SystemOutPrint(7);
>>> 7
```
Pero antes de crear números, debes crear `create`.

```python
create create;
```

Muchos idiomas carecen de un indicador claro de creación de clases, pero una vez más es solo jonrón tras jonrón para Elratio.
```python
    create class book:
pass;
```

## Comentarios innovadores
El símbolo `#` se ha utilizado durante mucho tiempo para indicar que ciertas líneas son comentarios y no deben ejecutarse. Al diseñar Elratio, reconstruimos los comentarios desde cero y creamos la palabra clave `comment`.
```python
comment rewrite this segment;
```
Es tan simple como `comment`, barra espaciadora, tu comentario y un punto y coma.

## Redefiniendo `def`
Aunque `def` puede ser conveniente en el momento, puede conducir a código espagueti, por lo que lo hemos reemplazado con `definition`.
```python
    definition doNothing:
pass;
```

## Sintaxis de impresión mejorada
Python usa la sintaxis poco clara `print()` para imprimir. Elratio usa `systemOutPrint()` para mayor claridad.
<pre>
print(10);
>>> Soy un compilador de principios. No acepto print(). Usa systemOutPrint() en su lugar.
</pre>
```python
systemOutPrint(10);
>>> 10
```
Puedes agradecer a Java por inspirar este cambio.

## Retroalimentación personalizada del compilador
Elratio utiliza tecnología de cadenas de próxima generación para proporcionar al usuario mensajes de error únicos y descriptivos.
<pre>
>>> Programa vacío. ¡No me envíes esa basura la próxima vez, imbécil!
</pre>
<pre>
>>> Error en la línea 31: vacío
>>> Las sentencias que no terminan con dos puntos deben terminar con ASCII (2^6)-5.
</pre>
<pre>
>>> Error grave en la línea 42: print(44);
>>> ¿Eres estúpido? El dígito "4" aún no ha sido creado. Usa "create 4" primero.
</pre>

# Ejemplos
Puedes encontrar programas de ejemplo en la carpeta [examples](examples). Aquí hay un ejemplo de un programa que imprime la hora escrito en Elratio:
```python
        comment imports;
        import time;
        comment create number;
        create create;
        create 1;
        empty;
        definition print_formatted_time(current_time, format_string):
    formatted_time = time.strftime(format_string, current_time);
    systemOutPrint("Formatted time:", formatted_time);
    empty;
        definition main():
    systemOutPrint("Welcome to the Simple Time Printer!");
    systemOutPrint("Select an option:");
    create 2;
    systemOutPrint("1. Print current time in default format");
    systemOutPrint("2. Print current time in custom format");
    choice = input("Enter your choice: ");
    empty;
    comment get the current time;
    current_time = time.localtime();
    empty;
    if choice == 1:
comment print the time with formatting;
print_formatted_time(current_time, "%Y-%m-%d %H:%M:%S");
    elif choice == 2:
custom_format = input("Enter your custom format (e.g., %Y/%m/%d %I:%M %p): ");
print_formatted_time(current_time, custom_format);
    else:
systemOutPrint("Invalid choice.");
    empty;
        if __name__ == "__main__":
    main();
        end;
>>> Welcome to the Simple Time Printer!
>>> Select an option:
>>> 1. Print current time in default format
>>> 2. Print current time in custom format
>>> Enter your choice: 1
>>> ('Formatted time:', '2023-08-26 00:34:10')
```
Como recordatorio, puedes comenzar a programar en Elratio **ahora mismo** descargando [template.py](https://raw.githubusercontent.com/LiamSwayne/Elratio/main/template.py) y escribiendo tu programa!


# Soporte de paquetes
¡Elratio soporta todos los paquetes de Python existentes! No es necesario modificar los paquetes para importarlos en Elratio.

# Patrocinadores ❤️
<a href="https://liamswayne.github.io/elratio/antarctica_public_school.jpeg"><img src="/sponsors/antarctica_public_schools.jpg" height="150"></a> <a href="https://liamswayne.github.io/elratio/enron_guy.png"><img src="/sponsors/enron.png" height="150"></a> <a href="https://liamswayne.github.io/elratio/sbf_link.png"><img src="/sponsors/sam_bankman_reeee.png" height="150"></a>

# Licencia
Elratio está bajo la licencia GPL 3.0, lo que significa que todo programa Elratio debe ser de código abierto. Tener un programa Elratio en tu computadora sin un espejo disponible libremente en línea es una violación de esta licencia. No nos hagas recurrir a la violencia.

<!--
¿Sigues aquí? Se acabó. Vete a casa.
-->


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-29

---