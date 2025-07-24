
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# Nothing but Nix

**Transforma tu runner de GitHub Actions en una potencia [Nix](https://zero-to-nix.com/concepts/nix/) ❄️ eliminando sin piedad el software preinstalado innecesario.**

Los runners de GitHub Actions vienen con un espacio en disco escaso para Nix: apenas ~20GB.
*Nothing but Nix* **elimina brutalmente** el software innecesario, ¡dándote **65GB a 130GB** para tu Nix store! 💪

## Uso 🔧

Agrega esta acción **antes** de instalar Nix en tu flujo de trabajo:

```yaml
jobs:
  build:
    runs-on: ubuntu-latest
    permissions:
      contents: read
      id-token: write
    steps:
      - uses: actions/checkout@v4
      - uses: wimpysworld/nothing-but-nix@main
      - name: Install Nix
        uses: DeterminateSystems/nix-installer-action@main
      - name: Run Nix
        run: |
          nix --version
          # Your Nix-powered steps here...
```

### Requisitos ️✔️

- Solo es compatible con los runners oficiales de **Ubuntu** en GitHub Actions
- Debe ejecutarse **antes** de que se instale Nix

## El Problema: Haciendo Espacio para que Nix Prospere 🌱

Los runners estándar de GitHub Actions están llenos de *"bloatware"* que nunca usarás en un flujo de trabajo Nix:

- 🌍 Navegadores web. Muchos de ellos. ¡Hay que tenerlos todos!
- 🐳 Imágenes de Docker consumiendo gigabytes de valioso espacio en disco
- 💻 Entornos de ejecución de lenguajes innecesarios (.NET, Ruby, PHP, Java...)
- 📦 Gestores de paquetes acumulando polvo digital
- 📚 Documentación que nadie jamás leerá

Este exceso deja solo ~20GB para tu almacén Nix, ¡apenas suficiente para compilaciones Nix serias! 😞

## La Solución: Nada más que Nix ️❄️

**Nada más que Nix** aplica una estrategia de tierra arrasada a los runners de GitHub Actions y recupera espacio en disco sin piedad usando un ataque en dos fases:

1. **Corte Inicial:** Crea instantáneamente un gran volumen `/nix` (~65GB) reclamando espacio libre de `/mnt`
2. **Ataque en Segundo Plano:** Mientras tu flujo de trabajo continúa, eliminamos sin piedad el software innecesario para expandir tu volumen `/nix` hasta ~130GB
   - ¿Navegadores web? No ⛔
   - ¿Imágenes de Docker? Eliminadas 🗑️
   - ¿Entornos de ejecución? Borrados 💥
   - ¿Gestores de paquetes? Aniquilados 💣
   - ¿Documentación? Vaporizada ️👻

La purga del sistema de archivos es impulsada por `rmz` (del proyecto [Fast Unix Commands (FUC)](https://github.com/SUPERCILEX/fuc)) - una alternativa de alto rendimiento a `rm` que hace que la recuperación de espacio sea rapidísima ⚡
   - Supera al `rm` estándar por un orden de magnitud
   - Elimina en paralelo para máxima eficiencia
   - **¡Recupera espacio en segundos en vez de minutos!** ️⏱️

¿El resultado final? ¡Un runner de GitHub Actions con **65GB a 130GB** de espacio listo para Nix! 😁

### Crecimiento Dinámico del Volumen

A diferencia de otras soluciones, **Nada más que Nix** hace crecer tu volumen `/nix` dinámicamente:

1. **Creación Inicial de Volumen (1-10 segundos):** (*dependiendo del Protocolo Hatchet*)
   - Crea un dispositivo de bucle a partir del espacio libre en `/mnt`
   - Configura un sistema de archivos BTRFS en modo RAID0
   - Monta con compresión y ajustes de rendimiento
   - Proporciona un `/nix` de 65GB de inmediato, incluso antes de que comience la purga

2. **Expansión en Segundo Plano (30-180 segundos):** (*dependiendo del Protocolo Hatchet*)
   - Ejecuta operaciones de purga
   - Monitorea el espacio recién liberado a medida que se elimina el bloat
   - Agrega dinámicamente un disco de expansión al volumen `/nix`
   - Rebalancea el sistema de archivos para incorporar el nuevo espacio

El volumen `/nix` **crece automáticamente durante la ejecución del flujo de trabajo** 🎩🪄

### Elige Tu Arma: El Protocolo Hatchet 🪓

Controla el nivel de aniquilación 💥 con el parámetro de entrada `hatchet-protocol`:

```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    hatchet-protocol: 'cleave'  # Options: holster, carve, cleave (default), rampage
```

#### Comparación de Protocolos ⚖️

| Protocolo | `/nix` | Descripción                                      | Purgar apt  | Purgar docker | Purgar snap | Sistemas de archivos purgados     |
|-----------|--------|--------------------------------------------------|-------------|---------------|-------------|-----------------------------------|
| Holster   | ~65GB  | Mantén el hacha envainada, usa espacio de `/mnt` | No          | No            | No          | Ninguno                           |
| Carve     | ~85GB  | Fabrica y combina espacio libre de `/` y `/mnt`  | No          | No            | No          | Ninguno                           |
| Cleave    | ~115GB | Haz cortes potentes y decisivos a paquetes grandes| Mínimo      | Sí            | Sí          | `/opt` y `/usr/local`             |
| Rampage   | ~130GB | Eliminación implacable y brutal de todo el bloat | Agresivo    | Sí            | Sí          | ¡Muajajaja! 🔥🌎                   |

Elige sabiamente:
- **Holster** cuando necesitas que las herramientas del runner sigan totalmente funcionales
- **Carve** para preservar las herramientas funcionales del runner pero reclamar todo el espacio libre para Nix
- **Cleave** (*predeterminado*) para un buen equilibrio entre espacio y funcionalidad
- **Rampage** cuando necesitas el máximo espacio para Nix y no te importa lo que se rompa `#nix-es-vida`

### Sé Testigo de la Carnicería 🩸

Por defecto, el proceso de purga se ejecuta silenciosamente en segundo plano mientras tu flujo de trabajo continúa. Pero si quieres ver la masacre en tiempo real:

```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    ️hatchet-protocol: 'cleave'
    witness-carnage: true  # Default: false
```

### Personaliza Refugios Seguros 🛡️

Controla cuánto espacio reservar del acaparamiento de la tienda Nix con tamaños personalizados de refugio seguro:

```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    ️hatchet-protocol: 'cleave'
    root-safe-haven: '3072'   # Reserve 3GB on the / filesystem
    mnt-safe-haven: '2048'    # Reserve 2GB on the /mnt filesystem
```

Estos refugios seguros definen cuánto espacio (en MB) será misericordiosamente preservado durante la recuperación de espacio:
- El `root-safe-haven` predeterminado es 2048MB (2GB)
- El `mnt-safe-haven` predeterminado es 1024MB (1GB)

Aumenta estos valores si necesitas más margen en tus sistemas de archivos, o redúcelos para no mostrar piedad alguna. 😈

### Otorgar propiedad de /nix al usuario (Edicto de Permisos de Nix) 🧑‍⚖️

Algunos instaladores o configuraciones de Nix esperan que el directorio `/nix` sea escribible por el usuario actual. Por defecto, `/nix` pertenece a root. Si necesitas propiedad de usuario (por ejemplo, para ciertos scripts de instalación de Nix que no usan `sudo` para todas las operaciones dentro de `/nix`), puedes habilitar el `nix-permission-edict`:

```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    nix-permission-edict: true  # Default: false
```

Cuando `nix-permission-edict` está configurado en `true`, la acción ejecutará `sudo chown -R "$(id --user)":"$(id --group)" /nix` después de montar `/nix`.

¡Ahora ve y construye algo asombroso con todo ese glorioso espacio del Nix store! ❄️

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-24

---