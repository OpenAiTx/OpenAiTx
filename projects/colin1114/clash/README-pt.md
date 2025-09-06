
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=it">Itapano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>
</div>

A aceleração CDN e a proteção de segurança para este projeto são patrocinadas pela Tencent EdgeOne.

[![image](https://github.com/user-attachments/assets/059fed87-d415-41b0-a575-2423bf2d77e2)](https://edgeone.ai/?from=github)

O autor deste projeto é colin1114.

# 🚀 Conversor de Assinaturas Clash

Uma ferramenta online bonita e poderosa para converter diversos links de assinatura de proxy para o formato de configuração Clash. Suporta implantação automática via Cloudflare Workers & Pages, oferecendo um serviço rápido e confiável de conversão de assinaturas.

## ✨ Características

- 🎨 **Interface moderna e atraente** - Utiliza fundo em gradiente e design em cartões
- 🔄 **Suporte a múltiplos protocolos** - Compatível com V2Ray, VLESS, Shadowsocks, Trojan e outros protocolos populares
- ☁️ **Implantação em nuvem** - Aceleração global via CDN com Cloudflare Workers
- 📱 **Design responsivo** - Adaptação perfeita para desktop e dispositivos móveis
- ⚡ **Conversão rápida** - Converte links de assinatura em configurações Clash em tempo real
- 📋 **Cópia inteligente** - Suporte para copiar configurações YAML geradas com um clique, compatível com vários navegadores
- 📡 **Geração de links de assinatura** - Gera automaticamente links de assinatura para importação direta no Clash
- 🌐 **Acesso online ao YAML** - Disponibiliza várias formas de acesso ao arquivo YAML:
  - 📡 Link de assinatura: compatível com atualização automática do Clash
  - 🔗 Visualização online: ver conteúdo da configuração diretamente no navegador
  - 💾 Download de arquivo: baixar arquivo .yaml para o dispositivo local
  - ⚡ Acesso rápido: link de download simplificado
- 🔧 **Suporte UTF-8** - Suporte total para nomes de nós e configurações em chinês
- 🆓 **Totalmente gratuito** - Baseado no serviço gratuito do Cloudflare, sem restrições de uso

## 📁 Estrutura do projeto

```
clash/
├── index.html              # 前端页面
├── worker.js               # Cloudflare Worker 后端代码
├── wrangler.jsonc          # Wrangler 配置文件
├── _headers                # Cloudflare Pages HTTP头配置
├── .github/
│   └── workflows/
│       └── deploy.yml      # GitHub Actions 部署配置
├── README.md              # 项目说明文档
└── package.json           # 项目配置文件
```

## 🚀 Início Rápido

### Método 1: Execução Local

1. **Clone o projeto**
   ```bash
   git clone <repository-url>
   cd clash
   ```
2. **Inicie o servidor local**

   ```bash
   # 使用 Python
   python -m http.server 8000
   
   # 或使用 Node.js
   npx serve .
   ```

3. **Acessar o aplicativo**
   - Abra o navegador e acesse `http://localhost:8000`
   - No ambiente local será exibida a configuração de exemplo

### Método 2: Implantação com Cloudflare Workers

#### Etapa 1: Criar Worker

1. Acesse [Cloudflare Workers](https://workers.cloudflare.com/)
2. Cadastre-se/entre na sua conta Cloudflare
3. Clique em "Create a Worker"
4. Copie todo o código de `worker.js` para o editor
5. Clique em "Save and Deploy"

#### Etapa 2: Implantar usando Wrangler CLI

```bash
# 安装 Wrangler CLI
npm install -g wrangler

# 登录到 Cloudflare
wrangler login

# 部署 Worker
npm run deploy:worker
```

#### Etapa 3: Configurar domínio (opcional)

1. Adicione um domínio personalizado nas configurações do Worker
2. Ou utilize o domínio padrão fornecido pela Cloudflare

### Método 3: Implantação via Cloudflare Pages

#### Opção A: Integração com GitHub (recomendado)

1. **Preparar o repositório**
   - Envie o código para o repositório do GitHub
   - Certifique-se de incluir todos os arquivos necessários

2. **Criar projeto Pages**
   - Acesse [Cloudflare Pages](https://pages.cloudflare.com/)
   - Conecte seu repositório do GitHub
   - Selecione o repositório do projeto

3. **Configurações de build**
   - Comando de build: deixe em branco ou `echo "No build required"`
   - Diretório de saída de build: `/` (diretório raiz)
   - Variáveis de ambiente: não é necessário configurar

#### Opção B: Upload direto

```bash
# 使用 Wrangler Pages 部署
npm run deploy:pages
```

## 🛠️ Arquitetura Técnica

### Stack de Tecnologias Frontend
- **HTML5** - Linguagem de marcação moderna
- **CSS3** - Design responsivo e efeitos de animação
- **JavaScript Puro** - Interações leves no frontend

### Stack de Tecnologias Backend
- **Cloudflare Workers** - Plataforma de computação de borda
- **Web APIs** - API padrão Fetch e processamento de respostas

### Protocolos Suportados
- **VMess** - Protocolo padrão V2Ray
- **VLESS** - Protocolo leve V2Ray (suporta Reality)
- **Shadowsocks** - Protocolo clássico de proxy
- **Trojan** - Protocolo proxy emergente

### Endpoints de API
- `GET /` - Página principal
- `POST /convert` - API de conversão de assinatura
- `GET /clash/{config-id}` - Obter arquivo de configuração YAML (link de assinatura)
- `GET /yaml/{config-id}` - Baixar arquivo de configuração YAML
- `OPTIONS /*` - Solicitação de pré-verificação CORS

## 📖 Guia de Uso

### Uso Básico

1. **Inserir link de assinatura**
   - Cole seu link de assinatura de proxy na caixa de entrada
   - Suporta links de assinatura codificados em Base64

2. **Definir nome da configuração**
   - Opcionalmente defina um nome personalizado para o arquivo de configuração
   - O padrão é "Minha Configuração Clash"

3. **Converter configuração**
   - Clique no botão "Converter Assinatura"
   - Aguarde a conclusão da conversão
4. **Usando a configuração**
   - Copie a configuração YAML gerada
   - Importe no cliente Clash para usar

5. **Usando o link de assinatura (recomendado)**
   - Copie o link de assinatura gerado
   - Adicione a assinatura no cliente Clash
   - A configuração será sincronizada automaticamente, sem necessidade de atualização manual

### Configuração avançada

A configuração gerada do Clash inclui as seguintes características:

- **Política de grupo de proxy**
  - 🚀 Seleção de nó - seleção manual de proxy
  - ♻️ Seleção automática - teste de latência e seleção automática
  - 🎯 Conexão direta global - conexão direta

- **Configuração de DNS**
  - Habilitar resolução DNS
  - Suporte ao modo fake-ip
  - Separação de DNS nacional e internacional

- **Regras de roteamento**
  - Endereços locais conectam diretamente
  - IPs nacionais conectam diretamente
  - Outro tráfego passa pelo proxy

## 🔧 Solução de problemas de implantação

### Problemas comuns

#### 1. Wrangler não encontra o ponto de entrada
**Mensagem de erro**: `Missing entry-point to Worker script`

**Solução**: 
- Certifique-se de que há um arquivo `wrangler.jsonc` no diretório raiz do projeto
- Verifique se o campo `main` em `wrangler.jsonc` aponta para `worker.js`


#### 2. Falha na implantação do GitHub Actions
**Solução**:
- Adicione os seguintes Secrets nas configurações do repositório GitHub:
  - `CLOUDFLARE_API_TOKEN`: Token da API do Cloudflare
  - `CLOUDFLARE_ACCOUNT_ID`: ID da conta Cloudflare

#### 3. Falha na construção do Pages
**Solução**:
- Defina o comando de construção como vazio ou `echo "No build required"`
- Certifique-se de que o diretório de saída da construção esteja definido como `/`

### Explicação dos arquivos de configuração de implantação

- **`wrangler.jsonc`**: Configuração do Wrangler CLI, usada para implantação do Worker
- **`_headers`**: Configuração de cabeçalhos HTTP do Cloudflare Pages
- **`.github/workflows/deploy.yml`**: Configuração de implantação automática do GitHub Actions

## 🔧 Configuração personalizada

### Modificar grupo de proxy

Você pode editar a função `convertToClash` em `worker.js` para personalizar grupos de proxy:

```javascript
'proxy-groups': [
  {
    name: '🚀 节点选择',
    type: 'select',
    proxies: ['♻️ 自动选择', '🎯 全球直连', ...proxyNames]
  },
  // 添加更多代理组...
]
```

### Regras de Roteamento Personalizadas

Modifique o array `rules` para adicionar regras de roteamento personalizadas:

```javascript
rules: [
  'DOMAIN-SUFFIX,youtube.com,🚀 节点选择',
  'DOMAIN-SUFFIX,local,DIRECT',
  // 添加更多规则...
]
```

## 📊 Características de Desempenho

- **CDN Global** - Cloudflare com pontos de presença em todo o mundo
- **Resposta Rápida** - Tempo médio de resposta < 100ms
- **Alta Disponibilidade** - 99,9% de disponibilidade do serviço
- **Cota Gratuita** - 100.000 requisições por dia

## 🔒 Informações de Segurança

- **Privacidade de Dados** - Dados de assinatura usados apenas durante a conversão, não são armazenados
- **Criptografia HTTPS** - Todas as comunicações são criptografadas via HTTPS
- **Transparência Open Source** - Código-fonte completo disponível para revisão

## 🤝 Guia de Contribuição

Contribuições via Issue e Pull Request são bem-vindas!

1. Faça um Fork deste repositório
2. Crie um branch de funcionalidade (`git checkout -b feature/AmazingFeature`)
3. Envie as alterações (`git commit -m 'Add some AmazingFeature'`)
4. Faça push para o branch (`git push origin feature/AmazingFeature`)
5. Abra um Pull Request

## 📝 Registro de Atualizações

### v1.1.0
- ✅ Suporte ao protocolo VLESS (incluindo transmissão segura Reality)
- ✅ Compatibilidade de protocolo aprimorada

### v1.0.0
- ✅ Conversão básica de assinaturas
- ✅ Interface de usuário atraente
- ✅ Suporte ao Cloudflare Workers
- ✅ Suporte a múltiplos protocolos (VMess, Shadowsocks, Trojan)
- ✅ Design responsivo
- ✅ Função de cópia em um clique

## 📞 Suporte e Feedback

Se você encontrar problemas ou tiver sugestões durante o uso, por favor:

1. Consulte este documento README
2. Envie um [Issue](../../issues)
3. Inicie uma [Discussion](../../discussions)

## 📄 Licença

Este projeto utiliza a licença MIT - consulte o arquivo [LICENSE](LICENSE) para mais detalhes

## 🙏 Agradecimentos

- [Cloudflare Workers](https://workers.cloudflare.com/) - Plataforma de computação de borda
- [Clash](https://github.com/Dreamacro/clash) - Excelente cliente de proxy
- Apoio de todos os colaboradores e usuários

---

⭐ Se este projeto foi útil para você, por favor, deixe uma estrela! 


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-06

---