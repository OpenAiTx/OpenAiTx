A aceleração de CDN e a proteção de segurança para este projeto são patrocinadas pela Tencent EdgeOne.

[![image](https://github.com/user-attachments/assets/059fed87-d415-41b0-a575-2423bf2d77e2)](https://edgeone.ai/?from=github)

O autor deste projeto é colin1114.

# 🚀 Conversor de Assinaturas Clash

Uma ferramenta online bonita e poderosa, usada para converter vários links de assinaturas de proxy para o formato de configuração do Clash. Suporta implantação automática via Cloudflare Workers & Pages, oferecendo um serviço de conversão de assinaturas rápido e confiável.

## ✨ Funcionalidades

- 🎨 **Interface moderna e bonita** - Utiliza fundo em gradiente e design em cartões
- 🔄 **Suporte a múltiplos protocolos** - Suporta protocolos populares como V2Ray, VLESS, Shadowsocks, Trojan, entre outros
- ☁️ **Implantação em nuvem** - Aceleração global de CDN via Cloudflare Workers
- 📱 **Design responsivo** - Perfeita adaptação para desktop e dispositivos móveis
- ⚡ **Conversão rápida** - Converte links de assinatura em tempo real para configuração Clash
- 📋 **Cópia inteligente** - Suporta cópia em um clique do YAML gerado, compatível com diversos navegadores
- 📡 **Geração de links de assinatura** - Gera automaticamente links de assinatura prontos para importar no Clash
- 🌐 **Acesso online ao YAML** - Oferece várias formas de acessar arquivos YAML:
  - 📡 Link de assinatura: suporta atualização automática no cliente Clash
  - 🔗 Visualização online: veja o conteúdo da configuração diretamente no navegador
  - 💾 Download de arquivo: baixe o arquivo .yaml localmente
  - ⚡ Acesso rápido: link de download simplificado
- 🔧 **Suporte UTF-8** - Suporte perfeito para nomes de nós e configurações em chinês
- 🆓 **Totalmente gratuito** - Baseado nos serviços gratuitos da Cloudflare, sem restrições de uso

## 📁 Estrutura do Projeto

```
clash/
├── index.html              # Página frontend
├── worker.js               # Código backend do Cloudflare Worker
├── wrangler.jsonc          # Arquivo de configuração do Wrangler
├── _headers                # Configuração de headers HTTP do Cloudflare Pages
├── .github/
│   └── workflows/
│       └── deploy.yml      # Configuração de implantação do GitHub Actions
├── README.md              # Documento de explicação do projeto
└── package.json           # Arquivo de configuração do projeto
```

## 🚀 Início Rápido

### Método 1: Executar localmente

1. **Clone o projeto**
   ```bash
   git clone <repository-url>
   cd clash
   ```

2. **Inicie o servidor local**
   ```bash
   # Usando Python
   python -m http.server 8000
   
   # Ou usando Node.js
   npx serve .
   ```

3. **Acesse o aplicativo**
   - Abra o navegador e acesse `http://localhost:8000`
   - Um exemplo de configuração será exibido no ambiente local

### Método 2: Implantação via Cloudflare Workers

#### Etapa 1: Criar Worker

1. Acesse [Cloudflare Workers](https://workers.cloudflare.com/)
2. Registre-se/Faça login em sua conta Cloudflare
3. Clique em "Create a Worker"
4. Copie todo o código de `worker.js` para o editor
5. Clique em "Save and Deploy"

#### Etapa 2: Implantar usando Wrangler CLI

```bash
# Instale o Wrangler CLI
npm install -g wrangler

# Faça login no Cloudflare
wrangler login

# Implemente o Worker
npm run deploy:worker
```

#### Etapa 3: Configurar domínio (opcional)

1. Adicione um domínio personalizado nas configurações do Worker
2. Ou use o domínio padrão fornecido pela Cloudflare

### Método 3: Implantação via Cloudflare Pages

#### Opção A: Integração com GitHub (recomendado)

1. **Prepare o repositório**
   - Envie o código para o repositório do GitHub
   - Certifique-se de incluir todos os arquivos necessários
2. **Criar o projeto Pages**
   - Acesse [Cloudflare Pages](https://pages.cloudflare.com/)
   - Conecte seu repositório GitHub
   - Selecione o repositório do projeto

3. **Configurações de build**
   - Comando de build: deixe em branco ou `echo "No build required"`
   - Diretório de saída do build: `/` (diretório raiz)
   - Variáveis de ambiente: não é necessário configurar

#### Opção B: Upload direto

```bash
# Implantação com Wrangler Pages
npm run deploy:pages
```

## 🛠️ Arquitetura Técnica

### Stack de tecnologias front-end
- **HTML5** - Linguagem de marcação moderna
- **CSS3** - Design responsivo e efeitos de animação
- **Vanilla JavaScript** - Interação front-end leve

### Stack de tecnologias back-end
- **Cloudflare Workers** - Plataforma de computação de borda
- **Web APIs** - API Fetch padrão e tratamento de respostas

### Protocolos suportados
- **VMess** - Protocolo padrão V2Ray
- **VLESS** - Protocolo leve V2Ray (suporta Reality)
- **Shadowsocks** - Protocolo de proxy clássico
- **Trojan** - Novo protocolo de proxy

### Endpoints da API
- `GET /` - Página principal
- `POST /convert` - API de conversão de assinatura
- `GET /clash/{config-id}` - Obter arquivo de configuração YAML (link de assinatura)
- `GET /yaml/{config-id}` - Baixar arquivo de configuração YAML
- `OPTIONS /*` - Solicitações de pré-verificação CORS

## 📖 Guia de Uso

### Uso Básico

1. **Insira o link da assinatura**
   - Cole seu link de assinatura de proxy na caixa de entrada
   - Suporta links de assinatura codificados em Base64

2. **Defina o nome da configuração**
   - Opcionalmente, defina um nome personalizado para o arquivo de configuração
   - Padrão: "My Clash Config"

3. **Converter configuração**
   - Clique no botão "Converter assinatura"
   - Aguarde a conclusão da conversão

4. **Usar configuração**
   - Copie a configuração YAML gerada
   - Importe para o cliente Clash

5. **Usar link de assinatura (recomendado)**
   - Copie o link de assinatura gerado
   - Adicione a assinatura no cliente Clash
   - A configuração será sincronizada automaticamente, sem necessidade de atualização manual

### Configuração avançada

A configuração Clash gerada inclui os seguintes recursos:

- **Políticas de grupo de proxy**
  - 🚀 Seleção de nó - escolha manual do proxy
  - ♻️ Seleção automática - seleção automática baseada em teste de latência
  - 🎯 Conexão direta global - conexão direta

- **Configuração de DNS**
  - DNS ativado
  - Suporte ao modo fake-ip
  - Divisão de DNS nacional/internacional

- **Regras de roteamento**
  - Endereços locais conectados diretamente
  - IPs nacionais conectados diretamente
  - O restante do tráfego passa pelo proxy

## 🔧 Solução de Problemas de Deploy

### Problemas Comuns

#### 1. Wrangler não encontra o ponto de entrada
**Mensagem de erro**: `Missing entry-point to Worker script`

**Solução**: 
- Certifique-se de que há um arquivo `wrangler.jsonc` no diretório raiz do projeto
- Verifique se o campo `main` em `wrangler.jsonc` aponta para `worker.js`

#### 2. Falha no deploy pelo GitHub Actions
**Solução**:
- Adicione os seguintes Secrets nas configurações do repositório GitHub:
- `CLOUDFLARE_API_TOKEN`: Token da API do Cloudflare  
- `CLOUDFLARE_ACCOUNT_ID`: ID da Conta Cloudflare

#### 3. Falha na construção do Pages
**Soluções**:
- Defina o comando de construção como vazio ou `echo "No build required"`
- Certifique-se de que o diretório de saída da construção esteja definido como `/`

### Explicação dos arquivos de configuração de implantação

- **`wrangler.jsonc`**: Configuração do Wrangler CLI, usada para implantação de Worker
- **`_headers`**: Configuração de cabeçalhos HTTP do Cloudflare Pages
- **`.github/workflows/deploy.yml`**: Configuração de implantação automática do GitHub Actions

## 🔧 Configuração personalizada

### Modificar grupos de proxy

Você pode editar a função `convertToClash` em `worker.js` para personalizar os grupos de proxy:

```javascript
'proxy-groups': [
  {
    name: '🚀 Seleção de Nó',
    type: 'select',
    proxies: ['♻️ Seleção Automática', '🎯 Conexão Direta Global', ...proxyNames]
  },
  // Adicione mais grupos de proxy...
]
```

### Regras de roteamento personalizadas

Modifique o array `rules` para adicionar regras de roteamento personalizadas:

```javascript
rules: [
  'DOMAIN-SUFFIX,youtube.com,🚀 Seleção de Nó',
  'DOMAIN-SUFFIX,local,DIRECT',
  // Adicione mais regras...
]
```

## 📊 Características de desempenho

- **CDN global** - Cloudflare cobre nós de borda em todo o mundo
- **Resposta rápida** - Tempo médio de resposta < 100ms
- **Alta disponibilidade** - 99,9% de disponibilidade do serviço
- **Cota gratuita** - 100.000 requisições diárias

## 🔒 Informações de segurança

- **Privacidade de dados** - Os dados da assinatura são usados apenas durante a conversão e não são armazenados
- **Criptografia HTTPS** - Toda comunicação é criptografada via HTTPS
- **Transparência open source** - Código-fonte completo disponível publicamente para auditoria

## 🤝 Guia de contribuição

Contribuições via Issue e Pull Request são bem-vindas!

1. Faça um Fork deste repositório
2. Crie um branch de feature (`git checkout -b feature/AmazingFeature`)
3. Faça commit das alterações (`git commit -m 'Add some AmazingFeature'`)
4. Faça push para o branch (`git push origin feature/AmazingFeature`)
5. Abra um Pull Request

## 📝 Registro de alterações

### v1.1.0
- ✅ Suporte adicionado ao protocolo VLESS (incluindo transmissão segura Reality)
- ✅ Compatibilidade de protocolo aprimorada

### v1.0.0
- ✅ Função básica de conversão de assinatura
- ✅ Interface de usuário bonita
- ✅ Suporte ao Cloudflare Workers
- ✅ Suporte a múltiplos protocolos (VMess, Shadowsocks, Trojan)
- ✅ Design responsivo
- ✅ Função de copiar com um clique

## 📞 Suporte e feedback

Se você encontrar problemas ou tiver sugestões durante o uso, por favor:

1. Consulte este documento README
2. Envie um [Issue](../../issues)
3. Inicie uma [Discussion](../../discussions)

## 📄 Licença

Este projeto utiliza a licença MIT - veja o arquivo [LICENSE](LICENSE) para mais detalhes

## 🙏 Agradecimentos

- [Cloudflare Workers](https://workers.cloudflare.com/) - Plataforma de computação de borda
- [Clash](https://github.com/Dreamacro/clash) - Excelente cliente proxy
- Agradecimentos a todos os colaboradores e usuários

---
⭐ Se este projeto foi útil para você, por favor, deixe uma estrela!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---