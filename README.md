### POC API Serilog .NET Core 8

## Descrição
Este projeto é uma Minimal API em .NET Core 8, focado em operações CRUD de produtos com SQL Server, integrando Serilog para logging eficiente. Tudo rodando em contêineres Docker para facilitar a implantação e escalabilidade.

## Tecnologias Utilizadas
- .NET Core 8
- SQL Server
- MongoDB
- Docker
- Docker Compose

## Pré-requisitos
É necessário ter instalado em sua máquina:
- .NET Core 8 SDK
- Docker
- SQL Server
- MongoDb
- Docker Compose

## Configuração e Instalação

### Clonando o Repositório
Clone o repositório usando: https://github.com/gfmaurila/poc.api.serilog.net8

### Configurando o Docker e Docker Compose
docker-compose up --build
http://localhost:5071/swagger/index.html

### SQL Server
- Add-Migration Inicial -Context SqlServerDb
- Update-Database -Context SqlServerDb

## Youtube
https://www.youtube.com/watch?v=v-_yNDviInQ

## Autor

- Guilherme Figueiras Maurila

## 📫 Como me encontrar
- [![YouTube](https://img.shields.io/badge/YouTube-FF0000?style=for-the-badge&logo=youtube&logoColor=white)](https://www.youtube.com/channel/UCjy19AugQHIhyE0Nv558jcQ)
- [![Linkedin Badge](https://img.shields.io/badge/-Guilherme_Figueiras_Maurila-blue?style=flat-square&logo=Linkedin&logoColor=white&link=https://www.linkedin.com/in/guilherme-maurila)](https://www.linkedin.com/in/guilherme-maurila)
- [![Gmail Badge](https://img.shields.io/badge/-gfmaurila@gmail.com-c14438?style=flat-square&logo=Gmail&logoColor=white&link=mailto:gfmaurila@gmail.com)](mailto:gfmaurila@gmail.com)
- 📧 Email: gfmaurila@gmail.com
