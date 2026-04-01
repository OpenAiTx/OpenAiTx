# Typst-live
This is a simple utility to watch for changes in your [typst](https://github.com/typst/typst) file and automatically
recompile them for live feedback. `typst-live` allows you to open a tab in your browser with typst generated pdf and have it automatically reload
whenever your source `.typ` files are changed.

## Difference from `--watch` flag
`typst-live` hosts a webserver that automatically refreshes the page so you don't have to manually reload it with `typst --watch`

## Installation
If you have [rust](https://www.rust-lang.org) setup use the following command:
```
cargo install typst-live
```

If you use Nix, you can run typst-live directly from the GitHub repository using the following command:
```
nix run github:ItsEthra/typst-live
```

## Usage
### 1. With auto recompilation
* Launch `typst-live` from your terminal:
```
$ typst-live <file.typ>
Server is listening on http://127.0.0.1:5599/
```
* Go to `http://127.0.0.1:5599/` in your browser.
* Now edit your `file.typ` and watch changes appear in browser tab.

### 2. With manual recompilation
You can use `typst-live` to reload pdf files without recompilation of source files.
For that you want to use `--no-recompile` option which disables recompilation and just hosts
your pdf file in browser tab, you will need to specify `filename` as pdf instead of source `.typ` file.
Whenever pdf file changes browser tab will be refreshed.
