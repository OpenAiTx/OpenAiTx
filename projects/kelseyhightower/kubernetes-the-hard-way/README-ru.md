# Kubernetes The Hard Way

Этот учебник проведет вас через настройку Kubernetes «трудным способом». Это руководство не предназначено для тех, кто ищет полностью автоматизированный инструмент для развертывания кластера Kubernetes. Kubernetes The Hard Way оптимизирован для обучения, что подразумевает более длинный путь, чтобы вы поняли каждую задачу, необходимую для запуска кластера Kubernetes.

> Результаты этого учебника не следует рассматривать как готовые к использованию в продакшене и они могут получать ограниченную поддержку от сообщества, но пусть это не мешает вам учиться!

## Авторские права

<a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/"><img alt="Creative Commons License" style="border-width:0" src="https://i.creativecommons.org/l/by-nc-sa/4.0/88x31.png" /></a><br />Эта работа лицензирована на условиях <a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/">Creative Commons Attribution-NonCommercial-ShareAlike 4.0 International License</a>.


## Целевая аудитория

Целевая аудитория этого учебника — те, кто хочет понять основы Kubernetes и то, как основные компоненты взаимодействуют друг с другом.

## Подробности о кластере

Kubernetes The Hard Way проведет вас через запуск базового кластера Kubernetes со всеми компонентами контрольной плоскости, работающими на одном узле, и двумя рабочими узлами, чего достаточно для изучения основных концепций.

Версии компонентов:

* [kubernetes](https://github.com/kubernetes/kubernetes) v1.32.x
* [containerd](https://github.com/containerd/containerd) v2.1.x
* [cni](https://github.com/containernetworking/cni) v1.6.x
* [etcd](https://github.com/etcd-io/etcd) v3.6.x

## Лабораторные работы

Для прохождения этого учебника требуется четыре (4) виртуальных или физических машины на базе ARM64 или AMD64, подключенные к одной сети.

* [Требования](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/01-prerequisites.md)
* [Настройка Jumpbox](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/02-jumpbox.md)
* [Выделение вычислительных ресурсов](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/03-compute-resources.md)
* [Настройка CA и генерация TLS-сертификатов](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/04-certificate-authority.md)
* [Генерация конфигурационных файлов Kubernetes для аутентификации](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/05-kubernetes-configuration-files.md)
* [Генерация конфигурации и ключа для шифрования данных](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/06-data-encryption-keys.md)
* [Запуск кластера etcd](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/07-bootstrapping-etcd.md)
* [Запуск компонентов контрольной плоскости Kubernetes](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/08-bootstrapping-kubernetes-controllers.md)
* [Запуск рабочих узлов Kubernetes](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/09-bootstrapping-kubernetes-workers.md)
* [Настройка kubectl для удаленного доступа](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/10-configuring-kubectl.md)
* [Настройка маршрутов сетей Pod'ов](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/11-pod-network-routes.md)
* [Smoke Test](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/12-smoke-test.md)
* [Очистка](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/13-cleanup.md)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-28

---