# MauiApp1 – Proyecto .NET MAUI (Grupo 6)

Este proyecto es una aplicación básica desarrollada en **.NET MAUI** para la materia **ISWZ2103 – Programación IV** de la Universidad.

La aplicación muestra un mensaje de bienvenida y un botón interactivo.  
Cada vez que el usuario presiona el botón:

- Se incrementa un contador.
- Se actualiza el texto que muestra cuántas veces se ha presionado.
- Se despliega un mensaje emergente (`DisplayAlert`) confirmando la acción.

---

## Funcionalidad principal

Pantalla única (`MainPage`):

- **Label 1:**  
  Texto fijo: `Bienvenido a nuestra app .NET MAUI`.

- **Label 2 (CounterLabel):**  
  Muestra el mensaje:  
  `Has presionado el botón 0 veces.`  
  y se actualiza en cada clic.

- **Button:**  
  Texto: `Presionar`.

  Al hacer clic:
  - Incrementa el contador.
  - Cambia el texto del Label a:  
    `Has presionado el botón X veces.`
  - Muestra un `DisplayAlert` con el título **"Evento activado"** y el mensaje **"¡Has presionado el botón!"**.

---

## Layout utilizado

Se utilizó un **StackLayout** en `MainPage.xaml` para organizar los elementos de forma vertical:

- Mensaje de bienvenida  
- Texto del contador  
- Botón de acción  

Este layout permite una estructura clara y minimalista, ideal para una aplicación de ejemplo multiplataforma.

---

## Tecnologías empleadas

- **.NET MAUI**
- **C#**
- **XAML**
- Plataforma de pruebas: **Windows**

---

## Uso de IA (Prompt Generator)

Para generar la base del código se utilizó **ChatGPT** como herramienta de *Prompt Generator*.  
El prompt utilizado fue el siguiente:

> Genera el código de un proyecto básico en .NET MAUI en C#.  
> La aplicación debe llamarse **MauiApp1** y debe incluir lo siguiente:
> - Una página principal llamada `MainPage` usando `StackLayout`.
> - Un `Label` que muestre el texto: "Bienvenido a nuestra app .NET MAUI".
> - Un `Label` adicional que muestre un contador de clics con el texto inicial: "Has presionado el botón 0 veces.".
> - Un `Button` con el texto "Presionar".
> - Cuando se presione el botón:
>   - Incrementar el contador.
>   - Actualizar el texto del contador a: "Has presionado el botón X veces."
>   - Mostrar un `DisplayAlert` con un mensaje simple.
> Indica también dónde se ubican los archivos `MainPage.xaml` y `MainPage.xaml.cs` en la estructura estándar de un proyecto .NET MAUI y cómo se conecta el evento `Clicked` del botón con el método en C#.

---

## Estructura del proyecto

- `MainPage.xaml`  
  Define la interfaz gráfica usando `StackLayout`, dos Labels y un Button.

- `MainPage.xaml.cs`  
  Contiene la lógica del contador y el manejo del evento `OnButtonClicked`.

---

## Integrantes – Grupo 6

Anthony Guaygua
Kevin Román
Alexander Vinueza

Cada integrante participó mediante commits en este repositorio para evidenciar su aporte.

---
