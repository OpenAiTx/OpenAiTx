<p align="center">
  <img src="https://raw.githubusercontent.com/aadya940/autoresume/main/main_app/frontend/public/autoresume-logo.png" alt="autoResume Logo" title="autoResume Logo" width="180"/>
</p>

<h1 align="center">autoResume</h1>

<p align="center">
  <b>Construtor de currículos open‑source: cole seus links, edite manualmente e deixe a IA ajudar a aperfeiçoar, atualizar e personalizar seu currículo.</b>
</p>

---

### Como usar isto?

[Link do Blog no Medium](https://medium.com/@aadyachinubhai/autoresume-copy-and-paste-links-its-that-simple-8e50e6d155a1)

O blog está desatualizado em relação à Interface do Usuário e ao Modelo utilizado.

## Funcionalidades

- <b>Importação Fácil de Links:</b> Cole links de sites e construa rapidamente um currículo em PDF.
- <b>Editor Manual Incluso:</b> Ajuste ou crie seu currículo do zero com um editor de código integrado.
- <b>Sugestões Inteligentes:</b> Compartilhe feedback ou novos links, e as edições inteligentes ajudarão a refinar e atualizar seu currículo.
- <b>Personalizado para Vagas:</b> Cole uma descrição de vaga e receba recomendações para alinhar seu currículo.
- <b>Qualidade LaTeX:</b> Todos os currículos são gerados usando LaTeX para um layout limpo e profissional.
- <b>Visualização Instantânea:</b> Veja seu currículo em PDF em tempo real.
- <b>Reinício Fácil:</b> Limpe e reinicie seu currículo com um clique.
- <b>Local:</b> Roda totalmente em sua máquina usando Docker.

---

## Primeiros Passos

### Pré-requisitos
- [Docker](https://www.docker.com/get-started)
- [Docker Compose](https://docs.docker.com/compose/)

### Configuração

1. Clone o repositório:
   ```bash
   git clone https://github.com/aadya940/autoresume.git
   cd autoresume
   ```
2. Construa e inicie o aplicativo:
   ```bash
   docker compose up --build
   ```
3. Acesse os aplicativos:
   
   [_http://localhost:5173_](http://localhost:5173)
---

## Uso

1. Abra o autoResume no seu navegador.
2. Clique no ícone :gear:, cole sua [CHAVE DE API DO GOOGLE](https://aistudio.google.com/) e seu Email.
3. Cole links com suas informações profissionais (por exemplo, Github, Site Pessoal, etc.).
4. Opcionalmente, adicione feedback ou o link de uma vaga para personalização adicional.
5. Clique em <b>Gerar Currículo</b> e deixe a IA fazer o resto!

---

## Licença

Este projeto está licenciado sob a Licença Apache 2.0.

## Guia de Contribuição

### Frontend
- Implemente componentes React na pasta `frontend/src/components/`
- Usamos Chakra UI para implementar os componentes.
- Importe e utilize seus componentes em `frontend/src/App.jsx`

### Backend
- Implemente rotas de API no diretório `backend/src/routes/`
- Adicione funcionalidades de IA no diretório `backend/src/ai/`
- Utilizamos o formatador de código `black` para código Python
- Mantenha os manipuladores de rotas limpos e a lógica separada

### Diretrizes Gerais
- Crie um novo branch para sua funcionalidade/correção: `git checkout -b seu-nome-de-branch`
- Escreva mensagens de commit claras
- Teste suas alterações antes de enviar um PR

### Enviando Alterações
1. Crie um Pull Request
2. Na descrição do seu PR, inclua:
   - Quais alterações você fez
   - Por que as fez
   - Quaisquer capturas de tela ou resultados de teste relevantes
   - Quaisquer mudanças incompatíveis ou etapas de migração necessárias

Agradecemos suas contribuições e revisaremos seu PR o mais rápido possível!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-07

---