# Go-Deploy Deployment Tool

An automated deployment tool developed in Go, supporting uploading local build artifacts to remote servers via the SFTP protocol.

## Features

- ✅ **Secure Transfer**: Uses SFTP protocol, encrypted transmission based on SSH
- ✅ **Directory Synchronization**: Recursively uploads the entire directory structure, preserving file hierarchy
- ✅ **Intelligent Creation**: Automatically creates remote directory structure
- ✅ **Path Adaptation**: Automatically calculates the local path based on the executable location, no need to worry about the execution directory
- ✅ **Configuration File Support**: Supports JSON configuration files, making it easy to manage configurations for different environments
- ✅ **File Exclusion**: Supports wildcard patterns to exclude files that do not need to be uploaded
- ✅ **Automatic Backup**: Can automatically back up remote files before uploading
- ✅ **Retry Mechanism**: Automatically retries on upload failure to improve success rate
- ✅ **Detailed Statistics**: Displays number of uploaded files, transfer size, duration, and speed
- ✅ **Progress Display**: Real-time display of upload progress and file information
- ✅ **Error Handling**: Comprehensive error handling and log output

## System Requirements

- Go 1.18 or higher
- Target server supports SSH/SFTP protocol

## Installation Instructions

### 1. Clone the Project

```bash
git clone <your-repo-url>
cd go-deploy
```

### 2. Initialize Go Module

```bash
go mod init go-deploy
go mod tidy
```

### 3. Install Dependencies

The program will automatically download the following dependencies:

- `github.com/pkg/sftp` - SFTP client
- `golang.org/x/crypto/ssh` - SSH client

## Configuration Instructions

The program supports two configuration methods:

### 1. Using Configuration File (Recommended)

Copy `config.example.json` to `config.json` and modify the configuration:

```bash
cp config.example.json config.json
```

Then edit `config.json`:

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

#### Configuration Item Descriptions

**server configuration**:

- `host`: SSH server address
- `port`: SSH port, usually 22
- `username`: SSH username
- `password`: SSH password (for production, it is recommended to use key authentication)
- `timeout`: Connection timeout (seconds)

**paths configuration**:

- `local`: Local directory path, supports both relative and absolute paths
- `remote`: Remote directory path, must be an absolute path

**options configuration**:

- `backup`: Whether to create a backup of existing remote files before uploading
- `backup_suffix`: Backup file suffix, can be customized; if the backup file does not exist, skip backup
- `exclude_patterns`: File exclusion patterns, supports wildcards
- `max_retries`: Maximum number of retries when upload fails
- `chunk_size`: File transfer chunk size (bytes, not yet implemented)

### 2. Default Configuration (Compatibility Mode)

If there is no `config.json` file, the program will use the built-in default configuration to maintain backward compatibility.

#### Configuration File Priority

1. **Configuration file specified by command line**: File specified with the `--config` parameter
2. **Default configuration file**: `config.json` in the current directory
3. **Built-in default configuration**: If neither exists, use the built-in configuration

#### Path Handling Rules

- **Configuration file path**:

  - Relative path: Based on the executable's directory
  - Absolute path: Use the specified path directly
- **Local directory path**:

  - Relative path: Based on the executable's directory
  - Absolute path: Use the specified path directly

## Usage Instructions

### Command Line Parameters

The program supports the following command line parameters:

```bash
# Display help information
./deploy --help

# Display version information  
./deploy --version

# Use the default configuration file config.json
./deploy

# Use a specified configuration file
./deploy --config prod.json

# Use an absolute path configuration file
./deploy --config /path/to/config.json
```

### Running in Development Environment

```bash
# Use default configuration
go run main.go

# Use specified configuration file
go run main.go --config test.json

# Display help
go run main.go --help
```

### Running After Compilation

```bash
# Compile
go build -o deploy main.go

# Run with default configuration
./deploy

# Run with specified configuration file
./deploy --config prod.json
```

## Packaging Instructions

### 1. Local Platform Packaging

```bash
# Compile executable for the current platform
go build -o deploy main.go
```

### 2. Cross-Platform Packaging

#### Linux 64-bit

```bash
GOOS=linux GOARCH=amd64 go build -o deploy-linux-amd64 main.go
```

#### Windows 64-bit
```bash
GOOS=windows GOARCH=amd64 go build -o deploy-windows-amd64.exe main.go
```

#### macOS 64-bit

```bash
GOOS=darwin GOARCH=amd64 go build -o deploy-darwin-amd64 main.go
```

#### macOS ARM64 (M1/M2)

```bash
GOOS=darwin GOARCH=arm64 go build -o deploy-darwin-arm64 main.go
```

### 3. Optimized Packaging (Reducing File Size)

```bash
# Remove debug info and symbol table
go build -ldflags="-s -w" -o deploy main.go

# Compress with UPX (need to install UPX first)
upx --best deploy
```

### 4. Batch Packaging Script

Create a `build.sh` script:

```bash
#!/bin/bash

# Create build directory
mkdir -p builds

# Build versions for each platform
echo "Building Linux 64-bit version..."
GOOS=linux GOARCH=amd64 go build -ldflags="-s -w" -o builds/deploy-linux-amd64 main.go

echo "Building Windows 64-bit version..."
GOOS=windows GOARCH=amd64 go build -ldflags="-s -w" -o builds/deploy-windows-amd64.exe main.go

echo "Building macOS 64-bit version..."
GOOS=darwin GOARCH=amd64 go build -ldflags="-s -w" -o builds/deploy-darwin-amd64 main.go

echo "Building macOS ARM64 version..."
GOOS=darwin GOARCH=arm64 go build -ldflags="-s -w" -o builds/deploy-darwin-arm64 main.go

echo "Build completed!"
ls -la builds/
```

Run the script:

```bash
chmod +x build.sh
./build.sh
```

## Usage Example

### Show Help Information

```bash
$ ./deploy --help
Go-Deploy Deployment Tool

Usage: ./deploy [options]

Options:
  -config string
        Path to config file (default "config.json")
  -help
        Show help information
  -version
        Show version information

Examples:
  ./deploy                           # Use default config file config.json
  ./deploy --config prod.json        # Use the specified config file
  ./deploy --config /path/to/config.json  # Use absolute path to config file
```

### Use a Specific Config File

```bash
$ ./deploy --config prod.json
Starting deployment program...
Trying to read config file: /path/to/go-deploy/prod.json
Using config file...
Local directory /path/to/project/dist exists
Connecting to SSH server...
SSH server connection successful
...
```

### Using the Config File

```bash
$ ./deploy
Starting deployment program...
Trying to read config file: /path/to/go-deploy/config.json
Using config file...
Local directory /path/to/project/unpackage/dist/build/web exists
Connecting to SSH server...
SSH server connection successful
Creating SFTP client...
SFTP client created successfully
Preparing to upload to remote directory: /opt/xsoft/nginx/html/app/dist
Starting directory upload...
Traversing local directory: /path/to/project/unpackage/dist/build/web
Creating directory: /opt/xsoft/nginx/html/app/dist
File static/js/app.js.map excluded, skipping upload
Creating backup: /opt/xsoft/nginx/html/app/dist/index.html -> /opt/xsoft/nginx/html/app/dist/index.html.backup
Uploading file: /path/to/project/unpackage/dist/build/web/index.html -> /opt/xsoft/nginx/html/app/dist/index.html
File .DS_Store excluded, skipping upload
Uploading file: /path/to/project/unpackage/dist/build/web/static/css/app.css -> /opt/xsoft/nginx/html/app/dist/static/css/app.css
Upload failed (attempt 1/3): network error
Retrying file upload (2/3): /path/to/project/unpackage/dist/build/web/static/js/app.js
Uploading file: /path/to/project/unpackage/dist/build/web/static/js/app.js -> /opt/xsoft/nginx/html/app/dist/static/js/app.js
...
Directory uploaded successfully!
Statistics:
  - Number of files uploaded: 485
  - Number of directories created: 18
  - Transfer size: 25.8 MB
  - Upload time: 38.5s
  - Total time: 39.2s
  - Transfer speed: 0.67 MB/s
```

## Notes

1. **Security**:

   - For production environments, it is recommended to use SSH key authentication instead of password authentication
   - Currently using `ssh.InsecureIgnoreHostKey()`, production should verify host keys
2. **Network**:

   - Ensure local machine can access port 22 of the target server
   - Transfer speed depends on network bandwidth and server performance
3. **Permissions**:

   - Make sure the SSH user has write permissions to the target directory
   - If needed, sudo permissions may be required
4. **Paths**:

   - Local paths are automatically calculated based on the executable location, no need to care about the execution directory
   - Remote paths use absolute paths

## Troubleshooting

### Common Issues

1. **Connection Timeout**

   ```
   Failed to connect to SSH server: dial tcp: i/o timeout
   ```

   - Check server address and port
   - Verify network connectivity
   - Check firewall settings
2. **Authentication Failure**

   ```
   Login failed: ssh: handshake failed
   ```

   - Check username and password
   - Verify SSH service is running
   - Check SSH configuration
3. **Permission Error**

   ```
   Failed to create directory: permission denied
   ```

   - Check if user has write permissions to the target directory
   - May need to use sudo or change directory ownership
4. **Local Directory Does Not Exist**

   ```
   Error: Local directory /path/to/unpackage/dist/build/web does not exist
   ```

   - Make sure local build is complete
   - Check if project directory structure is correct
   - The program automatically calculates the path, no need to manually change the working directory

## Development Notes

### Project Structure

```
go-deploy/
├── main.go                 # Main program file
├── go.mod                  # Go module file  
├── go.sum                  # Dependency checksum file
```
├── README.md               # Detailed documentation
├── Makefile                # Build tool
├── build.sh                # Batch packaging script
├── install.sh              # One-click installation script
└── config.example.json     # Example configuration file
```

### Main Functions

- `main()` - Main function, handles connection and calls upload
- `uploadDirectory()` - Recursively uploads directories
- `uploadFile()` - Uploads a single file
- `mkdirAll()` - Recursively creates remote directories

## License

MIT License

## Contribution

Issues and Pull Requests are welcome!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---