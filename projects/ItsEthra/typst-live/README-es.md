# Typst-live
Esta es una utilidad simple para monitorear cambios en tu archivo [typst](https://github.com/typst/typst) y recompilarlos automáticamente
para retroalimentación en vivo. `typst-live` te permite abrir una pestaña en tu navegador con el pdf generado por typst y que se recargue automáticamente
cada vez que se modifiquen tus archivos fuente `.typ`.

## Diferencia con la opción `--watch`
`typst-live` hospeda un servidor web que refresca automáticamente la página para que no tengas que recargarla manualmente con `typst --watch`

## Instalación
Si tienes configurado [rust](https://www.rust-lang.org) usa el siguiente comando:
```
cargo install typst-live
```
Si usas Nix, puedes ejecutar typst-live directamente desde el repositorio de GitHub usando el siguiente comando:

```
nix run github:ItsEthra/typst-live
```

## Uso
### 1. Con recompilación automática
* Inicie `typst-live` desde su terminal:
```
$ typst-live <file.typ>
Server is listening on http://127.0.0.1:5599/
```
* Ve a `http://127.0.0.1:5599/` en tu navegador.  
* Ahora edita tu `file.typ` y observa los cambios aparecer en la pestaña del navegador.  

### 2. Con recompilación manual  
Puedes usar `typst-live` para recargar archivos pdf sin recompilar los archivos fuente.  
Para eso quieres usar la opción `--no-recompile` que deshabilita la recompilación y solo aloja  
tu archivo pdf en la pestaña del navegador, necesitarás especificar el `filename` como pdf en lugar del archivo fuente `.typ`.  
Cada vez que el archivo pdf cambie, la pestaña del navegador se actualizará.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-01

---