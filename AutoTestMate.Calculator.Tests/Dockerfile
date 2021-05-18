FROM registry.access.redhat.com/ubi8/dotnet-50 AS build-env
WORKDIR /app

# this is hack to make the app working in a container. We also did an attempt to build it inside ubi8/dotnet-50 and it did not work.
COPY bin/Debug/net5.0/ .


USER root

RUN useradd -ms /bin/bash test

RUN mkdir -p /etc/selenoid/TestResults

RUN chown -R test:test /etc/selenoid/TestResults

RUN chmod 755 /etc/selenoid/TestResults

 

USER test

#WORKDIR $HOME/calc-tests

#COPY ./Calculator.Tests .

 
# dotnet test **/bin/Debug/net5.0/ref/AutoTestMate.Calculator.Tests.dll  --Settings:Ubuntu.runsettings
#CMD dotnet vstest Calculator.Tests.dll --Settings:Test.runsettings --logger:trx --logger:ReportPortal
CMD dotnet test **/bin/Debug/net5.0/ref/AutoTestMate.Calculator.Tests.dll  --Settings:testsettings.runsettings

