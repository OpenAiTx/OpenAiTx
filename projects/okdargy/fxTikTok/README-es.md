# fxTikTok

Incrusta videos y presentaciones de TikTok en Discord con solo `s/i/n`

> [!NOTA]  
> ¿Tienes una función que quieres ver en fxTikTok o quieres reportar un error? ¡Crea un issue! Me encantaría recibir tus comentarios.

## 📸 Capturas de pantalla

<details>
  <summary>Haz clic aquí para ver cómo se ve fxTikTok en acción</summary>

| <img src="/.github/readme/compare.png" alt="Vista previa de video" height="400px" /> |
| :--------------------------------------------------------------------------------: |
|          Comparando incrustaciones de `tiktok.com` vs. `tnktok.com` en Discord          |

| <img src="/.github/readme/slideshow.png" alt="Vista previa de presentación" /> |
| :-----------------------------------------------------------------------------: |
|                          Incrustaciones de presentaciones                           |

| <img src="/.github/readme/direct.png" alt="Vista previa directa" height="400px" /> |
| :--------------------------------------------------------------------------------: |
|                          Soporte directo para imagen/video                          |

</details>

## 📖 Uso

Usar fxTikTok es fácil en Discord. Arregla incrustaciones feas y no responsivas enviando tu enlace de TikTok y luego escribiendo `s/i/n`

<details>
  <summary>👁️ ¿Aprendes mejor visualmente? Haz clic aquí para ver un tutorial en GIF</summary>

  <img src="https://raw.githubusercontent.com/okdargy/fxTikTok/hono-rewrite/.github/readme/introduction.gif" alt="GIF de introducción" height="500px" style="border-radius:2%" />
</details>

### ¿Cómo funciona esto?

Cuando envías `s/i/n` en Discord, modifica tu mensaje más reciente usando el formato de [sed](https://www.gnu.org/software/sed/manual/sed.html). Específicamente, reemplaza la primera aparición del segundo parámetro (`i`) en el mensaje por el tercer parámetro (`n`).

|     Antes     |     Después      |
| :------------: | :------------: |
| t**i**ktok.com | t**n**ktok.com |

> [!TIP]
> Si administras un servidor de Discord, te recomiendo mucho agregar [FixTweetBot](https://github.com/Kyrela/FixTweetBot) a tu servidor. Modifica automáticamente los enlaces para usar corregidores de incrustaciones como fxTikTok, y es altamente personalizable.

### Usando Incrustaciones Directas

¿No quieres todo ese desorden de estadísticas en tu incrustación y solo quieres el video o imagen? Simplemente cambia tu URL a `d.tnktok.com`

|         Antes         |        Después         |
| :--------------------: | :------------------: |
| **www**.t**i**ktok.com | **d**.t**n**ktok.com |

> Alternativamente, también puedes establecer `isDirect` a true a través de la consulta URL añadiendo `?isDirect=true` al final de tu URL

### "¡No veo el pie de foto del video!"

Por defecto, ponemos la descripción en la etiqueta `og:description`, pero Discord la elimina de la incrustación si hay un video dentro de la misma. Decidimos no agregarla en la parte superior como hace [tfxktok.com](https://tfxktok.com) para evitar que la incrustación se llene demasiado con hashtags.

Sin embargo, queremos dar a los usuarios la opción de agregarla en caso de que aporte contexto adicional al video. Puedes cambiar tu URL a `a.tnktok.com` para añadir la descripción en la parte superior.

|         Antes         |        Después         |
| :--------------------: | :------------------: |
| **www**.t**i**ktok.com | **a**.t**n**ktok.com |

> Alternativamente, también puedes establecer `addDesc` a true a través de la consulta URL añadiendo `?addDesc=true` al final de tu URL

### Cambiando a Alta Calidad

TikTok soporta H.265/HEVC (Codificación de Video de Alta Eficiencia) que ofrece una calidad significativamente mejor al mismo tamaño de archivo comparado con H.264, a costa de compatibilidad. Por defecto, usamos calidad H.264 ya que [muchos usuarios reportan problemas con incrustaciones que se rompen con H.265](https://github.com/okdargy/fxTikTok/issues/14), pero se soporta habilitar H.265.

Para habilitar la reproducción en alta calidad H.265, añade `?hq=true` o usa `hq.tnktok.com`:
| Antes | Después |
| :--------------------: | :------------------: |
| **www**.t**i**ktok.com | **hq**.t**n**ktok.com |

### Combinando Modos

Puedes combinar diferentes modos usando nombres de host específicos o parámetros de consulta en la URL. Por ejemplo, si quieres activar H.265 y también ver los subtítulos, puedes usar `hq.a.tnktok.com` o agregar `?hq=true&addDesc=true` a la URL.

> No puedes usar el Modo Directo y el Modo de Subtítulos simultáneamente ya que se contradicen entre sí.

### ¿Por qué usar tnktok.com?

Cumplimos con todos los requisitos para ser uno de los mejores servicios de inserción de TikTok con muchas características que otros no tienen. Aquí hay una tabla comparando nuestro servicio, tnktok.com, con otros servicios de inserción de TikTok así como con las inserciones predeterminadas de TikTok.

|                                        | [fxTikTok](https://www.tnktok.com) | TikTok Predeterminado | [kkScript](https://kktiktok.com/) | [tfxktok.com](https://tfxktok.com) | [EmbedEZ](https://tiktokez.com) |
| -------------------------------------- | ---------------------------------- | --------------------- | --------------------------------- | ---------------------------------- | ------------------------------- |
| Insertar videos reproducibles          | ☑️                                 | ☑️                    | ☑️                                | ☑️                                 | ☑️                              |
| Insertar presentaciones de varias imágenes | ☑️                                 | ❌                    | ❌                                | ☑️                                 | ☑️                              |
| Código abierto                         | ☑️                                 | ❌                    | ❔                                | ❌                                 | ❌                              |
| Soporta inserciones directas           | ☑️                                 | ❌                    | ❔                                | ❌                                 | ❌                              |
| Muestra likes, compartidos, comentarios | ☑️                                 | ☑️                    | ❌                                | ☑️                                 | ☑️                              |
| Elimina seguimiento en redirecciones   | ☑️                                 | ❌                    | ❌                                | ☑️                                 | ☑️                              |
| Soporte para URLs cortas multi-continente | ☑️                                 | ☑️                    | ❌                                | ❌                                 | ☑️                              |
| Soporte para h265/alta calidad          | ☑️                                 | ❌                    | ❌                                | ❌                                 | ❌                              |
| Último commit                         | [![][tnk]][tnkc]                   | N/A                   | [![][kkt]][kktc]                  | N/A                                | N/A                             |

[tnk]: https://img.shields.io/github/last-commit/okdargy/fxTikTok?label
[tnkc]: https://github.com/okdargy/fxTikTok/commits
[kkt]: https://img.shields.io/github/last-commit/kkscript/kk?label
[kktc]: https://github.com/kkscript/kk/commits

Los siguientes servicios de inserción no están listados debido a que no están mantenidos o simplemente no funcionan:

- [tiktxk.com](https://tiktxk.com)
- [vxtiktok.com](https://vxtiktok.com) (redirigiendo a kkScript)

## 💻 Autoalojamiento

Por defecto, al configurar una nueva instancia de fxTikTok, el servidor de descarga predeterminado es `offload.tnktok.com`.
Para configurar el tuyo propio, solo compila y ejecuta [`offload.ts`](/src/offload.ts) que iniciará en el puerto **8787**.

```bash
# Install all necessary dependencies
pnpm install
# Start your server
bun run src/offload.ts
```

> Recomiendo configurar esto en tu propio dominio junto con un proxy inverso como [nginx](https://nginx.org) y sobre Cloudflare con protección activada.

A continuación, despliega tu Worker con el botón de abajo y sigue las instrucciones.

[![Deploy to Cloudflare Workers](https://deploy.workers.cloudflare.com/button)](https://deploy.workers.cloudflare.com/?url=https://github.com/okdargy/fxtiktok)

Una vez hecho, ve a "Settings" y cambia tu servidor de descarga en "Variables and Secrets":

<img src="https://raw.githubusercontent.com/okdargy/fxTikTok/hono-rewrite/.github/readme/settings.png" alt="Página de Configuración, mostrando dónde hacer clic para cambiar tu Servidor de Descarga" height="300px" style="border-radius:2%" />

#### 🎉 ¡Eso es todo! Ahora tienes tu propia instancia de fxTikTok para usar cuando y donde quieras.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-04

---