## Verificar a instalação do .NET SDK: 
Abra um terminal e digite o seguinte comando:
dotnet --version

Este comando retornará a versão do .NET SDK atualmente em uso.

## Listar todas as versões do .NET SDK instaladas: 
dotnet --list-sdks


## Remover uma versão específica do .NET SDK: 
Para remover uma versão específica do .NET SDK no Linux, pode usar o comando sudo apt-get remove dotnet-sdk-<version>, onde <version> é a versão que você deseja remover.

Atualizar o .NET SDK: Para atualizar o .NET SDK, é preciso baixar e instalar a versão mais recente do .NET SDK a partir do site oficial da Microsoft.

Antes de instalar o novo pacote, é uma boa prática atualizar a lista de pacotes do seu gerenciador de pacotes. No Ubuntu, você pode fazer isso com o seguinte comando:

sudo apt-get update

## Instale o .NET SDK: 
sudo apt-get install -y dotnet-sdk-7.0


## Verifique a instalação: 
dotnet --version

Este comando retornará a versão do .NET SDK atualmente em uso


