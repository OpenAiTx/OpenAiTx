# Go-Deploy Herramienta de Despliegue

Una herramienta de despliegue automatizado desarrollada en Go, que permite subir los artefactos construidos localmente al servidor remoto mediante el protocolo SFTP.

## Características

- ✅ **Transferencia segura**: Usa el protocolo SFTP, basado en transferencia cifrada SSH
- ✅ **Sincronización de directorios**: Sube recursivamente toda la estructura de directorios, manteniendo la jerarquía de archivos
- ✅ **Creación inteligente**: Crea automáticamente la estructura de directorios remotos
- ✅ **Ruta auto-adaptativa**: Calcula automáticamente la ruta local en base a la ubicación del ejecutable, sin preocuparse por el directorio de ejecución
- ✅ **Soporte de archivos de configuración**: Soporta archivos de configuración JSON, facilitando la gestión de diferentes entornos
- ✅ **Exclusión de archivos**: Soporta patrones comodín para excluir archivos que no se deben subir
- ✅ **Copia de seguridad automática**: Puede realizar copias de seguridad automáticas de archivos remotos antes de subirlos
- ✅ **Mecanismo de reintentos**: Reintenta automáticamente la subida en caso de fallo, aumentando la tasa de éxito
- ✅ **Estadísticas detalladas**: Muestra el número de archivos subidos, tamaño transferido, tiempo empleado y velocidad
- ✅ **Visualización de progreso**: Muestra en tiempo real el progreso de la subida y la información de los archivos
- ✅ **Gestión de errores**: Manejo de errores completo y salida de logs

## Requisitos del sistema

- Go 1.18 o superior
- El servidor de destino debe soportar el protocolo SSH/SFTP

## Instrucciones de instalación

### 1. Clonar el proyecto

```bash
git clone <your-repo-url>
cd go-deploy
```

### 2. Inicializar el módulo de Go

```bash
go mod init go-deploy
go mod tidy
```

### 3. Instalar dependencias

El programa descargará automáticamente las siguientes dependencias:

- `github.com/pkg/sftp` - Cliente SFTP
- `golang.org/x/crypto/ssh` - Cliente SSH

## Instrucciones de configuración

El programa soporta dos formas de configuración:

### 1. Usar archivo de configuración (recomendado)

Copia `config.example.json` como `config.json` y modifica la configuración:

```bash
cp config.example.json config.json
```

Luego edita `config.json`:

```json
{
  "server": {
    "host": "your-server-ip",
    "port": 22,
    "username": "your-username",
    "password": "your-password",
    "timeout": 10
  },
  "paths": {
    "local": "../../unpackage/dist/build/web",
    "remote": "/opt/your-path/dist"
  },
  "options": {
    "backup": true,
    "backup_suffix": ".backup",
    "exclude_patterns": [
      "*.log",
      "*.map",
      ".DS_Store",
      "node_modules"
    ],
    "max_retries": 3,
    "chunk_size": 1048576
  }
}
```

#### Descripción de los parámetros de configuración

**Configuración de server**:

- `host`: Dirección del servidor SSH
- `port`: Puerto SSH, normalmente 22
- `username`: Nombre de usuario SSH
- `password`: Contraseña SSH (se recomienda autenticación por clave en producción)
- `timeout`: Tiempo de espera de conexión (segundos)

**Configuración de paths**:

- `local`: Ruta del directorio local, soporta rutas relativas y absolutas
- `remote`: Ruta del directorio remoto, debe ser una ruta absoluta

**Configuración de options**:

- `backup`: Si se realiza una copia de seguridad de los archivos remotos existentes antes de subir
- `backup_suffix`: Sufijo de los archivos de copia de seguridad, se puede personalizar; si el archivo de respaldo no existe, se omite la copia
- `exclude_patterns`: Patrones de exclusión de archivos, soporta comodines
- `max_retries`: Número máximo de reintentos en caso de fallo de subida
- `chunk_size`: Tamaño del bloque de transferencia (bytes, aún no implementado)

### 2. Configuración predeterminada (modo compatible)

Si no existe el archivo `config.json`, el programa usará la configuración predeterminada incorporada, asegurando compatibilidad hacia atrás.

#### Prioridad de archivos de configuración

1. **Archivo de configuración especificado en línea de comandos**: Archivo indicado con el parámetro `--config`
2. **Archivo de configuración predeterminado**: `config.json` en el directorio actual
3. **Configuración predeterminada interna**: Si no existe ninguno de los anteriores, usa la configuración interna del programa

#### Reglas de manejo de rutas

- **Ruta del archivo de configuración**:

  - Ruta relativa: Con base en el directorio donde está el ejecutable
  - Ruta absoluta: Usa la ruta indicada directamente
- **Ruta del directorio local**:

  - Ruta relativa: Con base en el directorio donde está el ejecutable
  - Ruta absoluta: Usa la ruta indicada directamente

## Instrucciones de ejecución

### Parámetros de línea de comandos

El programa soporta los siguientes parámetros:

```bash
# Mostrar ayuda
./deploy --help

# Mostrar versión  
./deploy --version

# Usar archivo de configuración predeterminado config.json
./deploy

# Usar archivo de configuración especificado
./deploy --config prod.json

# Usar archivo de configuración con ruta absoluta
./deploy --config /path/to/config.json
```

### Ejecución en entorno de desarrollo

```bash
# Usar configuración predeterminada
go run main.go

# Usar archivo de configuración especificado
go run main.go --config test.json

# Mostrar ayuda
go run main.go --help
```

### Ejecución tras compilar

```bash
# Compilar
go build -o deploy main.go

# Ejecutar con configuración predeterminada
./deploy

# Ejecutar con archivo de configuración especificado
./deploy --config prod.json
```

## Instrucciones de empaquetado

### 1. Empaquetado para la plataforma local

```bash
# Compilar ejecutable para la plataforma actual
go build -o deploy main.go
```

### 2. Empaquetado multiplataforma

#### Linux 64 bits

```bash
GOOS=linux GOARCH=amd64 go build -o deploy-linux-amd64 main.go
```

#### Windows 64 bits
```bash
GOOS=windows GOARCH=amd64 go build -o deploy-windows-amd64.exe main.go
```

#### macOS 64 bits

```bash
GOOS=darwin GOARCH=amd64 go build -o deploy-darwin-amd64 main.go
```

#### macOS ARM64 (M1/M2)

```bash
GOOS=darwin GOARCH=arm64 go build -o deploy-darwin-arm64 main.go
```

### 3. Optimización del empaquetado (reducir el tamaño del archivo)

```bash
# Eliminar información de depuración y tabla de símbolos
go build -ldflags="-s -w" -o deploy main.go

# Comprimir con UPX (requiere tener UPX instalado)
upx --best deploy
```

### 4. Script de empaquetado por lotes

Crea el script `build.sh`:

```bash
#!/bin/bash

# Crear directorio de compilación
mkdir -p builds

# Compilar versiones para cada plataforma
echo "Compilando versión Linux 64 bits..."
GOOS=linux GOARCH=amd64 go build -ldflags="-s -w" -o builds/deploy-linux-amd64 main.go

echo "Compilando versión Windows 64 bits..."
GOOS=windows GOARCH=amd64 go build -ldflags="-s -w" -o builds/deploy-windows-amd64.exe main.go

echo "Compilando versión macOS 64 bits..."
GOOS=darwin GOARCH=amd64 go build -ldflags="-s -w" -o builds/deploy-darwin-amd64 main.go

echo "Compilando versión macOS ARM64..."
GOOS=darwin GOARCH=arm64 go build -ldflags="-s -w" -o builds/deploy-darwin-arm64 main.go

echo "¡Compilación completada!"
ls -la builds/
```

Ejecutar el script:

```bash
chmod +x build.sh
./build.sh
```

## Ejemplo de uso

### Mostrar información de ayuda

```bash
$ ./deploy --help
Herramienta de despliegue Go-Deploy

Uso: ./deploy [opciones]

Opciones:
  -config string
        Ruta al archivo de configuración (por defecto "config.json")
  -help
        Muestra información de ayuda
  -version
        Muestra información de versión

Ejemplos:
  ./deploy                           # Usa el archivo de configuración por defecto config.json
  ./deploy --config prod.json        # Usa un archivo de configuración especificado
  ./deploy --config /path/to/config.json  # Usa un archivo de configuración con ruta absoluta
```

### Usar archivo de configuración especificado

```bash
$ ./deploy --config prod.json
Iniciando ejecución del programa de despliegue...
Intentando leer el archivo de configuración: /path/to/go-deploy/prod.json
Usando archivo de configuración...
El directorio local /path/to/project/dist existe
Conectando al servidor SSH...
Conexión al servidor SSH exitosa
...
```

### Usar archivo de configuración

```bash
$ ./deploy
Iniciando ejecución del programa de despliegue...
Intentando leer el archivo de configuración: /path/to/go-deploy/config.json
Usando archivo de configuración...
El directorio local /path/to/project/unpackage/dist/build/web existe
Conectando al servidor SSH...
Conexión al servidor SSH exitosa
Creando cliente SFTP...
Cliente SFTP creado correctamente
Preparando subida al directorio remoto: /opt/xsoft/nginx/html/app/dist
Comenzando la subida del directorio...
Recorriendo directorio local: /path/to/project/unpackage/dist/build/web
Creando directorio: /opt/xsoft/nginx/html/app/dist
Archivo static/js/app.js.map excluido, omitiendo subida
Creando copia de seguridad: /opt/xsoft/nginx/html/app/dist/index.html -> /opt/xsoft/nginx/html/app/dist/index.html.backup
Subiendo archivo: /path/to/project/unpackage/dist/build/web/index.html -> /opt/xsoft/nginx/html/app/dist/index.html
Archivo .DS_Store excluido, omitiendo subida
Subiendo archivo: /path/to/project/unpackage/dist/build/web/static/css/app.css -> /opt/xsoft/nginx/html/app/dist/static/css/app.css
Subida fallida (intento 1/3): error de red
Reintentando subida de archivo (2/3): /path/to/project/unpackage/dist/build/web/static/js/app.js
Subiendo archivo: /path/to/project/unpackage/dist/build/web/static/js/app.js -> /opt/xsoft/nginx/html/app/dist/static/js/app.js
...
¡Directorio subido con éxito!
Estadísticas:
  - Archivos subidos: 485
  - Directorios creados: 18
  - Tamaño transferido: 25.8 MB
  - Tiempo de subida: 38.5s
  - Tiempo total: 39.2s
  - Velocidad de transferencia: 0.67 MB/s
```

## Notas

1. **Seguridad**:

   - En entornos de producción se recomienda usar autenticación por clave SSH en lugar de contraseña
   - Actualmente se utiliza `ssh.InsecureIgnoreHostKey()`, en producción se debe verificar la clave del host
2. **Red**:

   - Asegúrate de que se puede acceder al puerto 22 del servidor de destino desde el host local
   - La velocidad de transferencia depende del ancho de banda y el rendimiento del servidor
3. **Permisos**:

   - Asegúrate de que el usuario SSH tenga permisos de escritura en el directorio de destino
   - Si es necesario, puede requerirse permisos de sudo
4. **Rutas**:

   - La ruta local se calcula automáticamente en base a la ubicación del ejecutable, no es necesario preocuparse por el directorio de trabajo
   - La ruta remota utiliza rutas absolutas

## Solución de problemas

### Problemas comunes

1. **Tiempo de espera de conexión**

   ```
   Fallo al conectar al servidor SSH: dial tcp: i/o timeout
   ```

   - Verifica la dirección y el puerto del servidor
   - Confirma la conectividad de red
   - Revisa la configuración del firewall
2. **Fallo de autenticación**

   ```
   Error de inicio de sesión: ssh: handshake failed
   ```

   - Revisa el nombre de usuario y contraseña
   - Confirma que el servicio SSH está activo
   - Revisa la configuración de SSH
3. **Error de permisos**

   ```
   Error al crear directorio: permission denied
   ```

   - Verifica que el usuario tenga permisos de escritura en el directorio de destino
   - Puede requerirse usar sudo o cambiar el propietario del directorio
4. **Directorio local no existe**

   ```
   Error: El directorio local /path/to/unpackage/dist/build/web no existe
   ```

   - Confirma que la construcción local se ha completado
   - Verifica que la estructura del proyecto sea correcta
   - El programa calculará automáticamente la ruta, no es necesario cambiar el directorio de trabajo manualmente

## Notas de desarrollo

### Estructura del proyecto

```
go-deploy/
├── main.go                 # Archivo principal del programa
├── go.mod                  # Archivo de módulo de Go  
├── go.sum                  # Archivo de verificación de dependencias
```
├── README.md               # Documentación detallada
├── Makefile                # Herramienta de construcción
├── build.sh                # Script de empaquetado por lotes
├── install.sh              # Script de instalación en un solo paso
└── config.example.json     # Ejemplo de archivo de configuración
```

### Funciones principales

- `main()` - Función principal, maneja la conexión y llama a la subida
- `uploadDirectory()` - Sube directorios recursivamente
- `uploadFile()` - Sube un solo archivo
- `mkdirAll()` - Crea directorios remotos recursivamente

## Licencia

Licencia MIT

## Contribuciones

¡Bienvenidos los Issues y Pull Requests!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---