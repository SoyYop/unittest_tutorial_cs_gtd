# Tutorial de .net con pruebas unitarias

Puedes usar vs.code o Visual Studio para la ejecución. Recuerda usar la consola de pruebas unitarias de tu editor.

Notas

Si quieres crear un proyecto como este desde cero, puedes usar:

```
 dotnet new sln -n urbaneats
 dotnet new console -n urbaneats
 dotnet new xunit -n urbaneats.tests

 dotnet sln add .\urbaneats.tests\urbaneats.tests.csproj
 dotnet sln add .\urbaneats\urbaneats.csproj
```