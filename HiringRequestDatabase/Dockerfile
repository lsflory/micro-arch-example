FROM mcr.microsoft.com/mssql/server:2019-latest

USER root

# Create non-root user and update permissions
#
RUN mkdir -p -m 770 /var/opt/mssql && chgrp -R 0 /var/opt/mssql

# Grant sql the permissions to connect to ports <1024 as a non-root user
#
RUN setcap 'cap_net_bind_service+ep' /opt/mssql/bin/sqlservr

# Allow dumps from the non-root process
# 
RUN setcap 'cap_sys_ptrace+ep' /opt/mssql/bin/paldumper
RUN setcap 'cap_sys_ptrace+ep' /usr/bin/gdb

# Add an ldconfig file because setcap causes the os to remove LD_LIBRARY_PATH
# and other env variables that control dynamic linking
#
RUN mkdir -p /etc/ld.so.conf.d && touch /etc/ld.so.conf.d/mssql.conf
RUN echo -e "# mssql libs\n/opt/mssql/lib" >> /etc/ld.so.conf.d/mssql.conf
RUN ldconfig

# Create db directory
#
RUN mkdir -p /usr/src/db

# Bundle db source
#
COPY . /usr/src/db

# Grant permissions for the import-data script to be executable
#
RUN chmod +x /usr/src/db/setup-db.sh

# Ensure using 'mssql' user and run the entrypoint script
#
USER mssql
ENTRYPOINT /bin/bash /usr/src/db/entrypoint.sh