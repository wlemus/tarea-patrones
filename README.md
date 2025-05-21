# Solución de Patrones de Diseño - Diplomado de Arquitectura de Software Universidad de la Sabana

---

## Grupo No. 5

## Problema 1: Personalización de Automóviles

### Escenario
Imagina que estás desarrollando una aplicación para una compañía automotriz que permite a los clientes personalizar y ordenar un automóvil. Un objeto Automóvil puede tener muchas configuraciones opcionales: tipo de motor, color, llantas, sistema de sonido, interiores, techo solar, navegación GPS, etc.

### Problema
Crear un objeto Automóvil con múltiples configuraciones puede llevar a constructores con muchos parámetros (el infame "constructor telescópico") o a múltiples constructores sobrecargados, lo que dificulta el mantenimiento y legibilidad del código.

### Beneficios esperados de la solución:
- Legibilidad y claridad: Facilitar la creación de objetos complejos con muchos parámetros sin necesidad de múltiples constructores o valores por defecto.  
- Inmutabilidad: Una vez creado el objeto, sus propiedades no se pueden modificar si el constructor lo define como inmutable.  
- Flexibilidad: Poder omitir atributos opcionales sin necesidad de crear subclases o múltiples constructores.  
- Separación de construcción y representación: Separar la lógica de construcción del objeto en sí, facilitando modificaciones futuras.

---

### Solución

#### Tipo de patrón
Creacional

#### Patrón aplicado
Builder

#### Diagrama de clases (PlantUML)
![Diagrama de clases](documentacion/1_Diagrama.png)
```plantuml
  @startuml

interface Builder {
    +Reiniciar()
    +SetTipoMotor(AutoTiporMotor)
    +SetTransmision(AutoTransmision)
    +SetColor(String)
    +SetLlantas(int)
    +SetSistemaSonido(String)
    +SetInteriores(String[])
    +SetTechoSolar(bool)
    +SetGPS(bool)
}

class AutomovilBuilder {
  -auto: Automovil
    +Reiniciar()
    +SetTipoMotor(AutoTiporMotor)
    +SetTransmision(AutoTransmision)
    +SetColor(String)
    +SetLlantas(int)
    +SetSistemaSonido(String)
    +SetInteriores(String[])
    +SetTechoSolar(bool)
    +SetGPS(bool)
    +GetAutomovil():Auto
}

enum AutoTransmision {
    automatico
    mecanico
}

enum AutoTiporMotor {
    GASOLINA
    DIESEL
    GAS
    HIBRIDO
    ELECRICO
}

class Automovil {
    +tipoMotor: AutoTiporMotor
    +tipoTransmision: AutoTransmision
    +color: String
    +llantas:int
    +sistemaSonido: String
    +interiores: String[]
    +techoSolar:bool
    +sistemaGPS:bool
}

class Director {
    +ConstruirAutoFamiliar(AutoBuilder)
    +ConstruirAutoDeportivo(AutoBuilder)
    +ConstruirAutoCompacto(AutoBuilder)
}

AutomovilBuilder ..|> Builder
AutomovilBuilder --> Automovil
Director --> AutomovilBuilder

@enduml
```
## Problema 2: Notificaciones Multiplataforma

### Escenario
Estás desarrollando una aplicación que gestiona la visualización de notificaciones en diferentes plataformas (por ejemplo: escritorio, móvil, web). Las notificaciones pueden ser de distintos tipos (mensaje, alerta, advertencia, confirmación) y cada tipo puede mostrarse de distintas formas según la plataforma.

### Problema
Si usas herencia tradicional, tendrías que crear clases como:  
- NotificacionMensajeWeb  
- NotificacionAlertaWeb  
- NotificacionMensajeMovil  
- NotificacionAlertaMovil  
Esto lleva rápidamente a una explosión combinatoria de subclases difíciles de mantener.

### Beneficios esperados de la solución:
- Separación de responsabilidades: Separar la lógica de la notificación del medio por el que se presenta.  
- Escalabilidad: Poder agregar nuevas plataformas o tipos de notificación sin modificar el resto del sistema.  
- Reducción de clases: Evitar la multiplicación de clases para cada combinación.  
- Flexibilidad en tiempo de ejecución: Poder cambiar la plataforma dinámicamente si es necesario.

---

### Solución

#### Tipo de patrón
Estructural

#### Patrón aplicado
Bridge

#### Diagrama de clases (PlantUML)

![Diagrama de clases](documentacion/2_Diagrama.png)
```plantuml
@startuml

title Bridge Class Diagram

interface INotificationSender{
  +void Send(string message)
}
abstract Notification{
  -INotificationSender
  +Notify(string message)
}

class WebSender
class SMSSender{
-List:string _telephoneCompanies
+SetCompanies(List:string telephoneCompanies)
}

class MessageNotification {
 +void saveDB(string message)
}
class AlertNotification 
class WarningNotification 

Notification *-- INotificationSender

WebSender ..> INotificationSender
SMSSender ..> INotificationSender 
Notification <|-- MessageNotification
Notification <|-- AlertNotification
Notification <|-- WarningNotification

@enduml
```

## Problema 3: Gestión de Mensajes en Chat Grupal

### Escenario
Estás desarrollando una aplicación de chat grupal. Los usuarios pueden enviarse mensajes entre sí dentro de una sala de chat. Sin embargo, gestionar las interacciones directas entre cada usuario haría que cada uno deba conocer y comunicarse con todos los demás, lo que resulta en una alta dependencia entre objetos.

### Problema
Sin un mediador, cada usuario tendría que mantener referencias directas a todos los demás, lo que genera un sistema difícil de escalar y mantener. Si agregas o eliminas usuarios, debes actualizar muchas relaciones.

### Beneficios esperados de la solución:
1. Facilita el mantenimiento: Agregar o eliminar usuarios no debe requerir modificar los demás.  
2. Mejor organización: La lógica de comunicación debe estar centralizada, no dispersa en muchos objetos.  
3. Reduce la complejidad: Evitar una red enmarañada de interacciones punto a punto.

---

### Solución

#### Mediator Pattern - Chat Grupal

Este proyecto demuestra la implementación del patrón de diseño **Mediator** en una aplicación de consola en C#. 
Permite gestionar la comunicación entre usuarios sin acoplamientos directos.

##### Objetivo

Desacoplar la comunicación entre múltiples usuarios dentro de una sala de chat, 
centralizando la lógica de interacción a través de un objeto mediador (`SalaChat`).

#### Tipo de patrón
Comportamiento

#### Patrón aplicado
Mediator


### Diagrama de clases (PlantUML)

![Diagrama de clases](documentacion/3_Diagrama.png)
```plantuml
@startuml
skinparam classAttributeIconSize 0

' Interfaces
interface IMediador {
    +Enviar(mensaje: string, emisor: Usuario)
    +Registrar(usuario: Usuario)
}

' Entidades principales
class Usuario {
    -nombre: string
    -sala: IMediador
    +Enviar(mensaje: string)
    +Recibir(mensaje: string, emisor: string)
    +SetSala(sala: IMediador)
}

class SalaChat {
    -usuarios: List<Usuario>
    +Registrar(usuario: Usuario)
    +Enviar(mensaje: string, emisor: Usuario)
}

' Clase de aplicación
class ChatService {
    +EjecutarChat()
}

' Relaciones
Usuario --> IMediador : usa
IMediador <|.. SalaChat : implementa
SalaChat --> Usuario : registra
ChatService --> SalaChat : instancia
ChatService --> Usuario : instancia

' Notas explicativas
note right of Usuario
  Cada usuario conoce solo al mediador
end note

note bottom of SalaChat
  La sala centraliza la comunicación
end note

note right of ChatService
  Orquesta el chat y registra usuarios
end note

@enduml

```
## 📂 Estructura del Código

```
patrones.back/
│── patrones.back.Application/       # Lógica de aplicación (ChatService, flujo principal)
│── patrones.back.Entities/           # Entidades del dominio (Usuario)
│── patrones.back.Interfaces/    # Contratos del mediador (IMediador)
│── patrones.back.Mediator/             # Implementación concreta del mediador (SalaChat)

patrones.test/
│── patrones.test/Program       # Punto de entrada de la aplicación
```
- `Program.cs`: ejecuta el método `EjecutarChat()` desde `ChatService` para simular la conversación.


## 📦 Resultado esperado

Cuando un usuario envía un mensaje, todos los demás lo reciben mediante la clase `SalaChat`.

## ▶️ Cómo ejecutar

1. Clona el repositorio
2. Abre el proyecto en Visual Studio / VS Code
3. Compila y ejecuta el proyecto desde `Program.cs`


