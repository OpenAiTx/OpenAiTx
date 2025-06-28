# Kubernetes The Hard Way

Este tutorial te guía a través de la configuración de Kubernetes de la manera difícil. Esta guía no es para quienes buscan una herramienta completamente automatizada para desplegar un clúster de Kubernetes. Kubernetes The Hard Way está optimizado para el aprendizaje, lo que significa tomar el camino largo para asegurarte de comprender cada tarea necesaria para arrancar un clúster de Kubernetes.

> Los resultados de este tutorial no deben considerarse listos para producción, y pueden recibir soporte limitado de la comunidad, ¡pero eso no debe impedirte aprender!

## Copyright

<a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/"><img alt="Licencia Creative Commons" style="border-width:0" src="https://i.creativecommons.org/l/by-nc-sa/4.0/88x31.png" /></a><br />Este trabajo está licenciado bajo una <a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/">Licencia Creative Commons Atribución-NoComercial-CompartirIgual 4.0 Internacional</a>.


## Público Objetivo

El público objetivo de este tutorial es alguien que desea comprender los fundamentos de Kubernetes y cómo encajan los componentes principales.

## Detalles del Clúster

Kubernetes The Hard Way te guía a través del arranque de un clúster básico de Kubernetes con todos los componentes del plano de control ejecutándose en un solo nodo, y dos nodos de trabajo, lo que es suficiente para aprender los conceptos principales.

Versiones de los componentes:

* [kubernetes](https://github.com/kubernetes/kubernetes) v1.32.x
* [containerd](https://github.com/containerd/containerd) v2.1.x
* [cni](https://github.com/containernetworking/cni) v1.6.x
* [etcd](https://github.com/etcd-io/etcd) v3.6.x

## Laboratorios

Este tutorial requiere cuatro (4) máquinas virtuales o físicas basadas en ARM64 o AMD64 conectadas a la misma red.

* [Requisitos Previos](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/01-prerequisites.md)
* [Configuración del Jumpbox](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/02-jumpbox.md)
* [Provisionamiento de Recursos de Cómputo](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/03-compute-resources.md)
* [Provisionamiento de la CA y Generación de Certificados TLS](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/04-certificate-authority.md)
* [Generación de Archivos de Configuración de Kubernetes para Autenticación](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/05-kubernetes-configuration-files.md)
* [Generación de la Configuración y Llave de Cifrado de Datos](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/06-data-encryption-keys.md)
* [Arranque del Clúster etcd](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/07-bootstrapping-etcd.md)
* [Arranque del Plano de Control de Kubernetes](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/08-bootstrapping-kubernetes-controllers.md)
* [Arranque de los Nodos de Trabajo de Kubernetes](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/09-bootstrapping-kubernetes-workers.md)
* [Configuración de kubectl para Acceso Remoto](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/10-configuring-kubectl.md)
* [Provisionamiento de Rutas de Red para Pods](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/11-pod-network-routes.md)
* [Prueba de Humo](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/12-smoke-test.md)
* [Limpieza](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/13-cleanup.md)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-28

---