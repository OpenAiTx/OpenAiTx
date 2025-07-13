# Terminal de Pagamento NFC

Um terminal de pagamento NFC multi-chain que processa pagamentos em criptomoedas através de 5 redes blockchain com monitoramento de transações em tempo real e rastreamento histórico abrangente.

## 🌐 Redes Suportadas

- **Ethereum**
- **Base**
- **Arbitrum**
- **Optimism**
- **Polygon**

### 🎯 **Prioridade Inteligente de Pagamento**

Em vez de negociar uma combinação de rede/token com o comerciante, o terminal de pagamento lida com isso automaticamente. Primeiro, ele identifica uma rede suportada pelo comerciante na qual você também possui fundos e, em seguida, envia uma transação com ETH ou um token ERC-20 seguindo esta prioridade:

```
Stablecoin em L2 > Outros em L2 > ETH em L2 > Stablecoin em L1 > Outros em L1 > ETH em L1
```
## 🚀 Início Rápido

1. **Instale as dependências:**
   ```bash
   npm install
   ```

2. **Configuração do ambiente:**
   ```bash
   echo "ALCHEMY_API_KEY=your_alchemy_api_key_here" > .env
   ```

3. **Execute o terminal:**
   ```bash
   npm start
   ```

4. **Abra a interface:**
   Navegue até `http://localhost:3000`

## 🏗️ Arquitetura

```
src/
├── server.ts                   # Servidor Express & manipulador WebSocket
├── app.ts                      # Orquestrador principal da aplicação
├── web/index.html              # Interface do terminal de pagamento
├── config/index.ts             # Configuração multi-chain
└── services/
    ├── nfcService.ts           # Leitor NFC & leitura de carteira
    ├── alchemyService.ts       # Saldo multi-chain & monitoramento
    ├── paymentService.ts       # Seleção de pagamento & geração EIP-681
    ├── ethereumService.ts      # Utilitários de validação de endereço
    └── addressProcessor.ts     # Prevenção de processamento duplicado
scripts/
└── rpi-deploy/
    ├── setup-build-environment.sh  # Instala dependências para permitir a construção de uma imagem do Raspberry Pi
    └── build-pi-image-osx.sh       # Constrói uma imagem do Raspberry Pi
```
## 💡 Uso

### **Processamento de Pagamentos**
1. Digite o valor usando o teclado (base em centavos: "150" = R$1,50)
2. Toque em "Cobrar" para iniciar o pagamento
3. O cliente aproxima o dispositivo NFC para enviar o pagamento
4. Monitoramento em tempo real confirma a transação
5. Mensagem "Aprovado" com link para o explorador de blocos

### **Histórico de Transações**
1. Toque no botão 📜 de histórico no teclado
2. Veja todas as transações ou escaneie uma carteira para histórico específico
3. Toque em "📱 Escanear Carteira para Histórico" e peça para o cliente aproximar o dispositivo
4. Navegue pelas transações filtradas para essa carteira específica


## 🔄 Fluxo de Pagamento

1. **Detecção NFC** → Cliente aproxima o dispositivo
2. **Busca Multi-Chain** → Análise de portfólio em todas as 6 redes
3. **Seleção Inteligente** → Token de pagamento ideal com base no sistema de prioridade
4. **Geração EIP-681** → Solicitação de pagamento com ID da rede
5. **Monitoramento em Tempo Real** → WebSocket/polling para confirmação da transação
6. **Registro no Histórico** → Transação armazenada com metadados completos
## 🛡️ Monitoramento de Transações

- **Monitoramento via WebSocket** para Ethereum, Base, Arbitrum, Optimism, Polygon
- **Monitoramento baseado em polling** como alternativa
- **Timeout automático** após 5 minutos
- **Integração com explorador de blocos** para verificação de transações
- **Rastreamento de status**: detectada → confirmada → falhou

## 🍓 Implantação no Raspberry Pi

Este terminal de pagamento NFC pode ser implantado como um **quiosque plug-and-play** em hardware Raspberry Pi para uso em produção.

### **Requisitos de Hardware**
- Raspberry Pi 4B (recomendado 4GB+ RAM)
- Tela sensível ao toque oficial de 7" do Raspberry Pi 
- **Leitor NFC ACR1252U-M1** (especificamente suportado)
- Cartão MicroSD de 32GB ou mais

### **Recursos de Implantação**
- **Build com um comando** cria uma imagem de cartão SD inicializável
- **WiFi pré-configurado** e credenciais de API
- **Inicialização automática** com modo quiosque em tela cheia
- **Validação de segurança** impede implantação com endereços de teste
- Suporte a build em **macOS e Linux**
### **Implantação Rápida**
```bash
# Navegue até os scripts de implantação
cd scripts/rpi-deploy

# Configure sua implantação
cp build-config.env.template build-config.env
# Edite o build-config.env com seu WiFi, chave de API e endereço do comerciante

# Construa a imagem inicializável (macOS)
./build-pi-image-osx.sh

# Grave o arquivo gerado nfc-terminal-<date>.img.gz no cartão SD usando o Raspberry Pi Imager e inicialize!
```

📖 **[Guia Completo de Implantação](https://raw.githubusercontent.com/FreePayPOS/merchant-app/main/README-DEPLOYMENT.md)**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---