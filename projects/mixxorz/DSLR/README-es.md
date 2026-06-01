<br />
<br />
<p align="center">
  <a href="https://github.com/mixxorz/DSLR">
    <img width="281" height="84" src="https://user-images.githubusercontent.com/3102758/181914025-44bff27e-aac1-4d1b-a037-9fa98f9fed65.png" alt="El logo de DSLR">
  </a>
</p>
<br />

<p align="center">
  <a href=""><img src="" alt=""></a>
  <a href="https://badge.fury.io/py/dslr"><img src="https://badge.fury.io/py/dslr.svg" alt="Versión en PyPI"></a>
  <a href="https://pypi.python.org/pypi/dslr/"><img src="https://img.shields.io/pypi/pyversions/dslr.svg" alt="Versiones de Python soportadas en PyPI"></a>
  <a href="https://github.com/mixxorz/dslr"><img src="https://github.com/mixxorz/dslr/actions/workflows/tests.yml/badge.svg" alt="GitHub Actions (Calidad de código y pruebas)"></a>

</p>

<p align="center">
  <img src="https://user-images.githubusercontent.com/3102758/190845105-dd2ec4e6-286b-431d-a33d-490805852b68.png" alt="Una terminal mostrando la interfaz de línea de comandos de DSLR.">
</p>

---

Instantáneas, listado y restauración de bases de datos

Toma instantáneas ultrarrápidas de tus bases de datos locales de Postgres.

## ¿Qué es esto?

DSLR es una herramienta que te permite tomar y restaurar instantáneas de bases de datos rápidamente
cuando estás escribiendo migraciones de bases de datos, cambiando de ramas o experimentando con
SQL.

Está pensada para ser una sucesora espiritual de
[Stellar](https://github.com/fastmonkeys/stellar).

**Importante:** DSLR está destinada solo para uso en desarrollo. No es recomendable
usar DSLR en bases de datos de producción.

## Rendimiento
DSLR es mucho más rápido que el enfoque estándar de `pg_dump`/`pg_restore` para instantáneas.

<p align="center">
  <img src="https://user-images.githubusercontent.com/3102758/182014327-1b13da6e-63ad-4bbe-817e-7d6c66befc98.png" alt="Un gráfico que compara el tiempo de ejecución entre DSLR y pg_dump/pg_restore. Para instantánea y restauración, DSLR tomó 4.125 segundos y 4.431 segundos respectivamente. pg_dump/pg_restore tomó 36.602 segundos y 13.257 segundos respectivamente.">
</p>

DSLR es 8 veces más rápido al tomar instantáneas y 3 veces más rápido al restaurarlas en comparación con el enfoque `pg_dump`/`pg_restore`.

<details>
  <summary>Metodología de prueba</summary>
  
  Inicié Postgres 12.3 usando Docker, creé una base de datos de prueba y la llené con 1GB de datos aleatorios usando este script:
  

  ```SQL
  CREATE TABLE large_test (num1 bigint, num2 double precision, num3 double precision);

INSERT INTO large*test (num1, num2, num3)
SELECT round(random() * 10), random(), random() \_ 142
FROM generate_series(1, 20000000) s(i);

```

Utilicé los siguientes comandos para medir el tiempo de ejecución:

```

time dslr snapshot my-snapshot
time dslr restore my-snapshot
time pg_dump -Fc -f export.dump
time pg_restore --no-acl --no-owner export.dump

```
Ejecuté cada comando tres veces y tracé la media en el gráfico.

Aquí están los datos sin procesar:

| Comando       | Ejecución | Tiempo de ejecución (segundos) |
| ------------- | --------- | ------------------------------ |
| dslr snapshot | 1         | 4.797                          |
|               | 2         | 4.650                          |
|               | 3         | 2.927                          |
| dslr restore  | 1         | 5.840                          |
|               | 2         | 4.122                          |
|               | 3         | 3.331                          |
| pg_dump       | 1         | 37.345                         |
|               | 2         | 36.227                         |
|               | 3         | 36.233                         |
| pg_restore    | 1         | 13.304                         |
|               | 2         | 13.148                         |
|               | 3         | 13.320                         |
</details>

## Instalación


```

pip install DSLR psycopg2 # or psycopg2-binary, or psycopg

```

**Instalar usando pipx**

```

pipx install DSLR[psycopg2] # or psycopg2-binary, or psycopg

````

**Instalar usando uv**

```

uv tool install 'DSLR[psycopg2]' # or psycopg2-binary, or psycopg

```

Nota: Los comandos de instantánea `export` e `import` de DSLR requieren que `pg_dump` y
`pg_restore` estén presentes en su `PATH`, por lo que necesitará las utilidades CLI de Postgres
si desea usar esos comandos.

<details>
  <summary><strong>Autocompletado en shell</strong></summary>

**Bash**

Agregue esto a `~/.bashrc`:

```
eval "$(_DSLR_COMPLETE=bash_source dslr)"
```

**Zsh**

Add this to `~/.zshrc`:

```
eval "$(_DSLR_COMPLETE=zsh_source dslr)"
```

**Fish**

Agrega esto a `~/.config/fish/completions/dslr.fish`:

```
eval (env _DSLR_COMPLETE=fish_source dslr)
```

Este es el mismo archivo utilizado para el método del script de activación a continuación. Para Fish probablemente siempre sea más fácil usar ese método.

Usar eval significa que el comando se invoca y evalúa cada vez que se inicia una shell, lo que puede retrasar la capacidad de respuesta de la shell. Para acelerarlo, escriba el script generado en un archivo y luego ejecútelo con source.

**Bash**

Guarde el script en algún lugar.

```
_DSLR_COMPLETE=bash_source dslr > ~/.dslr-complete.bash
```

Ejecute el archivo en ~/.bashrc.

```
. ~/.dslr-complete.bash
```

**Zsh**

Save the script somewhere.

```
_DSLR_COMPLETE=zsh_source dslr > ~/.dslr-complete.zsh
```

Fuente el archivo en ~/.zshrc.

```
. ~/.dslr-complete.zsh
```

**Fish**

Guarde el script en ~/.config/fish/completions/foo-bar.fish:

```
_DSLR_COMPLETE=fish_source dslr > ~/.config/fish/completions/dslr.fish
```

</details>



## Configuración

Puedes indicarle a DSLR de qué base de datos tomar instantáneas de varias maneras:

**DATABASE_URL**

Si la variable de entorno `DATABASE_URL` está configurada, DSLR la utilizará para conectarse
a tu base de datos objetivo.

```bash
export DATABASE_URL=postgres://username:password@host:port/database_name
````

**dslr.toml**

Si existe un archivo `dslr.toml` en el directorio actual, DSLR leerá sus
configuraciones desde allí. DSLR preferirá esto sobre la variable de entorno.

```toml
url = 'postgres://username:password@host:port/database_name'
```

**Opción `--url`**

Finalmente, puede pasar explícitamente la cadena de conexión mediante la opción `--url`.
Esto anulará cualquiera de las configuraciones anteriores.

## Uso

```
$ dslr snapshot my-first-snapshot
Created new snapshot my-first-snapshot

$ dslr restore my-first-snapshot
Restored database from snapshot my-first-snapshot

$ dslr list

  Name                Created            Size
 ─────────────────────────────────────────────
  my-first-snapshot   2 minutes ago   3253 kB

$ dslr rename my-first-snapshot fresh-db
Renamed snapshot my-first-snapshot to fresh-db

$ dslr delete some-old-snapshot
Deleted some-old-snapshot

$ dslr export my-feature-test
Exported snapshot my-feature-test to my-feature-test_20220730-075650.dump

$ dslr import snapshot-from-a-friend_20220730-080632.dump friend-snapshot
Imported snapshot friend-snapshot from snapshot-from-a-friend_20220730-080632.dump
```

Para forzar la sobrescritura de una instantánea existente en una consola no interactiva, use la opción `-y`:

```
$ dslr snapshot my-first-snapshot -y
Updated snapshot my-first-snapshot
```

## ¿Cómo funciona?

DSLR toma instantáneas clonando bases de datos usando la funcionalidad de [Bases de Datos Plantilla](https://www.postgresql.org/docs/current/manage-ag-templatedbs.html) de Postgres. Esta es la principal fuente de la rapidez de DSLR.

Esto significa que tomar una instantánea es simplemente crear una nueva base de datos usando la base de datos principal como plantilla. Restaurar una instantánea es simplemente eliminar la base de datos principal y crear una nueva base de datos usando la base de datos de la instantánea como plantilla. Y así sucesivamente.

## Colaboradores

[![Colaboradores](https://contrib.rocks/image?repo=mixxorz/DSLR)](https://github.com/mixxorz/DSLR/graphs/contributors)

## Licencia

MIT







---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-01

---