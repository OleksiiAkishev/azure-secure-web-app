Secure Azure Web App with Managed Identity and DevSecOps pipeline
1. Learned about docker layers. That specific commands [COPY, RUN, CMD] creates new layers during execution.
2. Learned how to properly use relative and absolute paths in respect to Dockerfile
3. It is better to pointing to the csproj files instead of the Solution sln.4. During build stage better use publish instead of build for the Production env, as omits to create redndant files, usful for local development only.
5. Learned about wsl:
    a. how to install
    b. how to use VS code by reffering it from wsl. note: not forget to install VS code extension to that.
    c. where service/regular users are stored in linux [/etc/passwd/]
    d. where groups are stored in linux [/etc/group/]
    e. where normally local dev certificates are stored for net code apps [.aspnet/]

6. How to generate local dev certificates with the dotnet command with a private key
7. Learned which parameter in dot net is responsible for ports mapping [ASPNETCORE_URLS]
8. Learned how to efficiently use commands for Dockerfile to not create redundant layers and whereever is possible to merge logically commands in one integrity.
9. Learned about runtime net core layer in Dockerfile. 
10. Learned how to build docker compose, why it is needed(instead of using huge run commands with argumets when run a dockerfile) and where to put it (root of the project).
11. Learned on volumes mappings: [source path on wsl] : [destination path in container] : [permissions]
12. Removed old docker.io packages and old docker compose, after installed a new Compose v2 and buildx, + added official docker repo
Learned how to use vim editor in 3 basic modes [visual, insert, normal]





