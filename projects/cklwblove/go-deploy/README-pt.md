# Go-Deploy Ferramenta de Deploy

Uma ferramenta de deploy automatizado desenvolvida em Go, que suporta o upload dos artefatos de build locais para servidores remotos via protocolo SFTP.

## Funcionalidades

- ✅ **Transmissão segura**: Utiliza o protocolo SFTP, com transferência criptografada baseada em SSH
- ✅ **Sincronização de diretórios**: Upload recursivo de toda a estrutura de diretórios, mantendo a hierarquia dos arquivos
- ✅ **Criação inteligente**: Criação automática da estrutura de diretórios remota
- ✅ **Adaptação de caminho**: Calcula automaticamente o caminho local com base na localização do executável, sem necessidade de se preocupar com o diretório de execução
- ✅ **Suporte a arquivo de configuração**: Suporta arquivos de configuração JSON, facilitando o gerenciamento de configurações para diferentes ambientes
- ✅ **Exclusão de arquivos**: Suporta padrões com curingas para excluir arquivos que não precisam ser enviados
- ✅ **Backup automático**: Pode realizar backup automático dos arquivos remotos antes do upload
- ✅ **Mecanismo de retentativa**: Tenta o upload novamente automaticamente em caso de falha, aumentando a taxa de sucesso
- ✅ **Estatísticas detalhadas**: Exibe número de arquivos enviados, tamanho transferido, tempo gasto e velocidade
- ✅ **Exibição de progresso**: Mostra o progresso do upload e informações dos arquivos em tempo real
- ✅ **Tratamento de erros**: Tratamento de erros completo e saída de logs

## Requisitos do Sistema

- Go 1.18 ou superior
- O servidor de destino deve suportar o protocolo SSH/SFTP

## Instruções de Instalação

### 1. Clonar o projeto

```bash
git clone <your-repo-url>
cd go-deploy
```

### 2. Inicializar o módulo Go

```bash
go mod init go-deploy
go mod tidy
```

### 3. Instalar dependências

O programa irá baixar automaticamente as seguintes dependências:

- `github.com/pkg/sftp` - Cliente SFTP
- `golang.org/x/crypto/ssh` - Cliente SSH

## Instruções de Configuração

O programa suporta dois modos de configuração:

### 1. Usando arquivo de configuração (recomendado)

Copie `config.example.json` para `config.json` e edite as configurações:

```bash
cp config.example.json config.json
```

Em seguida, edite `config.json`:

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

#### Explicação dos parâmetros de configuração

**Configuração do server**:

- `host`: Endereço do servidor SSH
- `port`: Porta SSH, normalmente 22
- `username`: Usuário SSH
- `password`: Senha SSH (em produção recomenda-se autenticação por chave)
- `timeout`: Tempo limite de conexão (segundos)

**Configuração de paths**:

- `local`: Caminho do diretório local, suporta caminhos relativos e absolutos
- `remote`: Caminho do diretório remoto, deve ser um caminho absoluto

**Configuração de options**:

- `backup`: Se deve criar um backup dos arquivos remotos existentes antes do upload
- `backup_suffix`: Sufixo do arquivo de backup, pode ser personalizado; se o arquivo de backup não existir, o backup é ignorado
- `exclude_patterns`: Padrões de exclusão de arquivos, suporta curingas
- `max_retries`: Número máximo de tentativas de upload em caso de falha
- `chunk_size`: Tamanho do bloco de transferência de arquivos (bytes, ainda não implementado)

### 2. Configuração padrão (modo compatibilidade)

Se não houver o arquivo `config.json`, o programa usará a configuração padrão interna, mantendo a compatibilidade retroativa.

#### Prioridade dos arquivos de configuração

1. **Arquivo especificado via linha de comando**: Arquivo indicado pelo parâmetro `--config`
2. **Arquivo de configuração padrão**: `config.json` no diretório atual
3. **Configuração padrão embutida**: Caso nenhum dos anteriores exista, usa a configuração interna do programa

#### Regras de tratamento de caminhos

- **Caminho do arquivo de configuração**:

  - Caminho relativo: Baseado no diretório onde está o executável
  - Caminho absoluto: Usa o caminho especificado diretamente
- **Caminho do diretório local**:

  - Caminho relativo: Baseado no diretório onde está o executável
  - Caminho absoluto: Usa o caminho especificado diretamente

## Instruções de Execução

### Parâmetros de linha de comando

O programa suporta os seguintes parâmetros de linha de comando:

```bash
# Exibir informações de ajuda
./deploy --help

# Exibir informações da versão  
./deploy --version

# Usar o arquivo de configuração padrão config.json
./deploy

# Usar arquivo de configuração especificado
./deploy --config prod.json

# Usar arquivo de configuração com caminho absoluto
./deploy --config /path/to/config.json
```

### Execução em ambiente de desenvolvimento

```bash
# Usar configuração padrão
go run main.go

# Usar arquivo de configuração especificado
go run main.go --config test.json

# Exibir ajuda
go run main.go --help
```

### Execução após compilação

```bash
# Compilar
go build -o deploy main.go

# Executar com configuração padrão
./deploy

# Executar com arquivo de configuração especificado
./deploy --config prod.json
```

## Instruções de Empacotamento

### 1. Empacotamento para plataforma local

```bash
# Compilar executável para a plataforma atual
go build -o deploy main.go
```

### 2. Empacotamento multiplataforma

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

### 3. Otimização do empacotamento (reduzir o tamanho do arquivo)

```bash
# Remover informações de debug e tabela de símbolos
go build -ldflags="-s -w" -o deploy main.go

# Comprimir usando UPX (necessário instalar o UPX antes)
upx --best deploy
```

### 4. Script de empacotamento em lote

Crie o script `build.sh`:

```bash
#!/bin/bash

# Criar diretório de build
mkdir -p builds

# Compilar versões para cada plataforma
echo "Compilando versão Linux 64 bits..."
GOOS=linux GOARCH=amd64 go build -ldflags="-s -w" -o builds/deploy-linux-amd64 main.go

echo "Compilando versão Windows 64 bits..."
GOOS=windows GOARCH=amd64 go build -ldflags="-s -w" -o builds/deploy-windows-amd64.exe main.go

echo "Compilando versão macOS 64 bits..."
GOOS=darwin GOARCH=amd64 go build -ldflags="-s -w" -o builds/deploy-darwin-amd64 main.go

echo "Compilando versão macOS ARM64..."
GOOS=darwin GOARCH=arm64 go build -ldflags="-s -w" -o builds/deploy-darwin-arm64 main.go

echo "Compilação concluída!"
ls -la builds/
```

Execute o script:

```bash
chmod +x build.sh
./build.sh
```

## Exemplos de Uso

### Exibir informações de ajuda

```bash
$ ./deploy --help
Go-Deploy Ferramenta de Deploy

Uso: ./deploy [opções]

Opções:
  -config string
        Caminho do arquivo de configuração (padrão "config.json")
  -help
        Exibir informações de ajuda
  -version
        Exibir informações de versão

Exemplos:
  ./deploy                           # Usar arquivo de configuração padrão config.json
  ./deploy --config prod.json        # Usar arquivo de configuração especificado
  ./deploy --config /path/to/config.json  # Usar caminho absoluto para o arquivo de configuração
```

### Usar arquivo de configuração especificado

```bash
$ ./deploy --config prod.json
Iniciando execução do programa de deploy...
Tentando ler o arquivo de configuração: /path/to/go-deploy/prod.json
Usando arquivo de configuração...
Diretório local /path/to/project/dist existe
Conectando ao servidor SSH...
Conexão ao servidor SSH bem-sucedida
...
```

### Usar arquivo de configuração

```bash
$ ./deploy
Iniciando execução do programa de deploy...
Tentando ler o arquivo de configuração: /path/to/go-deploy/config.json
Usando arquivo de configuração...
Diretório local /path/to/project/unpackage/dist/build/web existe
Conectando ao servidor SSH...
Conexão ao servidor SSH bem-sucedida
Criando cliente SFTP...
Cliente SFTP criado com sucesso
Preparando upload para o diretório remoto: /opt/xsoft/nginx/html/app/dist
Iniciando upload do diretório...
Percorrendo diretório local: /path/to/project/unpackage/dist/build/web
Criando diretório: /opt/xsoft/nginx/html/app/dist
Arquivo static/js/app.js.map foi excluído, pulando upload
Criando backup: /opt/xsoft/nginx/html/app/dist/index.html -> /opt/xsoft/nginx/html/app/dist/index.html.backup
Enviando arquivo: /path/to/project/unpackage/dist/build/web/index.html -> /opt/xsoft/nginx/html/app/dist/index.html
Arquivo .DS_Store foi excluído, pulando upload
Enviando arquivo: /path/to/project/unpackage/dist/build/web/static/css/app.css -> /opt/xsoft/nginx/html/app/dist/static/css/app.css
Falha no upload (tentativa 1/3): erro de rede
Tentando novamente upload do arquivo (2/3): /path/to/project/unpackage/dist/build/web/static/js/app.js
Enviando arquivo: /path/to/project/unpackage/dist/build/web/static/js/app.js -> /opt/xsoft/nginx/html/app/dist/static/js/app.js
...
Upload do diretório realizado com sucesso!
Estatísticas:
  - Número de arquivos enviados: 485
  - Número de diretórios criados: 18
  - Tamanho transferido: 25,8 MB
  - Tempo de upload: 38,5s
  - Tempo total: 39,2s
  - Velocidade de transferência: 0,67 MB/s
```

## Observações

1. **Segurança**:

   - Em ambientes de produção, recomenda-se autenticação por chave SSH ao invés de senha
   - Atualmente usa-se `ssh.InsecureIgnoreHostKey()`, em produção deve-se validar a chave do host
2. **Rede**:

   - Certifique-se de que sua máquina pode acessar a porta 22 do servidor de destino
   - A velocidade de transferência depende da largura de banda e do desempenho do servidor
3. **Permissões**:

   - Certifique-se de que o usuário SSH tenha permissão de escrita no diretório de destino
   - Se necessário, pode ser preciso usar permissões sudo
4. **Caminhos**:

   - O caminho local é calculado automaticamente com base na localização do executável, não é necessário se preocupar com o diretório de execução
   - O caminho remoto deve ser absoluto

## Solução de Problemas

### Problemas Comuns

1. **Tempo limite de conexão**

   ```
   Falha ao conectar ao servidor SSH: dial tcp: i/o timeout
   ```

   - Verifique o endereço e a porta do servidor
   - Confirme a conectividade da rede
   - Cheque as configurações do firewall
2. **Falha de autenticação**

   ```
   Falha no login: ssh: handshake failed
   ```

   - Verifique o nome de usuário e senha
   - Confirme que o serviço SSH está ativo
   - Cheque as configurações do SSH
3. **Erro de permissão**

   ```
   Falha ao criar diretório: permission denied
   ```

   - Verifique se o usuário tem permissão de escrita no diretório de destino
   - Pode ser necessário usar sudo ou alterar o proprietário do diretório
4. **Diretório local inexistente**

   ```
   Erro: Diretório local /path/to/unpackage/dist/build/web não existe
   ```

   - Confirme se o build local foi concluído
   - Verifique se a estrutura de diretórios do projeto está correta
   - O programa calcula o caminho automaticamente, não é necessário ajustar manualmente o diretório de trabalho

## Notas de Desenvolvimento

### Estrutura do Projeto

```
go-deploy/
├── main.go                 # Arquivo principal do programa
├── go.mod                  # Arquivo de módulo Go  
├── go.sum                  # Arquivo de verificação de dependências
```
├── README.md               # Documento de explicação detalhada  
├── Makefile                # Ferramenta de construção  
├── build.sh                # Script de empacotamento em lote  
├── install.sh              # Script de instalação automática  
└── config.example.json     # Exemplo de arquivo de configuração  
```

### Funções principais

- `main()` - Função principal, lida com a conexão e chama o upload
- `uploadDirectory()` - Faz upload recursivo de diretórios
- `uploadFile()` - Faz upload de um único arquivo
- `mkdirAll()` - Cria diretórios remotos recursivamente

## Licença

Licença MIT

## Contribuição

Contribuições via Issue e Pull Request são bem-vindas!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---