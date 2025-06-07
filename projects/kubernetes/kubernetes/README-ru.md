# Kubernetes (K8s)

[![CII Best Practices](https://bestpractices.coreinfrastructure.org/projects/569/badge)](https://bestpractices.coreinfrastructure.org/projects/569) [![Go Report Card](https://goreportcard.com/badge/github.com/kubernetes/kubernetes)](https://goreportcard.com/report/github.com/kubernetes/kubernetes) ![GitHub release (latest SemVer)](https://img.shields.io/github/v/release/kubernetes/kubernetes?sort=semver)

<img src="https://github.com/kubernetes/kubernetes/raw/master/logo/logo.png" width="100">

----

Kubernetes, также известный как K8s, — это система с открытым исходным кодом для управления [контейнеризованными приложениями] на множестве хостов. Она предоставляет базовые механизмы для развертывания, обслуживания и масштабирования приложений.

Kubernetes основан на пятнадцатилетнем опыте компании Google по запуску рабочих нагрузок в промышленном масштабе с использованием системы под названием [Borg], а также на лучших идеях и практиках сообщества.

Kubernetes размещён в Cloud Native Computing Foundation ([CNCF]).
Если ваша компания хочет принять участие в формировании эволюции технологий, упакованных в контейнеры, динамически планируемых и ориентированных на микросервисы, рассмотрите возможность вступления в CNCF.
Подробнее о том, кто участвует и какова роль Kubernetes, читайте в [анонсе CNCF].

----

## Как начать использовать K8s

Смотрите нашу документацию на [kubernetes.io].

Пройдите бесплатный курс [Масштабируемые микросервисы с Kubernetes].

Чтобы использовать код Kubernetes как библиотеку в других приложениях, смотрите [список опубликованных компонентов](https://git.k8s.io/kubernetes/staging/README.md).
Использование модуля `k8s.io/kubernetes` или пакетов `k8s.io/kubernetes/...` в качестве библиотек не поддерживается.

## Как начать разрабатывать K8s

В [репозитории сообщества] содержится вся информация о сборке Kubernetes из исходников, о том, как вносить вклад в код и документацию, к кому обращаться по различным вопросам и т.д.

Если вы хотите сразу приступить к сборке Kubernetes, есть два варианта:

##### У вас настроено рабочее [Go-окружение].

```
git clone https://github.com/kubernetes/kubernetes
cd kubernetes
make
```

##### У вас настроено рабочее [Docker-окружение].

```
git clone https://github.com/kubernetes/kubernetes
cd kubernetes
make quick-release
```

Для полного описания перейдите к [документации для разработчиков].

## Поддержка

Если вам нужна поддержка, начните с [руководства по устранению неполадок] и следуйте предложенному процессу.

Если у вас возникли вопросы, свяжитесь с нами [одним из способов][communication].

[announcement]: https://cncf.io/news/announcement/2015/07/new-cloud-native-computing-foundation-drive-alignment-among-container
[Borg]: https://research.google.com/pubs/pub43438.html?authuser=1
[CNCF]: https://www.cncf.io/about
[communication]: https://git.k8s.io/community/communication
[community repository]: https://git.k8s.io/community
[containerized applications]: https://kubernetes.io/docs/concepts/overview/what-is-kubernetes/
[developer's documentation]: https://git.k8s.io/community/contributors/devel#readme
[Docker environment]: https://docs.docker.com/engine
[Go environment]: https://go.dev/doc/install
[kubernetes.io]: https://kubernetes.io
[Scalable Microservices with Kubernetes]: https://www.udacity.com/course/scalable-microservices-with-kubernetes--ud615
[troubleshooting guide]: https://kubernetes.io/docs/tasks/debug/

## Встречи сообщества

В [Календаре](https://www.kubernetes.dev/resources/calendar/) собран список всех встреч сообщества Kubernetes в одном месте.

## Пользователи

На сайте [User Case Studies](https://kubernetes.io/case-studies/) приведены реальные примеры использования Kubernetes организациями из различных отраслей, которые внедряют или мигрируют на Kubernetes.

## Управление

Проект Kubernetes управляется с помощью системы принципов, ценностей, политик и процессов, которые помогают нашему сообществу и заинтересованным сторонам двигаться к общим целям.

[Сообщество Kubernetes](https://github.com/kubernetes/community/blob/master/governance.md) — отправная точка для знакомства с нашей организационной структурой.

[Репозиторий Kubernetes Steering Community](https://github.com/kubernetes/steering) используется Руководящим комитетом Kubernetes, который осуществляет надзор за управлением проектом Kubernetes.

## Дорожная карта

В [репозитории Kubernetes Enhancements](https://github.com/kubernetes/enhancements) содержится информация о релизах Kubernetes, а также отслеживание функций и бэклоги.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---