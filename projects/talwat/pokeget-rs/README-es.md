# pokeget-rs

Una mejor versión en Rust de pokeget.

## Uso

`pokeget <pokemon>`

Para más información, ejecuta `pokeget --help`.

## Estado del proyecto

He decidido que aunque seguiré corrigiendo errores y demás,
no se añadirán ni modificarán más sprites a menos que sea un problema serio.
Esto es porque primero, pokemon se está alejando de los sprites en píxeles,
y segundo, que pokesprite ha dejado de actualizarse y no se ha encontrado
una alternativa adecuada.

### .bashrc

Si usas pokeget al iniciar la shell, como en `.bashrc`,
entonces en lugar de ejecutar `pokeget <pokemon>`, puedes escribir la salida
a un archivo haciendo: `pokeget <pokemon> > file.txt`
y luego tener algo como `cat file.txt` en tu bashrc.

Esto hace que la inicialización de tu shell sea prácticamente instantánea, pero obviamente
no funcionará con pokemon aleatorios. pokeget ya es bastante rápido,
así que usarlo en la inicialización de la shell tampoco es un gran cuello de botella.

### Ejemplos

#### Usando múltiples pokemon

`pokeget bulbasaur pikachu random`

#### Usando IDs de la pokedex

`pokeget 1 2 3`

#### Usando formas alternativas

`pokeget raichu sandslash meowth --alolan`

#### Uso de regiones

`pokeget kanto`

## Instalación

### Cargo *(recomendado)*

El método de instalación recomendado es usar cargo:

```sh
cargo install pokeget
```

and making sure `$HOME/.cargo/bin` is added to `$PATH`.

### AUR

If you're on Arch, you can also use the AUR:

```sh
yay -S pokeget
```

### Git

You can also clone the repository and compile manually by doing:

```sh
git clone --recurse-submodules https://github.com/talwat/pokeget-rs.git
cd pokeget-rs
cargo build --release
mv target/release/pokeget ~/.local/bin
```

y asegurándose de que `$HOME/.local/bin` esté añadido a `$PATH`.

### Añadiendo un directorio a $PATH

#### Bash & Zsh

Agrega esto a tu `.bashrc` o `.zshrc`:

```sh
export PATH="<path>:$PATH"
```

#### Pescado

Ejecuta esto en tu CLI:

```sh
fish_add_path <path>
```

## Actualización

Simplemente vuelve a ejecutar `cargo install pokeget` o `git pull` en el repositorio y luego recompila.

## ¿Por qué?

Porque el primer pokeget era lento, pesado y muy complicado, así que decidí hacer una mejor versión en Rust.

Ahora, en lugar de precomputar todos los sprites y subirlos a un repositorio, pokeget podrá
computarlos bajo demanda, lo que hace que todo sea mucho más flexible.
Rust permite que ese cálculo se realice mucho más rápido que algo como Python.

También dibujará los sprites 2x más pequeños usando cuadrados medios.

## ¿Qué pasa con otros proyectos?

pokeget-rs tiene una ventaja sobre proyectos como el antiguo pokeget, pokeshell, etc... ya que está en Rust.
Además, es significativamente (5.5x) más rápido que krabby, que es otro proyecto muy similar.

Para más información, visita [OTHER_PROJECTS.md](https://raw.githubusercontent.com/talwat/pokeget-rs/main/OTHER_PROJECTS.md).

## ¿Qué pasa con los sprites grandes?

Desaparecieron. Reducidos a átomos.

En serio, simplemente decidí no lidiar con ellos porque es un trabajo significativamente
extra que no quiero manejar. Rara vez se usaban y se veían feos
en ventanas de terminal pequeñas, así que tenía poco sentido mantenerlos.

## Créditos

Esta vez, los sprites son de [pokesprite](https://github.com/msikma/pokesprite) y pokeget los usa con un submódulo git.

Los sprites están integrados en el binario, por lo que pokeget no los descargará. Esto es un buen compromiso,
ya que aunque el binario pueda ser grande, pokeget puede ejecutarse casi instantáneamente y sin conexión.

## Licencia

pokeget usa la licencia MIT, así que siéntete libre de bifurcarlo y personalizarlo como desees.
Si no estás seguro acerca de algún funcionamiento interno de pokeget, [abre un issue](https://github.com/talwat/pokeget-rs/issues),  
y responderé cualquier pregunta que puedas tener.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-19

---