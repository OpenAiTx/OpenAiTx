# Dana wallet

Dana es una aplicación Flutter usada para aceptar donaciones en bitcoin. Utiliza pagos silenciosos, un nuevo protocolo de pagos estáticos, para recibir donaciones preservando la privacidad en la cadena.

## Prueba Dana wallet

**Dana wallet está actualmente en una fase experimental. Recomendamos usar testnet/signet. Si realmente quieres probar la wallet en mainnet, usa solo fondos que estés dispuesto a perder. No nos hacemos responsables por fondos perdidos.**

Estamos considerando lanzar Dana wallet en las tiendas de aplicaciones populares una vez que la app sea más estable.

Mientras tanto, hay dos formas de probar Dana wallet:

- Descarga el último APK de Dana wallet desde la [página de lanzamientos](https://github.com/cygnet3/danawallet/releases)
- Descarga Dana wallet usando nuestro [repositorio F-Droid autoalojado](https://fdroid.silentpayments.dev/fdroid/repo)

### Descargar usando F-Droid

Recomendamos la opción F-Droid, ya que tiene soporte para actualizaciones automáticas y solo requiere configurarse una vez.

- Abre F-Droid en tu teléfono Android
- Ve a 'Ajustes'
- En la sección 'Mis apps', haz clic en 'Repositorios'
- Añade un nuevo repositorio haciendo clic en el icono '+'
- Escanea el código QR que se encuentra en esta página: https://fdroid.silentpayments.dev/fdroid/repo

Ahora has añadido nuestro repositorio autoalojado. Para descargar la app, busca 'Dana Wallet' en la sección de la tienda F-Droid (puede que necesites actualizar la lista de apps primero deslizando hacia abajo en la pantalla de la tienda F-Droid).

## Compilar Dana wallet desde el código fuente

A continuación hay algunas instrucciones para compilar Dana wallet desde el código fuente. Esto solo se recomienda si quieres ayudar con el desarrollo de Dana wallet.

### Compilar para linux (escritorio)

Compilar para linux no debería requerir esfuerzo adicional, simplemente ejecuta

```
flutter run
```

Esto también puede funcionar en otras plataformas (macOS, Windows), pero no lo hemos probado.

### Compilar para android

Compilar para un dispositivo android requiere trabajo preparatorio para generar binarios para esta arquitectura.

Primero, necesitas `cargo-ndk`. También puede que necesites añadir las toolchains deseadas:

```
cargo install cargo-ndk
rustup target add \
    aarch64-linux-android \
    armv7-linux-androideabi \
    x86_64-linux-android \
    i686-linux-android
```

Después de instalarlos, entra en el directorio rust y ejecuta `just build-android`.

```
cd rust
just build-android
```

Si no tienes `just` instalado, también puedes copiar los comandos que están en el `justfile`.
Esto genera los binarios.

Luego, conecta tu teléfono y habilita el modo de depuración.
Verifica si tu teléfono está conectado ejecutando

```
flutter devices
```

Finalmente, para compilar e instalar la app en tu dispositivo android:

```
flutter run
```

## Dona a Dana

Puedes donar a Dana wallet usando nuestra dirección:

> ₿donate@danawallet.app

o puedes usar la siguiente dirección de pago silencioso:

> sp1qq0cygnetgn3rz2kla5cp05nj5uetlsrzez0l4p8g7wehf7ldr93lcqadw65upymwzvp5ed38l8ur2rznd6934xh95msevwrdwtrpk372hyz4vr6g

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---