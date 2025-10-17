# Construcción del Teclado Inalámbrico Corne Económico

Un teclado inalámbrico dividido DIY basado en el diseño Corne, construido por aproximadamente $25 USD. Este proyecto utiliza un clon ProMicro con chip nrf52840, convirtiéndolo en una alternativa económica a las construcciones tradicionales de teclados inalámbricos divididos.

## Características
- Totalmente inalámbrico usando Bluetooth
- Diseño ergonómico dividido (diseño Corne)
- Diseño de perfil bajo para portabilidad
- Alimentado por batería con interruptor de encendido
- Firmware ZMK
- Vida estimada de la batería: más de 1 mes

## Lista de Materiales

| Componente | Cantidad | Costo (USD) | Enlace |
|------------|----------|-------------|--------|
| Placas controladoras (ProMicro nrf52840) | 2 | 6.82 | [AliExpress](https://a.aliexpress.com/_EIV3vwY) |
| Baterías | 2 | 4.20 | [AliExpress](https://a.aliexpress.com/_Eynt9TK) |
| Interruptores mecánicos | 50 | 7.47 | [AliExpress](https://a.aliexpress.com/_EGhMxEC) |
| Keycaps | Set | 3.79 | [Opción 1](https://a.aliexpress.com/_EzQyNtA) / [Opción 2](https://a.aliexpress.com/_EH8mNqs) |
| Diodos (1N4148) | 100 | 0.85 | [AliExpress](https://a.aliexpress.com/_EwZoG2G) |
| Interruptores deslizantes | 2 | 0.11 | |
| Piezas impresas en 3D | Set | 1.80 | Archivos proporcionados |

**Costo Total**: $25.04 (excluyendo cables y tornillos)

## Mapa de Teclas Actual

![image](https://github.com/user-attachments/assets/362ff580-5528-4f7a-ad09-1fa24acbc6c7)
![image](https://github.com/user-attachments/assets/3da97ceb-8e2a-43c5-a241-cf9ad4206688)
![image](https://github.com/user-attachments/assets/e262846d-57bf-43b6-b32c-b7e37d3ebb8c)
![image](https://github.com/user-attachments/assets/2a8999cc-e58c-4d51-a142-067cb7ca768c)
![image](https://github.com/user-attachments/assets/06909fd8-bb4d-4956-88a1-f5d6a8b80e5f)

## Instrucciones de Construcción

### Requisitos Previos
- Habilidades básicas de soldadura
- Acceso a una impresora 3D
- Comprensión básica del firmware de teclados
### Ensamblaje de la Caja
1. Imprima los archivos de la caja (archivos STL proporcionados en el directorio `3DFiles`)
2. Nota: Puede que necesite ajustar:
   - Tamaño del compartimento de la batería
   - Agujeros para el interruptor deslizante

### Cableado
1. Cablee los interruptores en una configuración de matriz
2. Conecte los diodos:
   - La dirección importa (la línea negra indica el cátodo)
   - Use las patas del diodo para las filas
   - Use cables separados para las columnas
3. Mantenga el cableado despejado de los agujeros para tornillos
4. Conecte la batería:
   - GND al pin GND
   - Positivo a una de las patas laterales del interruptor deslizante
   - Pin central del interruptor deslizante al pin RAW

### Conexiones de Pines para Filas y Columnas
La configuración de la matriz usa pines GPIO en el clon nRF52840 Pro Micro. A continuación se muestran las conexiones:

![pinout](https://github.com/user-attachments/assets/ae1bf9eb-8071-4a8f-8cac-c95a39f61f9e)

#### Cómo se Numeran Filas y Columnas

- **Filas**: Las filas siempre se numeran de arriba hacia abajo en ambas mitades.
- **Columnas**: Las columnas siempre se numeran de izquierda a derecha (visto desde la parte trasera de la placa (donde se realiza el cableado)).

⚠️ **Nota**: Si accidentalmente suelda las filas o columnas en los pines equivocados, no es necesario desoldar. Las asignaciones se pueden corregir en los archivos de configuración del firmware:
- `corne.dtsi`: Define las filas para ambas mitades.
- `corne_left.overlay`: Define las columnas para la mitad izquierda.
- `corne_right.overlay`: Define las columnas para la mitad derecha.

#### Asignación de Pines en la Mitad Izquierda
- **Filas (conectadas a `row-gpios`)**:
  - Fila 0: Pin 21
  - Fila 1: Pin 20
  - Fila 2: Pin 19
  - Fila 3: Pin 18

- **Columnas (Conectadas a `col-gpios`)**:
  - Columna 0: Pin 2
  - Columna 1: Pin 7
  - Columna 2: Pin 6
  - Columna 3: Pin 5
  - Columna 4: Pin 4
  - Columna 5: Pin 3

#### Asignaciones de Pines de la Mitad Derecha
- **Filas (`row-gpios`)**:
  - Fila 0: Pin 21
  - Fila 1: Pin 20
  - Fila 2: Pin 19
  - Fila 3: Pin 18
- **Columnas (`col-gpios`)**:
  - Columna 0: Pin 3
  - Columna 1: Pin 4
  - Columna 2: Pin 5
  - Columna 3: Pin 6
  - Columna 4: Pin 7
  - Columna 5: Pin 2

### Configuración del Firmware
Este teclado usa el firmware ZMK. La mitad izquierda actúa como el controlador principal que se conecta a tu dispositivo.

Para flashear el firmware:
1. Presiona dos veces el botón de reinicio
2. La placa aparecerá como dispositivo de almacenamiento masivo
3. Flashea el archivo de firmware correspondiente

Si olvidaste el teclado en tu dispositivo y no puedes reconectarte:
1. Flashea el archivo `settings_reset-nice_nano_v2-zmk.uf2`
2. Vuelve a flashear el firmware regular
3. Empareja

## Estructura del Repositorio
```
├── .github/workflows/
│   └── build.yml
├── 3DFiles/
│   ├── STEP/
│   │   └── CorneSTEP.step
│   ├── STL/
│   │   ├── Case_Left.stl
│   │   ├── Case_Right.stl
│   │   └── PlateCorne.stl
├── config/
│   ├── boards/shields/corne/
│   │   ├── corne_left.conf
│   │   ├── corne_left.overlay
│   │   ├── corne_right.conf
│   │   ├── corne_right.overlay
│   │   ├── corne.conf
│   │   ├── corne.dtsi
│   │   ├── Kconfig.defconfig
│   │   └── Kconfig.shield
│   ├── corne.keymap
│   └── west.yml
├── firmware/
│   ├── corne_left-nice_nano_v2-zmk.uf2
│   ├── corne_right-nice_nano_v2-zmk.uf2
│   └── settings_reset-nice_nano_v2-zmk.uf2
└── zephyr/
    ├── module.yml
    └── build.yaml
```

## Problemas conocidos
- La carcasa del lado izquierdo puede tener problemas de deformación si la batería se hincha
- Los orificios del interruptor deslizante pueden necesitar ajuste según tus componentes

## Resultado final
![im1](https://github.com/user-attachments/assets/f57abe5a-585d-4f4e-b741-5c103c7af887)
![im3](https://github.com/user-attachments/assets/1ed52801-5bc1-44b9-8378-1a5e53600e92)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-17

---