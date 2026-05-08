# Action Hero

## What is Action Hero?

Action Hero is a sidecar style utility to assist with creating least privilege IAM Policies for AWS.

## Why is it needed?

Commonly developers begin creating infrastructure as code with more permissive roles that have administrative access to rapidly iterate. However, trying to create a more finely scoped set of permissions can be painful and time consuming.

Action Hero provides a means to capture all required permissions during the more permissive iterations to make it easier to create an IAM role with just the required permissions.

## How does it work?

Action Hero uses a feature of the AWS SDK known as Client Side Monitoring. This feature sends AWS API calls to a local udp port (31000 by default)

Summit Route discusses the feature in this [post](https://summitroute.com/blog/2020/05/25/client_side_monitoring/) (which was the inspiration for this tool)

## Prerequisites

As discussed in the above post ``export AWS_CSM_ENABLED=true`` must be run in the shell or set in a profile where the tool using the SDK will be run. For example if you're using terraform it would need to be exported in the shell that the plan/apply would be run from

The environment variable ``AWS_CSM_PORT`` can also be used to override the port CSM actions are sent to, and what port Action Hero listens on. This would need to be exported in both shells if used.

## Installation

Binaries are available from the [releases](https://github.com/princespaghetti/actionhero/releases) page

A docker image is also available from [docker hub](https://hub.docker.com/r/princespaghetti/actionhero)

## Running Action Hero

In a seperate terminal from where you are using the SDK run the binary

``./actionhero``

Alternatively you can use a docker run command

``docker run -e "IN_DOCKER=True" -p 127.0.0.1:31000:31000/udp --rm princespaghetti/actionhero:latest``

Ctrl+C can be used to terminate the process safely

## Walkthrough

Please see this [blog post](https://dev.to/prince_of_pasta/action-hero-to-the-rescue-creating-least-privilege-aws-iam-policies-53o2) for sample usage of the tool.