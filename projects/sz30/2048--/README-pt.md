<div align="right">
  <details>
    <summary >🌐 Outro Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>


[English](https://raw.githubusercontent.com/sz30/2048--/main/README.md) | [简体中文](https://raw.githubusercontent.com/sz30/2048--/main/README.zh-CN.md) | [繁體中文](https://raw.githubusercontent.com/sz30/2048--/main/README.zh-TW.md)

# 🎮 2048++

Uma versão aprimorada do clássico jogo 2048, agora com ainda mais recursos divertidos! Este é um pequeno projeto que desenvolvi em meu tempo livre—espero que lhe traga alegria!

## 🎯 Introdução ao Jogo

2048 é um jogo simples, porém viciante, de combinação de números. Em uma grade 4x4, deslize para cima, baixo, esquerda ou direita para juntar blocos com o mesmo número. O objetivo? Chegar ao 2048 (mas você pode continuar tentando pontuações ainda maiores)!

**Como jogar:**
- Use as teclas de seta ou WASD para mover os blocos.
- Quando dois blocos com o mesmo número colidem, eles se fundem em um só.
- Após cada movimento, um novo 2 ou 4 aparecerá aleatoriamente em um espaço vazio.
- O jogo termina quando não há mais movimentos disponíveis.

## ✨ Recursos Especiais

### 1. Função Desfazer
- Fez um movimento errado? Sem problemas!
- Basta clicar no botão "Desfazer" para voltar um passo.
- Você pode desfazer quantas vezes quiser, até o início do jogo.
- Nunca mais deixe um deslize atrapalhar sua partida!

### 2. Modo Secreto de Trapaça
- Digite a sequência mágica: ←←→→ →→←← (esquerda, esquerda, direita, direita, direita, direita, esquerda, esquerda)
- Todos os blocos vão se transformar magicamente em 128!
- É um Easter egg, só para diversão.
- Dica de especialista: Trapacear é divertido, mas não exagere! 😉

## 🎯 Demonstração

🎯 : [Jogue aqui](http://34.150.49.127:5000/)
<img width="1279" alt="demo" src="https://github.com/user-attachments/assets/0df2c956-b6d9-4371-a916-f6ac3ae642be" />



## 📁 Estrutura do Projeto
```
2048/
├── static/
│ ├── css/
│ │ └── styles.css # Game styles
│ └── js/
│ └── script.js # Frontend game logic
├── index.html # Main game page
└── 2048.py # Backend server
```
**Descrições dos Arquivos:**
- `2048.py`: Servidor backend escrito com Flask, lida com a lógica do jogo e requisições de API.
- `script.js`: Lógica do jogo no frontend, incluindo movimentos, animações e recursos especiais.
- `styles.css`: Estilos do jogo, garantindo que tudo fique bonito e responsivo.
- `index.html`: A página principal que integra todos os componentes.

## 🚀 Primeiros Passos

**Método 1: Baixar Release**
1. Baixe a versão mais recente.
2. Certifique-se de que o Python 3.x está instalado.
3. Instale as dependências: `pip install flask`
4. Execute: `python 2048.py`
5. Abra seu navegador e vá para: [http://localhost:9969](http://localhost:9969)

**Método 2: Clonar do GitHub**
```bash
git clone https://github.com/sz30/2048.git
cd 2048
pip install flask
python 2048.py
```

## 🎨 Personalização

Quer deixar com a sua cara? Ajuste o `styles.css` para um novo visual, ou mergulhe no `script.js` para modificar a jogabilidade. Todo o código está bem comentado para facilitar a personalização!

## 📝 Licença

Licença GPL-2.0

## 🤝 Contribuindo

Ainda em atualização! Issues e Pull Requests são super bem-vindos—vamos tornar este jogo ainda mais incrível juntos!


## 🙏 Agradecimentos

Agradecimentos aos seguintes patrocinadores por apoiarem este projeto:
- [Nenhum](https://#/) fornecendo o servidor
- [Serv00](https://www.serv00.com/) fornecendo o servidor

---
_Última atualização: ago. 2025_




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-09

---