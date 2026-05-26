# MaichartConverter

## Un programa sencillo que proporciona la funcionalidad de convertir charts de maimai entre Simai y Ma2.

> Las clases de soporte originales ahora están separadas de este repositorio. Por favor,
> consulte [MaiLib](https://github.com/Neskol/MaiLib) para más información.

### Construcción

    git clone
    git submodule update --init --recursive
    dotnet build

### Uso y Comandos Disponibles

> Escriba 'MaichartConverter help' para el manual detallado de cada comando.

- `CompileDatabase`([Inglés](https://raw.githubusercontent.com/Neskol/MaichartConverter/master/./Manuals/ENG/CompileDatabase.md)/[中文](https://raw.githubusercontent.com/Neskol/MaichartConverter/master/./Manuals/CHN/CompileDatabase_CN.md)): Compone
  toda la base de datos ma2 a simai
- `CompileMa2`([Inglés](https://raw.githubusercontent.com/Neskol/MaichartConverter/master/./Manuals/ENG/CompileMa2.md)/[中文](https://raw.githubusercontent.com/Neskol/MaichartConverter/master/./Manuals/CHN/CompileMa2_CN.md)): Compila el chart Ma2 asignado
  al formato asignado
- `CompileMa2ID`([Inglés](https://raw.githubusercontent.com/Neskol/MaichartConverter/master/./Manuals/ENG/CompileMa2ID.md)/[中文](https://raw.githubusercontent.com/Neskol/MaichartConverter/master/./Manuals/CHN/CompileMa2ID_CN.md)): Compila el
  chart Ma2 asignado indexado por ID al formato asignado
- `CompileSimai`([Inglés](https://raw.githubusercontent.com/Neskol/MaichartConverter/master/./Manuals/ENG/CompileSimai.md)/[中文](https://raw.githubusercontent.com/Neskol/MaichartConverter/master/./Manuals/CHN/CompileSimai_CN.md)): Compila el chart
  simai asignado al formato asignado
-
`ReverseMa2FromSimaiDatabase`([Inglés](https://raw.githubusercontent.com/Neskol/MaichartConverter/master/./Manuals/ENG/ReverseMa2FromSimaiDatabase.md)/[中文](https://raw.githubusercontent.com/Neskol/MaichartConverter/master/./Manuals/CHN/ReverseMa2FromSimaiDatabase_CN.md)):
Invierte la base de datos Simai desde la carpeta dada a la carpeta MaiAnalysis para compilación

### Aviso de Parámetros

- Los archivos de música deben nombrarse musicxxxxxx.mp3 donde xxxxxx coincide con el ID de música especificado en music.xml en cada carpeta a000,
  y se rellenan con ceros al frente hasta 6 dígitos
- Los archivos bga deben nombrarse xxxxxx.mp4 que coincide con el ID de música especificado en music.xml en cada carpeta a000, y
  se rellenan con ceros al frente hasta 6 dígitos
- La carpeta de imágenes debe estar estructurada en image/Texture2D/ y los archivos deben comenzar con UI_Jacket_xxxxxx.jpg donde
  xxxxxx coincide con el ID de música especificado en music.xml en cada carpeta a000, y se rellenan con ceros al frente hasta 6 dígitos
- Todas las reglas especificadas arriba son para su conveniencia para usar directamente después de obtener datos por medios considerables
- El parámetro de dificultad está listado de 0 a 4 como Básico a Re:Master. En MaiLib especifiqué reglas para Fácil y Utage, pero está

  me toma tiempo entenderlo, o podrías implementarlo por tu cuenta consultando el código de MaiLib
- Todas las rutas deben terminar con un separador de ruta como "/" o "\". No puedes incluir comillas en la ruta.
- Si tienes dificultades usando los comandos, por favor consulta launch.json de VSCode donde incluí varios ejemplos
- Todo el programa fue planeado inicialmente para convertir de ma2 a simai y todas las demás funciones se desarrollaron después,
  por lo que hay una ENORME cantidad de compromisos en el diseño del código que lo hacen difícil de leer (pero funciona hasta ahora). Sería
  muy amable de tu parte si quisieras ayudarme a corregir eso

### Descargo de responsabilidad

- Los derechos de autor de las obras pertenecen a cada titular de derechos individual. Esta herramienta se usa puramente con fines no comerciales y de estudio.
  Debes encontrar tu propio camino para cualquier recurso que pueda ser usado y usarlo adecuadamente bajo tu propio riesgo.
- Si deseas usar el parser en tu proyecto, por favor consulta [MaiLib](https://github.com/Neskol/MaiLib) y
  ¡esperamos que te sea útil!


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-26

---