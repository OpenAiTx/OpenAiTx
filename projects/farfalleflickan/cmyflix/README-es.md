# cmyflix
*¡Un clon de Netflix, ahora en C!*

cmyflix es también una reescritura completa de mi original ![Myflix](https://github.com/farfalleflickan/Myflix/) usando C, por lo que es aproximadamente 30x **más rápido** que el original manteniendo casi toda la funcionalidad.

cmyflix intenta ser un "Netflix DIY" algo simple y ligero, similar a Plex, streama o Emby, para tu NAS, especialmente dirigido al ecosistema Raspberry Pi/Odroid/etc. No está **pensado** ni **diseñado** para ser sofisticado (si tienes el hardware y quieres mucha funcionalidad, opta por otras soluciones :) ), sino lo mínimo indispensable para ser algo bonito, rápido y usable. El programa crea bases de datos json que almacenan la ubicación de los archivos y metadatos, estas bases de datos se usan luego para crear páginas web estáticas que pueden ser servidas desde cualquier servidor web!    

Grandes agradecimientos a las siguientes librerías: ![cwalk](https://github.com/likle/cwalk), ![cjson](https://github.com/DaveGamble/cJSON).   
Si deseas proteger con contraseña tus archivos de cmyflix, quizás quieras mirar ![esto](https://github.com/farfalleflickan/JSONlogin)!  

¿Te gusta mi trabajo? No dudes en donar :)  
[<img src="https://raw.githubusercontent.com/andreostrovsky/donate-with-paypal/master/dark.svg" alt="donation" width="150"/>](https://www.paypal.com/donate?hosted_button_id=YEAQ4WGKJKYQQ)

# Capturas de pantalla:  
Página de series de TV
![TV shows](https://github.com/farfalleflickan/Myflix/blob/master/screenshots/ec53e53f252f908bc8bac7f8c4486790.jpg)   

Modal de temporada/episodio de serie de TV
![TV show episodes](https://github.com/farfalleflickan/Myflix/blob/master/screenshots/fb31129a22d81b732ce88f02cae27fea.jpg)  


Reproductor de episodio de serie de TV
![TV show episode player](https://github.com/farfalleflickan/Myflix/blob/master/screenshots/102b3df4924efeae7476d6ceee79bec9.png)

Página de películas
![Movies](https://github.com/farfalleflickan/Myflix/blob/master/screenshots/d4271907a9af78d8dd84f3941ca1e56a.jpg)  

Reproductor de películas
![Movies player](https://github.com/farfalleflickan/Myflix/blob/master/screenshots/2eb41c935d1c11e19adb66466bcdf97e.png)

# Cómo compilar:
Simplemente compila ejecutando make, las librerías requeridas son (en Ubuntu) `libbsd-dev libcjson-dev libcurl4-openssl-dev`.

# Cómo instalar:
Puedes instalar desde el código fuente con make install O usar un paquete precompilado desde la pestaña de releases.

Atención, el archivo `deb` precompilado está construido usando el backend por defecto `libcurl4-openssl-dev`.

# Requisitos para ejecutar:
cmyflix usa libcjson(>=1.7.15), libcurl(>=7.68), imagemagick, ffmpeg y una clave api de TMDB. También ten en cuenta que cmyflix busca archivos `mp4`,`mkv`,`ogv` y `webm` debido al uso de HTML5 y sus formatos soportados.

# Configuración y uso:
Para comenzar, cmyflix busca `cmyflix.cfg` primero en la misma carpeta que el binario, luego en `$HOME/.config/cmyflix/` y finalmente en `/etc/cmyflix/`. Lo mismo aplica para la carpeta `html` y su contenido.

Para más opciones e información, consulte el archivo de configuración o vea el menú de ayuda, que se puede invocar pasando `--help`.

# Expectativas de la estructura de carpetas
cmyflix es un poco exigente en el sentido de que espera que todo esté en carpetas organizadas. 
Para programas de TV espera que cada programa esté en su propia carpeta, con una subcarpeta para cada temporada (más una "Season.Extras" para cualquier otra cosa). Ejemplo: `/ruta/a/archivos/Nombre.del.Programa/Season.1/Nombre.Del.Programa.S01E01.mp4`.
Para películas, idealmente deberían estar en una subcarpeta para cada película, ejemplo: `/ruta/a/archivos/Nombre.de.Pelicula/Nombre.De.Pelicula.mp4`. Tenga en cuenta que técnicamente múltiples películas pueden estar en la misma subcarpeta, como en `/ruta/a/archivos/Peliculas/Star.Wars/La.Venganza.de.Los.Sith.mp4` y `/ruta/a/archivos/Peliculas/Star.Wars/El.Imperio.Contraataca.mp4`.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-27

---