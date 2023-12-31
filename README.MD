# Chucho Bot 🤖

## Requerimientos

Para poder ejecutar la aplicación es necesario:

- Windows
- Microsoft .Net Framework 4.7.2
- Acceso a Primary API provisto por ALyC (Matriz)

> Nota: No funciona en iOS, MacOS, Android o Linux.

## ¿Cómo puedo ejecutar la aplicación?

Los releases se encuentran en la sección `Releases`

- Ir a la sección [Releases](https://github.com/ChuchoCoder/chuchobot/releases)
- Descargar el archivo zip (Ejemplo: `ChuchoBot2023-10-06.zip`)
- Descomprimir en una carpeta
- Ejecutar `ChuchoBot.exe`

## ¿Cuál es la Primary API Base URL de mi ALyC?

En la ventana de **Primary Login**, reemplazar la `Primary API Basi URL` por la provista por ALyC. **Ejemplo**: Si tenés **Bull Market Brokers** usa `https://api.bull.xoms.com.ar`

![Login](docs/screenshots/Login.png)

- **Cocos Capital (requiere plan 🥥 Cocos Pro)**: ```https://api.cocos.xoms.com.ar```
- **Eco Valores**: `https://api.eco.xoms.com.ar`
- **Veta Capital**: `https://api.veta.xoms.com.ar`
- **Bull Market Brokers**: `https://api.bull.xoms.com.ar`
- **Cohen**: `https://api.cohen.xoms.com.ar/`
- **Adcap**: `https://api.adcap.xoms.com.ar/`
- **BCCH**: `https://api.bcch.xoms.com.ar/`

### ¿Cúal es mi usuario y contraseña para hacer Login?

El usuario y contraseña a utilizar es el mismo que se utiliza para ingresar en Matriz.

## IMPORTANTE: Configurar Comisión Operación %

La aplicación tiene configurado algunos instrumentos (no todos) que son utilizados para calcular automaticamente los Derechos de Mercado:

- **Acciones y CEDEARs 0,08%** (Instrumentos en setting `AccionesCEDEARs`)
- **Letras 0,001%** (Instrumentos en setting `Letras`)
- **Bonos 0,01%** (resto de instrumentos)

Además de los derechos de mercado, la comisión configurada por cada operación es de 0,10% (por defecto). Este porcentaje puede modificarse en la ventana de Arbitrajes de Plazos

**Derechos de Mercado BYMA**: https://www.byma.com.ar/wp-content/uploads/dlm_uploads/2019/11/BYMA-Derechos-Mercado-sobre-Operaciones-2022-12-01.pdf

## IMPORTANTE: Configurar Comisión Caución Tomadora y Colocadora

La aplicación tiene configurado valores arbitrarios para la comisión que cobra el broker al momento de colocar o tomar caución. 

Para obtener un P&L correcto, es necesario configurar estos valores en los campos `Comisión Tomadora (TNA)` y `Comisión Colocadora (TNA)`.

## Telemetría

Para deshabilitar la telemetría de la aplicación:

1. Editar el archivo de configuración `ChuchoBot.exe.config`
2. Eliminar sección de `<connectionStrings>...</connectionStrings>``

```xml
  <connectionStrings>
    <add name="Primary.WinFormsApp.Properties.Settings.AppInsightsConnectionString"
      connectionString="..." />
  </connectionStrings>
```

## ¿Cómo agregar/eliminar instrumentos a monitorear?

1. Ir a `Configuración` => `Instrumentos a monitorear`

    ![Configuracion](docs/screenshots/Configuracion.png)

2. Agregar o quitar instrumentos a la lista (1 instrumento por linea). **Ejemplo**: Agregar `GGAL` para monitorear la acción de Galicia.

    ![Instrumentos a Monitorear](docs/screenshots/InstrumentosMonitorear.png)

## ¿Puedo utilizar la aplicación si no tengo acceso a Matriz?

No, la aplicación necesita tener acceso a Primary API (Matriz).

## Scanner de arbitraje de plazos

El scanner de arbitraje de plazos permite detectar oportunidades para arbitrar plazos de distintos activos.

Opciones:

- **Ver sólo arbitrajes de según instrumentos en cartera**: Muestra sólo los arbitrajes que son posibles evaluando los instrumentos que se tienen en cartera.
- **Ver sólo arbitrajes con profit**: Muestra sólo los arbitrajes donde la ganancia (columna P&L) sea positiva

![Scanner de arbitraje de plazos](docs/screenshots/ArbitrajePlazos.png)

Haciendo doble clic en cualquier de las filas de la grilla se accede una ventana con el detalle del arbitraje. En dicha ventana se pueden cambiar los nominales, precios de compra/venta y comisión para poder obtener un cálculo aproximado de la ganancia/pérdida que se obtendría.

![Scanner de arbitraje de plazos detalle](docs/screenshots/ArbitrajePlazoDetail.png)

### Operatoria cuando el plazo de la Venta es menor al de Compra (requiere títulos en cartera)

Cuando el plazo de la `1 Venta` es menor al de `2 Compra` es necesario contar con los títulos en cartera (Ejemplo: `1 Venta NVDA - CI` / `2 Compra NVDA - 48hs`).

La operación consiste en realizar las siguientes operaciones:

1. **Vender** el título en el plazo visualizado `CI` o `24hs`
2. **Comprar** el título en el plazo visualizado `24hs` o `48hs`
3. **Colocar** en caución el resultado de la venta del paso **1**
   - Nota APB 🤦‍♂️: Si la venta del paso 1 se realizó en `24hs` se coloca el dinero en caución al siguiente día

### Operatoria cuando el plazo de la Venta es mayor al de Compra

Cuando el plazo de la `1 Venta` es mayor al de `2 Compra` será necesario contar con el dinero o poder tomar caución para cubrir el descubierto de lo comprado (Ejemplo: `1 Venta SPY - 48hs` / `2 Compra SPY - CI`).

La operación consiste en realizar las siguientes operaciones:

1. **Comprar** el título en el plazo visualizado `CI` o `24hs`
2. **Vender** el título en el plazo visualizado `24hs` o `48hs`
3. **Tomar** caución por el total de la compra del paso **1**
   - Nota APB 🤦‍♂️: Si la compra del paso 1 se realizó en `24hs` se deberá tomar el dinero en caución al siguiente día

### Abrir arbitraje de plazos para un instrumento

Es posible abrir la ventana de arbitraje de plazos para un instrumento y plazos de liquidación específicos:

![Abrir arbitraje de plazos para un instrumento](docs/screenshots/ArbitrajePlazosLauncher.png)

## Scanner para comprar/vender dolar MEP y CCL

La aplicación permite visualizar en tiempo real en que instrumentos conviene comprar y vender dolar MEP y CCL.

### Dolar MEP

![Scanner de Dolar MEP](docs/screenshots/DolarMEP.png)

### Dolar CCL

![Scanner de Dolar CCL](docs/screenshots/DolarCCL.png)

## ¿Por qué aparece el icono de WiFi rojo y el texto "DISCONNECTED"?

Cuando la aplicación deja de recibir datos por WebSocket, el icono de WiFi pasa de verde a rojo para avisar que puede existir algún problema con la conexión. Esto también ocurre antes de la apertura y luego de la finalización de la rueda.

![Disconnected](docs/screenshots/Disconnected.png)

Si esto ocurre mientras el mercado está abierto, se recomienda cerrar la apliación y volver a ejecutarla.

## ¿La aplicación recibe datos en tiempo real?

Sí, la aplicación se conecta por WebSocket a Primary API y la misma recibe los datos de los instrumentos en tiempo real.

## ¿La aplicación envía alguna orden de compra o venta?

No, la aplicación no emite o envía ninguna orden de compra y venta al mercado. Solamente permite visualizar las oportunidades de arbitraje que existen en tiempo real.
