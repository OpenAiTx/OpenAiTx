[\[EN-ReadMe\]](https://github.com/Sugobet/API_Sword/blob/main/%5BEN%5D-README.md) <------ por favor lea esto
# WeChat Public Account: APT250

## Siguiendo el principio de código abierto y aprendizaje colaborativo, API Sword se abrirá al público y se publicará en la tienda oficial de plugins de Burp BApp Store dentro de dos semanas (después del 7 de septiembre), para facilitar futuras actualizaciones y uso. Actualmente está en revisión de código oficial, creemos que pronto estará disponible en BApp Store.

# [Nuevo plugin clásico para burp] API Sword - Recolección profunda automática de APIs en diversas respuestas

El paquete jar está en release, y después de publicarse en la tienda oficial de plugins de burp también podrá descargarse desde la tienda.

## Prefacio

Este plugin combina mi trabajo reciente y parte de mi experiencia previa con el premio de 40,000 dólares por vulnerabilidades en cuentas de Microsoft API.

Los desarrolladores de API Sword han logrado resultados y 0days genéricos en proyectos usando API Sword. Con esta herramienta, ya no necesito buscar manualmente interfaces, rutas o parámetros en ningún js de forma dolorosa.

![Inserte aquí la descripción de la imagen](https://i-blog.csdnimg.cn/direct/388ed286aff845ce8863640b37d4636e.png)

Similar a muchas herramientas populares como JS Finder, URLFinder y otras para extracción de js y api, que son excelentes herramientas, **API Sword se beneficia y destaca gracias a las características de burp.**

Captura de pantalla de la página principal del plugin:

<img width="3020" height="1582" alt="image" src="https://github.com/user-attachments/assets/e1677009-917b-4e90-a5e8-ccd067263d6e" />

## Funciones principales de API Sword

API Sword previene bucles, extrae automáticamente APIs y archivos js dentro del rango especificado desde diversas respuestas, luego extrae recursivamente APIs en profundidad, solicitando activamente APIs, js y otros archivos valiosos.

Los resultados de las APIs son WYSIWYG, la ventana derecha muestra el js fuente de la API, donde se pueden obtener al instante los parámetros de la API, luego burp permite probar rápidamente con ctrl + r.

No es tan complejo como parece, API Sword principalmente **reduce mucho el trabajo repetitivo, tedioso y que consume tiempo de búsqueda de js, api y parámetros de api.**

1. API Sword captura el tráfico dentro del rango de burp y extrae la mayoría de los enlaces de las respuestas http.
2. API Sword limpia cualquier enlace o ruta extraída en el paso anterior, y con su juicio propio realiza solicitudes GET o POST activas a APIs, JS, etc.
3. API Sword procesa las respuestas de estas solicitudes activas, extrae más información y repite el paso anterior. **API Sword tiene prevención de bucles para evitar solicitudes en ciclo infinito.**
4. API Sword envía todas las solicitudes y respuestas API que cumplen condiciones, así como las respuestas de los archivos js fuente, al GUI de burp de API Sword.
5. API Sword añade automáticamente todas las solicitudes relacionadas al sitemap de burp target, **donde podrá disfrutar plenamente de los frutos que API Sword ofrece en funciones como análisis del sitemap.**

El usuario solo debe habilitar API Sword y definir un "rango razonable", luego seguir navegando y usando las funciones del sistema web en el navegador para que todo el tráfico pase por burp y sea analizado por API Sword, que le devolverá los frutos demoníacos que desea.

**Por motivos de opsec y seguridad, actualmente API Sword no realiza fuzzing activo de parámetros; si se requiere, se añadirá como función opcional en el futuro.**

## ¿Cómo usar?

`Nota: el plugin debe ejecutarse en Burp Suite versión 2024.7 o superior; (para versiones inferiores a 2024.7, es necesario desactivar manualmente la función "usar headers originales" en la página de configuración del plugin)`

El uso de API Sword es muy sencillo,

1. Instale el plugin en versiones de Burp posteriores a 2024, asegurándose de que no haya errores en el plugin
2. Configure el Scope para el plugin
3. Abra el navegador y asegúrese de que el tráfico pase a través de Burp
4. Ingrese al sitio objetivo, haga clic y pruebe todo lo que vea en el sitio
5. Después de un tiempo, revise los resultados desde el Sitemap de API Sword

## Configuración de API Sword

En la pestaña Scope, podemos configurar el alcance, que puede ser URL, dominio o IP

<img width="1946" height="1068" alt="image" src="https://github.com/user-attachments/assets/945d1e66-9d1a-4c59-920c-3fadacbeeb4f" />

Este alcance es especialmente importante, se recomienda considerarlo con cuidado, de lo contrario podría terminar escaneando el espacio exterior.

Después de configurar el alcance, veamos la pestaña Setting

<img width="3018" height="1338" alt="image" src="https://github.com/user-attachments/assets/4e67c07f-0e37-470c-881e-fa234632d30b" />

1. Permitir solicitudes activas a la API

Esta opción está activada por defecto, no se recomienda desactivarla, de lo contrario API Sword no podrá extraer datos en profundidad

2. Usar headers originales

Activado por defecto, si desea probar específicamente APIs no autorizadas, puede desactivar esta opción; al desactivarla no se enviarán cookies ni información de sesión

3. Detener inmediatamente el envío de todas las solicitudes

Desactivado por defecto, sirve para pausar en caso de emergencia, se recomienda usar junto con la primera opción

4. Borrar todos los datos actuales del SiteMap

Este botón se utiliza para eliminar todos los datos de sitios en el Site Map de API Sword

![在这里插入图片描述](https://i-blog.csdnimg.cn/direct/d7e8eca0e2994a65b9bae2abb8554e69.png)

5. Habilitar la tasa de solicitud HTTP activa

Limitar el intervalo de tiempo entre cada solicitud

6. ¿Agregar rutas personalizadas adicionales en solicitudes activas?

Al activar esta opción, API Jian añadirá la ruta personalizada especificada antes de concatenar con la URL principal

7. Filtrar códigos de respuesta personalizados distintos de 200

8. Permitir que API Jian busque activamente la baseURL en la respuesta y realice la concatenación de rutas en baseURL

9. Añadir campos de encabezado personalizados: (sobrescribe automáticamente los campos de encabezado existentes)

10. Habilitar eludir acceso a interfaces peligrosas (se omite si la interfaz contiene ciertas cadenas)

11. Guardar alcance y todas las configuraciones

12. ¿Agregar rutas personalizadas adicionales después de la interfaz API y antes de los parámetros?

13. Control de cantidad de hilos

Otras configuraciones están en desarrollo y mejora, si tiene alguna idea, sugerencia o problema, puede reportarlo mediante un issue en GitHub

## Agradecimientos

Gracias a `Microsoft`

Gracias a mi `mentor de NSFOCUS`

Gracias a `mil1ln`

Gracias a `探姬`

Gracias a todos los que han brindado valiosas opiniones y comentarios durante la fase de prueba de API Jian

¡Gracias a todos los anteriores por todo el apoyo brindado a API Jian!
## TODO

1. Recoger una camiseta polo de Meihua K ⬛️  
2. Añadir ruta base url opcional para fuzz ✅  
3. Añadir filtrado personalizado de códigos de respuesta ✅  
4. Añadir opción de ruta base personalizada al hacer solicitudes activas con API Sword ✅  
5. Optimizar la estrategia de coincidencia, desbloqueando el rendimiento del API Sword en un 80% ✅  
6. Optimización de solicitudes activas de API Sword para evitar acceder a APIs peligrosas ✅  
7. Solucionar el problema de que el header por defecto de Burp no incluya el campo CT ✅  
8. Optimizar el ancho de las etiquetas en la tabla de respuestas ✅  
9. Corregir el parpadeo de la UI del sitemap ✅  
10. Añadir función opcional de cabeceras de solicitud personalizadas ✅  
11. Añadir ordenación automática de etiquetas en la lista de respuestas ✅  
12. Optimizar la estrategia de coincidencia ✅  
13. Optimizar bloques de código ⬛️  
14. Registrar el manejo al desinstalar Burp ✅  
15. Añadir comentarios de código bilingües chino-inglés en todo el código ⬛️  
16. Añadir función de cambio bilingüe chino-inglés en la GUI ✅  
17. Optimizar problemas de bloqueo y renderizado en Burp causados por la UI ✅  
18. Añadir función para guardar el alcance y configuración ✅  
19. Añadir función de velocidad para solicitudes HTTP activas ✅  
20. Añadir función de multihilo ✅  
21. Añadir función de ruta personalizada después de la interfaz y antes de los parámetros ✅  
22. Reparación urgente del fallo en la lógica anti-bucle causado por multihilo ✅  
23. Corregir error de visualización en ordenación automática ✅  
24. Optimizar la UI de la lista de APIs, al insertar datos, las teclas de dirección ya no interrumpen la acción ✅  
25. Reparar completamente el bug que causaba fallo en la lógica anti-bucle debido a multihilo ✅  
26. Añadir filtros ✅  
27. Añadir funciones para expandir nodos y contraer todos los nodos ✅  
28. Optimizar función para limpiar el sitemap ✅  
29. Optimizar lógica de concatenación de JS en CDN/cross-site para usar referer como baseUrl ✅  
30. Añadir función de escaneo manual; el escaneo manual añadirá automáticamente el host al alcance: clic derecho en el cuerpo de una solicitud en Burp -> Extensión -> API Sword -> API Scan ✅



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-03

---