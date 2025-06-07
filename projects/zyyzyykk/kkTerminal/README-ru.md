# kkTerminal

> kkTerminal, терминал для Web SSH-подключения  
> Автор: [zyyzyykk](https://github.com/zyyzyykk/)  
> Исходный код: https://github.com/zyyzyykk/kkTerminal  
> Адрес Docker Hub: https://hub.docker.com/repository/docker/zyyzyykk/kkterminal/general  
> Превью: https://ssh.kkbpro.com/  
> Дата обновления: 2025-03-15  
>

<p align="center"><a href="https://ssh.kkbpro.com/" target="_blank" rel="noopener noreferrer"><img width="100" src="https://kkbapps.oss-cn-shanghai.aliyuncs.com/logo/terminal.png" alt="kkTerminal"></a></p>

<p align="center">
  <a href="https://hub.docker.com/repository/docker/zyyzyykk/kkterminal/general"><img src="https://img.shields.io/docker/pulls/zyyzyykk/kkterminal?logo=docker" alt="Docker Image"></a>
  <a href="https://www.oracle.com/cn/java/technologies/downloads/#java8-windows"><img src="https://img.shields.io/badge/jdk-1.8-orange?logo=openjdk&logoColor=%23e3731c" alt="JDK Version"></a>
  <a href="https://spring.io/projects/spring-boot"><img src="https://img.shields.io/badge/springboot-2.7.15-green?color=6db33f&logo=springboot" alt="SpringBoot Version"></a>
  <a href="https://cn.vuejs.org/"><img src="https://img.shields.io/badge/vue-3.x-green?color=42b883&logo=vue.js" alt="Vue Version"></a>
  <a href="https://www.apache.org/licenses/"><img src="https://img.shields.io/badge/licence-Apache-red?logo=apache&logoColor=%23D22128" alt="Apache Licence"></a>
  <a href="https://github.com/zyyzyykk/kkTerminal"><img src="https://img.shields.io/github/stars/zyyzyykk/kkterminal" alt="GitHub"></a>
</p>
<p align="center">English ｜ <a href="https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/zh_CN/README.md" >简体中文</a></p>

### ⚡ Быстрая интеграция

Для быстрой интеграции используйте тег `iframe` в HTML-страницах:

```html
<iframe src="https://ssh.kkbpro.com/" height="400px" width="600px" ></iframe>
```

### 🐳 Развертывание через Docker

1. Загрузите образ:

```bash
docker pull zyyzyykk/kkterminal
```

2. Создайте и запустите контейнер с пробросом порта: `-p порт:3000`

```bash
docker run -d --name kkterminal -p 3000:3000 zyyzyykk/kkterminal
```

3. Кастомизация арт-надписи: `-e TITLE="ArtWord"`

```bash
docker run -d --name kkterminal -p 3000:3000 -e TITLE="kkbpro" zyyzyykk/kkterminal
```

4. Откройте в браузере: `http://server-ip:3000/`

### 🛸 Превью

Перейдите по адресу: https://ssh.kkbpro.com/

![Connect](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/Connect.png)

![Preference](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/Preference.png)

![File](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/File.png)

![Editor](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/Editor.png)

[**Больше модулей-превью**](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/MODULE.md)

### 💡 Описание функций

1. kkTerminal — это терминал для Web SSH-подключения. Нажмите на иконку терминала в верхнем левом углу и выберите настройки подключения для установления SSH-соединения

2. Поддержка использования тега `iframe` для быстрой интеграции на сторонних веб-сайтах

3. Поддержка кастомизации конфигурации терминала через [URL-параметры](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/PARAMS.md)

4. Поддержка интернационализации и переключения языка между китайским и английским

5. Поддержка локального развертывания на ПК, при запуске автоматически открывается окно браузера

6. Поддержка адаптивного размера окна и китайского ввода

7. Поддержка пользовательских настроек предпочтений: выбор цвета фона/текста, размера шрифта, стиля отображения курсора, включение TCode для терминала и др.

8. Поддержка перезапуска: автоматический перезапуск после изменения настроек SSH-подключения или пользовательских настроек, или ручной перезапуск после разрыва SSH-соединения

9. Поддержка копирования и вставки:

   - Копирование: как в терминале `Git`, выделение текста автоматически копирует его

   - Вставка: как в терминале `Cmd`, правая кнопка мыши вставляет (требуются разрешения браузера)

9. Поддержка управления файлами: откройте модуль управления файлами для просмотра, распаковки, загрузки и скачивания файлов/папок

10. Поддержка горячих клавиш: выбор нескольких/всех файлов, копирование и вставка, вырезание, переключение выбора, открытие и др.

11. Поддержка просмотра и редактирования файлов, сохранение изменений на удалённый сервер с помощью `ctrl+s`

12. Поддержка [TCode (Terminal Code)](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/TCODE.md), позволяющего реализовать автоматизированный Workflow, аналогичный Shell-скриптам, через настраиваемый TCode

13. Поддержка записи операций и функции облачной синхронизации

14. Поддержка функций Cooperate, Monitor и Docker

### 👨‍💻 Журнал обновлений

##### zyyzyykk/kkterminal:3.6.0: latest

- Добавлена расширенная функция Cooperate
- Добавлена расширенная функция Monitor
- Добавлена расширенная функция Docker
- Оптимизирован размер пакета и отображение веб-страницы

##### zyyzyykk/kkterminal:3.5.6: 

- Поддержка большего количества URL-параметров
- Добавлены процентные размеры текста и изображений редактора
- Оптимизировано отображение веб-страницы

##### zyyzyykk/kkterminal:3.5.3: 

- Добавлен URL-параметр для настройки конфигурации терминала
- Исправлена ошибка перезапуска при нескольких окнах
- Добавлены функции записи операций и облачной синхронизации
- Рефакторинг части логики кода

[**История обновлений**](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/UPDATE.md)

### 🧬 Архитектура

```markdown
+---------+     http      +-------------+    ssh     +---------------+
| browser | <===========> | kk Terminal | <========> | remote server |
+---------+   websocket   +-------------+    sftp    +---------------+
Vue + Xterm              SpringBoot + SSHJ                Linux OS    
```

### 🏘️ О проекте

Уважаемые пользователи,

С сожалением сообщаю, что из-за нехватки времени и сил я больше не смогу поддерживать `kkTerminal` в будущем.

Если вы заинтересованы в `kkTerminal` или хотите продолжить его поддержку, пожалуйста, свяжитесь со мной или создайте issue.

Если вы обнаружите ошибки или захотите реализовать новые функции, также создайте issue.

Спасибо за вашу поддержку `kkTerminal`, искренне надеюсь, что `kkTerminal` окажется для вас полезным.

С наилучшими пожеланиями,

[zyyzyykk](https://github.com/zyyzyykk/)

2025.03.15

### 🌟 Звёзды

[![Stars](https://starchart.cc/zyyzyykk/kkTerminal.svg?variant=adaptive)](https://starchart.cc/zyyzyykk/kkTerminal)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---