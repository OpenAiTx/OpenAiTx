# Ativação Instantânea do Windows 10 & 11: Solução em 40 Segundos.

[![Readme](https://img.shields.io/badge/README_IN-فارسی-blue?logo=readme)](README-FA.md)  
[![Readme](https://img.shields.io/badge/README_IN-ENGLISH-blue?logo=readme)](README.md)

> Este repositório contém um método que pode ativar o Windows 10 e 11 em menos de 40 segundos. Ambos os métodos são compatíveis com as versões Home, Home N, Home Single Language, Home Country Specific, Professional, Education e Enterprise do Windows.

## Método 1 (recomendado)  
### Ativação instantânea do Windows usando (PowerShell)  
> [!DICA]
> Temos várias formas de executar o PowerShell no Windows 10 & 11. [^1]

Uma das maneiras mais rápidas de abrir o PowerShell no Windows é através de uma busca no menu Iniciar. Siga os passos abaixo:

<br>

### Passo 1  
Tudo o que você precisa fazer é clicar no botão iniciar ou no ícone de busca e digitar "PowerShell" na caixa de pesquisa.  
> Outra forma fácil: [^2]

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/5a10538a-c8c2-4934-868b-fd8e910f1f9e" width="540px">
</p>  

---
<br>

### Passo 2  
Em seguida, você deve clicar em `Executar como administrador` para iniciar o PowerShell, pois precisamos rodar com **privilégios administrativos**.

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/1f25dd2a-16db-4053-a45c-aac6f8a9e470" width="540px">
</p>

---
<br>

### Passo 3  
Agora, após uma breve pausa para execução, por favor `copie` esta linha:

```CSS
irm https://get.activated.win | iex
```

---
<br>

### Passo 4  
Agora cole (com o botão direito do mouse) e pressione Enter. Na nova janela aberta, há várias opções disponíveis, das quais devemos selecionar a opção `1` e aguardar alguns segundos até a conclusão.

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/0c3689a1-1595-40b3-97e2-041dac423237" width="540px">
</p>

<br>

#### Parabéns,
seu Windows foi ativado.  
Agora você pode pressionar Enter para sair do CMD, fechar o PowerShell e verificar o menu de Ativação do Windows [^3]

<br><br><br><br><br><br><br><br>

## Método 2  
### Ativação instantânea do Windows usando CMD (Prompt de Comando)

<br>

> [!NOTA]
> Lembre-se de **conectar** à **Internet**
>
> VPN **não é necessário**

<br>

### Passo 1  
Primeiro, clique no botão iniciar ou no ícone de busca e digite "CMD" na caixa de pesquisa. Após ver a opção de prompt de comando, execute como **administrador**  
> outras formas fáceis: [^2].

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/88ac970a-f24b-4acc-82c0-f8e7c0b05249" width="480px">
</p>  

---
<br>

### A seguir está a lista de CHAVES DE LICENÇA  

|            **Chave**            |  **Versão**   |
| :-----------------------------: | :-----------: |
| TX9XD-98N7V-6WMQ6-BX7FG-H8Q99   |     Home      |
| 3KHY7-WNT83-DGQKR-F7HPR-844BM   |    Home N     |
| 7HNRX-D7KGG-3K4RQ-4WPJ4-YTDFH   | Home sl [^4]  |
| PVMJN-6DFY6–9CCP6–7BKTT-D3WVR   | Home cs [^5]  |
| W269N-WFGWX-YVC9B-4J6C9-T83GX   | Professional  |
| MH37W-N47XK-V7XM9-C7227-GCQG9   | Professional N|
| NW6C2-QMPVW-D7KKK-3GKT6-VCFB2   |  Education    |
| 2WH4N-8QGBV-H22JP-CT43Q-MDWWJ   | Education N   |
| NPPR9-FWDCX-D2C8J-H872K-2YT43   |  Enterprise   |
| DPH2V-TTNVB-4X9Q3-TJR4H-KHJW4   | Enterprise N  |

![rainbow](https://github.com/NiREvil/vless/assets/126243832/1aca7f5d-6495-44b7-aced-072bae52f256)

<br>

### Passo 2  
Instale a chave cliente KMS.

Use este comando:

```CSS
slmgr /ipk suachavedeproduto
```

> [!NOTA]
> Por favor, selecione uma das **chaves de licença** da lista que **corresponda à sua versão do Windows** e substitua pela frase `suachavedeproduto` no comando.

> [!DICA]
> Como verificar a versão do Windows [^3].

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/1b6401e6-7e63-4351-8a92-fa355dfc30cf" width="480px">
</p>  

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/90037069-7ea3-44a8-a9fa-e296f5e8d47b" width="340px">
</p>  

---
<br>

### Passo 3  
Defina o endereço da máquina KMS.

Use o comando:

```CSS
slmgr /skms kms8.msguides.com
```

para conectar ao meu servidor KMS.

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/9d634454-1c59-47da-874e-bfe575288fe6" width="480px">
</p>  

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/2d2e6cfb-4e85-483f-ae0a-c7157d22da36" width="340px">
</p>  

---  
<br>

### Passo 4  
Ative o seu Windows.
O último passo é ativar o seu Windows usando o comando:

```CSS
slmgr /ato
```

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/5e495d42-6ce5-4884-9de2-96a56efb4343" width="480px">
</p>  

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/aecd9cfd-8c09-4433-b410-a62205a8d692" width="240px">
</p>  

---
<br>

### Passo 5  
Agora verifique novamente o status da ativação [^6].

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/9ca70137-8e2e-4504-a52d-22f41d959bd7" width="480px">
</p>

#### Pronto ✅  
seu Windows foi ativado com sucesso.

<br>

**Seja curioso 🤍**

[![Telegram](https://img.shields.io/badge/TELEGRAM-blue.svg?logo=telegram)](https://t.me/F_NiREvil) [![Twitter](https://img.shields.io/badge/TWITTER-blue.svg?logo=x)](https://twitter.com/NiREvil_)

<picture>
  <source media="(prefers-color-scheme: dark)" srcset="https://user-images.githubusercontent.com/25423296/163456776-7f95b81a-f1ed-45f7-b7ab-8fa810d529fa.png">
  <source media="(prefers-color-scheme: light)" srcset="https://user-images.githubusercontent.com/25423296/163456779-a8556205-d0a5-45e2-ac17-42d089e3c3f8.png">
  <img alt="Mostra um sol ilustrado no modo claro e uma lua com estrelas no modo escuro." src="https://user-images.githubusercontent.com/25423296/163456779-a8556205-d0a5-45e2-ac17-42d089e3c3f8.png">
</picture>

<br>

[^1]: [10 maneiras de executar o PowerShell no Windows](https://www.google.com/amp/s/www.minitool.com/news/open-windows-11-powershell.html%3famp)  

[^2]: Outra maneira fácil de executar o PowerShell: **Clique com o botão direito** no menu Iniciar para abrir o menu rápido e selecione **Windows Terminal (admin)** no Windows 11 ou **Windows powershell (admin)** no Windows 10 na lista de menus.
[^3]: Para verificar a versão do seu Windows: **Clique com o botão direito** no menu Iniciar e selecione a opção **sistema**. Sua versão do Windows pode ser vista na segunda seção, em **Edição.** Você também pode seguir os passos do método 2 **copiando e colando**. Copie os comandos e depois clique com o **botão direito** no **cmd ou powershell** para colar.
[^4]: Versão Home Single Language.
[^5]: Versão Home Country Specific.
[^6]: Para ver o status de ativação do Windows, vá para:  
***Configurações → Atualização e Segurança → menu de ativação.***

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx) - 2025-06-07

---