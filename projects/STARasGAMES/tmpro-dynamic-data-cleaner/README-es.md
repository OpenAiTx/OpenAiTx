## Acerca de
Los activos de fuente dinámica de TextMeshPro tienen un hábito muy molesto de guardar sus datos binarios generados dinámicamente en el
mismo archivo de texto que sus datos de configuración. Esto causa grandes dolores de cabeza para el control de versiones.

El script de este paquete aborda el problema mencionado. Se ejecuta cada vez que cualquier activo en el proyecto está a punto de guardarse. Si alguno de
esos activos es un activo de fuente dinámica TMP, sus datos generados dinámicamente serán borrados antes de
guardarse, lo que evita que esos datos contaminen el control de versiones.

Créditos a @cxode, quien ideó esta brillante solución:<br>
`https://forum.unity.com/threads/tmpro-dynamic-font-asset-constantly-changes-in-source-control.1227831/#post-8934711`

Mi contribución es convertir el script en un paquete compatible con upm que pueda ser instalado fácilmente.<br>
Se realizaron algunas mejoras de rendimiento y verificaciones adicionales para casos límite.<br>
Además, creé una prueba para verificar rápidamente si el script funciona correctamente en tu proyecto/version de Unity.<br>

## Instalación
Instalar vía URL git:
`https://github.com/STARasGAMES/tmpro-dynamic-data-cleaner.git#upm`

O añadiendo una nueva entrada en tu **`manifest.json`**.
```json
{
  "dependencies": {
    "com.starasgames.tmpro-dynamic-data-cleaner": "https://github.com/STARasGAMES/tmpro-dynamic-data-cleaner.git#upm",
    ...
  },
  "testables" : ["com.starasgames.tmpro-dynamic-data-cleaner"]
}
```
Para que la prueba de integración sea visible en la ventana TestRunner, es necesario agregar el atributo `"testables"`, pero esto es opcional.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---