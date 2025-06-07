# helm-chartsnap 📸 
[![Go Reference](https://pkg.go.dev/badge/github.com/jlandowner/helm-chartsnap.svg)](https://pkg.go.dev/github.com/jlandowner/helm-chartsnap)
[![Go Report Card](https://goreportcard.com/badge/github.com/jlandowner/helm-chartsnap)](https://goreportcard.com/report/github.com/jlandowner/helm-chartsnap)
[![codecov](https://codecov.io/gh/jlandowner/helm-chartsnap/graph/badge.svg?token=8ARG53CRL7)](https://codecov.io/gh/jlandowner/helm-chartsnap)
[![Workflow Status](https://github.com/jlandowner/helm-chartsnap/actions/workflows/release.yaml/badge.svg)](https://github.com/jlandowner/helm-chartsnap/actions/workflows/release.yaml)
[![CI](https://github.com/jlandowner/helm-chartsnap/actions/workflows/ci.yaml/badge.svg)](https://github.com/jlandowner/helm-chartsnap/actions/workflows/ci.yaml)
[![GitHub Marketplace](https://img.shields.io/badge/Marketplace-Helm%20chartsnap%20action-blue.svg?colorA=24292e&colorB=0366d6&style=flat&longCache=true&logo=github)](https://github.com/marketplace/actions/helm-chartsnap-action)

Herramienta de pruebas de instantáneas para Helm charts.

Aporta potentes capacidades de pruebas de UI para Helm charts con una configuración mínima directamente en el archivo `values.yaml`.

![screenshot](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/docs/screenshot.png)

## Descripción general
- [Características 🔑](#características-)
- [¿Por qué pruebas de instantáneas? 📸](#por-qué-pruebas-de-instantáneas-)
  - [Motivación](#motivación)
- [Instalación 🚀](#instalación-)
- [Uso](#uso)
  - [Manejo de valores dinámicos 💪](#manejo-de-valores-dinámicos-)
- [Ejemplos y Usuarios ✨](#ejemplos-y-usuarios-)

## Características 🔑

* **Pruebas de instantáneas fáciles e intuitivas para desarrolladores de Helm**
  
  - **Sin formato de archivo TestSuite específico de la herramienta**: A diferencia de algunas herramientas que requieren la creación de TestSuites separados con formatos de archivo personalizados, esta herramienta no requiere formatos de archivo adicionales. En su lugar, puedes preparar variaciones del archivo estándar `values.yaml` para cada caso de prueba. Esto elimina la necesidad de aprender nuevos formatos y simplifica las pruebas.

* **Optimizado para Helm charts**

  - **Manejo de salidas dinámicas generadas por funciones de helm**: Puedes especificar propiedades adicionales dentro del archivo values.yaml para cada caso de prueba y así proporcionar flexibilidad al ajustar el comportamiento de la prueba. Por ejemplo, puedes controlar la salida generada dinámicamente por funciones de helm como [randAlphaNum](https://helm.sh/docs/chart_template_guide/function_list/).

* **Pruebas de instantáneas continuas**

  - **[GitHub Action](https://github.com/jlandowner/helm-chartsnap-action) listo**: Ya está disponible una acción de GitHub que permite realizar pruebas de instantáneas continuas para Helm charts locales o remotos en tu CI 🚀 -> [`helm-chart-action`](https://github.com/jlandowner/helm-chartsnap-action)

## ¿Por qué pruebas de instantáneas? 📸

Creo que las pruebas de instantáneas, un enfoque popular en las pruebas Web o de UI con herramientas como Jest, es la mejor manera de probar Helm charts. Las pruebas de instantáneas proporcionan varios beneficios:

- **Comparaciones visuales:** Las pruebas de instantáneas crean una salida base y luego la comparan con los resultados de pruebas posteriores. Esto permite una inspección visual fácil de los cambios y regresiones en el renderizado del Helm chart.

- **Mayor mantenibilidad:** Las pruebas de instantáneas simplifican el proceso de configuración de pruebas, haciéndolo más accesible y mantenible, especialmente cuando se trata de Helm charts complejos. La entrada para el Helm chart es una combinación de valores. Solo necesitamos mantener las combinaciones de entrada asumidas (=values.yaml), y sus instantáneas.

- **Pruebas continuas:** Al tomar instantáneas continuamente del Helm chart en tu proceso de CI, puedes notar rápidamente los cambios en todo tu chart y evitar regresiones.

Estas ventajas no se limitan al Helm chart que creaste, sino también a los charts de terceros que has instalado en tu Kubernetes si eres un administrador de Kubernetes. Al actualizar un clúster, puedes notar cualquier cambio en los manifiestos de salida producidos por tus *values*, sin importar cuán pequeño sea.

### Motivación

Existen herramientas de prueba para Helm que soportan pruebas de instantáneas.
- [helm-unittest](https://github.com/helm-unittest/helm-unittest), una herramienta de pruebas unitarias popular, tiene una opción para [pruebas de instantáneas](https://github.com/helm-unittest/helm-unittest#snapshot-testing).
- [terratest](https://terratest.gruntwork.io/), pruebas automatizadas para tu código de infraestructura. Permite escribir pruebas en Go y tiene la funcionalidad de probar la salida de Helm. [blog post](https://blog.gruntwork.io/automated-testing-for-kubernetes-and-helm-charts-using-terratest-a4ddc4e67344)

> La herramienta oficial de pruebas de Helm [`ct`](https://github.com/helm/chart-testing) no es para pruebas unitarias o de instantáneas, sino para lint y pruebas de integración.

Aunque son herramientas valiosas para probar Helm charts, tienen ciertas limitaciones para las pruebas de instantáneas.

- Debes aprender y preparar los archivos de Test Suite de las herramientas incluso si solo es para pruebas de instantáneas.

- No hacen instantáneas de todo el chart por defecto, sino que están diseñadas para probar por archivo dentro del Helm chart.

- Las salidas dinámicas de las funciones de Helm no son consideradas.

helm-unittest está diseñado para realizar pruebas por archivo dentro del Helm chart. Esto significa que evalúa cada archivo de manera independiente, y cuando los valores o condiciones del Helm chart provocan que un archivo completo sea incluido o excluido condicionalmente, puede resultar en que las pruebas no cubran escenarios importantes.

Aquí un ejemplo de un archivo de especificación de prueba para pruebas de instantáneas en helm-unittest.

> https://github.com/helm-unittest/helm-unittest#snapshot-testing
> 
> ```yaml
> templates:
>   - templates/deployment.yaml
> tests:
>   - it: pod spec should match snapshot
>     asserts:
>       - matchSnapshot:
>           path: spec.template.spec
>   # o puedes hacer instantánea de todo el manifiesto
>   - it: manifest should match snapshot
>     asserts:
>       - matchSnapshot: {}
> ```

Por ejemplo, considera un escenario donde el Helm chart puede crear un recurso `Certificate` de `cert-manager` cuando tanto TLS como cert-manager están habilitados, pero crea un recurso `Secret` TLS autofirmado usando la función de helm [`genSelfSignedCert`](https://helm.sh/docs/chart_template_guide/function_list/#genselfsignedcert) cuando cert-manager no está habilitado. Además, el hecho de que TLS esté habilitado o no afecta las propiedades TLS de Ingress, las opciones específicas de TLS de la aplicación en Deployment, etc.

En estos casos, helm-unittest puede no ser capaz de probar adecuadamente el comportamiento completo del chart, ya que la salida de estos archivos condicionales puede estar vacía, lo que lleva a pruebas incompletas.

Sin embargo, todo lo que tienes que hacer con `helm-chartsnap` es simplemente preparar algunos archivos `values.yaml` con los patrones que esperas 😊

## Instalación 🚀

Puedes instalarlo como un plugin de Helm.

```sh
helm plugin install https://github.com/jlandowner/helm-chartsnap
```

Otras opciones:

- Instalación con Go

  ```sh
  go install github.com/jlandowner/helm-chartsnap@latest
  ```

- [Descargar binario de la release](https://github.com/jlandowner/helm-chartsnap/releases)

## Uso

Simplemente pasa tu chart para un inicio rápido.

```
helm chartsnap -c TU_CHART
```

El directorio `__snapshot__` se crea en el directorio del chart y se crea `default.snap`.

Además, puedes crear casos de prueba como una variación de los archivos Values de tu chart.

Aquí está el uso completo del comando.

```sh
Uso:
  chartsnap -c CHART [flags]

Ejemplos:

  # Instantánea con valores por defecto:
  chartsnap -c TU_CHART
  
  # Actualizar archivos de instantáneas:
  chartsnap -c TU_CHART -u

  # Instantánea con valores de caso de prueba:
  chartsnap -c TU_CHART -f TU_ARCHIVO_DE_VALORES_DE_PRUEBA
  
  # Instantánea de todos los casos de prueba:
  chartsnap -c TU_CHART -f TU_DIRECTORIO_DE_VALORES_DE_PRUEBA
  
  # Establecer argumentos o flags adicionales para el comando 'helm template':
  chartsnap -c TU_CHART -f TU_ARCHIVO_DE_VALORES_DE_PRUEBA -- --skip-tests

  # Instantánea de un chart remoto en el repositorio de Helm:
  chartsnap -c NOMBRE_DEL_CHART -f TU_ARCHIVO_DE_VALORES -- --repo URL_DEL_REPO_HELM

  # Instantánea de ingress-nginx (https://kubernetes.github.io/ingress-nginx/) chart de Helm para una versión específica con tu archivo de valores:
  chartsnap -c ingress-nginx -f TU_ARCHIVO_DE_VALORES -- --repo https://kubernetes.github.io/ingress-nginx --namespace kube-system --version 4.8.3

  # Instantánea de cilium (https://cilium.io) chart de Helm con valores por defecto y establecer flags:
  chartsnap -c cilium -- --repo https://helm.cilium.io --namespace kube-system --set hubble.relay.enabled=true --set hubble.ui.enabled=true

  # Instantánea de charts en el registro OCI
  chartsnap -c oci://ghcr.io/nginxinc/charts/nginx-gateway-fabric -n nginx-gateway

  # Salida sin colores:
  NO_COLOR=1 chartsnap -c TU_CHART

Flags:
  -c, --chart string              ruta al directorio del chart. Este flag se pasa a 'helm template RELEASE_NAME CHART --values VALUES' como 'CHART'
      --config-file string        nombre o ruta del archivo de configuración, que define el comportamiento de las instantáneas, por ejemplo, campos dinámicos (por defecto ".chartsnap.yaml")
  -N, --ctx-lines int             número de líneas a mostrar en la salida diff. 0 para salida completa (por defecto 3)
      --debug                     modo debug
      --fail-helm-error           falla si el comando 'helm template' falla
      --failfast                  falla en cuanto falle cualquier caso de prueba
  -h, --help                      ayuda para chartsnap
  -n, --namespace string          namespace. Este flag se pasa a 'helm template RELEASE_NAME CHART --values VALUES --namespace NAMESPACE' como 'NAMESPACE' (por defecto "default")
  -o, --output-dir string         directorio donde se crea el directorio __snapshot__. (por defecto: directorio del archivo de valores si se establece --values; directorio del chart si el chart es local; si no, el directorio actual)
      --parallelism int           concurrencia de pruebas si se toman múltiples instantáneas para un directorio de archivos de valores de prueba. el valor por defecto es ilimitado (por defecto -1)
      --release-name string       nombre del release. Este flag se pasa a 'helm template RELEASE_NAME CHART --values VALUES' como 'RELEASE_NAME' (por defecto "chartsnap")
      --snapshot-version string   usa una versión específica del formato de instantánea. Se soportan v1, v2, v3. (por defecto: última)
  -u, --update-snapshot           modo de actualización de instantáneas
  -f, --values string             ruta a un archivo de valores de prueba o directorio. Si se establece un directorio, se prueban todos los archivos de prueba. Si está vacío, se usan los valores por defecto. Este flag se pasa a 'helm template RELEASE_NAME CHART --values VALUES' como 'VALUES'
  -v, --version                   versión de chartsnap

```

### Manejo de valores dinámicos 💪

Helm tiene una característica llamada "Funciones de Helm" que genera valores aleatorios o certificados autofirmados como [`randAlphaNum`](https://helm.sh/docs/chart_template_guide/function_list/#randalphanum-randalpha-randnumeric-and-randascii) y [`genCA`, `genPrivateKey`, `genSelfSignedCert`](https://helm.sh/docs/chart_template_guide/function_list/#cryptographic-and-security-functions)

Al usar estas funciones, la salida variará cada vez que se ejecute Helm.
Para este caso, chartsnap tiene una característica que previene instantáneas desajustadas sustituyéndolas por un valor fijo, `###DYNAMIC_FIELD###`.

Puedes especificar las rutas de los valores dinámicos en el YAML generado usando [JSONPath](https://datatracker.ietf.org/doc/html/rfc6901).

```yaml:.chartsnap.yaml
dynamicFields:
  - apiVersion: v1
    kind: Secret
    name: cosmo-auth-env
    jsonPath:
      - /data/COOKIE_HASHKEY
      - /data/COOKIE_BLOCKKEY
      - /data/COOKIE_HASHKEY
      - /data/COOKIE_SESSION_NAME
    base64: true
```

> NOTA:
> En JSONPath, el carácter / debe escaparse, como se documenta en [RFC6901, sección 3](https://datatracker.ietf.org/doc/html/rfc6901#section-3)
> ```
>    Debido a que los caracteres '~' (%x7E) y '/' (%x2F) tienen significados
>    especiales en JSON Pointer, '~' debe codificarse como '~0' y '/'
>    debe codificarse como '~1' cuando estos caracteres aparecen en un
>    token de referencia.
> ```
>
> Así que si manejas un manifiesto como el siguiente, debes especificar la ruta json como `/metadata/annotaions/checksum~1values`.
> 
> ```yaml
> metadata:
>   annotations:
>     checksum/values: RANDOM_VALUES
> ```

Si tienes un directorio de archivos de valores de prueba, colócalo como un archivo `.chartsnap.yaml` dentro de ese directorio. Es un comportamiento común en todas las pruebas de instantáneas del directorio.

Para más ejemplos, consulta [example/app1](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/app1).

Alternativamente, puedes agregar la configuración directamente en el archivo de valores de prueba como una propiedad `testSpec`.
En este caso, no necesitas preparar `.chartsnap.yaml`. Es para tomar instantáneas de charts remotos o de terceros con tu único archivo de valores.

Tu archivo de valores puede ser así:

```yaml
# Añade esta propiedad a tus valores.
testSpec:
  dynamicFields:
    - apiVersion: v1
      kind: Secret
      name: cilium-ca
      jsonPath:
        - /data/ca.crt
        - /data/ca.key
      base64: true
    - apiVersion: v1
      kind: Secret
      name: hubble-server-certs
      jsonPath:
        - /data/ca.crt
        - /data/tls.crt
        - /data/tls.key
      base64: true
    - apiVersion: v1
      kind: Secret
      name: hubble-relay-client-certs
      jsonPath:
        - /data/ca.crt
        - /data/tls.crt
        - /data/tls.key
      base64: true

# Otros pueden ser cualquier valor de tu chart.
# ...
```

Para más ejemplos, consulta [example/remote](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/remote).

## Ejemplos y Usuarios ✨

| Usuarios / Proyectos | Descripción | URL |
|:---|:---|:---|
| Ejemplo | Chart de ejemplo generado por el comando `helm create` | [`example/app1`](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/app1) |
| Ejemplo | Ejemplo de instantáneas de charts en repositorios remotos de Helm | [`example/remote`](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/remote) |
| [helm-chartsnap-action](https://github.com/jlandowner/helm-chartsnap-action) | Acción de GitHub para usar helm chartsnap en CI | https://github.com/jlandowner/helm-chartsnap-action |
| [cosmo-workspace](https://github.com/cosmo-workspace/cosmo) | Plataforma WebIDE & DevEnvironment open source sobre Kubernetes | https://github.com/cosmo-workspace/cosmo/tree/main/charts/cosmo/test |
| [Kong](https://github.com/Kong/kong) | 🦍 The Cloud-Native API Gateway and AI Gateway. | https://github.com/Kong/charts |

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---