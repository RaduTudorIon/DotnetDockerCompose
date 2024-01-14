# Dotnet Containers

This project is using Docker Compose to define and manage a multi-container application. Docker Compose is a tool that allows you to define and run multi-container Docker applications using a YAML file.
In this specific project, the docker-compose.yml file is defining two services: demo-containers and app_db.
The demo-containers service is using an image called democontainers from the Docker Hub registry. It depends on the app_db service, which is using the postgres:latest image. The demo-containers service is exposing port 8088 on the host machine and mapping it to port 80 inside the container. It is also specifying a build context and Dockerfile for building the image. Additionally, it sets environment variables for the connection string and ASP.NET Core URLs. Both services are connected to a network called dev.
The app_db service is responsible for running a PostgreSQL database. It sets environment variables for the PostgreSQL user, password, and database name. It exposes port 5433 on the host machine and maps it to port 5432 inside the container. It also specifies a volume for persisting the database data. The service is set to restart always, ensuring that it automatically restarts if it stops unexpectedly.

## Files

### docker-compose.yml

The `docker-compose.yml` file is used to define and configure the services that make up the application. It specifies the version of Docker Compose to use, defines networks, services, and volumes, and sets up the necessary environment variables.

### Dockerfile

The `Dockerfile` is used to build the Docker image for the `demo-containers` service. It specifies the base image, copies the necessary files, and sets up the environment for running the application.

### app_data

The `app_data` volume is used to persist the data for the `app_db` service. It is mounted to the `/var/lib/postgresql/data` directory in the `app_db` container.

## Usage

To run the application, make sure you have Docker and Docker Compose installed. Then, navigate to the project directory and run the following command: docker-compose up 
This will start the services defined in the `docker-compose.yml` file and create the necessary containers.

## License

This project is licensed under the [MIT License](LICENSE).
