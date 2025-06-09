# Actualizar la base de datos de Browserslist

<img width="120" height="120" alt="Logo de Browserslist por Anton Popov"
     src="https://browsersl.ist/logo.svg" align="right">

Herramienta CLI para actualizar `caniuse-lite` con la base de datos de navegadores
desde la configuración de [Browserslist](https://github.com/browserslist/browserslist/).

Algunas consultas como `last 2 versions` o `>1%` dependen de los datos reales
de `caniuse-lite`.

```sh
npx update-browserslist-db@latest
```

<a href="https://evilmartians.com/?utm_source=update-browserslist-db">
  <img src="https://evilmartians.com/badges/sponsored-by-evil-martians.svg"
       alt="Patrocinado por Evil Martians" width="236" height="54">
</a>

## Por qué necesitas ejecutarlo regularmente

`npx update-browserslist-db@latest` actualiza la versión de `caniuse-lite`
en el archivo de bloqueo de npm, yarn o pnpm.

Esta actualización traerá datos sobre nuevos navegadores a herramientas de polyfill
como Autoprefixer o Babel y reducirá los polyfills innecesarios.

Debes hacerlo regularmente por tres razones:

1. Para usar las versiones y estadísticas más recientes de los navegadores en consultas como
   `last 2 versions` o `>1%`. Por ejemplo, si creaste tu proyecto
   hace 2 años y no actualizaste tus dependencias, `last 1 version`
   devolverá navegadores de hace 2 años.
2. Los datos reales de los navegadores conducirán a usar menos polyfills. Esto reducirá
   el tamaño de los archivos JS y CSS y mejorará el rendimiento del sitio web.
3. Deduplificación de `caniuse-lite`: para sincronizar versiones en diferentes herramientas.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---