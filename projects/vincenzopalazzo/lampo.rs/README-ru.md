<div align="center">
  <h1>Lampo</h1>

  <img src="https://github.com/saradurante/lampo.docs/blob/dc0dce971c3052f0e9dd668fdf0c7376b12fee7b/imgs/web/icon-512.png?raw=true"  width="150" height="150" />


  <p>
    <strong>Быстрая и модульная реализация Lightning Network для любых задач, написанная на Rust.</strong>
  </p>

  <h4>
    <a href="https://lampo.devcrew.cc">Домашняя страница проекта</a>
  </h4>
</div>

## Crates

Это полный список поддерживаемых на данный момент crates:

| Crate       | Описание                                   | Версия     |
|:------------|:------------------------------------------:|-----------:|
| lampod-cli  | Командная строка Lampo Daemon для запуска демона | _unrelated_ |
| lampo-cli   | Простая командная строка Lampo для взаимодействия с демоном | _unrelated_ |

## Как установить

Чтобы установить все необходимые зависимости и бинарный файл Lampo, необходимо
иметь установленный rust, а затем выполнить следующую команду:

```
make install
```

После того как у вас появятся `lampod-cli` и `lampo-cli`, вы можете
запустить следующую команду для запуска Lampo в режиме signet:

```
➜  ~ lampod-cli --network signet
✓ Кошелек создан, пожалуйста, сохраните эти слова в безопасном месте
 wallet-keys  maple have fitness decide food joy flame coast stereo front grab stumble
```

>[!NOTE]
Сохраните слова от кошелька и используйте их для восстановления кошелька с помощью `--restore-wallet`.
Если вы не сохраните свои слова, ваши средства будут утеряны при следующем запуске Lampo!

Обратите внимание, что у вас должен быть файл `lampo.conf` по пути `~/.lampo/signet`. Выполните
следующую команду для использования примерa конфигурационного файла:

```
cp lampo.example.conf ~/.lampo/signet/lampo.conf
```

Затем вы можете сделать запрос к ноде с помощью следующей команды:

``` 
➜  ~ lampo-cli --network signet getinfo
{
  "node_id": "035b889551a44e502cd0cd6657acf067336034986cd6639b222cd4be563a7fc205",
  "peers": 0,
  "channels": 0
}
```

### Для запуска интеграционных тестов с core lightning:

Убедитесь, что вы собрали core-lightning в режиме разработчика. Руководство по установке можно найти [здесь](https://docs.corelightning.org/docs/installation).

Интеграционные тесты можно запустить следующей командой:

```
make integration
```

## Руководство по участию в проекте

Пожалуйста, ознакомьтесь с нашим [руководством для участников](https://raw.githubusercontent.com/vincenzopalazzo/lampo.rs/main/CONTRIBUTING.md).

## Сообщество

Для поддержания прозрачности мы выбрали определённые каналы для общения:
- Разработчики, присоединяйтесь к нам на [Zulip](https://lampo-dev.zulipchat.com/).
- Участники сообщества, ждём ваши идеи в нашем [сообществе Twitter](https://twitter.com/i/communities/1736414802849706087).
- Для технических вопросов и запросов новых функций — обсуждения на GitHub.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---