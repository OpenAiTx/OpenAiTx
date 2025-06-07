# Tema GNOME para Discord

Un tema de GNOME para Discord, siguiendo el estilo Adwaita y las Guías de Interfaz Humana de GNOME (dentro de lo que el CSS de Discord me permite).

## Requisitos

1. Vesktop

   Para habilitar la barra de título de Windows.

2. Configuración > Idioma > Elegir "English (US)"

   Esto permite el uso de iconos personalizados debido a cómo se identifican en Discord. Puedes [localizar](https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/src/global/icons.scss) el tema, pero lee la nota sobre localización.

3. Configuración > Plugins > Habilitar "ThemeAttributes"

   Esto permite iconos en el cuadro de diálogo de configuración.

4. Configuración > Configuración de Vesktop > Habilitar "Discord Titlebar"

   Opcional, pero recomendado si tienes barras de título.

### Adiciones opcionales

1. Eliminar referencias a Nitro: https://github.com/CroissantDuNord/discord-adblock

## Filosofía del tema

### Guías de Interfaz Humana

El tema puede que no cumpla totalmente con las HIG debido a limitaciones de CSS o diseño de Discord, o por mis propias decisiones.

### Soporte

No se soportan:

- Experimentos de Discord

  No trabajo para Discord, por lo que no tengo forma de saber si estos experimentos están siendo cambiados, desaprobados, etc., es decir, carga de mantenimiento — mantengo varios otros proyectos.

- Nitro

  Excepciones — cualquier cosa accesible con el plugin FakeNitro.

Puedes abrir una incidencia sobre cualquiera de estos puntos, pero solo se corregirá si es una solución sencilla, es decir, un icono faltante.

## Instalación

### Sin configuración

Copia lo siguiente en la caja de texto ubicada en Configuración > Temas > Temas en línea:

```
https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/gnome.theme.css
```

### Incluyendo configuración

Coloca [gnome.theme.css](https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/gnome.theme.css) en ~/.config/vesktop/themes. Se sigue actualizando automáticamente.

## Vista previa

![first](https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/assets/preview/Screenshot%20from%202024-04-27%2011-55-58.png)
![cozy second](https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/assets/preview/Screenshot%20from%202024-04-27%2012-31-42.png)
![third](https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/assets/preview/Screenshot%20from%202024-04-27%2012-24-16.png)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---