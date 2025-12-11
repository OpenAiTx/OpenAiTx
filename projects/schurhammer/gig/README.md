# gig

Gig is a gleam compiler written in gleam.

## How to use

### Compile and run a sample file:

```bash
# clone the repository
git clone https://github.com/schurhammer/gig
cd gig

# compile a sample
gleam run samples/hello_world.gleam

# run the sample
samples/hello_world.exe
```

- This will compile the file `samples/hello_world.gleam` to `samples/hello_world.c` and then use a c compiler to create the binary at `samples/hello_world.exe`.
- Gig adds the `.exe` extension to avoid common naming conflicts with source directories.

### Compile gig:

```bash
# compile gig into a binary
gleam run src/gig.gleam --gc --release

# compile a sample using the gig binary
src/gig.exe samples/hello_world.gleam

# run the sample
samples/hello_world.exe
```

### Compile your project using the gig binary:

- Add the `gig` executable to your path or copy it into your project.
- Copy the `patch` directory into your project.

```bash
# you should be in your project root
cd <your project root>

# copy patch directory (adjust file paths to match your system)
cp -r ../gig/patch patch

# ensure dependencies are downloaded
gleam deps download

# compile your main module
gig src/<main module>.gleam

# run your main module
src/<main module>.exe
```

- You should run gig from the root directory of the project.
- Gig will include source files from the main module's directory, the `patch` directory, and each source directory of downloaded dependencies (i.e. `build/packages/<package_name>/src`).
- Download dependencies using `gleam deps download`.
- Your main module should be non-nested i.e. directly in the `src` directory.

### Compile your project using gig as a path dependency

- Add gig as a path dependency in your `gleam.toml` file `gig = { path = "../gig" }`.
- Copy the `patch` directory into your project.

```bash
# you should be in your project root
cd <your project root>

# copy patch directory (adjust file paths to match your system)
cp -r ../gig/patch patch

# ensure dependencies are downloaded
gleam deps download

# compile your project using gig as a path dependency
gleam run -m gig src/<main module>.gleam

# run your main module
src/<main module>.exe
```

### Optional flags:

- `--release`: enable optimisation.
- `--gc`: enable garbage collection (otherwise no garbage collection).
- `--debug`: include debug symbols.
- `--headers`: generate header files for FFI functions.
- `--compiler=name`: the name/path of the c compiler.
- `-c`: only generate the c file (not the binary).

> [!IMPORTANT]
> In the likely case you encounter stack overflows, increase your stack size. These often show up as segfaults.
>
> ```
> ulimit -s unlimited
> ```

## Required Dependencies:

- C compiler (clang seems to work best)
- Boehm GC is needed for `--gc` (aka `libgc`)

## Standard Library

Since much of the standard library is implemented with `@external` calls, not all functions are available at this time.
Some functions have already been re-implemented with patches, see the `patch` directory. The compiler will print a warning if an unimplemented function is used, and a "todo" will be used as the function body.

## Patch System

Since gig is a third party project, most gleam libraries in the wild are
unlikely to support it. For these situations we have a patch system that
lets you override some modules that would otherwise not work. To do this simply
create a module called `x.patch.gleam` where `x` is the name of the module
you wish to patch. The patch will be merged with the original module, so you
only need to implement the functions that are broken.
Patches can be placed in the `patch` directory or any of the source directories.

For better c language support in your editor, you can add a `.clangd` and
`compile_flags.txt` file to your project.

`.clangd`:

```
CompileFlags:
  Add: [-Ipatch]
```

`compile_flags.txt`: (empty file)

## FFI

You can use the `@external(c, "", "function_name")` annotation to define C
functions, similar to FFI in normal gleam.
After this, run the compiler with the `--headers` option to generate a header file
with function and type declarations required to implement the external function.
Your implementation C file should `#include` the header file and be named in the
same way as the header file.
Preferably your functions should be namespaced e.g. `module_name_function_name()`.

## Feature / Todo List

### Basics

- [x] Bool
- [x] Int
- [x] Float
- [x] Number formats (other than decimal)
- [x] String
- [x] List
- [x] Equality
- [x] Assignments
- [x] Discard patterns
- [x] Type inference
- [x] Type annotations
- [x] Modules (note: modules are resolved relative to the target file)
- [x] Dependencies
- [x] Unqualified imports
- [x] Type aliases
- [x] Blocks
- [x] Constants
- [x] Memory Management (GC/RC)

### Functions

- [x] Functions
- [x] Higher order functions
- [x] Anonymous functions
- [x] Function captures
- [x] Generic functions
- [x] Pipelines
- [x] Labeled arguments
- [ ] Documentation comments (ignored)
- [ ] Deprecations (ignored)

### Flow control

- [x] Case expressions
- [x] Variable patterns
- [x] Constructor patterns
- [x] String patterns
- [x] List patterns
- [x] Recursion
- [ ] Tail calls (note: the c compiler may do this for us)
- [x] Multiple subjects
- [x] Alternative patterns
- [x] Pattern aliases
- [x] Guards
- [ ] Exhaustiveness checking

### Other Data types

- [x] Tuples
- [x] Custom Types
- [x] Records
- [x] Record accessors
- [x] Record updates
- [x] Generic custom types
- [x] Results
- [ ] Bit arrays (partial support)

### Advanced features

- [ ] Opaque types
- [x] Use
- [x] Todo
- [x] Panic
- [x] Let assert
- [x] Externals

## Contributing

I am not accepting code contributions at this time. Feel free to make issues, suggestions, or discussions though.
