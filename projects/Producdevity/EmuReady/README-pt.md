# EmuReady

Uma plataforma orientada pela comunidade para rastrear a compatibilidade de emulação em diferentes dispositivos e emuladores.

Visite nosso site: [https://emuready.com](https://emuready.com)

---

**Captura de Tela da Página Inicial**

<img src="https://github.com/user-attachments/assets/9a7077fd-a9b1-4a1c-8a81-8f9beed25581" width="48%">&nbsp;&nbsp;&nbsp;<img src="https://github.com/user-attachments/assets/df612c7c-4b9d-481b-ae92-175b2b6afb0b" width="48%">

---

**Captura de Tela da Página de Listagens de Compatibilidade**

<img src="https://github.com/user-attachments/assets/400c48d4-6340-4a60-8d86-f996a35f1bf4" width="48%">&nbsp;&nbsp;&nbsp;<img src="https://github.com/user-attachments/assets/4ca1c1de-3616-4c25-81b9-ad80f8a69458" width="48%">

---

**Captura de Tela da Página de Jogos**

<img src="https://github.com/user-attachments/assets/b036de53-18ed-4bf4-8117-5cd36e87ee31" width="48%">&nbsp;&nbsp;&nbsp;<img src="https://github.com/user-attachments/assets/9fbe12c4-3387-4e1d-986a-df80761134e3" width="48%">

---

## Visão Geral

O EmuReady ajuda os usuários a compartilhar e descobrir informações de compatibilidade de emulação em diferentes configurações de hardware e software. Usuários podem contribuir com relatórios de compatibilidade, votar em listagens e discutir combinações específicas de jogo/dispositivo/emulador.

![License](https://img.shields.io/github/license/Producdevity/emuready?cacheSeconds=1)
![Stars](https://img.shields.io/github/stars/Producdevity/emuready?cacheSeconds=1)
![Forks](https://img.shields.io/github/forks/Producdevity/emuready?cacheSeconds=1)
![Issues](https://img.shields.io/github/issues/Producdevity/emuready?cacheSeconds=1)

## Funcionalidades

- **Banco de Dados de Compatibilidade Abrangente**: Acompanhe como os jogos funcionam em diferentes emuladores e dispositivos
- **Contribuições dos Usuários**: Relatórios da comunidade e sistema de votação
- **Sistema de Discussão**: Tópicos de comentários com funcionalidade de votos positivos/negativos
- **Painel de Administração**: Gerencie usuários, listagens e moderação de conteúdo
- **Design Responsivo**: Funciona em dispositivos móveis, tablets e desktop

## Melhorias Recentes

O código-fonte foi significativamente aprimorado com as seguintes melhorias:

### Componentes de UI

- Criado um componente **ErrorBoundary** para melhor tratamento e recuperação de erros
- Adicionado um componente **OptimizedImage** usando o componente Image do Next.js para melhor desempenho
- Melhorias na **Paginação** com recursos de acessibilidade, navegação por teclado e melhor experiência do usuário
- Aprimorado o componente **Badge** com mais variantes, tamanhos e opção de pílula
- Adicionado o componente **ThemeToggle** para alternar entre temas claro, escuro e sistema
- Implementado **SortableHeader** para ordenação de tabelas com indicadores visuais

### Cache & Performance

- Configuração aprimorada do React Query com melhores padrões para cache, tempos de expiração e lógica de repetição
- Adicionada otimização de imagens para imagens de dispositivos
- Implementado tratamento de erros adequado em toda a aplicação

### Acessibilidade

- Navegação por teclado aprimorada para elementos interativos
- Adicionados rótulos e papéis ARIA adequados
- Melhor gerenciamento de foco
- Melhor contraste de cores nos componentes da interface

### Segurança

- Validação e sanitização de dados em múltiplos níveis (cliente, servidor, banco de dados)
- Implementação de Content Security Policy
- Proteção contra ataques XSS e CSRF
- Autenticação segura com NextAuth.js
- Validação e segurança em upload de arquivos
- Restrições de tamanho de entrada e sanitização adequada
- Validação de UUID para prevenir adulteração de parâmetros

### Experiência do Desenvolvedor

- Scripts npm adicionais para o fluxo de trabalho de desenvolvimento
- Estrutura de projeto melhorada com exports consistentes
- Feedback de erro aprimorado com ErrorBoundary personalizado
- Página 404 melhorada com opções úteis de navegação

### Tematização

- Detecção de preferência de tema do sistema
- Alternância de tema com múltiplas opções de interface
- Implementação aprimorada do modo escuro em todos os componentes

## Primeiros Passos

### Pré-requisitos

- Node.js 20+
- `npm`
- PostgreSQL (ou SQLite para desenvolvimento)

### Instalação

1. Clone o repositório

```bash
git clone https://github.com/Producdevity/emuready.git
cd emuready
```

2. Instale as dependências

```bash
npm install
```

3. Configure as variáveis de ambiente

```bash
cp .env.example .env
```

Depois edite o arquivo `.env` com suas credenciais do banco de dados e outras configurações.

4. Configure o banco de dados

```bash
npx prisma generate
npx prisma db push
```

5. Inicie o servidor de desenvolvimento

```bash
npm run dev
```

6. Abra [http://localhost:3000](http://localhost:3000) no seu navegador

## Scripts Disponíveis

- `npm run dev` - Inicia o servidor de desenvolvimento
- `npm run dev:strict` - Inicia com React em modo estrito
- `npm run build` - Compila para produção
- `npm run start` - Inicia o servidor de produção
- `npm run test` - Executa os testes
- `npm run lint` - Executa o ESLint
- `npm run lint:fix` - Corrige problemas de lint
- `npm run format` - Formata o código com Prettier
- `npm run typecheck` - Verifica os tipos do TypeScript
- `npm run analyze` - Analisa o tamanho do bundle
- `npm run clean` - Limpa o cache de build
- `npm run prepare-deploy` - Prepara para deploy (lint, typecheck, test, build)

### Comandos Prisma

- `npx prisma db seed` - Popula o banco de dados
- `npx prisma studio` - Abre o Prisma Studio
- `npx prisma db pull` - Puxa o esquema do banco de dados
- `npx prisma db push` - Envia o esquema do banco de dados

Veja a [Referência do Prisma CLI](https://www.prisma.io/docs/orm/reference/prisma-cli-reference) para mais detalhes.

## Stack Tecnológico

- **Framework**: Next.js 15
- **ORM de Banco de Dados**: Prisma
- **API**: tRPC
- **Autenticação**: NextAuth.js
- **Estilização**: Tailwind CSS
- **Gerenciamento de Estado**: React Query
- **Verificação de Tipos**: TypeScript
- **Animação**: Framer Motion
- **Validação**: Zod, Content Security Policy, Validação de Entrada

## Contribuindo

Contribuições são bem-vindas! Veja nossas [Diretrizes de Contribuição](https://raw.githubusercontent.com/Producdevity/EmuReady/master/CONTRIBUTING.md) para mais detalhes.

## Licença

Este projeto está licenciado sob a Licença MIT - veja o arquivo [LICENSE](https://raw.githubusercontent.com/Producdevity/EmuReady/master/LICENSE) para detalhes.

## Código de Conduta (TODO)

Por favor, note que este projeto segue um [Código de Conduta](https://raw.githubusercontent.com/Producdevity/EmuReady/master/CODE_OF_CONDUCT.md). Ao participar deste projeto, você concorda em seguir seus termos.

## Segurança (TODO)

Se você descobrir uma vulnerabilidade de segurança, por favor siga nossa [Política de Segurança](https://raw.githubusercontent.com/Producdevity/EmuReady/master/SECURITY.md) para reportar.

## Agradecimentos

- Todos os nossos [Contribuidores](https://github.com/Producdevity/emuready/graphs/contributors)
- A comunidade de emulação pela inspiração e apoio

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---